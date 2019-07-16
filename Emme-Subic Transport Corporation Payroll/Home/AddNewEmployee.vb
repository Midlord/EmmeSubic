Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Bitmap
Public Class AddNewEmployee
    Dim connection As New SqlConnection("Server = DESKTOP-BBDJH6Q; Database = EmmeSubic; Integrated Security = true")
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
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'Dim caption As String
            Dim command As New SqlCommand("insert into UserDetails(fname, mname, lname, birthdate, birthplace, Cstatus, Age, CellphoneNo, datehired, EmployeeStats, Gender, Religion, Height, Weight, EmailAdd, Caddress, Paddress, role, Picture, created_at, EmployeeID)
            values (@fname, @mname, @lname, @birthdate, @birthplace, @Cstatus, @Age, @CellphoneNo, @datehired, @EmployeeStats, @Gender, @Religion, @Height, @Weight, @EmailAdd, @Caddress, @Paddress, @role, @Picture, @created_at, @EmployeeID)", connection)
            Dim pic As New MemoryStream
            Dim pec As Image
            pec = Emme_Subic_Transport_Corporation_Payroll.My.Resources._24

            Dim dob As DateTime = Date.Now
            Console.WriteLine("Day:{0}", dob.Day)
            Console.WriteLine("Month:{0}", dob.Month)
            Console.WriteLine("Year:{0}", dob.Year)
            Console.WriteLine("Hour:{0}", dob.Hour)
            Console.WriteLine("Minute:{0}", dob.Minute)
            Console.WriteLine("Second:{0}", dob.Second)
            Console.WriteLine("Millisecond:{0}", dob.Millisecond)

            'Add New Employee Info

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
            command.Parameters.Add("@created_at", SqlDbType.DateTime).Value = dob
            command.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = tbxEmployeeId.Text
            If ImgBox.Image IsNot Nothing Then
                'check if image is not null
                ImgBox.Image.Save(pic, ImgBox.Image.RawFormat)
                command.Parameters.Add("@Picture", SqlDbType.Image).Value = pic.ToArray()
            Else
                command.Parameters.Add("@Picture", SqlDbType.Image).Value = pec
            End If

            'Open Database Connection
            connection.Open()
            If command.ExecuteNonQuery Then
                If tbxEmployeeId.Text = "" Or tbxFname.Text = "" Or tbxLname.Text = "" Or tbxBday.Text = "" Or TbxBplace.Text = "" Or CmbCstatus.Text = Nothing Or TbxAge.Text = "" Or tbxCpno.Text = "" Or tbxDhired.Text = "" Or CmbEstatus.Text = Nothing Or TbxEAddress.Text = "" Or tbxCAddress.Text = "" Or btnSame.Checked = False Or tbxSSS.Text = "" Or tbxPagibig.Text = "" Or tbxCpno.Text = "" Or tbxPhilhealth.Text = "" Or tbxTIN.Text = "" Then
                    MessageBox.Show("Please enter required fields.")
                    tbxEmployeeId.Text = ""
                    tbxFname.Text = ""
                    tbxLname.Text = ""
                    tbxBday.Text = ""
                    TbxBplace.Text = ""
                    CmbCstatus.Text = Nothing
                    TbxAge.Text = ""
                    tbxCpno.Text = ""
                    tbxDhired.Text = ""
                    CmbEstatus.Text = Nothing
                    CmbGender.Text = Nothing
                    TbxEAddress.Text = ""
                    tbxCAddress.Text = ""
                    btnSame.Checked = False
                    tbxSSS.Text = ""
                    tbxPagibig.Text = ""
                    tbxPhilhealth.Text = ""
                    tbxTIN.Text = ""
                Else
                    MessageBox.Show("A new Driver is added")
                    tbxEmployeeId.Text = ""
                    tbxFname.Text = ""
                    tbxMName.Text = ""
                    tbxLname.Text = ""
                    tbxBday.Text = ""
                    TbxBplace.Text = ""
                    CmbCstatus.Text = Nothing
                    TbxAge.Text = ""
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
                    ImgBox.Image = Nothing
                    Me.Hide()
                    Home.Show()
                End If
            Else
                MessageBox.Show("Employee not able to add")
            End If

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tbxEmployeeId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxEmployeeId.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," AndAlso e.KeyChar <> "-" Then
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
        'Dim today, dob As Integer
        'Today = DateTime.Today.Year
        'dob = tbxBday.Value.Year
        'TbxAge.Text = today.ToString - dob.ToString

        Dim dob As DateTime
        dob = New DateTime(tbxBday.Value.Year, tbxBday.Value.Month, tbxBday.Value.Day)
        Dim tday As TimeSpan = DateTime.Now.Subtract(dob)
        Dim years As Integer, months As Integer, days As Integer
        months = 12 * (DateTime.Now.Year - dob.Year) + (DateTime.Now.Month - dob.Month)

        If DateTime.Now.Day < dob.Day Then
            months -= 1
            days = DateTime.DaysInMonth(dob.Year, dob.Month) - dob.Day + DateTime.Now.Day
        Else
            days = DateTime.Now.Day - dob.Day
        End If
        years = Math.Floor(months / 12)
        months -= years * 12
        TbxAge.Text = years

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

        Else
            tbxPaddress.Enabled = True
            PAddress.ForeColor = Color.Black
            tbxPaddress.Text = ""
        End If
    End Sub

    Private Sub tbxCpno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxCpno.KeyPress

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
               AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "+" AndAlso e.KeyChar <> "(" AndAlso e.KeyChar <> ")" Then
            e.Handled = True
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
        TbxAge.Text = ""
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

    Private Sub PictureMax_Click_1(sender As Object, e As EventArgs) Handles PictureMax.Click
        Me.WindowState = FormWindowState.Maximized
        PictureRest.Visible = True
        PictureMax.Visible = False
    End Sub

    Private Sub PictureRest_Click_1(sender As Object, e As EventArgs) Handles PictureRest.Click
        Me.WindowState = FormWindowState.Normal
        PictureRest.Visible = False
        PictureMax.Visible = True
    End Sub

    Private Sub PictureMix_Click(sender As Object, e As EventArgs) Handles PictureMix.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub tbxLname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxLname.KeyPress
        If (e.KeyChar < "a" OrElse e.KeyChar > "z") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> " " Then
            e.Handled = True

        End If
    End Sub

    Private Sub tbxFname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxFname.KeyPress
        If (e.KeyChar < "a" OrElse e.KeyChar > "z") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> " " Then
            e.Handled = True

        End If
    End Sub

    Private Sub tbxMName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxMName.KeyPress
        If (e.KeyChar < "a" OrElse e.KeyChar > "z") _
                  AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbxBday_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxBday.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub TbxBplace_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxBplace.KeyPress
        If (e.KeyChar < "a" OrElse e.KeyChar > "z") _
               AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub CmbCstatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbCstatus.KeyPress
        If (e.KeyChar < "a" OrElse e.KeyChar > "z") _
               AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbxDhired_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxDhired.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub



    Private Sub CmbEstatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbEstatus.KeyPress
        If (e.KeyChar < "a" OrElse e.KeyChar > "z") _
              AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub CmbGender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbGender.KeyPress
        If (e.KeyChar < "a" OrElse e.KeyChar > "z") _
              AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbxReligion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxReligion.KeyPress
        If (e.KeyChar < "a" OrElse e.KeyChar > "z") _
              AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub tbxHeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxHeight.KeyPress
        If (e.KeyChar < "a" OrElse e.KeyChar > "z") _
              AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " AndAlso e.KeyChar <> "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbxWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxWeight.KeyPress
        If (e.KeyChar < "a" OrElse e.KeyChar > "z") _
              AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub


    Private Sub TbxEAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxEAddress.KeyPress
        If (e.KeyChar < "a" OrElse e.KeyChar > "z") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "@" Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbxCAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxCAddress.KeyPress
        If (e.KeyChar < "a" OrElse e.KeyChar > "z") _
              AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "," AndAlso e.KeyChar <> " " AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "1," AndAlso e.KeyChar <> "2" AndAlso e.KeyChar <> "3" AndAlso e.KeyChar <> "4" AndAlso e.KeyChar <> "5" AndAlso e.KeyChar <> "6" AndAlso e.KeyChar <> "7" AndAlso e.KeyChar <> "8" AndAlso e.KeyChar <> "9" AndAlso e.KeyChar <> "0" Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbxPaddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxPaddress.KeyPress
        If (e.KeyChar < "a" OrElse e.KeyChar > "z") _
             AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "," AndAlso e.KeyChar <> " " AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "1," AndAlso e.KeyChar <> "2" AndAlso e.KeyChar <> "3" AndAlso e.KeyChar <> "4" AndAlso e.KeyChar <> "5" AndAlso e.KeyChar <> "6" AndAlso e.KeyChar <> "7" AndAlso e.KeyChar <> "8" AndAlso e.KeyChar <> "9" AndAlso e.KeyChar <> "0" Then
            e.Handled = True
        End If
    End Sub
    Private Sub tbxSSS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxSSS.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub tbxPagibig_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxPagibig.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub tbxPhilhealth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxPhilhealth.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub tbxTIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxTIN.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
End Class
