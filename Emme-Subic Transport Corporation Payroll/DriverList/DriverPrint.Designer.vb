<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DriverPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DriverPrint))
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewControl = New System.Windows.Forms.PrintPreviewControl()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintPreview = New System.Windows.Forms.Button()
        Me.Print = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureExit = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureMax = New System.Windows.Forms.PictureBox()
        Me.PictureMin = New System.Windows.Forms.PictureBox()
        Me.PictureRest = New System.Windows.Forms.PictureBox()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureRest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDialog
        '
        Me.PrintDialog.Document = Me.PrintDocument
        Me.PrintDialog.UseEXDialog = True
        '
        'PrintDocument
        '
        '
        'PrintPreviewControl
        '
        Me.PrintPreviewControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintPreviewControl.AutoZoom = False
        Me.PrintPreviewControl.Document = Me.PrintDocument
        Me.PrintPreviewControl.Location = New System.Drawing.Point(12, 52)
        Me.PrintPreviewControl.Name = "PrintPreviewControl"
        Me.PrintPreviewControl.Size = New System.Drawing.Size(1155, 587)
        Me.PrintPreviewControl.TabIndex = 0
        Me.PrintPreviewControl.Zoom = 1.182R
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'PrintPreview
        '
        Me.PrintPreview.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PrintPreview.Location = New System.Drawing.Point(443, 653)
        Me.PrintPreview.Name = "PrintPreview"
        Me.PrintPreview.Size = New System.Drawing.Size(93, 23)
        Me.PrintPreview.TabIndex = 1
        Me.PrintPreview.Text = " Print Preview"
        Me.PrintPreview.UseVisualStyleBackColor = True
        '
        'Print
        '
        Me.Print.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Print.Location = New System.Drawing.Point(617, 653)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(85, 23)
        Me.Print.TabIndex = 3
        Me.Print.Text = "Print"
        Me.Print.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.PictureExit)
        Me.Panel8.Controls.Add(Me.PictureBox3)
        Me.Panel8.Controls.Add(Me.PictureMax)
        Me.Panel8.Controls.Add(Me.PictureMin)
        Me.Panel8.Controls.Add(Me.PictureRest)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1179, 33)
        Me.Panel8.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(35, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(379, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Emme-Subic Transport Corporation Add New Employee"
        '
        'PictureExit
        '
        Me.PictureExit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureExit.BackgroundImage = Global.Emme_Subic_Transport_Corporation_Payroll.My.Resources.Resources._21
        Me.PictureExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureExit.Location = New System.Drawing.Point(1151, 3)
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
        Me.PictureMax.Location = New System.Drawing.Point(1120, 3)
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
        Me.PictureMin.Location = New System.Drawing.Point(1089, 4)
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
        Me.PictureRest.Location = New System.Drawing.Point(1120, 3)
        Me.PictureRest.Name = "PictureRest"
        Me.PictureRest.Size = New System.Drawing.Size(25, 25)
        Me.PictureRest.TabIndex = 13
        Me.PictureRest.TabStop = False
        '
        'DriverPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 702)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Print)
        Me.Controls.Add(Me.PrintPreview)
        Me.Controls.Add(Me.PrintPreviewControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DriverPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DriverPrint"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureRest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintDialog As PrintDialog
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents PrintPreviewControl As PrintPreviewControl
    Friend WithEvents PrintPreviewDialog As PrintPreviewDialog
    Friend WithEvents PrintPreview As Button
    Friend WithEvents Print As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureExit As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureMax As PictureBox
    Friend WithEvents PictureMin As PictureBox
    Friend WithEvents PictureRest As PictureBox
End Class
