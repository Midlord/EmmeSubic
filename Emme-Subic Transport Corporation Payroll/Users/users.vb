Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient


Public Class users
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsersTable.DataSource = GetUsersList()

    End Sub

    Private Function GetUsersList()

        Dim TableUsers As New DataTable

        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString

        Using conn As New SqlConnection(connString)

            Using cmd As New SqlCommand("SELECT firstName, lastName, birthDate, role FROM [EmmeSubic].[dbo].[Users]", conn)

                conn.Open()

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                TableUsers.Load(reader)
            End Using
        End Using

        Return TableUsers

    End Function
End Class
