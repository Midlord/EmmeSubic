<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminHistory))
        Me.UsertableLog = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureExit = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureMax = New System.Windows.Forms.PictureBox()
        Me.PictureMin = New System.Windows.Forms.PictureBox()
        Me.PictureRest = New System.Windows.Forms.PictureBox()
        Me.Back = New System.Windows.Forms.Button()
        Me.SuperAdminTable = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBack = New System.Windows.Forms.PictureBox()
        CType(Me.UsertableLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureRest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperAdminTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsertableLog
        '
        Me.UsertableLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsertableLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UsertableLog.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.UsertableLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsertableLog.Location = New System.Drawing.Point(24, 125)
        Me.UsertableLog.Name = "UsertableLog"
        Me.UsertableLog.Size = New System.Drawing.Size(1152, 479)
        Me.UsertableLog.TabIndex = 0
        Me.UsertableLog.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureExit)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.PictureMax)
        Me.Panel1.Controls.Add(Me.PictureMin)
        Me.Panel1.Controls.Add(Me.PictureRest)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 33)
        Me.Panel1.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(35, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(322, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Emme-Subic Transport Corporation Admin LOG"
        '
        'PictureExit
        '
        Me.PictureExit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureExit.BackgroundImage = Global.Emme_Subic_Transport_Corporation_Payroll.My.Resources.Resources._21
        Me.PictureExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureExit.Location = New System.Drawing.Point(1172, 3)
        Me.PictureExit.Name = "PictureExit"
        Me.PictureExit.Size = New System.Drawing.Size(25, 25)
        Me.PictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureExit.TabIndex = 13
        Me.PictureExit.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.Emme_Subic_Transport_Corporation_Payroll.My.Resources.Resources.Icon_PNG
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'PictureMax
        '
        Me.PictureMax.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureMax.BackgroundImage = Global.Emme_Subic_Transport_Corporation_Payroll.My.Resources.Resources._20
        Me.PictureMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureMax.Location = New System.Drawing.Point(1141, 4)
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
        Me.PictureMin.Location = New System.Drawing.Point(1110, 4)
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
        Me.PictureRest.Location = New System.Drawing.Point(1141, 3)
        Me.PictureRest.Name = "PictureRest"
        Me.PictureRest.Size = New System.Drawing.Size(25, 25)
        Me.PictureRest.TabIndex = 13
        Me.PictureRest.TabStop = False
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Back.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Back.ForeColor = System.Drawing.Color.Black
        Me.Back.Location = New System.Drawing.Point(24, 65)
        Me.Back.Margin = New System.Windows.Forms.Padding(4)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(78, 36)
        Me.Back.TabIndex = 1
        Me.Back.Text = "Back"
        Me.Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Back.UseVisualStyleBackColor = False
        '
        'SuperAdminTable
        '
        Me.SuperAdminTable.AllowUserToAddRows = False
        Me.SuperAdminTable.AllowUserToDeleteRows = False
        Me.SuperAdminTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SuperAdminTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SuperAdminTable.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.SuperAdminTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SuperAdminTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SuperAdminTable.Location = New System.Drawing.Point(24, 125)
        Me.SuperAdminTable.Name = "SuperAdminTable"
        Me.SuperAdminTable.ReadOnly = True
        Me.SuperAdminTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.SuperAdminTable.Size = New System.Drawing.Size(1152, 479)
        Me.SuperAdminTable.TabIndex = 2
        Me.SuperAdminTable.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(109, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1067, 53)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "ADMIN LOGIN HISTORY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.FlowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 44)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1176, 572)
        Me.FlowLayoutPanel1.TabIndex = 71
        '
        'PictureBack
        '
        Me.PictureBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PictureBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBack.Image = Global.Emme_Subic_Transport_Corporation_Payroll.My.Resources.Resources._18
        Me.PictureBack.Location = New System.Drawing.Point(29, 72)
        Me.PictureBack.Name = "PictureBack"
        Me.PictureBack.Size = New System.Drawing.Size(22, 24)
        Me.PictureBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBack.TabIndex = 67
        Me.PictureBack.TabStop = False
        '
        'AdminHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 623)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SuperAdminTable)
        Me.Controls.Add(Me.PictureBack)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UsertableLog)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminHistory"
        CType(Me.UsertableLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureRest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperAdminTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UsertableLog As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureExit As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureMax As PictureBox
    Friend WithEvents PictureMin As PictureBox
    Friend WithEvents PictureRest As PictureBox
    Friend WithEvents PictureBack As PictureBox
    Friend WithEvents Back As Button
    Friend WithEvents SuperAdminTable As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel

End Class
