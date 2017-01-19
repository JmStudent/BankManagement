Public Class Register
    Dim pbBox As New PictureBox
    Dim lblRegister As New Label
    Dim lblLogin As New Label
    Dim lblBtnReg As New Label
    Dim lblCIF As New Label
    Dim txtCIF As New TextBox
    Dim lblName As New Label
    Dim txtName As New TextBox
    Dim lblAddress As New Label
    Dim txtAddress As New TextBox
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panHeader.Height = oneRow()
        pbLogo.SetBounds(oneColumn() * 2.3, 0, 500, 63)
        ' SET BOX FORM
        pbBox.BorderStyle = BorderStyle.FixedSingle
        pbBox.BackColor = ColorTranslator.FromHtml("#ebebeb")
        pbBox.SetBounds(oneColumnPan() * 2, oneRowPan() * 1, oneColumnPan() * 5, oneRowPan() * 7)
        panBody.Controls.Add(pbBox)
        pbBox.SendToBack()
        ' SET REGISTER BOX
        lblRegister.Text = "REGISTRO"
        'lblRegister.BorderStyle = BorderStyle.FixedSingle
        lblRegister.BackColor = ColorTranslator.FromHtml("#404040")
        lblRegister.ForeColor = Color.White
        lblRegister.Font = New Font("Arial", 15, FontStyle.Bold)
        lblRegister.TextAlign = ContentAlignment.MiddleCenter
        lblRegister.SetBounds(pbBox.Left + (pbBox.Width / 2), oneRowPan() * 0.7, oneColumnPan() * 2, oneRowPan() * 0.8)
        panBody.Controls.Add(lblRegister)
        lblRegister.BringToFront()
        ' SET LOGIN BOX
        lblLogin.Text = "LOGIN"
        lblLogin.BorderStyle = BorderStyle.FixedSingle
        lblLogin.Cursor = Cursors.Hand
        lblLogin.BackColor = Color.White
        lblLogin.ForeColor = Color.Black
        lblLogin.Font = New Font("Arial", 15, FontStyle.Bold)
        lblLogin.TextAlign = ContentAlignment.MiddleCenter
        lblLogin.SetBounds(pbBox.Left + oneColumnPan() * 0.5, oneRowPan() * 0.7, oneColumnPan() * 2, oneRowPan() * 0.8)
        panBody.Controls.Add(lblLogin)
        lblLogin.BringToFront()
        AddHandler lblLogin.Click, AddressOf lblLogin_Click
        ' LABELS AND TEXTBOX FORM
        ' first field
        lblCIF.Text = "CIF"
        lblCIF.Font = New Font("Arial", 13, FontStyle.Bold)
        lblCIF.BackColor = ColorTranslator.FromHtml("#ebebeb")
        lblCIF.TextAlign = ContentAlignment.MiddleCenter
        lblCIF.Location = New Point(oneColumnPan() * 4.05, oneRowPan() * 1.9)
        panBody.Controls.Add(lblCIF)
        lblCIF.BringToFront()
        txtCIF.SetBounds(oneColumnPan() * 3.5, oneRowPan() * 2.4, oneColumnPan() * 2, oneRowPan())
        txtCIF.Font = New Font("Arial", 13)
        txtCIF.MaxLength = 10
        panBody.Controls.Add(txtCIF)
        txtCIF.BringToFront()
        ' second field
        lblName.Text = "NOMBRE DE LA EMPRESA"
        lblName.Font = New Font("Arial", 13, FontStyle.Bold)
        lblName.BackColor = ColorTranslator.FromHtml("#ebebeb")
        lblName.TextAlign = ContentAlignment.MiddleCenter
        lblName.AutoSize = True
        lblName.Location = New Point(oneColumnPan() * 3.5, oneRowPan() * 3.3)
        panBody.Controls.Add(lblName)
        lblName.BringToFront()
        txtName.SetBounds(oneColumnPan() * 3.5, oneRowPan() * 3.8, oneColumnPan() * 2, oneRowPan())
        txtName.Font = New Font("Arial", 13)
        txtName.MaxLength = 100
        panBody.Controls.Add(txtName)
        txtName.BringToFront()
        ' third field
        lblAddress.Text = "DIRECCIÓN DE LA EMPRESA"
        lblAddress.Font = New Font("Arial", 13, FontStyle.Bold)
        lblAddress.BackColor = ColorTranslator.FromHtml("#ebebeb")
        lblAddress.TextAlign = ContentAlignment.MiddleCenter
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(oneColumnPan() * 3.41, oneRowPan() * 4.7)
        panBody.Controls.Add(lblAddress)
        lblAddress.BringToFront()
        txtAddress.SetBounds(oneColumnPan() * 3.5, oneRowPan() * 5.2, oneColumnPan() * 2, oneRowPan())
        txtAddress.Multiline = True
        txtAddress.Font = New Font("Arial", 13)
        txtAddress.MaxLength = 150
        panBody.Controls.Add(txtAddress)
        txtAddress.BringToFront()
        ' button
        lblBtnReg.BackColor = ColorTranslator.FromHtml("#1952C9")
        lblBtnReg.ForeColor = Color.White
        lblBtnReg.Text = "REGISTRAR"
        lblBtnReg.Font = New Font("Arial", 13, FontStyle.Bold)
        lblBtnReg.TextAlign = ContentAlignment.MiddleCenter
        lblBtnReg.SetBounds(oneColumnPan() * 3.5, oneRowPan() * 6.6, oneColumnPan() * 2, oneRowPan())
        lblBtnReg.BorderStyle = BorderStyle.FixedSingle
        lblBtnReg.Cursor = Cursors.Hand
        panBody.Controls.Add(lblBtnReg)
        lblBtnReg.BringToFront()
        AddHandler lblBtnReg.Click, AddressOf lblBtnReg_Click
    End Sub
    ' BEHAVIOR
    Private Sub lblLogin_Click(sender As Object, e As EventArgs)
        Base.Show()
        Me.Close()
    End Sub
    Private Sub lblBtnReg_Click(sender As Object, e As EventArgs)
        ' ERROR DEFINITION
        Dim cifRight As Boolean = False
        Dim nameRight As Boolean = False
        Dim addressRight As Boolean = False
        If txtCIF.Text = "" Then
            epCif.SetError(txtCIF, "El campo CIF no puede quedar vacío")
            cifRight = False
        Else
            cifRight = True
        End If
        If txtName.Text = "" Then
            epName.SetError(txtName, "El campo Nombre de empresa no puede quedar vacío")
            nameRight = False
        Else
            nameRight = True
        End If
        If txtAddress.Text = "" Then
            epAddress.SetError(txtAddress, "El campo CIF no puede quedar vacío")
            addressRight = False
        Else
            addressRight = True
        End If
        If cifRight And nameRight And addressRight Then
            Dim ad As New DataAccess
            Dim ds As New DataSet
            Dim query As String
            query = "SELECT CIF FROM empresas where CIF = '" & txtCIF.Text & "'"
            ds = ad.query(query)
            If ds.Tables(0).Rows().Count = 1 Then
                MessageBox.Show("Esta empresa ya está registrada", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCIF.Text = ""
                txtName.Text = ""
                txtAddress.Text = ""
            Else
                'pass son los 4 últimos dígitos del cif
                Dim pass As String = txtCIF.Text.Substring(6)
                query = "INSERT INTO empresas VALUES('" & txtCIF.Text.ToUpper & "','" & pass & "'
                        ,'" & txtName.Text & "','" & txtAddress.Text & "', 0)"
                ad.cud(query)
                MessageBox.Show("Empresa registrada con éxito. El administrador debe desbloquear su cuenta", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
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
End Class