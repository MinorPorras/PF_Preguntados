Public Class P_PCuenta
    Public NombreProf As String
    Public Ape1Prof As String
    Public Ape2Prof As String

    '----------------------------Metodo cargar-----------------------------------------
    Private Sub P_PCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_datos_Prof()
    End Sub

    Public Sub Cargar_datos_Prof()
        Try
            T.Tables.Clear()
            SQL = "SELECT * FROM Profesores WHERE ID = " & ID_cuenta
            Cargar_Tabla(T, SQL)
            NombreProf = T.Tables(0).Rows(0).Item(1)
            Ape1Prof = T.Tables(0).Rows(0).Item(2)
            Ape2Prof = T.Tables(0).Rows(0).Item(3)
            TXT_CNombreProf.Text = NombreProf & " " & Ape1Prof & " " & Ape2Prof
            TXT_CUsuarioProf.Text = T.Tables(0).Rows(0).Item(4)
            TXT_CClaveProf.Text = T.Tables(0).Rows(0).Item(5)
            PIC_FotoProf.ImageLocation = T.Tables(0).Rows(0).Item(7)
            TXT_CCorreoProf.Text = T.Tables(0).Rows(0).Item(6)
        Catch ex As Exception
            MsgBox("Error al cargar los datos de la cuenta: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    '---------------------------------Funciones de los botones---------------------------------------------
    Private Sub CerrarAPP_Click(sender As Object, e As EventArgs) Handles CerrarAPP.Click
        Dim resultado As MsgBoxResult
        resultado = MsgBox("¿Desea cerrar la aplicación?", vbOKCancel + vbQuestion, "Confirmar")

        If resultado = MsgBoxResult.Ok Then
            ' Cerramos la aplicación
            Application.Exit()
        End If
    End Sub

    Private Sub BTN_RegresarProfNuevo_Click(sender As Object, e As EventArgs) Handles BTN_RegresarProfNuevo.Click
        Me.Close()
    End Sub

    Private Sub BTN_GuardarProfNuevo_Click(sender As Object, e As EventArgs) Handles BTN_GuardarProfNuevo.Click
        Try
            E_PAActUsuarioProf.IdProf = CInt(ID_cuenta)
            E_PAActUsuarioProf.TXT_NombreModProf.Text = NombreProf
            E_PAActUsuarioProf.TXT_Ape1ModProf.Text = Ape1Prof
            E_PAActUsuarioProf.TXT_Ape2ModProf.Text = Ape2Prof
            E_PAActUsuarioProf.TXT_UsuarioProfMod.Text = TXT_CUsuarioProf.Text
            E_PAActUsuarioProf.TXT_ClaveProfMod.Text = TXT_CClaveProf.Text
            E_PAActUsuarioProf.TXT_RutaImagenMod.Text = PIC_FotoProf.ImageLocation
            E_PAActUsuarioProf.TXT_CorreoProfMod.Text = TXT_CCorreoProf.Text
            E_PAActUsuarioProf.Show()
        Catch ex As Exception
            MsgBox("Error al cargar los datos de la cuenta: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try

    End Sub

    Private Sub P_PCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_GuardarProfNuevo.PerformClick()
        ElseIf e.KeyChar = Chr(27) Then
            CerrarAPP.PerformClick()
        End If
    End Sub
End Class