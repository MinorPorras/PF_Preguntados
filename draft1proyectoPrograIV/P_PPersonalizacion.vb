Public Class P_PPersonalizacion

    '---------------------------------Funciones de los botones---------------------------------------------
    Private Sub BTN_VerTemas_Click(sender As Object, e As EventArgs) Handles BTN_VerTemas.Click
        P_PTemas.Show()
        Me.Close()
    End Sub

    Private Sub BTN_VerCategorias_Click(sender As Object, e As EventArgs) Handles BTN_VerCategorias.Click
        P_PCategoria.Show()
        Me.Close()
    End Sub

    Private Sub BTN_RegresarPersonalizar_Click(sender As Object, e As EventArgs) Handles BTN_RegresarPersonalizar.Click
        P_PPrincipal.Show()
        Me.Close()
    End Sub
    Private Sub BTN_CerrarSesion_Click(sender As Object, e As EventArgs) Handles BTN_CerrarSesion.Click
        P_TLogin.Show()
        Me.Close()
    End Sub

    Private Sub CerrarAPP_Click(sender As Object, e As EventArgs) Handles CerrarAPP.Click
        Dim resultado As MsgBoxResult
        resultado = MsgBox("¿Desea cerrar la aplicación?", vbOKCancel + vbQuestion, "Confirmar")

        If resultado = MsgBoxResult.Ok Then
            ' Cerramos la aplicación
            Application.Exit()
        End If
    End Sub

    Private Sub BTN_VerPregunta_Click(sender As Object, e As EventArgs) Handles BTN_VerPregunta.Click
        P_PPreguntas.Show()
        Me.Close()
    End Sub

    Private Sub BTN_CuentaProf_Click(sender As Object, e As EventArgs) Handles BTN_CuentaProf.Click
        P_PCuenta.Show()
    End Sub

    Private Sub P_PPersonalizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub P_PPersonalizacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = "1"c Then
            BTN_VerTemas.PerformClick()
        ElseIf e.KeyChar = "2"c Then
            BTN_VerCategorias.PerformClick()
        ElseIf e.KeyChar = "3"c Then
            BTN_VerPregunta.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        Else
        End If
    End Sub
End Class