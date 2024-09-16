Public Class P_PGenReporteIndividual
    Private Sub P_PReporteIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCBXTema()
        REFRESCAR()
    End Sub

    Private Sub CerrarAPP_Click(sender As Object, e As EventArgs) Handles CerrarAPP.Click
        Dim resultado As MsgBoxResult
        resultado = MsgBox("¿Desea cerrar la aplicación?", vbOKCancel + vbQuestion, "Confirmar")

        If resultado = MsgBoxResult.Ok Then
            ' Cerramos la aplicación
            Application.Exit()
        End If
    End Sub

    Private Sub BTN_CerrarSesion_Click(sender As Object, e As EventArgs) Handles BTN_CerrarSesion.Click
        CProf = False
        P_TLogin.Show()
        Me.Close()
    End Sub

    Private Sub BTN_CuentaProf_Click(sender As Object, e As EventArgs) Handles BTN_CuentaProf.Click
        P_PCuenta.Show()
    End Sub

    Private Sub cargarCBXTema()
        Try
            CBX_Tema.Items.Clear()
            'Se limpia la tabla temporal y se envía el query a la base de datos, cargando la tabla temporal
            T.Tables.Clear()
            SQL = "SELECT ID, Nombre FROM Temas"
            Cargar_Tabla(T, SQL)

            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    'Se establece una nueva instancia de Tema para guardar ambos datos en un solo objeto
                    Dim TemaItem As New ClsTema()
                    TemaItem.Nombre = T.Tables(0).Rows(i).Item("Nombre").ToString()
                    TemaItem.ID = T.Tables(0).Rows(i).Item("ID").ToString()

                    'Se añade el objeto al combo box
                    CBX_Tema.Items.Add(TemaItem)
                Next
                'Se configura lo que muestra el combo box
                CBX_Tema.DisplayMember = "Nombre"
                CBX_Tema.ValueMember = "ID"
                CBX_Tema.DataSource = T.Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la lista de temas: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub BTN_RegresarAsig_Click(sender As Object, e As EventArgs) Handles BTN_RegresarAsig.Click
        P_PReporteIndividualPrincipal.Show()
        Me.Close()
    End Sub

    Friend Sub REFRESCAR()
        Try
            CTX_ReporteInd.Visible = False
            LSV_RepIndividual.Items.Clear()
            T.Tables.Clear()
            If CBX_Tema.SelectedIndex <> -1 Then
                SQL = "SELECT r.ID, e.ID, e.Apellido_1, e.Apellido_2, e.Nombre, a.ID, a.Nombre, s.ID, s.Nombre" &
                    " FROM Resultados r, Estudiante e, Asignatura a, Seccion s, Temas t WHERE r.ID_Estudiante = e.ID" &
                    " AND s.ID = e.ID_Seccion AND s.ID = a.ID_Seccion AND t.ID = r.ID_Tema AND t.ID = " & CBX_Tema.SelectedValue
                Cargar_Tabla(T, SQL)
                If T.Tables(0).Rows.Count > 0 Then
                    For I As Integer = 0 To T.Tables(0).Rows.Count - 1
                        Dim item As New ListViewItem(T.Tables(0).Rows(I).Item(0).ToString())
                        For J As Integer = 1 To 8
                            Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(I).Item(J)), "", T.Tables(0).Rows(I).Item(J).ToString())
                            item.SubItems.Add(subItem)
                        Next
                        LSV_RepIndividual.Items.Add(item)
                    Next
                    CTX_ReporteInd.Visible = True
                End If
                LSV_RepIndividual.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
                LSV_RepIndividual.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                LSV_RepIndividual.Columns(0).Width = 0
                LSV_RepIndividual.Columns(1).Width = 0
                LSV_RepIndividual.Columns(5).Width = 0
                LSV_RepIndividual.Columns(7).Width = 0
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la lista de Resultados: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub GenerarReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarReporteToolStripMenuItem.Click
        Try
            E_PNuevoReporteIndividual.idResult = LSV_RepIndividual.SelectedItems(0).SubItems(0).Text
            E_PNuevoReporteIndividual.idTema = CBX_Tema.SelectedValue
            E_PNuevoReporteIndividual.TXT_Tema.Text = CBX_Tema.Text
            E_PNuevoReporteIndividual.idEst = LSV_RepIndividual.SelectedItems(0).SubItems(1).Text
            E_PNuevoReporteIndividual.TXT_NombreEst.Text = LSV_RepIndividual.SelectedItems(0).SubItems(4).Text & " " &
                LSV_RepIndividual.SelectedItems(0).SubItems(2).Text & " " & LSV_RepIndividual.SelectedItems(0).SubItems(3).Text
            E_PNuevoReporteIndividual.idAsig = LSV_RepIndividual.SelectedItems(0).SubItems(5).Text
            E_PNuevoReporteIndividual.TXT_Asig.Text = LSV_RepIndividual.SelectedItems(0).SubItems(6).Text
            E_PNuevoReporteIndividual.idSeccion = LSV_RepIndividual.SelectedItems(0).SubItems(7).Text
            E_PNuevoReporteIndividual.TXT_Seccion.Text = LSV_RepIndividual.SelectedItems(0).SubItems(8).Text
            E_PNuevoReporteIndividual.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al cargar losdatos para generar el reporte: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub P_PGenReporteIndividual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub

    Private Sub CBX_Tema_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_Tema.SelectedIndexChanged
        REFRESCAR()
    End Sub
End Class