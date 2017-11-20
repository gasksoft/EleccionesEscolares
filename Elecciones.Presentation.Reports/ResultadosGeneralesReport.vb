Imports Elecciones.DataModel

Public Class ResultadosGeneralesReport
    Public Property Votos As List(Of Voto)
    Private Sub ResultadosGeneralesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VotoBindingSource.DataSource = Votos

        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        ReportViewer1.ZoomPercent = 100
        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
    End Sub
End Class