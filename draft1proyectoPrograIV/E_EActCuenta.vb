Public Class E_EActCuenta
    Public IdEst
    Private Sub BTN_RegresarActAdmin_Click(sender As Object, e As EventArgs) Handles BTN_RegresarActAdmin.Click
        P_ECuenta.Show()
        Me.Close()
    End Sub

    Private Sub BTN_GuardarActAdmin_Click(sender As Object, e As EventArgs) Handles BTN_GuardarActAdmin.Click
        Try
            If MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                GUARDAR_STR("Estudiante", "Usuario", TXT_ActUsuarioEst.Text, "ID", IdEst)
                GUARDAR_STR("Estudiante", "Clave", TXT_ActClaveEst.Text, "ID", IdEst)
                P_ECuenta.Show()
                P_ECuenta.cargar_datos_Est()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub E_EActCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub E_EActCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_GuardarActAdmin.PerformClick()
        End If
    End Sub
End Class