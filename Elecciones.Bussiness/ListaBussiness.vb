Imports Elecciones.Common
Imports Elecciones.Data
Imports Elecciones.DataModel
Public Class ListaBussiness
    Private ReadOnly _listaData As New ListaData
    Public Function GetListas() As ObservableListSource(Of Lista)
        Return _listaData.GetListas
    End Function

    Public Sub Guardar()
        _listaData.Guardar
    End Sub

    Public Sub QuitarCandidato(candidato As Candidato)
        _listaData.QuitarCandidato(candidato)
    End Sub
End Class
