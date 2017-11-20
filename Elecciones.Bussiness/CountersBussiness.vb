Imports Elecciones.Data

Public Class CountersBussiness
    Private ReadOnly _CountersData As New CountersData
    Public Function GetCountSecciones() As Integer
        Return _CountersData.GetCountSecciones
    End Function

    Public Function GetCountAlumnos() As Integer
        Return _CountersData.GetCountAlumnos
    End Function

    Public Function GetCountMesas() As Integer
        Return _CountersData.GetCountMesas
    End Function

    Public Function GetCountListas() As Integer
        Return _CountersData.GetCountListas
    End Function

    Public Function GetCountCandidatos() As Integer
        Return _CountersData.GetCountCandidatos
    End Function

    Public Function GetCountMiembrosMesa() As Integer
        Return _CountersData.GetCountMiembrosMesa
    End Function
End Class
