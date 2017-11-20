Imports Elecciones.Data.Contexto
Imports Elecciones.DataModel

Public Class GradoData
    Private _ctx As EleccionesContext = ContextLocator.Instance.Contexto

    Public Sub GuardarCambios()
        _ctx.SaveChanges()
    End Sub

    Public Function GetGradosByNivel(nivel As ENivel) As List(Of Grado)
        Return (From g In _ctx.Grados Where g.IdNivel = nivel Order By g.IdGrado).ToList
    End Function

    Public Function GetGrados() As List(Of Grado)
        Return (From g In _ctx.Grados Order By g.IdNivel, g.IdGrado).ToList
    End Function
End Class
