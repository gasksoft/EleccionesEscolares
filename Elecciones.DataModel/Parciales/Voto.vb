Partial Public Class Voto
    Public ReadOnly Property DescGrado As String
        Get
            Return Seccion?.Grado?.DescGrado
        End Get
    End Property
    Public ReadOnly Property DescSeccion As String
        Get
            Return Seccion?.DescSeccion
        End Get
    End Property
    Public ReadOnly Property Mesa As Integer?
        Get
            Return Seccion?.IdMesa
        End Get
    End Property
    Public ReadOnly Property DescLista As String
        Get
            Return $"{Lista?.NombreLista} - {Lista?.Sigla}"
        End Get
    End Property
    Public ReadOnly Property LogoLista As Byte()
        Get
            Return Lista?.Logo
        End Get
    End Property
End Class
