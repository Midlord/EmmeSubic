Imports System.Data.SqlClient
Imports System.Configuration
Public Class Adminregister



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using connection As New SqlConnection(connString)
            Dim command As New SqlCommand("insert into [EmmeSubic].[dbo].[Users] (firstName,lastName, userName, password, birthDate, role) values (@firstName,@lastName, @userName, @password, @birthDate, @role)", connection)



            command.Parameters.Add("@firstName", SqlDbType.VarChar).Value = RegFirstName.Text
            command.Parameters.Add("@lastName", SqlDbType.VarChar).Value = RegLastName.Text
            command.Parameters.Add("@userName", SqlDbType.VarChar).Value = RegUserName.Text
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = RegPassword.Text
            command.Parameters.Add("@birthDate", SqlDbType.Date).Value = RegBirthDate.Value
            command.Parameters.Add("@role", SqlDbType.VarChar).Value = "Admin"

            'Open Database Connection
            connection.Open()
            If RegFirstName.Text = "" Or RegLastName.Text = "" Or RegUserName.Text = "" Or RegPassword.Text = "" Or RegBirthDate.Text = "" Then
                'check if no fields
                MessageBox.Show("Please enter required fields.")
                RegFirstName.Text = ""
                RegLastName.Text = ""
                RegUserName.Text = ""
                RegPassword.Text = ""
                RegBirthDate.Text = ""
            Else
                command.ExecuteNonQuery()
                MessageBox.Show("A New Payroll Manager User is added")
                RegFirstName.Text = ""
                    RegLastName.Text = ""
                    RegUserName.Text = ""
                    RegPassword.Text = ""
                    RegBirthDate.Text = ""

                    Me.Hide()
                    Home.Show()

            End If
            connection.Close()


        End Using


    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Home.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Home.Show()
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

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Home.Show()
        RegFirstName.Text = ""
        RegLastName.Text = ""
        RegUserName.Text = ""
        RegPassword.Text = ""
        RegBirthDate.Text = ""
    End Sub

    Private Sub Backbut_Click(sender As Object, e As EventArgs) Handles Backbut.Click
        Me.Hide()
        Home.Show()

    End Sub

    Private Sub Adminregister_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub RegBirthDate_ValueChanged(sender As Object, e As EventArgs) Handles RegBirthDate.ValueChanged

    End Sub
End Class

