Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Entity
Public Class TripSheet

    '  Dim db As [Emme_Subic_Transport_Corporation_Payroll].EmmeSubicEntities1
    'Public price As Integer
    'Public user_id As Integer = Driverlist.tbxUser_id.Text
    Sub ChangeFormColor(FormName As Form)
        Dim rnd As New Random
        Randomize()
        FormName.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
    End Sub
    Public Function GetTripList() As DataTable

        Dim user_id As Integer = Driverlist.tbxUser_id.Text
        Dim TripSheetView As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString

        Using conn As New SqlConnection(connString)
            '   check If login user has SuperAdmin role
            Using cmd As New SqlCommand("SELECT id, tripDate, broker, fromLocation, toLocation, driverHelper, WaybillNumber, Container, ActivityType, Rate, Remarks
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

    Private Sub TripSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user_id As Integer = Driverlist.tbxUser_id.Text
        ChangeFormColor(Me)

        '  db = New [Emme_Subic_Transport_Corporation_Payroll].EmmeSubicEntities1
        '  db.TripSheets.Where(Function(c) c.user_id = user_id).Load()
        'TripSheetBindingSource.DataSource = db.TripSheets.Local
        TripSheetView.DataSource = GetTripList()

        TripSheetView.BorderStyle = BorderStyle.None
        TripSheetView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        TripSheetView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        TripSheetView.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
        TripSheetView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke
        TripSheetView.BackgroundColor = Color.White
        TripSheetView.EnableHeadersVisualStyles = False
        TripSheetView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        TripSheetView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
        TripSheetView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        TripSheetView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        If GetTripList() IsNot Nothing AndAlso GetTripList.Rows.Count = 0 Then
            cmbRemarks.ReadOnly = True
        Else
            cmbRemarks.ReadOnly = False
        End If

    End Sub
    Private Sub TripSheet_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim user_id As Integer = Driverlist.tbxUser_id.Text
        ChangeFormColor(Me)
        ' db = New [Emme_Subic_Transport_Corporation_Payroll].EmmeSubicEntities1
        ' db.TripSheets.Where(Function(c) c.user_id = user_id).Load()
        ' 'TripSheetBindingSource.DataSource = db.TripSheets.Local

        TripSheetView.DataSource = GetTripList()
        tbxTimesheetId.Visible = False
        If GetTripList() IsNot Nothing AndAlso GetTripList.Rows.Count = 0 Then
            cmbRemarks.ReadOnly = True
        Else
            cmbRemarks.ReadOnly = False
        End If

        With TripSheetView
            .RowHeadersVisible = True
            .Columns(0).HeaderCell.Value = "Tracker#"
            .Columns(1).HeaderCell.Value = "Date"
            .Columns(2).HeaderCell.Value = "Broker/Consignee"
            .Columns(3).HeaderCell.Value = "From"
            .Columns(4).HeaderCell.Value = "To"
            .Columns(5).HeaderCell.Value = "Driver Helper"
            .Columns(6).HeaderCell.Value = "Waybill Number"
            .Columns(7).HeaderCell.Value = "Container"
            .Columns(8).HeaderCell.Value = "Activity Type"
            .Columns(9).HeaderCell.Value = "Trip Rate"

        End With
        EmployeeID.Text = Driverlist.tbxEmployeeId.Text
        LabelName.Text = Driverlist.tbxLname.Text + ", " + Driverlist.tbxFname.Text + " " + Driverlist.tbxMName.Text
    End Sub
    Private Sub PictureMin_Click(sender As Object, e As EventArgs) Handles PictureMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PictureMax_Click(sender As Object, e As EventArgs) Handles PictureMax.Click
        Me.WindowState = FormWindowState.Maximized
        PictureRest.Enabled = True
        PictureMax.Enabled = False
        Panel.Left = 12
        Panel.Size = New Size(950, 339)
        btnUpdate.Left = 970
        btnUpdate.Size = New Size(937, 339)

    End Sub
    Private Sub PictureRest_Click(sender As Object, e As EventArgs) Handles PictureRest.Click
        Me.WindowState = FormWindowState.Normal
        PictureRest.Enabled = False
        PictureMax.Enabled = True
        Panel.Left = 12
        Panel.Size = New Size(630, 339)
        btnUpdate.Left = 648
        btnUpdate.Size = New Size(579, 339)
    End Sub
    Private Sub PictureExit_Click(sender As Object, e As EventArgs) Handles PictureExit.Click
        Me.Close()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim user_id As Integer = Driverlist.tbxUser_id.Text
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("insert into [EmmeSubic].[dbo].[TripSheet]  (user_id,tripDate,broker,fromLocation,toLocation,driverHelper,WaybillNumber,Container,ActivityType,Rate,Remarks)
                    VALUES (@user_id,@tripDate,@broker,@fromLocation,@toLocation,@driverHelper,@WaybillNumber,@Container,@ActivityType,@Rate,@Remarks)",
                                        conn)
                cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id
                cmd.Parameters.Add("@tripDate", SqlDbType.DateTime).Value = tbxDate.Value
                cmd.Parameters.Add("@broker", SqlDbType.VarChar).Value = tbxconsignee.Text
                cmd.Parameters.Add("@fromLocation", SqlDbType.VarChar).Value = tbxfromdestination.Text
                cmd.Parameters.Add("@toLocation", SqlDbType.VarChar).Value = tbxtodestination.Text
                cmd.Parameters.Add("@driverHelper", SqlDbType.VarChar).Value = tbxdriverhelper.Text
                cmd.Parameters.Add("@WaybillNumber", SqlDbType.Text).Value = tbxwaybill.Text
                cmd.Parameters.Add("@Container", SqlDbType.VarChar).Value = tbxContainerNumber.Text
                cmd.Parameters.Add("@ActivityType", SqlDbType.VarChar).Value = CmbActivityType.Text
                cmd.Parameters.Add("@Rate", SqlDbType.Float).Value = tbxRate.Text
                cmd.Parameters.Add("@Remarks", SqlDbType.Text).Value = CmbActivityType.Text + ", from " + tbxfromdestination.Text + " to " + tbxtodestination.Text + " " + cmbremark.Text

                If tbxfromdestination.Text = "" Or tbxtodestination.Text = "" Or tbxRate.Text = "" Or tbxdriverhelper.Text = "" Or tbxconsignee.Text = "" Or tbxRate.Text = "" Or tbxContainerNumber.Text = "" Or CmbActivityType.Text = "" Or cmbremark.Text = "" Or tbxwaybill.Text = " " Then
                    MsgBox("Please Fill the Required lines")
                    tbxfromdestination.Text = ""
                    tbxtodestination.Text = ""
                    tbxRate.Text = ""
                    tbxdriverhelper.Text = ""
                    tbxconsignee.Text = ""
                    tbxRate.Text = ""
                    tbxContainerNumber.Text = ""
                    CmbActivityType.Text = Nothing
                    cmbremark.Text = Nothing
                    tbxwaybill.Text = ""
                Else
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    'db.SaveChanges()
                    MsgBox("Saved successfully!")
                    conn.Close()
                    tbxfromdestination.Text = ""
                    tbxtodestination.Text = ""
                    tbxRate.Text = ""
                    tbxdriverhelper.Text = ""
                    tbxconsignee.Text = ""
                    tbxRate.Text = ""
                    tbxContainerNumber.Text = ""
                    CmbActivityType.Text = Nothing
                    cmbremark.Text = Nothing
                    tbxwaybill.Text = ""
                    Driverlist.Show()

                End If
            End Using
        End Using

    End Sub
    Private Sub Btnupdatee_Click(sender As Object, e As EventArgs) Handles btnupdatee.Click
        Dim rowsaffected As Integer
        Dim user_id As Integer = Driverlist.tbxUser_id.Text
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("UPDATE [EmmeSubic].[dbo].[TripSheet] SET tripDate=@tripDate,broker=@broker,fromLocation=@fromLocation,toLocation=@toLocation,driverHelper=@driverHelper,WaybillNumber=@WaybillNumber,Container=@Container,ActivityType=@ActivityType,Rate=@Rate,Remarks=@Remarks where id = @id", conn)
                ' cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = tbxTimesheetId.Text
                cmd.Parameters.AddWithValue("@tripDate", SqlDbType.DateTime).Value = tbxDate.Value
                cmd.Parameters.Add("@broker", SqlDbType.VarChar).Value = tbxconsignee.Text
                cmd.Parameters.Add("@fromLocation", SqlDbType.VarChar).Value = tbxfromdestination.Text
                cmd.Parameters.Add("@toLocation", SqlDbType.VarChar).Value = tbxtodestination.Text
                cmd.Parameters.Add("@driverHelper", SqlDbType.VarChar).Value = tbxdriverhelper.Text
                cmd.Parameters.Add("@WaybillNumber", SqlDbType.Text).Value = tbxwaybill.Text
                cmd.Parameters.Add("@Container", SqlDbType.VarChar).Value = tbxContainerNumber.Text
                cmd.Parameters.Add("@ActivityType", SqlDbType.VarChar).Value = CmbActivityType.Text
                cmd.Parameters.Add("@Rate", SqlDbType.Float).Value = tbxRate.Text
                cmd.Parameters.Add("@Remarks", SqlDbType.Text).Value = CmbActivityType.Text + ", from " + tbxfromdestination.Text + " to " + tbxtodestination.Text + " " + cmbremark.Text
                conn.Open()
                rowsaffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Your Update has been Saved Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
            End Using
        End Using
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Please Add One Item at a time. Thankyou!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'TripSheetBindingSource.AddNew()
    End Sub

    Private Sub TripSheetView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TripSheetView.CellContentClick

    End Sub

    Private Sub TripSheetView_MouseClick(sender As Object, e As MouseEventArgs) Handles TripSheetView.MouseClick

    End Sub

    Private Sub TripSheetView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TripSheetView.CellClick

        tbxTimesheetId.Text = TripSheetView.CurrentRow.Cells(0).Value.ToString
        tbxDate.Value = TripSheetView.CurrentRow.Cells(1).Value.ToString
        tbxconsignee.Text = TripSheetView.CurrentRow.Cells(2).Value.ToString
        tbxfromdestination.Text = TripSheetView.CurrentRow.Cells(3).Value.ToString
        tbxtodestination.Text = TripSheetView.CurrentRow.Cells(4).Value.ToString
        tbxdriverhelper.Text = TripSheetView.CurrentRow.Cells(5).Value.ToString
        tbxwaybill.Text = TripSheetView.CurrentRow.Cells(6).Value.ToString
        tbxContainerNumber.Text = TripSheetView.CurrentRow.Cells(7).Value.ToString
        CmbActivityType.SelectedItem = TripSheetView.CurrentRow.Cells(8).Value.ToString
        tbxRate.Text = TripSheetView.CurrentRow.Cells(9).Value.ToString
        cmbRemarks.Text = TripSheetView.CurrentRow.Cells(10).Value.ToString
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearTextboxes(Me)
        ClearComboboxes(Me)
        ' Cleardatetimepicker(Me)


    End Sub
    Private Sub ClearTextboxes(c As Control)
        Dim currentTextBox As TextBox

        'Loop through all the controls.>>
        For Each ctrl As Control In c.Controls
            'If the control is a TextBox do the next action.>>
            If TypeOf ctrl Is TextBox Then
                'Convert the type of ctrl and assign
                currentTextBox = CType(ctrl, TextBox)
                'Clear the current TextBox.>>
                currentTextBox.Clear()
            End If

            If ctrl.HasChildren Then
                ClearTextboxes(ctrl)
            End If
        Next
    End Sub
    Private Sub ClearComboboxes(c As Control)

        Dim currentComboBox As ComboBox
        'Loop through all the controls.>>
        For Each ctrl As Control In c.Controls
            'If the control is a TextBox do the next action.>>

            If TypeOf ctrl Is ComboBox Then
                currentComboBox = CType(ctrl, ComboBox)
                'Clear the current combobox.>>
                currentComboBox.SelectedIndex = -1
            End If

            If ctrl.HasChildren Then
                ClearComboboxes(ctrl)
            End If
        Next
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim rowsaffected As Integer
        Dim user_id As Integer = Driverlist.tbxUser_id.Text
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("DELETE FROM [EmmeSubic].[dbo].[TripSheet] where id = @id", conn)
                ' cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = tbxTimesheetId.Text
                conn.Open()
                rowsaffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Successfully Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
            End Using
        End Using
    End Sub
End Class
