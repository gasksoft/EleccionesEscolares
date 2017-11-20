<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PadronElectoralReport
    Inherits Elecciones.Presentation.CommonWinForm.MasterForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MesaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MesaComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataSource = GetType(Elecciones.DataModel.Alumno)
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.AlumnosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Elecciones.Presentation.Reports.PadronElectoralReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 21)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(883, 445)
        Me.ReportViewer1.TabIndex = 1
        '
        'MesaBindingSource
        '
        Me.MesaBindingSource.DataSource = GetType(Elecciones.DataModel.Mesa)
        '
        'MesaComboBox
        '
        Me.MesaComboBox.DataSource = Me.MesaBindingSource
        Me.MesaComboBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.MesaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MesaComboBox.FormattingEnabled = True
        Me.MesaComboBox.Location = New System.Drawing.Point(0, 0)
        Me.MesaComboBox.Name = "MesaComboBox"
        Me.MesaComboBox.Size = New System.Drawing.Size(883, 21)
        Me.MesaComboBox.TabIndex = 1
        '
        'PadronElectoralReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 466)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MesaComboBox)
        Me.Name = "PadronElectoralReport"
        Me.Text = "PadronElectoralReport"
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AlumnosBindingSource As BindingSource
    Friend WithEvents MesaBindingSource As BindingSource
    Friend WithEvents MesaComboBox As ComboBox
End Class
