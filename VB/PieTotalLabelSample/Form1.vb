Imports DevExpress.XtraCharts
Imports System
Imports System.Windows.Forms

Namespace PieTotalLabelSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
'            #Region "#PieTotalLabel"
            Dim totalLabel As PieTotalLabel = CType(pieChart.Series("Country Areas").View, DoughnutSeriesView).TotalLabel
            totalLabel.Visible = True
            totalLabel.TextPattern = "Total area" & vbLf & "{TV:F2} km" & ChrW(&HB2).ToString()
'            #End Region ' #PieTotalLabel
        End Sub
    End Class
End Namespace
