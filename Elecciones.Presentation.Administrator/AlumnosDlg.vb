Imports Elecciones.Bussiness
Imports Elecciones.DataModel

Public Class AlumnosDlg
    Private _seccionBussiness As New SeccionBussiness
    Private _alumnoBussiness As New AlumnoBussiness
    Private _AlumnoBorrado As Alumno
    Public Property Seccion As Seccion
    Public Property Alumno As Alumno

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OK_Button.Click
        _alumnoBussiness.GuardarCambios()
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub AlumnosDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SeccionBindingSource.DataSource = If(Seccion, _seccionBussiness.GetSecciones)
    End Sub

    Private Sub AlumnosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles AlumnosBindingSource.CurrentChanged
        Alumno = AlumnosBindingSource.Current
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        _AlumnoBorrado = Alumno
        _alumnoBussiness.EliminarAlumno(_AlumnoBorrado)
    End Sub

    Private Sub SeccionBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles SeccionBindingSource.CurrentChanged
        Seccion = SeccionBindingSource.Current
    End Sub

    Private Sub FotoPictureBox_DoubleClick(sender As Object, e As EventArgs) Handles FotoPictureBox.DoubleClick
        Dim ofd As New OpenFileDialog With {
            .AddExtension = True,
            .CheckFileExists = True,
            .CheckPathExists = True,
            .DefaultExt = "*.jpg",
            .Filter = "Archivos de imagen(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG",
            .Multiselect = False
        }

        If ofd.ShowDialog(Me) = Global.System.Windows.Forms.DialogResult.OK Then
            Alumno.Fotografia = Image.FromFile(ofd.FileName)
            AlumnosBindingSource.ResetCurrentItem()
        End If
    End Sub
End Class
