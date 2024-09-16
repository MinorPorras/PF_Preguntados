
Public Class E_ANuevoUsuarioProf
    Public IdProf As Integer
    '--------------------------------------Metodo cargar--------------------------------------------
    Private Sub E_PNuevoUsuarioProf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IdProf = OBTENERPK("Profesores", "ID")
    End Sub

    '-----------------------------------Función de los botones--------------------------------------
    Private Sub BTN_RegresarProfNuevo_Click(sender As Object, e As EventArgs) Handles BTN_RegresarProfNuevo.Click
        P_AUsuariosProf.Show()
        Me.Close()
    End Sub

    Private Sub BTN_GuardarProfNuevo_Click(sender As Object, e As EventArgs) Handles BTN_GuardarProfNuevo.Click
        Try
            'Comprobación de que se quiere agregar la información a la base de datos por parte del usuario
            If MessageBox.Show("Desea guardar esta información", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                'Si la PK que esté guardada en IdCat no existe en la base de datos en ese tabla...
                If EXISTEPK("Profesores", "ID", IdProf) = False Then 'Si no se ha guardado la categoría
                    'Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                    GUARDAR_PK("Profesores", "ID", IdProf)
                End If
                'Guarda la información en la db, limpia los datos en la textbox y le informa al usuario que todo salio bien
                GUARDAR_STR("Profesores", "Usuario", TXT_UsuarioProfNuevo.Text, "ID", IdProf)
                GUARDAR_STR("Profesores", "Clave", TXT_ClaveProfNuevo.Text, "ID", IdProf)
                GUARDAR_STR("Profesores", "Imagen", TXT_RutaImagen.Text, "ID", IdProf)
                GUARDAR_STR("Profesores", "Correo", TXT_CorreoProfNuevo.Text, "ID", IdProf)
                GUARDAR_TIMEACTUAL("Profesores", "Fecha_Registro", "ID", IdProf)
                GUARDAR_STR("Profesores", "Nombre", TXT_NombreNProf.Text, "ID", IdProf)
                GUARDAR_STR("Profesores", "Apellido1", TXT_Ape1NProf.Text, "ID", IdProf)
                GUARDAR_STR("Profesores", "apellido2", TXT_Ape2NProf.Text, "ID", IdProf)
                GUARDAR_INT("Profesores", "Utilizado", 0, "ID", IdProf)
                LIMPIAR()
                MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Trasacción exitosa")
                'Muestra y refresca la pantalla del list view de niveles y cierra esta
                P_AUsuariosProf.Show()
                P_AUsuariosProf.REFRESCAR()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub BTN_imagenProfNuevo_Click(sender As Object, e As EventArgs) Handles BTN_imagenProfNuevo.Click
        If OFD_CrearProf.ShowDialog() > 0 Then
            TXT_RutaImagen.Text = OFD_CrearProf.FileName
        End If
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_ClaveProfNuevo.Clear()
        TXT_CorreoProfNuevo.Clear()
        TXT_RutaImagen.Clear()
        TXT_UsuarioProfNuevo.Clear()
        TXT_Ape1NProf.Clear()
        TXT_Ape2NProf.Clear()
        TXT_NombreNProf.Clear()
    End Sub


    '-----------------------Validación de que todos los campos estén llenos---------------------------------
    Friend Sub VALIDAR()
        'Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_ClaveProfNuevo.Text <> "" And TXT_CorreoProfNuevo.Text <> "" And TXT_RutaImagen.Text <> "" And TXT_UsuarioProfNuevo.Text <> "" Then
            BTN_GuardarProfNuevo.Enabled = True
        Else
            BTN_GuardarProfNuevo.Enabled = False
        End If
    End Sub
    Private Sub TXT_UsuarioProfNuevo_TextChanged(sender As Object, e As EventArgs) Handles TXT_UsuarioProfNuevo.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_ClaveProfNuevo_TextChanged(sender As Object, e As EventArgs) Handles TXT_ClaveProfNuevo.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_CorreoProfNuevo_TextChanged(sender As Object, e As EventArgs) Handles TXT_CorreoProfNuevo.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_RutaImagen_TextChanged(sender As Object, e As EventArgs) Handles TXT_RutaImagen.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_NombreNProf_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreNProf.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_Ape1NProf_TextChanged(sender As Object, e As EventArgs) Handles TXT_Ape1NProf.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_Ape2NProf_TextChanged(sender As Object, e As EventArgs) Handles TXT_Ape2NProf.TextChanged
        VALIDAR()
    End Sub

    Private Sub E_ANuevoUsuarioProf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_GuardarProfNuevo.PerformClick()
        End If
    End Sub
End Class