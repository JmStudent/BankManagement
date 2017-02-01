Public Class liberarC
    Dim ad As New DataAccess

    Private Sub liberarC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carcarBancos()
    End Sub

    Private Sub carcarBancos()
        Dim query As String
        Dim ds As DataSet


        query = "SELECT nombre FROM bancos "
        ds = ad.query(query)

        cbbancos.DataSource = ds.Tables(0)
        cbbancos.DisplayMember = "nombre"
        cbbancos.SelectedIndex = -1

    End Sub

    Private Sub liberar()
        Dim query As String
        Dim ds As DataSet
        Dim usado = 0
        Dim x = Nothing
        If (tbsaldo.Text <> "" And cbbancos.Text <> "") Then
            query = "UPDATE cuentas SET saldo=" & tbsaldo.Text & ", CIF_emp='" & x & "', usado=" & usado & " where Banco='" & cbbancos.Text & "' "
            ds = ad.query(query)

            query = "DELETE FROM operaciones WHERE codigo IN(Select cod_op FROM cc_op WHERE cc IN(SELECT CC FROM cuentas where Banco='" & cbbancos.Text & "'))"
            ds = ad.query(query)

            query = "DELETE FROM cc_op where cc in (SELECT CC FROM cuentas where Banco='" & cbbancos.Text & "')"
            ds = ad.query(query)



            MessageBox.Show("Cuentas liberadas con éxito", "Liberar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Rellene todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub tbsaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbsaldo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 45 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btenviar_Click(sender As Object, e As EventArgs) Handles btenviar.Click
        liberar()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        GCuentas.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim res As Integer

        res = MessageBox.Show("¿Está seguro que desea salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = 6 Then
            Application.Exit()
        End If
    End Sub
End Class