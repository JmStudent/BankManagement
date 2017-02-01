Public Class ReiniciarSaldo
    Dim query As String
    Dim ad As New DataAccess
    Dim ds As DataSet
    Private Sub ReiniciarSaldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbLogo.SetBounds(oneColumn() * 2.3, 0, 500, 63)
        pbContainer.Location = New Point(oneColumnPan(), oneRowPan())
        pbContainer.Width = (oneColumnPan() * 7)
        pbContainer.Height = (oneRowPan() * 7)
        Try
            query = "SELECT nombre FROM bancos"
            ds = ad.query(query)
            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    cbBanco.DataSource = ds.Tables(0)
                    cbBanco.DisplayMember = "nombre"
                Next
            Else
                MessageBox.Show("No hay bancos disponibles en la base de datos, agregue alguno antes de añadir ninguna cuenta", "Bancos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("No ha podido cargarse los bancos disponibles", "Bancos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
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
        ' poner ventana de atrás
    End Sub

    Private Sub pbRefresh_Click(sender As Object, e As EventArgs)
        txtSaldo.Text = ""
    End Sub

    Private Sub lblReiniciar_MouseHover(sender As Object, e As EventArgs) Handles lblReiniciar.MouseHover
        lblReiniciar.BackColor = SystemColors.Highlight
    End Sub

    Private Sub lblReiniciar_MouseLeave(sender As Object, e As EventArgs) Handles lblReiniciar.MouseLeave
        lblReiniciar.BackColor = Color.FromArgb(0, 104, 176)
    End Sub

    Private Sub lblReiniciar_Click(sender As Object, e As EventArgs) Handles lblReiniciar.Click
        If not_error() Then
            Try
                query = "SELECT CC FROM cuentas WHERE Banco = '" & cbBanco.Text & "'"
                ds = ad.query(query)
                If ds.Tables(0).Rows.Count > 0 Then
                    Dim dsCC As New DataSet
                    dsCC = ds
                    For i = 0 To (dsCC.Tables(0).Rows.Count - 1)
                        Try
                            query = "UPDATE cuentas SET Saldo = " & txtSaldo.Text & " WHERE CC = '" & dsCC.Tables(0).Rows.Item(i).Item(0) & "'"
                            ad.cud(query)
                        Catch ex As Exception
                            MessageBox.Show("Ha habido un error mientras se estaba modificando el saldo de las cuentas. Se han modificado " & i & " cuentas.", "Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit For
                        End Try
                    Next
                    MessageBox.Show("El saldo de las cuentas selecciondas se ha reiniciado con éxito", "Saldo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No hay cuentas asociadas a este banco", "Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un error al intentar recuperar las cuentas", "Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub
    Function not_error() As Boolean
        Dim passed As Boolean = True
        If cbBanco.Text = "" Then
            passed = False
            epBanco.SetError(cbBanco, "No puede quedar vacío el campo Banco")
        End If
        If txtSaldo.Text = "" Then
            passed = False
            epSaldo.SetError(txtSaldo, "No puede quedar vacío el campo Saldo")
        End If
        Return passed
    End Function

    Private Sub txtSaldo_TextChanged(sender As Object, e As EventArgs) Handles txtSaldo.TextChanged
        epSaldo.Clear()
    End Sub

    Private Sub cbBanco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBanco.SelectedIndexChanged
        epBanco.Clear()
    End Sub
    Private Sub txtSaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaldo.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 45 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class