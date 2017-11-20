Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class Mesa
    Public ReadOnly Property CountSecciones As Integer
        Get
            Return Secciones.Count
        End Get
    End Property

    Public ReadOnly Property CountAlumnos As Integer
        Get
            Return Secciones.Sum(Function(x) x.CountAlumnos)
        End Get
    End Property

    <NotMapped>
    Public ReadOnly Property MiembrosMesa As List(Of MiembroMesa)
        Get
            Dim mms As New List(Of MiembroMesa)
            For Each s In Secciones.ToList
                mms.AddRange((From aa In s.Alumnos Select aa.Participante).OfType(Of MiembroMesa).ToList)
            Next
            Return mms
        End Get
    End Property

    <NotMapped>
    Public ReadOnly Property Candidatos As List(Of Candidato)
        Get
            Dim mmc As New List(Of Candidato)
            For Each s In Secciones.ToList
                mmc.AddRange((From aa In s.Alumnos Select aa.Participante).OfType(Of Candidato).ToList)
            Next
            Return mmc
        End Get
    End Property

    <NotMapped>
    Public ReadOnly Property AlumnosSorteables As List(Of Alumno)
        Get
            Dim aas As New List(Of Alumno)
            For Each s In Secciones.ToList
                aas.AddRange((From aa In s.Alumnos).ToList)
            Next
            For Each m In MiembrosMesa.ToList
                aas.Remove(m.Alumno)
            Next
            For Each c In Candidatos.ToList
                aas.Remove(c.Alumno)
            Next
            Return aas
        End Get
    End Property

    <NotMapped>
    Public ReadOnly Property AlumnosVotantes As List(Of Alumno)
        Get
            Dim aas As New List(Of Alumno)
            For Each s In Secciones.ToList
                aas.AddRange((From aa In s.Alumnos).ToList)
            Next
            Return aas
        End Get
    End Property

    Public ReadOnly Property DetMesa As String
        Get
            Return $"{IdMesa:D4}: #Sec. = {CountSecciones:D2}, #Alum. = {CountAlumnos:D3}"
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return DetMesa
    End Function
End Class
