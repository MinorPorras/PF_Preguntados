Public Class E_PNuevaAsig
    Public IdAsig As Integer

    '--------------------------------------Metodo cargar--------------------------------------------
    Private Sub E_PNuevaAsig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCBXSeccion()
        'Al cargar la pagina obtiene una PK nueva
        IdAsig = OBTENERPK("Asignatura", "ID")
    End Sub

    '-----------------------------------Función de los botones--------------------------------------
    Private Sub BTN_AgregarNuevaAsig_Click(sender As Object, e As EventArgs) Handles BTN_AgregarNuevaAsig.Click
        Try
            'Comprobación de que se quiere agregar la información a la base de datos por parte del usuario
            If MessageBox.Show("Desea guardar esta información", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'Si la PK que esté guardada en IdCat no existe en la base de datos en ese tabla...
                If EXISTEPK("Asignatura", "ID", IdAsig) = False Then 'Si no se ha guardado la categoría
                    'Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                    GUARDAR_PK("Asignatura", "ID", IdAsig)
                End If
                'Guarda la información en la db, limpia los datos en la textbox y le informa al usuario que todo salio bien
                GUARDAR_STR("Asignatura", "Nombre", TXT_NombreNuevaAsig.Text, "ID", IdAsig)
                GUARDAR_INT("Asignatura", "ID_Seccion", CBX_SeccionNuevaAsig.SelectedValue, "ID", IdAsig)
                GUARDAR_INT("Asignatura", "ID_Profesor", ID_cuenta, "ID", IdAsig)
                GUARDAR_INT("Asignatura", "Utilizado", 0, "ID", IdAsig)
                LIMPIAR()
                MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Trasacción exitosa")
                'Muestra y refresca la pantalla del list view de niveles y cierra esta
                P_PAsignatura.Show()
                P_PAsignatura.REFRESCAR()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al guardar la nueva asignatura" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub BTNRegresaNuevaAsig_Click(sender As Object, e As EventArgs) Handles BTNRegresaNuevaAsig.Click
        P_PAsignatura.Show()
        Me.Close()
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_NombreNuevaAsig.Clear()
        CBX_SeccionNuevaAsig.SelectedIndex = -1
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
                    CBX_SeccionNuevaAsig.Items.Add(seccionItem)
                Next
                'Se configura lo que muestra el combo box
                CBX_SeccionNuevaAsig.DisplayMember = "Nombre"
                CBX_SeccionNuevaAsig.ValueMember = "ID"
                CBX_SeccionNuevaAsig.DataSource = T.Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la lista de secciones" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    '-----------------------Validación de que todos los campos estén llenos---------------------------------
    Friend Sub VALIDAR()
        'Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_NombreNuevaAsig.Text <> "" And CBX_SeccionNuevaAsig.SelectedIndex <> -1 Then
            BTN_AgregarNuevaAsig.Enabled = True
        Else
            BTN_AgregarNuevaAsig.Enabled = False
        End If
    End Sub

    Private Sub TXT_NombreNuevaAsig_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreNuevaAsig.TextChanged
        VALIDAR()
    End Sub

    Private Sub CBX_SeccionNuevaAsig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_SeccionNuevaAsig.SelectedIndexChanged
        VALIDAR()
    End Sub

    Private Sub CBX_Profesor_SelectedIndexChanged(sender As Object, e As EventArgs)
        VALIDAR()
    End Sub

    Private Sub E_PNuevaAsig_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarNuevaAsig.PerformClick()
        End If
    End Sub
End Class