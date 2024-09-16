<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreacionUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreacionUsuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXT_Carnet = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_Ape1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_Ape2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_Nombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_Seccion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_Correo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_Clave = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_Usuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_Periodo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AgregarEstNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.RegresarEstNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(81, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Carnet:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(53, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido 1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(53, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Apellido 2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(72, 343)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nombre:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(430, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Clave:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(416, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Imagen:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(417, 343)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 19)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Correo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(76, 391)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 19)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Sección:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(411, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 19)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Periodo:"
        '
        'TXT_Carnet
        '
        Me.TXT_Carnet.AutoSize = True
        Me.TXT_Carnet.BackColor = System.Drawing.Color.Transparent
        Me.TXT_Carnet.BorderColor = System.Drawing.Color.Transparent
        Me.TXT_Carnet.BorderRadius = 25
        Me.TXT_Carnet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Carnet.DefaultText = ""
        Me.TXT_Carnet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Carnet.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Carnet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Carnet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Carnet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Carnet.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Carnet.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Carnet.Location = New System.Drawing.Point(162, 165)
        Me.TXT_Carnet.Name = "TXT_Carnet"
        Me.TXT_Carnet.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Carnet.PlaceholderText = ""
        Me.TXT_Carnet.SelectedText = ""
        Me.TXT_Carnet.Size = New System.Drawing.Size(200, 47)
        Me.TXT_Carnet.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(409, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 19)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Usuario:"
        '
        'TXT_Ape1
        '
        Me.TXT_Ape1.AutoSize = True
        Me.TXT_Ape1.BackColor = System.Drawing.Color.Transparent
        Me.TXT_Ape1.BorderColor = System.Drawing.Color.Transparent
        Me.TXT_Ape1.BorderRadius = 25
        Me.TXT_Ape1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Ape1.DefaultText = ""
        Me.TXT_Ape1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Ape1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Ape1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Ape1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Ape1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Ape1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Ape1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Ape1.Location = New System.Drawing.Point(162, 218)
        Me.TXT_Ape1.Name = "TXT_Ape1"
        Me.TXT_Ape1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Ape1.PlaceholderText = ""
        Me.TXT_Ape1.SelectedText = ""
        Me.TXT_Ape1.Size = New System.Drawing.Size(200, 47)
        Me.TXT_Ape1.TabIndex = 14
        '
        'TXT_Ape2
        '
        Me.TXT_Ape2.AutoSize = True
        Me.TXT_Ape2.BackColor = System.Drawing.Color.Transparent
        Me.TXT_Ape2.BorderColor = System.Drawing.Color.Transparent
        Me.TXT_Ape2.BorderRadius = 25
        Me.TXT_Ape2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Ape2.DefaultText = ""
        Me.TXT_Ape2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Ape2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Ape2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Ape2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Ape2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Ape2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Ape2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Ape2.Location = New System.Drawing.Point(162, 271)
        Me.TXT_Ape2.Name = "TXT_Ape2"
        Me.TXT_Ape2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Ape2.PlaceholderText = ""
        Me.TXT_Ape2.SelectedText = ""
        Me.TXT_Ape2.Size = New System.Drawing.Size(200, 47)
        Me.TXT_Ape2.TabIndex = 15
        '
        'TXT_Nombre
        '
        Me.TXT_Nombre.AutoSize = True
        Me.TXT_Nombre.BackColor = System.Drawing.Color.Transparent
        Me.TXT_Nombre.BorderColor = System.Drawing.Color.Transparent
        Me.TXT_Nombre.BorderRadius = 25
        Me.TXT_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Nombre.DefaultText = ""
        Me.TXT_Nombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Nombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Nombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Nombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Nombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Nombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Nombre.Location = New System.Drawing.Point(162, 324)
        Me.TXT_Nombre.Name = "TXT_Nombre"
        Me.TXT_Nombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Nombre.PlaceholderText = ""
        Me.TXT_Nombre.SelectedText = ""
        Me.TXT_Nombre.Size = New System.Drawing.Size(200, 47)
        Me.TXT_Nombre.TabIndex = 16
        '
        'TXT_Seccion
        '
        Me.TXT_Seccion.AutoSize = True
        Me.TXT_Seccion.BackColor = System.Drawing.Color.Transparent
        Me.TXT_Seccion.BorderColor = System.Drawing.Color.Transparent
        Me.TXT_Seccion.BorderRadius = 25
        Me.TXT_Seccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Seccion.DefaultText = ""
        Me.TXT_Seccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Seccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Seccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Seccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Seccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Seccion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Seccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Seccion.Location = New System.Drawing.Point(162, 377)
        Me.TXT_Seccion.Name = "TXT_Seccion"
        Me.TXT_Seccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Seccion.PlaceholderText = ""
        Me.TXT_Seccion.SelectedText = ""
        Me.TXT_Seccion.Size = New System.Drawing.Size(200, 47)
        Me.TXT_Seccion.TabIndex = 17
        '
        'TXT_Correo
        '
        Me.TXT_Correo.AutoSize = True
        Me.TXT_Correo.BackColor = System.Drawing.Color.Transparent
        Me.TXT_Correo.BorderColor = System.Drawing.Color.Transparent
        Me.TXT_Correo.BorderRadius = 25
        Me.TXT_Correo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Correo.DefaultText = ""
        Me.TXT_Correo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Correo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Correo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Correo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Correo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Correo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Correo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Correo.Location = New System.Drawing.Point(495, 324)
        Me.TXT_Correo.Name = "TXT_Correo"
        Me.TXT_Correo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Correo.PlaceholderText = ""
        Me.TXT_Correo.SelectedText = ""
        Me.TXT_Correo.Size = New System.Drawing.Size(200, 47)
        Me.TXT_Correo.TabIndex = 21
        '
        'TXT_Clave
        '
        Me.TXT_Clave.AutoSize = True
        Me.TXT_Clave.BackColor = System.Drawing.Color.Transparent
        Me.TXT_Clave.BorderColor = System.Drawing.Color.Transparent
        Me.TXT_Clave.BorderRadius = 25
        Me.TXT_Clave.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Clave.DefaultText = ""
        Me.TXT_Clave.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Clave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Clave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Clave.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Clave.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Clave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Clave.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Clave.Location = New System.Drawing.Point(495, 271)
        Me.TXT_Clave.Name = "TXT_Clave"
        Me.TXT_Clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Clave.PlaceholderText = ""
        Me.TXT_Clave.SelectedText = ""
        Me.TXT_Clave.Size = New System.Drawing.Size(200, 47)
        Me.TXT_Clave.TabIndex = 20
        '
        'TXT_Usuario
        '
        Me.TXT_Usuario.AutoSize = True
        Me.TXT_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.TXT_Usuario.BorderColor = System.Drawing.Color.Transparent
        Me.TXT_Usuario.BorderRadius = 25
        Me.TXT_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Usuario.DefaultText = ""
        Me.TXT_Usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Usuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Usuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Usuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Usuario.Location = New System.Drawing.Point(495, 218)
        Me.TXT_Usuario.Name = "TXT_Usuario"
        Me.TXT_Usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Usuario.PlaceholderText = ""
        Me.TXT_Usuario.SelectedText = ""
        Me.TXT_Usuario.Size = New System.Drawing.Size(200, 47)
        Me.TXT_Usuario.TabIndex = 19
        '
        'TXT_Periodo
        '
        Me.TXT_Periodo.AutoSize = True
        Me.TXT_Periodo.BackColor = System.Drawing.Color.Transparent
        Me.TXT_Periodo.BorderColor = System.Drawing.Color.Transparent
        Me.TXT_Periodo.BorderRadius = 25
        Me.TXT_Periodo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Periodo.DefaultText = ""
        Me.TXT_Periodo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Periodo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Periodo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Periodo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Periodo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Periodo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Periodo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Periodo.Location = New System.Drawing.Point(495, 165)
        Me.TXT_Periodo.Name = "TXT_Periodo"
        Me.TXT_Periodo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Periodo.PlaceholderText = ""
        Me.TXT_Periodo.SelectedText = ""
        Me.TXT_Periodo.Size = New System.Drawing.Size(200, 47)
        Me.TXT_Periodo.TabIndex = 18
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
        Me.AgregarEstNuevo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarEstNuevo.ForeColor = System.Drawing.Color.White
        Me.AgregarEstNuevo.Image = CType(resources.GetObject("AgregarEstNuevo.Image"), System.Drawing.Image)
        Me.AgregarEstNuevo.ImageSize = New System.Drawing.Size(30, 30)
        Me.AgregarEstNuevo.Location = New System.Drawing.Point(421, 499)
        Me.AgregarEstNuevo.Name = "AgregarEstNuevo"
        Me.AgregarEstNuevo.Size = New System.Drawing.Size(213, 66)
        Me.AgregarEstNuevo.TabIndex = 23
        Me.AgregarEstNuevo.Text = "Agregar"
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
        Me.RegresarEstNuevo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegresarEstNuevo.ForeColor = System.Drawing.Color.White
        Me.RegresarEstNuevo.Image = CType(resources.GetObject("RegresarEstNuevo.Image"), System.Drawing.Image)
        Me.RegresarEstNuevo.ImageSize = New System.Drawing.Size(30, 30)
        Me.RegresarEstNuevo.Location = New System.Drawing.Point(193, 499)
        Me.RegresarEstNuevo.Name = "RegresarEstNuevo"
        Me.RegresarEstNuevo.Size = New System.Drawing.Size(222, 66)
        Me.RegresarEstNuevo.TabIndex = 24
        Me.RegresarEstNuevo.Text = "Regresar"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.White
        Me.Guna2Button1.BorderRadius = 25
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button1.Location = New System.Drawing.Point(495, 377)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(200, 47)
        Me.Guna2Button1.TabIndex = 25
        Me.Guna2Button1.Text = "Buscar"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(198, -89)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(393, 343)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 26
        Me.Guna2PictureBox1.TabStop = False
        '
        'CreacionUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(752, 602)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.RegresarEstNuevo)
        Me.Controls.Add(Me.AgregarEstNuevo)
        Me.Controls.Add(Me.TXT_Correo)
        Me.Controls.Add(Me.TXT_Clave)
        Me.Controls.Add(Me.TXT_Usuario)
        Me.Controls.Add(Me.TXT_Periodo)
        Me.Controls.Add(Me.TXT_Seccion)
        Me.Controls.Add(Me.TXT_Nombre)
        Me.Controls.Add(Me.TXT_Ape2)
        Me.Controls.Add(Me.TXT_Ape1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXT_Carnet)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreacionUsuario"
        Me.Text = "CrearUsuario"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TXT_Carnet As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TXT_Ape1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_Ape2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_Nombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_Seccion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_Correo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_Clave As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_Usuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_Periodo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AgregarEstNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RegresarEstNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
