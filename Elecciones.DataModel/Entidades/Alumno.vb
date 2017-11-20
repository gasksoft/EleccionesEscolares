Public Class Alumno
    Public Property Dni As String
    Public Property Apellidos As String
    Public Property Nombres As String
    Public Property Genero As EGenero
    Public Property YaVoto As Boolean
    Public Property IdNivel As ENivel
    Public Property IdGrado As Integer
    Public Property IdSeccion As String
    Public Property Foto As Byte()
    Public Overridable Property Seccion As Seccion
    Public Overridable Property Participante As Participante
End Class