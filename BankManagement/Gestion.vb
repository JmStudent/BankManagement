Public Class Gestion


    Sub New()


        InitializeComponent()


        AddHandler pan_header.MouseDown, New MouseEventHandler(AddressOf ctl_MouseDown)
        AddHandler pan_header.MouseMove, New MouseEventHandler(AddressOf ctl_MouseMove)
        AddHandler pan_header.MouseUp, New MouseEventHandler(AddressOf ctl_MouseUp)

    End Sub

    Private m_WindowState As FormWindowState = FormWindowState.Normal
    Private m_MousePressed As Boolean = False
    Private m_oldX As Integer, my_oldY As Integer

    Private Sub ctl_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim TS As Point = Me.PointToScreen(e.Location)
        m_oldX = TS.X
        my_oldY = TS.Y
        m_MousePressed = True
    End Sub

    Private Sub ctl_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        m_MousePressed = False
    End Sub



    Private Sub ctl_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)

        If m_MousePressed = True AndAlso m_WindowState <> FormWindowState.Maximized Then
            Dim TS As Point = Me.PointToScreen(e.Location)

            Me.Location = New Point(Me.Location.X + (TS.X - m_oldX), Me.Location.Y + (TS.Y - my_oldY))
            m_oldX = TS.X
            my_oldY = TS.Y
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Transferencias.Show()
        Me.Close()
    End Sub



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim res As Integer

        res = MessageBox.Show("¿Está seguro que desea salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = 6 Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        'Login.Show()
        'Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Base.Show()
        Me.Close()

    End Sub

End Class