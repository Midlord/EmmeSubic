<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisteredAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisteredAdmin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureExit = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureMax = New System.Windows.Forms.PictureBox()
        Me.PictureMin = New System.Windows.Forms.PictureBox()
        Me.PictureRest = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RemoveUser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UsersTable = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureRest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureExit)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureMax)
        Me.Panel1.Controls.Add(Me.PictureMin)
        Me.Panel1.Controls.Add(Me.PictureRest)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 33)
        Me.Panel1.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(35, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(366, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Emme-Subic Transport Corporation Registered Admin"
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
        Me.PictureMax.Location = New System.Drawing.Point(1141, 3)
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
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel3.Controls.Add(Me.RemoveUser)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.UsersTable)
        Me.Panel3.Location = New System.Drawing.Point(12, 39)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1177, 572)
        Me.Panel3.TabIndex = 18
        '
        'RemoveUser
        '
        Me.RemoveUser.BackColor = System.Drawing.SystemColors.HotTrack
        Me.RemoveUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RemoveUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.RemoveUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RemoveUser.Location = New System.Drawing.Point(1076, 11)
        Me.RemoveUser.Name = "RemoveUser"
        Me.RemoveUser.Size = New System.Drawing.Size(88, 53)
        Me.RemoveUser.TabIndex = 71
        Me.RemoveUser.Text = "Remove User"
        Me.RemoveUser.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(97, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1059, 53)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "CURRENTLY REGISTERED ADMIN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PictureBox1.BackgroundImage = Global.Emme_Subic_Transport_Corporation_Payroll.My.Resources.Resources._18
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(18, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 24)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(12, 22)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 36)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Back"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'UsersTable
        '
        Me.UsersTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersTable.Location = New System.Drawing.Point(12, 77)
        Me.UsersTable.Name = "UsersTable"
        Me.UsersTable.Size = New System.Drawing.Size(1152, 483)
        Me.UsersTable.TabIndex = 0
        '
        'RegisteredAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 623)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegisteredAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureRest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureExit As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureMax As PictureBox
    Friend WithEvents PictureMin As PictureBox
    Friend WithEvents PictureRest As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RemoveUser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents UsersTable As DataGridView
End Class
