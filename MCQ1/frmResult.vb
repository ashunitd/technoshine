Public Class frmResult
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Private Sub frmResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        lblUser.Text = Form1.puser
        lblRight.Text = Form1.rightans
        lblWrong.Text = Form1.wrongans
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MCQ.accdb"
        Dim n As Integer = 1
        Dim n1 As Integer = 1
        Dim sc1 As Single
        Dim dt = New DataTable()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Gamer WHERE [ID]='" & Me.lblUser.Text & "'", con)
        da.Fill(dt)
        For Each DataRow In dt.Rows


            sc1 = Val(DataRow.Item(1)) + Val(DataRow.Item(2)) + Val(DataRow.Item(3)) + Val(DataRow.Item(4)) + Val(DataRow.Item(5)) + Val(DataRow.Item(6)) + Val(DataRow.Item(7)) + Val(DataRow.Item(8)) + Val(DataRow.Item(9)) + Val(DataRow.Item(10)) + Val(DataRow.Item(11)) + Val(DataRow.Item(12)) + Val(DataRow.Item(13)) + Val(DataRow.Item(14)) + Val(DataRow.Item(15)) + Val(DataRow.Item(16)) + Val(DataRow.Item(17)) + Val(DataRow.Item(18)) + Val(DataRow.Item(19)) + Val(DataRow.Item(20)) + Val(DataRow.Item(21)) + Val(DataRow.Item(22)) + Val(DataRow.Item(23)) + Val(DataRow.Item(24)) + Val(DataRow.Item(25)) + Val(DataRow.Item(26)) + Val(DataRow.Item(27)) + Val(DataRow.Item(28)) + Val(DataRow.Item(29)) + Val(DataRow.Item(30))


        Next
        Score.Text = sc1



    End Sub
    Private Sub frmResult_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        con = New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MCQ.accdb"
        Dim s1 As Integer = 1
        Dim t1 As Integer = 1
        Dim q1 As Integer = 1
        Dim X As String = ""
        X = "NULL"
        If Not con.State = ConnectionState.Open Then
            con.open
        End If
        While (s1 <= 30)


            cmd.Connection = con
            cmd.CommandText = "UPDATE Q_A" & " SET [User_Answer]='" & "" & "'WHERE [ID]='" & s1 & "'"
            cmd.ExecuteNonQuery()
            s1 = s1 + 1
        End While
        While (t1 <= 30)


            cmd.Connection = con
            cmd.CommandText = "UPDATE Q_A" & " SET [lbl_lock]='" & "" & "'WHERE [ID]='" & t1 & "'"
            cmd.ExecuteNonQuery()
            t1 = t1 + 1
        End While
        While (q1 <= 30)


            cmd.Connection = con
            cmd.CommandText = "UPDATE Q_A" & " SET [lbl_vis]='" & "" & "'WHERE [ID]='" & q1 & "'"
            cmd.ExecuteNonQuery()
            q1 = q1 + 1
        End While
        cmd.Connection = con
        cmd.CommandText = "UPDATE Q_A" & " SET [Second_Time]='" & 60 & "' WHERE [ID]='1'"
        cmd.ExecuteNonQuery()

        con.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub
End Class