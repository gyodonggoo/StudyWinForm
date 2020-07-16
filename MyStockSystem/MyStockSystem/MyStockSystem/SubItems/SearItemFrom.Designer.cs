namespace MyStockSystem.SubItems
{
    partial class SearItemFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearItemFrom));
            this.MtlSearchWeb = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TxtSearchItem = new MetroFramework.Controls.MetroTextBox();
            this.SearchButton = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.DgvSearchItem = new System.Windows.Forms.DataGridView();
            this.isin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korSecnNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secnKacdNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shotnIsin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchItem)).BeginInit();
            this.SuspendLayout();
            // 
            // MtlSearchWeb
            // 
            this.MtlSearchWeb.Location = new System.Drawing.Point(1192, 657);
            this.MtlSearchWeb.Name = "MtlSearchWeb";
            this.MtlSearchWeb.Size = new System.Drawing.Size(65, 40);
            this.MtlSearchWeb.TabIndex = 1;
            this.MtlSearchWeb.TileImage = global::MyStockSystem.Properties.Resources.back2;
            this.MtlSearchWeb.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlSearchWeb.UseTileImage = true;
            this.MtlSearchWeb.Click += new System.EventHandler(this.MtlSearchWeb_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1234, 588);
            this.metroTabControl1.TabIndex = 2;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.splitContainer1);
            this.metroTabPage1.Font = new System.Drawing.Font("나눔고딕코딩", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1226, 548);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "주식 기초정보 수집";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TxtSearchItem);
            this.splitContainer1.Panel1.Controls.Add(this.SearchButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgvSearchItem);
            this.splitContainer1.Size = new System.Drawing.Size(1226, 548);
            this.splitContainer1.SplitterDistance = 51;
            this.splitContainer1.TabIndex = 2;
            // 
            // TxtSearchItem
            // 
            this.TxtSearchItem.Location = new System.Drawing.Point(833, 4);
            this.TxtSearchItem.Name = "TxtSearchItem";
            this.TxtSearchItem.Size = new System.Drawing.Size(284, 44);
            this.TxtSearchItem.TabIndex = 1;
            this.TxtSearchItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchItem_KeyPress);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(1123, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 44);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "metroButton1";
            this.SearchButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Font = new System.Drawing.Font("나눔고딕코딩", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1226, 548);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "해당 정보 수집";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // DgvSearchItem
            // 
            this.DgvSearchItem.AllowUserToAddRows = false;
            this.DgvSearchItem.AllowUserToDeleteRows = false;
            this.DgvSearchItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSearchItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isin,
            this.issuDt,
            this.korSecnNm,
            this.secnKacdNm,
            this.shotnIsin});
            this.DgvSearchItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSearchItem.Location = new System.Drawing.Point(0, 0);
            this.DgvSearchItem.Name = "DgvSearchItem";
            this.DgvSearchItem.RowTemplate.Height = 23;
            this.DgvSearchItem.Size = new System.Drawing.Size(1226, 493);
            this.DgvSearchItem.TabIndex = 0;
            // 
            // isin
            // 
            this.isin.HeaderText = "표준코드";
            this.isin.Name = "isin";
            this.isin.Width = 150;
            // 
            // issuDt
            // 
            this.issuDt.HeaderText = "주식발행일자";
            this.issuDt.Name = "issuDt";
            this.issuDt.Width = 150;
            // 
            // korSecnNm
            // 
            this.korSecnNm.HeaderText = "한글종목명";
            this.korSecnNm.Name = "korSecnNm";
            this.korSecnNm.Width = 150;
            // 
            // secnKacdNm
            // 
            this.secnKacdNm.HeaderText = "보통주/우선주";
            this.secnKacdNm.Name = "secnKacdNm";
            this.secnKacdNm.Width = 150;
            // 
            // shotnIsin
            // 
            this.shotnIsin.HeaderText = "단축코드";
            this.shotnIsin.Name = "shotnIsin";
            this.shotnIsin.Width = 150;
            // 
            // SearItemFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.MtlSearchWeb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearItemFrom";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "주식정보 검색";
            this.Load += new System.EventHandler(this.SearItemFrom_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile MtlSearchWeb;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroButton SearchButton;
        private MetroFramework.Controls.MetroTextBox TxtSearchItem;
        private System.Windows.Forms.DataGridView DgvSearchItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn isin;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn korSecnNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn secnKacdNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn shotnIsin;
    }
}