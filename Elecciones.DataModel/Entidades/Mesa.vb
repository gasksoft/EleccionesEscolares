Imports Elecciones.Common

Public Class Mesa
    Public Property IdMesa As Integer
    Public Property Estado As EEstadoMesa
    Public Property UltimoDni As String
    Public Property UltimaConexion As DateTime
    Public Overridable Property Secciones As New ObservableListSource(Of Seccion)
End Class