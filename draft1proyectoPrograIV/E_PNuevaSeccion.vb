Public Class E_PNuevaSeccion
    Public IdSeccion As Integer

    '--------------------------------------Metodo cargar--------------------------------------------
    Private Sub E_PNuevaSeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCBXNivel()
        'Al cargar la pagina obtiene una PK nueva
        IdSeccion = OBTENERPK("Seccion", "ID")
    End Sub

    '-----------------------------------Función de los botones--------------------------------------
    Private Sub BTN_AgregarNuevaSeccion_Click(sender As Object, e As EventArgs) Handles BTN_AgregarNuevaSeccion.Click
        Try
            'Comprobación de que se quiere agregar la información a la base de datos por parte del usuario
            If MessageBox.Show("Desea guardar esta información", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'Si la PK que esté guardada en IdCat no existe en la base de datos en ese tabla...
                If EXISTEPK("Seccion", "ID", IdSeccion) = False Then 'Si no se ha guardado la categoría
                    'Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                    GUARDAR_PK("Seccion", "ID", IdSeccion)
                End If
                'Guarda la información en la db, limpia los datos en la textbox y le informa al usuario que todo salio bien
                GUARDAR_STR("Seccion", "Nombre", TXT_NombreNuevaSeccion.Text, "ID", IdSeccion)
                GUARDAR_INT("Seccion", "ID_Nivel", CBX_NivelModSeccion.SelectedValue, "ID", IdSeccion)
                GUARDAR_INT("Seccion", "Utilizado", 0, "ID", IdSeccion)
                LIMPIAR()
                MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Trasacción exitosa")
                'Muestra y refresca la pantalla del list view de niveles y cierra esta
                P_PSeccion.Show()
                P_PSeccion.REFRESCAR()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al guardar la nueva sección" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub BTNRegresaNuevaSeccion_Click(sender As Object, e As EventArgs) Handles BTNRegresaNuevaSeccion.Click
        P_PSeccion.Show()
        Me.Close()
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_NombreNuevaSeccion.Clear()
        CBX_NivelModSeccion.SelectedIndex = -1
    End Sub

    '--------------------------------- CARGA DE LOS COMBO BOX --------------------------------
    Friend Sub cargarCBXNivel()
        Try
            'Se limpia la tabla temporal y se envía el query a la base de datos, cargando la tabla temporal
            SQL = "SELECT * FROM Nivel"
            T.Tables.Clear()
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    'Se establece una nueva instancia de Nivel para guardar ambos datos en un solo objeto
                    Dim nivelItem As New ClsNivel()
                    nivelItem.Nombre = T.Tables(0).Rows(i).Item(1)
                    nivelItem.ID = T.Tables(0).Rows(i).Item(0)

                    'Se añade el objeto al combo box
                    CBX_NivelModSeccion.Items.Add(nivelItem)
                Next
                'Se configura lo que muestra el combo box
                CBX_NivelModSeccion.DisplayMember = "Nombre"
                CBX_NivelModSeccion.ValueMember = "ID"
                CBX_NivelModSeccion.DataSource = T.Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la lista de niveles" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    '-----------------------Validación de que todos los campos estén llenos---------------------------------
    Friend Sub VALIDAR()
        'Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_NombreNuevaSeccion.Text <> "" And CBX_NivelModSeccion.SelectedIndex <> -1 Then
            BTN_AgregarNuevaSeccion.Enabled = True
        Else
            BTN_AgregarNuevaSeccion.Enabled = False
        End If
    End Sub

    Private Sub TXT_NombreNuevaSeccion_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreNuevaSeccion.TextChanged
        VALIDAR()
    End Sub

    Private Sub CBX_NivelModSeccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_NivelModSeccion.SelectedIndexChanged
        VALIDAR()
    End Sub

    Private Sub E_PNuevaSeccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarNuevaSeccion.PerformClick()
        End If
    End Sub
End Class