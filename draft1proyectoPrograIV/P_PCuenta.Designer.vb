<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_PCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_PCuenta))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PIC_FotoProf = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_CUsuarioProf = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_CCorreoProf = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_CNombreProf = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_RegresarProfNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_GuardarProfNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.CerrarAPP = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.TXT_CClaveProf = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_FotoProf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloCentroDeUsuario
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(180, -83)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(447, 358)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 79
        Me.Guna2PictureBox1.TabStop = False
        '
        'PIC_FotoProf
        '
        Me.PIC_FotoProf.BackColor = System.Drawing.Color.Transparent
        Me.PIC_FotoProf.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PIC_FotoProf.ImageRotate = 0!
        Me.PIC_FotoProf.Location = New System.Drawing.Point(553, 176)
        Me.PIC_FotoProf.Name = "PIC_FotoProf"
        Me.PIC_FotoProf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PIC_FotoProf.Size = New System.Drawing.Size(178, 178)
        Me.PIC_FotoProf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PIC_FotoProf.TabIndex = 80
        Me.PIC_FotoProf.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(68, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 28)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Usuario:"
        '
        'TXT_CUsuarioProf
        '
        Me.TXT_CUsuarioProf.AutoRoundedCorners = True
        Me.TXT_CUsuarioProf.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CUsuarioProf.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_CUsuarioProf.BorderRadius = 17
        Me.TXT_CUsuarioProf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CUsuarioProf.DefaultText = ""
        Me.TXT_CUsuarioProf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CUsuarioProf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CUsuarioProf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CUsuarioProf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CUsuarioProf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CUsuarioProf.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CUsuarioProf.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CUsuarioProf.Location = New System.Drawing.Point(180, 199)
        Me.TXT_CUsuarioProf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CUsuarioProf.Name = "TXT_CUsuarioProf"
        Me.TXT_CUsuarioProf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CUsuarioProf.PlaceholderText = ""
        Me.TXT_CUsuarioProf.ReadOnly = True
        Me.TXT_CUsuarioProf.SelectedText = ""
        Me.TXT_CUsuarioProf.Size = New System.Drawing.Size(367, 36)
        Me.TXT_CUsuarioProf.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(75, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 28)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Correo:"
        '
        'TXT_CCorreoProf
        '
        Me.TXT_CCorreoProf.AutoRoundedCorners = True
        Me.TXT_CCorreoProf.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CCorreoProf.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_CCorreoProf.BorderRadius = 17
        Me.TXT_CCorreoProf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CCorreoProf.DefaultText = ""
        Me.TXT_CCorreoProf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CCorreoProf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CCorreoProf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCorreoProf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCorreoProf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCorreoProf.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CCorreoProf.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCorreoProf.Location = New System.Drawing.Point(180, 301)
        Me.TXT_CCorreoProf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CCorreoProf.Name = "TXT_CCorreoProf"
        Me.TXT_CCorreoProf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CCorreoProf.PlaceholderText = ""
        Me.TXT_CCorreoProf.ReadOnly = True
        Me.TXT_CCorreoProf.SelectedText = ""
        Me.TXT_CCorreoProf.Size = New System.Drawing.Size(367, 36)
        Me.TXT_CCorreoProf.TabIndex = 84
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(71, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 28)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Nombre:"
        '
        'TXT_CNombreProf
        '
        Me.TXT_CNombreProf.AutoRoundedCorners = True
        Me.TXT_CNombreProf.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CNombreProf.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_CNombreProf.BorderRadius = 17
        Me.TXT_CNombreProf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CNombreProf.DefaultText = ""
        Me.TXT_CNombreProf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CNombreProf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CNombreProf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CNombreProf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CNombreProf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CNombreProf.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CNombreProf.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CNombreProf.Location = New System.Drawing.Point(180, 352)
        Me.TXT_CNombreProf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CNombreProf.Name = "TXT_CNombreProf"
        Me.TXT_CNombreProf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CNombreProf.PlaceholderText = ""
        Me.TXT_CNombreProf.ReadOnly = True
        Me.TXT_CNombreProf.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TXT_CNombreProf.SelectedText = ""
        Me.TXT_CNombreProf.Size = New System.Drawing.Size(432, 36)
        Me.TXT_CNombreProf.TabIndex = 86
        '
        'BTN_RegresarProfNuevo
        '
        Me.BTN_RegresarProfNuevo.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarProfNuevo.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarProfNuevo.BorderRadius = 25
        Me.BTN_RegresarProfNuevo.BorderThickness = 1
        Me.BTN_RegresarProfNuevo.CustomBorderColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarProfNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarProfNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarProfNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarProfNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarProfNuevo.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarProfNuevo.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarProfNuevo.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarProfNuevo.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarProfNuevo.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarProfNuevo.Location = New System.Drawing.Point(94, 406)
        Me.BTN_RegresarProfNuevo.Name = "BTN_RegresarProfNuevo"
        Me.BTN_RegresarProfNuevo.Size = New System.Drawing.Size(298, 66)
        Me.BTN_RegresarProfNuevo.TabIndex = 91
        Me.BTN_RegresarProfNuevo.Text = "Regresar"
        '
        'BTN_GuardarProfNuevo
        '
        Me.BTN_GuardarProfNuevo.BackColor = System.Drawing.Color.Transparent
        Me.BTN_GuardarProfNuevo.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_GuardarProfNuevo.BorderRadius = 25
        Me.BTN_GuardarProfNuevo.BorderThickness = 1
        Me.BTN_GuardarProfNuevo.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_GuardarProfNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GuardarProfNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GuardarProfNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_GuardarProfNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_GuardarProfNuevo.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_GuardarProfNuevo.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GuardarProfNuevo.ForeColor = System.Drawing.Color.White
        Me.BTN_GuardarProfNuevo.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_GuardarProfNuevo.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_GuardarProfNuevo.Location = New System.Drawing.Point(409, 406)
        Me.BTN_GuardarProfNuevo.Name = "BTN_GuardarProfNuevo"
        Me.BTN_GuardarProfNuevo.Size = New System.Drawing.Size(298, 66)
        Me.BTN_GuardarProfNuevo.TabIndex = 92
        Me.BTN_GuardarProfNuevo.Text = "Actualizar información"
        '
        'CerrarAPP
        '
        Me.CerrarAPP.BackColor = System.Drawing.Color.Transparent
        Me.CerrarAPP.BorderColor = System.Drawing.Color.White
        Me.CerrarAPP.BorderThickness = 1
        Me.CerrarAPP.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CerrarAPP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CerrarAPP.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CerrarAPP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CerrarAPP.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CerrarAPP.Font = New System.Drawing.Font("Cooper Black", 20.25!)
        Me.CerrarAPP.ForeColor = System.Drawing.Color.White
        Me.CerrarAPP.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_cerrarAPPBlanco
        Me.CerrarAPP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.CerrarAPP.ImageSize = New System.Drawing.Size(30, 30)
        Me.CerrarAPP.Location = New System.Drawing.Point(711, 25)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 93
        '
        'TXT_CClaveProf
        '
        Me.TXT_CClaveProf.AutoRoundedCorners = True
        Me.TXT_CClaveProf.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CClaveProf.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_CClaveProf.BorderRadius = 17
        Me.TXT_CClaveProf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CClaveProf.DefaultText = ""
        Me.TXT_CClaveProf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CClaveProf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CClaveProf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CClaveProf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CClaveProf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CClaveProf.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CClaveProf.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CClaveProf.Location = New System.Drawing.Point(180, 250)
        Me.TXT_CClaveProf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CClaveProf.Name = "TXT_CClaveProf"
        Me.TXT_CClaveProf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_CClaveProf.PlaceholderText = ""
        Me.TXT_CClaveProf.ReadOnly = True
        Me.TXT_CClaveProf.SelectedText = ""
        Me.TXT_CClaveProf.Size = New System.Drawing.Size(367, 36)
        Me.TXT_CClaveProf.TabIndex = 95
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(30, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 28)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Contraseña:"
        '
        'P_PCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.Fondo_BlancoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(786, 497)
        Me.Controls.Add(Me.TXT_CClaveProf)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.BTN_GuardarProfNuevo)
        Me.Controls.Add(Me.BTN_RegresarProfNuevo)
        Me.Controls.Add(Me.TXT_CNombreProf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_CCorreoProf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_CUsuarioProf)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PIC_FotoProf)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_PCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centro de usuario"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_FotoProf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PIC_FotoProf As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_CUsuarioProf As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_CCorreoProf As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_CNombreProf As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_RegresarProfNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_GuardarProfNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents TXT_CClaveProf As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
End Class
