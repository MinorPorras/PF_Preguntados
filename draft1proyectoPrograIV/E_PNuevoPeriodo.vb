Public Class E_PNuevoPeriodo
    Public IdPeriodo As Integer

    '--------------------------------------Metodo cargar--------------------------------------------
    Private Sub E_PNuevoPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IdPeriodo = OBTENERPK("Periodo", "ID")
    End Sub

    '-----------------------------------Función de los botones--------------------------------------
    Private Sub BTN_AgregarNuevoPeriodo_Click(sender As Object, e As EventArgs) Handles BTN_AgregarNuevoPeriodo.Click
        Try
            'Comprobación de que se quiere agregar la información a la base de datos por parte del usuario
            If MessageBox.Show("Desea guardar esta información", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'Si la PK que esté guardada en IdCat no existe en la base de datos en ese tabla...
                If EXISTEPK("Periodo", "ID", IdPeriodo) = False Then 'Si no se ha guardado la categoría
                    'Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                    GUARDAR_PK("Periodo", "ID", IdPeriodo)
                End If
                'Guarda la información en la db, limpia los datos en la textbox y le informa al usuario que todo salio bien
                GUARDAR_STR("Periodo", "Nombre", TXT_NombreNuevoPeriodo.Text, "ID", IdPeriodo)
                GUARDAR_INT("Periodo", "Utilizado", 0, "ID", IdPeriodo)
                LIMPIAR()
                MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Trasacción exitosa")
                'Muestra y refresca la pantalla del list view de niveles y cierra esta
                P_PPeriodo.Show()
                P_PPeriodo.REFRESCAR()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al guardar el nuevo periodo" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub BTNRegresaNuevoPeriodo_Click(sender As Object, e As EventArgs) Handles BTNRegresaNuevoPeriodo.Click
        P_PPeriodo.Show()
        Me.Close()
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_NombreNuevoPeriodo.Clear()
    End Sub

    '-----------------------Validación de que todos los campos estén llenos---------------------------------
    Friend Sub VALIDAR()
        'Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_NombreNuevoPeriodo.Text <> "" Then
            BTN_AgregarNuevoPeriodo.Enabled = True
        Else
            BTN_AgregarNuevoPeriodo.Enabled = False
        End If
    End Sub

    Private Sub TXT_NombreNuevoPeriodo_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreNuevoPeriodo.TextChanged
        VALIDAR()
    End Sub

    Private Sub E_PNuevoPeriodo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarNuevoPeriodo.PerformClick()
        End If
    End Sub
End Class