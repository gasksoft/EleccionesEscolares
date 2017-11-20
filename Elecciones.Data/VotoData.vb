Imports Elecciones.DataModel

Public Class VotoData
    Public Sub Votar(idNivel As ENivel, idGrado As Integer, idSeccion As String, idLista As Integer)
        Using ctx As New Contexto.EleccionesContext
            ctx.Votos.Add(New Voto With {.IdNivel = idNivel, .IdGrado = idGrado, .IdSeccion = idSeccion, .IdLista = idLista})
            ctx.SaveChanges()
        End Using
    End Sub
End Class
