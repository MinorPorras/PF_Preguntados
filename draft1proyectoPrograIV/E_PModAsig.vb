Public Class E_PModAsig
    Public Property IdAsig As Integer

    '--------------------------------------Metodo cargar--------------------------------------------
    Private Sub E_PModAsig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCBXSeccion()
    End Sub

    '-----------------------------------Función de los botones--------------------------------------
    Private Sub BTN_GuardarModAsig_Click(sender As Object, e As EventArgs) Handles BTN_AgregarModAsig.Click
        ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
        If MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                GUARDAR_STR("Asignatura", "Nombre", TXT_NombreModAsig.Text, "ID", IdAsig)
                GUARDAR_INT("Asignatura", "ID_Seccion", CBX_SeccionModAsig.SelectedValue, "ID", IdAsig)
                GUARDAR_INT("Asignatura", "ID_Profesor", ID_cuenta, "ID", IdAsig)
                LIMPIAR()
                MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Trasacción exitosa")
                'Muestra y refresca la pantalla del list view de niveles y cierra esta
                P_PAsignatura.Show()
                P_PAsignatura.REFRESCAR()
                Me.Close()
                Me.Close()
            Catch ex As Exception
                MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End Try
        End If
    End Sub
    Private Sub BTN_RegresarModAsig_Click(sender As Object, e As EventArgs) Handles BTNRegresaModAsig.Click
        P_PAsignatura.Show()
        Me.Close()
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_NombreModAsig.Clear()
        CBX_SeccionModAsig.SelectedIndex = -1
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
                    CBX_SeccionModAsig.Items.Add(seccionItem)
                Next
                'Se configura lo que muestra el combo box
                CBX_SeccionModAsig.DisplayMember = "Nombre"
                CBX_SeccionModAsig.ValueMember = "ID"
                CBX_SeccionModAsig.DataSource = T.Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la lista de secciones" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    '-----------------------Validación de que todos los campos estén llenos---------------------------------
    Friend Sub VALIDAR()
        'Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_NombreModAsig.Text <> "" And CBX_SeccionModAsig.SelectedIndex <> -1 Then
            BTN_AgregarModAsig.Enabled = True
        Else
            BTN_AgregarModAsig.Enabled = False
        End If
    End Sub
    Private Sub TXT_NombreModAsig_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreModAsig.TextChanged
        VALIDAR()
    End Sub

    Private Sub CBX_SeccionModAsig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_SeccionModAsig.SelectedIndexChanged
        VALIDAR()
    End Sub

    Private Sub E_PModAsig_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarModAsig.PerformClick()
        End If
    End Sub
End Class

