Imports System.ComponentModel

Partial Public Class Grado
    Public ReadOnly Property DescGrado As String
        Get
            Select Case IdNivel
                Case ENivel.Inicial
                    Return $"{IdGrado} años"
                    Exit Select
                Case ENivel.Primaria
                    Return $"{IdGrado}° grado"
                    Exit Select
                Case ENivel.Secundaria
                    Return $"{IdGrado}° año"
                    Exit Select
            End Select
            Return ""
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return $"{IdNivel} - {DescGrado}"
    End Function
End Class
