Imports System.ComponentModel

Partial Public Class Seccion
    Public ReadOnly Property CountAlumnos As Integer
        Get
            Return Alumnos.Count
        End Get
    End Property
    Public ReadOnly Property DetMesa As String
        Get
            Return Mesa?.DetMesa
        End Get
    End Property

    Public ReadOnly Property DescSeccion As String
        Get
            Return $"{Grado?.ToString} - {IdSeccion}"
        End Get
    End Property
End Class
