Imports System.ComponentModel

Partial Public Class MiembroMesa
    Public Overrides ReadOnly Property TipoParticipante As String
        Get
            Return "Miembro de Mesa"
        End Get
    End Property

    Public ReadOnly Property ApellidosNombres As String
        Get
            Return Alumno.ApellidosNombres
        End Get
    End Property
End Class
