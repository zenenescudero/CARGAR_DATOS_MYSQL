<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.gridtabla = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SERVIDOR = New System.Windows.Forms.TextBox()
        Me.BASE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.USUARIO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PASS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.REGISTROS = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.puerto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TABLA = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.gridtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridtabla
        '
        Me.gridtabla.AllowUserToAddRows = False
        Me.gridtabla.AllowUserToDeleteRows = False
        Me.gridtabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridtabla.Location = New System.Drawing.Point(13, 135)
        Me.gridtabla.Margin = New System.Windows.Forms.Padding(4)
        Me.gridtabla.Name = "gridtabla"
        Me.gridtabla.RowHeadersVisible = False
        Me.gridtabla.Size = New System.Drawing.Size(960, 328)
        Me.gridtabla.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SERVIDOR"
        '
        'SERVIDOR
        '
        Me.SERVIDOR.Location = New System.Drawing.Point(89, 13)
        Me.SERVIDOR.Name = "SERVIDOR"
        Me.SERVIDOR.Size = New System.Drawing.Size(158, 24)
        Me.SERVIDOR.TabIndex = 2
        Me.SERVIDOR.Text = "localhost"
        '
        'BASE
        '
        Me.BASE.Location = New System.Drawing.Point(89, 49)
        Me.BASE.Name = "BASE"
        Me.BASE.Size = New System.Drawing.Size(158, 24)
        Me.BASE.TabIndex = 4
        Me.BASE.Text = "aclaraciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "BASE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 18)
        Me.Label3.TabIndex = 5
        '
        'USUARIO
        '
        Me.USUARIO.Location = New System.Drawing.Point(334, 7)
        Me.USUARIO.Name = "USUARIO"
        Me.USUARIO.Size = New System.Drawing.Size(158, 24)
        Me.USUARIO.TabIndex = 8
        Me.USUARIO.Text = "root"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(253, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "USUARIO"
        '
        'PASS
        '
        Me.PASS.Location = New System.Drawing.Point(334, 38)
        Me.PASS.Name = "PASS"
        Me.PASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.PASS.Size = New System.Drawing.Size(158, 24)
        Me.PASS.TabIndex = 10
        Me.PASS.Text = "zenen"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(253, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "PASS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "TABLA"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(498, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 29)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "GUARDAR EN DB"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(784, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 47)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Exportar a Excel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(667, 58)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 52)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Cargar Excel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'REGISTROS
        '
        Me.REGISTROS.AutoSize = True
        Me.REGISTROS.Location = New System.Drawing.Point(781, 87)
        Me.REGISTROS.Name = "REGISTROS"
        Me.REGISTROS.Size = New System.Drawing.Size(16, 18)
        Me.REGISTROS.TabIndex = 16
        Me.REGISTROS.Text = "0"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(498, 108)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(139, 22)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "Borrar existentes"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(667, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 47)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Consultar Datos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(420, 73)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 47)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Lipiar grilla"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(498, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(94, 47)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Conectar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'puerto
        '
        Me.puerto.Location = New System.Drawing.Point(334, 75)
        Me.puerto.Name = "puerto"
        Me.puerto.Size = New System.Drawing.Size(70, 24)
        Me.puerto.TabIndex = 22
        Me.puerto.Text = "3306"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(253, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 18)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Puerto"
        '
        'TABLA
        '
        Me.TABLA.Location = New System.Drawing.Point(88, 78)
        Me.TABLA.Name = "TABLA"
        Me.TABLA.Size = New System.Drawing.Size(158, 24)
        Me.TABLA.TabIndex = 6
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(88, 105)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(212, 25)
        Me.Button7.TabIndex = 23
        Me.Button7.Text = "Descripcion de campos"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 521)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.puerto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.REGISTROS)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PASS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.USUARIO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TABLA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BASE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SERVIDOR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gridtabla)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridtabla As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SERVIDOR As System.Windows.Forms.TextBox
    Friend WithEvents BASE As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents USUARIO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PASS As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents REGISTROS As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents puerto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TABLA As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button

End Class
