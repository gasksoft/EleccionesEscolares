Imports Elecciones.Common
Imports Elecciones.Data
Imports Elecciones.DataModel

Public Class MesaBussiness
    Private _mesaData As New MesaData
    Public Function GetMesas() As ObservableListSource(Of Mesa)
        Return _mesaData.GetMesas
    End Function

    Public Sub QuitarMiembro(miembro As MiembroMesa)
        _mesaData.QuitarMiembro(miembro)
    End Sub

    Public Sub Guardar()
        _mesaData.Guardar
    End Sub

    Public Function GetMesaById(idMesa As Integer) As Mesa
        Return _mesaData.GetMesaById(idMesa)
    End Function

    Public Function HayVotantes(mesa As Mesa) As Boolean
        Return _mesaData.HayVotantes(mesa)
    End Function
End Class
