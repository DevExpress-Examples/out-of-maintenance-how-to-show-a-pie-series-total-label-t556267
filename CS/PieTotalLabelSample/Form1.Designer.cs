namespace PieTotalLabelSample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel1 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("Russia", new object[] {
            ((object)(17.0752D))}, 0);
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("Canada", new object[] {
            ((object)(9.98467D))}, 1);
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("USA", new object[] {
            ((object)(9.63142D))}, 2);
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("China", new object[] {
            ((object)(9.59696D))}, 3);
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint("Brazil", new object[] {
            ((object)(8.511965D))}, 4);
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint("Australia", new object[] {
            ((object)(7.68685D))}, 5);
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint("India", new object[] {
            ((object)(3.28759D))}, 6);
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint("Others", new object[] {
            ((object)(81.2D))}, 7);
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView1 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.pieChart = new DevExpress.XtraCharts.ChartControl();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChart
            // 
            this.pieChart.DataBindings = null;
            this.pieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart.Legend.Name = "Default Legend";
            this.pieChart.Location = new System.Drawing.Point(0, 0);
            this.pieChart.Name = "pieChart";
            doughnutSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns;
            doughnutSeriesLabel1.TextPattern = "{V:F2} km²";
            series1.Label = doughnutSeriesLabel1;
            series1.LegendTextPattern = "{A}";
            series1.Name = "Country Areas";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5,
            seriesPoint6,
            seriesPoint7,
            seriesPoint8});
            doughnutSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            doughnutSeriesView1.Rotation = 90;
            doughnutSeriesView1.TotalLabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doughnutSeriesView1.TotalLabel.Visible = true;
            series1.View = doughnutSeriesView1;
            this.pieChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.pieChart.Size = new System.Drawing.Size(1264, 681);
            this.pieChart.TabIndex = 0;
            chartTitle1.Text = "Country Areas";
            this.pieChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pieChart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl pieChart;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
    }
}

