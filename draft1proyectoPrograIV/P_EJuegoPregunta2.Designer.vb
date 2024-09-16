<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_EJuegoPregunta2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_EJuegoPregunta2))
        Me.TXT_PtsObt2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_Tiempo2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_TituloCat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_DescPreg2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PRB_Preg2 = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.BTN_Resp1 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.BTN_Resp4 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.BTN_Resp3 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.BTN_Resp2 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.TimerPreg = New System.Windows.Forms.Timer(Me.components)
        Me.TXT_CantPreg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.L_preg4 = New System.Windows.Forms.Label()
        Me.L_preg2 = New System.Windows.Forms.Label()
        Me.L_preg3 = New System.Windows.Forms.Label()
        Me.L_preg1 = New System.Windows.Forms.Label()
        Me.TXT_PtsPreg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'TXT_PtsObt2
        '
        Me.TXT_PtsObt2.AutoRoundedCorners = True
        Me.TXT_PtsObt2.BackColor = System.Drawing.Color.Transparent
        Me.TXT_PtsObt2.BorderRadius = 17
        Me.TXT_PtsObt2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_PtsObt2.DefaultText = ""
        Me.TXT_PtsObt2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_PtsObt2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_PtsObt2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PtsObt2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PtsObt2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PtsObt2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PtsObt2.ForeColor = System.Drawing.Color.Black
        Me.TXT_PtsObt2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PtsObt2.IconRight = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Moneda
        Me.TXT_PtsObt2.IconRightSize = New System.Drawing.Size(30, 30)
        Me.TXT_PtsObt2.Location = New System.Drawing.Point(14, 13)
        Me.TXT_PtsObt2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TXT_PtsObt2.Name = "TXT_PtsObt2"
        Me.TXT_PtsObt2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_PtsObt2.PlaceholderText = ""
        Me.TXT_PtsObt2.ReadOnly = True
        Me.TXT_PtsObt2.SelectedText = ""
        Me.TXT_PtsObt2.Size = New System.Drawing.Size(200, 36)
        Me.TXT_PtsObt2.TabIndex = 124
        Me.TXT_PtsObt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_Tiempo2
        '
        Me.TXT_Tiempo2.AutoRoundedCorners = True
        Me.TXT_Tiempo2.BackColor = System.Drawing.Color.Transparent
        Me.TXT_Tiempo2.BorderRadius = 17
        Me.TXT_Tiempo2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Tiempo2.DefaultText = ""
        Me.TXT_Tiempo2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Tiempo2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Tiempo2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Tiempo2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Tiempo2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Tiempo2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Tiempo2.ForeColor = System.Drawing.Color.Black
        Me.TXT_Tiempo2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Tiempo2.Location = New System.Drawing.Point(586, 13)
        Me.TXT_Tiempo2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TXT_Tiempo2.Name = "TXT_Tiempo2"
        Me.TXT_Tiempo2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Tiempo2.PlaceholderText = ""
        Me.TXT_Tiempo2.ReadOnly = True
        Me.TXT_Tiempo2.SelectedText = ""
        Me.TXT_Tiempo2.Size = New System.Drawing.Size(200, 36)
        Me.TXT_Tiempo2.TabIndex = 125
        Me.TXT_Tiempo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_TituloCat
        '
        Me.TXT_TituloCat.BackColor = System.Drawing.Color.Transparent
        Me.TXT_TituloCat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_TituloCat.BorderRadius = 25
        Me.TXT_TituloCat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_TituloCat.DefaultText = ""
        Me.TXT_TituloCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_TituloCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_TituloCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TituloCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TituloCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TituloCat.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TituloCat.ForeColor = System.Drawing.Color.Black
        Me.TXT_TituloCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TituloCat.Location = New System.Drawing.Point(146, 69)
        Me.TXT_TituloCat.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_TituloCat.MaxLength = 500
        Me.TXT_TituloCat.Name = "TXT_TituloCat"
        Me.TXT_TituloCat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_TituloCat.PlaceholderText = "Titulo Categoría"
        Me.TXT_TituloCat.ReadOnly = True
        Me.TXT_TituloCat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_TituloCat.SelectedText = ""
        Me.TXT_TituloCat.Size = New System.Drawing.Size(513, 62)
        Me.TXT_TituloCat.TabIndex = 126
        Me.TXT_TituloCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_DescPreg2
        '
        Me.TXT_DescPreg2.BackColor = System.Drawing.Color.Transparent
        Me.TXT_DescPreg2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_DescPreg2.BorderRadius = 25
        Me.TXT_DescPreg2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_DescPreg2.DefaultText = ""
        Me.TXT_DescPreg2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_DescPreg2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_DescPreg2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_DescPreg2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_DescPreg2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_DescPreg2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DescPreg2.ForeColor = System.Drawing.Color.Black
        Me.TXT_DescPreg2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_DescPreg2.Location = New System.Drawing.Point(68, 146)
        Me.TXT_DescPreg2.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_DescPreg2.MaxLength = 500
        Me.TXT_DescPreg2.Name = "TXT_DescPreg2"
        Me.TXT_DescPreg2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_DescPreg2.PlaceholderText = "Pregunta va aquí"
        Me.TXT_DescPreg2.ReadOnly = True
        Me.TXT_DescPreg2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_DescPreg2.SelectedText = ""
        Me.TXT_DescPreg2.Size = New System.Drawing.Size(664, 125)
        Me.TXT_DescPreg2.TabIndex = 127
        Me.TXT_DescPreg2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PRB_Preg2
        '
        Me.PRB_Preg2.Location = New System.Drawing.Point(0, 464)
        Me.PRB_Preg2.Name = "PRB_Preg2"
        Me.PRB_Preg2.Size = New System.Drawing.Size(808, 30)
        Me.PRB_Preg2.TabIndex = 128
        Me.PRB_Preg2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'BTN_Resp1
        '
        Me.BTN_Resp1.BackColor = System.Drawing.Color.Transparent
        Me.BTN_Resp1.BorderColor = System.Drawing.Color.White
        Me.BTN_Resp1.BorderRadius = 25
        Me.BTN_Resp1.BorderThickness = 2
        Me.BTN_Resp1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Resp1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Resp1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Resp1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Resp1.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BTN_Resp1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Resp1.ForeColor = System.Drawing.Color.White
        Me.BTN_Resp1.Location = New System.Drawing.Point(73, 320)
        Me.BTN_Resp1.Name = "BTN_Resp1"
        Me.BTN_Resp1.Size = New System.Drawing.Size(315, 61)
        Me.BTN_Resp1.TabIndex = 129
        Me.BTN_Resp1.Text = "Guna2TileButton1"
        '
        'BTN_Resp4
        '
        Me.BTN_Resp4.BackColor = System.Drawing.Color.Transparent
        Me.BTN_Resp4.BorderColor = System.Drawing.Color.White
        Me.BTN_Resp4.BorderRadius = 25
        Me.BTN_Resp4.BorderThickness = 2
        Me.BTN_Resp4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Resp4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Resp4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Resp4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Resp4.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BTN_Resp4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Resp4.ForeColor = System.Drawing.Color.White
        Me.BTN_Resp4.Location = New System.Drawing.Point(417, 387)
        Me.BTN_Resp4.Name = "BTN_Resp4"
        Me.BTN_Resp4.Size = New System.Drawing.Size(315, 61)
        Me.BTN_Resp4.TabIndex = 132
        Me.BTN_Resp4.Text = "Guna2TileButton4"
        '
        'BTN_Resp3
        '
        Me.BTN_Resp3.BackColor = System.Drawing.Color.Transparent
        Me.BTN_Resp3.BorderColor = System.Drawing.Color.White
        Me.BTN_Resp3.BorderRadius = 25
        Me.BTN_Resp3.BorderThickness = 2
        Me.BTN_Resp3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Resp3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Resp3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Resp3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Resp3.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BTN_Resp3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Resp3.ForeColor = System.Drawing.Color.White
        Me.BTN_Resp3.Location = New System.Drawing.Point(73, 387)
        Me.BTN_Resp3.Name = "BTN_Resp3"
        Me.BTN_Resp3.Size = New System.Drawing.Size(315, 61)
        Me.BTN_Resp3.TabIndex = 131
        Me.BTN_Resp3.Text = "Guna2TileButton3"
        '
        'BTN_Resp2
        '
        Me.BTN_Resp2.BackColor = System.Drawing.Color.Transparent
        Me.BTN_Resp2.BorderColor = System.Drawing.Color.White
        Me.BTN_Resp2.BorderRadius = 25
        Me.BTN_Resp2.BorderThickness = 2
        Me.BTN_Resp2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Resp2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Resp2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Resp2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Resp2.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BTN_Resp2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Resp2.ForeColor = System.Drawing.Color.White
        Me.BTN_Resp2.Location = New System.Drawing.Point(417, 320)
        Me.BTN_Resp2.Name = "BTN_Resp2"
        Me.BTN_Resp2.Size = New System.Drawing.Size(315, 61)
        Me.BTN_Resp2.TabIndex = 130
        Me.BTN_Resp2.Text = "Guna2TileButton2"
        '
        'TimerPreg
        '
        Me.TimerPreg.Interval = 1000
        '
        'TXT_CantPreg
        '
        Me.TXT_CantPreg.AutoRoundedCorners = True
        Me.TXT_CantPreg.BackColor = System.Drawing.Color.Transparent
        Me.TXT_CantPreg.BorderRadius = 17
        Me.TXT_CantPreg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CantPreg.DefaultText = ""
        Me.TXT_CantPreg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CantPreg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CantPreg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CantPreg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CantPreg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CantPreg.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CantPreg.ForeColor = System.Drawing.Color.Black
        Me.TXT_CantPreg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CantPreg.Location = New System.Drawing.Point(298, 13)
        Me.TXT_CantPreg.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TXT_CantPreg.Name = "TXT_CantPreg"
        Me.TXT_CantPreg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CantPreg.PlaceholderText = ""
        Me.TXT_CantPreg.ReadOnly = True
        Me.TXT_CantPreg.SelectedText = ""
        Me.TXT_CantPreg.Size = New System.Drawing.Size(200, 36)
        Me.TXT_CantPreg.TabIndex = 133
        Me.TXT_CantPreg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_preg4
        '
        Me.L_preg4.AutoSize = True
        Me.L_preg4.Location = New System.Drawing.Point(69, 53)
        Me.L_preg4.Name = "L_preg4"
        Me.L_preg4.Size = New System.Drawing.Size(13, 13)
        Me.L_preg4.TabIndex = 137
        Me.L_preg4.Text = "4"
        Me.L_preg4.Visible = False
        '
        'L_preg2
        '
        Me.L_preg2.AutoSize = True
        Me.L_preg2.Location = New System.Drawing.Point(31, 53)
        Me.L_preg2.Name = "L_preg2"
        Me.L_preg2.Size = New System.Drawing.Size(13, 13)
        Me.L_preg2.TabIndex = 136
        Me.L_preg2.Text = "2"
        Me.L_preg2.Visible = False
        '
        'L_preg3
        '
        Me.L_preg3.AutoSize = True
        Me.L_preg3.Location = New System.Drawing.Point(50, 53)
        Me.L_preg3.Name = "L_preg3"
        Me.L_preg3.Size = New System.Drawing.Size(13, 13)
        Me.L_preg3.TabIndex = 135
        Me.L_preg3.Text = "3"
        Me.L_preg3.Visible = False
        '
        'L_preg1
        '
        Me.L_preg1.AutoSize = True
        Me.L_preg1.Location = New System.Drawing.Point(12, 53)
        Me.L_preg1.Name = "L_preg1"
        Me.L_preg1.Size = New System.Drawing.Size(13, 13)
        Me.L_preg1.TabIndex = 134
        Me.L_preg1.Text = "1"
        Me.L_preg1.Visible = False
        '
        'TXT_PtsPreg
        '
        Me.TXT_PtsPreg.AutoRoundedCorners = True
        Me.TXT_PtsPreg.BackColor = System.Drawing.Color.Transparent
        Me.TXT_PtsPreg.BorderRadius = 17
        Me.TXT_PtsPreg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_PtsPreg.DefaultText = ""
        Me.TXT_PtsPreg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_PtsPreg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_PtsPreg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PtsPreg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PtsPreg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PtsPreg.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PtsPreg.ForeColor = System.Drawing.Color.Black
        Me.TXT_PtsPreg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PtsPreg.Location = New System.Drawing.Point(586, 277)
        Me.TXT_PtsPreg.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TXT_PtsPreg.Name = "TXT_PtsPreg"
        Me.TXT_PtsPreg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_PtsPreg.PlaceholderText = ""
        Me.TXT_PtsPreg.ReadOnly = True
        Me.TXT_PtsPreg.SelectedText = ""
        Me.TXT_PtsPreg.Size = New System.Drawing.Size(146, 36)
        Me.TXT_PtsPreg.TabIndex = 138
        Me.TXT_PtsPreg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'P_EJuegoPregunta2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(805, 492)
        Me.Controls.Add(Me.TXT_PtsPreg)
        Me.Controls.Add(Me.L_preg4)
        Me.Controls.Add(Me.L_preg2)
        Me.Controls.Add(Me.L_preg3)
        Me.Controls.Add(Me.L_preg1)
        Me.Controls.Add(Me.TXT_CantPreg)
        Me.Controls.Add(Me.BTN_Resp4)
        Me.Controls.Add(Me.BTN_Resp3)
        Me.Controls.Add(Me.BTN_Resp2)
        Me.Controls.Add(Me.BTN_Resp1)
        Me.Controls.Add(Me.PRB_Preg2)
        Me.Controls.Add(Me.TXT_DescPreg2)
        Me.Controls.Add(Me.TXT_TituloCat)
        Me.Controls.Add(Me.TXT_Tiempo2)
        Me.Controls.Add(Me.TXT_PtsObt2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_EJuegoPregunta2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pregunta juego"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_PtsObt2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_Tiempo2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_TituloCat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_DescPreg2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PRB_Preg2 As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents BTN_Resp1 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents BTN_Resp4 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents BTN_Resp3 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents BTN_Resp2 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents TimerPreg As Timer
    Friend WithEvents TXT_CantPreg As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents L_preg4 As Label
    Friend WithEvents L_preg2 As Label
    Friend WithEvents L_preg3 As Label
    Friend WithEvents L_preg1 As Label
    Friend WithEvents TXT_PtsPreg As Guna.UI2.WinForms.Guna2TextBox
End Class
