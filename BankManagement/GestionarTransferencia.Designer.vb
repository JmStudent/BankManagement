<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarTransferencia
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
        Me.txtConEx = New System.Windows.Forms.TextBox()
        Me.lblConEx = New System.Windows.Forms.Label()
        Me.chbDom = New System.Windows.Forms.CheckBox()
        Me.lblDom = New System.Windows.Forms.Label()
        Me.cbConcepto = New System.Windows.Forms.ComboBox()
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.cbPer = New System.Windows.Forms.ComboBox()
        Me.lblPer = New System.Windows.Forms.Label()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.txtRem = New System.Windows.Forms.TextBox()
        Me.lblRem = New System.Windows.Forms.Label()
        Me.cbCD = New System.Windows.Forms.ComboBox()
        Me.lblCD = New System.Windows.Forms.Label()
        Me.cbED = New System.Windows.Forms.ComboBox()
        Me.lblED = New System.Windows.Forms.Label()
        Me.cbCO = New System.Windows.Forms.ComboBox()
        Me.lblCO = New System.Windows.Forms.Label()
        Me.cbEO = New System.Windows.Forms.ComboBox()
        Me.lblEO = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbMake = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClean = New System.Windows.Forms.Label()
        Me.pbRefresh = New System.Windows.Forms.PictureBox()
        Me.epCD = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.panHeader.SuspendLayout()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panBody.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbMake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epCD, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pbBack.TabIndex = 2
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
        Me.pbClose.TabIndex = 1
        Me.pbClose.TabStop = False
        '
        'pbLogo
        '
        Me.pbLogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbLogo.Image = Global.BankManagement.My.Resources.Resources.logov3
        Me.pbLogo.Location = New System.Drawing.Point(544, 16)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(500, 63)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'panBody
        '
        Me.panBody.BackColor = System.Drawing.Color.White
        Me.panBody.Controls.Add(Me.txtConEx)
        Me.panBody.Controls.Add(Me.lblConEx)
        Me.panBody.Controls.Add(Me.chbDom)
        Me.panBody.Controls.Add(Me.lblDom)
        Me.panBody.Controls.Add(Me.cbConcepto)
        Me.panBody.Controls.Add(Me.lblConcepto)
        Me.panBody.Controls.Add(Me.dtpDate)
        Me.panBody.Controls.Add(Me.lblDate)
        Me.panBody.Controls.Add(Me.cbPer)
        Me.panBody.Controls.Add(Me.lblPer)
        Me.panBody.Controls.Add(Me.txtCant)
        Me.panBody.Controls.Add(Me.lblCant)
        Me.panBody.Controls.Add(Me.txtRem)
        Me.panBody.Controls.Add(Me.lblRem)
        Me.panBody.Controls.Add(Me.cbCD)
        Me.panBody.Controls.Add(Me.lblCD)
        Me.panBody.Controls.Add(Me.cbED)
        Me.panBody.Controls.Add(Me.lblED)
        Me.panBody.Controls.Add(Me.cbCO)
        Me.panBody.Controls.Add(Me.lblCO)
        Me.panBody.Controls.Add(Me.cbEO)
        Me.panBody.Controls.Add(Me.lblEO)
        Me.panBody.Controls.Add(Me.Panel1)
        Me.panBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panBody.Location = New System.Drawing.Point(0, 100)
        Me.panBody.Name = "panBody"
        Me.panBody.Size = New System.Drawing.Size(1600, 800)
        Me.panBody.TabIndex = 1
        '
        'txtConEx
        '
        Me.txtConEx.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConEx.Location = New System.Drawing.Point(867, 514)
        Me.txtConEx.MaxLength = 100
        Me.txtConEx.Multiline = True
        Me.txtConEx.Name = "txtConEx"
        Me.txtConEx.Size = New System.Drawing.Size(605, 134)
        Me.txtConEx.TabIndex = 22
        '
        'lblConEx
        '
        Me.lblConEx.AutoSize = True
        Me.lblConEx.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConEx.Location = New System.Drawing.Point(860, 453)
        Me.lblConEx.Name = "lblConEx"
        Me.lblConEx.Size = New System.Drawing.Size(336, 37)
        Me.lblConEx.TabIndex = 21
        Me.lblConEx.Text = "Concepto Extendido:"
        Me.lblConEx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chbDom
        '
        Me.chbDom.AutoSize = True
        Me.chbDom.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbDom.Location = New System.Drawing.Point(1245, 387)
        Me.chbDom.Name = "chbDom"
        Me.chbDom.Size = New System.Drawing.Size(22, 21)
        Me.chbDom.TabIndex = 20
        Me.chbDom.UseVisualStyleBackColor = True
        '
        'lblDom
        '
        Me.lblDom.AutoSize = True
        Me.lblDom.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDom.Location = New System.Drawing.Point(860, 374)
        Me.lblDom.Name = "lblDom"
        Me.lblDom.Size = New System.Drawing.Size(356, 37)
        Me.lblDom.TabIndex = 19
        Me.lblDom.Text = "Domiciliación Masiva:"
        Me.lblDom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbConcepto
        '
        Me.cbConcepto.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbConcepto.FormattingEnabled = True
        Me.cbConcepto.Location = New System.Drawing.Point(1162, 280)
        Me.cbConcepto.Name = "cbConcepto"
        Me.cbConcepto.Size = New System.Drawing.Size(310, 38)
        Me.cbConcepto.TabIndex = 18
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcepto.Location = New System.Drawing.Point(860, 276)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(173, 37)
        Me.lblConcepto.TabIndex = 17
        Me.lblConcepto.Text = "Concepto:"
        Me.lblConcepto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.dtpDate.Location = New System.Drawing.Point(1162, 175)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(310, 37)
        Me.dtpDate.TabIndex = 16
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(860, 176)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(120, 37)
        Me.lblDate.TabIndex = 15
        Me.lblDate.Text = "Fecha:"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbPer
        '
        Me.cbPer.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPer.FormattingEnabled = True
        Me.cbPer.Location = New System.Drawing.Point(1162, 78)
        Me.cbPer.Name = "cbPer"
        Me.cbPer.Size = New System.Drawing.Size(310, 38)
        Me.cbPer.TabIndex = 14
        '
        'lblPer
        '
        Me.lblPer.AutoSize = True
        Me.lblPer.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPer.Location = New System.Drawing.Point(860, 75)
        Me.lblPer.Name = "lblPer"
        Me.lblPer.Size = New System.Drawing.Size(172, 37)
        Me.lblPer.TabIndex = 13
        Me.lblPer.Text = "Periódica:"
        Me.lblPer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCant
        '
        Me.txtCant.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant.Location = New System.Drawing.Point(431, 578)
        Me.txtCant.MaxLength = 15
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(310, 37)
        Me.txtCant.TabIndex = 12
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblCant.Location = New System.Drawing.Point(92, 578)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(164, 37)
        Me.lblCant.TabIndex = 11
        Me.lblCant.Text = "Cantidad:"
        Me.lblCant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRem
        '
        Me.txtRem.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRem.Location = New System.Drawing.Point(431, 478)
        Me.txtRem.MaxLength = 50
        Me.txtRem.Name = "txtRem"
        Me.txtRem.Size = New System.Drawing.Size(310, 37)
        Me.txtRem.TabIndex = 10
        '
        'lblRem
        '
        Me.lblRem.AutoSize = True
        Me.lblRem.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblRem.Location = New System.Drawing.Point(92, 478)
        Me.lblRem.Name = "lblRem"
        Me.lblRem.Size = New System.Drawing.Size(182, 37)
        Me.lblRem.TabIndex = 9
        Me.lblRem.Text = "Remitente:"
        Me.lblRem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbCD
        '
        Me.cbCD.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCD.FormattingEnabled = True
        Me.cbCD.Location = New System.Drawing.Point(431, 377)
        Me.cbCD.Name = "cbCD"
        Me.cbCD.Size = New System.Drawing.Size(310, 38)
        Me.cbCD.TabIndex = 8
        '
        'lblCD
        '
        Me.lblCD.AutoSize = True
        Me.lblCD.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblCD.Location = New System.Drawing.Point(92, 378)
        Me.lblCD.Name = "lblCD"
        Me.lblCD.Size = New System.Drawing.Size(262, 37)
        Me.lblCD.TabIndex = 7
        Me.lblCD.Text = "Cuenta Destino:"
        Me.lblCD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbED
        '
        Me.cbED.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbED.FormattingEnabled = True
        Me.cbED.Location = New System.Drawing.Point(431, 276)
        Me.cbED.Name = "cbED"
        Me.cbED.Size = New System.Drawing.Size(310, 38)
        Me.cbED.TabIndex = 6
        '
        'lblED
        '
        Me.lblED.AutoSize = True
        Me.lblED.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblED.Location = New System.Drawing.Point(92, 277)
        Me.lblED.Name = "lblED"
        Me.lblED.Size = New System.Drawing.Size(289, 37)
        Me.lblED.TabIndex = 5
        Me.lblED.Text = "Empresa Destino:"
        Me.lblED.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbCO
        '
        Me.cbCO.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCO.FormattingEnabled = True
        Me.cbCO.Location = New System.Drawing.Point(431, 175)
        Me.cbCO.Name = "cbCO"
        Me.cbCO.Size = New System.Drawing.Size(310, 38)
        Me.cbCO.TabIndex = 4
        '
        'lblCO
        '
        Me.lblCO.AutoSize = True
        Me.lblCO.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblCO.Location = New System.Drawing.Point(92, 176)
        Me.lblCO.Name = "lblCO"
        Me.lblCO.Size = New System.Drawing.Size(247, 37)
        Me.lblCO.TabIndex = 3
        Me.lblCO.Text = "Cuenta Origen:"
        Me.lblCO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbEO
        '
        Me.cbEO.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEO.FormattingEnabled = True
        Me.cbEO.Location = New System.Drawing.Point(431, 74)
        Me.cbEO.Name = "cbEO"
        Me.cbEO.Size = New System.Drawing.Size(310, 38)
        Me.cbEO.TabIndex = 2
        '
        'lblEO
        '
        Me.lblEO.AutoSize = True
        Me.lblEO.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEO.Location = New System.Drawing.Point(92, 75)
        Me.lblEO.Name = "lblEO"
        Me.lblEO.Size = New System.Drawing.Size(274, 37)
        Me.lblEO.TabIndex = 1
        Me.lblEO.Text = "Empresa Origen:"
        Me.lblEO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.pbMake)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblClean)
        Me.Panel1.Controls.Add(Me.pbRefresh)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 700)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1600, 100)
        Me.Panel1.TabIndex = 0
        '
        'pbMake
        '
        Me.pbMake.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbMake.Image = Global.BankManagement.My.Resources.Resources.transferv1
        Me.pbMake.Location = New System.Drawing.Point(1391, 7)
        Me.pbMake.Name = "pbMake"
        Me.pbMake.Size = New System.Drawing.Size(80, 80)
        Me.pbMake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMake.TabIndex = 25
        Me.pbMake.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(1129, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 51)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "REALIZAR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClean
        '
        Me.lblClean.AutoSize = True
        Me.lblClean.Font = New System.Drawing.Font("Arial", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblClean.Location = New System.Drawing.Point(677, 23)
        Me.lblClean.Name = "lblClean"
        Me.lblClean.Size = New System.Drawing.Size(202, 51)
        Me.lblClean.TabIndex = 23
        Me.lblClean.Text = "LIMPIAR"
        Me.lblClean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbRefresh
        '
        Me.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRefresh.Image = Global.BankManagement.My.Resources.Resources.refreshv3
        Me.pbRefresh.Location = New System.Drawing.Point(899, 7)
        Me.pbRefresh.Name = "pbRefresh"
        Me.pbRefresh.Size = New System.Drawing.Size(80, 80)
        Me.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRefresh.TabIndex = 0
        Me.pbRefresh.TabStop = False
        '
        'epCD
        '
        Me.epCD.ContainerControl = Me
        '
        'GestionarTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.panBody)
        Me.Controls.Add(Me.panHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionarTransferencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionarMovimiento"
        Me.panHeader.ResumeLayout(False)
        Me.panHeader.PerformLayout()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panBody.ResumeLayout(False)
        Me.panBody.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbMake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epCD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panHeader As Panel
    Friend WithEvents panBody As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents pbClose As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbBack As PictureBox
    Friend WithEvents lblEO As Label
    Friend WithEvents cbEO As ComboBox
    Friend WithEvents lblCant As Label
    Friend WithEvents txtRem As TextBox
    Friend WithEvents lblRem As Label
    Friend WithEvents cbCD As ComboBox
    Friend WithEvents lblCD As Label
    Friend WithEvents cbED As ComboBox
    Friend WithEvents lblED As Label
    Friend WithEvents cbCO As ComboBox
    Friend WithEvents lblCO As Label
    Friend WithEvents txtCant As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents cbPer As ComboBox
    Friend WithEvents lblPer As Label
    Friend WithEvents chbDom As CheckBox
    Friend WithEvents lblDom As Label
    Friend WithEvents cbConcepto As ComboBox
    Friend WithEvents lblConcepto As Label
    Friend WithEvents lblConEx As Label
    Friend WithEvents txtConEx As TextBox
    Friend WithEvents pbRefresh As PictureBox
    Friend WithEvents lblClean As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pbMake As PictureBox
    Friend WithEvents epCD As ErrorProvider
End Class
