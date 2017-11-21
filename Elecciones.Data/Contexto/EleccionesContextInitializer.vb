Imports System.Data.Entity
Imports System.Drawing
Imports Elecciones.Common
Imports Elecciones.DataModel
Imports SQLite.CodeFirst

Namespace Contexto
    Public Class EleccionesContextInitializer
        'Inherits SqliteDropCreateDatabaseAlways(Of EleccionesContext)
        Inherits SqliteDropCreateDatabaseWhenModelChanges(Of EleccionesContext)

        Public Sub New(modelBuilder As DbModelBuilder)
            MyBase.New(modelBuilder)
        End Sub

        Protected Overrides Sub Seed(context As EleccionesContext)
            If context Is Nothing Then
                Throw New ArgumentNullException(NameOf(context))
            End If

            Dim grados As New List(Of Grado) From {
                    New Grado With {.IdNivel = ENivel.Inicial, .IdGrado = 3},
                    New Grado With {.IdNivel = ENivel.Inicial, .IdGrado = 4},
                    New Grado With {.IdNivel = ENivel.Inicial, .IdGrado = 5},
                    New Grado With {.IdNivel = ENivel.Primaria, .IdGrado = 1},
                    New Grado With {.IdNivel = ENivel.Primaria, .IdGrado = 2},
                    New Grado With {.IdNivel = ENivel.Primaria, .IdGrado = 3},
                    New Grado With {.IdNivel = ENivel.Primaria, .IdGrado = 4},
                    New Grado With {.IdNivel = ENivel.Primaria, .IdGrado = 5},
                    New Grado With {.IdNivel = ENivel.Primaria, .IdGrado = 6},
                    New Grado With {.IdNivel = ENivel.Secundaria, .IdGrado = 1},
                    New Grado With {.IdNivel = ENivel.Secundaria, .IdGrado = 2},
                    New Grado With {.IdNivel = ENivel.Secundaria, .IdGrado = 3},
                    New Grado With {.IdNivel = ENivel.Secundaria, .IdGrado = 4},
                    New Grado With {.IdNivel = ENivel.Secundaria, .IdGrado = 5}
                    }
            For Each g In grados
                g.Secciones.Add(New Seccion With {.IdSeccion = "A"})
                g.Secciones.Add(New Seccion With {.IdSeccion = "B"})
                g.Secciones.Add(New Seccion With {.IdSeccion = "C"})
                g.Secciones.Add(New Seccion With {.IdSeccion = "D"})
                g.Secciones.Add(New Seccion With {.IdSeccion = "E"})
                g.Secciones.Add(New Seccion With {.IdSeccion = "F"})
            Next

            context.Set(Of Grado)().AddRange(grados)

            context.Set(Of Usuario).Add(New Usuario _
                                            With {.Username = "Admin", .Password = "kQN5uq7gPj84zEee6s3eec7230k="})
            context.Set(Of Usuario).Add(New Usuario _
                                            With {.Username = "GaSK", .Password = "s3ropnKkKrXs5ZZiJPJDYlfFWvE="})

            For i = 1 To 4
                Dim lista As New Lista With {.NombreLista = $"Agrupacion {i}", .Sigla = $"Abb{i}", .Activo = True}
                context.Set(Of Lista).Add(lista)
            Next

#If DEBUG Then
            Dim aleatorio As New Random(Now.Day)

            Dim archivosImagen = IO.Directory.GetFiles("s:\fotos", "*.jpg")

            For i = 0 To 3
                context.Set(Of Mesa).Add(New Mesa())
            Next
            Dim mesas = context.Mesas.Local.ToList
            'generamos secciones, mesas y alumnos aleatoriamente
            For Each seccion In context.Set(Of Seccion).Local.ToList
                For i = 0 To aleatorio.Next(5, 10)
                    Dim g = If(aleatorio.NextDouble > 0.5, EGenero.Mujer, EGenero.Varon)
                    seccion.Alumnos.Add(
                        New Alumno With {
                                           .Apellidos = NameGenerator.GenerarApellidos(),
                                           .Nombres =
                                           If _
                                           (g = EGenero.Mujer, NameGenerator.GenerarNombreMujer,
                                            NameGenerator.GenerarNombreVaron),
                                           .Dni = aleatorio.Next(10000000, 99999999),
                                           .Genero = g,
                                           .Fotografia = Image.FromFile(archivosImagen(aleatorio.Next(0, archivosImagen.Count)))
                                           })
                Next
                If aleatorio.NextDouble > 0.2 Then
                    seccion.Mesa = mesas(aleatorio.Next(0, 4))
                End If

            Next

            'generamos candidatos
            Dim alumnosList = context.Alumnos.Local.ToList
            For Each lista In context.Listas.Local.ToList
                For Each cargo In ([Enum].GetValues(GetType(ECargoCandidato)))
                    Dim alumno = alumnosList.FirstOrDefault
                    alumnosList.Remove(alumno)
                    Dim candidato As New Candidato With {
                            .Dni = alumno.Dni,
                            .Cargo = cargo
                            }
                    lista.Candidatos.Add(candidato)
                Next
                context.Set(Of Lista).Add(lista)
            Next

            'generamos con el resto de alumnos a los miembros de mesa
            For Each m In context.Mesas.Local.ToList
                For Each cmm In [Enum].GetValues(GetType(ECargoMiembroMesa))
                    Dim alumno = alumnosList.FirstOrDefault
                    alumnosList.Remove(alumno)
                    Dim miembro As New MiembroMesa With {
                            .Dni = alumno.Dni,
                            .CargoMiembroMesa = cmm
                            }
                    context.Set(Of MiembroMesa).Add(miembro)
                Next
            Next
#End If
        End Sub
    End Class
End Namespace