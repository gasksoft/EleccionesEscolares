Imports Elecciones.Data
Imports Elecciones.DataModel

Public Class ProcesoBussiness
    Private _procesoData As New ProcesoData
    Public Sub Iniciar()
        _procesoData.Iniciar
    End Sub

    Public Sub Terminar()
        _procesoData.Terminar
    End Sub

    Public Function GetVotos() As List(Of Voto)
        Return _procesoData.GetVotos
    End Function
End Class
