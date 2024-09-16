<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_ACuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_ACuenta))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.CerrarAPP = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_CUsuarioAdmin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_CClaveAdmin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_ActAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarCuentaAdmin = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloCentroDeUsuario
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(80, -67)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(351, 293)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 80
        Me.Guna2PictureBox1.TabStop = False
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
        Me.CerrarAPP.Location = New System.Drawing.Point(446, 14)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(34, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 28)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Constraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(86, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 28)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Usuario:"
        '
        'TXT_CUsuarioAdmin
        '
        Me.TXT_CUsuarioAdmin.AutoRoundedCorners = True
        Me.TXT_CUsuarioAdmin.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CUsuarioAdmin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_CUsuarioAdmin.BorderRadius = 17
        Me.TXT_CUsuarioAdmin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CUsuarioAdmin.DefaultText = ""
        Me.TXT_CUsuarioAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CUsuarioAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CUsuarioAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CUsuarioAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CUsuarioAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CUsuarioAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CUsuarioAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CUsuarioAdmin.Location = New System.Drawing.Point(200, 180)
        Me.TXT_CUsuarioAdmin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CUsuarioAdmin.Name = "TXT_CUsuarioAdmin"
        Me.TXT_CUsuarioAdmin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CUsuarioAdmin.PlaceholderText = ""
        Me.TXT_CUsuarioAdmin.ReadOnly = True
        Me.TXT_CUsuarioAdmin.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TXT_CUsuarioAdmin.SelectedText = ""
        Me.TXT_CUsuarioAdmin.Size = New System.Drawing.Size(231, 36)
        Me.TXT_CUsuarioAdmin.TabIndex = 87
        '
        'TXT_CClaveAdmin
        '
        Me.TXT_CClaveAdmin.AutoRoundedCorners = True
        Me.TXT_CClaveAdmin.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CClaveAdmin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_CClaveAdmin.BorderRadius = 17
        Me.TXT_CClaveAdmin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CClaveAdmin.DefaultText = ""
        Me.TXT_CClaveAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CClaveAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CClaveAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CClaveAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CClaveAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CClaveAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CClaveAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CClaveAdmin.Location = New System.Drawing.Point(200, 241)
        Me.TXT_CClaveAdmin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CClaveAdmin.Name = "TXT_CClaveAdmin"
        Me.TXT_CClaveAdmin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_CClaveAdmin.PlaceholderText = ""
        Me.TXT_CClaveAdmin.ReadOnly = True
        Me.TXT_CClaveAdmin.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TXT_CClaveAdmin.SelectedText = ""
        Me.TXT_CClaveAdmin.Size = New System.Drawing.Size(231, 36)
        Me.TXT_CClaveAdmin.TabIndex = 88
        '
        'BTN_ActAdmin
        '
        Me.BTN_ActAdmin.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ActAdmin.BorderColor = System.Drawing.Color.White
        Me.BTN_ActAdmin.BorderRadius = 25
        Me.BTN_ActAdmin.BorderThickness = 1
        Me.BTN_ActAdmin.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_ActAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ActAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ActAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ActAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ActAdmin.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_ActAdmin.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ActAdmin.ForeColor = System.Drawing.Color.White
        Me.BTN_ActAdmin.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_ActAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_ActAdmin.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_ActAdmin.Location = New System.Drawing.Point(267, 307)
        Me.BTN_ActAdmin.Name = "BTN_ActAdmin"
        Me.BTN_ActAdmin.Size = New System.Drawing.Size(211, 81)
        Me.BTN_ActAdmin.TabIndex = 94
        Me.BTN_ActAdmin.Text = "Actualizar información"
        Me.BTN_ActAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTN_RegresarCuentaAdmin
        '
        Me.BTN_RegresarCuentaAdmin.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarCuentaAdmin.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarCuentaAdmin.BorderRadius = 25
        Me.BTN_RegresarCuentaAdmin.BorderThickness = 1
        Me.BTN_RegresarCuentaAdmin.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_RegresarCuentaAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarCuentaAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarCuentaAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarCuentaAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarCuentaAdmin.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarCuentaAdmin.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarCuentaAdmin.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarCuentaAdmin.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarCuentaAdmin.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarCuentaAdmin.Location = New System.Drawing.Point(50, 307)
        Me.BTN_RegresarCuentaAdmin.Name = "BTN_RegresarCuentaAdmin"
        Me.BTN_RegresarCuentaAdmin.Size = New System.Drawing.Size(211, 81)
        Me.BTN_RegresarCuentaAdmin.TabIndex = 93
        Me.BTN_RegresarCuentaAdmin.Text = "Regresar"
        '
        'P_ACuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.Fondo_BlancoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(514, 415)
        Me.Controls.Add(Me.BTN_ActAdmin)
        Me.Controls.Add(Me.BTN_RegresarCuentaAdmin)
        Me.Controls.Add(Me.TXT_CClaveAdmin)
        Me.Controls.Add(Me.TXT_CUsuarioAdmin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_ACuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centro de usuario"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_CUsuarioAdmin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_CClaveAdmin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_ActAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarCuentaAdmin As Guna.UI2.WinForms.Guna2Button
End Class
