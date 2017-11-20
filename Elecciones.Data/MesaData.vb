Imports System.Data.Entity
Imports Elecciones.Common
Imports Elecciones.Data.Contexto
Imports Elecciones.DataModel

Public Class MesaData
    Private _ctx As EleccionesContext = ContextLocator.Instance.Contexto
    Public Function GetMesas() As ObservableListSource(Of Mesa)
        Return New ObservableListSource(Of Mesa)(_ctx.Mesas.ToList)
    End Function

    Public Sub QuitarMiembro(m As MiembroMesa)
        _ctx.Participantes.Remove(m)
    End Sub

    Public Sub Guardar()
        _ctx.SaveChanges()
    End Sub

    Private Shared locker As New Object
    Public Function GetMesaById(idMesa As Integer) As Mesa
        SyncLock locker
            Dim mesa = _ctx.Mesas.Where(Function(x) x.IdMesa = idMesa).FirstOrDefault
            If mesa IsNot Nothing Then
                _ctx.Entry(mesa).Reload()
            End If
            Return mesa
        End SyncLock
    End Function

    Public Function HayVotantes(mesa As Mesa) As Boolean
        Using c As New EleccionesContext
            c.Configuration.LazyLoadingEnabled = False
            c.Configuration.ProxyCreationEnabled = False
            For Each s In (From ss In _ctx.Secciones Where ss.IdMesa = mesa.IdMesa).Include("Alumnos").AsNoTracking
                If (From a In s.Alumnos Where Not a.YaVoto).Any Then
                    Return True
                End If
            Next
        End Using
        Return False
    End Function
End Class
