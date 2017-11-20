<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlumnosDlg
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
        Dim DniLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim GeneroLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlumnosDlg))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosNombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TipoParticipanteLabel1 = New System.Windows.Forms.Label()
        Me.GeneroComboBox = New System.Windows.Forms.ComboBox()
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.DniTextBox = New System.Windows.Forms.TextBox()
        Me.SeccionComboBox = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        DniLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        GeneroLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DniLabel
        '
        DniLabel.AutoSize = True
        DniLabel.Location = New System.Drawing.Point(49, 27)
        DniLabel.Name = "DniLabel"
        DniLabel.Size = New System.Drawing.Size(31, 19)
        DniLabel.TabIndex = 0
        DniLabel.Text = "Dni:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(14, 58)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(66, 19)
        ApellidosLabel.TabIndex = 2
        ApellidosLabel.Text = "Apellidos:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(13, 89)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(67, 19)
        NombresLabel.TabIndex = 4
        NombresLabel.Text = "Nombres:"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.Location = New System.Drawing.Point(14, 123)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(55, 19)
        GeneroLabel.TabIndex = 10
        GeneroLabel.Text = "Genero:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(339, 545)
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
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "Alumnos"
        Me.AlumnosBindingSource.DataSource = Me.SeccionBindingSource
        '
        'SeccionBindingSource
        '
        Me.SeccionBindingSource.DataSource = GetType(Elecciones.DataModel.Seccion)
        '
        'AlumnosDataGridView
        '
        Me.AlumnosDataGridView.AutoGenerateColumns = False
        Me.AlumnosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AlumnosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DniDataGridViewTextBoxColumn, Me.ApellidosNombresDataGridViewTextBoxColumn, Me.GeneroDataGridViewTextBoxColumn})
        Me.AlumnosDataGridView.DataSource = Me.AlumnosBindingSource
        Me.AlumnosDataGridView.Location = New System.Drawing.Point(18, 80)
        Me.AlumnosDataGridView.MultiSelect = False
        Me.AlumnosDataGridView.Name = "AlumnosDataGridView"
        Me.AlumnosDataGridView.ReadOnly = True
        Me.AlumnosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AlumnosDataGridView.Size = New System.Drawing.Size(491, 224)
        Me.AlumnosDataGridView.TabIndex = 1
        '
        'DniDataGridViewTextBoxColumn
        '
        Me.DniDataGridViewTextBoxColumn.DataPropertyName = "Dni"
        Me.DniDataGridViewTextBoxColumn.HeaderText = "Dni"
        Me.DniDataGridViewTextBoxColumn.Name = "DniDataGridViewTextBoxColumn"
        Me.DniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidosNombresDataGridViewTextBoxColumn
        '
        Me.ApellidosNombresDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ApellidosNombresDataGridViewTextBoxColumn.DataPropertyName = "ApellidosNombres"
        Me.ApellidosNombresDataGridViewTextBoxColumn.HeaderText = "ApellidosNombres"
        Me.ApellidosNombresDataGridViewTextBoxColumn.Name = "ApellidosNombresDataGridViewTextBoxColumn"
        Me.ApellidosNombresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GeneroDataGridViewTextBoxColumn
        '
        Me.GeneroDataGridViewTextBoxColumn.DataPropertyName = "Genero"
        Me.GeneroDataGridViewTextBoxColumn.HeaderText = "Genero"
        Me.GeneroDataGridViewTextBoxColumn.Name = "GeneroDataGridViewTextBoxColumn"
        Me.GeneroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.AlumnosBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(18, 52)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(257, 25)
        Me.BindingNavigator1.TabIndex = 2
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TipoParticipanteLabel1)
        Me.GroupBox1.Controls.Add(GeneroLabel)
        Me.GroupBox1.Controls.Add(Me.GeneroComboBox)
        Me.GroupBox1.Controls.Add(Me.FotoPictureBox)
        Me.GroupBox1.Controls.Add(NombresLabel)
        Me.GroupBox1.Controls.Add(Me.NombresTextBox)
        Me.GroupBox1.Controls.Add(ApellidosLabel)
        Me.GroupBox1.Controls.Add(Me.ApellidosTextBox)
        Me.GroupBox1.Controls.Add(DniLabel)
        Me.GroupBox1.Controls.Add(Me.DniTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 310)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 224)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Alumno"
        '
        'TipoParticipanteLabel1
        '
        Me.TipoParticipanteLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "TipoParticipante", True))
        Me.TipoParticipanteLabel1.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoParticipanteLabel1.Location = New System.Drawing.Point(6, 181)
        Me.TipoParticipanteLabel1.Name = "TipoParticipanteLabel1"
        Me.TipoParticipanteLabel1.Size = New System.Drawing.Size(481, 28)
        Me.TipoParticipanteLabel1.TabIndex = 12
        Me.TipoParticipanteLabel1.Text = "Label1"
        Me.TipoParticipanteLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GeneroComboBox
        '
        Me.GeneroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "Genero", True))
        Me.GeneroComboBox.FormattingEnabled = True
        Me.GeneroComboBox.Location = New System.Drawing.Point(86, 117)
        Me.GeneroComboBox.Name = "GeneroComboBox"
        Me.GeneroComboBox.Size = New System.Drawing.Size(283, 25)
        Me.GeneroComboBox.TabIndex = 11
        '
        'FotoPictureBox
        '
        Me.FotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.AlumnosBindingSource, "Foto", True))
        Me.FotoPictureBox.Location = New System.Drawing.Point(379, 24)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(108, 144)
        Me.FotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FotoPictureBox.TabIndex = 9
        Me.FotoPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.FotoPictureBox, "Doble click para cambiar...")
        '
        'NombresTextBox
        '
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "Nombres", True))
        Me.NombresTextBox.Location = New System.Drawing.Point(86, 86)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(283, 25)
        Me.NombresTextBox.TabIndex = 5
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(86, 55)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(283, 25)
        Me.ApellidosTextBox.TabIndex = 3
        '
        'DniTextBox
        '
        Me.DniTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "Dni", True))
        Me.DniTextBox.Location = New System.Drawing.Point(86, 24)
        Me.DniTextBox.Name = "DniTextBox"
        Me.DniTextBox.Size = New System.Drawing.Size(283, 25)
        Me.DniTextBox.TabIndex = 1
        '
        'SeccionComboBox
        '
        Me.SeccionComboBox.DataSource = Me.SeccionBindingSource
        Me.SeccionComboBox.DisplayMember = "DescSeccion"
        Me.SeccionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SeccionComboBox.FormattingEnabled = True
        Me.SeccionComboBox.Location = New System.Drawing.Point(18, 15)
        Me.SeccionComboBox.Name = "SeccionComboBox"
        Me.SeccionComboBox.Size = New System.Drawing.Size(491, 25)
        Me.SeccionComboBox.TabIndex = 5
        Me.SeccionComboBox.ValueMember = "Alumnos"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 1
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Fotografia"
        '
        'AlumnosDlg
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(521, 595)
        Me.Controls.Add(Me.SeccionComboBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.AlumnosDataGridView)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AlumnosDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Alumnos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents SeccionBindingSource As BindingSource
    Friend WithEvents AlumnosBindingSource As BindingSource
    Friend WithEvents AlumnosDataGridView As DataGridView
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FotoPictureBox As PictureBox
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents DniTextBox As TextBox
    Friend WithEvents SeccionComboBox As ComboBox
    Friend WithEvents GeneroComboBox As ComboBox
    Friend WithEvents DniDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosNombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GeneroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoParticipanteLabel1 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
