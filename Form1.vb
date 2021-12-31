Public Class Form1
    Public plrSpeed As Integer = 5
    Public speed As Integer = 4
    Dim winned As Boolean = False
    Private Sub AI_Tick(sender As Object, e As EventArgs) Handles AI.Tick
        AI.Interval = New Random().Next(20, 300)
        AICart.Left += speed
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub Form1_KeyPress(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Space Then
            If Not winned Then
                If Help.Enabled Then
                    Help.Stop()
                    Label1.Hide()
                End If
                PlayerCart.Left += plrSpeed
            End If
        End If
    End Sub
    Private Sub Help_Tick(sender As Object, e As EventArgs) Handles Help.Tick
        If Label1.ForeColor = Color.Red Then
            Label1.ForeColor = Color.White
        Else
            Label1.ForeColor = Color.Red
        End If
    End Sub
    Private Sub Lchance_Tick(sender As Object, e As EventArgs) Handles Lchance.Tick
        AI.Start()
        Lchance.Stop()
    End Sub
    Private Sub checkWinner_Tick(sender As Object, e As EventArgs) Handles checkWinner.Tick
        If Not winned Then
            If PlayerCart.Bounds.IntersectsWith(Win.Bounds) Then
                winned = True
                AI.Stop()
                WinnerAnnouncement.Text = " You Won!"
            End If
            If AICart.Bounds.IntersectsWith(Win.Bounds) Then
                winned = True
                AI.Stop()
                WinnerAnnouncement.Text = "Computer Won!"
            End If
        End If
    End Sub
End Class