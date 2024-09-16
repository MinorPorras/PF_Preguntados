Module CONEXION
    'Se crea el objeto de conexión
    Public Db As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=.\bd\Proyectofinal.accdb")
    'Se le envía la ruta del archivo .udl para que realicé la conexión
    Friend Sub CONECTAR()
        Try
            Db.Open()
            Exit Sub
        Catch ex As Exception
            MsgBox("Error al conectarse a la base de datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    'Se desconecta de la base de datos
    Friend Sub DESCONECTAR()
        Try
            Db.Close()
        Catch ex As Exception
            MsgBox("Error al desconectarse a la base de datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub
End Module
