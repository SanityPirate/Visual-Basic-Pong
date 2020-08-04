<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gameScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gameScreen))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.bottomCollisionShape = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.topCollisionShape = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ball = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.player2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.player1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.player1ScoreLabel = New System.Windows.Forms.Label()
        Me.player2ScoreLabel = New System.Windows.Forms.Label()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ballMask = New System.Windows.Forms.PictureBox()
        Me.player1Win = New System.Windows.Forms.Label()
        Me.player2Win = New System.Windows.Forms.Label()
        Me.gameOverLabel = New System.Windows.Forms.Label()
        CType(Me.ballMask, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.bottomCollisionShape, Me.topCollisionShape, Me.LineShape1, Me.ball, Me.player2, Me.player1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(906, 493)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'bottomCollisionShape
        '
        Me.bottomCollisionShape.BackColor = System.Drawing.Color.White
        Me.bottomCollisionShape.BorderColor = System.Drawing.Color.White
        Me.bottomCollisionShape.BorderWidth = 2
        Me.bottomCollisionShape.FillColor = System.Drawing.Color.White
        Me.bottomCollisionShape.Location = New System.Drawing.Point(-3, 482)
        Me.bottomCollisionShape.Name = "bottomCollisionShape"
        Me.bottomCollisionShape.Size = New System.Drawing.Size(919, 10)
        '
        'topCollisionShape
        '
        Me.topCollisionShape.BackColor = System.Drawing.Color.White
        Me.topCollisionShape.BorderColor = System.Drawing.Color.White
        Me.topCollisionShape.BorderWidth = 2
        Me.topCollisionShape.FillColor = System.Drawing.Color.White
        Me.topCollisionShape.Location = New System.Drawing.Point(-3, 0)
        Me.topCollisionShape.Name = "topCollisionShape"
        Me.topCollisionShape.Size = New System.Drawing.Size(919, 10)
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape1.BorderWidth = 5
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 454
        Me.LineShape1.X2 = 453
        Me.LineShape1.Y1 = 10
        Me.LineShape1.Y2 = 481
        '
        'ball
        '
        Me.ball.BorderWidth = 2
        Me.ball.FillColor = System.Drawing.Color.White
        Me.ball.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ball.Location = New System.Drawing.Point(444, 217)
        Me.ball.Name = "ball"
        Me.ball.Size = New System.Drawing.Size(20, 21)
        Me.ball.Visible = False
        '
        'player2
        '
        Me.player2.FillColor = System.Drawing.Color.White
        Me.player2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.player2.Location = New System.Drawing.Point(882, 177)
        Me.player2.Name = "player2"
        Me.player2.Size = New System.Drawing.Size(20, 110)
        '
        'player1
        '
        Me.player1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.player1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.player1.FillColor = System.Drawing.Color.White
        Me.player1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.player1.Location = New System.Drawing.Point(5, 177)
        Me.player1.Name = "player1"
        Me.player1.Size = New System.Drawing.Size(20, 110)
        '
        'player1ScoreLabel
        '
        Me.player1ScoreLabel.AutoSize = True
        Me.player1ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player1ScoreLabel.ForeColor = System.Drawing.Color.White
        Me.player1ScoreLabel.Location = New System.Drawing.Point(354, 46)
        Me.player1ScoreLabel.Name = "player1ScoreLabel"
        Me.player1ScoreLabel.Size = New System.Drawing.Size(37, 39)
        Me.player1ScoreLabel.TabIndex = 1
        Me.player1ScoreLabel.Text = "0"
        '
        'player2ScoreLabel
        '
        Me.player2ScoreLabel.AutoSize = True
        Me.player2ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player2ScoreLabel.ForeColor = System.Drawing.Color.White
        Me.player2ScoreLabel.Location = New System.Drawing.Point(513, 46)
        Me.player2ScoreLabel.Name = "player2ScoreLabel"
        Me.player2ScoreLabel.Size = New System.Drawing.Size(37, 39)
        Me.player2ScoreLabel.TabIndex = 2
        Me.player2ScoreLabel.Text = "0"
        '
        'gameTimer
        '
        Me.gameTimer.Enabled = True
        Me.gameTimer.Interval = 15
        '
        'ballMask
        '
        Me.ballMask.BackColor = System.Drawing.Color.White
        Me.ballMask.Location = New System.Drawing.Point(444, 217)
        Me.ballMask.Name = "ballMask"
        Me.ballMask.Size = New System.Drawing.Size(21, 22)
        Me.ballMask.TabIndex = 3
        Me.ballMask.TabStop = False
        '
        'player1Win
        '
        Me.player1Win.AutoSize = True
        Me.player1Win.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player1Win.ForeColor = System.Drawing.Color.White
        Me.player1Win.Location = New System.Drawing.Point(72, 109)
        Me.player1Win.Name = "player1Win"
        Me.player1Win.Size = New System.Drawing.Size(255, 47)
        Me.player1Win.TabIndex = 4
        Me.player1Win.Text = "Player 1 Wins!"
        Me.player1Win.Visible = False
        '
        'player2Win
        '
        Me.player2Win.AutoSize = True
        Me.player2Win.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player2Win.ForeColor = System.Drawing.Color.White
        Me.player2Win.Location = New System.Drawing.Point(575, 109)
        Me.player2Win.Name = "player2Win"
        Me.player2Win.Size = New System.Drawing.Size(255, 47)
        Me.player2Win.TabIndex = 5
        Me.player2Win.Text = "Player 2 Wins!"
        Me.player2Win.Visible = False
        '
        'gameOverLabel
        '
        Me.gameOverLabel.AutoSize = True
        Me.gameOverLabel.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameOverLabel.ForeColor = System.Drawing.Color.White
        Me.gameOverLabel.Location = New System.Drawing.Point(131, 414)
        Me.gameOverLabel.Name = "gameOverLabel"
        Me.gameOverLabel.Size = New System.Drawing.Size(647, 47)
        Me.gameOverLabel.TabIndex = 6
        Me.gameOverLabel.Text = "Press ESC to return to the main menu."
        Me.gameOverLabel.Visible = False
        '
        'gameScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(906, 493)
        Me.Controls.Add(Me.gameOverLabel)
        Me.Controls.Add(Me.player2Win)
        Me.Controls.Add(Me.player1Win)
        Me.Controls.Add(Me.ballMask)
        Me.Controls.Add(Me.player2ScoreLabel)
        Me.Controls.Add(Me.player1ScoreLabel)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "gameScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visual Basic Pong"
        CType(Me.ballMask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ball As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents player2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents player1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents player1ScoreLabel As System.Windows.Forms.Label
    Friend WithEvents player2ScoreLabel As System.Windows.Forms.Label
    Friend WithEvents gameTimer As System.Windows.Forms.Timer
    Friend WithEvents bottomCollisionShape As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents topCollisionShape As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ballMask As System.Windows.Forms.PictureBox
    Friend WithEvents player1Win As System.Windows.Forms.Label
    Friend WithEvents player2Win As System.Windows.Forms.Label
    Friend WithEvents gameOverLabel As System.Windows.Forms.Label

End Class
