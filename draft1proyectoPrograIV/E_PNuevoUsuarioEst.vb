Public Class E_PNuevoUsuarioEst

    Public IdEst As Integer

    '--------------------------------------Metodo cargar--------------------------------------------
    Private Sub E_PNuevoUsuarioEst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCBXSeccion()
        CargarCBXPeriodo()
        'Al cargar la pagina obtiene una PK nueva
        IdEst = OBTENERPK("Estudiante", "ID")
    End Sub

    '-----------------------------------Función de los botones--------------------------------------
    Private Sub BTN_AgregarEstNuevo_Click(sender As Object, e As EventArgs) Handles BTN_AgregarEstNuevo.Click
        Try
            'Comprobación de que se quiere agregar la información a la base de datos por parte del usuario
            If MessageBox.Show("Desea guardar esta información", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                'Si la PK que esté guardada en IdCat no existe en la base de datos en ese tabla...
                If EXISTEPK("Estudiante", "ID", IdEst) = False Then 'Si no se ha guardado la categoría
                    'Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                    GUARDAR_PK("Estudiante", "ID", IdEst)
                End If
                'Guarda la información en la db, limpia los datos en la textbox y le informa al usuario que todo salio bien
                GUARDAR_STR("Estudiante", "Apellido_1", TXT_Ape1Nuevo.Text, "ID", IdEst)
                GUARDAR_STR("Estudiante", "Apellido_2", TXT_Ape2Nuevo.Text, "ID", IdEst)
                GUARDAR_STR("Estudiante", "Nombre", TXT_NombreNuevo.Text, "ID", IdEst)
                GUARDAR_STR("Estudiante", "Carnet_Estudiante", TXT_CarnetNuevo.Text, "ID", IdEst)
                GUARDAR_STR("Estudiante", "Usuario", TXT_UsuarioNuevo.Text, "ID", IdEst)
                GUARDAR_STR("Estudiante", "Clave", TXT_ClaveNuevo.Text, "ID", IdEst)
                GUARDAR_STR("Estudiante", "Correo", TXT_CorreoNuevo.Text, "ID", IdEst)
                GUARDAR_INT("Estudiante", "ID_Seccion", CBX_SeccionNuevaEst.SelectedValue, "ID", IdEst)
                GUARDAR_INT("Estudiante", "ID_Periodo", CBX_PeriodoNuevoEst.SelectedValue, "ID", IdEst)
                Dim FechaNacimiento As DateTime = DTP_FechaNacimientoEst.Value
                Dim fecha As Date = FechaNacimiento.Date
                GUARDAR_DATE("Estudiante", "Fecha_Nacimiento", fecha, "ID", IdEst)
                GUARDAR_STR("Estudiante", "Imagen", TXT_RutaImgNuevoEst.Text, "ID", IdEst)
                GUARDAR_TIMEACTUAL("Estudiante", "Fecha_Registro", "ID", IdEst)
                GUARDAR_INT("Estudiante", "Utilizado", 0, "ID", IdEst)
                LIMPIAR()
                MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Trasacción exitosa")
                'Muestra y refresca la pantalla del list view de niveles y cierra esta
                P_PUsuariosEst.Show()
                P_PUsuariosEst.REFRESCAR()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al guardar el nuevo estudiante: " & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub BTN_RegresarEstNuevo_Click(sender As Object, e As EventArgs) Handles BTN_RegresarEstNuevo.Click
        P_PUsuariosEst.Show()
        Me.Close()
    End Sub

    Private Sub BTN_imagenUsuarioNuevo_Click(sender As Object, e As EventArgs) Handles BTN_imagenUsuarioNuevo.Click
        If OFD_ImgEstNuevo.ShowDialog() > 0 Then
            TXT_RutaImgNuevoEst.Text = OFD_ImgEstNuevo.FileName
        End If
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_Ape1Nuevo.Clear()
        TXT_Ape2Nuevo.Clear()
        TXT_CarnetNuevo.Clear()
        TXT_ClaveNuevo.Clear()
        TXT_CorreoNuevo.Clear()
        TXT_NombreNuevo.Clear()
        TXT_RutaImgNuevoEst.Clear()
        TXT_UsuarioNuevo.Clear()
        CBX_PeriodoNuevoEst.SelectedIndex = -1
        CBX_SeccionNuevaEst.SelectedIndex = -1
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
                    CBX_SeccionNuevaEst.Items.Add(seccionItem)
                Next
                'Se configura lo que muestra el combo box
                CBX_SeccionNuevaEst.DisplayMember = "Nombre"
                CBX_SeccionNuevaEst.ValueMember = "ID"
                CBX_SeccionNuevaEst.DataSource = T.Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la lista de secciones: " & vbCrLf & ex.ToString(), vbOKOnly, "Error")
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
                    CBX_PeriodoNuevoEst.Items.Add(periodoItem)
                Next
                'Se configura lo que muestra el combo box
                CBX_PeriodoNuevoEst.DisplayMember = "Nombre"
                CBX_PeriodoNuevoEst.ValueMember = "ID"
                CBX_PeriodoNuevoEst.DataSource = T.Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la lista de periodos: " & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    '--------------------------------------Validación de que los campos estén llenos-------------------------------
    Friend Sub VALIDAR()
        'Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_Ape1Nuevo.Text <> "" And TXT_Ape2Nuevo.Text <> "" And TXT_CarnetNuevo.Text <> "" And TXT_ClaveNuevo.Text <> "" And TXT_CorreoNuevo.Text <> "" And TXT_NombreNuevo.Text <> "" And TXT_RutaImgNuevoEst.Text <> "" And TXT_UsuarioNuevo.Text <> "" And CBX_SeccionNuevaEst.SelectedIndex <> -1 And CBX_PeriodoNuevoEst.SelectedIndex <> -1 Then
            BTN_AgregarEstNuevo.Enabled = True
        Else
            BTN_AgregarEstNuevo.Enabled = False
        End If
    End Sub
    Private Sub TXT_NombreNuevo_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreNuevo.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_CarnetNuevo_TextChanged(sender As Object, e As EventArgs) Handles TXT_CarnetNuevo.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_Ape1Nuevo_TextChanged(sender As Object, e As EventArgs) Handles TXT_Ape1Nuevo.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_Ape2Nuevo_TextChanged(sender As Object, e As EventArgs) Handles TXT_Ape2Nuevo.TextChanged
        VALIDAR()
    End Sub

    Private Sub CBX_SeccionNuevaEst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_SeccionNuevaEst.SelectedIndexChanged
        VALIDAR()
    End Sub

    Private Sub DTP_FechaNacimientoEst_ValueChanged(sender As Object, e As EventArgs) Handles DTP_FechaNacimientoEst.ValueChanged
        VALIDAR()
    End Sub

    Private Sub CBX_PeriodoNuevoEst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_PeriodoNuevoEst.SelectedIndexChanged
        VALIDAR()
    End Sub

    Private Sub TXT_UsuarioNuevo_TextChanged(sender As Object, e As EventArgs) Handles TXT_UsuarioNuevo.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_ClaveNuevo_TextChanged(sender As Object, e As EventArgs) Handles TXT_ClaveNuevo.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_CorreoNuevo_TextChanged(sender As Object, e As EventArgs) Handles TXT_CorreoNuevo.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_RutaImgNuevoEst_TextChanged(sender As Object, e As EventArgs) Handles TXT_RutaImgNuevoEst.TextChanged
        VALIDAR()
    End Sub

    Private Sub E_PNuevoUsuarioEst_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarEstNuevo.PerformClick()
        End If
    End Sub
End Class