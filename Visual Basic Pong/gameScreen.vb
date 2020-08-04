' who in their right mind would ever use visual basic to make a videogame.
' finished (more or less) by Brayden Waugh on 5/25/17 at 1:39AM. 

Imports Microsoft.VisualBasic.Devices

Public Class gameScreen
    ' next 4 lines are booleans for moving the player up or down
    Dim moveUpPlayer1 As Boolean = False
    Dim moveDownPlayer1 As Boolean = False
    Dim moveUpPlayer2 As Boolean = False
    Dim moveDownPlayer2 As Boolean = False
    ' move speed of the player's paddle
    Dim moveSpeed As Integer = 3
    ' move speed of the ball
    Dim ballSpeed As Integer = 6
    ' random number generator
    Dim random As New Random
    Dim randomPos As Integer = 1
    ' next two variables give the ball movement
    Dim xVelocity As Single = Math.Cos(random.Next(5, 10)) * ballSpeed
    Dim yVelocity As Single = Math.Sin(random.Next(5, 10)) * ballSpeed
    ' determines whether the game should start 
    Dim startGame As Boolean = False
    ' determines if the game has concluded and prevents the user from starting again without returning to the
    ' main menu first
    Dim canStart As Boolean = True
    ' global variables to determine who the user is playing against
    Public Shared vsPlayer As Boolean = False
    Public Shared vsComp As Boolean = False

    Private Sub gameScreen_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ' closes the application when the game is forced closed
        mainMenu.Close()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        ' case select for key presses to control movement of the paddles, starting the game,
        ' and exiting the game
        Select Case e.KeyCode
            Case Keys.W
                moveUpPlayer1 = True
                moveDownPlayer1 = False
            Case Keys.S
                moveUpPlayer1 = False
                moveDownPlayer1 = True
            Case Keys.O
                moveUpPlayer2 = True
                moveDownPlayer2 = False
            Case Keys.K
                moveUpPlayer2 = False
                moveDownPlayer2 = True
            Case Keys.Space
                If canStart = True Then
                    startGame = True
                End If
            Case Keys.Escape
                ' displays a message box and resets the gameScreen form and variables for the next potential game, and exits to the main menu
                Dim response = MessageBox.Show("Exit to main menu?", "", MessageBoxButtons.YesNo, MessageBoxIcon.None)
                If response = 6 Then
                    vsPlayer = False
                    vsComp = False
                    player1ScoreLabel.Text = 0
                    player2ScoreLabel.Text = 0
                    startGame = False
                    canStart = True
                    player1Win.Visible = False
                    player2Win.Visible = False
                    gameOverLabel.Visible = False
                    player1.Location = New Point(5, 177)
                    player2.Location = New Point(882, 177)
                    Me.Hide()
                    mainMenu.Show()
                    mainMenu.BringToFront()
                End If
        End Select
    End Sub

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        ' stops the movement of the paddle upon release of the key
        Select Case e.KeyCode
            Case Keys.W
                moveUpPlayer1 = False
            Case Keys.S
                moveDownPlayer1 = False
            Case Keys.O
                moveUpPlayer2 = False
            Case Keys.K
                moveDownPlayer2 = False
        End Select
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' formatting
        LineShape1.SendToBack()
    End Sub
    Private Sub gameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gameTimer.Tick
        ' places an object over the shape representing the ball to display over other controls on the form
        ballMask.Location = ball.Location
        ' moves the player 
        Call movePlayer1()
        ' moves player 2 if the game type was selected
        If vsPlayer = True Then
            Call movePlayer2()
        End If
        ' makes player 2 computer controlled if the game type was selected
        If vsComp = True Then
            If ball.Location.Y > 0 And ball.Location.Y < Me.Height - ball.Size.Height - 144 Then
                player2.Location = New Point(player2.Location.X, ball.Location.Y)
            End If
        End If
        ' determines which side the ball left the bounds of the form and awards a point to the player who scored
        ' also resets the position of the ball and readies a spacebar press
        If ball.Location.X < 0 Or ball.Location.X > Me.Width Then
            If ball.Location.X < 0 Then
                ball.Location = New Point(444, 217)
                player2ScoreLabel.Text += 1
            End If
            If ball.Location.X > Me.Width Then
                ball.Location = New Point(444, 217)
                player1ScoreLabel.Text += 1
            End If
            startGame = False
        End If
        ' gives the ball movement when spacebar is pressed
        If startGame = True Then
            ball.Location = New Point(ball.Location.X + xVelocity, ball.Location.Y + yVelocity)
        End If

        ' checks for collision with the top boundary
        If ball.Location.Y < 15 Then
            My.Computer.Audio.Play(My.Resources.plip, AudioPlayMode.Background)
            ball.Location = New Point(ball.Location.X, 15)
            yVelocity = -yVelocity
        End If

        ' checks for collision with the bottom boundary 
        If ball.Location.Y > Me.Height - ball.Size.Height - 50 Then
            My.Computer.Audio.Play(My.Resources.plop, AudioPlayMode.Background)
            ball.Location = New Point(ball.Location.X, Me.Height - ball.Size.Height - 50)
            yVelocity = -yVelocity
        End If

        ' checks for collision with player 1's paddle
        If ball.Bounds.IntersectsWith(player1.Bounds) Then
            My.Computer.Audio.Play(My.Resources.ping, AudioPlayMode.Background)
            ball.Location = New Point(player1.Location.X + ball.Size.Width, ball.Location.Y)
            xVelocity = -xVelocity
            ballSpeed += 100
        End If

        ' checks for collision with player 2's paddle
        If ball.Bounds.IntersectsWith(player2.Bounds) Then
            My.Computer.Audio.Play(My.Resources.pong, AudioPlayMode.Background)
            ball.Location = New Point(player2.Location.X - player2.Size.Width, ball.Location.Y)
            xVelocity = -xVelocity
        End If
    End Sub
    Sub movePlayer1()
        ' movement for player one
        If moveUpPlayer1 = True Then
            If player1.Location.Y < 15 Then
                player1.Location = New Point(player1.Location.X, player1.Location.Y)
            Else
                player1.Location = New Point(player1.Location.X, player1.Location.Y - moveSpeed)
            End If
        End If
        If moveDownPlayer1 = True Then
            If player1.Location.Y > 366 Then
                player1.Location = New Point(player1.Location.X, player1.Location.Y)
            Else
                player1.Location = New Point(player1.Location.X, player1.Location.Y + moveSpeed)
            End If
        End If
    End Sub
    Sub movePlayer2()
        ' movement for player two
        If moveUpPlayer2 = True Then
            If player2.Location.Y < 15 Then
                player2.Location = New Point(player2.Location.X, player2.Location.Y)
            Else
                player2.Location = New Point(player2.Location.X, player2.Location.Y - moveSpeed)
            End If
        End If
        If moveDownPlayer2 = True Then
            If player2.Location.Y > 366 Then
                player2.Location = New Point(player2.Location.X, player2.Location.Y)
            Else
                player2.Location = New Point(player2.Location.X, player2.Location.Y + moveSpeed)
            End If
        End If
    End Sub

    Private Sub player1ScoreLabel_TextChanged(sender As Object, e As System.EventArgs) Handles player1ScoreLabel.TextChanged
        ' determines if the game is over
        If player1ScoreLabel.Text = "3" Then
            My.Computer.Audio.Play(My.Resources.win, AudioPlayMode.Background)
            canStart = False
            startGame = False
            player1Win.Visible = True
            gameOverLabel.Visible = True
        End If
    End Sub

    Private Sub player2ScoreLabel_TextChanged(sender As Object, e As System.EventArgs) Handles player2ScoreLabel.TextChanged
        ' determines if the game is over
        If player2ScoreLabel.Text = "3" Then
            My.Computer.Audio.Play(My.Resources.win, AudioPlayMode.Background)
            canStart = False
            startGame = False
            player2Win.Visible = True
            gameOverLabel.Visible = True
        End If
    End Sub
End Class
