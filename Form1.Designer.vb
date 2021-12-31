<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PlayerCart = New System.Windows.Forms.Panel()
        Me.PlayerPart1 = New System.Windows.Forms.Panel()
        Me.PlayerPart3 = New System.Windows.Forms.Panel()
        Me.PlayerPart4 = New System.Windows.Forms.Panel()
        Me.PlayerPart2 = New System.Windows.Forms.Panel()
        Me.AICart = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Splitter = New System.Windows.Forms.Panel()
        Me.AI = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Help = New System.Windows.Forms.Timer(Me.components)
        Me.Lchance = New System.Windows.Forms.Timer(Me.components)
        Me.Win = New System.Windows.Forms.Panel()
        Me.WinnerAnnouncement = New System.Windows.Forms.Label()
        Me.checkWinner = New System.Windows.Forms.Timer(Me.components)
        Me.PlayerCart.SuspendLayout()
        Me.AICart.SuspendLayout()
        Me.SuspendLayout()
        '
        'PlayerCart
        '
        Me.PlayerCart.Controls.Add(Me.PlayerPart1)
        Me.PlayerCart.Controls.Add(Me.PlayerPart3)
        Me.PlayerCart.Controls.Add(Me.PlayerPart4)
        Me.PlayerCart.Controls.Add(Me.PlayerPart2)
        Me.PlayerCart.Location = New System.Drawing.Point(28, 40)
        Me.PlayerCart.Name = "PlayerCart"
        Me.PlayerCart.Size = New System.Drawing.Size(295, 104)
        Me.PlayerCart.TabIndex = 0
        '
        'PlayerPart1
        '
        Me.PlayerPart1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerPart1.Location = New System.Drawing.Point(3, 3)
        Me.PlayerPart1.Name = "PlayerPart1"
        Me.PlayerPart1.Size = New System.Drawing.Size(182, 44)
        Me.PlayerPart1.TabIndex = 2
        '
        'PlayerPart3
        '
        Me.PlayerPart3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PlayerPart3.Location = New System.Drawing.Point(136, 70)
        Me.PlayerPart3.Name = "PlayerPart3"
        Me.PlayerPart3.Size = New System.Drawing.Size(72, 34)
        Me.PlayerPart3.TabIndex = 3
        '
        'PlayerPart4
        '
        Me.PlayerPart4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PlayerPart4.Location = New System.Drawing.Point(3, 70)
        Me.PlayerPart4.Name = "PlayerPart4"
        Me.PlayerPart4.Size = New System.Drawing.Size(69, 34)
        Me.PlayerPart4.TabIndex = 2
        '
        'PlayerPart2
        '
        Me.PlayerPart2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerPart2.Location = New System.Drawing.Point(3, 37)
        Me.PlayerPart2.Name = "PlayerPart2"
        Me.PlayerPart2.Size = New System.Drawing.Size(289, 42)
        Me.PlayerPart2.TabIndex = 1
        '
        'AICart
        '
        Me.AICart.Controls.Add(Me.Panel2)
        Me.AICart.Controls.Add(Me.Panel3)
        Me.AICart.Controls.Add(Me.Panel4)
        Me.AICart.Controls.Add(Me.Panel5)
        Me.AICart.Location = New System.Drawing.Point(28, 267)
        Me.AICart.Name = "AICart"
        Me.AICart.Size = New System.Drawing.Size(295, 104)
        Me.AICart.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(182, 44)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(136, 70)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(72, 34)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(3, 70)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(69, 34)
        Me.Panel4.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel5.Location = New System.Drawing.Point(3, 37)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(289, 42)
        Me.Panel5.TabIndex = 1
        '
        'Splitter
        '
        Me.Splitter.BackColor = System.Drawing.Color.Coral
        Me.Splitter.Location = New System.Drawing.Point(-15, 192)
        Me.Splitter.Name = "Splitter"
        Me.Splitter.Size = New System.Drawing.Size(1538, 10)
        Me.Splitter.TabIndex = 5
        '
        'AI
        '
        Me.AI.Interval = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(76, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Press Space!"
        '
        'Help
        '
        Me.Help.Enabled = True
        Me.Help.Interval = 500
        '
        'Lchance
        '
        Me.Lchance.Enabled = True
        Me.Lchance.Interval = 300
        '
        'Win
        '
        Me.Win.BackgroundImage = Global.Short_Race.My.Resources.Resources.P
        Me.Win.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Win.Location = New System.Drawing.Point(1284, -5)
        Me.Win.Name = "Win"
        Me.Win.Size = New System.Drawing.Size(153, 459)
        Me.Win.TabIndex = 7
        '
        'WinnerAnnouncement
        '
        Me.WinnerAnnouncement.AutoSize = True
        Me.WinnerAnnouncement.BackColor = System.Drawing.Color.Transparent
        Me.WinnerAnnouncement.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinnerAnnouncement.ForeColor = System.Drawing.Color.White
        Me.WinnerAnnouncement.Location = New System.Drawing.Point(708, 410)
        Me.WinnerAnnouncement.Name = "WinnerAnnouncement"
        Me.WinnerAnnouncement.Size = New System.Drawing.Size(0, 31)
        Me.WinnerAnnouncement.TabIndex = 8
        '
        'checkWinner
        '
        Me.checkWinner.Enabled = True
        Me.checkWinner.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1518, 450)
        Me.Controls.Add(Me.WinnerAnnouncement)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Splitter)
        Me.Controls.Add(Me.Win)
        Me.Controls.Add(Me.PlayerCart)
        Me.Controls.Add(Me.AICart)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Short Race"
        Me.PlayerCart.ResumeLayout(False)
        Me.AICart.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlayerCart As Panel
    Friend WithEvents PlayerPart4 As Panel
    Friend WithEvents PlayerPart2 As Panel
    Friend WithEvents PlayerPart1 As Panel
    Friend WithEvents PlayerPart3 As Panel
    Friend WithEvents AICart As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Splitter As Panel
    Friend WithEvents AI As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Help As Timer
    Friend WithEvents Lchance As Timer
    Friend WithEvents Win As Panel
    Friend WithEvents WinnerAnnouncement As Label
    Friend WithEvents checkWinner As Timer
End Class
