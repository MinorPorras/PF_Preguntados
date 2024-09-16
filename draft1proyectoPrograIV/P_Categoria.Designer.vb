<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCategoria))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BTN_AGREGARCATEGORIA = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Agregar = New System.Windows.Forms.Label()
        Me.BTN_MODCATEGORIA = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Eliminar = New System.Windows.Forms.Label()
        Me.REGRESAR_MENU = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Regresar = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_AGREGARCATEGORIA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_MODCATEGORIA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGRESAR_MENU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(271, -98)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(462, 360)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'BTN_AGREGARCATEGORIA
        '
        Me.BTN_AGREGARCATEGORIA.BackColor = System.Drawing.Color.Transparent
        Me.BTN_AGREGARCATEGORIA.Image = CType(resources.GetObject("BTN_AGREGARCATEGORIA.Image"), System.Drawing.Image)
        Me.BTN_AGREGARCATEGORIA.ImageRotate = 0!
        Me.BTN_AGREGARCATEGORIA.Location = New System.Drawing.Point(130, 329)
        Me.BTN_AGREGARCATEGORIA.Name = "BTN_AGREGARCATEGORIA"
        Me.BTN_AGREGARCATEGORIA.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_AGREGARCATEGORIA.Size = New System.Drawing.Size(139, 125)
        Me.BTN_AGREGARCATEGORIA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_AGREGARCATEGORIA.TabIndex = 1
        Me.BTN_AGREGARCATEGORIA.TabStop = False
        Me.BTN_AGREGARCATEGORIA.UseTransparentBackground = True
        '
        'Agregar
        '
        Me.Agregar.AutoSize = True
        Me.Agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Agregar.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar.ForeColor = System.Drawing.Color.White
        Me.Agregar.Location = New System.Drawing.Point(153, 473)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(95, 23)
        Me.Agregar.TabIndex = 2
        Me.Agregar.Text = "Agregar"
        '
        'BTN_MODCATEGORIA
        '
        Me.BTN_MODCATEGORIA.BackColor = System.Drawing.Color.Transparent
        Me.BTN_MODCATEGORIA.Image = CType(resources.GetObject("BTN_MODCATEGORIA.Image"), System.Drawing.Image)
        Me.BTN_MODCATEGORIA.ImageRotate = 0!
        Me.BTN_MODCATEGORIA.Location = New System.Drawing.Point(407, 278)
        Me.BTN_MODCATEGORIA.Name = "BTN_MODCATEGORIA"
        Me.BTN_MODCATEGORIA.Size = New System.Drawing.Size(237, 224)
        Me.BTN_MODCATEGORIA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_MODCATEGORIA.TabIndex = 3
        Me.BTN_MODCATEGORIA.TabStop = False
        '
        'Eliminar
        '
        Me.Eliminar.AutoSize = True
        Me.Eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Eliminar.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar.ForeColor = System.Drawing.Color.White
        Me.Eliminar.Location = New System.Drawing.Point(472, 473)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(99, 23)
        Me.Eliminar.TabIndex = 4
        Me.Eliminar.Text = "Eliminar"
        '
        'REGRESAR_MENU
        '
        Me.REGRESAR_MENU.BackColor = System.Drawing.Color.Transparent
        Me.REGRESAR_MENU.Image = CType(resources.GetObject("REGRESAR_MENU.Image"), System.Drawing.Image)
        Me.REGRESAR_MENU.ImageRotate = 0!
        Me.REGRESAR_MENU.Location = New System.Drawing.Point(775, 313)
        Me.REGRESAR_MENU.Name = "REGRESAR_MENU"
        Me.REGRESAR_MENU.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.REGRESAR_MENU.Size = New System.Drawing.Size(141, 141)
        Me.REGRESAR_MENU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.REGRESAR_MENU.TabIndex = 5
        Me.REGRESAR_MENU.TabStop = False
        Me.REGRESAR_MENU.UseTransparentBackground = True
        '
        'Regresar
        '
        Me.Regresar.AutoSize = True
        Me.Regresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Regresar.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.Color.White
        Me.Regresar.Location = New System.Drawing.Point(797, 473)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(103, 23)
        Me.Regresar.TabIndex = 6
        Me.Regresar.Text = "Regresar"
        '
        'FrmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1022, 764)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.REGRESAR_MENU)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.BTN_MODCATEGORIA)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.BTN_AGREGARCATEGORIA)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCategoria"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_AGREGARCATEGORIA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_MODCATEGORIA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGRESAR_MENU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTN_AGREGARCATEGORIA As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Agregar As Label
    Friend WithEvents BTN_MODCATEGORIA As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Eliminar As Label
    Friend WithEvents REGRESAR_MENU As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Regresar As Label
End Class
