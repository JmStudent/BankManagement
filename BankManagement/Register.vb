Public Class Register
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function oneColumn() As Integer
        Return (Me.Width / 9)
    End Function
    Private Function oneRow() As Integer
        Return (Me.Height / 9)
    End Function
End Class