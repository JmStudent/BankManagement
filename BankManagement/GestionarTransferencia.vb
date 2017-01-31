Public Class GestionarTransferencia
    Dim query As String
    Dim ad As New DataAccess
    Dim ds As DataSet
    Dim loaded As Boolean = False
    Dim loaded2 As Boolean = False
    Dim subsEOr As String
    Dim subsEDe As String
    Dim conceptSelOri As String
    Dim conceptSelDes As String
    Dim cifOrigen As String
    Dim cifDestino As String
    Private Sub GestionarMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbLogo.SetBounds(oneColumn() * 2.3, 0, 500, 63)
        ' CONSULTAS
        query = "SELECT * FROM empresas WHERE activa = 1"
        Try
            ' EMPRESA ORIGEN
            ds = ad.query(query)
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                cbEO.DataSource = ds.Tables(0)
                cbEO.DisplayMember = "nombre"
            Next
            loaded = True
            cbEO.ResetText()

            ' EMPRESA DESTINO
            ds = ad.query(query)
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                cbED.DataSource = ds.Tables(0)
                cbED.DisplayMember = "nombre"
            Next
            loaded2 = True
            cbED.ResetText()
        Catch ex As Exception
            MessageBox.Show("No se puede conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' PERIODICA
        For i = 0 To 30
            cbPer.Items.Add(i)
        Next

        'FECHA
        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.CustomFormat = "dd/MM/yyyy"
        dtpDate.MinDate = Date.Today

        ' CONCEPTO
        cbConcepto.Items.Add("Abono en cuenta")
        cbConcepto.Items.Add("Domicialización")
        cbConcepto.Items.Add("Ingreso en efectivo")
        cbConcepto.Items.Add("Pago con tarjeta")
        cbConcepto.Items.Add("Retirada de efectivo")
    End Sub
    ' RESPONSIVE
    Private Function oneColumn() As Integer
        Return (Me.Width / 9)
    End Function
    Private Function oneRow() As Integer
        Return (Me.Height / 9)
    End Function
    Private Function oneColumnPan() As Integer
        Return (panBody.Width / 9)
    End Function
    Private Function oneRowPan() As Integer
        Return (panBody.Height / 9)
    End Function
    ' BEHAVIOR
    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles pbBack.Click
        ' ver cual sería el botón atrás de esto.
    End Sub
    Private Sub pbClose_Click(sender As Object, e As EventArgs) Handles pbClose.Click
        Dim returned As Integer
        returned = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If returned = 6 Then
            Me.Close()
        End If
    End Sub

    Private Sub pbRefresh_Click(sender As Object, e As EventArgs) Handles pbRefresh.Click
        txtRem.Text = ""
        txtCant.Text = ""
        dtpDate.ResetText()
        chbDom.Checked = False
        txtConEx.Text = ""
        epCD.Clear()
        epCD1.Clear()
        epCO.Clear()
        epRem.Clear()
        epCantidad.Clear()
        epPer.Clear()
        epConcepto.Clear()
        epConExt.Clear()
    End Sub
    Private Sub cbEO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEO.SelectedIndexChanged
        If loaded Then
            Dim query2 As String = "SELECT CIF FROM empresas WHERE nombre = '" & cbEO.Text & "' AND activa = 1"
            ds = ad.query(query2)
            If ds.Tables(0).Rows.Count > 0 Then
                cifOrigen = ds.Tables(0).Rows.Item(0).Item(0)
                subsEOr = cifOrigen.Substring(cifOrigen.Length - 3)
            End If
            query = "SELECT * FROM cuentas WHERE CIF_emp = (" & query2 & ")"
            ds = ad.query(query)
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                cbCO.DataSource = ds.Tables(0)
                cbCO.DisplayMember = "CC"
            Next
        End If
    End Sub

    Private Sub cbED_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbED.SelectedIndexChanged
        If loaded2 Then
            Dim query2 As String = "SELECT CIF FROM empresas WHERE nombre = '" & cbED.Text & "' AND activa = 1"
            ds = ad.query(query2)
            If ds.Tables(0).Rows.Count > 0 Then
                cifDestino = ds.Tables(0).Rows.Item(0).Item(0)
                subsEDe = cifDestino.Substring(cifDestino.Length - 3)
            End If
            query = "SELECT * FROM cuentas WHERE CIF_emp = (" & query2 & ")"
            ds = ad.query(query)
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                cbCD.DataSource = ds.Tables(0)
                cbCD.DisplayMember = "CC"
            Next
        End If
    End Sub
    Private Function not_Error_Empty() As Boolean
        Dim passed As Boolean = True
        If cbCO.Text = "" Then
            passed = False
            epCO.SetError(cbCO, "El campo cuenta origen no puede quedar vacío")
        End If
        If cbCD.Text = "" Then
            passed = False
            epCD1.SetError(cbCD, "El campo cuenta destino no puede quedar vacío")
        End If
        If cbConcepto.Text = "" Then
            passed = False
            epConcepto.SetError(cbConcepto, "El campo Concepto no puede quedar vacío")
        End If
        If Not passed Then
            MessageBox.Show("No se ha podido realizar la transferencia", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If cbCO.Text = cbCD.Text Then
                passed = False
                MessageBox.Show("La transferencia no se ha realizado porque la cuenta de destino no puede ser la misma que la cuenta de origen", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                epCD.SetError(cbCD, "Cambie la cuenta de destino o de origen")
            End If
        End If
        Return passed
    End Function
    Private Sub pbMake_Click(sender As Object, e As EventArgs) Handles pbMake.Click
        Dim returned As Integer
        If not_Error() Then
            Dim hoy As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
            If chbDom.Checked Then
                returned = MessageBox.Show("¿Está seguro que desea realizar la transferencia MASIVA?", "Transferencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If returned = 6 Then
                    'cobrarle a todas las cuentas la cantidad, lo que quiere decir 2 insert y 1 update por cada cuenta.
                    Try
                        Dim saldo As Integer
                        query = "SELECT * FROM cuentas"
                        ds = ad.query(query)
                        If ds.Tables(0).Rows.Count > 0 Then
                            For i = 0 To ds.Tables(0).Rows.Count - 1
                                Dim account As String = ds.Tables(0).Rows.Item(i).Item(1) ' primer item: cada fila, segundo item: 0 el cif, 1 la cuenta, 2 el banco, 3 la oficina, 4 saldo, 5 usado
                                saldo = ds.Tables(0).Rows.Item(i).Item(4)
                                saldo = saldo + CInt(txtCant.Text)
                                Dim newQuery As String
                                newQuery = "UPDATE cuentas SET Saldo = " & saldo & " WHERE CC = '" & account & "'"
                                ad.cud(newQuery)
                                Dim reference As String = dtpDate.Text.Substring(0, 2) & dtpDate.Text.Substring(3, 2) & dtpDate.Text.Substring(8) & "111" & account.Substring(account.Length - 3) & "A"
                                newQuery = "INSERT INTO operaciones (tipo, referencias, remitente, fecha, fecha_valor, concepto, concepto_ext, cantidad, saldo, periodica) VALUES('A', '" & reference & "', '" & txtRem.Text & "', '" & hoy & "', '" & dtpDate.Text & "', '" & cbConcepto.Text & "', '" & txtConEx.Text & "', " & txtCant.Text & ", " & saldo & ", " & cbPer.Text & ")"
                                ad.cud(newQuery)
                                newQuery = "INSERT INTO cc_op (SELECT LAST_INSERT_ID(), '" & account & "', 'A', " & saldo & ")"
                                ad.cud(newQuery)
                            Next
                        End If
                    Catch ex As Exception
                        MessageBox.Show("No ha podido realizarse la transferencia por problemas con la base de datos", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Try
                    MessageBox.Show("La transferencia se ha realizado con éxito", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                returned = MessageBox.Show("¿Está seguro que desea realizar la transferencia?", "Transferencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If returned = 6 Then
                    If not_Error_Empty() Then
                        Dim refOrigen As String = dtpDate.Text.Substring(0, 2) & dtpDate.Text.Substring(3, 2) & dtpDate.Text.Substring(8) & subsEOr & subsEDe & conceptSelOri
                        Dim refDestino As String = dtpDate.Text.Substring(0, 2) & dtpDate.Text.Substring(3, 2) & dtpDate.Text.Substring(8) & subsEOr & subsEDe & conceptSelDes
                        'Waiting.Show()
                        'Threading.Thread.Sleep(3000)
                        Try

                            ''''''''''''''''''''''' ORIGEN ''''''''''''''''''''''''
                            Dim saldo As Integer
                            query = "SELECT Saldo FROM cuentas WHERE CC = '" & cbCO.Text & "'"
                            ds = ad.query(query)
                            If ds.Tables(0).Rows.Count > 0 Then
                                saldo = ds.Tables(0).Rows.Item(0).Item(0)
                            End If
                            If conceptSelOri = "A" Then
                                saldo = saldo + CInt(txtCant.Text)
                            Else
                                saldo = saldo - CInt(txtCant.Text)
                            End If

                            'UPDATE cuentas ORIGEN
                            query = "UPDATE cuentas SET Saldo = " & saldo & " WHERE CC = '" & cbCO.Text & "'"
                            ad.cud(query)
                            ' INSERT operaciones ORIGEN
                            query = "INSERT INTO operaciones (tipo, referencias, remitente, fecha, fecha_valor, concepto, concepto_ext, cantidad, saldo, periodica) VALUES('" & conceptSelOri & "', '" & refOrigen & "', '" & txtRem.Text & "', '" & hoy & "', '" & dtpDate.Text & "', '" & cbConcepto.Text & "', '" & txtConEx.Text & "', " & txtCant.Text & ", " & saldo & ", " & cbPer.Text & ")"
                            ad.cud(query)
                            'INSERT cc_op ORIGEN
                            query = "INSERT INTO cc_op (SELECT LAST_INSERT_ID(), '" & cbCO.Text & "', '" & conceptSelOri & "', " & saldo & ")"
                            ad.cud(query)

                            ''''''''''''''''''''''' DESTINO ''''''''''''''''''''''''
                            query = "SELECT Saldo FROM cuentas WHERE CC = '" & cbCD.Text & "'"
                            ds = ad.query(query)
                            If ds.Tables(0).Rows.Count > 0 Then
                                saldo = ds.Tables(0).Rows.Item(0).Item(0)
                            End If
                            If conceptSelDes = "A" Then
                                saldo = saldo + CInt(txtCant.Text)
                            Else
                                saldo = saldo - CInt(txtCant.Text)
                            End If

                            'UPDATE cuentas DESTINO
                            query = "UPDATE cuentas SET Saldo = " & saldo & " WHERE CC = '" & cbCD.Text & "'"
                            ad.cud(query)
                            ' INSERT operaciones DESTINO
                            query = "INSERT INTO operaciones (tipo, referencias, remitente, fecha, fecha_valor, concepto, concepto_ext, cantidad, saldo, periodica) VALUES('" & conceptSelDes & "', '" & refDestino & "', '" & txtRem.Text & "', '" & hoy & "', '" & dtpDate.Text & "', '" & cbConcepto.Text & "', '" & txtConEx.Text & "', " & txtCant.Text & ", " & saldo & ", " & cbPer.Text & ")"
                            ad.cud(query)
                            'INSERT cc_op ORIGEN
                            query = "INSERT INTO cc_op (SELECT LAST_INSERT_ID(), '" & cbCD.Text & "', '" & conceptSelDes & "', " & saldo & ")"
                            ad.cud(query)
                        Catch ex As Exception
                            'Waiting.Close()
                            MessageBox.Show("No ha podido realizarse la transferencia por problemas con la base de datos", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End Try
                        'Waiting.Close()
                        MessageBox.Show("La transferencia se ha realizado con éxito", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        Else
            MessageBox.Show("No se ha podido realizar la transferencia", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Function not_Error() As Boolean
        Dim passed As Boolean = True
        If txtRem.Text = "" Then
            passed = False
            epRem.SetError(txtRem, "El campo remitente no puede quedar vacío")
        End If
        If txtCant.Text = "" Then
            passed = False
            epCantidad.SetError(txtCant, "El campo cantidad no puede quedar vacío")
        End If
        If cbPer.Text = "" Then
            passed = False
            epPer.SetError(cbPer, "El campo periodicidad no puede quedar vacío")
        End If
        If txtConEx.Text = "" Then
            passed = False
            epConExt.SetError(lblConEx, "El campo concepto extendido no puede quedar vacío")
        End If
        Return passed
    End Function
    Private Sub cbConcepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbConcepto.SelectedIndexChanged
        Select Case cbConcepto.SelectedIndex
            Case 0
                conceptSelOri = "C"
                conceptSelDes = "A"
            Case 1
                conceptSelOri = "A"
                conceptSelDes = "C"
            Case 2
                conceptSelOri = "C"
                conceptSelDes = "A"
            Case 3
                conceptSelOri = "C"
                conceptSelDes = "A"
            Case 4
                conceptSelOri = "C"
                conceptSelDes = "A"
        End Select
        epConcepto.Clear()
    End Sub
    Private Sub txtCant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCant.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 45 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    ' LIBERAR LOS ERROR PROVIDERS AQUÍ
    Private Sub cbCD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCD.SelectedIndexChanged
        epCD.Clear()
        epCD1.Clear()
    End Sub
    Private Sub txtRem_TextChanged(sender As Object, e As EventArgs) Handles txtRem.TextChanged
        epRem.Clear()
    End Sub

    Private Sub cbCO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCO.SelectedIndexChanged
        epCO.Clear()
    End Sub

    Private Sub txtCant_TextChanged(sender As Object, e As EventArgs) Handles txtCant.TextChanged
        epCantidad.Clear()
    End Sub

    Private Sub cbPer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPer.SelectedIndexChanged
        epPer.Clear()
    End Sub

    Private Sub txtConEx_TextChanged(sender As Object, e As EventArgs) Handles txtConEx.TextChanged
        epConExt.Clear()
    End Sub
End Class