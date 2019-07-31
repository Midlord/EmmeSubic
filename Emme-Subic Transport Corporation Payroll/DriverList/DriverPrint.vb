Imports System.Drawing.Printing
Public Class DriverPrint
    Private Sub DriverPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintPreviewControl.Document = PrintDocument
        PrintDocument.DefaultPageSettings.Landscape = True
    End Sub
    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim reportfont As Font = New Drawing.Font("Times New Roman", 10)
        e.Graphics.DrawString("Employee ID: " + DriverPayroll.lblEmpId.Text, reportfont, Brushes.BlueViolet, 10, 5)
        e.Graphics.DrawString("Employee NAME: " + DriverPayroll.lblEmpName.Text, reportfont, Brushes.BlueViolet, 10, 20)
        e.Graphics.DrawString("Pay Period From: " + DriverPayroll.dtpfrom.Value, reportfont, Brushes.BlueViolet, 330, 5)
        e.Graphics.DrawString(" To: " + DriverPayroll.dtpto.Value, reportfont, Brushes.BlueViolet, 407, 20)
        e.Graphics.DrawString("Issue Date: " + DateTime.Now, reportfont, Brushes.BlueViolet, 10, 35)
        e.PageSettings.Landscape = True
    End Sub
    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Print.Click
        PrintPreviewDialog.Document = PrintDocument
        For Each SupportedPaperSize As PaperSize In PrintDocument.PrinterSettings.PaperSizes
            If SupportedPaperSize.Kind = PaperKind.A5 Then
                PrintDocument.PrinterSettings.DefaultPageSettings.PaperSize = SupportedPaperSize
                Exit For
            End If
        Next
        PrintDialog.Document = PrintDocument
        PrintDialog.PrinterSettings.FromPage = 1
        PrintDialog.PrinterSettings.ToPage = 100
        If PrintDialog.ShowDialog = DialogResult.OK Then
            PrintDocument.Print()
        End If
    End Sub
    Private Sub PrintPreview_Click(sender As Object, e As EventArgs) Handles PrintPreview.Click
        PrintPreviewDialog.Document = PrintDocument
        PrintPreviewDialog.PrintPreviewControl.Zoom = 1.0
        PrintPreviewDialog.ShowDialog()
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
End Class
