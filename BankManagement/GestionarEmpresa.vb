Public Class gestionEmpresa
    Dim ad As New DataAccess
    Private Sub borrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub borrar()
        Dim query As String
        Dim ds As DataSet


        query = "DELETE FROM CUENTAS"
        ds = ad.query(query)
    End Sub



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim res As Integer

        res = MessageBox.Show("¿Está seguro que deseas eliminar todas las empresas?", "Eliminar Empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = 6 Then
            borrar()
        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim res As Integer

        res = MessageBox.Show("¿Está seguro que deseas eliminar todas las empresas?", "Eliminar Empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = 6 Then
            borrar()
        End If
    End Sub
End Class