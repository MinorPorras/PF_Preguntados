<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E_PModResp
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_PModResp))
        Me.BTN_AgregarModResp = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarModResp = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_ModResp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_PregModResp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CKB_Correcta = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_AgregarModResp
        '
        Me.BTN_AgregarModResp.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AgregarModResp.BorderColor = System.Drawing.Color.White
        Me.BTN_AgregarModResp.BorderRadius = 25
        Me.BTN_AgregarModResp.BorderThickness = 1
        Me.BTN_AgregarModResp.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_AgregarModResp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarModResp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarModResp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AgregarModResp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AgregarModResp.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_AgregarModResp.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AgregarModResp.ForeColor = System.Drawing.Color.White
        Me.BTN_AgregarModResp.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_AgregarModResp.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_AgregarModResp.Location = New System.Drawing.Point(318, 471)
        Me.BTN_AgregarModResp.Name = "BTN_AgregarModResp"
        Me.BTN_AgregarModResp.Size = New System.Drawing.Size(211, 72)
        Me.BTN_AgregarModResp.TabIndex = 128
        Me.BTN_AgregarModResp.Text = "Agregar"
        '
        'BTN_RegresarModResp
        '
        Me.BTN_RegresarModResp.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarModResp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_RegresarModResp.BorderRadius = 25
        Me.BTN_RegresarModResp.BorderThickness = 1
        Me.BTN_RegresarModResp.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_RegresarModResp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarModResp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarModResp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarModResp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarModResp.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarModResp.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarModResp.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarModResp.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarModResp.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarModResp.Location = New System.Drawing.Point(68, 471)
        Me.BTN_RegresarModResp.Name = "BTN_RegresarModResp"
        Me.BTN_RegresarModResp.Size = New System.Drawing.Size(211, 72)
        Me.BTN_RegresarModResp.TabIndex = 127
        Me.BTN_RegresarModResp.Text = "Regresar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(319, 429)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 20)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "Respuesta Correcta"
        '
        'TXT_ModResp
        '
        Me.TXT_ModResp.BackColor = System.Drawing.Color.Transparent
        Me.TXT_ModResp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_ModResp.BorderRadius = 25
        Me.TXT_ModResp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_ModResp.DefaultText = ""
        Me.TXT_ModResp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_ModResp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_ModResp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_ModResp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_ModResp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ModResp.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.TXT_ModResp.ForeColor = System.Drawing.Color.Black
        Me.TXT_ModResp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ModResp.Location = New System.Drawing.Point(31, 297)
        Me.TXT_ModResp.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_ModResp.MaxLength = 500
        Me.TXT_ModResp.Name = "TXT_ModResp"
        Me.TXT_ModResp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_ModResp.PlaceholderText = "Escriba la respuesta ( MAX 500 caracteres)"
        Me.TXT_ModResp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_ModResp.SelectedText = ""
        Me.TXT_ModResp.Size = New System.Drawing.Size(530, 125)
        Me.TXT_ModResp.TabIndex = 124
        Me.TXT_ModResp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(249, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 23)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Pregunta:"
        '
        'TXT_PregModResp
        '
        Me.TXT_PregModResp.AutoSize = True
        Me.TXT_PregModResp.BackColor = System.Drawing.Color.Transparent
        Me.TXT_PregModResp.BorderColor = System.Drawing.Color.White
        Me.TXT_PregModResp.BorderRadius = 25
        Me.TXT_PregModResp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_PregModResp.DefaultText = ""
        Me.TXT_PregModResp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_PregModResp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_PregModResp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PregModResp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PregModResp.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_PregModResp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PregModResp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_PregModResp.ForeColor = System.Drawing.Color.White
        Me.TXT_PregModResp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PregModResp.Location = New System.Drawing.Point(31, 183)
        Me.TXT_PregModResp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_PregModResp.MaxLength = 150
        Me.TXT_PregModResp.Multiline = True
        Me.TXT_PregModResp.Name = "TXT_PregModResp"
        Me.TXT_PregModResp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_PregModResp.PlaceholderText = ""
        Me.TXT_PregModResp.ReadOnly = True
        Me.TXT_PregModResp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_PregModResp.SelectedText = ""
        Me.TXT_PregModResp.Size = New System.Drawing.Size(530, 74)
        Me.TXT_PregModResp.TabIndex = 122
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloModResp__1_
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(115, -81)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(364, 325)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 121
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 23)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "Respuesta:"
        '
        'CKB_Correcta
        '
        Me.CKB_Correcta.BackColor = System.Drawing.Color.Transparent
        Me.CKB_Correcta.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CKB_Correcta.CheckedState.BorderRadius = 2
        Me.CKB_Correcta.CheckedState.BorderThickness = 0
        Me.CKB_Correcta.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CKB_Correcta.ForeColor = System.Drawing.Color.White
        Me.CKB_Correcta.Location = New System.Drawing.Point(509, 429)
        Me.CKB_Correcta.Name = "CKB_Correcta"
        Me.CKB_Correcta.Size = New System.Drawing.Size(20, 20)
        Me.CKB_Correcta.TabIndex = 130
        Me.CKB_Correcta.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CKB_Correcta.UncheckedState.BorderRadius = 2
        Me.CKB_Correcta.UncheckedState.BorderThickness = 0
        Me.CKB_Correcta.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'E_PModResp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.FondoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(587, 570)
        Me.Controls.Add(Me.CKB_Correcta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_AgregarModResp)
        Me.Controls.Add(Me.BTN_RegresarModResp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_ModResp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_PregModResp)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_PModResp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar respuesta"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_AgregarModResp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarModResp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_ModResp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_PregModResp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CKB_Correcta As Guna.UI2.WinForms.Guna2CustomCheckBox
End Class
