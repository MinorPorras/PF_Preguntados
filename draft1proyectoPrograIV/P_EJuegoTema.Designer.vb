<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_EJuegoTema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_EJuegoTema))
        Me.WMP_Tema = New AxWMPLib.AxWindowsMediaPlayer()
        Me.TXT_TituloTema = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_DescTema = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_SaltarInfoTema = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.WMP_Tema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WMP_Tema
        '
        Me.WMP_Tema.Enabled = True
        Me.WMP_Tema.Location = New System.Drawing.Point(-1, -1)
        Me.WMP_Tema.Name = "WMP_Tema"
        Me.WMP_Tema.OcxState = CType(resources.GetObject("WMP_Tema.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WMP_Tema.Size = New System.Drawing.Size(802, 451)
        Me.WMP_Tema.TabIndex = 0
        '
        'TXT_TituloTema
        '
        Me.TXT_TituloTema.BackColor = System.Drawing.Color.Transparent
        Me.TXT_TituloTema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_TituloTema.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_TituloTema.DefaultText = ""
        Me.TXT_TituloTema.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_TituloTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_TituloTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TituloTema.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TituloTema.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TituloTema.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TituloTema.ForeColor = System.Drawing.Color.Black
        Me.TXT_TituloTema.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TituloTema.Location = New System.Drawing.Point(131, 76)
        Me.TXT_TituloTema.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_TituloTema.MaxLength = 500
        Me.TXT_TituloTema.Name = "TXT_TituloTema"
        Me.TXT_TituloTema.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_TituloTema.PlaceholderText = "Aquí va el nombre del tema"
        Me.TXT_TituloTema.ReadOnly = True
        Me.TXT_TituloTema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_TituloTema.SelectedText = ""
        Me.TXT_TituloTema.Size = New System.Drawing.Size(513, 62)
        Me.TXT_TituloTema.TabIndex = 118
        Me.TXT_TituloTema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_DescTema
        '
        Me.TXT_DescTema.BackColor = System.Drawing.Color.Transparent
        Me.TXT_DescTema.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TXT_DescTema.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_DescTema.DefaultText = ""
        Me.TXT_DescTema.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_DescTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_DescTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_DescTema.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_DescTema.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_DescTema.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DescTema.ForeColor = System.Drawing.Color.Black
        Me.TXT_DescTema.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_DescTema.Location = New System.Drawing.Point(45, 146)
        Me.TXT_DescTema.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.TXT_DescTema.MaxLength = 500
        Me.TXT_DescTema.Name = "TXT_DescTema"
        Me.TXT_DescTema.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_DescTema.PlaceholderText = "Aquí va la descripción de tema"
        Me.TXT_DescTema.ReadOnly = True
        Me.TXT_DescTema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_DescTema.SelectedText = ""
        Me.TXT_DescTema.Size = New System.Drawing.Size(705, 216)
        Me.TXT_DescTema.TabIndex = 119
        Me.TXT_DescTema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_SaltarInfoTema
        '
        Me.BTN_SaltarInfoTema.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SaltarInfoTema.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_SaltarInfoTema.BorderThickness = 1
        Me.BTN_SaltarInfoTema.CustomBorderColor = System.Drawing.Color.Transparent
        Me.BTN_SaltarInfoTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SaltarInfoTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SaltarInfoTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_SaltarInfoTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_SaltarInfoTema.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_SaltarInfoTema.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SaltarInfoTema.ForeColor = System.Drawing.Color.White
        Me.BTN_SaltarInfoTema.ImageSize = New System.Drawing.Size(30, 30)
        Me.BTN_SaltarInfoTema.Location = New System.Drawing.Point(533, 372)
        Me.BTN_SaltarInfoTema.Name = "BTN_SaltarInfoTema"
        Me.BTN_SaltarInfoTema.Size = New System.Drawing.Size(240, 66)
        Me.BTN_SaltarInfoTema.TabIndex = 133
        Me.BTN_SaltarInfoTema.Text = "Continuar"
        '
        'P_EJuegoTema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTN_SaltarInfoTema)
        Me.Controls.Add(Me.TXT_DescTema)
        Me.Controls.Add(Me.TXT_TituloTema)
        Me.Controls.Add(Me.WMP_Tema)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_EJuegoTema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tema juego"
        CType(Me.WMP_Tema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WMP_Tema As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TXT_TituloTema As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_DescTema As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_SaltarInfoTema As Guna.UI2.WinForms.Guna2Button
End Class
