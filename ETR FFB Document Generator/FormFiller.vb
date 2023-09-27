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

    Public Sub FillBallot()

        Dim pdfTemplate As String = Application.StartupPath & "\PDF\FFB_Ballot_New.pdf"
        Dim newFile As String = Application.StartupPath & "\PDF\Saved\" & Form1.cmbStudentName.Text & "_FFB_Ballot.pdf"

        Dim pdfReader As New PdfReader(pdfTemplate)
        Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(
            newFile, FileMode.Create))

        Dim pdfFormFields As AcroFields = pdfStamper.AcroFields


        ' Set form fields
        ' Level 1 Notification Form
        pdfFormFields.SetField("STUDENT_NAME", Form1.cmbStudentName.Text)
        pdfFormFields.SetField("STUDENT_ID", Form1.txtStudentID.Text)
        pdfFormFields.SetField("INFRACTION_2", Form1.cmbInfraction.SelectedItem.ToString.ToUpper)
        pdfFormFields.SetField("BDATE", Form1.dtpFFBDate.Text)



        ' report by reading values from completed PDF
        Dim sTmp4 As String = "Ballot " +
        pdfFormFields.GetField("STUDENT_NAME") + " " +
        pdfFormFields.GetField("STUDENT_ID")
        'MessageBox.Show(sTmp, "Finished")

        ' flatten the form to remove editting options, set it to false
        ' to leave the form open to subsequent manual edits
        pdfStamper.FormFlattening = True

        ' close the pdf
        pdfStamper.Close()
        Dim pdfDest As String = Path.Combine(Application.StartupPath, $"PDF\Saved\" & Form1.cmbStudentName.Text & "_FFB_Ballot.pdf")
        Process.Start(New ProcessStartInfo(pdfDest) With {.UseShellExecute = True})
    End Sub

    Public Sub FillSummary1()

        Dim pdfTemplate As String = Application.StartupPath & "\PDF\FFB_Summary1.pdf"
        Dim newFile As String = Application.StartupPath & "\PDF\Saved\" & Form1.cmbStudentName.Text & "_Summary_Level_1.pdf"

        Dim pdfReader As New PdfReader(pdfTemplate)
        Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(
            newFile, FileMode.Create))

        Dim pdfFormFields As AcroFields = pdfStamper.AcroFields


        ' Set form fields
        ' Level 1 Notification Form
        pdfFormFields.SetField("STUDENT_NAME", Form1.cmbStudentName.Text)
        pdfFormFields.SetField("STUDENT_ID", Form1.txtStudentID.Text)
        pdfFormFields.SetField("CDATE", Form1.dtpNotification.Text.ToString())
        pdfFormFields.SetField("BDATE", Form1.dtpFFBDate.Text.ToString())
        pdfFormFields.SetField("INFRACTION_2", Form1.cmbInfraction.SelectedItem.ToString.ToUpper)
        pdfFormFields.SetField("CODE", Form1.txtPRHCode.Text)
        pdfFormFields.SetField("DOI_1", Form1.dtpDOI.Value.ToString())
        pdfFormFields.SetField("DESC1", Form1.txtDetails.Text)
        pdfFormFields.SetField("DOB_1", Form1.dtpDOB2.Value.ToString("MM/dd/yyyy"))
        pdfFormFields.SetField("DOE_1", Form1.dtpDOE2.Value.ToString("MM/dd/yyyy"))
        pdfFormFields.SetField("CENTER", My.Settings.CenterName)


        ' report by reading values from completed PDF
        Dim sTmp2 As String = "FFB Summary " +
        pdfFormFields.GetField("STUDENT_NAME") + " " +
        pdfFormFields.GetField("STUDENT_ID")


        ' flatten the form to remove editting options, set it to false
        ' to leave the form open to subsequent manual edits
        pdfStamper.FormFlattening = True

        ' close the pdf
        pdfStamper.Close()
        Dim pdfDest As String = Path.Combine(Application.StartupPath, $"PDF\Saved\" & Form1.cmbStudentName.Text & "_Summary_Level_1.pdf")
        Process.Start(New ProcessStartInfo(pdfDest) With {.UseShellExecute = True})
    End Sub

    Public Sub FillSummary2()

        Dim pdfTemplate As String = Application.StartupPath & "\PDF\FFB_Summary2.pdf"
        Dim newFile As String = Application.StartupPath & "\PDF\Saved\" & Form1.cmbStudentName.Text & "_Summary_Level_2.pdf"

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
        pdfFormFields.SetField("CODE", Form1.txtPRHCode.Text)
        pdfFormFields.SetField("DOI", Form1.dtpDOI.Text)
        pdfFormFields.SetField("DESC1", Form1.txtDetails.Text)
        pdfFormFields.SetField("DOB", Form1.dtpDOB.Text)
        pdfFormFields.SetField("DOE", Form1.dtpDOE.Text)
        pdfFormFields.SetField("CENTER", My.Settings.CenterName)


        ' report by reading values from completed PDF
        Dim sTmp2 As String = "FFB Summary " +
        pdfFormFields.GetField("STUDENT_NAME") + " " +
        pdfFormFields.GetField("STUDENT_ID")


        ' flatten the form to remove editting options, set it to false
        ' to leave the form open to subsequent manual edits
        pdfStamper.FormFlattening = True

        ' close the pdf
        pdfStamper.Close()
        Dim pdfDest As String = Path.Combine(Application.StartupPath, $"PDF\Saved\" & Form1.cmbStudentName.Text & "_Summary_Level_2.pdf")
        Process.Start(New ProcessStartInfo(pdfDest) With {.UseShellExecute = True})
    End Sub

    Public Sub FillTermLetter1()

        Dim pdfTemplate As String = Application.StartupPath & "\PDF\TERM_LETTER.pdf"
        Dim newFile As String = Application.StartupPath & "\PDF\Saved\" & Form1.cmbStudentName.Text & "_TERM_LETTER.pdf"

        Dim pdfReader As New PdfReader(pdfTemplate)
        Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(
            newFile, FileMode.Create))

        Dim pdfFormFields As AcroFields = pdfStamper.AcroFields
        Dim name As String = Form1.cmbStudentName.Text

        Dim Search As String() = Form1.cmbStudentName.Text.Split(" ")
        Dim last As String = Search(1)
        Dim first As String = Search(0)
        first = StrConv(first, vbProperCase)

        Dim firstName As String = first
        Dim infraction As String = Form1.cmbInfraction.SelectedItem.ToString.ToUpper
        ' Set form fields

        pdfFormFields.SetField("FNAME", firstName.ToString & ",")
        pdfFormFields.SetField("STUDENT_NAME", Form1.cmbStudentName.Text)
        pdfFormFields.SetField("STUDENT_ID", Form1.txtStudentID.Text)
        pdfFormFields.SetField("INFRACTION_2", infraction)
        pdfFormFields.SetField("BDATE", Form1.dtpFFBDate.Text)
        pdfFormFields.SetField("CODE", Form1.txtPRHCode.Text)
        pdfFormFields.SetField("EXT", My.Settings.PhoneNumber)

        ' report by reading values from completed PDF
        Dim sTmp5 As String = "Ballot " +
        pdfFormFields.GetField("STUDENT_NAME") + " " +
        pdfFormFields.GetField("STUDENT_ID")
        'MessageBox.Show(sTmp, "Finished")

        ' flatten the form to remove editting options, set it to false
        ' to leave the form open to subsequent manual edits
        pdfStamper.FormFlattening = True

        ' close the pdf
        pdfStamper.Close()
        Dim pdfDest As String = Path.Combine(Application.StartupPath, $"PDF\Saved\" & Form1.cmbStudentName.Text & "_TERM_LETTER.pdf")
        Process.Start(New ProcessStartInfo(pdfDest) With {.UseShellExecute = True})

    End Sub


    Public Sub RunLevel1()
        FillSummary1()
        FillNoticeLevel1()
        FillBallot()
        FillTermLetter1()
    End Sub

    Public Sub RunLevel2()
        FillSummary2()
        FillNoticeLevel2()
        FillBallot()
        FillTermLetter1()
    End Sub

    Public Function checkSettings() As Boolean
        If String.IsNullOrEmpty(My.Settings.CenterName) OrElse String.IsNullOrEmpty(My.Settings.PhoneNumber) Then
            Return True
        Else Return False
        End If
    End Function

    Public Sub runSettings()
        If checkSettings() Then
            Dim settingsForm As New Settings()
            settingsForm.ShowDialog()
        Else
            Exit Sub
        End If
    End Sub
End Module
