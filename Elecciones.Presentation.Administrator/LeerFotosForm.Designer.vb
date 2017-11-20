<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeerFotosForm
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.DashBoardItemUc1 = New Elecciones.Presentation.CommonWinForm.DashBoardItemUc()
        Me.DashBoardItemUc2 = New Elecciones.Presentation.CommonWinForm.DashBoardItemUc()
        Me.DashBoardItemUc3 = New Elecciones.Presentation.CommonWinForm.DashBoardItemUc()
        Me.DashBoardItemUc4 = New Elecciones.Presentation.CommonWinForm.DashBoardItemUc()
        Me.DashBoardItemUc6 = New Elecciones.Presentation.CommonWinForm.DashBoardItemUc()
        Me.DashBoardItemUc7 = New Elecciones.Presentation.CommonWinForm.DashBoardItemUc()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(428, 25)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(452, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Seleccionar carpeta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(595, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 25)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Ejecutar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(18, 50)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(670, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 3
        '
        'DashBoardItemUc1
        '
        Me.DashBoardItemUc1.BackColor = System.Drawing.Color.Transparent
        Me.DashBoardItemUc1.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.DashBoardItemUc1.Formato = Nothing
        Me.DashBoardItemUc1.Location = New System.Drawing.Point(18, 80)
        Me.DashBoardItemUc1.Margin = New System.Windows.Forms.Padding(4)
        Me.DashBoardItemUc1.Name = "DashBoardItemUc1"
        Me.DashBoardItemUc1.Size = New System.Drawing.Size(145, 106)
        Me.DashBoardItemUc1.TabIndex = 4
        Me.DashBoardItemUc1.Titulo = "Imagenes encontradas"
        Me.DashBoardItemUc1.Valor = 0R
        '
        'DashBoardItemUc2
        '
        Me.DashBoardItemUc2.BackColor = System.Drawing.Color.Transparent
        Me.DashBoardItemUc2.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.DashBoardItemUc2.Formato = Nothing
        Me.DashBoardItemUc2.Location = New System.Drawing.Point(171, 80)
        Me.DashBoardItemUc2.Margin = New System.Windows.Forms.Padding(4)
        Me.DashBoardItemUc2.Name = "DashBoardItemUc2"
        Me.DashBoardItemUc2.Size = New System.Drawing.Size(144, 106)
        Me.DashBoardItemUc2.TabIndex = 5
        Me.DashBoardItemUc2.Titulo = "Imagenes procesadas"
        Me.DashBoardItemUc2.Valor = 0R
        '
        'DashBoardItemUc3
        '
        Me.DashBoardItemUc3.BackColor = System.Drawing.Color.Transparent
        Me.DashBoardItemUc3.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.DashBoardItemUc3.Formato = "P"
        Me.DashBoardItemUc3.Location = New System.Drawing.Point(475, 80)
        Me.DashBoardItemUc3.Margin = New System.Windows.Forms.Padding(4)
        Me.DashBoardItemUc3.Name = "DashBoardItemUc3"
        Me.DashBoardItemUc3.Size = New System.Drawing.Size(213, 106)
        Me.DashBoardItemUc3.TabIndex = 6
        Me.DashBoardItemUc3.Titulo = "Avance"
        Me.DashBoardItemUc3.Valor = 0R
        '
        'DashBoardItemUc4
        '
        Me.DashBoardItemUc4.BackColor = System.Drawing.Color.Transparent
        Me.DashBoardItemUc4.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.DashBoardItemUc4.Formato = Nothing
        Me.DashBoardItemUc4.Location = New System.Drawing.Point(18, 194)
        Me.DashBoardItemUc4.Margin = New System.Windows.Forms.Padding(4)
        Me.DashBoardItemUc4.Name = "DashBoardItemUc4"
        Me.DashBoardItemUc4.Size = New System.Drawing.Size(145, 106)
        Me.DashBoardItemUc4.TabIndex = 7
        Me.DashBoardItemUc4.Titulo = "Total de Alumnos"
        Me.DashBoardItemUc4.Valor = 0R
        '
        'DashBoardItemUc6
        '
        Me.DashBoardItemUc6.BackColor = System.Drawing.Color.Transparent
        Me.DashBoardItemUc6.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.DashBoardItemUc6.Formato = Nothing
        Me.DashBoardItemUc6.Location = New System.Drawing.Point(323, 80)
        Me.DashBoardItemUc6.Margin = New System.Windows.Forms.Padding(4)
        Me.DashBoardItemUc6.Name = "DashBoardItemUc6"
        Me.DashBoardItemUc6.Size = New System.Drawing.Size(144, 106)
        Me.DashBoardItemUc6.TabIndex = 9
        Me.DashBoardItemUc6.Titulo = "Imagenes no procesadas"
        Me.DashBoardItemUc6.Valor = 0R
        '
        'DashBoardItemUc7
        '
        Me.DashBoardItemUc7.BackColor = System.Drawing.Color.Transparent
        Me.DashBoardItemUc7.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.DashBoardItemUc7.Formato = Nothing
        Me.DashBoardItemUc7.Location = New System.Drawing.Point(171, 194)
        Me.DashBoardItemUc7.Margin = New System.Windows.Forms.Padding(4)
        Me.DashBoardItemUc7.Name = "DashBoardItemUc7"
        Me.DashBoardItemUc7.Size = New System.Drawing.Size(145, 106)
        Me.DashBoardItemUc7.TabIndex = 10
        Me.DashBoardItemUc7.Titulo = "Alumnos sin Fotografia"
        Me.DashBoardItemUc7.Valor = 0R
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI Light", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(323, 194)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox2.Size = New System.Drawing.Size(366, 106)
        Me.TextBox2.TabIndex = 11
        '
        'LeerFotosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 326)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DashBoardItemUc7)
        Me.Controls.Add(Me.DashBoardItemUc6)
        Me.Controls.Add(Me.DashBoardItemUc4)
        Me.Controls.Add(Me.DashBoardItemUc3)
        Me.Controls.Add(Me.DashBoardItemUc2)
        Me.Controls.Add(Me.DashBoardItemUc1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "LeerFotosForm"
        Me.Padding = New System.Windows.Forms.Padding(15, 16, 15, 16)
        Me.Text = "LeerFotosForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents DashBoardItemUc1 As CommonWinForm.DashBoardItemUc
    Friend WithEvents DashBoardItemUc2 As CommonWinForm.DashBoardItemUc
    Friend WithEvents DashBoardItemUc3 As CommonWinForm.DashBoardItemUc
    Friend WithEvents DashBoardItemUc4 As CommonWinForm.DashBoardItemUc
    Friend WithEvents DashBoardItemUc5 As CommonWinForm.DashBoardItemUc
    Friend WithEvents DashBoardItemUc6 As CommonWinForm.DashBoardItemUc
    Friend WithEvents DashBoardItemUc7 As CommonWinForm.DashBoardItemUc
    Friend WithEvents TextBox2 As TextBox
End Class
