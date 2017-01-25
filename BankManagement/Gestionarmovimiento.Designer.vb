Imports MySql.Data.MySqlClient
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gestionarmovimiento
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panelencabezado = New System.Windows.Forms.Panel()
        Me.gridviewgestionmov = New System.Windows.Forms.Panel()
        Me.lista1 = New System.Windows.Forms.ListView()
        Me.Referencia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaValor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Importe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Saldo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panelbusqueda = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cbnombreempresa = New System.Windows.Forms.ComboBox()
        Me.botonseleccionar = New System.Windows.Forms.Button()
        Me.labelcuentaempresa = New System.Windows.Forms.Label()
        Me.Labelnomempresa = New System.Windows.Forms.Label()
        Me.gridviewgestionmov.SuspendLayout()
        Me.panelbusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panelencabezado
        '
        Me.Panelencabezado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panelencabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panelencabezado.Location = New System.Drawing.Point(0, 0)
        Me.Panelencabezado.Name = "Panelencabezado"
        Me.Panelencabezado.Size = New System.Drawing.Size(1530, 95)
        Me.Panelencabezado.TabIndex = 0
        '
        'gridviewgestionmov
        '
        Me.gridviewgestionmov.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gridviewgestionmov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridviewgestionmov.Controls.Add(Me.lista1)
        Me.gridviewgestionmov.Controls.Add(Me.panelbusqueda)
        Me.gridviewgestionmov.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.4!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridviewgestionmov.Location = New System.Drawing.Point(0, 94)
        Me.gridviewgestionmov.Margin = New System.Windows.Forms.Padding(3, 3, 3, 2)
        Me.gridviewgestionmov.Name = "gridviewgestionmov"
        Me.gridviewgestionmov.Size = New System.Drawing.Size(1536, 767)
        Me.gridviewgestionmov.TabIndex = 1
        '
        'lista1
        '
        Me.lista1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Referencia, Me.Fecha, Me.FechaValor, Me.Importe, Me.Saldo})
        Me.lista1.Location = New System.Drawing.Point(11, 381)
        Me.lista1.Name = "lista1"
        Me.lista1.Size = New System.Drawing.Size(1509, 365)
        Me.lista1.TabIndex = 2
        Me.lista1.UseCompatibleStateImageBehavior = False
        Me.lista1.View = System.Windows.Forms.View.Details
        '
        'Referencia
        '
        Me.Referencia.Text = "Referencia"
        Me.Referencia.Width = 235
        '
        'Fecha
        '
        Me.Fecha.Text = "Fecha"
        Me.Fecha.Width = 225
        '
        'FechaValor
        '
        Me.FechaValor.Text = "FechaValor"
        Me.FechaValor.Width = 220
        '
        'Importe
        '
        Me.Importe.Text = "Importe"
        Me.Importe.Width = 225
        '
        'Saldo
        '
        Me.Saldo.Text = "Saldo"
        Me.Saldo.Width = 225
        '
        'panelbusqueda
        '
        Me.panelbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelbusqueda.Controls.Add(Me.ComboBox1)
        Me.panelbusqueda.Controls.Add(Me.cbnombreempresa)
        Me.panelbusqueda.Controls.Add(Me.botonseleccionar)
        Me.panelbusqueda.Controls.Add(Me.labelcuentaempresa)
        Me.panelbusqueda.Controls.Add(Me.Labelnomempresa)
        Me.panelbusqueda.Location = New System.Drawing.Point(573, 78)
        Me.panelbusqueda.Name = "panelbusqueda"
        Me.panelbusqueda.Size = New System.Drawing.Size(429, 228)
        Me.panelbusqueda.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboBox1.Location = New System.Drawing.Point(138, 71)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(268, 25)
        Me.ComboBox1.TabIndex = 3
        '
        'cbnombreempresa
        '
        Me.cbnombreempresa.BackColor = System.Drawing.Color.White
        Me.cbnombreempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbnombreempresa.FormattingEnabled = True
        Me.cbnombreempresa.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.cbnombreempresa.Location = New System.Drawing.Point(155, 31)
        Me.cbnombreempresa.Name = "cbnombreempresa"
        Me.cbnombreempresa.Size = New System.Drawing.Size(251, 25)
        Me.cbnombreempresa.TabIndex = 1
        '
        'botonseleccionar
        '
        Me.botonseleccionar.AutoEllipsis = True
        Me.botonseleccionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.botonseleccionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.botonseleccionar.FlatAppearance.BorderSize = 0
        Me.botonseleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.botonseleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.botonseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonseleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonseleccionar.ForeColor = System.Drawing.Color.White
        Me.botonseleccionar.Location = New System.Drawing.Point(44, 126)
        Me.botonseleccionar.Name = "botonseleccionar"
        Me.botonseleccionar.Size = New System.Drawing.Size(157, 43)
        Me.botonseleccionar.TabIndex = 2
        Me.botonseleccionar.Text = "Seleccionar"
        Me.botonseleccionar.UseVisualStyleBackColor = False
        '
        'labelcuentaempresa
        '
        Me.labelcuentaempresa.AutoSize = True
        Me.labelcuentaempresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelcuentaempresa.Location = New System.Drawing.Point(40, 71)
        Me.labelcuentaempresa.Name = "labelcuentaempresa"
        Me.labelcuentaempresa.Size = New System.Drawing.Size(80, 20)
        Me.labelcuentaempresa.TabIndex = 1
        Me.labelcuentaempresa.Text = "Cuenta: "
        '
        'Labelnomempresa
        '
        Me.Labelnomempresa.AutoSize = True
        Me.Labelnomempresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelnomempresa.Location = New System.Drawing.Point(40, 32)
        Me.Labelnomempresa.Name = "Labelnomempresa"
        Me.Labelnomempresa.Size = New System.Drawing.Size(89, 20)
        Me.Labelnomempresa.TabIndex = 0
        Me.Labelnomempresa.Text = "Empresa:"
        '
        'Gestionarmovimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1530, 853)
        Me.Controls.Add(Me.gridviewgestionmov)
        Me.Controls.Add(Me.Panelencabezado)
        Me.Name = "Gestionarmovimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionarmovimiento"
        Me.gridviewgestionmov.ResumeLayout(False)
        Me.panelbusqueda.ResumeLayout(False)
        Me.panelbusqueda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panelencabezado As Panel
    Friend WithEvents gridviewgestionmov As Panel
    Friend WithEvents panelbusqueda As Panel
    Friend WithEvents Labelnomempresa As Label
    Friend WithEvents labelcuentaempresa As Label
    Friend WithEvents botonseleccionar As Button
    Friend WithEvents cbnombreempresa As ComboBox
    Friend WithEvents ComboBox1 As ComboBox

    Dim ad As New Datos
    Private Sub botonseleccionar_Click(sender As Object, e As EventArgs) Handles botonseleccionar.Click
        Dim consulta As String
        Dim tab As DataTable
        Dim i As Integer
        MsgBox(cbnombreempresa.Text)
        If cbnombreempresa.SelectedItem Is Nothing Or ComboBox1.SelectedItem Is Nothing Then
            lista1.Items.Clear()
            MsgBox("Campos vacíos")
        Else
            lista1.Items.Clear()
            consulta = "SELECT * FROM operaciones WHERE codigo IN(SELECT cod_op FROM cc_op WHERE cc in (SELECT CC FROM cuentas WHERE CC=" & ComboBox1.Text & "))"
            tab = ad.rellenartabla(consulta)
            For i = 0 To tab.Rows.Count - 1
                With lista1
                    .Items.Add(tab.Rows(i)("referencias"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(tab.Rows(i)("fecha"))
                        .Add(tab.Rows(i)("fecha_valor"))
                        .Add(tab.Rows(i)("cantidad"))
                        .Add(tab.Rows(i)("saldo"))
                    End With
                End With
            Next
            MsgBox("exito")
        End If
    End Sub

    Private Sub cbnombreempresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbnombreempresa.SelectedIndexChanged
        Dim consulta As String
        Dim dsconsulta As DataSet

        consulta = "SELECT * FROM Cuentas WHERE CIF_emp IN (SELECT CIF FROM Empresas WHERE nombre='" & cbnombreempresa.Text & "')"
        dsconsulta = ad.consultar(consulta)
        ComboBox1.DataSource = Nothing
        For i As Integer = 0 To dsconsulta.Tables(0).Rows.Count - 1
            ComboBox1.DataSource = dsconsulta.Tables(0)
            ComboBox1.DisplayMember = "CC"
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Gestionarmovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consulta As String
        Dim dsconsulta As DataSet

        consulta = "SELECT * FROM Empresas"
        dsconsulta = ad.consultar(consulta)

        For i As Integer = 0 To dsconsulta.Tables(0).Rows.Count - 1
            cbnombreempresa.DataSource = dsconsulta.Tables(0)
            cbnombreempresa.DisplayMember = "nombre"
        Next

        cbnombreempresa.SelectedIndex = -1
        ComboBox1.SelectedIndex = -1

    End Sub

    Private Sub gridviewgestionmov_Paint(sender As Object, e As PaintEventArgs) Handles gridviewgestionmov.Paint

    End Sub

    Friend WithEvents lista1 As ListView
    Friend WithEvents Referencia As ColumnHeader
    Friend WithEvents Fecha As ColumnHeader
    Friend WithEvents FechaValor As ColumnHeader
    Friend WithEvents Importe As ColumnHeader
    Friend WithEvents Saldo As ColumnHeader
End Class
