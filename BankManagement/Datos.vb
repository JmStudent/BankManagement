Imports mysql.Data.MySqlClient
Public Class Datos

    Public Function conectar()
        Dim txtconexion As String = "server=127.0.0.1;" & "database=bancaonline;uid=root;pwd=;"
        Dim conexion As New MySqlConnection(txtconexion)
        Try
            conexion.Open()
            If conexion.State = ConnectionState.Open Then
                MsgBox("Conexión abierta")
            End If
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos")
        End Try
        Return conexion
    End Function
    Public Sub desconectar(conex As MySqlConnection)
        Try
            If conex.State = ConnectionState.Open Then
                conex.Close()
                MsgBox("Conexión cerrada con éxito")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Function CUD(cons As String)
        Dim num As Integer
        Dim conex As New MySqlConnection
        conex = conectar()
        Dim comm As New MySqlCommand(cons, conex)
        Try
            num = comm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al ejecutar la consulta")
        End Try
        desconectar(conex)
        Return num
    End Function
    Public Function consultar(cons As String)
        Dim ds As New DataSet
        Dim conex As New MySqlConnection
        conex = conectar()
        Dim adap As New MySqlDataAdapter(cons, conex)
        Try
            adap.Fill(ds, "tabla")
        Catch ex As Exception
            MsgBox("error al ejectuar la consulta")
        End Try
        desconectar(conex)
        Return ds
    End Function
    Public Sub eliminarperfil(cons As String)
        Dim ds As New DataSet
        Dim conex As New MySqlConnection
        conex = conectar()
        Dim adap As New MySqlDataAdapter(cons, conex)
        desconectar(conex)
    End Sub
End Class

