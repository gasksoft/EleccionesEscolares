Imports Elecciones.Bussiness

Public Class MonitoreoProcesoForm
    Private _procesoBussiness As New ProcesoBussiness
    Private Sub IniciarProcesoBtn_Click(sender As Object, e As EventArgs) Handles IniciarProcesoBtn.Click
        _procesoBussiness.Iniciar()
        IniciarProcesoBtn.Enabled = False
        TerminarProcesoBtn.Enabled = True
    End Sub

    Private Sub TerminarProcesoBtn_Click(sender As Object, e As EventArgs) Handles TerminarProcesoBtn.Click
        _procesoBussiness.Terminar()
        TerminarProcesoBtn.Enabled = False
        ResultadosBtn.Enabled = True
    End Sub

    Private Sub ResultadosBtn_Click(sender As Object, e As EventArgs) Handles ResultadosBtn.Click
        Dim dlg As New Reports.ResultadosGeneralesReport
        dlg.Votos = _procesoBussiness.GetVotos
        dlg.ShowDialog(Me)
    End Sub
End Class