<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_PModTema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_PModTema))
        Me.BTN_GuardarModTema = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BTN_SonidoTemaMod = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_AudioModTema = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_ImagenAniModTema = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_ImagenEstModTema = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBX_AsigModTema = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TXT_DescModTema = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_NombreModTema = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_RegresaModTema = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.OFD_ImgEstaticaTemaMod = New System.Windows.Forms.OpenFileDialog()
        Me.OFD_ImgAnimTemaMod = New System.Windows.Forms.OpenFileDialog()
        Me.OFD_AudioTemaMod = New System.Windows.Forms.OpenFileDialog()
        Me.OFD_SonidoTemaMod = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_GuardarModTema
        '
        Me.BTN_GuardarModTema.BackColor = System.Drawing.Color.Transparent
        Me.BTN_GuardarModTema.BorderColor = System.Drawing.Color.White
        Me.BTN_GuardarModTema.BorderRadius = 25
        Me.BTN_GuardarModTema.BorderThickness = 1
        Me.BTN_GuardarModTema.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_GuardarModTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GuardarModTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GuardarModTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_GuardarModTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_GuardarModTema.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_GuardarModTema.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GuardarModTema.ForeColor = System.Drawing.Color.White
        Me.BTN_GuardarModTema.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_GuardarModTema.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_GuardarModTema.Location = New System.Drawing.Point(483, 573)
        Me.BTN_GuardarModTema.Name = "BTN_GuardarModTema"
        Me.BTN_GuardarModTema.Size = New System.Drawing.Size(274, 72)
        Me.BTN_GuardarModTema.TabIndex = 117
        Me.BTN_GuardarModTema.Text = "Agregar"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderRadius = 20
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_SonidoTemaMod)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_AudioModTema)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_ImagenAniModTema)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_ImagenEstModTema)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(421, 312)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(443, 242)
        Me.Guna2GroupBox1.TabIndex = 116
        Me.Guna2GroupBox1.Text = "Busqueda de Archivos"
        '
        'BTN_SonidoTemaMod
        '
        Me.BTN_SonidoTemaMod.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SonidoTemaMod.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_SonidoTemaMod.BorderRadius = 25
        Me.BTN_SonidoTemaMod.BorderThickness = 1
        Me.BTN_SonidoTemaMod.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_SonidoTemaMod.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SonidoTemaMod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SonidoTemaMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_SonidoTemaMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_SonidoTemaMod.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_SonidoTemaMod.Font = New System.Drawing.Font("Showcard Gothic", 13.8!)
        Me.BTN_SonidoTemaMod.ForeColor = System.Drawing.Color.White
        Me.BTN_SonidoTemaMod.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_SonidoTemaMod.Location = New System.Drawing.Point(227, 142)
        Me.BTN_SonidoTemaMod.Name = "BTN_SonidoTemaMod"
        Me.BTN_SonidoTemaMod.Size = New System.Drawing.Size(196, 83)
        Me.BTN_SonidoTemaMod.TabIndex = 108
        Me.BTN_SonidoTemaMod.Text = "4. Sonido de fondo"
        '
        'BTN_AudioModTema
        '
        Me.BTN_AudioModTema.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AudioModTema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_AudioModTema.BorderRadius = 25
        Me.BTN_AudioModTema.BorderThickness = 1
        Me.BTN_AudioModTema.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_AudioModTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AudioModTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AudioModTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AudioModTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AudioModTema.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_AudioModTema.Font = New System.Drawing.Font("Showcard Gothic", 13.8!)
        Me.BTN_AudioModTema.ForeColor = System.Drawing.Color.White
        Me.BTN_AudioModTema.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_AudioModTema.Location = New System.Drawing.Point(25, 142)
        Me.BTN_AudioModTema.Name = "BTN_AudioModTema"
        Me.BTN_AudioModTema.Size = New System.Drawing.Size(196, 83)
        Me.BTN_AudioModTema.TabIndex = 106
        Me.BTN_AudioModTema.Text = "3. Audio de voz"
        '
        'BTN_ImagenAniModTema
        '
        Me.BTN_ImagenAniModTema.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ImagenAniModTema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_ImagenAniModTema.BorderRadius = 25
        Me.BTN_ImagenAniModTema.BorderThickness = 1
        Me.BTN_ImagenAniModTema.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_ImagenAniModTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ImagenAniModTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ImagenAniModTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ImagenAniModTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ImagenAniModTema.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_ImagenAniModTema.Font = New System.Drawing.Font("Showcard Gothic", 13.8!)
        Me.BTN_ImagenAniModTema.ForeColor = System.Drawing.Color.White
        Me.BTN_ImagenAniModTema.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_ImagenAniModTema.Location = New System.Drawing.Point(227, 53)
        Me.BTN_ImagenAniModTema.Name = "BTN_ImagenAniModTema"
        Me.BTN_ImagenAniModTema.Size = New System.Drawing.Size(196, 83)
        Me.BTN_ImagenAniModTema.TabIndex = 105
        Me.BTN_ImagenAniModTema.Text = "2. Fondo animado"
        '
        'BTN_ImagenEstModTema
        '
        Me.BTN_ImagenEstModTema.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ImagenEstModTema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_ImagenEstModTema.BorderRadius = 25
        Me.BTN_ImagenEstModTema.BorderThickness = 1
        Me.BTN_ImagenEstModTema.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_ImagenEstModTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ImagenEstModTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ImagenEstModTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ImagenEstModTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ImagenEstModTema.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_ImagenEstModTema.Font = New System.Drawing.Font("Showcard Gothic", 13.8!)
        Me.BTN_ImagenEstModTema.ForeColor = System.Drawing.Color.White
        Me.BTN_ImagenEstModTema.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_ImagenEstModTema.Location = New System.Drawing.Point(25, 53)
        Me.BTN_ImagenEstModTema.Name = "BTN_ImagenEstModTema"
        Me.BTN_ImagenEstModTema.Size = New System.Drawing.Size(196, 83)
        Me.BTN_ImagenEstModTema.TabIndex = 104
        Me.BTN_ImagenEstModTema.Text = "1. Fondo estático"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(430, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 23)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Asignatura a la que pertenece:"
        '
        'CBX_AsigModTema
        '
        Me.CBX_AsigModTema.AutoRoundedCorners = True
        Me.CBX_AsigModTema.BackColor = System.Drawing.Color.Transparent
        Me.CBX_AsigModTema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.CBX_AsigModTema.BorderRadius = 17
        Me.CBX_AsigModTema.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBX_AsigModTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_AsigModTema.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_AsigModTema.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_AsigModTema.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBX_AsigModTema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBX_AsigModTema.ItemHeight = 30
        Me.CBX_AsigModTema.Location = New System.Drawing.Point(421, 245)
        Me.CBX_AsigModTema.Name = "CBX_AsigModTema"
        Me.CBX_AsigModTema.Size = New System.Drawing.Size(443, 36)
        Me.CBX_AsigModTema.TabIndex = 114
        '
        'TXT_DescModTema
        '
        Me.TXT_DescModTema.BackColor = System.Drawing.Color.Transparent
        Me.TXT_DescModTema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_DescModTema.BorderRadius = 25
        Me.TXT_DescModTema.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_DescModTema.DefaultText = ""
        Me.TXT_DescModTema.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_DescModTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_DescModTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_DescModTema.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_DescModTema.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_DescModTema.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DescModTema.ForeColor = System.Drawing.Color.Black
        Me.TXT_DescModTema.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_DescModTema.Location = New System.Drawing.Point(42, 339)
        Me.TXT_DescModTema.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_DescModTema.MaxLength = 500
        Me.TXT_DescModTema.Multiline = True
        Me.TXT_DescModTema.Name = "TXT_DescModTema"
        Me.TXT_DescModTema.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_DescModTema.PlaceholderText = "Descripción (MAX 500 caracteres)"
        Me.TXT_DescModTema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_DescModTema.SelectedText = ""
        Me.TXT_DescModTema.Size = New System.Drawing.Size(372, 215)
        Me.TXT_DescModTema.TabIndex = 113
        '
        'TXT_NombreModTema
        '
        Me.TXT_NombreModTema.AutoRoundedCorners = True
        Me.TXT_NombreModTema.BackColor = System.Drawing.Color.Transparent
        Me.TXT_NombreModTema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_NombreModTema.BorderRadius = 17
        Me.TXT_NombreModTema.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NombreModTema.DefaultText = ""
        Me.TXT_NombreModTema.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NombreModTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NombreModTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreModTema.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreModTema.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreModTema.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NombreModTema.ForeColor = System.Drawing.Color.Black
        Me.TXT_NombreModTema.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreModTema.Location = New System.Drawing.Point(42, 245)
        Me.TXT_NombreModTema.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_NombreModTema.MaxLength = 150
        Me.TXT_NombreModTema.Name = "TXT_NombreModTema"
        Me.TXT_NombreModTema.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NombreModTema.PlaceholderText = "Nombre del tema ( MAX 150 caracteres)"
        Me.TXT_NombreModTema.SelectedText = ""
        Me.TXT_NombreModTema.Size = New System.Drawing.Size(372, 36)
        Me.TXT_NombreModTema.TabIndex = 112
        Me.TXT_NombreModTema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_RegresaModTema
        '
        Me.BTN_RegresaModTema.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresaModTema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_RegresaModTema.BorderRadius = 25
        Me.BTN_RegresaModTema.BorderThickness = 1
        Me.BTN_RegresaModTema.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_RegresaModTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresaModTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresaModTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresaModTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresaModTema.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresaModTema.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresaModTema.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresaModTema.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresaModTema.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresaModTema.Location = New System.Drawing.Point(140, 573)
        Me.BTN_RegresaModTema.Name = "BTN_RegresaModTema"
        Me.BTN_RegresaModTema.Size = New System.Drawing.Size(274, 72)
        Me.BTN_RegresaModTema.TabIndex = 110
        Me.BTN_RegresaModTema.Text = "Regresar"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloModTema
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(268, -71)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(393, 343)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 111
        Me.Guna2PictureBox1.TabStop = False
        '
        'OFD_ImgEstaticaTemaMod
        '
        Me.OFD_ImgEstaticaTemaMod.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif"
        '
        'OFD_ImgAnimTemaMod
        '
        Me.OFD_ImgAnimTemaMod.Filter = "Archivos de video|*.mp4;*.avi;*.mkv;*.mov"
        '
        'OFD_AudioTemaMod
        '
        Me.OFD_AudioTemaMod.Filter = "Archivos de audio|*.wav"
        '
        'OFD_SonidoTemaMod
        '
        Me.OFD_SonidoTemaMod.Filter = "Archivos de audio|*.wav"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(58, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 23)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(58, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 23)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "Descripción:"
        '
        'E_PModTema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.FondoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(905, 677)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTN_GuardarModTema)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBX_AsigModTema)
        Me.Controls.Add(Me.TXT_DescModTema)
        Me.Controls.Add(Me.TXT_NombreModTema)
        Me.Controls.Add(Me.BTN_RegresaModTema)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_PModTema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Tema"
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_GuardarModTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents BTN_AudioModTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_ImagenAniModTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_ImagenEstModTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CBX_AsigModTema As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXT_DescModTema As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_NombreModTema As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_RegresaModTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents OFD_ImgEstaticaTemaMod As OpenFileDialog
    Friend WithEvents OFD_ImgAnimTemaMod As OpenFileDialog
    Friend WithEvents OFD_AudioTemaMod As OpenFileDialog
    Friend WithEvents BTN_SonidoTemaMod As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OFD_SonidoTemaMod As OpenFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
