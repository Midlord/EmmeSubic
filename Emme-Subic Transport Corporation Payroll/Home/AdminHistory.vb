Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class AdminHistory

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmmeSubicDataSet2.Histories' table. You can move, or remove it, as needed.
        Me.HistoriesTableAdapter.Fill(Me.EmmeSubicDataSet2.Histories)

        If LoginForm.user_id = 1 Then
            SuperAdminTable.DataSource = SuperAdminList()
            SuperAdminTable.Visible = True
            UsertableLog.Visible = False

            SuperAdminTable.BorderStyle = BorderStyle.None
            SuperAdminTable.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
            SuperAdminTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            SuperAdminTable.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
            SuperAdminTable.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke
            SuperAdminTable.BackgroundColor = Color.White

            SuperAdminTable.EnableHeadersVisualStyles = False
            SuperAdminTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            SuperAdminTable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
            SuperAdminTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        Else
            UsertableLog.DataSource = GetUsersList()
            UsertableLog.Visible = True
            SuperAdminTable.Visible = False

            UsertableLog.BorderStyle = BorderStyle.None
            UsertableLog.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
            UsertableLog.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            UsertableLog.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
            UsertableLog.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke
            UsertableLog.BackgroundColor = Color.White

            UsertableLog.EnableHeadersVisualStyles = False
            UsertableLog.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            UsertableLog.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
            UsertableLog.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        End If
    End Sub

    Private Sub AdminHistory_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        If LoginForm.user_id = 1 Then
            SuperAdminTable.DataSource = SuperAdminList()
            SuperAdminTable.Visible = True
            UsertableLog.Visible = False
        Else
            UsertableLog.DataSource = GetUsersList()
            UsertableLog.Visible = True
            SuperAdminTable.Visible = False
        End If

    End Sub


    Private Function GetUsersList()

        Dim UsertableLog As New DataTable

        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString

        Using conn As New SqlConnection(connString)


            'check if login user has SuperAdmin role
            Using cmd As New SqlCommand("SELECT u.userName as UserName, action as Action FROM [EmmeSubic].[dbo].[Histories] h
                                            left join  [EmmeSubic].[dbo].[Users] u 
                                            on u.id = h.user_id
                                            where u.id = @userId and isDeleted = 0", conn)


                cmd.Parameters.Add("@userId", SqlDbType.Int).Value = LoginForm.user_id

                conn.Open()

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                UsertableLog.Load(reader)

            End Using
        End Using

        Return UsertableLog
    End Function


    Private Function SuperAdminList()

        Dim SuperAdminTable As New DataTable

        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString

        Using conn As New SqlConnection(connString)


            'check if login user has SuperAdmin role
            Using cmd As New SqlCommand("SELECT u.userName as UserName, action as Action FROM [EmmeSubic].[dbo].[Histories] h
                                            left join  [EmmeSubic].[dbo].[Users] u 
                                            on u.id = h.user_id", conn)

                conn.Open()

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                SuperAdminTable.Load(reader)

            End Using
        End Using

        Return SuperAdminTable


    End Function


    Private Sub PictureExit_Click(sender As Object, e As EventArgs) Handles PictureExit.Click
        Me.Close()


    End Sub

    Private Sub PictureMax_Click(sender As Object, e As EventArgs) Handles PictureMax.Click
        Me.WindowState = FormWindowState.Maximized
        PictureMax.Visible = False
        PictureRest.Visible = True
    End Sub

    Private Sub PictureRest_Click(sender As Object, e As EventArgs) Handles PictureRest.Click

        Me.WindowState = FormWindowState.Normal
        PictureRest.Visible = False
        PictureMax.Visible = True
    End Sub

    Private Sub PictureMin_Click(sender As Object, e As EventArgs) Handles PictureMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Home.Show()

    End Sub

    Private Sub PictureBack_Click(sender As Object, e As EventArgs) Handles PictureBack.Click
        Me.Hide()
        Home.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub UsertableLog_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsertableLog.CellContentClick

    End Sub
End Class
