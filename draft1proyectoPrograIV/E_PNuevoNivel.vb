Public Class E_PNuevoNivel
    Public IdCat As Integer

    '--------------------------------------Metodo cargar--------------------------------------------
    Private Sub E_PNuevoNivel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Al cargar la pagina obtiene una PK nueva
        IdCat = OBTENERPK("Nivel", "ID")
    End Sub

    '-----------------------------------Función de los botones--------------------------------------
    Private Sub BTN_AgregarNuevaNivel_Click(sender As Object, e As EventArgs) Handles BTN_AgregarNuevaNivel.Click
        Try
            'Comprobación de que se quiere agregar la información a la base de datos por parte del usuario
            If MessageBox.Show("Desea guardar esta información", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'Si la PK que esté guardada en IdCat no existe en la base de datos en ese tabla...
                If EXISTEPK("Nivel", "ID", IdCat) = False Then 'Si no se ha guardado la categoría
                    'Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                    GUARDAR_PK("Nivel", "ID", IdCat)
                End If
                'Guarda la información en la db, limpia los datos en la textbox y le informa al usuario que todo salio bien
                GUARDAR_STR("Nivel", "Nombre", TXT_NombreNuevoNivel.Text, "ID", IdCat)
                GUARDAR_INT("Nivel", "Utilizado", 0, "ID", IdCat)
                LIMPIAR()
                MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Trasacción exitosa")
                'Muestra y refresca la pantalla del list view de niveles y cierra esta
                P_PNivel.Show()
                P_PNivel.REFRESCAR()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al guardar el nuevo nivel" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try

    End Sub

    Private Sub BTNRegresaNuevoNivel_Click(sender As Object, e As EventArgs) Handles BTNRegresaNuevoNivel.Click
        P_PNivel.Show()
        Me.Close()
    End Sub

    '----------------------------------Limpieza del form-------------------------------------------
    Friend Sub LIMPIAR()
        TXT_NombreNuevoNivel.Clear()
    End Sub

    '-----------------------Validación de que todos los campos estén llenos---------------------------------
    Friend Sub VALIDAR()
        'Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_NombreNuevoNivel.Text <> "" Then
            BTN_AgregarNuevaNivel.Enabled = True
        Else
            BTN_AgregarNuevaNivel.Enabled = False
        End If
    End Sub

    Public Sub TXT_NombreNuevoNivel_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreNuevoNivel.TextChanged
        VALIDAR()
    End Sub

    Private Sub E_PNuevoNivel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarNuevaNivel.PerformClick()
        End If
    End Sub
End Class