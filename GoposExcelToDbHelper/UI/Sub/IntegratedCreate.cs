﻿using GoposExcelToDbHelper.Utils;
using GoposExcelToDbHelper.VO;
using MemoHelper.Util;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private string excelData => tbx_text.Text;
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

            tbx_create.Font = new Font(FontFamily.GenericMonospace, tbx_mapper.Font.Size);
            tbx_erd.Font = new Font(FontFamily.GenericMonospace, tbx_mapper.Font.Size);
            tbx_vo.Font = new Font(FontFamily.GenericMonospace, tbx_mapper.Font.Size);
            tbx_mapper.Font = new Font(FontFamily.GenericMonospace, tbx_mapper.Font.Size);
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.Show();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.Show();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (!Validation()) return;
            if (!DisassembleExcelData()) return;

            SetCreateQuery();
            SetErd();
            SetVo();
            SetMapper();

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
                tbx_text.Focus();

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
            var column = string.Join(",\r\n", colQuerys);

            // 제약조건 쿼리 생성
            var pk = (pks.Count != 0 ? $", PRIMARY KEY ({string.Join(",", pks)})" : "");
            var fk = "";
            foreach (var fkTable in fks)
            {
                fk += $", CONSTRAINT `fk_{fkTable.table.ToLower()}_{table.ToLower()}_{fks.IndexOf(fkTable) + 1}` FOREIGN KEY (`{fkTable.name}`) REFERENCES `{fkTable.table}` (`{fkTable.name}`)";

                if (fks.IndexOf(fkTable) != fks.Count - 1)
                {
                    fk += "\r\n";
                }
            }
            var unique = (unqs.Count != 0 ? $", CONSTRAINT {table.ToLower()}_uk UNIQUE ({string.Join(",", unqs)})" : "");
            var index = (idxs.Count != 0 ? $", INDEX {table.ToLower()}_idx ({string.Join(",", idxs)})" : "");

            // 쿼리 통합
            var query =
$@"CREATE TABLE `{table}` (
{column}
{pk}
{fk}
{unique}
{index}
) ENGINE={dbEngine} DEFAULT CHARSET={dbCharset}";

            tbx_create.Text = query;

            //Clipboard.SetText(tbx_result.Text);
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

entity ""{table}"" as {table.ToSnakeCase()} {{{pkErd}{separateLine}{colErd}
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
            var mapper = MybatisMapperMaker.GetMapper(table, cols);

            tbx_mapper.Text = mapper;
        }
    }
}
