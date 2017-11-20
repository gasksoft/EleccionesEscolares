Imports Elecciones.DataModel

Public Class CandidatosReport
    Public Property Lista As Lista

    Private Sub CandidatosReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaBindingSource.DataSource = Lista
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        ReportViewer1.RefreshReport()
    End Sub
End Class