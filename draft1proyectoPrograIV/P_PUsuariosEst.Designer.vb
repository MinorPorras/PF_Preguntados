<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_PUsuariosEst
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_PUsuariosEst))
        Me.BTN_RegresarUsuarioEst = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_AgregarEst = New Guna.UI2.WinForms.Guna2Button()
        Me.LSV_Estudiantes = New System.Windows.Forms.ListView()
        Me.IDEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CarnetEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellido1Est = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellido2Est = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombreEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UsuarioEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClaveEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CorreoEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idSeccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NomSeccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ID_Periodo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NomPeriodo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImgEstudiante = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaRegistro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaNacimiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_MODIFICAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TXT_BuscarEst = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CerrarAPP = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CerrarSesion = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CuentaProf = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.MNU_CONTX.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_RegresarUsuarioEst
        '
        Me.BTN_RegresarUsuarioEst.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarUsuarioEst.BorderColor = System.Drawing.Color.White
        Me.BTN_RegresarUsuarioEst.BorderRadius = 25
        Me.BTN_RegresarUsuarioEst.BorderThickness = 1
        Me.BTN_RegresarUsuarioEst.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_RegresarUsuarioEst.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarUsuarioEst.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarUsuarioEst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarUsuarioEst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarUsuarioEst.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarUsuarioEst.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarUsuarioEst.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarUsuarioEst.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarUsuarioEst.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarUsuarioEst.Location = New System.Drawing.Point(134, 575)
        Me.BTN_RegresarUsuarioEst.Name = "BTN_RegresarUsuarioEst"
        Me.BTN_RegresarUsuarioEst.Size = New System.Drawing.Size(256, 66)
        Me.BTN_RegresarUsuarioEst.TabIndex = 6
        Me.BTN_RegresarUsuarioEst.Text = "Regresar"
        '
        'BTN_AgregarEst
        '
        Me.BTN_AgregarEst.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AgregarEst.BorderColor = System.Drawing.Color.White
        Me.BTN_AgregarEst.BorderRadius = 25
        Me.BTN_AgregarEst.BorderThickness = 1
        Me.BTN_AgregarEst.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_AgregarEst.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarEst.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarEst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AgregarEst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AgregarEst.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_AgregarEst.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AgregarEst.ForeColor = System.Drawing.Color.White
        Me.BTN_AgregarEst.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_AgregarEst.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_AgregarEst.Location = New System.Drawing.Point(485, 575)
        Me.BTN_AgregarEst.Name = "BTN_AgregarEst"
        Me.BTN_AgregarEst.Size = New System.Drawing.Size(256, 66)
        Me.BTN_AgregarEst.TabIndex = 5
        Me.BTN_AgregarEst.Text = "Agregar estudiante"
        '
        'LSV_Estudiantes
        '
        Me.LSV_Estudiantes.BackColor = System.Drawing.Color.White
        Me.LSV_Estudiantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSV_Estudiantes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IDEst, Me.CarnetEst, Me.Apellido1Est, Me.Apellido2Est, Me.NombreEst, Me.UsuarioEst, Me.ClaveEst, Me.CorreoEst, Me.idSeccion, Me.NomSeccion, Me.ID_Periodo, Me.NomPeriodo, Me.ImgEstudiante, Me.FechaRegistro, Me.FechaNacimiento})
        Me.LSV_Estudiantes.ContextMenuStrip = Me.MNU_CONTX
        Me.LSV_Estudiantes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSV_Estudiantes.ForeColor = System.Drawing.Color.Black
        Me.LSV_Estudiantes.FullRowSelect = True
        Me.LSV_Estudiantes.GridLines = True
        Me.LSV_Estudiantes.HideSelection = False
        Me.LSV_Estudiantes.Location = New System.Drawing.Point(45, 251)
        Me.LSV_Estudiantes.MultiSelect = False
        Me.LSV_Estudiantes.Name = "LSV_Estudiantes"
        Me.LSV_Estudiantes.Size = New System.Drawing.Size(735, 306)
        Me.LSV_Estudiantes.TabIndex = 4
        Me.LSV_Estudiantes.UseCompatibleStateImageBehavior = False
        Me.LSV_Estudiantes.View = System.Windows.Forms.View.Details
        '
        'IDEst
        '
        Me.IDEst.Text = "ID"
        '
        'CarnetEst
        '
        Me.CarnetEst.Text = "Carnet"
        Me.CarnetEst.Width = 91
        '
        'Apellido1Est
        '
        Me.Apellido1Est.Text = "Apellido 1"
        Me.Apellido1Est.Width = 83
        '
        'Apellido2Est
        '
        Me.Apellido2Est.Text = "Apellido 2"
        Me.Apellido2Est.Width = 96
        '
        'NombreEst
        '
        Me.NombreEst.Text = "Nombre"
        Me.NombreEst.Width = 96
        '
        'UsuarioEst
        '
        Me.UsuarioEst.Text = "Usuario"
        Me.UsuarioEst.Width = 100
        '
        'ClaveEst
        '
        Me.ClaveEst.Text = "Clave"
        Me.ClaveEst.Width = 103
        '
        'CorreoEst
        '
        Me.CorreoEst.Text = "Correo"
        Me.CorreoEst.Width = 94
        '
        'idSeccion
        '
        Me.idSeccion.Text = "idSeccion"
        Me.idSeccion.Width = 72
        '
        'NomSeccion
        '
        Me.NomSeccion.Text = "Seccion"
        '
        'ID_Periodo
        '
        Me.ID_Periodo.Text = "ID_Periodo"
        '
        'NomPeriodo
        '
        Me.NomPeriodo.Text = "Periodo"
        '
        'ImgEstudiante
        '
        Me.ImgEstudiante.Text = "Imagen"
        '
        'FechaRegistro
        '
        Me.FechaRegistro.Text = "Fecha de registro"
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.Text = "Fecha de Nacimiento"
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
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(221, -73)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(411, 374)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 7
        Me.Guna2PictureBox1.TabStop = False
        '
        'TXT_BuscarEst
        '
        Me.TXT_BuscarEst.AutoRoundedCorners = True
        Me.TXT_BuscarEst.BackColor = System.Drawing.Color.Transparent
        Me.TXT_BuscarEst.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_BuscarEst.BorderRadius = 17
        Me.TXT_BuscarEst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarEst.DefaultText = ""
        Me.TXT_BuscarEst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarEst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarEst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarEst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarEst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarEst.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarEst.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarEst.IconRight = CType(resources.GetObject("TXT_BuscarEst.IconRight"), System.Drawing.Image)
        Me.TXT_BuscarEst.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.TXT_BuscarEst.Location = New System.Drawing.Point(45, 209)
        Me.TXT_BuscarEst.Margin = New System.Windows.Forms.Padding(6)
        Me.TXT_BuscarEst.Name = "TXT_BuscarEst"
        Me.TXT_BuscarEst.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarEst.PlaceholderText = "Buscar Estudiante por nombre"
        Me.TXT_BuscarEst.SelectedText = ""
        Me.TXT_BuscarEst.Size = New System.Drawing.Size(735, 36)
        Me.TXT_BuscarEst.TabIndex = 63
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
        Me.CerrarAPP.Location = New System.Drawing.Point(768, 24)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 65
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
        Me.BTN_CerrarSesion.Location = New System.Drawing.Point(768, 81)
        Me.BTN_CerrarSesion.Name = "BTN_CerrarSesion"
        Me.BTN_CerrarSesion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CerrarSesion.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CerrarSesion.TabIndex = 64
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
        Me.BTN_CuentaProf.Location = New System.Drawing.Point(768, 135)
        Me.BTN_CuentaProf.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CuentaProf.Name = "BTN_CuentaProf"
        Me.BTN_CuentaProf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CuentaProf.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CuentaProf.TabIndex = 66
        '
        'P_PUsuariosEst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.Fondo_BlancoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(842, 673)
        Me.Controls.Add(Me.BTN_CuentaProf)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.BTN_CerrarSesion)
        Me.Controls.Add(Me.TXT_BuscarEst)
        Me.Controls.Add(Me.BTN_RegresarUsuarioEst)
        Me.Controls.Add(Me.BTN_AgregarEst)
        Me.Controls.Add(Me.LSV_Estudiantes)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_PUsuariosEst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estudiantes"
        Me.MNU_CONTX.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_RegresarUsuarioEst As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_AgregarEst As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LSV_Estudiantes As ListView
    Friend WithEvents CarnetEst As ColumnHeader
    Friend WithEvents Apellido1Est As ColumnHeader
    Friend WithEvents Apellido2Est As ColumnHeader
    Friend WithEvents NombreEst As ColumnHeader
    Friend WithEvents UsuarioEst As ColumnHeader
    Friend WithEvents ClaveEst As ColumnHeader
    Friend WithEvents CorreoEst As ColumnHeader
    Friend WithEvents idSeccion As ColumnHeader
    Friend WithEvents IDEst As ColumnHeader
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TXT_BuscarEst As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ImgEstudiante As ColumnHeader
    Friend WithEvents ID_Periodo As ColumnHeader
    Friend WithEvents FechaRegistro As ColumnHeader
    Friend WithEvents FechaNacimiento As ColumnHeader
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_MODIFICAR As ToolStripMenuItem
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CerrarSesion As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CuentaProf As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents NomPeriodo As ColumnHeader
    Friend WithEvents NomSeccion As ColumnHeader
End Class
