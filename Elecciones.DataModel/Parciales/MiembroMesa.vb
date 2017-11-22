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

    Public ReadOnly Property Foto As Byte()
        Get
            Return Alumno.Foto
        End Get
    End Property

    Public ReadOnly Property DescSeccion As String
        Get
            Return Alumno.DescSeccion
        End Get
    End Property

    Public ReadOnly Property IdMesa As Integer
        Get
            Return Alumno.Seccion.IdMesa
        End Get
    End Property

    Public ReadOnly Property DescCargoMiembroMesa As String
        Get
            Select Case CargoMiembroMesa
                Case ECargoMiembroMesa.Presidente
                    Return "Presidente"
                    Exit Select
                Case ECargoMiembroMesa.Secretario
                    Return "Secretario"
                    Exit Select
                Case ECargoMiembroMesa.Vocal
                    Return "Vocal"
                    Exit Select
                Case ECargoMiembroMesa.Suplente1
                    Return "Suplente 1"
                    Exit Select
                Case ECargoMiembroMesa.Suplente2
                    Return "Suplente 2"
                    Exit Select
                Case Else
                    Return "Suplente 3"
                    Exit Select
            End Select
        End Get
    End Property
End Class
