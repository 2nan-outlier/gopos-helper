using MemoHelper.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoposExcelToDbHelper
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Size = new Size(278, 170);
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            IntegratedCreate create = new IntegratedCreate();
            create.Show();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.Show();
        }

        private void FormSizeCheck()
        {
            var height = this.Size.Height;
            var width = this.Size.Width;

            if (height != 170 || width != 278)
            {
                Msg.Info("폼 사이즈 오류로 인해 크기를 재조정합니다.");
                this.Size = new Size(278, 170);
            }
        }

        private void Main_MouseHover(object sender, EventArgs e)
        {
            FormSizeCheck();
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            FormSizeCheck();
        }
    }
}
