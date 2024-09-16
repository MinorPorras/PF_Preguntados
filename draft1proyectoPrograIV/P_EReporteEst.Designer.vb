<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_EReporteEst
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_EReporteEst))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBX_Tema = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BTN_CuentaProf = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.CerrarAPP = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CerrarSesion = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_RegresarRepInd = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_BuscarReporte = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.CTX_ReporteEst = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LSV_ReporteEst = New System.Windows.Forms.ListView()
        Me.ID_Informe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ID_Resultado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IDTEMA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tema = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id_est = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nombreEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idAsig = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombreAsig = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idSeccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombreSeccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Pts_obtenidos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Pts_Totales = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id_tipoEnvio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tipoEnvio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CTX_ReporteEst.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(39, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 23)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "Seleccione un tema:"
        '
        'CBX_Tema
        '
        Me.CBX_Tema.AutoRoundedCorners = True
        Me.CBX_Tema.BackColor = System.Drawing.Color.Transparent
        Me.CBX_Tema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBX_Tema.BorderRadius = 17
        Me.CBX_Tema.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBX_Tema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_Tema.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_Tema.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_Tema.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBX_Tema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBX_Tema.ItemHeight = 30
        Me.CBX_Tema.Location = New System.Drawing.Point(253, 249)
        Me.CBX_Tema.Name = "CBX_Tema"
        Me.CBX_Tema.Size = New System.Drawing.Size(502, 36)
        Me.CBX_Tema.TabIndex = 171
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
        Me.BTN_CuentaProf.Location = New System.Drawing.Point(722, 129)
        Me.BTN_CuentaProf.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CuentaProf.Name = "BTN_CuentaProf"
        Me.BTN_CuentaProf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CuentaProf.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CuentaProf.TabIndex = 170
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
        Me.CerrarAPP.Location = New System.Drawing.Point(722, 20)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 169
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
        Me.BTN_CerrarSesion.Location = New System.Drawing.Point(722, 75)
        Me.BTN_CerrarSesion.Name = "BTN_CerrarSesion"
        Me.BTN_CerrarSesion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CerrarSesion.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CerrarSesion.TabIndex = 168
        '
        'BTN_RegresarRepInd
        '
        Me.BTN_RegresarRepInd.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarRepInd.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarRepInd.BorderRadius = 25
        Me.BTN_RegresarRepInd.BorderThickness = 2
        Me.BTN_RegresarRepInd.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_RegresarRepInd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarRepInd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarRepInd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarRepInd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarRepInd.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarRepInd.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarRepInd.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarRepInd.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarRepInd.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarRepInd.Location = New System.Drawing.Point(193, 578)
        Me.BTN_RegresarRepInd.Name = "BTN_RegresarRepInd"
        Me.BTN_RegresarRepInd.Size = New System.Drawing.Size(398, 72)
        Me.BTN_RegresarRepInd.TabIndex = 166
        Me.BTN_RegresarRepInd.Text = "Regresar"
        '
        'TXT_BuscarReporte
        '
        Me.TXT_BuscarReporte.AutoRoundedCorners = True
        Me.TXT_BuscarReporte.BackColor = System.Drawing.Color.Transparent
        Me.TXT_BuscarReporte.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_BuscarReporte.BorderRadius = 17
        Me.TXT_BuscarReporte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarReporte.DefaultText = ""
        Me.TXT_BuscarReporte.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarReporte.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarReporte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarReporte.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarReporte.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarReporte.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarReporte.IconRight = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_BuscarNaranja
        Me.TXT_BuscarReporte.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.TXT_BuscarReporte.Location = New System.Drawing.Point(43, 196)
        Me.TXT_BuscarReporte.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_BuscarReporte.Name = "TXT_BuscarReporte"
        Me.TXT_BuscarReporte.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarReporte.PlaceholderText = "Buscar Reporte por asignatura"
        Me.TXT_BuscarReporte.SelectedText = ""
        Me.TXT_BuscarReporte.Size = New System.Drawing.Size(712, 36)
        Me.TXT_BuscarReporte.TabIndex = 165
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloReporteIndividual
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(160, -94)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(484, 386)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 163
        Me.Guna2PictureBox1.TabStop = False
        '
        'CTX_ReporteEst
        '
        Me.CTX_ReporteEst.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.CTX_ReporteEst.Name = "CTX_ReporteInd"
        Me.CTX_ReporteEst.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CTX_ReporteEst.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.CTX_ReporteEst.RenderStyle.ColorTable = Nothing
        Me.CTX_ReporteEst.RenderStyle.RoundedEdges = True
        Me.CTX_ReporteEst.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.CTX_ReporteEst.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CTX_ReporteEst.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.CTX_ReporteEst.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.CTX_ReporteEst.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CTX_ReporteEst.Size = New System.Drawing.Size(119, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_AgregarVerde
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.ToolStripMenuItem1.Text = "Exportar"
        '
        'LSV_ReporteEst
        '
        Me.LSV_ReporteEst.BackColor = System.Drawing.Color.White
        Me.LSV_ReporteEst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSV_ReporteEst.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID_Informe, Me.ID_Resultado, Me.IDTEMA, Me.tema, Me.id_est, Me.nombreEst, Me.idAsig, Me.NombreAsig, Me.idSeccion, Me.NombreSeccion, Me.Pts_obtenidos, Me.Pts_Totales, Me.Nota, Me.id_tipoEnvio, Me.tipoEnvio})
        Me.LSV_ReporteEst.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LSV_ReporteEst.ForeColor = System.Drawing.Color.Black
        Me.LSV_ReporteEst.FullRowSelect = True
        Me.LSV_ReporteEst.GridLines = True
        Me.LSV_ReporteEst.HideSelection = False
        Me.LSV_ReporteEst.Location = New System.Drawing.Point(43, 291)
        Me.LSV_ReporteEst.MultiSelect = False
        Me.LSV_ReporteEst.Name = "LSV_ReporteEst"
        Me.LSV_ReporteEst.Size = New System.Drawing.Size(712, 274)
        Me.LSV_ReporteEst.TabIndex = 173
        Me.LSV_ReporteEst.UseCompatibleStateImageBehavior = False
        Me.LSV_ReporteEst.View = System.Windows.Forms.View.Details
        '
        'ID_Informe
        '
        Me.ID_Informe.Text = "ID_Informe"
        '
        'ID_Resultado
        '
        Me.ID_Resultado.Text = "ID_Resultado"
        '
        'IDTEMA
        '
        Me.IDTEMA.Text = "IDTEMA"
        '
        'tema
        '
        Me.tema.Text = "Tema"
        '
        'id_est
        '
        Me.id_est.Text = "id_est"
        '
        'nombreEst
        '
        Me.nombreEst.Text = "Estudiante"
        '
        'idAsig
        '
        Me.idAsig.Text = "idAsig"
        '
        'NombreAsig
        '
        Me.NombreAsig.Text = "Asignatura"
        '
        'idSeccion
        '
        Me.idSeccion.Text = "id_Seccion"
        '
        'NombreSeccion
        '
        Me.NombreSeccion.Text = "Sección"
        '
        'Pts_obtenidos
        '
        Me.Pts_obtenidos.Text = "Pts_obtenidos"
        '
        'Pts_Totales
        '
        Me.Pts_Totales.Text = "Pts_Totales"
        '
        'Nota
        '
        Me.Nota.Text = "Nota"
        '
        'id_tipoEnvio
        '
        Me.id_tipoEnvio.Text = "id_tipoEnvio"
        '
        'tipoEnvio
        '
        Me.tipoEnvio.Text = "Tipo de envío"
        '
        'P_EReporteEst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.FondoBlancoMorado
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 688)
        Me.ContextMenuStrip = Me.CTX_ReporteEst
        Me.Controls.Add(Me.LSV_ReporteEst)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBX_Tema)
        Me.Controls.Add(Me.BTN_CuentaProf)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.BTN_CerrarSesion)
        Me.Controls.Add(Me.BTN_RegresarRepInd)
        Me.Controls.Add(Me.TXT_BuscarReporte)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_EReporteEst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CTX_ReporteEst.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CBX_Tema As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BTN_CuentaProf As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CerrarSesion As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_RegresarRepInd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_BuscarReporte As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents CTX_ReporteEst As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LSV_ReporteEst As ListView
    Friend WithEvents ID_Informe As ColumnHeader
    Friend WithEvents ID_Resultado As ColumnHeader
    Friend WithEvents IDTEMA As ColumnHeader
    Friend WithEvents tema As ColumnHeader
    Friend WithEvents id_est As ColumnHeader
    Friend WithEvents nombreEst As ColumnHeader
    Friend WithEvents idAsig As ColumnHeader
    Friend WithEvents NombreAsig As ColumnHeader
    Friend WithEvents idSeccion As ColumnHeader
    Friend WithEvents NombreSeccion As ColumnHeader
    Friend WithEvents Pts_obtenidos As ColumnHeader
    Friend WithEvents Pts_Totales As ColumnHeader
    Friend WithEvents Nota As ColumnHeader
    Friend WithEvents id_tipoEnvio As ColumnHeader
    Friend WithEvents tipoEnvio As ColumnHeader
End Class
