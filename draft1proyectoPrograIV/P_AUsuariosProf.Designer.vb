<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_AUsuariosProf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_AUsuariosProf))
        Me.BTN_RegresarUsuarioProf = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_AgregarProf = New Guna.UI2.WinForms.Guna2Button()
        Me.LSV_Profesores = New System.Windows.Forms.ListView()
        Me.IDProf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellido1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellido2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UsuarioProf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClaveProf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImagenProf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CorreoProf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FRegistroProf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_MODIFICAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TXT_BuscarProfesor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CerrarAPP = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CerrarSesion = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CuentaProf = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.MNU_CONTX.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_RegresarUsuarioProf
        '
        Me.BTN_RegresarUsuarioProf.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarUsuarioProf.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarUsuarioProf.BorderRadius = 25
        Me.BTN_RegresarUsuarioProf.BorderThickness = 1
        Me.BTN_RegresarUsuarioProf.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_RegresarUsuarioProf.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarUsuarioProf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarUsuarioProf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarUsuarioProf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarUsuarioProf.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarUsuarioProf.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarUsuarioProf.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarUsuarioProf.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarUsuarioProf.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarUsuarioProf.Location = New System.Drawing.Point(151, 617)
        Me.BTN_RegresarUsuarioProf.Name = "BTN_RegresarUsuarioProf"
        Me.BTN_RegresarUsuarioProf.Size = New System.Drawing.Size(253, 66)
        Me.BTN_RegresarUsuarioProf.TabIndex = 10
        Me.BTN_RegresarUsuarioProf.Text = "Regresar"
        '
        'BTN_AgregarProf
        '
        Me.BTN_AgregarProf.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AgregarProf.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_AgregarProf.BorderRadius = 25
        Me.BTN_AgregarProf.BorderThickness = 1
        Me.BTN_AgregarProf.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_AgregarProf.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarProf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarProf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AgregarProf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AgregarProf.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_AgregarProf.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AgregarProf.ForeColor = System.Drawing.Color.White
        Me.BTN_AgregarProf.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_AgregarProf.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_AgregarProf.Location = New System.Drawing.Point(433, 617)
        Me.BTN_AgregarProf.Name = "BTN_AgregarProf"
        Me.BTN_AgregarProf.Size = New System.Drawing.Size(253, 66)
        Me.BTN_AgregarProf.TabIndex = 9
        Me.BTN_AgregarProf.Text = "Agregar Profesor"
        '
        'LSV_Profesores
        '
        Me.LSV_Profesores.BackColor = System.Drawing.Color.White
        Me.LSV_Profesores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSV_Profesores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IDProf, Me.Nombre, Me.Apellido1, Me.Apellido2, Me.UsuarioProf, Me.ClaveProf, Me.ImagenProf, Me.CorreoProf, Me.FRegistroProf})
        Me.LSV_Profesores.ContextMenuStrip = Me.MNU_CONTX
        Me.LSV_Profesores.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LSV_Profesores.ForeColor = System.Drawing.Color.Black
        Me.LSV_Profesores.FullRowSelect = True
        Me.LSV_Profesores.GridLines = True
        Me.LSV_Profesores.HideSelection = False
        Me.LSV_Profesores.Location = New System.Drawing.Point(51, 289)
        Me.LSV_Profesores.MultiSelect = False
        Me.LSV_Profesores.Name = "LSV_Profesores"
        Me.LSV_Profesores.Size = New System.Drawing.Size(735, 312)
        Me.LSV_Profesores.TabIndex = 8
        Me.LSV_Profesores.UseCompatibleStateImageBehavior = False
        Me.LSV_Profesores.View = System.Windows.Forms.View.Details
        '
        'IDProf
        '
        Me.IDProf.Text = "ID"
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        '
        'Apellido1
        '
        Me.Apellido1.Text = "Apellido1"
        '
        'Apellido2
        '
        Me.Apellido2.Text = "Apellido2"
        '
        'UsuarioProf
        '
        Me.UsuarioProf.Text = "Usuario"
        Me.UsuarioProf.Width = 100
        '
        'ClaveProf
        '
        Me.ClaveProf.Text = "Clave"
        Me.ClaveProf.Width = 103
        '
        'ImagenProf
        '
        Me.ImagenProf.Text = "Imagen"
        '
        'CorreoProf
        '
        Me.CorreoProf.Text = "Correo"
        Me.CorreoProf.Width = 94
        '
        'FRegistroProf
        '
        Me.FRegistroProf.Text = "Fecha de Registro"
        Me.FRegistroProf.Width = 116
        '
        'MNU_CONTX
        '
        Me.MNU_CONTX.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MNU_CONTX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNU_MODIFICAR, Me.MNU_ELIMINAR})
        Me.MNU_CONTX.Name = "MNU_CONTX"
        Me.MNU_CONTX.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MNU_CONTX.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.MNU_CONTX.RenderStyle.ColorTable = Nothing
        Me.MNU_CONTX.RenderStyle.RoundedEdges = True
        Me.MNU_CONTX.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.MNU_CONTX.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MNU_CONTX.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.MNU_CONTX.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.MNU_CONTX.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.MNU_CONTX.Size = New System.Drawing.Size(130, 56)
        '
        'MNU_MODIFICAR
        '
        Me.MNU_MODIFICAR.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_modificarAzul
        Me.MNU_MODIFICAR.Name = "MNU_MODIFICAR"
        Me.MNU_MODIFICAR.Size = New System.Drawing.Size(129, 26)
        Me.MNU_MODIFICAR.Text = "Modificar"
        Me.MNU_MODIFICAR.Visible = False
        '
        'MNU_ELIMINAR
        '
        Me.MNU_ELIMINAR.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_eliminarRojo
        Me.MNU_ELIMINAR.Name = "MNU_ELIMINAR"
        Me.MNU_ELIMINAR.Size = New System.Drawing.Size(129, 26)
        Me.MNU_ELIMINAR.Text = "Eliminar"
        Me.MNU_ELIMINAR.Visible = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloProfesores
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(206, -66)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(411, 374)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 11
        Me.Guna2PictureBox1.TabStop = False
        '
        'TXT_BuscarProfesor
        '
        Me.TXT_BuscarProfesor.AutoRoundedCorners = True
        Me.TXT_BuscarProfesor.BackColor = System.Drawing.Color.Transparent
        Me.TXT_BuscarProfesor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_BuscarProfesor.BorderRadius = 17
        Me.TXT_BuscarProfesor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarProfesor.DefaultText = ""
        Me.TXT_BuscarProfesor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarProfesor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarProfesor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarProfesor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarProfesor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarProfesor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarProfesor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarProfesor.IconRight = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_BuscarNaranja
        Me.TXT_BuscarProfesor.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.TXT_BuscarProfesor.Location = New System.Drawing.Point(51, 236)
        Me.TXT_BuscarProfesor.Margin = New System.Windows.Forms.Padding(6)
        Me.TXT_BuscarProfesor.Name = "TXT_BuscarProfesor"
        Me.TXT_BuscarProfesor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarProfesor.PlaceholderText = "Buscar Profesor"
        Me.TXT_BuscarProfesor.SelectedText = ""
        Me.TXT_BuscarProfesor.Size = New System.Drawing.Size(735, 36)
        Me.TXT_BuscarProfesor.TabIndex = 62
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
        Me.CerrarAPP.Location = New System.Drawing.Point(751, 31)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 64
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
        Me.BTN_CerrarSesion.Location = New System.Drawing.Point(751, 88)
        Me.BTN_CerrarSesion.Name = "BTN_CerrarSesion"
        Me.BTN_CerrarSesion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CerrarSesion.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CerrarSesion.TabIndex = 63
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
        Me.BTN_CuentaProf.Location = New System.Drawing.Point(751, 145)
        Me.BTN_CuentaProf.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CuentaProf.Name = "BTN_CuentaProf"
        Me.BTN_CuentaProf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CuentaProf.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CuentaProf.TabIndex = 65
        '
        'P_AUsuariosProf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.Fondo_BlancoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(830, 723)
        Me.Controls.Add(Me.BTN_CuentaProf)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.BTN_CerrarSesion)
        Me.Controls.Add(Me.TXT_BuscarProfesor)
        Me.Controls.Add(Me.BTN_RegresarUsuarioProf)
        Me.Controls.Add(Me.BTN_AgregarProf)
        Me.Controls.Add(Me.LSV_Profesores)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_AUsuariosProf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profesores"
        Me.MNU_CONTX.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_RegresarUsuarioProf As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_AgregarProf As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LSV_Profesores As ListView
    Friend WithEvents IDProf As ColumnHeader
    Friend WithEvents UsuarioProf As ColumnHeader
    Friend WithEvents ClaveProf As ColumnHeader
    Friend WithEvents CorreoProf As ColumnHeader
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents FRegistroProf As ColumnHeader
    Friend WithEvents TXT_BuscarProfesor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ImagenProf As ColumnHeader
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_MODIFICAR As ToolStripMenuItem
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CerrarSesion As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents Apellido1 As ColumnHeader
    Friend WithEvents Apellido2 As ColumnHeader
    Friend WithEvents BTN_CuentaProf As Guna.UI2.WinForms.Guna2CircleButton
End Class
