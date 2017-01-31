Public Class AnadirCuenta
    Dim query As String
    Dim ad As New DataAccess
    Dim ds As DataSet
    Private Sub AnadirCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbLogo.SetBounds(oneColumn() * 2.3, 0, 500, 63)
        pbContainer.Location = New Point(oneColumnPan(), oneRowPan())
        pbContainer.Width = (oneColumnPan() * 7)
        pbContainer.Height = (oneRowPan() * 7)
        ' Banco
        Try
            query = "SELECT * FROM bancos"
            ds = ad.query(query)
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                cbBanco.DataSource = ds.Tables(0)
                cbBanco.DisplayMember = "nombre"
            Next
        Catch ex As Exception
            MessageBox.Show("No ha podido cargarse los bancos disponibles", "Bancos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        'Cantidad
        For i = 1 To 200
            cbCantidad.Items.Add(i)
        Next
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

    Private Sub pbClose_Click(sender As Object, e As EventArgs) Handles pbClose.Click
        Dim returned As Integer
        returned = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If returned = 6 Then
            Me.Close()
        End If
    End Sub

    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles pbBack.Click
        ' el menú anterior
    End Sub

    Private Sub pbRefresh_Click(sender As Object, e As EventArgs) Handles pbRefresh.Click
        txtOficina.Text = ""
        txtSaldo.Text = ""
    End Sub

    Private Sub pbMake_Click(sender As Object, e As EventArgs) Handles pbMake.Click
        If not_Error() Then
            'codigo bueno aquí

        Else
            MessageBox.Show("No se ha podido realizar la transferencia", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Function not_Error() As Boolean
        Dim passed As Boolean = True
        If cbBanco.Text = "" Then
            passed = False
            epBanco.SetError(cbBanco, "El campo banco no puede quedar vacío")
        End If
        If txtOficina.Text = "" Then
            passed = False
            epOficina.SetError(txtOficina, "El campo oficina no puede quedar vacío")
        End If
        If txtSaldo.Text = "" Then
            passed = False
            epSaldo.SetError(txtSaldo, "El campo saldo no puede quedar vacío")
        End If
        If cbCantidad.Text = "" Then
            passed = False
            epCantidad.SetError(cbCantidad, "El campo cantidad no puede quedar vacío")
        End If
        Return passed
    End Function
End Class