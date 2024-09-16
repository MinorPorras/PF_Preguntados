Public Class E_PModCategoria
    '-----------------------DEFINICIÓN DE VARIABLES NECESARIAS------------------------------
    Public Property IdCat As Integer
    Public RutaImgEst As String
    Public RutaImgAni As String
    Public RutaAudio As String

    '--------------------------------------Metodo cargar--------------------------------------------
    Private Sub E_PModCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar los temas en el ComboBox
        cargarCBXTema()
    End Sub

    '-----------------------------------Función de los botones (EXCEPTO DE LAS IMAGENES)--------------------------------------
    Private Sub BTN_GuardarModCat_Click(sender As Object, e As EventArgs) Handles BTN_GuardarModCat.Click
        ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
        If MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                'Guarda la información en la db, limpia los datos en la textbox y le informa al usuario que todo salió bien
                GUARDAR_STR("Categoria", "Nombre", TXT_NombreModCat.Text, "ID", IdCat)
                GUARDAR_STR("Categoria", "Descripcion", TXT_DescModCat.Text, "ID", IdCat)
                GUARDAR_STR("Categoria", "Imagen_Estatica", RutaImgEst, "ID", IdCat)
                GUARDAR_STR("Categoria", "Imagen_Animada", RutaImgAni, "ID", IdCat)
                GUARDAR_STR("Categoria", "Audio", RutaAudio, "ID", IdCat)
                GUARDAR_INT("Categoria", "ID_Tema", CBX_TemaModCat.SelectedValue, "ID", IdCat)
                LIMPIAR()
                MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Transacción exitosa")
                'Muestra y refresca la pantalla del list view de niveles y cierra esta
                P_PCategoria.Show()
                P_PCategoria.REFRESCAR()
                Me.Close()
            Catch ex As Exception
                MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End Try
        End If
    End Sub

    Private Sub BTN_RegresarModCat_Click(sender As Object, e As EventArgs) Handles BTN_RegresarModCat.Click
        P_PCategoria.Show()
        Me.Close()
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_NombreModCat.Clear()
        TXT_DescModCat.Clear()
        RutaImgEst = ""
        RutaImgAni = ""
        RutaAudio = ""
        CBX_TemaModCat.SelectedIndex = -1
    End Sub

    '--------------------------------- CARGA DE LOS COMBO BOX --------------------------------
    Private Sub cargarCBXTema()
        Try
            CBX_TemaModCat.Items.Clear()
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
                    CBX_TemaModCat.Items.Add(TemaItem)
                Next
                'Se configura lo que muestra el combo box
                CBX_TemaModCat.DisplayMember = "Nombre"
                CBX_TemaModCat.ValueMember = "ID"
                CBX_TemaModCat.DataSource = T.Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la lista de temas" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    '----------------------------------Validación de que todos los campos estén llenos-----------------------------------------------
    Friend Sub VALIDAR()
        'Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_DescModCat.Text <> "" And TXT_NombreModCat.Text <> "" And RutaAudio <> "" And RutaImgAni <> "" And RutaImgEst <> "" And CBX_TemaModCat.SelectedIndex <> -1 Then
            BTN_GuardarModCat.Enabled = True
        Else
            BTN_GuardarModCat.Enabled = False
        End If
    End Sub

    Private Sub BTN_ImagenEstModCat_Click(sender As Object, e As EventArgs) Handles BTN_imgEstModCat.Click
        If OFD_ImgEstCatMod.ShowDialog() = DialogResult.OK Then
            RutaImgEst = OFD_ImgEstCatMod.FileName
            VALIDAR()
        End If
    End Sub

    Private Sub BTN_ImagenAniModCat_Click(sender As Object, e As EventArgs) Handles BTN_ImgAniModCat.Click
        If OFD_ImgAniModCat.ShowDialog() = DialogResult.OK Then
            RutaImgAni = OFD_ImgAniModCat.FileName
            VALIDAR()
        End If
    End Sub

    Private Sub BTN_AudioModCat_Click(sender As Object, e As EventArgs) Handles BTN_AudioModCat.Click
        If OFD_AudioModCat.ShowDialog() = DialogResult.OK Then
            RutaAudio = OFD_AudioModCat.FileName
            VALIDAR()
        End If
    End Sub

    Private Sub TXT_NombreModCat_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreModCat.TextChanged
        VALIDAR()
    End Sub

    Private Sub CBX_TemaModCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_TemaModCat.SelectedIndexChanged
        VALIDAR()
    End Sub

    Private Sub TXT_DescModCat_TextChanged(sender As Object, e As EventArgs) Handles TXT_DescModCat.TextChanged
        VALIDAR()
    End Sub

    Private Sub E_PModCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_GuardarModCat.PerformClick()
        End If
    End Sub
End Class
