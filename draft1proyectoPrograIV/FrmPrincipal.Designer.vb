<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BTN_PCentroUsuario = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_PPerTemas = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_PReporte = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(192, -108)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(426, 397)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'BTN_PCentroUsuario
        '
        Me.BTN_PCentroUsuario.AutoRoundedCorners = True
        Me.BTN_PCentroUsuario.BackColor = System.Drawing.Color.Transparent
        Me.BTN_PCentroUsuario.BorderColor = System.Drawing.Color.White
        Me.BTN_PCentroUsuario.BorderRadius = 53
        Me.BTN_PCentroUsuario.BorderThickness = 1
        Me.BTN_PCentroUsuario.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_PCentroUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_PCentroUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_PCentroUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_PCentroUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_PCentroUsuario.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BTN_PCentroUsuario.Font = New System.Drawing.Font("Cooper Black", 14.25!)
        Me.BTN_PCentroUsuario.ForeColor = System.Drawing.Color.White
        Me.BTN_PCentroUsuario.Image = CType(resources.GetObject("BTN_PCentroUsuario.Image"), System.Drawing.Image)
        Me.BTN_PCentroUsuario.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_PCentroUsuario.Location = New System.Drawing.Point(101, 244)
        Me.BTN_PCentroUsuario.Name = "BTN_PCentroUsuario"
        Me.BTN_PCentroUsuario.Size = New System.Drawing.Size(270, 108)
        Me.BTN_PCentroUsuario.TabIndex = 24
        Me.BTN_PCentroUsuario.Text = "Centro de usuarios"
        '
        'BTN_PPerTemas
        '
        Me.BTN_PPerTemas.AutoRoundedCorners = True
        Me.BTN_PPerTemas.BackColor = System.Drawing.Color.Transparent
        Me.BTN_PPerTemas.BorderColor = System.Drawing.Color.White
        Me.BTN_PPerTemas.BorderRadius = 53
        Me.BTN_PPerTemas.BorderThickness = 1
        Me.BTN_PPerTemas.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_PPerTemas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_PPerTemas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_PPerTemas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_PPerTemas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_PPerTemas.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BTN_PPerTemas.Font = New System.Drawing.Font("Cooper Black", 14.25!)
        Me.BTN_PPerTemas.ForeColor = System.Drawing.Color.White
        Me.BTN_PPerTemas.Image = CType(resources.GetObject("BTN_PPerTemas.Image"), System.Drawing.Image)
        Me.BTN_PPerTemas.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_PPerTemas.Location = New System.Drawing.Point(101, 372)
        Me.BTN_PPerTemas.Name = "BTN_PPerTemas"
        Me.BTN_PPerTemas.Size = New System.Drawing.Size(622, 108)
        Me.BTN_PPerTemas.TabIndex = 25
        Me.BTN_PPerTemas.Text = "Personalización de temas"
        '
        'BTN_PReporte
        '
        Me.BTN_PReporte.AutoRoundedCorners = True
        Me.BTN_PReporte.BackColor = System.Drawing.Color.Transparent
        Me.BTN_PReporte.BorderColor = System.Drawing.Color.White
        Me.BTN_PReporte.BorderRadius = 53
        Me.BTN_PReporte.BorderThickness = 1
        Me.BTN_PReporte.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_PReporte.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_PReporte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_PReporte.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_PReporte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_PReporte.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BTN_PReporte.Font = New System.Drawing.Font("Cooper Black", 14.25!)
        Me.BTN_PReporte.ForeColor = System.Drawing.Color.White
        Me.BTN_PReporte.Image = CType(resources.GetObject("BTN_PReporte.Image"), System.Drawing.Image)
        Me.BTN_PReporte.ImageSize = New System.Drawing.Size(50, 50)
        Me.BTN_PReporte.Location = New System.Drawing.Point(432, 244)
        Me.BTN_PReporte.Name = "BTN_PReporte"
        Me.BTN_PReporte.Size = New System.Drawing.Size(291, 108)
        Me.BTN_PReporte.TabIndex = 26
        Me.BTN_PReporte.Text = "Reportes"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(803, 574)
        Me.Controls.Add(Me.BTN_PReporte)
        Me.Controls.Add(Me.BTN_PPerTemas)
        Me.Controls.Add(Me.BTN_PCentroUsuario)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPrincipal"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTN_PCentroUsuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_PPerTemas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_PReporte As Guna.UI2.WinForms.Guna2Button
End Class
