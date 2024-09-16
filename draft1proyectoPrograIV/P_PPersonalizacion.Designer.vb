<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_PPersonalizacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_PPersonalizacion))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BTN_VerTemas = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_VerCategorias = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarPersonalizar = New Guna.UI2.WinForms.Guna2Button()
        Me.CerrarAPP = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CerrarSesion = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_VerPregunta = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_CuentaProf = New Guna.UI2.WinForms.Guna2CircleButton()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloPersonalización
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(82, -96)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(443, 433)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'BTN_VerTemas
        '
        Me.BTN_VerTemas.AutoRoundedCorners = True
        Me.BTN_VerTemas.BackColor = System.Drawing.Color.Transparent
        Me.BTN_VerTemas.BorderColor = System.Drawing.Color.White
        Me.BTN_VerTemas.BorderRadius = 29
        Me.BTN_VerTemas.BorderThickness = 1
        Me.BTN_VerTemas.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_VerTemas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VerTemas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VerTemas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_VerTemas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_VerTemas.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_VerTemas.Font = New System.Drawing.Font("Showcard Gothic", 18.0!)
        Me.BTN_VerTemas.ForeColor = System.Drawing.Color.White
        Me.BTN_VerTemas.ImageSize = New System.Drawing.Size(60, 70)
        Me.BTN_VerTemas.Location = New System.Drawing.Point(82, 221)
        Me.BTN_VerTemas.Name = "BTN_VerTemas"
        Me.BTN_VerTemas.Size = New System.Drawing.Size(443, 60)
        Me.BTN_VerTemas.TabIndex = 25
        Me.BTN_VerTemas.Text = "1. Temas"
        '
        'BTN_VerCategorias
        '
        Me.BTN_VerCategorias.AutoRoundedCorners = True
        Me.BTN_VerCategorias.BackColor = System.Drawing.Color.Transparent
        Me.BTN_VerCategorias.BorderColor = System.Drawing.Color.White
        Me.BTN_VerCategorias.BorderRadius = 29
        Me.BTN_VerCategorias.BorderThickness = 1
        Me.BTN_VerCategorias.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_VerCategorias.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VerCategorias.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VerCategorias.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_VerCategorias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_VerCategorias.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_VerCategorias.Font = New System.Drawing.Font("Showcard Gothic", 18.0!)
        Me.BTN_VerCategorias.ForeColor = System.Drawing.Color.White
        Me.BTN_VerCategorias.ImageSize = New System.Drawing.Size(60, 70)
        Me.BTN_VerCategorias.Location = New System.Drawing.Point(82, 287)
        Me.BTN_VerCategorias.Name = "BTN_VerCategorias"
        Me.BTN_VerCategorias.Size = New System.Drawing.Size(443, 60)
        Me.BTN_VerCategorias.TabIndex = 26
        Me.BTN_VerCategorias.Text = "2. Categorias"
        '
        'BTN_RegresarPersonalizar
        '
        Me.BTN_RegresarPersonalizar.AutoRoundedCorners = True
        Me.BTN_RegresarPersonalizar.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarPersonalizar.BorderColor = System.Drawing.Color.White
        Me.BTN_RegresarPersonalizar.BorderRadius = 36
        Me.BTN_RegresarPersonalizar.BorderThickness = 1
        Me.BTN_RegresarPersonalizar.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_RegresarPersonalizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarPersonalizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarPersonalizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarPersonalizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarPersonalizar.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarPersonalizar.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarPersonalizar.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarPersonalizar.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarPersonalizar.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarPersonalizar.Location = New System.Drawing.Point(82, 419)
        Me.BTN_RegresarPersonalizar.Name = "BTN_RegresarPersonalizar"
        Me.BTN_RegresarPersonalizar.Size = New System.Drawing.Size(443, 74)
        Me.BTN_RegresarPersonalizar.TabIndex = 73
        Me.BTN_RegresarPersonalizar.Text = "Regresar"
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
        Me.CerrarAPP.Location = New System.Drawing.Point(539, 18)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 75
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
        Me.BTN_CerrarSesion.Location = New System.Drawing.Point(539, 75)
        Me.BTN_CerrarSesion.Name = "BTN_CerrarSesion"
        Me.BTN_CerrarSesion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CerrarSesion.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CerrarSesion.TabIndex = 74
        '
        'BTN_VerPregunta
        '
        Me.BTN_VerPregunta.AutoRoundedCorners = True
        Me.BTN_VerPregunta.BackColor = System.Drawing.Color.Transparent
        Me.BTN_VerPregunta.BorderColor = System.Drawing.Color.White
        Me.BTN_VerPregunta.BorderRadius = 29
        Me.BTN_VerPregunta.BorderThickness = 1
        Me.BTN_VerPregunta.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_VerPregunta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VerPregunta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VerPregunta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_VerPregunta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_VerPregunta.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_VerPregunta.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VerPregunta.ForeColor = System.Drawing.Color.White
        Me.BTN_VerPregunta.ImageSize = New System.Drawing.Size(60, 70)
        Me.BTN_VerPregunta.Location = New System.Drawing.Point(82, 353)
        Me.BTN_VerPregunta.Name = "BTN_VerPregunta"
        Me.BTN_VerPregunta.Size = New System.Drawing.Size(443, 60)
        Me.BTN_VerPregunta.TabIndex = 76
        Me.BTN_VerPregunta.Text = "3. Preguntas y respuestas"
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
        Me.BTN_CuentaProf.Location = New System.Drawing.Point(539, 129)
        Me.BTN_CuentaProf.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CuentaProf.Name = "BTN_CuentaProf"
        Me.BTN_CuentaProf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CuentaProf.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CuentaProf.TabIndex = 77
        '
        'P_PPersonalizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.Fondo_BlancoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(608, 533)
        Me.Controls.Add(Me.BTN_CuentaProf)
        Me.Controls.Add(Me.BTN_VerPregunta)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.BTN_CerrarSesion)
        Me.Controls.Add(Me.BTN_RegresarPersonalizar)
        Me.Controls.Add(Me.BTN_VerCategorias)
        Me.Controls.Add(Me.BTN_VerTemas)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_PPersonalizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personalización"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTN_VerTemas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_VerCategorias As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarPersonalizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CerrarSesion As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_VerPregunta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_CuentaProf As Guna.UI2.WinForms.Guna2CircleButton
End Class
