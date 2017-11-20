Imports Elecciones.Common
Imports Elecciones.Data.Contexto
Imports Elecciones.DataModel

Public Class SeccionData
    Private _ctx As EleccionesContext = ContextLocator.Instance.Contexto
    Public Function GetSeccionesByGrado(idNivel As ENivel, idGrado As Integer) As ObservableListSource(Of Seccion)
        Return New ObservableListSource(Of Seccion)((From s In _ctx.Secciones Where s.IdNivel = idNivel And s.IdGrado = idGrado Order By s.IdSeccion).ToList)
    End Function

    Public Function GetSecciones() As ObservableListSource(Of Seccion)
        Return New ObservableListSource(Of Seccion)((From s In _ctx.Secciones Order By s.IdNivel, s.IdGrado, s.IdSeccion).ToList)
    End Function

    Public Sub GuardarCambios()
        _ctx.SaveChanges()
    End Sub
End Class
