Public Class P_PGenReporteGeneral
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

    Private Sub BTN_RegresarRepGen_Click(sender As Object, e As EventArgs) Handles BTN_RegresarRepGen.Click
        P_PReporteGeneralPrincipal.Show()
        Me.Close()
    End Sub

    Public Sub cargarCBXAsig()
        Try
            CBX_AsigRepGen.Items.Clear()
            ' Se limpia la tabla temporal y se envía el query a la base de datos, cargando la tabla temporal
            T.Tables.Clear()
            SQL = "SELECT ID, Nombre FROM Asignatura WHERE ID_Profesor = " & ID_cuenta ' Asegúrate de que este es el nombre correcto de la tabla
            Cargar_Tabla(T, SQL)

            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    ' Se establece una nueva instancia de Asignatura para guardar ambos datos en un solo objeto
                    Dim AsigItem As New ClsAsig()
                    AsigItem.Nombre = T.Tables(0).Rows(i).Item("Nombre").ToString()
                    AsigItem.ID = CInt(T.Tables(0).Rows(i).Item("ID"))

                    ' Se añade el objeto al combo box
                    CBX_AsigRepGen.Items.Add(AsigItem)
                Next
                ' Se configura lo que muestra el combo box
                CBX_AsigRepGen.DisplayMember = "Nombre"
                CBX_AsigRepGen.ValueMember = "ID"
                CBX_AsigRepGen.DataSource = T.Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la lista de asignaturas: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub P_PReporteGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCBXAsig()
        REFRESCAR()
    End Sub

    Friend Sub REFRESCAR()
        Try
            CTX_GenReporteGen.Visible = False
            LSV_RepGeneral.Items.Clear()
            T.Tables.Clear()
            If CBX_AsigRepGen.SelectedIndex <> -1 Then
                SQL = "SELECT t.ID, t.Nombre, s.ID, s.Nombre FROM Asignatura a, Temas t, Seccion s" &
                    " WHERE a.ID_Seccion = s.ID AND t.ID_Asignatura = a.ID AND a.ID = " & CBX_AsigRepGen.SelectedValue
                Cargar_Tabla(T, SQL)
                If T.Tables(0).Rows.Count > 0 Then
                    For I As Integer = 0 To T.Tables(0).Rows.Count - 1
                        Dim item As New ListViewItem(T.Tables(0).Rows(I).Item(0).ToString())
                        For J As Integer = 1 To 3
                            Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(I).Item(J)), "", T.Tables(0).Rows(I).Item(J).ToString())
                            item.SubItems.Add(subItem)
                        Next
                        LSV_RepGeneral.Items.Add(item)
                    Next
                    CTX_GenReporteGen.Visible = True
                End If
                LSV_RepGeneral.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
                LSV_RepGeneral.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                LSV_RepGeneral.Columns(0).Width = 0
                LSV_RepGeneral.Columns(2).Width = 0
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la lista de temas y secciones: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub GenerarReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarReporteToolStripMenuItem.Click
        Try
            E_PNuevoReporteGeneral.idTema = LSV_RepGeneral.SelectedItems(0).SubItems(0).Text
            E_PNuevoReporteGeneral.TXT_Tema.Text = LSV_RepGeneral.SelectedItems(0).SubItems(1).Text
            E_PNuevoReporteGeneral.idSeccion = LSV_RepGeneral.SelectedItems(0).SubItems(2).Text
            E_PNuevoReporteGeneral.TXT_Seccion.Text = LSV_RepGeneral.SelectedItems(0).SubItems(3).Text
            E_PNuevoReporteGeneral.ReporteYaCreado = False
            E_PNuevoReporteGeneral.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al cargar los datos para generar el reporte: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub P_PGenReporteGeneral_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub

    Private Sub CBX_AsigRepGen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_AsigRepGen.SelectedIndexChanged
        REFRESCAR()
    End Sub
End Class