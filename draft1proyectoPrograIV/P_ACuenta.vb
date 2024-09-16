Public Class P_ACuenta
    '----------------------------Metodo cargar-----------------------------------------
    Private Sub P_ACuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_datos_Admin()
    End Sub
    Public Sub Cargar_datos_Admin()
        Try
            T.Tables.Clear()
            SQL = "SELECT * FROM Administradores WHERE ID = " & ID_cuenta
            Cargar_Tabla(T, SQL)
            TXT_CUsuarioAdmin.Text = T.Tables(0).Rows(0).Item(1)
            TXT_CClaveAdmin.Text = T.Tables(0).Rows(0).Item(2)
        Catch ex As Exception
            MsgBox("Error al cargar los datos de la cuenta" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    '---------------------------------Funciones de los botones---------------------------------------------
    Private Sub CerrarAPP_Click(sender As Object, e As EventArgs) Handles CerrarAPP.Click
        Dim resultado As MsgBoxResult
        resultado = MsgBox("¿Desea cerrar la aplicación?", vbOKCancel + vbQuestion, "Confirmar")

        If resultado = MsgBoxResult.Ok Then
            ' Cerramos la aplicación
            Application.Exit()
        End If
    End Sub

    Private Sub BTN_CerrarSesion_Click(sender As Object, e As EventArgs)
        P_TLogin.Show()
        Me.Close()
    End Sub


    Private Sub BTN_RegresarCuentaAdmin_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCuentaAdmin.Click
        Me.Close()
    End Sub

    Private Sub BTN_ActAdmin_Click(sender As Object, e As EventArgs) Handles BTN_ActAdmin.Click
        Try
            E_AActAdmin.TXT_CUsuarioAdmin.Text = TXT_CUsuarioAdmin.Text
            E_AActAdmin.TXT_CClaveAdmin.Text = TXT_CClaveAdmin.Text
            E_AActAdmin.Show()
        Catch ex As Exception
            MsgBox("Error al cargar los datos del administrador" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub P_ACuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_ActAdmin.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class