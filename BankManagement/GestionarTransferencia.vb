Public Class GestionarTransferencia
    Dim query As String
    Dim ad As New DataAccess
    Dim ds As DataSet
    Dim loaded As Boolean = False
    Dim loaded2 As Boolean = False
    Private Sub GestionarMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' limitar el maxlength de los campos al máximo de caracteres que se pueda introducir en la base de datos.
        pbLogo.SetBounds(oneColumn() * 2.3, 0, 500, 63)
        ' CONSULTAS
        query = "SELECT * FROM empresas"
        Try
            ' EMPRESA ORIGEN
            ds = ad.query(query)
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                cbEO.DataSource = ds.Tables(0)
                cbEO.DisplayMember = "nombre" ' esta es la consulta que quiero hacer.
            Next
            loaded = True

            ' EMPRESA DESTINO
            ds = ad.query(query)
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                cbED.DataSource = ds.Tables(0)
                cbED.DisplayMember = "nombre"
            Next
            loaded2 = True
        Catch ex As Exception
            MessageBox.Show("No se puede conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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
    End Sub
    Private Sub cbEO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEO.SelectedIndexChanged
        If loaded Then
            query = "SELECT * FROM cuentas WHERE CIF_emp = (SELECT CIF FROM empresas WHERE nombre = '" & cbEO.Text & "')"
            ds = ad.query(query)
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                cbCO.DataSource = ds.Tables(0)
                cbCO.DisplayMember = "CC"
            Next
        End If
    End Sub

    Private Sub cbED_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbED.SelectedIndexChanged
        If loaded2 Then
            query = "SELECT * FROM cuentas WHERE CIF_emp = (SELECT CIF FROM empresas WHERE nombre = '" & cbED.Text & "')"
            ds = ad.query(query)
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                cbCD.DataSource = ds.Tables(0)
                cbCD.DisplayMember = "CC"
            Next
        End If
    End Sub

    Private Sub pbMake_Click(sender As Object, e As EventArgs) Handles pbMake.Click
        Dim returned As Integer
        returned = MessageBox.Show("¿Está seguro que desea realizar la transferencia?", "Transferencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If returned = 6 Then
            If cbCO.Text = cbCD.Text Then
                MessageBox.Show("La transferencia no se ha realizado", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                epCD.SetError(cbCD, "La cuenta de destino no puede ser la misma que la cuenta de origen")
            End If
        End If
    End Sub

    'Private Sub cbEO_DropDown(sender As Object, e As EventArgs) Handles cbEO.DropDown
    '    MsgBox(cbED.Text)
    'End Sub
End Class