Imports System.Data.SqlClient
Imports System.IO


Public Class AddNewEmployee

    Dim connection As New SqlConnection("Server = DESKTOP-BBDJH6Q; Database = EmmeSubic; Integrated Security = true")


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        ImgBox.Image = Nothing
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Dim pic As New OpenFileDialog
        pic.Filter = "Choose Image (*.jpg;*.png;;*.gif;|*jpg;*.png;*.gif;"
        If pic.ShowDialog = DialogResult.OK Then
            ImgBox.Image = Image.FromFile(pic.FileName)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim command As New SqlCommand("insert into UserDetails(user_id, fname, mname, lname, birthdate, birthplace, Cstatus, Age, CellphoneNo, datehired, EmployeeStats, Gender, Religion, Height, Weight, EmailAdd, Caddress, Paddress, role, Picture,created_at)
values (@user_id, @fname, @mname, @lname, @birthdate, @birthplace, @Cstatus, @Age, @CellphoneNo, @datehired, @EmployeeStats, @Gender, @Religion, @Height, @Weight, @EmailAdd, @Caddress, @Paddress, @role, @Picture,@created_at)", connection)
        Dim pic As New MemoryStream
        ImgBox.Image.Save(pic, ImgBox.Image.RawFormat)
        'System.NullReferenceException 'Object reference not set to an instance of an object.'

        Dim dob As DateTime = Date.Now
        Console.WriteLine("Day:{0}", dob.Day)
        Console.WriteLine("Month:{0}", dob.Month)
        Console.WriteLine("Year:{0}", dob.Year)
        Console.WriteLine("Hour:{0}", dob.Hour)
        Console.WriteLine("Minute:{0}", dob.Minute)
        Console.WriteLine("Second:{0}", dob.Second)
        Console.WriteLine("Millisecond:{0}", dob.Millisecond)

        'Add New Employee Info

        command.Parameters.Add("@user_id", SqlDbType.Int).Value = tbxEmployeeId.Text
        command.Parameters.Add("@fname", SqlDbType.VarChar).Value = tbxFname.Text
        command.Parameters.Add("@mname", SqlDbType.VarChar).Value = tbxMName.Text
        command.Parameters.Add("@lname", SqlDbType.VarChar).Value = tbxLname.Text
        command.Parameters.Add("@birthdate", SqlDbType.Date).Value = tbxBday.Value
        command.Parameters.Add("@birthplace", SqlDbType.VarChar).Value = TbxBplace.Text
        command.Parameters.Add("@Cstatus", SqlDbType.VarChar).Value = CmbCstatus.Text
        command.Parameters.Add("@Age", SqlDbType.Int).Value = TbxAge.Text
        command.Parameters.Add("@CellphoneNo", SqlDbType.VarChar).Value = tbxCpno.Text
        command.Parameters.Add("@datehired", SqlDbType.Date).Value = tbxDhired.Value
        command.Parameters.Add("@EmployeeStats", SqlDbType.VarChar).Value = CmbEstatus.Text
        command.Parameters.Add("@Gender", SqlDbType.VarChar).Value = CmbGender.Text
        command.Parameters.Add("@Religion", SqlDbType.VarChar).Value = tbxReligion.Text
        command.Parameters.Add("@Height", SqlDbType.VarChar).Value = tbxHeight.Text
        command.Parameters.Add("@Weight", SqlDbType.VarChar).Value = tbxWeight.Text
        command.Parameters.Add("@EmailAdd", SqlDbType.VarChar).Value = TbxEAddress.Text
        command.Parameters.Add("@Caddress", SqlDbType.Text).Value = tbxCAddress.Text
        command.Parameters.Add("@Paddress", SqlDbType.Text).Value = tbxPaddress.Text
        command.Parameters.Add("@role", SqlDbType.VarChar).Value = "Truck Driver"
        command.Parameters.Add("@Picture", SqlDbType.Image).Value = pic.ToArray()
        command.Parameters.Add("@created_at", SqlDbType.DateTime).Value = dob


        'Open Database Connection
        connection.Open()
        If command.ExecuteNonQuery = 1 Then

            MessageBox.Show("A new Driver is added")

        Else
            MessageBox.Show("Error, new Driver not added")
        End If
        connection.Close()

        Me.Hide()

        Home.Show()
    End Sub
    Private Sub tbxEmployeeId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxEmployeeId.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True

        End If
    End Sub


    Private Sub TbxAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxAge.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TbxBday_ValueChanged(sender As Object, e As EventArgs) Handles tbxBday.ValueChanged
        Dim today, dob As Integer
        today = DateTime.Today.Year
        dob = tbxBday.Value.Year
        TbxAge.Text = today.ToString - dob.ToString
    End Sub

    Private Sub TbxAge_TextChanged(sender As Object, e As EventArgs) Handles TbxAge.TextChanged
        TbxAge.Enabled = False
    End Sub
    Private Sub Same_CheckedChanged(sender As Object, e As EventArgs) Handles btnSame.CheckedChanged
        If btnSame.Checked Then
            tbxPaddress.Enabled = False
            PAddress.ForeColor = Color.Gray
            tbxCAddress.Enabled = True
            Caddress.ForeColor = Color.Black
            tbxCAddress.Text = ""
        Else
            tbxPaddress.Enabled = True
            PAddress.ForeColor = Color.Black
            tbxPaddress.Text = ""
        End If
    End Sub

    Private Sub tbxCpno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxCpno.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            MsgBox("Numbers only please!", MsgBoxStyle.RetryCancel)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub PictureMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureMax_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
        PictureRest.Visible = True
        PictureMax.Visible = False
    End Sub
    Private Sub PictureRest_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Normal
        PictureRest.Visible = False
        PictureMax.Visible = True
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
        TbxAge.Text = ""
        tbxCpno.Text = ""
        tbxDhired.Text = ""
        CmbEstatus.Text = ""
        CmbGender.Text = ""
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
        ImgBox.Image = Nothing



    End Sub

    Private Sub Pictureback_Click(sender As Object, e As EventArgs) Handles PictureBack.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub TbxEmployeeId_TextChanged(sender As Object, e As EventArgs) Handles tbxEmployeeId.TextChanged

    End Sub

    Private Sub PictureExit_Click(sender As Object, e As EventArgs) Handles PictureExit.Click
        Me.Close()
    End Sub
End Class
