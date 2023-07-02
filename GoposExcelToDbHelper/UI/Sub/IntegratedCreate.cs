using GoposExcelToDbHelper.Properties;
using GoposExcelToDbHelper.UI.Popup;
using GoposExcelToDbHelper.Utils;
using GoposExcelToDbHelper.VO;
using MemoHelper.Util;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace GoposExcelToDbHelper
{
    public partial class IntegratedCreate : MetroFramework.Forms.MetroForm
    {
        private const string springBootPath = @"\src\main\java\gopos\";
        private const string springBootMapperPath = @"\src\main\resources\mapper\";
        private const int All = 0;
        private const int Controller = 1;
        private const int Service = 2;
        private const int Dao = 3;
        private const int Mapper = 4;


        private string excelData => tbx_text.Text;
        private string projectPath => tbx_projectPath.Text;
        private string dbEngine => cbx_engine.SelectedItem.ToString();
        private string dbCharset => cbx_charset.SelectedItem.ToString();


        private string[] rows;
        private List<string> pks = new List<string>();
        private List<ForeignKeyInfo> fks = new List<ForeignKeyInfo>();
        private List<string> unqs = new List<string>();
        private List<string> idxs = new List<string>();
        private List<ColumnInfo> cols = new List<ColumnInfo>();
        private string table = string.Empty;

        public IntegratedCreate()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitWindow();
        }

        private void InitWindow()
        {
            // 프로젝트 경로 조회
            tbx_projectPath.Text = Settings.Default.projectPath;

            // 폰트 설정
            tbx_create.Font = new Font(FontFamily.GenericMonospace, tbx_create.Font.Size);
            tbx_erd.Font = new Font(FontFamily.GenericMonospace, tbx_erd.Font.Size);
            tbx_mapper.Font = new Font(FontFamily.GenericMonospace, tbx_mapper.Font.Size);

            // 엔진 add
            cbx_engine.Items.Add("InnoDB");
            //cbx_engine.Items.Add("MyISAM");
            //cbx_engine.Items.Add("ndbcluster");
            cbx_engine.Items.Add("MEMORY");
            //cbx_engine.Items.Add("FEDERATED");
            //cbx_engine.Items.Add("ARCHIVE");
            //cbx_engine.Items.Add("CSV");
            //cbx_engine.Items.Add("BLACKHOLE");
            //cbx_engine.Items.Add("MRG_MyISAM");

            // 캐릭터셋 add
            cbx_charset.Items.Add("utf8mb4");

            // 파일 생성 모드
            cbx_createFileMode.Items.Add("All");
            cbx_createFileMode.Items.Add("Controller");
            cbx_createFileMode.Items.Add("Service");
            cbx_createFileMode.Items.Add("DAO");
            cbx_createFileMode.Items.Add("Mapper");

            cbx_engine.SelectedIndex = 0;
            cbx_charset.SelectedIndex = 0;
            cbx_createFileMode.SelectedIndex = 0;

            if (Settings.Default.isTestConnection)
            {
                cbx_createTable.Checked = Settings.Default.isCreateTable;
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            tbx_result.Text = string.Empty;

            if (!Validation()) return;
            if (!DisassembleExcelData()) return;

            SetCreateQuery();
            SetErd();
            SetVo();
            SetMapper();

            CreateClassFile();
            CreateTable();

            SetResultLog();

            string toastXmlString =
   $@"<toast><visual>
            <binding template='ToastGeneric'>
            <text>{"흐응"}</text>
            <text>{"호오"}</text>
            </binding>
        </visual></toast>";
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(toastXmlString);
            var toastNotification = new ToastNotification(xmlDoc);

            var toastNotifier = ToastNotificationManager.CreateToastNotifier("tets");
            toastNotifier.Show(toastNotification);
        }

        private bool Validation()
        {
            if (excelData.Equals(string.Empty))
            {
                Msg.Info("변환할 텍스트가 입력되지 않았습니다.");
                SetLog("변환할 텍스트가 입력되지 않았습니다.", false);

                tbx_text.Focus();

                return false;
            }

            if (cbx_createFile.Checked && string.IsNullOrEmpty(tbx_projectPath.Text))
            {
                Msg.Info("프로젝트 경로를 입력해주세요.");
                SetLog("프로젝트 경로를 입력해주세요.", false);

                return false;
            }

            if (cbx_createFile.Checked && string.IsNullOrEmpty(tbx_createFilePath.Text))
            {
                Msg.Info("파일을 생성할 패키지명을 입력해주세요.");
                SetLog("파일을 생성할 패키지명을 입력해주세요.", false);

                return false;
            }

            return true;
        }

        private bool DisassembleExcelData()
        {
            pks.Clear();
            fks.Clear();
            unqs.Clear();
            idxs.Clear();
            cols.Clear();
            table = string.Empty;

            //    0         1       2         3         4        5    6    7       8         9       10     11     12    
            // 엔터티명 테이블명 [컬럼명] [속성명] [속성타입] 도메인 설명 [PK] [NOT NULL] [UNIQUE] [INDEX] [FK] [기본값] MIN MAX
            // `컬럼명` 타입 null여부 추가옵션 comment ''
            rows = excelData.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if (rows.First().Split('\t').Length != 13)
            {
                Msg.Info("복사한 엑셀 컬럼수를 확인해주세요.\n\n엔티티명, 테이블명, 컬럼명, 속성명, 속성타입, 도메인, 설명, PK, NOT NULL, UNIQUE, INDEX, FK, 기본값");
                SetLog("복사한 엑셀 컬럼수를 확인해주세요.\n\n엔티티명, 테이블명, 컬럼명, 속성명, 속성타입, 도메인, 설명, PK, NOT NULL, UNIQUE, INDEX, FK, 기본값", false);
                return false;
            }

            foreach (var row in rows)
            {
                // 한글 컬럼열 pass
                if (Array.IndexOf(rows, row) == 0) continue;

                var excelCols = row.Split('\t').ToList();
                if (excelCols.Count <= 0) continue;

                table = excelCols[1].Trim().ToUpper();

                var name = excelCols[2].Trim().ToUpper();
                var comment = excelCols[3].Trim();
                var type = excelCols[4].Trim();
                var isPk = excelCols.Count <= 7 ? false : excelCols[7].Trim().Equals("O");
                var isNotNull = excelCols.Count <= 8 ? false : excelCols[8].Trim().Equals("O");
                var isUnique = excelCols.Count <= 9 ? false : excelCols[9].Trim().Equals("O");
                var isIndex = excelCols.Count <= 10 ? false : excelCols[10].Trim().Equals("O");
                var isFk = excelCols.Count <= 11 ? false : !excelCols[11].Trim().Equals("");
                var defaults = excelCols.Count <= 12 ? "" : excelCols[12].Trim();

                ColumnInfo col = new ColumnInfo()
                {
                    name = name,
                    type = type,
                    isNotNull = isNotNull,
                    isPk = isPk,
                    isFk = isFk,
                    isUnique = isUnique,
                    isIndex = isIndex,
                    comment = comment,
                    defaults = defaults
                };

                // 제약조건 쿼리 리스트에 추가
                if (col.isPk) pks.Add($"`{col.name}`");
                if (col.isFk) fks.Add(new ForeignKeyInfo()
                {
                    table = excelCols[11].Trim(),
                    name = col.name
                });
                if (col.isUnique) unqs.Add($"`{col.name}`");
                if (col.isIndex) idxs.Add($"`{col.name}`");
                
                cols.Add(col);
            }

            return true;
        }

        private void SetCreateQuery()
        {
            var colQuerys = new List<string>();
            foreach (var col in cols)
            {
                // 컬럼 쿼리 리스트에 추가
                var colQuery =
                    $@"`{col.name}` {col.type} {(col.isNotNull ? "NOT NULL" : "")} {(col.defaults.Equals("AUTO_INCREMENT") ? col.defaults : col.defaults.Equals(string.Empty) ? "" : $"DEFAULT {col.defaults}")} COMMENT '{col.comment}'";
                colQuerys.Add(colQuery);
            }

            // 컬럼 쿼리 생성
            var column = string.Join(",\r\n  ", colQuerys);

            // 제약조건 쿼리 생성
            var pk = (pks.Count != 0 ? $", PRIMARY KEY ({string.Join(",", pks)})" : "");
            var fk = string.Empty;
            foreach (var fkTable in fks)
            {
                fk += $", CONSTRAINT `fk_{fkTable.table.ToLower()}_{table.ToLower()}_{fks.IndexOf(fkTable) + 1}` FOREIGN KEY (`{fkTable.name}`) REFERENCES `{fkTable.table}` (`{fkTable.name}`)";

                if (fks.IndexOf(fkTable) != fks.Count - 1)
                {
                    fk += "\r\n";
                }
            }
            var unique = (unqs.Count != 0 ? $", CONSTRAINT {table.ToLower()}_uk UNIQUE ({string.Join(",", unqs)})" : string.Empty);
            var index = (idxs.Count != 0 ? $", INDEX {table.ToLower()}_idx ({string.Join(",", idxs)})" : string.Empty);

            // 쿼리 통합
            var query = string.Empty;
            query += $"CREATE TABLE `{table}` (";
            query += $"\r\n  {column}";
            query += $"\r\n  {pk}";
            query += string.IsNullOrEmpty(fk) ? string.Empty : $"\r\n  {fk}";
            query += string.IsNullOrEmpty(unique) ? string.Empty : $"\r\n  {unique}";
            query += string.IsNullOrEmpty(index) ? string.Empty : $"\r\n  {index}";
            query += $"\r\n) ENGINE={dbEngine} DEFAULT CHARSET={dbCharset}";

            gb_create.Text = $"{table}.sql";
            tbx_create.Text = query;
        }

        private void SetErd()
        {
            var pkErd = string.Empty;
            var colErd = string.Empty;
            var separateLine = "\r\n  --";

            foreach (var pk in pks)
            {
                pkErd += $"\r\n  {pk} : int << pk >>";
            }
            foreach(var col in cols)
            {
                colErd += $"\r\n  {col.name} : {col.type}";
            }

            var erd = $@"@startuml

left to right direction

entity ""{table}"" as {table.ToCamelCase()} {{{pkErd}{separateLine}{colErd}
}}

@enduml";

            var fileNm = table.ToLower().Replace('_', '-');
            var idx = fileNm.IndexOf('-') + 1;
            gb_erd.Text = $"{fileNm.Substring(idx)}-erd.puml";
            tbx_erd.Text = erd;
        }

        private void SetVo()
        {

        }

        private void SetMapper()
        {
            var package = string.IsNullOrEmpty(tbx_createFilePath.Text) ? @"""패키지명""" : tbx_createFilePath.Text;
            var mapper = MybatisMapperMaker.GetMapper(package, table, cols);

            gb_mapper.Text = $"{table.ToCamelCase("")}Mapper.xml";
            tbx_mapper.Text = mapper;
        }

        private void SetResultLog()
        {
            lbx_log.Items.Add("========================================================");
            lbx_log.Items.Add("실행 시간 : " + DateTime.Today.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH:mm:ss"));
            SetLog($"테이블 자동 생성여부 : {cbx_createTable.Checked}", false);
            SetLog($"클래스 파일 자동 생성여부 : {cbx_createFile.Checked}");
            if (cbx_createFile.Checked)
            {
                SetLog($"클래스 파일 생성 모드 : {cbx_createFileMode.SelectedItem.ToString()}");
                //SetLog($"클래스 파일 생성 경로 : \\src\\main\\java\\{tbx_createFilePath.Text}");
            }

            lbx_log.Items.Add("========================================================");
        }

        private void SetLog(string value, bool isNewLine = true)
        {
            lbx_log.Items.Add(value);
            string newLine = isNewLine ? Environment.NewLine : string.Empty;
            tbx_result.Text += $"{newLine}{value}";
        }

        private void CreateClassFile()
        {
            if (!cbx_createFile.Checked)
            {
                return;
            }

            DirectoryInfo di = new DirectoryInfo(projectPath);
            if (!di.Exists)
            {
                Msg.Warning("프로젝트 폴더가 존재하지 않습니다.");
                SetLog("프로젝트 폴더가 존재하지 않습니다.", false);
                return;
            }

            // src\main\java\gopos
            var packagePath = $@"{projectPath}{springBootPath}{tbx_createFilePath.Text}";
            var servicePath = $@"{projectPath}{springBootPath}{tbx_createFilePath.Text}\service";
            var daoPath = $@"{projectPath}{springBootPath}{tbx_createFilePath.Text}\dao";
            var mapperPath = $@"{projectPath}{springBootMapperPath}{tbx_createFilePath.Text}";
            DirectoryInfo package = new DirectoryInfo(packagePath);
            DirectoryInfo service = new DirectoryInfo(servicePath);
            DirectoryInfo dao = new DirectoryInfo(daoPath);
            DirectoryInfo mapper = new DirectoryInfo(mapperPath);

            package.Create();
            service.Create();
            dao.Create();
            mapper.Create();

            // mybatis mapper
            //string[] lines = MybatisMapperMaker.GetMapper(tbx_createFilePath.Text, table, cols).Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> lines = new List<string> { MybatisMapperMaker.GetMapper(tbx_createFilePath.Text, table, cols) };

            switch (cbx_createFileMode.SelectedIndex)
            {
                case All:
                    ClassFileMaker.Controller(packagePath, tbx_createFilePath.Text, table.ToCamelCase(""));
                    ClassFileMaker.Service(servicePath, tbx_createFilePath.Text, table.ToCamelCase(""));
                    ClassFileMaker.Dao(daoPath, tbx_createFilePath.Text, table.ToCamelCase(""));
                    ClassFileMaker.Mapper(mapperPath, tbx_createFilePath.Text, table.ToCamelCase(""), lines);

                    break;

                case Controller:
                    ClassFileMaker.Controller(packagePath, tbx_createFilePath.Text, table.ToCamelCase(""));
                    break;

                case Service:
                    ClassFileMaker.Service(servicePath, tbx_createFilePath.Text, table.ToCamelCase(""));
                    break;

                case Dao:
                    ClassFileMaker.Dao(daoPath, tbx_createFilePath.Text, table.ToCamelCase(""));
                    break;

                case Mapper:
                    ClassFileMaker.Mapper(mapperPath, tbx_createFilePath.Text, table.ToCamelCase(""), lines);
                    break;
            }
        }

        private void CreateTable()
        {

        }

        private void btn_findPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;

                if (fbd.ShowDialog().Equals(DialogResult.OK))
                {
                    tbx_projectPath.Text = fbd.SelectedPath;
                    Settings.Default.projectPath = fbd.SelectedPath;
                    Settings.Default.Save();
                }
            }
        }

        private void btn_connectDb_Click(object sender, EventArgs e)
        {
            ConnectDatabasePopup connectDatabasePopup = new ConnectDatabasePopup();
            connectDatabasePopup.ShowDialog();
        }

        private void cbx_createFile_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_createFile.Checked)
            {
                tbx_createFilePath.Enabled = true;
                tbx_createFilePath.ReadOnly = false;
            }
            else
            {
                tbx_createFilePath.Enabled = false;
                tbx_createFilePath.ReadOnly = true;
            }
        }

        private void cbx_createTable_Click(object sender, EventArgs e)
        {
            if (!Settings.Default.isTestConnection)
            {
                Msg.Info("DB 연결을 먼저 진행해주세요.");
                SetLog("DB 연결을 먼저 진행해주세요.", false);

                cbx_createTable.Checked = false;
            }
        }

        private void cbx_createTable_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.isCreateTable = cbx_createTable.Checked;
            Settings.Default.Save();
        }

        private void btn_clearLog_Click(object sender, EventArgs e)
        {
            lbx_log.Items.Clear();
        }

        private void btn_createCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbx_create.Text);
        }

        private void btn_erdCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbx_erd.Text);
        }

        private void btn_mapperCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbx_mapper.Text);
        }
    }
}
