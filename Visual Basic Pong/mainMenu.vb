Public Class mainMenu
    Private Sub vsPlayerButton_Click(sender As Object, e As System.EventArgs) Handles vsPlayerButton.Click
        Me.Hide()
        gameScreen.Show()
        gameScreen.vsPlayer = True
    End Sub

    Private Sub vsComputerButton_Click(sender As Object, e As System.EventArgs) Handles vsComputerButton.Click
        Me.Hide()
        gameScreen.Show()
        gameScreen.vsComp = True
    End Sub

    Private Sub exitButton_Click(sender As Object, e As System.EventArgs) Handles exitButton.Click
        gameScreen.Close()
        Me.Close()
    End Sub

    Private Sub controlsButton_Click(sender As Object, e As System.EventArgs) Handles controlsButton.Click
        ' shows controls '
        MessageBox.Show("Player 1     -  Move Up/Down: W & S" & vbNewLine & "Player 2     -  Move Up/Down O & K" & vbNewLine & "Serve Ball  -  Spacebar" & vbNewLine & vbNewLine & "First to score 3 points wins!", "Controls", MessageBoxButtons.OK)
    End Sub
End Class