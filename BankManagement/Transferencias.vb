Public Class Transferencias
    Dim ad As New DataAccess

    Private Sub Transferencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcc()
        cargarempresas()

    End Sub

    Private Sub cargarcc()
        Dim query As String
        Dim ds As DataSet


        query = "SELECT CC FROM cuentas "
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
        Dim query, query2, querySaldoOrigen, querySaldoDestino, updateorigen, updatedestino, referencia1, referencia2, querycc_op1, querycc_op2 As String
        Dim ds As New DataSet

        Dim cantidadD, cantidadO As Integer

        If (cbcuantaorigen.Text <> "" And cbcuentadestino.Text <> "" And cbempresadestino.Text <> "" And tbcantidad.Text <> "" And tbconcepto.Text <> "" And tbconceptoextendido.Text <> "" And tbremitente.Text <> "") Then
            Dim tmo As Integer = cbcuantaorigen.Text.Length
            Dim tmd As Integer = cbcuentadestino.Text.Length
            Dim cantidad As Integer = tbcantidad.Text
            Dim letra1, letra2 As String
            Dim origen1 As String
            Dim destino1 As String
            If (CInt(tbcantidad.Text) > 0) Then
                'origen cargo destino abono'
                letra1 = "C"
                letra2 = "A"
                origen1 = "Cargo"
                destino1 = "Abono"

            Else
                letra1 = "A"
                letra2 = "C"
                origen1 = "Abono"
                destino1 = "Cargo"

            End If

            referencia1 = Date.Today.ToString.Substring(0, 2) & Date.Today.ToString.Substring(3, 2) & Date.Today.ToString.Substring(8, 2) & cbcuantaorigen.Text.Substring((tmo - 3), 3) & cbcuentadestino.Text.Substring((tmd - 3), 3) & letra1
            referencia2 = Date.Today.ToString.Substring(0, 2) & Date.Today.ToString.Substring(3, 2) & Date.Today.ToString.Substring(8, 2) & cbcuantaorigen.Text.Substring((tmo - 3), 3) & cbcuentadestino.Text.Substring((tmd - 3), 3) & letra2

            querySaldoOrigen = "SELECT saldo FROM cuentas where CC= '" & cbcuantaorigen.Text & "' "
            ds = ad.query(querySaldoOrigen)
            Dim saldoorigen As Integer = ds.Tables(0).Rows(0).Item(0).ToString()

            querySaldoDestino = "SELECT saldo FROM cuentas where CC= '" & cbcuentadestino.Text & "' "
            ds = ad.query(querySaldoDestino)
            Dim saldodestino As Integer = ds.Tables(0).Rows(0).Item(0).ToString()


            cantidadO = saldoorigen - cantidad
            MsgBox(cantidad)
            updateorigen = "UPDATE cuentas SET saldo=" & cantidadO & " where CC='" & cbcuantaorigen.Text & "' "
            ds = ad.query(updateorigen)


            cantidadD = saldodestino + cantidad
            MsgBox(cantidadD)
            updatedestino = "UPDATE cuentas SET saldo=" & cantidadD & " where CC='" & cbcuentadestino.Text & "' "
            ds = ad.query(updatedestino)


            query = "INSERT INTO operaciones(`tipo`, `referencias`, `remitente`, `fecha`, `fecha_valor`, `concepto`, `concepto_ext`, `cantidad`, `saldo`, `periodica`) VALUES ('" & origen1 & "','" & referencia1 & "','" & tbremitente.Text & "','" & Date.Today.ToString.Substring(0, 10) & "','" & Date.Today.ToString.Substring(0, 10) & "','" & tbconcepto.Text & "','" & tbconceptoextendido.Text & "', " & CInt(tbcantidad.Text) & "," & cantidadO & ",'no')"
            ds = ad.query(query)

            querycc_op1 = "INSERT INTO cc_op (SELECT LAST_INSERT_ID(),'" & cbcuantaorigen.Text & "','" & origen1 & "'," & cantidadO & ")"
            ds = ad.query(querycc_op1)

            query2 = "INSERT INTO operaciones(`tipo`, `referencias`, `remitente`, `fecha`, `fecha_valor`, `concepto`, `concepto_ext`, `cantidad`, `saldo`, `periodica`) VALUES
            ('" & destino1 & "','" & referencia2 & "','" & tbremitente.Text & "','" & Date.Today.ToString.Substring(0, 10) & "','" & Date.Today.ToString.Substring(0, 10) & "','" & tbconcepto.Text & "','" & tbconceptoextendido.Text & "', " & CInt(tbcantidad.Text) & "," & cantidadD & ",'no')"
            ds = ad.query(query2)

            querycc_op2 = "INSERT INTO cc_op (SELECT LAST_INSERT_ID(),'" & cbcuentadestino.Text & "','" & destino1 & "'," & cantidadD & ")"
            ds = ad.query(querycc_op2)



        Else
            MessageBox.Show("Rellene todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If




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

    Private Sub tbcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbcantidad.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 45 Then
            If Asc(e.KeyChar) < 45 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


End Class