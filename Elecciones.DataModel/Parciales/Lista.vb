Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Partial Public Class Lista
    Private _logoImage As Image
    <NotMapped>
    Public Property LogoImage As Image
        Get
            If Logo Is Nothing Then Return Nothing
            If _logoImage Is Nothing Then
                Using ms As New MemoryStream(Logo)
                    _logoImage = Image.FromStream(ms)
                End Using
            End If
            Return _logoImage
        End Get
        Set
            _logoImage = Nothing
            If Value Is Nothing Then
                _logoImage = Nothing
                Return
            End If
            Dim ancho = Value.Width
            Dim alto = Value.Height
            Dim factor = ancho / alto
            Dim alto2 = 240 'As Integer = ancho2 / factor
            Dim ancho2 As Integer = alto2 * factor  ' = 150
            Using img As New Bitmap(ancho2, alto2)
                Using g As Graphics = Graphics.FromImage(img)
                    g.DrawImage(Value, 0, 0, ancho2, alto2)
                    Using ms As New MemoryStream
                        img.Save(ms, ImageFormat.Jpeg)
                        Logo = ms.GetBuffer
                    End Using
                End Using
            End Using
        End Set
    End Property
End Class
