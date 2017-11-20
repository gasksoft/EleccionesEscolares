Imports System.ComponentModel
Imports Elecciones.Bussiness
Imports Elecciones.DataModel

Public Class MainForm
    Private _mesa As Mesa
    Private _estadoPrevio As EEstadoMesa = -1
    Private ReadOnly _mesaBussiness As New MesaBussiness
    Private ReadOnly _alumnoBussiness As New AlumnoBussiness
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
                    Case EEstadoMesa.PorAperturar
                        Dim miembros = _mesa.MiembrosMesa.ToList
                        miembros.Sort(Function(x, y) x.CargoMiembroMesa.CompareTo(y.CargoMiembroMesa))
                        MiembrosMesaBindingSource.DataSource = miembros
                        TabControl1.TabPages.Add(TabPage2)
                        Exit Select
                    Case EEstadoMesa.EnMesa
                        If _mesaBussiness.HayVotantes(_mesa) Then
                            SplitContainer1.Panel2Collapsed = True
                            AcceptButton = BuscarAlumnoBtn
                            TabControl1.TabPages.Add(TabPage3)
                        Else
                            _mesa.Estado = EEstadoMesa.EsperaCierre
                            _mesa.UltimaConexion = Now
                            _mesaBussiness.Guardar()
                        End If
                        Exit Select
                    Case EEstadoMesa.EnCabina
                        If _votante Is Nothing Then
                            _votante = _alumnoBussiness.GetAlumnoByDni(_mesa.UltimoDni)
                            AlumnoBindingSource.DataSource = _votante
                        End If
                        TabControl1.TabPages.Add(TabPage4)
                        Exit Select
                    Case EEstadoMesa.EsperaCierre
                        TabControl1.TabPages.Add(TabPage5)
                        Exit Select
                    Case EEstadoMesa.EnCierre
                        TabControl1.TabPages.Add(TabPage6)
                        Exit Select
                    Case EEstadoMesa.Cerrada
                        TabControl1.TabPages.Add(TabPage7)
                        Exit Select
                End Select
            End Sub
        worker.WorkerReportsProgress = True
        worker.RunWorkerAsync()
    End Sub

    Private Sub ExcluirMiembroMesaBtn_Click(sender As Object, e As EventArgs) Handles ExcluirMiembroMesaBtn.Click
        Dim miembros As List(Of MiembroMesa) = MiembrosMesaBindingSource.DataSource
        If miembros.Count > 3 Then
            If MsgBox("Desea excluir este miebro de mesa? los miembros inferiores seran promovidos", vbYesNo) = MsgBoxResult.Yes Then
                Dim miembro As MiembroMesa = MiembrosMesaBindingSource.Current
                _mesaBussiness.QuitarMiembro(miembro)
                miembros = _mesa.MiembrosMesa.ToList
                miembros.Sort(Function(x, y) x.CargoMiembroMesa.CompareTo(y.CargoMiembroMesa))
                Dim c = 0
                For Each m In miembros
                    m.CargoMiembroMesa = c
                    c += 1
                Next
                _mesaBussiness.Guardar()
                MiembrosMesaBindingSource.DataSource = miembros
            End If
        End If
    End Sub

    Private Sub AperturarMesaBtn_Click(sender As Object, e As EventArgs) Handles AperturarMesaBtn.Click
        Dim miembros = _mesa.MiembrosMesa.Where(Function(x) x.CargoMiembroMesa > ECargoMiembroMesa.Vocal).ToList
        For Each m In miembros.ToList
            _mesaBussiness.QuitarMiembro(m)
        Next
        miembros = _mesa.MiembrosMesa
        miembros.Sort(Function(x, y) x.CargoMiembroMesa.CompareTo(y.CargoMiembroMesa))
        Dim c = 0
        For Each m In miembros
            m.CargoMiembroMesa = c
            c += 1
        Next
        MiembrosMesaBindingSource.DataSource = miembros
        _mesa.Estado = EEstadoMesa.EnMesa
        _mesa.UltimaConexion = Now
        _mesaBussiness.Guardar()
    End Sub

    Private _votante As Alumno
    Private suspenderMonitoreo As Boolean

    Private Sub BuscarAlumnoBtn_Click(sender As Object, e As EventArgs) Handles BuscarAlumnoBtn.Click
        Dim votantes = _mesa.AlumnosVotantes.ToList
        _votante = votantes.Where(Function(x) x.Dni = TextBox1.Text).FirstOrDefault
        If _votante Is Nothing Then
            SplitContainer1.Panel2Collapsed = True
        Else
            _alumnoBussiness.Refrescar(_votante)
            AlumnoBindingSource.DataSource = _votante
            AlumnoBindingSource.ResetBindings(True)
            SplitContainer1.Panel1Collapsed = True
            PaseCAbinaVotacionBtn.Enabled = Not _votante.YaVoto
        End If
    End Sub

    Private Sub PaseCAbinaVotacionBtn_Click(sender As Object, e As EventArgs) Handles PaseCAbinaVotacionBtn.Click
        _mesa.Estado = EEstadoMesa.EnCabina
        _mesa.UltimoDni = _votante.Dni
        _mesa.UltimaConexion = Now
        _mesaBussiness.Guardar()
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Alt AndAlso e.Control AndAlso e.Shift AndAlso e.KeyValue = 77 Then
            ModificarMesa()
        End If
    End Sub

    Private Sub VerConteoVotosMesaBtn_Click(sender As Object, e As EventArgs) Handles VerConteoVotosMesaBtn.Click
        Dim dlg As New Reports.ResultadosEnMesaReport
        suspenderMonitoreo = True
        dlg.Mesa = _mesa
        dlg.ShowDialog(Me)
        suspenderMonitoreo = False
    End Sub

    Private Sub CerrarMesaBtn_Click(sender As Object, e As EventArgs) Handles CerrarMesaBtn.Click
        If MsgBox("Desea cerrar la mesa?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
            _mesa.Estado = EEstadoMesa.Cerrada
            _mesa.UltimaConexion = Now
            _mesaBussiness.Guardar()
        End If
    End Sub
End Class
