Imports System.ComponentModel
Imports Elecciones.Bussiness
Imports Elecciones.DataModel

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
        Using dlg As New Reports.ResultadosGeneralesReport
            dlg.Votos = _procesoBussiness.GetVotos
            dlg.ShowDialog(Me)
        End Using
    End Sub

    Private Sub ReiniciarDatosproceso_Click(sender As Object, e As EventArgs) Handles ReiniciarDatosproceso.Click
        If MsgBox("Desea resetear los datos del proceso???", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2) = MsgBoxResult.No Then Return
        _procesoBussiness.ResetData()
        MsgBox("Datos reseteado: Votos, Miembros de Mesa, Estados de las mesas")
    End Sub

    Private Sub MonitoreoProcesoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim worker As New BackgroundWorker
        Dim mesas As New List(Of Mesa)
        AddHandler worker.DoWork,
            Sub()
                While True
                    mesas = _procesoBussiness.GetMesas
                    worker.ReportProgress(100)
                    Threading.Thread.Sleep(3000)
                End While
            End Sub
        AddHandler worker.ProgressChanged,
            Sub()
                EstadoMesaUc1.Mesa = mesas(0)
                EstadoMesaUc2.Mesa = mesas(1)
                EstadoMesaUc3.Mesa = mesas(2)
                EstadoMesaUc4.Mesa = mesas(3)
                EstadoMesaUc5.Mesa = mesas(4)
                EstadoMesaUc6.Mesa = mesas(5)
            End Sub
        worker.WorkerReportsProgress = True
        worker.RunWorkerAsync()
    End Sub
End Class