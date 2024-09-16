<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_PRespuestas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_PRespuestas))
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_MODIFICAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_CrearRespuesta = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarRespuesta = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.CerrarAPP = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CerrarSesion = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CuentaProf = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.TXT_PregRESP = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LSV_Respuesta = New System.Windows.Forms.ListView()
        Me.IDRespuesta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombreRespuesta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ID_Correcta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Correcta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IDPregunta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MNU_CONTX.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'BTN_CrearRespuesta
        '
        Me.BTN_CrearRespuesta.BackColor = System.Drawing.Color.Transparent
        Me.BTN_CrearRespuesta.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_CrearRespuesta.BorderRadius = 25
        Me.BTN_CrearRespuesta.BorderThickness = 2
        Me.BTN_CrearRespuesta.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_CrearRespuesta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CrearRespuesta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CrearRespuesta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_CrearRespuesta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_CrearRespuesta.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_CrearRespuesta.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CrearRespuesta.ForeColor = System.Drawing.Color.White
        Me.BTN_CrearRespuesta.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_CrearRespuesta.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_CrearRespuesta.Location = New System.Drawing.Point(454, 538)
        Me.BTN_CrearRespuesta.Name = "BTN_CrearRespuesta"
        Me.BTN_CrearRespuesta.Size = New System.Drawing.Size(279, 72)
        Me.BTN_CrearRespuesta.TabIndex = 89
        Me.BTN_CrearRespuesta.Text = "Crear Respuesta"
        '
        'BTN_RegresarRespuesta
        '
        Me.BTN_RegresarRespuesta.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarRespuesta.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarRespuesta.BorderRadius = 25
        Me.BTN_RegresarRespuesta.BorderThickness = 2
        Me.BTN_RegresarRespuesta.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_RegresarRespuesta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarRespuesta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarRespuesta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarRespuesta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarRespuesta.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarRespuesta.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarRespuesta.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarRespuesta.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarRespuesta.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarRespuesta.Location = New System.Drawing.Point(133, 538)
        Me.BTN_RegresarRespuesta.Name = "BTN_RegresarRespuesta"
        Me.BTN_RegresarRespuesta.Size = New System.Drawing.Size(254, 72)
        Me.BTN_RegresarRespuesta.TabIndex = 88
        Me.BTN_RegresarRespuesta.Text = "Regresar"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloResp__1_
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(217, -67)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(408, 370)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 91
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
        Me.CerrarAPP.Location = New System.Drawing.Point(764, 23)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 94
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
        Me.BTN_CerrarSesion.Location = New System.Drawing.Point(764, 80)
        Me.BTN_CerrarSesion.Name = "BTN_CerrarSesion"
        Me.BTN_CerrarSesion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CerrarSesion.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CerrarSesion.TabIndex = 93
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
        Me.BTN_CuentaProf.Location = New System.Drawing.Point(764, 134)
        Me.BTN_CuentaProf.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CuentaProf.Name = "BTN_CuentaProf"
        Me.BTN_CuentaProf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CuentaProf.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CuentaProf.TabIndex = 95
        '
        'TXT_PregRESP
        '
        Me.TXT_PregRESP.AutoSize = True
        Me.TXT_PregRESP.BackColor = System.Drawing.Color.Transparent
        Me.TXT_PregRESP.BorderColor = System.Drawing.Color.Black
        Me.TXT_PregRESP.BorderRadius = 25
        Me.TXT_PregRESP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_PregRESP.DefaultText = ""
        Me.TXT_PregRESP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_PregRESP.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_PregRESP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PregRESP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PregRESP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PregRESP.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_PregRESP.ForeColor = System.Drawing.Color.Black
        Me.TXT_PregRESP.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PregRESP.Location = New System.Drawing.Point(37, 227)
        Me.TXT_PregRESP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_PregRESP.MaxLength = 150
        Me.TXT_PregRESP.Multiline = True
        Me.TXT_PregRESP.Name = "TXT_PregRESP"
        Me.TXT_PregRESP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_PregRESP.PlaceholderText = ""
        Me.TXT_PregRESP.ReadOnly = True
        Me.TXT_PregRESP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_PregRESP.SelectedText = ""
        Me.TXT_PregRESP.Size = New System.Drawing.Size(770, 89)
        Me.TXT_PregRESP.TabIndex = 123
        Me.TXT_PregRESP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(362, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 23)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Pregunta:"
        '
        'LSV_Respuesta
        '
        Me.LSV_Respuesta.BackColor = System.Drawing.Color.White
        Me.LSV_Respuesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSV_Respuesta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IDRespuesta, Me.NombreRespuesta, Me.ID_Correcta, Me.Correcta, Me.IDPregunta})
        Me.LSV_Respuesta.ContextMenuStrip = Me.MNU_CONTX
        Me.LSV_Respuesta.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LSV_Respuesta.ForeColor = System.Drawing.Color.Black
        Me.LSV_Respuesta.FullRowSelect = True
        Me.LSV_Respuesta.GridLines = True
        Me.LSV_Respuesta.HideSelection = False
        Me.LSV_Respuesta.Location = New System.Drawing.Point(37, 323)
        Me.LSV_Respuesta.MultiSelect = False
        Me.LSV_Respuesta.Name = "LSV_Respuesta"
        Me.LSV_Respuesta.Size = New System.Drawing.Size(770, 209)
        Me.LSV_Respuesta.TabIndex = 125
        Me.LSV_Respuesta.UseCompatibleStateImageBehavior = False
        Me.LSV_Respuesta.View = System.Windows.Forms.View.Details
        '
        'IDRespuesta
        '
        Me.IDRespuesta.Text = "ID"
        Me.IDRespuesta.Width = 49
        '
        'NombreRespuesta
        '
        Me.NombreRespuesta.Text = "Respuesta"
        Me.NombreRespuesta.Width = 174
        '
        'ID_Correcta
        '
        Me.ID_Correcta.Text = "ID_Correcta"
        Me.ID_Correcta.Width = 68
        '
        'Correcta
        '
        Me.Correcta.Text = "Correcta"
        Me.Correcta.Width = 89
        '
        'IDPregunta
        '
        Me.IDPregunta.Text = "IDPregunta"
        Me.IDPregunta.Width = 100
        '
        'P_PRespuestas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.Fondo_BlancoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(841, 639)
        Me.Controls.Add(Me.LSV_Respuesta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_PregRESP)
        Me.Controls.Add(Me.BTN_CuentaProf)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.BTN_CerrarSesion)
        Me.Controls.Add(Me.BTN_CrearRespuesta)
        Me.Controls.Add(Me.BTN_RegresarRespuesta)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_PRespuestas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Respuestas"
        Me.MNU_CONTX.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_CrearRespuesta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarRespuesta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_MODIFICAR As ToolStripMenuItem
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CerrarSesion As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CuentaProf As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents TXT_PregRESP As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LSV_Respuesta As ListView
    Friend WithEvents IDRespuesta As ColumnHeader
    Friend WithEvents NombreRespuesta As ColumnHeader
    Friend WithEvents ID_Correcta As ColumnHeader
    Friend WithEvents Correcta As ColumnHeader
    Friend WithEvents IDPregunta As ColumnHeader
End Class
