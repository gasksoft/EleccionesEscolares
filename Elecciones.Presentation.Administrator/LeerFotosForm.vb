Imports System.ComponentModel
Imports Elecciones.Bussiness
Imports Elecciones.DataModel

Public Class LeerFotosForm
    ReadOnly _alumnoBussiness As New AlumnoBussiness
    Dim _strImagenes As New List(Of String)
    Dim _alumnos As Dictionary(Of String, Alumno)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog(Me) = DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
            _strImagenes = IO.Directory.GetFiles(TextBox1.Text, "*.jpg", IO.SearchOption.AllDirectories).ToList
            DashBoardItemUc1.Valor = _strImagenes.Count
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _alumnos = _alumnoBussiness.GetAlumnos
        Dim worker As New BackgroundWorker
        worker.WorkerReportsProgress = True
        AddHandler worker.ProgressChanged, AddressOf WorkerNextImage
        AddHandler worker.RunWorkerCompleted, AddressOf WorkerCompleted
        AddHandler worker.DoWork, AddressOf ProcesaImagenes
        TextBox2.Text = ""
        DashBoardItemUc2.Valor = 0
        DashBoardItemUc3.Valor = 0
        DashBoardItemUc6.Valor = 0
        DashBoardItemUc4.Valor = _alumnos.Count
        DashBoardItemUc7.Valor = _alumnos.Where(Function(x) x.Value.Foto Is Nothing).Count
        worker.RunWorkerAsync()
    End Sub

    Private cuentaAvance As Integer
    Private totalImagenes As Integer
    Private Sub ProcesaImagenes(sender As Object, e As DoWorkEventArgs)
        Dim w As BackgroundWorker = sender
        totalImagenes = _strImagenes.Count

        For cuentaAvance = 0 To totalImagenes - 1
            Dim rutaImagen = _strImagenes(cuentaAvance)
            Dim dni = IO.Path.GetFileNameWithoutExtension(rutaImagen)
            Dim alumno As Alumno = Nothing
            _alumnos.TryGetValue(dni, alumno)
            If alumno IsNot Nothing Then
                Using img = Image.FromFile(rutaImagen)
                    alumno.Fotografia = img.Clone
                End Using
                w.ReportProgress(100 * cuentaAvance / _strImagenes.Count)
            Else
                w.ReportProgress(100 * cuentaAvance / _strImagenes.Count, IO.Path.GetFileName(rutaImagen))
            End If

        Next
    End Sub

    Private Sub WorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        TextBox2.Text = $"{TextBox2.Text}Guardando datos, espere....{vbCrLf}"
        _alumnoBussiness.GuardarCambios()
        TextBox2.Text = $"{TextBox2.Text}A continuación la lista de DNI sin fotografia:{vbCrLf}"
        For Each a In _alumnos.Where(Function(x) x.Value.Foto Is Nothing).ToList
            TextBox2.Text = $"{TextBox2.Text}{a.Key}{vbCrLf}"
        Next
        MsgBox("Proceso Terminado!")
    End Sub

    Private Sub WorkerNextImage(sender As Object, e As ProgressChangedEventArgs)
        ProgressBar1.Value = 100 * cuentaAvance / totalImagenes
        If e.UserState IsNot Nothing Then
            TextBox2.Text = $"{TextBox2.Text}{e.UserState} : No se encontro equivalencia{vbCrLf}"
            DashBoardItemUc6.Valor += 1
        Else
            DashBoardItemUc2.Valor += 1
        End If
        DashBoardItemUc3.Valor = cuentaAvance / totalImagenes
        DashBoardItemUc7.Valor = _alumnos.Where(Function(x) x.Value.Foto Is Nothing).Count
    End Sub
End Class