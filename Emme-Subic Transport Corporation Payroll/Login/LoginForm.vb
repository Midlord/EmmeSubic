Imports System.Data.SqlClient
Imports System.Configuration
Public Class LoginForm

    Public user_id As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Date.Now.ToString("dddd | MMM dd, yyyy hh:mm:ss")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using connection As New SqlConnection(connString)
            Dim reader As SqlDataReader
            Dim command As New SqlCommand("select id, firstName, lastName, userName, Password, role  from [EmmeSubic].[dbo].[Users] where userName = @username and Password = @password and isDeleted = 0", connection)

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
                Dim com As New SqlCommand("insert into [EmmeSubic].[dbo].[Histories] (user_id,action,login_date) VALUES (@userId,@action,@loginDate)", connection)

                reader = command.ExecuteReader()
                Dim Name As String = ""
                While reader.Read()
                    Console.WriteLine(String.Format("{0}, {1}, {2}, {3}",
                       reader(0), reader(1), reader(2), reader(3)))
                    user_id = reader(0)
                    Name = reader(1) + " " + reader(2)
                End While
                connection.Close()

                com.Parameters.Add("@userId", SqlDbType.Int).Value = user_id
                com.Parameters.Add("@action", SqlDbType.Text).Value = Name + " admin login at " + dob
                com.Parameters.Add("@loginDate", SqlDbType.DateTime).Value = dob
                connection.Open()
                'hide this page
                TbxUserName.Text = ""
                Password.Text = ""

                'Redirect to homepage
                com.ExecuteNonQuery()
                MsgBox("Login Successfully!")

                Me.Hide()
                Home.Show()
                connection.Close()
            End If
        End Using
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
End Class
