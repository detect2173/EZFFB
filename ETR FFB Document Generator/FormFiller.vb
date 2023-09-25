' This file is used by Code Analysis to maintain SuppressMessage
' attributes that are applied to this project.
' Project-level suppressions either have no target or are given
' a specific target and scoped to a namespace, type, member, etc.

Imports iTextSharp.text.pdf
Imports System.IO

Module FormFiller

    Public Sub FillNoticeLevel1()
        Dim pdfTemplate As String = Application.StartupPath & "\PDF\Notice_L1.pdf"
        Dim newFile As String = Application.StartupPath & "\PDF\Saved\" & Form1.cmbStudentName.Text & "_Notice_L1.pdf"

        Dim pdfReader As New PdfReader(pdfTemplate)
        Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(
            newFile, FileMode.Create))

        Dim pdfFormFields As AcroFields = pdfStamper.AcroFields


        ' Set form fields
        ' Level 1 Notification Form
        pdfFormFields.SetField("STUDENT_NAME", Form1.cmbStudentName.Text)
        pdfFormFields.SetField("STUDENT_ID", Form1.txtStudentID.Text)
        pdfFormFields.SetField("CDATE", Form1.dtpNotification.Text)
        pdfFormFields.SetField("BDATE", Form1.dtpFFBDate.Text)
        pdfFormFields.SetField("INFRACTION_1", Form1.cmbInfraction.SelectedItem.ToString.ToUpper)
        pdfFormFields.SetField("LOCATION1", Form1.txtLocation.Text)



        ' report by reading values from completed PDF
        Dim sTmp1 As String = "Notice of Hearing " +
        pdfFormFields.GetField("STUDENT_NAME") + " " +
        pdfFormFields.GetField("STUDENT_ID")


        ' flatten the form to remove editting options, set it to false
        ' to leave the form open to subsequent manual edits
        pdfStamper.FormFlattening = True

        ' close the pdf
        pdfStamper.Close()
        Dim pdfDest As String = Path.Combine(Application.StartupPath, $"PDF\Saved\" & Form1.cmbStudentName.Text & "_Notice_L1.pdf")
        Process.Start(New ProcessStartInfo(pdfDest) With {.UseShellExecute = True})

    End Sub

    Public Sub FillNoticeLevel2()
        Dim pdfTemplate As String = Application.StartupPath & "\PDF\Notice_L2.pdf"
        Dim newFile As String = Application.StartupPath & "\PDF\Saved\" & Form1.cmbStudentName.Text & "_Notice_L2.pdf"

        Dim pdfReader As New PdfReader(pdfTemplate)
        Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(
            newFile, FileMode.Create))

        Dim pdfFormFields As AcroFields = pdfStamper.AcroFields


        ' Set form fields
        ' Level 1 Notification Form
        pdfFormFields.SetField("STUDENT_NAME", Form1.cmbStudentName.Text)
        pdfFormFields.SetField("STUDENT_ID", Form1.txtStudentID.Text)
        pdfFormFields.SetField("CDATE", Form1.dtpNotification.Text)
        pdfFormFields.SetField("BDATE", Form1.dtpFFBDate.Text)
        pdfFormFields.SetField("INFRACTION_2", Form1.cmbInfraction.SelectedItem.ToString.ToUpper)
        pdfFormFields.SetField("LOCATION1", Form1.txtLocation.Text)



        ' report by reading values from completed PDF
        Dim sTmp1 As String = "Notice of Hearing " +
        pdfFormFields.GetField("STUDENT_NAME") + " " +
        pdfFormFields.GetField("STUDENT_ID")


        ' flatten the form to remove editting options, set it to false
        ' to leave the form open to subsequent manual edits
        pdfStamper.FormFlattening = True

        ' close the pdf
        pdfStamper.Close()
        Dim pdfDest As String = Path.Combine(Application.StartupPath, $"PDF\Saved\" & Form1.cmbStudentName.Text & "_Notice_L2.pdf")
        Process.Start(New ProcessStartInfo(pdfDest) With {.UseShellExecute = True})

    End Sub




End Module
