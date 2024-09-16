Public Class P_PInfoEstudiantil
    '---------------------------------Funciones de los botones---------------------------------------------
    Private Sub BTN_VerEst_Click(sender As Object, e As EventArgs) Handles BTN_VerEst.Click
        P_PUsuariosEst.Show()
        Me.Close()
    End Sub

    Private Sub BTN_VerProf_Click(sender As Object, e As EventArgs)
        P_AUsuariosProf.Show()
        Me.Close()
    End Sub

    Private Sub BTN_VerNivel_Click(sender As Object, e As EventArgs) Handles BTN_VerNivel.Click
        P_PNivel.Show()
        Me.Close()
    End Sub

    Private Sub BTN_VerAsig_Click(sender As Object, e As EventArgs) Handles BTN_VerAsig.Click
        P_PAsignatura.Show()
        Me.Close()
    End Sub

    Private Sub BTN_VerSeccion_Click(sender As Object, e As EventArgs) Handles BTN_VerSeccion.Click
        P_PSeccion.Show()
        Me.Close()
    End Sub

    Private Sub BTN_RegresarCUsuario_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCUsuario.Click
        P_PPrincipal.Show()
        Me.Close()
    End Sub
    Private Sub BTN_VerPeriodo_Click(sender As Object, e As EventArgs) Handles BTN_VerPeriodo.Click
        P_PPeriodo.Show()
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

    Private Sub BTN_CuentaProf_Click(sender As Object, e As EventArgs) Handles BTN_CuentaProf.Click
        P_PCuenta.Show()
    End Sub

    Private Sub P_PInfoEstudiantil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub P_PInfoEstudiantil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = "1"c Then
            BTN_VerNivel.PerformClick()
        ElseIf e.KeyChar = "2"c Then
            BTN_VerSeccion.PerformClick()
        ElseIf e.KeyChar = "3"c Then
            BTN_VerPeriodo.PerformClick()
        ElseIf e.KeyChar = "4"c Then
            BTN_VerAsig.PerformClick()
        ElseIf e.KeyChar = "5"c Then
            BTN_VerEst.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class