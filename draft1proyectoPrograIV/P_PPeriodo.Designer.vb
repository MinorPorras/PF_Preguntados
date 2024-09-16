<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_PPeriodo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_PPeriodo))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TXT_BuscarPeriodo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_AgregarNPeriodo = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarPeriodo = New Guna.UI2.WinForms.Guna2Button()
        Me.LSV_Periodo = New System.Windows.Forms.ListView()
        Me.IDPeriodo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombrePeriodo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_MODIFICAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloPeriodoSF
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(86, -34)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(295, 269)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 78
        Me.Guna2PictureBox1.TabStop = False
        '
        'TXT_BuscarPeriodo
        '
        Me.TXT_BuscarPeriodo.AutoRoundedCorners = True
        Me.TXT_BuscarPeriodo.BackColor = System.Drawing.Color.Transparent
        Me.TXT_BuscarPeriodo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_BuscarPeriodo.BorderRadius = 17
        Me.TXT_BuscarPeriodo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarPeriodo.DefaultText = ""
        Me.TXT_BuscarPeriodo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarPeriodo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarPeriodo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarPeriodo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarPeriodo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarPeriodo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarPeriodo.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarPeriodo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarPeriodo.IconRight = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_BuscarNaranja
        Me.TXT_BuscarPeriodo.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.TXT_BuscarPeriodo.Location = New System.Drawing.Point(27, 182)
        Me.TXT_BuscarPeriodo.Margin = New System.Windows.Forms.Padding(6)
        Me.TXT_BuscarPeriodo.Name = "TXT_BuscarPeriodo"
        Me.TXT_BuscarPeriodo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarPeriodo.PlaceholderText = "Buscar Periodo"
        Me.TXT_BuscarPeriodo.SelectedText = ""
        Me.TXT_BuscarPeriodo.Size = New System.Drawing.Size(405, 36)
        Me.TXT_BuscarPeriodo.TabIndex = 80
        '
        'BTN_AgregarNPeriodo
        '
        Me.BTN_AgregarNPeriodo.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AgregarNPeriodo.BorderColor = System.Drawing.Color.White
        Me.BTN_AgregarNPeriodo.BorderRadius = 25
        Me.BTN_AgregarNPeriodo.BorderThickness = 1
        Me.BTN_AgregarNPeriodo.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_AgregarNPeriodo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarNPeriodo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AgregarNPeriodo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AgregarNPeriodo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AgregarNPeriodo.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_AgregarNPeriodo.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AgregarNPeriodo.ForeColor = System.Drawing.Color.White
        Me.BTN_AgregarNPeriodo.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Agregar
        Me.BTN_AgregarNPeriodo.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_AgregarNPeriodo.Location = New System.Drawing.Point(227, 444)
        Me.BTN_AgregarNPeriodo.Name = "BTN_AgregarNPeriodo"
        Me.BTN_AgregarNPeriodo.Size = New System.Drawing.Size(205, 52)
        Me.BTN_AgregarNPeriodo.TabIndex = 83
        Me.BTN_AgregarNPeriodo.Text = "Crear Periodo"
        '
        'BTN_RegresarPeriodo
        '
        Me.BTN_RegresarPeriodo.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarPeriodo.BorderColor = System.Drawing.Color.White
        Me.BTN_RegresarPeriodo.BorderRadius = 25
        Me.BTN_RegresarPeriodo.BorderThickness = 1
        Me.BTN_RegresarPeriodo.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_RegresarPeriodo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarPeriodo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarPeriodo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarPeriodo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarPeriodo.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarPeriodo.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarPeriodo.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarPeriodo.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarPeriodo.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarPeriodo.Location = New System.Drawing.Point(27, 444)
        Me.BTN_RegresarPeriodo.Name = "BTN_RegresarPeriodo"
        Me.BTN_RegresarPeriodo.Size = New System.Drawing.Size(190, 52)
        Me.BTN_RegresarPeriodo.TabIndex = 82
        Me.BTN_RegresarPeriodo.Text = "Regresar"
        '
        'LSV_Periodo
        '
        Me.LSV_Periodo.BackColor = System.Drawing.Color.White
        Me.LSV_Periodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSV_Periodo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IDPeriodo, Me.NombrePeriodo})
        Me.LSV_Periodo.ContextMenuStrip = Me.MNU_CONTX
        Me.LSV_Periodo.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LSV_Periodo.ForeColor = System.Drawing.Color.Black
        Me.LSV_Periodo.FullRowSelect = True
        Me.LSV_Periodo.GridLines = True
        Me.LSV_Periodo.HideSelection = False
        Me.LSV_Periodo.Location = New System.Drawing.Point(27, 227)
        Me.LSV_Periodo.MultiSelect = False
        Me.LSV_Periodo.Name = "LSV_Periodo"
        Me.LSV_Periodo.Size = New System.Drawing.Size(405, 211)
        Me.LSV_Periodo.TabIndex = 81
        Me.LSV_Periodo.UseCompatibleStateImageBehavior = False
        Me.LSV_Periodo.View = System.Windows.Forms.View.Details
        '
        'IDPeriodo
        '
        Me.IDPeriodo.Text = "ID"
        Me.IDPeriodo.Width = 0
        '
        'NombrePeriodo
        '
        Me.NombrePeriodo.Text = "Periodo"
        Me.NombrePeriodo.Width = 259
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
        Me.CerrarAPP.Location = New System.Drawing.Point(402, 16)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 85
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
        Me.BTN_CerrarSesion.Location = New System.Drawing.Point(402, 71)
        Me.BTN_CerrarSesion.Name = "BTN_CerrarSesion"
        Me.BTN_CerrarSesion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CerrarSesion.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CerrarSesion.TabIndex = 84
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
        Me.BTN_CuentaProf.Location = New System.Drawing.Point(402, 125)
        Me.BTN_CuentaProf.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CuentaProf.Name = "BTN_CuentaProf"
        Me.BTN_CuentaProf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CuentaProf.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CuentaProf.TabIndex = 86
        '
        'P_PPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.Fondo_BlancoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(468, 525)
        Me.Controls.Add(Me.BTN_CuentaProf)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.BTN_CerrarSesion)
        Me.Controls.Add(Me.TXT_BuscarPeriodo)
        Me.Controls.Add(Me.BTN_AgregarNPeriodo)
        Me.Controls.Add(Me.BTN_RegresarPeriodo)
        Me.Controls.Add(Me.LSV_Periodo)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_PPeriodo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Periodos"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MNU_CONTX.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TXT_BuscarPeriodo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_AgregarNPeriodo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarPeriodo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LSV_Periodo As ListView
    Friend WithEvents IDPeriodo As ColumnHeader
    Friend WithEvents NombrePeriodo As ColumnHeader
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CerrarSesion As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_MODIFICAR As ToolStripMenuItem
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents BTN_CuentaProf As Guna.UI2.WinForms.Guna2CircleButton
End Class
