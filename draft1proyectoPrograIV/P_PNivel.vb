Public Class P_PNivel
    '----------------------------Metodo cargar-----------------------------------------
    Private Sub P_PNivel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
    End Sub

    '---------------------------------Funciones de los botones---------------------------------------------
    Private Sub BTN_AgregarNuevoNivel_Click(sender As Object, e As EventArgs) Handles BTN_AgregarNuevoNivel.Click
        E_PNuevoNivel.Show()
    End Sub

    Private Sub BTN_RegresarNivel_Click(sender As Object, e As EventArgs) Handles BTN_RegresarNivel.Click
        P_PInfoEstudiantil.Show()
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
    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If LSV_Nivel.SelectedItems.Count > 0 Then
                If MsgBox("¿Desea eliminar el nivel: " & LSV_Nivel.SelectedItems(0).SubItems(1).Text & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idNivelEliminar As Integer = Convert.ToInt32(LSV_Nivel.SelectedItems(0).SubItems(0).Text)
                    ' Verificar si hay secciones asociadas
                    SQL = "SELECT COUNT(ID) FROM Seccion WHERE ID = " & idNivelEliminar
                    Cargar_Tabla(T, SQL)
                    If T.Tables(0).Rows(0).Item(0) = 0 Then
                        SQL = "SELECT Utilizado FROM nivel WHERE ID = " & idNivelEliminar
                        Cargar_Tabla(T1, SQL)
                        If T1.Tables(0).Rows(0).Item(0) = 0 Then
                            SQL = "DELETE FROM Nivel WHERE ID = " & idNivelEliminar
                            EJECUTAR(SQL)
                            REFRESCAR()
                            MsgBox("El nivel fue eliminado satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                        Else
                            MsgBox("No se puede eliminar el nivel porque ya ha sido utilizado.", vbExclamation, "Error")
                        End If
                    Else
                        MsgBox("No se puede eliminar el nivel porque tiene secciones asociadas.", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione un nivel para eliminar.", vbInformation + vbOKOnly, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar el nivel: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            If LSV_Nivel.SelectedItems.Count > 0 Then
                E_PModNivel.IdNivel = (LSV_Nivel.SelectedItems(0).SubItems(0).Text)
                E_PModNivel.TXT_NombreModNivel.Text = LSV_Nivel.SelectedItems(0).SubItems(1).Text
                E_PModNivel.Show()
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los datos del nivel: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    '------------------------------Función de busqueda------------------------------------------
    Friend Sub REFRESCAR()
        Try
            LSV_Nivel.Items.Clear()
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            T.Tables.Clear()
            If TXT_BuscarNivel.Text <> "" Then
                SQL = "SELECT * FROM Nivel WHERE NOMBRE LIKE '%" & TXT_BuscarNivel.Text & "%'"
            Else
                SQL = "SELECT * FROM Nivel"
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(i).Item(0).ToString())
                    item.SubItems.Add(T.Tables(0).Rows(i).Item(1).ToString())
                    LSV_Nivel.Items.Add(item)
                Next
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            LSV_Nivel.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Nivel.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Nivel.Columns(0).Width = 0
        Catch ex As Exception
            MsgBox("Error al cargar la lista de niveles: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub TXT_BuscarNivel_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarNivel.TextChanged
        REFRESCAR()
    End Sub

    Private Sub BTN_CuentaProf_Click(sender As Object, e As EventArgs) Handles BTN_CuentaProf.Click
        P_PCuenta.Show()
    End Sub

    Private Sub P_PNivel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarNuevoNivel.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class



