Public Class FrmModPregunta
    Public IdPregunta As Integer
    '--------------------------------------Metodo cargar--------------------------------------------
    Private Sub FrmModPregunta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCBXCategoria()
    End Sub

    '-----------------------------------Función de los botones--------------------------------------
    Private Sub BTN_AgregarPreMod_Click(sender As Object, e As EventArgs) Handles BTN_AgregarPreMod.Click
        Try
            'Comprobación de que se quiere agregar la información a la base de datos por parte del usuario
            If MessageBox.Show("Desea guardar esta información", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                'Si la PK que esté guardada en IdCat no existe en la base de datos en ese tabla...
                If EXISTEPK("Preguntas", "ID", IdPregunta) = False Then 'Si no se ha guardado la categoría
                    'Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                    GUARDAR_PK("Preguntas", "ID", IdPregunta)
                End If
                'Guarda la información en la db, limpia los datos en la textbox y le informa al usuario que todo salio bien
                GUARDAR_STR("Preguntas", "Texto", TXT_PreguntaMod.Text, "ID", IdPregunta)
                GUARDAR_STR("Preguntas", "Explicacion", TXT_ModExplicacion.Text, "ID", IdPregunta)
                GUARDAR_INT("Preguntas", "ID_Categoria", CBX_CategoriaModPregunta.SelectedValue, "ID", IdPregunta)
                Dim Tiempo = New TimeSpan(0, Convert.ToInt32(NUD_MinutosModPregunta.Text), Convert.ToInt32(NUD_SegundosModPregunta.Text))
                GUARDAR_TIME("Preguntas", "Tiempo", Tiempo, "ID", IdPregunta)
                GUARDAR_INT("Preguntas", "Puntaje", NUD_PuntajeModPregunta.Value, "ID", IdPregunta)
                LIMPIAR()
                MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Trasacción exitosa")
                'Muestra y refresca la pantalla del list view de niveles y cierra esta
                P_PPreguntas.Show()
                P_PPreguntas.REFRESCAR()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al guardar la pregunta" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub


    Private Sub BTN_RegresarPreMod_Click(sender As Object, e As EventArgs) Handles BTN_RegresarPreMod.Click
        P_PPreguntas.Show()
        Me.Close()
    End Sub

    '--------------------------------- CARGA DE LOS COMBO BOX --------------------------------
    Private Sub CargarCBXCategoria()
        Try
            'Se limpia la tabla temporal y se envía el query a la base de datos, cargando la tabla temporal
            SQL = "SELECT ID, Nombre FROM Categoria"
            T.Tables.Clear()
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    'Se establece una nueva instancia de Nivel para guardar ambos datos en un solo objeto
                    Dim CatItem As New ClsCategoria()
                    CatItem.ID = T.Tables(0).Rows(i).Item(0)
                    CatItem.Nombre = T.Tables(0).Rows(i).Item(1)

                    'Se añade el objeto al combo box
                    CBX_CategoriaModPregunta.Items.Add(CatItem)
                Next
                'Se configura lo que muestra el combo box
                CBX_CategoriaModPregunta.DisplayMember = "Nombre"
                CBX_CategoriaModPregunta.ValueMember = "ID"
                CBX_CategoriaModPregunta.DataSource = T.Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la lista de categorías" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_PreguntaMod.Clear()
        TXT_ModExplicacion.Clear()
        NUD_MinutosModPregunta.Value = 0
        NUD_SegundosModPregunta.Value = 0
        CBX_CategoriaModPregunta.SelectedIndex = -1
    End Sub


    '-----------------------Validación de que todos los campos estén llenos---------------------------------
    Friend Sub VALIDAR()
        'Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_PreguntaMod.Text <> "" And TXT_ModExplicacion.Text <> "" And (NUD_SegundosModPregunta.Value <> 0 Or NUD_MinutosModPregunta.Value <> 0) And NUD_PuntajeModPregunta.Value >= 0 And CBX_CategoriaModPregunta.SelectedIndex <> -1 Then
            BTN_AgregarPreMod.Enabled = True
        Else
            BTN_AgregarPreMod.Enabled = False
        End If
    End Sub

    Private Sub TXT_PreguntaMod_TextChanged(sender As Object, e As EventArgs) Handles TXT_PreguntaMod.TextChanged
        VALIDAR()
    End Sub

    Private Sub CBX_CategoriaModPregunta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_CategoriaModPregunta.SelectedIndexChanged
        VALIDAR()
    End Sub

    Private Sub NUD_PuntajeModPregunta_ValueChanged(sender As Object, e As EventArgs) Handles NUD_PuntajeModPregunta.ValueChanged
        VALIDAR()
    End Sub

    Private Sub NUD_MinutosModPregunta_ValueChanged(sender As Object, e As EventArgs) Handles NUD_MinutosModPregunta.ValueChanged
        VALIDAR()
    End Sub

    Private Sub NUD_SegundosModPregunta_ValueChanged(sender As Object, e As EventArgs) Handles NUD_SegundosModPregunta.ValueChanged
        VALIDAR()
    End Sub

    Private Sub TXT_ModExplicacion_TextChanged(sender As Object, e As EventArgs) Handles TXT_ModExplicacion.TextChanged
        VALIDAR()
    End Sub

    Private Sub FrmModPregunta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarPreMod.PerformClick()
        End If
    End Sub
End Class