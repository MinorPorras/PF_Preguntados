<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_PNuevaCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_PNuevaCategoria))
        Me.BTN_AgregarNuevaCat = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BTN_AudioNuevaCat = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_ImgAniNuevaCat = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_imgEstNuevaCat = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBX_Tema_NuevaCat = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BTN_RegresarNuevaCat = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_Desc_NuevaCat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_NombreNuevaCat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.OFD_ImgEstCatNueva = New System.Windows.Forms.OpenFileDialog()
        Me.OFD_ImgAniNuevaCat = New System.Windows.Forms.OpenFileDialog()
        Me.OFD_AudioNuevaCat = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_AgregarNuevaCat
        '
        Me.BTN_AgregarNuevaCat.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AgregarNuevaCat.BorderColor = System.Drawing.Color.White
        Me.BTN_AgregarNuevaCat.BorderRadius = 25
        Me.BTN_AgregarNuevaCat.BorderThickness = 1
        Me.BTN_AgregarNuevaCat.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_AgregarNuevaCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarNuevaCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarNuevaCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AgregarNuevaCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AgregarNuevaCat.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_AgregarNuevaCat.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AgregarNuevaCat.ForeColor = System.Drawing.Color.White
        Me.BTN_AgregarNuevaCat.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_AgregarNuevaCat.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_AgregarNuevaCat.Location = New System.Drawing.Point(489, 555)
        Me.BTN_AgregarNuevaCat.Name = "BTN_AgregarNuevaCat"
        Me.BTN_AgregarNuevaCat.Size = New System.Drawing.Size(274, 72)
        Me.BTN_AgregarNuevaCat.TabIndex = 112
        Me.BTN_AgregarNuevaCat.Text = "Agregar"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderRadius = 20
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_AudioNuevaCat)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_ImgAniNuevaCat)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_imgEstNuevaCat)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(456, 292)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(430, 242)
        Me.Guna2GroupBox1.TabIndex = 111
        Me.Guna2GroupBox1.Text = "Busqueda de Archivos"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_AudioNuevaCat
        '
        Me.BTN_AudioNuevaCat.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AudioNuevaCat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_AudioNuevaCat.BorderRadius = 25
        Me.BTN_AudioNuevaCat.BorderThickness = 1
        Me.BTN_AudioNuevaCat.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_AudioNuevaCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AudioNuevaCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AudioNuevaCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AudioNuevaCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AudioNuevaCat.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_AudioNuevaCat.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AudioNuevaCat.ForeColor = System.Drawing.Color.White
        Me.BTN_AudioNuevaCat.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_AudioNuevaCat.Location = New System.Drawing.Point(124, 145)
        Me.BTN_AudioNuevaCat.Name = "BTN_AudioNuevaCat"
        Me.BTN_AudioNuevaCat.Size = New System.Drawing.Size(196, 83)
        Me.BTN_AudioNuevaCat.TabIndex = 107
        Me.BTN_AudioNuevaCat.Text = "3. Sonido de fondo"
        '
        'BTN_ImgAniNuevaCat
        '
        Me.BTN_ImgAniNuevaCat.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ImgAniNuevaCat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_ImgAniNuevaCat.BorderRadius = 25
        Me.BTN_ImgAniNuevaCat.BorderThickness = 1
        Me.BTN_ImgAniNuevaCat.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_ImgAniNuevaCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ImgAniNuevaCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ImgAniNuevaCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ImgAniNuevaCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ImgAniNuevaCat.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_ImgAniNuevaCat.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ImgAniNuevaCat.ForeColor = System.Drawing.Color.White
        Me.BTN_ImgAniNuevaCat.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_ImgAniNuevaCat.Location = New System.Drawing.Point(231, 56)
        Me.BTN_ImgAniNuevaCat.Name = "BTN_ImgAniNuevaCat"
        Me.BTN_ImgAniNuevaCat.Size = New System.Drawing.Size(196, 83)
        Me.BTN_ImgAniNuevaCat.TabIndex = 106
        Me.BTN_ImgAniNuevaCat.Text = "2. Fondo animado"
        '
        'BTN_imgEstNuevaCat
        '
        Me.BTN_imgEstNuevaCat.BackColor = System.Drawing.Color.Transparent
        Me.BTN_imgEstNuevaCat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_imgEstNuevaCat.BorderRadius = 25
        Me.BTN_imgEstNuevaCat.BorderThickness = 1
        Me.BTN_imgEstNuevaCat.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_imgEstNuevaCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_imgEstNuevaCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_imgEstNuevaCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_imgEstNuevaCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_imgEstNuevaCat.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_imgEstNuevaCat.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_imgEstNuevaCat.ForeColor = System.Drawing.Color.White
        Me.BTN_imgEstNuevaCat.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_imgEstNuevaCat.Location = New System.Drawing.Point(13, 56)
        Me.BTN_imgEstNuevaCat.Name = "BTN_imgEstNuevaCat"
        Me.BTN_imgEstNuevaCat.Size = New System.Drawing.Size(196, 83)
        Me.BTN_imgEstNuevaCat.TabIndex = 105
        Me.BTN_imgEstNuevaCat.Text = "1. Fondo Estático"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(452, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 23)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Tema al que pertenece la categoría:"
        '
        'CBX_Tema_NuevaCat
        '
        Me.CBX_Tema_NuevaCat.AutoRoundedCorners = True
        Me.CBX_Tema_NuevaCat.BackColor = System.Drawing.Color.Transparent
        Me.CBX_Tema_NuevaCat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.CBX_Tema_NuevaCat.BorderRadius = 17
        Me.CBX_Tema_NuevaCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBX_Tema_NuevaCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_Tema_NuevaCat.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_Tema_NuevaCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_Tema_NuevaCat.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBX_Tema_NuevaCat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBX_Tema_NuevaCat.ItemHeight = 30
        Me.CBX_Tema_NuevaCat.Location = New System.Drawing.Point(456, 224)
        Me.CBX_Tema_NuevaCat.Name = "CBX_Tema_NuevaCat"
        Me.CBX_Tema_NuevaCat.Size = New System.Drawing.Size(430, 36)
        Me.CBX_Tema_NuevaCat.TabIndex = 109
        '
        'BTN_RegresarNuevaCat
        '
        Me.BTN_RegresarNuevaCat.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarNuevaCat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_RegresarNuevaCat.BorderRadius = 25
        Me.BTN_RegresarNuevaCat.BorderThickness = 1
        Me.BTN_RegresarNuevaCat.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_RegresarNuevaCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarNuevaCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarNuevaCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarNuevaCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarNuevaCat.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarNuevaCat.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarNuevaCat.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarNuevaCat.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarNuevaCat.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarNuevaCat.Location = New System.Drawing.Point(169, 555)
        Me.BTN_RegresarNuevaCat.Name = "BTN_RegresarNuevaCat"
        Me.BTN_RegresarNuevaCat.Size = New System.Drawing.Size(274, 72)
        Me.BTN_RegresarNuevaCat.TabIndex = 108
        Me.BTN_RegresarNuevaCat.Text = "Regresar"
        '
        'TXT_Desc_NuevaCat
        '
        Me.TXT_Desc_NuevaCat.BackColor = System.Drawing.Color.Transparent
        Me.TXT_Desc_NuevaCat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_Desc_NuevaCat.BorderRadius = 25
        Me.TXT_Desc_NuevaCat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Desc_NuevaCat.DefaultText = ""
        Me.TXT_Desc_NuevaCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Desc_NuevaCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Desc_NuevaCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Desc_NuevaCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Desc_NuevaCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Desc_NuevaCat.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.TXT_Desc_NuevaCat.ForeColor = System.Drawing.Color.Black
        Me.TXT_Desc_NuevaCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Desc_NuevaCat.Location = New System.Drawing.Point(57, 319)
        Me.TXT_Desc_NuevaCat.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_Desc_NuevaCat.MaxLength = 500
        Me.TXT_Desc_NuevaCat.Multiline = True
        Me.TXT_Desc_NuevaCat.Name = "TXT_Desc_NuevaCat"
        Me.TXT_Desc_NuevaCat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Desc_NuevaCat.PlaceholderText = "Descripción (MAX 500 caracteres)"
        Me.TXT_Desc_NuevaCat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_Desc_NuevaCat.SelectedText = ""
        Me.TXT_Desc_NuevaCat.Size = New System.Drawing.Size(372, 215)
        Me.TXT_Desc_NuevaCat.TabIndex = 107
        '
        'TXT_NombreNuevaCat
        '
        Me.TXT_NombreNuevaCat.AutoRoundedCorners = True
        Me.TXT_NombreNuevaCat.BackColor = System.Drawing.Color.Transparent
        Me.TXT_NombreNuevaCat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_NombreNuevaCat.BorderRadius = 17
        Me.TXT_NombreNuevaCat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NombreNuevaCat.DefaultText = ""
        Me.TXT_NombreNuevaCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NombreNuevaCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NombreNuevaCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreNuevaCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreNuevaCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreNuevaCat.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.TXT_NombreNuevaCat.ForeColor = System.Drawing.Color.Black
        Me.TXT_NombreNuevaCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreNuevaCat.Location = New System.Drawing.Point(57, 224)
        Me.TXT_NombreNuevaCat.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_NombreNuevaCat.MaxLength = 150
        Me.TXT_NombreNuevaCat.Name = "TXT_NombreNuevaCat"
        Me.TXT_NombreNuevaCat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NombreNuevaCat.PlaceholderText = "Nombre de la categoría (MAX 150 caracteres)"
        Me.TXT_NombreNuevaCat.SelectedText = ""
        Me.TXT_NombreNuevaCat.Size = New System.Drawing.Size(372, 36)
        Me.TXT_NombreNuevaCat.TabIndex = 106
        Me.TXT_NombreNuevaCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloNuevaCat
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(262, -70)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(403, 346)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 105
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'OFD_ImgEstCatNueva
        '
        Me.OFD_ImgEstCatNueva.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif"
        '
        'OFD_ImgAniNuevaCat
        '
        Me.OFD_ImgAniNuevaCat.Filter = "Archivos de video|*.mp4;*.avi;*.mkv;*.mov"
        '
        'OFD_AudioNuevaCat
        '
        Me.OFD_AudioNuevaCat.Filter = "Archivos de audio|*.wav"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(53, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(53, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 23)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Descripción:"
        '
        'E_PNuevaCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.FondoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(934, 657)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_AgregarNuevaCat)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBX_Tema_NuevaCat)
        Me.Controls.Add(Me.BTN_RegresarNuevaCat)
        Me.Controls.Add(Me.TXT_Desc_NuevaCat)
        Me.Controls.Add(Me.TXT_NombreNuevaCat)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_PNuevaCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Categoría"
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_AgregarNuevaCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents BTN_AudioNuevaCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_ImgAniNuevaCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_imgEstNuevaCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CBX_Tema_NuevaCat As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BTN_RegresarNuevaCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_Desc_NuevaCat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_NombreNuevaCat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents OFD_ImgEstCatNueva As OpenFileDialog
    Friend WithEvents OFD_ImgAniNuevaCat As OpenFileDialog
    Friend WithEvents OFD_AudioNuevaCat As OpenFileDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
