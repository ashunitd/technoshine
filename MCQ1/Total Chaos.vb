Public Class Form1
    
    Dim con As New OleDb.OleDbConnection

    Dim ds As New DataSet
    Dim maxRows As Integer
    Dim inc As Integer
    Dim score As Single = 0.0
    Dim ans As String = ""
    Dim sc1 As String
    Dim sc2 As String
    Dim lbllock As Integer
    Dim lblvis As Integer
    Dim lbllockID As Integer = 1
    Dim lblvisID As Integer = 1
    Dim radiobutton As String
    Dim n As Integer = 0
    Dim n1 As Integer = 0
    Dim cmd As New OleDb.OleDbCommand
    Dim dt As New DataTable
    Public puser As String
    Public rightans As String
    Public wrongans As String


   



    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        lblUser.Text = Login_Signup.user
        Dim z As Integer = 0

        Timer1.Interval = 1000
        Timer1.Start()



        con = New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MCQ.accdb"


        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If


        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
        da.Fill(ds, "Q_A")
        If ds.Tables("Q_A").Rows.Count > 0 Then

            lblQuestion.Text = ds.Tables("Q_A").Rows(0).Item(0).ToString()
            rbtn1.Text = ds.Tables("Q_A").Rows(0).Item(1).ToString()
            rbtn2.Text = ds.Tables("Q_A").Rows(0).Item(2).ToString()
            rbtn3.Text = ds.Tables("Q_A").Rows(0).Item(3).ToString()
            rbtn4.Text = ds.Tables("Q_A").Rows(0).Item(4).ToString()


        End If



        Try

            Dim M As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            M.Fill(ds, "Q_A")

            maxRows = ds.Tables("Q_A").Rows.Count


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
         If inc = 0 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis1]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis1.BackColor = Color.DarkGreen
        End If
        con.Close()

        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If


        Dim na As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
        na.Fill(ds, "Q_A")
        If ds.Tables("Q_A").Rows.Count > 0 Then

            lbltimeMin.Text = ds.Tables("Q_A").Rows(0).Item(8).ToString()
            lblTimeSec.Text = ds.Tables("Q_A").Rows(0).Item(9).ToString()
            con.Close()
        End If
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
         Dim dt As New DataTable
        Dim dg As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        dg.Fill(dt)
        For Each DataRow In dt.Rows



            If DataRow.Item("lbl_vis1") = "2" Then
                vis1.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis2") = "2" Then
                vis2.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis3") = "2" Then
                vis3.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis4") = "2" Then
                vis4.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis5") = "2" Then
                vis5.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis6") = "2" Then
                vis6.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis7") = "2" Then
                vis7.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis8") = "2" Then
                vis8.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis9") = "2" Then
                vis9.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis10") = "2" Then
                vis10.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis11") = "2" Then
                vis11.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis12") = "2" Then
                vis12.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis13") = "2" Then
                vis13.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis14") = "2" Then
                vis14.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis15") = "2" Then
                vis15.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis16") = "2" Then
                vis16.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis17") = "2" Then
                vis17.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis18") = "2" Then
                vis18.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis19") = "2" Then
                vis19.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis20") = "2" Then
                vis20.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis21") = "2" Then
                vis21.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis22") = "2" Then
                vis22.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis23") = "2" Then
                vis23.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis24") = "2" Then
                vis24.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis25") = "2" Then
                vis25.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis26") = "2" Then
                vis26.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis27") = "2" Then
                vis27.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis28") = "2" Then
                vis28.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis29") = "2" Then
                vis29.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_vis30") = "2" Then
                vis30.BackColor = Color.DarkGreen
            End If
            If DataRow.Item("lbl_lock1") = "1" Then
                lblL1.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock2") = "1" Then
                lblL2.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock3") = "1" Then
                lblL3.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock4") = "1" Then
                lblL4.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock5") = "1" Then
                lblL5.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock6") = "1" Then
                lblL6.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock7") = "1" Then
                lblL7.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock8") = "1" Then
                lblL8.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock9") = "1" Then
                lblL9.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock10") = "1" Then
                lblL10.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock11") = "1" Then
                lblL11.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock12") = "1" Then
                lblL12.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock13") = "1" Then
                lblL13.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock14") = "1" Then
                lblL14.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock15") = "1" Then
                lblL15.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock16") = "1" Then
                lblL16.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock17") = "1" Then
                lblL17.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock18") = "1" Then
                lblL18.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock19") = "1" Then
                lblL19.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock20") = "1" Then
                lblL20.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock21") = "1" Then
                lblL21.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock22") = "1" Then
                lblL22.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock23") = "1" Then
                lblL23.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock24") = "1" Then
                lblL24.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock25") = "1" Then
                lblL25.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock26") = "1" Then
                lblL26.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock27") = "1" Then
                lblL27.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock28") = "1" Then
                lblL28.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock29") = "1" Then
                lblL29.BackColor = Color.OrangeRed
            End If
            If DataRow.Item("lbl_lock30") = "1" Then
                lblL30.BackColor = Color.OrangeRed
            End If
        Next
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            If inc = 0 Then

                TextBox3.Text = DataRow.Item("Ans1")
                TextBox2.Text = DataRow.Item("Q_NO1")

            End If
        Next

        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        If Not con.State = ConnectionState.Open Then
            con.Open()

        End If


        Dim ka As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        ka.Fill(dt)
        For Each DataRow In dt.Rows


            txtRight.Text = DataRow.Item("RIGHT")
            txtWrong.Text = DataRow.Item("WRONG")


        Next
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblQuestion.Click
        lblQuestion.BackColor = Color.Transparent
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblL8.Click

    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        rightans = txtRight.Text
        wrongans = txtWrong.Text
        puser = lblUser.Text
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        While (n <= 29)
            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A", con)


            While (n1 <= 29)
                sc1 = ds.Tables("Q_A").Rows(n).Item(5).ToString()
                sc2 = ds.Tables("Q_A").Rows(n1).Item(6).ToString()
                If sc1 = sc2 Then
                    score = score + 1
                ElseIf sc1 <> sc2 Then
                    score = score - 0.25
                End If
                n1 = n1 + 1
                n = n + 1
            End While


        End While

        lblScore.Text = score
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        cmd.Connection = con
        cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & 29 & "',[Second_Time]='" & 60 & "' WHERE [ID]='1'"
        cmd.ExecuteNonQuery()
        con.Close()
       
        Me.Hide()
        frmResult.Show()

       
    End Sub

    Private Sub rbtn1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn1.CheckedChanged

       
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click


        If inc < maxRows / 2 - 1 Then
            inc = inc + 1
            NavigateRecords()

        Else
            MsgBox("Last Question")
        End If



        rbtn1.Checked = False
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False

        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            If inc = 0 Then
                TextBox2.Text = DataRow.Item("Q_NO1")
                TextBox3.Text = DataRow.Item("Ans1")

            ElseIf inc = 1 Then
                TextBox2.Text = DataRow.Item("Q_NO2")
                TextBox3.Text = DataRow.Item("Ans2")

            ElseIf inc = 2 Then
                TextBox2.Text = DataRow.Item("Q_NO3")
                TextBox3.Text = DataRow.Item("Ans3")

            ElseIf inc = 3 Then
                TextBox2.Text = DataRow.Item("Q_NO4")
                TextBox3.Text = DataRow.Item("Ans4")

            ElseIf inc = 4 Then
                TextBox2.Text = DataRow.Item("Q_NO5")
                TextBox3.Text = DataRow.Item("Ans5")

            ElseIf inc = 5 Then
                TextBox2.Text = DataRow.Item("Q_NO6")
                TextBox3.Text = DataRow.Item("Ans6")

            ElseIf inc = 6 Then
                TextBox2.Text = DataRow.Item("Q_NO7")
                TextBox3.Text = DataRow.Item("Ans7")

            ElseIf inc = 7 Then
                TextBox2.Text = DataRow.Item("Q_NO8")
                TextBox3.Text = DataRow.Item("Ans8")

            ElseIf inc = 8 Then
                TextBox2.Text = DataRow.Item("Q_NO9")
                TextBox3.Text = DataRow.Item("Ans9")

            ElseIf inc = 9 Then
                TextBox2.Text = DataRow.Item("Q_NO10")
                TextBox3.Text = DataRow.Item("Ans10")

            ElseIf inc = 10 Then
                TextBox2.Text = DataRow.Item("Q_NO11")
                TextBox3.Text = DataRow.Item("Ans11")

            ElseIf inc = 11 Then
                TextBox2.Text = DataRow.Item("Q_NO12")
                TextBox3.Text = DataRow.Item("Ans12")

            ElseIf inc = 12 Then
                TextBox2.Text = DataRow.Item("Q_NO13")
                TextBox3.Text = DataRow.Item("Ans13")

            ElseIf inc = 13 Then
                TextBox2.Text = DataRow.Item("Q_NO14")
                TextBox3.Text = DataRow.Item("Ans14")

            ElseIf inc = 14 Then
                TextBox2.Text = DataRow.Item("Q_NO15")
                TextBox3.Text = DataRow.Item("Ans15")
            ElseIf inc = 15 Then
                TextBox2.Text = DataRow.Item("Q_NO16")
                TextBox3.Text = DataRow.Item("Ans16")

            ElseIf inc = 16 Then
                TextBox2.Text = DataRow.Item("Q_NO17")
                TextBox3.Text = DataRow.Item("Ans17")

            ElseIf inc = 17 Then
                TextBox2.Text = DataRow.Item("Q_NO18")
                TextBox3.Text = DataRow.Item("Ans18")

            ElseIf inc = 18 Then
                TextBox2.Text = DataRow.Item("Q_NO19")
                TextBox3.Text = DataRow.Item("Ans19")

            ElseIf inc = 19 Then
                TextBox2.Text = DataRow.Item("Q_NO20")
                TextBox3.Text = DataRow.Item("Ans20")

            ElseIf inc = 20 Then
                TextBox2.Text = DataRow.Item("Q_NO21")
                TextBox3.Text = DataRow.Item("Ans21")

            ElseIf inc = 21 Then
                TextBox2.Text = DataRow.Item("Q_NO22")
                TextBox3.Text = DataRow.Item("Ans22")

            ElseIf inc = 22 Then
                TextBox2.Text = DataRow.Item("Q_NO23")
                TextBox3.Text = DataRow.Item("Ans23")

            ElseIf inc = 23 Then
                TextBox2.Text = DataRow.Item("Q_NO24")
                TextBox3.Text = DataRow.Item("Ans24")

            ElseIf inc = 24 Then
                TextBox2.Text = DataRow.Item("Q_NO25")
                TextBox3.Text = DataRow.Item("Ans25")

            ElseIf inc = 25 Then
                TextBox2.Text = DataRow.Item("Q_NO26")
                TextBox3.Text = DataRow.Item("Ans26")

            ElseIf inc = 26 Then
                TextBox2.Text = DataRow.Item("Q_NO27")
                TextBox3.Text = DataRow.Item("Ans27")

            ElseIf inc = 27 Then
                TextBox2.Text = DataRow.Item("Q_NO28")
                TextBox3.Text = DataRow.Item("Ans28")

            ElseIf inc = 28 Then
                TextBox2.Text = DataRow.Item("Q_NO29")
                TextBox3.Text = DataRow.Item("Ans29")



            ElseIf inc = 29 Then
                TextBox2.Text = DataRow.Item("Q_NO30")
                TextBox3.Text = DataRow.Item("Ans30")

            End If


        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If

        If inc = 1 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis2]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis2.BackColor = Color.DarkGreen

        End If
        If inc = 2 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis3]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis3.BackColor = Color.DarkGreen

        End If
        If inc = 3 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis4]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis4.BackColor = Color.DarkGreen

        End If
        If inc = 4 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis5]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis5.BackColor = Color.DarkGreen

        End If
        If inc = 5 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis6]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis6.BackColor = Color.DarkGreen

        End If
        If inc = 6 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis7]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis7.BackColor = Color.DarkGreen

        End If
        If inc = 7 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis8]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis8.BackColor = Color.DarkGreen

        End If
        If inc = 8 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis9]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis9.BackColor = Color.DarkGreen

        End If
        If inc = 9 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis10]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis10.BackColor = Color.DarkGreen

        End If
        If inc = 10 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis11]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis11.BackColor = Color.DarkGreen
        End If
        If inc = 11 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis12]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis12.BackColor = Color.DarkGreen
        End If
        If inc = 12 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis13]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis13.BackColor = Color.DarkGreen
        End If
        If inc = 13 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis14]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis14.BackColor = Color.DarkGreen
        End If
        If inc = 14 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis15]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis15.BackColor = Color.DarkGreen
        End If
        If inc = 15 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis16]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis16.BackColor = Color.DarkGreen
        End If
        If inc = 16 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis17]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis17.BackColor = Color.DarkGreen
        End If
        If inc = 17 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis18]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis18.BackColor = Color.DarkGreen
        End If
        If inc = 18 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis19]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis19.BackColor = Color.DarkGreen
        End If
        If inc = 19 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis20]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis20.BackColor = Color.DarkGreen
        End If
        If inc = 20 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis21]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis21.BackColor = Color.DarkGreen
        End If
        If inc = 21 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis22]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis22.BackColor = Color.DarkGreen
        End If
        If inc = 22 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis23]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis23.BackColor = Color.DarkGreen
        End If
        If inc = 23 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis24]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis24.BackColor = Color.DarkGreen
        End If
        If inc = 24 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis25]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis25.BackColor = Color.DarkGreen
        End If
        If inc = 25 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis26]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis26.BackColor = Color.DarkGreen
        End If
        If inc = 26 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis27]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis27.BackColor = Color.DarkGreen
        End If
        If inc = 27 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis28]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis28.BackColor = Color.DarkGreen
        End If
        If inc = 28 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis29]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis29.BackColor = Color.DarkGreen
        End If
        If inc = 29 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis30]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis30.BackColor = Color.DarkGreen
        End If

        con.Close()
    End Sub
    Private Sub NavigateRecords()

        Try
            lblQuestion.Text = ds.Tables("Q_A").Rows(inc).Item(0).ToString()
            rbtn1.Text = ds.Tables("Q_A").Rows(inc).Item(1).ToString()
            rbtn2.Text = ds.Tables("Q_A").Rows(inc).Item(2).ToString()
            rbtn3.Text = ds.Tables("Q_A").Rows(inc).Item(3).ToString()
            rbtn4.Text = ds.Tables("Q_A").Rows(inc).Item(4).ToString()


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        
    End Sub

    

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        If inc = 0 Then
            MessageBox.Show("First Question")
        Else
            inc = inc - 1

            NavigateRecords()
        End If
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If

        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            If inc = 0 Then
                TextBox2.Text = DataRow.Item("Q_NO1")
                TextBox3.Text = DataRow.Item("Ans1")
            ElseIf inc = 1 Then
                TextBox2.Text = DataRow.Item("Q_NO2")
                TextBox3.Text = DataRow.Item("Ans2")

            ElseIf inc = 2 Then
                TextBox2.Text = DataRow.Item("Q_NO3")
                TextBox3.Text = DataRow.Item("Ans3")

            ElseIf inc = 3 Then
                TextBox2.Text = DataRow.Item("Q_NO4")
                TextBox3.Text = DataRow.Item("Ans4")

            ElseIf inc = 4 Then
                TextBox2.Text = DataRow.Item("Q_NO5")
                TextBox3.Text = DataRow.Item("Ans5")

            ElseIf inc = 5 Then
                TextBox2.Text = DataRow.Item("Q_NO6")
                TextBox3.Text = DataRow.Item("Ans6")

            ElseIf inc = 6 Then
                TextBox2.Text = DataRow.Item("Q_NO7")
                TextBox3.Text = DataRow.Item("Ans7")

            ElseIf inc = 7 Then
                TextBox2.Text = DataRow.Item("Q_NO8")
                TextBox3.Text = DataRow.Item("Ans8")

            ElseIf inc = 8 Then
                TextBox2.Text = DataRow.Item("Q_NO9")
                TextBox3.Text = DataRow.Item("Ans9")

            ElseIf inc = 9 Then
                TextBox2.Text = DataRow.Item("Q_NO10")
                TextBox3.Text = DataRow.Item("Ans10")

            ElseIf inc = 10 Then
                TextBox2.Text = DataRow.Item("Q_NO11")
                TextBox3.Text = DataRow.Item("Ans11")

            ElseIf inc = 11 Then
                TextBox2.Text = DataRow.Item("Q_NO12")
                TextBox3.Text = DataRow.Item("Ans12")

            ElseIf inc = 12 Then
                TextBox2.Text = DataRow.Item("Q_NO13")
                TextBox3.Text = DataRow.Item("Ans13")

            ElseIf inc = 13 Then
                TextBox2.Text = DataRow.Item("Q_NO14")
                TextBox3.Text = DataRow.Item("Ans14")

            ElseIf inc = 14 Then
                TextBox2.Text = DataRow.Item("Q_NO15")
                TextBox3.Text = DataRow.Item("Ans15")
            ElseIf inc = 15 Then
                TextBox2.Text = DataRow.Item("Q_NO16")
                TextBox3.Text = DataRow.Item("Ans16")

            ElseIf inc = 16 Then
                TextBox2.Text = DataRow.Item("Q_NO17")
                TextBox3.Text = DataRow.Item("Ans17")

            ElseIf inc = 17 Then
                TextBox2.Text = DataRow.Item("Q_NO18")
                TextBox3.Text = DataRow.Item("Ans18")

            ElseIf inc = 18 Then
                TextBox2.Text = DataRow.Item("Q_NO19")
                TextBox3.Text = DataRow.Item("Ans19")

            ElseIf inc = 19 Then
                TextBox2.Text = DataRow.Item("Q_NO20")
                TextBox3.Text = DataRow.Item("Ans20")

            ElseIf inc = 20 Then
                TextBox2.Text = DataRow.Item("Q_NO21")
                TextBox3.Text = DataRow.Item("Ans21")

            ElseIf inc = 21 Then
                TextBox2.Text = DataRow.Item("Q_NO22")
                TextBox3.Text = DataRow.Item("Ans22")

            ElseIf inc = 22 Then
                TextBox2.Text = DataRow.Item("Q_NO23")
                TextBox3.Text = DataRow.Item("Ans23")

            ElseIf inc = 23 Then
                TextBox2.Text = DataRow.Item("Q_NO24")
                TextBox3.Text = DataRow.Item("Ans24")

            ElseIf inc = 24 Then
                TextBox2.Text = DataRow.Item("Q_NO25")
                TextBox3.Text = DataRow.Item("Ans25")

            ElseIf inc = 25 Then
                TextBox2.Text = DataRow.Item("Q_NO26")
                TextBox3.Text = DataRow.Item("Ans26")

            ElseIf inc = 26 Then
                TextBox2.Text = DataRow.Item("Q_NO27")
                TextBox3.Text = DataRow.Item("Ans27")

            ElseIf inc = 27 Then
                TextBox2.Text = DataRow.Item("Q_NO28")
                TextBox3.Text = DataRow.Item("Ans28")

            ElseIf inc = 28 Then
                TextBox2.Text = DataRow.Item("Q_NO29")
                TextBox3.Text = DataRow.Item("Ans29")



            ElseIf inc = 29 Then
                TextBox2.Text = DataRow.Item("Q_NO30")
                TextBox3.Text = DataRow.Item("Ans30")

            End If


        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        If inc = 1 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis2]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis2.BackColor = Color.DarkGreen

        End If
        If inc = 2 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis3]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis3.BackColor = Color.DarkGreen

        End If
        If inc = 3 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis4]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis4.BackColor = Color.DarkGreen

        End If
        If inc = 4 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis5]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis5.BackColor = Color.DarkGreen

        End If
        If inc = 5 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis6]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis6.BackColor = Color.DarkGreen

        End If
        If inc = 6 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis7]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis7.BackColor = Color.DarkGreen

        End If
        If inc = 7 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis8]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis8.BackColor = Color.DarkGreen

        End If
        If inc = 8 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis9]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis9.BackColor = Color.DarkGreen

        End If
        If inc = 9 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis10]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis10.BackColor = Color.DarkGreen

        End If
        If inc = 10 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis11]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis11.BackColor = Color.DarkGreen
        End If
        If inc = 11 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis12]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis12.BackColor = Color.DarkGreen
        End If
        If inc = 12 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis13]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis13.BackColor = Color.DarkGreen
        End If
        If inc = 13 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis14]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis14.BackColor = Color.DarkGreen
        End If
        If inc = 14 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis15]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis15.BackColor = Color.DarkGreen
        End If
        If inc = 15 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis16]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis16.BackColor = Color.DarkGreen
        End If
        If inc = 16 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis17]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis17.BackColor = Color.DarkGreen
        End If
        If inc = 17 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis18]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis18.BackColor = Color.DarkGreen
        End If
        If inc = 18 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis19]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis19.BackColor = Color.DarkGreen
        End If
        If inc = 19 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis20]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis20.BackColor = Color.DarkGreen
        End If
        If inc = 20 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis21]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis21.BackColor = Color.DarkGreen
        End If
        If inc = 21 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis22]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis22.BackColor = Color.DarkGreen
        End If
        If inc = 22 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis23]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis23.BackColor = Color.DarkGreen
        End If
        If inc = 23 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis24]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis24.BackColor = Color.DarkGreen
        End If
        If inc = 24 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis25]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis25.BackColor = Color.DarkGreen
        End If
        If inc = 25 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis26]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis26.BackColor = Color.DarkGreen
        End If
        If inc = 26 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis27]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis27.BackColor = Color.DarkGreen
        End If
        If inc = 27 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis28]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis28.BackColor = Color.DarkGreen
        End If
        If inc = 28 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis29]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis29.BackColor = Color.DarkGreen
        End If
        If inc = 29 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis30]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
            cmd.ExecuteNonQuery()
            vis30.BackColor = Color.DarkGreen
        End If

        con.Close()

        
    End Sub

   
    Private Sub btnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLock.Click
        If rbtn1.Checked = True Then
            ans = "A"


        ElseIf rbtn2.Checked = True Then
            ans = "B"


        ElseIf rbtn3.Checked = True Then
            ans = "C"


        ElseIf rbtn4.Checked = True Then
            ans = "D"

        Else
            MsgBox("Please Select Your Answer")
            Return


        End If
        txtRadio.Text = ans

        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim ds As New DataSet
        con = New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Technoshine X.6\Technoshine X.6\bin\MCQ.accdb"

        ds.Tables.Add(dt)
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If




        Dim da As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & 10 & "' ", con)
        da.Fill(dt)
        For Each DataRow In dt.Rows




            If inc = 0 And txtRadio.Text = DataRow.Item(1) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO1='" & 1 & "',[lbl_lock1]='" & 1 & "',[Ans1]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL1.BackColor = Color.OrangeRed


            ElseIf inc = 0 And txtRadio.Text <> DataRow.Item(1) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO1='" & -0.25 & "',[lbl_lock1]='" & 1 & "',[Ans1]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL1.BackColor = Color.OrangeRed


            End If



            If inc = 1 And txtRadio.Text = DataRow.Item(2) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO2='" & 1 & "',[lbl_lock2]='" & 1 & "',[Ans2]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL2.BackColor = Color.OrangeRed

            ElseIf inc = 1 And txtRadio.Text <> DataRow.Item(2) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO2='" & -0.25 & "',[lbl_lock2]='" & 1 & "',[Ans2]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL2.BackColor = Color.OrangeRed

            End If

            If inc = 2 And txtRadio.Text = DataRow.Item(3) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO3='" & 1 & "',[lbl_lock3]='" & 1 & "',[Ans3]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL3.BackColor = Color.OrangeRed


            ElseIf inc = 2 And txtRadio.Text <> DataRow.Item(3) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO3='" & -0.25 & "',[lbl_lock3]='" & 1 & "',[Ans3]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL3.BackColor = Color.OrangeRed

            End If

            If inc = 3 And txtRadio.Text = DataRow.Item(4) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO4='" & 1 & "',[lbl_lock4]='" & 1 & "',[Ans4]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL4.BackColor = Color.OrangeRed

            ElseIf inc = 3 And txtRadio.Text <> DataRow.Item(4) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO4='" & -0.25 & "',[lbl_lock4]='" & 1 & "',[Ans4]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL4.BackColor = Color.OrangeRed

            End If
            If inc = 4 And txtRadio.Text = DataRow.Item(5) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO5='" & 1 & "',[lbl_lock5]='" & 1 & "',[Ans5]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL5.BackColor = Color.OrangeRed

            ElseIf inc = 4 And txtRadio.Text <> DataRow.Item(5) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO5='" & -0.25 & "',[lbl_lock5]='" & 1 & "',[Ans5]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL5.BackColor = Color.OrangeRed

            End If
            If inc = 5 And txtRadio.Text = DataRow.Item(6) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO6='" & 1 & "',[lbl_lock6]='" & 1 & "',[Ans6]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL6.BackColor = Color.OrangeRed

            ElseIf inc = 5 And txtRadio.Text <> DataRow.Item(6) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO6='" & -0.25 & "',[lbl_lock6]='" & 1 & "',[Ans6]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL6.BackColor = Color.OrangeRed

            End If
            If inc = 6 And txtRadio.Text = DataRow.Item(7) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO7='" & 1 & "',[lbl_lock7]='" & 1 & "',[Ans7]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL7.BackColor = Color.OrangeRed

            ElseIf inc = 6 And txtRadio.Text <> DataRow.Item(7) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO7='" & -0.25 & "',[lbl_lock7]='" & 1 & "',[Ans7]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL7.BackColor = Color.OrangeRed

            End If

            If inc = 7 And txtRadio.Text = DataRow.Item(8) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO8='" & 1 & "',[lbl_lock8]='" & 1 & "',[Ans8]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL8.BackColor = Color.OrangeRed

            ElseIf inc = 7 And txtRadio.Text <> DataRow.Item(8) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO8='" & -0.25 & "',[lbl_lock8]='" & 1 & "',[Ans8]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL8.BackColor = Color.OrangeRed

            End If
            If inc = 8 And txtRadio.Text = DataRow.Item(9) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO9='" & 1 & "',[lbl_lock9]='" & 1 & "',[Ans9]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL9.BackColor = Color.OrangeRed

            ElseIf inc = 8 And txtRadio.Text <> DataRow.Item(9) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO9='" & -0.25 & "',[lbl_lock9]='" & 1 & "',[Ans9]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL9.BackColor = Color.OrangeRed

            End If

            If inc = 9 And txtRadio.Text = DataRow.Item(10) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO10='" & 1 & "',[lbl_lock10]='" & 1 & "',[Ans10]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL10.BackColor = Color.OrangeRed

            ElseIf inc = 9 And txtRadio.Text <> DataRow.Item(10) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO10='" & -0.25 & "',[lbl_lock10]='" & 1 & "',[Ans10]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL10.BackColor = Color.OrangeRed

            End If
            If inc = 10 And txtRadio.Text = DataRow.Item(11) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO11='" & 1 & "',[lbl_lock11]='" & 1 & "',[Ans11]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL11.BackColor = Color.OrangeRed

            ElseIf inc = 10 And txtRadio.Text <> DataRow.Item(11) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO11='" & -0.25 & "',[lbl_lock11]='" & 1 & "',[Ans11]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL11.BackColor = Color.OrangeRed

            End If

            If inc = 11 And txtRadio.Text = DataRow.Item(12) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO12='" & 1 & "',[lbl_lock12]='" & 1 & "',[Ans12]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL12.BackColor = Color.OrangeRed

            ElseIf inc = 11 And txtRadio.Text <> DataRow.Item(12) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO12='" & -0.25 & "',[lbl_lock12]='" & 1 & "',[Ans12]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL12.BackColor = Color.OrangeRed

            End If

            If inc = 12 And txtRadio.Text = DataRow.Item(13) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO13='" & 1 & "',[lbl_lock13]='" & 1 & "',[Ans13]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL13.BackColor = Color.OrangeRed

            ElseIf inc = 12 And txtRadio.Text <> DataRow.Item(13) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO13='" & -0.25 & "',[lbl_lock13]='" & 1 & "',[Ans13]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL13.BackColor = Color.OrangeRed

            End If
            If inc = 13 And txtRadio.Text = DataRow.Item(14) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO14='" & 1 & "',[lbl_lock14]='" & 1 & "',[Ans14]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL14.BackColor = Color.OrangeRed

            ElseIf inc = 13 And txtRadio.Text <> DataRow.Item(14) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO14='" & -0.25 & "',[lbl_lock14]='" & 1 & "',[Ans14]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL14.BackColor = Color.OrangeRed

            End If

            If inc = 14 And txtRadio.Text = DataRow.Item(15) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO15='" & 1 & "',[lbl_lock15]='" & 1 & "',[Ans15]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL15.BackColor = Color.OrangeRed

            ElseIf inc = 14 And txtRadio.Text <> DataRow.Item(15) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO15='" & -0.25 & "',[lbl_lock15]='" & 1 & "',[Ans15]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL15.BackColor = Color.OrangeRed

            End If

            If inc = 15 And txtRadio.Text = DataRow.Item(16) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO16='" & 1 & "',[lbl_lock16]='" & 1 & "',[Ans16]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL16.BackColor = Color.OrangeRed

            ElseIf inc = 15 And txtRadio.Text <> DataRow.Item(16) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO16='" & -0.25 & "',[lbl_lock16]='" & 1 & "',[Ans16]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL16.BackColor = Color.OrangeRed

            End If

            If inc = 16 And txtRadio.Text = DataRow.Item(17) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO17='" & 1 & "',[lbl_lock17]='" & 1 & "',[Ans17]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL17.BackColor = Color.OrangeRed

            ElseIf inc = 16 And txtRadio.Text <> DataRow.Item(17) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO17='" & -0.25 & "',[lbl_lock17]='" & 1 & "',[Ans17]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL17.BackColor = Color.OrangeRed

            End If

            If inc = 17 And txtRadio.Text = DataRow.Item(18) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO18='" & 1 & "',[lbl_lock18]='" & 1 & "',[Ans18]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL18.BackColor = Color.OrangeRed

            ElseIf inc = 17 And txtRadio.Text <> DataRow.Item(18) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO18='" & -0.25 & "',[lbl_lock18]='" & 1 & "',[Ans18]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL18.BackColor = Color.OrangeRed

            End If

            If inc = 18 And txtRadio.Text = DataRow.Item(19) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO19='" & 1 & "',[lbl_lock19]='" & 1 & "',[Ans19]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL19.BackColor = Color.OrangeRed

            ElseIf inc = 18 And txtRadio.Text <> DataRow.Item(19) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO19='" & -0.25 & "',[lbl_lock19]='" & 1 & "',[Ans19]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL19.BackColor = Color.OrangeRed

            End If
            If inc = 19 And txtRadio.Text = DataRow.Item(20) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO20='" & 1 & "',[lbl_lock20]='" & 1 & "',[Ans20]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL20.BackColor = Color.OrangeRed

            ElseIf inc = 19 And txtRadio.Text <> DataRow.Item(20) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO20='" & -0.25 & "',[lbl_lock20]='" & 1 & "',[Ans20]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL20.BackColor = Color.OrangeRed

            End If

            If inc = 20 And txtRadio.Text = DataRow.Item(21) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO21='" & 1 & "',[lbl_lock21]='" & 1 & "',[Ans21]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL21.BackColor = Color.OrangeRed

            ElseIf inc = 20 And txtRadio.Text <> DataRow.Item(21) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO21='" & -0.25 & "',[lbl_lock21]='" & 1 & "',[Ans21]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL21.BackColor = Color.OrangeRed

            End If

            If inc = 21 And txtRadio.Text = DataRow.Item(22) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO22='" & 1 & "',[lbl_lock22]='" & 1 & "',[Ans22]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL22.BackColor = Color.OrangeRed

            ElseIf inc = 21 And txtRadio.Text <> DataRow.Item(22) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO22='" & -0.25 & "',[lbl_lock22]='" & 1 & "',[Ans22]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL22.BackColor = Color.OrangeRed

            End If
            If inc = 22 And txtRadio.Text = DataRow.Item(23) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO23='" & 1 & "',[lbl_lock23]='" & 1 & "',[Ans23]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL23.BackColor = Color.OrangeRed

            ElseIf inc = 22 And txtRadio.Text <> DataRow.Item(23) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO23='" & -0.25 & "',[lbl_lock23]='" & 1 & "',[Ans23]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL23.BackColor = Color.OrangeRed

            End If

            If inc = 23 And txtRadio.Text = DataRow.Item(24) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO24='" & 1 & "',[lbl_lock24]='" & 1 & "',[Ans24]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL24.BackColor = Color.OrangeRed

            ElseIf inc = 23 And txtRadio.Text <> DataRow.Item(24) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO24='" & -0.25 & "',[lbl_lock24]='" & 1 & "',[Ans24]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL24.BackColor = Color.OrangeRed

            End If
            If inc = 24 And txtRadio.Text = DataRow.Item(25) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO25='" & 1 & "',[lbl_lock25]='" & 1 & "',[Ans25]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL25.BackColor = Color.OrangeRed

            ElseIf inc = 24 And txtRadio.Text <> DataRow.Item(25) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO25='" & -0.25 & "',[lbl_lock25]='" & 1 & "',[Ans25]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL25.BackColor = Color.OrangeRed

            End If

            If inc = 25 And txtRadio.Text = DataRow.Item(26) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO26='" & 1 & "',[lbl_lock26]='" & 1 & "',[Ans26]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL26.BackColor = Color.OrangeRed

            ElseIf inc = 25 And txtRadio.Text <> DataRow.Item(26) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO26='" & -0.25 & "',[lbl_lock26]='" & 1 & "',[Ans26]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL26.BackColor = Color.OrangeRed

            End If

            If inc = 26 And txtRadio.Text = DataRow.Item(27) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO27='" & 1 & "',[lbl_lock27]='" & 1 & "',[Ans27]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL27.BackColor = Color.OrangeRed

            ElseIf inc = 26 And txtRadio.Text <> DataRow.Item(27) Then
                txtWrong.Text = Val(txtWrong.Text) + 1

                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO27='" & -0.25 & "',[lbl_lock27]='" & 1 & "',[Ans27]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL27.BackColor = Color.OrangeRed

            End If

            If inc = 27 And txtRadio.Text = DataRow.Item(28) Then
                txtRight.Text = Val(txtRight.Text) + 1

                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO28='" & 1 & "',[lbl_lock28]='" & 1 & "',[Ans28]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL28.BackColor = Color.OrangeRed

            ElseIf inc = 27 And txtRadio.Text <> DataRow.Item(28) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO28='" & -0.25 & "',[lbl_lock28]='" & 1 & "',[Ans28]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL28.BackColor = Color.OrangeRed

            End If

            If inc = 28 And txtRadio.Text = DataRow.Item(29) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO29='" & 1 & "',[lbl_lock29]='" & 1 & "',[Ans29]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL29.BackColor = Color.OrangeRed

            ElseIf inc = 28 And txtRadio.Text <> DataRow.Item(29) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO29='" & -0.25 & "',[lbl_lock29]='" & 1 & "',[Ans29]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL29.BackColor = Color.OrangeRed

            End If

            If inc = 29 And txtRadio.Text = DataRow.Item(30) Then
                txtRight.Text = Val(txtRight.Text) + 1
                cmd.Connection = con

                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO30='" & 1 & "',[lbl_lock30]='" & 1 & "',[Ans30]='" & Me.txtRadio.Text & "',[RIGHT]='" & Me.txtRight.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL30.BackColor = Color.OrangeRed

            ElseIf inc = 29 And txtRadio.Text <> DataRow.Item(30) Then
                txtWrong.Text = Val(txtWrong.Text) + 1
                cmd.Connection = con
                cmd.CommandText = "UPDATE Gamer" & " SET Q_NO30='" & -0.25 & "',[lbl_lock30]='" & 1 & "',[Ans30]='" & Me.txtRadio.Text & "',[WRONG]='" & Me.txtWrong.Text & "' WHERE [ID]='" & Me.lblUser.Text & "'"
                cmd.ExecuteNonQuery()
                lblL30.BackColor = Color.OrangeRed

            End If

        Next

        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            If inc = 0 Then
                TextBox2.Text = DataRow.Item("Q_NO1")

            ElseIf inc = 1 Then
                TextBox2.Text = DataRow.Item("Q_NO2")


            ElseIf inc = 2 Then
                TextBox2.Text = DataRow.Item("Q_NO3")


            ElseIf inc = 3 Then
                TextBox2.Text = DataRow.Item("Q_NO4")


            ElseIf inc = 4 Then
                TextBox2.Text = DataRow.Item("Q_NO5")


            ElseIf inc = 5 Then
                TextBox2.Text = DataRow.Item("Q_NO6")


            ElseIf inc = 6 Then
                TextBox2.Text = DataRow.Item("Q_NO7")


            ElseIf inc = 7 Then
                TextBox2.Text = DataRow.Item("Q_NO8")


            ElseIf inc = 8 Then
                TextBox2.Text = DataRow.Item("Q_NO9")


            ElseIf inc = 9 Then
                TextBox2.Text = DataRow.Item("Q_NO10")


            ElseIf inc = 10 Then
                TextBox2.Text = DataRow.Item("Q_NO11")


            ElseIf inc = 11 Then
                TextBox2.Text = DataRow.Item("Q_NO12")


            ElseIf inc = 12 Then
                TextBox2.Text = DataRow.Item("Q_NO13")


            ElseIf inc = 13 Then
                TextBox2.Text = DataRow.Item("Q_NO14")


            ElseIf inc = 14 Then
                TextBox2.Text = DataRow.Item("Q_NO15")

            ElseIf inc = 15 Then
                TextBox2.Text = DataRow.Item("Q_NO16")


            ElseIf inc = 16 Then
                TextBox2.Text = DataRow.Item("Q_NO17")


            ElseIf inc = 17 Then
                TextBox2.Text = DataRow.Item("Q_NO18")


            ElseIf inc = 18 Then
                TextBox2.Text = DataRow.Item("Q_NO19")


            ElseIf inc = 19 Then
                TextBox2.Text = DataRow.Item("Q_NO20")


            ElseIf inc = 20 Then
                TextBox2.Text = DataRow.Item("Q_NO21")


            ElseIf inc = 21 Then
                TextBox2.Text = DataRow.Item("Q_NO22")


            ElseIf inc = 22 Then
                TextBox2.Text = DataRow.Item("Q_NO23")


            ElseIf inc = 23 Then
                TextBox2.Text = DataRow.Item("Q_NO24")


            ElseIf inc = 24 Then
                TextBox2.Text = DataRow.Item("Q_NO25")


            ElseIf inc = 25 Then
                TextBox2.Text = DataRow.Item("Q_NO26")


            ElseIf inc = 26 Then
                TextBox2.Text = DataRow.Item("Q_NO27")


            ElseIf inc = 27 Then
                TextBox2.Text = DataRow.Item("Q_NO28")


            ElseIf inc = 28 Then
                TextBox2.Text = DataRow.Item("Q_NO29")




            ElseIf inc = 29 Then
                TextBox2.Text = DataRow.Item("Q_NO30")


            End If


        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
        End If

        con.Close()


        
    End Sub

    
    Private Sub count()
        score = score + 1

    End Sub
    Protected Sub vis1_Click(sender As Object, e As EventArgs) Handles vis1.Click
        inc = 0

        btnPrev.Enabled = False
        btnNext.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO1")
            TextBox3.Text = DataRow.Item("Ans1")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        ElseIf TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(0).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(0).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(0).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(0).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(0).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis1]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis1.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis2_Click(sender As Object, e As EventArgs) Handles vis2.Click
        inc = 1

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO2")
            TextBox3.Text = DataRow.Item("Ans2")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(1).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(1).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(1).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(1).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(1).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis2]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis2.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis3_Click(sender As Object, e As EventArgs) Handles vis3.Click
        inc = 2

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO3")
            TextBox3.Text = DataRow.Item("Ans3")
        Next
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If

        Try

            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(2).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(2).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(2).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(2).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(2).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis3]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis3.BackColor = Color.DarkGreen



    End Sub

    Protected Sub vis4_Click(sender As Object, e As EventArgs) Handles vis4.Click
        inc = 3

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO4")
            TextBox3.Text = DataRow.Item("Ans4")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(3).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(3).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(3).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(3).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(3).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis4]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis4.BackColor = Color.DarkGreen



    End Sub

    Protected Sub vis5_Click(sender As Object, e As EventArgs) Handles vis5.Click
        inc = 4

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO5")
            TextBox3.Text = DataRow.Item("Ans5")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(4).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(4).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(4).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(4).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(4).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis5]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis5.BackColor = Color.DarkGreen



    End Sub

    Protected Sub vis6_Click(sender As Object, e As EventArgs) Handles vis6.Click
        inc = 5

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO6")
            TextBox3.Text = DataRow.Item("Ans6")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = True
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(5).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(5).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(5).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(5).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(5).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis6]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis6.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis7_Click(sender As Object, e As EventArgs) Handles vis7.Click
        inc = 6

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO7")
            TextBox3.Text = DataRow.Item("Ans7")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(6).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(6).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(6).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(6).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(6).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis7]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis7.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis8_Click(sender As Object, e As EventArgs) Handles vis8.Click
        inc = 7

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO8")
            TextBox3.Text = DataRow.Item("Ans8")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(7).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(7).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(7).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(7).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(7).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis8]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis8.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis9_Click(sender As Object, e As EventArgs) Handles vis9.Click
        inc = 8

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False

        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO9")
            TextBox3.Text = DataRow.Item("Ans9")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(8).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(8).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(8).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(8).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(8).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis9]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis9.BackColor = Color.DarkGreen

    End Sub

    Protected Sub vis10_Click(sender As Object, e As EventArgs) Handles vis10.Click
        inc = 9

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO10")
            TextBox3.Text = DataRow.Item("Ans10")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(9).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(9).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(9).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(9).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(9).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis10]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis10.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis11_Click(sender As Object, e As EventArgs) Handles vis11.Click
        inc = 10

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False

        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO11")
            TextBox3.Text = DataRow.Item("Ans11")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(10).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(10).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(10).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(10).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(10).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis11]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis11.BackColor = Color.DarkGreen

    End Sub

    Protected Sub vis12_Click(sender As Object, e As EventArgs) Handles vis12.Click
        inc = 11

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False

        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO12")
            TextBox3.Text = DataRow.Item("Ans12")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(11).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(11).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(11).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(11).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(11).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis12]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis12.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis13_Click(sender As Object, e As EventArgs) Handles vis13.Click
        inc = 12

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO13")
            TextBox3.Text = DataRow.Item("Ans13")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(12).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(12).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(12).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(12).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(12).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis13]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis13.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis14_Click(sender As Object, e As EventArgs) Handles vis14.Click
        inc = 13

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO4")
            TextBox3.Text = DataRow.Item("Ans14")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(13).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(13).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(13).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(13).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(13).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis14]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis14.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis15_Click(sender As Object, e As EventArgs) Handles vis15.Click
        inc = 14

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO15")
            TextBox3.Text = DataRow.Item("Ans15")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(14).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(14).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(14).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(14).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(14).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis15]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis15.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis16_Click(sender As Object, e As EventArgs) Handles vis16.Click
        inc = 15

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO16")
            TextBox3.Text = DataRow.Item("Ans16")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(15).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(15).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(15).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(15).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(15).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis16]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis16.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis17_Click(sender As Object, e As EventArgs) Handles vis17.Click
        inc = 16

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO17")
            TextBox3.Text = DataRow.Item("Ans17")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(16).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(16).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(16).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(16).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(16).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis17]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis17.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis18_Click(sender As Object, e As EventArgs) Handles vis18.Click
        inc = 17

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False

        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO18")
            TextBox3.Text = DataRow.Item("Ans18")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(17).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(17).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(17).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(17).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(17).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis18]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis18.BackColor = Color.DarkGreen

    End Sub

    Protected Sub vis19_Click(sender As Object, e As EventArgs) Handles vis19.Click
        inc = 18

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False

        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO19")
            TextBox3.Text = DataRow.Item("Ans19")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(18).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(18).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(18).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(18).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(18).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis19]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis19.BackColor = Color.DarkGreen

    End Sub

    Protected Sub vis20_Click(sender As Object, e As EventArgs) Handles vis20.Click
        inc = 19

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO20")
            TextBox3.Text = DataRow.Item("Ans20")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(19).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(19).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(19).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(19).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(19).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis20]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis20.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis21_Click(sender As Object, e As EventArgs) Handles vis21.Click
        inc = 20

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO21")
            TextBox3.Text = DataRow.Item("Ans21")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(20).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(20).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(20).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(20).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(20).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis21]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis21.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis22_Click(sender As Object, e As EventArgs) Handles vis22.Click
        inc = 21

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO22")
            TextBox3.Text = DataRow.Item("Ans22")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(21).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(21).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(21).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(21).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(21).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis22]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis22.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis23_Click(sender As Object, e As EventArgs) Handles vis23.Click
        inc = 22

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO23")
            TextBox3.Text = DataRow.Item("Ans23")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(22).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(22).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(22).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(22).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(22).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis23]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis23.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis24_Click(sender As Object, e As EventArgs) Handles vis24.Click
        inc = 23

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO24")
            TextBox3.Text = DataRow.Item("Ans24")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(23).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(23).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(23).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(23).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(23).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis24]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis24.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis25_Click(sender As Object, e As EventArgs) Handles vis25.Click
        inc = 24

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False

        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO25")
            TextBox3.Text = DataRow.Item("Ans25")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(24).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(24).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(24).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(24).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(24).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis25]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis25.BackColor = Color.DarkGreen

    End Sub

    Protected Sub vis26_Click(sender As Object, e As EventArgs) Handles vis26.Click

        inc = 25

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO26")
            TextBox3.Text = DataRow.Item("Ans26")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(25).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(25).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(25).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(25).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(25).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis26]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis26.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis27_Click(sender As Object, e As EventArgs) Handles vis27.Click
        inc = 26

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO27")
            TextBox3.Text = DataRow.Item("Ans27")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(26).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(26).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(26).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(26).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(26).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis27]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis27.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis28_Click(sender As Object, e As EventArgs) Handles vis28.Click
        inc = 27

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO28")
            TextBox3.Text = DataRow.Item("Ans28")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = False
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(27).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(27).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(27).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(27).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(27).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis28]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis28.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis29_Click(sender As Object, e As EventArgs) Handles vis29.Click
        inc = 28

        btnNext.Enabled = True
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO29")
            TextBox3.Text = DataRow.Item("Ans29")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(28).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(28).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(28).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(28).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(28).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis29]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis29.BackColor = Color.DarkGreen


    End Sub

    Protected Sub vis30_Click(sender As Object, e As EventArgs) Handles vis30.Click
        


        inc = 29

        btnNext.Enabled = False
        btnPrev.Enabled = True
        rbtn2.Checked = False
        rbtn3.Checked = False
        rbtn4.Checked = False
        rbtn1.Checked = False
        Dim sa As New OleDb.OleDbDataAdapter("select * from Gamer where [ID]='" & Me.lblUser.Text & "'", con)
        sa.Fill(dt)
        For Each DataRow In dt.Rows
            TextBox2.Text = DataRow.Item("Q_NO30")
            TextBox3.Text = DataRow.Item("Ans30")
        Next
        If TextBox2.Text = "0.25" Or "1" Then

            rbtn2.Enabled = False
            rbtn3.Enabled = False
            rbtn4.Enabled = False
            rbtn1.Enabled = False
            btnLock.Enabled = False
        End If
        If TextBox2.Text = "0" Then

            rbtn2.Enabled = True
            rbtn3.Enabled = True
            rbtn4.Enabled = True
            rbtn1.Enabled = True
            btnLock.Enabled = True
        End If
        If TextBox3.Text = "A" Then
            rbtn1.Checked = True
        ElseIf TextBox3.Text = "B" Then
            rbtn2.Checked = True
        ElseIf TextBox3.Text = "C" Then
            rbtn3.Checked = True
        ElseIf TextBox3.Text = "D" Then
            rbtn4.Checked = True
        End If
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Q_A ", con)
            da.Fill(ds, "Q_A")
            If ds.Tables("Q_A").Rows.Count > 0 Then

                lblQuestion.Text = ds.Tables("Q_A").Rows(29).Item(0).ToString()
                rbtn1.Text = ds.Tables("Q_A").Rows(29).Item(1).ToString()
                rbtn2.Text = ds.Tables("Q_A").Rows(29).Item(2).ToString()
                rbtn3.Text = ds.Tables("Q_A").Rows(29).Item(3).ToString()
                rbtn4.Text = ds.Tables("Q_A").Rows(29).Item(4).ToString()


            End If




        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cmd.Connection = con

        cmd.CommandText = "UPDATE Gamer" & " SET [lbl_vis30]='" & 2 & "' WHERE [ID]='" & Me.lblUser.Text & "'"
        cmd.ExecuteNonQuery()
        vis30.BackColor = Color.DarkGreen


    End Sub

    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim second As Integer = lblTimeSec.Text
        Dim id As Integer = 0
        lblTimeSec.Text = lblTimeSec.Text - 1
        If lblTimeSec.Text = -1 Then
            lblTimeSec.Text = 60
            lbltimeMin.Text = lbltimeMin.Text - 1
        End If
        Dim cmd As New OleDb.OleDbCommand
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        If lbltimeMin.Text = -1 And lblTimeSec.Text = 60 Then
            Me.Hide()
            frmResult.Show()
        End If
        If lbltimeMin.Text = 29 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 28 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 27 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 26 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 25 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()



        ElseIf lbltimeMin.Text = 24 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 23 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()



        ElseIf lbltimeMin.Text = 22 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 21 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 20 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 19 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 18 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 17 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 16 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 15 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 14 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 14 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 13 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 12 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 11 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 10 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 9 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 8 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 7 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 6 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 5 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 4 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 3 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 2 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 1 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()




        ElseIf lbltimeMin.Text = 0 And lblTimeSec.Text = 60 Then
            cmd.Connection = con

            cmd.CommandText = "UPDATE Q_A" & " SET [Time]='" & Me.lbltimeMin.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()
        End If

        While (second >= 0)
            cmd.Connection = con
            cmd.CommandText = "UPDATE Q_A" & " SET [Second_Time]='" & Me.lblTimeSec.Text & "'WHERE [ID]='1'"
            cmd.ExecuteNonQuery()
            second = second - 1
        End While
        con.Close()
    End Sub

    Private Sub lbltimeMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltimeMin.Click

    End Sub
    
End Class
