Imports System.Data.SqlClient
Public Class LoginForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Date.Now.ToString("dddd | MMM dd, yyyy hh:mm:ss")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim connection As New SqlConnection("Server=DESKTOP-BBDJH6Q; Database = EmmeSubic; Integrated Security = true")
        Dim command As New SqlCommand("select firstName, lastName, userName, Password  from Users where userName = @username and Password = @password", connection)

        ' Dim conn As New SqlConnection("Server=DESKTOP-BBDJH6Q; Database = EmmeSubic; Integrated Security = true")
        ' Dim comm As New SqlCommand("select * FROM Tracker where userName = @userName and timeIn = @In", connection)

        command.Parameters.Add("@username", SqlDbType.VarChar).Value = TbxUserName.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = Password.Text

        ' comm.Parameters.Add("@userName", SqlDbType.VarChar).Value = TbxUserName.Text
        ' comm.Parameters.Add("@In", SqlDbType.DateTime).Value = Date.Now.ToString("MMM dd, yyyy hh:mm:ss")

        Dim adapter As New SqlDataAdapter(command)
        'Dim adapt As New SqlDataAdapter(comm)

        Dim table As New DataTable()
        'Dim tbl As New DataTable()

        adapter.Fill(table)
        ' adapt.Fill(tbl)

        If table.Rows.Count() <= 0 Then
            'failed
            MessageBox.Show("Username Or Password Are Invalid")

        Else
            'success
            MessageBox.Show("Login Successfully")

            'hide this page
            TbxUserName.Text = ""
            Password.Text = ""
            Me.Hide()
            'Redirect to homepage
            Home.Show()

        End If



    End Sub


End Class
