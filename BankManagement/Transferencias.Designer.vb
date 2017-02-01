<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transferencias
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pan_header = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbconceptoextendido = New System.Windows.Forms.TextBox()
        Me.tbconcepto = New System.Windows.Forms.TextBox()
        Me.tbcantidad = New System.Windows.Forms.TextBox()
        Me.tbremitente = New System.Windows.Forms.TextBox()
        Me.cbcuentadestino = New System.Windows.Forms.ComboBox()
        Me.cbempresadestino = New System.Windows.Forms.ComboBox()
        Me.cbcuantaorigen = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_concepto = New System.Windows.Forms.Label()
        Me.lb_cantidad = New System.Windows.Forms.Label()
        Me.lb_remitente = New System.Windows.Forms.Label()
        Me.lb_cuenta_destino = New System.Windows.Forms.Label()
        Me.lb_empresa_destino = New System.Windows.Forms.Label()
        Me.lb_cuanta_origen = New System.Windows.Forms.Label()
        Me.btn_ = New System.Windows.Forms.Button()
        Me.pan_header.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pan_header
        '
        Me.pan_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.pan_header.Controls.Add(Me.PictureBox2)
        Me.pan_header.Controls.Add(Me.PictureBox3)
        Me.pan_header.Controls.Add(Me.PictureBox1)
        Me.pan_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_header.Location = New System.Drawing.Point(0, 0)
        Me.pan_header.Name = "pan_header"
        Me.pan_header.Size = New System.Drawing.Size(621, 75)
        Me.pan_header.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.BankManagement.My.Resources.Resources.backv2
        Me.PictureBox2.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.BankManagement.My.Resources.Resources.logov3
        Me.PictureBox3.Location = New System.Drawing.Point(117, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(396, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.BankManagement.My.Resources.Resources.closeIconv3
        Me.PictureBox1.Location = New System.Drawing.Point(573, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbconceptoextendido)
        Me.GroupBox1.Controls.Add(Me.tbconcepto)
        Me.GroupBox1.Controls.Add(Me.tbcantidad)
        Me.GroupBox1.Controls.Add(Me.tbremitente)
        Me.GroupBox1.Controls.Add(Me.cbcuentadestino)
        Me.GroupBox1.Controls.Add(Me.cbempresadestino)
        Me.GroupBox1.Controls.Add(Me.cbcuantaorigen)
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
        'tbconceptoextendido
        '
        Me.tbconceptoextendido.Location = New System.Drawing.Point(216, 252)
        Me.tbconceptoextendido.Name = "tbconceptoextendido"
        Me.tbconceptoextendido.Size = New System.Drawing.Size(211, 26)
        Me.tbconceptoextendido.TabIndex = 13
        '
        'tbconcepto
        '
        Me.tbconcepto.Location = New System.Drawing.Point(216, 216)
        Me.tbconcepto.Name = "tbconcepto"
        Me.tbconcepto.Size = New System.Drawing.Size(211, 26)
        Me.tbconcepto.TabIndex = 12
        '
        'tbcantidad
        '
        Me.tbcantidad.Location = New System.Drawing.Point(216, 181)
        Me.tbcantidad.Name = "tbcantidad"
        Me.tbcantidad.Size = New System.Drawing.Size(211, 26)
        Me.tbcantidad.TabIndex = 11
        '
        'tbremitente
        '
        Me.tbremitente.Location = New System.Drawing.Point(216, 149)
        Me.tbremitente.Name = "tbremitente"
        Me.tbremitente.Size = New System.Drawing.Size(211, 26)
        Me.tbremitente.TabIndex = 10
        '
        'cbcuentadestino
        '
        Me.cbcuentadestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcuentadestino.FormattingEnabled = True
        Me.cbcuentadestino.Location = New System.Drawing.Point(216, 106)
        Me.cbcuentadestino.Name = "cbcuentadestino"
        Me.cbcuentadestino.Size = New System.Drawing.Size(211, 28)
        Me.cbcuentadestino.TabIndex = 9
        '
        'cbempresadestino
        '
        Me.cbempresadestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbempresadestino.FormattingEnabled = True
        Me.cbempresadestino.Location = New System.Drawing.Point(216, 70)
        Me.cbempresadestino.Name = "cbempresadestino"
        Me.cbempresadestino.Size = New System.Drawing.Size(211, 28)
        Me.cbempresadestino.TabIndex = 8
        '
        'cbcuantaorigen
        '
        Me.cbcuantaorigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcuantaorigen.FormattingEnabled = True
        Me.cbcuantaorigen.Location = New System.Drawing.Point(216, 34)
        Me.cbcuantaorigen.Name = "cbcuantaorigen"
        Me.cbcuantaorigen.Size = New System.Drawing.Size(211, 28)
        Me.cbcuantaorigen.TabIndex = 7
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
        'lb_concepto
        '
        Me.lb_concepto.AutoSize = True
        Me.lb_concepto.Location = New System.Drawing.Point(17, 222)
        Me.lb_concepto.Name = "lb_concepto"
        Me.lb_concepto.Size = New System.Drawing.Size(78, 20)
        Me.lb_concepto.TabIndex = 5
        Me.lb_concepto.Text = "Concepto"
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
        'lb_remitente
        '
        Me.lb_remitente.AutoSize = True
        Me.lb_remitente.Location = New System.Drawing.Point(17, 150)
        Me.lb_remitente.Name = "lb_remitente"
        Me.lb_remitente.Size = New System.Drawing.Size(83, 20)
        Me.lb_remitente.TabIndex = 3
        Me.lb_remitente.Text = "Remitente"
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
        'lb_empresa_destino
        '
        Me.lb_empresa_destino.AutoSize = True
        Me.lb_empresa_destino.Location = New System.Drawing.Point(17, 78)
        Me.lb_empresa_destino.Name = "lb_empresa_destino"
        Me.lb_empresa_destino.Size = New System.Drawing.Size(132, 20)
        Me.lb_empresa_destino.TabIndex = 1
        Me.lb_empresa_destino.Text = "Empresa Destino"
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
        'btn_
        '
        Me.btn_.Location = New System.Drawing.Point(534, 433)
        Me.btn_.Name = "btn_"
        Me.btn_.Size = New System.Drawing.Size(75, 23)
        Me.btn_.TabIndex = 4
        Me.btn_.Text = "Realizar"
        Me.btn_.UseVisualStyleBackColor = True
        '
        'Transferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 468)
        Me.Controls.Add(Me.btn_)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pan_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transferencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferencias"
        Me.pan_header.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pan_header As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_concepto As Label
    Friend WithEvents lb_cantidad As Label
    Friend WithEvents lb_remitente As Label
    Friend WithEvents lb_cuenta_destino As Label
    Friend WithEvents lb_empresa_destino As Label
    Friend WithEvents lb_cuanta_origen As Label
    Friend WithEvents tbconceptoextendido As TextBox
    Friend WithEvents tbconcepto As TextBox
    Friend WithEvents tbcantidad As TextBox
    Friend WithEvents tbremitente As TextBox
    Friend WithEvents cbcuentadestino As ComboBox
    Friend WithEvents cbempresadestino As ComboBox
    Friend WithEvents cbcuantaorigen As ComboBox
    Friend WithEvents btn_ As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
