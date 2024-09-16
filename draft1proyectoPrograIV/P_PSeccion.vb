Imports System.Windows.Forms
Public Class P_PSeccion
    '----------------------------Metodo cargar-----------------------------------------
    Private Sub P_PSeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
    End Sub

    '---------------------------------Funciones de los botones---------------------------------------------
    Private Sub BTN_RegresarSeccion_Click(sender As Object, e As EventArgs) Handles BTN_RegresarSeccion.Click
        P_PInfoEstudiantil.Show()
        Me.Close()
    End Sub

    Private Sub BTN_AgregarNuevaSeccion_Click(sender As Object, e As EventArgs) Handles BTN_AgregarNuevaSeccion.Click
        E_PNuevaSeccion.Show()
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
            If LSV_Seccion.SelectedItems.Count > 0 Then
                If MsgBox("¿Desea eliminar la sección: " & LSV_Seccion.SelectedItems(0).SubItems(1).Text & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idSeccionEliminar As Integer = Convert.ToInt32(LSV_Seccion.SelectedItems(0).SubItems(0).Text)
                    ' Verificar si hay estudiantes o asignaturas asociadas
                    SQL = "SELECT count(a.ID), COUNT(e.ID) FROM Asignatura a, Estudiante e, Seccion s WHERE a.ID_Seccion = s.id and e.ID_Seccion = s.ID AND s.ID = " & idSeccionEliminar
                    Cargar_Tabla(T, SQL)
                    'Si no tiene asignaturas asociadas
                    If T.Tables(0).Rows(0).Item(0) = 0 Then
                        'Si no tiene estudiantes asociados
                        If T.Tables(0).Rows(0).Item(1) = 0 Then
                            'Se verifica que no haya sido utilizado
                            SQL = "SELECT Utilizado FROM Seccion WHERE ID = " & idSeccionEliminar
                            Cargar_Tabla(T1, SQL)
                            'Si no ha sido utilizado
                            If T1.Tables(0).Rows(0).Item(0) = 0 Then
                                'Pasa a estar inactivo
                                SQL = "DELETE FROM Seccion WHERE ID= " & idSeccionEliminar
                                EJECUTAR(SQL)
                                REFRESCAR()
                                MsgBox("La sección fue eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                            Else
                                MsgBox("No se puede eliminar la sección porque ya a sido utilizada.", vbExclamation, "Error")
                            End If
                        Else
                            MsgBox("No se puede eliminar la sección porque tiene estudiantes asociados.", vbExclamation, "Error")
                        End If
                    Else
                        MsgBox("No se puede eliminar la sección porque tiene Asignaturas asociadas.", vbExclamation, "Error")
                    End If
                Else
                    MsgBox("Seleccione una sección para eliminar.", vbInformation + vbOKOnly, "Información")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar la sección: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            If LSV_Seccion.SelectedItems.Count > 0 Then
                E_PModSeccion.IdSeccion = CInt(LSV_Seccion.SelectedItems(0).SubItems(0).Text)
                E_PModSeccion.TXT_NombreModSeccion.Text = LSV_Seccion.SelectedItems(0).SubItems(1).Text
                E_PModSeccion.Show()
                E_PModSeccion.CBX_NivelModSeccion.SelectedValue = LSV_Seccion.SelectedItems(0).SubItems(2).Text
            End If
        Catch ex As Exception
            MsgBox("Error al cargas los datos la sección: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try

    End Sub

    '------------------------------Función de busqueda------------------------------------------
    Public Sub REFRESCAR()
        Try
            LSV_Seccion.Items.Clear()
            T.Tables.Clear()
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            If TXT_BuscarSección.Text <> "" Then
                SQL = "SELECT s.ID, s.Nombre, s.ID_Nivel, n.Nombre FROM Seccion s, Nivel n WHERE S.ID_Nivel = n.ID AND S.NOMBRE LIKE '%" & TXT_BuscarSección.Text & "%'"
            Else
                SQL = "SELECT s.ID, s.Nombre, s.ID_Nivel, n.Nombre FROM Seccion s, Nivel n WHERE S.ID_Nivel = n.ID"
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For I As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(I).Item(0).ToString())
                    For J As Integer = 1 To 3
                        Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(I).Item(J)), "", T.Tables(0).Rows(I).Item(J).ToString())
                        item.SubItems.Add(subItem)
                    Next
                    LSV_Seccion.Items.Add(item)
                Next
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            LSV_Seccion.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Seccion.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Seccion.Columns(0).Width = 0
            LSV_Seccion.Columns(2).Width = 0
        Catch ex As Exception
            ' Verificar si es la excepción específica
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de secciones: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try

    End Sub

    Private Sub TXT_BuscarSección_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarSección.TextChanged
        REFRESCAR()
    End Sub

    Private Sub BTN_CuentaProf_Click(sender As Object, e As EventArgs) Handles BTN_CuentaProf.Click
        P_PCuenta.Show()
    End Sub

    Private Sub P_PSeccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarNuevaSeccion.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class

