<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transferencias
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pan_header = New System.Windows.Forms.Panel()
        Me.lb_header = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb_cuanta_origen = New System.Windows.Forms.Label()
        Me.lb_empresa_destino = New System.Windows.Forms.Label()
        Me.lb_cuenta_destino = New System.Windows.Forms.Label()
        Me.lb_remitente = New System.Windows.Forms.Label()
        Me.lb_cantidad = New System.Windows.Forms.Label()
        Me.lb_concepto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pan_header.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pan_header
        '
        Me.pan_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.pan_header.Controls.Add(Me.lb_header)
        Me.pan_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_header.Location = New System.Drawing.Point(0, 0)
        Me.pan_header.Name = "pan_header"
        Me.pan_header.Size = New System.Drawing.Size(621, 75)
        Me.pan_header.TabIndex = 2
        '
        'lb_header
        '
        Me.lb_header.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_header.AutoSize = True
        Me.lb_header.Enabled = False
        Me.lb_header.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_header.ForeColor = System.Drawing.Color.White
        Me.lb_header.Location = New System.Drawing.Point(89, 19)
        Me.lb_header.Name = "lb_header"
        Me.lb_header.Size = New System.Drawing.Size(417, 39)
        Me.lb_header.TabIndex = 0
        Me.lb_header.Text = "Banca Online 'Salesianos'"
        Me.lb_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lb_concepto)
        Me.GroupBox1.Controls.Add(Me.lb_cantidad)
        Me.GroupBox1.Controls.Add(Me.lb_remitente)
        Me.GroupBox1.Controls.Add(Me.lb_cuenta_destino)
        Me.GroupBox1.Controls.Add(Me.lb_empresa_destino)
        Me.GroupBox1.Controls.Add(Me.lb_cuanta_origen)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(96, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 305)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Realizar Transferencia"
        '
        'lb_cuanta_origen
        '
        Me.lb_cuanta_origen.AutoSize = True
        Me.lb_cuanta_origen.Location = New System.Drawing.Point(17, 42)
        Me.lb_cuanta_origen.Name = "lb_cuanta_origen"
        Me.lb_cuanta_origen.Size = New System.Drawing.Size(112, 20)
        Me.lb_cuanta_origen.TabIndex = 0
        Me.lb_cuanta_origen.Text = "Cuenta Origen"
        '
        'lb_empresa_destino
        '
        Me.lb_empresa_destino.AutoSize = True
        Me.lb_empresa_destino.Location = New System.Drawing.Point(17, 78)
        Me.lb_empresa_destino.Name = "lb_empresa_destino"
        Me.lb_empresa_destino.Size = New System.Drawing.Size(132, 20)
        Me.lb_empresa_destino.TabIndex = 1
        Me.lb_empresa_destino.Text = "Empresa Destino"
        '
        'lb_cuenta_destino
        '
        Me.lb_cuenta_destino.AutoSize = True
        Me.lb_cuenta_destino.Location = New System.Drawing.Point(17, 114)
        Me.lb_cuenta_destino.Name = "lb_cuenta_destino"
        Me.lb_cuenta_destino.Size = New System.Drawing.Size(120, 20)
        Me.lb_cuenta_destino.TabIndex = 2
        Me.lb_cuenta_destino.Text = "Cuenta Destino"
        '
        'lb_remitente
        '
        Me.lb_remitente.AutoSize = True
        Me.lb_remitente.Location = New System.Drawing.Point(17, 150)
        Me.lb_remitente.Name = "lb_remitente"
        Me.lb_remitente.Size = New System.Drawing.Size(83, 20)
        Me.lb_remitente.TabIndex = 3
        Me.lb_remitente.Text = "Remitente"
        '
        'lb_cantidad
        '
        Me.lb_cantidad.AutoSize = True
        Me.lb_cantidad.Location = New System.Drawing.Point(17, 186)
        Me.lb_cantidad.Name = "lb_cantidad"
        Me.lb_cantidad.Size = New System.Drawing.Size(73, 20)
        Me.lb_cantidad.TabIndex = 4
        Me.lb_cantidad.Text = "Cantidad"
        '
        'lb_concepto
        '
        Me.lb_concepto.AutoSize = True
        Me.lb_concepto.Location = New System.Drawing.Point(17, 222)
        Me.lb_concepto.Name = "lb_concepto"
        Me.lb_concepto.Size = New System.Drawing.Size(78, 20)
        Me.lb_concepto.TabIndex = 5
        Me.lb_concepto.Text = "Concepto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Concepto Extendido"
        '
        'Transferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 452)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pan_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transferencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferencias"
        Me.pan_header.ResumeLayout(False)
        Me.pan_header.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pan_header As Panel
    Friend WithEvents lb_header As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_concepto As Label
    Friend WithEvents lb_cantidad As Label
    Friend WithEvents lb_remitente As Label
    Friend WithEvents lb_cuenta_destino As Label
    Friend WithEvents lb_empresa_destino As Label
    Friend WithEvents lb_cuanta_origen As Label
End Class
