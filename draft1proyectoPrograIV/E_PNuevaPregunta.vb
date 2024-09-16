Public Class E_PNuevaPregunta
    Public IdPregunta As Integer

    '--------------------------------------Metodo cargar--------------------------------------------
    Private Sub E_PNuevaPregunta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCBXCategoria()
        IdPregunta = OBTENERPK("Preguntas", "ID")
    End Sub

    '-----------------------------------Función de los botones--------------------------------------
    Private Sub BTN_AgregarPreNuevo_Click(sender As Object, e As EventArgs) Handles BTN_AgregarPreNuevo.Click
        Try
            'Comprobación de que se quiere agregar la información a la base de datos por parte del usuario
            If MessageBox.Show("Desea guardar esta información", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                'Si la PK que esté guardada en IdCat no existe en la base de datos en ese tabla...
                If EXISTEPK("Preguntas", "ID", IdPregunta) = False Then 'Si no se ha guardado la categoría
                    'Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                    GUARDAR_PK("Preguntas", "ID", IdPregunta)
                End If
                'Guarda la información en la db, limpia los datos en la textbox y le informa al usuario que todo salio bien
                GUARDAR_STR("Preguntas", "Texto", TXT_PreguntaNueva.Text, "ID", IdPregunta)
                GUARDAR_STR("Preguntas", "Explicacion", TXT_NExplicacion.Text, "ID", IdPregunta)
                GUARDAR_INT("Preguntas", "ID_Categoria", CBX_CategoriaNuevaPregunta.SelectedValue, "ID", IdPregunta)
                Dim Tiempo = New TimeSpan(0, Convert.ToInt32(NUD_MinutosNPregunta.Text), Convert.ToInt32(NUD_SegundosNPregunta.Text))
                GUARDAR_TIME("Preguntas", "Tiempo", Tiempo, "ID", IdPregunta)
                GUARDAR_INT("Preguntas", "Puntaje", NUD_PuntajeNPregunta.Value, "ID", IdPregunta)
                GUARDAR_INT("Preguntas", "Utilizado", 0, "ID", IdPregunta)
                LIMPIAR()
                MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Trasacción exitosa")
                'Muestra y refresca la pantalla del list view de niveles y cierra esta
                P_PPreguntas.Show()
                P_PPreguntas.REFRESCAR()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al guardar la nueva respuesta" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub BTN_RegresarPreNuevo_Click(sender As Object, e As EventArgs) Handles BTN_RegresarPreNuevo.Click
        P_PPreguntas.Show()
        Me.Close()
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_PreguntaNueva.Clear()
        TXT_NExplicacion.Clear()
        NUD_PuntajeNPregunta.Value = 0
        NUD_SegundosNPregunta.Value = 0
        CBX_CategoriaNuevaPregunta.SelectedIndex = -1
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
                    CBX_CategoriaNuevaPregunta.Items.Add(CatItem)
                Next
                'Se configura lo que muestra el combo box
                CBX_CategoriaNuevaPregunta.DisplayMember = "Nombre"
                CBX_CategoriaNuevaPregunta.ValueMember = "ID"
                CBX_CategoriaNuevaPregunta.DataSource = T.Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la lista de categorías" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    '-----------------------Validación de que todos los campos estén llenos---------------------------------
    Friend Sub VALIDAR()
        'Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_PreguntaNueva.Text <> "" And TXT_NExplicacion.Text <> "" And (NUD_SegundosNPregunta.Value <> 0 Or NUD_MinutosNPregunta.Value <> 0) And NUD_PuntajeNPregunta.Value >= 0 And CBX_CategoriaNuevaPregunta.SelectedIndex <> -1 Then
            BTN_AgregarPreNuevo.Enabled = True
        Else
            BTN_AgregarPreNuevo.Enabled = False
        End If
    End Sub

    Private Sub TXT_PreguntaNueva_TextChanged(sender As Object, e As EventArgs) Handles TXT_PreguntaNueva.TextChanged
        VALIDAR()
    End Sub

    Private Sub NUD_TiempoNPregunta_ValueChanged(sender As Object, e As EventArgs) Handles NUD_SegundosNPregunta.ValueChanged
        VALIDAR()
    End Sub

    Private Sub NUD_PuntajeNPregunta_ValueChanged(sender As Object, e As EventArgs) Handles NUD_PuntajeNPregunta.ValueChanged
        VALIDAR()
    End Sub

    Private Sub CBX_CategoriaNuevaPregunta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_CategoriaNuevaPregunta.SelectedIndexChanged
        VALIDAR()
    End Sub

    Private Sub NUD_MinutosNPregunta_ValueChanged(sender As Object, e As EventArgs) Handles NUD_MinutosNPregunta.ValueChanged
        VALIDAR()
    End Sub

    Private Sub TXT_NExplicacion_TextChanged(sender As Object, e As EventArgs) Handles TXT_NExplicacion.TextChanged
        VALIDAR()
    End Sub

    Private Sub E_PNuevaPregunta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarPreNuevo.PerformClick()
        End If
    End Sub
End Class