Public Class borrar
    Dim ad As New DataAccess
    Private Sub borrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub borrar()
        Dim query As String
        Dim ds As DataSet


        query = "DELETE FROM CUENTAS"
        ds = ad.query(query)
    End Sub
End Class