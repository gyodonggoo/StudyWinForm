namespace BookRentalShop.SubItems
{
    partial class UserMngForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMngForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdUserTbl = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.Email = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.Addr = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Names = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.IDX = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Mobile = new MetroFramework.Controls.MetroTextBox();
            this.Levels = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUserTbl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GrdUserTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(760, 370);
            this.splitContainer1.SplitterDistance = 373;
            this.splitContainer1.TabIndex = 0;
            // 
            // GrdUserTbl
            // 
            this.GrdUserTbl.AllowUserToResizeRows = false;
            this.GrdUserTbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.GrdUserTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdUserTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdUserTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdUserTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdUserTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdUserTbl.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrdUserTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdUserTbl.EnableHeadersVisualStyles = false;
            this.GrdUserTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdUserTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdUserTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdUserTbl.Name = "GrdUserTbl";
            this.GrdUserTbl.ReadOnly = true;
            this.GrdUserTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdUserTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrdUserTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdUserTbl.RowTemplate.Height = 23;
            this.GrdUserTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdUserTbl.Size = new System.Drawing.Size(373, 370);
            this.GrdUserTbl.TabIndex = 0;
            this.GrdUserTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrbDevTbl_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Levels);
            this.groupBox1.Controls.Add(this.BtnCancel);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.Addr);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.Mobile);
            this.groupBox1.Controls.Add(this.Names);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.IDX);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕코딩", 13F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상세";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(292, 308);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseSelectable = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(201, 308);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(109, 308);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 6;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // Email
            // 
            // 
            // 
            // 
            this.Email.CustomButton.Image = null;
            this.Email.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.Email.CustomButton.Name = "";
            this.Email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Email.CustomButton.TabIndex = 1;
            this.Email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Email.CustomButton.UseSelectable = true;
            this.Email.CustomButton.Visible = false;
            this.Email.Lines = new string[0];
            this.Email.Location = new System.Drawing.Point(103, 211);
            this.Email.MaxLength = 200;
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Email.SelectedText = "";
            this.Email.SelectionLength = 0;
            this.Email.SelectionStart = 0;
            this.Email.ShortcutsEnabled = true;
            this.Email.Size = new System.Drawing.Size(264, 23);
            this.Email.TabIndex = 5;
            this.Email.UseSelectable = true;
            this.Email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(16, 211);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(81, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "이메일 :";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Addr
            // 
            // 
            // 
            // 
            this.Addr.CustomButton.Image = null;
            this.Addr.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.Addr.CustomButton.Name = "";
            this.Addr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Addr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Addr.CustomButton.TabIndex = 1;
            this.Addr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Addr.CustomButton.UseSelectable = true;
            this.Addr.CustomButton.Visible = false;
            this.Addr.Lines = new string[0];
            this.Addr.Location = new System.Drawing.Point(103, 140);
            this.Addr.MaxLength = 100;
            this.Addr.Name = "Addr";
            this.Addr.PasswordChar = '\0';
            this.Addr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Addr.SelectedText = "";
            this.Addr.SelectionLength = 0;
            this.Addr.SelectionStart = 0;
            this.Addr.ShortcutsEnabled = true;
            this.Addr.Size = new System.Drawing.Size(264, 23);
            this.Addr.TabIndex = 3;
            this.Addr.UseSelectable = true;
            this.Addr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Addr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(16, 140);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "주소 :";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Names
            // 
            // 
            // 
            // 
            this.Names.CustomButton.Image = null;
            this.Names.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.Names.CustomButton.Name = "";
            this.Names.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Names.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Names.CustomButton.TabIndex = 1;
            this.Names.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Names.CustomButton.UseSelectable = true;
            this.Names.CustomButton.Visible = false;
            this.Names.Lines = new string[0];
            this.Names.Location = new System.Drawing.Point(103, 69);
            this.Names.MaxLength = 45;
            this.Names.Name = "Names";
            this.Names.PasswordChar = '\0';
            this.Names.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Names.SelectedText = "";
            this.Names.SelectionLength = 0;
            this.Names.SelectionStart = 0;
            this.Names.ShortcutsEnabled = true;
            this.Names.Size = new System.Drawing.Size(264, 23);
            this.Names.TabIndex = 1;
            this.Names.UseSelectable = true;
            this.Names.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Names.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(16, 175);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(81, 23);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "전화번호 :";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(16, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "이름 :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(16, 104);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 23);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "등급 :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IDX
            // 
            // 
            // 
            // 
            this.IDX.CustomButton.Image = null;
            this.IDX.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.IDX.CustomButton.Name = "";
            this.IDX.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.IDX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.IDX.CustomButton.TabIndex = 1;
            this.IDX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IDX.CustomButton.UseSelectable = true;
            this.IDX.CustomButton.Visible = false;
            this.IDX.Lines = new string[0];
            this.IDX.Location = new System.Drawing.Point(103, 33);
            this.IDX.MaxLength = 15;
            this.IDX.Name = "IDX";
            this.IDX.PasswordChar = '\0';
            this.IDX.ReadOnly = true;
            this.IDX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IDX.SelectedText = "";
            this.IDX.SelectionLength = 0;
            this.IDX.SelectionStart = 0;
            this.IDX.ShortcutsEnabled = true;
            this.IDX.Size = new System.Drawing.Size(264, 23);
            this.IDX.TabIndex = 0;
            this.IDX.UseSelectable = true;
            this.IDX.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.IDX.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(16, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 23);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "번호 :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Mobile
            // 
            // 
            // 
            // 
            this.Mobile.CustomButton.Image = null;
            this.Mobile.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.Mobile.CustomButton.Name = "";
            this.Mobile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Mobile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Mobile.CustomButton.TabIndex = 1;
            this.Mobile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Mobile.CustomButton.UseSelectable = true;
            this.Mobile.CustomButton.Visible = false;
            this.Mobile.Lines = new string[0];
            this.Mobile.Location = new System.Drawing.Point(103, 175);
            this.Mobile.MaxLength = 13;
            this.Mobile.Name = "Mobile";
            this.Mobile.PasswordChar = '\0';
            this.Mobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Mobile.SelectedText = "";
            this.Mobile.SelectionLength = 0;
            this.Mobile.SelectionStart = 0;
            this.Mobile.ShortcutsEnabled = true;
            this.Mobile.Size = new System.Drawing.Size(264, 23);
            this.Mobile.TabIndex = 4;
            this.Mobile.UseSelectable = true;
            this.Mobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Mobile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mobile_KeyPress);
            // 
            // Levels
            // 
            this.Levels.FormattingEnabled = true;
            this.Levels.ItemHeight = 23;
            this.Levels.Location = new System.Drawing.Point(103, 102);
            this.Levels.Name = "Levels";
            this.Levels.Size = new System.Drawing.Size(264, 29);
            this.Levels.TabIndex = 2;
            this.Levels.UseSelectable = true;
            // 
            // UserMngForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserMngForm";
            this.Text = "Books Mng Form";
            this.Load += new System.EventHandler(this.DevMngForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdUserTbl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid GrdUserTbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton BtnCancel;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroTextBox Names;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox IDX;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Email;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox Addr;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox Mobile;
        private MetroFramework.Controls.MetroComboBox Levels;
    }
}