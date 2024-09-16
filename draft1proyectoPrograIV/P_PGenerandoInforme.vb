Public Class P_PGenerandoInforme

    Private Sub P_PGenerandoInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Public Async Sub Cargar()
        PGI_GenRep.Style = Guna.UI2.WinForms.Enums.ProgressIndicatorStyle.Windows
        PGI_GenRep.AnimationSpeed = 85
        PGI_GenRep.Start()
        Await Task.Run(Sub()

                           ProcesoReporte()


                       End Sub)
        If Task.CompletedTask.IsCompleted Then
            PGI_GenRep.Stop()

            Me.Close()
        End If
    End Sub
End Class