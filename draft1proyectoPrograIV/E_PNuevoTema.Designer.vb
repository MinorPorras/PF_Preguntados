<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_PNuevoTema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_PNuevoTema))
        Me.BTNRegresaNuevoTema = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TXT_NombreNuevoTema = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_DescNuevoTema = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBX_AsigNuevoTema = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BTN_SonidoTemaNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_AudioNuevoTema = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_ImagenAniNuevoTema = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_ImagenEstNuevaTema = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_AgregarNuevoTema = New Guna.UI2.WinForms.Guna2Button()
        Me.OFD_ImgEstaticaTemaNuevo = New System.Windows.Forms.OpenFileDialog()
        Me.OFD_ImgAnimTemaNuevo = New System.Windows.Forms.OpenFileDialog()
        Me.OFD_AudioTemaNuevo = New System.Windows.Forms.OpenFileDialog()
        Me.OFD_SonidoTemaNuevo = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNRegresaNuevoTema
        '
        Me.BTNRegresaNuevoTema.BackColor = System.Drawing.Color.Transparent
        Me.BTNRegresaNuevoTema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTNRegresaNuevoTema.BorderRadius = 25
        Me.BTNRegresaNuevoTema.BorderThickness = 1
        Me.BTNRegresaNuevoTema.CustomBorderColor = System.Drawing.Color.White
        Me.BTNRegresaNuevoTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNRegresaNuevoTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNRegresaNuevoTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNRegresaNuevoTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNRegresaNuevoTema.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTNRegresaNuevoTema.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRegresaNuevoTema.ForeColor = System.Drawing.Color.White
        Me.BTNRegresaNuevoTema.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTNRegresaNuevoTema.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTNRegresaNuevoTema.Location = New System.Drawing.Point(163, 553)
        Me.BTNRegresaNuevoTema.Name = "BTNRegresaNuevoTema"
        Me.BTNRegresaNuevoTema.Size = New System.Drawing.Size(274, 72)
        Me.BTNRegresaNuevoTema.TabIndex = 94
        Me.BTNRegresaNuevoTema.Text = "Regresar"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloNuevoTema
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(271, -69)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(393, 343)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 97
        Me.Guna2PictureBox1.TabStop = False
        '
        'TXT_NombreNuevoTema
        '
        Me.TXT_NombreNuevoTema.AutoRoundedCorners = True
        Me.TXT_NombreNuevoTema.BackColor = System.Drawing.Color.Transparent
        Me.TXT_NombreNuevoTema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_NombreNuevoTema.BorderRadius = 17
        Me.TXT_NombreNuevoTema.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NombreNuevoTema.DefaultText = ""
        Me.TXT_NombreNuevoTema.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NombreNuevoTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NombreNuevoTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreNuevoTema.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreNuevoTema.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreNuevoTema.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.TXT_NombreNuevoTema.ForeColor = System.Drawing.Color.Black
        Me.TXT_NombreNuevoTema.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreNuevoTema.Location = New System.Drawing.Point(44, 238)
        Me.TXT_NombreNuevoTema.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_NombreNuevoTema.MaxLength = 150
        Me.TXT_NombreNuevoTema.Name = "TXT_NombreNuevoTema"
        Me.TXT_NombreNuevoTema.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NombreNuevoTema.PlaceholderText = "Nombre del tema (MAX 150 caracteres)"
        Me.TXT_NombreNuevoTema.SelectedText = ""
        Me.TXT_NombreNuevoTema.Size = New System.Drawing.Size(372, 36)
        Me.TXT_NombreNuevoTema.TabIndex = 104
        Me.TXT_NombreNuevoTema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_DescNuevoTema
        '
        Me.TXT_DescNuevoTema.BackColor = System.Drawing.Color.Transparent
        Me.TXT_DescNuevoTema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_DescNuevoTema.BorderRadius = 25
        Me.TXT_DescNuevoTema.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_DescNuevoTema.DefaultText = ""
        Me.TXT_DescNuevoTema.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_DescNuevoTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_DescNuevoTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_DescNuevoTema.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_DescNuevoTema.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_DescNuevoTema.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.TXT_DescNuevoTema.ForeColor = System.Drawing.Color.Black
        Me.TXT_DescNuevoTema.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_DescNuevoTema.Location = New System.Drawing.Point(44, 314)
        Me.TXT_DescNuevoTema.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_DescNuevoTema.MaxLength = 500
        Me.TXT_DescNuevoTema.Multiline = True
        Me.TXT_DescNuevoTema.Name = "TXT_DescNuevoTema"
        Me.TXT_DescNuevoTema.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_DescNuevoTema.PlaceholderText = "Descripción (MAX 500 caracteres)"
        Me.TXT_DescNuevoTema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_DescNuevoTema.SelectedText = ""
        Me.TXT_DescNuevoTema.Size = New System.Drawing.Size(372, 215)
        Me.TXT_DescNuevoTema.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(419, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(447, 23)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Asignatura al que pertenece la categoría:"
        '
        'CBX_AsigNuevoTema
        '
        Me.CBX_AsigNuevoTema.AutoRoundedCorners = True
        Me.CBX_AsigNuevoTema.BackColor = System.Drawing.Color.Transparent
        Me.CBX_AsigNuevoTema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.CBX_AsigNuevoTema.BorderRadius = 17
        Me.CBX_AsigNuevoTema.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBX_AsigNuevoTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_AsigNuevoTema.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_AsigNuevoTema.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_AsigNuevoTema.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBX_AsigNuevoTema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBX_AsigNuevoTema.ItemHeight = 30
        Me.CBX_AsigNuevoTema.Location = New System.Drawing.Point(423, 238)
        Me.CBX_AsigNuevoTema.Name = "CBX_AsigNuevoTema"
        Me.CBX_AsigNuevoTema.Size = New System.Drawing.Size(443, 36)
        Me.CBX_AsigNuevoTema.TabIndex = 106
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderRadius = 20
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_SonidoTemaNuevo)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_AudioNuevoTema)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_ImagenAniNuevoTema)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_ImagenEstNuevaTema)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(423, 297)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(443, 232)
        Me.Guna2GroupBox1.TabIndex = 108
        Me.Guna2GroupBox1.Text = "Busqueda de Archivos"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_SonidoTemaNuevo
        '
        Me.BTN_SonidoTemaNuevo.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SonidoTemaNuevo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_SonidoTemaNuevo.BorderRadius = 25
        Me.BTN_SonidoTemaNuevo.BorderThickness = 1
        Me.BTN_SonidoTemaNuevo.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_SonidoTemaNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SonidoTemaNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SonidoTemaNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_SonidoTemaNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_SonidoTemaNuevo.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_SonidoTemaNuevo.Font = New System.Drawing.Font("Showcard Gothic", 13.8!)
        Me.BTN_SonidoTemaNuevo.ForeColor = System.Drawing.Color.White
        Me.BTN_SonidoTemaNuevo.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_SonidoTemaNuevo.Location = New System.Drawing.Point(232, 138)
        Me.BTN_SonidoTemaNuevo.Name = "BTN_SonidoTemaNuevo"
        Me.BTN_SonidoTemaNuevo.Size = New System.Drawing.Size(196, 83)
        Me.BTN_SonidoTemaNuevo.TabIndex = 107
        Me.BTN_SonidoTemaNuevo.Text = "4. Sonido de fondo"
        '
        'BTN_AudioNuevoTema
        '
        Me.BTN_AudioNuevoTema.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AudioNuevoTema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_AudioNuevoTema.BorderRadius = 25
        Me.BTN_AudioNuevoTema.BorderThickness = 1
        Me.BTN_AudioNuevoTema.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_AudioNuevoTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AudioNuevoTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AudioNuevoTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AudioNuevoTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AudioNuevoTema.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_AudioNuevoTema.Font = New System.Drawing.Font("Showcard Gothic", 13.8!)
        Me.BTN_AudioNuevoTema.ForeColor = System.Drawing.Color.White
        Me.BTN_AudioNuevoTema.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_AudioNuevoTema.Location = New System.Drawing.Point(15, 138)
        Me.BTN_AudioNuevoTema.Name = "BTN_AudioNuevoTema"
        Me.BTN_AudioNuevoTema.Size = New System.Drawing.Size(196, 83)
        Me.BTN_AudioNuevoTema.TabIndex = 106
        Me.BTN_AudioNuevoTema.Text = "3. Audio de voz"
        '
        'BTN_ImagenAniNuevoTema
        '
        Me.BTN_ImagenAniNuevoTema.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ImagenAniNuevoTema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_ImagenAniNuevoTema.BorderRadius = 25
        Me.BTN_ImagenAniNuevoTema.BorderThickness = 1
        Me.BTN_ImagenAniNuevoTema.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_ImagenAniNuevoTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ImagenAniNuevoTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ImagenAniNuevoTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ImagenAniNuevoTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ImagenAniNuevoTema.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_ImagenAniNuevoTema.Font = New System.Drawing.Font("Showcard Gothic", 13.8!)
        Me.BTN_ImagenAniNuevoTema.ForeColor = System.Drawing.Color.White
        Me.BTN_ImagenAniNuevoTema.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_ImagenAniNuevoTema.Location = New System.Drawing.Point(232, 49)
        Me.BTN_ImagenAniNuevoTema.Name = "BTN_ImagenAniNuevoTema"
        Me.BTN_ImagenAniNuevoTema.Size = New System.Drawing.Size(196, 83)
        Me.BTN_ImagenAniNuevoTema.TabIndex = 105
        Me.BTN_ImagenAniNuevoTema.Text = "2. Fondo animado"
        '
        'BTN_ImagenEstNuevaTema
        '
        Me.BTN_ImagenEstNuevaTema.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ImagenEstNuevaTema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BTN_ImagenEstNuevaTema.BorderRadius = 25
        Me.BTN_ImagenEstNuevaTema.BorderThickness = 1
        Me.BTN_ImagenEstNuevaTema.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_ImagenEstNuevaTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ImagenEstNuevaTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ImagenEstNuevaTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ImagenEstNuevaTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ImagenEstNuevaTema.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_ImagenEstNuevaTema.Font = New System.Drawing.Font("Showcard Gothic", 13.8!)
        Me.BTN_ImagenEstNuevaTema.ForeColor = System.Drawing.Color.White
        Me.BTN_ImagenEstNuevaTema.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_ImagenEstNuevaTema.Location = New System.Drawing.Point(15, 49)
        Me.BTN_ImagenEstNuevaTema.Name = "BTN_ImagenEstNuevaTema"
        Me.BTN_ImagenEstNuevaTema.Size = New System.Drawing.Size(196, 83)
        Me.BTN_ImagenEstNuevaTema.TabIndex = 104
        Me.BTN_ImagenEstNuevaTema.Text = "1. Fondo estático"
        '
        'BTN_AgregarNuevoTema
        '
        Me.BTN_AgregarNuevoTema.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AgregarNuevoTema.BorderColor = System.Drawing.Color.White
        Me.BTN_AgregarNuevoTema.BorderRadius = 25
        Me.BTN_AgregarNuevoTema.BorderThickness = 1
        Me.BTN_AgregarNuevoTema.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_AgregarNuevoTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarNuevoTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarNuevoTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AgregarNuevoTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AgregarNuevoTema.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_AgregarNuevoTema.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AgregarNuevoTema.ForeColor = System.Drawing.Color.White
        Me.BTN_AgregarNuevoTema.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_AgregarNuevoTema.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_AgregarNuevoTema.Location = New System.Drawing.Point(477, 553)
        Me.BTN_AgregarNuevoTema.Name = "BTN_AgregarNuevoTema"
        Me.BTN_AgregarNuevoTema.Size = New System.Drawing.Size(274, 72)
        Me.BTN_AgregarNuevoTema.TabIndex = 109
        Me.BTN_AgregarNuevoTema.Text = "Agregar"
        '
        'OFD_ImgEstaticaTemaNuevo
        '
        Me.OFD_ImgEstaticaTemaNuevo.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif"
        '
        'OFD_ImgAnimTemaNuevo
        '
        Me.OFD_ImgAnimTemaNuevo.Filter = "Archivos de video|*.mp4;*.avi;*.mkv;*.mov"
        '
        'OFD_AudioTemaNuevo
        '
        Me.OFD_AudioTemaNuevo.Filter = "Archivos de audio|*.wav"
        '
        'OFD_SonidoTemaNuevo
        '
        Me.OFD_SonidoTemaNuevo.Filter = "Archivos de audio|*.wav"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(52, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(52, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 23)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Descripción:"
        '
        'E_PNuevoTema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.FondoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(905, 657)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_AgregarNuevoTema)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBX_AsigNuevoTema)
        Me.Controls.Add(Me.TXT_DescNuevoTema)
        Me.Controls.Add(Me.TXT_NombreNuevoTema)
        Me.Controls.Add(Me.BTNRegresaNuevoTema)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "E_PNuevoTema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo tema"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNRegresaNuevoTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TXT_NombreNuevoTema As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_DescNuevoTema As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBX_AsigNuevoTema As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents BTN_AudioNuevoTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_ImagenAniNuevoTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_ImagenEstNuevaTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_AgregarNuevoTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OFD_ImgEstaticaTemaNuevo As OpenFileDialog
    Friend WithEvents OFD_ImgAnimTemaNuevo As OpenFileDialog
    Friend WithEvents OFD_AudioTemaNuevo As OpenFileDialog
    Friend WithEvents BTN_SonidoTemaNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OFD_SonidoTemaNuevo As OpenFileDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
