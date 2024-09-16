Public Class P_TLogin

    Private Sub CerrarAPP_Click(sender As Object, e As EventArgs) Handles CerrarAPP.Click
        Dim resultado As MsgBoxResult
        resultado = MsgBox("¿Desea cerrar la aplicación?", vbOKCancel + vbQuestion, "Confirmar")

        If resultado = MsgBoxResult.Ok Then
            ' Cerramos la aplicación
            Application.Exit()
        End If
    End Sub

    Private Sub AccessValid_Click(sender As Object, e As EventArgs) Handles AccessValid.Click
        Try
            If TXT_ValidUsuario.Text <> "" Then
                If TXT_ValidClave.Text <> "" Then
                    If CBX_Tipo.SelectedIndex <> -1 Then
                        If CBX_Tipo.SelectedIndex = 2 Then
                            validacion_cuenta("Profesores")
                        ElseIf CBX_Tipo.SelectedIndex = 1 Then
                            validacion_cuenta("Estudiante")
                        ElseIf CBX_Tipo.SelectedIndex = 3 Then
                            validacion_cuenta("Administradores")
                        End If
                    Else
                        MsgBox("El tipo de cuenta no puede quedar en blanco, por favor rellene el espacio", vbInformation + vbOKOnly, "Error de inicio de sesión")
                        CBX_Tipo.Focus()
                    End If
                Else
                    MsgBox("La contraseña no puede quedar en blanco, por favor rellene el espacio", vbInformation + vbOKOnly, "Error de inicio de sesión")
                    TXT_ValidClave.Focus()
                End If
            ElseIf CBX_Tipo.SelectedText = "" Then
                errorCBX()
            Else
                errorCBX()
            End If
        Catch ex As Exception
            MsgBox("Error de validación de usuario: " & vbCrLf & ex.ToString(), vbOKOnly + vbCritical, "Error")
        End Try


    End Sub

    Private Sub errorCBX()
        MsgBox("Debe de escoger un tipo de cuenta y un usuario correcto, por favor rellene el espacio", vbInformation + vbOKOnly, "Error de inicio de sesión")
        TXT_ValidUsuario.Focus()
    End Sub
    Private Sub validacion_cuenta(ByVal tabla As String)
        T.Tables.Clear()
        SQL = "SELECT ID, Usuario, Clave FROM " & tabla & " where Usuario = '" & TXT_ValidUsuario.Text & "' AND Clave = '" & TXT_ValidClave.Text & "'"
        Cargar_Tabla(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            Dim usuario As Object = T.Tables(0).Rows(0).Item("Usuario")
            Dim clave As Object = T.Tables(0).Rows(0).Item("Clave")
            ID_cuenta = T.Tables(0).Rows(0).Item(0)
            Tipo_cuenta = tabla

            If Not IsDBNull(usuario) AndAlso Not IsDBNull(clave) Then
                If TXT_ValidUsuario.Text = T.Tables(0).Rows(0).Item(1) Then
                    If TXT_ValidClave.Text = T.Tables(0).Rows(0).Item(2) Then
                        If tabla = "Profesores" Then
                            T1.Tables.Clear()
                            GUARDAR_INT("Profesores", "Utilizado", 1, "ID", ID_cuenta)
                            CProf = True
                            P_PPrincipal.Show()
                            Me.Close()
                        ElseIf tabla = "Administradores" Then
                            GUARDAR_INT("Administradores", "Utilizado", 1, "ID", ID_cuenta)
                            CAdmin = True
                            P_APrincipal.Show()
                            Me.Close()
                        ElseIf tabla = "Estudiante" Then
                            GUARDAR_INT("Estudiante", "Utilizado", 1, "ID", ID_cuenta)
                            T1.Tables.Clear()
                            SQL = "SELECT e.ID AS est, s.ID As sec, n.ID as nivel, p.ID as periodo FROM Estudiante e, Seccion s, nivel n, Periodo p where e.ID_Seccion = s.ID AND s.ID_Nivel = n.ID AND e.ID_Periodo = p.ID"
                            Cargar_Tabla(T1, SQL)
                            GUARDAR_INT("Nivel", "Utilizado", 1, "ID", T1.Tables(0).Rows(0).Item(2))
                            GUARDAR_INT("Seccion", "Utilizado", 1, "ID", T1.Tables(0).Rows(0).Item(1))
                            GUARDAR_INT("Periodo", "Utilizado", 1, "ID", T1.Tables(0).Rows(0).Item(3))
                            CEstudiante = True
                            P_EPrincipal.Show()
                            Me.Close()
                        End If
                    Else
                        MsgBox("La contraseña es incorrecta", vbInformation + vbOKOnly, "Error de inicio de sesión")
                    End If
                Else
                    MsgBox("El usuario es incorrecto", vbInformation + vbOKOnly, "Error de inicio de sesión")
                End If
            Else
                MsgBox("El usuario no existe o está mal escrito, revise los datos nuevamente", vbInformation + vbOKOnly, "Error de inicio de sesión")
            End If
        Else
            MsgBox("El usuario no existe o está mal escrito, revise los datos nuevamente", vbInformation + vbOKOnly, "Error de inicio de sesión")
        End If
    End Sub

    Private Sub P_TLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub P_TLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            AccessValid.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class