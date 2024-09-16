Public Class P_EComenzarJuego
    Dim MinASeg As Integer
    Dim Segundos As Integer
    Dim TotalTiempo As Integer
    Dim IdTema As Integer
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

    Private Sub cargarCBXTema()
        Try
            CBX_Tema.Items.Clear()
            'Se limpia la tabla temporal y se envía el query a la base de datos, cargando la tabla temporal
            T1.Tables.Clear()
            SQL = "SELECT s.ID FROM Estudiante e, Seccion s WHERE s.ID = e.ID_Seccion"
            Cargar_Tabla(T1, SQL)
            Dim idSeccion As Integer = 0
            If T1.Tables(0).Rows.Count > 0 Then
                idSeccion = T1.Tables(0).Rows(0).Item(0)
            End If

            T.Tables.Clear()
            SQL = "SELECT t.ID, t.Nombre FROM Temas t, Seccion s, Asignatura a WHERE t.ID_Asignatura = a.ID AND s.ID = a.ID_Seccion AND s.ID = " & idSeccion
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
            MsgBox("Error al cargar la lista de temas" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub P_EComenzarJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCBXTema()
        Cargar_Datos_Tema()
        IdTema = CBX_Tema.SelectedValue
    End Sub

    Private Sub Cargar_Datos_Tema()
        Try
            BTN_ComenzarJuego.Enabled = True
            TotalTiempo = 0
            Cargar_TotalCat()
            Cargar_Total_Tiempo()
            Cargar_Puntaje()
            Cargar_TotalPreg()
        Catch ex As Exception
            TXT_CantCat.Text = 0
            TXT_PtsTotal.Text = 0
            TXT_TiempoTotal.Text = 0
            BTN_ComenzarJuego.Enabled = False
        End Try
    End Sub

    Private Sub Cargar_TotalCat()
        Try
            T.Tables.Clear()
            SQL = "SELECT COUNT(ID) FROM Categoria WHERE ID_Tema = " & CBX_Tema.SelectedValue
            Cargar_Tabla(T, SQL)
            Totalcat = T.Tables(0).Rows(0).Item(0)
            TXT_CantCat.Text = Totalcat
            If Totalcat = 0 Then
                BTN_ComenzarJuego.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Error al cargar el total de categorías" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try

    End Sub

    Private Sub Cargar_TotalPreg()
        Try
            T.Tables.Clear()
            SQL = "SELECT Count(p.ID) FROM Temas T, Categoria C, Preguntas p WHERE T.ID = C.ID_Tema AND C.ID = P.ID_Categoria AND T.ID = " & CBX_Tema.SelectedValue
            Cargar_Tabla(T, SQL)
            PregTotalJuego = T.Tables(0).Rows(0).Item(0)
            If PregTotalJuego <> 0 Then
                ReDim RespEscogida(PregTotalJuego - 1)
            Else
                ReDim RespEscogida(0)
                BTN_ComenzarJuego.Enabled = False

            End If
        Catch ex As Exception
            MsgBox("Error al cargar el total de preguntas" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub Cargar_Total_Tiempo()
        Try
            T.Tables.Clear()
            SQL = "SELECT SUM(DatePart('n', P.Tiempo)), SUM(DatePart('s', P.Tiempo)), T.ID, T.Nombre FROM Preguntas P, Categoria C, Temas T WHERE T.ID = C.ID_Tema AND C.ID = P.ID_Categoria GROUP BY T.ID, T.Nombre HAVING T.ID = " & CBX_Tema.SelectedValue
            Cargar_Tabla(T, SQL)

            Dim TotalTiempo As Integer = 0

            For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                Dim MinASeg As Integer = CInt(T.Tables(0).Rows(i).Item(0)) * 60
                Dim Segundos As Integer = CInt(T.Tables(0).Rows(i).Item(1))
                TotalTiempo += MinASeg + Segundos
            Next
            If TotalTiempo = 0 Then
                BTN_ComenzarJuego.Enabled = False
            End If

            TXT_TiempoTotal.Text = TotalTiempo & " Segundos"
        Catch ex As Exception
            MsgBox("Error al cargar el total del tiempo" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub Cargar_Puntaje()
        Try
            T.Tables.Clear()
            SQL = "SELECT T.ID, SUM(P.Puntaje) FROM Preguntas P, Categoria C, Temas T WHERE T.ID = C.ID_Tema AND C.ID = P.ID_Categoria GROUP BY T.ID HAVING T.ID = " & CBX_Tema.SelectedValue
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                TXT_PtsTotal.Text = T.Tables(0).Rows(0).Item(1)
            Else
                TXT_PtsTotal.Text = 0
                BTN_ComenzarJuego.Enabled = False

            End If
        Catch ex As Exception
            MsgBox("Error al cargar el puntaje total" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub CBX_Tema_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_Tema.SelectedIndexChanged
        Cargar_Datos_Tema()
        IdTema = CBX_Tema.SelectedValue
    End Sub

    Private Sub BTN_RegresarProfNuevo_Click(sender As Object, e As EventArgs) Handles BTN_RegresarProfNuevo.Click
        P_EPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub BTN_ActCEst_Click(sender As Object, e As EventArgs) Handles BTN_ComenzarJuego.Click
        Try
            T.Tables.Clear()
            SQL = "SELECT COUNT(ID) FROM Resultados WHERE ID_Tema = " & IdTema & " AND ID_Estudiante = " & ID_cuenta
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows(0).Item(0) = 0 Then
                PROCESO_JUEGO.IdTema = IdTema
                PROCESO_JUEGO.PtsTotalTema = CInt(TXT_PtsTotal.Text)
                P_EJuegoTema.Show()
                Me.Close()
            Else
                MsgBox("Ya has gastado todos tun intentos en este tema", vbOKOnly + vbExclamation, "¡Sin intentos!")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los intentos del tema" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub P_EComenzarJuego_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_ComenzarJuego.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class