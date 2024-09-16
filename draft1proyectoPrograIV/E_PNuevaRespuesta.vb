Public Class E_PNuevaRespuesta
    Public IdPreg As Integer
    Dim IdResp As Integer

    '--------------------------------------Metodo cargar--------------------------------------------
    Private Sub E_PNuevaRespuesta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_NResp.Focus()
        IdResp = OBTENERPK("Respuestas", "ID")
    End Sub
    '-----------------------------------Función de los botones--------------------------------------
    Private Sub BTN_AgregarNResp_Click(sender As Object, e As EventArgs) Handles BTN_AgregarNResp.Click
        Try
            'Comprobación de que se quiere agregar la información a la base de datos por parte del usuario
            T.Tables.Clear()
            SQL = "SELECT COUNT(ID) FROM Respuestas WHERE ID_Pregunta = " & IdPreg
            Cargar_Tabla(T, SQL)
            Dim cont As Integer = CInt(T.Tables(0).Rows(0).Item(0))
            If cont < 4 Then
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
                                Exit Sub
                            End If
                        Next
                        guardarDatos(1)
                    Else
                        guardarDatos(0)
                    End If
                End If
            Else
                MsgBox("Las preguntas pueden tener un máximo de 4 respuestas, si desea agregar otra, debe de eliminar una de las existentes", vbOKOnly + vbCritical, "Demasiadas respuestas")
            End If
        Catch ex As Exception
            MsgBox("Error al guardar la nueva respuesta" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub BTN_RegresarNResp_Click(sender As Object, e As EventArgs) Handles BTN_RegresarNResp.Click
        P_PRespuestas.Show()
        Me.Close()
    End Sub

    '----------------------------------Guardado de datos-----------------------------------------------------------
    Private Sub guardarDatos(ByVal idCorrecta As Integer)
        'Si la PK que esté guardada en IdCat no existe en la base de datos en ese tabla...
        If EXISTEPK("Respuestas", "ID", IdResp) = False Then 'Si no se ha guardado la categoría
            'Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
            GUARDAR_PK("Respuestas", "ID", IdResp)
        End If
        'Guarda la información en la db, limpia los datos en la textbox y le informa al usuario que todo salio bien
        GUARDAR_STR("Respuestas", "Texto", TXT_NResp.Text, "ID", IdResp)
        GUARDAR_INT("Respuestas", "ID_Pregunta", IdPreg, "ID", IdResp)
        GUARDAR_INT("Respuestas", "Correcta", idCorrecta, "ID", IdResp)
        GUARDAR_INT("Respuestas", "Utilizado", 0, "ID", IdResp)
        LIMPIAR()
        MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Trasacción exitosa")
        'Muestra y refresca la pantalla del list view de niveles y cierra esta
        P_PRespuestas.Show()
        P_PRespuestas.REFRESCAR()
        Me.Close()
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_NResp.Clear()
        TXT_PregNuevaResp.Clear()
        CKB_Correcta.Checked = False
    End Sub

    '-----------------------Validación de que todos los campos estén llenos---------------------------------
    Friend Sub VALIDAR()
        'Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_NResp.Text <> "" And IdPreg <> 0 Then
            BTN_AgregarNResp.Enabled = True
        Else
            BTN_AgregarNResp.Enabled = False
        End If
    End Sub

    Private Sub TXT_NResp_TextChanged(sender As Object, e As EventArgs) Handles TXT_NResp.TextChanged
        VALIDAR()
    End Sub

    Private Sub E_PNuevaRespuesta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarNResp.PerformClick()
        End If
    End Sub
End Class