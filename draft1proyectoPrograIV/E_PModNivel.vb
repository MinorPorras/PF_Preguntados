Public Class E_PModNivel

    Public IdNivel As Integer

    '-----------------------------------Función de los botones--------------------------------------
    Private Sub BTN_GuardarModNivel_Click(sender As Object, e As EventArgs) Handles BTN_AgregarModNivel.Click
        ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
        If MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                'Guarda la información en la db, limpia los datos en la textbox y le informa al usuario que todo salio bien
                GUARDAR_STR("Nivel", "Nombre", TXT_NombreModNivel.Text, "ID", IdNivel)
                LIMPIAR()
                MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Trasacción exitosa")
                'Muestra y refresca la pantalla del list view de niveles y cierra esta
                P_PNivel.Show()
                P_PNivel.REFRESCAR()
                Me.Close()
            Catch ex As Exception
                MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End Try
        End If
    End Sub
    Private Sub BTN_RegresarModNivel_Click(sender As Object, e As EventArgs) Handles BTNRegresaModNivel.Click
        P_PNivel.Show()
        Me.Close()
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_NombreModNivel.Clear()
    End Sub

    '-----------------------Validación de que todos los campos estén llenos---------------------------------
    Friend Sub VALIDAR()
        'Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_NombreModNivel.Text <> "" Then
            BTN_AgregarModNivel.Enabled = True
        Else
            BTN_AgregarModNivel.Enabled = False
        End If
    End Sub

    Private Sub TXT_NombreModNivel_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreModNivel.TextChanged
        VALIDAR()
    End Sub

    Private Sub E_PModNivel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarModNivel.PerformClick()
        End If
    End Sub

    Private Sub E_PModNivel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
