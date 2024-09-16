Public Class P_PReporteIndividualPrincipal
    Dim noCargado As Boolean = True
    Dim PtsTotal As Integer
    Dim PtsObtenido As Integer
    Dim NotaResultado As Double
    Private Sub VerDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CTX_VerDatos.Click
        Try
            E_PNuevoReporteIndividual.idReporte = LSV_RepIndividual.SelectedItems(0).SubItems(0).Text
            E_PNuevoReporteIndividual.idResult = LSV_RepIndividual.SelectedItems(0).SubItems(1).Text
            E_PNuevoReporteIndividual.idTema = LSV_RepIndividual.SelectedItems(0).SubItems(2).Text
            E_PNuevoReporteIndividual.TXT_Tema.Text = LSV_RepIndividual.SelectedItems(0).SubItems(3).Text
            E_PNuevoReporteIndividual.idEst = LSV_RepIndividual.SelectedItems(0).SubItems(4).Text
            E_PNuevoReporteIndividual.TXT_NombreEst.Text = LSV_RepIndividual.SelectedItems(0).SubItems(5).Text
            E_PNuevoReporteIndividual.idAsig = LSV_RepIndividual.SelectedItems(0).SubItems(6).Text
            E_PNuevoReporteIndividual.TXT_Asig.Text = LSV_RepIndividual.SelectedItems(0).SubItems(7).Text
            E_PNuevoReporteIndividual.idSeccion = LSV_RepIndividual.SelectedItems(0).SubItems(8).Text
            E_PNuevoReporteIndividual.TXT_Seccion.Text = LSV_RepIndividual.SelectedItems(0).SubItems(9).Text
            If LSV_RepIndividual.SelectedItems(0).SubItems(13).Text = 1 Then
                E_PNuevoReporteIndividual.RBTN_ComYCal.Checked = True
            ElseIf LSV_RepIndividual.SelectedItems(0).SubItems(13).Text = 2 Then
                E_PNuevoReporteIndividual.RBTN_RespInc.Checked = True
            ElseIf LSV_RepIndividual.SelectedItems(0).SubItems(13).Text = 3 Then
                E_PNuevoReporteIndividual.RBTN_RespNoInc.Checked = True
            Else
                E_PNuevoReporteIndividual.RBTN_NoEnviar.Checked = True
            End If
            E_PNuevoReporteIndividual.ReporteYacreado = True
            E_PNuevoReporteIndividual.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error cargar los datos del reporte: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub P_PReporteIndividualPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        noCargado = True
        cargarCBXTema()
        REFRESCAR()
    End Sub

    Friend Sub REFRESCAR()
        Try
            If noCargado = False Then
                LSV_RepIndividual.Items.Clear()
                T.Tables.Clear()
                CTX_Exportar.Visible = False
                CTX_VerDatos.Visible = False
                If TXT_BuscarReporte.Text <> "" Then
                    SQL = "SELECT ri.ID, r.ID, t.ID, t.Nombre, e.ID, [e.Nombre] & ' ' & [e.Apellido_1] & ' ' & [e.Apellido_2] as NombreCompleto, a.ID, a.Nombre, s.ID," &
                        " s.Nombre, r.Pts_Obtenida, r.Pts_Totales, r.Pts_Totales, ri.TipoEnvioEst, " &
                        "IIf(ri.TipoEnvioEst = 1, 'Enviado con calificación', " &
                            "IIf(ri.TipoEnvioEst = 2, 'Enviado con las respuestas del estudiante', " &
                                "IIf(ri.TipoEnvioEst = 3, 'Enviado sin las respuestas', 'No enviado'))) AS EstadoEnvio " &
                        "FROM Reporte_Individual ri, Resultados r, Estudiante e, Temas t, Asignatura a, seccion s " &
                        "WHERE ri.ID_Resultado = r.ID AND r.ID_Estudiante = e.ID AND t.ID_Asignatura = a.ID AND r.ID_Tema = t.ID" &
                        " AND a.ID_Seccion = s.ID AND t.ID = " & CBX_Tema.SelectedValue & " AND [e.Nombre] & ' ' & [e.Apellido_1] & ' ' & [e.Apellido_2] Like '%" & TXT_BuscarReporte.Text & "%'"
                Else
                    SQL = "SELECT ri.ID, r.ID, t.ID, t.Nombre, e.ID, [e.Nombre] & ' ' & [e.Apellido_1] & ' ' & [e.Apellido_2] as NombreCompleto, a.ID, a.Nombre, s.ID," &
                        " s.Nombre, r.Pts_Obtenida, r.Pts_Totales, r.Pts_Totales, ri.TipoEnvioEst, " &
                        "IIf(ri.TipoEnvioEst = 1, 'Enviado con calificación', " &
                            "IIf(ri.TipoEnvioEst = 2, 'Enviado con las respuestas del estudiante', " &
                                "IIf(ri.TipoEnvioEst = 3, 'Enviado sin las respuestas', 'No enviado'))) AS EstadoEnvio " &
                        "FROM Reporte_Individual ri, Resultados r, Estudiante e, Temas t, Asignatura a, seccion s " &
                        "WHERE ri.ID_Resultado = r.ID AND r.ID_Estudiante = e.ID AND t.ID_Asignatura = a.ID AND r.ID_Tema = t.ID" &
                        " AND a.ID_Seccion = s.ID AND t.ID = " & CBX_Tema.SelectedValue

                End If
                Cargar_Tabla(T, SQL)
                If T.Tables(0).Rows.Count > 0 Then
                    For I As Integer = 0 To T.Tables(0).Rows.Count - 1
                        Dim item As New ListViewItem(T.Tables(0).Rows(I).Item(0).ToString())
                        For J As Integer = 1 To 14
                            If J = 10 Then
                                PtsObtenido = T.Tables(0).Rows(I).Item(J)
                                item.SubItems.Add(PtsObtenido)
                            ElseIf J = 11 Then
                                PtsTotal = T.Tables(0).Rows(I).Item(J)
                                item.SubItems.Add(PtsTotal)
                            ElseIf J = 12 Then
                                NotaResultado = (PtsObtenido * 100) / PtsTotal
                                Dim subItem As String = Math.Round(NotaResultado, 2)
                                item.SubItems.Add(subItem)
                            Else
                                Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(I).Item(J)), "", T.Tables(0).Rows(I).Item(J).ToString())
                                item.SubItems.Add(subItem)
                            End If
                        Next
                        LSV_RepIndividual.Items.Add(item)
                    Next
                    CTX_Exportar.Visible = True
                    CTX_VerDatos.Visible = True
                End If
                LSV_RepIndividual.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
                LSV_RepIndividual.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                LSV_RepIndividual.Columns(0).Width = 0
                LSV_RepIndividual.Columns(1).Width = 0
                LSV_RepIndividual.Columns(2).Width = 0
                LSV_RepIndividual.Columns(4).Width = 0
                LSV_RepIndividual.Columns(6).Width = 0
                LSV_RepIndividual.Columns(8).Width = 0
                LSV_RepIndividual.Columns(10).Width = 0
                LSV_RepIndividual.Columns(11).Width = 0
                LSV_RepIndividual.Columns(13).Width = 0
            End If
        Catch ex As Exception
            MsgBox("Error cargar la lista de reportes: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub BTN_GenRepInd_Click(sender As Object, e As EventArgs) Handles BTN_GenRepInd.Click
        P_PGenReporteIndividual.Show()
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
            noCargado = False
        Catch ex As Exception
            MsgBox("Error cargar la lista de temas: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub TXT_BuscarReporte_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarReporte.TextChanged
        If noCargado = False Then
            REFRESCAR()
        End If

    End Sub

    Private Sub CBX_Tema_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_Tema.SelectedIndexChanged
        REFRESCAR()
    End Sub

    Private Sub BTN_RegresarRepInd_Click(sender As Object, e As EventArgs) Handles BTN_RegresarRepInd.Click
        P_PReportesPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub envioDatosReporte(ByVal tipoRep As Integer, ByVal RepWord As Boolean)
        Try
            REPORTES.TipodeRep = 1
            REPORTES.TipoEnvio = tipoRep
            REPORTES.TipoExportacion = 1
            REPORTES.idInformeRep = LSV_RepIndividual.SelectedItems(0).SubItems(0).Text
            REPORTES.idResultRep = LSV_RepIndividual.SelectedItems(0).SubItems(1).Text
            REPORTES.idTemaRep = LSV_RepIndividual.SelectedItems(0).SubItems(2).Text
            REPORTES.NombreTemaRep = LSV_RepIndividual.SelectedItems(0).SubItems(3).Text
            REPORTES.idEstRep = LSV_RepIndividual.SelectedItems(0).SubItems(4).Text
            REPORTES.NombreEstRep = LSV_RepIndividual.SelectedItems(0).SubItems(5).Text
            REPORTES.idAsigRep = LSV_RepIndividual.SelectedItems(0).SubItems(6).Text
            REPORTES.NombreAsigRep = LSV_RepIndividual.SelectedItems(0).SubItems(7).Text
            REPORTES.idSeccionRep = LSV_RepIndividual.SelectedItems(0).SubItems(8).Text
            REPORTES.NombreSeccionRep = LSV_RepIndividual.SelectedItems(0).SubItems(9).Text
            REPORTES.PtsObtenidoRep = LSV_RepIndividual.SelectedItems(0).SubItems(10).Text
            REPORTES.PtsTotalRep = LSV_RepIndividual.SelectedItems(0).SubItems(11).Text
            REPORTES.NotaRep = LSV_RepIndividual.SelectedItems(0).SubItems(12).Text
            REPORTES.RepWord = RepWord
        Catch ex As Exception
            MsgBox("Error cargar los datos del reporte: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try


    End Sub

    Private Sub CTX_CalifWord_Click(sender As Object, e As EventArgs) Handles CTX_CalifWord.Click
        If MessageBox.Show("Desea descargar este informe?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            envioDatosReporte(1, True)
            P_PGenerandoInforme.Show()
        End If
    End Sub

    Private Sub CTX_Exportar_RespInc_Click(sender As Object, e As EventArgs) Handles CTX_Exportar_RespInc.Click
        If MessageBox.Show("Desea descargar este informe?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            envioDatosReporte(2, True)
            P_PGenerandoInforme.Show()
        End If
    End Sub

    Private Sub SoloLasPreguntasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoloLasPreguntasToolStripMenuItem.Click
        If MessageBox.Show("Desea descargar este informe?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            envioDatosReporte(3, True)
            P_PGenerandoInforme.Show()
        End If
    End Sub
    Private Sub CTX_CalifExcel_Click(sender As Object, e As EventArgs) Handles CTX_CalifExcel.Click
        If MessageBox.Show("Desea descargar este informe?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            envioDatosReporte(1, False)
            P_PGenerandoInforme.Show()
        End If
    End Sub

    Private Sub P_PReporteIndividualPrincipal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_GenRepInd.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class