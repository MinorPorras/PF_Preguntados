Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Class P_TInicialización
    Dim IdSU As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        ' Increment progress bar by 4
        progressBar1.Increment(30)
        label1.Text = progressBar1.Value.ToString() & "%"

        ' Si el progreso de la barra llega a su punto máximo, detiene el timer, oculta el form actual, y muestra el login
        If progressBar1.Value = progressBar1.Maximum Then
            timer1.Stop()
            P_TLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Inicialización_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarSU()
        Catch ex As Exception
            MsgBox("Error de carga de super usuario: " & vbCrLf & ex.ToString(), vbOKOnly + vbCritical, "Error")
        End Try
    End Sub

    Private Sub cargarSU()
        T.Tables.Clear()
        SQL = "SELECT ID FROM Administradores WHERE Usuario = 'SU' AND Clave = '17964';"
        Cargar_Tabla(T, SQL)

        If T.Tables(0).Rows.Count > 0 Then
            ' El usuario existe, No se crea el super usuario y continua normalmente con la app
        Else
            IdSU = OBTENERPK("Administradores", "ID")
            ' El usuario no existe, crea un nuevo registro
            SQL = "INSERT INTO Administradores VALUES (" & IdSU & ", 'SU', '17964', 1)"
            ' Ejecuta la consulta para insertar el nuevo usuario
            EJECUTAR(SQL)
        End If
    End Sub
End Class
