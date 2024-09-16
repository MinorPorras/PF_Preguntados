Public Class P_PRespuestas
    Public idPreg As Integer
    '----------------------------Metodo cargar-----------------------------------------
    Private Sub P_PRespuestas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
    End Sub
    '---------------------------------Funciones de los botones---------------------------------------------
    Private Sub BTN_CrearRespuesta_Click(sender As Object, e As EventArgs) Handles BTN_CrearRespuesta.Click
        Try
            E_PNuevaRespuesta.IdPreg = idPreg
            E_PNuevaRespuesta.TXT_PregNuevaResp.Text = TXT_PregRESP.Text
            E_PNuevaRespuesta.Show()
        Catch ex As Exception
            MsgBox("Error cargar datos de la pregunta: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try

    End Sub

    Private Sub BTN_RegresarRespuesta_Click(sender As Object, e As EventArgs) Handles BTN_RegresarRespuesta.Click
        P_PPreguntas.Show()
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
    '---------------------------------Funciones de los botones del context menu strip---------------------------------------------
    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            If LSV_Respuesta.SelectedItems.Count > 0 Then
                E_PModResp.IdPreg = idPreg
                E_PModResp.IdResp = LSV_Respuesta.SelectedItems(0).SubItems(0).Text
                E_PModResp.TXT_PregModResp.Text = TXT_PregRESP.Text
                E_PModResp.TXT_ModResp.Text = LSV_Respuesta.SelectedItems(0).SubItems(1).Text
                If LSV_Respuesta.SelectedItems(0).SubItems(2).Text = 1 Then
                    E_PModResp.CKB_Correcta.Checked = True
                ElseIf LSV_Respuesta.SelectedItems(0).SubItems(2).Text = 0 Then
                    E_PModResp.CKB_Correcta.Checked = False
                End If
                E_PModResp.Show()
            End If
        Catch ex As Exception
            MsgBox("Error cargar datos de la respuesta: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try

    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        Try
            If LSV_Respuesta.SelectedItems.Count > 0 Then
                If MsgBox("¿Desea eliminar la Respuesta: " & LSV_Respuesta.SelectedItems(0).SubItems(1).Text & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idRespEliminar As Integer = Convert.ToInt32(LSV_Respuesta.SelectedItems(0).SubItems(0).Text)
                    SQL = "SELECT Utilizado FROM Respuestas WHERE ID = " & idRespEliminar
                    Cargar_Tabla(T, SQL)
                    If T.Tables(0).Rows(0).Item(0) = 0 Then
                        ' Proceder con la eliminación
                        SQL = "DELETE FROM Respuestas WHERE ID = " & idRespEliminar
                        EJECUTAR(SQL)
                        REFRESCAR()
                        MsgBox("Respuesta eliminada correctamente.", vbInformation, "Éxito")
                    Else
                        MsgBox("Error al eliminar la respuesta ya que se ha utilizado en un juego", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione una respuesta para eliminar.", vbExclamation, "Error")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar la Respuesta: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try


    End Sub

    '------------------------------Función de busqueda------------------------------------------
    Friend Sub REFRESCAR()
        Try
            LSV_Respuesta.Items.Clear()
            T.Tables.Clear()
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            SQL = "SELECT ID, Texto, Correcta, IIf(Correcta = 1, 'Correcta', 'Incorrecta') AS Respuesta, ID_Pregunta FROM Respuestas WHERE ID_Pregunta = " & idPreg
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For I As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(I).Item(0).ToString())
                    For J As Integer = 1 To 4
                        Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(I).Item(J)), "", T.Tables(0).Rows(I).Item(J).ToString())
                        item.SubItems.Add(subItem)
                    Next
                    LSV_Respuesta.Items.Add(item)
                Next
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            LSV_Respuesta.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Respuesta.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Respuesta.Columns(0).Width = 0
            LSV_Respuesta.Columns(2).Width = 0
            LSV_Respuesta.Columns(4).Width = 0
            TXT_PregRESP.Select()

        Catch ex As Exception
            MsgBox("Error cargar la lista de respuestas: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try

    End Sub

    Private Sub TXT_BuscarRespuesta_TextChanged(sender As Object, e As EventArgs)
        REFRESCAR()
    End Sub

    Private Sub BTN_CuentaProf_Click(sender As Object, e As EventArgs) Handles BTN_CuentaProf.Click
        P_PCuenta.Show()
    End Sub

    Private Sub P_PRespuestas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_CrearRespuesta.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class