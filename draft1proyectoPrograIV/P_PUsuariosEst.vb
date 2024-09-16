Public Class P_PUsuariosEst
    '----------------------------Metodo cargar-----------------------------------------
    Private Sub P_PUsuariosEst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
    End Sub

    '---------------------------------Funciones de los botones---------------------------------------------
    Private Sub BTN_AgregarEst_Click(sender As Object, e As EventArgs) Handles BTN_AgregarEst.Click
        E_PNuevoUsuarioEst.Show()
    End Sub

    Private Sub BTN_RegresarUsuarioEst_Click(sender As Object, e As EventArgs) Handles BTN_RegresarUsuarioEst.Click
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
    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        If LSV_Estudiantes.SelectedItems.Count > 0 Then
            Try
                E_PActUsuarioEst.IdEst = CInt(LSV_Estudiantes.SelectedItems(0).SubItems(0).Text)
                E_PActUsuarioEst.TXT_CarnetMod.Text = LSV_Estudiantes.SelectedItems(0).SubItems(1).Text
                E_PActUsuarioEst.TXT_Ape1Mod.Text = LSV_Estudiantes.SelectedItems(0).SubItems(2).Text
                E_PActUsuarioEst.TXT_Ape2Mod.Text = LSV_Estudiantes.SelectedItems(0).SubItems(3).Text
                E_PActUsuarioEst.TXT_NombreMod.Text = LSV_Estudiantes.SelectedItems(0).SubItems(4).Text

                E_PActUsuarioEst.TXT_UsuarioMod.Text = LSV_Estudiantes.SelectedItems(0).SubItems(5).Text
                E_PActUsuarioEst.TXT_ClaveMod.Text = LSV_Estudiantes.SelectedItems(0).SubItems(6).Text
                E_PActUsuarioEst.TXT_CorreoMod.Text = LSV_Estudiantes.SelectedItems(0).SubItems(7).Text

                E_PActUsuarioEst.Show()

                E_PActUsuarioEst.CBX_SeccionModEst.SelectedValue = LSV_Estudiantes.SelectedItems(0).SubItems(8).Text
                E_PActUsuarioEst.CBX_PeriodoModEst.SelectedValue = LSV_Estudiantes.SelectedItems(0).SubItems(10).Text
                E_PActUsuarioEst.TXT_RutaImgModEst.Text = LSV_Estudiantes.SelectedItems(0).SubItems(12).Text

                ' Validar y asignar la fecha de nacimiento
                Dim fechaNacimientoStr As String = LSV_Estudiantes.SelectedItems(0).SubItems(14).Text
                Dim fechaNacimiento As Date
                If Date.TryParse(fechaNacimientoStr, fechaNacimiento) Then
                    ' Asignar fecha válida
                    E_PActUsuarioEst.DTP_FechaNacimientoEst.Value = fechaNacimiento
                Else
                    ' Mostrar mensaje de error
                    E_PActUsuarioEst.DTP_FechaNacimientoEst.Value = Date.Now()
                    MsgBox("La fecha de nacimiento no es válida. Ingrese una fecha en formato dd/MM/yyyy.", vbExclamation + vbOKOnly, "Error")
                End If
            Catch ex As Exception
                MsgBox("Error al cargar los datos del estudiante: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End Try
        End If
    End Sub
    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        If LSV_Estudiantes.SelectedItems.Count > 0 Then
            Dim idEstEliminar As Integer = Convert.ToInt32(LSV_Estudiantes.SelectedItems(0).SubItems(0).Text)
            If MsgBox("¿Desea eliminar al estudiante con el carnet: " & LSV_Estudiantes.SelectedItems(0).SubItems(1).Text & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                SQL = "SELECT Utilizado FROM Estudiante where ID = " & idEstEliminar
                Cargar_Tabla(T, SQL)
                Try
                    If T.Tables(0).Rows(0).Item(0) = 0 Then
                        SQL = "DELETE FROM Estudiante WHERE ID = " & idEstEliminar
                        EJECUTAR(SQL)
                        REFRESCAR()
                        MsgBox("El estudiante fue eliminado satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                    Else
                        MsgBox("Error al eliminar el estudiante: Debido a que este ya ha sido utilizado", vbCritical + vbOKOnly, "Error")
                    End If
                Catch ex As Exception
                    MsgBox("Error al eliminar el estudiante: " & ex.Message, vbCritical + vbOKOnly, "Error")
                End Try
            End If
        Else
            MsgBox("Seleccione un estudiante para eliminar.", vbInformation + vbOKOnly, "Información")
        End If
    End Sub

    '------------------------------Función de busqueda------------------------------------------
    Friend Sub REFRESCAR()
        Try
            LSV_Estudiantes.Items.Clear()
            T.Tables.Clear()
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            If TXT_BuscarEst.Text <> "" Then
                SQL = "SELECT e.ID, e.Carnet_Estudiante, e.Apellido_1, e.Apellido_2, e.Nombre, e.Usuario, e.CLave, e.Correo, e.ID_Seccion, c.Nombre, e.ID_Periodo, p.Nombre, e.Imagen, e.Fecha_Registro, e.Fecha_Nacimiento FROM Estudiante e, seccion c, periodo p WHERE e.ID_Periodo =p.ID AND e.ID_Seccion = c.ID AND e.Nombre LIKE '%" & TXT_BuscarEst.Text & "%'"
            Else
                SQL = "SELECT e.ID, e.Carnet_Estudiante, e.Apellido_1, e.Apellido_2, e.Nombre, e.Usuario, e.CLave, e.Correo, e.ID_Seccion, c.Nombre, e.ID_Periodo, p.Nombre, e.Imagen, e.Fecha_Registro, e.Fecha_Nacimiento FROM Estudiante e, seccion c, periodo p WHERE e.ID_Periodo =p.ID AND e.ID_Seccion = c.ID"
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For I As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(I).Item(0).ToString())
                    For J As Integer = 1 To 14
                        Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(I).Item(J)), "", T.Tables(0).Rows(I).Item(J).ToString())
                        item.SubItems.Add(subItem)
                    Next
                    LSV_Estudiantes.Items.Add(item)
                Next
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            LSV_Estudiantes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Estudiantes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Estudiantes.Columns(0).Width = 0
            LSV_Estudiantes.Columns(8).Width = 0
            LSV_Estudiantes.Columns(10).Width = 0
        Catch ex As Exception
            MsgBox("Error de carga la lista de los estudiantes." & vbCrLf & ex.ToString(), vbOKOnly + vbCritical, "Error")
        End Try

    End Sub

    Private Sub TXT_BuscarEst_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarEst.TextChanged
        REFRESCAR()
    End Sub

    Private Sub BTN_CuentaProf_Click(sender As Object, e As EventArgs) Handles BTN_CuentaProf.Click
        P_PCuenta.Show()
    End Sub

    Private Sub P_PUsuariosEst_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarEst.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class
