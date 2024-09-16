Public Class E_PModPeriodo
    Public IdPeriodo As Integer
    '-----------------------------------Función de los botones--------------------------------------
    Private Sub BTN_AgregarModPeriodo_Click(sender As Object, e As EventArgs) Handles BTN_AgregarModPeriodo.Click
        ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
        If MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                ' Actualizar los campos en la base de datos
                'Guarda la información en la db, limpia los datos en la textbox y le informa al usuario que todo salio bien
                GUARDAR_STR("Periodo", "Nombre", TXT_NombreModPeriodo.Text, "ID", IdPeriodo)
                LIMPIAR()
                MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Trasacción exitosa")
                'Muestra y refresca la pantalla del list view de niveles y cierra esta
                P_PPeriodo.Show()
                P_PPeriodo.REFRESCAR()
                Me.Close()
            Catch ex As Exception
                MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End Try
        End If
    End Sub

    Private Sub BTNRegresarModPeriodo_Click(sender As Object, e As EventArgs) Handles BTNRegresarModPeriodo.Click
        P_PPeriodo.Show()
        Me.Close()
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_NombreModPeriodo.Clear()
    End Sub

    '-----------------------Validación de que todos los campos estén llenos---------------------------------
    Friend Sub VALIDAR()
        'Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_NombreModPeriodo.Text <> "" Then
            BTN_AgregarModPeriodo.Enabled = True
        Else
            BTN_AgregarModPeriodo.Enabled = False
        End If
    End Sub

    Private Sub TXT_NombreModPeriodo_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreModPeriodo.TextChanged
        VALIDAR()
    End Sub

    Private Sub E_PModPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub E_PModPeriodo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarModPeriodo.PerformClick()
        End If
    End Sub
End Class