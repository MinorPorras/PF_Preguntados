Public Class P_AUsuariosProf
    '----------------------------Metodo cargar-----------------------------------------
    Private Sub P_PUsuariosProf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
    End Sub

    '---------------------------------Funciones de los botones---------------------------------------------
    Private Sub BTN_AgregarProf_Click(sender As Object, e As EventArgs) Handles BTN_AgregarProf.Click
        E_ANuevoUsuarioProf.Show()
    End Sub

    Private Sub BTN_RegresarUsuarioProf_Click(sender As Object, e As EventArgs) Handles BTN_RegresarUsuarioProf.Click
        P_APrincipal.Show()
        Me.Close()
    End Sub
    Private Sub BTN_CerrarSesion_Click(sender As Object, e As EventArgs) Handles BTN_CerrarSesion.Click
        CAdmin = False
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
    Private Sub BTN_CuentaProf_Click(sender As Object, e As EventArgs) Handles BTN_CuentaProf.Click
        P_ACuenta.Show()
    End Sub

    '---------------------------------Funciones de los botones del context menu strip---------------------------------------------
    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If LSV_Profesores.SelectedItems.Count > 0 Then
                If MsgBox("¿Desea eliminar el profesor " & LSV_Profesores.SelectedItems(0).SubItems(1).Text & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idEliminarProf As Integer = Convert.ToInt32(LSV_Profesores.SelectedItems(0).SubItems(0).Text)
                    SQL = "SELECT count(ID) FROM Asignatura WHERE ID_Profesor = " & idEliminarProf
                    Cargar_Tabla(T, SQL)
                    If T.Tables(0).Rows(0).Item(0) = 0 Then
                        SQL = "SELECT Utilizado FROM Profesores WHERE ID = " & idEliminarProf
                        Cargar_Tabla(T1, SQL)
                        If T1.Tables(0).Rows(0).Item(0) = 0 Then
                            SQL = "DELETE FROM Profesores WHERE ID = " & idEliminarProf
                            EJECUTAR(SQL)
                            REFRESCAR()
                            MsgBox("El profesor fue eliminado satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                        Else
                            MsgBox("No se puede eliminar el profesor porque ya ha sido utilizado.", vbExclamation, "Error")
                        End If
                    Else
                        MsgBox("No se puede eliminar el profesor porque tiene asignaturas asociadas.", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione un profesor para eliminar.", vbInformation + vbOKOnly, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar el profesor: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            If LSV_Profesores.SelectedItems.Count > 0 Then
                E_PAActUsuarioProf.IdProf = CInt(LSV_Profesores.SelectedItems(0).SubItems(0).Text)
                E_PAActUsuarioProf.TXT_NombreModProf.Text = LSV_Profesores.SelectedItems(0).SubItems(1).Text
                E_PAActUsuarioProf.TXT_Ape1ModProf.Text = LSV_Profesores.SelectedItems(0).SubItems(2).Text
                E_PAActUsuarioProf.TXT_Ape2ModProf.Text = LSV_Profesores.SelectedItems(0).SubItems(3).Text
                E_PAActUsuarioProf.TXT_UsuarioProfMod.Text = LSV_Profesores.SelectedItems(0).SubItems(4).Text
                E_PAActUsuarioProf.TXT_ClaveProfMod.Text = LSV_Profesores.SelectedItems(0).SubItems(5).Text
                E_PAActUsuarioProf.TXT_RutaImagenMod.Text = LSV_Profesores.SelectedItems(0).SubItems(6).Text
                E_PAActUsuarioProf.TXT_CorreoProfMod.Text = LSV_Profesores.SelectedItems(0).SubItems(7).Text
                E_PAActUsuarioProf.Show()
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los datos del profesor" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    '------------------------------Función de busqueda------------------------------------------
    Friend Sub REFRESCAR()
        Try
            LSV_Profesores.Items.Clear()
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            T.Tables.Clear()
            If TXT_BuscarProfesor.Text <> "" Then
                SQL = "SELECT ID, Nombre, Apellido1, Apellido2, Usuario, Clave, Imagen, Correo, Fecha_Registro FROM Profesores WHERE Usuario LIKE '%" & TXT_BuscarProfesor.Text & "%'"
            Else
                SQL = "SELECT ID, Nombre, Apellido1, Apellido2, Usuario, Clave, Imagen, Correo, Fecha_Registro FROM Profesores"
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For I As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(I).Item(0).ToString())
                    For J As Integer = 1 To 8
                        Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(I).Item(J)), "", T.Tables(0).Rows(I).Item(J).ToString())
                        item.SubItems.Add(subItem)
                    Next
                    LSV_Profesores.Items.Add(item)
                Next
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            LSV_Profesores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Profesores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Profesores.Columns(0).Width = 0
        Catch ex As Exception
            MsgBox("Error al cargar la lista de profesores" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub TXT_BuscarProfesor_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProfesor.TextChanged
        REFRESCAR()
    End Sub

    Private Sub P_AUsuariosProf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarProf.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class

