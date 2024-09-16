<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_Temas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_Temas))
        Me.LSV_Est = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Descripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ID_Nivel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AgregarEstNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.RegresarEstNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LSV_Est
        '
        Me.LSV_Est.BackColor = System.Drawing.Color.White
        Me.LSV_Est.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSV_Est.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Nombre, Me.Descripcion, Me.ID_Nivel})
        Me.LSV_Est.ForeColor = System.Drawing.Color.White
        Me.LSV_Est.GridLines = True
        Me.LSV_Est.HideSelection = False
        Me.LSV_Est.Location = New System.Drawing.Point(175, 231)
        Me.LSV_Est.Margin = New System.Windows.Forms.Padding(4)
        Me.LSV_Est.MultiSelect = False
        Me.LSV_Est.Name = "LSV_Est"
        Me.LSV_Est.Size = New System.Drawing.Size(809, 384)
        Me.LSV_Est.TabIndex = 60
        Me.LSV_Est.UseCompatibleStateImageBehavior = False
        Me.LSV_Est.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 137
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 174
        '
        'Descripcion
        '
        Me.Descripcion.Text = "Descripcion"
        Me.Descripcion.Width = 252
        '
        'ID_Nivel
        '
        Me.ID_Nivel.Text = "ID_Nivel"
        Me.ID_Nivel.Width = 317
        '
        'AgregarEstNuevo
        '
        Me.AgregarEstNuevo.BackColor = System.Drawing.Color.Transparent
        Me.AgregarEstNuevo.BorderColor = System.Drawing.Color.White
        Me.AgregarEstNuevo.BorderRadius = 25
        Me.AgregarEstNuevo.BorderThickness = 1
        Me.AgregarEstNuevo.CustomBorderColor = System.Drawing.Color.White
        Me.AgregarEstNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AgregarEstNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AgregarEstNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AgregarEstNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AgregarEstNuevo.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.AgregarEstNuevo.Font = New System.Drawing.Font("Cooper Black", 14.25!)
        Me.AgregarEstNuevo.ForeColor = System.Drawing.Color.White
        Me.AgregarEstNuevo.Image = CType(resources.GetObject("AgregarEstNuevo.Image"), System.Drawing.Image)
        Me.AgregarEstNuevo.ImageSize = New System.Drawing.Size(30, 30)
        Me.AgregarEstNuevo.Location = New System.Drawing.Point(622, 651)
        Me.AgregarEstNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.AgregarEstNuevo.Name = "AgregarEstNuevo"
        Me.AgregarEstNuevo.Size = New System.Drawing.Size(320, 89)
        Me.AgregarEstNuevo.TabIndex = 58
        Me.AgregarEstNuevo.Text = "Crear nuevo tema"
        '
        'RegresarEstNuevo
        '
        Me.RegresarEstNuevo.BackColor = System.Drawing.Color.Transparent
        Me.RegresarEstNuevo.BorderColor = System.Drawing.Color.White
        Me.RegresarEstNuevo.BorderRadius = 25
        Me.RegresarEstNuevo.BorderThickness = 1
        Me.RegresarEstNuevo.CustomBorderColor = System.Drawing.Color.White
        Me.RegresarEstNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.RegresarEstNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.RegresarEstNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RegresarEstNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.RegresarEstNuevo.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.RegresarEstNuevo.Font = New System.Drawing.Font("Cooper Black", 14.25!)
        Me.RegresarEstNuevo.ForeColor = System.Drawing.Color.White
        Me.RegresarEstNuevo.Image = CType(resources.GetObject("RegresarEstNuevo.Image"), System.Drawing.Image)
        Me.RegresarEstNuevo.ImageSize = New System.Drawing.Size(30, 30)
        Me.RegresarEstNuevo.Location = New System.Drawing.Point(233, 651)
        Me.RegresarEstNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.RegresarEstNuevo.Name = "RegresarEstNuevo"
        Me.RegresarEstNuevo.Size = New System.Drawing.Size(313, 89)
        Me.RegresarEstNuevo.TabIndex = 57
        Me.RegresarEstNuevo.Text = "Regresar"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(307, -94)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(524, 422)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 59
        Me.Guna2PictureBox1.TabStop = False
        '
        'P_FrmTemas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1124, 767)
        Me.Controls.Add(Me.LSV_Est)
        Me.Controls.Add(Me.AgregarEstNuevo)
        Me.Controls.Add(Me.RegresarEstNuevo)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "P_FrmTemas"
        Me.Text = "P_FrmTemas"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LSV_Est As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents Descripcion As ColumnHeader
    Friend WithEvents ID_Nivel As ColumnHeader
    Friend WithEvents AgregarEstNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RegresarEstNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
