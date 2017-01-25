Public Class Transferencias
    Dim ad As New DataAccess

    Private Sub Transferencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcc()
        cargarempresas()

    End Sub

    Private Sub cargarcc()
        Dim query As String
        Dim ds As DataSet
        Dim cif As String
        cif = "A11111111"

        query = "SELECT CC FROM cuentas where CIF_emp='" & cif & "'"
        ds = ad.query(query)

        cbcuantaorigen.DataSource = ds.Tables(0)
        cbcuantaorigen.DisplayMember = "CC"
        cbcuantaorigen.SelectedIndex = -1
    End Sub
    Private Sub cargarempresas()
        Dim query As String
        Dim ds As DataSet
        query = "Select nombre FROM empresas"
        ds = ad.query(query)
        cbempresadestino.DataSource = ds.Tables(0)
        cbempresadestino.DisplayMember = "nombre"
        cbempresadestino.SelectedIndex = -1
    End Sub

    Private Sub cargarccd()
        Dim query As String
        Dim ds As DataSet
        query = "Select CC FROM cuentas where CIF_emp In (Select CIF FROM empresas WHERE nombre= '" & cbempresadestino.Text & "')"
        ds = ad.query(query)
        cbcuentadestino.DataSource = ds.Tables(0)
        cbcuentadestino.DisplayMember = "CC"
    End Sub

    Private Sub cbempresadestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbempresadestino.SelectedIndexChanged
        cargarccd()
    End Sub

    Private Sub transfe()
        Dim query, querySaldoOrigen, querySaldoDestino, updateorigen, updatedestino, referencia, querycc_op1 As String
        Dim ds As New DataSet
        Dim tmo As Integer = cbcuantaorigen.Text.Length
        Dim tmd As Integer = cbcuentadestino.Text.Length
        Dim cantidad As Integer = tbcantidad.Text
        Dim cantidad2 As Integer
        referencia = Date.Today.ToString.Substring(0, 2) & Date.Today.ToString.Substring(3, 2) & Date.Today.ToString.Substring(8, 2) & cbcuantaorigen.Text.Substring((tmo - 3), 3) & cbcuentadestino.Text.Substring((tmd - 3), 3)

        querySaldoOrigen = "SELECT saldo FROM cuentas where CC= '" & cbcuantaorigen.Text & "' "
        ds = ad.query(querySaldoOrigen)
        Dim saldoorigen As Integer = ds.Tables(0).Rows(0).Item(0).ToString()

        querySaldoDestino = "SELECT saldo FROM cuentas where CC= '" & cbcuentadestino.Text & "' "
        ds = ad.query(querySaldoDestino)
        Dim saldodestino As Integer = ds.Tables(0).Rows(0).Item(0).ToString()


        cantidad = saldoorigen - cantidad
        MsgBox(cantidad)
        updateorigen = "UPDATE cuentas SET saldo=" & cantidad & " where CC='" & cbcuantaorigen.Text & "' "
        ds = ad.query(updateorigen)


        cantidad2 = saldodestino + cantidad
        MsgBox(cantidad2)
        updatedestino = "UPDATE cuentas SET saldo=" & cantidad2 & " where CC='" & cbcuentadestino.Text & "' "
        ds = ad.query(updatedestino)


        query = "INSERT INTO operaciones(`tipo`, `referencias`, `remitente`, `fecha`, `fecha_valor`, `concepto`, `concepto_ext`, `cantidad`, `saldo`, `periodica`) VALUES ('ABONO','" & referencia & "','" & tbremitente.Text & "','" & Date.Today.ToString.Substring(0, 10) & "','" & Date.Today.ToString.Substring(0, 10) & "','" & tbconcepto.Text & "','" & tbconceptoextendido.Text & "', " & CInt(tbcantidad.Text) & "," & cantidad & ",'no')"
        ds = ad.query(query)

        querycc_op1 = "INSERT INTO cc_op (LAST_INSERT_ID(),'" & cbcuantaorigen.Text & "','ABONO'," & cantidad & ")"
        ds = ad.query(querycc_op1)

    End Sub

    Private Sub btn__Click(sender As Object, e As EventArgs) Handles btn_.Click
        transfe()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim res As Integer

        res = MessageBox.Show("¿Está seguro que desea salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = 6 Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Gestion.Show()
        Me.Close()
    End Sub
End Class