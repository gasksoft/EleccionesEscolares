Imports Elecciones.Data.Contexto
Imports Elecciones.DataModel

Public Class CountersData
    Private _ctx As EleccionesContext = ContextLocator.Instance.Contexto
    Public Function GetCountSecciones() As Integer
        Return _ctx.Secciones.Count
    End Function

    Public Function GetCountAlumnos() As Integer
        Return _ctx.Alumnos.Count
    End Function

    Public Function GetCountMesas() As Integer
        Return _ctx.Mesas.Count
    End Function

    Public Function GetCountListas() As Integer
        Return _ctx.Listas.Where(Function(x) x.Activo).Count
    End Function

    Public Function GetCountCandidatos() As Integer
        Return _ctx.Participantes.OfType(Of Candidato).Where(Function(x) x.Lista.Activo = True).Count
    End Function

    Public Function GetCountMiembrosMesa() As Integer
        Return _ctx.Participantes.OfType(Of MiembroMesa).Count
    End Function
End Class