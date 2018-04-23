Namespace PieTotalLabelSample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim doughnutSeriesLabel1 As New DevExpress.XtraCharts.DoughnutSeriesLabel()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("Russia", New Object() { (CObj(17.0752R))}, 0)
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("Canada", New Object() { (CObj(9.98467R))}, 1)
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("USA", New Object() { (CObj(9.63142R))}, 2)
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("China", New Object() { (CObj(9.59696R))}, 3)
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("Brazil", New Object() { (CObj(8.511965R))}, 4)
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("Australia", New Object() { (CObj(7.68685R))}, 5)
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("India", New Object() { (CObj(3.28759R))}, 6)
            Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("Others", New Object() { (CObj(81.2R))}, 7)
            Dim doughnutSeriesView1 As New DevExpress.XtraCharts.DoughnutSeriesView()
            Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
            Me.pieChart = New DevExpress.XtraCharts.ChartControl()
            Me.defaultLookAndFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            CType(Me.pieChart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(doughnutSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(doughnutSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pieChart
            ' 
            Me.pieChart.DataBindings = Nothing
            Me.pieChart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pieChart.Legend.Name = "Default Legend"
            Me.pieChart.Location = New System.Drawing.Point(0, 0)
            Me.pieChart.Name = "pieChart"
            doughnutSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns
            doughnutSeriesLabel1.TextPattern = "{V:F2} km²"
            series1.Label = doughnutSeriesLabel1
            series1.LegendTextPattern = "{A}"
            series1.Name = "Country Areas"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8})
            doughnutSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
            doughnutSeriesView1.Rotation = 90
            doughnutSeriesView1.TotalLabel.Font = New System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            doughnutSeriesView1.TotalLabel.Visible = True
            series1.View = doughnutSeriesView1
            Me.pieChart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.pieChart.Size = New System.Drawing.Size(1264, 681)
            Me.pieChart.TabIndex = 0
            chartTitle1.Text = "Country Areas"
            Me.pieChart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
            ' 
            ' defaultLookAndFeel
            ' 
            Me.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1264, 681)
            Me.Controls.Add(Me.pieChart)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(doughnutSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(doughnutSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pieChart, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private pieChart As DevExpress.XtraCharts.ChartControl
        Private defaultLookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

