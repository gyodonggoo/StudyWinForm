namespace ChartTestApp
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.BtnYValues = new MetroFramework.Controls.MetroButton();
            this.BtnXValues = new MetroFramework.Controls.MetroButton();
            this.BtnDataBind = new MetroFramework.Controls.MetroButton();
            this.MultiChart = new MetroFramework.Controls.MetroButton();
            this.BtnDBBind = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 63);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Score";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1034, 634);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.BtnDBBind);
            this.metroPanel1.Controls.Add(this.MultiChart);
            this.metroPanel1.Controls.Add(this.BtnDataBind);
            this.metroPanel1.Controls.Add(this.BtnXValues);
            this.metroPanel1.Controls.Add(this.BtnYValues);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1063, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(194, 634);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // BtnYValues
            // 
            this.BtnYValues.Location = new System.Drawing.Point(19, 3);
            this.BtnYValues.Name = "BtnYValues";
            this.BtnYValues.Size = new System.Drawing.Size(156, 65);
            this.BtnYValues.TabIndex = 2;
            this.BtnYValues.Text = "Only Y Values";
            this.BtnYValues.UseSelectable = true;
            this.BtnYValues.Click += new System.EventHandler(this.BtnYValues_Click);
            // 
            // BtnXValues
            // 
            this.BtnXValues.Location = new System.Drawing.Point(19, 74);
            this.BtnXValues.Name = "BtnXValues";
            this.BtnXValues.Size = new System.Drawing.Size(156, 65);
            this.BtnXValues.TabIndex = 2;
            this.BtnXValues.Text = "XY Values";
            this.BtnXValues.UseSelectable = true;
            this.BtnXValues.Click += new System.EventHandler(this.BtnXValues_Click);
            // 
            // BtnDataBind
            // 
            this.BtnDataBind.Location = new System.Drawing.Point(19, 145);
            this.BtnDataBind.Name = "BtnDataBind";
            this.BtnDataBind.Size = new System.Drawing.Size(156, 65);
            this.BtnDataBind.TabIndex = 2;
            this.BtnDataBind.Text = "Data Bind";
            this.BtnDataBind.UseSelectable = true;
            this.BtnDataBind.Click += new System.EventHandler(this.BtnDataBind_Click);
            // 
            // MultiChart
            // 
            this.MultiChart.Location = new System.Drawing.Point(19, 216);
            this.MultiChart.Name = "MultiChart";
            this.MultiChart.Size = new System.Drawing.Size(156, 65);
            this.MultiChart.TabIndex = 2;
            this.MultiChart.Text = "Multi Chart";
            this.MultiChart.UseSelectable = true;
            this.MultiChart.Click += new System.EventHandler(this.MultiChart_Click);
            // 
            // BtnDBBind
            // 
            this.BtnDBBind.Location = new System.Drawing.Point(19, 287);
            this.BtnDBBind.Name = "BtnDBBind";
            this.BtnDBBind.Size = new System.Drawing.Size(156, 65);
            this.BtnDBBind.TabIndex = 2;
            this.BtnDBBind.Text = "DB Bind";
            this.BtnDBBind.UseSelectable = true;
            this.BtnDBBind.Click += new System.EventHandler(this.BtnDBBind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Chart Test App";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton BtnXValues;
        private MetroFramework.Controls.MetroButton BtnYValues;
        private MetroFramework.Controls.MetroButton BtnDataBind;
        private MetroFramework.Controls.MetroButton MultiChart;
        private MetroFramework.Controls.MetroButton BtnDBBind;
    }
}

