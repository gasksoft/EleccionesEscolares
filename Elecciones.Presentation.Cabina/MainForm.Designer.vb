<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cand3Btn = New System.Windows.Forms.Button()
        Me.Cand2Btn = New System.Windows.Forms.Button()
        Me.Cand1Btn = New System.Windows.Forms.Button()
        Me.MiembrosMesaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.MiembrosMesaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(185, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(597, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "86026 - Institucion Educativa Pública Emblematica Santa Inés - Yungay"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(600, 54)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Elecciones Escolares 2017 - 2018"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(271, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(674, 72)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "MESA 0001"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(79, 20)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(18, 205)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1201, 329)
        Me.Panel1.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1201, 329)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1193, 299)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "En Apertura"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1187, 293)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Esperando inicio del proceso..."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.Label10)
        Me.TabPage7.Location = New System.Drawing.Point(4, 26)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1193, 299)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Mesa Cerrada"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Light", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1187, 293)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Mesa Cerrada" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proceso electoral terminado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Espere los resultados con el admin" &
    "istrador"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1193, 299)
        Me.TabPage2.TabIndex = 7
        Me.TabPage2.Text = "En Mesa"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1187, 293)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Esperando votante..."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1193, 299)
        Me.TabPage3.TabIndex = 8
        Me.TabPage3.Text = "En cabina"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cand3Btn, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cand2Btn, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cand1Btn, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 82)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(8)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 281.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1187, 214)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cand3Btn
        '
        Me.Cand3Btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cand3Btn.Font = New System.Drawing.Font("Segoe UI Light", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cand3Btn.Location = New System.Drawing.Point(803, 23)
        Me.Cand3Btn.Margin = New System.Windows.Forms.Padding(15)
        Me.Cand3Btn.Name = "Cand3Btn"
        Me.Cand3Btn.Size = New System.Drawing.Size(361, 168)
        Me.Cand3Btn.TabIndex = 3
        Me.Cand3Btn.Tag = "3"
        Me.Cand3Btn.Text = "Nombre Agrupacion"
        Me.Cand3Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cand3Btn.UseVisualStyleBackColor = True
        '
        'Cand2Btn
        '
        Me.Cand2Btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cand2Btn.Font = New System.Drawing.Font("Segoe UI Light", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cand2Btn.Location = New System.Drawing.Point(413, 23)
        Me.Cand2Btn.Margin = New System.Windows.Forms.Padding(15)
        Me.Cand2Btn.Name = "Cand2Btn"
        Me.Cand2Btn.Size = New System.Drawing.Size(360, 168)
        Me.Cand2Btn.TabIndex = 2
        Me.Cand2Btn.Tag = "2"
        Me.Cand2Btn.Text = "Nombre Agrupacion"
        Me.Cand2Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cand2Btn.UseVisualStyleBackColor = True
        '
        'Cand1Btn
        '
        Me.Cand1Btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cand1Btn.Font = New System.Drawing.Font("Segoe UI Light", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cand1Btn.Location = New System.Drawing.Point(23, 23)
        Me.Cand1Btn.Margin = New System.Windows.Forms.Padding(15)
        Me.Cand1Btn.Name = "Cand1Btn"
        Me.Cand1Btn.Size = New System.Drawing.Size(360, 168)
        Me.Cand1Btn.TabIndex = 1
        Me.Cand1Btn.Tag = "1"
        Me.Cand1Btn.Text = "Nombre Agrupacion"
        Me.Cand1Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cand1Btn.UseVisualStyleBackColor = True
        '
        'MiembrosMesaBindingSource
        '
        Me.MiembrosMesaBindingSource.DataSource = GetType(Elecciones.DataModel.MiembroMesa)
        '
        'AlumnoBindingSource
        '
        Me.AlumnoBindingSource.DataSource = GetType(Elecciones.DataModel.Alumno)
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1187, 79)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nombre del alumno"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 553)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "MainForm"
        Me.Padding = New System.Windows.Forms.Padding(15, 16, 15, 16)
        Me.Text = "Cabina de Votación"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.MiembrosMesaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MiembrosMesaBindingSource As BindingSource
    Friend WithEvents AlumnoBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Cand3Btn As Button
    Friend WithEvents Cand2Btn As Button
    Friend WithEvents Cand1Btn As Button
    Friend WithEvents Label6 As Label
End Class
