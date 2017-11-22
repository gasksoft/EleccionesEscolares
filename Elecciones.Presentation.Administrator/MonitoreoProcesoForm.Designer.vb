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
        Me.ReiniciarDatosproceso = New System.Windows.Forms.Button()
        Me.EstadoMesaUc1 = New Elecciones.Presentation.CommonWinForm.EstadoMesaUc()
        Me.EstadoMesaUc2 = New Elecciones.Presentation.CommonWinForm.EstadoMesaUc()
        Me.EstadoMesaUc3 = New Elecciones.Presentation.CommonWinForm.EstadoMesaUc()
        Me.EstadoMesaUc4 = New Elecciones.Presentation.CommonWinForm.EstadoMesaUc()
        Me.EstadoMesaUc5 = New Elecciones.Presentation.CommonWinForm.EstadoMesaUc()
        Me.EstadoMesaUc6 = New Elecciones.Presentation.CommonWinForm.EstadoMesaUc()
        Me.SuspendLayout()
        '
        'IniciarProcesoBtn
        '
        Me.IniciarProcesoBtn.Location = New System.Drawing.Point(18, 83)
        Me.IniciarProcesoBtn.Name = "IniciarProcesoBtn"
        Me.IniciarProcesoBtn.Size = New System.Drawing.Size(138, 58)
        Me.IniciarProcesoBtn.TabIndex = 0
        Me.IniciarProcesoBtn.Text = "Iniciar Proceso"
        Me.IniciarProcesoBtn.UseVisualStyleBackColor = True
        '
        'TerminarProcesoBtn
        '
        Me.TerminarProcesoBtn.Enabled = False
        Me.TerminarProcesoBtn.Location = New System.Drawing.Point(166, 83)
        Me.TerminarProcesoBtn.Name = "TerminarProcesoBtn"
        Me.TerminarProcesoBtn.Size = New System.Drawing.Size(138, 58)
        Me.TerminarProcesoBtn.TabIndex = 1
        Me.TerminarProcesoBtn.Text = "Terminar Proceso"
        Me.TerminarProcesoBtn.UseVisualStyleBackColor = True
        '
        'ResultadosBtn
        '
        Me.ResultadosBtn.Location = New System.Drawing.Point(314, 83)
        Me.ResultadosBtn.Name = "ResultadosBtn"
        Me.ResultadosBtn.Size = New System.Drawing.Size(138, 58)
        Me.ResultadosBtn.TabIndex = 2
        Me.ResultadosBtn.Text = "Ver Resultados"
        Me.ResultadosBtn.UseVisualStyleBackColor = True
        '
        'ReiniciarDatosproceso
        '
        Me.ReiniciarDatosproceso.Location = New System.Drawing.Point(18, 19)
        Me.ReiniciarDatosproceso.Name = "ReiniciarDatosproceso"
        Me.ReiniciarDatosproceso.Size = New System.Drawing.Size(434, 58)
        Me.ReiniciarDatosproceso.TabIndex = 3
        Me.ReiniciarDatosproceso.Text = "Reiniciar datos para el proceso"
        Me.ReiniciarDatosproceso.UseVisualStyleBackColor = True
        '
        'EstadoMesaUc1
        '
        Me.EstadoMesaUc1.BackColor = System.Drawing.Color.White
        Me.EstadoMesaUc1.Font = New System.Drawing.Font("Segoe UI Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoMesaUc1.Location = New System.Drawing.Point(18, 150)
        Me.EstadoMesaUc1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.EstadoMesaUc1.Mesa = Nothing
        Me.EstadoMesaUc1.Name = "EstadoMesaUc1"
        Me.EstadoMesaUc1.Size = New System.Drawing.Size(138, 132)
        Me.EstadoMesaUc1.TabIndex = 4
        '
        'EstadoMesaUc2
        '
        Me.EstadoMesaUc2.BackColor = System.Drawing.Color.White
        Me.EstadoMesaUc2.Font = New System.Drawing.Font("Segoe UI Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoMesaUc2.Location = New System.Drawing.Point(166, 150)
        Me.EstadoMesaUc2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.EstadoMesaUc2.Mesa = Nothing
        Me.EstadoMesaUc2.Name = "EstadoMesaUc2"
        Me.EstadoMesaUc2.Size = New System.Drawing.Size(138, 132)
        Me.EstadoMesaUc2.TabIndex = 5
        '
        'EstadoMesaUc3
        '
        Me.EstadoMesaUc3.BackColor = System.Drawing.Color.White
        Me.EstadoMesaUc3.Font = New System.Drawing.Font("Segoe UI Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoMesaUc3.Location = New System.Drawing.Point(314, 150)
        Me.EstadoMesaUc3.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.EstadoMesaUc3.Mesa = Nothing
        Me.EstadoMesaUc3.Name = "EstadoMesaUc3"
        Me.EstadoMesaUc3.Size = New System.Drawing.Size(138, 132)
        Me.EstadoMesaUc3.TabIndex = 6
        '
        'EstadoMesaUc4
        '
        Me.EstadoMesaUc4.BackColor = System.Drawing.Color.White
        Me.EstadoMesaUc4.Font = New System.Drawing.Font("Segoe UI Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoMesaUc4.Location = New System.Drawing.Point(18, 294)
        Me.EstadoMesaUc4.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.EstadoMesaUc4.Mesa = Nothing
        Me.EstadoMesaUc4.Name = "EstadoMesaUc4"
        Me.EstadoMesaUc4.Size = New System.Drawing.Size(138, 132)
        Me.EstadoMesaUc4.TabIndex = 7
        '
        'EstadoMesaUc5
        '
        Me.EstadoMesaUc5.BackColor = System.Drawing.Color.White
        Me.EstadoMesaUc5.Font = New System.Drawing.Font("Segoe UI Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoMesaUc5.Location = New System.Drawing.Point(166, 294)
        Me.EstadoMesaUc5.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.EstadoMesaUc5.Mesa = Nothing
        Me.EstadoMesaUc5.Name = "EstadoMesaUc5"
        Me.EstadoMesaUc5.Size = New System.Drawing.Size(138, 132)
        Me.EstadoMesaUc5.TabIndex = 8
        '
        'EstadoMesaUc6
        '
        Me.EstadoMesaUc6.BackColor = System.Drawing.Color.White
        Me.EstadoMesaUc6.Font = New System.Drawing.Font("Segoe UI Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoMesaUc6.Location = New System.Drawing.Point(314, 294)
        Me.EstadoMesaUc6.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.EstadoMesaUc6.Mesa = Nothing
        Me.EstadoMesaUc6.Name = "EstadoMesaUc6"
        Me.EstadoMesaUc6.Size = New System.Drawing.Size(138, 132)
        Me.EstadoMesaUc6.TabIndex = 9
        '
        'MonitoreoProcesoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 456)
        Me.Controls.Add(Me.EstadoMesaUc6)
        Me.Controls.Add(Me.EstadoMesaUc5)
        Me.Controls.Add(Me.EstadoMesaUc4)
        Me.Controls.Add(Me.EstadoMesaUc3)
        Me.Controls.Add(Me.EstadoMesaUc2)
        Me.Controls.Add(Me.EstadoMesaUc1)
        Me.Controls.Add(Me.ReiniciarDatosproceso)
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
    Friend WithEvents ReiniciarDatosproceso As Button
    Friend WithEvents EstadoMesaUc1 As CommonWinForm.EstadoMesaUc
    Friend WithEvents EstadoMesaUc2 As CommonWinForm.EstadoMesaUc
    Friend WithEvents EstadoMesaUc3 As CommonWinForm.EstadoMesaUc
    Friend WithEvents EstadoMesaUc4 As CommonWinForm.EstadoMesaUc
    Friend WithEvents EstadoMesaUc5 As CommonWinForm.EstadoMesaUc
    Friend WithEvents EstadoMesaUc6 As CommonWinForm.EstadoMesaUc
End Class
