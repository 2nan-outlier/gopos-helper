using GoposExcelToDbHelper.Properties;
using GoposExcelToDbHelper.Utils;
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

namespace GoposExcelToDbHelper.UI.Popup
{
    public partial class ConnectDatabasePopup : MetroFramework.Forms.MetroForm
    {
        public bool isTestConnection = false;

        public ConnectDatabasePopup()
        {
            InitializeComponent();
        }

        private void ConnectDatabasePopup_Load(object sender, EventArgs e)
        {
            tbx_dbHost.Text = Settings.Default.dbHost;
            tbx_dbPort.Text = Settings.Default.dbPort;
            tbx_dbSchema.Text = Settings.Default.dbSchema;
            tbx_userId.Text = Settings.Default.dbUserId;
            tbx_userPw.Text = Settings.Default.dbUserPw;

            tbx_dbHost.TextChanged += TextChanged;
            tbx_dbPort.TextChanged += TextChanged;
            tbx_dbSchema.TextChanged += TextChanged;
            tbx_userId.TextChanged += TextChanged;
            tbx_userPw.TextChanged += TextChanged;
        }

        private bool ValidationInput()
        {
            if (string.IsNullOrEmpty(tbx_dbHost.Text))
            {
                Msg.Info("DB Host를 입력해주세요.");
                return false;
            }
            if (string.IsNullOrEmpty(tbx_dbPort.Text))
            {
                Msg.Info("DB Port를 입력해주세요.");
                return false;
            }
            if (string.IsNullOrEmpty(tbx_dbSchema.Text))
            {
                Msg.Info("DB Schema를 입력해주세요.");
                return false;
            }
            if (string.IsNullOrEmpty(tbx_userId.Text))
            {
                Msg.Info("DB User ID를 입력해주세요.");
                return false;
            }
            if (string.IsNullOrEmpty(tbx_userPw.Text))
            {
                Msg.Info("DB User Pw를 입력해주세요.");
                return false;
            }
            if (!int.TryParse(tbx_dbPort.Text, out int port))
            {
                Msg.Info("DB Port는 숫자만 입력해주세요.");
                return false;
            }

            return true;
        }

        private void btn_testConnection_Click(object sender, EventArgs e)
        {
            isTestConnection = false;

            if (!ValidationInput()) return;

            int.TryParse(tbx_dbPort.Text, out int port);

            MysqlUtils mysql = new MysqlUtils(
                tbx_dbHost.Text,
                port,
                tbx_dbSchema.Text,
                tbx_userId.Text,
                tbx_userPw.Text
            );

            if (mysql.DatabaseTestConnection())
            {
                isTestConnection = true;
                Settings.Default.isTestConnection = true;
                Settings.Default.Save();

                Msg.Info("정상적으로 연결되었습니다.");
            }
            else
            {
                Msg.Warning("연결을 실패했습니다.");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!ValidationInput()) return;

            if (!isTestConnection)
            {
                Msg.Warning("Test Connection을 실행해주세요.");
                return;
            }

            Settings.Default.dbHost = tbx_dbHost.Text;
            Settings.Default.dbPort = tbx_dbPort.Text;
            Settings.Default.dbSchema = tbx_dbSchema.Text;
            Settings.Default.dbUserId = tbx_userId.Text;
            Settings.Default.dbUserPw = tbx_userPw.Text;
            Settings.Default.Save();

            Msg.Info("저장되었습니다.");
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (Msg.Ask("취소하시겠습니까?").Equals(DialogResult.Yes))
            {
                Dispose();
            }
        }

        private void ConnectDatabasePopup_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void TextChanged(object sender, EventArgs e)
        {
            // 텍스트가 변경되면 TestConnection 여부 false
            isTestConnection = false;
        }
    }
}
