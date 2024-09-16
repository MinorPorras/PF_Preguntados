Public Class E_PModTema
    '-----------------------DEFINICIÓN DE VARIABLES NECESARIAS------------------------------
    Public Property IdTema As Integer
    Public RutaImgEst As String
    Public RutaImgAni As String
    Public RutaAudio As String
    Public RutaSonido As String

    '--------------------------------------Metodo cargar--------------------------------------------
    Private Sub E_PModTema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar las asignaturas en el ComboBox
        cargarCBXAsig()
        VALIDAR()
    End Sub

    '-----------------------------------Función de los botones (EXCEPTO DE LAS IMAGENES)--------------------------------------
    Private Sub BTN_GuardarModTema_Click(sender As Object, e As EventArgs) Handles BTN_GuardarModTema.Click
        ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
        If MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                ' Actualizar los campos en la base de datos
                GUARDAR_STR("Temas", "Nombre", TXT_NombreModTema.Text, "ID", IdTema)
                GUARDAR_STR("Temas", "Descripción", TXT_DescModTema.Text, "ID", IdTema)
                GUARDAR_STR("Temas", "Imagen_Estatica", RutaImgEst, "ID", IdTema)
                GUARDAR_STR("Temas", "Imagen_Animada", RutaImgAni, "ID", IdTema)
                GUARDAR_STR("Temas", "Sonido", RutaSonido, "ID", IdTema)
                GUARDAR_STR("Temas", "Audio", RutaAudio, "ID", IdTema)
                GUARDAR_INT("Temas", "ID_Asignatura", CBX_AsigModTema.SelectedValue, "ID", IdTema)
                LIMPIAR()
                MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Transacción exitosa")
                ' Muestra y refresca la pantalla del list view de niveles y cierra esta
                P_PTemas.Show()
                P_PTemas.REFRESCAR()
                Me.Close()
            Catch ex As Exception
                MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End Try
        End If
    End Sub
    Private Sub BTN_RegresarModTema_Click(sender As Object, e As EventArgs) Handles BTN_RegresaModTema.Click
        P_PTemas.Show()
        Me.Close()
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_NombreModTema.Clear()
        TXT_DescModTema.Clear()
        RutaImgEst = ""
        RutaImgAni = ""
        RutaAudio = ""
        RutaSonido = ""
        CBX_AsigModTema.SelectedIndex = -1
    End Sub

    '--------------------------------- CARGA DE LOS COMBO BOX --------------------------------
    Public Sub cargarCBXAsig()
        Try
            CBX_AsigModTema.Items.Clear()
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
                    CBX_AsigModTema.Items.Add(AsigItem)
                Next
                ' Se configura lo que muestra el combo box
                CBX_AsigModTema.DisplayMember = "Nombre"
                CBX_AsigModTema.ValueMember = "ID"
                CBX_AsigModTema.DataSource = T.Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la lista de asignaturas" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    '----------------------------------Validación de que todos los campos estén llenos-----------------------------------------------
    Friend Sub VALIDAR()
        ' Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_NombreModTema.Text <> "" And TXT_DescModTema.Text <> "" And RutaAudio <> "" And RutaImgAni <> "" And RutaImgEst <> "" And RutaSonido <> "" And CBX_AsigModTema.SelectedIndex <> -1 Then
            BTN_GuardarModTema.Enabled = True
        Else
            BTN_GuardarModTema.Enabled = False
        End If
    End Sub

    Private Sub BTN_ImagenEstModTema_Click(sender As Object, e As EventArgs) Handles BTN_ImagenEstModTema.Click
        If OFD_ImgEstaticaTemaMod.ShowDialog() = DialogResult.OK Then
            RutaImgEst = OFD_ImgEstaticaTemaMod.FileName
            VALIDAR()
        End If
    End Sub

    Private Sub BTN_ImagenAniModTema_Click(sender As Object, e As EventArgs) Handles BTN_ImagenAniModTema.Click
        If OFD_ImgAnimTemaMod.ShowDialog() = DialogResult.OK Then
            RutaImgAni = OFD_ImgAnimTemaMod.FileName
            VALIDAR()
        End If
    End Sub

    Private Sub BTN_AudioModTema_Click(sender As Object, e As EventArgs) Handles BTN_AudioModTema.Click
        If OFD_AudioTemaMod.ShowDialog() = DialogResult.OK Then
            RutaAudio = OFD_AudioTemaMod.FileName
            VALIDAR()
        End If
    End Sub

    Private Sub BTN_SonidoTemaMod_Click(sender As Object, e As EventArgs) Handles BTN_SonidoTemaMod.Click
        If OFD_SonidoTemaMod.ShowDialog() = DialogResult.OK Then
            RutaSonido = OFD_SonidoTemaMod.FileName
            VALIDAR()
        End If
    End Sub

    Private Sub TXT_DescModTema_TextChanged(sender As Object, e As EventArgs) Handles TXT_DescModTema.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_NombreModTema_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreModTema.TextChanged
        VALIDAR()
    End Sub

    Private Sub CBX_AsigModTema_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_AsigModTema.SelectedIndexChanged
        VALIDAR()
    End Sub

    Private Sub E_PModTema_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_GuardarModTema.PerformClick()
        End If
    End Sub
End Class
