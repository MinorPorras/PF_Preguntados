<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_EComenzarJuego
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_EComenzarJuego))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.CBX_Tema = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GRB_Tema = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.TXT_TiempoTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_PtsTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_CantCat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_ComenzarJuego = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarProfNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_CuentaProf = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.CerrarAPP = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CerrarSesion = New Guna.UI2.WinForms.Guna2CircleButton()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRB_Tema.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloComenzarJugar
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(64, -67)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(431, 325)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'CBX_Tema
        '
        Me.CBX_Tema.AutoRoundedCorners = True
        Me.CBX_Tema.BackColor = System.Drawing.Color.Transparent
        Me.CBX_Tema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.CBX_Tema.BorderRadius = 17
        Me.CBX_Tema.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBX_Tema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_Tema.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_Tema.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_Tema.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBX_Tema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBX_Tema.ItemHeight = 30
        Me.CBX_Tema.Location = New System.Drawing.Point(86, 222)
        Me.CBX_Tema.Name = "CBX_Tema"
        Me.CBX_Tema.Size = New System.Drawing.Size(398, 36)
        Me.CBX_Tema.TabIndex = 129
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(185, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 23)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Seleccione un tema:"
        '
        'GRB_Tema
        '
        Me.GRB_Tema.BackColor = System.Drawing.Color.Transparent
        Me.GRB_Tema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GRB_Tema.BorderRadius = 25
        Me.GRB_Tema.Controls.Add(Me.TXT_TiempoTotal)
        Me.GRB_Tema.Controls.Add(Me.TXT_PtsTotal)
        Me.GRB_Tema.Controls.Add(Me.TXT_CantCat)
        Me.GRB_Tema.Controls.Add(Me.Label4)
        Me.GRB_Tema.Controls.Add(Me.Label3)
        Me.GRB_Tema.Controls.Add(Me.Label2)
        Me.GRB_Tema.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GRB_Tema.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRB_Tema.ForeColor = System.Drawing.Color.White
        Me.GRB_Tema.Location = New System.Drawing.Point(63, 274)
        Me.GRB_Tema.Name = "GRB_Tema"
        Me.GRB_Tema.Size = New System.Drawing.Size(432, 189)
        Me.GRB_Tema.TabIndex = 131
        Me.GRB_Tema.Text = "Evolución"
        Me.GRB_Tema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_TiempoTotal
        '
        Me.TXT_TiempoTotal.AutoRoundedCorners = True
        Me.TXT_TiempoTotal.BackColor = System.Drawing.Color.Transparent
        Me.TXT_TiempoTotal.BorderColor = System.Drawing.Color.Lime
        Me.TXT_TiempoTotal.BorderRadius = 17
        Me.TXT_TiempoTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_TiempoTotal.DefaultText = ""
        Me.TXT_TiempoTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_TiempoTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_TiempoTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TiempoTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TiempoTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TiempoTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_TiempoTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TiempoTotal.Location = New System.Drawing.Point(288, 143)
        Me.TXT_TiempoTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_TiempoTotal.Name = "TXT_TiempoTotal"
        Me.TXT_TiempoTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_TiempoTotal.PlaceholderText = ""
        Me.TXT_TiempoTotal.ReadOnly = True
        Me.TXT_TiempoTotal.SelectedText = ""
        Me.TXT_TiempoTotal.Size = New System.Drawing.Size(132, 36)
        Me.TXT_TiempoTotal.TabIndex = 136
        '
        'TXT_PtsTotal
        '
        Me.TXT_PtsTotal.AutoRoundedCorners = True
        Me.TXT_PtsTotal.BackColor = System.Drawing.Color.Transparent
        Me.TXT_PtsTotal.BorderColor = System.Drawing.Color.Lime
        Me.TXT_PtsTotal.BorderRadius = 17
        Me.TXT_PtsTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_PtsTotal.DefaultText = ""
        Me.TXT_PtsTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_PtsTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_PtsTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PtsTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PtsTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PtsTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_PtsTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PtsTotal.Location = New System.Drawing.Point(288, 95)
        Me.TXT_PtsTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_PtsTotal.Name = "TXT_PtsTotal"
        Me.TXT_PtsTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_PtsTotal.PlaceholderText = ""
        Me.TXT_PtsTotal.ReadOnly = True
        Me.TXT_PtsTotal.SelectedText = ""
        Me.TXT_PtsTotal.Size = New System.Drawing.Size(132, 36)
        Me.TXT_PtsTotal.TabIndex = 135
        '
        'TXT_CantCat
        '
        Me.TXT_CantCat.AutoRoundedCorners = True
        Me.TXT_CantCat.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CantCat.BorderColor = System.Drawing.Color.Lime
        Me.TXT_CantCat.BorderRadius = 17
        Me.TXT_CantCat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CantCat.DefaultText = ""
        Me.TXT_CantCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CantCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CantCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CantCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CantCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CantCat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CantCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CantCat.Location = New System.Drawing.Point(288, 49)
        Me.TXT_CantCat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CantCat.Name = "TXT_CantCat"
        Me.TXT_CantCat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CantCat.PlaceholderText = ""
        Me.TXT_CantCat.ReadOnly = True
        Me.TXT_CantCat.SelectedText = ""
        Me.TXT_CantCat.Size = New System.Drawing.Size(132, 36)
        Me.TXT_CantCat.TabIndex = 132
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(122, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 23)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Tiempo Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(99, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 23)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Puntos totales:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 23)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Cantidad de categorías:"
        '
        'BTN_ComenzarJuego
        '
        Me.BTN_ComenzarJuego.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ComenzarJuego.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_ComenzarJuego.BorderRadius = 25
        Me.BTN_ComenzarJuego.BorderThickness = 1
        Me.BTN_ComenzarJuego.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_ComenzarJuego.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ComenzarJuego.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ComenzarJuego.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ComenzarJuego.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ComenzarJuego.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_ComenzarJuego.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ComenzarJuego.ForeColor = System.Drawing.Color.White
        Me.BTN_ComenzarJuego.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_aceptar
        Me.BTN_ComenzarJuego.ImageSize = New System.Drawing.Size(45, 45)
        Me.BTN_ComenzarJuego.Location = New System.Drawing.Point(285, 485)
        Me.BTN_ComenzarJuego.Name = "BTN_ComenzarJuego"
        Me.BTN_ComenzarJuego.Size = New System.Drawing.Size(240, 66)
        Me.BTN_ComenzarJuego.TabIndex = 133
        Me.BTN_ComenzarJuego.Text = "Comenzar"
        '
        'BTN_RegresarProfNuevo
        '
        Me.BTN_RegresarProfNuevo.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarProfNuevo.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarProfNuevo.BorderRadius = 25
        Me.BTN_RegresarProfNuevo.BorderThickness = 1
        Me.BTN_RegresarProfNuevo.CustomBorderColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarProfNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarProfNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarProfNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarProfNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarProfNuevo.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarProfNuevo.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarProfNuevo.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarProfNuevo.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarProfNuevo.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarProfNuevo.Location = New System.Drawing.Point(39, 485)
        Me.BTN_RegresarProfNuevo.Name = "BTN_RegresarProfNuevo"
        Me.BTN_RegresarProfNuevo.Size = New System.Drawing.Size(240, 66)
        Me.BTN_RegresarProfNuevo.TabIndex = 132
        Me.BTN_RegresarProfNuevo.Text = "Regresar"
        '
        'BTN_CuentaProf
        '
        Me.BTN_CuentaProf.BackColor = System.Drawing.Color.Transparent
        Me.BTN_CuentaProf.BorderColor = System.Drawing.Color.White
        Me.BTN_CuentaProf.BorderThickness = 1
        Me.BTN_CuentaProf.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CuentaProf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CuentaProf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_CuentaProf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_CuentaProf.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BTN_CuentaProf.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CuentaProf.ForeColor = System.Drawing.Color.White
        Me.BTN_CuentaProf.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Usuario
        Me.BTN_CuentaProf.ImageSize = New System.Drawing.Size(35, 35)
        Me.BTN_CuentaProf.Location = New System.Drawing.Point(501, 130)
        Me.BTN_CuentaProf.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CuentaProf.Name = "BTN_CuentaProf"
        Me.BTN_CuentaProf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CuentaProf.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CuentaProf.TabIndex = 136
        '
        'CerrarAPP
        '
        Me.CerrarAPP.BackColor = System.Drawing.Color.Transparent
        Me.CerrarAPP.BorderColor = System.Drawing.Color.White
        Me.CerrarAPP.BorderThickness = 1
        Me.CerrarAPP.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CerrarAPP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CerrarAPP.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CerrarAPP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CerrarAPP.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CerrarAPP.Font = New System.Drawing.Font("Cooper Black", 20.25!)
        Me.CerrarAPP.ForeColor = System.Drawing.Color.White
        Me.CerrarAPP.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_cerrarAPPBlanco
        Me.CerrarAPP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.CerrarAPP.ImageSize = New System.Drawing.Size(30, 30)
        Me.CerrarAPP.Location = New System.Drawing.Point(501, 21)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 135
        '
        'BTN_CerrarSesion
        '
        Me.BTN_CerrarSesion.BackColor = System.Drawing.Color.Transparent
        Me.BTN_CerrarSesion.BorderColor = System.Drawing.Color.White
        Me.BTN_CerrarSesion.BorderThickness = 1
        Me.BTN_CerrarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CerrarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CerrarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_CerrarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_CerrarSesion.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_CerrarSesion.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CerrarSesion.ForeColor = System.Drawing.Color.White
        Me.BTN_CerrarSesion.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_cerrarSesionBlancoUsado
        Me.BTN_CerrarSesion.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_CerrarSesion.Location = New System.Drawing.Point(501, 76)
        Me.BTN_CerrarSesion.Name = "BTN_CerrarSesion"
        Me.BTN_CerrarSesion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CerrarSesion.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CerrarSesion.TabIndex = 134
        '
        'P_EComenzarJuego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.FondoMorado
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(568, 584)
        Me.Controls.Add(Me.BTN_CuentaProf)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.BTN_CerrarSesion)
        Me.Controls.Add(Me.BTN_ComenzarJuego)
        Me.Controls.Add(Me.BTN_RegresarProfNuevo)
        Me.Controls.Add(Me.GRB_Tema)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBX_Tema)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_EComenzarJuego"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comenzar juego"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRB_Tema.ResumeLayout(False)
        Me.GRB_Tema.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents CBX_Tema As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GRB_Tema As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_TiempoTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_PtsTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_CantCat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_ComenzarJuego As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarProfNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_CuentaProf As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CerrarSesion As Guna.UI2.WinForms.Guna2CircleButton
End Class
