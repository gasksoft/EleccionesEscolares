Imports System.Drawing
Imports Elecciones.Common

Public Class Lista
    Public Property IdLista As Integer
    Public Property NombreLista As String
    Public Property Sigla As String
    Public Property Activo As Boolean
    Public Property Logo As Byte()
    Public Overridable Property Candidatos As New ObservableListSource(Of Candidato)
    Public Overridable Property Votos As New ObservableListSource(Of Voto)
End Class