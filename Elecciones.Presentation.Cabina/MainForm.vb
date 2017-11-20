Imports System.ComponentModel
Imports Elecciones.Bussiness
Imports Elecciones.DataModel

Public Class MainForm
    Private _mesa As Mesa
    Private _estadoPrevio As EEstadoMesa = -1
    Private ReadOnly _mesaBussiness As New MesaBussiness
    Private ReadOnly _alumnoBussiness As New AlumnoBussiness
    Private ReadOnly _listaBussiness As New ListaBussiness
    Private ReadOnly _votoBussiness As New VotoBussiness
    Sub New()
        InitializeComponent()
        WindowState = FormWindowState.Normal
        FormBorderStyle = FormBorderStyle.None
        Bounds = Screen.PrimaryScreen.Bounds
    End Sub

    Private Sub ModificarMesa()
        If ChooseMesaDlg.ShowDialog(Me) = DialogResult.OK Then
            My.MySettings.Default.IdMesa = ChooseMesaDlg.Mesa?.IdMesa
            My.MySettings.Default.Save()
            MsgBox("Variable configurada!!! Vuelva a iniciar el programa")
            End
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.MySettings.Default.IdMesa < 1 Then ModificarMesa()
        Label3.Text = $"MESA {My.MySettings.Default.IdMesa:0000}"

        Dim listas = _listaBussiness.GetListas
        Cand1Btn.Image = listas(0).LogoImage
        Cand2Btn.Image = listas(1).LogoImage
        Cand3Btn.Image = listas(2).LogoImage
        Cand1Btn.Text = listas(0).NombreLista
        Cand2Btn.Text = listas(1).NombreLista
        Cand3Btn.Text = listas(2).NombreLista

        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage1)
        Dim worker As New BackgroundWorker
        AddHandler worker.DoWork,
            Sub()
                While True
                    If suspenderMonitoreo Then Continue While
                    _mesa = _mesaBussiness.GetMesaById(My.MySettings.Default.IdMesa)
                    If _mesa.Estado <> _estadoPrevio Then
                        _estadoPrevio = _mesa.Estado
                        worker.ReportProgress(100)
                    End If
                    Threading.Thread.Sleep(3000)
                End While
            End Sub
        AddHandler worker.ProgressChanged,
            Sub()
                TabControl1.TabPages.Clear()
                Select Case _mesa.Estado
                    Case EEstadoMesa.PorIniciarProceso
                        TabControl1.TabPages.Add(TabPage1)
                        Exit Select
                    Case EEstadoMesa.EnCabina
                        _votante = _alumnoBussiness.GetAlumnoByDni(_mesa.UltimoDni)
                        Label6.Text = _votante.ApellidosNombres
                        TabControl1.TabPages.Add(TabPage3)
                        Exit Select
                    Case EEstadoMesa.Cerrada
                        TabControl1.TabPages.Add(TabPage7)
                        Exit Select
                    Case Else
                        TabControl1.TabPages.Add(TabPage2)
                        Exit Select
                End Select
            End Sub
        worker.WorkerReportsProgress = True
        worker.RunWorkerAsync()
    End Sub


    Private _votante As Alumno
    Private suspenderMonitoreo As Boolean

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Alt AndAlso e.Control AndAlso e.Shift AndAlso e.KeyValue = 77 Then
            ModificarMesa()
        End If
    End Sub

    Private Sub Cand1Btn_Click(sender As Object, e As EventArgs) Handles Cand1Btn.Click, Cand2Btn.Click, Cand3Btn.Click
        Dim btn As Button = sender
        If MsgBox("Estas seguro de votar por " & btn.Text, MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1) = MsgBoxResult.Yes Then
            Dim idLista As Integer = btn.Tag
            _votoBussiness.Votar(_votante.IdNivel, _votante.IdGrado, _votante.IdSeccion, idLista)
            _mesa.Estado = EEstadoMesa.EnMesa
            _mesa.UltimaConexion = Now
            _votante.YaVoto = True
            _mesaBussiness.Guardar()
            TabControl1.TabPages.Clear()
        End If
    End Sub
End Class
