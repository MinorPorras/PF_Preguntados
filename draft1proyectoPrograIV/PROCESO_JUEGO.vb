Module PROCESO_JUEGO

    'Utilizados para el tema
    Public IdTema As Integer
    Public NombreTema As String
    Public URL As String
    Public SonidoTema As String
    Public DescTema As String

    'Utilizados para las categorías y los fondos de las preguntas
    Public Totalcat As Integer
    Public ContCat As Integer = 0
    Public IdCat = New String() {}
    Public NombreCat = New String() {}
    Public DescCat = New String() {}
    Dim ImgEst = New String() {}
    Dim ImgAni = New String() {}
    Dim VideoCat = New String() {}
    Dim AudioCat = New String() {}

    'Utilizados para las preguntas
    Public TotalPreg As Integer
    Public ContPreg As Integer = 0
    Public IdPreg = New String() {}
    Public TXTPreg = New String() {}
    Public PtsPreg = New String() {}
    Public minPreg = New String() {}
    Public secPreg = New String() {}
    Public Explicacion = New String() {}
    Public CantPreg As Integer

    'Utilizados para las respuestas
    Public TotalResp As Integer
    Public ContResp As Integer = 0
    Public IdResp = New String(3) {}
    Public TXTResp = New String(3) {}
    Public correcta = New String(3) {}

    'Utilizado para la contabilización de puntos y los resultados
    Public PtsTotal As Integer
    Public PtsObtenido As Integer
    Public RespCorrecta As Integer = False
    ' Aquí se coloca el id de las respuesta que se seleccionó
    Public Respuestas = New Integer() {}
    'En este arreglo de PtsObtenidos se coloca nada más el 1 o el 0 si la respuesta fue correcta o incorrecta
    Public PtsObtenidosCat = New Integer() {}
    Public PtsTotalTema As Integer
    Public PtsTotalObtenido As Integer
    Public PregTotalJuego As Integer
    Public TiempoTotalJuego As String
    Public RespEscogida = New Integer() {}
    Public contRespEscogida As Integer = 0

    'Para definir que se estpá recabando la información para un reporte
    Public ParaReporte As Boolean


    Public Sub CargarTabla_Tema()
        Try
            GUARDAR_INT("Temas", "Utilizado", 1, "ID", IdTema)
            T.Tables.Clear()
            SQL = "SELECT ID, Nombre, Descripción, Imagen_Estatica, Imagen_Animada, Sonido, Audio, ID_Asignatura FROM TEMAS WHERE ID = " & IdTema
            Cargar_Tabla(T, SQL)
            GUARDAR_INT("Asignatura", "Utilizado", 1, "ID", CInt(T.Tables(0).Rows(0).Item(7)))
        Catch ex As Exception
            MsgBox("Error al cargar la tabla desde la base de datos" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Public Async Sub Cargar_Tema()
        Try
            P_EJuegoResultados.TimerJuegoTotal.Start()
            CargarTabla_Tema()
            NombreTema = T.Tables(0).Rows(0).Item(1)
            P_EJuegoTema.TXT_TituloTema.Text = NombreTema
            DescTema = T.Tables(0).Rows(0).Item(2)
            P_EJuegoTema.TXT_DescTema.Text = DescTema
            P_EJuegoTema.RutaImgEst = T.Tables(0).Rows(0).Item(3)
            P_EJuegoTema.WMP_Tema.uiMode = "none"
            P_EJuegoTema.WMP_Tema.URL = T.Tables(0).Rows(0).Item(4)
            SonidoTema = T.Tables(0).Rows(0).Item(5)

            ' Carga el formulario de manera asincrónica
            Await Task.Run(Sub()
                               ' Reproduce el audio en segundo plano
                               Dim Audio As String = T.Tables(0).Rows(0).Item(6)
                               My.Computer.Audio.Play(Audio, AudioPlayMode.BackgroundLoop)
                           End Sub)
        Catch ex As Exception
            MsgBox("Error al cargar el tema: " & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Public Sub Cargar_Cat()
        Try
            T1.Tables.Clear()
            SQL = "SELECT ID, Nombre, Descripcion, Imagen_Estatica, Imagen_Animada, Audio FROM Categoria WHERE ID_Tema = " & IdTema
            Cargar_Tabla(T1, SQL)
            Totalcat = T1.Tables(0).Rows.Count - 1
            ContCat = 0
            ReDim IdCat(Totalcat)
            ReDim PtsObtenidosCat(Totalcat)
            ReDim NombreCat(Totalcat)
            ReDim DescCat(Totalcat)
            ReDim ImgEst(Totalcat)
            ReDim ImgAni(Totalcat)
            ReDim AudioCat(Totalcat)
            For i As Integer = 0 To T1.Tables(0).Rows.Count - 1
                IdCat(i) = CInt(T1.Tables(0).Rows(i).Item(0))
                GUARDAR_INT("Categoria", "Utilizado", 1, "ID", CInt(T1.Tables(0).Rows(i).Item(0)))
                NombreCat(i) = T1.Tables(0).Rows(i).Item(1)
                DescCat(i) = T1.Tables(0).Rows(i).Item(2)
                ImgEst(i) = T1.Tables(0).Rows(i).Item(3)
                ImgAni(i) = T1.Tables(0).Rows(i).Item(4)
                AudioCat(i) = T1.Tables(0).Rows(i).Item(5)
            Next
        Catch ex As Exception
            MsgBox("Error al cargar la categoría: " & vbCrLf & ex.ToString(), vbOKOnly, "Error")

        End Try
    End Sub
    Public Async Sub Sig_categoria()
        Try
            If ContCat <= Totalcat Then
                P_EJuegoCategoria.Show()
                P_EJuegoPregunta.Close()
                P_EJuegoPregunta2.Close()
                P_EJuegoCategoria.LIMPIAR()
                'Carga la pesta{a de categoría con su información respectiva
                P_EJuegoCategoria.TXT_TituloCat.Text = NombreCat(ContCat)
                P_EJuegoCategoria.TXT_DescCat.Text = DescCat(ContCat)
                P_EJuegoCategoria.RutaImgEst = ImgEst(ContCat)
                P_EJuegoCategoria.WMP_Cat.uiMode = "none"
                P_EJuegoCategoria.WMP_Cat.URL = ImgAni(ContCat)
                Await Task.Run(Sub()
                                   ' Reproduce el audio en segundo plano
                                   My.Computer.Audio.Play(SonidoTema, AudioPlayMode.BackgroundLoop)
                                   'Luego eliminar esto de aquí y colocarlo cuando termine el recorrido del form de preguntas
                               End Sub)
            Else
                'Se muestra la página de resultados
                MsgBox("¡Se acabó el juego! ¡Buen Trabajo!", vbOKOnly, "Fin del juego")
                P_EJuegoResultados.Show()
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la siguiente categoría: " & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Public Sub cargar_Preguntas(IdCategoria As Integer)
        Try
            T2.Tables.Clear()
            SQL = "SELECT ID, Texto, Puntaje, DATEPART('n', Tiempo) As Minutos, DATEPART('s', Tiempo) As Segundos, Explicacion FROM Preguntas  WHERE ID_Categoria =" & IdCategoria
            Cargar_Tabla(T2, SQL)
            TotalPreg = T2.Tables(0).Rows.Count - 1
            CantPreg = T2.Tables(0).Rows.Count
            ContPreg = 0
            ReDim IdPreg(TotalPreg)
            ReDim TXTPreg(TotalPreg)
            ReDim PtsPreg(TotalPreg)
            ReDim minPreg(TotalPreg)
            ReDim secPreg(TotalPreg)
            ReDim Explicacion(TotalPreg)
            PtsObtenido = 0
            PtsTotal = 0
            For i As Integer = 0 To T2.Tables(0).Rows.Count - 1
                IdPreg(i) = T2.Tables(0).Rows(i).Item(0)
                GUARDAR_INT("Preguntas", "Utilizado", 1, "ID", CInt(T2.Tables(0).Rows(i).Item(0)))
                TXTPreg(i) = T2.Tables(0).Rows(i).Item(1)
                PtsPreg(i) = T2.Tables(0).Rows(i).Item(2)
                PtsTotal += CInt(T2.Tables(0).Rows(i).Item(2))
                minPreg(i) = T2.Tables(0).Rows(i).Item(3)
                secPreg(i) = T2.Tables(0).Rows(i).Item(4)
                Explicacion(i) = T2.Tables(0).Rows(i).Item(5)
            Next
            Dim Audio As String = AudioCat(ContCat)
            My.Computer.Audio.Play(Audio, AudioPlayMode.BackgroundLoop)
        Catch ex As Exception
            MsgBox("Error al cargar las preguntas: " & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Public Sub Sig_Preg()
        Try
            If ContCat <= Totalcat Then
                'Código para cargar los datos de la pregunta en el forms de la pregunta dentro del juego y aumento en 1 del contPreg
                If ContPreg <= TotalPreg Then
                    P_EJuegoPregunta.LIMPIAR()
                    P_EJuegoPregunta.TXT_CantPreg.Text = "Pregunta: " & ContPreg + 1 & " / " & CantPreg
                    P_EJuegoPregunta.TXT_TituloCat.Text = NombreCat(ContCat)
                    P_EJuegoPregunta.TXT_DescPreg.Text = TXTPreg(ContPreg)
                    P_EJuegoPregunta.TiempoRest = New TimeSpan(0, minPreg(ContPreg), secPreg(ContPreg))
                    P_EJuegoPregunta.TXT_PtsPreg.Text = "Pts: " & PtsPreg(ContPreg)
                    P_EJuegoPregunta.RutaImagenEst = ImgEst(ContCat)
                    cargar_Respuesta(IdPreg(ContPreg))

                    P_EJuegoPregunta.BTN_Resp1.Text = TXTResp(0)
                    P_EJuegoPregunta.BTN_Resp1.Tag = correcta(0)

                    P_EJuegoPregunta.BTN_Resp2.Text = TXTResp(1)
                    P_EJuegoPregunta.BTN_Resp2.Tag = correcta(1)

                    P_EJuegoPregunta.BTN_Resp3.Text = TXTResp(2)
                    P_EJuegoPregunta.BTN_Resp3.Tag = correcta(2)

                    P_EJuegoPregunta.BTN_Resp4.Text = TXTResp(3)
                    P_EJuegoPregunta.BTN_Resp4.Tag = correcta(3)

                    Dim stringPts As String = "Puntos: " & PtsObtenido & " / " & PtsTotal
                    P_EJuegoPregunta.TXT_PtsObt.Text = stringPts

                    P_EJuegoPregunta.Show()
                Else
                    If Not ParaReporte Then
                        PtsObtenidosCat(ContCat) = PtsObtenido
                        ContCat += 1
                        P_EJuegoPregunta.LIMPIAR()
                        P_EJuegoPregunta2.LIMPIAR()
                        Sig_categoria()
                    Else
                        ContCat += 1
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la siguiente pregunta: " & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Public Sub Sig_Preg2()
        Try
            If ContCat <= Totalcat Then
                'Código para cargar los datos de la pregunta en el forms de la pregunta dentro del juego y aumento en 1 del contPreg
                If ContPreg <= TotalPreg Then
                    P_EJuegoPregunta2.LIMPIAR()
                    P_EJuegoPregunta2.TXT_CantPreg.Text = "Pregunta: " & ContPreg + 1 & " / " & CantPreg
                    P_EJuegoPregunta2.TXT_TituloCat.Text = NombreCat(ContCat)
                    P_EJuegoPregunta2.TXT_DescPreg2.Text = TXTPreg(ContPreg)
                    P_EJuegoPregunta2.TiempoRest = New TimeSpan(0, minPreg(ContPreg), secPreg(ContPreg))
                    P_EJuegoPregunta2.TXT_PtsPreg.Text = "Pts: " & PtsPreg(ContPreg)
                    P_EJuegoPregunta.RutaImagenEst = ImgEst(ContCat)
                    cargar_Respuesta(IdPreg(ContPreg))

                    P_EJuegoPregunta2.BTN_Resp1.Text = TXTResp(0)
                    P_EJuegoPregunta2.BTN_Resp1.Tag = correcta(0)

                    P_EJuegoPregunta2.BTN_Resp2.Text = TXTResp(1)
                    P_EJuegoPregunta2.BTN_Resp2.Tag = correcta(1)

                    P_EJuegoPregunta2.BTN_Resp3.Text = TXTResp(2)
                    P_EJuegoPregunta2.BTN_Resp3.Tag = correcta(2)

                    P_EJuegoPregunta2.BTN_Resp4.Text = TXTResp(3)
                    P_EJuegoPregunta2.BTN_Resp4.Tag = correcta(3)

                    Dim stringPts As String = "Puntos: " & PtsObtenido & " / " & PtsTotal
                    P_EJuegoPregunta2.TXT_PtsObt2.Text = stringPts

                    P_EJuegoPregunta2.Show()
                Else
                    PtsObtenidosCat(ContCat) = PtsObtenido
                    ContCat += 1
                    P_EJuegoPregunta.LIMPIAR()
                    P_EJuegoPregunta2.LIMPIAR()
                    Sig_categoria()
                End If
            Else
                'Se muestra la página de resultados
                MsgBox("¡Se acabó el juego!", vbOK, "Fin del juego")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la siguiente pregunta: " & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Public Sub cargar_Respuesta(IdPregunta As Integer)
        Try
            T3.Tables.Clear()
            SQL = "SELECT ID, Texto, Correcta FROM RESPUESTAS WHERE ID_Pregunta = " & IdPregunta
            Cargar_Tabla(T3, SQL)
            TotalResp = T3.Tables(0).Rows.Count() - 1
            ContResp = 0
            For i As Integer = 0 To TotalResp
                IdResp(i) = T3.Tables(0).Rows(i).Item(0)
                GUARDAR_INT("Respuestas", "Utilizado", 1, "ID", CInt(T3.Tables(0).Rows(i).Item(0)))
                If i = 0 Then
                    P_EJuegoPregunta.L_preg1.Text = IdResp(i)
                    P_EJuegoPregunta2.L_preg1.Text = IdResp(i)
                ElseIf i = 1 Then
                    P_EJuegoPregunta.L_preg2.Text = IdResp(i)
                    P_EJuegoPregunta2.L_preg2.Text = IdResp(i)
                ElseIf i = 2 Then
                    P_EJuegoPregunta.L_preg3.Text = IdResp(i)
                    P_EJuegoPregunta2.L_preg3.Text = IdResp(i)
                Else
                    P_EJuegoPregunta.L_preg4.Text = IdResp(i)
                    P_EJuegoPregunta2.L_preg4.Text = IdResp(i)
                End If

                TXTResp(i) = T3.Tables(0).Rows(i).Item(1)
                correcta(i) = T3.Tables(0).Rows(i).Item(2)
            Next
            If TotalResp < 3 Then
                For i As Integer = TotalResp + 1 To 3
                    IdResp(i) = 0
                    TXTResp(i) = "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
                    correcta(i) = 0
                Next
            End If
        Catch ex As Exception
            MsgBox("Error al cargar las respuestas: " & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Public Sub CargarResultados()
        Try
            P_EJuegoResultados.TimerJuegoTotal.Stop()
            P_EJuegoResultados.TXT_Tema_Juego.Text = NombreTema
            P_EJuegoResultados.TXT_CantCat.Text = Totalcat + 1
            For i As Integer = 0 To Totalcat
                PtsTotalObtenido += PtsObtenidosCat(i)
            Next
            Dim nota As Decimal = (PtsTotalObtenido * 100) / PtsTotalTema
            P_EJuegoResultados.TXT_Nota.Text = nota.ToString() & "%"
            P_EJuegoResultados.TXT_PtsObtenidos.Text = PtsTotalObtenido & " / " & PtsTotalTema
            P_EJuegoResultados.TXT_CantPreg.Text = PregTotalJuego
            Dim tiempo As TimeSpan = TimeSpan.FromSeconds(TiempoTotalJuego)
            Dim stringTiempo As String = tiempo.ToString()
            P_EJuegoResultados.TXT_TiempoJuego.Text = stringTiempo
            ContCat = 0
            ContPreg = 0
            contRespEscogida = 0
            PtsObtenido = 0
        Catch ex As Exception
            MsgBox("Error al cargar los resultados: " & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

End Module
