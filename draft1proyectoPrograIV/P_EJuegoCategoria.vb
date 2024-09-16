Public Class P_EJuegoCategoria
    Public RutaImgEst As String
    Private Sub P_EJuegoCategoria_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    ' Método que se ejecuta cuando el audio termina
    Private Sub AudioPlaybackCompleted(sender As Object, e As EventArgs)
        ''Ya se acabó de reproducir el audio, por lo que se pasa a la pestaña de categorías
        P_EJuegoPregunta.RutaImagenEst = RutaImgEst
        cargar_Preguntas(IdCat(ContCat))
        P_EJuegoPregunta.Show()
        Me.Close()
    End Sub

    Private Sub WMP_Cat_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles WMP_Cat.PlayStateChange
        If e.newState = WMPLib.WMPPlayState.wmppsStopped Then
            ' El video ha terminado de reproducirse, se muestra la imagen estática
            WMP_Cat.Ctlcontrols.stop()
            WMP_Cat.Visible = False
            WMP_Cat.Enabled = False
            Dim ImagenEst As Image = Image.FromFile(RutaImgEst)
            BackgroundImage = ImagenEst
        End If
    End Sub

    Private Sub BTN_SaltarInfoCat_Click(sender As Object, e As EventArgs) Handles BTN_SaltarInfoCat.Click
        If WMP_Cat.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            WMP_Cat.Ctlcontrols.stop()
        End If
        P_EJuegoPregunta.RutaImagenEst = RutaImgEst
        P_EJuegoPregunta2.RutaImagenEst = RutaImgEst
        cargar_Preguntas(IdCat(ContCat))
        Sig_Preg()
        P_EJuegoPregunta.Show()
        Me.Close()
    End Sub


    Public Sub LIMPIAR()
        TXT_DescCat.Clear()
        TXT_TituloCat.Clear()
        RutaImgEst = ""
        WMP_Cat.Visible = True
        WMP_Cat.Enabled = True
        My.Computer.Audio.Stop()

    End Sub

    Private Sub P_EJuegoCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_SaltarInfoCat.PerformClick()
        End If
    End Sub
End Class