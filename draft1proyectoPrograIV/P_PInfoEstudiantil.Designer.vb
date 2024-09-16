<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_PInfoEstudiantil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_PInfoEstudiantil))
        Me.BTN_RegresarCUsuario = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_VerEst = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BTN_VerNivel = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_VerSeccion = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_VerAsig = New Guna.UI2.WinForms.Guna2Button()
        Me.CerrarAPP = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_CerrarSesion = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_VerPeriodo = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_CuentaProf = New Guna.UI2.WinForms.Guna2CircleButton()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_RegresarCUsuario
        '
        Me.BTN_RegresarCUsuario.AutoRoundedCorners = True
        Me.BTN_RegresarCUsuario.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarCUsuario.BorderColor = System.Drawing.Color.White
        Me.BTN_RegresarCUsuario.BorderRadius = 30
        Me.BTN_RegresarCUsuario.BorderThickness = 1
        Me.BTN_RegresarCUsuario.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_RegresarCUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarCUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarCUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarCUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarCUsuario.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BTN_RegresarCUsuario.Font = New System.Drawing.Font("Showcard Gothic", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarCUsuario.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarCUsuario.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.ICO_Regresar
        Me.BTN_RegresarCUsuario.ImageSize = New System.Drawing.Size(50, 50)
        Me.BTN_RegresarCUsuario.Location = New System.Drawing.Point(60, 485)
        Me.BTN_RegresarCUsuario.Name = "BTN_RegresarCUsuario"
        Me.BTN_RegresarCUsuario.Size = New System.Drawing.Size(682, 62)
        Me.BTN_RegresarCUsuario.TabIndex = 80
        Me.BTN_RegresarCUsuario.Text = "Regresar"
        '
        'BTN_VerEst
        '
        Me.BTN_VerEst.AutoRoundedCorners = True
        Me.BTN_VerEst.BackColor = System.Drawing.Color.Transparent
        Me.BTN_VerEst.BorderColor = System.Drawing.Color.White
        Me.BTN_VerEst.BorderRadius = 30
        Me.BTN_VerEst.BorderThickness = 1
        Me.BTN_VerEst.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_VerEst.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VerEst.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VerEst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_VerEst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_VerEst.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_VerEst.Font = New System.Drawing.Font("Showcard Gothic", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VerEst.ForeColor = System.Drawing.Color.White
        Me.BTN_VerEst.ImageSize = New System.Drawing.Size(60, 70)
        Me.BTN_VerEst.Location = New System.Drawing.Point(60, 390)
        Me.BTN_VerEst.Name = "BTN_VerEst"
        Me.BTN_VerEst.Size = New System.Drawing.Size(682, 62)
        Me.BTN_VerEst.TabIndex = 79
        Me.BTN_VerEst.Text = "5. Estudiantes"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloInfoEstudiantil
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(179, -71)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(447, 358)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 77
        Me.Guna2PictureBox1.TabStop = False
        '
        'BTN_VerNivel
        '
        Me.BTN_VerNivel.AutoRoundedCorners = True
        Me.BTN_VerNivel.BackColor = System.Drawing.Color.Transparent
        Me.BTN_VerNivel.BorderColor = System.Drawing.Color.White
        Me.BTN_VerNivel.BorderRadius = 30
        Me.BTN_VerNivel.BorderThickness = 1
        Me.BTN_VerNivel.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_VerNivel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VerNivel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VerNivel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_VerNivel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_VerNivel.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_VerNivel.Font = New System.Drawing.Font("Showcard Gothic", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VerNivel.ForeColor = System.Drawing.Color.White
        Me.BTN_VerNivel.ImageSize = New System.Drawing.Size(60, 70)
        Me.BTN_VerNivel.Location = New System.Drawing.Point(60, 225)
        Me.BTN_VerNivel.Name = "BTN_VerNivel"
        Me.BTN_VerNivel.Size = New System.Drawing.Size(335, 62)
        Me.BTN_VerNivel.TabIndex = 85
        Me.BTN_VerNivel.Text = "1. Niveles"
        '
        'BTN_VerSeccion
        '
        Me.BTN_VerSeccion.AutoRoundedCorners = True
        Me.BTN_VerSeccion.BackColor = System.Drawing.Color.Transparent
        Me.BTN_VerSeccion.BorderColor = System.Drawing.Color.White
        Me.BTN_VerSeccion.BorderRadius = 30
        Me.BTN_VerSeccion.BorderThickness = 1
        Me.BTN_VerSeccion.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_VerSeccion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VerSeccion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VerSeccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_VerSeccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_VerSeccion.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_VerSeccion.Font = New System.Drawing.Font("Showcard Gothic", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VerSeccion.ForeColor = System.Drawing.Color.White
        Me.BTN_VerSeccion.ImageSize = New System.Drawing.Size(60, 70)
        Me.BTN_VerSeccion.Location = New System.Drawing.Point(407, 225)
        Me.BTN_VerSeccion.Name = "BTN_VerSeccion"
        Me.BTN_VerSeccion.Size = New System.Drawing.Size(335, 62)
        Me.BTN_VerSeccion.TabIndex = 86
        Me.BTN_VerSeccion.Text = "2. Secciones"
        '
        'BTN_VerAsig
        '
        Me.BTN_VerAsig.AutoRoundedCorners = True
        Me.BTN_VerAsig.BackColor = System.Drawing.Color.Transparent
        Me.BTN_VerAsig.BorderColor = System.Drawing.Color.White
        Me.BTN_VerAsig.BorderRadius = 30
        Me.BTN_VerAsig.BorderThickness = 1
        Me.BTN_VerAsig.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_VerAsig.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VerAsig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VerAsig.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_VerAsig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_VerAsig.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_VerAsig.Font = New System.Drawing.Font("Showcard Gothic", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VerAsig.ForeColor = System.Drawing.Color.White
        Me.BTN_VerAsig.ImageSize = New System.Drawing.Size(60, 70)
        Me.BTN_VerAsig.Location = New System.Drawing.Point(407, 306)
        Me.BTN_VerAsig.Name = "BTN_VerAsig"
        Me.BTN_VerAsig.Size = New System.Drawing.Size(335, 62)
        Me.BTN_VerAsig.TabIndex = 87
        Me.BTN_VerAsig.Text = "4. Asignaturas"
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
        Me.CerrarAPP.Location = New System.Drawing.Point(728, 19)
        Me.CerrarAPP.Name = "CerrarAPP"
        Me.CerrarAPP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarAPP.Size = New System.Drawing.Size(51, 51)
        Me.CerrarAPP.TabIndex = 89
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
        Me.BTN_CerrarSesion.Location = New System.Drawing.Point(728, 76)
        Me.BTN_CerrarSesion.Name = "BTN_CerrarSesion"
        Me.BTN_CerrarSesion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CerrarSesion.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CerrarSesion.TabIndex = 88
        '
        'BTN_VerPeriodo
        '
        Me.BTN_VerPeriodo.AutoRoundedCorners = True
        Me.BTN_VerPeriodo.BackColor = System.Drawing.Color.Transparent
        Me.BTN_VerPeriodo.BorderColor = System.Drawing.Color.White
        Me.BTN_VerPeriodo.BorderRadius = 30
        Me.BTN_VerPeriodo.BorderThickness = 1
        Me.BTN_VerPeriodo.CustomBorderColor = System.Drawing.Color.White
        Me.BTN_VerPeriodo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VerPeriodo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VerPeriodo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_VerPeriodo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_VerPeriodo.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTN_VerPeriodo.Font = New System.Drawing.Font("Showcard Gothic", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VerPeriodo.ForeColor = System.Drawing.Color.White
        Me.BTN_VerPeriodo.ImageSize = New System.Drawing.Size(60, 70)
        Me.BTN_VerPeriodo.Location = New System.Drawing.Point(60, 306)
        Me.BTN_VerPeriodo.Name = "BTN_VerPeriodo"
        Me.BTN_VerPeriodo.Size = New System.Drawing.Size(335, 62)
        Me.BTN_VerPeriodo.TabIndex = 90
        Me.BTN_VerPeriodo.Text = "3. Periodos"
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
        Me.BTN_CuentaProf.Location = New System.Drawing.Point(728, 130)
        Me.BTN_CuentaProf.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CuentaProf.Name = "BTN_CuentaProf"
        Me.BTN_CuentaProf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_CuentaProf.Size = New System.Drawing.Size(51, 51)
        Me.BTN_CuentaProf.TabIndex = 91
        '
        'P_PInfoEstudiantil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.Fondo_BlancoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 591)
        Me.Controls.Add(Me.BTN_CuentaProf)
        Me.Controls.Add(Me.BTN_VerPeriodo)
        Me.Controls.Add(Me.CerrarAPP)
        Me.Controls.Add(Me.BTN_CerrarSesion)
        Me.Controls.Add(Me.BTN_VerAsig)
        Me.Controls.Add(Me.BTN_VerSeccion)
        Me.Controls.Add(Me.BTN_VerNivel)
        Me.Controls.Add(Me.BTN_RegresarCUsuario)
        Me.Controls.Add(Me.BTN_VerEst)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_PInfoEstudiantil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información estudiantil"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_RegresarCUsuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_VerEst As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTN_VerNivel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_VerSeccion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_VerAsig As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CerrarAPP As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_CerrarSesion As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_VerPeriodo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_CuentaProf As Guna.UI2.WinForms.Guna2CircleButton
End Class
