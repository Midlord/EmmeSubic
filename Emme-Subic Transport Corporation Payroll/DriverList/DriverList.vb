Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.Entity
Imports System.Configuration
Public Class Driverlist

    Dim db As [Emme_Subic_Transport_Corporation_Payroll].EmmeSubicEntities
    Sub ChangeFormColor(FormName As Form)
        Dim rnd As New Random
        Randomize()
        FormName.BackColor = Color.FromArgb(255, Rnd.Next(255), Rnd.Next(255), Rnd.Next(255))
    End Sub

    Private Sub Driverlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangeFormColor(Me)
        If tbxUser_id.Text = "0" Then
            AddTrip.Visible = False
        Else
            AddTrip.Visible = True
        End If
        db = New [Emme_Subic_Transport_Corporation_Payroll].EmmeSubicEntities
        db.UserDetails.Where(Function(c) c.isDeleted <> 1).Load()
        UserDetailBindingSource.DataSource = db.UserDetails.Local

        '  DataGridView.BorderStyle = BorderStyle.None
        DataGridView.Columns(1).ReadOnly = True
        DataGridView.Rows(0).Selected = False
        DataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        DataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
        DataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke
        DataGridView.BackgroundColor = Color.White
        DataGridView.EnableHeadersVisualStyles = False
        'DataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
        DataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub
    Private Sub Driverlist_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ChangeFormColor(Me)
        If tbxUser_id.Text = "0" Then
            AddTrip.Visible = False
        Else
            AddTrip.Visible = True
        End If
        db = New [Emme_Subic_Transport_Corporation_Payroll].EmmeSubicEntities
        db.UserDetails.Where(Function(c) c.isDeleted <> 1).Load()
        UserDetailBindingSource.DataSource = db.UserDetails.Local
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddTrip.Visible = False
        If tbxUser_id.Text.Count < 1 Then
            MessageBox.Show("Welcome! Please Register your First User!", "Welcome Admin!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UserDetailBindingSource.AddNew()
            tbxEmployeeId.Enabled = True
        Else
            tbxDhired.Format = DateTimePickerFormat.Custom
            tbxBday.Format = DateTimePickerFormat.Custom
            tbxEmployeeId.Enabled = True
            tbxEmployeeId.ReadOnly = False
            MessageBox.Show("Please Add One Item at a time. Thankyou!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UserDetailBindingSource.AddNew()
            tbxEmployeeId.Text = ""
            tbxFname.Text = ""
            tbxMName.Text = ""
            tbxLname.Text = ""
            tbxBday.CustomFormat = ""
            TbxBplace.Text = ""
            CmbCstatus.Text = Nothing
            tbxCpno.Text = ""
            tbxDhired.CustomFormat = ""
            CmbEstatus.Text = Nothing
            CmbGender.Text = Nothing
            tbxReligion.Text = ""
            tbxHeight.Text = ""
            tbxWeight.Text = ""
            TbxEAddress.Text = ""
            tbxCAddress.Text = ""
            tbxPaddress.Text = ""
            btnSame.Checked = False
            tbxSSS.Text = ""
            tbxPagibig.Text = ""
            tbxPhilhealth.Text = ""
            tbxTIN.Text = ""
            tbxAge.Text = ""
        End If

    End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If tbxUser_id.Text.Count < 1 Then
            MessageBox.Show("Must Click Add First", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddTrip.Visible = True
            Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
            Using connection As New SqlConnection(connString)
                Dim command As New SqlCommand("select EmployeeID from [EmmeSubic].[dbo].[UserDetails] where EmployeeID = @employeeID and isDeleted = 0", connection)
                command.Parameters.Add("@employeeID", SqlDbType.VarChar).Value = tbxEmployeeId.Text
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count() <= 0 Then
                    db.SaveChanges()
                    AddTrip.Visible = True
                    MessageBox.Show("Your User has been Saved Successfully!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Employee Id is Already Exist!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    connection.Close()
                    AddTrip.Visible = True
                End If
            End Using
        End If
    End Sub
    Private Sub BtnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        tbxEmployeeId.Enabled = False
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using connection As New SqlConnection(connString)
            If tbxUser_id.Text.Count < 1 Then
                MessageBox.Show("Must Register atleast 1 Employee First", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                '      Dim com As New SqlCommand("select EmployeeID FROM [EmmeSubic].[dbo].[UserDetails] WHERE employeeID = @employeeID", connection)
                '      com.Parameters.AddWithValue("@employeeID", tbxEmployeeId.Text)
                '    connection.Open()
                '    If com.ExecuteNonQuery Then
                '         MessageBox.Show("what")
                '   Else
                If tbxUser_id.Text <= 0 Then
                    MessageBox.Show("Cannot Save Using Update!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    db.SaveChanges()
                    tbxEmployeeId.Enabled = False
                    tbxEmployeeId.ReadOnly = True
                    MessageBox.Show("Your Update has been Saved Successfully!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                '        connection.Close()
                '     End If
            End If
            '       Dim com As New SqlCommand("select EmployeeID FROM [EmmeSubic].[dbo].[UserDetails] WHERE employeeID = @employeeID", connection)
            '     com.Parameters.AddWithValue("@employeeID", tbxEmployeeId.Text)
            '      connection.Open()
            '       If com.ExecuteNonQuery() Then
            '      MessageBox.Show("ex.message")
            '     tbxEmployeeId.ReadOnly = False
            '             connection.Close()
            '
            '      End If


        End Using
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If tbxUser_id.Text.Count < 1 Then
            MessageBox.Show("Nothing to Delete Yet", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
            Using conn As New SqlConnection(connString)
                Using cmd As New SqlCommand("UPDATE [EmmeSubic].[dbo].[UserDetails] SET EmployeeID = Null, isDeleted = 1 where id = @user_id", conn)
                    cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = tbxUser_id.Text
                    If MessageBox.Show("Are you sure to delete this records?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        conn.Open()
                        cmd.ExecuteNonQuery()
                        UserDetailBindingSource.RemoveCurrent()
                        '     db = New Emme_Subic_Transport_Corporation_Payroll.EmmeSubicEntities
                        '     UserDetailBindingSource.DataSource = db.UserDetails.Local.Add
                        conn.Close()
                    End If
                End Using
            End Using
        End If
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If tbxUser_id.Text.Count < 1 Then
            MessageBox.Show("Must Click Add first to Remove All Current Input", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim changed = db.ChangeTracker.Entries.Where(Function(x) x.State <> EntityState.Unchanged).ToList
            For Each obj In changed
                Select Case obj.State
                    Case EntityState.Modified
                        obj.CurrentValues.SetValues(obj.OriginalValues)
                        obj.State = EntityState.Unchanged
                    Case EntityState.Added
                        obj.State = EntityState.Detached
                    Case EntityState.Deleted
                        obj.State = EntityState.Unchanged
                End Select
            Next
            CmbCstatus.Text = Nothing
            CmbEstatus.Text = Nothing
            CmbGender.Text = Nothing
            btnSame.Checked = False
            UserDetailBindingSource.ResetBindings(False)
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        ImgBox.Image = Nothing
    End Sub
    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Dim picc As New OpenFileDialog
        Try
            With picc

                'CHECK THE SELECTED FILE IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckFileExists = True

                'CHECK THE SELECTED PATH IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckPathExists = True

                'GET AND SET THE DEFAULT EXTENSION
                .DefaultExt = "All Files"

                'RETURN THE FILE LINKED TO THE LNK FILE
                .DereferenceLinks = True

                'SET THE FILE NAME TO EMPTY 
                .FileName = ""

                'FILTERING THE FILES
                .Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*"
                'SET THIS FOR ONE FILE SELECTION ONLY.
                .Multiselect = False

                'SET THIS TO PUT THE CURRENT FOLDER BACK TO WHERE IT HAS STARTED.
                .RestoreDirectory = True

                'SET THE TITLE OF THE DIALOG BOX.
                .Title = "Select a file to open"

                'ACCEPT ONLY THE VALID WIN32 FILE NAMES.
                .ValidateNames = True

                If .ShowDialog = DialogResult.OK Then
                    Try
                        ImgBox.Image = Image.FromFile(picc.FileName)
                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Sub
    Private Sub TbxAge_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TbxBday_ValueChanged(sender As Object, e As EventArgs) Handles tbxBday.ValueChanged

        Dim dob As DateTime
        dob = New DateTime(tbxBday.Value.Year, tbxBday.Value.Month, tbxBday.Value.Day)
        Dim tday As TimeSpan = DateTime.Now.Subtract(dob)
        Dim months As Integer
        Dim years As Integer, days As Integer
        months = 12 * (DateTime.Now.Year - dob.Year) + (DateTime.Now.Month - dob.Month)

        If DateTime.Now.Day < dob.Day Then
            months -= 1
            days = DateTime.DaysInMonth(dob.Year, dob.Month) - dob.Day + DateTime.Now.Day
        Else
            days = DateTime.Now.Day - dob.Day
        End If
        years = Math.Floor(months / 12)

        tbxAge.Text = years


    End Sub

    Private Sub Same_CheckedChanged(sender As Object, e As EventArgs) Handles btnSame.CheckedChanged
        If btnSame.Checked Then
            tbxPaddress.Enabled = False
            PAddress.ForeColor = Color.Gray
            tbxCAddress.Enabled = True
            CAddress.ForeColor = Color.White
            tbxPaddress.Text = ""
        Else
            tbxPaddress.Enabled = True
            PAddress.ForeColor = Color.White
            tbxPaddress.Text = ""
        End If
    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Home.Show()
        tbxEmployeeId.Text = ""
        tbxFname.Text = ""
        tbxMName.Text = ""
        tbxLname.Text = ""
        tbxBday.Text = ""
        TbxBplace.Text = ""
        CmbCstatus.Text = Nothing
        tbxCpno.Text = ""
        tbxDhired.Text = ""
        CmbEstatus.Text = Nothing
        CmbGender.Text = Nothing
        tbxReligion.Text = ""
        tbxHeight.Text = ""
        tbxWeight.Text = ""
        TbxEAddress.Text = ""
        tbxCAddress.Text = ""
        tbxPaddress.Text = ""
        btnSame.Checked = False
        tbxSSS.Text = ""
        tbxPagibig.Text = ""
        tbxPhilhealth.Text = ""
        tbxTIN.Text = ""


    End Sub
    Private Sub Pictureback_Click(sender As Object, e As EventArgs) Handles PictureBack.Click
        Me.Hide()
        Home.Show()
    End Sub
    Private Sub PictureExit_Click(sender As Object, e As EventArgs) Handles PictureExit.Click
        Me.Close()
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
    Private Sub PictureMin_Click(sender As Object, e As EventArgs) Handles PictureMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub TbxEmployeeId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxEmployeeId.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," AndAlso e.KeyChar <> "-" Then
            e.Handled = True

        End If
    End Sub
    Private Sub TbxLname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxLname.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
            AndAlso Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 46 Then
            e.Handled = False
        End If
    End Sub
    Private Sub TbxFname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxFname.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
            And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 46 Then
            e.Handled = False
        End If
    End Sub
    Private Sub TbxMName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxMName.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
            And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 46 Then
            e.Handled = False
        End If
    End Sub
    Private Sub TbxBday_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxBday.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> " " AndAlso Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 AndAlso Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
        End If
    End Sub
    Private Sub TbxBplace_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxBplace.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
            And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 46 Then
            e.Handled = False
        End If
    End Sub
    Private Sub CmbCstatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbCstatus.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
            And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 46 Then
            e.Handled = False
        End If
    End Sub
    Private Sub TbxCpno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxCpno.KeyPress

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
               AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "+" AndAlso e.KeyChar <> "(" AndAlso e.KeyChar <> ")" AndAlso Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 AndAlso Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
        End If
    End Sub
    Private Sub TbxDhired_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> " " AndAlso Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 AndAlso Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
        End If
    End Sub
    Private Sub CmbEstatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbEstatus.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
            And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 46 Then
            e.Handled = False
        End If
    End Sub
    Private Sub CmbGender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbGender.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
            And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 46 Then
            e.Handled = False
        End If
    End Sub
    Private Sub TbxReligion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxReligion.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
            And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 46 Then
            e.Handled = False
        End If
    End Sub
    Private Sub TbxHeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxHeight.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
             AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " AndAlso e.KeyChar <> "'" AndAlso e.KeyChar <> "." AndAlso Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 AndAlso Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
        End If
    End Sub
    Private Sub TbxWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxWeight.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
             AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " AndAlso e.KeyChar <> "'" AndAlso e.KeyChar <> "." AndAlso Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 AndAlso Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
        End If
    End Sub
    Private Sub TbxEAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxEAddress.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
            And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 46 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 48 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 49 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 50 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 51 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 52 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 53 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 54 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 55 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 56 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 57 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 64 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 95 Then
            e.Handled = False
        End If
    End Sub
    Private Sub TbxCAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxCAddress.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
            And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 44 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 46 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 48 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 49 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 50 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 51 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 52 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 53 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 54 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 55 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 56 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 57 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 58 Then
            e.Handled = False
        End If
    End Sub
    Private Sub TbxPaddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxPaddress.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
            And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 44 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 46 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 48 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 49 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 50 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 51 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 52 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 53 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 54 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 55 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 56 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 57 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 58 Then
            e.Handled = False
        End If
    End Sub
    Private Sub TbxSSS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxSSS.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub TbxPagibig_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxPagibig.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub TbxPhilhealth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxPhilhealth.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub TbxTIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxTIN.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles empId.TextChanged
        Using db As New [Emme_Subic_Transport_Corporation_Payroll].EmmeSubicEntities

            Dim drivers = db.UserDetails.Where(Function(c) c.EmployeeID.Contains(empId.Text) And c.isDeleted <> 1).ToList
            If drivers.Count() > 0 Then
                db.UserDetails.Where(Function(c) c.isDeleted <> 1).Load()
                '        db.UserDetails.Load()
                UserDetailBindingSource.DataSource = db.UserDetails.Local
            Else
                MsgBox("No Match Found!")
                empId.Text = ""
            End If
        End Using
    End Sub
    Private Sub AddTrip_Click(sender As Object, e As EventArgs) Handles AddTrip.Click
        If tbxUser_id.Text = "0" Then
            MsgBox("No Employee is registered/No Employee is Selected!")
        Else
            TripSheet.Show()

            TripSheet.tbxfromdestination.Text = ""
            TripSheet.tbxtodestination.Text = ""
            TripSheet.tbxRate.Text = ""
            TripSheet.tbxdriverhelper.Text = ""
            TripSheet.tbxconsignee.Text = ""
            TripSheet.tbxRate.Text = ""
            TripSheet.tbxContainerNumber.Text = ""
            TripSheet.CmbActivityType.Text = Nothing
            TripSheet.cmbRemarks.Text = Nothing
            TripSheet.tbxwaybill.Text = ""
        End If
    End Sub
    Private Sub TbxEmployeeId_Click(sender As Object, e As EventArgs) Handles tbxEmployeeId.Click
     If tbxUser_id.Text = "" Then
            MessageBox.Show("Please Click Add First")
            tbxEmployeeId.Enabled = False
        Else
            tbxEmployeeId.Enabled = True
        End If
    End Sub


    Private Sub DataGridView_EnabledChanged(sender As Object, e As EventArgs) Handles DataGridView.EnabledChanged
        If tbxUser_id.Text.Count >= 1 Then
            tbxEmployeeId.Enabled = False
        Else
            tbxEmployeeId.Enabled = True
        End If
    End Sub

    Private Sub TbxEmployeeId_TextChanged(sender As Object, e As EventArgs) Handles tbxEmployeeId.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DriverPayroll.Show()

    End Sub
    Private Sub Archive_Click(sender As Object, e As EventArgs) Handles Archive.Click
        If tbxUser_id.Text.Count < 1 Then
            MessageBox.Show("Add atleast one Employee First!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            DriverArchive.Show()
        End If


    End Sub
End Class
