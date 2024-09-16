<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_PGenerandoInforme
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_PGenerandoInforme))
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.timer_informe = New System.Windows.Forms.Timer(Me.components)
        Me.PGI_GenRep = New Guna.UI2.WinForms.Guna2ProgressIndicator()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.Image = Global.draft1proyectoPrograIV.My.Resources.Resources.tituloGenReporte
        Me.pictureBox1.Location = New System.Drawing.Point(26, -59)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(468, 370)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 8
        Me.pictureBox1.TabStop = False
        '
        'timer_informe
        '
        Me.timer_informe.Enabled = True
        Me.timer_informe.Interval = 1000
        '
        'PGI_GenRep
        '
        Me.PGI_GenRep.BackColor = System.Drawing.Color.Transparent
        Me.PGI_GenRep.Location = New System.Drawing.Point(206, 223)
        Me.PGI_GenRep.Name = "PGI_GenRep"
        Me.PGI_GenRep.ProgressColor = System.Drawing.Color.White
        Me.PGI_GenRep.Size = New System.Drawing.Size(113, 116)
        Me.PGI_GenRep.TabIndex = 9
        '
        'P_PGenerandoInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.draft1proyectoPrograIV.My.Resources.Resources.FondoAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(519, 363)
        Me.Controls.Add(Me.PGI_GenRep)
        Me.Controls.Add(Me.pictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_PGenerandoInforme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generando informe"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents timer_informe As Timer
    Friend WithEvents PGI_GenRep As Guna.UI2.WinForms.Guna2ProgressIndicator
End Class
