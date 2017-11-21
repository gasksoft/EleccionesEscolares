Imports Elecciones.Bussiness
Imports Elecciones.DataModel

Public Class ResultadosEnMesaReport
    'Private ReadOnly _sb As New MesaBussiness
    Property Mesa As Mesa
    'Dim seccion As Seccion
    Dim votos As List(Of Voto)

    Private Sub PadronElectoralReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim mesas = _sb.GetMesas
        'MesaBindingSource.DataSource = mesas
        MesaBindingSource.DataSource = Mesa
        'ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub

    Private Sub MesaBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles MesaBindingSource.CurrentChanged
        mesa = MesaBindingSource.Current
        If mesa Is Nothing Then Return
        votos = New List(Of Voto)
        For Each s In mesa.Secciones
            votos.AddRange(s.Votos)
        Next
        VotoBindingSource.DataSource = votos
        ReportViewer1.RefreshReport()
    End Sub
End Class