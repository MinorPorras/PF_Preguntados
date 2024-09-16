<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_EJuegoResultados
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_EJuegoResultados))
        Me.BTN_CuentaProf = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.CerrarAPP = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CerrarSesion = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.L_TituloTema = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_CantCat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_CantPreg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_PtsObtenidos = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_TiempoJuego = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_ContinuarResultados = New Guna.UI2.WinForms.Guna2Button()
        Me.TimerJuegoTotal = New System.Windows.Forms.Timer(Me.components)
        Me.TXT_Nota = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_Tema_Juego = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BTN_CuentaProf.Location = New System.Drawing.Point(613, 127)
        Me.BTN_CuentaProf.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CuentaProf.Name = "BTN_CuentaProf"
        Me.BTN_CuentaProf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CuentaProf.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CuentaProf.TabIndex = 139
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
        Me.CerrarAPP.Location = New System.Drawing.Point(613, 18)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 138
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
        Me.BTN_CerrarSesion.Location = New System.Drawing.Point(613, 73)
        Me.BTN_CerrarSesion.Name = "BTN_CerrarSesion"
        Me.BTN_CerrarSesion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CerrarSesion.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CerrarSesion.TabIndex = 137
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloResultados
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(144, -73)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(431, 325)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 140
        Me.Guna2PictureBox1.TabStop = False
        '
        'L_TituloTema
        '
        Me.L_TituloTema.AutoSize = True
        Me.L_TituloTema.BackColor = System.Drawing.Color.Transparent
        Me.L_TituloTema.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_TituloTema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.L_TituloTema.Location = New System.Drawing.Point(84, 189)
        Me.L_TituloTema.Name = "L_TituloTema"
        Me.L_TituloTema.Size = New System.Drawing.Size(71, 23)
        Me.L_TituloTema.TabIndex = 141
        Me.L_TituloTema.Text = "Tema: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(125, 342)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 23)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Puntos Obtenidos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(68, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 23)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Cantidad de categorías:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(74, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 23)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Cantidad de preguntas:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(146, 430)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 23)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Tiempo de juego:"
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
        Me.TXT_CantCat.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CantCat.ForeColor = System.Drawing.Color.Black
        Me.TXT_CantCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CantCat.Location = New System.Drawing.Point(334, 247)
        Me.TXT_CantCat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CantCat.Name = "TXT_CantCat"
        Me.TXT_CantCat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CantCat.PlaceholderText = ""
        Me.TXT_CantCat.ReadOnly = True
        Me.TXT_CantCat.SelectedText = ""
        Me.TXT_CantCat.Size = New System.Drawing.Size(206, 36)
        Me.TXT_CantCat.TabIndex = 146
        '
        'TXT_CantPreg
        '
        Me.TXT_CantPreg.AutoRoundedCorners = True
        Me.TXT_CantPreg.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CantPreg.BorderColor = System.Drawing.Color.Lime
        Me.TXT_CantPreg.BorderRadius = 17
        Me.TXT_CantPreg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CantPreg.DefaultText = ""
        Me.TXT_CantPreg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CantPreg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CantPreg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CantPreg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CantPreg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CantPreg.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CantPreg.ForeColor = System.Drawing.Color.Black
        Me.TXT_CantPreg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CantPreg.Location = New System.Drawing.Point(334, 291)
        Me.TXT_CantPreg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CantPreg.Name = "TXT_CantPreg"
        Me.TXT_CantPreg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CantPreg.PlaceholderText = ""
        Me.TXT_CantPreg.ReadOnly = True
        Me.TXT_CantPreg.SelectedText = ""
        Me.TXT_CantPreg.Size = New System.Drawing.Size(206, 36)
        Me.TXT_CantPreg.TabIndex = 147
        '
        'TXT_PtsObtenidos
        '
        Me.TXT_PtsObtenidos.AutoRoundedCorners = True
        Me.TXT_PtsObtenidos.BackColor = System.Drawing.Color.Transparent
        Me.TXT_PtsObtenidos.BorderColor = System.Drawing.Color.Lime
        Me.TXT_PtsObtenidos.BorderRadius = 17
        Me.TXT_PtsObtenidos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_PtsObtenidos.DefaultText = ""
        Me.TXT_PtsObtenidos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_PtsObtenidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_PtsObtenidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PtsObtenidos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PtsObtenidos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PtsObtenidos.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PtsObtenidos.ForeColor = System.Drawing.Color.Black
        Me.TXT_PtsObtenidos.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PtsObtenidos.Location = New System.Drawing.Point(334, 334)
        Me.TXT_PtsObtenidos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_PtsObtenidos.Name = "TXT_PtsObtenidos"
        Me.TXT_PtsObtenidos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_PtsObtenidos.PlaceholderText = ""
        Me.TXT_PtsObtenidos.ReadOnly = True
        Me.TXT_PtsObtenidos.SelectedText = ""
        Me.TXT_PtsObtenidos.Size = New System.Drawing.Size(206, 36)
        Me.TXT_PtsObtenidos.TabIndex = 148
        '
        'TXT_TiempoJuego
        '
        Me.TXT_TiempoJuego.AutoRoundedCorners = True
        Me.TXT_TiempoJuego.BackColor = System.Drawing.Color.Transparent
        Me.TXT_TiempoJuego.BorderColor = System.Drawing.Color.Lime
        Me.TXT_TiempoJuego.BorderRadius = 17
        Me.TXT_TiempoJuego.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_TiempoJuego.DefaultText = ""
        Me.TXT_TiempoJuego.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_TiempoJuego.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_TiempoJuego.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TiempoJuego.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TiempoJuego.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TiempoJuego.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TiempoJuego.ForeColor = System.Drawing.Color.Black
        Me.TXT_TiempoJuego.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TiempoJuego.Location = New System.Drawing.Point(334, 423)
        Me.TXT_TiempoJuego.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_TiempoJuego.Name = "TXT_TiempoJuego"
        Me.TXT_TiempoJuego.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_TiempoJuego.PlaceholderText = ""
        Me.TXT_TiempoJuego.ReadOnly = True
        Me.TXT_TiempoJuego.SelectedText = ""
        Me.TXT_TiempoJuego.Size = New System.Drawing.Size(206, 36)
        Me.TXT_TiempoJuego.TabIndex = 149
        '
        'BTN_ContinuarResultados
        '
        Me.BTN_ContinuarResultados.AutoRoundedCorners = True
        Me.BTN_ContinuarResultados.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ContinuarResultados.BorderColor = System.Drawing.Color.White
        Me.BTN_ContinuarResultados.BorderRadius = 32
        Me.BTN_ContinuarResultados.BorderThickness = 1
        Me.BTN_ContinuarResultados.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_ContinuarResultados.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ContinuarResultados.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ContinuarResultados.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ContinuarResultados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ContinuarResultados.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_ContinuarResultados.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ContinuarResultados.ForeColor = System.Drawing.Color.White
        Me.BTN_ContinuarResultados.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_iniciarSesionBlanco
        Me.BTN_ContinuarResultados.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BTN_ContinuarResultados.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_ContinuarResultados.Location = New System.Drawing.Point(205, 478)
        Me.BTN_ContinuarResultados.Name = "BTN_ContinuarResultados"
        Me.BTN_ContinuarResultados.Size = New System.Drawing.Size(302, 67)
        Me.BTN_ContinuarResultados.TabIndex = 150
        Me.BTN_ContinuarResultados.Text = "Continuar y guardar"
        Me.BTN_ContinuarResultados.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TimerJuegoTotal
        '
        Me.TimerJuegoTotal.Interval = 1000
        '
        'TXT_Nota
        '
        Me.TXT_Nota.AutoRoundedCorners = True
        Me.TXT_Nota.BackColor = System.Drawing.Color.Transparent
        Me.TXT_Nota.BorderColor = System.Drawing.Color.Lime
        Me.TXT_Nota.BorderRadius = 17
        Me.TXT_Nota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Nota.DefaultText = ""
        Me.TXT_Nota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Nota.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Nota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Nota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Nota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Nota.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Nota.ForeColor = System.Drawing.Color.Black
        Me.TXT_Nota.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Nota.Location = New System.Drawing.Point(334, 378)
        Me.TXT_Nota.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_Nota.Name = "TXT_Nota"
        Me.TXT_Nota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Nota.PlaceholderText = ""
        Me.TXT_Nota.ReadOnly = True
        Me.TXT_Nota.SelectedText = ""
        Me.TXT_Nota.Size = New System.Drawing.Size(206, 36)
        Me.TXT_Nota.TabIndex = 152
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(261, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 23)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Nota:"
        '
        'TXT_Tema_Juego
        '
        Me.TXT_Tema_Juego.AutoRoundedCorners = True
        Me.TXT_Tema_Juego.BackColor = System.Drawing.Color.Transparent
        Me.TXT_Tema_Juego.BorderColor = System.Drawing.Color.Lime
        Me.TXT_Tema_Juego.BorderRadius = 17
        Me.TXT_Tema_Juego.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Tema_Juego.DefaultText = ""
        Me.TXT_Tema_Juego.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Tema_Juego.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Tema_Juego.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Tema_Juego.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Tema_Juego.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Tema_Juego.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Tema_Juego.ForeColor = System.Drawing.Color.Black
        Me.TXT_Tema_Juego.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Tema_Juego.Location = New System.Drawing.Point(150, 184)
        Me.TXT_Tema_Juego.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_Tema_Juego.Name = "TXT_Tema_Juego"
        Me.TXT_Tema_Juego.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Tema_Juego.PlaceholderText = ""
        Me.TXT_Tema_Juego.ReadOnly = True
        Me.TXT_Tema_Juego.SelectedText = ""
        Me.TXT_Tema_Juego.Size = New System.Drawing.Size(450, 36)
        Me.TXT_Tema_Juego.TabIndex = 153
        '
        'P_EJuegoResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.FondoBlancoMorado
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(691, 586)
        Me.Controls.Add(Me.TXT_Tema_Juego)
        Me.Controls.Add(Me.TXT_Nota)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTN_ContinuarResultados)
        Me.Controls.Add(Me.TXT_TiempoJuego)
        Me.Controls.Add(Me.TXT_PtsObtenidos)
        Me.Controls.Add(Me.TXT_CantPreg)
        Me.Controls.Add(Me.TXT_CantCat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.L_TituloTema)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.BTN_CuentaProf)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.BTN_CerrarSesion)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_EJuegoResultados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resultados del juego"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_CuentaProf As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CerrarSesion As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents L_TituloTema As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_CantCat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_CantPreg As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_PtsObtenidos As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_TiempoJuego As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_ContinuarResultados As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TimerJuegoTotal As Timer
    Friend WithEvents TXT_Nota As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_Tema_Juego As Guna.UI2.WinForms.Guna2TextBox
End Class
