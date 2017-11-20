Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class Candidato
    Public Overrides ReadOnly Property TipoParticipante As String
        Get
            Return "Candidato"
        End Get
    End Property
    <NotMapped>
    Public ReadOnly Property CargoDesc As String
        Get
            Dim sufijo1 = ""
            Dim sufijo2 = ""
            If Alumno?.Genero = EGenero.Mujer Then
                sufijo1 = "sa"
                sufijo2 = "a"
            End If

            Select Case Cargo
                Case ECargoCandidato.Alcalde
                    Return $"Alcalde{sufijo1}"
                    Exit Select
                Case ECargoCandidato.TenienteAlcalde
                    Return $"Teniente Alcalde{sufijo1}"
                    Exit Select
                Case ECargoCandidato.Regidor1
                    Return $"Regidor{sufijo2} de educación, cultura, recreación y deporte"
                    Exit Select
                Case ECargoCandidato.Regidor2
                    Return $"Regidor{sufijo2} de salud y ambiente"
                    Exit Select
                Case ECargoCandidato.Regidor3
                    Return $"Regidor{sufijo2} de emprendimiento y actividades productivas"
                    Exit Select
                Case ECargoCandidato.Regidor4
                    Return $"Regidor{sufijo2} de derechos del niño, niña y adolescente"
                    Exit Select
                Case ECargoCandidato.Regidor5
                    Return $"Regidor{sufijo2} de comunicación y tecnologías de la información"
                    Exit Select
                Case Else
                    Return "<valor no valido>"
                    Exit Select
            End Select
        End Get
    End Property
    Public ReadOnly Property ListaDesc As String
        Get
            Return $"{Lista?.NombreLista} - {Lista?.Sigla}"
        End Get
    End Property
    Public ReadOnly Property BinaryLogoLista As Byte()
        Get
            Return Lista?.Logo
        End Get
    End Property
    Public ReadOnly Property BinaryFotoCandidato As Byte()
        Get
            Return Alumno?.Foto
        End Get
    End Property
    Public ReadOnly Property DescSeccion As String
        Get
            Return Alumno?.DescSeccion
        End Get
    End Property
    Public ReadOnly Property NombreCandidato As String
        Get
            Return Alumno?.ApellidosNombres
        End Get
    End Property
End Class
