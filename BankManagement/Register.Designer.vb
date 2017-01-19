<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
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
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.panBody = New System.Windows.Forms.Panel()
        Me.epCif = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epName = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epAddress = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.panHeader.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epCif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panHeader
        '
        Me.panHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.panHeader.Controls.Add(Me.pbLogo)
        Me.panHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panHeader.Location = New System.Drawing.Point(0, 0)
        Me.panHeader.Name = "panHeader"
        Me.panHeader.Size = New System.Drawing.Size(1600, 116)
        Me.panHeader.TabIndex = 0
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
        Me.pbLogo.TabIndex = 1
        Me.pbLogo.TabStop = False
        '
        'panBody
        '
        Me.panBody.BackColor = System.Drawing.Color.White
        Me.panBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panBody.Location = New System.Drawing.Point(0, 116)
        Me.panBody.Name = "panBody"
        Me.panBody.Size = New System.Drawing.Size(1600, 784)
        Me.panBody.TabIndex = 1
        '
        'epCif
        '
        Me.epCif.ContainerControl = Me
        '
        'epName
        '
        Me.epName.ContainerControl = Me
        '
        'epAddress
        '
        Me.epAddress.ContainerControl = Me
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.panBody)
        Me.Controls.Add(Me.panHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.panHeader.ResumeLayout(False)
        Me.panHeader.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epCif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panHeader As Panel
    Friend WithEvents panBody As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents epCif As ErrorProvider
    Friend WithEvents epName As ErrorProvider
    Friend WithEvents epAddress As ErrorProvider
End Class
