<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gestion
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
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pan_body = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lb_transfer = New System.Windows.Forms.Label()
        Me.lb_cuentas = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pan_header.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_body.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pan_header
        '
        Me.pan_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.pan_header.Controls.Add(Me.PictureBox5)
        Me.pan_header.Controls.Add(Me.PictureBox4)
        Me.pan_header.Controls.Add(Me.PictureBox3)
        Me.pan_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_header.Location = New System.Drawing.Point(0, 0)
        Me.pan_header.Name = "pan_header"
        Me.pan_header.Size = New System.Drawing.Size(768, 75)
        Me.pan_header.TabIndex = 0
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.BankManagement.My.Resources.Resources.logov3
        Me.PictureBox4.Location = New System.Drawing.Point(153, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(473, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.BankManagement.My.Resources.Resources.closeIconv3
        Me.PictureBox3.Location = New System.Drawing.Point(705, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'pan_body
        '
        Me.pan_body.Controls.Add(Me.GroupBox1)
        Me.pan_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pan_body.Location = New System.Drawing.Point(0, 75)
        Me.pan_body.Name = "pan_body"
        Me.pan_body.Size = New System.Drawing.Size(768, 382)
        Me.pan_body.TabIndex = 1
        '
        'PictureBox5
        '
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.BankManagement.My.Resources.Resources.backv2
        Me.PictureBox5.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(69, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'lb_transfer
        '
        Me.lb_transfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_transfer.Location = New System.Drawing.Point(244, 218)
        Me.lb_transfer.Name = "lb_transfer"
        Me.lb_transfer.Size = New System.Drawing.Size(193, 16)
        Me.lb_transfer.TabIndex = 5
        Me.lb_transfer.Text = "REALIZAR TRANSFERENCIA"
        '
        'lb_cuentas
        '
        Me.lb_cuentas.AutoSize = True
        Me.lb_cuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_cuentas.Location = New System.Drawing.Point(48, 218)
        Me.lb_cuentas.Name = "lb_cuentas"
        Me.lb_cuentas.Size = New System.Drawing.Size(99, 16)
        Me.lb_cuentas.TabIndex = 4
        Me.lb_cuentas.Text = "MIS CUENTAS"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.BankManagement.My.Resources.Resources.transfer
        Me.PictureBox2.Location = New System.Drawing.Point(257, 58)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(180, 141)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.BankManagement.My.Resources.Resources.account__1_
        Me.PictureBox1.Location = New System.Drawing.Point(19, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.lb_transfer)
        Me.GroupBox1.Controls.Add(Me.lb_cuentas)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(153, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(478, 269)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestión De Cuentas"
        '
        'Gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 457)
        Me.Controls.Add(Me.pan_body)
        Me.Controls.Add(Me.pan_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Gestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion"
        Me.pan_header.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_body.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pan_header As Panel
    Friend WithEvents pan_body As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lb_transfer As Label
    Friend WithEvents lb_cuentas As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
