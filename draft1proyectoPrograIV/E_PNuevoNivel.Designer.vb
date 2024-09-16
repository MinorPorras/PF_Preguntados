<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_PNuevoNivel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_PNuevoNivel))
        Me.BTN_AgregarNuevaNivel = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNRegresaNuevoNivel = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_NombreNuevoNivel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_AgregarNuevaNivel
        '
        Me.BTN_AgregarNuevaNivel.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AgregarNuevaNivel.BorderColor = System.Drawing.Color.White
        Me.BTN_AgregarNuevaNivel.BorderRadius = 25
        Me.BTN_AgregarNuevaNivel.BorderThickness = 1
        Me.BTN_AgregarNuevaNivel.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_AgregarNuevaNivel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarNuevaNivel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarNuevaNivel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AgregarNuevaNivel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AgregarNuevaNivel.Enabled = False
        Me.BTN_AgregarNuevaNivel.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_AgregarNuevaNivel.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AgregarNuevaNivel.ForeColor = System.Drawing.Color.White
        Me.BTN_AgregarNuevaNivel.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_AgregarNuevaNivel.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_AgregarNuevaNivel.Location = New System.Drawing.Point(259, 285)
        Me.BTN_AgregarNuevaNivel.Name = "BTN_AgregarNuevaNivel"
        Me.BTN_AgregarNuevaNivel.Size = New System.Drawing.Size(188, 72)
        Me.BTN_AgregarNuevaNivel.TabIndex = 115
        Me.BTN_AgregarNuevaNivel.Text = "Agregar"
        '
        'BTNRegresaNuevoNivel
        '
        Me.BTNRegresaNuevoNivel.BackColor = System.Drawing.Color.Transparent
        Me.BTNRegresaNuevoNivel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTNRegresaNuevoNivel.BorderRadius = 25
        Me.BTNRegresaNuevoNivel.BorderThickness = 1
        Me.BTNRegresaNuevoNivel.CustomBorderColor = System.Drawing.Color.White
        Me.BTNRegresaNuevoNivel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNRegresaNuevoNivel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNRegresaNuevoNivel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNRegresaNuevoNivel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNRegresaNuevoNivel.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTNRegresaNuevoNivel.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRegresaNuevoNivel.ForeColor = System.Drawing.Color.White
        Me.BTNRegresaNuevoNivel.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTNRegresaNuevoNivel.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTNRegresaNuevoNivel.Location = New System.Drawing.Point(29, 285)
        Me.BTNRegresaNuevoNivel.Name = "BTNRegresaNuevoNivel"
        Me.BTNRegresaNuevoNivel.Size = New System.Drawing.Size(188, 72)
        Me.BTNRegresaNuevoNivel.TabIndex = 114
        Me.BTNRegresaNuevoNivel.Text = "Regresar"
        '
        'TXT_NombreNuevoNivel
        '
        Me.TXT_NombreNuevoNivel.AutoSize = True
        Me.TXT_NombreNuevoNivel.BackColor = System.Drawing.Color.Transparent
        Me.TXT_NombreNuevoNivel.BorderColor = System.Drawing.Color.Transparent
        Me.TXT_NombreNuevoNivel.BorderRadius = 25
        Me.TXT_NombreNuevoNivel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NombreNuevoNivel.DefaultText = ""
        Me.TXT_NombreNuevoNivel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NombreNuevoNivel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NombreNuevoNivel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreNuevoNivel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreNuevoNivel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreNuevoNivel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_NombreNuevoNivel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreNuevoNivel.Location = New System.Drawing.Point(29, 221)
        Me.TXT_NombreNuevoNivel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_NombreNuevoNivel.MaxLength = 30
        Me.TXT_NombreNuevoNivel.Name = "TXT_NombreNuevoNivel"
        Me.TXT_NombreNuevoNivel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NombreNuevoNivel.PlaceholderText = "Max 30 caracteres"
        Me.TXT_NombreNuevoNivel.SelectedText = ""
        Me.TXT_NombreNuevoNivel.Size = New System.Drawing.Size(418, 47)
        Me.TXT_NombreNuevoNivel.TabIndex = 113
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloNuevoNivel
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(58, -76)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(372, 344)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 112
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(54, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 147
        Me.Label3.Text = "Nombre:"
        '
        'E_PNuevoNivel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.FondoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 386)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTN_AgregarNuevaNivel)
        Me.Controls.Add(Me.BTNRegresaNuevoNivel)
        Me.Controls.Add(Me.TXT_NombreNuevoNivel)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_PNuevoNivel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo nivel"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_AgregarNuevaNivel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNRegresaNuevoNivel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_NombreNuevoNivel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label3 As Label
End Class
