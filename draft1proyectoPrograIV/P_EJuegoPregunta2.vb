Public Class P_EJuegoPregunta2
    '-----------------------Definición de variables------------------------------------------------
    Public RutaImagenEst As String
    Public TiempoRest As TimeSpan

    '------------------------------------Método load--------------------------------------------------------------------------
    Private Sub P_EJuegoPregunta2_Load(sender As Object, e As EventArgs) Handles Me.Load
        L_preg1.Visible = False
        L_preg2.Visible = False
        L_preg3.Visible = False
        L_preg4.Visible = False
        Dim ImagenEst As Image = Image.FromFile(RutaImagenEst)
        BackgroundImage = ImagenEst
        TXT_Tiempo2.Text = TiempoRest.ToString()
        PRB_Preg2.Maximum = CInt(TiempoRest.TotalSeconds)
        PRB_Preg2.Value = PRB_Preg2.Maximum
        TimerPreg.Start()
    End Sub

    '----------------------------Método de limpieza ----------------------------------------
    Public Sub LIMPIAR()
        TXT_DescPreg2.Clear()
        TXT_Tiempo2.Clear()
        TXT_TituloCat.Clear()
        TXT_PtsObt2.Clear()
        BTN_Resp1.Text = ""
        BTN_Resp2.Text = ""
        BTN_Resp3.Text = ""
        BTN_Resp4.Text = ""
        BTN_Resp1.Enabled = True
        BTN_Resp2.Enabled = True
        BTN_Resp3.Enabled = True
        BTN_Resp4.Enabled = True
    End Sub

    '------------------------------ Funciones de los botones -----------------------------------------------
    Private Sub BTN_Resp1_Click(sender As Object, e As EventArgs) Handles BTN_Resp1.Click
        TimerPreg.Stop()
        RespEscogida(contRespEscogida) = CInt(L_preg1.Text)
        contRespEscogida += 1
        'Botón resp 1
        If BTN_Resp1.Tag = 1 Then
            BTN_Resp1.FillColor = Color.FromArgb(102, 221, 51) ' verde
            PtsObtenido += PtsPreg(ContPreg)
            MsgBox_mostrar("Respuesta Correcta" & vbCrLf & "Explicación: " & Explicacion(ContPreg), "Felicidades!")
        Else
            BTN_Resp1.FillColor = Color.FromArgb(255, 49, 49) ' rojo
            Dim stringCorrecta As String = consultarCorrecta()
            MsgBox_mostrar("Respuesta Incorrecta" & vbCrLf & "La respuesta correcta es: " & stringCorrecta & vbCrLf & "Explicación: " & Explicacion(ContPreg), "Mas suerte la próxima!")
        End If
    End Sub
    Private Sub BTN_Resp2_Click(sender As Object, e As EventArgs) Handles BTN_Resp2.Click
        TimerPreg.Stop()
        RespEscogida(contRespEscogida) = CInt(L_preg2.Text)
        contRespEscogida += 1
        'Botón resp 2
        If BTN_Resp2.Tag = 1 Then
            BTN_Resp2.FillColor = Color.FromArgb(102, 221, 51) ' verde
            PtsObtenido += PtsPreg(ContPreg)
            MsgBox_mostrar("Respuesta Correcta" & vbCrLf & "Explicación: " & Explicacion(ContPreg), "Felicidades!")

        Else
            BTN_Resp2.FillColor = Color.FromArgb(255, 49, 49) ' rojo
            Dim stringCorrecta As String = consultarCorrecta()
            MsgBox_mostrar("Respuesta Incorrecta" & vbCrLf & "La respuesta correcta es: " & stringCorrecta & vbCrLf & "Explicación: " & Explicacion(ContPreg), "Mas suerte la próxima!")
        End If

    End Sub

    Private Sub BTN_Resp3_Click(sender As Object, e As EventArgs) Handles BTN_Resp3.Click
        TimerPreg.Stop()
        RespEscogida(contRespEscogida) = CInt(L_preg3.Text)
        contRespEscogida += 1
        'Botón resp 3
        If BTN_Resp3.Tag = 1 Then
            BTN_Resp3.FillColor = Color.FromArgb(102, 221, 51) ' verde
            PtsObtenido += PtsPreg(ContPreg)
            MsgBox_mostrar("Respuesta Correcta" & vbCrLf & "Explicación: " & Explicacion(ContPreg), "Felicidades!")
        Else
            BTN_Resp3.FillColor = Color.FromArgb(255, 49, 49) ' rojo
            Dim stringCorrecta As String = consultarCorrecta()
            MsgBox_mostrar("Respuesta Incorrecta" & vbCrLf & "La respuesta correcta es: " & stringCorrecta & vbCrLf & "Explicación: " & Explicacion(ContPreg), "Mas suerte la próxima!")
        End If
    End Sub

    Private Sub BTN_Resp4_Click(sender As Object, e As EventArgs) Handles BTN_Resp4.Click
        TimerPreg.Stop()
        RespEscogida(contRespEscogida) = CInt(L_preg4.Text)
        contRespEscogida += 1
        'Botón resp 4
        If BTN_Resp4.Tag = 1 Then
            BTN_Resp4.FillColor = Color.FromArgb(102, 221, 51) ' verde
            PtsObtenido += PtsPreg(ContPreg)
            MsgBox_mostrar("Respuesta Correcta" & vbCrLf & "Explicación: " & Explicacion(ContPreg), "Felicidades!")
        Else
            BTN_Resp4.FillColor = Color.FromArgb(255, 49, 49) ' rojo
            Dim stringCorrecta As String = consultarCorrecta()
            MsgBox_mostrar("Respuesta Incorrecta" & vbCrLf & "La respuesta correcta es: " & stringCorrecta & vbCrLf & "Explicación: " & Explicacion(ContPreg), "Mas suerte la próxima!")
        End If
    End Sub

    Private Function consultarCorrecta()
        Dim stringCorrectaF As String = ""
        If BTN_Resp1.Tag = 1 Then
            stringCorrectaF = BTN_Resp1.Text
        ElseIf BTN_Resp2.Tag = 1 Then
            stringCorrectaF = BTN_Resp2.Text
        ElseIf BTN_Resp3.Tag = 1 Then
            stringCorrectaF = BTN_Resp3.Text
        ElseIf BTN_Resp4.Tag = 1 Then
            stringCorrectaF = BTN_Resp4.Text
        End If
        Return stringCorrectaF
    End Function

    Private Sub MsgBox_mostrar(correcta As String, titulo As String)
        Dim resultado As MsgBoxResult
        resultado = MsgBox(correcta, vbOKOnly, titulo)
        If resultado = MsgBoxResult.Ok Then
            ContPreg += 1
            Sig_Preg()
            Me.Close()
        End If
    End Sub

    Public Sub mostrar_correcta()
        If BTN_Resp1.Tag = 1 Then
            BTN_Resp4.FillColor = Color.FromArgb(102, 221, 51) ' verde
            MsgBox_mostrar("Tiempo finalizado" & vbCrLf & "Explicación: " & Explicacion(ContPreg), "Mas suerte la proxima")
        End If
        If BTN_Resp2.Tag = 1 Then
            BTN_Resp4.FillColor = Color.FromArgb(102, 221, 51) ' verde
            MsgBox_mostrar("Tiempo finalizado" & vbCrLf & "Explicación: " & Explicacion(ContPreg), "Mas suerte la proxima")
        End If
        If BTN_Resp3.Tag = 1 Then
            BTN_Resp4.FillColor = Color.FromArgb(102, 221, 51) ' verde
            MsgBox_mostrar("Tiempo finalizado" & vbCrLf & "Explicación: " & Explicacion(ContPreg), "Mas suerte la proxima")
        End If
        If BTN_Resp4.Tag = 1 Then
            BTN_Resp4.FillColor = Color.FromArgb(102, 221, 51) ' verde
            MsgBox_mostrar("Tiempo finalizado" & vbCrLf & "Explicación: " & Explicacion(ContPreg), "Mas suerte la proxima")
        End If
    End Sub

    '------------------------------- Control de timers ----------------------------------------
    Private Sub TimerPreg_Tick(sender As Object, e As EventArgs) Handles TimerPreg.Tick
        If TiempoRest.TotalSeconds > 0 Then
            TiempoRest = TiempoRest.Subtract(New TimeSpan(0, 0, 1))
            ' Actualizar la interfaz de usuario con el tiempo restante
            TXT_Tiempo2.Text = TiempoRest.ToString()
            PRB_Preg2.Value = CInt(TiempoRest.TotalSeconds)
        Else
            ' Realizar la acción deseada cuando se acabe el tiempo
            TimerPreg.Stop()
            mostrar_correcta()
        End If
    End Sub


    '------------------------------Cambio de colores de los botones al pasar por encima de ellos---------------------------------
    Private Sub BTN_Resp1_MouseEnter(sender As Object, e As EventArgs) Handles BTN_Resp1.MouseEnter
        BTN_Resp1.BorderColor = Color.Brown
    End Sub

    Private Sub BTN_Resp1_MouseLeave(sender As Object, e As EventArgs) Handles BTN_Resp1.MouseLeave
        BTN_Resp1.BorderColor = Color.White
    End Sub

    Private Sub BTN_Resp2_MouseEnter(sender As Object, e As EventArgs) Handles BTN_Resp2.MouseEnter
        BTN_Resp2.BorderColor = Color.Brown
    End Sub

    Private Sub BTN_Resp2_MouseLeave(sender As Object, e As EventArgs) Handles BTN_Resp2.MouseLeave
        BTN_Resp2.BorderColor = Color.White
    End Sub

    Private Sub BTN_Resp3_MouseEnter(sender As Object, e As EventArgs) Handles BTN_Resp3.MouseEnter
        BTN_Resp3.BorderColor = Color.Brown
    End Sub

    Private Sub BTN_Resp3_MouseLeave(sender As Object, e As EventArgs) Handles BTN_Resp3.MouseLeave
        BTN_Resp3.BorderColor = Color.White
    End Sub

    Private Sub BTN_Resp4_MouseEnter(sender As Object, e As EventArgs) Handles BTN_Resp4.MouseEnter
        BTN_Resp4.BorderColor = Color.Brown
    End Sub

    Private Sub BTN_Resp4_MouseLeave(sender As Object, e As EventArgs) Handles BTN_Resp4.MouseLeave
        BTN_Resp4.BorderColor = Color.White
    End Sub

    Private Sub P_EJuegoPregunta2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = "1"c Then
            BTN_Resp1.PerformClick()
        ElseIf e.KeyChar = "2"c Then
            BTN_Resp2.PerformClick()
        ElseIf e.KeyChar = "3"c Then
            BTN_Resp3.PerformClick()
        ElseIf e.KeyChar = "4"c Then
            BTN_Resp4.PerformClick()
        End If
    End Sub
End Class