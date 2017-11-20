Imports Elecciones.Common
Imports Elecciones.Data.Contexto
Imports Elecciones.DataModel

Public Class ListaData
    Private _ctx As EleccionesContext = ContextLocator.Instance.Contexto
    Public Function GetListas() As ObservableListSource(Of Lista)
        Return New ObservableListSource(Of Lista)(_ctx.Listas.ToList)
    End Function

    Public Sub Guardar()
        _ctx.SaveChanges()
    End Sub

    Public Sub QuitarCandidato(candidato As Candidato)
        _ctx.Participantes.Remove(candidato)
    End Sub
End Class