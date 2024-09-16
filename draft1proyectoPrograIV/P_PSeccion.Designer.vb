<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_PSeccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_PSeccion))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TXT_BuscarSección = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LSV_Seccion = New System.Windows.Forms.ListView()
        Me.IDSeccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombreSeccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IDNivel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nivel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_MODIFICAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_AgregarNuevaSeccion = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarSeccion = New Guna.UI2.WinForms.Guna2Button()
        Me.CerrarAPP = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CerrarSesion = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CuentaProf = New Guna.UI2.WinForms.Guna2CircleButton()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MNU_CONTX.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloSeccion
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(80, -72)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(416, 378)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 60
        Me.Guna2PictureBox1.TabStop = False
        '
        'TXT_BuscarSección
        '
        Me.TXT_BuscarSección.AutoRoundedCorners = True
        Me.TXT_BuscarSección.BackColor = System.Drawing.Color.Transparent
        Me.TXT_BuscarSección.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_BuscarSección.BorderRadius = 17
        Me.TXT_BuscarSección.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarSección.DefaultText = ""
        Me.TXT_BuscarSección.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarSección.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarSección.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarSección.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarSección.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarSección.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarSección.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarSección.IconRight = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_BuscarNaranja
        Me.TXT_BuscarSección.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.TXT_BuscarSección.Location = New System.Drawing.Point(64, 203)
        Me.TXT_BuscarSección.Margin = New System.Windows.Forms.Padding(6)
        Me.TXT_BuscarSección.Name = "TXT_BuscarSección"
        Me.TXT_BuscarSección.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarSección.PlaceholderText = "Buscar Sección"
        Me.TXT_BuscarSección.SelectedText = ""
        Me.TXT_BuscarSección.Size = New System.Drawing.Size(458, 36)
        Me.TXT_BuscarSección.TabIndex = 62
        '
        'LSV_Seccion
        '
        Me.LSV_Seccion.BackColor = System.Drawing.Color.White
        Me.LSV_Seccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSV_Seccion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IDSeccion, Me.NombreSeccion, Me.IDNivel, Me.Nivel})
        Me.LSV_Seccion.ContextMenuStrip = Me.MNU_CONTX
        Me.LSV_Seccion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSV_Seccion.ForeColor = System.Drawing.Color.Black
        Me.LSV_Seccion.FullRowSelect = True
        Me.LSV_Seccion.GridLines = True
        Me.LSV_Seccion.HideSelection = False
        Me.LSV_Seccion.Location = New System.Drawing.Point(64, 245)
        Me.LSV_Seccion.MultiSelect = False
        Me.LSV_Seccion.Name = "LSV_Seccion"
        Me.LSV_Seccion.Size = New System.Drawing.Size(458, 274)
        Me.LSV_Seccion.TabIndex = 63
        Me.LSV_Seccion.UseCompatibleStateImageBehavior = False
        Me.LSV_Seccion.View = System.Windows.Forms.View.Details
        '
        'IDSeccion
        '
        Me.IDSeccion.Text = "ID"
        Me.IDSeccion.Width = 26
        '
        'NombreSeccion
        '
        Me.NombreSeccion.Text = "Sección"
        Me.NombreSeccion.Width = 349
        '
        'IDNivel
        '
        Me.IDNivel.Text = "IDNivel"
        '
        'Nivel
        '
        Me.Nivel.Text = "Nivel"
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
        'BTN_AgregarNuevaSeccion
        '
        Me.BTN_AgregarNuevaSeccion.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AgregarNuevaSeccion.BorderColor = System.Drawing.Color.White
        Me.BTN_AgregarNuevaSeccion.BorderRadius = 25
        Me.BTN_AgregarNuevaSeccion.BorderThickness = 1
        Me.BTN_AgregarNuevaSeccion.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_AgregarNuevaSeccion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarNuevaSeccion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarNuevaSeccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AgregarNuevaSeccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AgregarNuevaSeccion.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_AgregarNuevaSeccion.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AgregarNuevaSeccion.ForeColor = System.Drawing.Color.White
        Me.BTN_AgregarNuevaSeccion.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_AgregarNuevaSeccion.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_AgregarNuevaSeccion.Location = New System.Drawing.Point(317, 533)
        Me.BTN_AgregarNuevaSeccion.Name = "BTN_AgregarNuevaSeccion"
        Me.BTN_AgregarNuevaSeccion.Size = New System.Drawing.Size(205, 52)
        Me.BTN_AgregarNuevaSeccion.TabIndex = 65
        Me.BTN_AgregarNuevaSeccion.Text = "Crear Sección"
        '
        'BTN_RegresarSeccion
        '
        Me.BTN_RegresarSeccion.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarSeccion.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarSeccion.BorderRadius = 25
        Me.BTN_RegresarSeccion.BorderThickness = 1
        Me.BTN_RegresarSeccion.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_RegresarSeccion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarSeccion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarSeccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarSeccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarSeccion.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarSeccion.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarSeccion.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarSeccion.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarSeccion.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarSeccion.Location = New System.Drawing.Point(64, 533)
        Me.BTN_RegresarSeccion.Name = "BTN_RegresarSeccion"
        Me.BTN_RegresarSeccion.Size = New System.Drawing.Size(190, 52)
        Me.BTN_RegresarSeccion.TabIndex = 64
        Me.BTN_RegresarSeccion.Text = "Regresar"
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
        Me.CerrarAPP.Location = New System.Drawing.Point(502, 21)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 67
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
        Me.BTN_CerrarSesion.Location = New System.Drawing.Point(502, 78)
        Me.BTN_CerrarSesion.Name = "BTN_CerrarSesion"
        Me.BTN_CerrarSesion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CerrarSesion.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CerrarSesion.TabIndex = 66
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
        Me.BTN_CuentaProf.Location = New System.Drawing.Point(502, 132)
        Me.BTN_CuentaProf.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CuentaProf.Name = "BTN_CuentaProf"
        Me.BTN_CuentaProf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CuentaProf.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CuentaProf.TabIndex = 68
        '
        'P_PSeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.Fondo_BlancoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(569, 625)
        Me.Controls.Add(Me.BTN_CuentaProf)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.BTN_CerrarSesion)
        Me.Controls.Add(Me.BTN_AgregarNuevaSeccion)
        Me.Controls.Add(Me.BTN_RegresarSeccion)
        Me.Controls.Add(Me.LSV_Seccion)
        Me.Controls.Add(Me.TXT_BuscarSección)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_PSeccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Secciones"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MNU_CONTX.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TXT_BuscarSección As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LSV_Seccion As ListView
    Friend WithEvents IDSeccion As ColumnHeader
    Friend WithEvents NombreSeccion As ColumnHeader
    Friend WithEvents BTN_AgregarNuevaSeccion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarSeccion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Nivel As ColumnHeader
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_MODIFICAR As ToolStripMenuItem
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CerrarSesion As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CuentaProf As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents IDNivel As ColumnHeader
End Class
