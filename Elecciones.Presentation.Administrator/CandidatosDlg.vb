Imports Elecciones.Bussiness
Imports Elecciones.DataModel

Public Class CandidatosDlg
    Private ReadOnly _listaBussiness As New ListaBussiness
    Private c1, c2, c3, c4, c5, c6, c7 As Candidato

    Private _lista As Lista

    Private Sub Foto1_Click(sender As Object, e As EventArgs) Handles Foto1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dlg As New Reports.CandidatosReport
        dlg.Lista = _lista
        dlg.ShowDialog(Me)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OK_Button.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub CandidatosDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaBindingSource.DataSource = _listaBussiness.GetListas
    End Sub

    Private Sub ListaBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ListaBindingSource.CurrentChanged
        _lista = ListaBindingSource.Current
        EnlazarCandidatos
    End Sub
    Private Sub EnlazarCandidatos()
        c1 = _lista.Candidatos.Where(Function(x) x.Cargo = ECargoCandidato.Alcalde).FirstOrDefault
        c2 = _lista.Candidatos.Where(Function(x) x.Cargo = ECargoCandidato.TenienteAlcalde).FirstOrDefault
        c3 = _lista.Candidatos.Where(Function(x) x.Cargo = ECargoCandidato.Regidor1).FirstOrDefault
        c4 = _lista.Candidatos.Where(Function(x) x.Cargo = ECargoCandidato.Regidor2).FirstOrDefault
        c5 = _lista.Candidatos.Where(Function(x) x.Cargo = ECargoCandidato.Regidor3).FirstOrDefault
        c6 = _lista.Candidatos.Where(Function(x) x.Cargo = ECargoCandidato.Regidor4).FirstOrDefault
        c7 = _lista.Candidatos.Where(Function(x) x.Cargo = ECargoCandidato.Regidor5).FirstOrDefault

        Foto1.Image = c1?.Alumno.Fotografia
        Cargo1.Text = If(c1?.CargoDesc, "Alcalde")
        ApeNomb1.Text = c1?.Alumno.ApellidosNombres
        Seccion1.Text = c1?.Alumno.DescSeccion

        Foto2.Image = c2?.Alumno.Fotografia
        Cargo2.Text = If(c2?.CargoDesc, "Teniente Alcalde")
        ApeNomb2.Text = c2?.Alumno.ApellidosNombres
        Seccion2.Text = c2?.Alumno.DescSeccion

        Foto3.Image = c3?.Alumno.Fotografia
        Cargo3.Text = If(c3?.CargoDesc, "Regidor de educación, cultura, recreación y deporte")
        ApeNomb3.Text = c3?.Alumno.ApellidosNombres
        Seccion3.Text = c3?.Alumno.DescSeccion

        Foto4.Image = c4?.Alumno.Fotografia
        Cargo4.Text = If(c4?.CargoDesc, "Regidor de salud y ambiente")
        ApeNomb4.Text = c4?.Alumno.ApellidosNombres
        Seccion4.Text = c4?.Alumno.DescSeccion

        Foto5.Image = c5?.Alumno.Fotografia
        Cargo5.Text = If(c5?.CargoDesc, "Regidor de emprendimiento y actividades productivas")
        ApeNomb5.Text = c5?.Alumno.ApellidosNombres
        Seccion5.Text = c5?.Alumno.DescSeccion

        Foto6.Image = c6?.Alumno.Fotografia
        Cargo6.Text = If(c6?.CargoDesc, "Regidor de derechos del niño, niña y adolescente")
        ApeNomb6.Text = c6?.Alumno.ApellidosNombres
        Seccion6.Text = c6?.Alumno.DescSeccion

        Foto7.Image = c7?.Alumno.Fotografia
        Cargo7.Text = If(c7?.CargoDesc, "Regidor de comunicación y tecnologías de la información")
        ApeNomb7.Text = c7?.Alumno.ApellidosNombres
        Seccion7.Text = c7?.Alumno.DescSeccion

        Foto1.Tag = If(c1, New Candidato With {.Cargo = ECargoCandidato.Alcalde})
        Foto2.Tag = If(c2, New Candidato With {.Cargo = ECargoCandidato.TenienteAlcalde})
        Foto3.Tag = If(c3, New Candidato With {.Cargo = ECargoCandidato.Regidor1})
        Foto4.Tag = If(c4, New Candidato With {.Cargo = ECargoCandidato.Regidor2})
        Foto5.Tag = If(c5, New Candidato With {.Cargo = ECargoCandidato.Regidor3})
        Foto6.Tag = If(c6, New Candidato With {.Cargo = ECargoCandidato.Regidor4})
        Foto7.Tag = If(c7, New Candidato With {.Cargo = ECargoCandidato.Regidor5})
    End Sub

    Private Sub Foto_Click(sender As Object, e As EventArgs) _
        Handles Foto1.DoubleClick, Foto2.DoubleClick, Foto3.DoubleClick,
        Foto4.DoubleClick, Foto5.DoubleClick, Foto6.DoubleClick, Foto7.DoubleClick
        Dim candidato As Candidato = sender.tag
        Dim dlg As New BuscarAlumnoDlg
        If dlg.ShowDialog(Me) = DialogResult.OK Then
            If dlg.Alumno?.TipoParticipante <> "Votante" Then
                MsgBox("Este alumno ya esta participando como candidato o como miembro de mesa.")
                Return
            End If
            If candidato?.Alumno IsNot Nothing Then
                _listaBussiness.QuitarCandidato(candidato)
            End If
            candidato.Dni = dlg.Alumno.Dni
            _lista.Candidatos.Add(candidato)
            _listaBussiness.Guardar()
            EnlazarCandidatos()
        End If
    End Sub
End Class
