Public Class E_PAActUsuarioProf
    Public IdProf As Integer

    '--------------------------------------Metodo cargar--------------------------------------------
    Private Sub E_PModUsuarioProf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '-----------------------------------Función de los botones--------------------------------------
    Private Sub BTN_GuardarProfMod_Click(sender As Object, e As EventArgs) Handles BTN_GuardarProfMod.Click
        ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
        If MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                ' Actualizar los campos en la base de datos
                'Guarda la información en la db, limpia los datos en la textbox y le informa al usuario que todo salio bien
                GUARDAR_STR("Profesores", "Usuario", TXT_UsuarioProfMod.Text, "ID", IdProf)
                GUARDAR_STR("Profesores", "Clave", TXT_ClaveProfMod.Text, "ID", IdProf)
                GUARDAR_STR("Profesores", "Imagen", TXT_RutaImagenMod.Text, "ID", IdProf)
                GUARDAR_STR("Profesores", "Correo", TXT_CorreoProfMod.Text, "ID", IdProf)
                GUARDAR_STR("Profesores", "Nombre", TXT_NombreModProf.Text, "ID", IdProf)
                GUARDAR_STR("Profesores", "Apellido1", TXT_Ape1ModProf.Text, "ID", IdProf)
                GUARDAR_STR("Profesores", "apellido2", TXT_Ape2ModProf.Text, "ID", IdProf)
                LIMPIAR()
                MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Trasacción exitosa")
                'Muestra y refresca la pantalla del list view de niveles y cierra esta
                If CAdmin = True Then
                    P_AUsuariosProf.Show()
                    P_AUsuariosProf.REFRESCAR()
                Else
                    P_PCuenta.Show()
                    P_PCuenta.Cargar_datos_Prof()
                End If
                Me.Close()
            Catch ex As Exception
                MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End Try
        End If
    End Sub

    Private Sub BTN_RegresarProfMod_Click(sender As Object, e As EventArgs) Handles BTN_RegresarProfMod.Click
        If CAdmin = True Then
            P_AUsuariosProf.Show()
            P_AUsuariosProf.REFRESCAR()
        Else
            P_PCuenta.Show()
            P_PCuenta.Cargar_datos_Prof()
        End If
        Me.Close()
    End Sub

    Private Sub BTN_imagenProfMod_Click(sender As Object, e As EventArgs) Handles BTN_imagenProfMod.Click
        If OFD_ModProf.ShowDialog() > 0 Then
            TXT_RutaImagenMod.Text = OFD_ModProf.FileName
        End If
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_UsuarioProfMod.Clear()
        TXT_ClaveProfMod.Clear()
        TXT_RutaImagenMod.Clear()
        TXT_CorreoProfMod.Clear()
        TXT_NombreModProf.Clear()
        TXT_Ape1ModProf.Clear()
        TXT_Ape2ModProf.Clear()
    End Sub

    '-----------------------Validación de que todos los campos estén llenos---------------------------------
    Friend Sub VALIDAR()
        'Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_ClaveProfMod.Text <> "" And TXT_CorreoProfMod.Text <> "" And TXT_RutaImagenMod.Text <> "" And TXT_UsuarioProfMod.Text <> "" Then
            BTN_GuardarProfMod.Enabled = True
        Else
            BTN_GuardarProfMod.Enabled = False
        End If
    End Sub

    Private Sub TXT_UsuarioProfMod_TextChanged(sender As Object, e As EventArgs) Handles TXT_UsuarioProfMod.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_ClaveProfMod_TextChanged(sender As Object, e As EventArgs) Handles TXT_ClaveProfMod.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_CorreoProfMod_TextChanged(sender As Object, e As EventArgs) Handles TXT_CorreoProfMod.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_RutaImagenMod_TextChanged(sender As Object, e As EventArgs) Handles TXT_RutaImagenMod.TextChanged
        VALIDAR()
    End Sub

    Private Sub E_PAActUsuarioProf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_GuardarProfMod.PerformClick()
        End If
    End Sub
End Class
