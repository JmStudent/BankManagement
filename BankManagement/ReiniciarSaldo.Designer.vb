<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReiniciarSaldo
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
        Me.components = New System.ComponentModel.Container()
        Me.panHeader = New System.Windows.Forms.Panel()
        Me.pbBack = New System.Windows.Forms.PictureBox()
        Me.pbClose = New System.Windows.Forms.PictureBox()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.panBody = New System.Windows.Forms.Panel()
        Me.lblReiniciar = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.cbBanco = New System.Windows.Forms.ComboBox()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.lblRC = New System.Windows.Forms.Label()
        Me.pbContainer = New System.Windows.Forms.PictureBox()
        Me.epBanco = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epSaldo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.panHeader.SuspendLayout()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panBody.SuspendLayout()
        CType(Me.pbContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panHeader
        '
        Me.panHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.panHeader.Controls.Add(Me.pbBack)
        Me.panHeader.Controls.Add(Me.pbClose)
        Me.panHeader.Controls.Add(Me.pbLogo)
        Me.panHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panHeader.Location = New System.Drawing.Point(0, 0)
        Me.panHeader.Name = "panHeader"
        Me.panHeader.Size = New System.Drawing.Size(1600, 100)
        Me.panHeader.TabIndex = 0
        '
        'pbBack
        '
        Me.pbBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBack.Image = Global.BankManagement.My.Resources.Resources.backv2
        Me.pbBack.Location = New System.Drawing.Point(34, 16)
        Me.pbBack.Name = "pbBack"
        Me.pbBack.Size = New System.Drawing.Size(63, 63)
        Me.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBack.TabIndex = 4
        Me.pbBack.TabStop = False
        '
        'pbClose
        '
        Me.pbClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbClose.Image = Global.BankManagement.My.Resources.Resources.closeIconv3
        Me.pbClose.Location = New System.Drawing.Point(1516, 16)
        Me.pbClose.Name = "pbClose"
        Me.pbClose.Size = New System.Drawing.Size(63, 63)
        Me.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbClose.TabIndex = 3
        Me.pbClose.TabStop = False
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.BankManagement.My.Resources.Resources.logov3
        Me.pbLogo.Location = New System.Drawing.Point(544, 16)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(500, 63)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbLogo.TabIndex = 1
        Me.pbLogo.TabStop = False
        '
        'panBody
        '
        Me.panBody.BackColor = System.Drawing.Color.White
        Me.panBody.Controls.Add(Me.lblReiniciar)
        Me.panBody.Controls.Add(Me.txtSaldo)
        Me.panBody.Controls.Add(Me.lblSaldo)
        Me.panBody.Controls.Add(Me.cbBanco)
        Me.panBody.Controls.Add(Me.lblBanco)
        Me.panBody.Controls.Add(Me.lblRC)
        Me.panBody.Controls.Add(Me.pbContainer)
        Me.panBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panBody.Location = New System.Drawing.Point(0, 100)
        Me.panBody.Name = "panBody"
        Me.panBody.Size = New System.Drawing.Size(1600, 800)
        Me.panBody.TabIndex = 1
        '
        'lblReiniciar
        '
        Me.lblReiniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.lblReiniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReiniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReiniciar.ForeColor = System.Drawing.Color.White
        Me.lblReiniciar.Location = New System.Drawing.Point(425, 512)
        Me.lblReiniciar.Name = "lblReiniciar"
        Me.lblReiniciar.Size = New System.Drawing.Size(718, 160)
        Me.lblReiniciar.TabIndex = 28
        Me.lblReiniciar.Text = "REINICIAR SALDO"
        Me.lblReiniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSaldo
        '
        Me.txtSaldo.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.txtSaldo.Location = New System.Drawing.Point(722, 341)
        Me.txtSaldo.MaxLength = 15
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(421, 76)
        Me.txtSaldo.TabIndex = 14
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblSaldo.Location = New System.Drawing.Point(413, 347)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(214, 70)
        Me.lblSaldo.TabIndex = 13
        Me.lblSaldo.Text = "Saldo:"
        Me.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbBanco
        '
        Me.cbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBanco.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.cbBanco.FormattingEnabled = True
        Me.cbBanco.Location = New System.Drawing.Point(722, 177)
        Me.cbBanco.Name = "cbBanco"
        Me.cbBanco.Size = New System.Drawing.Size(421, 78)
        Me.cbBanco.TabIndex = 5
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblBanco.Location = New System.Drawing.Point(413, 185)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(233, 70)
        Me.lblBanco.TabIndex = 4
        Me.lblBanco.Text = "Banco:"
        Me.lblBanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRC
        '
        Me.lblRC.AutoSize = True
        Me.lblRC.Font = New System.Drawing.Font("Arial", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblRC.Location = New System.Drawing.Point(222, 60)
        Me.lblRC.Name = "lblRC"
        Me.lblRC.Size = New System.Drawing.Size(411, 51)
        Me.lblRC.TabIndex = 3
        Me.lblRC.Text = "REINICIAR SALDO"
        Me.lblRC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbContainer
        '
        Me.pbContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbContainer.Location = New System.Drawing.Point(160, 89)
        Me.pbContainer.Name = "pbContainer"
        Me.pbContainer.Size = New System.Drawing.Size(1281, 623)
        Me.pbContainer.TabIndex = 1
        Me.pbContainer.TabStop = False
        '
        'epBanco
        '
        Me.epBanco.ContainerControl = Me
        '
        'epSaldo
        '
        Me.epSaldo.ContainerControl = Me
        '
        'ReiniciarSaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.panBody)
        Me.Controls.Add(Me.panHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReiniciarSaldo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReiniciarSaldo"
        Me.panHeader.ResumeLayout(False)
        Me.panHeader.PerformLayout()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panBody.ResumeLayout(False)
        Me.panBody.PerformLayout()
        CType(Me.pbContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panHeader As Panel
    Friend WithEvents panBody As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents pbClose As PictureBox
    Friend WithEvents pbBack As PictureBox
    Friend WithEvents pbContainer As PictureBox
    Friend WithEvents lblRC As Label
    Friend WithEvents lblBanco As Label
    Friend WithEvents cbBanco As ComboBox
    Friend WithEvents lblSaldo As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents lblReiniciar As Label
    Friend WithEvents epBanco As ErrorProvider
    Friend WithEvents epSaldo As ErrorProvider
End Class
