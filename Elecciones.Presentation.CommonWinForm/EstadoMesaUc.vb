Imports Elecciones.DataModel

Public Class EstadoMesaUc
    Private _mesa As Mesa
    Public Property Mesa As Mesa
        Get
            Return _mesa
        End Get
        Set(value As Mesa)
            _mesa = value
            If Mesa Is Nothing Then Return
            Label1.Text = $"{Mesa.IdMesa:0000}"
            Label2.Text = (Now - _mesa.UltimaConexion).ToString("hh\:mm\:ss")
            Label3.Text = _mesa.Estado.ToString
        End Set
    End Property
End Class
