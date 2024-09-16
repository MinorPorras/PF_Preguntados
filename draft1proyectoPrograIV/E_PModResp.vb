Public Class E_PModResp
    Public IdPreg As Integer
    Public IdResp As Integer
    '--------------------------------------Metodo cargar--------------------------------------------
    Private Sub E_PModResp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_ModResp.Focus()
    End Sub

    '-----------------------------------Función de los botones--------------------------------------
    Private Sub BTN_AgregarModResp_Click(sender As Object, e As EventArgs) Handles BTN_AgregarModResp.Click
        Try
            If MessageBox.Show("Desea guardar esta información", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If CKB_Correcta.Checked = True Then
                    T.Tables.Clear()
                    SQL = "SELECT Correcta FROM Respuestas WHERE ID_Pregunta = " & IdPreg
                    Cargar_Tabla(T, SQL)
                    For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                        If T.Tables(0).Rows(i).Item(0) = 0 Then

                        Else
                            MsgBox("Esta pregunta ya tiene una respuesta correcta, si desea cambiar la respuesta correcta de la pregunta favor editar la respuesta correcta actual", vbOKOnly + vbCritical, "Conflicto entre respuestas correctas")
                            CKB_Correcta.Checked = False
                            Return
                        End If
                    Next
                    guardarDatos(1)
                Else
                    guardarDatos(0)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al guardar la respuestas" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub BTN_RegresarModResp_Click(sender As Object, e As EventArgs) Handles BTN_RegresarModResp.Click
        P_PRespuestas.Show()
        Me.Close()
    End Sub

    '----------------------------------Guardado de datos-----------------------------------------------------------
    Private Sub guardarDatos(ByVal idCorrecta As Integer)
        'Guarda la información en la db, limpia los datos en la textbox y le informa al usuario que todo salio bien
        GUARDAR_STR("Respuestas", "Texto", TXT_ModResp.Text, "ID", IdResp)
        GUARDAR_INT("Respuestas", "ID_Pregunta", IdPreg, "ID", IdResp)
        GUARDAR_INT("Respuestas", "Correcta", idCorrecta, "ID", IdResp)
        LIMPIAR()
        MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Trasacción exitosa")
        'Muestra y refresca la pantalla del list view de niveles y cierra esta
        P_PRespuestas.Show()
        P_PRespuestas.REFRESCAR()
        Me.Close()
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_ModResp.Clear()
        TXT_PregModResp.Clear()
        CKB_Correcta.Checked = False
    End Sub

    '-----------------------Validación de que todos los campos estén llenos---------------------------------
    Friend Sub VALIDAR()
        'Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_ModResp.Text <> "" And IdPreg <> 0 Then
            BTN_AgregarModResp.Enabled = True
        Else
            BTN_AgregarModResp.Enabled = False
        End If
    End Sub

    Private Sub TXT_ModResp_TextChanged(sender As Object, e As EventArgs) Handles TXT_ModResp.TextChanged
        VALIDAR()
    End Sub

    Private Sub E_PModResp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarModResp.PerformClick()
        End If
    End Sub
End Class