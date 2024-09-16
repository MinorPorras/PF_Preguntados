Public Class E_PNuevoReporteGeneral
    Public idTema As Integer
    Public idSeccion As Integer
    Dim NombreCompleto As String
    Dim PtsObtenido As Integer
    Dim PtsTotal As Integer
    Dim Nota As Double
    Public ReporteYaCreado As Boolean
    Public idRepGeneral As Integer

    Private Sub P_PVerReporteGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ReporteYaCreado Then
        Else
            idRepGeneral = OBTENERPK("Reporte_General", "ID")
        End If
        cargarDatos()
    End Sub

    Private Sub cargarDatos()
        CargarDatosCali()
        CargarDatosPregRepGen()
    End Sub

    Private Sub CargarDatosPregRepGen()
        Try
            T.Tables.Clear()
            T1.Tables.Clear()
            'SQL para cargar la pregunta con más aciertos y el texto de esta
            SQL = "SELECT COUNT(p.ID), p.Texto FROM Resultados r, Respuestas re, Resultados_Respuestas rr, Preguntas p," &
                " Estudiante e, Seccion s, Temas t, Categoria c WHERE r.ID = rr.ID_Resultado AND re.ID = rr.ID_Respuesta" &
                " AND re.ID_Pregunta = p.ID AND e.ID_Seccion = s.ID AND e.ID = r.ID_Estudiante  AND t.ID = c.ID_Tema" &
                " AND  p.ID_Categoria = c.ID AND re.correcta = 1 AND s.ID = " & idSeccion & " AND t.ID = " & idTema & " GROUP BY p.texto" &
                " ORDER BY COUNT(p.ID) DESC;"
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                TXT_AciertosPregFacil.Text = T.Tables(0).Rows(0).Item(0) & " Aciertos"
                TXT_PregFacil.Text = T.Tables(0).Rows(0).Item(1)
            Else
                TXT_AciertosPregFacil.Text = "No hay datos"
                TXT_PregFacil.Text = "No hay datos"
            End If

            'SQL para cargar la pregunta con menos aciertos y el texto de esta
            SQL = "SELECT COUNT(p.ID), p.Texto FROM Resultados r, Respuestas re, Resultados_Respuestas rr, Preguntas p," &
                " Estudiante e, Seccion s, Temas t, Categoria c WHERE r.ID = rr.ID_Resultado AND re.ID = rr.ID_Respuesta" &
                " AND re.ID_Pregunta = p.ID AND e.ID_Seccion = s.ID AND e.ID = r.ID_Estudiante  AND t.ID = c.ID_Tema" &
                " AND  p.ID_Categoria = c.ID AND re.correcta = 1 AND s.ID = " & idSeccion & " AND t.ID = " & idTema & " GROUP BY p.texto" &
                " ORDER BY COUNT(p.ID) ASC;"
            Cargar_Tabla(T1, SQL)
            If T1.Tables(0).Rows.Count > 0 Then
                TXT_AciertosPregDificil.Text = T1.Tables(0).Rows(0).Item(0) & " Aciertos"
                TXT_PregDificil.Text = T1.Tables(0).Rows(0).Item(1)
            Else
                TXT_AciertosPregDificil.Text = "No hay datos"
                TXT_PregDificil.Text = "No hay datos"
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los datos del reporte" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try

    End Sub

    Private Sub CargarDatosCali()
        Try
            T.Tables.Clear()
            T1.Tables.Clear()
            'SQL para cargar maxima nota y el nombre del estudiante con esta
            SQL = "SELECT MAX(r.Pts_Obtenida), r.Pts_Totales, e.Nombre, e.Apellido_1, E.Apellido_2" &
                " FROM Resultados r, Estudiante e, seccion s, Temas t WHERE r.ID_Estudiante = e.ID AND s.ID = e.ID_Seccion" &
                " AND t.ID = r.ID_Tema AND T.ID = " & idTema & " AND S.ID = " & idSeccion & " GROUP BY r.Pts_Totales, E.Nombre, e.Apellido_1, E.Apellido_2" &
                " ORDER BY MAX(r.Pts_Obtenida) DESC"

            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                PtsObtenido = T.Tables(0).Rows(0).Item(0)
                PtsTotal = T.Tables(0).Rows(0).Item(1)
                Nota = (PtsObtenido * 100) / PtsTotal
                TXT_MasNota.Text = Math.Round(Nota, 2) & "%"
                NombreCompleto = T.Tables(0).Rows(0).Item(2) & " " & T.Tables(0).Rows(0).Item(3) & " " & T.Tables(0).Rows(0).Item(4)
                TXT_MasNotaEst.Text = NombreCompleto
            End If

            'SQL para seleccionar la nota minima y el nombre del estudiante que la tiene
            SQL = "SELECT MIN(r.Pts_Obtenida), r.Pts_Totales, e.Nombre, e.Apellido_1, E.Apellido_2" &
                " FROM Resultados r, Estudiante e, seccion s, Temas t WHERE r.ID_Estudiante = e.ID AND s.ID = e.ID_Seccion" &
                " AND t.ID = r.ID_Tema AND T.ID = " & idTema & " AND S.ID = " & idSeccion & " GROUP BY r.Pts_Totales, E.Nombre, e.Apellido_1, E.Apellido_2" &
                " ORDER BY MIN(r.Pts_Obtenida) ASC"
            Cargar_Tabla(T1, SQL)
            If T1.Tables(0).Rows.Count > 0 Then
                PtsObtenido = T1.Tables(0).Rows(0).Item(0)
                PtsTotal = T1.Tables(0).Rows(0).Item(1)
                Nota = (PtsObtenido * 100) / PtsTotal
                TXT_MenosNota.Text = Math.Round(Nota, 2) & "%"
                NombreCompleto = T1.Tables(0).Rows(0).Item(2) & " " & T1.Tables(0).Rows(0).Item(3) & " " & T1.Tables(0).Rows(0).Item(4)
                TXT_MenosNotaEst.Text = NombreCompleto
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los datos del reporte" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub BTNRegresaExpRepGen_Click(sender As Object, e As EventArgs) Handles BTNRegresaExpRepGen.Click
        If ReporteYaCreado Then
            P_PReporteGeneralPrincipal.Show()
        Else
            P_PGenReporteGeneral.Show()
        End If
        Me.Close()

    End Sub

    Private Sub BTN_GuardaryCompartir_Click(sender As Object, e As EventArgs) Handles BTN_GuardarReporteGen.Click
        Try
            'Hacer confirmación de querer guardarlo, guardarlo y preguntas si se quiere generar otro reporte si es si,
            'te regresa a la pestaña de generar reportes sino te regresas a la principal de reporte general
            If MessageBox.Show("Desea guardar y compartir este informe?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                'Si la PK que esté guardada en idReporte no existe en la base de datos en esa tabla...
                If EXISTEPK("Reporte_General", "ID", idRepGeneral) = False Then 'Si no se ha guardado el Reporte
                    'Guarda la PK almacenada en idReporte dentro de la Base de datos en la tabla y PK indicado
                    GUARDAR_PK("Reporte_General", "ID", idRepGeneral)
                End If
                'Se debe de guardarel id del resultado que se está usando en el informe
                GUARDAR_INT("Reporte_General", "ID_Seccion", idSeccion, "ID", idRepGeneral)
                'Fecha y hora en la que se está generando el informe
                GUARDAR_TIMEACTUAL("Reporte_General", "FechaGeneracion", "ID", idRepGeneral)
                GUARDAR_INT("Reporte_General", "Utilizado", 0, "ID", idRepGeneral)
                If MessageBox.Show("Desea generar otro informe?", "Nueva Generación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    P_PGenReporteGeneral.Show()
                    P_PGenReporteGeneral.REFRESCAR()
                Else
                    P_PReporteGeneralPrincipal.Show()
                    P_PReporteGeneralPrincipal.REFRESCAR()
                End If
                ReporteYaCreado = False
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al guardar y compartir los datos del reporte" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub E_PNuevoReporteGeneral_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_GuardarReporteGen.PerformClick()
        End If
    End Sub
End Class