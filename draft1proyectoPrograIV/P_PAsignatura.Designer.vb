<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_PAsignatura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_PAsignatura))
        Me.TXT_BuscarAsig = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_AgregarNuevoAsig = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarAsig = New Guna.UI2.WinForms.Guna2Button()
        Me.LSV_Asig = New System.Windows.Forms.ListView()
        Me.IDAsig = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombreAsig = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IdSeccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Seccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_MODIFICAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.CerrarAPP = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CerrarSesion = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CuentaProf = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.MNU_CONTX.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_BuscarAsig
        '
        Me.TXT_BuscarAsig.AutoRoundedCorners = True
        Me.TXT_BuscarAsig.BackColor = System.Drawing.Color.Transparent
        Me.TXT_BuscarAsig.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_BuscarAsig.BorderRadius = 17
        Me.TXT_BuscarAsig.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarAsig.DefaultText = ""
        Me.TXT_BuscarAsig.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarAsig.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarAsig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarAsig.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarAsig.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarAsig.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarAsig.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarAsig.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarAsig.IconRight = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_BuscarNaranja
        Me.TXT_BuscarAsig.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.TXT_BuscarAsig.Location = New System.Drawing.Point(56, 197)
        Me.TXT_BuscarAsig.Margin = New System.Windows.Forms.Padding(6)
        Me.TXT_BuscarAsig.Name = "TXT_BuscarAsig"
        Me.TXT_BuscarAsig.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarAsig.PlaceholderText = "Buscar Asignatura"
        Me.TXT_BuscarAsig.SelectedText = ""
        Me.TXT_BuscarAsig.Size = New System.Drawing.Size(495, 36)
        Me.TXT_BuscarAsig.TabIndex = 72
        '
        'BTN_AgregarNuevoAsig
        '
        Me.BTN_AgregarNuevoAsig.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AgregarNuevoAsig.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_AgregarNuevoAsig.BorderRadius = 25
        Me.BTN_AgregarNuevoAsig.BorderThickness = 1
        Me.BTN_AgregarNuevoAsig.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_AgregarNuevoAsig.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarNuevoAsig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarNuevoAsig.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AgregarNuevoAsig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AgregarNuevoAsig.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_AgregarNuevoAsig.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AgregarNuevoAsig.ForeColor = System.Drawing.Color.White
        Me.BTN_AgregarNuevoAsig.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_AgregarNuevoAsig.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_AgregarNuevoAsig.Location = New System.Drawing.Point(311, 527)
        Me.BTN_AgregarNuevoAsig.Name = "BTN_AgregarNuevoAsig"
        Me.BTN_AgregarNuevoAsig.Size = New System.Drawing.Size(240, 61)
        Me.BTN_AgregarNuevoAsig.TabIndex = 75
        Me.BTN_AgregarNuevoAsig.Text = "Crear Asignatura"
        '
        'BTN_RegresarAsig
        '
        Me.BTN_RegresarAsig.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarAsig.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarAsig.BorderRadius = 25
        Me.BTN_RegresarAsig.BorderThickness = 1
        Me.BTN_RegresarAsig.CustomBorderColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarAsig.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarAsig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarAsig.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarAsig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarAsig.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarAsig.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarAsig.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarAsig.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarAsig.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarAsig.Location = New System.Drawing.Point(56, 527)
        Me.BTN_RegresarAsig.Name = "BTN_RegresarAsig"
        Me.BTN_RegresarAsig.Size = New System.Drawing.Size(240, 61)
        Me.BTN_RegresarAsig.TabIndex = 74
        Me.BTN_RegresarAsig.Text = "Regresar"
        '
        'LSV_Asig
        '
        Me.LSV_Asig.BackColor = System.Drawing.Color.White
        Me.LSV_Asig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSV_Asig.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IDAsig, Me.NombreAsig, Me.IdSeccion, Me.Seccion})
        Me.LSV_Asig.ContextMenuStrip = Me.MNU_CONTX
        Me.LSV_Asig.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LSV_Asig.ForeColor = System.Drawing.Color.Black
        Me.LSV_Asig.FullRowSelect = True
        Me.LSV_Asig.GridLines = True
        Me.LSV_Asig.HideSelection = False
        Me.LSV_Asig.Location = New System.Drawing.Point(56, 239)
        Me.LSV_Asig.MultiSelect = False
        Me.LSV_Asig.Name = "LSV_Asig"
        Me.LSV_Asig.Size = New System.Drawing.Size(495, 274)
        Me.LSV_Asig.TabIndex = 73
        Me.LSV_Asig.UseCompatibleStateImageBehavior = False
        Me.LSV_Asig.View = System.Windows.Forms.View.Details
        '
        'IDAsig
        '
        Me.IDAsig.Text = "ID"
        Me.IDAsig.Width = 49
        '
        'NombreAsig
        '
        Me.NombreAsig.Text = "Asignatura"
        Me.NombreAsig.Width = 352
        '
        'IdSeccion
        '
        Me.IdSeccion.Text = "IdSeccion"
        '
        'Seccion
        '
        Me.Seccion.Text = "Sección"
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
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloAsig
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(100, -78)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(416, 378)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 71
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
        Me.CerrarAPP.Location = New System.Drawing.Point(533, 15)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 77
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
        Me.BTN_CerrarSesion.Location = New System.Drawing.Point(533, 72)
        Me.BTN_CerrarSesion.Name = "BTN_CerrarSesion"
        Me.BTN_CerrarSesion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CerrarSesion.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CerrarSesion.TabIndex = 76
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
        Me.BTN_CuentaProf.Location = New System.Drawing.Point(533, 126)
        Me.BTN_CuentaProf.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CuentaProf.Name = "BTN_CuentaProf"
        Me.BTN_CuentaProf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CuentaProf.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CuentaProf.TabIndex = 78
        '
        'P_PAsignatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.Fondo_BlancoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(599, 629)
        Me.Controls.Add(Me.BTN_CuentaProf)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.BTN_CerrarSesion)
        Me.Controls.Add(Me.TXT_BuscarAsig)
        Me.Controls.Add(Me.BTN_AgregarNuevoAsig)
        Me.Controls.Add(Me.BTN_RegresarAsig)
        Me.Controls.Add(Me.LSV_Asig)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_PAsignatura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignaturas"
        Me.MNU_CONTX.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TXT_BuscarAsig As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_AgregarNuevoAsig As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarAsig As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LSV_Asig As ListView
    Friend WithEvents IDAsig As ColumnHeader
    Friend WithEvents NombreAsig As ColumnHeader
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Seccion As ColumnHeader
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_MODIFICAR As ToolStripMenuItem
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CerrarSesion As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CuentaProf As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents IdSeccion As ColumnHeader
End Class
