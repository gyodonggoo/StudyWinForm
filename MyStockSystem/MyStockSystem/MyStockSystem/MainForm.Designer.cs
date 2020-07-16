namespace MyStockSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MtlStockAnal = new MetroFramework.Controls.MetroTile();
            this.MtlImvestSimuls = new MetroFramework.Controls.MetroTile();
            this.MtlSearchItem = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // MtlStockAnal
            // 
            this.MtlStockAnal.Location = new System.Drawing.Point(329, 63);
            this.MtlStockAnal.Name = "MtlStockAnal";
            this.MtlStockAnal.Size = new System.Drawing.Size(150, 150);
            this.MtlStockAnal.Style = MetroFramework.MetroColorStyle.Orange;
            this.MtlStockAnal.TabIndex = 0;
            this.MtlStockAnal.Text = "주식 정보 분석";
            this.MtlStockAnal.TileImage = global::MyStockSystem.Properties.Resources.analysis2;
            this.MtlStockAnal.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlStockAnal.UseTileImage = true;
            // 
            // MtlImvestSimuls
            // 
            this.MtlImvestSimuls.Location = new System.Drawing.Point(329, 219);
            this.MtlImvestSimuls.Name = "MtlImvestSimuls";
            this.MtlImvestSimuls.Size = new System.Drawing.Size(300, 150);
            this.MtlImvestSimuls.Style = MetroFramework.MetroColorStyle.Green;
            this.MtlImvestSimuls.TabIndex = 0;
            this.MtlImvestSimuls.Text = "투자 시뮬레이션";
            this.MtlImvestSimuls.TileImage = global::MyStockSystem.Properties.Resources.simulator21;
            this.MtlImvestSimuls.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlImvestSimuls.UseTileImage = true;
            // 
            // MtlSearchItem
            // 
            this.MtlSearchItem.Location = new System.Drawing.Point(23, 63);
            this.MtlSearchItem.Name = "MtlSearchItem";
            this.MtlSearchItem.Size = new System.Drawing.Size(300, 150);
            this.MtlSearchItem.TabIndex = 0;
            this.MtlSearchItem.Text = "주식 정보 검색";
            this.MtlSearchItem.TileImage = global::MyStockSystem.Properties.Resources.marketing2;
            this.MtlSearchItem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlSearchItem.UseTileImage = true;
            this.MtlSearchItem.Click += new System.EventHandler(this.MtlSearchItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.MtlStockAnal);
            this.Controls.Add(this.MtlImvestSimuls);
            this.Controls.Add(this.MtlSearchItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "주식분석 시스템";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile MtlSearchItem;
        private MetroFramework.Controls.MetroTile MtlStockAnal;
        private MetroFramework.Controls.MetroTile MtlImvestSimuls;
    }
}

