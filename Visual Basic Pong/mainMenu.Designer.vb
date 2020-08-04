<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainMenu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.vsPlayerButton = New System.Windows.Forms.Button()
        Me.vsComputerButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.controlsButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(814, 333)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'vsPlayerButton
        '
        Me.vsPlayerButton.BackColor = System.Drawing.Color.Black
        Me.vsPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.vsPlayerButton.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vsPlayerButton.ForeColor = System.Drawing.Color.White
        Me.vsPlayerButton.Location = New System.Drawing.Point(113, 361)
        Me.vsPlayerButton.Name = "vsPlayerButton"
        Me.vsPlayerButton.Size = New System.Drawing.Size(289, 72)
        Me.vsPlayerButton.TabIndex = 1
        Me.vsPlayerButton.TabStop = False
        Me.vsPlayerButton.Text = "VS. PLAYER"
        Me.vsPlayerButton.UseVisualStyleBackColor = False
        '
        'vsComputerButton
        '
        Me.vsComputerButton.BackColor = System.Drawing.Color.Black
        Me.vsComputerButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.vsComputerButton.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vsComputerButton.ForeColor = System.Drawing.Color.White
        Me.vsComputerButton.Location = New System.Drawing.Point(438, 361)
        Me.vsComputerButton.Name = "vsComputerButton"
        Me.vsComputerButton.Size = New System.Drawing.Size(289, 72)
        Me.vsComputerButton.TabIndex = 2
        Me.vsComputerButton.TabStop = False
        Me.vsComputerButton.Text = "VS. COMPUTER"
        Me.vsComputerButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.Black
        Me.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.exitButton.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.ForeColor = System.Drawing.Color.White
        Me.exitButton.Location = New System.Drawing.Point(275, 517)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(289, 72)
        Me.exitButton.TabIndex = 3
        Me.exitButton.TabStop = False
        Me.exitButton.Text = "EXIT GAME"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'controlsButton
        '
        Me.controlsButton.BackColor = System.Drawing.Color.Black
        Me.controlsButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.controlsButton.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.controlsButton.ForeColor = System.Drawing.Color.White
        Me.controlsButton.Location = New System.Drawing.Point(275, 439)
        Me.controlsButton.Name = "controlsButton"
        Me.controlsButton.Size = New System.Drawing.Size(289, 72)
        Me.controlsButton.TabIndex = 4
        Me.controlsButton.TabStop = False
        Me.controlsButton.Text = "CONTROLS"
        Me.controlsButton.UseVisualStyleBackColor = False
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(839, 600)
        Me.Controls.Add(Me.controlsButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.vsComputerButton)
        Me.Controls.Add(Me.vsPlayerButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "mainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visual Basic Pong"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents vsPlayerButton As System.Windows.Forms.Button
    Friend WithEvents vsComputerButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents controlsButton As System.Windows.Forms.Button
End Class
