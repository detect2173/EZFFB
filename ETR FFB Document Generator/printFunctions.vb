Imports Microsoft.Reporting.WebForms
Imports Microsoft.Reporting.WinForms
Imports System.IO

Module printFunctions


    Public Sub GenerateRDLCPDF()

        ' Set up the ReportViewer
        Dim reportViewer As New ReportViewer()
        reportViewer.ProcessingMode = ProcessingMode.Local
        reportViewer.LocalReport.ReportPath = "path_to_your_report_file.rdlc"

        ' Prepare the data source
        Dim studentRoster As New DataTable()
        ' ...fill the table with data from MySQL

        ' Bind the data source to the report
        Dim rds As New ReportDataSource("StudentRosterDataSet", studentRoster)
        reportViewer.LocalReport.DataSources.Clear()
        reportViewer.LocalReport.DataSources.Add(rds)
        reportViewer.RefreshReport()

        ' Code to export the report as a PDF
        Dim warnings As Warning()
        Dim streamids As String()
        Dim mimeType As String = ""
        Dim encoding As String = ""
        Dim extension As String = "pdf"
        Dim bytes As Byte() = reportViewer.LocalReport.Render("PDF", Nothing, mimeType, encoding, extension, streamids, warnings)
        ' Write bytes to a file
        Dim fs As New FileStream("ExportedReport.pdf", FileMode.Create)
        fs.Write(bytes, 0, bytes.Length)
        fs.Close()

    End Sub


End Module
