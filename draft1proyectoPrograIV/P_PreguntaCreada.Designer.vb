<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_PreguntaCreada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_PreguntaCreada))
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LSV_Est = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Explicacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Correcta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ID_Categoria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Puntaje = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tiempo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AgregarEstNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.RegresarEstNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.Guna2TextBox1.BorderRadius = 50
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = "(PREGUNTA CREADA)"
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(271, 52)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(791, 144)
        Me.Guna2TextBox1.TabIndex = 67
        Me.Guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LSV_Est
        '
        Me.LSV_Est.BackColor = System.Drawing.Color.White
        Me.LSV_Est.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSV_Est.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Nombre, Me.Explicacion, Me.Correcta, Me.ID_Categoria, Me.Puntaje, Me.Tiempo})
        Me.LSV_Est.ForeColor = System.Drawing.Color.White
        Me.LSV_Est.GridLines = True
        Me.LSV_Est.HideSelection = False
        Me.LSV_Est.Location = New System.Drawing.Point(271, 235)
        Me.LSV_Est.Margin = New System.Windows.Forms.Padding(4)
        Me.LSV_Est.MultiSelect = False
        Me.LSV_Est.Name = "LSV_Est"
        Me.LSV_Est.Size = New System.Drawing.Size(796, 384)
        Me.LSV_Est.TabIndex = 66
        Me.LSV_Est.UseCompatibleStateImageBehavior = False
        Me.LSV_Est.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 95
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 118
        '
        'Explicacion
        '
        Me.Explicacion.Text = "Explicación"
        Me.Explicacion.Width = 158
        '
        'Correcta
        '
        Me.Correcta.DisplayIndex = 4
        Me.Correcta.Text = "Correcta"
        Me.Correcta.Width = 104
        '
        'ID_Categoria
        '
        Me.ID_Categoria.DisplayIndex = 3
        Me.ID_Categoria.Text = "ID Categoria"
        Me.ID_Categoria.Width = 118
        '
        'Puntaje
        '
        Me.Puntaje.Text = "Puntaje"
        Me.Puntaje.Width = 110
        '
        'Tiempo
        '
        Me.Tiempo.Text = "Tiempo"
        Me.Tiempo.Width = 97
        '
        'AgregarEstNuevo
        '
        Me.AgregarEstNuevo.BackColor = System.Drawing.Color.Transparent
        Me.AgregarEstNuevo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.AgregarEstNuevo.BorderRadius = 25
        Me.AgregarEstNuevo.BorderThickness = 2
        Me.AgregarEstNuevo.CustomBorderColor = System.Drawing.Color.White
        Me.AgregarEstNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AgregarEstNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AgregarEstNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AgregarEstNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AgregarEstNuevo.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.AgregarEstNuevo.Font = New System.Drawing.Font("Cooper Black", 14.25!)
        Me.AgregarEstNuevo.ForeColor = System.Drawing.Color.White
        Me.AgregarEstNuevo.Image = CType(resources.GetObject("AgregarEstNuevo.Image"), System.Drawing.Image)
        Me.AgregarEstNuevo.ImageSize = New System.Drawing.Size(30, 30)
        Me.AgregarEstNuevo.Location = New System.Drawing.Point(731, 655)
        Me.AgregarEstNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.AgregarEstNuevo.Name = "AgregarEstNuevo"
        Me.AgregarEstNuevo.Size = New System.Drawing.Size(336, 89)
        Me.AgregarEstNuevo.TabIndex = 65
        Me.AgregarEstNuevo.Text = "Crear Nueva Pregunta"
        '
        'RegresarEstNuevo
        '
        Me.RegresarEstNuevo.BackColor = System.Drawing.Color.Transparent
        Me.RegresarEstNuevo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.RegresarEstNuevo.BorderRadius = 25
        Me.RegresarEstNuevo.BorderThickness = 2
        Me.RegresarEstNuevo.CustomBorderColor = System.Drawing.Color.White
        Me.RegresarEstNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.RegresarEstNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.RegresarEstNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RegresarEstNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.RegresarEstNuevo.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.RegresarEstNuevo.Font = New System.Drawing.Font("Cooper Black", 14.25!)
        Me.RegresarEstNuevo.ForeColor = System.Drawing.Color.White
        Me.RegresarEstNuevo.Image = CType(resources.GetObject("RegresarEstNuevo.Image"), System.Drawing.Image)
        Me.RegresarEstNuevo.ImageSize = New System.Drawing.Size(30, 30)
        Me.RegresarEstNuevo.Location = New System.Drawing.Point(280, 655)
        Me.RegresarEstNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.RegresarEstNuevo.Name = "RegresarEstNuevo"
        Me.RegresarEstNuevo.Size = New System.Drawing.Size(339, 89)
        Me.RegresarEstNuevo.TabIndex = 64
        Me.RegresarEstNuevo.Text = "Regresar"
        '
        'P_FrmPreguntaCreada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1258, 770)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.LSV_Est)
        Me.Controls.Add(Me.AgregarEstNuevo)
        Me.Controls.Add(Me.RegresarEstNuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "P_FrmPreguntaCreada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "P_FrmPreguntaCreada"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LSV_Est As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents Explicacion As ColumnHeader
    Friend WithEvents Correcta As ColumnHeader
    Friend WithEvents ID_Categoria As ColumnHeader
    Friend WithEvents Puntaje As ColumnHeader
    Friend WithEvents Tiempo As ColumnHeader
    Friend WithEvents AgregarEstNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RegresarEstNuevo As Guna.UI2.WinForms.Guna2Button
End Class
