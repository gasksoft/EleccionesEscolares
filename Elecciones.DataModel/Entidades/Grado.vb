Imports Elecciones.Common

Public Class Grado
    Public Property IdNivel As ENivel
    Public Property IdGrado As Integer
    Public Overridable Property Secciones As New ObservableListSource(Of Seccion)
End Class