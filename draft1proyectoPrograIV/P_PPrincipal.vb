Public Class P_PPrincipal
    '---------------------------------Funciones de los botones---------------------------------------------
    Private Sub BTN_CerrarSesion_Click(sender As Object, e As EventArgs) Handles BTN_CerrarSesion.Click
        CProf = False
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

    Private Sub BTN_PCentroUsuario_Click(sender As Object, e As EventArgs) Handles BTN_PCentroUsuario.Click
        P_PInfoEstudiantil.Show()
        Me.Close()
    End Sub

    Private Sub BTN_PPerTemas_Click(sender As Object, e As EventArgs) Handles BTN_PPerTemas.Click
        P_PPersonalizacion.Show()
        Me.Close()
    End Sub

    Private Sub BTN_PReporte_Click(sender As Object, e As EventArgs) Handles BTN_PReporte.Click
        P_PReportesPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub BTN_CuentaProf_Click(sender As Object, e As EventArgs) Handles BTN_CuentaProf.Click
        P_PCuenta.Show()
    End Sub

    Private Sub P_PPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub P_PPrincipal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = "1"c Then
            BTN_PCentroUsuario.PerformClick()
        ElseIf e.KeyChar = "2"c Then
            BTN_PPerTemas.PerformClick()
        ElseIf e.KeyChar = "3"c Then
            BTN_PReporte.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class