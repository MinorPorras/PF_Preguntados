<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_ECuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_ECuenta))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.CerrarAPP = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.TXT_CClaveEst = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTN_ActCEst = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarProfNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_CNombreEst = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_CCorreoEst = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_CUsuarioEst = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PIC_FotoEst = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_CSeccionEst = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_CCarnetEst = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_CFechaNacimientoEst = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_CPeriodoEst = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_FotoEst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloCentroUsuarioMorado
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(176, -87)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(447, 358)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 80
        Me.Guna2PictureBox1.TabStop = False
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
        Me.CerrarAPP.Location = New System.Drawing.Point(773, 21)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 81
        '
        'TXT_CClaveEst
        '
        Me.TXT_CClaveEst.AutoRoundedCorners = True
        Me.TXT_CClaveEst.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CClaveEst.BorderColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.TXT_CClaveEst.BorderRadius = 17
        Me.TXT_CClaveEst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CClaveEst.DefaultText = ""
        Me.TXT_CClaveEst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CClaveEst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CClaveEst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CClaveEst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CClaveEst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CClaveEst.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CClaveEst.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CClaveEst.Location = New System.Drawing.Point(193, 235)
        Me.TXT_CClaveEst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CClaveEst.Name = "TXT_CClaveEst"
        Me.TXT_CClaveEst.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_CClaveEst.PlaceholderText = ""
        Me.TXT_CClaveEst.ReadOnly = True
        Me.TXT_CClaveEst.SelectedText = ""
        Me.TXT_CClaveEst.Size = New System.Drawing.Size(402, 36)
        Me.TXT_CClaveEst.TabIndex = 106
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(36, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 28)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Contraseña:"
        '
        'BTN_ActCEst
        '
        Me.BTN_ActCEst.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ActCEst.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_ActCEst.BorderRadius = 25
        Me.BTN_ActCEst.BorderThickness = 1
        Me.BTN_ActCEst.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_ActCEst.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ActCEst.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ActCEst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ActCEst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ActCEst.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_ActCEst.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ActCEst.ForeColor = System.Drawing.Color.White
        Me.BTN_ActCEst.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_ActCEst.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_ActCEst.Location = New System.Drawing.Point(425, 495)
        Me.BTN_ActCEst.Name = "BTN_ActCEst"
        Me.BTN_ActCEst.Size = New System.Drawing.Size(298, 66)
        Me.BTN_ActCEst.TabIndex = 104
        Me.BTN_ActCEst.Text = "Actualizar información"
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
        Me.BTN_RegresarProfNuevo.Location = New System.Drawing.Point(92, 495)
        Me.BTN_RegresarProfNuevo.Name = "BTN_RegresarProfNuevo"
        Me.BTN_RegresarProfNuevo.Size = New System.Drawing.Size(298, 66)
        Me.BTN_RegresarProfNuevo.TabIndex = 103
        Me.BTN_RegresarProfNuevo.Text = "Regresar"
        '
        'TXT_CNombreEst
        '
        Me.TXT_CNombreEst.AutoRoundedCorners = True
        Me.TXT_CNombreEst.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CNombreEst.BorderColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.TXT_CNombreEst.BorderRadius = 17
        Me.TXT_CNombreEst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CNombreEst.DefaultText = ""
        Me.TXT_CNombreEst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CNombreEst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CNombreEst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CNombreEst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CNombreEst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CNombreEst.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CNombreEst.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CNombreEst.Location = New System.Drawing.Point(193, 337)
        Me.TXT_CNombreEst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CNombreEst.Name = "TXT_CNombreEst"
        Me.TXT_CNombreEst.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CNombreEst.PlaceholderText = ""
        Me.TXT_CNombreEst.ReadOnly = True
        Me.TXT_CNombreEst.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TXT_CNombreEst.SelectedText = ""
        Me.TXT_CNombreEst.Size = New System.Drawing.Size(461, 36)
        Me.TXT_CNombreEst.TabIndex = 102
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(77, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 28)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Nombre:"
        '
        'TXT_CCorreoEst
        '
        Me.TXT_CCorreoEst.AutoRoundedCorners = True
        Me.TXT_CCorreoEst.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CCorreoEst.BorderColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.TXT_CCorreoEst.BorderRadius = 17
        Me.TXT_CCorreoEst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CCorreoEst.DefaultText = ""
        Me.TXT_CCorreoEst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CCorreoEst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CCorreoEst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCorreoEst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCorreoEst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCorreoEst.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CCorreoEst.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCorreoEst.Location = New System.Drawing.Point(193, 286)
        Me.TXT_CCorreoEst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CCorreoEst.Name = "TXT_CCorreoEst"
        Me.TXT_CCorreoEst.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CCorreoEst.PlaceholderText = ""
        Me.TXT_CCorreoEst.ReadOnly = True
        Me.TXT_CCorreoEst.SelectedText = ""
        Me.TXT_CCorreoEst.Size = New System.Drawing.Size(420, 36)
        Me.TXT_CCorreoEst.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(81, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 28)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Correo:"
        '
        'TXT_CUsuarioEst
        '
        Me.TXT_CUsuarioEst.AutoRoundedCorners = True
        Me.TXT_CUsuarioEst.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CUsuarioEst.BorderColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.TXT_CUsuarioEst.BorderRadius = 17
        Me.TXT_CUsuarioEst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CUsuarioEst.DefaultText = ""
        Me.TXT_CUsuarioEst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CUsuarioEst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CUsuarioEst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CUsuarioEst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CUsuarioEst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CUsuarioEst.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CUsuarioEst.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CUsuarioEst.Location = New System.Drawing.Point(193, 184)
        Me.TXT_CUsuarioEst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CUsuarioEst.Name = "TXT_CUsuarioEst"
        Me.TXT_CUsuarioEst.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CUsuarioEst.PlaceholderText = ""
        Me.TXT_CUsuarioEst.ReadOnly = True
        Me.TXT_CUsuarioEst.SelectedText = ""
        Me.TXT_CUsuarioEst.Size = New System.Drawing.Size(420, 36)
        Me.TXT_CUsuarioEst.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(74, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 28)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Usuario:"
        '
        'PIC_FotoEst
        '
        Me.PIC_FotoEst.BackColor = System.Drawing.Color.Transparent
        Me.PIC_FotoEst.FillColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.PIC_FotoEst.ImageRotate = 0!
        Me.PIC_FotoEst.Location = New System.Drawing.Point(619, 150)
        Me.PIC_FotoEst.Name = "PIC_FotoEst"
        Me.PIC_FotoEst.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PIC_FotoEst.Size = New System.Drawing.Size(204, 202)
        Me.PIC_FotoEst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PIC_FotoEst.TabIndex = 96
        Me.PIC_FotoEst.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(489, 433)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 28)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Sección:"
        '
        'TXT_CSeccionEst
        '
        Me.TXT_CSeccionEst.AutoRoundedCorners = True
        Me.TXT_CSeccionEst.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CSeccionEst.BorderColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.TXT_CSeccionEst.BorderRadius = 17
        Me.TXT_CSeccionEst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CSeccionEst.DefaultText = ""
        Me.TXT_CSeccionEst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CSeccionEst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CSeccionEst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CSeccionEst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CSeccionEst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CSeccionEst.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CSeccionEst.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CSeccionEst.Location = New System.Drawing.Point(596, 429)
        Me.TXT_CSeccionEst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CSeccionEst.Name = "TXT_CSeccionEst"
        Me.TXT_CSeccionEst.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CSeccionEst.PlaceholderText = ""
        Me.TXT_CSeccionEst.ReadOnly = True
        Me.TXT_CSeccionEst.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TXT_CSeccionEst.SelectedText = ""
        Me.TXT_CSeccionEst.Size = New System.Drawing.Size(203, 36)
        Me.TXT_CSeccionEst.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(87, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 28)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Carnet:"
        '
        'TXT_CCarnetEst
        '
        Me.TXT_CCarnetEst.AutoRoundedCorners = True
        Me.TXT_CCarnetEst.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CCarnetEst.BorderColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.TXT_CCarnetEst.BorderRadius = 17
        Me.TXT_CCarnetEst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CCarnetEst.DefaultText = ""
        Me.TXT_CCarnetEst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CCarnetEst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CCarnetEst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCarnetEst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCarnetEst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCarnetEst.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CCarnetEst.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCarnetEst.Location = New System.Drawing.Point(193, 385)
        Me.TXT_CCarnetEst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CCarnetEst.Name = "TXT_CCarnetEst"
        Me.TXT_CCarnetEst.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CCarnetEst.PlaceholderText = ""
        Me.TXT_CCarnetEst.ReadOnly = True
        Me.TXT_CCarnetEst.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TXT_CCarnetEst.SelectedText = ""
        Me.TXT_CCarnetEst.Size = New System.Drawing.Size(203, 36)
        Me.TXT_CCarnetEst.TabIndex = 110
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(62, 432)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(254, 28)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "Fecha de nacimiento:"
        '
        'TXT_CFechaNacimientoEst
        '
        Me.TXT_CFechaNacimientoEst.AutoRoundedCorners = True
        Me.TXT_CFechaNacimientoEst.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CFechaNacimientoEst.BorderColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.TXT_CFechaNacimientoEst.BorderRadius = 17
        Me.TXT_CFechaNacimientoEst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CFechaNacimientoEst.DefaultText = ""
        Me.TXT_CFechaNacimientoEst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CFechaNacimientoEst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CFechaNacimientoEst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CFechaNacimientoEst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CFechaNacimientoEst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CFechaNacimientoEst.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CFechaNacimientoEst.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CFechaNacimientoEst.Location = New System.Drawing.Point(314, 429)
        Me.TXT_CFechaNacimientoEst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CFechaNacimientoEst.Name = "TXT_CFechaNacimientoEst"
        Me.TXT_CFechaNacimientoEst.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CFechaNacimientoEst.PlaceholderText = ""
        Me.TXT_CFechaNacimientoEst.ReadOnly = True
        Me.TXT_CFechaNacimientoEst.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TXT_CFechaNacimientoEst.SelectedText = ""
        Me.TXT_CFechaNacimientoEst.Size = New System.Drawing.Size(172, 36)
        Me.TXT_CFechaNacimientoEst.TabIndex = 113
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(404, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 28)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Periodo:"
        '
        'TXT_CPeriodoEst
        '
        Me.TXT_CPeriodoEst.AutoRoundedCorners = True
        Me.TXT_CPeriodoEst.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CPeriodoEst.BorderColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.TXT_CPeriodoEst.BorderRadius = 17
        Me.TXT_CPeriodoEst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CPeriodoEst.DefaultText = ""
        Me.TXT_CPeriodoEst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CPeriodoEst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CPeriodoEst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CPeriodoEst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CPeriodoEst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CPeriodoEst.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CPeriodoEst.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CPeriodoEst.Location = New System.Drawing.Point(519, 385)
        Me.TXT_CPeriodoEst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_CPeriodoEst.Name = "TXT_CPeriodoEst"
        Me.TXT_CPeriodoEst.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CPeriodoEst.PlaceholderText = ""
        Me.TXT_CPeriodoEst.ReadOnly = True
        Me.TXT_CPeriodoEst.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TXT_CPeriodoEst.SelectedText = ""
        Me.TXT_CPeriodoEst.Size = New System.Drawing.Size(239, 36)
        Me.TXT_CPeriodoEst.TabIndex = 115
        '
        'P_ECuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.FondoBlancoMorado
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(858, 612)
        Me.Controls.Add(Me.TXT_CPeriodoEst)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXT_CFechaNacimientoEst)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXT_CCarnetEst)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_CSeccionEst)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_CClaveEst)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BTN_ActCEst)
        Me.Controls.Add(Me.BTN_RegresarProfNuevo)
        Me.Controls.Add(Me.TXT_CNombreEst)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_CCorreoEst)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_CUsuarioEst)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PIC_FotoEst)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_ECuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centro de usuario"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_FotoEst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents TXT_CClaveEst As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BTN_ActCEst As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarProfNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_CNombreEst As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_CCorreoEst As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_CUsuarioEst As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PIC_FotoEst As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_CSeccionEst As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_CCarnetEst As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_CFechaNacimientoEst As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXT_CPeriodoEst As Guna.UI2.WinForms.Guna2TextBox
End Class
