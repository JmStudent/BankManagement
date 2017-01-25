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
        ' limitar el maxlength de los campos al máximo de caracteres que se pueda introducir en la base de datos.
        pbLogo.SetBounds(oneColumn() * 2.3, 0, 500, 63)
        ' CONSULTAS
        query = "SELECT * FROM empresas WHERE activa = 1"
        Try
            ' EMPRESA ORIGEN
            ds = ad.query(query)
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                cbEO.DataSource = ds.Tables(0)
                cbEO.DisplayMember = "nombre" ' esta es la consulta que quiero hacer.
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
        For i = 1 To 30
            cbPer.Items.Add(i)
        Next

        'FECHA
        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.CustomFormat = "dd/MM/yyyy"

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
        cbEO.ResetText()
        cbCO.ResetText()
        cbED.ResetText()
        cbCD.ResetText()
        txtRem.Text = ""
        txtCant.Text = ""
        cbPer.ResetText()
        dtpDate.ResetText()
        cbConcepto.ResetText()
        chbDom.Checked = False
        txtConEx.Text = ""
        epCD.Clear()
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

    Private Sub pbMake_Click(sender As Object, e As EventArgs) Handles pbMake.Click
        Dim returned As Integer
        If chbDom.Checked Then
            returned = MessageBox.Show("¿Está seguro que desea realizar la transferencia MASIVA?", "Transferencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If returned = 6 Then
                'cobrarle a todas las cuentas la cantidad, lo que quiere decir 2 insert y 1 update por cada cuenta.
            End If
        Else
            returned = MessageBox.Show("¿Está seguro que desea realizar la transferencia?", "Transferencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If returned = 6 Then
                If cbCO.Text = cbCD.Text Then
                    MessageBox.Show("La transferencia no se ha realizado porque la cuenta de destino no puede ser la misma que la cuenta de origen", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    epCD.SetError(cbCD, "Cambie la cuenta de destino o de origen")
                Else
                    ' aquí debe ir el código para una transferencia normal de un sitio a otro

                    ' este es el numero de referencia de origen
                    Dim refOrigen As String = dtpDate.Text.Substring(0, 2) & dtpDate.Text.Substring(3, 2) & dtpDate.Text.Substring(8) & subsEOr & subsEDe & conceptSelOri
                    Dim refDestino As String = dtpDate.Text.Substring(0, 2) & dtpDate.Text.Substring(3, 2) & dtpDate.Text.Substring(8) & subsEOr & subsEDe & conceptSelDes
                    MsgBox(refOrigen)
                    MsgBox(refDestino)
                    ' realizar un dialog1.show()
                    'Try

                    ' INSERT operaciones ORIGEN
                    Dim saldo As Integer
                    query = "SELECT Saldo FROM cuentas WHERE CC = '" & cbCO.Text & "'"
                    ds = ad.query(query)
                        If ds.Tables(0).Rows.Count > 0 Then
                            saldo = ds.Tables(0).Rows.Item(0).Item(0)
                        End If
                        '(codigo, tipo, referencias, remitente, fecha, fecha_valor, concepto, concepto_ext, cantidad, saldo, periodica)
                        Dim queryOrigen As String = "INSERT INTO operaciones VALUES(0, '" & conceptSelOri & "', '" & refOrigen & "', '" & txtRem.Text & "', '" & dtpDate.Text & "', '" & dtpDate.Text & "', '" & cbConcepto.Text & "', '" & txtConEx.Text & "', " & txtCant.Text & ", " & saldo & ", " & cbPer.Text & ")"
                    ad.cud(queryOrigen)

                    ' INSERT operaciones DESTINO
                    query = "SELECT Saldo FROM cuentas WHERE CC = '" & cbCD.Text & "'"
                    ds = ad.query(query)
                    If ds.Tables(0).Rows.Count > 0 Then
                        saldo = ds.Tables(0).Rows.Item(0).Item(0)
                    End If
                    Dim queryDestino As String = "INSERT operaciones
                    (codigo, tipo, referencias, remitente, fecha, fecha_valor, concepto, concepto_ext, cantidad, saldo, periodica) 
                    VALUES 
                    (0, 'NorthWestern')"
                    ad.cud(queryDestino)
                    'Catch ex As Exception
                    '    ' poner también aquí que se cierre la ventana
                    '    MessageBox.Show("No ha podido realizarse la transferencia por problemas con la base de datos", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    'End Try
                    ' al final cerrar la ventana de "realizando transferencia"
                    MessageBox.Show("La transferencia se ha realizado con éxito", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub cbCD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCD.SelectedIndexChanged
        epCD.Clear()
    End Sub

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
    End Sub
End Class