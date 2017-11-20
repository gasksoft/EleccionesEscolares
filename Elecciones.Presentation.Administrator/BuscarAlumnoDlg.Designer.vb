<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarAlumnoDlg
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
        Me.components = New System.ComponentModel.Container()
        Dim ApellidosNombresLabel As System.Windows.Forms.Label
        Dim DescSeccionLabel As System.Windows.Forms.Label
        Dim DniLabel As System.Windows.Forms.Label
        Dim TipoParticipanteLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.FotografiaPictureBox = New System.Windows.Forms.PictureBox()
        Me.AlumnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApellidosNombresLabel1 = New System.Windows.Forms.Label()
        Me.DescSeccionLabel1 = New System.Windows.Forms.Label()
        Me.DniLabel1 = New System.Windows.Forms.Label()
        Me.TipoParticipanteLabel1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.BuscarTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        ApellidosNombresLabel = New System.Windows.Forms.Label()
        DescSeccionLabel = New System.Windows.Forms.Label()
        DniLabel = New System.Windows.Forms.Label()
        TipoParticipanteLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.FotografiaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ApellidosNombresLabel
        '
        ApellidosNombresLabel.AutoSize = True
        ApellidosNombresLabel.Location = New System.Drawing.Point(6, 21)
        ApellidosNombresLabel.Name = "ApellidosNombresLabel"
        ApellidosNombresLabel.Size = New System.Drawing.Size(125, 19)
        ApellidosNombresLabel.TabIndex = 3
        ApellidosNombresLabel.Text = "Apellidos Nombres:"
        '
        'DescSeccionLabel
        '
        DescSeccionLabel.AutoSize = True
        DescSeccionLabel.Location = New System.Drawing.Point(6, 86)
        DescSeccionLabel.Name = "DescSeccionLabel"
        DescSeccionLabel.Size = New System.Drawing.Size(56, 19)
        DescSeccionLabel.TabIndex = 4
        DescSeccionLabel.Text = "Seccion:"
        '
        'DniLabel
        '
        DniLabel.AutoSize = True
        DniLabel.Location = New System.Drawing.Point(6, 63)
        DniLabel.Name = "DniLabel"
        DniLabel.Size = New System.Drawing.Size(31, 19)
        DniLabel.TabIndex = 6
        DniLabel.Text = "Dni:"
        '
        'TipoParticipanteLabel
        '
        TipoParticipanteLabel.AutoSize = True
        TipoParticipanteLabel.Location = New System.Drawing.Point(6, 109)
        TipoParticipanteLabel.Name = "TipoParticipanteLabel"
        TipoParticipanteLabel.Size = New System.Drawing.Size(111, 19)
        TipoParticipanteLabel.TabIndex = 10
        TipoParticipanteLabel.Text = "Tipo Participante:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(241, 289)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 38)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Enabled = False
        Me.OK_Button.Location = New System.Drawing.Point(3, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(78, 30)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(88, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(78, 30)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'FotografiaPictureBox
        '
        Me.FotografiaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FotografiaPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.AlumnoBindingSource, "Fotografia", True))
        Me.FotografiaPictureBox.Location = New System.Drawing.Point(262, 24)
        Me.FotografiaPictureBox.Name = "FotografiaPictureBox"
        Me.FotografiaPictureBox.Size = New System.Drawing.Size(116, 154)
        Me.FotografiaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FotografiaPictureBox.TabIndex = 3
        Me.FotografiaPictureBox.TabStop = False
        '
        'AlumnoBindingSource
        '
        Me.AlumnoBindingSource.DataSource = GetType(Elecciones.DataModel.Alumno)
        '
        'ApellidosNombresLabel1
        '
        Me.ApellidosNombresLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnoBindingSource, "ApellidosNombres", True))
        Me.ApellidosNombresLabel1.Location = New System.Drawing.Point(6, 40)
        Me.ApellidosNombresLabel1.Name = "ApellidosNombresLabel1"
        Me.ApellidosNombresLabel1.Size = New System.Drawing.Size(250, 23)
        Me.ApellidosNombresLabel1.TabIndex = 4
        Me.ApellidosNombresLabel1.Text = "(--)"
        '
        'DescSeccionLabel1
        '
        Me.DescSeccionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnoBindingSource, "DescSeccion", True))
        Me.DescSeccionLabel1.Location = New System.Drawing.Point(68, 86)
        Me.DescSeccionLabel1.Name = "DescSeccionLabel1"
        Me.DescSeccionLabel1.Size = New System.Drawing.Size(188, 23)
        Me.DescSeccionLabel1.TabIndex = 5
        Me.DescSeccionLabel1.Text = "(--)"
        '
        'DniLabel1
        '
        Me.DniLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnoBindingSource, "Dni", True))
        Me.DniLabel1.Location = New System.Drawing.Point(43, 63)
        Me.DniLabel1.Name = "DniLabel1"
        Me.DniLabel1.Size = New System.Drawing.Size(100, 23)
        Me.DniLabel1.TabIndex = 7
        Me.DniLabel1.Text = "(--)"
        '
        'TipoParticipanteLabel1
        '
        Me.TipoParticipanteLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnoBindingSource, "TipoParticipante", True))
        Me.TipoParticipanteLabel1.Location = New System.Drawing.Point(123, 109)
        Me.TipoParticipanteLabel1.Name = "TipoParticipanteLabel1"
        Me.TipoParticipanteLabel1.Size = New System.Drawing.Size(133, 23)
        Me.TipoParticipanteLabel1.TabIndex = 11
        Me.TipoParticipanteLabel1.Text = "(--)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Buscar DNI:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BuscarBtn)
        Me.GroupBox1.Controls.Add(Me.BuscarTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 60)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterios"
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Location = New System.Drawing.Point(204, 23)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(75, 26)
        Me.BuscarBtn.TabIndex = 14
        Me.BuscarBtn.Text = "Buscar"
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'BuscarTxt
        '
        Me.BuscarTxt.Location = New System.Drawing.Point(88, 24)
        Me.BuscarTxt.Name = "BuscarTxt"
        Me.BuscarTxt.Size = New System.Drawing.Size(110, 25)
        Me.BuscarTxt.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(ApellidosNombresLabel)
        Me.GroupBox2.Controls.Add(Me.ApellidosNombresLabel1)
        Me.GroupBox2.Controls.Add(Me.FotografiaPictureBox)
        Me.GroupBox2.Controls.Add(TipoParticipanteLabel)
        Me.GroupBox2.Controls.Add(DescSeccionLabel)
        Me.GroupBox2.Controls.Add(Me.TipoParticipanteLabel1)
        Me.GroupBox2.Controls.Add(Me.DescSeccionLabel1)
        Me.GroupBox2.Controls.Add(Me.DniLabel1)
        Me.GroupBox2.Controls.Add(DniLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(389, 189)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'BuscarAlumnoDlg
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(425, 343)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BuscarAlumnoDlg"
        Me.Padding = New System.Windows.Forms.Padding(15, 16, 15, 16)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BuscarAlumno"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.FotografiaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents AlumnoBindingSource As BindingSource
    Friend WithEvents FotografiaPictureBox As PictureBox
    Friend WithEvents ApellidosNombresLabel1 As Label
    Friend WithEvents DescSeccionLabel1 As Label
    Friend WithEvents DniLabel1 As Label
    Friend WithEvents TipoParticipanteLabel1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BuscarBtn As Button
    Friend WithEvents BuscarTxt As TextBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
