Public Class P_EPrincipal
    Private Sub P_EPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CerrarAPP_Click(sender As Object, e As EventArgs) Handles CerrarAPP.Click
        Dim resultado As MsgBoxResult
        resultado = MsgBox("¿Desea cerrar la aplicación?", vbOKCancel + vbQuestion, "Confirmar")

        If resultado = MsgBoxResult.Ok Then
            ' Cerramos la aplicación
            Application.Exit()
        End If
    End Sub

    Private Sub BTN_CerrarSesion_Click(sender As Object, e As EventArgs) Handles BTN_CerrarSesion.Click
        P_TLogin.Show()
        Me.Close()
    End Sub

    Private Sub BTN_CuentaProf_Click(sender As Object, e As EventArgs) Handles BTN_CuentaProf.Click
        P_ECuenta.Show()
    End Sub

    Private Sub BTN_Jugar_Click(sender As Object, e As EventArgs) Handles BTN_Jugar.Click
        P_EComenzarJuego.Show()
        Me.Close()
    End Sub

    Private Sub BTN_Resultados_Click(sender As Object, e As EventArgs) Handles BTN_Resultados.Click
        P_EReporteEst.Show()
        Me.Close()
    End Sub

    Private Sub P_EPrincipal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = "1"c Then
            BTN_Jugar.PerformClick()
        ElseIf e.KeyChar = "2"c Then
            BTN_Resultados.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class