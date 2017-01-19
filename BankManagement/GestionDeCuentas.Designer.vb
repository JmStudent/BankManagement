<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionDeCuentas
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
        Me.lb_header = New System.Windows.Forms.Label()
        Me.pan_body = New System.Windows.Forms.Panel()
        Me.lb_transfer = New System.Windows.Forms.Label()
        Me.lb_cuentas = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lb_gestion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pan_header.SuspendLayout()
        Me.pan_body.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pan_header
        '
        Me.pan_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.pan_header.Controls.Add(Me.lb_header)
        Me.pan_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_header.Location = New System.Drawing.Point(0, 0)
        Me.pan_header.Name = "pan_header"
        Me.pan_header.Size = New System.Drawing.Size(919, 75)
        Me.pan_header.TabIndex = 0
        '
        'lb_header
        '
        Me.lb_header.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_header.AutoSize = True
        Me.lb_header.Enabled = False
        Me.lb_header.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_header.ForeColor = System.Drawing.Color.White
        Me.lb_header.Location = New System.Drawing.Point(255, 9)
        Me.lb_header.Name = "lb_header"
        Me.lb_header.Size = New System.Drawing.Size(417, 39)
        Me.lb_header.TabIndex = 0
        Me.lb_header.Text = "Banca Online 'Salesianos'"
        Me.lb_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pan_body
        '
        Me.pan_body.Controls.Add(Me.PictureBox1)
        Me.pan_body.Controls.Add(Me.lb_transfer)
        Me.pan_body.Controls.Add(Me.lb_cuentas)
        Me.pan_body.Controls.Add(Me.PictureBox2)
        Me.pan_body.Controls.Add(Me.lb_gestion)
        Me.pan_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pan_body.Location = New System.Drawing.Point(0, 75)
        Me.pan_body.Name = "pan_body"
        Me.pan_body.Size = New System.Drawing.Size(919, 432)
        Me.pan_body.TabIndex = 1
        '
        'lb_transfer
        '
        Me.lb_transfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_transfer.Location = New System.Drawing.Point(489, 296)
        Me.lb_transfer.Name = "lb_transfer"
        Me.lb_transfer.Size = New System.Drawing.Size(193, 16)
        Me.lb_transfer.TabIndex = 5
        Me.lb_transfer.Text = "REALIZAR TRANSFERENCIA"
        '
        'lb_cuentas
        '
        Me.lb_cuentas.AutoSize = True
        Me.lb_cuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_cuentas.Location = New System.Drawing.Point(308, 296)
        Me.lb_cuentas.Name = "lb_cuentas"
        Me.lb_cuentas.Size = New System.Drawing.Size(99, 16)
        Me.lb_cuentas.TabIndex = 4
        Me.lb_cuentas.Text = "MIS CUENTAS"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(492, 142)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(180, 141)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'lb_gestion
        '
        Me.lb_gestion.AutoSize = True
        Me.lb_gestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_gestion.Location = New System.Drawing.Point(335, 41)
        Me.lb_gestion.Name = "lb_gestion"
        Me.lb_gestion.Size = New System.Drawing.Size(272, 33)
        Me.lb_gestion.TabIndex = 0
        Me.lb_gestion.Text = "Gestión de Cuentas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(272, 142)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'GestionDeCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 507)
        Me.Controls.Add(Me.pan_body)
        Me.Controls.Add(Me.pan_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionDeCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion"
        Me.pan_header.ResumeLayout(False)
        Me.pan_header.PerformLayout()
        Me.pan_body.ResumeLayout(False)
        Me.pan_body.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pan_header As Panel
    Friend WithEvents pan_body As Panel
    Friend WithEvents lb_header As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lb_gestion As Label
    Friend WithEvents lb_transfer As Label
    Friend WithEvents lb_cuentas As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
