using DevExpress.XtraCharts;
using System;
using System.Windows.Forms;

namespace PieTotalLabelSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            #region #PieTotalLabel
            PieTotalLabel totalLabel = ((DoughnutSeriesView)pieChart.Series["Country Areas"].View).TotalLabel;
            totalLabel.Visible = true;
            totalLabel.TextPattern = "Total area\n{TV:F2} km\xB2";
            #endregion #PieTotalLabel
        }
    }
}
