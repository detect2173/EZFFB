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
                html.Append("<html><head></head><body style='font-family: Arial, sans-serif; margin: 20px;'>")
                html.Append("<h2 style='text-align: center;'>Student Roster</h2>")
                html.Append("<table style='width: 100%; border-collapse: collapse; margin: 20px 0;'>")
                html.Append("<tr style='border: 1px solid #ddd;'><th style='border: 1px solid #ddd; text-align: left; padding: 8px;'>#</th><th style='border: 1px solid #ddd; text-align: left; padding: 8px;'>StudentID</th><th style='border: 1px solid #ddd; text-align: left; padding: 8px;'>Full Name</th></tr>")

                While reader.Read()
                    Dim rowStyle As String = If(counter Mod 2 = 0, " style='background-color: #f2f2f2; border: 1px solid #ddd;'", " style='border: 1px solid #ddd;'")
                    html.AppendFormat("<tr{0}>", rowStyle)
                    html.AppendFormat("<td style='border: 1px solid #ddd; text-align: left; padding: 8px;'>{0}</td>", counter) ' Numbering column
                    html.AppendFormat("<td style='border: 1px solid #ddd; text-align: left; padding: 8px;'>{0}</td>", reader("StudentID"))
                    html.AppendFormat("<td style='border: 1px solid #ddd; text-align: left; padding: 8px;'>{0} {1}</td>", reader("Firstname"), reader("Lastname"))
                    html.Append("</tr>")
                    counter += 1 ' Increment counter
                End While

                html.Append("</table>")
                html.Append("</body></html>")
            End Using
        End Using

        Return html.ToString()
    End Function



    Sub GeneratePDF()
        Try
            Dim currentDate As String = DateTime.Now.ToString("MMMddyy_HHmmss")
            Dim pdfDest As String = $"c:/roster/Students_{currentDate}.pdf"

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

            ' Show success message
            MessageBox.Show("PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Open the PDF file with the default associated application
            Process.Start(New ProcessStartInfo(pdfDest) With {.UseShellExecute = True})

        Catch ex As Exception
            ' Show error message
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



End Module
