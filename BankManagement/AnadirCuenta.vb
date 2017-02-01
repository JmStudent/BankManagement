Public Class AnadirCuenta
    Dim query As String
    Dim ad As New DataAccess
    Dim ds As DataSet
    Dim dsBank As DataSet
    Private Sub AnadirCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbLogo.SetBounds(oneColumn() * 2.3, 0, 500, 63)
        pbContainer.Location = New Point(oneColumnPan(), oneRowPan())
        pbContainer.Width = (oneColumnPan() * 7)
        pbContainer.Height = (oneRowPan() * 7)
        ' Banco
        Try
            query = "SELECT * FROM bancos"
            dsBank = ad.query(query)
            If dsBank.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To dsBank.Tables(0).Rows.Count - 1
                    cbBanco.DataSource = dsBank.Tables(0)
                    cbBanco.DisplayMember = "nombre"
                Next
            Else
                MessageBox.Show("No hay bancos disponibles en la base de datos, agregue alguno antes de añadir ninguna cuenta", "Bancos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("No ha podido cargarse los bancos disponibles", "Bancos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        'Cantidad
        For i = 1 To 50
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
            For x = 1 To CInt(cbCantidad.Text)
                Try
                    Dim ccList As New ArrayList
                    query = "SELECT CC FROM cuentas"
                    ds = ad.query(query)
                    If ds.Tables(0).Rows.Count > 0 Then
                        For i = 0 To (ds.Tables(0).Rows.Count - 1)
                            ccList.Add(ds.Tables(0).Rows.Item(i).Item(0))
                        Next
                        Dim ram As String = CStr(ranInt()) & CStr(ranInt()) & CStr(ranInt())
                        'For Each cc As String In ccList
                        '    If cc.Substring(cc.Length - 3) = ran Then
                        '        ran = CStr(ranInt()) + CStr(ranInt()) + CStr(ranInt())
                        '    End If
                        'Next
                        For j = 0 To (ccList.Count - 1)
                            If ccList.Item(j).Substring(ccList.Item(j).Length - 3) = ram Then
                                ram = CStr(ranInt()) & CStr(ranInt()) & CStr(ranInt())
                                j = 0
                            End If
                        Next
                        ' primer item: cada fila, segundo item: 0 el cif, 1 la cuenta, 2 el banco, 3 la oficina, 4 saldo, 5 usado
                        Dim cc As String = dsBank.Tables(0).Rows.Item(CInt(cbBanco.SelectedIndex)).Item(1) & ram
                        query = "INSERT INTO cuentas (CC, Banco, Oficina, Saldo, Usado)  VALUES('" & cc & "', '" & cbBanco.Text & "', '" & txtOficina.Text & "', " & txtSaldo.Text & ", 0)"
                        ad.cud(query)
                        'Dim listaprueba As New ArrayList
                        'listaprueba.Add("1")
                        'listaprueba.Add("7")
                        'listaprueba.Add("9")
                        'Dim ran As String = CStr(ranInt())
                        '    MsgBox("Numero aleatorio primero: " & ran)
                        'For j = 0 To (listaprueba.Count - 1)
                        '    If listaprueba.Item(j) = ran Then
                        '        MsgBox("El número de la lista: " & listaprueba.Item(j) & " y el aleatorio: " & ran & "son iguales")
                        '        ran = CStr(ranInt())
                        '        MsgBox("Nuevo número aleatorio: " & ran)
                        '        j = 0
                        '    End If
                        '    MsgBox("j después del if" & j)
                        'Next
                        'MsgBox("permiso concedido, terminado el loop")
                    End If
                Catch ex As Exception
                    MessageBox.Show("No se ha podido añadir la/s cuenta/s", "Añadir Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Next
            MessageBox.Show("La/s cuenta/s se ha/n añadido con éxito", "Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No se ha podido añadir la/s cuenta/s", "Añadir Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Function ranInt() As Integer
        Return CInt(Rnd() * 9)
    End Function
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