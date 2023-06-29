namespace GoposExcelToDbHelper
{
    partial class IntegratedCreate
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tc_main = new System.Windows.Forms.TabControl();
            this.tp_create = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_text = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_change = new MetroFramework.Controls.MetroButton();
            this.cbx_charset = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbx_engine = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tb_insert = new System.Windows.Forms.TabPage();
            this.tp_erd = new System.Windows.Forms.TabPage();
            this.tp_vo = new System.Windows.Forms.TabPage();
            this.tp_mapper = new System.Windows.Forms.TabPage();
            this.tp_log = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_clearLog = new MetroFramework.Controls.MetroButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbx_log = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.gp_create = new System.Windows.Forms.GroupBox();
            this.tbx_create = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.gb_erd = new System.Windows.Forms.GroupBox();
            this.tbx_erd = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.gp_vo = new System.Windows.Forms.GroupBox();
            this.tbx_vo = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbx_mapper = new MetroFramework.Controls.MetroTextBox();
            this.tc_main.SuspendLayout();
            this.tp_create.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tb_insert.SuspendLayout();
            this.tp_erd.SuspendLayout();
            this.tp_vo.SuspendLayout();
            this.tp_mapper.SuspendLayout();
            this.tp_log.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gp_create.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.gb_erd.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.gp_vo.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_main
            // 
            this.tc_main.Controls.Add(this.tp_create);
            this.tc_main.Controls.Add(this.tb_insert);
            this.tc_main.Controls.Add(this.tp_erd);
            this.tc_main.Controls.Add(this.tp_vo);
            this.tc_main.Controls.Add(this.tp_mapper);
            this.tc_main.Controls.Add(this.tp_log);
            this.tc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_main.Location = new System.Drawing.Point(21, 75);
            this.tc_main.Name = "tc_main";
            this.tc_main.SelectedIndex = 0;
            this.tc_main.Size = new System.Drawing.Size(890, 502);
            this.tc_main.TabIndex = 1;
            // 
            // tp_create
            // 
            this.tp_create.Controls.Add(this.tableLayoutPanel1);
            this.tp_create.Location = new System.Drawing.Point(4, 25);
            this.tp_create.Name = "tp_create";
            this.tp_create.Padding = new System.Windows.Forms.Padding(3);
            this.tp_create.Size = new System.Drawing.Size(882, 473);
            this.tp_create.TabIndex = 0;
            this.tp_create.Text = "Excel 테이블 데이터";
            this.tp_create.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(876, 467);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 54);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(870, 409);
            this.splitContainer1.SplitterDistance = 424;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_text);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(424, 409);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "엑셀 텍스트";
            // 
            // tbx_text
            // 
            // 
            // 
            // 
            this.tbx_text.CustomButton.Image = null;
            this.tbx_text.CustomButton.Location = new System.Drawing.Point(36, 1);
            this.tbx_text.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_text.CustomButton.Name = "";
            this.tbx_text.CustomButton.Size = new System.Drawing.Size(381, 381);
            this.tbx_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_text.CustomButton.TabIndex = 1;
            this.tbx_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_text.CustomButton.UseSelectable = true;
            this.tbx_text.CustomButton.Visible = false;
            this.tbx_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_text.Lines = new string[0];
            this.tbx_text.Location = new System.Drawing.Point(3, 22);
            this.tbx_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_text.MaxLength = 32767;
            this.tbx_text.Multiline = true;
            this.tbx_text.Name = "tbx_text";
            this.tbx_text.PasswordChar = '\0';
            this.tbx_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_text.SelectedText = "";
            this.tbx_text.SelectionLength = 0;
            this.tbx_text.SelectionStart = 0;
            this.tbx_text.ShortcutsEnabled = true;
            this.tbx_text.Size = new System.Drawing.Size(418, 383);
            this.tbx_text.TabIndex = 2;
            this.tbx_text.UseSelectable = true;
            this.tbx_text.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_text.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 409);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "옵션";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_change);
            this.flowLayoutPanel1.Controls.Add(this.cbx_charset);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel3);
            this.flowLayoutPanel1.Controls.Add(this.cbx_engine);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(870, 42);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(781, 4);
            this.btn_change.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(86, 36);
            this.btn_change.TabIndex = 10;
            this.btn_change.Text = "변환";
            this.btn_change.UseSelectable = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // cbx_charset
            // 
            this.cbx_charset.FormattingEnabled = true;
            this.cbx_charset.ItemHeight = 24;
            this.cbx_charset.Location = new System.Drawing.Point(637, 4);
            this.cbx_charset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx_charset.Name = "cbx_charset";
            this.cbx_charset.Size = new System.Drawing.Size(138, 30);
            this.cbx_charset.TabIndex = 13;
            this.cbx_charset.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(476, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(155, 40);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "DEFAULT CHARSET :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbx_engine
            // 
            this.cbx_engine.FormattingEnabled = true;
            this.cbx_engine.ItemHeight = 24;
            this.cbx_engine.Location = new System.Drawing.Point(332, 4);
            this.cbx_engine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx_engine.Name = "cbx_engine";
            this.cbx_engine.Size = new System.Drawing.Size(138, 30);
            this.cbx_engine.TabIndex = 14;
            this.cbx_engine.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(251, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 40);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "ENGINE :";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_insert
            // 
            this.tb_insert.Controls.Add(this.tableLayoutPanel3);
            this.tb_insert.Location = new System.Drawing.Point(4, 25);
            this.tb_insert.Name = "tb_insert";
            this.tb_insert.Padding = new System.Windows.Forms.Padding(3);
            this.tb_insert.Size = new System.Drawing.Size(882, 473);
            this.tb_insert.TabIndex = 1;
            this.tb_insert.Text = "테이블 Create 쿼리";
            this.tb_insert.UseVisualStyleBackColor = true;
            // 
            // tp_erd
            // 
            this.tp_erd.Controls.Add(this.tableLayoutPanel4);
            this.tp_erd.Location = new System.Drawing.Point(4, 25);
            this.tp_erd.Name = "tp_erd";
            this.tp_erd.Padding = new System.Windows.Forms.Padding(3);
            this.tp_erd.Size = new System.Drawing.Size(882, 473);
            this.tp_erd.TabIndex = 2;
            this.tp_erd.Text = "ERD";
            this.tp_erd.UseVisualStyleBackColor = true;
            // 
            // tp_vo
            // 
            this.tp_vo.Controls.Add(this.tableLayoutPanel5);
            this.tp_vo.Location = new System.Drawing.Point(4, 25);
            this.tp_vo.Name = "tp_vo";
            this.tp_vo.Padding = new System.Windows.Forms.Padding(3);
            this.tp_vo.Size = new System.Drawing.Size(882, 473);
            this.tp_vo.TabIndex = 3;
            this.tp_vo.Text = "VO";
            this.tp_vo.UseVisualStyleBackColor = true;
            // 
            // tp_mapper
            // 
            this.tp_mapper.Controls.Add(this.tableLayoutPanel6);
            this.tp_mapper.Location = new System.Drawing.Point(4, 25);
            this.tp_mapper.Name = "tp_mapper";
            this.tp_mapper.Padding = new System.Windows.Forms.Padding(3);
            this.tp_mapper.Size = new System.Drawing.Size(882, 473);
            this.tp_mapper.TabIndex = 4;
            this.tp_mapper.Text = "Mapper";
            this.tp_mapper.UseVisualStyleBackColor = true;
            // 
            // tp_log
            // 
            this.tp_log.Controls.Add(this.tableLayoutPanel2);
            this.tp_log.Location = new System.Drawing.Point(4, 25);
            this.tp_log.Name = "tp_log";
            this.tp_log.Padding = new System.Windows.Forms.Padding(3);
            this.tp_log.Size = new System.Drawing.Size(882, 473);
            this.tp_log.TabIndex = 5;
            this.tp_log.Text = "변환 결과 Log";
            this.tp_log.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btn_clearLog, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(876, 467);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // btn_clearLog
            // 
            this.btn_clearLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clearLog.Location = new System.Drawing.Point(3, 420);
            this.btn_clearLog.Name = "btn_clearLog";
            this.btn_clearLog.Size = new System.Drawing.Size(870, 44);
            this.btn_clearLog.TabIndex = 13;
            this.btn_clearLog.Text = "로그 초기화";
            this.btn_clearLog.UseSelectable = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbx_log);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 4);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(870, 409);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "변환 결과 Log";
            // 
            // tbx_log
            // 
            // 
            // 
            // 
            this.tbx_log.CustomButton.Image = null;
            this.tbx_log.CustomButton.Location = new System.Drawing.Point(482, 1);
            this.tbx_log.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_log.CustomButton.Name = "";
            this.tbx_log.CustomButton.Size = new System.Drawing.Size(381, 381);
            this.tbx_log.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_log.CustomButton.TabIndex = 1;
            this.tbx_log.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_log.CustomButton.UseSelectable = true;
            this.tbx_log.CustomButton.Visible = false;
            this.tbx_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_log.Lines = new string[0];
            this.tbx_log.Location = new System.Drawing.Point(3, 22);
            this.tbx_log.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_log.MaxLength = 32767;
            this.tbx_log.Multiline = true;
            this.tbx_log.Name = "tbx_log";
            this.tbx_log.PasswordChar = '\0';
            this.tbx_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_log.SelectedText = "";
            this.tbx_log.SelectionLength = 0;
            this.tbx_log.SelectionStart = 0;
            this.tbx_log.ShortcutsEnabled = true;
            this.tbx_log.Size = new System.Drawing.Size(864, 383);
            this.tbx_log.TabIndex = 2;
            this.tbx_log.UseSelectable = true;
            this.tbx_log.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_log.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.metroButton1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.gp_create, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(876, 467);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // metroButton1
            // 
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton1.Location = new System.Drawing.Point(3, 420);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(870, 44);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "로그 초기화";
            this.metroButton1.UseSelectable = true;
            // 
            // gp_create
            // 
            this.gp_create.Controls.Add(this.tbx_create);
            this.gp_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp_create.Location = new System.Drawing.Point(3, 4);
            this.gp_create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gp_create.Name = "gp_create";
            this.gp_create.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gp_create.Size = new System.Drawing.Size(870, 409);
            this.gp_create.TabIndex = 10;
            this.gp_create.TabStop = false;
            this.gp_create.Text = "Create 쿼리";
            // 
            // tbx_create
            // 
            // 
            // 
            // 
            this.tbx_create.CustomButton.Image = null;
            this.tbx_create.CustomButton.Location = new System.Drawing.Point(482, 1);
            this.tbx_create.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_create.CustomButton.Name = "";
            this.tbx_create.CustomButton.Size = new System.Drawing.Size(381, 381);
            this.tbx_create.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_create.CustomButton.TabIndex = 1;
            this.tbx_create.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_create.CustomButton.UseSelectable = true;
            this.tbx_create.CustomButton.Visible = false;
            this.tbx_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_create.Lines = new string[0];
            this.tbx_create.Location = new System.Drawing.Point(3, 22);
            this.tbx_create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_create.MaxLength = 32767;
            this.tbx_create.Multiline = true;
            this.tbx_create.Name = "tbx_create";
            this.tbx_create.PasswordChar = '\0';
            this.tbx_create.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_create.SelectedText = "";
            this.tbx_create.SelectionLength = 0;
            this.tbx_create.SelectionStart = 0;
            this.tbx_create.ShortcutsEnabled = true;
            this.tbx_create.Size = new System.Drawing.Size(864, 383);
            this.tbx_create.TabIndex = 2;
            this.tbx_create.UseSelectable = true;
            this.tbx_create.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_create.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.metroButton2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.gb_erd, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(876, 467);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // metroButton2
            // 
            this.metroButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton2.Location = new System.Drawing.Point(3, 420);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(870, 44);
            this.metroButton2.TabIndex = 13;
            this.metroButton2.Text = "로그 초기화";
            this.metroButton2.UseSelectable = true;
            // 
            // gb_erd
            // 
            this.gb_erd.Controls.Add(this.tbx_erd);
            this.gb_erd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_erd.Location = new System.Drawing.Point(3, 4);
            this.gb_erd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_erd.Name = "gb_erd";
            this.gb_erd.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_erd.Size = new System.Drawing.Size(870, 409);
            this.gb_erd.TabIndex = 10;
            this.gb_erd.TabStop = false;
            this.gb_erd.Text = "ERD";
            // 
            // tbx_erd
            // 
            // 
            // 
            // 
            this.tbx_erd.CustomButton.Image = null;
            this.tbx_erd.CustomButton.Location = new System.Drawing.Point(482, 1);
            this.tbx_erd.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_erd.CustomButton.Name = "";
            this.tbx_erd.CustomButton.Size = new System.Drawing.Size(381, 381);
            this.tbx_erd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_erd.CustomButton.TabIndex = 1;
            this.tbx_erd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_erd.CustomButton.UseSelectable = true;
            this.tbx_erd.CustomButton.Visible = false;
            this.tbx_erd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_erd.Lines = new string[0];
            this.tbx_erd.Location = new System.Drawing.Point(3, 22);
            this.tbx_erd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_erd.MaxLength = 32767;
            this.tbx_erd.Multiline = true;
            this.tbx_erd.Name = "tbx_erd";
            this.tbx_erd.PasswordChar = '\0';
            this.tbx_erd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_erd.SelectedText = "";
            this.tbx_erd.SelectionLength = 0;
            this.tbx_erd.SelectionStart = 0;
            this.tbx_erd.ShortcutsEnabled = true;
            this.tbx_erd.Size = new System.Drawing.Size(864, 383);
            this.tbx_erd.TabIndex = 2;
            this.tbx_erd.UseSelectable = true;
            this.tbx_erd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_erd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.metroButton3, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.gp_vo, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(876, 467);
            this.tableLayoutPanel5.TabIndex = 11;
            // 
            // metroButton3
            // 
            this.metroButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton3.Location = new System.Drawing.Point(3, 420);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(870, 44);
            this.metroButton3.TabIndex = 13;
            this.metroButton3.Text = "로그 초기화";
            this.metroButton3.UseSelectable = true;
            // 
            // gp_vo
            // 
            this.gp_vo.Controls.Add(this.tbx_vo);
            this.gp_vo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp_vo.Location = new System.Drawing.Point(3, 4);
            this.gp_vo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gp_vo.Name = "gp_vo";
            this.gp_vo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gp_vo.Size = new System.Drawing.Size(870, 409);
            this.gp_vo.TabIndex = 10;
            this.gp_vo.TabStop = false;
            this.gp_vo.Text = "VO";
            // 
            // tbx_vo
            // 
            // 
            // 
            // 
            this.tbx_vo.CustomButton.Image = null;
            this.tbx_vo.CustomButton.Location = new System.Drawing.Point(482, 1);
            this.tbx_vo.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_vo.CustomButton.Name = "";
            this.tbx_vo.CustomButton.Size = new System.Drawing.Size(381, 381);
            this.tbx_vo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_vo.CustomButton.TabIndex = 1;
            this.tbx_vo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_vo.CustomButton.UseSelectable = true;
            this.tbx_vo.CustomButton.Visible = false;
            this.tbx_vo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_vo.Lines = new string[0];
            this.tbx_vo.Location = new System.Drawing.Point(3, 22);
            this.tbx_vo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_vo.MaxLength = 32767;
            this.tbx_vo.Multiline = true;
            this.tbx_vo.Name = "tbx_vo";
            this.tbx_vo.PasswordChar = '\0';
            this.tbx_vo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_vo.SelectedText = "";
            this.tbx_vo.SelectionLength = 0;
            this.tbx_vo.SelectionStart = 0;
            this.tbx_vo.ShortcutsEnabled = true;
            this.tbx_vo.Size = new System.Drawing.Size(864, 383);
            this.tbx_vo.TabIndex = 2;
            this.tbx_vo.UseSelectable = true;
            this.tbx_vo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_vo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.metroButton4, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(876, 467);
            this.tableLayoutPanel6.TabIndex = 11;
            // 
            // metroButton4
            // 
            this.metroButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton4.Location = new System.Drawing.Point(3, 420);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(870, 44);
            this.metroButton4.TabIndex = 13;
            this.metroButton4.Text = "로그 초기화";
            this.metroButton4.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbx_mapper);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(870, 409);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mapper";
            // 
            // tbx_mapper
            // 
            // 
            // 
            // 
            this.tbx_mapper.CustomButton.Image = null;
            this.tbx_mapper.CustomButton.Location = new System.Drawing.Point(482, 1);
            this.tbx_mapper.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_mapper.CustomButton.Name = "";
            this.tbx_mapper.CustomButton.Size = new System.Drawing.Size(381, 381);
            this.tbx_mapper.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_mapper.CustomButton.TabIndex = 1;
            this.tbx_mapper.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_mapper.CustomButton.UseSelectable = true;
            this.tbx_mapper.CustomButton.Visible = false;
            this.tbx_mapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_mapper.Lines = new string[0];
            this.tbx_mapper.Location = new System.Drawing.Point(3, 22);
            this.tbx_mapper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_mapper.MaxLength = 32767;
            this.tbx_mapper.Multiline = true;
            this.tbx_mapper.Name = "tbx_mapper";
            this.tbx_mapper.PasswordChar = '\0';
            this.tbx_mapper.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_mapper.SelectedText = "";
            this.tbx_mapper.SelectionLength = 0;
            this.tbx_mapper.SelectionStart = 0;
            this.tbx_mapper.ShortcutsEnabled = true;
            this.tbx_mapper.Size = new System.Drawing.Size(864, 383);
            this.tbx_mapper.TabIndex = 2;
            this.tbx_mapper.UseSelectable = true;
            this.tbx_mapper.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_mapper.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // IntegratedCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 597);
            this.Controls.Add(this.tc_main);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IntegratedCreate";
            this.Padding = new System.Windows.Forms.Padding(21, 75, 21, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Load += new System.EventHandler(this.Main_Load);
            this.tc_main.ResumeLayout(false);
            this.tp_create.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tb_insert.ResumeLayout(false);
            this.tp_erd.ResumeLayout(false);
            this.tp_vo.ResumeLayout(false);
            this.tp_mapper.ResumeLayout(false);
            this.tp_log.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.gp_create.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.gb_erd.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.gp_vo.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tc_main;
        private System.Windows.Forms.TabPage tp_create;
        private System.Windows.Forms.TabPage tb_insert;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox tbx_text;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton btn_change;
        private MetroFramework.Controls.MetroComboBox cbx_charset;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbx_engine;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tp_erd;
        private System.Windows.Forms.TabPage tp_vo;
        private System.Windows.Forms.TabPage tp_mapper;
        private System.Windows.Forms.TabPage tp_log;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox6;
        private MetroFramework.Controls.MetroTextBox tbx_log;
        private MetroFramework.Controls.MetroButton btn_clearLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.GroupBox gp_create;
        private MetroFramework.Controls.MetroTextBox tbx_create;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.GroupBox gb_erd;
        private MetroFramework.Controls.MetroTextBox tbx_erd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.GroupBox gp_vo;
        private MetroFramework.Controls.MetroTextBox tbx_vo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox tbx_mapper;
    }
}

