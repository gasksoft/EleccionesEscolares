Imports Elecciones.Common
Imports Elecciones.Data
Imports Elecciones.DataModel

Public Class SeccionBussiness
    Private ReadOnly _seccionData As New SeccionData
    Public Function GetSeccionesByGrado(grado As Grado) As ObservableListSource(Of Seccion)
        Return _seccionData.GetSeccionesByGrado(grado.IdNivel, grado.IdGrado)
    End Function

    Public Function GetSecciones() As ObservableListSource(Of Seccion)
        Return _seccionData.GetSecciones
    End Function

    Public Sub GuardarCambios()
        _seccionData.GuardarCambios
    End Sub
End Class
