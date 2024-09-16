Public Class P_ECuenta
    Dim NombreEst As String
    Dim Ape1Est As String
    Dim Ape2Est As String
    Dim idSeccion As Integer
    Dim idPeriodo As Integer

    '----------------------------Metodo cargar-----------------------------------------
    Private Sub P_ECuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_datos_Est()
    End Sub

    Public Sub cargar_datos_Est()
        Try
            TXT_CCarnetEst.Clear()
            TXT_CClaveEst.Clear()
            TXT_CCorreoEst.Clear()
            TXT_CFechaNacimientoEst.Clear()
            TXT_CNombreEst.Clear()
            TXT_CPeriodoEst.Clear()
            TXT_CSeccionEst.Clear()
            TXT_CUsuarioEst.Clear()
            T.Tables.Clear()
            SQL = "SELECT E.Apellido_1, E.Apellido_2, E.Nombre, E.Carnet_Estudiante, E.Usuario, E.Clave, E.Correo, E.Imagen, E.Fecha_Nacimiento, " &
                "S.Nombre, E.ID_Seccion, E.ID_Periodo, P.Nombre FROM Estudiante E, Seccion S, Periodo P WHERE E.ID_Seccion = S.ID AND " &
                "E.ID_Periodo = P.ID AND E.ID = " & ID_cuenta
            Cargar_Tabla(T, SQL)
            Ape1Est = T.Tables(0).Rows(0).Item(0)
            Ape2Est = T.Tables(0).Rows(0).Item(1)
            NombreEst = T.Tables(0).Rows(0).Item(2)
            TXT_CNombreEst.Text = NombreEst & " " & Ape1Est & " " & Ape2Est
            TXT_CCarnetEst.Text = T.Tables(0).Rows(0).Item(3)
            TXT_CUsuarioEst.Text = T.Tables(0).Rows(0).Item(4)
            TXT_CClaveEst.Text = T.Tables(0).Rows(0).Item(5)
            TXT_CCorreoEst.Text = T.Tables(0).Rows(0).Item(6)
            PIC_FotoEst.ImageLocation = T.Tables(0).Rows(0).Item(7)
            TXT_CFechaNacimientoEst.Text = T.Tables(0).Rows(0).Item(8)
            TXT_CSeccionEst.Text = T.Tables(0).Rows(0).Item(9)
            idSeccion = T.Tables(0).Rows(0).Item(10)
            idPeriodo = T.Tables(0).Rows(0).Item(11)
            TXT_CPeriodoEst.Text = T.Tables(0).Rows(0).Item(12)
        Catch ex As Exception
            MsgBox("Error al cargar los datos de la cuenta" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    '---------------------------------Funciones de los botones---------------------------------------------
    Private Sub CerrarAPP_Click(sender As Object, e As EventArgs) Handles CerrarAPP.Click
        Dim resultado = MsgBox("¿Desea cerrar la aplicación?", vbOKCancel + vbQuestion, "Confirmar")

        If resultado = MsgBoxResult.Ok Then
            ' Cerramos la aplicación
            Application.Exit()
        End If
    End Sub

    Private Sub BTN_RegresarProfNuevo_Click(sender As Object, e As EventArgs) Handles BTN_RegresarProfNuevo.Click
        Me.Close()
    End Sub

    Private Sub BTN_ActCEst_Click(sender As Object, e As EventArgs) Handles BTN_ActCEst.Click
        Try
            E_EActCuenta.IdEst = ID_cuenta
            E_EActCuenta.TXT_ActUsuarioEst.Text = TXT_CUsuarioEst.Text
            E_EActCuenta.TXT_ActClaveEst.Text = TXT_CClaveEst.Text
            E_EActCuenta.Show()
        Catch ex As Exception
            MsgBox("Error al cargar los datos de la cuenta" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub P_ECuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_ActCEst.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class