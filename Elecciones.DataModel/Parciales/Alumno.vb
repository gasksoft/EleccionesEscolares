Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Partial Public Class Alumno
    Private _fotografia As Image

    Public ReadOnly Property TipoParticipante As String
        Get
            If Participante Is Nothing Then
                Return "Votante"
            Else
                Return Participante?.TipoParticipante
            End If
        End Get
    End Property

    Public ReadOnly Property ApellidosNombres As String
        Get
            Return $"{Apellidos}, {Nombres}"
        End Get
    End Property

    Public ReadOnly Property DescSeccion As String
        Get
            Return Seccion?.DescSeccion
        End Get
    End Property

    <NotMapped>
    Public Property Fotografia As Image
        Get
            If Foto Is Nothing Then Return Nothing
            If _fotografia Is Nothing Then
                Using ms As New MemoryStream(Foto)
                    _fotografia = Image.FromStream(ms)
                End Using
            End If
            Return _fotografia
        End Get
        Set
            _fotografia = Nothing
            If Value Is Nothing Then
                _fotografia = Nothing
                Return
            End If
            Dim ancho = Value.Width
            Dim alto = Value.Height
            Dim factor = ancho / alto
            Dim alto2 As Integer = 210 / factor
            Using img As New Bitmap(210, alto2)
                Using g As Graphics = Graphics.FromImage(img)
                    g.DrawImage(Value, 0, 0, 210, alto2)
                    Using ms As New MemoryStream
                        img.Save(ms, ImageFormat.Jpeg)
                        Foto = ms.GetBuffer
                    End Using
                End Using
            End Using
        End Set
    End Property

    Public ReadOnly Property DescGrado As String
        Get
            Return Seccion?.Grado?.DescGrado
        End Get
    End Property

    Public ReadOnly Property Mesa As Integer
        Get
            Return Seccion?.IdMesa
        End Get
    End Property

End Class
