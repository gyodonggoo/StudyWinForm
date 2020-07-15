namespace BookRentalShop.SubItems
{
    partial class BooksMngForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksMngForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdBooksTbl = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.BtmDelete = new MetroFramework.Controls.MetroButton();
            this.Author = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.IDX = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Names = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.Isbn = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.Price = new MetroFramework.Controls.MetroTextBox();
            this.Divistion = new MetroFramework.Controls.MetroComboBox();
            this.DateRelease = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdBooksTbl)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.GrdBooksTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(760, 370);
            this.splitContainer1.SplitterDistance = 373;
            this.splitContainer1.TabIndex = 0;
            // 
            // GrdBooksTbl
            // 
            this.GrdBooksTbl.AllowUserToResizeRows = false;
            this.GrdBooksTbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.GrdBooksTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdBooksTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdBooksTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdBooksTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdBooksTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdBooksTbl.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrdBooksTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdBooksTbl.EnableHeadersVisualStyles = false;
            this.GrdBooksTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdBooksTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdBooksTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdBooksTbl.Name = "GrdBooksTbl";
            this.GrdBooksTbl.ReadOnly = true;
            this.GrdBooksTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdBooksTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrdBooksTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdBooksTbl.RowTemplate.Height = 23;
            this.GrdBooksTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdBooksTbl.Size = new System.Drawing.Size(373, 370);
            this.GrdBooksTbl.TabIndex = 0;
            this.GrdBooksTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrbDevTbl_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DateRelease);
            this.groupBox1.Controls.Add(this.Divistion);
            this.groupBox1.Controls.Add(this.BtnCancel);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.BtmDelete);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.Isbn);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.Names);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.Author);
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
            this.BtnCancel.TabIndex = 5;
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
            this.BtnNew.TabIndex = 3;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtmDelete
            // 
            this.BtmDelete.Location = new System.Drawing.Point(16, 308);
            this.BtmDelete.Name = "BtmDelete";
            this.BtmDelete.Size = new System.Drawing.Size(75, 23);
            this.BtmDelete.TabIndex = 2;
            this.BtmDelete.Text = "삭제";
            this.BtmDelete.UseSelectable = true;
            this.BtmDelete.Click += new System.EventHandler(this.BtmDelete_Click);
            // 
            // Author
            // 
            // 
            // 
            // 
            this.Author.CustomButton.Image = null;
            this.Author.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.Author.CustomButton.Name = "";
            this.Author.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Author.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Author.CustomButton.TabIndex = 1;
            this.Author.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Author.CustomButton.UseSelectable = true;
            this.Author.CustomButton.Visible = false;
            this.Author.Lines = new string[0];
            this.Author.Location = new System.Drawing.Point(103, 69);
            this.Author.MaxLength = 45;
            this.Author.Name = "Author";
            this.Author.PasswordChar = '\0';
            this.Author.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Author.SelectedText = "";
            this.Author.SelectionLength = 0;
            this.Author.SelectionStart = 0;
            this.Author.ShortcutsEnabled = true;
            this.Author.Size = new System.Drawing.Size(264, 23);
            this.Author.TabIndex = 1;
            this.Author.UseSelectable = true;
            this.Author.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Author.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(16, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "저자명 :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(16, 104);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 23);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "장르 :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(16, 140);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "이름 :";
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
            this.Names.Location = new System.Drawing.Point(103, 140);
            this.Names.MaxLength = 100;
            this.Names.Name = "Names";
            this.Names.PasswordChar = '\0';
            this.Names.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Names.SelectedText = "";
            this.Names.SelectionLength = 0;
            this.Names.SelectionStart = 0;
            this.Names.ShortcutsEnabled = true;
            this.Names.Size = new System.Drawing.Size(264, 23);
            this.Names.TabIndex = 3;
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
            this.metroLabel5.Text = "출간일 :";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(16, 211);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(81, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "ISBN :";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Isbn
            // 
            // 
            // 
            // 
            this.Isbn.CustomButton.Image = null;
            this.Isbn.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.Isbn.CustomButton.Name = "";
            this.Isbn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Isbn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Isbn.CustomButton.TabIndex = 1;
            this.Isbn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Isbn.CustomButton.UseSelectable = true;
            this.Isbn.CustomButton.Visible = false;
            this.Isbn.Lines = new string[0];
            this.Isbn.Location = new System.Drawing.Point(103, 211);
            this.Isbn.MaxLength = 200;
            this.Isbn.Name = "Isbn";
            this.Isbn.PasswordChar = '\0';
            this.Isbn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Isbn.SelectedText = "";
            this.Isbn.SelectionLength = 0;
            this.Isbn.SelectionStart = 0;
            this.Isbn.ShortcutsEnabled = true;
            this.Isbn.Size = new System.Drawing.Size(264, 23);
            this.Isbn.TabIndex = 5;
            this.Isbn.UseSelectable = true;
            this.Isbn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Isbn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Location = new System.Drawing.Point(16, 247);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(81, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "가격 :";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Price
            // 
            // 
            // 
            // 
            this.Price.CustomButton.Image = null;
            this.Price.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.Price.CustomButton.Name = "";
            this.Price.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Price.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Price.CustomButton.TabIndex = 1;
            this.Price.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Price.CustomButton.UseSelectable = true;
            this.Price.CustomButton.Visible = false;
            this.Price.Lines = new string[0];
            this.Price.Location = new System.Drawing.Point(103, 247);
            this.Price.MaxLength = 45;
            this.Price.Name = "Price";
            this.Price.PasswordChar = '\0';
            this.Price.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Price.SelectedText = "";
            this.Price.SelectionLength = 0;
            this.Price.SelectionStart = 0;
            this.Price.ShortcutsEnabled = true;
            this.Price.Size = new System.Drawing.Size(264, 23);
            this.Price.TabIndex = 6;
            this.Price.UseSelectable = true;
            this.Price.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Price.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Divistion
            // 
            this.Divistion.FormattingEnabled = true;
            this.Divistion.ItemHeight = 23;
            this.Divistion.Location = new System.Drawing.Point(103, 102);
            this.Divistion.Name = "Divistion";
            this.Divistion.Size = new System.Drawing.Size(264, 29);
            this.Divistion.TabIndex = 2;
            this.Divistion.UseSelectable = true;
            this.Divistion.SelectedIndexChanged += new System.EventHandler(this.Divistion_SelectedIndexChanged);
            // 
            // DateRelease
            // 
            this.DateRelease.FormattingEnabled = true;
            this.DateRelease.ItemHeight = 23;
            this.DateRelease.Location = new System.Drawing.Point(103, 172);
            this.DateRelease.Name = "DateRelease";
            this.DateRelease.Size = new System.Drawing.Size(264, 29);
            this.DateRelease.TabIndex = 4;
            this.DateRelease.UseSelectable = true;
            // 
            // BooksMngForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BooksMngForm";
            this.Text = "Books Mng Form";
            this.Load += new System.EventHandler(this.DevMngForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdBooksTbl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid GrdBooksTbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton BtnCancel;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroButton BtmDelete;
        private MetroFramework.Controls.MetroTextBox Author;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox IDX;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox DateRelease;
        private MetroFramework.Controls.MetroComboBox Divistion;
        private MetroFramework.Controls.MetroTextBox Price;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox Isbn;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox Names;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}