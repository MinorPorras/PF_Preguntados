<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E_PNuevaAsig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_PNuevaAsig))
        Me.TXT_NombreNuevaAsig = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CBX_SeccionNuevaAsig = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_AgregarNuevaAsig = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNRegresaNuevaAsig = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_NombreNuevaAsig
        '
        Me.TXT_NombreNuevaAsig.AutoRoundedCorners = True
        Me.TXT_NombreNuevaAsig.AutoSize = True
        Me.TXT_NombreNuevaAsig.BackColor = System.Drawing.Color.Transparent
        Me.TXT_NombreNuevaAsig.BorderColor = System.Drawing.Color.Transparent
        Me.TXT_NombreNuevaAsig.BorderRadius = 17
        Me.TXT_NombreNuevaAsig.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NombreNuevaAsig.DefaultText = ""
        Me.TXT_NombreNuevaAsig.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NombreNuevaAsig.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NombreNuevaAsig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreNuevaAsig.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreNuevaAsig.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreNuevaAsig.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_NombreNuevaAsig.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreNuevaAsig.Location = New System.Drawing.Point(52, 224)
        Me.TXT_NombreNuevaAsig.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_NombreNuevaAsig.MaxLength = 30
        Me.TXT_NombreNuevaAsig.Name = "TXT_NombreNuevaAsig"
        Me.TXT_NombreNuevaAsig.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NombreNuevaAsig.PlaceholderText = "Max 30 caracteres"
        Me.TXT_NombreNuevaAsig.SelectedText = ""
        Me.TXT_NombreNuevaAsig.Size = New System.Drawing.Size(417, 36)
        Me.TXT_NombreNuevaAsig.TabIndex = 114
        '
        'CBX_SeccionNuevaAsig
        '
        Me.CBX_SeccionNuevaAsig.AutoRoundedCorners = True
        Me.CBX_SeccionNuevaAsig.BackColor = System.Drawing.Color.Transparent
        Me.CBX_SeccionNuevaAsig.BorderColor = System.Drawing.Color.Black
        Me.CBX_SeccionNuevaAsig.BorderRadius = 17
        Me.CBX_SeccionNuevaAsig.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBX_SeccionNuevaAsig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_SeccionNuevaAsig.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_SeccionNuevaAsig.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_SeccionNuevaAsig.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBX_SeccionNuevaAsig.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBX_SeccionNuevaAsig.ItemHeight = 30
        Me.CBX_SeccionNuevaAsig.Location = New System.Drawing.Point(53, 313)
        Me.CBX_SeccionNuevaAsig.Name = "CBX_SeccionNuevaAsig"
        Me.CBX_SeccionNuevaAsig.Size = New System.Drawing.Size(417, 36)
        Me.CBX_SeccionNuevaAsig.TabIndex = 115
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(52, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 23)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Sección a la que se le imparte:"
        '
        'BTN_AgregarNuevaAsig
        '
        Me.BTN_AgregarNuevaAsig.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AgregarNuevaAsig.BorderColor = System.Drawing.Color.White
        Me.BTN_AgregarNuevaAsig.BorderRadius = 25
        Me.BTN_AgregarNuevaAsig.BorderThickness = 1
        Me.BTN_AgregarNuevaAsig.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_AgregarNuevaAsig.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarNuevaAsig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarNuevaAsig.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AgregarNuevaAsig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AgregarNuevaAsig.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_AgregarNuevaAsig.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AgregarNuevaAsig.ForeColor = System.Drawing.Color.White
        Me.BTN_AgregarNuevaAsig.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_AgregarNuevaAsig.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_AgregarNuevaAsig.Location = New System.Drawing.Point(272, 378)
        Me.BTN_AgregarNuevaAsig.Name = "BTN_AgregarNuevaAsig"
        Me.BTN_AgregarNuevaAsig.Size = New System.Drawing.Size(198, 72)
        Me.BTN_AgregarNuevaAsig.TabIndex = 118
        Me.BTN_AgregarNuevaAsig.Text = "Agregar"
        '
        'BTNRegresaNuevaAsig
        '
        Me.BTNRegresaNuevaAsig.BackColor = System.Drawing.Color.Transparent
        Me.BTNRegresaNuevaAsig.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTNRegresaNuevaAsig.BorderRadius = 25
        Me.BTNRegresaNuevaAsig.BorderThickness = 1
        Me.BTNRegresaNuevaAsig.CustomBorderColor = System.Drawing.Color.White
        Me.BTNRegresaNuevaAsig.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNRegresaNuevaAsig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNRegresaNuevaAsig.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNRegresaNuevaAsig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNRegresaNuevaAsig.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTNRegresaNuevaAsig.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRegresaNuevaAsig.ForeColor = System.Drawing.Color.White
        Me.BTNRegresaNuevaAsig.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTNRegresaNuevaAsig.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTNRegresaNuevaAsig.Location = New System.Drawing.Point(56, 378)
        Me.BTNRegresaNuevaAsig.Name = "BTNRegresaNuevaAsig"
        Me.BTNRegresaNuevaAsig.Size = New System.Drawing.Size(198, 72)
        Me.BTNRegresaNuevaAsig.TabIndex = 117
        Me.BTNRegresaNuevaAsig.Text = "Regresar"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloNuevaAsig
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(81, -76)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(372, 344)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 119
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(52, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Nombre:"
        '
        'E_PNuevaAsig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.FondoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(519, 476)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_AgregarNuevaAsig)
        Me.Controls.Add(Me.BTNRegresaNuevaAsig)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBX_SeccionNuevaAsig)
        Me.Controls.Add(Me.TXT_NombreNuevaAsig)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_PNuevaAsig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Asignatura"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_NombreNuevaAsig As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CBX_SeccionNuevaAsig As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_AgregarNuevaAsig As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNRegresaNuevaAsig As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label2 As Label
End Class
