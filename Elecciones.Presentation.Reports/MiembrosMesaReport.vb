Imports Elecciones.DataModel

Public Class MiembrosMesaReport
    Public Property Mesa As Mesa
    Private Sub MiembrosMesaReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MesaBindingSource.DataSource = Mesa
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
End Class