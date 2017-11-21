Imports Elecciones.Bussiness
Imports Elecciones.DataModel

Public Class ListasDlg
    Private ReadOnly _listaBussiness As New ListaBussiness

    Property Lista As Lista

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OK_Button.Click
        _listaBussiness.Guardar
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub ListasDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaBindingSource.DataSource = _listaBussiness.GetListas
    End Sub

    Private Sub ListaDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListaDataGridView.CellDoubleClick
        'Text = e.ColumnIndex & "  " & e.RowIndex
        If e.ColumnIndex = 3 Then
            Using ofd As New OpenFileDialog With {
                .AddExtension = True,
                .CheckFileExists = True,
                .CheckPathExists = True,
                .DefaultExt = "*.jpg",
                .Filter = "Archivos de imagen(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG",
                .Multiselect = False
            }

                If ofd.ShowDialog(Me) = Global.System.Windows.Forms.DialogResult.OK Then
                    Lista.LogoImage = Image.FromFile(ofd.FileName)
                    ListaBindingSource.ResetCurrentItem()
                End If
            End Using
        End If
    End Sub

    Private Sub ListaBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ListaBindingSource.CurrentChanged
        Lista = ListaBindingSource.Current
    End Sub
End Class
