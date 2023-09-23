Imports System.IO
Imports System.Text
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.html.simpleparser
Imports MySql.Data.MySqlClient



Module printFunctions

    Function GenerateHTML() As String
        Dim html As New StringBuilder()
        Dim connectionString As String = $"Server=localhost;Database=roster;User ID=root;Password=;"
        Dim query As String = "SELECT * FROM roster"
        Dim counter As Integer = 1 ' Counter for numbering students

        Using conn As New MySqlConnection(connectionString)
            Dim cmd As New MySqlCommand(query, conn)
            conn.Open()

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                html.Append("<html><head><style>")
                html.Append("body { font-family: Arial, sans-serif; margin: 20px; }")
                html.Append("h2 { text-align: center; }")
                html.Append("table { width: 100%; border-collapse: collapse; margin: 20px 0; }")
                html.Append("th, td { border: 1px solid #ddd; text-align: left; padding: 8px; }")
                html.Append("tr:nth-child(even) { background-color: #f2f2f2; }")
                html.Append("@media print {")
                html.Append("  body { width: 8.5in; margin: 0.5in 0.5in; }")
                html.Append("  table { width: 100%; }")
                html.Append("  th, td { width: auto; overflow: hidden; white-space: nowrap; }")
                html.Append("}")
                html.Append("</style></head><body>")
                html.Append("</style></head><body>")
                html.Append("<h2>Student Roster</h2>")
                html.Append("<table>")
                html.Append("<tr><th>#</th><th>StudentID</th><th>Full Name</th></tr>") ' Added '#' column

                While reader.Read()
                    html.Append("<tr>")
                    html.AppendFormat("<td>{0}</td>", counter) ' Numbering column
                    html.AppendFormat("<td>{0}</td>", reader("StudentID"))
                    html.AppendFormat("<td>{0} {1}</td>", reader("Firstname"), reader("Lastname"))
                    html.Append("</tr>")
                    counter += 1 ' Increment counter
                End While

                html.Append("</table>")
                html.Append("</body></html>")
            End Using
        End Using

        Return html.ToString()
    End Function


    Function GeneratePDF()
        Dim pdfDest As String = "c:/roster/Students.pdf"
        Dim htmlString As String = GenerateHTML()
        System.IO.Directory.CreateDirectory("c:\roster")

        Dim document As New Document()
        PdfWriter.GetInstance(document, New FileStream(pdfDest, FileMode.Create))
        document.Open()

        Dim styles As New StyleSheet()
        Dim hw As New HTMLWorker(document)
        hw.SetStyleSheet(styles)
        hw.Parse(New StringReader(htmlString))

        document.Close()
    End Function

End Module
