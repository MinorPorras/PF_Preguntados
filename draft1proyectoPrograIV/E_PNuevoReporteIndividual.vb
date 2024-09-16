Public Class E_PNuevoReporteIndividual
    Public idReporte As Integer
    Public idTema As Integer
    Public idSeccion As Integer
    Public idEst As Integer
    Public idAsig As Integer
    Public idResult As Integer
    Dim PtsObtenido As Integer
    Dim PtsTotal As Integer
    Dim Nota As Double
    Public ReporteYacreado As Boolean

    Private Sub BTNRegresaExpRepInd_Click(sender As Object, e As EventArgs) Handles BTNRegresaExpRepInd.Click
        If ReporteYacreado Then
            P_PReporteIndividualPrincipal.Show()
        Else
            P_PGenReporteIndividual.Show()
        End If
        ReporteYacreado = False
        Me.Close()
    End Sub

    Private Sub E_PExpReporteIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTN_GuardaryCompartir.Enabled = False
        Cargar_Resultados()
        If ReporteYacreado = False Then
            BTN_ActualizarEnvio.Enabled = False
            idReporte = OBTENERPK("Reporte_Individual", "ID")
        End If
        VALIDAR()
    End Sub

    Private Sub Cargar_Resultados()
        T.Tables.Clear()
        SQL = "SELECT Pts_Totales, Pts_Obtenida, Tiempo_Juego, Fecha_Juego From Resultados WHERE ID = " & idResult
        Cargar_Tabla(T, SQL)
        Try
            If T.Tables(0).Rows.Count > 0 Then
                PtsObtenido = T.Tables(0).Rows(0).Item(1)
                PtsTotal = T.Tables(0).Rows(0).Item(0)
                TXT_PtsTotal.Text = PtsTotal & " Puntos."
                TXT_PtsObtenidos.Text = PtsObtenido & " Puntos."
                Nota = (PtsObtenido * 100) / PtsTotal
                TXT_Nota.Text = Math.Round(Nota, 2) & "%"
                TXT_TiempoJuego.Text = T.Tables(0).Rows(0).Item(2)
                TXT_FechaJuego.Text = T.Tables(0).Rows(0).Item(3)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub VALIDAR()
        If (RBTN_ComYCal.Checked = True Or RBTN_RespInc.Checked = True Or RBTN_RespNoInc.Checked = True Or RBTN_NoEnviar.Checked = True) Then
            If ReporteYacreado = False Then
                BTN_GuardaryCompartir.Enabled = True
            Else
                BTN_ActualizarEnvio.Enabled = True
            End If
        End If
    End Sub

    Private Sub RBTN_ComYCal_CheckedChanged(sender As Object, e As EventArgs) Handles RBTN_ComYCal.CheckedChanged
        VALIDAR()
    End Sub

    Private Sub RBTN_RespInc_CheckedChanged(sender As Object, e As EventArgs) Handles RBTN_RespInc.CheckedChanged
        VALIDAR()
    End Sub

    Private Sub RBTN_RespNoInc_CheckedChanged(sender As Object, e As EventArgs) Handles RBTN_RespNoInc.CheckedChanged
        VALIDAR()
    End Sub

    Private Sub RBTN_NoEnviar_CheckedChanged_1(sender As Object, e As EventArgs) Handles RBTN_NoEnviar.CheckedChanged
        VALIDAR()
    End Sub

    Private Sub guardarDatos()
        Try
            'Comprobación de que se quiere agregar la información a la base de datos por parte del usuario
            If MessageBox.Show("Desea guardar y compartir este informe?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                'Si la PK que esté guardada en idReporte no existe en la base de datos en esa tabla...
                If EXISTEPK("Reporte_Individual", "ID", idReporte) = False Then 'Si no se ha guardado el Reporte
                    'Guarda la PK almacenada en idReporte dentro de la Base de datos en la tabla y PK indicado
                    GUARDAR_PK("Reporte_Individual", "ID", idReporte)
                End If
                'Se debe de guardarel id del resultado que se está usando en el informe
                GUARDAR_INT("Reporte_Individual", "ID_Resultado", idResult, "ID", idReporte)
                actualizarEnvio()
                'Fecha y hora en la que se está compartiendo el infrome al estudiante para que él lo puedo exportar al tipo de archivo
                GUARDAR_TIMEACTUAL("Reporte_Individual", "FechaGeneracion", "ID", idReporte)
                'Que desee desde su cuenta en el apartado de reportes
                GUARDAR_INT("Reporte_Individual", "Utilizado", 0, "ID", idReporte)
                If MessageBox.Show("Proceso Completado exitosamente " & vbCrLf & "Desea generar otro informe?", "Nueva Generación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    P_PGenReporteIndividual.Show()
                    P_PGenReporteIndividual.REFRESCAR()
                Else
                    P_PReporteIndividualPrincipal.Show()
                    P_PReporteIndividualPrincipal.REFRESCAR()
                End If
                ReporteYacreado = False
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al guardar el nuevo reporte: " & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub actualizarEnvio()
        Try
            'Se debe de guardar el tipo de envío
            If RBTN_ComYCal.Checked = True Then
                TipoEnvio = 1
                GUARDAR_TIMEACTUAL("Reporte_Individual", "FechaEnvioEst", "ID", idReporte)
            ElseIf RBTN_RespInc.Checked = True Then
                TipoEnvio = 2
                GUARDAR_TIMEACTUAL("Reporte_Individual", "FechaEnvioEst", "ID", idReporte)
            ElseIf RBTN_RespNoInc.Checked = True Then
                TipoEnvio = 3
                GUARDAR_TIMEACTUAL("Reporte_Individual", "FechaEnvioEst", "ID", idReporte)
            Else
                TipoEnvio = 4
            End If
            GUARDAR_INT("Reporte_Individual", "TipoEnvioEst", TipoEnvio, "ID", idReporte)
        Catch ex As Exception
            MsgBox("Error al actualizar el tipo de envío: " & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub BTN_GuardaryCompartir_Click(sender As Object, e As EventArgs) Handles BTN_GuardaryCompartir.Click
        guardarDatos()
    End Sub

    Private Sub BTN_ActualizarEnvio_Click(sender As Object, e As EventArgs) Handles BTN_ActualizarEnvio.Click
        If MessageBox.Show("Desea Actualizar el tipo de envío del informe?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            actualizarEnvio()
            MsgBox("Tipo de envío actualizado con exito", vbOKOnly, "Actualización exitosa")
            P_PReporteIndividualPrincipal.Show()
            Me.Close()
        End If

    End Sub

    Private Sub E_PNuevoReporteIndividual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            If ReporteYacreado Then
                BTN_ActualizarEnvio.PerformClick()
            Else
                BTN_GuardaryCompartir.PerformClick()
            End If
        End If
    End Sub
End Class