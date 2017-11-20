<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SeccionesDlg
    Inherits CommonWinForm.MasterForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeccionesDlg))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.GradoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GradoComboBox = New System.Windows.Forms.ComboBox()
        Me.SeccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeccionDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdSeccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountAlumnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mesa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeccionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AlumnosBtn = New System.Windows.Forms.Button()
        Me.MesaBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GradoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeccionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeccionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SeccionBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(313, 292)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(171, 38)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(77, 30)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(89, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(78, 30)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'GradoBindingSource
        '
        Me.GradoBindingSource.DataSource = GetType(Elecciones.DataModel.Grado)
        '
        'GradoComboBox
        '
        Me.GradoComboBox.DataSource = Me.GradoBindingSource
        Me.GradoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GradoComboBox.FormattingEnabled = True
        Me.GradoComboBox.Location = New System.Drawing.Point(74, 22)
        Me.GradoComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GradoComboBox.Name = "GradoComboBox"
        Me.GradoComboBox.Size = New System.Drawing.Size(161, 25)
        Me.GradoComboBox.TabIndex = 1
        '
        'SeccionBindingSource
        '
        Me.SeccionBindingSource.DataMember = "Secciones"
        Me.SeccionBindingSource.DataSource = Me.GradoBindingSource
        '
        'SeccionDataGridView
        '
        Me.SeccionDataGridView.AutoGenerateColumns = False
        Me.SeccionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SeccionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSeccionDataGridViewTextBoxColumn, Me.CountAlumnos, Me.Mesa})
        Me.SeccionDataGridView.DataSource = Me.SeccionBindingSource
        Me.SeccionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SeccionDataGridView.Location = New System.Drawing.Point(3, 45)
        Me.SeccionDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SeccionDataGridView.Name = "SeccionDataGridView"
        Me.SeccionDataGridView.ReadOnly = True
        Me.SeccionDataGridView.Size = New System.Drawing.Size(458, 189)
        Me.SeccionDataGridView.TabIndex = 0
        '
        'IdSeccionDataGridViewTextBoxColumn
        '
        Me.IdSeccionDataGridViewTextBoxColumn.DataPropertyName = "IdSeccion"
        Me.IdSeccionDataGridViewTextBoxColumn.HeaderText = "Seccion"
        Me.IdSeccionDataGridViewTextBoxColumn.Name = "IdSeccionDataGridViewTextBoxColumn"
        Me.IdSeccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdSeccionDataGridViewTextBoxColumn.Width = 120
        '
        'CountAlumnos
        '
        Me.CountAlumnos.DataPropertyName = "CountAlumnos"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.CountAlumnos.DefaultCellStyle = DataGridViewCellStyle1
        Me.CountAlumnos.HeaderText = "# Alum."
        Me.CountAlumnos.Name = "CountAlumnos"
        Me.CountAlumnos.ReadOnly = True
        Me.CountAlumnos.Width = 120
        '
        'Mesa
        '
        Me.Mesa.DataPropertyName = "IdMesa"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.Format = "D5"
        Me.Mesa.DefaultCellStyle = DataGridViewCellStyle2
        Me.Mesa.HeaderText = "Mesa"
        Me.Mesa.Name = "Mesa"
        Me.Mesa.ReadOnly = True
        Me.Mesa.Width = 120
        '
        'SeccionBindingNavigator
        '
        Me.SeccionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SeccionBindingNavigator.BindingSource = Me.SeccionBindingSource
        Me.SeccionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SeccionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SeccionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.SeccionBindingNavigator.Location = New System.Drawing.Point(3, 20)
        Me.SeccionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SeccionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SeccionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SeccionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SeccionBindingNavigator.Name = "SeccionBindingNavigator"
        Me.SeccionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SeccionBindingNavigator.Size = New System.Drawing.Size(458, 25)
        Me.SeccionBindingNavigator.TabIndex = 1
        Me.SeccionBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(44, 23)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SeccionDataGridView)
        Me.GroupBox1.Controls.Add(Me.SeccionBindingNavigator)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 50)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(464, 236)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Secciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grado:"
        '
        'AlumnosBtn
        '
        Me.AlumnosBtn.Enabled = False
        Me.AlumnosBtn.Location = New System.Drawing.Point(21, 296)
        Me.AlumnosBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AlumnosBtn.Name = "AlumnosBtn"
        Me.AlumnosBtn.Size = New System.Drawing.Size(112, 30)
        Me.AlumnosBtn.TabIndex = 3
        Me.AlumnosBtn.Text = "Alumnos"
        Me.AlumnosBtn.UseVisualStyleBackColor = True
        '
        'MesaBtn
        '
        Me.MesaBtn.Enabled = False
        Me.MesaBtn.Location = New System.Drawing.Point(139, 296)
        Me.MesaBtn.Name = "MesaBtn"
        Me.MesaBtn.Size = New System.Drawing.Size(116, 30)
        Me.MesaBtn.TabIndex = 4
        Me.MesaBtn.Text = "Mesa"
        Me.MesaBtn.UseVisualStyleBackColor = True
        '
        'SeccionesDlg
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(498, 339)
        Me.Controls.Add(Me.MesaBtn)
        Me.Controls.Add(Me.AlumnosBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GradoComboBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SeccionesDlg"
        Me.Padding = New System.Windows.Forms.Padding(18, 19, 18, 19)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Secciones"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.GradoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeccionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeccionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SeccionBindingNavigator.ResumeLayout(False)
        Me.SeccionBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GradoBindingSource As BindingSource
    Friend WithEvents GradoComboBox As ComboBox
    Friend WithEvents SeccionBindingSource As BindingSource
    Friend WithEvents SeccionDataGridView As DataGridView
    Friend WithEvents SeccionBindingNavigator As BindingNavigator
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
    Friend WithEvents Label1 As Label
    Friend WithEvents AlumnosBtn As Button
    Friend WithEvents MesaBtn As Button
    Friend WithEvents IdSeccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountAlumnos As DataGridViewTextBoxColumn
    Friend WithEvents Mesa As DataGridViewTextBoxColumn
End Class
