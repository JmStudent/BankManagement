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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.panelbusqueda = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cbnombreempresa = New System.Windows.Forms.ComboBox()
        Me.botonseleccionar = New System.Windows.Forms.Button()
        Me.labelcuentaempresa = New System.Windows.Forms.Label()
        Me.Labelnomempresa = New System.Windows.Forms.Label()
        Me.Referencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridviewgestionmov.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelbusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panelencabezado
        '
        Me.Panelencabezado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panelencabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panelencabezado.Location = New System.Drawing.Point(0, 0)
        Me.Panelencabezado.Name = "Panelencabezado"
        Me.Panelencabezado.Size = New System.Drawing.Size(1582, 95)
        Me.Panelencabezado.TabIndex = 0
        '
        'gridviewgestionmov
        '
        Me.gridviewgestionmov.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gridviewgestionmov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridviewgestionmov.Controls.Add(Me.DataGridView1)
        Me.gridviewgestionmov.Controls.Add(Me.panelbusqueda)
        Me.gridviewgestionmov.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.4!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridviewgestionmov.Location = New System.Drawing.Point(0, 94)
        Me.gridviewgestionmov.Margin = New System.Windows.Forms.Padding(3, 3, 3, 2)
        Me.gridviewgestionmov.Name = "gridviewgestionmov"
        Me.gridviewgestionmov.Size = New System.Drawing.Size(1582, 767)
        Me.gridviewgestionmov.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Referencia, Me.Fecha, Me.FechaValor, Me.Importe, Me.Salod})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.DataGridView1.Location = New System.Drawing.Point(102, 370)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1317, 352)
        Me.DataGridView1.TabIndex = 1
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
        'Referencia
        '
        Me.Referencia.HeaderText = "Referencia"
        Me.Referencia.Name = "Referencia"
        Me.Referencia.Width = 200
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 200
        '
        'FechaValor
        '
        Me.FechaValor.HeaderText = "Fechavalor"
        Me.FechaValor.Name = "FechaValor"
        Me.FechaValor.Width = 200
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.Width = 190
        '
        'Salod
        '
        Me.Salod.HeaderText = "Saldo"
        Me.Salod.Name = "Salod"
        Me.Salod.Width = 190
        '
        'Gestionarmovimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1582, 853)
        Me.Controls.Add(Me.gridviewgestionmov)
        Me.Controls.Add(Me.Panelencabezado)
        Me.Name = "Gestionarmovimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionarmovimiento"
        Me.gridviewgestionmov.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Referencia As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents FechaValor As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents Salod As DataGridViewTextBoxColumn
End Class
