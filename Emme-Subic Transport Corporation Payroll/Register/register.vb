Imports System.Data.SqlClient

Public Class register

    Dim connection As New SqlConnection("Server = DESKTOP-BBDJH6Q; Database = EmmeSubic; Integrated Security = true")



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim command As New SqlCommand("insert into Users(firstName,lastName, userName, password, birthDate, role) values (@firstName,@lastName, @userName, @password, @birthDate, @role)", connection)

        'Add User Info

        command.Parameters.Add("@firstName", SqlDbType.VarChar).Value = RegFirstName.Text
        command.Parameters.Add("@lastName", SqlDbType.VarChar).Value = RegLastName.Text
        command.Parameters.Add("@userName", SqlDbType.VarChar).Value = RegUserName.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = RegPassword.Text
        command.Parameters.Add("@birthDate", SqlDbType.Date).Value = RegBirthDate.Value
        command.Parameters.Add("@role", SqlDbType.VarChar).Value = "Admin"

        'Open Database Connection
        connection.Open()
        If command.ExecuteNonQuery = 1 Then

            MessageBox.Show("A New Payroll Manager User is added")
        Else
            MessageBox.Show("Error, Payroll Manager not added")
        End If
        connection.Close()

        Me.Hide()

        Home.Show()



    End Sub

    Private Sub RegFirstName_TextChanged(sender As Object, e As EventArgs) Handles RegFirstName.TextChanged

    End Sub
End Class

