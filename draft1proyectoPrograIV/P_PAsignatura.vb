Public Class P_PAsignatura
    '----------------------------Metodo cargar-----------------------------------------
    Private Sub P_PAsignatura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
    End Sub

    '---------------------------------Funciones de los botones---------------------------------------------
    Private Sub BTN_RegresarAsig_Click(sender As Object, e As EventArgs) Handles BTN_RegresarAsig.Click
        P_PInfoEstudiantil.Show()
        Me.Close()
    End Sub

    Private Sub BTN_AgregarNuevoAsig_Click(sender As Object, e As EventArgs) Handles BTN_AgregarNuevoAsig.Click
        E_PNuevaAsig.Show()
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
            If LSV_Asig.SelectedItems.Count > 0 Then
                If MsgBox("¿Desea eliminar la asignatura: " & LSV_Asig.SelectedItems(0).SubItems(1).Text & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idEliminarAsig As Integer = Convert.ToInt32(LSV_Asig.SelectedItems(0).SubItems(0).Text)
                    ' Verificar si hay respuestas asociadas
                    SQL = "SELECT COUNT(ID) FROM Temas WHERE ID_Asignatura = " & idEliminarAsig
                    Cargar_Tabla(T, SQL)
                    If T.Tables(0).Rows(0).Item(0) = 0 Then
                        SQL = "SELECT Utilizado FROM Asignatura WHERE ID = " & idEliminarAsig
                        Cargar_Tabla(T1, SQL)
                        If T1.Tables(0).Rows(0).Item(0) = 0 Then
                            SQL = "DELETE FROM Asignatura WHERE ID = " & idEliminarAsig
                            EJECUTAR(SQL)
                            REFRESCAR()
                            MsgBox("La asignatura fue eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                        Else
                            MsgBox("No se puede eliminar la asignatura porque ya se ha jugado con esta", vbExclamation, "Error")
                        End If
                    Else
                        MsgBox("No se puede eliminar la asignatura porque tiene temas asociados.", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione una asignatura para eliminar.", vbInformation + vbOKOnly, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar la asignatura: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            If LSV_Asig.SelectedItems.Count > 0 Then
                E_PModAsig.IdAsig = CInt(LSV_Asig.SelectedItems(0).SubItems(0).Text)
                E_PModAsig.TXT_NombreModAsig.Text = LSV_Asig.SelectedItems(0).SubItems(1).Text
                E_PModAsig.Show()
                E_PModAsig.CBX_SeccionModAsig.SelectedValue = LSV_Asig.SelectedItems(0).SubItems(2).Text
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los datos de la categoría: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    '------------------------------Función de busqueda------------------------------------------
    Friend Sub REFRESCAR()
        Try
            LSV_Asig.Items.Clear()
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            T.Tables.Clear()
            If TXT_BuscarAsig.Text <> "" Then
                SQL = "SELECT a.ID, a.Nombre, a.ID_Seccion, s.Nombre FROM Asignatura a, seccion s, Profesores p WHERE a.ID_Seccion = s.ID AND p.ID = a.ID_Profesor AND a.Nombre LIKE '%" & TXT_BuscarAsig.Text & "%' AND a.ID_Profesor = " & ID_cuenta
            Else
                SQL = " SELECT a.ID, a.Nombre, a.ID_Seccion, s.Nombre FROM Asignatura a, seccion s, Profesores p  WHERE a.ID_Seccion = s.ID AND p.ID = a.ID_Profesor AND a.ID_Profesor = " & ID_cuenta
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(i).Item(0).ToString())
                    For j As Integer = 1 To 3
                        Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(i).Item(j)), "", T.Tables(0).Rows(i).Item(j).ToString())
                        item.SubItems.Add(subItem)
                    Next
                    LSV_Asig.Items.Add(item)
                Next
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            LSV_Asig.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Asig.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Asig.Columns(0).Width = 0
            LSV_Asig.Columns(2).Width = 0
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de asignaturas: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try

    End Sub

    Private Sub TXT_BuscarAsig_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarAsig.TextChanged
        REFRESCAR()
    End Sub

    Private Sub BTN_CuentaProf_Click(sender As Object, e As EventArgs) Handles BTN_CuentaProf.Click
        P_PCuenta.Show()
    End Sub

    Private Sub P_PAsignatura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarNuevoAsig.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class
