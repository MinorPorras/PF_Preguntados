Public Class P_PReporteGeneralPrincipal
    Dim noCargado As Boolean = True

    Private Sub P_PReporteGeneralPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        noCargado = True
        cargarCBXTema()
        REFRESCAR()
    End Sub

    Friend Sub REFRESCAR()
        Try
            noCargado = False
            'Metodo par cargar el list view
            LSV_RepGeneral.Items.Clear()
            T.Tables.Clear()
            CTX_Exportar.Visible = False
            CTX_VerDatos.Visible = False
            If TXT_BuscarRepGeneral.Text <> "" Then
                SQL = "SELECT rg.ID, t.ID, t.Nombre, a.id, a.Nombre, s.ID, s.Nombre, rg.FechaGeneracion" &
                    " FROM Reporte_General rg, Temas t, Asignatura a, Seccion s " &
                    "WHERE rg.ID_Seccion = s.ID AND t.ID_Asignatura = a.ID AND a.ID_Seccion = s.ID " &
                    "AND T.[ID] = " & CBX_Tema.SelectedValue & " AND s.Nombre Like '%" & TXT_BuscarRepGeneral.Text & "%'"
            Else
                SQL = "SELECT rg.ID, t.ID, t.Nombre, a.id, a.Nombre, s.ID, s.Nombre, rg.FechaGeneracion" &
                    " FROM Reporte_General rg, Temas t, Asignatura a, Seccion s " &
                    "WHERE rg.ID_Seccion = s.ID AND t.ID_Asignatura = a.ID AND a.ID_Seccion = s.ID " &
                    "AND T.[ID] = " & CBX_Tema.SelectedValue

            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For I As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(I).Item(0).ToString())
                    For J As Integer = 1 To 7
                        Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(I).Item(J)), "", T.Tables(0).Rows(I).Item(J).ToString())
                        item.SubItems.Add(subItem)
                    Next
                    LSV_RepGeneral.Items.Add(item)
                Next
                CTX_Exportar.Visible = True
                CTX_VerDatos.Visible = True
            End If
            LSV_RepGeneral.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_RepGeneral.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_RepGeneral.Columns(0).Width = 0
            LSV_RepGeneral.Columns(1).Width = 0
            LSV_RepGeneral.Columns(3).Width = 0
            LSV_RepGeneral.Columns(5).Width = 0
        Catch ex As Exception
            MsgBox("Error cargar la lista de reportes: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try

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
                    TemaItem.Nombre = T.Tables(0).Rows(i).Item(1)
                    TemaItem.ID = T.Tables(0).Rows(i).Item(0)

                    'Se añade el objeto al combo box
                    CBX_Tema.Items.Add(TemaItem)
                Next
                'Se configura lo que muestra el combo box
                CBX_Tema.DisplayMember = "Nombre"
                CBX_Tema.ValueMember = "ID"
                CBX_Tema.DataSource = T.Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Error cargar la lista de temas: " & ex.Message, vbCritical + vbOKOnly, "Error")

        End Try
    End Sub

    Private Sub BTN_GenRepGen_Click(sender As Object, e As EventArgs) Handles BTN_GenRepGen.Click
        P_PGenReporteGeneral.Show()
        Me.Close()
    End Sub

    Private Sub BTN_CuentaProf_Click(sender As Object, e As EventArgs) Handles BTN_CuentaProf.Click
        P_PCuenta.Show()
    End Sub

    Private Sub BTN_RegresarRepGen_Click(sender As Object, e As EventArgs) Handles BTN_RegresarRepGen.Click
        P_PReportesPrincipal.Show()
        noCargado = True
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

    Private Sub BTN_CerrarSesion_Click(sender As Object, e As EventArgs) Handles BTN_CerrarSesion.Click
        CProf = False
        noCargado = True
        P_TLogin.Show()
        Me.Close()
    End Sub

    Private Sub TXT_BuscarRepGeneral_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarRepGeneral.TextChanged
        If Not noCargado Then
            REFRESCAR()
        End If
    End Sub

    Private Sub verDatosRepGen()
        Try
            E_PNuevoReporteGeneral.idTema = LSV_RepGeneral.SelectedItems(0).SubItems(1).Text
            E_PNuevoReporteGeneral.TXT_Tema.Text = LSV_RepGeneral.SelectedItems(0).SubItems(2).Text
            E_PNuevoReporteGeneral.idSeccion = LSV_RepGeneral.SelectedItems(0).SubItems(5).Text
            E_PNuevoReporteGeneral.TXT_Seccion.Text = LSV_RepGeneral.SelectedItems(0).SubItems(6).Text
        Catch ex As Exception
            MsgBox("Error cargar los datos del reporte: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try

    End Sub

    Private Sub CTX_VerDatos_Click(sender As Object, e As EventArgs) Handles CTX_VerDatos.Click
        verDatosRepGen()
        E_PNuevoReporteGeneral.ReporteYaCreado = True
        E_PNuevoReporteGeneral.Show()
    End Sub

    Public Sub cargarDatosRepGen(ByVal tipoRepGen As String, repWord As Boolean)
        Try
            REPORTES.TipodeRep = 2
            REPORTES.tipoRepGen = tipoRepGen
            REPORTES.TipoExportacion = 1
            REPORTES.idTemaRep = LSV_RepGeneral.SelectedItems(0).SubItems(1).Text
            REPORTES.NombreTemaRep = LSV_RepGeneral.SelectedItems(0).SubItems(2).Text
            REPORTES.idSeccionRep = LSV_RepGeneral.SelectedItems(0).SubItems(5).Text
            REPORTES.NombreSeccionRep = LSV_RepGeneral.SelectedItems(0).SubItems(6).Text
            REPORTES.idAsigRep = LSV_RepGeneral.SelectedItems(0).SubItems(3).Text
            REPORTES.NombreAsigRep = LSV_RepGeneral.SelectedItems(0).SubItems(4).Text
            REPORTES.RepWord = repWord
        Catch ex As Exception
            MsgBox("Error cargar los datos del reporte: " & ex.Message, vbCritical + vbOKOnly, "Error")

        End Try

    End Sub

    Private Sub WordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CTX_ExpComWord.Click
        If MessageBox.Show("Desea descargar este informe?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            cargarDatosRepGen(1, True)
            P_PGenerandoInforme.Show()
        End If
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelToolStripMenuItem.Click
        If MessageBox.Show("Desea descargar este informe?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            cargarDatosRepGen(1, False)
            P_PGenerandoInforme.Show()
        End If
    End Sub

    Private Sub CTX_RepGenResum_Click(sender As Object, e As EventArgs) Handles CTX_RepGenResum.Click
        If MessageBox.Show("Desea descargar este informe?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            cargarDatosRepGen(2, True)
            P_PGenerandoInforme.Show()
        End If
    End Sub

    Private Sub P_PReporteGeneralPrincipal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_GenRepGen.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub

    Private Sub CBX_Tema_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_Tema.SelectedIndexChanged
        If Not noCargado Then
            REFRESCAR()
        End If
    End Sub
End Class