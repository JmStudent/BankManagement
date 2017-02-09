Public Class ModificarEmpresas
    Dim ad As New DataAccess
    Dim Index = 0
    Private Sub ModificarEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarnombre()
        'cargardatos()

    End Sub

    Private Sub cargarnombre()
        Dim query As String
        Dim ds As DataSet



        query = "SELECT Nombre FROM empresas"
        ds = ad.query(query)

        cbempresas.DataSource = ds.Tables(0)
        cbempresas.DisplayMember = "Nombre"
        cbempresas.SelectedIndex = -1



        Index = -1
    End Sub
    Private Sub cargardatos()
        Dim query As String
        Dim ds As DataSet
        Dim dt As DataRow
        Dim activa As Integer


        If (cbempresas.SelectedIndex >index) Then

            query = "SELECT CIF,domicilio,activa FROM empresas where nombre='" & cbempresas.Text & "'"
            ds = ad.query(query)
            dt = ds.Tables(0).Rows(0)

            tbcif.Text = dt("CIF")
            tbdomicilio.Text = dt("domicilio")
            activa = dt("activa")
            If (activa = "1") Then
                cbactiva.Checked = True
            Else
                cbactiva.Checked = False
            End If


            query = "(SELECT CC  FROM cuentas where CIF_emp  =(SELECT CIF FROM empresas where nombre='" & cbempresas.Text & "') LIMIT 0,1 ) UNION (SELECT CC  FROM cuentas where Usado=0)"
            ds = ad.query(query)

            cbcuenta1.DataSource = ds.Tables(0)
            cbcuenta1.DisplayMember = "CC"






            query = "(SELECT CC  FROM cuentas where CIF_emp  =(SELECT CIF FROM empresas where nombre='" & cbempresas.Text & "') LIMIT 1,1)  UNION (SELECT CC  FROM cuentas where Usado=0)"
            ds = ad.query(query)

            cbcuenta2.DataSource = ds.Tables(0)
            cbcuenta2.DisplayMember = "CC"










        End If


    End Sub

    Private Sub cbempresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbempresas.SelectedIndexChanged
        cargardatos()
    End Sub

    Private Sub cbcuenta2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcuenta2.SelectedIndexChanged
        'Dim query As String
        'Dim ds As DataSet
        'query = "SELECT CC  FROM cuentas where CIF_emp  =(SELECT CIF FROM empresas where nombre='" & cbempresas.Text & "')"
        'ds = ad.query(query)

        'cbcuenta2.DataSource = ds.Tables(0)
        'cbcuenta2.DisplayMember = "CC"
    End Sub
End Class