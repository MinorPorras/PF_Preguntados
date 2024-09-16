Public Class E_PNuevoTema
    '-----------------------DEFINICIÓN DE VARIABLES NECESARIAS------------------------------
    Public RutaImgEst As String
    Public RutaImgAni As String
    Public RutaAudio As String
    Public RutaSonido As String
    Public IdTema As String

    '--------------------------------------Metodo cargar--------------------------------------------
    Private Sub E_PNuevoTema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCBXAsig()
        ' Al cargar la página obtiene una PK nueva
        IdTema = OBTENERPK("Temas", "ID")
        BTN_AgregarNuevoTema.Enabled = False ' Deshabilita el botón al cargar el formulario
    End Sub

    '-----------------------------------Función de los botones (EXCEPTO DE LAS IMAGENES)--------------------------------------
    Private Sub BTN_AgregarNuevoTema_Click(sender As Object, e As EventArgs) Handles BTN_AgregarNuevoTema.Click
        Try
            ' Comprobación de que se quiere agregar la información a la base de datos por parte del usuario
            If MessageBox.Show("Desea guardar esta información", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ' Si la PK que esté guardada en IdCat no existe en la base de datos en esa tabla...
                If EXISTEPK("Temas", "ID", IdTema) = False Then ' Si no se ha guardado la categoría
                    ' Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                    GUARDAR_PK("Temas", "ID", IdTema)
                End If
                ' Guarda la información en la db, limpia los datos en la textbox y le informa al usuario que todo salió bien
                GUARDAR_STR("Temas", "Nombre", TXT_NombreNuevoTema.Text, "ID", IdTema)
                GUARDAR_STR("Temas", "Descripción", TXT_DescNuevoTema.Text, "ID", IdTema)
                GUARDAR_STR("Temas", "Imagen_Estatica", RutaImgEst, "ID", IdTema)
                GUARDAR_STR("Temas", "Imagen_Animada", RutaImgAni, "ID", IdTema)
                GUARDAR_STR("Temas", "Sonido", RutaSonido, "ID", IdTema)
                GUARDAR_STR("Temas", "Audio", RutaAudio, "ID", IdTema)
                GUARDAR_INT("Temas", "ID_Asignatura", CBX_AsigNuevoTema.SelectedValue, "ID", IdTema)
                GUARDAR_INT("Temas", "Utilizado", 0, "ID", IdTema)
                LIMPIAR()
                MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Transacción exitosa")
                ' Muestra y refresca la pantalla del list view de niveles y cierra esta
                P_PTemas.Show()
                P_PTemas.REFRESCAR()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al guardar el nuevo tema: " & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub BTNRegresaNuevoTema_Click(sender As Object, e As EventArgs) Handles BTNRegresaNuevoTema.Click
        P_PTemas.Show()
        Me.Close()
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_DescNuevoTema.Clear()
        TXT_NombreNuevoTema.Clear()
        RutaSonido = ""
        RutaImgEst = ""
        RutaImgAni = ""
        RutaAudio = ""
        CBX_AsigNuevoTema.SelectedIndex = -1
        BTN_AgregarNuevoTema.Enabled = False
    End Sub

    '--------------------------------- CARGA DE LOS COMBO BOX --------------------------------
    Public Sub cargarCBXAsig()
        Try
            CBX_AsigNuevoTema.Items.Clear()
            ' Se limpia la tabla temporal y se envía el query a la base de datos, cargando la tabla temporal
            T.Tables.Clear()
            SQL = "SELECT ID, Nombre FROM Asignatura" ' Asegúrate de que este es el nombre correcto de la tabla
            Cargar_Tabla(T, SQL)

            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    ' Se establece una nueva instancia de Asignatura para guardar ambos datos en un solo objeto
                    Dim AsigItem As New ClsAsig()
                    AsigItem.Nombre = T.Tables(0).Rows(i).Item("Nombre").ToString()
                    AsigItem.ID = CInt(T.Tables(0).Rows(i).Item("ID"))

                    ' Se añade el objeto al combo box
                    CBX_AsigNuevoTema.Items.Add(AsigItem)
                Next
                ' Se configura lo que muestra el combo box
                CBX_AsigNuevoTema.DisplayMember = "Nombre"
                CBX_AsigNuevoTema.ValueMember = "ID"
                CBX_AsigNuevoTema.DataSource = T.Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la lista de asignaturas: " & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    '----------------------------------Validación de que todos los campos estén llenos-----------------------------------------------
    Friend Sub VALIDAR()
        ' Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_NombreNuevoTema.Text <> "" And TXT_DescNuevoTema.Text <> "" And RutaAudio <> "" And RutaImgAni <> "" And RutaImgEst <> "" And RutaSonido <> "" And CBX_AsigNuevoTema.SelectedIndex <> -1 Then
            BTN_AgregarNuevoTema.Enabled = True
        Else
            BTN_AgregarNuevoTema.Enabled = False
        End If
    End Sub

    Private Sub TXT_NombreNuevoTema_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreNuevoTema.TextChanged
        VALIDAR()
    End Sub

    Private Sub CBX_AsigNuevoTema_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_AsigNuevoTema.SelectedIndexChanged
        VALIDAR()
    End Sub

    Private Sub TXT_DescNuevoTema_TextChanged(sender As Object, e As EventArgs) Handles TXT_DescNuevoTema.TextChanged
        VALIDAR()
    End Sub

    Private Sub BTN_ImagenEstNuevaTema_Click(sender As Object, e As EventArgs) Handles BTN_ImagenEstNuevaTema.Click
        If OFD_ImgEstaticaTemaNuevo.ShowDialog() > 0 Then
            RutaImgEst = OFD_ImgEstaticaTemaNuevo.FileName
            VALIDAR()
        End If
    End Sub

    Private Sub BTN_ImagenAniNuevoTema_Click(sender As Object, e As EventArgs) Handles BTN_ImagenAniNuevoTema.Click
        If OFD_ImgAnimTemaNuevo.ShowDialog() > 0 Then
            RutaImgAni = OFD_ImgAnimTemaNuevo.FileName
            VALIDAR()
        End If
    End Sub

    Private Sub BTN_AudioNuevoTema_Click(sender As Object, e As EventArgs) Handles BTN_AudioNuevoTema.Click
        If OFD_AudioTemaNuevo.ShowDialog() > 0 Then
            RutaAudio = OFD_AudioTemaNuevo.FileName
            VALIDAR()
        End If
    End Sub

    Private Sub BTN_SonidoTemaNuevo_Click(sender As Object, e As EventArgs) Handles BTN_SonidoTemaNuevo.Click
        If OFD_SonidoTemaNuevo.ShowDialog() > 0 Then
            RutaSonido = OFD_SonidoTemaNuevo.FileName
            VALIDAR()
        End If
    End Sub

    Private Sub E_PNuevoTema_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarNuevoTema.PerformClick()
        End If
    End Sub
End Class



