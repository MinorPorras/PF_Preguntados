Public Class E_AActAdmin

    '-----------------------------------Función de los botones--------------------------------------
    Private Sub BTN_RegresarActAdmin_Click(sender As Object, e As EventArgs) Handles BTN_RegresarActAdmin.Click
        Me.Close()
    End Sub
    Private Sub BTN_GuardarProfNuevo_Click(sender As Object, e As EventArgs) Handles BTN_GuardarActAdmin.Click
        ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
        If MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                'Guarda la información en la db, limpia los datos en la textbox y le informa al usuario que todo salio bien
                GUARDAR_STR("Administradores", "Usuario", TXT_CUsuarioAdmin.Text, "ID", ID_cuenta)
                GUARDAR_STR("Administradores", "Clave", TXT_CClaveAdmin.Text, "ID", ID_cuenta)
                LIMPIAR()
                MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Trasacción exitosa")
                'Muestra y refresca la pantalla del list view de niveles y cierra esta
                P_ACuenta.Cargar_datos_Admin()
                P_ACuenta.Show()
                Me.Close()
            Catch ex As Exception
                MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End Try
        End If
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_CUsuarioAdmin.Clear()
        TXT_CClaveAdmin.Clear()
    End Sub


    '-----------------------Validación de que todos los campos estén llenos---------------------------------
    Friend Sub VALIDAR()
        'Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_CClaveAdmin.Text <> "" And TXT_CUsuarioAdmin.Text <> "" Then
            BTN_GuardarActAdmin.Enabled = True
        Else
            BTN_GuardarActAdmin.Enabled = False
        End If
    End Sub

    Private Sub TXT_CUsuarioAdmin_TextChanged(sender As Object, e As EventArgs) Handles TXT_CUsuarioAdmin.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_CClaveAdmin_TextChanged(sender As Object, e As EventArgs) Handles TXT_CClaveAdmin.TextChanged
        VALIDAR()
    End Sub

    Private Sub E_AActAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub E_AActAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_GuardarActAdmin.PerformClick()
        End If
    End Sub
End Class