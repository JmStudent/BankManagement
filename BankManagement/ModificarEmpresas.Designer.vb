<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarEmpresas
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btmodificar = New System.Windows.Forms.Button()
        Me.cbcuenta2 = New System.Windows.Forms.ComboBox()
        Me.lbcuenta2 = New System.Windows.Forms.Label()
        Me.cbcuenta1 = New System.Windows.Forms.ComboBox()
        Me.lbcuenta1 = New System.Windows.Forms.Label()
        Me.cbactiva = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbdomicilio = New System.Windows.Forms.TextBox()
        Me.lbdomicilio = New System.Windows.Forms.Label()
        Me.tbcif = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbempresas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.pan_header.TabIndex = 3
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
        Me.PictureBox1.Location = New System.Drawing.Point(559, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btmodificar)
        Me.GroupBox1.Controls.Add(Me.cbcuenta2)
        Me.GroupBox1.Controls.Add(Me.lbcuenta2)
        Me.GroupBox1.Controls.Add(Me.cbcuenta1)
        Me.GroupBox1.Controls.Add(Me.lbcuenta1)
        Me.GroupBox1.Controls.Add(Me.cbactiva)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbdomicilio)
        Me.GroupBox1.Controls.Add(Me.lbdomicilio)
        Me.GroupBox1.Controls.Add(Me.tbcif)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbempresas)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(117, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 423)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modificar Empresas"
        '
        'btmodificar
        '
        Me.btmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmodificar.Location = New System.Drawing.Point(288, 367)
        Me.btmodificar.Name = "btmodificar"
        Me.btmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btmodificar.TabIndex = 14
        Me.btmodificar.Text = "Modificar"
        Me.btmodificar.UseVisualStyleBackColor = True
        '
        'cbcuenta2
        '
        Me.cbcuenta2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcuenta2.FormattingEnabled = True
        Me.cbcuenta2.Location = New System.Drawing.Point(147, 303)
        Me.cbcuenta2.Name = "cbcuenta2"
        Me.cbcuenta2.Size = New System.Drawing.Size(234, 32)
        Me.cbcuenta2.TabIndex = 13
        '
        'lbcuenta2
        '
        Me.lbcuenta2.AutoSize = True
        Me.lbcuenta2.Location = New System.Drawing.Point(10, 311)
        Me.lbcuenta2.Name = "lbcuenta2"
        Me.lbcuenta2.Size = New System.Drawing.Size(108, 24)
        Me.lbcuenta2.TabIndex = 12
        Me.lbcuenta2.Text = "Cuenta nº2:"
        '
        'cbcuenta1
        '
        Me.cbcuenta1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcuenta1.FormattingEnabled = True
        Me.cbcuenta1.Location = New System.Drawing.Point(147, 252)
        Me.cbcuenta1.Name = "cbcuenta1"
        Me.cbcuenta1.Size = New System.Drawing.Size(234, 32)
        Me.cbcuenta1.TabIndex = 11
        '
        'lbcuenta1
        '
        Me.lbcuenta1.AutoSize = True
        Me.lbcuenta1.Location = New System.Drawing.Point(10, 260)
        Me.lbcuenta1.Name = "lbcuenta1"
        Me.lbcuenta1.Size = New System.Drawing.Size(108, 24)
        Me.lbcuenta1.TabIndex = 10
        Me.lbcuenta1.Text = "Cuenta nº1:"
        '
        'cbactiva
        '
        Me.cbactiva.AutoSize = True
        Me.cbactiva.Location = New System.Drawing.Point(147, 222)
        Me.cbactiva.Name = "cbactiva"
        Me.cbactiva.Size = New System.Drawing.Size(15, 14)
        Me.cbactiva.TabIndex = 9
        Me.cbactiva.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Activar"
        '
        'tbdomicilio
        '
        Me.tbdomicilio.Location = New System.Drawing.Point(147, 159)
        Me.tbdomicilio.MaxLength = 150
        Me.tbdomicilio.Name = "tbdomicilio"
        Me.tbdomicilio.Size = New System.Drawing.Size(234, 29)
        Me.tbdomicilio.TabIndex = 7
        '
        'lbdomicilio
        '
        Me.lbdomicilio.AutoSize = True
        Me.lbdomicilio.Location = New System.Drawing.Point(10, 164)
        Me.lbdomicilio.Name = "lbdomicilio"
        Me.lbdomicilio.Size = New System.Drawing.Size(87, 24)
        Me.lbdomicilio.TabIndex = 6
        Me.lbdomicilio.Text = "Domicilio"
        '
        'tbcif
        '
        Me.tbcif.Location = New System.Drawing.Point(147, 101)
        Me.tbcif.Name = "tbcif"
        Me.tbcif.ReadOnly = True
        Me.tbcif.Size = New System.Drawing.Size(234, 29)
        Me.tbcif.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CIF"
        '
        'cbempresas
        '
        Me.cbempresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbempresas.FormattingEnabled = True
        Me.cbempresas.Location = New System.Drawing.Point(147, 47)
        Me.cbempresas.Name = "cbempresas"
        Me.cbempresas.Size = New System.Drawing.Size(234, 32)
        Me.cbempresas.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empresas"
        '
        'ModificarEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(621, 592)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pan_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarEmpresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificarEmpresas"
        Me.pan_header.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pan_header As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbdomicilio As TextBox
    Friend WithEvents lbdomicilio As Label
    Friend WithEvents tbcif As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbempresas As ComboBox
    Friend WithEvents btmodificar As Button
    Friend WithEvents cbcuenta2 As ComboBox
    Friend WithEvents lbcuenta2 As Label
    Friend WithEvents cbcuenta1 As ComboBox
    Friend WithEvents lbcuenta1 As Label
    Friend WithEvents cbactiva As CheckBox
    Friend WithEvents Label4 As Label
End Class
