Imports Elecciones.Common
Imports Elecciones.Data.Contexto
Imports Elecciones.DataModel

Public Class AlumnoData
    Private _ctx As EleccionesContext = ContextLocator.Instance.Contexto
    Public Function GetAlumnosBySeccion(seccion As Seccion) As ObservableListSource(Of Alumno)
        Dim res = From a In _ctx.Alumnos
                  Where seccion.IdNivel = a.Seccion.IdNivel And
                      seccion.IdGrado = a.Seccion.IdGrado And
                      seccion.IdSeccion = a.IdSeccion
                  Order By a.Apellidos, a.Nombres
        Return New ObservableListSource(Of Alumno)(res)
    End Function

    Public Function GetAlumnos() As List(Of Alumno)
        Return _ctx.Alumnos.ToList
    End Function

    Public Function GetAlumnoByDni(dni As String) As Alumno
        Return (From a In _ctx.Alumnos Where a.Dni = dni).FirstOrDefault
    End Function

    Public Sub Refrescar(alumno As Alumno)
        _ctx.Entry(alumno).Reload()
    End Sub

    Public Sub EliminarAlumno(alumno As Alumno)
        _ctx.Alumnos.Local.Remove(alumno)
    End Sub

    Public Sub GuardarCambios()
        _ctx.SaveChanges()
    End Sub
End Class