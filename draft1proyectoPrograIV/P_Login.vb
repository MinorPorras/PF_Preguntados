Public Class FrmLogin
    Private Sub CerrarAPP_Click(sender As Object, e As EventArgs) Handles CerrarAPP.Click
        If MessageBox.Show("Desea cerrar la aplicación", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ' Cerramos la aplicación
            Application.Exit()
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class