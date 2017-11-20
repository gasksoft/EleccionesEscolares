Imports Elecciones.Bussiness
Imports Elecciones.DataModel

Public Class ChooseMesaDlg
    Private ReadOnly _mesaBussiness As New MesaBussiness
    Private _cargando As Boolean

    Property Mesa As Mesa

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OK_Button.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub ChooseMesaDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _cargando = True
        Dim mesas = _mesaBussiness.GetMesas
        MesaBindingSource.DataSource = mesas
        If Mesa Is Nothing Then
            _cargando = False
            MesaBindingSource.MoveFirst()
            Mesa = MesaBindingSource.Current
            Return
        Else
            Dim idx = mesas.IndexOf(Mesa)
            _cargando = False
            MesaBindingSource.Position = idx
        End If
    End Sub

    Private Sub MesaBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles MesaBindingSource.CurrentChanged
        If _cargando Then Return
        Mesa = MesaBindingSource.Current
    End Sub
End Class
