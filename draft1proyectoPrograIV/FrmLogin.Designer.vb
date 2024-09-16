<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Logo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.PasswordValid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UserValid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AccessValid = New Guna.UI2.WinForms.Guna2Button()
        Me.ImagenContraseñña = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.FotoUsuario = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.ResetPass = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Contraseña = New System.Windows.Forms.Label()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenContraseñña, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(207, -72)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(399, 339)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 28
        Me.Guna2PictureBox1.TabStop = False
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.ImageRotate = 0!
        Me.Logo.Location = New System.Drawing.Point(11, 11)
        Me.Logo.Margin = New System.Windows.Forms.Padding(2)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(195, 179)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 29
        Me.Logo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(212, 380)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 19)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Tipo de cuenta"
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.AutoRoundedCorners = True
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.BorderColor = System.Drawing.Color.LimeGreen
        Me.Guna2ComboBox1.BorderRadius = 17
        Me.Guna2ComboBox1.BorderThickness = 2
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.Items.AddRange(New Object() {"Estudiante", "Profesor"})
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(207, 402)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(399, 36)
        Me.Guna2ComboBox1.TabIndex = 40
        '
        'PasswordValid
        '
        Me.PasswordValid.AutoRoundedCorners = True
        Me.PasswordValid.AutoSize = True
        Me.PasswordValid.BackColor = System.Drawing.Color.Transparent
        Me.PasswordValid.BorderColor = System.Drawing.Color.LimeGreen
        Me.PasswordValid.BorderRadius = 22
        Me.PasswordValid.BorderThickness = 2
        Me.PasswordValid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordValid.DefaultText = ""
        Me.PasswordValid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordValid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordValid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordValid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordValid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordValid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PasswordValid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordValid.Location = New System.Drawing.Point(207, 297)
        Me.PasswordValid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PasswordValid.Name = "PasswordValid"
        Me.PasswordValid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordValid.PlaceholderText = ""
        Me.PasswordValid.SelectedText = ""
        Me.PasswordValid.Size = New System.Drawing.Size(399, 47)
        Me.PasswordValid.TabIndex = 38
        '
        'UserValid
        '
        Me.UserValid.AutoRoundedCorners = True
        Me.UserValid.AutoSize = True
        Me.UserValid.BackColor = System.Drawing.Color.Transparent
        Me.UserValid.BorderColor = System.Drawing.Color.LimeGreen
        Me.UserValid.BorderRadius = 22
        Me.UserValid.BorderThickness = 2
        Me.UserValid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserValid.DefaultText = ""
        Me.UserValid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserValid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserValid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserValid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserValid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserValid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UserValid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserValid.Location = New System.Drawing.Point(207, 196)
        Me.UserValid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UserValid.Name = "UserValid"
        Me.UserValid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserValid.PlaceholderText = ""
        Me.UserValid.SelectedText = ""
        Me.UserValid.Size = New System.Drawing.Size(399, 47)
        Me.UserValid.TabIndex = 37
        '
        'AccessValid
        '
        Me.AccessValid.BackColor = System.Drawing.Color.Transparent
        Me.AccessValid.BorderColor = System.Drawing.Color.White
        Me.AccessValid.BorderRadius = 25
        Me.AccessValid.BorderThickness = 1
        Me.AccessValid.CustomBorderColor = System.Drawing.Color.White
        Me.AccessValid.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AccessValid.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AccessValid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AccessValid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AccessValid.FillColor = System.Drawing.Color.LimeGreen
        Me.AccessValid.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccessValid.ForeColor = System.Drawing.Color.White
        Me.AccessValid.ImageSize = New System.Drawing.Size(30, 30)
        Me.AccessValid.Location = New System.Drawing.Point(304, 470)
        Me.AccessValid.Name = "AccessValid"
        Me.AccessValid.Size = New System.Drawing.Size(202, 50)
        Me.AccessValid.TabIndex = 36
        Me.AccessValid.Text = "Ingresar"
        '
        'ImagenContraseñña
        '
        Me.ImagenContraseñña.BackColor = System.Drawing.Color.Transparent
        Me.ImagenContraseñña.Image = CType(resources.GetObject("ImagenContraseñña.Image"), System.Drawing.Image)
        Me.ImagenContraseñña.ImageRotate = 0!
        Me.ImagenContraseñña.Location = New System.Drawing.Point(143, 292)
        Me.ImagenContraseñña.Margin = New System.Windows.Forms.Padding(2)
        Me.ImagenContraseñña.Name = "ImagenContraseñña"
        Me.ImagenContraseñña.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ImagenContraseñña.Size = New System.Drawing.Size(48, 52)
        Me.ImagenContraseñña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenContraseñña.TabIndex = 35
        Me.ImagenContraseñña.TabStop = False
        '
        'FotoUsuario
        '
        Me.FotoUsuario.BackColor = System.Drawing.Color.Transparent
        Me.FotoUsuario.Image = CType(resources.GetObject("FotoUsuario.Image"), System.Drawing.Image)
        Me.FotoUsuario.ImageRotate = 0!
        Me.FotoUsuario.Location = New System.Drawing.Point(143, 192)
        Me.FotoUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.FotoUsuario.Name = "FotoUsuario"
        Me.FotoUsuario.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.FotoUsuario.Size = New System.Drawing.Size(48, 52)
        Me.FotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoUsuario.TabIndex = 34
        Me.FotoUsuario.TabStop = False
        '
        'ResetPass
        '
        Me.ResetPass.BackColor = System.Drawing.Color.Transparent
        Me.ResetPass.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetPass.ForeColor = System.Drawing.Color.White
        Me.ResetPass.Location = New System.Drawing.Point(328, 601)
        Me.ResetPass.Margin = New System.Windows.Forms.Padding(2)
        Me.ResetPass.Name = "ResetPass"
        Me.ResetPass.Size = New System.Drawing.Size(173, 21)
        Me.ResetPass.TabIndex = 31
        Me.ResetPass.Text = "Contraseña Olvidada"
        '
        'Contraseña
        '
        Me.Contraseña.AutoSize = True
        Me.Contraseña.BackColor = System.Drawing.Color.Transparent
        Me.Contraseña.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contraseña.ForeColor = System.Drawing.Color.White
        Me.Contraseña.Location = New System.Drawing.Point(212, 270)
        Me.Contraseña.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.Size = New System.Drawing.Size(103, 19)
        Me.Contraseña.TabIndex = 33
        Me.Contraseña.Text = "Contraseña"
        '
        'Usuario
        '
        Me.Usuario.AutoSize = True
        Me.Usuario.BackColor = System.Drawing.Color.Transparent
        Me.Usuario.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.ForeColor = System.Drawing.Color.White
        Me.Usuario.Location = New System.Drawing.Point(212, 169)
        Me.Usuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(75, 19)
        Me.Usuario.TabIndex = 32
        Me.Usuario.Text = "Usuario"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(317, 545)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(173, 21)
        Me.Guna2HtmlLabel1.TabIndex = 43
        Me.Guna2HtmlLabel1.Text = "Contraseña Olvidada"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(143, 386)
        Me.Guna2CirclePictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(48, 52)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 44
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(764, 577)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2ComboBox1)
        Me.Controls.Add(Me.PasswordValid)
        Me.Controls.Add(Me.UserValid)
        Me.Controls.Add(Me.AccessValid)
        Me.Controls.Add(Me.ImagenContraseñña)
        Me.Controls.Add(Me.FotoUsuario)
        Me.Controls.Add(Me.ResetPass)
        Me.Controls.Add(Me.Contraseña)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPrincipal"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenContraseñña, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Logo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents PasswordValid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UserValid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AccessValid As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ImagenContraseñña As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents FotoUsuario As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents ResetPass As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Contraseña As Label
    Friend WithEvents Usuario As Label
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
