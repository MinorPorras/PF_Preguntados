<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModPregunta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModPregunta))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.NUD_MinutosModPregunta = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NUD_SegundosModPregunta = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NUD_PuntajeModPregunta = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.CBX_CategoriaModPregunta = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BTN_RegresarPreMod = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_AgregarPreMod = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_PreguntaMod = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_ModExplicacion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.NUD_MinutosModPregunta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_SegundosModPregunta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_PuntajeModPregunta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloModPre
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(224, -67)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(337, 315)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 36
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.BorderRadius = 20
        Me.Guna2GroupBox1.Controls.Add(Me.NUD_MinutosModPregunta)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.NUD_SegundosModPregunta)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(417, 448)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(301, 112)
        Me.Guna2GroupBox1.TabIndex = 144
        Me.Guna2GroupBox1.Text = "Tiempo para responder"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NUD_MinutosModPregunta
        '
        Me.NUD_MinutosModPregunta.AutoRoundedCorners = True
        Me.NUD_MinutosModPregunta.BackColor = System.Drawing.Color.Transparent
        Me.NUD_MinutosModPregunta.BorderColor = System.Drawing.Color.Black
        Me.NUD_MinutosModPregunta.BorderRadius = 17
        Me.NUD_MinutosModPregunta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_MinutosModPregunta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_MinutosModPregunta.Location = New System.Drawing.Point(39, 65)
        Me.NUD_MinutosModPregunta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NUD_MinutosModPregunta.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NUD_MinutosModPregunta.Name = "NUD_MinutosModPregunta"
        Me.NUD_MinutosModPregunta.Size = New System.Drawing.Size(74, 36)
        Me.NUD_MinutosModPregunta.TabIndex = 123
        Me.NUD_MinutosModPregunta.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(181, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Segundos"
        '
        'NUD_SegundosModPregunta
        '
        Me.NUD_SegundosModPregunta.AutoRoundedCorners = True
        Me.NUD_SegundosModPregunta.BackColor = System.Drawing.Color.Transparent
        Me.NUD_SegundosModPregunta.BorderColor = System.Drawing.Color.Black
        Me.NUD_SegundosModPregunta.BorderRadius = 17
        Me.NUD_SegundosModPregunta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_SegundosModPregunta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_SegundosModPregunta.Location = New System.Drawing.Point(185, 65)
        Me.NUD_SegundosModPregunta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NUD_SegundosModPregunta.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NUD_SegundosModPregunta.Name = "NUD_SegundosModPregunta"
        Me.NUD_SegundosModPregunta.Size = New System.Drawing.Size(74, 36)
        Me.NUD_SegundosModPregunta.TabIndex = 117
        Me.NUD_SegundosModPregunta.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Minutos:"
        '
        'NUD_PuntajeModPregunta
        '
        Me.NUD_PuntajeModPregunta.AutoRoundedCorners = True
        Me.NUD_PuntajeModPregunta.BackColor = System.Drawing.Color.Transparent
        Me.NUD_PuntajeModPregunta.BorderColor = System.Drawing.Color.Black
        Me.NUD_PuntajeModPregunta.BorderRadius = 17
        Me.NUD_PuntajeModPregunta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_PuntajeModPregunta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_PuntajeModPregunta.Location = New System.Drawing.Point(135, 513)
        Me.NUD_PuntajeModPregunta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NUD_PuntajeModPregunta.Name = "NUD_PuntajeModPregunta"
        Me.NUD_PuntajeModPregunta.Size = New System.Drawing.Size(244, 36)
        Me.NUD_PuntajeModPregunta.TabIndex = 143
        Me.NUD_PuntajeModPregunta.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        '
        'CBX_CategoriaModPregunta
        '
        Me.CBX_CategoriaModPregunta.AutoRoundedCorners = True
        Me.CBX_CategoriaModPregunta.BackColor = System.Drawing.Color.Transparent
        Me.CBX_CategoriaModPregunta.BorderColor = System.Drawing.Color.Black
        Me.CBX_CategoriaModPregunta.BorderRadius = 17
        Me.CBX_CategoriaModPregunta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBX_CategoriaModPregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_CategoriaModPregunta.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_CategoriaModPregunta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_CategoriaModPregunta.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBX_CategoriaModPregunta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBX_CategoriaModPregunta.ItemHeight = 30
        Me.CBX_CategoriaModPregunta.Location = New System.Drawing.Point(135, 448)
        Me.CBX_CategoriaModPregunta.Name = "CBX_CategoriaModPregunta"
        Me.CBX_CategoriaModPregunta.Size = New System.Drawing.Size(244, 36)
        Me.CBX_CategoriaModPregunta.TabIndex = 142
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(36, 458)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 20)
        Me.Label10.TabIndex = 141
        Me.Label10.Text = "Categoría:"
        '
        'BTN_RegresarPreMod
        '
        Me.BTN_RegresarPreMod.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarPreMod.BorderColor = System.Drawing.Color.White
        Me.BTN_RegresarPreMod.BorderRadius = 25
        Me.BTN_RegresarPreMod.BorderThickness = 1
        Me.BTN_RegresarPreMod.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_RegresarPreMod.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarPreMod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarPreMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarPreMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarPreMod.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarPreMod.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarPreMod.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarPreMod.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarPreMod.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarPreMod.Location = New System.Drawing.Point(123, 587)
        Me.BTN_RegresarPreMod.Name = "BTN_RegresarPreMod"
        Me.BTN_RegresarPreMod.Size = New System.Drawing.Size(246, 66)
        Me.BTN_RegresarPreMod.TabIndex = 140
        Me.BTN_RegresarPreMod.Text = "Regresar"
        '
        'BTN_AgregarPreMod
        '
        Me.BTN_AgregarPreMod.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AgregarPreMod.BorderColor = System.Drawing.Color.White
        Me.BTN_AgregarPreMod.BorderRadius = 25
        Me.BTN_AgregarPreMod.BorderThickness = 1
        Me.BTN_AgregarPreMod.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_AgregarPreMod.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarPreMod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarPreMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AgregarPreMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AgregarPreMod.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_AgregarPreMod.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AgregarPreMod.ForeColor = System.Drawing.Color.White
        Me.BTN_AgregarPreMod.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_AgregarPreMod.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_AgregarPreMod.Location = New System.Drawing.Point(408, 587)
        Me.BTN_AgregarPreMod.Name = "BTN_AgregarPreMod"
        Me.BTN_AgregarPreMod.Size = New System.Drawing.Size(246, 66)
        Me.BTN_AgregarPreMod.TabIndex = 139
        Me.BTN_AgregarPreMod.Text = "Agregar"
        '
        'TXT_PreguntaMod
        '
        Me.TXT_PreguntaMod.AutoSize = True
        Me.TXT_PreguntaMod.BackColor = System.Drawing.Color.Transparent
        Me.TXT_PreguntaMod.BorderColor = System.Drawing.Color.Transparent
        Me.TXT_PreguntaMod.BorderRadius = 25
        Me.TXT_PreguntaMod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_PreguntaMod.DefaultText = ""
        Me.TXT_PreguntaMod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_PreguntaMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_PreguntaMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PreguntaMod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PreguntaMod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PreguntaMod.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PreguntaMod.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PreguntaMod.Location = New System.Drawing.Point(34, 203)
        Me.TXT_PreguntaMod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_PreguntaMod.MaxLength = 500
        Me.TXT_PreguntaMod.Multiline = True
        Me.TXT_PreguntaMod.Name = "TXT_PreguntaMod"
        Me.TXT_PreguntaMod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_PreguntaMod.PlaceholderText = "Escriba la pregunta (Max 500 palabras)"
        Me.TXT_PreguntaMod.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_PreguntaMod.SelectedText = ""
        Me.TXT_PreguntaMod.Size = New System.Drawing.Size(687, 116)
        Me.TXT_PreguntaMod.TabIndex = 138
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(52, 522)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Puntaje:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(56, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 20)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "Escriba la pregunta:"
        '
        'TXT_ModExplicacion
        '
        Me.TXT_ModExplicacion.BackColor = System.Drawing.Color.Transparent
        Me.TXT_ModExplicacion.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_ModExplicacion.BorderRadius = 25
        Me.TXT_ModExplicacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_ModExplicacion.DefaultText = ""
        Me.TXT_ModExplicacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_ModExplicacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_ModExplicacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_ModExplicacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_ModExplicacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ModExplicacion.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.TXT_ModExplicacion.ForeColor = System.Drawing.Color.Black
        Me.TXT_ModExplicacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ModExplicacion.Location = New System.Drawing.Point(34, 347)
        Me.TXT_ModExplicacion.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_ModExplicacion.MaxLength = 200
        Me.TXT_ModExplicacion.Name = "TXT_ModExplicacion"
        Me.TXT_ModExplicacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_ModExplicacion.PlaceholderText = "Escriba la explicación, MAX 200 caracteres"
        Me.TXT_ModExplicacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_ModExplicacion.SelectedText = ""
        Me.TXT_ModExplicacion.Size = New System.Drawing.Size(687, 74)
        Me.TXT_ModExplicacion.TabIndex = 147
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(56, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 20)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "Escribe una explicación:"
        '
        'FrmModPregunta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.FondoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(760, 685)
        Me.Controls.Add(Me.TXT_ModExplicacion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.NUD_PuntajeModPregunta)
        Me.Controls.Add(Me.CBX_CategoriaModPregunta)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BTN_RegresarPreMod)
        Me.Controls.Add(Me.BTN_AgregarPreMod)
        Me.Controls.Add(Me.TXT_PreguntaMod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmModPregunta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar pregunta"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.NUD_MinutosModPregunta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_SegundosModPregunta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_PuntajeModPregunta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents NUD_MinutosModPregunta As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NUD_SegundosModPregunta As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents NUD_PuntajeModPregunta As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents CBX_CategoriaModPregunta As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BTN_RegresarPreMod As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_AgregarPreMod As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_PreguntaMod As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_ModExplicacion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
End Class
