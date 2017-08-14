<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResult
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Score = New System.Windows.Forms.Label()
        Me.totalScore = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.lblWrong = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Score)
        Me.Panel1.Controls.Add(Me.totalScore)
        Me.Panel1.Location = New System.Drawing.Point(524, 170)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 161)
        Me.Panel1.TabIndex = 0
        '
        'Score
        '
        Me.Score.BackColor = System.Drawing.Color.Transparent
        Me.Score.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score.ForeColor = System.Drawing.Color.Black
        Me.Score.Location = New System.Drawing.Point(87, 61)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(217, 39)
        Me.Score.TabIndex = 2
        Me.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalScore
        '
        Me.totalScore.BackColor = System.Drawing.Color.Transparent
        Me.totalScore.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalScore.ForeColor = System.Drawing.Color.Black
        Me.totalScore.Location = New System.Drawing.Point(87, 9)
        Me.totalScore.Name = "totalScore"
        Me.totalScore.Size = New System.Drawing.Size(217, 39)
        Me.totalScore.TabIndex = 1
        Me.totalScore.Text = "TOTAL SCORE"
        Me.totalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RosyBrown
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(664, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 62)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblRight
        '
        Me.lblRight.BackColor = System.Drawing.Color.Transparent
        Me.lblRight.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRight.ForeColor = System.Drawing.Color.Black
        Me.lblRight.Location = New System.Drawing.Point(151, 311)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(217, 39)
        Me.lblRight.TabIndex = 3
        Me.lblRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWrong
        '
        Me.lblWrong.BackColor = System.Drawing.Color.Transparent
        Me.lblWrong.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrong.ForeColor = System.Drawing.Color.Black
        Me.lblWrong.Location = New System.Drawing.Point(919, 334)
        Me.lblWrong.Name = "lblWrong"
        Me.lblWrong.Size = New System.Drawing.Size(217, 39)
        Me.lblWrong.TabIndex = 4
        Me.lblWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Black
        Me.lblUser.Location = New System.Drawing.Point(293, 9)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(217, 39)
        Me.lblUser.TabIndex = 5
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MCQ.My.Resources.Resources.Puzzle_Clown
        Me.ClientSize = New System.Drawing.Size(1370, 673)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblWrong)
        Me.Controls.Add(Me.lblRight)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmResult"
        Me.Text = "frmResult"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents totalScore As System.Windows.Forms.Label
    Friend WithEvents Score As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblRight As System.Windows.Forms.Label
    Friend WithEvents lblWrong As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
End Class
