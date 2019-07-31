Imports System.Configuration
Imports System.Data.SqlClient
Public Class DriverArchive

    Private Sub PictureMin_Click(sender As Object, e As EventArgs) Handles PictureMin.Click
            Me.WindowState = FormWindowState.Minimized
        End Sub

        Private Sub PictureMax_Click(sender As Object, e As EventArgs) Handles PictureMax.Click
            Me.WindowState = FormWindowState.Maximized
            PictureMax.Visible = False
            PictureRest.Visible = True
        End Sub

        Private Sub PictureRest_Click(sender As Object, e As EventArgs) Handles PictureRest.Click
            Me.WindowState = FormWindowState.Normal
            PictureMax.Visible = True
            PictureRest.Visible = False
        End Sub

        Private Sub PictureExit_Click(sender As Object, e As EventArgs) Handles PictureExit.Click
            Me.Close()
        End Sub
        Private Sub DriverArchive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            DeletedUserTable.DataSource = GetDeletedList()
        '  If GetDeletedList() IsNot Nothing AndAlso GetDeletedList.Rows.Count = 0 Then
        '   If MessageBox.Show("No User has been deleted yet", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
        '     Me.Close()
        ' Driverlist.Show()
        '    End If
        'End If

    End Sub
        Private Sub DriverArchive_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DeletedUserTable.DataSource = GetDeletedList()
        If GetDeletedList() IsNot Nothing AndAlso GetDeletedList.Rows.Count = 0 Then
            If MessageBox.Show("No User has been deleted yet", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                Me.Close()
                Driverlist.Show()
            End If
        End If

    End Sub

    Private Function GetDeletedList() As DataTable
        Dim delete As New DataTable

        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString

        Using conn As New SqlConnection(connString)

            Using cmd As New SqlCommand("SELECT * FROM [EmmeSubic].[dbo].[UserDetails]                                       
                                            where isDeleted = 1", conn)

                conn.Open()

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                delete.Load(reader)

            End Using
        End Using
        Return delete
    End Function
    Private Sub Recover_Click(sender As Object, e As EventArgs) Handles Recover.Click
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using conn As New SqlConnection(connString)
            Dim command As New SqlCommand("UPDATE [EmmeSubic].[dbo].[UserDetails] SET isDeleted = 0 where isDeleted = 1", conn)
            ' command.Parameters.Add("@user_id", SqlDbType.Int).Value = Driverlist.tbxUser_id.Text
            conn.Open()
            If MessageBox.Show("Are you sure you want to recover?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                command.ExecuteNonQuery()
                '  For Each row As DataGridViewRow In DeletedUserTable.SelectedRows
                '  DeletedUserTable.Rows.Remove(row)
                '  Next
                MessageBox.Show("The User is successfully Recovered!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
            End If
        End Using
    End Sub
    Private Sub DeletedUserTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DeletedUserTable.CellContentClick

    End Sub
End Class
