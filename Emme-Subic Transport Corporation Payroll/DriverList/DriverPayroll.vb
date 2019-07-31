Imports System.Data.SqlClient
Imports System.Configuration
Public Class DriverPayroll

    Public user_id As Integer
    Public totalAmout As Double


    Public Function GetPayrollByUserId() As DataTable

        Dim user_id As Integer = Driverlist.tbxUser_id.Text
        Dim TripSheetView As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString

        Using conn As New SqlConnection(connString)
            '   check If login user has SuperAdmin role
            Using cmd As New SqlCommand("SELECT id, fromRange, toRange, employeeContribution FROM [EmmeSubic].[dbo].[UserSSS] ", conn)

                cmd.Parameters.Add("@userId", SqlDbType.Int).Value = user_id
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                TripSheetView.Load(reader)
                conn.Close()
            End Using
        End Using
        Return TripSheetView
    End Function

    Public Function GetTripList() As DataTable

        Dim user_id As Integer = Driverlist.tbxUser_id.Text
        Dim TripSheetView As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString

        Using conn As New SqlConnection(connString)
            '   check If login user has SuperAdmin role
            Using cmd As New SqlCommand("SELECT tripDate, Rate, Remarks
                                              FROM [EmmeSubic].[dbo].[TripSheet] 
                                               where user_id = @userId", conn)

                cmd.Parameters.Add("@userId", SqlDbType.Int).Value = user_id
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                TripSheetView.Load(reader)
                conn.Close()
            End Using
        End Using
        Return TripSheetView
    End Function


    Sub ChangeFormColor(FormName As Form)
        Dim rnd As New Random
        Randomize()
        FormName.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
    End Sub
    Private Sub DriverPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangeFormColor(Me)
        tbxtrip.Text = Driverlist.tbxUser_id.Text + "  |Time/s"


    End Sub
    Private Sub DriverPayroll_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ChangeFormColor(Me)

        DataGridView.DataSource = GetTripList()

        With DataGridView
            .RowHeadersVisible = True
            .Columns(0).HeaderCell.Value = "Date"
            .Columns(1).HeaderCell.Value = "Rate"
            .Columns(2).HeaderCell.Value = "Remarks"

        End With


        lblEmpId.Text = Driverlist.tbxEmployeeId.Text
        lblEmpName.Text = Driverlist.tbxLname.Text + ", " + Driverlist.tbxFname.Text + " " + Driverlist.tbxMName.Text
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

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        DriverPrint.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Dim sss, sssLoan, philhealth, witholdingTax, pagibigFunds, pagibigLoan, officeLoan, officeDeduction As Integer


        Using connection As New SqlConnection(connString)
            Dim reader As SqlDataReader
            Dim command As New SqlCommand("select user_id, SUM(rate) from [EmmeSubic].[dbo].[TripSheet]
                                            where tripDate >= @dtFrom and tripDate <= @dtTo
                                                    and user_id = @userId
                                                    Group By user_id", connection)

            command.Parameters.Add("@dtFrom", SqlDbType.Date).Value = dtpfrom.Value
            command.Parameters.Add("@dtTo", SqlDbType.Date).Value = dtpto.Value
            command.Parameters.Add("@userId", SqlDbType.Int).Value = Driverlist.tbxUser_id.Text



            connection.Open()

            reader = command.ExecuteReader()
            Dim Name As String = ""
            While reader.Read()
                Console.WriteLine(String.Format("{0}, {1}",
                       reader(0), reader(1)))
                user_id = reader(0)
                totalAmout = reader(1)
            End While

            connection.Close()
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

            sss = Val(200)
            sssLoan = Val(100)
            philhealth = Val(50)
            witholdingTax = Val(200)
            pagibigFunds = Val(200)
            pagibigLoan = Val(0)
            officeLoan = Val(0)
            officeDeduction = Val(0)
            tbxtripRATE.Text = (totalAmout - sss - sssLoan - philhealth - witholdingTax - pagibigLoan - pagibigFunds - officeDeduction - officeLoan)



        End Using

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Tbxtotaldeduct_TextChanged(sender As Object, e As EventArgs) Handles tbxtotaldeduct.TextChanged
    End Sub
End Class
