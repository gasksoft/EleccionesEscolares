Imports System.ComponentModel
Imports System.Threading
Imports Elecciones.Bussiness
Imports Elecciones.Presentation.CommonWinForm

Public Class MainForm
    Private _suspenderContadores As Boolean
    Private Sub SeccionesBtn_Click(sender As Object, e As EventArgs) Handles SeccionesBtn.Click
        Call New SeccionesDlg().ShowDialog(Me)
    End Sub

    Private Sub AlumnosBtn_Click(sender As Object, e As EventArgs) Handles AlumnosBtn.Click
        Call New AlumnosDlg().ShowDialog(Me)
    End Sub

    Private Sub ListasBtn_Click(sender As Object, e As EventArgs) Handles ListasBtn.Click
        Call New ListasDlg().ShowDialog(Me)
    End Sub

    Private Sub CandidatosBtn_Click(sender As Object, e As EventArgs) Handles CandidatosBtn.Click
        Call New CandidatosDlg().ShowDialog(Me)
    End Sub

    Private Sub MiembrosMesaBtn_Click(sender As Object, e As EventArgs) Handles MiembrosMesaBtn.Click
        Call New MiembrosMesaDlg().ShowDialog(Me)
    End Sub

    Private Sub PadronBtn_Click(sender As Object, e As EventArgs) Handles PadronBtn.Click
        Call New Reports.PadronElectoralReport().ShowDialog(Me)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Dim dlg = New Reports.ResultadosGeneralesReport()
            'dlg.Votos = New ProcesoBussiness().GetVotos
            'dlg.ShowDialog()
            'End
            CounterRefresh()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub CounterRefresh()
        Dim worker As New BackgroundWorker
        AddHandler worker.DoWork,
            Sub()
                While Not worker.CancellationPending
                    If Not _suspenderContadores Then worker.ReportProgress(100)
                    Thread.Sleep(2500)
                End While
            End Sub
        AddHandler worker.ProgressChanged,
            Sub()
                Dim countersBussiness As New CountersBussiness
                UpdateControlCounter(DashBoardItemUc1, countersBussiness.GetCountSecciones)
                UpdateControlCounter(DashBoardItemUc2, countersBussiness.GetCountAlumnos)
                UpdateControlCounter(DashBoardItemUc3, countersBussiness.GetCountMesas)
                UpdateControlCounter(DashBoardItemUc5, countersBussiness.GetCountListas)
                UpdateControlCounter(DashBoardItemUc6, countersBussiness.GetCountCandidatos)
                UpdateControlCounter(DashBoardItemUc4, countersBussiness.GetCountMiembrosMesa)
                'UpdateControlCounter(PadronElectoralMt, New AlumnoBussinessService().GetCountPadron)
            End Sub
        worker.WorkerReportsProgress = True
        worker.RunWorkerAsync()
    End Sub

    Private Sub UpdateControlCounter(control As DashBoardItemUc, value As Integer)
        control.Valor = value
        control.Invalidate()
    End Sub

    Private Sub ReadPhotosBtn_Click(sender As Object, e As EventArgs) Handles ReadPhotosBtn.Click
        _suspenderContadores = True
        Call New LeerFotosForm().ShowDialog(Me)
        _suspenderContadores = False
    End Sub

    Private Sub FindAlumnByDniBtn_Click(sender As Object, e As EventArgs) Handles FindAlumnByDniBtn.Click
        Call New BuscarAlumnoDlg().ShowDialog(Me)
    End Sub

    Private Sub MonitoreoProcesoBtn_Click(sender As Object, e As EventArgs) Handles MonitoreoProcesoBtn.Click
        Call New MonitoreoProcesoForm().ShowDialog(Me)
    End Sub
End Class