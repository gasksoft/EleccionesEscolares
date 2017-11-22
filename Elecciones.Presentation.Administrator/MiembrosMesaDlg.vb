Imports System.Windows.Forms
Imports Elecciones.Bussiness
Imports Elecciones.DataModel

Public Class MiembrosMesaDlg
    Private ReadOnly _mesaBussiness As New MesaBussiness
    Private _mesa As Mesa
    Private c1, c2, c3, c4, c5, c6 As MiembroMesa

    Private Sub MesaBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles MesaBindingSource.CurrentChanged
        _mesa = MesaBindingSource.Current
        EnlazarMiembros()
    End Sub

    Private Sub PrintMiembrosMesaBtn_Click(sender As Object, e As EventArgs) Handles PrintMiembrosMesaBtn.Click
        Call New Reports.MiembrosMesaReport With {.Mesa = _mesa}.ShowDialog(Me)
    End Sub

    Private Sub MiembrosMesaDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MesaBindingSource.DataSource = _mesaBussiness.GetMesas
        EnlazarMiembros()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OK_Button.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub EnlazarMiembros()
        Dim mms = _mesa.MiembrosMesa
        c1 = mms.Where(Function(x) x.CargoMiembroMesa = ECargoMiembroMesa.Presidente).FirstOrDefault
        c2 = mms.Where(Function(x) x.CargoMiembroMesa = ECargoMiembroMesa.Secretario).FirstOrDefault
        c3 = mms.Where(Function(x) x.CargoMiembroMesa = ECargoMiembroMesa.Vocal).FirstOrDefault
        c4 = mms.Where(Function(x) x.CargoMiembroMesa = ECargoMiembroMesa.Suplente1).FirstOrDefault
        c5 = mms.Where(Function(x) x.CargoMiembroMesa = ECargoMiembroMesa.Suplente2).FirstOrDefault
        c6 = mms.Where(Function(x) x.CargoMiembroMesa = ECargoMiembroMesa.Suplente3).FirstOrDefault

        Foto1.Image = c1?.Alumno.Fotografia
        Cargo1.Text = If(c1?.CargoMiembroMesa.ToString, "Presidente")
        ApeNomb1.Text = c1?.Alumno.ApellidosNombres
        Seccion1.Text = c1?.Alumno.DescSeccion

        Foto2.Image = c2?.Alumno.Fotografia
        Cargo2.Text = If(c2?.CargoMiembroMesa.ToString, "Secretario")
        ApeNomb2.Text = c2?.Alumno.ApellidosNombres
        Seccion2.Text = c2?.Alumno.DescSeccion

        Foto3.Image = c3?.Alumno.Fotografia
        Cargo3.Text = If(c3?.CargoMiembroMesa.ToString, "Vocal")
        ApeNomb3.Text = c3?.Alumno.ApellidosNombres
        Seccion3.Text = c3?.Alumno.DescSeccion

        Foto4.Image = c4?.Alumno.Fotografia
        Cargo4.Text = If(c4?.CargoMiembroMesa.ToString, "Suplente 1")
        ApeNomb4.Text = c4?.Alumno.ApellidosNombres
        Seccion4.Text = c4?.Alumno.DescSeccion

        Foto5.Image = c5?.Alumno.Fotografia
        Cargo5.Text = If(c5?.CargoMiembroMesa.ToString, "Suplente 2")
        ApeNomb5.Text = c5?.Alumno.ApellidosNombres
        Seccion5.Text = c5?.Alumno.DescSeccion

        Foto6.Image = c6?.Alumno.Fotografia
        Cargo6.Text = If(c6?.CargoMiembroMesa.ToString, "Suplente 3")
        ApeNomb6.Text = c6?.Alumno.ApellidosNombres
        Seccion6.Text = c6?.Alumno.DescSeccion

        Foto1.Tag = If(c1, New MiembroMesa With {.CargoMiembroMesa = ECargoMiembroMesa.Presidente})
        Foto2.Tag = If(c2, New MiembroMesa With {.CargoMiembroMesa = ECargoMiembroMesa.Secretario})
        Foto3.Tag = If(c3, New MiembroMesa With {.CargoMiembroMesa = ECargoMiembroMesa.Vocal})
        Foto4.Tag = If(c4, New MiembroMesa With {.CargoMiembroMesa = ECargoMiembroMesa.Suplente1})
        Foto5.Tag = If(c5, New MiembroMesa With {.CargoMiembroMesa = ECargoMiembroMesa.Suplente2})
        Foto6.Tag = If(c6, New MiembroMesa With {.CargoMiembroMesa = ECargoMiembroMesa.Suplente3})
    End Sub

    Private Sub SortearBtn_Click(sender As Object, e As EventArgs) Handles SortearBtn.Click
        If MsgBox("Desea volver a sortear los miembros de mesa?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2) = MsgBoxResult.No Then Return
        Dim mms = _mesa.MiembrosMesa
        For Each m In mms
            _mesaBussiness.QuitarMiembro(m)
        Next
        Dim aleatorio As New Random(Now.Second + Now.Millisecond + Now.Minute)
        Dim sorteables = _mesa.AlumnosSorteables

        Dim sorteado = sorteables(aleatorio.Next(0, sorteables.Count))
        sorteables.Remove(sorteado)
        sorteado.Participante = New MiembroMesa With {.CargoMiembroMesa = ECargoMiembroMesa.Presidente}

        sorteado = sorteables(aleatorio.Next(0, sorteables.Count))
        sorteables.Remove(sorteado)
        sorteado.Participante = New MiembroMesa With {.CargoMiembroMesa = ECargoMiembroMesa.Secretario}

        sorteado = sorteables(aleatorio.Next(0, sorteables.Count))
        sorteables.Remove(sorteado)
        sorteado.Participante = New MiembroMesa With {.CargoMiembroMesa = ECargoMiembroMesa.Vocal}

        sorteado = sorteables(aleatorio.Next(0, sorteables.Count))
        sorteables.Remove(sorteado)
        sorteado.Participante = New MiembroMesa With {.CargoMiembroMesa = ECargoMiembroMesa.Suplente1}

        sorteado = sorteables(aleatorio.Next(0, sorteables.Count))
        sorteables.Remove(sorteado)
        sorteado.Participante = New MiembroMesa With {.CargoMiembroMesa = ECargoMiembroMesa.Suplente2}

        sorteado = sorteables(aleatorio.Next(0, sorteables.Count))
        sorteables.Remove(sorteado)
        sorteado.Participante = New MiembroMesa With {.CargoMiembroMesa = ECargoMiembroMesa.Suplente3}

        _mesaBussiness.Guardar()
        EnlazarMiembros()
    End Sub
End Class
