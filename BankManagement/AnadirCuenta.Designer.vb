<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnadirCuenta
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
        Me.components = New System.ComponentModel.Container()
        Me.panHeader = New System.Windows.Forms.Panel()
        Me.panBody = New System.Windows.Forms.Panel()
        Me.lblAC = New System.Windows.Forms.Label()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.cbBanco = New System.Windows.Forms.ComboBox()
        Me.lblOficina = New System.Windows.Forms.Label()
        Me.txtOficina = New System.Windows.Forms.TextBox()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.cbCantidad = New System.Windows.Forms.ComboBox()
        Me.pbMake = New System.Windows.Forms.PictureBox()
        Me.pbRefresh = New System.Windows.Forms.PictureBox()
        Me.pbContainer = New System.Windows.Forms.PictureBox()
        Me.pbClose = New System.Windows.Forms.PictureBox()
        Me.pbBack = New System.Windows.Forms.PictureBox()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.epBanco = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epOficina = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epSaldo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epCantidad = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.panHeader.SuspendLayout()
        Me.panBody.SuspendLayout()
        CType(Me.pbMake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epOficina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panHeader
        '
        Me.panHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.panHeader.Controls.Add(Me.pbClose)
        Me.panHeader.Controls.Add(Me.pbBack)
        Me.panHeader.Controls.Add(Me.pbLogo)
        Me.panHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panHeader.Location = New System.Drawing.Point(0, 0)
        Me.panHeader.Name = "panHeader"
        Me.panHeader.Size = New System.Drawing.Size(1600, 100)
        Me.panHeader.TabIndex = 0
        '
        'panBody
        '
        Me.panBody.BackColor = System.Drawing.Color.White
        Me.panBody.Controls.Add(Me.pbMake)
        Me.panBody.Controls.Add(Me.pbRefresh)
        Me.panBody.Controls.Add(Me.cbCantidad)
        Me.panBody.Controls.Add(Me.lblCantidad)
        Me.panBody.Controls.Add(Me.txtSaldo)
        Me.panBody.Controls.Add(Me.lblSaldo)
        Me.panBody.Controls.Add(Me.txtOficina)
        Me.panBody.Controls.Add(Me.lblOficina)
        Me.panBody.Controls.Add(Me.cbBanco)
        Me.panBody.Controls.Add(Me.lblBanco)
        Me.panBody.Controls.Add(Me.lblAC)
        Me.panBody.Controls.Add(Me.pbContainer)
        Me.panBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panBody.Location = New System.Drawing.Point(0, 100)
        Me.panBody.Name = "panBody"
        Me.panBody.Size = New System.Drawing.Size(1600, 800)
        Me.panBody.TabIndex = 1
        '
        'lblAC
        '
        Me.lblAC.AutoSize = True
        Me.lblAC.Font = New System.Drawing.Font("Arial", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblAC.Location = New System.Drawing.Point(222, 60)
        Me.lblAC.Name = "lblAC"
        Me.lblAC.Size = New System.Drawing.Size(425, 51)
        Me.lblAC.TabIndex = 2
        Me.lblAC.Text = "AÑADIR CUENTA/S"
        Me.lblAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanco.Location = New System.Drawing.Point(224, 196)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(123, 37)
        Me.lblBanco.TabIndex = 3
        Me.lblBanco.Text = "Banco:"
        Me.lblBanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbBanco
        '
        Me.cbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBanco.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBanco.FormattingEnabled = True
        Me.cbBanco.Location = New System.Drawing.Point(430, 200)
        Me.cbBanco.Name = "cbBanco"
        Me.cbBanco.Size = New System.Drawing.Size(310, 38)
        Me.cbBanco.TabIndex = 4
        '
        'lblOficina
        '
        Me.lblOficina.AutoSize = True
        Me.lblOficina.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOficina.Location = New System.Drawing.Point(224, 387)
        Me.lblOficina.Name = "lblOficina"
        Me.lblOficina.Size = New System.Drawing.Size(137, 37)
        Me.lblOficina.TabIndex = 5
        Me.lblOficina.Text = "Oficina:"
        Me.lblOficina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOficina
        '
        Me.txtOficina.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOficina.Location = New System.Drawing.Point(430, 390)
        Me.txtOficina.MaxLength = 50
        Me.txtOficina.Name = "txtOficina"
        Me.txtOficina.Size = New System.Drawing.Size(310, 37)
        Me.txtOficina.TabIndex = 11
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.Location = New System.Drawing.Point(846, 196)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(114, 37)
        Me.lblSaldo.TabIndex = 12
        Me.lblSaldo.Text = "Saldo:"
        Me.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSaldo
        '
        Me.txtSaldo.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(1078, 200)
        Me.txtSaldo.MaxLength = 50
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(310, 37)
        Me.txtSaldo.TabIndex = 13
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(846, 390)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(164, 37)
        Me.lblCantidad.TabIndex = 14
        Me.lblCantidad.Text = "Cantidad:"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbCantidad
        '
        Me.cbCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCantidad.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCantidad.FormattingEnabled = True
        Me.cbCantidad.Location = New System.Drawing.Point(1078, 390)
        Me.cbCantidad.Name = "cbCantidad"
        Me.cbCantidad.Size = New System.Drawing.Size(310, 38)
        Me.cbCantidad.TabIndex = 15
        '
        'pbMake
        '
        Me.pbMake.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbMake.Image = Global.BankManagement.My.Resources.Resources.addv2
        Me.pbMake.Location = New System.Drawing.Point(853, 516)
        Me.pbMake.Name = "pbMake"
        Me.pbMake.Size = New System.Drawing.Size(160, 160)
        Me.pbMake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMake.TabIndex = 26
        Me.pbMake.TabStop = False
        '
        'pbRefresh
        '
        Me.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRefresh.Image = Global.BankManagement.My.Resources.Resources.refreshv3
        Me.pbRefresh.Location = New System.Drawing.Point(544, 516)
        Me.pbRefresh.Name = "pbRefresh"
        Me.pbRefresh.Size = New System.Drawing.Size(160, 160)
        Me.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRefresh.TabIndex = 17
        Me.pbRefresh.TabStop = False
        '
        'pbContainer
        '
        Me.pbContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbContainer.Location = New System.Drawing.Point(184, 85)
        Me.pbContainer.Name = "pbContainer"
        Me.pbContainer.Size = New System.Drawing.Size(1281, 623)
        Me.pbContainer.TabIndex = 0
        Me.pbContainer.TabStop = False
        '
        'pbClose
        '
        Me.pbClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbClose.Image = Global.BankManagement.My.Resources.Resources.closeIconv3
        Me.pbClose.Location = New System.Drawing.Point(1516, 16)
        Me.pbClose.Name = "pbClose"
        Me.pbClose.Size = New System.Drawing.Size(63, 63)
        Me.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbClose.TabIndex = 2
        Me.pbClose.TabStop = False
        '
        'pbBack
        '
        Me.pbBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBack.Image = Global.BankManagement.My.Resources.Resources.backv2
        Me.pbBack.Location = New System.Drawing.Point(34, 16)
        Me.pbBack.Name = "pbBack"
        Me.pbBack.Size = New System.Drawing.Size(63, 63)
        Me.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBack.TabIndex = 1
        Me.pbBack.TabStop = False
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.BankManagement.My.Resources.Resources.logov3
        Me.pbLogo.Location = New System.Drawing.Point(544, 16)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(500, 63)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'AnadirCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.panBody)
        Me.Controls.Add(Me.panHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AnadirCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AnadirCuenta"
        Me.panHeader.ResumeLayout(False)
        Me.panHeader.PerformLayout()
        Me.panBody.ResumeLayout(False)
        Me.panBody.PerformLayout()
        CType(Me.pbMake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epOficina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panHeader As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents pbClose As PictureBox
    Friend WithEvents pbBack As PictureBox
    Friend WithEvents panBody As Panel
    Friend WithEvents pbContainer As PictureBox
    Friend WithEvents lblAC As Label
    Friend WithEvents lblBanco As Label
    Friend WithEvents lblOficina As Label
    Friend WithEvents cbBanco As ComboBox
    Friend WithEvents lblSaldo As Label
    Friend WithEvents txtOficina As TextBox
    Friend WithEvents cbCantidad As ComboBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents pbRefresh As PictureBox
    Friend WithEvents pbMake As PictureBox
    Friend WithEvents epBanco As ErrorProvider
    Friend WithEvents epOficina As ErrorProvider
    Friend WithEvents epSaldo As ErrorProvider
    Friend WithEvents epCantidad As ErrorProvider
End Class
