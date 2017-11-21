Imports Elecciones.Bussiness
Imports Elecciones.DataModel

Public Class PadronElectoralReport
    Private ReadOnly _sb As New MesaBussiness
    Dim mesa As Mesa
    'Dim seccion As Seccion
    Dim alumnos As List(Of Alumno)

    Private Sub PadronElectoralReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mesas = _sb.GetMesas
        MesaBindingSource.DataSource = mesas
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub

    Private Sub MesaBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles MesaBindingSource.CurrentChanged
        mesa = MesaBindingSource.Current
        If mesa Is Nothing Then Return
        alumnos = New List(Of Alumno)
        For Each s In mesa.Secciones
            alumnos.AddRange(s.Alumnos)
        Next
        AlumnosBindingSource.DataSource = alumnos
        ReportViewer1.RefreshReport()
    End Sub
End Class