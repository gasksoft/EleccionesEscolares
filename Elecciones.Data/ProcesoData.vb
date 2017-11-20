Imports Elecciones.Data.Contexto
Imports Elecciones.DataModel

Public Class ProcesoData
    Private _ctx As EleccionesContext = ContextLocator.Instance.Contexto
    Public Sub Iniciar()
        For Each m In _ctx.Mesas
            _ctx.Entry(m).Reload()
            m.Estado = DataModel.EEstadoMesa.PorAperturar
            m.UltimaConexion = Now
        Next
        _ctx.SaveChanges()
    End Sub

    Public Function GetVotos() As List(Of Voto)
        Using ctx As New EleccionesContext
            ctx.Configuration.LazyLoadingEnabled = False
            Return ctx.Votos.AsNoTracking.Include("Lista").ToList()
        End Using
    End Function

    Public Sub Terminar()
        For Each m In _ctx.Mesas
            _ctx.Entry(m).Reload()
            m.Estado = DataModel.EEstadoMesa.EnCierre
            m.UltimaConexion = Now
        Next
        _ctx.SaveChanges()
    End Sub
End Class
