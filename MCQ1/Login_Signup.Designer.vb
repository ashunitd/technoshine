<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Signup
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpTeam = New System.Windows.Forms.GroupBox()
        Me.cmbTeam = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtloginPassword = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTechnoshine = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.grpTeam.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.btnRegister)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(189, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 386)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sign Up"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(156, 237)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(217, 39)
        Me.txtPhone.TabIndex = 12
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(156, 171)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(46)
        Me.txtPassword.Size = New System.Drawing.Size(217, 39)
        Me.txtPassword.TabIndex = 11
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(156, 117)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(217, 39)
        Me.txtUsername.TabIndex = 10
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(156, 67)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(217, 22)
        Me.txtName.TabIndex = 9
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(186, 309)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(135, 47)
        Me.btnRegister.TabIndex = 8
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 31)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Phone"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'grpTeam
        '
        Me.grpTeam.BackColor = System.Drawing.Color.Transparent
        Me.grpTeam.Controls.Add(Me.cmbTeam)
        Me.grpTeam.Controls.Add(Me.Label7)
        Me.grpTeam.Controls.Add(Me.txtloginPassword)
        Me.grpTeam.Controls.Add(Me.txtLogin)
        Me.grpTeam.Controls.Add(Me.btnLogin)
        Me.grpTeam.Controls.Add(Me.Label6)
        Me.grpTeam.Controls.Add(Me.Label5)
        Me.grpTeam.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTeam.Location = New System.Drawing.Point(805, 162)
        Me.grpTeam.Name = "grpTeam"
        Me.grpTeam.Size = New System.Drawing.Size(457, 326)
        Me.grpTeam.TabIndex = 1
        Me.grpTeam.TabStop = False
        Me.grpTeam.Text = "Sign In"
        '
        'cmbTeam
        '
        Me.cmbTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTeam.FormattingEnabled = True
        Me.cmbTeam.Items.AddRange(New Object() {"Team A", "Team B", "Team C", "Team D"})
        Me.cmbTeam.Location = New System.Drawing.Point(169, 178)
        Me.cmbTeam.Name = "cmbTeam"
        Me.cmbTeam.Size = New System.Drawing.Size(217, 39)
        Me.cmbTeam.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(71, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 31)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Team"
        '
        'txtloginPassword
        '
        Me.txtloginPassword.Location = New System.Drawing.Point(169, 106)
        Me.txtloginPassword.Name = "txtloginPassword"
        Me.txtloginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(46)
        Me.txtloginPassword.Size = New System.Drawing.Size(217, 39)
        Me.txtloginPassword.TabIndex = 11
        '
        'txtLogin
        '
        Me.txtLogin.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.Location = New System.Drawing.Point(169, 52)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(217, 39)
        Me.txtLogin.TabIndex = 10
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(228, 253)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(99, 43)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 31)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 31)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Username"
        '
        'lblTechnoshine
        '
        Me.lblTechnoshine.BackColor = System.Drawing.Color.Transparent
        Me.lblTechnoshine.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTechnoshine.Location = New System.Drawing.Point(522, 35)
        Me.lblTechnoshine.Name = "lblTechnoshine"
        Me.lblTechnoshine.Size = New System.Drawing.Size(313, 48)
        Me.lblTechnoshine.TabIndex = 2
        Me.lblTechnoshine.Text = "TOTAL CHAOS"
        Me.lblTechnoshine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login_Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MCQ.My.Resources.Resources.Puzzle_Clown
        Me.ClientSize = New System.Drawing.Size(1370, 673)
        Me.Controls.Add(Me.lblTechnoshine)
        Me.Controls.Add(Me.grpTeam)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Login_Signup"
        Me.Text = "Login_Signup"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpTeam.ResumeLayout(False)
        Me.grpTeam.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpTeam As System.Windows.Forms.GroupBox
    Friend WithEvents lblTechnoshine As System.Windows.Forms.Label
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtloginPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents cmbTeam As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
