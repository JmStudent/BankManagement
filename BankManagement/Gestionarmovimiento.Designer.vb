<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestionarmovimiento
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panelencabezado = New System.Windows.Forms.Panel()
        Me.Panelcuerpo = New System.Windows.Forms.Panel()
        Me.panelbusqueda = New System.Windows.Forms.Panel()
        Me.Labelnomempresa = New System.Windows.Forms.Label()
        Me.labelcuentaempresa = New System.Windows.Forms.Label()
        Me.botonseleccionar = New System.Windows.Forms.Button()
        Me.cbnombreempresa = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panelcuerpo.SuspendLayout()
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
        'Panelcuerpo
        '
        Me.Panelcuerpo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panelcuerpo.Controls.Add(Me.panelbusqueda)
        Me.Panelcuerpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.4!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panelcuerpo.Location = New System.Drawing.Point(0, 93)
        Me.Panelcuerpo.Margin = New System.Windows.Forms.Padding(3, 3, 3, 2)
        Me.Panelcuerpo.Name = "Panelcuerpo"
        Me.Panelcuerpo.Size = New System.Drawing.Size(1582, 760)
        Me.Panelcuerpo.TabIndex = 1
        '
        'panelbusqueda
        '
        Me.panelbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelbusqueda.Controls.Add(Me.ComboBox1)
        Me.panelbusqueda.Controls.Add(Me.cbnombreempresa)
        Me.panelbusqueda.Controls.Add(Me.botonseleccionar)
        Me.panelbusqueda.Controls.Add(Me.labelcuentaempresa)
        Me.panelbusqueda.Controls.Add(Me.Labelnomempresa)
        Me.panelbusqueda.Location = New System.Drawing.Point(605, 103)
        Me.panelbusqueda.Name = "panelbusqueda"
        Me.panelbusqueda.Size = New System.Drawing.Size(429, 228)
        Me.panelbusqueda.TabIndex = 0
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
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboBox1.Location = New System.Drawing.Point(138, 71)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(268, 25)
        Me.ComboBox1.TabIndex = 3
        '
        'Gestionarmovimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1582, 853)
        Me.Controls.Add(Me.Panelcuerpo)
        Me.Controls.Add(Me.Panelencabezado)
        Me.Name = "Gestionarmovimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionarmovimiento"
        Me.Panelcuerpo.ResumeLayout(False)
        Me.panelbusqueda.ResumeLayout(False)
        Me.panelbusqueda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panelencabezado As Panel
    Friend WithEvents Panelcuerpo As Panel
    Friend WithEvents panelbusqueda As Panel
    Friend WithEvents Labelnomempresa As Label
    Friend WithEvents labelcuentaempresa As Label
    Friend WithEvents botonseleccionar As Button
    Friend WithEvents cbnombreempresa As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
