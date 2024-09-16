<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_EJuegoCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_EJuegoCategoria))
        Me.WMP_Cat = New AxWMPLib.AxWindowsMediaPlayer()
        Me.TXT_DescCat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_TituloCat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_SaltarInfoCat = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.WMP_Cat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WMP_Cat
        '
        Me.WMP_Cat.Enabled = True
        Me.WMP_Cat.Location = New System.Drawing.Point(-1, 0)
        Me.WMP_Cat.Name = "WMP_Cat"
        Me.WMP_Cat.OcxState = CType(resources.GetObject("WMP_Cat.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WMP_Cat.Size = New System.Drawing.Size(802, 451)
        Me.WMP_Cat.TabIndex = 1
        '
        'TXT_DescCat
        '
        Me.TXT_DescCat.BackColor = System.Drawing.Color.Transparent
        Me.TXT_DescCat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_DescCat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_DescCat.DefaultText = ""
        Me.TXT_DescCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_DescCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_DescCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_DescCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_DescCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_DescCat.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DescCat.ForeColor = System.Drawing.Color.Black
        Me.TXT_DescCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_DescCat.Location = New System.Drawing.Point(48, 152)
        Me.TXT_DescCat.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.TXT_DescCat.MaxLength = 500
        Me.TXT_DescCat.Name = "TXT_DescCat"
        Me.TXT_DescCat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_DescCat.PlaceholderText = "Aquí va la descripción de la categoría"
        Me.TXT_DescCat.ReadOnly = True
        Me.TXT_DescCat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_DescCat.SelectedText = ""
        Me.TXT_DescCat.Size = New System.Drawing.Size(705, 216)
        Me.TXT_DescCat.TabIndex = 121
        Me.TXT_DescCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_TituloCat
        '
        Me.TXT_TituloCat.BackColor = System.Drawing.Color.Transparent
        Me.TXT_TituloCat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_TituloCat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_TituloCat.DefaultText = ""
        Me.TXT_TituloCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_TituloCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_TituloCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TituloCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TituloCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TituloCat.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TituloCat.ForeColor = System.Drawing.Color.Black
        Me.TXT_TituloCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TituloCat.Location = New System.Drawing.Point(134, 82)
        Me.TXT_TituloCat.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_TituloCat.MaxLength = 500
        Me.TXT_TituloCat.Name = "TXT_TituloCat"
        Me.TXT_TituloCat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_TituloCat.PlaceholderText = "Aquí va el nombre de la categoría"
        Me.TXT_TituloCat.ReadOnly = True
        Me.TXT_TituloCat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_TituloCat.SelectedText = ""
        Me.TXT_TituloCat.Size = New System.Drawing.Size(513, 62)
        Me.TXT_TituloCat.TabIndex = 120
        Me.TXT_TituloCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_SaltarInfoCat
        '
        Me.BTN_SaltarInfoCat.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SaltarInfoCat.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_SaltarInfoCat.BorderThickness = 1
        Me.BTN_SaltarInfoCat.CustomBorderColor = System.Drawing.Color.Transparent
        Me.BTN_SaltarInfoCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SaltarInfoCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SaltarInfoCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_SaltarInfoCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_SaltarInfoCat.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_SaltarInfoCat.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SaltarInfoCat.ForeColor = System.Drawing.Color.White
        Me.BTN_SaltarInfoCat.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_SaltarInfoCat.Location = New System.Drawing.Point(548, 372)
        Me.BTN_SaltarInfoCat.Name = "BTN_SaltarInfoCat"
        Me.BTN_SaltarInfoCat.Size = New System.Drawing.Size(240, 66)
        Me.BTN_SaltarInfoCat.TabIndex = 134
        Me.BTN_SaltarInfoCat.Text = "Continuar"
        '
        'P_EJuegoCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTN_SaltarInfoCat)
        Me.Controls.Add(Me.TXT_DescCat)
        Me.Controls.Add(Me.TXT_TituloCat)
        Me.Controls.Add(Me.WMP_Cat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_EJuegoCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categoría Juego"
        CType(Me.WMP_Cat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WMP_Cat As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TXT_DescCat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_TituloCat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_SaltarInfoCat As Guna.UI2.WinForms.Guna2Button
End Class
