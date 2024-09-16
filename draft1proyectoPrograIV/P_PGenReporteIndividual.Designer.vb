<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_PGenReporteIndividual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_PGenReporteIndividual))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BTN_CuentaProf = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.CerrarAPP = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CerrarSesion = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBX_Tema = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LSV_RepIndividual = New System.Windows.Forms.ListView()
        Me.ID_Resultado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellido1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellido2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ID_Asig = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre_Asig = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id_seccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Seccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CTX_ReporteInd = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.GenerarReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_RegresarAsig = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CTX_ReporteInd.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloReporteIndividual
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(132, -87)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(399, 385)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 81
        Me.Guna2PictureBox1.TabStop = False
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
        Me.BTN_CuentaProf.Location = New System.Drawing.Point(580, 130)
        Me.BTN_CuentaProf.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CuentaProf.Name = "BTN_CuentaProf"
        Me.BTN_CuentaProf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CuentaProf.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CuentaProf.TabIndex = 84
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
        Me.CerrarAPP.Location = New System.Drawing.Point(580, 21)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 83
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
        Me.BTN_CerrarSesion.Location = New System.Drawing.Point(580, 76)
        Me.BTN_CerrarSesion.Name = "BTN_CerrarSesion"
        Me.BTN_CerrarSesion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CerrarSesion.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CerrarSesion.TabIndex = 82
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(109, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 23)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "Seleccione un tema:"
        '
        'CBX_Tema
        '
        Me.CBX_Tema.AutoRoundedCorners = True
        Me.CBX_Tema.BackColor = System.Drawing.Color.Transparent
        Me.CBX_Tema.BorderColor = System.Drawing.Color.Black
        Me.CBX_Tema.BorderRadius = 17
        Me.CBX_Tema.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBX_Tema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_Tema.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_Tema.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_Tema.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBX_Tema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBX_Tema.ItemHeight = 30
        Me.CBX_Tema.Location = New System.Drawing.Point(101, 227)
        Me.CBX_Tema.Name = "CBX_Tema"
        Me.CBX_Tema.Size = New System.Drawing.Size(452, 36)
        Me.CBX_Tema.TabIndex = 133
        '
        'LSV_RepIndividual
        '
        Me.LSV_RepIndividual.BackColor = System.Drawing.Color.White
        Me.LSV_RepIndividual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSV_RepIndividual.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID_Resultado, Me.idEst, Me.Apellido1, Me.Apellido2, Me.Nombre, Me.ID_Asig, Me.Nombre_Asig, Me.id_seccion, Me.Seccion})
        Me.LSV_RepIndividual.ContextMenuStrip = Me.CTX_ReporteInd
        Me.LSV_RepIndividual.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LSV_RepIndividual.ForeColor = System.Drawing.Color.Black
        Me.LSV_RepIndividual.FullRowSelect = True
        Me.LSV_RepIndividual.GridLines = True
        Me.LSV_RepIndividual.HideSelection = False
        Me.LSV_RepIndividual.Location = New System.Drawing.Point(45, 269)
        Me.LSV_RepIndividual.MultiSelect = False
        Me.LSV_RepIndividual.Name = "LSV_RepIndividual"
        Me.LSV_RepIndividual.Size = New System.Drawing.Size(557, 274)
        Me.LSV_RepIndividual.TabIndex = 135
        Me.LSV_RepIndividual.UseCompatibleStateImageBehavior = False
        Me.LSV_RepIndividual.View = System.Windows.Forms.View.Details
        '
        'ID_Resultado
        '
        Me.ID_Resultado.Text = "ID_Resultado"
        Me.ID_Resultado.Width = 83
        '
        'idEst
        '
        Me.idEst.Text = "idEst"
        '
        'Apellido1
        '
        Me.Apellido1.Text = "Apellido1"
        Me.Apellido1.Width = 75
        '
        'Apellido2
        '
        Me.Apellido2.Text = "Apellido2"
        Me.Apellido2.Width = 73
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        '
        'ID_Asig
        '
        Me.ID_Asig.Text = "ID_Asig"
        '
        'Nombre_Asig
        '
        Me.Nombre_Asig.Text = "Asignatura"
        Me.Nombre_Asig.Width = 74
        '
        'id_seccion
        '
        Me.id_seccion.Text = "id_seccion"
        Me.id_seccion.Width = 67
        '
        'Seccion
        '
        Me.Seccion.Text = "Sección"
        '
        'CTX_ReporteInd
        '
        Me.CTX_ReporteInd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarReporteToolStripMenuItem})
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
        Me.CTX_ReporteInd.Size = New System.Drawing.Size(160, 26)
        '
        'GenerarReporteToolStripMenuItem
        '
        Me.GenerarReporteToolStripMenuItem.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_AgregarVerde
        Me.GenerarReporteToolStripMenuItem.Name = "GenerarReporteToolStripMenuItem"
        Me.GenerarReporteToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.GenerarReporteToolStripMenuItem.Text = "Generar Reporte"
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
        Me.BTN_RegresarAsig.Location = New System.Drawing.Point(158, 549)
        Me.BTN_RegresarAsig.Name = "BTN_RegresarAsig"
        Me.BTN_RegresarAsig.Size = New System.Drawing.Size(323, 61)
        Me.BTN_RegresarAsig.TabIndex = 136
        Me.BTN_RegresarAsig.Text = "Regresar"
        '
        'P_PGenReporteIndividual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.Fondo_BlancoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(653, 639)
        Me.Controls.Add(Me.BTN_RegresarAsig)
        Me.Controls.Add(Me.LSV_RepIndividual)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBX_Tema)
        Me.Controls.Add(Me.BTN_CuentaProf)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.BTN_CerrarSesion)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_PGenReporteIndividual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informes individuales"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CTX_ReporteInd.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTN_CuentaProf As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CerrarSesion As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents CBX_Tema As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LSV_RepIndividual As ListView
    Friend WithEvents ID_Resultado As ColumnHeader
    Friend WithEvents Apellido1 As ColumnHeader
    Friend WithEvents Apellido2 As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents ID_Asig As ColumnHeader
    Friend WithEvents Nombre_Asig As ColumnHeader
    Friend WithEvents BTN_RegresarAsig As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents id_seccion As ColumnHeader
    Friend WithEvents Seccion As ColumnHeader
    Friend WithEvents CTX_ReporteInd As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents GenerarReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents idEst As ColumnHeader
End Class
