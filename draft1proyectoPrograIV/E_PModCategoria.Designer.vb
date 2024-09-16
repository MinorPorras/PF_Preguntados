<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_PModCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_PModCategoria))
        Me.BTN_GuardarModCat = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BTN_AudioModCat = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_ImgAniModCat = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_imgEstModCat = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBX_TemaModCat = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BTN_RegresarModCat = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_DescModCat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_NombreModCat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.OFD_ImgEstCatMod = New System.Windows.Forms.OpenFileDialog()
        Me.OFD_ImgAniModCat = New System.Windows.Forms.OpenFileDialog()
        Me.OFD_AudioModCat = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_GuardarModCat
        '
        Me.BTN_GuardarModCat.BackColor = System.Drawing.Color.Transparent
        Me.BTN_GuardarModCat.BorderColor = System.Drawing.Color.White
        Me.BTN_GuardarModCat.BorderRadius = 25
        Me.BTN_GuardarModCat.BorderThickness = 1
        Me.BTN_GuardarModCat.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_GuardarModCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GuardarModCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GuardarModCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_GuardarModCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_GuardarModCat.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_GuardarModCat.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GuardarModCat.ForeColor = System.Drawing.Color.White
        Me.BTN_GuardarModCat.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_GuardarModCat.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_GuardarModCat.Location = New System.Drawing.Point(510, 556)
        Me.BTN_GuardarModCat.Name = "BTN_GuardarModCat"
        Me.BTN_GuardarModCat.Size = New System.Drawing.Size(274, 72)
        Me.BTN_GuardarModCat.TabIndex = 112
        Me.BTN_GuardarModCat.Text = "Guardar"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderRadius = 20
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_AudioModCat)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_ImgAniModCat)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_imgEstModCat)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(445, 294)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(430, 242)
        Me.Guna2GroupBox1.TabIndex = 111
        Me.Guna2GroupBox1.Text = "Busqueda de Archivos"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_AudioModCat
        '
        Me.BTN_AudioModCat.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AudioModCat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_AudioModCat.BorderRadius = 25
        Me.BTN_AudioModCat.BorderThickness = 1
        Me.BTN_AudioModCat.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_AudioModCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AudioModCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AudioModCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AudioModCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AudioModCat.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_AudioModCat.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AudioModCat.ForeColor = System.Drawing.Color.White
        Me.BTN_AudioModCat.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_AudioModCat.Location = New System.Drawing.Point(130, 142)
        Me.BTN_AudioModCat.Name = "BTN_AudioModCat"
        Me.BTN_AudioModCat.Size = New System.Drawing.Size(196, 83)
        Me.BTN_AudioModCat.TabIndex = 118
        Me.BTN_AudioModCat.Text = "Sonido de fondo"
        '
        'BTN_ImgAniModCat
        '
        Me.BTN_ImgAniModCat.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ImgAniModCat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_ImgAniModCat.BorderRadius = 25
        Me.BTN_ImgAniModCat.BorderThickness = 1
        Me.BTN_ImgAniModCat.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_ImgAniModCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ImgAniModCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ImgAniModCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ImgAniModCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ImgAniModCat.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_ImgAniModCat.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ImgAniModCat.ForeColor = System.Drawing.Color.White
        Me.BTN_ImgAniModCat.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_ImgAniModCat.Location = New System.Drawing.Point(219, 53)
        Me.BTN_ImgAniModCat.Name = "BTN_ImgAniModCat"
        Me.BTN_ImgAniModCat.Size = New System.Drawing.Size(196, 83)
        Me.BTN_ImgAniModCat.TabIndex = 117
        Me.BTN_ImgAniModCat.Text = "Fondo animado"
        '
        'BTN_imgEstModCat
        '
        Me.BTN_imgEstModCat.BackColor = System.Drawing.Color.Transparent
        Me.BTN_imgEstModCat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_imgEstModCat.BorderRadius = 25
        Me.BTN_imgEstModCat.BorderThickness = 1
        Me.BTN_imgEstModCat.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_imgEstModCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_imgEstModCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_imgEstModCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_imgEstModCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_imgEstModCat.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_imgEstModCat.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_imgEstModCat.ForeColor = System.Drawing.Color.White
        Me.BTN_imgEstModCat.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_imgEstModCat.Location = New System.Drawing.Point(17, 53)
        Me.BTN_imgEstModCat.Name = "BTN_imgEstModCat"
        Me.BTN_imgEstModCat.Size = New System.Drawing.Size(196, 83)
        Me.BTN_imgEstModCat.TabIndex = 116
        Me.BTN_imgEstModCat.Text = "Fondo Estático"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(441, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 23)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Tema al que pertenece la categoría:"
        '
        'CBX_TemaModCat
        '
        Me.CBX_TemaModCat.AutoRoundedCorners = True
        Me.CBX_TemaModCat.BackColor = System.Drawing.Color.Transparent
        Me.CBX_TemaModCat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.CBX_TemaModCat.BorderRadius = 17
        Me.CBX_TemaModCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBX_TemaModCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_TemaModCat.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_TemaModCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_TemaModCat.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBX_TemaModCat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBX_TemaModCat.ItemHeight = 30
        Me.CBX_TemaModCat.Location = New System.Drawing.Point(445, 243)
        Me.CBX_TemaModCat.Name = "CBX_TemaModCat"
        Me.CBX_TemaModCat.Size = New System.Drawing.Size(430, 36)
        Me.CBX_TemaModCat.TabIndex = 109
        '
        'BTN_RegresarModCat
        '
        Me.BTN_RegresarModCat.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarModCat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_RegresarModCat.BorderRadius = 25
        Me.BTN_RegresarModCat.BorderThickness = 1
        Me.BTN_RegresarModCat.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_RegresarModCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarModCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarModCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarModCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarModCat.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarModCat.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarModCat.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarModCat.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarModCat.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarModCat.Location = New System.Drawing.Point(180, 556)
        Me.BTN_RegresarModCat.Name = "BTN_RegresarModCat"
        Me.BTN_RegresarModCat.Size = New System.Drawing.Size(274, 72)
        Me.BTN_RegresarModCat.TabIndex = 108
        Me.BTN_RegresarModCat.Text = "Regresar"
        '
        'TXT_DescModCat
        '
        Me.TXT_DescModCat.BackColor = System.Drawing.Color.Transparent
        Me.TXT_DescModCat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_DescModCat.BorderRadius = 25
        Me.TXT_DescModCat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_DescModCat.DefaultText = ""
        Me.TXT_DescModCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_DescModCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_DescModCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_DescModCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_DescModCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_DescModCat.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.TXT_DescModCat.ForeColor = System.Drawing.Color.Black
        Me.TXT_DescModCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_DescModCat.Location = New System.Drawing.Point(49, 321)
        Me.TXT_DescModCat.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_DescModCat.MaxLength = 500
        Me.TXT_DescModCat.Multiline = True
        Me.TXT_DescModCat.Name = "TXT_DescModCat"
        Me.TXT_DescModCat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_DescModCat.PlaceholderText = "Descripción (MAX 500 caracteres)"
        Me.TXT_DescModCat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_DescModCat.SelectedText = ""
        Me.TXT_DescModCat.Size = New System.Drawing.Size(372, 215)
        Me.TXT_DescModCat.TabIndex = 107
        '
        'TXT_NombreModCat
        '
        Me.TXT_NombreModCat.AutoRoundedCorners = True
        Me.TXT_NombreModCat.BackColor = System.Drawing.Color.Transparent
        Me.TXT_NombreModCat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_NombreModCat.BorderRadius = 17
        Me.TXT_NombreModCat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NombreModCat.DefaultText = ""
        Me.TXT_NombreModCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NombreModCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NombreModCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreModCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreModCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreModCat.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.TXT_NombreModCat.ForeColor = System.Drawing.Color.Black
        Me.TXT_NombreModCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreModCat.Location = New System.Drawing.Point(49, 243)
        Me.TXT_NombreModCat.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_NombreModCat.MaxLength = 150
        Me.TXT_NombreModCat.Name = "TXT_NombreModCat"
        Me.TXT_NombreModCat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NombreModCat.PlaceholderText = "Nombre de la categoría (MAX 150 caracteres)"
        Me.TXT_NombreModCat.SelectedText = ""
        Me.TXT_NombreModCat.Size = New System.Drawing.Size(372, 36)
        Me.TXT_NombreModCat.TabIndex = 106
        Me.TXT_NombreModCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloModCat
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(245, -67)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(403, 346)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 105
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'OFD_ImgEstCatMod
        '
        Me.OFD_ImgEstCatMod.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif"
        '
        'OFD_ImgAniModCat
        '
        Me.OFD_ImgAniModCat.Filter = "Archivos de video|*.mp4;*.avi;*.mkv;*.mov"
        '
        'OFD_AudioModCat
        '
        Me.OFD_AudioModCat.Filter = "Archivos de audio|*.wav"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(57, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(57, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 23)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Descripción:"
        '
        'E_PModCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.FondoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(934, 657)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_GuardarModCat)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBX_TemaModCat)
        Me.Controls.Add(Me.BTN_RegresarModCat)
        Me.Controls.Add(Me.TXT_DescModCat)
        Me.Controls.Add(Me.TXT_NombreModCat)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_PModCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar categoría"
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_GuardarModCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBX_TemaModCat As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BTN_RegresarModCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_DescModCat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_NombreModCat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTN_AudioModCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_ImgAniModCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_imgEstModCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OFD_ImgEstCatMod As OpenFileDialog
    Friend WithEvents OFD_ImgAniModCat As OpenFileDialog
    Friend WithEvents OFD_AudioModCat As OpenFileDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
