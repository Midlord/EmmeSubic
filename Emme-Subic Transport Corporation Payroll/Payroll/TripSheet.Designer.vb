<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TripSheet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TripSheet))
        Me.tbxfromdestination = New System.Windows.Forms.TextBox()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.tbxconsignee = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbxdriverhelper = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxtodestination = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.EmployeeID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.tbxDate = New System.Windows.Forms.DateTimePicker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureExit = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureMax = New System.Windows.Forms.PictureBox()
        Me.PictureMin = New System.Windows.Forms.PictureBox()
        Me.PictureRest = New System.Windows.Forms.PictureBox()
        Me.TripSheetView = New System.Windows.Forms.DataGridView()
        Me.Rate = New System.Windows.Forms.Label()
        Me.tbxRate = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbxContainerNumber = New System.Windows.Forms.TextBox()
        Me.CmbActivityType = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbxwaybill = New System.Windows.Forms.TextBox()
        Me.btnupdatee = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Remarks = New System.Windows.Forms.Label()
        Me.cmbremark = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbRemarks = New System.Windows.Forms.TextBox()
        Me.tbxTimesheetId = New System.Windows.Forms.TextBox()
        Me.Panel.SuspendLayout
        Me.Panel4.SuspendLayout
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureRest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TripSheetView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnUpdate.SuspendLayout
        Me.SuspendLayout
        '
        'tbxfromdestination
        '
        Me.tbxfromdestination.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxfromdestination.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxfromdestination.Location = New System.Drawing.Point(151, 154)
        Me.tbxfromdestination.Name = "tbxfromdestination"
        Me.tbxfromdestination.Size = New System.Drawing.Size(226, 20)
        Me.tbxfromdestination.TabIndex = 3
        '
        'Panel
        '
        Me.Panel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel.Controls.Add(Me.tbxTimesheetId)
        Me.Panel.Controls.Add(Me.tbxconsignee)
        Me.Panel.Controls.Add(Me.Label9)
        Me.Panel.Controls.Add(Me.tbxdriverhelper)
        Me.Panel.Controls.Add(Me.Label5)
        Me.Panel.Controls.Add(Me.tbxtodestination)
        Me.Panel.Controls.Add(Me.Label4)
        Me.Panel.Controls.Add(Me.Label2)
        Me.Panel.Controls.Add(Me.tbxfromdestination)
        Me.Panel.Controls.Add(Me.Label)
        Me.Panel.Controls.Add(Me.EmployeeID)
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Controls.Add(Me.Label3)
        Me.Panel.Controls.Add(Me.LabelName)
        Me.Panel.Controls.Add(Me.tbxDate)
        Me.Panel.Location = New System.Drawing.Point(12, 39)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(630, 339)
        Me.Panel.TabIndex = 1
        '
        'tbxconsignee
        '
        Me.tbxconsignee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxconsignee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxconsignee.Location = New System.Drawing.Point(151, 127)
        Me.tbxconsignee.Name = "tbxconsignee"
        Me.tbxconsignee.Size = New System.Drawing.Size(226, 20)
        Me.tbxconsignee.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(12, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 21)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Broker/Consignee:"
        '
        'tbxdriverhelper
        '
        Me.tbxdriverhelper.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxdriverhelper.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxdriverhelper.Location = New System.Drawing.Point(151, 206)
        Me.tbxdriverhelper.Name = "tbxdriverhelper"
        Me.tbxdriverhelper.Size = New System.Drawing.Size(226, 20)
        Me.tbxdriverhelper.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(12, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Driver Helper:"
        '
        'tbxtodestination
        '
        Me.tbxtodestination.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxtodestination.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxtodestination.Location = New System.Drawing.Point(151, 180)
        Me.tbxtodestination.Name = "tbxtodestination"
        Me.tbxtodestination.Size = New System.Drawing.Size(226, 20)
        Me.tbxtodestination.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(12, 177)
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
        'Label
        '
        Me.Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label.AutoSize = True
        Me.Label.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label.Location = New System.Drawing.Point(12, 151)
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
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(12, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Trip Date:"
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
        'tbxDate
        '
        Me.tbxDate.Checked = False
        Me.tbxDate.CustomFormat = "MM/dd/yyyy"
        Me.tbxDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tbxDate.Location = New System.Drawing.Point(151, 101)
        Me.tbxDate.MinDate = New Date(2019, 7, 1, 0, 0, 0, 0)
        Me.tbxDate.Name = "tbxDate"
        Me.tbxDate.Size = New System.Drawing.Size(226, 20)
        Me.tbxDate.TabIndex = 1
        Me.tbxDate.Value = New Date(2019, 7, 30, 0, 0, 0, 0)
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
        Me.Panel4.TabIndex = 25
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
        Me.TripSheetView.AllowUserToAddRows = False
        Me.TripSheetView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TripSheetView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TripSheetView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TripSheetView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.TripSheetView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TripSheetView.Location = New System.Drawing.Point(12, 384)
        Me.TripSheetView.Name = "TripSheetView"
        Me.TripSheetView.Size = New System.Drawing.Size(1215, 422)
        Me.TripSheetView.TabIndex = 0
        '
        'Rate
        '
        Me.Rate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Rate.AutoSize = True
        Me.Rate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Rate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Rate.Location = New System.Drawing.Point(21, 180)
        Me.Rate.Name = "Rate"
        Me.Rate.Size = New System.Drawing.Size(74, 21)
        Me.Rate.TabIndex = 4
        Me.Rate.Text = "Trip Rate:"
        '
        'tbxRate
        '
        Me.tbxRate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxRate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxRate.Location = New System.Drawing.Point(168, 180)
        Me.tbxRate.Name = "tbxRate"
        Me.tbxRate.Size = New System.Drawing.Size(226, 20)
        Me.tbxRate.TabIndex = 9
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.Black
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSave.Location = New System.Drawing.Point(22, 291)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 37)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label14.Location = New System.Drawing.Point(21, 154)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 21)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Activity Type:"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(21, 127)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 21)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Container:"
        '
        'tbxContainerNumber
        '
        Me.tbxContainerNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxContainerNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxContainerNumber.Location = New System.Drawing.Point(168, 127)
        Me.tbxContainerNumber.Name = "tbxContainerNumber"
        Me.tbxContainerNumber.Size = New System.Drawing.Size(227, 20)
        Me.tbxContainerNumber.TabIndex = 7
        '
        'CmbActivityType
        '
        Me.CmbActivityType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbActivityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbActivityType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmbActivityType.FormattingEnabled = True
        Me.CmbActivityType.Items.AddRange(New Object() {"IMPORT", "EXPORT", "PULLOUT", "POSITION"})
        Me.CmbActivityType.Location = New System.Drawing.Point(168, 154)
        Me.CmbActivityType.Name = "CmbActivityType"
        Me.CmbActivityType.Size = New System.Drawing.Size(226, 21)
        Me.CmbActivityType.TabIndex = 8
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label19.Location = New System.Drawing.Point(21, 101)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(140, 21)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Waybill Number:"
        '
        'tbxwaybill
        '
        Me.tbxwaybill.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxwaybill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxwaybill.Location = New System.Drawing.Point(168, 101)
        Me.tbxwaybill.Name = "tbxwaybill"
        Me.tbxwaybill.Size = New System.Drawing.Size(227, 20)
        Me.tbxwaybill.TabIndex = 6
        '
        'btnupdatee
        '
        Me.btnupdatee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnupdatee.BackColor = System.Drawing.Color.SeaGreen
        Me.btnupdatee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnupdatee.ForeColor = System.Drawing.SystemColors.Control
        Me.btnupdatee.Location = New System.Drawing.Point(108, 291)
        Me.btnupdatee.Name = "btnupdatee"
        Me.btnupdatee.Size = New System.Drawing.Size(75, 37)
        Me.btnupdatee.TabIndex = 21
        Me.btnupdatee.Text = "UPDATE"
        Me.btnupdatee.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnUpdate.Controls.Add(Me.btnDelete)
        Me.btnUpdate.Controls.Add(Me.btnClear)
        Me.btnUpdate.Controls.Add(Me.Remarks)
        Me.btnUpdate.Controls.Add(Me.cmbremark)
        Me.btnUpdate.Controls.Add(Me.Label6)
        Me.btnUpdate.Controls.Add(Me.cmbRemarks)
        Me.btnUpdate.Controls.Add(Me.btnupdatee)
        Me.btnUpdate.Controls.Add(Me.tbxwaybill)
        Me.btnUpdate.Controls.Add(Me.Label19)
        Me.btnUpdate.Controls.Add(Me.CmbActivityType)
        Me.btnUpdate.Controls.Add(Me.tbxContainerNumber)
        Me.btnUpdate.Controls.Add(Me.Label15)
        Me.btnUpdate.Controls.Add(Me.Label14)
        Me.btnUpdate.Controls.Add(Me.btnSave)
        Me.btnUpdate.Controls.Add(Me.tbxRate)
        Me.btnUpdate.Controls.Add(Me.Rate)
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUpdate.Location = New System.Drawing.Point(648, 39)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(579, 339)
        Me.btnUpdate.TabIndex = 2
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Location = New System.Drawing.Point(189, 291)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 37)
        Me.btnDelete.TabIndex = 33
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.BackColor = System.Drawing.Color.DarkCyan
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.Control
        Me.btnClear.Location = New System.Drawing.Point(270, 291)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 37)
        Me.btnClear.TabIndex = 32
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Remarks
        '
        Me.Remarks.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Remarks.AutoSize = True
        Me.Remarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Remarks.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Remarks.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Remarks.Location = New System.Drawing.Point(21, 208)
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Size = New System.Drawing.Size(71, 21)
        Me.Remarks.TabIndex = 31
        Me.Remarks.Text = "Remarks"
        '
        'cmbremark
        '
        Me.cmbremark.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbremark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbremark.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbremark.FormattingEnabled = True
        Me.cmbremark.Items.AddRange(New Object() {"MONDAY TRIP", "TUESDAY TRIP", "WEDNESDAY TRIP", "THURSDAY TRIP", "FRIDAY TRIP", "SATURDAY TRIP", "SUNDAY TRIP"})
        Me.cmbremark.Location = New System.Drawing.Point(169, 205)
        Me.cmbremark.Name = "cmbremark"
        Me.cmbremark.Size = New System.Drawing.Size(226, 21)
        Me.cmbremark.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(21, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 21)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Remarks Changes:"
        '
        'cmbRemarks
        '
        Me.cmbRemarks.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbRemarks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbRemarks.Location = New System.Drawing.Point(168, 232)
        Me.cmbRemarks.Name = "cmbRemarks"
        Me.cmbRemarks.Size = New System.Drawing.Size(226, 20)
        Me.cmbRemarks.TabIndex = 26
        '
        'tbxTimesheetId
        '
        Me.tbxTimesheetId.Location = New System.Drawing.Point(452, 101)
        Me.tbxTimesheetId.Name = "tbxTimesheetId"
        Me.tbxTimesheetId.Size = New System.Drawing.Size(51, 20)
        Me.tbxTimesheetId.TabIndex = 14
        '
        'TripSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1239, 815)
        Me.Controls.Add(Me.TripSheetView)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TripSheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TripSheet"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureRest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TripSheetView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnUpdate.ResumeLayout(False)
        Me.btnUpdate.PerformLayout
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbxfromdestination As TextBox
    Friend WithEvents Panel As Panel
    Friend WithEvents LabelName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EmployeeID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureExit As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureMax As PictureBox
    Friend WithEvents PictureMin As PictureBox
    Friend WithEvents PictureRest As PictureBox
    Friend WithEvents tbxtodestination As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxconsignee As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbxdriverhelper As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TripDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FromLocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToLocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DriverHelperDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TractorPlateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OdometerNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChasisNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DIFNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrokerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FinalKMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TruckOriginDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContainerNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActivityTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BLNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SealNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemarksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WaybillNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TripSheetView As DataGridView
    Friend WithEvents tbxDate As DateTimePicker
    Friend WithEvents Rate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxRate As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents tbxContainerNumber As TextBox
    Friend WithEvents CmbActivityType As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tbxwaybill As TextBox
    Friend WithEvents btnupdatee As Button
    Friend WithEvents btnUpdate As Panel
    Friend WithEvents cmbRemarks As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Private WithEvents Label6 As Label
    Private WithEvents Remarks As Label
    Friend WithEvents cmbremark As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents tbxTimesheetId As TextBox
End Class
