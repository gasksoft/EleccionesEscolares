Imports Elecciones.Bussiness
Imports Elecciones.DataModel

Public Class BuscarAlumnoDlg
    Private ReadOnly _alumnoBussiness As New AlumnoBussiness

    Property Alumno As Alumno

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OK_Button.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        Alumno = _alumnoBussiness.GetAlumnoByDni(BuscarTxt.Text)
        AlumnoBindingSource.DataSource = Alumno
        OK_Button.Enabled = Alumno IsNot Nothing
    End Sub
End Class
