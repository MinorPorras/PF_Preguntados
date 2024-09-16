Public Class P_PCategoria
    '----------------------------Metodo cargar-----------------------------------------
    Private Sub P_PCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
    End Sub

    '---------------------------------Funciones de los botones---------------------------------------------
    Private Sub BTN_CrearCat_Click(sender As Object, e As EventArgs) Handles BTN_CrearCat.Click
        E_PNuevaCategoria.Show()
    End Sub

    Private Sub BTN_RegresarCat_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCat.Click
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
            If LSV_Categoria.SelectedItems.Count > 0 Then
                If MsgBox("¿Desea eliminar la categoría: " & LSV_Categoria.SelectedItems(0).SubItems(1).Text & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idCatEliminar As Integer = Convert.ToInt32(LSV_Categoria.SelectedItems(0).SubItems(0).Text)
                    ' Verificar si hay preguntas asociadas
                    SQL = "SELECT COUNT(ID) FROM Preguntas WHERE ID_Categoria = " & idCatEliminar
                    Cargar_Tabla(T, SQL)
                    If T.Tables(0).Rows(0).Item(0) = 0 Then
                        SQL = "SELECT Utilizado FROM Categoria WHERE ID = " & idCatEliminar
                        Cargar_Tabla(T1, SQL)
                        If T1.Tables(0).Rows(0).Item(0) = 0 Then
                            SQL = "DELETE FROM Categoria WHERE ID = " & idCatEliminar
                            EJECUTAR(SQL)
                            REFRESCAR()
                            MsgBox("La categoría fue eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                        Else
                            MsgBox("No se puede eliminar la categoría porque ya ha sido utilizada.", vbExclamation, "Error")
                        End If
                    Else
                        MsgBox("No se puede eliminar la categoría porque tiene preguntas asociadas.", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione una categoría para eliminar.", vbInformation + vbOKOnly, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar la categoría: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        If LSV_Categoria.SelectedItems.Count > 0 Then
            Try
                E_PModCategoria.IdCat = CInt(LSV_Categoria.SelectedItems(0).SubItems(0).Text)
                E_PModCategoria.TXT_NombreModCat.Text = LSV_Categoria.SelectedItems(0).SubItems(1).Text
                E_PModCategoria.TXT_DescModCat.Text = LSV_Categoria.SelectedItems(0).SubItems(2).Text
                E_PModCategoria.RutaImgEst = LSV_Categoria.SelectedItems(0).SubItems(5).Text
                E_PModCategoria.OFD_ImgEstCatMod.FileName = LSV_Categoria.SelectedItems(0).SubItems(5).Text
                E_PModCategoria.RutaImgAni = LSV_Categoria.SelectedItems(0).SubItems(6).Text
                E_PModCategoria.OFD_ImgAniModCat.FileName = LSV_Categoria.SelectedItems(0).SubItems(6).Text
                E_PModCategoria.RutaAudio = LSV_Categoria.SelectedItems(0).SubItems(7).Text
                E_PModCategoria.OFD_AudioModCat.FileName = LSV_Categoria.SelectedItems(0).SubItems(7).Text
                E_PModCategoria.Show()
                E_PModCategoria.CBX_TemaModCat.SelectedValue = LSV_Categoria.SelectedItems(0).SubItems(3).Text
            Catch ex As Exception
                MsgBox("Error al cargar los datos de la categoría: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End Try
        End If
    End Sub

    '------------------------------Función de busqueda------------------------------------------
    Friend Sub REFRESCAR()
        Try
            LSV_Categoria.Items.Clear()
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            T.Tables.Clear()
            If TXT_BuscarCategori.Text <> "" Then
                SQL = "SELECT c.ID, c.Nombre, c.Descripcion, c.ID_Tema, t.Nombre, c.Imagen_Estatica, c.Imagen_Animada, c.Audio FROM Categoria C, Temas t WHERE c.ID_Tema = t.ID AND c.Nombre LIKE '%" & TXT_BuscarCategori.Text & "%'"
            Else
                SQL = "SELECT c.ID, c.Nombre, c.Descripcion, c.ID_Tema, t.Nombre, c.Imagen_Estatica, c.Imagen_Animada, c.Audio FROM Categoria C, Temas t WHERE c.ID_Tema = t.ID"
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(i).Item("ID").ToString())
                    For j As Integer = 1 To 7
                        Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(i).Item(j)), "", T.Tables(0).Rows(i).Item(j).ToString())
                        item.SubItems.Add(subItem)
                    Next
                    LSV_Categoria.Items.Add(item)
                Next
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            LSV_Categoria.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Categoria.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Categoria.Columns(0).Width = 0
            LSV_Categoria.Columns(3).Width = 0
            TXT_BuscarCategori.Select()
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de categorías: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try
    End Sub

    Private Sub TXT_BuscarCategori_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarCategori.TextChanged
        REFRESCAR()
    End Sub

    Private Sub BTN_CuentaProf_Click(sender As Object, e As EventArgs) Handles BTN_CuentaProf.Click
        P_PCuenta.Show()
    End Sub

    Private Sub P_PCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_CrearCat.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class
