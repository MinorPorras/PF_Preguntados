Public Class P_PTemas
    '----------------------------Metodo cargar-----------------------------------------
    Private Sub P_PTemas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
    End Sub

    '---------------------------------Funciones de los botones---------------------------------------------
    Private Sub BTN_AgregarNuevoTema_Click(sender As Object, e As EventArgs) Handles BTN_AgregarNuevoTema.Click
        E_PNuevoTema.Show()
    End Sub

    Private Sub BTN_RegresarTemas_Click(sender As Object, e As EventArgs) Handles BTN_RegresarTemas.Click
        P_PPersonalizacion.Show()
        Me.Close()
    End Sub
    Private Sub BTN_CerrarSesion_Click(sender As Object, e As EventArgs) Handles BTN_CerrarSesion.Click
        P_TLogin.Show()
        Me.Close()
    End Sub

    Private Sub CerrarAPP_Click(sender As Object, e As EventArgs) Handles CerrarAPP.Click
        Dim resultado As MsgBoxResult
        resultado = MsgBox("¿Desea cerrar la aplicación?", vbOKCancel + vbQuestion, "Confirmar")

        If resultado = MsgBoxResult.Ok Then
            ' Cerramos la aplicación
            Application.Exit()
        End If
    End Sub

    '---------------------------------Funciones de los botones del context menu strip---------------------------------------------
    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If LSV_Temas.SelectedItems.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If MsgBox("¿Desea eliminar el tema: " & LSV_Temas.SelectedItems(0).SubItems(1).Text & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idTemaEliminar As Integer = Convert.ToInt32(LSV_Temas.SelectedItems(0).SubItems(0).Text)
                    ' Verificar si hay categorías asociadas
                    SQL = "SELECT COUNT(C.ID_Tema) as cIdTema FROM Temas t, Categoria c WHERE T.ID = C.ID_Tema AND t.ID = " & idTemaEliminar
                    Cargar_Tabla(T, SQL)

                    If T.Tables(0).Rows(0).Item(0) = 0 Then
                        ' Se verifica que no se haya utilizado el tema
                        SQL = "SELECT Utilizado FROM Temas WHERE ID = " & idTemaEliminar
                        Cargar_Tabla(T1, SQL)

                        If T1.Tables(0).Rows(0).Item(0) = 0 Then
                            'Se cambia el estado a inactivo
                            SQL = "DELETE FROM Temas WHERE ID = " & idTemaEliminar
                            EJECUTAR(SQL)
                            REFRESCAR()
                            MsgBox("El tema fue eliminado satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                        Else
                            MsgBox("No se puede eliminar el tema porque ya se ha jugado con el", vbExclamation, "Error")
                        End If
                    Else
                        MsgBox("No se puede eliminar el tema porque tiene categorías asociadas", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione un tema para eliminar.", vbInformation + vbOKOnly, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar el tema: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try


    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        If LSV_Temas.SelectedItems.Count >= 0 Then
            Try
                E_PModTema.IdTema = CInt(LSV_Temas.SelectedItems(0).SubItems(0).Text)
                E_PModTema.TXT_NombreModTema.Text = LSV_Temas.SelectedItems(0).SubItems(1).Text
                E_PModTema.TXT_DescModTema.Text = LSV_Temas.SelectedItems(0).SubItems(2).Text
                E_PModTema.RutaImgEst = LSV_Temas.SelectedItems(0).SubItems(5).Text
                E_PModTema.OFD_ImgEstaticaTemaMod.FileName = LSV_Temas.SelectedItems(0).SubItems(5).Text
                E_PModTema.RutaImgAni = LSV_Temas.SelectedItems(0).SubItems(6).Text
                E_PModTema.OFD_ImgAnimTemaMod.FileName = LSV_Temas.SelectedItems(0).SubItems(6).Text
                E_PModTema.RutaAudio = LSV_Temas.SelectedItems(0).SubItems(7).Text
                E_PModTema.OFD_AudioTemaMod.FileName = LSV_Temas.SelectedItems(0).SubItems(7).Text
                E_PModTema.RutaSonido = LSV_Temas.SelectedItems(0).SubItems(8).Text
                E_PModTema.OFD_SonidoTemaMod.FileName = LSV_Temas.SelectedItems(0).SubItems(8).Text
                E_PModTema.Show()
                E_PModTema.CBX_AsigModTema.SelectedValue = LSV_Temas.SelectedItems(0).SubItems(3).Text
            Catch ex As Exception
                MsgBox("Error al cargar los datos del tema: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End Try
        End If
    End Sub

    '------------------------------Función de busqueda------------------------------------------
    Friend Sub REFRESCAR()
        Try
            LSV_Temas.Items.Clear()
            T.Tables.Clear()
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            If TXT_BuscarTema.Text <> "" Then
                SQL = "SELECT t.ID, t.NOMBRE, t.Descripción, t.ID_ASIGNATURA, a.Nombre, t.Imagen_Estatica, t.Imagen_Animada, t.Sonido, t.Audio FROM Temas t, Asignatura a WHERE T.ID_Asignatura = a.ID AND T.Nombre LIKE '%" & TXT_BuscarTema.Text & "%'"
            Else
                SQL = "SELECT t.ID, t.NOMBRE, t.Descripción, t.ID_ASIGNATURA, a.Nombre, t.Imagen_Estatica, t.Imagen_Animada, t.Sonido, t.Audio FROM Temas t, Asignatura a WHERE T.ID_Asignatura = a.ID"
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For I As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(I).Item("ID").ToString())
                    For J As Integer = 1 To 8
                        Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(I).Item(J)), "", T.Tables(0).Rows(I).Item(J).ToString())
                        item.SubItems.Add(subItem)
                    Next
                    LSV_Temas.Items.Add(item)
                Next
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            LSV_Temas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Temas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Temas.Columns(0).Width = 0
            LSV_Temas.Columns(3).Width = 0
            TXT_BuscarTema.Select()
        Catch ex As Exception
            MsgBox("Error al cargar la lista de los temas: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub TXT_BuscarTema_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarTema.TextChanged
        REFRESCAR()
    End Sub

    Private Sub BTN_CuentaProf_Click(sender As Object, e As EventArgs) Handles BTN_CuentaProf.Click
        P_PCuenta.Show()
    End Sub

    Private Sub P_PTemas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_AgregarNuevoTema.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class
