Public Class Transferencias
    Dim ad As New DataAccess

    Private Sub Transferencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcc()
        cargarempresas()

    End Sub

    Private Sub cargarcc()
        Dim query As String
        Dim ds As DataSet
        Dim cif As String
        cif = "A11111111"

        query = "SELECT CC FROM cuentas where CIF_emp='" & cif & "'"
        ds = ad.query(query)

        cbcuantaorigen.DataSource = ds.Tables(0)
        cbcuantaorigen.DisplayMember = "CC"
        cbcuantaorigen.SelectedIndex = -1
    End Sub
    Private Sub cargarempresas()
        Dim query As String
        Dim ds As DataSet
        query = "Select nombre FROM empresas"
        ds = ad.query(query)
        cbempresadestino.DataSource = ds.Tables(0)
        cbempresadestino.DisplayMember = "nombre"
        cbempresadestino.SelectedIndex = -1
    End Sub

    Private Sub cargarccd()
        Dim query As String
        Dim ds As DataSet
        query = "Select CC FROM cuentas where CIF_emp In (Select CIF FROM empresas WHERE nombre= '" & cbempresadestino.Text & "')"
        ds = ad.query(query)
        cbcuentadestino.DataSource = ds.Tables(0)
        cbcuentadestino.DisplayMember = "CC"
    End Sub

    Private Sub cbempresadestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbempresadestino.SelectedIndexChanged
        cargarccd()
    End Sub

    Private Sub transfe()
        Dim query, referencia, x As String
        Dim ds As DataSet
        Dim tmo As Integer = cbcuantaorigen.Text.Length
        Dim tmd As Integer = cbcuentadestino.Text.Length
        referencia = Date.Today.ToString.Substring(0, 2) & Date.Today.ToString.Substring(3, 2) & Date.Today.ToString.Substring(8, 2) & cbcuantaorigen.Text.Substring((tmo - 3), 3) & cbcuentadestino.Text.Substring((tmd - 3), 3)

        query = "INSERT INTO operaciones VALUES (1,ABONO,'" & referencia & "','" & tbremitente.Text & ",'" & Date.Today.ToString & "','" & Date.Today.ToString & "','" & tbconcepto.Text & "','" & tbconceptoextendido.Text & "',)"
    End Sub

    Private Sub btn__Click(sender As Object, e As EventArgs) Handles btn_.Click
        transfe()
    End Sub
End Class