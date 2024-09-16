<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_PGenReporteGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_PGenReporteGeneral))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBX_AsigRepGen = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LSV_RepGeneral = New System.Windows.Forms.ListView()
        Me.ID_Tema = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombreTema = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id_seccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Seccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CTX_GenReporteGen = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.GenerarReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_RegresarRepGen = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_CuentaProf = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.CerrarAPP = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CerrarSesion = New Guna.UI2.WinForms.Guna2CircleButton()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CTX_GenReporteGen.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloReporteGeneral
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(106, -86)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(484, 386)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 141
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(291, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 23)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "Asignatura:"
        '
        'CBX_AsigRepGen
        '
        Me.CBX_AsigRepGen.AutoRoundedCorners = True
        Me.CBX_AsigRepGen.BackColor = System.Drawing.Color.Transparent
        Me.CBX_AsigRepGen.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.CBX_AsigRepGen.BorderRadius = 17
        Me.CBX_AsigRepGen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBX_AsigRepGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_AsigRepGen.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_AsigRepGen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_AsigRepGen.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBX_AsigRepGen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBX_AsigRepGen.ItemHeight = 30
        Me.CBX_AsigRepGen.Location = New System.Drawing.Point(145, 231)
        Me.CBX_AsigRepGen.Name = "CBX_AsigRepGen"
        Me.CBX_AsigRepGen.Size = New System.Drawing.Size(422, 36)
        Me.CBX_AsigRepGen.TabIndex = 142
        '
        'LSV_RepGeneral
        '
        Me.LSV_RepGeneral.BackColor = System.Drawing.Color.White
        Me.LSV_RepGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSV_RepGeneral.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID_Tema, Me.NombreTema, Me.id_seccion, Me.Seccion})
        Me.LSV_RepGeneral.ContextMenuStrip = Me.CTX_GenReporteGen
        Me.LSV_RepGeneral.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LSV_RepGeneral.ForeColor = System.Drawing.Color.Black
        Me.LSV_RepGeneral.FullRowSelect = True
        Me.LSV_RepGeneral.GridLines = True
        Me.LSV_RepGeneral.HideSelection = False
        Me.LSV_RepGeneral.Location = New System.Drawing.Point(54, 273)
        Me.LSV_RepGeneral.MultiSelect = False
        Me.LSV_RepGeneral.Name = "LSV_RepGeneral"
        Me.LSV_RepGeneral.Size = New System.Drawing.Size(597, 274)
        Me.LSV_RepGeneral.TabIndex = 144
        Me.LSV_RepGeneral.UseCompatibleStateImageBehavior = False
        Me.LSV_RepGeneral.View = System.Windows.Forms.View.Details
        '
        'ID_Tema
        '
        Me.ID_Tema.Text = "ID_Tema"
        '
        'NombreTema
        '
        Me.NombreTema.Text = "Tema"
        '
        'id_seccion
        '
        Me.id_seccion.Text = "id_seccion"
        '
        'Seccion
        '
        Me.Seccion.Text = "Sección"
        '
        'CTX_GenReporteGen
        '
        Me.CTX_GenReporteGen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarReporteToolStripMenuItem})
        Me.CTX_GenReporteGen.Name = "CTX_ReporteInd"
        Me.CTX_GenReporteGen.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CTX_GenReporteGen.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.CTX_GenReporteGen.RenderStyle.ColorTable = Nothing
        Me.CTX_GenReporteGen.RenderStyle.RoundedEdges = True
        Me.CTX_GenReporteGen.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.CTX_GenReporteGen.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CTX_GenReporteGen.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.CTX_GenReporteGen.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.CTX_GenReporteGen.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CTX_GenReporteGen.Size = New System.Drawing.Size(160, 26)
        '
        'GenerarReporteToolStripMenuItem
        '
        Me.GenerarReporteToolStripMenuItem.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_AgregarVerde
        Me.GenerarReporteToolStripMenuItem.Name = "GenerarReporteToolStripMenuItem"
        Me.GenerarReporteToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.GenerarReporteToolStripMenuItem.Text = "Generar Reporte"
        '
        'BTN_RegresarRepGen
        '
        Me.BTN_RegresarRepGen.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarRepGen.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarRepGen.BorderRadius = 25
        Me.BTN_RegresarRepGen.BorderThickness = 1
        Me.BTN_RegresarRepGen.CustomBorderColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarRepGen.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarRepGen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarRepGen.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarRepGen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarRepGen.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarRepGen.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarRepGen.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarRepGen.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarRepGen.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_RegresarRepGen.Location = New System.Drawing.Point(213, 553)
        Me.BTN_RegresarRepGen.Name = "BTN_RegresarRepGen"
        Me.BTN_RegresarRepGen.Size = New System.Drawing.Size(305, 61)
        Me.BTN_RegresarRepGen.TabIndex = 145
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
        Me.BTN_CuentaProf.Location = New System.Drawing.Point(626, 130)
        Me.BTN_CuentaProf.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CuentaProf.Name = "BTN_CuentaProf"
        Me.BTN_CuentaProf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CuentaProf.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CuentaProf.TabIndex = 148
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
        Me.CerrarAPP.Location = New System.Drawing.Point(626, 21)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 147
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
        Me.BTN_CerrarSesion.Location = New System.Drawing.Point(626, 76)
        Me.BTN_CerrarSesion.Name = "BTN_CerrarSesion"
        Me.BTN_CerrarSesion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CerrarSesion.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CerrarSesion.TabIndex = 146
        '
        'P_PGenReporteGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.Fondo_BlancoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(700, 644)
        Me.Controls.Add(Me.BTN_CuentaProf)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.BTN_CerrarSesion)
        Me.Controls.Add(Me.BTN_RegresarRepGen)
        Me.Controls.Add(Me.LSV_RepGeneral)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBX_AsigRepGen)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_PGenReporteGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informes generales"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CTX_GenReporteGen.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBX_AsigRepGen As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LSV_RepGeneral As ListView
    Friend WithEvents id_seccion As ColumnHeader
    Friend WithEvents Seccion As ColumnHeader
    Friend WithEvents BTN_RegresarRepGen As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_CuentaProf As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CerrarSesion As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents ID_Tema As ColumnHeader
    Friend WithEvents NombreTema As ColumnHeader
    Friend WithEvents CTX_GenReporteGen As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents GenerarReporteToolStripMenuItem As ToolStripMenuItem
End Class
