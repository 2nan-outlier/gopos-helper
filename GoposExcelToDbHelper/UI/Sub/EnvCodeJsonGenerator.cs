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
    public partial class EnvCodeJsonGenerator : MetroFramework.Forms.MetroForm
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

        public EnvCodeJsonGenerator()
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


            foreach (var row in rows)
            {
                if (Array.IndexOf(rows, row) == 0) continue;

                var idx = 0;
                var value = string.Empty;
                var cols = row.Split('\t');
                foreach (var col in cols)
                {
                    value += $"\"{col}\"";

                    if (idx != cols.Length - 1)
                    {
                        value += ",";
                    }

                    idx++;
                }

                var query = $@"INSERT INTO {table}({column}) VALUES ({value});";
                insertQuerys.Add(query);
            }

            var allQuery = string.Empty;
            foreach (var query in insertQuerys)
            {
                allQuery += query + "\r\n";
            }

            tbx_result.Text = allQuery;

            Clipboard.SetText(tbx_result.Text);
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Process.Start("chrome", @"https://www.notion.so/Gopos-Excel-To-Db-Helper-668cd93c63894ed5a8e0313e1a0e1954");
        }
    }
}
