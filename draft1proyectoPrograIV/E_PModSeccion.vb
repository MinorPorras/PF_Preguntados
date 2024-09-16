Public Class E_PModSeccion

    Public IdSeccion As Integer

    '--------------------------------------Metodo cargar--------------------------------------------
    Private Sub E_PModSeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCBXNivel()
    End Sub

    '-----------------------------------Función de los botones--------------------------------------
    Private Sub BTN_GuardarModSeccion_Click(sender As Object, e As EventArgs) Handles BTN_AgregarModSeccion.Click
        ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
        If MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                'Guarda la información en la db, limpia los datos en la textbox y le informa al usuario que todo salio bien
                GUARDAR_STR("Seccion", "Nombre", TXT_NombreModSeccion.Text, "ID", IdSeccion)
                GUARDAR_INT("Seccion", "ID_Nivel", CBX_NivelModSeccion.SelectedValue, "ID", IdSeccion)
                'Muestra y refresca la pantalla del list view de niveles y cierra esta
                P_PSeccion.Show()
                P_PSeccion.REFRESCAR()
                Me.Close()
            Catch ex As Exception
                MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End Try
        End If
    End Sub
    Private Sub BTN_RegresarModSeccion_Click(sender As Object, e As EventArgs) Handles BTNRegresaModSeccion.Click
        P_PSeccion.Show()
        Me.Close()
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_NombreModSeccion.Clear()
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
        If TXT_NombreModSeccion.Text <> "" And CBX_NivelModSeccion.SelectedValue <> -1 Then
            BTN_AgregarModSeccion.Enabled = True
        Else
            BTN_AgregarModSeccion.Enabled = False
        End If
    End Sub

    Private Sub TXT_NombreModSeccion_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreModSeccion.TextChanged
        VALIDAR()
    End Sub

    Private Sub CBX_NivelModSeccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_NivelModSeccion.SelectedIndexChanged
        VALIDAR()
    End Sub

    Private Sub E_PModSeccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarModSeccion.PerformClick()
        End If
    End Sub
End Class