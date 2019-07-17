Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Bitmap
Public Class DriveLists

    Dim connection As New SqlConnection("Server = DESKTOP-BBDJH6Q; Database = EmmeSubic; Integrated Security = true")
    Private Sub DriveLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmmeSubicDataSetLast.UserDetails' table. You can move, or remove it, as needed.
        Me.UserDetailsTableAdapter.Fill(Me.EmmeSubicDataSetLast.UserDetails)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'Dim caption As String
            Dim command As New SqlCommand("insert into UserDetails(fname, mname, lname, birthdate, birthplace, Cstatus, Age, CellphoneNo, datehired, EmployeeStats, Gender, Religion, Height, Weight, EmailAdd, Caddress, Paddress, role, Picture, created_at, EmployeeID, sss, pagibig, philhealth, tin)
            values (@fname, @mname, @lname, @birthdate, @birthplace, @Cstatus, @Age, @CellphoneNo, @datehired, @EmployeeStats, @Gender, @Religion, @Height, @Weight, @EmailAdd, @Caddress, @Paddress, @role, @Picture, @created_at, @EmployeeID, @sss, @pagibig, @philhealth, @tin,)", connection)
            Dim pic As New MemoryStream
            Dim pec As Image
            pec = My.Resources._24

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
            command.Parameters.Add("@sss", SqlDbType.VarChar).Value = tbxSSS.Text
            command.Parameters.Add("@pagibig", SqlDbType.VarChar).Value = tbxPagibig.Text
            command.Parameters.Add("@philhealth", SqlDbType.VarChar).Value = tbxPhilhealth.Text
            command.Parameters.Add("@tin", SqlDbType.VarChar).Value = tbxTIN.Text
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
End Class
