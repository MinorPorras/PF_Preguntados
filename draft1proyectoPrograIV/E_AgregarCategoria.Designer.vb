<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgregarCategoria))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TXT_CAT_NOMBRE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox5 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox6 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TEMA = New System.Windows.Forms.ListBox()
        Me.TXT_Imagen1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AgregarEstNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.RegresarEstNuevo = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(266, -99)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(478, 360)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'TXT_CAT_NOMBRE
        '
        Me.TXT_CAT_NOMBRE.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CAT_NOMBRE.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_CAT_NOMBRE.BorderRadius = 25
        Me.TXT_CAT_NOMBRE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CAT_NOMBRE.DefaultText = "INGRESE LA CATEGORÍA"
        Me.TXT_CAT_NOMBRE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CAT_NOMBRE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CAT_NOMBRE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CAT_NOMBRE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CAT_NOMBRE.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.TXT_CAT_NOMBRE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CAT_NOMBRE.Font = New System.Drawing.Font("Cooper Black", 10.8!)
        Me.TXT_CAT_NOMBRE.ForeColor = System.Drawing.Color.Black
        Me.TXT_CAT_NOMBRE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CAT_NOMBRE.Location = New System.Drawing.Point(47, 208)
        Me.TXT_CAT_NOMBRE.Margin = New System.Windows.Forms.Padding(5)
        Me.TXT_CAT_NOMBRE.Name = "TXT_CAT_NOMBRE"
        Me.TXT_CAT_NOMBRE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CAT_NOMBRE.PlaceholderText = ""
        Me.TXT_CAT_NOMBRE.SelectedText = ""
        Me.TXT_CAT_NOMBRE.Size = New System.Drawing.Size(336, 53)
        Me.TXT_CAT_NOMBRE.TabIndex = 89
        Me.TXT_CAT_NOMBRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2TextBox1.BorderRadius = 25
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = "INGRESE LA DESCRIPCIÓN"
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Cooper Black", 10.8!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(47, 306)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(336, 99)
        Me.Guna2TextBox1.TabIndex = 90
        Me.Guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2TextBox4
        '
        Me.Guna2TextBox4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2TextBox4.BorderRadius = 25
        Me.Guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox4.DefaultText = "INGRESE EL VÍDEO"
        Me.Guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.Font = New System.Drawing.Font("Cooper Black", 10.8!)
        Me.Guna2TextBox4.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.Location = New System.Drawing.Point(328, 536)
        Me.Guna2TextBox4.Margin = New System.Windows.Forms.Padding(5)
        Me.Guna2TextBox4.Name = "Guna2TextBox4"
        Me.Guna2TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox4.PlaceholderText = ""
        Me.Guna2TextBox4.SelectedText = ""
        Me.Guna2TextBox4.Size = New System.Drawing.Size(336, 53)
        Me.Guna2TextBox4.TabIndex = 93
        Me.Guna2TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2TextBox5
        '
        Me.Guna2TextBox5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2TextBox5.BorderRadius = 25
        Me.Guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox5.DefaultText = "INGRESE EL AUDÍO"
        Me.Guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox5.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox5.Font = New System.Drawing.Font("Cooper Black", 10.8!)
        Me.Guna2TextBox5.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox5.Location = New System.Drawing.Point(603, 433)
        Me.Guna2TextBox5.Margin = New System.Windows.Forms.Padding(5)
        Me.Guna2TextBox5.Name = "Guna2TextBox5"
        Me.Guna2TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox5.PlaceholderText = ""
        Me.Guna2TextBox5.SelectedText = ""
        Me.Guna2TextBox5.Size = New System.Drawing.Size(336, 53)
        Me.Guna2TextBox5.TabIndex = 94
        Me.Guna2TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2TextBox6
        '
        Me.Guna2TextBox6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2TextBox6.BorderRadius = 25
        Me.Guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox6.DefaultText = "INGRESE EL GIFT"
        Me.Guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox6.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox6.Font = New System.Drawing.Font("Cooper Black", 10.8!)
        Me.Guna2TextBox6.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox6.Location = New System.Drawing.Point(47, 433)
        Me.Guna2TextBox6.Margin = New System.Windows.Forms.Padding(5)
        Me.Guna2TextBox6.Name = "Guna2TextBox6"
        Me.Guna2TextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox6.PlaceholderText = ""
        Me.Guna2TextBox6.SelectedText = ""
        Me.Guna2TextBox6.Size = New System.Drawing.Size(336, 53)
        Me.Guna2TextBox6.TabIndex = 95
        Me.Guna2TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TEMA
        '
        Me.TEMA.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TEMA.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.TEMA.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEMA.ForeColor = System.Drawing.Color.Black
        Me.TEMA.FormattingEnabled = True
        Me.TEMA.ItemHeight = 23
        Me.TEMA.Location = New System.Drawing.Point(603, 208)
        Me.TEMA.Margin = New System.Windows.Forms.Padding(5)
        Me.TEMA.Name = "TEMA"
        Me.TEMA.Size = New System.Drawing.Size(306, 50)
        Me.TEMA.TabIndex = 97
        '
        'TXT_Imagen1
        '
        Me.TXT_Imagen1.BackColor = System.Drawing.Color.Transparent
        Me.TXT_Imagen1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_Imagen1.BorderRadius = 25
        Me.TXT_Imagen1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Imagen1.DefaultText = "INGRESE LA IMAGEN"
        Me.TXT_Imagen1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Imagen1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Imagen1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Imagen1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Imagen1.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.TXT_Imagen1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Imagen1.Font = New System.Drawing.Font("Cooper Black", 10.8!)
        Me.TXT_Imagen1.ForeColor = System.Drawing.Color.Black
        Me.TXT_Imagen1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Imagen1.Location = New System.Drawing.Point(603, 306)
        Me.TXT_Imagen1.Margin = New System.Windows.Forms.Padding(5)
        Me.TXT_Imagen1.Name = "TXT_Imagen1"
        Me.TXT_Imagen1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Imagen1.PlaceholderText = ""
        Me.TXT_Imagen1.SelectedText = ""
        Me.TXT_Imagen1.Size = New System.Drawing.Size(336, 53)
        Me.TXT_Imagen1.TabIndex = 98
        Me.TXT_Imagen1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AgregarEstNuevo
        '
        Me.AgregarEstNuevo.BackColor = System.Drawing.Color.Transparent
        Me.AgregarEstNuevo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.AgregarEstNuevo.BorderRadius = 25
        Me.AgregarEstNuevo.BorderThickness = 1
        Me.AgregarEstNuevo.CustomBorderColor = System.Drawing.Color.White
        Me.AgregarEstNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AgregarEstNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AgregarEstNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AgregarEstNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AgregarEstNuevo.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.AgregarEstNuevo.Font = New System.Drawing.Font("Cooper Black", 14.25!)
        Me.AgregarEstNuevo.ForeColor = System.Drawing.Color.White
        Me.AgregarEstNuevo.Image = CType(resources.GetObject("AgregarEstNuevo.Image"), System.Drawing.Image)
        Me.AgregarEstNuevo.ImageSize = New System.Drawing.Size(60, 60)
        Me.AgregarEstNuevo.Location = New System.Drawing.Point(566, 632)
        Me.AgregarEstNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.AgregarEstNuevo.Name = "AgregarEstNuevo"
        Me.AgregarEstNuevo.Size = New System.Drawing.Size(320, 89)
        Me.AgregarEstNuevo.TabIndex = 100
        Me.AgregarEstNuevo.Text = "Guardar"
        '
        'RegresarEstNuevo
        '
        Me.RegresarEstNuevo.BackColor = System.Drawing.Color.Transparent
        Me.RegresarEstNuevo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.RegresarEstNuevo.BorderRadius = 25
        Me.RegresarEstNuevo.BorderThickness = 1
        Me.RegresarEstNuevo.CustomBorderColor = System.Drawing.Color.White
        Me.RegresarEstNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.RegresarEstNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.RegresarEstNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RegresarEstNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.RegresarEstNuevo.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.RegresarEstNuevo.Font = New System.Drawing.Font("Cooper Black", 14.25!)
        Me.RegresarEstNuevo.ForeColor = System.Drawing.Color.White
        Me.RegresarEstNuevo.Image = CType(resources.GetObject("RegresarEstNuevo.Image"), System.Drawing.Image)
        Me.RegresarEstNuevo.ImageSize = New System.Drawing.Size(30, 30)
        Me.RegresarEstNuevo.Location = New System.Drawing.Point(194, 632)
        Me.RegresarEstNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.RegresarEstNuevo.Name = "RegresarEstNuevo"
        Me.RegresarEstNuevo.Size = New System.Drawing.Size(313, 89)
        Me.RegresarEstNuevo.TabIndex = 99
        Me.RegresarEstNuevo.Text = "Regresar"
        '
        'FrmAgregarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1018, 764)
        Me.Controls.Add(Me.AgregarEstNuevo)
        Me.Controls.Add(Me.RegresarEstNuevo)
        Me.Controls.Add(Me.TXT_Imagen1)
        Me.Controls.Add(Me.TEMA)
        Me.Controls.Add(Me.Guna2TextBox6)
        Me.Controls.Add(Me.Guna2TextBox5)
        Me.Controls.Add(Me.Guna2TextBox4)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.TXT_CAT_NOMBRE)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAgregarCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAgregarCategoria"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TXT_CAT_NOMBRE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox5 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox6 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TEMA As ListBox
    Friend WithEvents TXT_Imagen1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AgregarEstNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RegresarEstNuevo As Guna.UI2.WinForms.Guna2Button
End Class
