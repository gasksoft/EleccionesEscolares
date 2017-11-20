Imports System.ComponentModel
Imports System.Data.Entity.Infrastructure
Imports Elecciones.Bussiness
Imports Elecciones.DataModel

Public Class SeccionesDlg
    Private _gradoBussiness As New GradoBussiness

    Public Property Grado As Grado
    Public Property Seccion As Seccion

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OK_Button.Click
        Try
            _gradoBussiness.GuardarCambios()
        Catch ex As DbUpdateException
            MsgBox(ex.InnerException.InnerException.Message)
        End Try

        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub PadronElectoralDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GradoBindingSource.DataSource = _gradoBussiness.GetGrados
    End Sub

    Private Sub GradoBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles GradoBindingSource.CurrentChanged
        Grado = GradoBindingSource.Current
    End Sub

    Private Sub SeccionBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles SeccionBindingSource.CurrentChanged
        Seccion = SeccionBindingSource.Current
        AlumnosBtn.Enabled = Seccion IsNot Nothing
        MesaBtn.Enabled = AlumnosBtn.Enabled
    End Sub

    Private Sub SeccionDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles SeccionDataGridView.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
        End If
    End Sub

    Private Sub AlumnosBtn_Click(sender As Object, e As EventArgs) Handles AlumnosBtn.Click
        If New AlumnosDlg() With {.Seccion = Seccion}.ShowDialog(Me) = DialogResult.OK Then
            _gradoBussiness.GuardarCambios()
            GradoBindingSource.ResetBindings(True)
        End If
    End Sub

    Private Sub MesaBtn_Click(sender As Object, e As EventArgs) Handles MesaBtn.Click
        Dim dlg = New ChooseMesaDlg() With {.Mesa = Seccion.Mesa}
        If dlg.ShowDialog(Me) = DialogResult.OK Then
            Seccion.IdMesa = dlg.Mesa?.IdMesa
            _gradoBussiness.GuardarCambios()
            GradoBindingSource.ResetCurrentItem()
        End If
    End Sub

    Private Sub SeccionBindingSource_AddingNew(sender As Object, e As AddingNewEventArgs) Handles SeccionBindingSource.AddingNew
        Dim idSeccion As String
        If Grado.Secciones.Any Then
            idSeccion = Chr(Grado.Secciones.Max(Function(x) Asc(x.IdSeccion)) + 1)
        Else
            idSeccion = "A"
        End If
        e.NewObject = New Seccion With {.IdSeccion = idSeccion}
    End Sub
End Class
