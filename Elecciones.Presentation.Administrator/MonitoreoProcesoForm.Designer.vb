<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonitoreoProcesoForm
    Inherits Elecciones.Presentation.CommonWinForm.MasterForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.IniciarProcesoBtn = New System.Windows.Forms.Button()
        Me.TerminarProcesoBtn = New System.Windows.Forms.Button()
        Me.ResultadosBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'IniciarProcesoBtn
        '
        Me.IniciarProcesoBtn.Location = New System.Drawing.Point(18, 19)
        Me.IniciarProcesoBtn.Name = "IniciarProcesoBtn"
        Me.IniciarProcesoBtn.Size = New System.Drawing.Size(176, 58)
        Me.IniciarProcesoBtn.TabIndex = 0
        Me.IniciarProcesoBtn.Text = "Iniciar Proceso"
        Me.IniciarProcesoBtn.UseVisualStyleBackColor = True
        '
        'TerminarProcesoBtn
        '
        Me.TerminarProcesoBtn.Enabled = False
        Me.TerminarProcesoBtn.Location = New System.Drawing.Point(200, 19)
        Me.TerminarProcesoBtn.Name = "TerminarProcesoBtn"
        Me.TerminarProcesoBtn.Size = New System.Drawing.Size(176, 58)
        Me.TerminarProcesoBtn.TabIndex = 1
        Me.TerminarProcesoBtn.Text = "Terminar Proceso"
        Me.TerminarProcesoBtn.UseVisualStyleBackColor = True
        '
        'ResultadosBtn
        '
        Me.ResultadosBtn.Enabled = False
        Me.ResultadosBtn.Location = New System.Drawing.Point(382, 19)
        Me.ResultadosBtn.Name = "ResultadosBtn"
        Me.ResultadosBtn.Size = New System.Drawing.Size(176, 58)
        Me.ResultadosBtn.TabIndex = 2
        Me.ResultadosBtn.Text = "Ver Resultados"
        Me.ResultadosBtn.UseVisualStyleBackColor = True
        '
        'MonitoreoProcesoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 428)
        Me.Controls.Add(Me.ResultadosBtn)
        Me.Controls.Add(Me.TerminarProcesoBtn)
        Me.Controls.Add(Me.IniciarProcesoBtn)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "MonitoreoProcesoForm"
        Me.Padding = New System.Windows.Forms.Padding(15, 16, 15, 16)
        Me.Text = "MonitoreoProcesoForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents IniciarProcesoBtn As Button
    Friend WithEvents TerminarProcesoBtn As Button
    Friend WithEvents ResultadosBtn As Button
End Class
