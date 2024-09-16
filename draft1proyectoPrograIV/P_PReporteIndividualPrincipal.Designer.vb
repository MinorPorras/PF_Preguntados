<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_PReporteIndividualPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_PReporteIndividualPrincipal))
        Me.BTN_CuentaProf = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.CerrarAPP = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CerrarSesion = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_GenRepInd = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarRepInd = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_BuscarReporte = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LSV_RepIndividual = New System.Windows.Forms.ListView()
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
        Me.CTX_ReporteInd = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.CTX_Exportar = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTX_Exportar_Calif = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTX_CalifWord = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTX_CalifExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTX_Exportar_RespInc = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoloLasPreguntasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTX_VerDatos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBX_Tema = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CTX_ReporteInd.SuspendLayout()
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
        Me.BTN_CuentaProf.Location = New System.Drawing.Point(720, 125)
        Me.BTN_CuentaProf.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CuentaProf.Name = "BTN_CuentaProf"
        Me.BTN_CuentaProf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CuentaProf.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CuentaProf.TabIndex = 160
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
        Me.CerrarAPP.Location = New System.Drawing.Point(720, 16)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 159
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
        Me.BTN_CerrarSesion.Location = New System.Drawing.Point(720, 71)
        Me.BTN_CerrarSesion.Name = "BTN_CerrarSesion"
        Me.BTN_CerrarSesion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CerrarSesion.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CerrarSesion.TabIndex = 158
        '
        'BTN_GenRepInd
        '
        Me.BTN_GenRepInd.BackColor = System.Drawing.Color.Transparent
        Me.BTN_GenRepInd.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_GenRepInd.BorderRadius = 25
        Me.BTN_GenRepInd.BorderThickness = 2
        Me.BTN_GenRepInd.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_GenRepInd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GenRepInd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GenRepInd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_GenRepInd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_GenRepInd.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_GenRepInd.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GenRepInd.ForeColor = System.Drawing.Color.White
        Me.BTN_GenRepInd.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_GenRepInd.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_GenRepInd.Location = New System.Drawing.Point(439, 582)
        Me.BTN_GenRepInd.Name = "BTN_GenRepInd"
        Me.BTN_GenRepInd.Size = New System.Drawing.Size(279, 72)
        Me.BTN_GenRepInd.TabIndex = 157
        Me.BTN_GenRepInd.Text = "Generar Reporte"
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
        Me.BTN_RegresarRepInd.Location = New System.Drawing.Point(83, 582)
        Me.BTN_RegresarRepInd.Name = "BTN_RegresarRepInd"
        Me.BTN_RegresarRepInd.Size = New System.Drawing.Size(254, 72)
        Me.BTN_RegresarRepInd.TabIndex = 156
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
        Me.TXT_BuscarReporte.Location = New System.Drawing.Point(41, 192)
        Me.TXT_BuscarReporte.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_BuscarReporte.Name = "TXT_BuscarReporte"
        Me.TXT_BuscarReporte.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarReporte.PlaceholderText = "Buscar Reporte por tema"
        Me.TXT_BuscarReporte.SelectedText = ""
        Me.TXT_BuscarReporte.Size = New System.Drawing.Size(712, 36)
        Me.TXT_BuscarReporte.TabIndex = 155
        '
        'LSV_RepIndividual
        '
        Me.LSV_RepIndividual.BackColor = System.Drawing.Color.White
        Me.LSV_RepIndividual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSV_RepIndividual.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID_Informe, Me.ID_Resultado, Me.IDTEMA, Me.tema, Me.id_est, Me.nombreEst, Me.idAsig, Me.NombreAsig, Me.idSeccion, Me.NombreSeccion, Me.Pts_obtenidos, Me.Pts_Totales, Me.Nota, Me.id_tipoEnvio, Me.tipoEnvio})
        Me.LSV_RepIndividual.ContextMenuStrip = Me.CTX_ReporteInd
        Me.LSV_RepIndividual.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LSV_RepIndividual.ForeColor = System.Drawing.Color.Black
        Me.LSV_RepIndividual.FullRowSelect = True
        Me.LSV_RepIndividual.GridLines = True
        Me.LSV_RepIndividual.HideSelection = False
        Me.LSV_RepIndividual.Location = New System.Drawing.Point(41, 294)
        Me.LSV_RepIndividual.MultiSelect = False
        Me.LSV_RepIndividual.Name = "LSV_RepIndividual"
        Me.LSV_RepIndividual.Size = New System.Drawing.Size(712, 274)
        Me.LSV_RepIndividual.TabIndex = 154
        Me.LSV_RepIndividual.UseCompatibleStateImageBehavior = False
        Me.LSV_RepIndividual.View = System.Windows.Forms.View.Details
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
        'CTX_ReporteInd
        '
        Me.CTX_ReporteInd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CTX_Exportar, Me.CTX_VerDatos})
        Me.CTX_ReporteInd.Name = "CTX_ReporteInd"
        Me.CTX_ReporteInd.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CTX_ReporteInd.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.CTX_ReporteInd.RenderStyle.ColorTable = Nothing
        Me.CTX_ReporteInd.RenderStyle.RoundedEdges = True
        Me.CTX_ReporteInd.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.CTX_ReporteInd.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CTX_ReporteInd.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.CTX_ReporteInd.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.CTX_ReporteInd.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CTX_ReporteInd.Size = New System.Drawing.Size(217, 48)
        '
        'CTX_Exportar
        '
        Me.CTX_Exportar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CTX_Exportar_Calif, Me.CTX_Exportar_RespInc, Me.SoloLasPreguntasToolStripMenuItem})
        Me.CTX_Exportar.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_AgregarVerde
        Me.CTX_Exportar.Name = "CTX_Exportar"
        Me.CTX_Exportar.Size = New System.Drawing.Size(216, 22)
        Me.CTX_Exportar.Text = "Exportar"
        '
        'CTX_Exportar_Calif
        '
        Me.CTX_Exportar_Calif.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CTX_CalifWord, Me.CTX_CalifExcel})
        Me.CTX_Exportar_Calif.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_TipodeCuenta
        Me.CTX_Exportar_Calif.Name = "CTX_Exportar_Calif"
        Me.CTX_Exportar_Calif.Size = New System.Drawing.Size(247, 22)
        Me.CTX_Exportar_Calif.Text = "Calificado"
        '
        'CTX_CalifWord
        '
        Me.CTX_CalifWord.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CTX_CalifWord.Name = "CTX_CalifWord"
        Me.CTX_CalifWord.Size = New System.Drawing.Size(103, 22)
        Me.CTX_CalifWord.Text = "Word"
        '
        'CTX_CalifExcel
        '
        Me.CTX_CalifExcel.ForeColor = System.Drawing.Color.LimeGreen
        Me.CTX_CalifExcel.Name = "CTX_CalifExcel"
        Me.CTX_CalifExcel.Size = New System.Drawing.Size(103, 22)
        Me.CTX_CalifExcel.Text = "Excel"
        '
        'CTX_Exportar_RespInc
        '
        Me.CTX_Exportar_RespInc.Name = "CTX_Exportar_RespInc"
        Me.CTX_Exportar_RespInc.Size = New System.Drawing.Size(247, 22)
        Me.CTX_Exportar_RespInc.Text = "Respuestas del estudiante (word)"
        '
        'SoloLasPreguntasToolStripMenuItem
        '
        Me.SoloLasPreguntasToolStripMenuItem.Name = "SoloLasPreguntasToolStripMenuItem"
        Me.SoloLasPreguntasToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.SoloLasPreguntasToolStripMenuItem.Text = "Solo las preguntas (word)"
        '
        'CTX_VerDatos
        '
        Me.CTX_VerDatos.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_BuscarNaranja
        Me.CTX_VerDatos.Name = "CTX_VerDatos"
        Me.CTX_VerDatos.Size = New System.Drawing.Size(216, 22)
        Me.CTX_VerDatos.Text = "Actualizar envio estudiante"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloReporteIndividual
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(158, -98)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(484, 386)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 153
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(37, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 23)
        Me.Label1.TabIndex = 162
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
        Me.CBX_Tema.Location = New System.Drawing.Point(251, 245)
        Me.CBX_Tema.Name = "CBX_Tema"
        Me.CBX_Tema.Size = New System.Drawing.Size(502, 36)
        Me.CBX_Tema.TabIndex = 161
        '
        'P_PReporteIndividualPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.Fondo_BlancoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(794, 690)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBX_Tema)
        Me.Controls.Add(Me.BTN_CuentaProf)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.BTN_CerrarSesion)
        Me.Controls.Add(Me.BTN_GenRepInd)
        Me.Controls.Add(Me.BTN_RegresarRepInd)
        Me.Controls.Add(Me.TXT_BuscarReporte)
        Me.Controls.Add(Me.LSV_RepIndividual)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_PReporteIndividualPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte individual"
        Me.CTX_ReporteInd.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_CuentaProf As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CerrarSesion As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_GenRepInd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarRepInd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_BuscarReporte As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LSV_RepIndividual As ListView
    Friend WithEvents ID_Informe As ColumnHeader
    Friend WithEvents ID_Resultado As ColumnHeader
    Friend WithEvents IDTEMA As ColumnHeader
    Friend WithEvents tema As ColumnHeader
    Friend WithEvents id_est As ColumnHeader
    Friend WithEvents nombreEst As ColumnHeader
    Friend WithEvents idSeccion As ColumnHeader
    Friend WithEvents NombreSeccion As ColumnHeader
    Friend WithEvents Nota As ColumnHeader
    Friend WithEvents id_tipoEnvio As ColumnHeader
    Friend WithEvents tipoEnvio As ColumnHeader
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents CTX_ReporteInd As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents CTX_Exportar As ToolStripMenuItem
    Friend WithEvents CTX_Exportar_Calif As ToolStripMenuItem
    Friend WithEvents CTX_Exportar_RespInc As ToolStripMenuItem
    Friend WithEvents CTX_VerDatos As ToolStripMenuItem
    Friend WithEvents idAsig As ColumnHeader
    Friend WithEvents NombreAsig As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents CBX_Tema As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Pts_obtenidos As ColumnHeader
    Friend WithEvents Pts_Totales As ColumnHeader
    Friend WithEvents CTX_CalifWord As ToolStripMenuItem
    Friend WithEvents SoloLasPreguntasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CTX_CalifExcel As ToolStripMenuItem
End Class
