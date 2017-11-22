Imports Elecciones.Data.Contexto
Imports Elecciones.DataModel

Public Class ProcesoData
    Public Sub Iniciar()
        Using ctx As New EleccionesContext
            For Each m In ctx.Mesas.Where(Function(x) x.Estado = EEstadoMesa.PorIniciarProceso)
                m.Estado = EEstadoMesa.PorAperturar
                m.UltimaConexion = Now
            Next
            ctx.SaveChanges()
        End Using
    End Sub

    Public Function GetVotos() As List(Of Voto)
        Using ctx As New EleccionesContext
            ctx.Configuration.LazyLoadingEnabled = False
            Return ctx.Votos.AsNoTracking.Include("Lista").ToList()
        End Using
    End Function

    Public Function GetMesas() As List(Of Mesa)
        Using ctx As New EleccionesContext
            ctx.Configuration.LazyLoadingEnabled = False
            Return ctx.Mesas.AsNoTracking.ToList()
        End Using
    End Function

    Public Sub ResetData()
        Using ctx As New EleccionesContext
            Using trans = ctx.Database.BeginTransaction()
                ctx.Database.ExecuteSqlCommand("Delete from Voto;")
                ctx.Database.ExecuteSqlCommand("Update Mesa set Estado=0;")
                ctx.Database.ExecuteSqlCommand("Update Alumno set YaVoto=0;")
                'esto es solo para este colegio......
                ctx.Database.ExecuteSqlCommand("Delete from MiembroMesa;")
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "72098172", .CargoMiembroMesa = 0})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "72940330", .CargoMiembroMesa = 0})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "75977302", .CargoMiembroMesa = 0})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "76044768", .CargoMiembroMesa = 0})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "76012552", .CargoMiembroMesa = 0})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "75977315", .CargoMiembroMesa = 0})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "72110622", .CargoMiembroMesa = 1})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "76036047", .CargoMiembroMesa = 1})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "72102523", .CargoMiembroMesa = 1})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "76555034", .CargoMiembroMesa = 1})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "76629147", .CargoMiembroMesa = 1})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "76322161", .CargoMiembroMesa = 1})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "72102514", .CargoMiembroMesa = 2})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "70488590", .CargoMiembroMesa = 2})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "70508967", .CargoMiembroMesa = 2})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "76035969", .CargoMiembroMesa = 2})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "48810460", .CargoMiembroMesa = 2})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "76519625", .CargoMiembroMesa = 2})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "76120055", .CargoMiembroMesa = 3})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "77493808", .CargoMiembroMesa = 3})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "71006411", .CargoMiembroMesa = 3})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "77140676", .CargoMiembroMesa = 3})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "76191178", .CargoMiembroMesa = 3})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "75977517", .CargoMiembroMesa = 3})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "73108438", .CargoMiembroMesa = 4})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "77488817", .CargoMiembroMesa = 4})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "72102515", .CargoMiembroMesa = 4})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "72110628", .CargoMiembroMesa = 4})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "76244030", .CargoMiembroMesa = 4})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "75481410", .CargoMiembroMesa = 4})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "75777759", .CargoMiembroMesa = 5})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "76356621", .CargoMiembroMesa = 5})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "75939752", .CargoMiembroMesa = 5})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "72102504", .CargoMiembroMesa = 5})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "75070905", .CargoMiembroMesa = 5})
                ctx.Participantes.Add(New MiembroMesa With {.Dni = "77227333", .CargoMiembroMesa = 5})
                ctx.SaveChanges()
                trans.Commit()
            End Using
        End Using
    End Sub

    Public Sub Terminar()
        Using ctx As New EleccionesContext
            For Each m In ctx.Mesas
                m.Estado = EEstadoMesa.EnCierre
                m.UltimaConexion = Now
            Next
            ctx.SaveChanges()
        End Using
    End Sub
End Class
