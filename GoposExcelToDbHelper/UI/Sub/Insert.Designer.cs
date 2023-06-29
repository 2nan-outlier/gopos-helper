namespace GoposExcelToDbHelper
{
    partial class Insert
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbx_text = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbx_result = new MetroFramework.Controls.MetroTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbx_table = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_change = new MetroFramework.Controls.MetroButton();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(21, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(236, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "GOPOS Excel To Db Helper";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_text
            // 
            // 
            // 
            // 
            this.tbx_text.CustomButton.Image = null;
            this.tbx_text.CustomButton.Location = new System.Drawing.Point(-82, 1);
            this.tbx_text.CustomButton.Name = "";
            this.tbx_text.CustomButton.Size = new System.Drawing.Size(425, 425);
            this.tbx_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_text.CustomButton.TabIndex = 1;
            this.tbx_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_text.CustomButton.UseSelectable = true;
            this.tbx_text.CustomButton.Visible = false;
            this.tbx_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_text.Lines = new string[0];
            this.tbx_text.Location = new System.Drawing.Point(3, 17);
            this.tbx_text.MaxLength = 32767;
            this.tbx_text.Multiline = true;
            this.tbx_text.Name = "tbx_text";
            this.tbx_text.PasswordChar = '\0';
            this.tbx_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_text.SelectedText = "";
            this.tbx_text.SelectionLength = 0;
            this.tbx_text.SelectionStart = 0;
            this.tbx_text.ShortcutsEnabled = true;
            this.tbx_text.Size = new System.Drawing.Size(344, 427);
            this.tbx_text.TabIndex = 2;
            this.tbx_text.UseSelectable = true;
            this.tbx_text.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_text.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_text);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 447);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "엑셀 텍스트";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbx_result);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 447);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "변환된 쿼리";
            // 
            // tbx_result
            // 
            // 
            // 
            // 
            this.tbx_result.CustomButton.Image = null;
            this.tbx_result.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.tbx_result.CustomButton.Name = "";
            this.tbx_result.CustomButton.Size = new System.Drawing.Size(425, 425);
            this.tbx_result.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_result.CustomButton.TabIndex = 1;
            this.tbx_result.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_result.CustomButton.UseSelectable = true;
            this.tbx_result.CustomButton.Visible = false;
            this.tbx_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_result.Lines = new string[0];
            this.tbx_result.Location = new System.Drawing.Point(3, 17);
            this.tbx_result.MaxLength = 32767;
            this.tbx_result.Multiline = true;
            this.tbx_result.Name = "tbx_result";
            this.tbx_result.PasswordChar = '\0';
            this.tbx_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_result.SelectedText = "";
            this.tbx_result.SelectionLength = 0;
            this.tbx_result.SelectionStart = 0;
            this.tbx_result.ShortcutsEnabled = true;
            this.tbx_result.Size = new System.Drawing.Size(521, 427);
            this.tbx_result.TabIndex = 2;
            this.tbx_result.UseSelectable = true;
            this.tbx_result.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_result.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 38);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(881, 447);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 5;
            // 
            // tbx_table
            // 
            // 
            // 
            // 
            this.tbx_table.CustomButton.Image = null;
            this.tbx_table.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.tbx_table.CustomButton.Name = "";
            this.tbx_table.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbx_table.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_table.CustomButton.TabIndex = 1;
            this.tbx_table.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_table.CustomButton.UseSelectable = true;
            this.tbx_table.CustomButton.Visible = false;
            this.tbx_table.Lines = new string[0];
            this.tbx_table.Location = new System.Drawing.Point(562, 3);
            this.tbx_table.MaxLength = 32767;
            this.tbx_table.Name = "tbx_table";
            this.tbx_table.PasswordChar = '\0';
            this.tbx_table.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx_table.SelectedText = "";
            this.tbx_table.SelectionLength = 0;
            this.tbx_table.SelectionStart = 0;
            this.tbx_table.ShortcutsEnabled = true;
            this.tbx_table.Size = new System.Drawing.Size(235, 23);
            this.tbx_table.TabIndex = 6;
            this.tbx_table.UseSelectable = true;
            this.tbx_table.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_table.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(477, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 26);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "테이블명 :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(887, 488);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_change);
            this.flowLayoutPanel1.Controls.Add(this.tbx_table);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(881, 29);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(803, 3);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 10;
            this.btn_change.Text = "변환";
            this.btn_change.UseSelectable = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(248, 38);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(55, 23);
            this.metroLink1.TabIndex = 9;
            this.metroLink1.Text = "사용법";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 564);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Insert";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 16);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbx_text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox tbx_result;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroTextBox tbx_table;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton btn_change;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}

