Imports Elecciones.Data
Imports Elecciones.DataModel

Public Class VotoBussiness
    Private ReadOnly VotoData As New VotoData
    Public Sub Votar(idNivel As ENivel, idGrado As Integer, idSeccion As String, idLista As Integer)
        VotoData.Votar(idNivel, idGrado, idSeccion, idLista)
    End Sub
End Class
