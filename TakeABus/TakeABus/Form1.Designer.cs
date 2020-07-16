namespace TakeABus
{
    partial class MainFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrom));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GoFirstBus1 = new MetroFramework.Controls.MetroTextBox();
            this.GoFirstBus2 = new MetroFramework.Controls.MetroTextBox();
            this.Button = new MetroFramework.Controls.MetroButton();
            this.GoSecondBus1 = new MetroFramework.Controls.MetroTextBox();
            this.BackFirstBus1 = new MetroFramework.Controls.MetroTextBox();
            this.BackSecondBus1 = new MetroFramework.Controls.MetroTextBox();
            this.BackSecondBus2 = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(23, 63);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(110, 23);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "등교 버스 시간";
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(23, 316);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(110, 23);
            this.metroTile2.TabIndex = 0;
            this.metroTile2.Text = "하교 버스 시간";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "1번째 버스";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "1번째 버스";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "2번째 버스";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "2번째 버스";
            // 
            // GoFirstBus1
            // 
            this.GoFirstBus1.Location = new System.Drawing.Point(78, 114);
            this.GoFirstBus1.Multiline = true;
            this.GoFirstBus1.Name = "GoFirstBus1";
            this.GoFirstBus1.Size = new System.Drawing.Size(518, 50);
            this.GoFirstBus1.TabIndex = 2;
            // 
            // GoFirstBus2
            // 
            this.GoFirstBus2.Location = new System.Drawing.Point(78, 170);
            this.GoFirstBus2.Multiline = true;
            this.GoFirstBus2.Name = "GoFirstBus2";
            this.GoFirstBus2.Size = new System.Drawing.Size(518, 50);
            this.GoFirstBus2.TabIndex = 3;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(521, 63);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 23);
            this.Button.TabIndex = 6;
            this.Button.Text = "새로고침";
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // GoSecondBus1
            // 
            this.GoSecondBus1.Location = new System.Drawing.Point(78, 245);
            this.GoSecondBus1.Multiline = true;
            this.GoSecondBus1.Name = "GoSecondBus1";
            this.GoSecondBus1.Size = new System.Drawing.Size(518, 50);
            this.GoSecondBus1.TabIndex = 3;
            // 
            // BackFirstBus1
            // 
            this.BackFirstBus1.Location = new System.Drawing.Point(78, 370);
            this.BackFirstBus1.Multiline = true;
            this.BackFirstBus1.Name = "BackFirstBus1";
            this.BackFirstBus1.Size = new System.Drawing.Size(518, 50);
            this.BackFirstBus1.TabIndex = 3;
            // 
            // BackSecondBus1
            // 
            this.BackSecondBus1.Location = new System.Drawing.Point(78, 447);
            this.BackSecondBus1.Multiline = true;
            this.BackSecondBus1.Name = "BackSecondBus1";
            this.BackSecondBus1.Size = new System.Drawing.Size(518, 50);
            this.BackSecondBus1.TabIndex = 2;
            // 
            // BackSecondBus2
            // 
            this.BackSecondBus2.Location = new System.Drawing.Point(78, 503);
            this.BackSecondBus2.Multiline = true;
            this.BackSecondBus2.Name = "BackSecondBus2";
            this.BackSecondBus2.Size = new System.Drawing.Size(518, 50);
            this.BackSecondBus2.TabIndex = 3;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.BackFirstBus1);
            this.Controls.Add(this.GoSecondBus1);
            this.Controls.Add(this.BackSecondBus2);
            this.Controls.Add(this.BackSecondBus1);
            this.Controls.Add(this.GoFirstBus2);
            this.Controls.Add(this.GoFirstBus1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrom";
            this.Resizable = false;
            this.Text = "등하교  버스 시간";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox GoFirstBus1;
        private MetroFramework.Controls.MetroTextBox GoFirstBus2;
        private MetroFramework.Controls.MetroButton Button;
        private MetroFramework.Controls.MetroTextBox GoSecondBus1;
        private MetroFramework.Controls.MetroTextBox BackFirstBus1;
        private MetroFramework.Controls.MetroTextBox BackSecondBus1;
        private MetroFramework.Controls.MetroTextBox BackSecondBus2;
    }
}

