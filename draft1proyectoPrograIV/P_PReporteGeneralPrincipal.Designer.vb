<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_PReporteGeneralPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_PReporteGeneralPrincipal))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LSV_RepGeneral = New System.Windows.Forms.ListView()
        Me.ID_Informe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IDTEMA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tema = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idAsig = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombreAsig = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idSeccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombreSeccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaGeneración = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CTX_ReporteGen = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.CTX_Exportar = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTX_RepGenCompl = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTX_ExpComWord = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTX_RepGenResum = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTX_VerDatos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TXT_BuscarRepGeneral = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_GenRepGen = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarRepGen = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_CuentaProf = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.CerrarAPP = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CerrarSesion = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBX_Tema = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CTX_ReporteGen.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloReporteGeneral
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(162, -89)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(484, 386)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 142
        Me.Guna2PictureBox1.TabStop = False
        '
        'LSV_RepGeneral
        '
        Me.LSV_RepGeneral.BackColor = System.Drawing.Color.White
        Me.LSV_RepGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSV_RepGeneral.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID_Informe, Me.IDTEMA, Me.tema, Me.idAsig, Me.NombreAsig, Me.idSeccion, Me.NombreSeccion, Me.FechaGeneración})
        Me.LSV_RepGeneral.ContextMenuStrip = Me.CTX_ReporteGen
        Me.LSV_RepGeneral.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LSV_RepGeneral.ForeColor = System.Drawing.Color.Black
        Me.LSV_RepGeneral.FullRowSelect = True
        Me.LSV_RepGeneral.GridLines = True
        Me.LSV_RepGeneral.HideSelection = False
        Me.LSV_RepGeneral.Location = New System.Drawing.Point(45, 286)
        Me.LSV_RepGeneral.MultiSelect = False
        Me.LSV_RepGeneral.Name = "LSV_RepGeneral"
        Me.LSV_RepGeneral.Size = New System.Drawing.Size(712, 274)
        Me.LSV_RepGeneral.TabIndex = 145
        Me.LSV_RepGeneral.UseCompatibleStateImageBehavior = False
        Me.LSV_RepGeneral.View = System.Windows.Forms.View.Details
        '
        'ID_Informe
        '
        Me.ID_Informe.Text = "ID_Informe"
        '
        'IDTEMA
        '
        Me.IDTEMA.Text = "IDTEMA"
        '
        'tema
        '
        Me.tema.Text = "Tema"
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
        'FechaGeneración
        '
        Me.FechaGeneración.Text = "Generado el:"
        '
        'CTX_ReporteGen
        '
        Me.CTX_ReporteGen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CTX_Exportar, Me.CTX_VerDatos})
        Me.CTX_ReporteGen.Name = "CTX_ReporteInd"
        Me.CTX_ReporteGen.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CTX_ReporteGen.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.CTX_ReporteGen.RenderStyle.ColorTable = Nothing
        Me.CTX_ReporteGen.RenderStyle.RoundedEdges = True
        Me.CTX_ReporteGen.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.CTX_ReporteGen.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CTX_ReporteGen.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.CTX_ReporteGen.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.CTX_ReporteGen.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CTX_ReporteGen.Size = New System.Drawing.Size(123, 48)
        '
        'CTX_Exportar
        '
        Me.CTX_Exportar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CTX_RepGenCompl, Me.CTX_RepGenResum})
        Me.CTX_Exportar.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_AgregarVerde
        Me.CTX_Exportar.Name = "CTX_Exportar"
        Me.CTX_Exportar.Size = New System.Drawing.Size(122, 22)
        Me.CTX_Exportar.Text = "Exportar"
        '
        'CTX_RepGenCompl
        '
        Me.CTX_RepGenCompl.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CTX_ExpComWord, Me.ExcelToolStripMenuItem})
        Me.CTX_RepGenCompl.ForeColor = System.Drawing.Color.Black
        Me.CTX_RepGenCompl.Name = "CTX_RepGenCompl"
        Me.CTX_RepGenCompl.Size = New System.Drawing.Size(161, 22)
        Me.CTX_RepGenCompl.Text = "Completo"
        '
        'CTX_ExpComWord
        '
        Me.CTX_ExpComWord.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CTX_ExpComWord.Name = "CTX_ExpComWord"
        Me.CTX_ExpComWord.Size = New System.Drawing.Size(103, 22)
        Me.CTX_ExpComWord.Text = "Word"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.ForeColor = System.Drawing.Color.LimeGreen
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'CTX_RepGenResum
        '
        Me.CTX_RepGenResum.ForeColor = System.Drawing.Color.Black
        Me.CTX_RepGenResum.Name = "CTX_RepGenResum"
        Me.CTX_RepGenResum.Size = New System.Drawing.Size(161, 22)
        Me.CTX_RepGenResum.Text = "Resumen (word)"
        '
        'CTX_VerDatos
        '
        Me.CTX_VerDatos.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_BuscarNaranja
        Me.CTX_VerDatos.Name = "CTX_VerDatos"
        Me.CTX_VerDatos.Size = New System.Drawing.Size(122, 22)
        Me.CTX_VerDatos.Text = "Ver datos"
        '
        'TXT_BuscarRepGeneral
        '
        Me.TXT_BuscarRepGeneral.AutoRoundedCorners = True
        Me.TXT_BuscarRepGeneral.BackColor = System.Drawing.Color.Transparent
        Me.TXT_BuscarRepGeneral.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_BuscarRepGeneral.BorderRadius = 17
        Me.TXT_BuscarRepGeneral.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarRepGeneral.DefaultText = ""
        Me.TXT_BuscarRepGeneral.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarRepGeneral.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarRepGeneral.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarRepGeneral.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarRepGeneral.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarRepGeneral.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarRepGeneral.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarRepGeneral.IconRight = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_BuscarNaranja
        Me.TXT_BuscarRepGeneral.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.TXT_BuscarRepGeneral.Location = New System.Drawing.Point(45, 201)
        Me.TXT_BuscarRepGeneral.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_BuscarRepGeneral.Name = "TXT_BuscarRepGeneral"
        Me.TXT_BuscarRepGeneral.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarRepGeneral.PlaceholderText = "Buscar Reporte por sección"
        Me.TXT_BuscarRepGeneral.SelectedText = ""
        Me.TXT_BuscarRepGeneral.Size = New System.Drawing.Size(712, 36)
        Me.TXT_BuscarRepGeneral.TabIndex = 146
        '
        'BTN_GenRepGen
        '
        Me.BTN_GenRepGen.BackColor = System.Drawing.Color.Transparent
        Me.BTN_GenRepGen.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_GenRepGen.BorderRadius = 25
        Me.BTN_GenRepGen.BorderThickness = 2
        Me.BTN_GenRepGen.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_GenRepGen.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GenRepGen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GenRepGen.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_GenRepGen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_GenRepGen.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_GenRepGen.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GenRepGen.ForeColor = System.Drawing.Color.White
        Me.BTN_GenRepGen.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_GenRepGen.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_GenRepGen.Location = New System.Drawing.Point(439, 577)
        Me.BTN_GenRepGen.Name = "BTN_GenRepGen"
        Me.BTN_GenRepGen.Size = New System.Drawing.Size(279, 72)
        Me.BTN_GenRepGen.TabIndex = 148
        Me.BTN_GenRepGen.Text = "Generar Reporte"
        '
        'BTN_RegresarRepGen
        '
        Me.BTN_RegresarRepGen.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarRepGen.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarRepGen.BorderRadius = 25
        Me.BTN_RegresarRepGen.BorderThickness = 2
        Me.BTN_RegresarRepGen.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_RegresarRepGen.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarRepGen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarRepGen.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarRepGen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarRepGen.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarRepGen.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarRepGen.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarRepGen.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarRepGen.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarRepGen.Location = New System.Drawing.Point(83, 577)
        Me.BTN_RegresarRepGen.Name = "BTN_RegresarRepGen"
        Me.BTN_RegresarRepGen.Size = New System.Drawing.Size(254, 72)
        Me.BTN_RegresarRepGen.TabIndex = 147
        Me.BTN_RegresarRepGen.Text = "Regresar"
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
        Me.BTN_CuentaProf.Location = New System.Drawing.Point(724, 134)
        Me.BTN_CuentaProf.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CuentaProf.Name = "BTN_CuentaProf"
        Me.BTN_CuentaProf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CuentaProf.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CuentaProf.TabIndex = 152
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
        Me.CerrarAPP.Location = New System.Drawing.Point(724, 25)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 151
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
        Me.BTN_CerrarSesion.Location = New System.Drawing.Point(724, 80)
        Me.BTN_CerrarSesion.Name = "BTN_CerrarSesion"
        Me.BTN_CerrarSesion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CerrarSesion.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CerrarSesion.TabIndex = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(41, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 23)
        Me.Label1.TabIndex = 164
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
        Me.CBX_Tema.Location = New System.Drawing.Point(255, 244)
        Me.CBX_Tema.Name = "CBX_Tema"
        Me.CBX_Tema.Size = New System.Drawing.Size(502, 36)
        Me.CBX_Tema.TabIndex = 163
        '
        'P_PReporteGeneralPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.Fondo_BlancoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 683)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBX_Tema)
        Me.Controls.Add(Me.BTN_CuentaProf)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.BTN_CerrarSesion)
        Me.Controls.Add(Me.BTN_GenRepGen)
        Me.Controls.Add(Me.BTN_RegresarRepGen)
        Me.Controls.Add(Me.TXT_BuscarRepGeneral)
        Me.Controls.Add(Me.LSV_RepGeneral)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_PReporteGeneralPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte general"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CTX_ReporteGen.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LSV_RepGeneral As ListView
    Friend WithEvents ID_Informe As ColumnHeader
    Friend WithEvents IDTEMA As ColumnHeader
    Friend WithEvents tema As ColumnHeader
    Friend WithEvents idSeccion As ColumnHeader
    Friend WithEvents NombreSeccion As ColumnHeader
    Friend WithEvents TXT_BuscarRepGeneral As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_GenRepGen As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarRepGen As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_CuentaProf As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CerrarSesion As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents CBX_Tema As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents idAsig As ColumnHeader
    Friend WithEvents NombreAsig As ColumnHeader
    Friend WithEvents FechaGeneración As ColumnHeader
    Friend WithEvents CTX_ReporteGen As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents CTX_Exportar As ToolStripMenuItem
    Friend WithEvents CTX_VerDatos As ToolStripMenuItem
    Friend WithEvents CTX_RepGenCompl As ToolStripMenuItem
    Friend WithEvents CTX_RepGenResum As ToolStripMenuItem
    Friend WithEvents CTX_ExpComWord As ToolStripMenuItem
    Friend WithEvents ExcelToolStripMenuItem As ToolStripMenuItem
End Class
