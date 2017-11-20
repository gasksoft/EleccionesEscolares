Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure.Annotations
Imports Elecciones.DataModel

Namespace Contexto
    Public Class EleccionesContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("eleccionesData")
#If DEBUG Then
            Database.Log = Sub(x) Debug.WriteLine(x)

            'Votos.RemoveRange(Votos.ToList)
            'Dim aleatorio As New Random
            'Dim nl = Listas.Count
            'For Each a In Alumnos.ToList
            '    Dim v As New Voto
            '    v.IdGrado = a.IdGrado
            '    Dim aa = aleatorio.NextDouble
            '    If aa <= 0.65 Then
            '        v.IdLista = 1
            '    ElseIf aa <= 0.97 Then
            '        v.IdLista = 2
            '    Else
            '        v.IdLista = 3
            '    End If
            '    v.IdNivel = a.IdNivel
            '    v.IdSeccion = a.IdSeccion
            '    Votos.Add(v)
            'Next
            'SaveChanges()
#End If
        End Sub

        Public Property Usuarios As DbSet(Of Usuario)
        Public Property Alumnos As DbSet(Of Alumno)
        Public Property Secciones As DbSet(Of Seccion)
        Public Property Mesas As DbSet(Of Mesa)
        Public Property Listas As DbSet(Of Lista)
        Public Property Participantes As DbSet(Of Participante)
        Public Property Grados As DbSet(Of Grado)
        Public Property Votos As DbSet(Of Voto)

        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            MyBase.OnModelCreating(modelBuilder)
            Database.SetInitializer(New EleccionesContextInitializer(modelBuilder))

            modelBuilder.Entity(Of Lista).HasKey(Function(x) x.IdLista)
            modelBuilder.Entity(Of Alumno).HasKey(Function(x) x.Dni)
            modelBuilder.Entity(Of Grado).HasKey(Function(x) New With {x.IdNivel, x.IdGrado})
            modelBuilder.Entity(Of Mesa).HasKey(Function(x) x.IdMesa)
            modelBuilder.Entity(Of Participante).HasKey(Function(x) x.Dni)
            modelBuilder.Entity(Of Seccion).HasKey(Function(x) New With {x.IdNivel, x.IdGrado, x.IdSeccion})
            modelBuilder.Entity(Of Voto).HasKey(Function(x) x.IdVoto)

            modelBuilder.Entity(Of Lista).ToTable("Lista")
            modelBuilder.Entity(Of Alumno).ToTable("Alumno")
            modelBuilder.Entity(Of Grado).ToTable("Grado")
            modelBuilder.Entity(Of Mesa).ToTable("Mesa")
            modelBuilder.Entity(Of Seccion).ToTable("Seccion")
            modelBuilder.Entity(Of Voto).ToTable("Voto")

            modelBuilder.Entity(Of Voto).HasRequired(Function(x) x.Seccion).WithMany(Function(x) x.Votos).
                HasForeignKey(Function(x) New With {x.IdNivel, x.IdGrado, x.IdSeccion})
            modelBuilder.Entity(Of Voto).HasRequired(Function(x) x.Lista)

            modelBuilder.Entity(Of Alumno).HasRequired(Function(x) x.Seccion)

            modelBuilder.Entity(Of MiembroMesa).Property(Function(x) x.CargoMiembroMesa).IsRequired()

            modelBuilder.Entity(Of Alumno).Property(Function(x) x.Dni).IsFixedLength.HasMaxLength(8)
            modelBuilder.Entity(Of Alumno).Property(Function(x) x.Apellidos).HasMaxLength(60).IsRequired()
            modelBuilder.Entity(Of Alumno).Property(Function(x) x.Nombres).HasMaxLength(60).IsRequired()
            modelBuilder.Entity(Of Alumno).Property(Function(x) x.IdSeccion).HasMaxLength(1)

            modelBuilder.Entity(Of Participante).Property(Function(x) x.Dni).IsFixedLength.HasMaxLength(8)

            modelBuilder.Entity(Of Alumno).HasOptional(Function(x) x.Participante).
                WithRequired(Function(x) x.Alumno).WillCascadeOnDelete(True)

            modelBuilder.Entity(Of MiembroMesa).Map(Sub(x)
                                                        x.MapInheritedProperties()
                                                        x.ToTable("MiembroMesa")
                                                    End Sub)

            modelBuilder.Entity(Of Candidato).Map(Sub(x)
                                                      x.MapInheritedProperties()
                                                      x.ToTable("Candidato")
                                                  End Sub)

            modelBuilder.Entity(Of Seccion).Property(Function(x) x.IdSeccion).HasMaxLength(1)
            modelBuilder.Entity(Of Seccion).Property(Function(x) x.IdMesa).IsOptional()

            modelBuilder.Entity(Of Lista).Property(Function(x) x.NombreLista).HasMaxLength(150).IsRequired()
            modelBuilder.Entity(Of Lista).Property(Function(x) x.Sigla).HasMaxLength(10).IsRequired()

            modelBuilder.Entity(Of Usuario).HasKey(Function(x) x.Username)
            modelBuilder.Entity(Of Usuario).Property(Function(x) x.Username).HasMaxLength(10)
            modelBuilder.Entity(Of Usuario).Property(Function(x) x.Password).HasMaxLength(28)

            modelBuilder.Entity(Of Mesa).Property(Function(x) x.UltimoDni).HasMaxLength(8).IsOptional()

            modelBuilder.Entity(Of Candidato)().HasIndex(Function(x) New With {x.IdLista, x.Cargo}).IsUnique()

            modelBuilder.Entity(Of Voto)().HasIndex(Function(x) New With {x.IdNivel, x.IdGrado, x.IdSeccion}).
                HasName("IX_VOTO_SECCION")

            modelBuilder.Entity(Of Mesa)().HasIndex(Function(x) x.IdMesa).IsUnique.IsClustered()

        End Sub

    End Class
End Namespace