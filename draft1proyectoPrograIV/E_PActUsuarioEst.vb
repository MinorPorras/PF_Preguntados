Public Class E_PActUsuarioEst
    Public IdEst As Integer

    '--------------------------------------Metodo cargar--------------------------------------------
    Private Sub E_PModUsuarioEst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCBXSeccion()
        CargarCBXPeriodo()
    End Sub

    '-----------------------------------Función de los botones--------------------------------------
    Private Sub BTN_GuardarEstMod_Click(sender As Object, e As EventArgs) Handles BTN_GuardarEstMod.Click
        ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
        If MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                GUARDAR_STR("Estudiante", "Apellido_1", TXT_Ape1Mod.Text, "ID", IdEst)
                GUARDAR_STR("Estudiante", "Apellido_2", TXT_Ape2Mod.Text, "ID", IdEst)
                GUARDAR_STR("Estudiante", "Nombre", TXT_NombreMod.Text, "ID", IdEst)
                GUARDAR_STR("Estudiante", "Carnet_Estudiante", TXT_CarnetMod.Text, "ID", IdEst)
                GUARDAR_STR("Estudiante", "Usuario", TXT_UsuarioMod.Text, "ID", IdEst)
                GUARDAR_STR("Estudiante", "Clave", TXT_ClaveMod.Text, "ID", IdEst)
                GUARDAR_STR("Estudiante", "Correo", TXT_CorreoMod.Text, "ID", IdEst)
                GUARDAR_INT("Estudiante", "ID_Periodo", CBX_PeriodoModEst.SelectedValue, "ID", IdEst)
                GUARDAR_INT("Estudiante", "ID_Seccion", CBX_SeccionModEst.SelectedValue, "ID", IdEst)
                Dim FechaNacimiento As Date = DTP_FechaNacimientoEst.Value
                GUARDAR_DATE("Estudiante", "Fecha_Nacimiento", FechaNacimiento, "ID", IdEst)
                GUARDAR_STR("Estudiante", "Imagen", TXT_RutaImgModEst.Text, "ID", IdEst)
                LIMPIAR()
                MsgBox("Datos actualizados satisfactoriamente", vbInformation + vbOKOnly, "Trasacción exitosa")
                'Muestra y refresca la pantalla del list view de niveles y cierra esta
                If CProf = True Then
                    P_PUsuariosEst.Show()
                    P_PUsuariosEst.REFRESCAR()
                End If

                Me.Close()
            Catch ex As Exception
                MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End Try
        End If
    End Sub

    Private Sub BTN_RegresarEstMod_Click(sender As Object, e As EventArgs) Handles BTN_RegresarEstMod.Click
        If CProf = True Then
            P_PUsuariosEst.Show()
        End If

        Me.Close()
    End Sub

    Private Sub BTN_imagenUsuarioMod_Click(sender As Object, e As EventArgs) Handles BTN_imagenUsuarioMod.Click
        If OFD_ImgModEst.ShowDialog() = DialogResult.OK Then
            TXT_RutaImgModEst.Text = OFD_ImgModEst.FileName
        End If
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_Ape1Mod.Clear()
        TXT_Ape2Mod.Clear()
        TXT_NombreMod.Clear()
        TXT_CarnetMod.Clear()
        TXT_UsuarioMod.Clear()
        TXT_ClaveMod.Clear()
        TXT_CorreoMod.Clear()
        CBX_SeccionModEst.SelectedIndex = -1
        CBX_PeriodoModEst.SelectedIndex = -1
        DTP_FechaNacimientoEst.Value = DateTime.Now
        TXT_RutaImgModEst.Clear()
    End Sub

    '--------------------------------- CARGA DE LOS COMBO BOX --------------------------------
    Private Sub CargarCBXSeccion()
        Try
            'Se limpia la tabla temporal y se envía el query a la base de datos, cargando la tabla temporal
            SQL = "SELECT ID, Nombre FROM Seccion"
            T.Tables.Clear()
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    'Se establece una nueva instancia de Nivel para guardar ambos datos en un solo objeto
                    Dim seccionItem As New ClsSeccion()
                    seccionItem.ID = T.Tables(0).Rows(i).Item(0)
                    seccionItem.Nombre = T.Tables(0).Rows(i).Item(1)

                    'Se añade el objeto al combo box
                    CBX_SeccionModEst.Items.Add(seccionItem)
                Next
                'Se configura lo que muestra el combo box
                CBX_SeccionModEst.DisplayMember = "Nombre"
                CBX_SeccionModEst.ValueMember = "ID"
                CBX_SeccionModEst.DataSource = T.Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la lista de secciones" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub CargarCBXPeriodo()
        Try
            'Se limpia la tabla temporal y se envía el query a la base de datos, cargando la tabla temporal
            SQL = "SELECT ID, Nombre FROM Periodo"
            T.Tables.Clear()
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    'Se establece una nueva instancia de Nivel para guardar ambos datos en un solo objeto
                    Dim periodoItem As New ClsPeriodo()
                    periodoItem.ID = T.Tables(0).Rows(i).Item(0)
                    periodoItem.Nombre = T.Tables(0).Rows(i).Item(1)

                    'Se añade el objeto al combo box
                    CBX_PeriodoModEst.Items.Add(periodoItem)
                Next
                'Se configura lo que muestra el combo box
                CBX_PeriodoModEst.DisplayMember = "Nombre"
                CBX_PeriodoModEst.ValueMember = "ID"
                CBX_PeriodoModEst.DataSource = T.Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la lista de periodos" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try

    End Sub

    '--------------------------------------Validación de que los campos estén llenos-------------------------------
    Friend Sub VALIDAR()
        'Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_Ape1Mod.Text <> "" And TXT_Ape2Mod.Text <> "" And TXT_CarnetMod.Text <> "" And TXT_ClaveMod.Text <> "" And TXT_CorreoMod.Text <> "" And TXT_NombreMod.Text <> "" And TXT_RutaImgModEst.Text <> "" And TXT_UsuarioMod.Text <> "" And CBX_PeriodoModEst.SelectedIndex <> -1 And CBX_SeccionModEst.SelectedIndex <> -1 Then
            BTN_GuardarEstMod.Enabled = True
        Else
            BTN_GuardarEstMod.Enabled = False
        End If
    End Sub

    Private Sub TXT_CarnetMod_TextChanged(sender As Object, e As EventArgs) Handles TXT_CarnetMod.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_Ape1Mod_TextChanged(sender As Object, e As EventArgs) Handles TXT_Ape1Mod.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_Ape2Mod_TextChanged(sender As Object, e As EventArgs) Handles TXT_Ape2Mod.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_NombreMod_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreMod.TextChanged
        VALIDAR()
    End Sub

    Private Sub CBX_SeccionModEst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_SeccionModEst.SelectedIndexChanged
        VALIDAR()
    End Sub

    Private Sub TXT_RutaImgModEst_TextChanged(sender As Object, e As EventArgs) Handles TXT_RutaImgModEst.TextChanged
        VALIDAR()
    End Sub

    Private Sub DTP_FechaNacimientoEst_ValueChanged(sender As Object, e As EventArgs) Handles DTP_FechaNacimientoEst.ValueChanged
        VALIDAR()
    End Sub

    Private Sub CBX_PeriodoModEst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_PeriodoModEst.SelectedIndexChanged
        VALIDAR()
    End Sub

    Private Sub TXT_UsuarioMod_TextChanged(sender As Object, e As EventArgs) Handles TXT_UsuarioMod.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_ClaveMod_TextChanged(sender As Object, e As EventArgs) Handles TXT_ClaveMod.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_CorreoMod_TextChanged(sender As Object, e As EventArgs) Handles TXT_CorreoMod.TextChanged
        VALIDAR()
    End Sub

    Private Sub E_PActUsuarioEst_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_GuardarEstMod.PerformClick()
        End If
    End Sub
End Class
