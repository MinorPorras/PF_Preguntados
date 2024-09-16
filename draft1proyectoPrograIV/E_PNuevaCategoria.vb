Public Class E_PNuevaCategoria
    '-----------------------DEFINICIÓN DE VARIABLES NECESARIAS------------------------------
    Dim RutaImgEst As String
    Dim RutaImgAni As String
    Dim RutaAudio As String
    Public IdCat As String

    '--------------------------------------Metodo cargar--------------------------------------------
    Private Sub E_PNuevaCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCBXTema()
        'Al cargar la página obtiene una PK nueva
        IdCat = OBTENERPK("Categoria", "ID")
    End Sub

    '-----------------------------------Función de los botones (EXCEPTO DE LAS IMAGENES)--------------------------------------
    Private Sub BTN_AgregarNuevaCat_Click(sender As Object, e As EventArgs) Handles BTN_AgregarNuevaCat.Click
        Try
            'Comprobación de que se quiere agregar la información a la base de datos por parte del usuario
            If MessageBox.Show("Desea guardar esta información", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                'Si la PK que esté guardada en IdCat no existe en la base de datos en ese tabla...
                If EXISTEPK("Categoria", "ID", IdCat) = False Then 'Si no se ha guardado la categoría
                    'Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                    GUARDAR_PK("Categoria", "ID", IdCat)
                End If
                'Guarda la información en la db, limpia los datos en la textbox y le informa al usuario que todo salió bien
                GUARDAR_STR("Categoria", "Nombre", TXT_NombreNuevaCat.Text, "ID", IdCat)
                GUARDAR_STR("Categoria", "Descripcion", TXT_Desc_NuevaCat.Text, "ID", IdCat)
                GUARDAR_STR("Categoria", "Imagen_Estatica", RutaImgEst, "ID", IdCat)
                GUARDAR_STR("Categoria", "Imagen_Animada", RutaImgAni, "ID", IdCat)
                GUARDAR_STR("Categoria", "Audio", RutaAudio, "ID", IdCat)
                GUARDAR_INT("Categoria", "ID_Tema", CBX_Tema_NuevaCat.SelectedValue, "ID", IdCat)
                GUARDAR_INT("Categoria", "Utilizado", 0, "ID", IdCat)
                LIMPIAR()
                MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Transacción exitosa")
                'Muestra y refresca la pantalla del list view de niveles y cierra esta
                P_PCategoria.Show()
                P_PCategoria.REFRESCAR()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al guardar la nueva categoría" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub BTN_RegresarNuevaCat_Click(sender As Object, e As EventArgs) Handles BTN_RegresarNuevaCat.Click
        P_PCategoria.Show()
        Me.Close()
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_NombreNuevaCat.Clear()
        TXT_Desc_NuevaCat.Clear()
        RutaImgEst = ""
        RutaImgAni = ""
        RutaAudio = ""
        CBX_Tema_NuevaCat.SelectedIndex = -1
    End Sub

    '--------------------------------- CARGA DE LOS COMBO BOX --------------------------------
    Private Sub cargarCBXTema()
        Try
            CBX_Tema_NuevaCat.Items.Clear()
            'Se limpia la tabla temporal y se envía el query a la base de datos, cargando la tabla temporal
            T.Tables.Clear()
            SQL = "SELECT ID, Nombre FROM Temas"
            Cargar_Tabla(T, SQL)

            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    'Se establece una nueva instancia de Tema para guardar ambos datos en un solo objeto
                    Dim TemaItem As New ClsTema()
                    TemaItem.Nombre = T.Tables(0).Rows(i).Item("Nombre").ToString()
                    TemaItem.ID = T.Tables(0).Rows(i).Item("ID").ToString()

                    'Se añade el objeto al combo box
                    CBX_Tema_NuevaCat.Items.Add(TemaItem)
                Next
                'Se configura lo que muestra el combo box
                CBX_Tema_NuevaCat.DisplayMember = "Nombre"
                CBX_Tema_NuevaCat.ValueMember = "ID"
                CBX_Tema_NuevaCat.DataSource = T.Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la lista de temas" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    '----------------------------------Validación de que todos los campos estén llenos-----------------------------------------------
    Friend Sub VALIDAR()
        'Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_Desc_NuevaCat.Text <> "" And TXT_NombreNuevaCat.Text <> "" And RutaAudio <> "" And RutaImgAni <> "" And RutaImgEst <> "" And CBX_Tema_NuevaCat.SelectedIndex <> -1 Then
            BTN_AgregarNuevaCat.Enabled = True
        Else
            BTN_AgregarNuevaCat.Enabled = False
        End If
    End Sub

    Private Sub TXT_NombreNuevaCat_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreNuevaCat.TextChanged
        VALIDAR()
    End Sub

    Private Sub CBX_Tema_NuevaCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_Tema_NuevaCat.SelectedIndexChanged
        VALIDAR()
    End Sub

    Private Sub TXT_Desc_NuevaCat_TextChanged(sender As Object, e As EventArgs) Handles TXT_Desc_NuevaCat.TextChanged
        VALIDAR()
    End Sub

    Private Sub BTN_imgEstNuevaCat_Click(sender As Object, e As EventArgs) Handles BTN_imgEstNuevaCat.Click
        If OFD_ImgEstCatNueva.ShowDialog() > 0 Then
            RutaImgEst = OFD_ImgEstCatNueva.FileName
        End If
        VALIDAR()
    End Sub

    Private Sub BTN_ImgAniNuevaCat_Click(sender As Object, e As EventArgs) Handles BTN_ImgAniNuevaCat.Click
        If OFD_ImgAniNuevaCat.ShowDialog() > 0 Then
            RutaImgAni = OFD_ImgAniNuevaCat.FileName
        End If
        VALIDAR()
    End Sub

    Private Sub BTN_AudioNuevaCat_Click(sender As Object, e As EventArgs) Handles BTN_AudioNuevaCat.Click
        If OFD_AudioNuevaCat.ShowDialog() > 0 Then
            RutaAudio = OFD_AudioNuevaCat.FileName
        End If
        VALIDAR()
    End Sub

    Private Sub E_PNuevaCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarNuevaCat.PerformClick()
        End If
    End Sub
End Class
