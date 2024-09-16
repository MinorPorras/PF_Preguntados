Imports WMPLib
Public Class P_EJuegoTema
    Public RutaImgEst As String
    Public IdTema As Integer

    Private Sub P_EJuegoTema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Tema()
    End Sub

    Private Sub WMP_Tema_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles WMP_Tema.PlayStateChange
        If e.newState = WMPLib.WMPPlayState.wmppsStopped Then
            ' El video ha terminado de reproducirse, se muestra la imagen estática
            WMP_Tema.Visible = False
            WMP_Tema.Enabled = False
            Dim ImagenEst As Image = Image.FromFile(RutaImgEst)
            BackgroundImage = ImagenEst
        End If
    End Sub

    ' Método que se ejecuta cuando el audio termina
    Private Sub AudioPlaybackCompleted(sender As Object, e As EventArgs)
        'Ya se acabó de reproducir el audio, por lo que se pasa a la pestaña de categorías
        paso_a_Cat()

    End Sub

    Public Sub paso_a_Cat()
        Cargar_Cat()
        Sig_categoria()
        Me.Close()
    End Sub

    Private Sub BTN_SaltarInfoTema_Click(sender As Object, e As EventArgs) Handles BTN_SaltarInfoTema.Click
        paso_a_Cat()
    End Sub

    Private Sub P_EJuegoTema_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_SaltarInfoTema.PerformClick()
        End If
    End Sub
End Class