Public Class Login_Signup
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Public user As String
    Private Sub Login_Signup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        con = New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MCQ.accdb"
        txtName.Size = New Size(222, 34)

    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        If txtName.Text = "" Or txtUserName.Text = "" Or txtPassword.Text = "" Or txtPhone.Text = "" Then
            con.Close()
            MsgBox("Please Fill Requirements")

        Else
            Try
                Dim cmd As New OleDb.OleDbCommand
                If Not con.State = ConnectionState.Open Then
                    con.Open()

                End If
                cmd.Connection = con

                cmd.CommandText = "INSERT INTO Login([PLAYERNAME],[USERNAME],[PASSWORD],[PHONE])" & "VALUES('" & Me.txtName.Text & "','" & Me.txtUserName.Text & "','" & Me.txtPassword.Text & "','" & Me.txtPhone.Text & "')"
                cmd.ExecuteNonQuery()
                MsgBox("Successfully Registerd")

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            con.Close()
        End If
        txtName.Text = ""
        txtUserName.Text = ""
        txtPassword.Text = ""
        txtPhone.Text = ""
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Function Login()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        If con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("select * from Login", con)
        da.Fill(dt)
        For Each DataRow In dt.Rows
            If txtLogin.Text = DataRow.item(1) And txtloginPassword.Text = DataRow.item(2) Then
                con.Close()
                Return True


            End If

        Next
        con.Close()
        Return False


    End Function

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If Login() = True Then
            user = txtLogin.Text
            Me.Hide()
            Form1.Show()

        Else
            MsgBox("Invalid Username or Password")
        End If
        con.Close()
        con = New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MCQ.accdb"
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If
            If cmbTeam.Text = "Team A" Then
                cmd.Connection = con

                cmd.CommandText = "ALTER TABLE Game_Player ADD COLUMN QUESTIONS_T1 TEXT(50),USER_ANSWER_T1 TEXT(10),[TIME_T1] TEXT(10) DEFAULT 29,[SECOND_T1] TEXT(10) DEFAULT 60,lbl_Lock_T1 TEXT(10),lbl_vis_T1 TEXT(10),SCORE_T1 TEXT(10),ID_T1 TEXT(10)"
                cmd.ExecuteNonQuery()

            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If
            If cmbTeam.Text = "Team B" Then
                cmd.Connection = con

                cmd.CommandText = "ALTER TABLE Game_Player ADD COLUMN QUESTIONS_T2 TEXT(50),USER_ANSWER_T2 TEXT(10),[TIME_T2] TEXT(10) DEFAULT 29,[SECOND_T2] TEXT(10) DEFAULT 60,lbl_Lock_T2 TEXT(10),lbl_vis_T2 TEXT(10),SCORE_T2 TEXT(10),ID_T2 TEXT(10)"
                cmd.ExecuteNonQuery()

            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If
            If cmbTeam.Text = "Team C" Then
                cmd.Connection = con

                cmd.CommandText = "ALTER TABLE Game_Player ADD COLUMN QUESTIONS_T3 TEXT(50),USER_ANSWER_T3 TEXT(10),[TIME_T3] TEXT(10) DEFAULT 29,[SECOND_T3] TEXT(10) DEFAULT 60,lbl_Lock_T3 TEXT(10),lbl_vis_T3 TEXT(10),SCORE_T3 TEXT(10),ID_T3 TEXT(10)"
                cmd.ExecuteNonQuery()

            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If
            If cmbTeam.Text = "Team D" Then
                cmd.Connection = con

                cmd.CommandText = "ALTER TABLE Game_Player ADD COLUMN QUESTIONS_T4 TEXT(50),USER_ANSWER_T4 TEXT(10),[TIME_T4] TEXT(10) DEFAULT 29,[SECOND_T4] TEXT(10) DEFAULT 60,lbl_Lock_T4 TEXT(10),lbl_vis_T4 TEXT(10),SCORE_T4 TEXT(10),ID_T4 TEXT(10)"
                cmd.ExecuteNonQuery()

            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
End Class