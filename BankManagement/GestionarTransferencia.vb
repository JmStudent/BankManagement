Public Class GestionarTransferencia
    Dim ad As New DataAccess
    Private Sub GestionarMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' limitar el maxlength de los campos al máximo de caracteres que se pueda introducir en la base de datos.
        pbLogo.SetBounds(oneColumn() * 2.3, 0, 500, 63)
        Dim consulta As String
        Dim dsconsulta As DataSet

        consulta = "SELECT * FROM empresas"
        dsconsulta = ad.query(consulta)
        For i As Integer = 0 To dsconsulta.Tables(0).Rows.Count - 1
            cbEO.DataSource = dsconsulta.Tables(0)
            cbEO.DisplayMember = "nombre" ' esta es la consulta que quiero hacer.
            cbED.DataSource = dsconsulta.Tables(0)
            cbED.DisplayMember = "nombre" ' esta es la consulta que quiero hacer.
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
        ' volver a cargar todos los combobox y vaciar los textboxt
        txtCant.Text = ""
        txtRem.Text = ""
        chbDom.Checked = False
        txtConEx.Text = ""
        dtpDate.ResetText()
    End Sub
End Class