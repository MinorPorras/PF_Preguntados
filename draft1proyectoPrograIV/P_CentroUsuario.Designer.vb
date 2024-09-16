<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCentroUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCentroUsuario))
        Me.LSV_Est = New System.Windows.Forms.ListView()
        Me.CarnetEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellido1Est = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellido2Est = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombreEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UsuarioEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClaveEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.imagenEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CorreoEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SeccionEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaRegistroEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PeriodoEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EliminarEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ModificarEst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AgregarEst = New Guna.UI2.WinForms.Guna2Button()
        Me.RegresarEst = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LSV_Est
        '
        Me.LSV_Est.BackColor = System.Drawing.Color.White
        Me.LSV_Est.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSV_Est.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CarnetEst, Me.Apellido1Est, Me.Apellido2Est, Me.NombreEst, Me.UsuarioEst, Me.ClaveEst, Me.imagenEst, Me.CorreoEst, Me.SeccionEst, Me.FechaRegistroEst, Me.PeriodoEst, Me.EliminarEst, Me.ModificarEst})
        Me.LSV_Est.ForeColor = System.Drawing.Color.White
        Me.LSV_Est.GridLines = True
        Me.LSV_Est.HideSelection = False
        Me.LSV_Est.Location = New System.Drawing.Point(108, 161)
        Me.LSV_Est.MultiSelect = False
        Me.LSV_Est.Name = "LSV_Est"
        Me.LSV_Est.Size = New System.Drawing.Size(568, 312)
        Me.LSV_Est.TabIndex = 1
        Me.LSV_Est.UseCompatibleStateImageBehavior = False
        Me.LSV_Est.View = System.Windows.Forms.View.Details
        '
        'CarnetEst
        '
        Me.CarnetEst.Text = "Carnet"
        Me.CarnetEst.Width = 91
        '
        'Apellido1Est
        '
        Me.Apellido1Est.Text = "Apellido 1"
        Me.Apellido1Est.Width = 83
        '
        'Apellido2Est
        '
        Me.Apellido2Est.Text = "Apellido 2"
        Me.Apellido2Est.Width = 96
        '
        'NombreEst
        '
        Me.NombreEst.Text = "Nombre"
        Me.NombreEst.Width = 96
        '
        'UsuarioEst
        '
        Me.UsuarioEst.Text = "Usuario"
        Me.UsuarioEst.Width = 100
        '
        'ClaveEst
        '
        Me.ClaveEst.Text = "Clave"
        Me.ClaveEst.Width = 103
        '
        'imagenEst
        '
        Me.imagenEst.Text = "Imagen"
        Me.imagenEst.Width = 108
        '
        'CorreoEst
        '
        Me.CorreoEst.Text = "Correo"
        Me.CorreoEst.Width = 94
        '
        'SeccionEst
        '
        Me.SeccionEst.Text = "Sección"
        Me.SeccionEst.Width = 72
        '
        'FechaRegistroEst
        '
        Me.FechaRegistroEst.Text = "Fecha de registro"
        Me.FechaRegistroEst.Width = 105
        '
        'PeriodoEst
        '
        Me.PeriodoEst.Text = "Periodo"
        Me.PeriodoEst.Width = 53
        '
        'EliminarEst
        '
        Me.EliminarEst.Text = "Eliminar"
        '
        'ModificarEst
        '
        Me.ModificarEst.Text = "Modificar"
        '
        'AgregarEst
        '
        Me.AgregarEst.BackColor = System.Drawing.Color.Transparent
        Me.AgregarEst.BorderColor = System.Drawing.Color.White
        Me.AgregarEst.BorderRadius = 25
        Me.AgregarEst.BorderThickness = 1
        Me.AgregarEst.CustomBorderColor = System.Drawing.Color.White
        Me.AgregarEst.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AgregarEst.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AgregarEst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AgregarEst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AgregarEst.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.AgregarEst.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarEst.ForeColor = System.Drawing.Color.White
        Me.AgregarEst.Image = CType(resources.GetObject("AgregarEst.Image"), System.Drawing.Image)
        Me.AgregarEst.ImageSize = New System.Drawing.Size(30, 30)
        Me.AgregarEst.Location = New System.Drawing.Point(413, 491)
        Me.AgregarEst.Name = "AgregarEst"
        Me.AgregarEst.Size = New System.Drawing.Size(213, 66)
        Me.AgregarEst.TabIndex = 2
        Me.AgregarEst.Text = "Agregar"
        '
        'RegresarEst
        '
        Me.RegresarEst.BackColor = System.Drawing.Color.Transparent
        Me.RegresarEst.BorderColor = System.Drawing.Color.White
        Me.RegresarEst.BorderRadius = 25
        Me.RegresarEst.BorderThickness = 1
        Me.RegresarEst.CustomBorderColor = System.Drawing.Color.White
        Me.RegresarEst.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.RegresarEst.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.RegresarEst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RegresarEst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.RegresarEst.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.RegresarEst.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegresarEst.ForeColor = System.Drawing.Color.White
        Me.RegresarEst.Image = CType(resources.GetObject("RegresarEst.Image"), System.Drawing.Image)
        Me.RegresarEst.ImageSize = New System.Drawing.Size(30, 30)
        Me.RegresarEst.Location = New System.Drawing.Point(173, 491)
        Me.RegresarEst.Name = "RegresarEst"
        Me.RegresarEst.Size = New System.Drawing.Size(222, 66)
        Me.RegresarEst.TabIndex = 3
        Me.RegresarEst.Text = "Regresar"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(209, -62)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(375, 295)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 4
        Me.Guna2PictureBox1.TabStop = False
        '
        'FrmCentroUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(752, 569)
        Me.Controls.Add(Me.RegresarEst)
        Me.Controls.Add(Me.AgregarEst)
        Me.Controls.Add(Me.LSV_Est)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCentroUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centro de Usuario"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LSV_Est As ListView
    Friend WithEvents CarnetEst As ColumnHeader
    Friend WithEvents Apellido1Est As ColumnHeader
    Friend WithEvents Apellido2Est As ColumnHeader
    Friend WithEvents NombreEst As ColumnHeader
    Friend WithEvents UsuarioEst As ColumnHeader
    Friend WithEvents ClaveEst As ColumnHeader
    Friend WithEvents imagenEst As ColumnHeader
    Friend WithEvents CorreoEst As ColumnHeader
    Friend WithEvents SeccionEst As ColumnHeader
    Friend WithEvents FechaRegistroEst As ColumnHeader
    Friend WithEvents PeriodoEst As ColumnHeader
    Friend WithEvents EliminarEst As ColumnHeader
    Friend WithEvents ModificarEst As ColumnHeader
    Friend WithEvents AgregarEst As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RegresarEst As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
