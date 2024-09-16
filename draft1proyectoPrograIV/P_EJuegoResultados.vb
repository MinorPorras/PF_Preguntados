Public Class P_EJuegoResultados
    Private idResultado As Integer
    Private Sub CerrarAPP_Click(sender As Object, e As EventArgs) Handles CerrarAPP.Click
        Dim resultado As MsgBoxResult
        resultado = MsgBox("¿Desea cerrar la aplicación?", vbOKCancel + vbQuestion, "Confirmar")

        If resultado = MsgBoxResult.Ok Then
            ' Cerramos la aplicación
            Application.Exit()
        End If
    End Sub

    Private Sub BTN_CerrarSesion_Click(sender As Object, e As EventArgs) Handles BTN_CerrarSesion.Click
        P_TLogin.Show()
        Me.Close()
    End Sub

    Private Sub BTN_CuentaProf_Click(sender As Object, e As EventArgs) Handles BTN_CuentaProf.Click
        P_ECuenta.Show()
    End Sub

    Private Sub TimerJuegoTotal_Tick(sender As Object, e As EventArgs) Handles TimerJuegoTotal.Tick
        TiempoTotalJuego += 1
        TXT_TiempoJuego.Text = TiempoTotalJuego
    End Sub

    Private Sub P_EJuegoResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Stop()
        idResultado = OBTENERPK("Resultados", "id")
        CargarResultados()
        TXT_Tema_Juego.Select()
    End Sub

    Private Sub BTN_ContinuarResultados_Click(sender As Object, e As EventArgs) Handles BTN_ContinuarResultados.Click
        GuardarResult()
        P_EPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub GuardarResult()
        Try
            T.Tables.Clear()
            'Si la PK que esté guardada en idEsultado no existe en la base de datos en ese tabla...
            If EXISTEPK("Resultados", "ID", idResultado) = False Then 'Si no se ha guardado la categoría
                'Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                GUARDAR_PK("Resultados", "ID", idResultado)
            End If
            GUARDAR_INT("Resultados", "ID_Estudiante", ID_cuenta, "id", idResultado)
            SQL = "SELECT s.ID FROM Temas t, Asignatura a, Seccion s, Estudiante e WHERE T.ID_Asignatura = a.ID AND a.ID_Seccion = s.ID AND e.ID_Seccion = e.ID_Seccion AND t.ID = " & IdTema & " AND e.ID = " & ID_cuenta
            T.Tables.Clear()
            Cargar_Tabla(T, SQL)
            Dim idseccion As Integer = T.Tables(0).Rows(0).Item(0)
            GUARDAR_INT("Resultados", "ID_Seccion", idseccion, "id", idResultado)
            GUARDAR_INT("Resultados", "ID_Tema", IdTema, "id", idResultado)
            GUARDAR_TIMEACTUAL("Resultados", "Fecha_Juego", "id", idResultado)
            GUARDAR_INT("Resultados", "Pts_Obtenida", PtsTotalObtenido, "id", idResultado)
            GUARDAR_INT("Resultados", "Pts_Totales", PtsTotalTema, "id", idResultado)
            Dim tiempo As TimeSpan = TimeSpan.FromSeconds(TiempoTotalJuego)
            GUARDAR_TIME("Resultados", "Tiempo_Juego", tiempo, "id", idResultado)
            GUARDAR_INT("Resultados", "Utilizado", 0, "id", idResultado)
            For i As Integer = 0 To PregTotalJuego - 1
                GUARDAR_INTNoPK("Resultados_Respuestas", idResultado, RespEscogida(i), 1)
            Next
            MsgBox("Se guardó la información correctamente", vbOKOnly, "Resultados guardados correctamente")
        Catch ex As Exception
            MsgBox("Error de carga de resultados, favor avisar al encargado." & vbCrLf & ex.ToString(), vbOKOnly, "Error importante")
        End Try
    End Sub

    Private Sub P_EJuegoResultados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_ContinuarResultados.PerformClick()
        End If
    End Sub
End Class