Imports Elecciones.Common
Imports Elecciones.Data
Imports Elecciones.DataModel

Public Class AlumnoBussiness
    Private ReadOnly _alumnoData As New AlumnoData
    Public Function GetAlumnosBySeccion(seccion As Seccion) As ObservableListSource(Of Alumno)
        Return _alumnoData.GetAlumnosBySeccion(seccion)
    End Function

    Public Function GetAlumnos() As Dictionary(Of String, Alumno)
        Return _alumnoData.GetAlumnos.ToDictionary(Function(x) x.Dni, Function(x) x)
    End Function

    Public Sub EliminarAlumno(alumno As Alumno)
        _alumnoData.EliminarAlumno(alumno)
    End Sub

    Public Sub GuardarCambios()
        _alumnoData.GuardarCambios
    End Sub

    Public Function GetAlumnoByDni(dni As String) As Alumno
        Return _alumnoData.GetAlumnoByDni(dni)
    End Function

    Public Sub Refrescar(alumno As Alumno)
        _alumnoData.Refrescar(alumno)
    End Sub
End Class
