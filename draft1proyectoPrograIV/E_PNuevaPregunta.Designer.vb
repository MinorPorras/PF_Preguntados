<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E_PNuevaPregunta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_PNuevaPregunta))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.NUD_MinutosNPregunta = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NUD_SegundosNPregunta = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NUD_PuntajeNPregunta = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.CBX_CategoriaNuevaPregunta = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BTN_RegresarPreNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_AgregarPreNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_PreguntaNueva = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_NExplicacion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.NUD_MinutosNPregunta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_SegundosNPregunta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_PuntajeNPregunta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.BorderRadius = 20
        Me.Guna2GroupBox1.Controls.Add(Me.NUD_MinutosNPregunta)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.NUD_SegundosNPregunta)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(419, 450)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(301, 112)
        Me.Guna2GroupBox1.TabIndex = 135
        Me.Guna2GroupBox1.Text = "Tiempo para responder"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NUD_MinutosNPregunta
        '
        Me.NUD_MinutosNPregunta.AutoRoundedCorners = True
        Me.NUD_MinutosNPregunta.BackColor = System.Drawing.Color.Transparent
        Me.NUD_MinutosNPregunta.BorderColor = System.Drawing.Color.Black
        Me.NUD_MinutosNPregunta.BorderRadius = 17
        Me.NUD_MinutosNPregunta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_MinutosNPregunta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_MinutosNPregunta.Location = New System.Drawing.Point(39, 65)
        Me.NUD_MinutosNPregunta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NUD_MinutosNPregunta.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NUD_MinutosNPregunta.Name = "NUD_MinutosNPregunta"
        Me.NUD_MinutosNPregunta.Size = New System.Drawing.Size(74, 36)
        Me.NUD_MinutosNPregunta.TabIndex = 123
        Me.NUD_MinutosNPregunta.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
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
        'NUD_SegundosNPregunta
        '
        Me.NUD_SegundosNPregunta.AutoRoundedCorners = True
        Me.NUD_SegundosNPregunta.BackColor = System.Drawing.Color.Transparent
        Me.NUD_SegundosNPregunta.BorderColor = System.Drawing.Color.Black
        Me.NUD_SegundosNPregunta.BorderRadius = 17
        Me.NUD_SegundosNPregunta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_SegundosNPregunta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_SegundosNPregunta.Location = New System.Drawing.Point(185, 65)
        Me.NUD_SegundosNPregunta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NUD_SegundosNPregunta.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NUD_SegundosNPregunta.Name = "NUD_SegundosNPregunta"
        Me.NUD_SegundosNPregunta.Size = New System.Drawing.Size(74, 36)
        Me.NUD_SegundosNPregunta.TabIndex = 117
        Me.NUD_SegundosNPregunta.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
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
        'NUD_PuntajeNPregunta
        '
        Me.NUD_PuntajeNPregunta.AutoRoundedCorners = True
        Me.NUD_PuntajeNPregunta.BackColor = System.Drawing.Color.Transparent
        Me.NUD_PuntajeNPregunta.BorderColor = System.Drawing.Color.Black
        Me.NUD_PuntajeNPregunta.BorderRadius = 17
        Me.NUD_PuntajeNPregunta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_PuntajeNPregunta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_PuntajeNPregunta.Location = New System.Drawing.Point(151, 515)
        Me.NUD_PuntajeNPregunta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NUD_PuntajeNPregunta.Name = "NUD_PuntajeNPregunta"
        Me.NUD_PuntajeNPregunta.Size = New System.Drawing.Size(244, 36)
        Me.NUD_PuntajeNPregunta.TabIndex = 134
        Me.NUD_PuntajeNPregunta.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        '
        'CBX_CategoriaNuevaPregunta
        '
        Me.CBX_CategoriaNuevaPregunta.AutoRoundedCorners = True
        Me.CBX_CategoriaNuevaPregunta.BackColor = System.Drawing.Color.Transparent
        Me.CBX_CategoriaNuevaPregunta.BorderColor = System.Drawing.Color.Black
        Me.CBX_CategoriaNuevaPregunta.BorderRadius = 17
        Me.CBX_CategoriaNuevaPregunta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBX_CategoriaNuevaPregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_CategoriaNuevaPregunta.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_CategoriaNuevaPregunta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_CategoriaNuevaPregunta.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBX_CategoriaNuevaPregunta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBX_CategoriaNuevaPregunta.ItemHeight = 30
        Me.CBX_CategoriaNuevaPregunta.Location = New System.Drawing.Point(151, 450)
        Me.CBX_CategoriaNuevaPregunta.Name = "CBX_CategoriaNuevaPregunta"
        Me.CBX_CategoriaNuevaPregunta.Size = New System.Drawing.Size(244, 36)
        Me.CBX_CategoriaNuevaPregunta.TabIndex = 133
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(52, 460)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 20)
        Me.Label10.TabIndex = 132
        Me.Label10.Text = "Categoría:"
        '
        'BTN_RegresarPreNuevo
        '
        Me.BTN_RegresarPreNuevo.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarPreNuevo.BorderColor = System.Drawing.Color.White
        Me.BTN_RegresarPreNuevo.BorderRadius = 25
        Me.BTN_RegresarPreNuevo.BorderThickness = 1
        Me.BTN_RegresarPreNuevo.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_RegresarPreNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarPreNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarPreNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarPreNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarPreNuevo.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarPreNuevo.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarPreNuevo.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarPreNuevo.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarPreNuevo.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarPreNuevo.Location = New System.Drawing.Point(138, 589)
        Me.BTN_RegresarPreNuevo.Name = "BTN_RegresarPreNuevo"
        Me.BTN_RegresarPreNuevo.Size = New System.Drawing.Size(222, 66)
        Me.BTN_RegresarPreNuevo.TabIndex = 131
        Me.BTN_RegresarPreNuevo.Text = "Regresar"
        '
        'BTN_AgregarPreNuevo
        '
        Me.BTN_AgregarPreNuevo.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AgregarPreNuevo.BorderColor = System.Drawing.Color.White
        Me.BTN_AgregarPreNuevo.BorderRadius = 25
        Me.BTN_AgregarPreNuevo.BorderThickness = 1
        Me.BTN_AgregarPreNuevo.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_AgregarPreNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarPreNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarPreNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AgregarPreNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AgregarPreNuevo.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_AgregarPreNuevo.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AgregarPreNuevo.ForeColor = System.Drawing.Color.White
        Me.BTN_AgregarPreNuevo.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_AgregarPreNuevo.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_AgregarPreNuevo.Location = New System.Drawing.Point(419, 589)
        Me.BTN_AgregarPreNuevo.Name = "BTN_AgregarPreNuevo"
        Me.BTN_AgregarPreNuevo.Size = New System.Drawing.Size(213, 66)
        Me.BTN_AgregarPreNuevo.TabIndex = 130
        Me.BTN_AgregarPreNuevo.Text = "Agregar"
        '
        'TXT_PreguntaNueva
        '
        Me.TXT_PreguntaNueva.AutoSize = True
        Me.TXT_PreguntaNueva.BackColor = System.Drawing.Color.Transparent
        Me.TXT_PreguntaNueva.BorderColor = System.Drawing.Color.Transparent
        Me.TXT_PreguntaNueva.BorderRadius = 25
        Me.TXT_PreguntaNueva.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_PreguntaNueva.DefaultText = ""
        Me.TXT_PreguntaNueva.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_PreguntaNueva.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_PreguntaNueva.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PreguntaNueva.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PreguntaNueva.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PreguntaNueva.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PreguntaNueva.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PreguntaNueva.Location = New System.Drawing.Point(40, 213)
        Me.TXT_PreguntaNueva.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_PreguntaNueva.MaxLength = 500
        Me.TXT_PreguntaNueva.Multiline = True
        Me.TXT_PreguntaNueva.Name = "TXT_PreguntaNueva"
        Me.TXT_PreguntaNueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_PreguntaNueva.PlaceholderText = "Escriba la pregunta (Max 500 palabras)"
        Me.TXT_PreguntaNueva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_PreguntaNueva.SelectedText = ""
        Me.TXT_PreguntaNueva.Size = New System.Drawing.Size(677, 119)
        Me.TXT_PreguntaNueva.TabIndex = 129
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(68, 524)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Puntaje:"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloNuevaPre
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(210, -84)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(373, 349)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 127
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(52, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 20)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "Escriba la pregunta:"
        '
        'TXT_NExplicacion
        '
        Me.TXT_NExplicacion.BackColor = System.Drawing.Color.Transparent
        Me.TXT_NExplicacion.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_NExplicacion.BorderRadius = 25
        Me.TXT_NExplicacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NExplicacion.DefaultText = ""
        Me.TXT_NExplicacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NExplicacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NExplicacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NExplicacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NExplicacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NExplicacion.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.TXT_NExplicacion.ForeColor = System.Drawing.Color.Black
        Me.TXT_NExplicacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NExplicacion.Location = New System.Drawing.Point(40, 363)
        Me.TXT_NExplicacion.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_NExplicacion.MaxLength = 200
        Me.TXT_NExplicacion.Name = "TXT_NExplicacion"
        Me.TXT_NExplicacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NExplicacion.PlaceholderText = "Escriba la explicación, MAX 200 caracteres"
        Me.TXT_NExplicacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_NExplicacion.SelectedText = ""
        Me.TXT_NExplicacion.Size = New System.Drawing.Size(677, 74)
        Me.TXT_NExplicacion.TabIndex = 138
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(52, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 20)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Escribe una explicación:"
        '
        'E_PNuevaPregunta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.FondoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(760, 685)
        Me.Controls.Add(Me.TXT_NExplicacion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.NUD_PuntajeNPregunta)
        Me.Controls.Add(Me.CBX_CategoriaNuevaPregunta)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BTN_RegresarPreNuevo)
        Me.Controls.Add(Me.BTN_AgregarPreNuevo)
        Me.Controls.Add(Me.TXT_PreguntaNueva)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_PNuevaPregunta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Pregunta"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.NUD_MinutosNPregunta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_SegundosNPregunta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_PuntajeNPregunta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents NUD_MinutosNPregunta As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NUD_SegundosNPregunta As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents NUD_PuntajeNPregunta As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents CBX_CategoriaNuevaPregunta As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BTN_RegresarPreNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_AgregarPreNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_PreguntaNueva As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_NExplicacion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
End Class
