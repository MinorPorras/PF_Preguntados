<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_PPreguntas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_PPreguntas))
        Me.LSV_Pregunta = New System.Windows.Forms.ListView()
        Me.IDPregunta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IDCategoriaPregunta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NomCat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TextoPregunta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Explicacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PuntajePregunta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TiempoPregunta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_RESPUESTAS = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_MODIFICAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.TXT_BuscarPregunta = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_CrearPregunta = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarPregunta = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.CerrarAPP = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CerrarSesion = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CuentaProf = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.MNU_CONTX.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LSV_Pregunta
        '
        Me.LSV_Pregunta.BackColor = System.Drawing.Color.White
        Me.LSV_Pregunta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSV_Pregunta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IDPregunta, Me.IDCategoriaPregunta, Me.NomCat, Me.TextoPregunta, Me.Explicacion, Me.PuntajePregunta, Me.TiempoPregunta})
        Me.LSV_Pregunta.ContextMenuStrip = Me.MNU_CONTX
        Me.LSV_Pregunta.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LSV_Pregunta.ForeColor = System.Drawing.Color.Black
        Me.LSV_Pregunta.FullRowSelect = True
        Me.LSV_Pregunta.GridLines = True
        Me.LSV_Pregunta.HideSelection = False
        Me.LSV_Pregunta.Location = New System.Drawing.Point(37, 246)
        Me.LSV_Pregunta.MultiSelect = False
        Me.LSV_Pregunta.Name = "LSV_Pregunta"
        Me.LSV_Pregunta.Size = New System.Drawing.Size(770, 353)
        Me.LSV_Pregunta.TabIndex = 82
        Me.LSV_Pregunta.UseCompatibleStateImageBehavior = False
        Me.LSV_Pregunta.View = System.Windows.Forms.View.Details
        '
        'IDPregunta
        '
        Me.IDPregunta.Text = "ID"
        Me.IDPregunta.Width = 32
        '
        'IDCategoriaPregunta
        '
        Me.IDCategoriaPregunta.Text = "IDCategoría"
        Me.IDCategoriaPregunta.Width = 49
        '
        'NomCat
        '
        Me.NomCat.Text = "Categoria"
        Me.NomCat.Width = 117
        '
        'TextoPregunta
        '
        Me.TextoPregunta.Text = "Pregunta"
        Me.TextoPregunta.Width = 174
        '
        'Explicacion
        '
        Me.Explicacion.Text = "Explicación"
        Me.Explicacion.Width = 191
        '
        'PuntajePregunta
        '
        Me.PuntajePregunta.Text = "Puntaje"
        Me.PuntajePregunta.Width = 57
        '
        'TiempoPregunta
        '
        Me.TiempoPregunta.Text = "Tiempo (Segundos)"
        Me.TiempoPregunta.Width = 126
        '
        'MNU_CONTX
        '
        Me.MNU_CONTX.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MNU_CONTX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNU_RESPUESTAS, Me.MNU_MODIFICAR, Me.MNU_ELIMINAR})
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
        Me.MNU_CONTX.Size = New System.Drawing.Size(137, 82)
        '
        'MNU_RESPUESTAS
        '
        Me.MNU_RESPUESTAS.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_AgregarVerde
        Me.MNU_RESPUESTAS.Name = "MNU_RESPUESTAS"
        Me.MNU_RESPUESTAS.Size = New System.Drawing.Size(136, 26)
        Me.MNU_RESPUESTAS.Text = "Respuestas"
        '
        'MNU_MODIFICAR
        '
        Me.MNU_MODIFICAR.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_modificarAzul
        Me.MNU_MODIFICAR.Name = "MNU_MODIFICAR"
        Me.MNU_MODIFICAR.Size = New System.Drawing.Size(136, 26)
        Me.MNU_MODIFICAR.Text = "Modificar"
        Me.MNU_MODIFICAR.Visible = False
        '
        'MNU_ELIMINAR
        '
        Me.MNU_ELIMINAR.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_eliminarRojo
        Me.MNU_ELIMINAR.Name = "MNU_ELIMINAR"
        Me.MNU_ELIMINAR.Size = New System.Drawing.Size(136, 26)
        Me.MNU_ELIMINAR.Text = "Eliminar"
        Me.MNU_ELIMINAR.Visible = False
        '
        'TXT_BuscarPregunta
        '
        Me.TXT_BuscarPregunta.AutoRoundedCorners = True
        Me.TXT_BuscarPregunta.BackColor = System.Drawing.Color.Transparent
        Me.TXT_BuscarPregunta.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_BuscarPregunta.BorderRadius = 17
        Me.TXT_BuscarPregunta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarPregunta.DefaultText = ""
        Me.TXT_BuscarPregunta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarPregunta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarPregunta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarPregunta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarPregunta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarPregunta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarPregunta.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarPregunta.IconRight = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_BuscarNaranja
        Me.TXT_BuscarPregunta.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.TXT_BuscarPregunta.Location = New System.Drawing.Point(37, 204)
        Me.TXT_BuscarPregunta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_BuscarPregunta.Name = "TXT_BuscarPregunta"
        Me.TXT_BuscarPregunta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarPregunta.PlaceholderText = "Buscar Pregunta"
        Me.TXT_BuscarPregunta.SelectedText = ""
        Me.TXT_BuscarPregunta.Size = New System.Drawing.Size(770, 36)
        Me.TXT_BuscarPregunta.TabIndex = 80
        '
        'BTN_CrearPregunta
        '
        Me.BTN_CrearPregunta.BackColor = System.Drawing.Color.Transparent
        Me.BTN_CrearPregunta.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_CrearPregunta.BorderRadius = 25
        Me.BTN_CrearPregunta.BorderThickness = 2
        Me.BTN_CrearPregunta.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_CrearPregunta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CrearPregunta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CrearPregunta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_CrearPregunta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_CrearPregunta.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_CrearPregunta.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CrearPregunta.ForeColor = System.Drawing.Color.White
        Me.BTN_CrearPregunta.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_CrearPregunta.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_CrearPregunta.Location = New System.Drawing.Point(467, 609)
        Me.BTN_CrearPregunta.Name = "BTN_CrearPregunta"
        Me.BTN_CrearPregunta.Size = New System.Drawing.Size(279, 72)
        Me.BTN_CrearPregunta.TabIndex = 79
        Me.BTN_CrearPregunta.Text = "Crear Pregunta"
        '
        'BTN_RegresarPregunta
        '
        Me.BTN_RegresarPregunta.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarPregunta.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarPregunta.BorderRadius = 25
        Me.BTN_RegresarPregunta.BorderThickness = 2
        Me.BTN_RegresarPregunta.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_RegresarPregunta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarPregunta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarPregunta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarPregunta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarPregunta.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarPregunta.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarPregunta.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarPregunta.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarPregunta.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarPregunta.Location = New System.Drawing.Point(111, 609)
        Me.BTN_RegresarPregunta.Name = "BTN_RegresarPregunta"
        Me.BTN_RegresarPregunta.Size = New System.Drawing.Size(254, 72)
        Me.BTN_RegresarPregunta.TabIndex = 78
        Me.BTN_RegresarPregunta.Text = "Regresar"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloPreguntas
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(240, -82)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(408, 370)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 81
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
        Me.CerrarAPP.Location = New System.Drawing.Point(767, 22)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 84
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
        Me.BTN_CerrarSesion.Location = New System.Drawing.Point(767, 79)
        Me.BTN_CerrarSesion.Name = "BTN_CerrarSesion"
        Me.BTN_CerrarSesion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CerrarSesion.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CerrarSesion.TabIndex = 83
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
        Me.BTN_CuentaProf.Location = New System.Drawing.Point(767, 133)
        Me.BTN_CuentaProf.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CuentaProf.Name = "BTN_CuentaProf"
        Me.BTN_CuentaProf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CuentaProf.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CuentaProf.TabIndex = 85
        '
        'P_PPreguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.Fondo_BlancoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(843, 717)
        Me.Controls.Add(Me.BTN_CuentaProf)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.BTN_CerrarSesion)
        Me.Controls.Add(Me.LSV_Pregunta)
        Me.Controls.Add(Me.TXT_BuscarPregunta)
        Me.Controls.Add(Me.BTN_CrearPregunta)
        Me.Controls.Add(Me.BTN_RegresarPregunta)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_PPreguntas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preguntas"
        Me.MNU_CONTX.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LSV_Pregunta As ListView
    Friend WithEvents IDPregunta As ColumnHeader
    Friend WithEvents TextoPregunta As ColumnHeader
    Friend WithEvents PuntajePregunta As ColumnHeader
    Friend WithEvents IDCategoriaPregunta As ColumnHeader
    Friend WithEvents TXT_BuscarPregunta As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_CrearPregunta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarPregunta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TiempoPregunta As ColumnHeader
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CerrarSesion As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_MODIFICAR As ToolStripMenuItem
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents MNU_RESPUESTAS As ToolStripMenuItem
    Friend WithEvents BTN_CuentaProf As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Explicacion As ColumnHeader
    Friend WithEvents NomCat As ColumnHeader
End Class
