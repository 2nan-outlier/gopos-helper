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
    public partial class Insert : MetroFramework.Forms.MetroForm
    {
        string table => tbx_table.Text.Trim();
        string txt => tbx_text.Text.Trim();

        public Insert()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private bool Validation()
        {
            if (table.Equals(string.Empty))
            {
                Msg.Info("테이블명이 입력되지 않았습니다.");
                tbx_table.Focus();

                return false;
            }
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
            var insertQuerys = new List<string>();
            var column = rows.First().Replace("\t", ", ");

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
