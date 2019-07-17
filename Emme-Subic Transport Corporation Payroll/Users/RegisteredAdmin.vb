Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient


Public Class RegisteredAdmin
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsersTable.DataSource = GetUsersList()

    End Sub

    Private Sub RegisteredAdmin_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        UsersTable.DataSource = GetUsersList()

        UsersTable.BorderStyle = BorderStyle.None
        UsersTable.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        UsersTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        UsersTable.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
        UsersTable.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke
        UsersTable.BackgroundColor = Color.White

        UsersTable.EnableHeadersVisualStyles = False
        UsersTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        UsersTable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
        UsersTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Private Function GetUsersList()

        Dim TableUsers As New DataTable

        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString

        Using conn As New SqlConnection(connString)

            Using cmd As New SqlCommand("SELECT CONCAT(firstName,' ',lastName) as Name, userName, birthDate, role FROM [EmmeSubic].[dbo].[Users]
                                        where isDeleted = 0", conn)

                conn.Open()

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                '      While reader.Read
                '      Dim it As ListViewItem = New ListViewItem(reader("firstName").ToString)
                '      it.SubItems.Add(reader("lastName").ToString)
                '      it.SubItems.Add(reader("userName").ToString)
                '      it.SubItems.Add(reader("birthDate").ToString)
                '      it.SubItems.Add(reader("role").ToString)
                '      TableUsers.AsDataView()
                '      End While
                TableUsers.Load(reader)
            End Using
        End Using

        Return TableUsers

    End Function

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RemoveUser.Click

        If UsersTable.SelectedRows.Count > 0 Then
            RemoveUser.Enabled = True
        Else
            register.Enabled = False

        End If


        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString

        Dim conn As New SqlConnection(connString)


        Using command As New SqlCommand("Update [EmmeSubic].[dbo].[Users] SET isDeleted = 1 where userName = @userName", conn)

            command.Parameters.Add("@userName", SqlDbType.VarChar).Value = UsersTable.SelectedRows(0).Cells(1).Value.ToString
            Try
                conn.Open()
                command.ExecuteNonQuery()
                MsgBox("User Successfully deleted!")
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub UsersTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersTable.CellContentClick

    End Sub
End Class
