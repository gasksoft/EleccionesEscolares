Imports Elecciones.Data
Imports Elecciones.DataModel

Public Class GradoBussiness
    Private _gradoData As New GradoData
    ''' <summary>
    ''' Dado que decidi usar el metodo CONECTADO solo guardare los datos en el contexto completo
    ''' </summary>
    Public Sub GuardarCambios()
        _gradoData.GuardarCambios
    End Sub
    Public Function GetGradosByNivel(nivel As ENivel) As List(Of Grado)
        Dim grados = _GradoData.GetGradosByNivel(nivel)
        grados.Sort(Function(x, y) x.IdGrado.CompareTo(y.IdGrado))
        Return grados
    End Function

    Public Function GetGrados() As List(Of Grado)
        Dim grados = _gradoData.GetGrados
        Return grados
    End Function
End Class
