Imports System.Collections.ObjectModel
Imports Elecciones.Common

Public Class Seccion
    Public Property IdNivel As ENivel
    Public Property IdGrado As Integer
    Public Property IdSeccion As String
    Public Property IdMesa As Integer?
    Public Overridable Property Mesa As Mesa
    Public Overridable Property Grado As Grado
    Public Overridable Property Alumnos As New ObservableListSource(Of Alumno)
    Public Overridable Property Votos As New Collection(Of Voto)
End Class