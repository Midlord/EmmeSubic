<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DateTimePickerDeparture = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbRemarks = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbxwaybill = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbxSealNo = New System.Windows.Forms.TextBox()
        Me.tbxBLnumber = New System.Windows.Forms.TextBox()
        Me.CmbActivityType = New System.Windows.Forms.ComboBox()
        Me.PictureMin = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePickerArrival = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureMax = New System.Windows.Forms.PictureBox()
        Me.tbxContainerNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureExit = New System.Windows.Forms.PictureBox()
        Me.PictureRest = New System.Windows.Forms.PictureBox()
        Me.TripSheetView = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tbxOrigin = New System.Windows.Forms.TextBox()
        Me.tbxodometer = New System.Windows.Forms.TextBox()
        Me.tbxtractorplate = New System.Windows.Forms.TextBox()
        Me.tbxfinalkm = New System.Windows.Forms.TextBox()
        Me.tbxconsignee = New System.Windows.Forms.TextBox()
        Me.tbxDifnumber = New System.Windows.Forms.TextBox()
        Me.tbxchasisnumber = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxdriverhelper = New System.Windows.Forms.TextBox()
        Me.tbxDate = New System.Windows.Forms.DateTimePicker()
        Me.tbxtodestination = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxfromdestination = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.EmployeeID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tbxRate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Rate = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureRest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TripSheetView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.btnUpdate.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePickerDeparture
        '
        Me.DateTimePickerDeparture.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePickerDeparture.Checked = False
        Me.DateTimePickerDeparture.CustomFormat = "dddd, dd - MM - yyyy"
        Me.DateTimePickerDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerDeparture.Location = New System.Drawing.Point(197, 179)
        Me.DateTimePickerDeparture.Name = "DateTimePickerDeparture"
        Me.DateTimePickerDeparture.Size = New System.Drawing.Size(214, 20)
        Me.DateTimePickerDeparture.TabIndex = 27
        Me.DateTimePickerDeparture.Value = New Date(2019, 7, 19, 2, 33, 59, 0)
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label21.Location = New System.Drawing.Point(14, 203)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(177, 21)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Arrival @ consignee:"
        '
        'cmbRemarks
        '
        Me.cmbRemarks.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbRemarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRemarks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbRemarks.FormattingEnabled = True
        Me.cmbRemarks.Items.AddRange(New Object() {"MONDAY TRIP", "TUESDAY TRIP", "WEDNESDAY TRIP", "THURSDAY TRIP", "FRIDAY TRIP"})
        Me.cmbRemarks.Location = New System.Drawing.Point(161, 257)
        Me.cmbRemarks.Name = "cmbRemarks"
        Me.cmbRemarks.Size = New System.Drawing.Size(226, 21)
        Me.cmbRemarks.TabIndex = 19
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.AutoSize = True
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label20.Location = New System.Drawing.Point(14, 257)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 21)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Remarks:"
        '
        'tbxwaybill
        '
        Me.tbxwaybill.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxwaybill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxwaybill.Location = New System.Drawing.Point(164, 13)
        Me.tbxwaybill.Name = "tbxwaybill"
        Me.tbxwaybill.Size = New System.Drawing.Size(227, 20)
        Me.tbxwaybill.TabIndex = 10
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label19.Location = New System.Drawing.Point(14, 13)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(140, 21)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Waybill Number:"
        '
        'tbxSealNo
        '
        Me.tbxSealNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxSealNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxSealNo.Location = New System.Drawing.Point(164, 155)
        Me.tbxSealNo.Name = "tbxSealNo"
        Me.tbxSealNo.Size = New System.Drawing.Size(227, 20)
        Me.tbxSealNo.TabIndex = 16
        '
        'tbxBLnumber
        '
        Me.tbxBLnumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxBLnumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxBLnumber.Location = New System.Drawing.Point(164, 131)
        Me.tbxBLnumber.Name = "tbxBLnumber"
        Me.tbxBLnumber.Size = New System.Drawing.Size(227, 20)
        Me.tbxBLnumber.TabIndex = 15
        '
        'CmbActivityType
        '
        Me.CmbActivityType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbActivityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbActivityType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmbActivityType.FormattingEnabled = True
        Me.CmbActivityType.Items.AddRange(New Object() {"IMPORT", "EXPORT", "PULLOUT", "POSITION"})
        Me.CmbActivityType.Location = New System.Drawing.Point(165, 106)
        Me.CmbActivityType.Name = "CmbActivityType"
        Me.CmbActivityType.Size = New System.Drawing.Size(226, 21)
        Me.CmbActivityType.TabIndex = 14
        '
        'PictureMin
        '
        Me.PictureMin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureMin.BackgroundImage = Global.Emme_Subic_Transport_Corporation_Payroll.My.Resources.Resources._22
        Me.PictureMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureMin.Location = New System.Drawing.Point(1149, 4)
        Me.PictureMin.Name = "PictureMin"
        Me.PictureMin.Size = New System.Drawing.Size(25, 25)
        Me.PictureMin.TabIndex = 11
        Me.PictureMin.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(316, 291)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 37)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "UPDATE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DateTimePickerArrival
        '
        Me.DateTimePickerArrival.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePickerArrival.Checked = False
        Me.DateTimePickerArrival.CustomFormat = "dddd, dd - MM - yyyy"
        Me.DateTimePickerArrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerArrival.Location = New System.Drawing.Point(197, 203)
        Me.DateTimePickerArrival.Name = "DateTimePickerArrival"
        Me.DateTimePickerArrival.Size = New System.Drawing.Size(214, 20)
        Me.DateTimePickerArrival.TabIndex = 28
        Me.DateTimePickerArrival.Value = New Date(2019, 7, 19, 2, 33, 59, 0)
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Emme_Subic_Transport_Corporation_Payroll.My.Resources.Resources.Icon_PNG
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureMax
        '
        Me.PictureMax.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureMax.BackgroundImage = Global.Emme_Subic_Transport_Corporation_Payroll.My.Resources.Resources._20
        Me.PictureMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureMax.Location = New System.Drawing.Point(1180, 3)
        Me.PictureMax.Name = "PictureMax"
        Me.PictureMax.Size = New System.Drawing.Size(25, 25)
        Me.PictureMax.TabIndex = 12
        Me.PictureMax.TabStop = False
        '
        'tbxContainerNumber
        '
        Me.tbxContainerNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxContainerNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxContainerNumber.Location = New System.Drawing.Point(164, 82)
        Me.tbxContainerNumber.Name = "tbxContainerNumber"
        Me.tbxContainerNumber.Size = New System.Drawing.Size(227, 20)
        Me.tbxContainerNumber.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(35, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(338, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Emme-Subic Transport Corporation Add New Trip"
        '
        'PictureExit
        '
        Me.PictureExit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureExit.BackgroundImage = Global.Emme_Subic_Transport_Corporation_Payroll.My.Resources.Resources._21
        Me.PictureExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureExit.Location = New System.Drawing.Point(1211, 3)
        Me.PictureExit.Name = "PictureExit"
        Me.PictureExit.Size = New System.Drawing.Size(25, 25)
        Me.PictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureExit.TabIndex = 13
        Me.PictureExit.TabStop = False
        '
        'PictureRest
        '
        Me.PictureRest.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureRest.BackgroundImage = Global.Emme_Subic_Transport_Corporation_Payroll.My.Resources.Resources._20
        Me.PictureRest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureRest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureRest.Location = New System.Drawing.Point(1180, 3)
        Me.PictureRest.Name = "PictureRest"
        Me.PictureRest.Size = New System.Drawing.Size(25, 25)
        Me.PictureRest.TabIndex = 13
        Me.PictureRest.TabStop = False
        '
        'TripSheetView
        '
        Me.TripSheetView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TripSheetView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TripSheetView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TripSheetView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TripSheetView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.TripSheetView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TripSheetView.Location = New System.Drawing.Point(12, 384)
        Me.TripSheetView.Name = "TripSheetView"
        Me.TripSheetView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.TripSheetView.Size = New System.Drawing.Size(1215, 422)
        Me.TripSheetView.TabIndex = 26
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.PictureExit)
        Me.Panel4.Controls.Add(Me.PictureBox3)
        Me.Panel4.Controls.Add(Me.PictureMax)
        Me.Panel4.Controls.Add(Me.PictureMin)
        Me.Panel4.Controls.Add(Me.PictureRest)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1239, 33)
        Me.Panel4.TabIndex = 29
        '
        'tbxOrigin
        '
        Me.tbxOrigin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxOrigin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxOrigin.Location = New System.Drawing.Point(164, 59)
        Me.tbxOrigin.Name = "tbxOrigin"
        Me.tbxOrigin.Size = New System.Drawing.Size(227, 20)
        Me.tbxOrigin.TabIndex = 12
        '
        'tbxodometer
        '
        Me.tbxodometer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxodometer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxodometer.Location = New System.Drawing.Point(462, 110)
        Me.tbxodometer.Name = "tbxodometer"
        Me.tbxodometer.Size = New System.Drawing.Size(165, 20)
        Me.tbxodometer.TabIndex = 3
        '
        'tbxtractorplate
        '
        Me.tbxtractorplate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxtractorplate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxtractorplate.Location = New System.Drawing.Point(150, 108)
        Me.tbxtractorplate.Name = "tbxtractorplate"
        Me.tbxtractorplate.Size = New System.Drawing.Size(190, 20)
        Me.tbxtractorplate.TabIndex = 2
        '
        'tbxfinalkm
        '
        Me.tbxfinalkm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxfinalkm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxfinalkm.Location = New System.Drawing.Point(462, 267)
        Me.tbxfinalkm.Name = "tbxfinalkm"
        Me.tbxfinalkm.Size = New System.Drawing.Size(165, 20)
        Me.tbxfinalkm.TabIndex = 9
        '
        'tbxconsignee
        '
        Me.tbxconsignee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxconsignee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxconsignee.Location = New System.Drawing.Point(152, 267)
        Me.tbxconsignee.Name = "tbxconsignee"
        Me.tbxconsignee.Size = New System.Drawing.Size(190, 20)
        Me.tbxconsignee.TabIndex = 8
        '
        'tbxDifnumber
        '
        Me.tbxDifnumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxDifnumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxDifnumber.Location = New System.Drawing.Point(150, 233)
        Me.tbxDifnumber.Name = "tbxDifnumber"
        Me.tbxDifnumber.Size = New System.Drawing.Size(226, 20)
        Me.tbxDifnumber.TabIndex = 7
        '
        'tbxchasisnumber
        '
        Me.tbxchasisnumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxchasisnumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxchasisnumber.Location = New System.Drawing.Point(150, 202)
        Me.tbxchasisnumber.Name = "tbxchasisnumber"
        Me.tbxchasisnumber.Size = New System.Drawing.Size(226, 20)
        Me.tbxchasisnumber.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Location = New System.Drawing.Point(14, 110)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 21)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Tractor Plate:"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(346, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 21)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Odometer No:"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(14, 199)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 21)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Chasis Number:"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(14, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 21)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "DIF Number:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(14, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 21)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Broker/Consignee:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(359, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 21)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Final KM:"
        '
        'tbxdriverhelper
        '
        Me.tbxdriverhelper.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxdriverhelper.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxdriverhelper.Location = New System.Drawing.Point(150, 79)
        Me.tbxdriverhelper.Name = "tbxdriverhelper"
        Me.tbxdriverhelper.Size = New System.Drawing.Size(226, 20)
        Me.tbxdriverhelper.TabIndex = 1
        '
        'tbxDate
        '
        Me.tbxDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxDate.Checked = False
        Me.tbxDate.CustomFormat = "dddd, dd - MM - yyyy"
        Me.tbxDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tbxDate.Location = New System.Drawing.Point(164, 36)
        Me.tbxDate.Name = "tbxDate"
        Me.tbxDate.Size = New System.Drawing.Size(227, 20)
        Me.tbxDate.TabIndex = 11
        Me.tbxDate.Value = New Date(2019, 7, 19, 2, 33, 59, 0)
        '
        'tbxtodestination
        '
        Me.tbxtodestination.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxtodestination.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxtodestination.Location = New System.Drawing.Point(150, 169)
        Me.tbxtodestination.Name = "tbxtodestination"
        Me.tbxtodestination.Size = New System.Drawing.Size(226, 20)
        Me.tbxtodestination.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(14, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "To Destination:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(14, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Employee Name:"
        '
        'Panel
        '
        Me.Panel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel.Controls.Add(Me.tbxodometer)
        Me.Panel.Controls.Add(Me.tbxtractorplate)
        Me.Panel.Controls.Add(Me.tbxfinalkm)
        Me.Panel.Controls.Add(Me.tbxconsignee)
        Me.Panel.Controls.Add(Me.tbxDifnumber)
        Me.Panel.Controls.Add(Me.tbxchasisnumber)
        Me.Panel.Controls.Add(Me.Label13)
        Me.Panel.Controls.Add(Me.Label12)
        Me.Panel.Controls.Add(Me.Label11)
        Me.Panel.Controls.Add(Me.Label10)
        Me.Panel.Controls.Add(Me.Label9)
        Me.Panel.Controls.Add(Me.Label8)
        Me.Panel.Controls.Add(Me.tbxdriverhelper)
        Me.Panel.Controls.Add(Me.Label5)
        Me.Panel.Controls.Add(Me.tbxtodestination)
        Me.Panel.Controls.Add(Me.Label4)
        Me.Panel.Controls.Add(Me.Label2)
        Me.Panel.Controls.Add(Me.tbxfromdestination)
        Me.Panel.Controls.Add(Me.Label)
        Me.Panel.Controls.Add(Me.EmployeeID)
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Controls.Add(Me.LabelName)
        Me.Panel.Location = New System.Drawing.Point(12, 39)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(630, 339)
        Me.Panel.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(14, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Driver Helper:"
        '
        'tbxfromdestination
        '
        Me.tbxfromdestination.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxfromdestination.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxfromdestination.Location = New System.Drawing.Point(150, 137)
        Me.tbxfromdestination.Name = "tbxfromdestination"
        Me.tbxfromdestination.Size = New System.Drawing.Size(226, 20)
        Me.tbxfromdestination.TabIndex = 4
        '
        'Label
        '
        Me.Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label.AutoSize = True
        Me.Label.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label.Location = New System.Drawing.Point(14, 134)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(133, 21)
        Me.Label.TabIndex = 5
        Me.Label.Text = "From Destination:"
        '
        'EmployeeID
        '
        Me.EmployeeID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmployeeID.AutoSize = True
        Me.EmployeeID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.EmployeeID.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmployeeID.Location = New System.Drawing.Point(147, 9)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(97, 21)
        Me.EmployeeID.TabIndex = 6
        Me.EmployeeID.Text = "Employee ID"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Employee ID: "
        '
        'LabelName
        '
        Me.LabelName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LabelName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelName.Location = New System.Drawing.Point(147, 42)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(124, 21)
        Me.LabelName.TabIndex = 4
        Me.LabelName.Text = "Employee Name"
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnUpdate.Controls.Add(Me.Button1)
        Me.btnUpdate.Controls.Add(Me.DateTimePickerArrival)
        Me.btnUpdate.Controls.Add(Me.DateTimePickerDeparture)
        Me.btnUpdate.Controls.Add(Me.Label21)
        Me.btnUpdate.Controls.Add(Me.cmbRemarks)
        Me.btnUpdate.Controls.Add(Me.Label20)
        Me.btnUpdate.Controls.Add(Me.tbxwaybill)
        Me.btnUpdate.Controls.Add(Me.Label19)
        Me.btnUpdate.Controls.Add(Me.tbxSealNo)
        Me.btnUpdate.Controls.Add(Me.tbxBLnumber)
        Me.btnUpdate.Controls.Add(Me.CmbActivityType)
        Me.btnUpdate.Controls.Add(Me.tbxContainerNumber)
        Me.btnUpdate.Controls.Add(Me.tbxOrigin)
        Me.btnUpdate.Controls.Add(Me.Label18)
        Me.btnUpdate.Controls.Add(Me.Label17)
        Me.btnUpdate.Controls.Add(Me.Label16)
        Me.btnUpdate.Controls.Add(Me.Label15)
        Me.btnUpdate.Controls.Add(Me.Label14)
        Me.btnUpdate.Controls.Add(Me.btnSave)
        Me.btnUpdate.Controls.Add(Me.tbxRate)
        Me.btnUpdate.Controls.Add(Me.Label3)
        Me.btnUpdate.Controls.Add(Me.Rate)
        Me.btnUpdate.Controls.Add(Me.tbxDate)
        Me.btnUpdate.Controls.Add(Me.Label6)
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUpdate.Location = New System.Drawing.Point(648, 39)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(579, 339)
        Me.btnUpdate.TabIndex = 28
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label18.Location = New System.Drawing.Point(14, 131)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 21)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "BL Number:"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label17.Location = New System.Drawing.Point(14, 155)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 21)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Seal No:"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label16.Location = New System.Drawing.Point(14, 179)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(177, 21)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Departure @ consignee:"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(14, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(143, 21)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Container Number:"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label14.Location = New System.Drawing.Point(14, 106)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 21)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Activity Type:"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.Black
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSave.Location = New System.Drawing.Point(227, 290)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 37)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save Trip"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'tbxRate
        '
        Me.tbxRate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxRate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxRate.Location = New System.Drawing.Point(161, 231)
        Me.tbxRate.Name = "tbxRate"
        Me.tbxRate.Size = New System.Drawing.Size(226, 20)
        Me.tbxRate.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(14, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Trip Date:"
        '
        'Rate
        '
        Me.Rate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Rate.AutoSize = True
        Me.Rate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Rate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Rate.Location = New System.Drawing.Point(14, 231)
        Me.Rate.Name = "Rate"
        Me.Rate.Size = New System.Drawing.Size(74, 21)
        Me.Rate.TabIndex = 4
        Me.Rate.Text = "Trip Rate:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(14, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Truck Origin:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1239, 815)
        Me.Controls.Add(Me.TripSheetView)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.btnUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureRest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TripSheetView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.btnUpdate.ResumeLayout(False)
        Me.btnUpdate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateTimePickerDeparture As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents cmbRemarks As ComboBox
    Private WithEvents Label20 As Label
    Friend WithEvents tbxwaybill As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tbxSealNo As TextBox
    Friend WithEvents tbxBLnumber As TextBox
    Friend WithEvents CmbActivityType As ComboBox
    Friend WithEvents PictureMin As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePickerArrival As DateTimePicker
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureMax As PictureBox
    Friend WithEvents tbxContainerNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureExit As PictureBox
    Friend WithEvents PictureRest As PictureBox
    Friend WithEvents TripSheetView As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tbxOrigin As TextBox
    Friend WithEvents tbxodometer As TextBox
    Friend WithEvents tbxtractorplate As TextBox
    Friend WithEvents tbxfinalkm As TextBox
    Friend WithEvents tbxconsignee As TextBox
    Friend WithEvents tbxDifnumber As TextBox
    Friend WithEvents tbxchasisnumber As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbxdriverhelper As TextBox
    Friend WithEvents tbxDate As DateTimePicker
    Friend WithEvents tbxtodestination As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents tbxfromdestination As TextBox
    Friend WithEvents Label As Label
    Friend WithEvents EmployeeID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents btnUpdate As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents tbxRate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Rate As Label
    Friend WithEvents Label6 As Label
End Class
