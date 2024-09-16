<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_EActCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_EActCuenta))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BTN_GuardarActAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarActAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_ActClaveEst = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_ActUsuarioEst = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloActCuentaMorado
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(82, -49)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(320, 273)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 81
        Me.Guna2PictureBox1.TabStop = False
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
        Me.BTN_GuardarActAdmin.Location = New System.Drawing.Point(245, 308)
        Me.BTN_GuardarActAdmin.Name = "BTN_GuardarActAdmin"
        Me.BTN_GuardarActAdmin.Size = New System.Drawing.Size(189, 58)
        Me.BTN_GuardarActAdmin.TabIndex = 110
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
        Me.BTN_RegresarActAdmin.Location = New System.Drawing.Point(50, 308)
        Me.BTN_RegresarActAdmin.Name = "BTN_RegresarActAdmin"
        Me.BTN_RegresarActAdmin.Size = New System.Drawing.Size(189, 58)
        Me.BTN_RegresarActAdmin.TabIndex = 109
        Me.BTN_RegresarActAdmin.Text = "Regresar"
        '
        'TXT_ActClaveEst
        '
        Me.TXT_ActClaveEst.AutoRoundedCorners = True
        Me.TXT_ActClaveEst.BackColor = System.Drawing.Color.Transparent
        Me.TXT_ActClaveEst.BorderColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TXT_ActClaveEst.BorderRadius = 22
        Me.TXT_ActClaveEst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_ActClaveEst.DefaultText = ""
        Me.TXT_ActClaveEst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_ActClaveEst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_ActClaveEst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_ActClaveEst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_ActClaveEst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ActClaveEst.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_ActClaveEst.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ActClaveEst.Location = New System.Drawing.Point(178, 245)
        Me.TXT_ActClaveEst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_ActClaveEst.MaxLength = 14
        Me.TXT_ActClaveEst.Name = "TXT_ActClaveEst"
        Me.TXT_ActClaveEst.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_ActClaveEst.PlaceholderText = "Max 14 caracteres"
        Me.TXT_ActClaveEst.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TXT_ActClaveEst.SelectedText = ""
        Me.TXT_ActClaveEst.Size = New System.Drawing.Size(267, 46)
        Me.TXT_ActClaveEst.TabIndex = 108
        '
        'TXT_ActUsuarioEst
        '
        Me.TXT_ActUsuarioEst.AutoRoundedCorners = True
        Me.TXT_ActUsuarioEst.BackColor = System.Drawing.Color.Transparent
        Me.TXT_ActUsuarioEst.BorderColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TXT_ActUsuarioEst.BorderRadius = 22
        Me.TXT_ActUsuarioEst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_ActUsuarioEst.DefaultText = ""
        Me.TXT_ActUsuarioEst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_ActUsuarioEst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_ActUsuarioEst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_ActUsuarioEst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_ActUsuarioEst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ActUsuarioEst.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_ActUsuarioEst.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ActUsuarioEst.Location = New System.Drawing.Point(178, 191)
        Me.TXT_ActUsuarioEst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_ActUsuarioEst.MaxLength = 14
        Me.TXT_ActUsuarioEst.Name = "TXT_ActUsuarioEst"
        Me.TXT_ActUsuarioEst.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_ActUsuarioEst.PlaceholderText = "Max 14 caracteres"
        Me.TXT_ActUsuarioEst.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TXT_ActUsuarioEst.SelectedText = ""
        Me.TXT_ActUsuarioEst.Size = New System.Drawing.Size(267, 46)
        Me.TXT_ActUsuarioEst.TabIndex = 107
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(26, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 23)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Constraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(74, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 23)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Usuario:"
        '
        'E_EActCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.FondoBlancoMorado
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(481, 395)
        Me.Controls.Add(Me.BTN_GuardarActAdmin)
        Me.Controls.Add(Me.BTN_RegresarActAdmin)
        Me.Controls.Add(Me.TXT_ActClaveEst)
        Me.Controls.Add(Me.TXT_ActUsuarioEst)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_EActCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar cuenta"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTN_GuardarActAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarActAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_ActClaveEst As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_ActUsuarioEst As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
