Imports System.Data.SqlClient
Imports System.Configuration
Public Class Home


    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using connection As New SqlConnection(connString)


            Dim dob As DateTime = Date.Now
            Dim command As New SqlCommand("select id, firstName, lastName, userName from Users 
                                        where id = @userId", connection)
            Dim com As New SqlCommand("insert into Histories (user_id,action,login_date) VALUES (@userId,@action,@loginDate)", connection)

            command.Parameters.Add("@userId", SqlDbType.Int).Value = LoginForm.user_id

            Dim reader As SqlDataReader
            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then
                'failed
                MessageBox.Show("Username Or Password Are Invalid")
            Else
                connection.Open()
                reader = command.ExecuteReader()

                Dim Name As String = ""
                While reader.Read()
                    Console.WriteLine(String.Format("{0}, {1}, {2}, {3}",
                       reader(0), reader(1), reader(2), reader(3)))
                    LoginForm.user_id = reader(0)
                    Name = reader(1) + " " + reader(2)
                End While
                connection.Close()
                com.Parameters.Add("@userId", SqlDbType.Int).Value = LoginForm.user_id
                com.Parameters.Add("@action", SqlDbType.Text).Value = Name + " admin logout at " + dob
                com.Parameters.Add("@loginDate", SqlDbType.DateTime).Value = dob

                connection.Open()
                'hide this page

                'Redirect to homepage
                com.ExecuteNonQuery()
                MsgBox("Logout Successfully!")

                Me.Close()
                LoginForm.Show()
                connection.Close()
            End If

        End Using

    End Sub

    Private Sub BtnNewAdmin_Click(sender As Object, e As EventArgs) Handles btnNewAdmin.Click
        If LoginForm.user_id <> 1 Then
            MsgBox("You can't create a new admin! Please Contact the Main Administrator!")
        Else
            Me.Hide()
            Adminregister.Show()
        End If

    End Sub

    Private Sub PictureMin_Click(sender As Object, e As EventArgs) Handles PictureMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureMax_Click(sender As Object, e As EventArgs) Handles PictureMax.Click
        Me.WindowState = FormWindowState.Maximized
        PictureRest.Visible = True
        PictureMax.Visible = False
    End Sub
    Private Sub PictureRest_Click(sender As Object, e As EventArgs) Handles PictureRest.Click
        Me.WindowState = FormWindowState.Normal
        PictureRest.Visible = False
        PictureMax.Visible = True
    End Sub

    Private Sub PictureExit_Click(sender As Object, e As EventArgs) Handles PictureExit.Click
        Me.Close()
    End Sub

    Private Sub BtnNewEmployee_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

        Me.Show()

    End Sub

    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click


        If LoginForm.user_id <> 1 Then
            MsgBox("You can't view this for privacy purposes! Please Contact the Main Administrator!")
        Else
            Me.Hide()
            RegisteredAdmin.Show()
        End If


    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Me.Hide()
        AdminHistory.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub BtnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        Me.Hide()
        Driverlist.Show()
    End Sub
End Class
