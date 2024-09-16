Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop.Excel
Imports System.IO

Module REPORTES

    Dim excelAPP As New Excel.Application
    Public OEXCEL = excelAPP
    Dim excelDoc As Object
    Dim wb As Object
    Dim WordApp As New Word.Application
    Public OWORD = WordApp
    Dim WordDoc As New Word.Document
    Public DOCUMENTO = WordDoc
    Dim DIRECTORIO As String
    Dim FUENTE As String = "Arial"

    Dim REPORTE_DIRECCION_PDF As String = ""
    Dim REPORTE_DIRECCION_WORD As String = ""
    Dim REPORTE_DIRECCION_EXCEL As String = ""

    Dim WordTabla1, WordTabla2, WordTabla3, WordTabla4 As Word.Table
    Public wt1 = WordTabla1
    Public wt2 = WordTabla2
    Public wt3 = WordTabla3
    Public wt4 = WordTabla4

    Dim Par0, Par1, Par2, Par3, Par4, Par5, Par6, Par7, Par8, Par9, Par10, Par11, Par12, Par13, Par14, Par15, Par16, Par17, Par18 As Word.Paragraph
    Public P0 = Par0
    Public P1 = Par1
    Public P2 = Par2
    Public P3 = Par3
    Public P4 = Par4
    Public P5 = Par5
    Public P6 = Par6
    Public P7 = Par7
    Public P8 = Par8
    Public P9 = Par9
    Public P10 = Par10
    Public P11 = Par11
    Public P12 = Par12
    Public P13 = Par13
    Public P14 = Par14
    Public P15 = Par15
    Public P16 = Par16
    Public P17 = Par17
    Public P18 = Par18
    Dim MATRIZ(100, 100) As String
    Dim MATRIZ2(100, 100) As String

    Dim S1 As Excel.Worksheet
    Dim ARRAY() = New String(15) {}
    Dim ARRAY1() = New String(15) {}
    Dim ARRAY2() = New String(15) {}
    Dim ARRAY3() = New String(15) {}
    Dim ARRAY4() = New String(15) {}
    Dim ARRAY5() = New String(15) {}
    Dim ARRAY6() = New String(15) {}
    Dim ARRAY7() = New String(15) {}
    Dim ARRAY8() = New String(15) {}
    Dim ARRAY9() = New String(15) {}
    Dim ARRAY10() = New String(15) {}
    Dim columnaInsertada As Integer

    'Dim correoEnvio = New System.Net.Mail.MailMessage()

    Public idInformeRep As Integer
    Public idResultRep As Integer

    Public idEstRep As Integer
    Public NombreEstRep As String
    Public idAsigRep As Integer
    Public NombreAsigRep As String
    Public idSeccionRep As Integer
    Public NombreSeccionRep As String
    Public PtsObtenidoRep As Integer
    Public PtsTotalRep As Integer
    Public NotaRep As Double

    'Usadas para el reporte general
    Public idPregFacilRep = New Integer() {}
    Public TxtPregFacilRep = New String() {}
    Public CantAciertosrRep = New Integer() {}
    Public TxtPregDificilRep = New String() {}
    Public CantAciertosrDificilRep = New Integer() {}
    Public NomMejorEstRep = New Integer() {}
    Public notaMejorEstRep = New Double() {}
    Public NomPeorEstRep = New Integer() {}
    Public notaPeorEstRep = New Double() {}
    Public PromedioNota As Double

    'Infor tema
    Public idTemaRep As Integer
    Public NombreTemaRep As String
    Public DescTemaRep As String

    'Info de las categorías
    Public TotalcatRep As Integer
    Public ContCatRep As Integer = 0
    Public IdCatRep = New Integer() {}
    Public NombreCatRep = New String() {}
    Public DescCatRep = New String() {}

    'Info de las Pregnutas
    Public TotalPregRep As Integer
    Public ContPregRep As Integer = 0
    Public IdPregRep = New String() {}
    Public TXTPregRep = New String() {}
    Public PtsPregRep = New String() {}
    Public ExplicacionRep = New String() {}
    Public TiempoPregRep = New String() {}
    Public CantPregRep As Integer
    Dim cantPregObtenidasFacil As Integer
    Dim cantPregObtenidasDificil As Integer = 0
    Dim cantEstmejorObtenido As Integer
    Dim cantEstPeorObtenido As Integer

    'Info de las respuestas
    Public TotalRespRep As Integer
    Public ContResp As Integer = 0
    Public IDRespCorrecta = New String() {}
    Public IDRespEscogida = New String() {}
    Dim respEquivocada As Boolean = False
    Dim ContRespRep As Integer




    Public TipodeRep As Integer
    ' Si es 1 = Individual                Si es 2 = General

    Public TipoEnvio As Integer
    'En reporte individual:
    ' Si es = 1: Se envía con todo y calificación        Si es = 2: Se envía la actividad con las respuestas que escogió el estudiante
    'Si es = 3: Se envía la actividad  sin las respuestas   Si es = 4: No se envía la actividad al estudiante
    '***** Solo se utiliza para los reportes individuales

    Public tipoRepGen As Integer
    'Si es = 1 Reporte completo con top 5 estudiantes con mejores y peores notas, top 5 preguntas mas acertadas y falladas, con un resumen de la actividad
    'Si es = 2 Reporte resumindo con solo los mejores y peores

    Public TipoExportacion As Integer
    ' si es = 1: Se va a descargar al equipo         Si es = 2: Se envía por correo

    Public RepWord As Boolean = False

    Friend Sub iniciarlizarWord()
        Dim WordApp As New Word.Application
        OWORD = WordApp
        DOCUMENTO = OWORD.Documents.Add()
        ReDim MATRIZ(100, 100)
        ReDim MATRIZ2(100, 100)
        wt1 = WordTabla1
        wt2 = WordTabla2
    End Sub

    Friend Sub INSERTAR_REGLON(ByVal ES_EL_PRIMER_PARRAFO As Boolean, ByRef PARRAFO As Word.Paragraph, ByVal TEXTO As String, ByVal NEGRITA As Boolean, ByVal CURSIVA As Boolean, ByVal TAMANO As Byte, ByVal ALINEACION As Char, ByVal INCORRECTO As Char)

        If ES_EL_PRIMER_PARRAFO = True Then
            PARRAFO = DOCUMENTO.Content.Paragraphs.Add
        Else
            Dim bookmarkName As String = "\endofdoc"
            Dim bookmarkRange As Word.Range = DOCUMENTO.Bookmarks(bookmarkName).Range
            PARRAFO = DOCUMENTO.Content.Paragraphs.Add(bookmarkRange)
        End If

        PARRAFO.Range.Text = TEXTO

        If NEGRITA = True Then
            PARRAFO.Range.Font.Bold = True
        Else
            PARRAFO.Range.Font.Bold = False
        End If

        If CURSIVA = True Then
            PARRAFO.Range.Font.Italic = True
        Else
            PARRAFO.Range.Font.Italic = False
        End If

        If INCORRECTO = "x" Then
            PARRAFO.Range.Font.Color = WdColor.wdColorRed
        ElseIf INCORRECTO = "o" Then
            PARRAFO.Range.Font.Color = WdColor.wdColorLime
        Else
            PARRAFO.Range.Font.Color = WdColor.wdColorBlack
        End If

        PARRAFO.Range.Font.Size = TAMANO
        PARRAFO.Range.Font.Name = FUENTE

        Select Case ALINEACION
            Case "I" 'IZQUIERDA
                PARRAFO.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft

            Case "D" 'DERECHA
                PARRAFO.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight

            Case "J" 'JUSTIFICADO
                PARRAFO.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify

            Case "C" 'CENTRADO
                PARRAFO.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        End Select

        PARRAFO.Range.InsertParagraphAfter()
    End Sub

    Friend Sub INSERTAR_LINEA_BLANCO(ByRef PARRAFO_ANTERIOR As Word.Paragraph, ByVal CANTIDAD_LINEAS_EN_BLANCO As Byte)
        Dim I As Byte

        For I = 1 To CANTIDAD_LINEAS_EN_BLANCO
            PARRAFO_ANTERIOR.Range.InsertParagraphBefore()
        Next
    End Sub

    Friend Sub INSERTAR_TABLA(ByVal VECTOR(,) As String, ByVal FILAS As Byte, ByVal COLUMNAS As Byte, ByVal TABLA As Word.Table, ByVal TAMANO As Byte, ByVal ANCHO_CELDA As Byte, ByVal ALTO_CELDA As Byte, ByVal ALINEACION As Char, ByVal NEGRITA As Boolean, ByVal CURSIVA As Boolean, ByVal INDICE_COLUMNA_NEGRITA As Byte, ByVal REQUIERE_COLUMNA_NEGRITA As Boolean, ByVal INDICE_COLUMNA_CURSIVA As Byte, ByVal REQUIERE_COLUMNA_CURSIVA As Boolean, ByRef PARRAFO As Word.Paragraph, ByVal INDICE_COLUMNA_CENTRAR As Byte, ByVal REQUIERE_COLUMNA_CENTRAR As Boolean)

        Dim FILA As Byte, COLUMNA As Byte
        Dim bookmarkName As String = "\endofdoc"
        Dim bookmarkRange As Word.Range = DOCUMENTO.Bookmarks(bookmarkName).Range
        TABLA = DOCUMENTO.Tables.Add(bookmarkRange, FILAS, COLUMNAS)
        For FILA = 1 To FILAS
            For COLUMNA = 1 To COLUMNAS
                TABLA.Cell(FILA, COLUMNA).Range.Text = VECTOR(FILA - 1, COLUMNA - 1)

                Select Case ALINEACION
                    Case "I" 'IZQUIERDA
                        TABLA.Cell(FILA, COLUMNA).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                    Case "D" 'DERECHA
                        TABLA.Cell(FILA, COLUMNA).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                    Case "J" 'JUSTIFICADO
                        TABLA.Cell(FILA, COLUMNA).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
                    Case "C" 'CENTRADO
                        TABLA.Cell(FILA, COLUMNA).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                End Select

                TABLA.Cell(FILA, COLUMNA).Range.Font.Size = TAMANO

                TABLA.Cell(FILA, COLUMNA).Range.Font.Name = FUENTE


                If NEGRITA = True Then
                    TABLA.Cell(FILA, COLUMNA).Range.Font.Bold = True
                Else
                    TABLA.Cell(FILA, COLUMNA).Range.Font.Bold = False
                End If

                If CURSIVA = True Then
                    TABLA.Cell(FILA, COLUMNA).Range.Font.Italic = True
                Else
                    TABLA.Cell(FILA, COLUMNA).Range.Font.Italic = False
                End If

                If REQUIERE_COLUMNA_CURSIVA = True Then

                    If COLUMNA = INDICE_COLUMNA_CURSIVA Then

                        TABLA.Cell(FILA, COLUMNA).Range.Font.Italic = True

                    Else
                        TABLA.Cell(FILA, COLUMNA).Range.Font.Italic = False

                    End If
                End If

                If REQUIERE_COLUMNA_CENTRAR = True Then
                    If COLUMNA = INDICE_COLUMNA_CENTRAR Then

                        TABLA.Cell(FILA, COLUMNA).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter

                    End If
                End If
            Next
        Next

        TABLA.Borders.OutsideColor = WdColor.wdColorWhite

        PARRAFO = DOCUMENTO.Content.Paragraphs.Add(bookmarkRange)

    End Sub


    Friend Sub CREAR_DIRECTORIO(ByVal CARPETA As String)
        DIRECTORIO = "C:\" & CARPETA
        Directory.CreateDirectory(DIRECTORIO)
    End Sub

    Friend Sub GUARDAR_DOCUMENTO_PDF(ByVal NOMBRE_DOCUMENTO As String, ByVal VER_REPORTE As Boolean)

        Dim DIRECCION As String = DIRECTORIO & "\" & NOMBRE_DOCUMENTO
        DOCUMENTO.SaveAs2(DIRECCION & ".DOCX")
        REPORTE_DIRECCION_WORD = DIRECCION & ".DOCX"

        DOCUMENTO.ExportAsFixedFormat(DIRECCION, WdExportFormat.wdExportFormatPDF, VER_REPORTE)
        REPORTE_DIRECCION_PDF = DIRECCION & ".pdf"

        'If MsgBox("¿Desea enviar el documento a la impresora?", vbQuestion + vbYesNo, "Impresora") = vbYes Then
        '    DOCUMENTO.PrintOut()
        'End If
    End Sub

    Friend Sub CERRAR_DOCUMENTO_WORD()
        OWORD.Documents.Close()
        OWORD.Application.Quit()
        WordDoc = Nothing
        WordApp = Nothing
        wt1 = Nothing
        wt2 = Nothing
        RepWord = False
    End Sub

    Friend Sub GuardarDocWord()
        Dim directorio As String
        'Se crea el directorio
        If TipodeRep = 1 Then
            directorio = "Reportes_Juego_Word\Individuales\Word"
        Else
            directorio = "Reportes_Juego_Word\Generales\Word"
        End If
        CREAR_DIRECTORIO(directorio)
        'Se obtienen los valores para los nombres de los archivos
        NombreTemaRep = NombreTemaRep.Replace(" ", "")
        Dim FechaNSpace = Date.Now().ToString().Replace(" ", "").Replace("/", "").Replace(":", "")
        If MessageBox.Show("Desea abrir este informe?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'Se guarda el reporte y se abre
            GUARDAR_DOCUMENTO_PDF("Reporte" & "_" & NombreTemaRep & "_" & FechaNSpace, True)
            P_PGenerandoInforme.Close()
        Else
            'Se guarda el reporte pero no se abre
            GUARDAR_DOCUMENTO_PDF("Reporte" & "_" & NombreTemaRep & "_" & FechaNSpace, False)
            P_PGenerandoInforme.Close()
        End If
        'Se cierra la app y el documento de word
        CERRAR_DOCUMENTO_WORD()
    End Sub

    Friend Sub ProcesoReporte()
        If TipoExportacion = 1 Then
            If TipodeRep = 1 Then
                If RepWord Then
                    'Si es un reporte individual en word
                    generarRepIndividualWord()
                Else
                    'Si es un reporte individual en excel
                    generarRepIndividualExcel()
                End If

            ElseIf TipodeRep = 2 Then
                If RepWord Then
                    'Si es un reporte general en word
                    generarRepGeneralWord()
                Else
                    'Si es un reporte general en excel
                    generarRepGeneralExcel()
                End If
            End If
        End If

    End Sub

    Private Sub generarRepGeneralWord()
        Try
            iniciarlizarWord()
            INSERTAR_REGLON(True, P1, "Informe de Desempeño General", True, False, 20, "C", "b")
            INSERTAR_LINEA_BLANCO(P1, 1)
            cargarNombreProf()
            CargarPregFacDif()
            cargarCaliRep()
            Dim NombreProf = T5.Tables(0).Rows(0).Item(0) & " " & T5.Tables(0).Rows(0).Item(1) & " " & T5.Tables(0).Rows(0).Item(2)
            INSERTAR_REGLON(False, P2, "Profesor: " & NombreProf, False, False, 12, "I", "b")
            INSERTAR_LINEA_BLANCO(P2, 1)
            INSERTAR_REGLON(False, P3, "Asignatura: " & NombreAsigRep & "        Sección: " & NombreSeccionRep, False, False, 12, "C", "b")
            INSERTAR_REGLON(False, P4, "Promedio de notas: " & Math.Round(PromedioNota, 2) & "%", True, False, 16, "C", "b")
            INSERTAR_LINEA_BLANCO(P4, 1)
            INSERTAR_REGLON(False, P5, "Tema: " & NombreTemaRep, True, False, 16, "C", "b")
            'Se carga la descripción del tema
            Cargar_DescTema()
            INSERTAR_REGLON(False, P6, "Descripción: " & DescTemaRep, False, False, 11, "J", "b")
            INSERTAR_LINEA_BLANCO(P6, 1)
            If tipoRepGen = 1 Then
                INSERTAR_REGLON(False, P7, "Preguntas más sencillas: ", True, False, 12, "i", "b")
                For i As Integer = 0 To CantPregRep
                    If i <> 4 Then
                        MATRIZ(i, 0) = i + 1 & ". " & TxtPregFacilRep(i)
                        MATRIZ(i, 1) = "Aciertos: " & CantAciertosrRep(i)
                    Else
                        cantPregObtenidasFacil = i
                        Exit For
                    End If
                    cantPregObtenidasFacil = i
                Next
                INSERTAR_TABLA(MATRIZ, cantPregObtenidasFacil + 1, 2, wt1, 11, 0, 0, "I", False, False, 2, True, 0, False, P7, 2, True)
                INSERTAR_REGLON(False, P8, "", False, False, 11, "C", "b")
                INSERTAR_LINEA_BLANCO(P8, 1)
                INSERTAR_REGLON(False, P9, "Preguntas más dificiles: ", True, False, 12, "I", "b")
                For i As Integer = 0 To CantPregRep
                    If i <> 4 Then
                        MATRIZ(i, 0) = i + 1 & ". " & TxtPregDificilRep(i)
                        MATRIZ(i, 1) = "Aciertos: " & CantAciertosrDificilRep(i)
                    Else
                        cantPregObtenidasDificil = i
                        Exit For
                    End If
                    cantPregObtenidasDificil = i
                Next
                INSERTAR_TABLA(MATRIZ, cantPregObtenidasDificil + 1, 2, wt2, 11, 0, 0, "I", False, False, 2, True, 0, False, P10, 2, True)

                INSERTAR_REGLON(False, P11, "", False, False, 11, "C", "b")
                INSERTAR_LINEA_BLANCO(P11, 1)
                INSERTAR_REGLON(False, P12, "Mejores notas: ", True, False, 12, "I", "b")
                For i As Integer = 0 To cantEstmejorObtenido
                    If i <> 4 Then
                        MATRIZ(i, 0) = i + 1 & ". " & NomMejorEstRep(i)
                        MATRIZ(i, 1) = "Nota: " & notaMejorEstRep(i)
                    Else
                        Exit For
                    End If
                Next
                INSERTAR_TABLA(MATRIZ, cantEstmejorObtenido + 1, 2, wt3, 11, 0, 0, "I", False, False, 2, True, 0, False, P13, 0, False)

                INSERTAR_REGLON(False, P14, "", False, False, 11, "C", "b")
                INSERTAR_LINEA_BLANCO(P14, 1)
                INSERTAR_REGLON(False, P15, "Notas mas bajas: ", True, False, 12, "I", "b")
                For i As Integer = 0 To cantEstPeorObtenido
                    If i <> 4 Then
                        MATRIZ(i, 0) = i + 1 & ". " & NomPeorEstRep(i)
                        MATRIZ(i, 1) = "Nota: " & notaPeorEstRep(i)
                    Else
                        Exit For
                    End If
                Next
                INSERTAR_TABLA(MATRIZ, cantEstPeorObtenido + 1, 2, wt4, 11, 0, 0, "I", False, False, 2, True, 0, False, P16, 0, False)
                INSERTAR_LINEA_BLANCO(P16, 1)
            Else
                INSERTAR_REGLON(False, P7, "Pregunta más sencilla: " & TxtPregFacilRep(0), True, False, 11, "I", "b")
                INSERTAR_REGLON(False, P8, "Aciertos: " & CantAciertosrRep(0), False, False, 11, "I", "b")
                INSERTAR_LINEA_BLANCO(P8, 1)
                INSERTAR_REGLON(False, P9, "Pregunta más dificil: " & TxtPregDificilRep(0), True, False, 11, "I", "b")
                INSERTAR_REGLON(False, P10, "Aciertos: " & CantAciertosrDificilRep(0), False, False, 11, "I", "b")
                INSERTAR_LINEA_BLANCO(P10, 1)
                INSERTAR_REGLON(False, P11, "Mejor nota: " & Math.Round(notaMejorEstRep(0), 2) & "%", True, False, 11, "I", "b")
                INSERTAR_REGLON(False, P12, "Estudiante: " & NomMejorEstRep(0), False, False, 11, "I", "b")
                INSERTAR_LINEA_BLANCO(P12, 1)
                INSERTAR_REGLON(False, P13, "Peor nota: " & Math.Round(notaPeorEstRep(0), 2) & "%", True, False, 11, "I", "b")
                INSERTAR_REGLON(False, P14, "Estudiante: " & NomPeorEstRep(0), False, False, 11, "I", "b")
                INSERTAR_LINEA_BLANCO(P14, 1)
            End If

            GuardarDocWord()
        Catch ex As Exception
            CERRAR_DOCUMENTO_WORD()
            MsgBox("Error al general el reporte: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try

    End Sub

    Friend Sub generarRepIndividualWord()
        Try
            iniciarlizarWord()
            If TipoEnvio = 1 Or TipoEnvio = 2 Or TipoEnvio = 3 Then
                'Titulo del informe
                INSERTAR_REGLON(True, P1, "Informe de Desempeño Individual", True, False, 20, "C", "b")
                INSERTAR_LINEA_BLANCO(P1, 1)
                'Guardar Nombre del profesor
                cargarNombreProf()
                Dim NombreProf = T5.Tables(0).Rows(0).Item(0) & " " & T5.Tables(0).Rows(0).Item(1) & " " & T5.Tables(0).Rows(0).Item(2)
                INSERTAR_REGLON(False, P2, "Profesor: " & NombreProf, False, False, 12, "I", "b")
                INSERTAR_REGLON(False, P3, "Estudiante: " & NombreEstRep, False, False, 12, "I", "b")
                INSERTAR_LINEA_BLANCO(P3, 1)
                INSERTAR_REGLON(False, P4, "Asignatura: " & NombreAsigRep & "                        Sección: " & NombreSeccionRep, False, False, 12, "C", "b")
                'Generar las lineas done3e están la info del estudiante, asignatura, tema, y nota
                '---------------------------------------------------------------------------------------------------'
                MATRIZ(0, 0) = ""
                MATRIZ(0, 1) = ""
                MATRIZ(0, 2) = ""
                '---------------------------------------------------------------------------------------------------'
                If TipoEnvio = 1 Then
                    MATRIZ(1, 0) = "Pts Totales: " & PtsTotalRep
                    MATRIZ(1, 1) = "Pts Obtenidos: " & PtsObtenidoRep
                    MATRIZ(1, 2) = "Nota: " & NotaRep & "%"
                Else
                    MATRIZ(1, 0) = ""
                    MATRIZ(1, 1) = ""
                    MATRIZ(1, 2) = ""
                End If
                '---------------------------------------------------------------------------------------------------'
                INSERTAR_TABLA(MATRIZ, 2, 3, wt1, 11, 0, 0, "C", False, False, 0, False, 0, False, P5, 0, False)
                Erase MATRIZ
                INSERTAR_REGLON(False, P6, "Tema: " & NombreTemaRep, True, False, 14, "C", "b")

                'Se carga la descripción del tema
                Cargar_DescTema()
                INSERTAR_REGLON(False, P7, "Descripción: " & DescTemaRep, False, False, 11, "J", "b")
                INSERTAR_LINEA_BLANCO(P7, 1)
                'Se comienza a hacer la insersión de las categorías, preguntas y respuestas
                INSERTAR_REGLON(False, P8, "Categorías:", True, False, 14, "I", "b")
                INSERTAR_LINEA_BLANCO(P8, 1)

                'Se cargan las respuesta escogidas por el estudiante y las correctas del tema
                CargarRespCorrectasRep()
                'Se cargan las categorías
                Cargar_CatRep()
                ContPregRep = 0
                For ContCatRep As Integer = 0 To TotalcatRep - 1
                    INSERTAR_REGLON(False, P9, ContCatRep + 1 & ". " & NombreCatRep(ContCatRep), True, False, 12, "I", "b")
                    INSERTAR_REGLON(False, P10, "Descripción: " & DescCatRep(ContCatRep), False, False, 11, "I", "b")
                    INSERTAR_REGLON(False, P11, "Preguntas: ", True, False, 11, "I", "b")
                    Erase MATRIZ
                    'Se cargan las preguntas 
                    cargar_PreguntasRep(IdCatRep(ContCatRep))
                    For ContPregRep As Integer = 0 To TotalPregRep
                        INSERTAR_REGLON(False, P12, ContPregRep + 1 & ") " & TXTPregRep(ContPregRep), False, False, 11, "J", "b")
                        INSERTAR_REGLON(False, P13, "Tiempo: " & TiempoPregRep(ContPregRep) & "                                                                      Pts pregunta: " & PtsPregRep(ContPregRep), False, False, 11, "J", "b")
                        If TipoEnvio = 1 Then
                            'Se cargan las respuestas que tengan el id de pregunta que se mandó
                            cargar_RespuestaRep(IdPregRep(ContPregRep), P14, P15, P16, P17, P18)
                            'Si el tipo de envío es = 2
                        ElseIf TipoEnvio = 2 Then
                            'Carga solo las repsuestas escopgidas por el estudiante
                            cargar_RespuestaRep(IdPregRep(ContPregRep), P14, P15, P16, P17, P18)
                        ElseIf TipoEnvio = 3 Then
                            'Solo inserta las preguntas sin sus respuestas.
                            INSERTAR_LINEA_BLANCO(P13, 1)
                        End If
                    Next
                Next
                GuardarDocWord()
            End If
        Catch ex As Exception
            CERRAR_DOCUMENTO_WORD()
            MsgBox("Error al general el reporte: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try


    End Sub

    Friend Sub cargarNombreProf()
        T5.Tables.Clear()
        SQL = "SELECT p.Nombre, P.Apellido1, p.Apellido2 FROM Profesores p, Asignatura a WHERE a.ID_Profesor = p.ID AND a.ID = " & idAsigRep
        Cargar_Tabla(T5, SQL)
    End Sub

    Public Sub Cargar_DescTema()
        T.Tables.Clear()
        SQL = "SELECT Descripción FROM TEMAS WHERE ID = " & idTemaRep
        Cargar_Tabla(T, SQL)
        DescTemaRep = T.Tables(0).Rows(0).Item(0)
    End Sub

    Public Sub Cargar_CatRep()
        T1.Tables.Clear()
        SQL = "SELECT ID, Nombre, Descripcion FROM Categoria WHERE ID_Tema = " & idTemaRep
        Cargar_Tabla(T1, SQL)
        TotalcatRep = T1.Tables(0).Rows.Count
        ReDim IdCatRep(TotalcatRep)
        ReDim NombreCatRep(TotalcatRep)
        ReDim DescCatRep(TotalcatRep)
        For i As Integer = 0 To T1.Tables(0).Rows.Count - 1
            IdCatRep(i) = CInt(T1.Tables(0).Rows(i).Item(0))
            NombreCatRep(i) = T1.Tables(0).Rows(i).Item(1)
            DescCatRep(i) = T1.Tables(0).Rows(i).Item(2)
        Next

    End Sub

    Public Sub cargar_PreguntasRep(IdCategoria As Integer)
        T2.Tables.Clear()
        SQL = "SELECT ID, Texto, Puntaje, DATEPART('n', Tiempo) As Minutos, DATEPART('s', Tiempo) As Segundos, Explicacion FROM Preguntas  WHERE ID_Categoria =" & IdCategoria
        Cargar_Tabla(T2, SQL)
        TotalPregRep = T2.Tables(0).Rows.Count - 1
        CantPregRep = T2.Tables(0).Rows.Count
        ContPregRep = 0
        ReDim IdPregRep(TotalPregRep)
        ReDim TXTPregRep(TotalPregRep)
        ReDim PtsPregRep(TotalPregRep)
        ReDim TiempoPregRep(TotalPregRep)
        ReDim ExplicacionRep(TotalPregRep)
        For i As Integer = 0 To T2.Tables(0).Rows.Count - 1
            IdPregRep(i) = T2.Tables(0).Rows(i).Item(0)
            TXTPregRep(i) = T2.Tables(0).Rows(i).Item(1)
            PtsPregRep(i) = T2.Tables(0).Rows(i).Item(2)
            Dim tiempo = New TimeSpan(0, T2.Tables(0).Rows(i).Item(3), T2.Tables(0).Rows(i).Item(4))
            TiempoPregRep(i) = tiempo.ToString()
            ExplicacionRep(i) = T2.Tables(0).Rows(i).Item(5)
        Next
    End Sub

    Public Sub cargar_RespuestaRep(ByVal IdPregunta As Integer, ByVal p1 As Word.Paragraph, ByVal p2 As Word.Paragraph, ByVal p3 As Word.Paragraph, ByVal p4 As Word.Paragraph, ByVal p5 As Word.Paragraph)
        respEquivocada = False
        T3.Tables.Clear()
        SQL = "SELECT ID, Texto FROM RESPUESTAS WHERE ID_Pregunta = " & IdPregunta
        Cargar_Tabla(T3, SQL)
        TotalRespRep = T3.Tables(0).Rows.Count()
        'Ciclo para recorrer todas las respuestas  encontradas en la pregnta indicada
        For i As Integer = 0 To TotalRespRep - 1
            'Si el tipo de envío no es 2 que es solo las prespuestas del estudiante
            If TipoEnvio = 1 Then
                'Si es la primera pregunta por la que se pasa
                If i = 0 Then
                    'Si lo almacenado en el id en la tabla T3 es = que lo que est guardado en el arreglo
                    'de las respuesa escogidas por el estudiante
                    If T3.Tables(0).Rows(i).Item(0) = IDRespEscogida(ContRespRep) Then
                        'Si la respuesta escogida es la misma que la respuesta correcta de esa pregunta
                        If IDRespEscogida(ContRespRep) = IDRespCorrecta(ContRespRep) Then
                            'Se coloca el texto en verde
                            INSERTAR_REGLON(False, p1, "A. " & T3.Tables(0).Rows(i).Item(1), False, False, 11, "J", "o")
                        Else
                            'Se coloca el texto en rojo
                            INSERTAR_REGLON(False, p1, "A. " & T3.Tables(0).Rows(i).Item(1), False, False, 11, "J", "x")
                            respEquivocada = True
                        End If
                        'Si no es la id que escogió el estudiante
                    Else
                        'Se coloca el texto en negro
                        INSERTAR_REGLON(False, p1, "A. " & T3.Tables(0).Rows(i).Item(1), False, False, 11, "J", "b")
                    End If
                    'Si es la segunda pregunta por la que se pasa
                ElseIf i = 1 Then
                    'Si lo almacenado en el id en la tabla T3 es = que lo que est guardado en el arreglo
                    'de las respuesa escogidas por el estudiante
                    If T3.Tables(0).Rows(i).Item(0) = IDRespEscogida(ContRespRep) Then
                        'Si la respuesta escogida es la misma que la respuesta correcta de esa pregunta
                        If IDRespEscogida(ContRespRep) = IDRespCorrecta(ContRespRep) Then
                            'Se coloca el texto en verde
                            INSERTAR_REGLON(False, p2, "B. " & T3.Tables(0).Rows(i).Item(1), False, False, 11, "J", "o")
                        Else
                            'Se coloca el texto en rojo
                            INSERTAR_REGLON(False, p2, "B. " & T3.Tables(0).Rows(i).Item(1), False, False, 11, "J", "x")
                            respEquivocada = True
                        End If
                        'Si no es la id que escogió el estudiante
                    Else
                        'Se coloca el texto en negro
                        INSERTAR_REGLON(False, p2, "B. " & T3.Tables(0).Rows(i).Item(1), False, False, 11, "J", "b")
                    End If
                ElseIf i = 2 Then
                    If T3.Tables(0).Rows(i).Item(0) = IDRespEscogida(ContRespRep) Then
                        If IDRespEscogida(ContRespRep) = IDRespCorrecta(ContRespRep) Then
                            INSERTAR_REGLON(False, p3, "C. " & T3.Tables(0).Rows(i).Item(1), False, False, 11, "J", "o")
                        Else
                            INSERTAR_REGLON(False, p3, "C. " & T3.Tables(0).Rows(i).Item(1), False, False, 11, "J", "x")
                            respEquivocada = True
                        End If
                    Else
                        INSERTAR_REGLON(False, p3, "C. " & T3.Tables(0).Rows(i).Item(1), False, False, 11, "J", "b")
                    End If

                Else
                    If T3.Tables(0).Rows(i).Item(0) = IDRespEscogida(ContRespRep) Then
                        If IDRespEscogida(ContRespRep) = IDRespCorrecta(ContRespRep) Then
                            INSERTAR_REGLON(False, p4, "D. " & T3.Tables(0).Rows(i).Item(1), False, False, 11, "J", "o")
                        Else
                            INSERTAR_REGLON(False, p4, "D. " & T3.Tables(0).Rows(i).Item(1), False, False, 11, "J", "x")
                            respEquivocada = True
                        End If
                    Else
                        INSERTAR_REGLON(False, p4, "D. " & T3.Tables(0).Rows(i).Item(1), False, False, 11, "J", "b")
                    End If
                End If
                'Si el tipo de envio es diferente de 1 entonces solo se envía la respuesta que seleccionó el estudiante
                'Sin la calificación
            Else
                If i = 0 Then
                    If T3.Tables(0).Rows(i).Item(0) = IDRespEscogida(ContRespRep) Then
                        INSERTAR_REGLON(False, p1, "Repuesta del estudiante: " & T3.Tables(0).Rows(i).Item(1), True, False, 11, "J", "b")
                        INSERTAR_LINEA_BLANCO(p1, 1)
                    End If
                ElseIf i = 1 Then
                    If T3.Tables(0).Rows(i).Item(0) = IDRespEscogida(ContRespRep) Then
                        INSERTAR_REGLON(False, p2, "Repuesta del estudiante: " & T3.Tables(0).Rows(i).Item(1), True, False, 11, "J", "b")
                        INSERTAR_LINEA_BLANCO(p2, 1)
                    End If
                ElseIf i = 2 Then
                    If T3.Tables(0).Rows(i).Item(0) = IDRespEscogida(ContRespRep) Then
                        INSERTAR_REGLON(False, p3, "Repuesta del estudiante: " & T3.Tables(0).Rows(i).Item(1), True, False, 11, "J", "b")
                        INSERTAR_LINEA_BLANCO(p3, 1)
                    End If
                ElseIf i = 3 Then
                    If T3.Tables(0).Rows(i).Item(0) = IDRespEscogida(ContRespRep) Then
                        INSERTAR_REGLON(False, p4, "Repuesta del estudiante: " & T3.Tables(0).Rows(i).Item(1), True, False, 11, "J", "b")
                        INSERTAR_LINEA_BLANCO(p4, 1)
                    End If
                End If
            End If
        Next
        ContRespRep += 1
        If respEquivocada Then
            INSERTAR_REGLON(False, p5, "Explicación: " & ExplicacionRep(ContPregRep), True, False, 11, "J", "b")
        End If
    End Sub

    Public Sub CargarRespCorrectasRep()
        T4.Tables.Clear()
        SQL = "SELECT r.ID  From Respuestas r, Preguntas p, Categoria c, Temas t  WHERE r.ID_Pregunta = p.iD" &
            " AND p.ID_Categoria = c.ID AND c.ID_Tema = t.ID AND correcta = 1 AND t.ID = " & idTemaRep
        Cargar_Tabla(T4, SQL)
        Dim cantRespRep As Integer = T4.Tables(0).Rows.Count - 1
        ReDim IDRespCorrecta(cantRespRep)
        For i As Integer = 0 To cantRespRep
            IDRespCorrecta(i) = T4.Tables(0).Rows(i).Item(0)
        Next
        T5.Tables.Clear()
        SQL = "SELECT rr.ID_Respuesta FROM Resultados r, Resultados_Respuestas rr, Temas t WHERE r.ID = RR.ID_Resultado" &
            " AND r.ID_Tema = t.ID AND r.id = " & idResultRep
        Cargar_Tabla(T5, SQL)
        cantRespRep = T5.Tables(0).Rows.Count - 1
        ReDim IDRespEscogida(cantRespRep)
        For i As Integer = 0 To cantRespRep
            IDRespEscogida(i) = T5.Tables(0).Rows(i).Item(0)
        Next
        ContRespRep = 0
    End Sub

    Public Sub CargarPregFacDif()
        'Se cargan las preguntas desde la más fácil hasta la que menos aciertos haya tenido
        T.Tables.Clear()
        'SQL para cargar la pregunta con más aciertos y el texto de esta
        SQL = "SELECT p.ID, COUNT(p.ID), p.Texto FROM Resultados r, Respuestas re, Resultados_Respuestas rr, Preguntas p," &
            " Estudiante e, Seccion s, Temas t, Categoria c WHERE r.ID = rr.ID_Resultado AND re.ID = rr.ID_Respuesta" &
            " AND re.ID_Pregunta = p.ID AND e.ID_Seccion = s.ID AND e.ID = r.ID_Estudiante  AND t.ID = c.ID_Tema" &
            " AND  p.ID_Categoria = c.ID AND re.correcta = 1 AND s.ID = " & idSeccionRep & " AND t.ID = " & idTemaRep & " GROUP BY p.ID, p.texto" &
            " ORDER BY COUNT(p.ID) DESC;"
        Cargar_Tabla(T, SQL)
        CantPregRep = T.Tables(0).Rows.Count() - 1
        ReDim idPregFacilRep(CantPregRep)
        ReDim TxtPregFacilRep(CantPregRep)
        ReDim CantAciertosrRep(CantPregRep)
        For i As Integer = 0 To CantPregRep
            idPregFacilRep(i) = T.Tables(0).Rows(i).Item(0)
            CantAciertosrRep(i) = T.Tables(0).Rows(i).Item(1)
            TxtPregFacilRep(i) = T.Tables(0).Rows(i).Item(2)
        Next
        T1.Tables.Clear()
        'SQL para cargar la pregunta con menos aciertos y el texto de esta
        SQL = "SELECT COUNT(p.ID), p.Texto FROM Resultados r, Respuestas re, Resultados_Respuestas rr, Preguntas p," &
            " Estudiante e, Seccion s, Temas t, Categoria c WHERE r.ID = rr.ID_Resultado AND re.ID = rr.ID_Respuesta" &
            " AND re.ID_Pregunta = p.ID AND e.ID_Seccion = s.ID AND e.ID = r.ID_Estudiante  AND t.ID = c.ID_Tema" &
            " AND  p.ID_Categoria = c.ID AND re.correcta = 1 AND s.ID = " & idSeccionRep & " AND t.ID = " & idTemaRep & " GROUP BY p.texto" &
            " ORDER BY COUNT(p.ID) ASC;"
        Cargar_Tabla(T1, SQL)
        CantPregRep = T1.Tables(0).Rows.Count() - 1
        ReDim TxtPregDificilRep(CantPregRep)
        ReDim CantAciertosrDificilRep(CantPregRep)
        For i As Integer = 0 To CantPregRep
            CantAciertosrDificilRep(i) = T1.Tables(0).Rows(i).Item(0)
            TxtPregDificilRep(i) = T1.Tables(0).Rows(i).Item(1)
        Next
    End Sub


    Public Sub cargarCaliRep()
        T2.Tables.Clear()
        T3.Tables.Clear()
        'SQL para cargar maxima nota y el nombre del estudiante con esta
        SQL = "SELECT r.Pts_Obtenida, r.Pts_Totales, e.Nombre, e.Apellido_1, E.Apellido_2" &
            " FROM Resultados r, Estudiante e, seccion s, Temas t WHERE r.ID_Estudiante = e.ID AND s.ID = e.ID_Seccion" &
            " AND t.ID = r.ID_Tema AND T.ID = " & idTemaRep & " AND S.ID = " & idSeccionRep &
            " ORDER BY r.Pts_Obtenida DESC"
        Cargar_Tabla(T2, SQL)
        cantEstmejorObtenido = T2.Tables(0).Rows.Count - 1
        Dim nota As Double
        Dim ptso As Integer
        Dim ptst As Integer
        Dim sumNota As Double
        ReDim notaMejorEstRep(cantEstmejorObtenido)
        ReDim NomMejorEstRep(cantEstmejorObtenido)
        For i As Integer = 0 To cantEstmejorObtenido
            ptso = T2.Tables(0).Rows(i).Item(0)
            ptst = T2.Tables(0).Rows(i).Item(1)
            nota = (ptso * 100) / ptst
            sumNota = sumNota + nota
            notaMejorEstRep(i) = nota
            NomMejorEstRep(i) = T2.Tables(0).Rows(i).Item(2) & " " & T2.Tables(0).Rows(i).Item(3) & " " & T2.Tables(0).Rows(i).Item(4)
        Next
        PromedioNota = sumNota / (cantEstmejorObtenido + 1)

        'SQL para seleccionar la nota minima y el nombre del estudiante que la tiene
        SQL = "SELECT r.Pts_Obtenida, r.Pts_Totales, e.Nombre, e.Apellido_1, E.Apellido_2" &
            " FROM Resultados r, Estudiante e, seccion s, Temas t WHERE r.ID_Estudiante = e.ID AND s.ID = e.ID_Seccion" &
            " AND t.ID = r.ID_Tema AND T.ID = " & idTemaRep & " AND S.ID = " & idSeccionRep &
            " ORDER BY r.Pts_Obtenida ASC"
        Cargar_Tabla(T3, SQL)
        cantEstPeorObtenido = T3.Tables(0).Rows.Count - 1
        ReDim notaPeorEstRep(cantEstmejorObtenido)
        ReDim NomPeorEstRep(cantEstmejorObtenido)
        For i As Integer = 0 To cantEstPeorObtenido
            ptso = T3.Tables(0).Rows(i).Item(0)
            ptst = T3.Tables(0).Rows(i).Item(1)
            nota = (ptso * 100) / ptst
            notaPeorEstRep(i) = nota
            NomPeorEstRep(i) = T3.Tables(0).Rows(i).Item(2) & " " & T3.Tables(0).Rows(i).Item(3) & " " & T3.Tables(0).Rows(i).Item(4)
        Next

    End Sub

    Friend Sub inicializarExcel()
        Dim excelApp As New Excel.Application
        OEXCEL = excelApp
        wb = OEXCEL.Workbooks.Add() ' Crea un nuevo libro sin guardar
        S1 = CType(wb.Worksheets.Add(), Excel.Worksheet)
        S1.Name = "Reporte"
        ReDim MATRIZ(100, 100), MATRIZ2(100, 100)
    End Sub

    Friend Sub INSERTAR_COLUMNA(ByVal ARRAY As String(), ByVal SHEET As Worksheet, ByVal FILA As Byte, ByVal CANTCOLUMNAS As Byte, ByVal TAMANO As Byte, ByVal ALINEACIONX As Char, ByVal ALINEACIONY As Char, ByVal NEGRITA As Boolean, ByVal CURSIVA As Boolean, ByVal SUBRAYADO As Boolean, ByVal INDICE_FILA_NEGRITA As Byte, ByVal REQUIERE_FILA_NEGRITA As Boolean, ByVal INDICE_FILA_CURSIVA As Byte, ByVal REQUIERE_FILA_CURSIVA As Boolean, ByVal INDICE_FILA_CENTRAR As Byte, ByVal REQUIERE_FILA_CENTRAR As Boolean, ByVal INDICE_FILA_SUBRAYAR As Byte, ByVal REQUIERE_FILA_SUBRAYAR As Boolean, ByVal RespIncorercta As Char)
        Dim ultimaColumna As Integer = SHEET.Cells(SHEET.Rows.Count, FILA).End(XlDirection.xlUp).Row
        For i As Integer = 0 To CANTCOLUMNAS - 1
            SHEET.Cells(FILA, ultimaColumna).Value = CStr(ARRAY(i))
            Dim CELL = SHEET.Cells(FILA, ultimaColumna)

            Select Case ALINEACIONX
                Case "I" 'IZQUIERDA
                    CELL.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

                Case "D" 'DERECHA
                    CELL.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

                Case "C" 'CENTRADO
                    CELL.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            End Select

            Select Case ALINEACIONY
                Case "T" 'ARRIBA
                    CELL.VerticalAlignment = Excel.XlVAlign.xlVAlignTop

                Case "C" 'CENTRO
                    CELL.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                Case "B" ' ABAJO
                    CELL.VerticalAlignment = Excel.XlVAlign.xlVAlignBottom

            End Select

            CELL.Font.Name = FUENTE
            CELL.Font.Size = TAMANO

            If NEGRITA = True Then
                CELL.Font.Bold = True
            Else
                CELL.Font.Bold = False
            End If

            If CURSIVA = True Then
                CELL.Font.Italic = True
            Else
                CELL.Font.Italic = False
            End If

            If SUBRAYADO = True Then
                CELL.Font.Underline = True
            Else
                CELL.Font.Underline = False
            End If

            If REQUIERE_FILA_CENTRAR Then
                If i + 1 = INDICE_FILA_CENTRAR Then
                    CELL.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    CELL.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                End If
            End If

            If REQUIERE_FILA_CURSIVA Then
                If i + 1 = INDICE_FILA_CURSIVA Then
                    CELL.Font.Italic = True
                End If
            End If

            If REQUIERE_FILA_NEGRITA Then
                If i + 1 = INDICE_FILA_NEGRITA Then
                    CELL.Font.Bold = True
                End If
            End If

            If REQUIERE_FILA_SUBRAYAR Then
                If i + 1 = INDICE_FILA_SUBRAYAR Then
                    CELL.Font.Underline = True
                End If
            End If
            If RespIncorercta = "x" Then
                CELL.font.Color = RGB(255, 0, 0) ' Rojo
            ElseIf RespIncorercta = "o" Then
                CELL.font.Color = RGB(0, 255, 0) ' Verde
            Else
                CELL.font.Color = RGB(0, 0, 0) ' negro
            End If
            ultimaColumna += 1
        Next
    End Sub

    Friend Sub INSERTAR_CELDAS_TABLA(ByVal VECTOR(,) As String, ByVal SHEET As Worksheet, ByVal NSHEET As String, ByVal FILAS As Byte, ByVal COLUMNAS As Byte, ByVal TAMANO As Byte, ByVal ALINEACIONX As Char, ByVal ALINEACIONY As Char, ByVal NEGRITA As Boolean, ByVal CURSIVA As Boolean, ByVal SUBRAYADO As Boolean)
        For i As Integer = 0 To COLUMNAS - 1
            ' Obtén la última fila utilizada en la fila actual (por ejemplo, columna A)
            Dim ultimaFila As Integer = SHEET.Cells(SHEET.Rows.Count, i).End(XlDirection.xlUp).Row
            For j As Integer = 0 To FILAS - 1
                SHEET.Cells(i, ultimaFila + 1).Value = VECTOR(i, j)
                Dim CELL = wb.Sheets(NSHEET).CELLS(i, ultimaFila + 1)

                Select Case ALINEACIONX
                    Case "I" 'IZQUIERDA
                        CELL.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

                    Case "D" 'DERECHA
                        CELL.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

                    Case "C" 'CENTRADO
                        CELL.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                End Select

                Select Case ALINEACIONY
                    Case "T" 'ARRIBA
                        CELL.VerticalAlignment = Excel.XlVAlign.xlVAlignTop

                    Case "C" 'CENTRO
                        CELL.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    Case "B" ' ABAJO
                        CELL.VerticalAlignment = Excel.XlVAlign.xlVAlignBottom

                End Select

                CELL.Font.Name = FUENTE
                CELL.Font.Size = TAMANO

                If NEGRITA = True Then
                    CELL.Font.Bold = True
                Else
                    CELL.Font.Bold = False
                End If

                If CURSIVA = True Then
                    CELL.Font.Italic = True
                Else
                    CELL.Font.Italic = False
                End If
                If CURSIVA = True Then
                    CELL.Font.Italic = True
                Else
                    CELL.Font.Italic = False
                End If
                ultimaFila += 1
            Next
        Next

    End Sub

    Friend Sub INSERTAR_FILA_BLANCO(ByVal NCOLUMNA As Integer, ByVal NSHEET As Worksheet)
        NSHEET.Rows(NCOLUMNA).Insert()
    End Sub

    Friend Sub GUARDAR_DOCUMENTO_XLXS(ByVal NOMBRE_DOCUMENTO As String, ByVal VER_REPORTE As Boolean)
        Dim DIRECCION As String = DIRECTORIO & "\" & NOMBRE_DOCUMENTO
        wb.SaveAs(DIRECCION & ".xlsx")
        REPORTE_DIRECCION_EXCEL = DIRECCION & ".xlsx"
        If VER_REPORTE Then
            wb = OEXCEL.Workbooks.Open(REPORTE_DIRECCION_EXCEL)
            ' Muestra la aplicación de Excel
            OEXCEL.Visible = True
        End If
    End Sub

    Friend Sub CERRAR_DOC_EXCEL()
        OEXCEL.Workbooks.Close()
        OEXCEL.Quit()
        OEXCEL = Nothing
        wb = Nothing
    End Sub


    Public Sub cargar_RespuestaRepExcel(ByVal IdPregunta As Integer, ByVal SHEET As Excel.Worksheet, ByVal Array() As String)
        respEquivocada = False
        T3.Tables.Clear()
        SQL = "SELECT ID, Texto FROM RESPUESTAS WHERE ID_Pregunta = " & IdPregunta
        Cargar_Tabla(T3, SQL)
        TotalRespRep = T3.Tables(0).Rows.Count()
        Dim numResp As String = ""
        'Ciclo para recorrer todas las respuestas  encontradas en la pregnta indicada
        For i As Integer = 0 To TotalRespRep - 1
            Select Case i
                Case 0
                    numResp = "A. "
                Case 1
                    numResp = "B. "
                Case 2
                    numResp = "C. "
                Case 3
                    numResp = "D. "
            End Select
            Array(0) = ""
            Array(1) = numResp & T3.Tables(0).Rows(i).Item(1)
            Array(2) = ""
            If T3.Tables(0).Rows(i).Item(0) = IDRespEscogida(ContRespRep) Then

                If IDRespEscogida(ContRespRep) = IDRespCorrecta(ContRespRep) Then
                    INSERTAR_COLUMNA(Array, SHEET, columnaInsertada, 3, 11, "I", "C", False, False, False, 0, False, 0, False, 0, False, 0, False, "o")
                Else
                    INSERTAR_COLUMNA(Array, SHEET, columnaInsertada, 3, 11, "I", "C", False, False, False, 0, False, 0, False, 0, False, 0, False, "x")
                End If
            Else
                INSERTAR_COLUMNA(Array, SHEET, columnaInsertada, 3, 11, "I", "C", False, False, False, 0, False, 0, False, 0, False, 0, False, "b")
            End If
            columnaInsertada += 1
            Erase Array
            ReDim Array(15)
        Next
        ContRespRep += 1
        INSERTAR_FILA_BLANCO(columnaInsertada, SHEET)
        columnaInsertada += 1
    End Sub

    Friend Sub GuardarSheetExcel()
        CREAR_DIRECTORIO("Reportes_Juego\Individuales\Excel")
        NombreTemaRep = NombreTemaRep.Replace(" ", "")
        Dim FechaNSpace = Date.Now().ToString().Replace(" ", "").Replace("/", "").Replace(":", "")
        If MessageBox.Show("Desea abrir este informe?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            GUARDAR_DOCUMENTO_XLXS("Reporte" & "_" & NombreTemaRep & "_" & FechaNSpace, True)
        Else
            GUARDAR_DOCUMENTO_XLXS("Reporte" & "_" & NombreTemaRep & "_" & FechaNSpace, False)
            CERRAR_DOC_EXCEL()
        End If
    End Sub

    Friend Sub generarRepIndividualExcel()
        Try
            columnaInsertada = 1
            inicializarExcel()
            cargarNombreProf()
            Cargar_DescTema()
            ARRAY(0) = ""
            ARRAY(1) = "Informe de Desempeño Individual"
            INSERTAR_COLUMNA(ARRAY, S1, columnaInsertada, 2, 18, "I", "C", False, False, False, 0, False, 0, False, 0, False, 0, False, "b")

            columnaInsertada += 1
            INSERTAR_FILA_BLANCO(columnaInsertada, S1)

            columnaInsertada += 1
            Dim NombreProf = T5.Tables(0).Rows(0).Item(0) & " " & T5.Tables(0).Rows(0).Item(1) & " " & T5.Tables(0).Rows(0).Item(2)
            ARRAY1(0) = ""
            ARRAY1(1) = ""
            ARRAY1(2) = "Profesor: "
            ARRAY1(3) = NombreProf
            ARRAY1(4) = ""
            ARRAY1(5) = ""
            INSERTAR_COLUMNA(ARRAY1, S1, columnaInsertada, 6, 12, "I", "C", False, False, False, 0, False, 0, False, 0, False, 0, False, "b")

            columnaInsertada += 1
            INSERTAR_FILA_BLANCO(columnaInsertada, S1)

            columnaInsertada += 1
            ARRAY2(0) = ""
            ARRAY2(1) = "Estudiante: " & NombreEstRep
            ARRAY2(2) = ""
            ARRAY2(3) = ""
            ARRAY2(4) = ""
            ARRAY2(5) = "Sección: " & NombreSeccionRep
            ARRAY2(6) = ""
            ARRAY2(7) = "Asignatura: " & NombreAsigRep
            INSERTAR_COLUMNA(ARRAY2, S1, columnaInsertada, 8, 12, "I", "C", False, False, False, 0, False, 0, False, 0, False, 0, False, "b")

            columnaInsertada += 1
            INSERTAR_FILA_BLANCO(columnaInsertada, S1)
            columnaInsertada += 1
            ARRAY3(0) = ""
            ARRAY3(1) = "Pts Totales: " & PtsTotalRep
            ARRAY3(2) = ""
            ARRAY3(3) = "Pts Obtenidos: " & PtsObtenidoRep
            ARRAY3(4) = ""
            ARRAY3(5) = "Nota: " & NotaRep & "%"
            INSERTAR_COLUMNA(ARRAY3, S1, columnaInsertada, 6, 12, "I", "C", False, False, False, 0, False, 0, False, 0, False, 0, False, "b")

            columnaInsertada += 1
            INSERTAR_FILA_BLANCO(columnaInsertada, S1)

            ARRAY4(0) = ""
            ARRAY4(1) = "Tema: " & NombreTemaRep
            ARRAY4(2) = ""
            columnaInsertada += 1
            INSERTAR_COLUMNA(ARRAY4, S1, columnaInsertada, 3, 14, "I", "C", False, False, False, 0, False, 0, False, 0, False, 0, False, "b")

            ARRAY5(0) = ""
            ARRAY5(1) = "Descripción: " & DescTemaRep
            ARRAY5(2) = ""
            columnaInsertada += 1
            INSERTAR_COLUMNA(ARRAY5, S1, columnaInsertada, 3, 14, "I", "C", False, False, False, 0, False, 0, False, 0, False, 0, False, "b")

            columnaInsertada += 1
            INSERTAR_FILA_BLANCO(columnaInsertada, S1)

            'Se cargan las respuesta escogidas por el estudiante y las correctas del tema
            CargarRespCorrectasRep()
            'Se cargan las categorías
            Cargar_CatRep()
            For ContCatRep = 0 To TotalcatRep - 1
                columnaInsertada += 1
                ARRAY6(0) = ""
                ARRAY6(1) = ContCatRep + 1 & ". " & NombreCatRep(ContCatRep)
                ARRAY6(2) = ""
                INSERTAR_COLUMNA(ARRAY6, S1, columnaInsertada, 3, 16, "I", "C", False, False, False, 2, True, 0, False, 0, False, 0, False, "b")

                columnaInsertada += 1
                ARRAY7(0) = ""
                ARRAY7(1) = "Descripción: " & DescCatRep(ContCatRep)
                ARRAY7(2) = ""
                INSERTAR_COLUMNA(ARRAY7, S1, columnaInsertada, 3, 12, "I", "C", False, False, False, 2, True, 0, False, 0, False, 0, False, "b")

                columnaInsertada += 1
                INSERTAR_FILA_BLANCO(columnaInsertada, S1)

                columnaInsertada += 1
                ARRAY8(0) = ""
                ARRAY8(1) = "Preguntas: "
                ARRAY8(2) = ""
                INSERTAR_COLUMNA(ARRAY8, S1, columnaInsertada, 3, 12, "I", "C", False, False, False, 2, True, 0, False, 0, False, 0, False, "b")

                'Se cargan las preguntas 
                cargar_PreguntasRep(IdCatRep(ContCatRep))
                For ContPregRep = 0 To TotalPregRep
                    columnaInsertada += 1
                    ARRAY9(0) = ""
                    ARRAY9(1) = ContPregRep + 1 & ") " & TXTPregRep(ContPregRep)
                    ARRAY9(2) = ""
                    INSERTAR_COLUMNA(ARRAY9, S1, columnaInsertada, 3, 11, "I", "C", False, False, False, 0, False, 0, False, 0, False, 0, False, "b")

                    columnaInsertada += 1
                    ARRAY10(0) = ""
                    ARRAY10(1) = "Tiempo: " & TiempoPregRep(ContPregRep)
                    ARRAY10(2) = ""
                    ARRAY10(3) = ""
                    ARRAY10(4) = "Pts pregunta: " & PtsPregRep(ContPregRep)
                    INSERTAR_COLUMNA(ARRAY10, S1, columnaInsertada, 5, 11, "I", "C", False, False, False, 0, False, 0, False, 0, False, 0, False, "b")

                    columnaInsertada += 1
                    cargar_RespuestaRepExcel(IdPregRep(ContPregRep), S1, ARRAY9)
                Next
                INSERTAR_FILA_BLANCO(columnaInsertada, S1)
            Next
            Erase ARRAY(15), ARRAY1(15), ARRAY2(15), ARRAY3(15), ARRAY4(15), ARRAY5(15), ARRAY6(15), ARRAY7(15), ARRAY8(15), ARRAY9(15), ARRAY10(15)
            GuardarSheetExcel()
            P_PGenerandoInforme.Close()
        Catch ex As Exception
            GuardarSheetExcel()
            P_PGenerandoInforme.Close()
            MsgBox("Error al generar el reporte" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Friend Sub generarRepGeneralExcel()
        Try
            columnaInsertada = 1
            inicializarExcel()
            cargarNombreProf()
            Cargar_DescTema()
            CargarPregFacDif()
            cargarCaliRep()
            ARRAY(0) = ""
            ARRAY(1) = "Informe de Desempeño General"
            INSERTAR_COLUMNA(ARRAY, S1, columnaInsertada, 6, 18, "I", "C", False, False, False, 1, False, 0, False, 0, False, 0, False, "b")

            columnaInsertada += 1
            Dim NombreProf = T5.Tables(0).Rows(0).Item(0) & " " & T5.Tables(0).Rows(0).Item(1) & " " & T5.Tables(0).Rows(0).Item(2)
            ARRAY(0) = ""
            ARRAY(1) = ""
            ARRAY(2) = "Profesor: "
            ARRAY(3) = NombreProf
            ARRAY(4) = ""
            ARRAY(5) = ""
            INSERTAR_COLUMNA(ARRAY, S1, columnaInsertada, 6, 12, "I", "C", False, False, False, 2, True, 0, False, 0, False, 0, False, "b")

            columnaInsertada += 1
            INSERTAR_FILA_BLANCO(columnaInsertada, S1)

            columnaInsertada += 1
            ARRAY(0) = ""
            ARRAY(1) = "Promedio de notas: " & Math.Round(PromedioNota, 2) & "%"
            ARRAY(2) = ""
            ARRAY(3) = ""
            ARRAY(4) = "Sección: " & NombreSeccionRep
            ARRAY(5) = ""
            ARRAY(6) = "Asignatura: " & NombreAsigRep
            INSERTAR_COLUMNA(ARRAY, S1, columnaInsertada, 7, 12, "I", "C", False, False, False, 0, False, 0, False, 0, False, 0, False, "b")

            columnaInsertada += 1
            INSERTAR_FILA_BLANCO(columnaInsertada, S1)

            ARRAY4(0) = ""
            ARRAY4(1) = "Tema: " & NombreTemaRep
            ARRAY4(2) = ""
            columnaInsertada += 1
            INSERTAR_COLUMNA(ARRAY4, S1, columnaInsertada, 3, 14, "I", "C", False, False, False, 0, False, 0, False, 0, False, 0, False, "b")

            ARRAY5(0) = ""
            ARRAY5(1) = "Descripción: " & DescTemaRep
            ARRAY5(2) = ""
            columnaInsertada += 1
            INSERTAR_COLUMNA(ARRAY5, S1, columnaInsertada, 3, 11, "I", "C", False, False, False, 0, False, 0, False, 0, False, 0, False, "b")

            columnaInsertada += 1
            INSERTAR_FILA_BLANCO(columnaInsertada, S1)

            ARRAY6(0) = ""
            ARRAY6(1) = "Preguntas más sencillas: "
            ARRAY6(2) = ""
            columnaInsertada += 1
            INSERTAR_COLUMNA(ARRAY6, S1, columnaInsertada, 3, 12, "I", "C", True, False, False, 0, False, 0, False, 0, False, 0, False, "o")

            ARRAY7(0) = ""
            ARRAY7(1) = "Pregunta"
            ARRAY7(2) = ""
            ARRAY7(3) = ""
            ARRAY7(4) = ""
            ARRAY7(5) = "Aciertos"
            columnaInsertada += 1
            INSERTAR_COLUMNA(ARRAY7, S1, columnaInsertada, 6, 12, "I", "C", True, False, False, 0, False, 0, False, 0, False, 0, False, "b")
            Dim columnaInicioGrafico1 As Integer = columnaInsertada + 1
            Dim HastaColumnagrafico1 As Integer

            For i As Integer = 0 To CantPregRep
                ARRAY8(0) = i + 1 & ". "
                ARRAY8(1) = TxtPregFacilRep(i)
                ARRAY8(2) = ""
                ARRAY8(3) = ""
                ARRAY8(4) = ""
                ARRAY8(5) = CantAciertosrRep(i).ToString()
                columnaInsertada += 1
                HastaColumnagrafico1 = columnaInsertada
                INSERTAR_COLUMNA(ARRAY8, S1, columnaInsertada, 7, 11, "I", "C", False, False, False, 0, False, 0, False, 0, False, 0, False, "b")
            Next

            CrearGraficos(S1, columnaInicioGrafico1, 2, HastaColumnagrafico1, 6, "Pregunta", columnaInicioGrafico1, 2, HastaColumnagrafico1, 2, "Acierto", columnaInicioGrafico1, 6, HastaColumnagrafico1, 6, "Preguntas más sencillas", columnaInicioGrafico1, 8, True, "b")


            columnaInsertada += 1
            INSERTAR_FILA_BLANCO(columnaInsertada, S1)

            ARRAY6(0) = ""
            ARRAY6(1) = "Preguntas más complicadas: "
            ARRAY6(2) = ""
            columnaInsertada += 1
            INSERTAR_COLUMNA(ARRAY6, S1, columnaInsertada, 3, 12, "I", "C", True, False, False, 0, False, 0, False, 0, False, 0, False, "x")

            ARRAY7(0) = ""
            ARRAY7(1) = "Pregunta"
            ARRAY7(2) = ""
            ARRAY7(3) = ""
            ARRAY7(4) = ""
            ARRAY7(5) = "Aciertos"
            columnaInsertada += 1
            INSERTAR_COLUMNA(ARRAY7, S1, columnaInsertada, 6, 12, "I", "C", True, False, False, 0, False, 0, False, 0, False, 0, False, "b")


            For i As Integer = 0 To CantPregRep
                ARRAY8(0) = i + 1 & ". "
                ARRAY8(1) = TxtPregDificilRep(i)
                ARRAY8(2) = ""
                ARRAY8(3) = ""
                ARRAY8(4) = ""
                ARRAY8(5) = CantAciertosrDificilRep(i).ToString()

                columnaInsertada += 1

                INSERTAR_COLUMNA(ARRAY8, S1, columnaInsertada, 6, 11, "I", "C", False, False, False, 0, False, 0, False, 0, False, 0, False, "b")
            Next

            columnaInsertada += 1
            INSERTAR_FILA_BLANCO(columnaInsertada, S1)

            ARRAY6(0) = ""
            ARRAY6(1) = "Mejores notas: "
            ARRAY6(2) = ""
            columnaInsertada += 1
            INSERTAR_COLUMNA(ARRAY6, S1, columnaInsertada, 3, 12, "I", "C", True, False, False, 0, False, 0, False, 0, False, 0, False, "o")

            ARRAY7(0) = ""
            ARRAY7(1) = "Estudiante"
            ARRAY7(2) = ""
            ARRAY7(3) = ""
            ARRAY7(4) = ""
            ARRAY7(5) = "Nota"
            columnaInsertada += 1
            INSERTAR_COLUMNA(ARRAY7, S1, columnaInsertada, 6, 12, "I", "C", True, False, False, 0, False, 0, False, 0, False, 0, False, "b")
            Dim columnaInicioGrafico2 As Integer = columnaInsertada + 1
            Dim HastaColumnagrafico2 As Integer
            For i As Integer = 0 To cantEstmejorObtenido
                ARRAY8(0) = i + 1 & ". "
                ARRAY8(1) = NomMejorEstRep(i)
                ARRAY8(2) = ""
                ARRAY8(3) = ""
                ARRAY8(4) = ""
                ARRAY8(5) = Math.Round(notaMejorEstRep(i), 0).ToString()
                columnaInsertada += 1
                HastaColumnagrafico2 = columnaInsertada
                INSERTAR_COLUMNA(ARRAY8, S1, columnaInsertada, 6, 11, "I", "C", False, False, False, 0, False, 0, False, 0, False, 0, False, "b")
            Next

            CrearGraficos(S1, columnaInicioGrafico2, 2, HastaColumnagrafico2, 6, "Estudiante", columnaInicioGrafico2, 2, HastaColumnagrafico2, 2, "Nota", columnaInicioGrafico2, 6, HastaColumnagrafico2, 6, "Mejores notas", columnaInicioGrafico2, 8, True, "b")

            columnaInsertada += 1
            INSERTAR_FILA_BLANCO(columnaInsertada, S1)

            ARRAY6(0) = ""
            ARRAY6(1) = "Notas mas bajas: "
            ARRAY6(2) = ""
            columnaInsertada += 1
            INSERTAR_COLUMNA(ARRAY6, S1, columnaInsertada, 3, 12, "I", "C", True, False, False, 0, False, 0, False, 0, False, 0, False, "x")

            ARRAY7(0) = ""
            ARRAY7(1) = "Estudiante"
            ARRAY7(2) = ""
            ARRAY7(3) = ""
            ARRAY7(4) = ""
            ARRAY7(5) = "Nota"
            columnaInsertada += 1
            INSERTAR_COLUMNA(ARRAY7, S1, columnaInsertada, 6, 12, "I", "C", True, False, False, 0, False, 0, False, 0, False, 0, False, "b")


            For i As Integer = 0 To cantEstPeorObtenido
                ARRAY8(0) = i + 1 & ". "
                ARRAY8(1) = NomPeorEstRep(i)
                ARRAY8(2) = ""
                ARRAY8(3) = ""
                ARRAY8(4) = ""
                ARRAY8(5) = Math.Round(notaPeorEstRep(i), 0).ToString()

                columnaInsertada += 1
                INSERTAR_COLUMNA(ARRAY8, S1, columnaInsertada, 6, 11, "I", "C", False, False, False, 0, False, 0, False, 0, False, 0, False, "b")
            Next
            Erase ARRAY(15), ARRAY1(15), ARRAY2(15), ARRAY3(15), ARRAY4(15), ARRAY5(15), ARRAY6(15), ARRAY7(15), ARRAY8(15), ARRAY9(15), ARRAY10(15)
            GuardarSheetExcel()
            P_PGenerandoInforme.Close()
        Catch ex As Exception
            GuardarSheetExcel()
            P_PGenerandoInforme.Close()
            MsgBox("Error al generar el reporte" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub CrearGraficos(ByVal SHEET As Excel.Worksheet, ByVal desdeCeldaX As Integer, ByVal desdeCeldaY As Integer, ByVal hastaceldaX As Integer, ByVal hastaceldaY As Integer, ByVal NomSerie1 As String, ByVal desdeCeldaXColeccion1 As Integer, ByVal desdeCeldaYColeccion1 As Integer, ByVal hastaCeldaXColeccion1 As Integer, ByVal hastaCeldaYColeccion1 As Integer, ByVal NomSerie2 As String, ByVal desdeCeldaXColeccion2 As Integer, ByVal desdeCeldaYColeccion2 As Integer, ByVal hastaCeldaXColeccion2 As Integer, ByVal hastaCeldaYColeccion2 As Integer, ByVal tituloGrafico As String, ByVal Fila As Integer, ByVal columna As Integer, ByVal hastitle As Boolean, ByVal tipoGrafico As Char)
        ' Se crea el objeto del gráfico
        Dim chartObjects As Microsoft.Office.Interop.Excel.ChartObjects = SHEET.ChartObjects()
        Dim chartObject As Microsoft.Office.Interop.Excel.ChartObject = chartObjects.Add(100, 100, 300, 200)
        Dim chart As Microsoft.Office.Interop.Excel.Chart = chartObject.Chart

        ' Se define su posición
        chartObject.Left = SHEET.Cells(Fila, columna).Left
        chartObject.Top = SHEET.Cells(Fila, columna).Top

        ' Se crea la colección de celdas
        Dim seriesCollection As Microsoft.Office.Interop.Excel.SeriesCollection = chart.SeriesCollection
        ' Serie 1
        Dim Serie1 As Microsoft.Office.Interop.Excel.Series = seriesCollection.NewSeries()
        Dim rangoSerie1 As String = SHEET.Cells(desdeCeldaXColeccion1, desdeCeldaYColeccion1).Address & ":" & SHEET.Cells(hastaCeldaXColeccion1, hastaCeldaYColeccion1).Address
        Serie1.Values = SHEET.Range(rangoSerie1)
        Serie1.Name = NomSerie1

        ' Serie 2
        Dim Serie2 As Microsoft.Office.Interop.Excel.Series = seriesCollection.NewSeries()
        Dim rangoSerie2 As String = SHEET.Cells(desdeCeldaXColeccion2, desdeCeldaYColeccion2).Address & ":" & SHEET.Cells(hastaCeldaXColeccion2, hastaCeldaYColeccion2).Address
        Serie2.Values = SHEET.Range(rangoSerie2)
        Serie2.Name = NomSerie2


        ' Configura los datos del gráfico (rango de celdas con los valores)
        Dim Rango As String = SHEET.Cells(desdeCeldaX, desdeCeldaY).Address & ":" & SHEET.Cells(hastaceldaX, hastaceldaY).Address
        chart.SetSourceData(SHEET.Range(Rango))

        chart.HasTitle = True
        chart.ChartTitle.Text = tituloGrafico
        chart.HasLegend = False
        ' Establece el tipo de gráfico
        Select Case tipoGrafico
            Case "l"
                chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlLine
            Case "p"
                chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlPie
            Case "b"
                chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlBarClustered
            Case "a"
                chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlArea
            Case "s"
                chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlXYScatter
            Case "r"
                chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlRadar
        End Select

    End Sub





    'Friend Sub EnvioCorreo(ByVal direccionEnvio As String, ByVal claveCorreo As String, ByVal asunto As String, ByVal destinatario As String, ByVal contenido As String, ByVal rutaArchivo As String)
    '    If FormatoCorreoValido(direccionEnvio) Then
    '        Try
    '            correoEnvio.From = New System.Net.Mail.MailAddress(direccionEnvio)
    '            correoEnvio.Subject = asunto
    '            correoEnvio.To.Add(destinatario)
    '            correoEnvio.Body = contenido
    '            ' Adjuntar el archivo
    '            Dim archivoAdjunto As New Attachment(rutaArchivo)
    '            correoEnvio.Attachments.Add(archivoAdjunto)

    '            ' Configurar el servidor SMTP
    '            Dim servidor As New SmtpClient()
    '            Dim dominio As String = GetDominio(direccionEnvio)
    '            ' Cambia esto al servidor SMTP que estés utilizando
    '            If dominio = "@gmail.com" Then
    '                servidor.Host = “smtp.gmail.com”
    '            ElseIf dominio = "outlook.com" OrElse dominio = "hotmail.com" OrElse dominio = "live.com" Then
    '                servidor.Host = “smtp-mail.outlook.com”
    '                servidor.Port = 465
    '            End If
    '            servidor.EnableSsl = True
    '            servidor.Credentials = New System.Net.NetworkCredential(direccionEnvio, claveCorreo)

    '            ' Enviar el correo
    '            servidor.Send(correoEnvio)

    '            ' Mostrar un mensaje de confirmación al usuario
    '            MessageBox.Show("Correo enviado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Catch ex As Exception
    '            MsgBox("Error de envío del correo: " & vbCrLf & ex.ToString(), vbOKOnly + vbExclamation, "Error de formato")
    '        End Try

    '    Else
    '        MsgBox("El formato del correo incorrecto o no existe", vbOKOnly + vbExclamation, "Error de formato")
    '    End If
    'End Sub

    'Function GetDominio(ByVal email As String) As String
    '    Dim atIndex As Integer = email.IndexOf("@")
    '    If atIndex >= 0 AndAlso atIndex < email.Length - 1 Then
    '        Return email.Substring(atIndex + 1)
    '    Else
    '        Return ""
    '    End If
    'End Function

    'Function FormatoCorreoValido(ByVal correo As String) As Boolean
    '    Try
    '        Dim a As New System.Net.Mail.MailAddress(correo)
    '    Catch
    '        Return False
    '    End Try
    '    Return True
    'End Function


End Module
