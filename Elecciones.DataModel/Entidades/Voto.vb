Public Class Voto
    Public Property IdVoto As Integer
    Public Property IdNivel As ENivel
    Public Property IdGrado As Integer
    Public Property IdSeccion As String
    Public Property IdLista As Integer
    Public Overridable Property Seccion As Seccion
    Public Overridable Property Lista As Lista
End Class