<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_PModPeriodo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_PModPeriodo))
        Me.TXT_NombreModPeriodo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_AgregarModPeriodo = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNRegresarModPeriodo = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_NombreModPeriodo
        '
        Me.TXT_NombreModPeriodo.AutoSize = True
        Me.TXT_NombreModPeriodo.BackColor = System.Drawing.Color.Transparent
        Me.TXT_NombreModPeriodo.BorderColor = System.Drawing.Color.Transparent
        Me.TXT_NombreModPeriodo.BorderRadius = 25
        Me.TXT_NombreModPeriodo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NombreModPeriodo.DefaultText = ""
        Me.TXT_NombreModPeriodo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NombreModPeriodo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NombreModPeriodo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreModPeriodo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreModPeriodo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreModPeriodo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_NombreModPeriodo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreModPeriodo.Location = New System.Drawing.Point(28, 171)
        Me.TXT_NombreModPeriodo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_NombreModPeriodo.MaxLength = 30
        Me.TXT_NombreModPeriodo.Name = "TXT_NombreModPeriodo"
        Me.TXT_NombreModPeriodo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NombreModPeriodo.PlaceholderText = "Max 30 caracteres"
        Me.TXT_NombreModPeriodo.SelectedText = ""
        Me.TXT_NombreModPeriodo.Size = New System.Drawing.Size(306, 47)
        Me.TXT_NombreModPeriodo.TabIndex = 119
        '
        'BTN_AgregarModPeriodo
        '
        Me.BTN_AgregarModPeriodo.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AgregarModPeriodo.BorderColor = System.Drawing.Color.White
        Me.BTN_AgregarModPeriodo.BorderRadius = 25
        Me.BTN_AgregarModPeriodo.BorderThickness = 1
        Me.BTN_AgregarModPeriodo.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_AgregarModPeriodo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarModPeriodo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarModPeriodo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AgregarModPeriodo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AgregarModPeriodo.Enabled = False
        Me.BTN_AgregarModPeriodo.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_AgregarModPeriodo.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AgregarModPeriodo.ForeColor = System.Drawing.Color.White
        Me.BTN_AgregarModPeriodo.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_AgregarModPeriodo.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_AgregarModPeriodo.Location = New System.Drawing.Point(184, 235)
        Me.BTN_AgregarModPeriodo.Name = "BTN_AgregarModPeriodo"
        Me.BTN_AgregarModPeriodo.Size = New System.Drawing.Size(150, 48)
        Me.BTN_AgregarModPeriodo.TabIndex = 121
        Me.BTN_AgregarModPeriodo.Text = "Agregar"
        '
        'BTNRegresarModPeriodo
        '
        Me.BTNRegresarModPeriodo.BackColor = System.Drawing.Color.Transparent
        Me.BTNRegresarModPeriodo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTNRegresarModPeriodo.BorderRadius = 25
        Me.BTNRegresarModPeriodo.BorderThickness = 1
        Me.BTNRegresarModPeriodo.CustomBorderColor = System.Drawing.Color.White
        Me.BTNRegresarModPeriodo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNRegresarModPeriodo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNRegresarModPeriodo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNRegresarModPeriodo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNRegresarModPeriodo.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTNRegresarModPeriodo.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRegresarModPeriodo.ForeColor = System.Drawing.Color.White
        Me.BTNRegresarModPeriodo.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTNRegresarModPeriodo.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTNRegresarModPeriodo.Location = New System.Drawing.Point(28, 235)
        Me.BTNRegresarModPeriodo.Name = "BTNRegresarModPeriodo"
        Me.BTNRegresarModPeriodo.Size = New System.Drawing.Size(150, 48)
        Me.BTNRegresarModPeriodo.TabIndex = 120
        Me.BTNRegresarModPeriodo.Text = "Regresar"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloPeriodoMod
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(40, -47)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(281, 247)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 118
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(36, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "Nombre:"
        '
        'E_PModPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.FondoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(357, 304)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTN_AgregarModPeriodo)
        Me.Controls.Add(Me.BTNRegresarModPeriodo)
        Me.Controls.Add(Me.TXT_NombreModPeriodo)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_PModPeriodo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar periodo"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_AgregarModPeriodo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNRegresarModPeriodo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_NombreModPeriodo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label3 As Label
End Class
