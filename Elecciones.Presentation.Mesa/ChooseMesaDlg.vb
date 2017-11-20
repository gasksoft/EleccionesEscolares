Imports System.Windows.Forms
Imports Elecciones.Bussiness
Imports Elecciones.DataModel

Public Class ChooseMesaDlg
    Private ReadOnly _mesaBussiness As New MesaBussiness
    Public Property Mesa As Mesa

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OK_Button.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ChooseMesaDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MesaBindingSource.DataSource = _mesaBussiness.GetMesas
    End Sub

    Private Sub MesaBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles MesaBindingSource.CurrentChanged
        Mesa = MesaBindingSource.Current
    End Sub
End Class
