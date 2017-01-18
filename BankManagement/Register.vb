Public Class Register
    Dim pbBox As New PictureBox
    Dim pbRegisterBox As New PictureBox
    Dim pbLoginBox As New PictureBox
    Dim lblRegister As New Label
    Dim lblLogin As New Label
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panHeader.Height = oneRow()
        ' SET BOX FORM
        'pbBox.Size = New Drawing.Size(oneColumn() * 2, oneRow() * 3)
        pbBox.BorderStyle = BorderStyle.FixedSingle
        pbBox.BackColor = ColorTranslator.FromHtml("#ebebeb")
        pbBox.SetBounds(oneColumnPan() * 2, oneRowPan() * 1, oneColumnPan() * 5, oneRowPan() * 7)
        panBody.Controls.Add(pbBox)
        pbBox.SendToBack()
        ' SET REGISTER BOX
        pbRegisterBox.BorderStyle = BorderStyle.FixedSingle
        pbRegisterBox.BackColor = ColorTranslator.FromHtml("#404040")
        pbRegisterBox.SetBounds(pbBox.Left + (pbBox.Width / 2), oneRowPan() * 0.7, oneColumnPan() * 2, oneRowPan() * 0.8)
        panBody.Controls.Add(pbRegisterBox)
        pbRegisterBox.BringToFront()
        lblRegister.Text = "Registro"
        lblRegister.BackColor = Color.White
        pbRegisterBox.SetBounds(pbBox.Left + (pbBox.Width / 2), oneRowPan() * 0.7, oneColumnPan() * 2, oneRowPan() * 0.8)
        panBody.Controls.Add(lblRegister)
        lblRegister.BringToFront()
        ' SET LOGIN BOX
        pbLoginBox.BorderStyle = BorderStyle.FixedSingle
        pbLoginBox.BackColor = Color.White
        pbLoginBox.SetBounds(pbBox.Left + oneColumnPan() * 0.5, oneRowPan() * 0.7, oneColumnPan() * 2, oneRowPan() * 0.8)
        panBody.Controls.Add(pbLoginBox)
        pbLoginBox.BringToFront()
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