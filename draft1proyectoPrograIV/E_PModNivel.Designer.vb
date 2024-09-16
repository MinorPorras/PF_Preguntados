<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E_PModNivel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_PModNivel))
        Me.BTN_AgregarModNivel = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNRegresaModNivel = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_NombreModNivel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_AgregarModNivel
        '
        Me.BTN_AgregarModNivel.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AgregarModNivel.BorderColor = System.Drawing.Color.White
        Me.BTN_AgregarModNivel.BorderRadius = 25
        Me.BTN_AgregarModNivel.BorderThickness = 1
        Me.BTN_AgregarModNivel.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_AgregarModNivel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarModNivel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarModNivel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AgregarModNivel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AgregarModNivel.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_AgregarModNivel.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AgregarModNivel.ForeColor = System.Drawing.Color.White
        Me.BTN_AgregarModNivel.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_AgregarModNivel.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_AgregarModNivel.Location = New System.Drawing.Point(227, 295)
        Me.BTN_AgregarModNivel.Name = "BTN_AgregarModNivel"
        Me.BTN_AgregarModNivel.Size = New System.Drawing.Size(188, 72)
        Me.BTN_AgregarModNivel.TabIndex = 120
        Me.BTN_AgregarModNivel.Text = "Agregar"
        '
        'BTNRegresaModNivel
        '
        Me.BTNRegresaModNivel.BackColor = System.Drawing.Color.Transparent
        Me.BTNRegresaModNivel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTNRegresaModNivel.BorderRadius = 25
        Me.BTNRegresaModNivel.BorderThickness = 1
        Me.BTNRegresaModNivel.CustomBorderColor = System.Drawing.Color.White
        Me.BTNRegresaModNivel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNRegresaModNivel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNRegresaModNivel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNRegresaModNivel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNRegresaModNivel.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTNRegresaModNivel.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRegresaModNivel.ForeColor = System.Drawing.Color.White
        Me.BTNRegresaModNivel.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTNRegresaModNivel.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTNRegresaModNivel.Location = New System.Drawing.Point(33, 295)
        Me.BTNRegresaModNivel.Name = "BTNRegresaModNivel"
        Me.BTNRegresaModNivel.Size = New System.Drawing.Size(188, 72)
        Me.BTNRegresaModNivel.TabIndex = 119
        Me.BTNRegresaModNivel.Text = "Regresar"
        '
        'TXT_NombreModNivel
        '
        Me.TXT_NombreModNivel.AutoSize = True
        Me.TXT_NombreModNivel.BackColor = System.Drawing.Color.Transparent
        Me.TXT_NombreModNivel.BorderColor = System.Drawing.Color.Transparent
        Me.TXT_NombreModNivel.BorderRadius = 25
        Me.TXT_NombreModNivel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NombreModNivel.DefaultText = ""
        Me.TXT_NombreModNivel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NombreModNivel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NombreModNivel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreModNivel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreModNivel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreModNivel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_NombreModNivel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreModNivel.Location = New System.Drawing.Point(22, 222)
        Me.TXT_NombreModNivel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_NombreModNivel.MaxLength = 30
        Me.TXT_NombreModNivel.Name = "TXT_NombreModNivel"
        Me.TXT_NombreModNivel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NombreModNivel.PlaceholderText = "Max 30 caracteres"
        Me.TXT_NombreModNivel.SelectedText = ""
        Me.TXT_NombreModNivel.Size = New System.Drawing.Size(404, 47)
        Me.TXT_NombreModNivel.TabIndex = 118
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloModNivel
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(43, -82)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(372, 344)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 117
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(39, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 147
        Me.Label3.Text = "Nombre:"
        '
        'E_PModNivel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.FondoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(450, 386)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTN_AgregarModNivel)
        Me.Controls.Add(Me.BTNRegresaModNivel)
        Me.Controls.Add(Me.TXT_NombreModNivel)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_PModNivel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar nivel"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_AgregarModNivel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNRegresaModNivel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_NombreModNivel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label3 As Label
End Class
