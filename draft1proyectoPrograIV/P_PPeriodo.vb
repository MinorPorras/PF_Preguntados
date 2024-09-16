Public Class P_PPeriodo
    '----------------------------Metodo cargar-----------------------------------------
    Private Sub P_PPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
    End Sub


    '---------------------------------Funciones de los botones---------------------------------------------
    Private Sub BTN_AgregarNPeriodo_Click(sender As Object, e As EventArgs) Handles BTN_AgregarNPeriodo.Click
        E_PNuevoPeriodo.Show()
    End Sub

    Private Sub BTN_RegresarPeriodo_Click(sender As Object, e As EventArgs) Handles BTN_RegresarPeriodo.Click
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
            'Se confirma que se haya selecionado algo en la list view
            If LSV_Periodo.SelectedItems.Count > 0 Then
                'Se confirma que se quiera eliminar el periodo
                If MsgBox("¿Desea eliminar el periodo: " & LSV_Periodo.SelectedItems(0).SubItems(1).Text & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idPeriodoEliminar As Integer = Convert.ToInt32(LSV_Periodo.SelectedItems(0).SubItems(0).Text)
                    SQL = "SELECT COUNT(ID) FROM Estudiante WHERE ID_Periodo = " & idPeriodoEliminar
                    Cargar_Tabla(T, SQL)
                    'Si no hay estudiantes relacionados se elimina
                    If T.Tables(0).Rows(0).Item(0) = 0 Then
                        SQL = "SELECT Utilizado FROM Periodo WHERE ID = " & idPeriodoEliminar
                        Cargar_Tabla(T1, SQL)
                        'Si no se ha utilizado el periodo
                        If T1.Tables(0).Rows(0).Item(0) = 0 Then
                            SQL = "DELETE FROM Periodo WHERE ID = " & idPeriodoEliminar
                            EJECUTAR(SQL)
                            REFRESCAR()
                            MsgBox("El periodo fue eliminado satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                        Else
                            MsgBox("No se puede eliminar el periodo debido a que ya ha sido utilizado.", vbExclamation, "Error")
                        End If
                    Else
                        MsgBox("No se puede eliminar el periodo debido a que tiene estudiantes asignados.", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione un periodo para eliminar.", vbInformation + vbOKOnly, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar el periodo: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            If LSV_Periodo.SelectedItems.Count > 0 Then
                E_PModPeriodo.IdPeriodo = CInt(LSV_Periodo.SelectedItems(0).SubItems(0).Text)
                E_PModPeriodo.TXT_NombreModPeriodo.Text = LSV_Periodo.SelectedItems(0).SubItems(1).Text
                E_PModPeriodo.Show()
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los datos del periodo: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try

    End Sub

    '------------------------------Función de busqueda------------------------------------------
    Friend Sub REFRESCAR()
        Try
            LSV_Periodo.Items.Clear()
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            T.Tables.Clear()
            If TXT_BuscarPeriodo.Text <> "" Then
                SQL = "SELECT * FROM Periodo WHERE Nombre LIKE '%" & TXT_BuscarPeriodo.Text & "%'"
            Else
                SQL = "SELECT * FROM Periodo"
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(i).Item(0).ToString())
                    item.SubItems.Add(T.Tables(0).Rows(i).Item(1).ToString())
                    LSV_Periodo.Items.Add(item)
                Next
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            LSV_Periodo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Periodo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Periodo.Columns(0).Width = 0
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de periodos: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try

    End Sub

    Private Sub TXT_BuscarPeriodo_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarPeriodo.TextChanged
        REFRESCAR()
    End Sub

    Private Sub BTN_CuentaProf_Click(sender As Object, e As EventArgs) Handles BTN_CuentaProf.Click
        P_PCuenta.Show()
    End Sub

    Private Sub P_PPeriodo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarNPeriodo.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class