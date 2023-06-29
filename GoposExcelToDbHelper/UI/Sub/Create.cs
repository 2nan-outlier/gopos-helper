using MemoHelper.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoposExcelToDbHelper
{
    public partial class Create : MetroFramework.Forms.MetroForm
    {
        string txt => tbx_text.Text.Trim();
        string engine => cbx_engine.SelectedItem.ToString();
        string charset => cbx_charset.SelectedItem.ToString();

        struct ColumnInfo
        {
            public string name;
            public string type;
            public bool isNotNull;
            public bool isPk;
            public bool isFk;
            public bool isUnique;
            public bool isIndex;
            public string comment;
            public string defaults;
        }

        struct ForeignKeyInfo
        {
            public string table;
            public string name;
        }

        public Create()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitWindow();
        }

        private void InitWindow()
        {
            // 엔진 add
            cbx_engine.Items.Add("InnoDB");
            //cbx_engine.Items.Add("MyISAM");
            //cbx_engine.Items.Add("ndbcluster");
            //cbx_engine.Items.Add("MEMORY");
            //cbx_engine.Items.Add("FEDERATED");
            //cbx_engine.Items.Add("ARCHIVE");
            //cbx_engine.Items.Add("CSV");
            //cbx_engine.Items.Add("BLACKHOLE");
            //cbx_engine.Items.Add("MRG_MyISAM");

            // 캐릭터셋 add
            cbx_charset.Items.Add("utf8mb4");

            cbx_engine.SelectedIndex = 0;
            cbx_charset.SelectedIndex = 0;
        }

        private bool Validation()
        {
            if (txt.Equals(string.Empty))
            {
                Msg.Info("변환할 텍스트가 입력되지 않았습니다.");
                tbx_text.Focus();

                return false;
            }

            return true;
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                return;
            }

            var rows = txt.Split(new char[] {'\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var pkList = new List<string>();
            var fKList = new List<ForeignKeyInfo>();
            var uniqueList = new List<string>();
            var indexList = new List<string>();
            var colList = new List<string>();
            var table = string.Empty;

            //    0         1       2         3         4        5    6    7       8         9       10     11     12    
            // 엔터티명 테이블명 [컬럼명] [속성명] [속성타입] 도메인 설명 [PK] [NOT NULL] [UNIQUE] [INDEX] [FK] [기본값] MIN MAX
            // `컬럼명` 타입 null여부 추가옵션 comment ''

            if (rows.First().Split('\t').Length != 13)
            {
                Msg.Info("복사한 엑셀 컬럼수를 확인해주세요.\n\n엔티티명, 테이블명, 컬럼명, 속성명, 속성타입, 도메인, 설명, PK, NOT NULL, UNIQUE, INDEX, FK, 기본값");
                return;
            }

            foreach (var row in rows)
            {
                if (Array.IndexOf(rows, row) == 0) continue;

                var cols = row.Split('\t').ToList();

                if (cols.Count <= 0)
                {
                    continue;
                }

                table = cols[1].Trim().ToUpper();

                var name = cols[2].Trim().ToUpper();
                var comment = cols[3].Trim();
                var type = cols[4].Trim();
                var isPk = cols.Count <= 7 ? false : cols[7].Trim().Equals("O");
                var isNotNull = cols.Count <= 8 ? false : cols[8].Trim().Equals("O");
                var isUnique = cols.Count <= 9 ? false : cols[9].Trim().Equals("O");
                var isIndex = cols.Count <= 10 ? false : cols[10].Trim().Equals("O");
                var isFk = cols.Count <= 11 ? false : !cols[11].Trim().Equals("");
                var defaults = cols.Count <= 12 ? "" : cols[12].Trim();

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
                if (col.isPk) pkList.Add($"`{col.name}`");
                if (col.isFk) fKList.Add(new ForeignKeyInfo()
                {
                    table = cols[11].Trim(),
                    name = col.name
                });
                if (col.isUnique) uniqueList.Add($"`{col.name}`");
                if (col.isIndex) indexList.Add($"`{col.name}`");

                // 컬럼 쿼리 리스트에 추가
                var colQuery = 
                    $@"`{col.name}` {col.type} {(col.isNotNull ? "NOT NULL" : "")} {(col.defaults.Equals("AUTO_INCREMENT") ? col.defaults : col.defaults.Equals(string.Empty) ? "" : $"DEFAULT {col.defaults}")} COMMENT '{col.comment}'";
                colList.Add(colQuery);
            }

            // 컬럼 쿼리 생성
            var column = string.Join(",\r\n", colList);

            // 제약조건 쿼리 생성
            var pk = (pkList.Count != 0 ? $", PRIMARY KEY ({string.Join(",", pkList)})" : "");
            var fk = "";
            foreach (var fkTable in fKList)
            {
                fk += $", CONSTRAINT `fk_{fkTable.table.ToLower()}_{table.ToLower()}_{fKList.IndexOf(fkTable) + 1}` FOREIGN KEY (`{fkTable.name}`) REFERENCES `{fkTable.table}` (`{fkTable.name}`)";
                
                if (fKList.IndexOf(fkTable) != fKList.Count - 1){
                    fk += "\r\n";
                }
            }
            var unique = (uniqueList.Count != 0 ? $", CONSTRAINT {table.ToLower()}_uk UNIQUE ({string.Join(",", uniqueList)})" : "");
            var index = (indexList.Count != 0 ? $", INDEX {table.ToLower()}_idx ({string.Join(",", indexList)})" : "");

            // 쿼리 통합
            var query =
$@"CREATE TABLE `{table}` (
{column}
{pk}
{fk}
{unique}
{index}
) ENGINE={engine} DEFAULT CHARSET={charset}";

            tbx_result.Text = query;

            Clipboard.SetText(tbx_result.Text);
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Process.Start("chrome", @"https://www.notion.so/Gopos-Excel-To-Db-Helper-668cd93c63894ed5a8e0313e1a0e1954");
        }
    }
}
