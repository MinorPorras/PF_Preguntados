<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_AActAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_AActAdmin))
        Me.BTN_GuardarActAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarActAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_CClaveAdmin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_CUsuarioAdmin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_GuardarActAdmin
        '
        Me.BTN_GuardarActAdmin.BackColor = System.Drawing.Color.Transparent
        Me.BTN_GuardarActAdmin.BorderColor = System.Drawing.Color.White
        Me.BTN_GuardarActAdmin.BorderRadius = 25
        Me.BTN_GuardarActAdmin.BorderThickness = 1
        Me.BTN_GuardarActAdmin.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_GuardarActAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GuardarActAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GuardarActAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_GuardarActAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_GuardarActAdmin.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_GuardarActAdmin.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GuardarActAdmin.ForeColor = System.Drawing.Color.White
        Me.BTN_GuardarActAdmin.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_GuardarActAdmin.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_GuardarActAdmin.Location = New System.Drawing.Point(333, 370)
        Me.BTN_GuardarActAdmin.Name = "BTN_GuardarActAdmin"
        Me.BTN_GuardarActAdmin.Size = New System.Drawing.Size(263, 70)
        Me.BTN_GuardarActAdmin.TabIndex = 103
        Me.BTN_GuardarActAdmin.Text = "Guardar"
        '
        'BTN_RegresarActAdmin
        '
        Me.BTN_RegresarActAdmin.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarActAdmin.BorderColor = System.Drawing.Color.White
        Me.BTN_RegresarActAdmin.BorderRadius = 25
        Me.BTN_RegresarActAdmin.BorderThickness = 1
        Me.BTN_RegresarActAdmin.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_RegresarActAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarActAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarActAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarActAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarActAdmin.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarActAdmin.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarActAdmin.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarActAdmin.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarActAdmin.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarActAdmin.Location = New System.Drawing.Point(61, 370)
        Me.BTN_RegresarActAdmin.Name = "BTN_RegresarActAdmin"
        Me.BTN_RegresarActAdmin.Size = New System.Drawing.Size(263, 70)
        Me.BTN_RegresarActAdmin.TabIndex = 102
        Me.BTN_RegresarActAdmin.Text = "Regresar"
        '
        'TXT_CClaveAdmin
        '
        Me.TXT_CClaveAdmin.AutoRoundedCorners = True
        Me.TXT_CClaveAdmin.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CClaveAdmin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_CClaveAdmin.BorderRadius = 22
        Me.TXT_CClaveAdmin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CClaveAdmin.DefaultText = ""
        Me.TXT_CClaveAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CClaveAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CClaveAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CClaveAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CClaveAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CClaveAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CClaveAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CClaveAdmin.Location = New System.Drawing.Point(228, 303)
        Me.TXT_CClaveAdmin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CClaveAdmin.MaxLength = 14
        Me.TXT_CClaveAdmin.Name = "TXT_CClaveAdmin"
        Me.TXT_CClaveAdmin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CClaveAdmin.PlaceholderText = "Max 14 caracteres"
        Me.TXT_CClaveAdmin.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TXT_CClaveAdmin.SelectedText = ""
        Me.TXT_CClaveAdmin.Size = New System.Drawing.Size(368, 46)
        Me.TXT_CClaveAdmin.TabIndex = 101
        '
        'TXT_CUsuarioAdmin
        '
        Me.TXT_CUsuarioAdmin.AutoRoundedCorners = True
        Me.TXT_CUsuarioAdmin.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CUsuarioAdmin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_CUsuarioAdmin.BorderRadius = 22
        Me.TXT_CUsuarioAdmin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CUsuarioAdmin.DefaultText = ""
        Me.TXT_CUsuarioAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CUsuarioAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CUsuarioAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CUsuarioAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CUsuarioAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CUsuarioAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CUsuarioAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CUsuarioAdmin.Location = New System.Drawing.Point(228, 227)
        Me.TXT_CUsuarioAdmin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CUsuarioAdmin.MaxLength = 14
        Me.TXT_CUsuarioAdmin.Name = "TXT_CUsuarioAdmin"
        Me.TXT_CUsuarioAdmin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CUsuarioAdmin.PlaceholderText = "Max 14 caracteres"
        Me.TXT_CUsuarioAdmin.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TXT_CUsuarioAdmin.SelectedText = ""
        Me.TXT_CUsuarioAdmin.Size = New System.Drawing.Size(368, 46)
        Me.TXT_CUsuarioAdmin.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(56, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 28)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Constraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(109, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 28)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Usuario:"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloActualizarCuenta
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(100, -83)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(439, 367)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 95
        Me.Guna2PictureBox1.TabStop = False
        '
        'E_AActAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.FondoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(645, 473)
        Me.Controls.Add(Me.BTN_GuardarActAdmin)
        Me.Controls.Add(Me.BTN_RegresarActAdmin)
        Me.Controls.Add(Me.TXT_CClaveAdmin)
        Me.Controls.Add(Me.TXT_CUsuarioAdmin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_AActAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar cuenta"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_GuardarActAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarActAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_CClaveAdmin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_CUsuarioAdmin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
