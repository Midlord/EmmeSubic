Imports System.Data.SqlClient
Public Class LoginForm

    Dim connection As New SqlConnection("Server=DESKTOP-BBDJH6Q; Database = EmmeSubic; Integrated Security = true")
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
        Dim reader As SqlDataReader
        Dim command As New SqlCommand("select id, firstName, lastName, userName, Password  from Users where userName = @username and Password = @password", connection)

        command.Parameters.Add("@username", SqlDbType.VarChar).Value = TbxUserName.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = Password.Text

        Dim dob As DateTime = Date.Now
        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()
        adapter.Fill(table)


        If table.Rows.Count() <= 0 Then
            'failed
            MessageBox.Show("Username Or Password Are Invalid")

        Else
            connection.Open()
            'success
            MessageBox.Show("Login Successfully")

            Dim com As New SqlCommand("insert into Histories (user_id,action,login_date) VALUES (@userId,@action,@loginDate)", connection)

            reader = command.ExecuteReader()
            Dim Name As String = ""
            While reader.Read()
                Console.WriteLine(String.Format("{0}, {1}, {2}",
               reader(0), reader(1), reader(2)))
                hidId.Text = reader(0)
                Name = reader(1) + " " + reader(2)
            End While
            connection.Close()

            com.Parameters.Add("@userId", SqlDbType.Int).Value = hidId.Text
            com.Parameters.Add("@action", SqlDbType.Text).Value = Name + " admin login at " + dob
            com.Parameters.Add("@loginDate", SqlDbType.DateTime).Value = dob
            connection.Open()
            'hide this page
            TbxUserName.Text = ""
            Password.Text = ""
            'Me.Hide()
            'Redirect to homepage
            com.ExecuteNonQuery()

            Home.Show()

            connection.Close()


        End If



    End Sub

    Private Sub PictureExit_Click(sender As Object, e As EventArgs) Handles PictureExit.Click
        Me.Close()
    End Sub

    Private Sub PictureMax_Click(sender As Object, e As EventArgs) Handles PictureMax.Click
        Me.WindowState = FormWindowState.Maximized
        PictureRest.Visible = True
        PictureMax.Visible = False
    End Sub

    Private Sub PictureMin_Click(sender As Object, e As EventArgs) Handles PictureMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PictureRest_Click(sender As Object, e As EventArgs) Handles PictureRest.Click
        Me.WindowState = FormWindowState.Normal
        PictureRest.Visible = False
        PictureMax.Visible = True


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles hidId.TextChanged
        'Dim connection As New SqlConnection("Server=DESKTOP-BBDJH6Q; Database = EmmeSubic; Integrated Security = true")
        'Dim command As New SqlCommand("select id, firstName, lastName, userName, Password  from Users where userName = @username and Password = @password or userId", connection)
        'hidId.Text = command.Parameters.Add("@userId", SqlDbType.Int).Value
    End Sub
End Class
