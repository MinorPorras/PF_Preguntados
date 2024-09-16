Public Class P_PPreguntas
    '----------------------------Metodo cargar-----------------------------------------
    Private Sub P_PPreguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
    End Sub

    '---------------------------------Funciones de los botones---------------------------------------------
    Private Sub BTN_CrearPregunta_Click(sender As Object, e As EventArgs) Handles BTN_CrearPregunta.Click
        E_PNuevaPregunta.Show()
    End Sub

    Private Sub BTN_RegresarPregunta_Click(sender As Object, e As EventArgs) Handles BTN_RegresarPregunta.Click
        P_PPersonalizacion.Show()
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
            If LSV_Pregunta.SelectedItems.Count > 0 Then
                FrmModPregunta.IdPregunta = CInt(LSV_Pregunta.SelectedItems(0).SubItems(0).Text)
                FrmModPregunta.TXT_PreguntaMod.Text = LSV_Pregunta.SelectedItems(0).SubItems(3).Text
                FrmModPregunta.Show()
                FrmModPregunta.CBX_CategoriaModPregunta.SelectedValue = LSV_Pregunta.SelectedItems(0).SubItems(1).Text
                FrmModPregunta.NUD_PuntajeModPregunta.Value = LSV_Pregunta.SelectedItems(0).SubItems(5).Text
                FrmModPregunta.TXT_ModExplicacion.Text = LSV_Pregunta.SelectedItems(0).SubItems(4).Text
                Dim tiempo As String() = Strings.Split(LSV_Pregunta.SelectedItems(0).SubItems(6).Text, ":")
                Dim segundoMilis() As String = Strings.Split(tiempo(2), ".")
                Dim minutos As Integer = CInt(tiempo(1))
                Dim segundos As Integer = CInt(segundoMilis(0))
                FrmModPregunta.NUD_MinutosModPregunta.Value = minutos
                FrmModPregunta.NUD_SegundosModPregunta.Value = segundos
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la información de la pregunta: " & ex.ToString(), vbExclamation, "Error")
        End Try

    End Sub
    Private Sub MNU_RESPUESTAS_Click(sender As Object, e As EventArgs) Handles MNU_RESPUESTAS.Click
        Try
            P_PRespuestas.idPreg = CInt(LSV_Pregunta.SelectedItems(0).SubItems(0).Text)
            P_PRespuestas.TXT_PregRESP.Text = LSV_Pregunta.SelectedItems(0).SubItems(3).Text
            P_PRespuestas.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al cargar las respuestas: " & ex.ToString(), vbExclamation, "Error")
        End Try

    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            'Se asegura que se haya selecionado algo en la list view
            If LSV_Pregunta.SelectedItems.Count > 0 Then
                'Se confirma que se quiera eliminar la sección
                If MsgBox("¿Desea eliminar la pregunta: " & LSV_Pregunta.SelectedItems(0).SubItems(3).Text & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idPregEliminar As Integer = Convert.ToInt32(LSV_Pregunta.SelectedItems(0).SubItems(0).Text)
                    ' Verificar si hay respuestas asociadas
                    SQL = "SELECT COUNT(R.ID) as cIDResp FROM Preguntas p, Respuestas r WHERE P.ID = r.ID_Pregunta AND p.ID = " & idPregEliminar
                    Cargar_Tabla(T, SQL)
                    'Que no haya ninguna respuesta relacionada con la pregunta
                    If T.Tables(0).Rows(0).Item(0) = 0 Or IsDBNull(T.Tables(0).Rows(0).Item(0)) Then
                        SQL = "SELECT p.Utilizado FROM Preguntas p WHERE p.ID = " & idPregEliminar
                        Cargar_Tabla(T1, SQL)
                        'Que no se haya utilizado en un juego
                        If T1.Tables(0).Rows(0).Item(0) = 0 Then
                            'Se elimina la pregunta
                            SQL = "DELETE FROM Preguntas WHERE ID= " & idPregEliminar
                            EJECUTAR(SQL)
                            REFRESCAR()
                            MsgBox("La pregunta fue eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                        Else
                            MsgBox("No se puede eliminar la pregunta porque ya ha sido utilizada en un juego.", vbExclamation, "Error")
                        End If
                    Else
                        MsgBox("No se puede eliminar la pregunta porque tiene respuestas asociadas.", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione una pregunta para eliminar.", vbExclamation, "Error")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar la pregunta: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    '------------------------------Función de busqueda------------------------------------------
    Friend Sub REFRESCAR()
        Try
            LSV_Pregunta.Items.Clear()
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            T.Tables.Clear()
            If TXT_BuscarPregunta.Text <> "" Then
                SQL = "SELECT p.ID, p.ID_Categoria,c.Nombre, p.Texto, p.Explicacion, p.Puntaje, p.Tiempo FROM Preguntas p, Categoria c WHERE p.ID_Categoria = c.ID AND p.Texto LIKE '%" & TXT_BuscarPregunta.Text & "%'"
            Else
                SQL = "SELECT p.ID, p.ID_Categoria,c.Nombre, p.Texto, p.Explicacion, p.Puntaje, p.Tiempo FROM Preguntas p, Categoria c WHERE p.ID_Categoria = c.ID"
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For I As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(I).Item(0).ToString())
                    For J As Integer = 1 To 6
                        Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(I).Item(J)), "", T.Tables(0).Rows(I).Item(J).ToString())
                        item.SubItems.Add(subItem)
                    Next
                    LSV_Pregunta.Items.Add(item)
                Next
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            LSV_Pregunta.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Pregunta.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Pregunta.Columns(0).Width = 0
            LSV_Pregunta.Columns(1).Width = 0
            TXT_BuscarPregunta.Select()
        Catch ex As Exception
            MsgBox("Error al cargar la lista de preguntas: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub TXT_BuscarPregunta_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarPregunta.TextChanged
        REFRESCAR()
    End Sub

    Private Sub BTN_CuentaProf_Click(sender As Object, e As EventArgs) Handles BTN_CuentaProf.Click
        P_PCuenta.Show()
    End Sub

    Private Sub P_PPreguntas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_CrearPregunta.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class