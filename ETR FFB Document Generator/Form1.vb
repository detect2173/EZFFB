
Imports System.Data
Imports System.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.IO
Imports Guna.UI2.WinForms

Public Class Form1
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        level1Infractions = GetLevel1Infractions()
        level2Infractions = GetLevel2Infractions()
        AddHandler MyBase.Load, AddressOf Form1_Load
        AddHandler Me.Guna2Button8.Click, AddressOf Guna2Button8_Click
        AddHandler Me.btnUpdateDB.Click, AddressOf btnUpdateDB_Click
        AddHandler txtFName.TextChanged, AddressOf TextBox_TextChanged
        AddHandler txtLName.TextChanged, AddressOf TextBox_TextChanged
        AddHandler btnReset.Click, AddressOf btnReset_Click
        AddHandler txtSearch.KeyUp, AddressOf txtSearch_KeyUp
        AddHandler cmbSearch.SelectedIndexChanged, AddressOf cmbSearch_SelectedIndexChanged
        AddHandler dgvRoster.CellClick, AddressOf dgvRoster_CellClick
        AddHandler btnReload.Click, AddressOf btnReload_Click
        AddHandler btnAdd.Click, AddressOf btnAdd_Click
        AddHandler btnUpdate.Click, AddressOf btnUpdate_Click
        AddHandler btnDelete.Click, AddressOf btnDelete_Click
        AddHandler btnFill.Click, AddressOf btnFill_Click
        AddHandler cbLevel.CheckedChanged, AddressOf cbLevel_CheckedChanged
        AddHandler cmbInfraction.SelectedIndexChanged, AddressOf cmbInfraction_SelectedIndexChanged
        AddHandler dtpFFBDate.ValueChanged, AddressOf dtpFFBDate_ValueChanged
        AddHandler cmbStudentName.SelectedIndexChanged, AddressOf cmbStudentName_SelectedIndexChanged
        AddHandler btnResetForm.Click, AddressOf btnResetForm_Click
        AddHandler btnCreateDocs.Click, AddressOf btnCreateDocs_Click
        AddHandler btnOpenDirectory.Click, AddressOf btnOpenDirectory_Click
        AddHandler btnSettings.Click, AddressOf btnSettings_Click
        AddHandler btnStatement.Click, AddressOf btnStatement_Click
        AddHandler btnPrint.Click, AddressOf btnPrint_Click
        AddHandler Guna2HtmlLabel11.Click, AddressOf Guna2HtmlLabel11_Click
    End Sub

    Private level1Infractions As Dictionary(Of String, String)
    Private level2Infractions As Dictionary(Of String, String)
    Private ReadOnly toolTip1 As New ToolTip()
    Private studentInfo As Dictionary(Of String, (Integer, DateTime, DateTime)) = GetStudentInfo()



    Private Sub Form1_Load(sender As Object, e As EventArgs)
        runSettings()
        toolTip1.SetToolTip(cbLevel, "Check the Box to Populate Level 2 infractions, and uncheck the box to populate Level 1 infractions.")
        CopyLogToDocuments()
        SetupLogic.SetupUI()
        ' Populate and set up DataGrid
        DBConnection.PopulateAndRefreshRoster(dgvRoster)
        dgvRoster.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkGray
        ' LOAD Infractions into the dropdown in the FFB UI
        cmbInfraction.Items.Clear()
        For Each kvp As KeyValuePair(Of String, String) In level1Infractions
            cmbInfraction.Items.Add(kvp.Key)
        Next
        btnCreateDocs.BorderRadius = 27
        btnResetForm.BorderRadius = 15
        btnOpenDirectory.BorderRadius = 15
        btnStatement.BorderRadius = 15

        'Load student names into cmbStdentName
        cmbStudentName.Items.Clear()
        Dim sortedNames As List(Of String) = studentInfo.Keys.ToList()
        sortedNames.Sort()
        For Each name As String In sortedNames
            cmbStudentName.Items.Add(name)
        Next
        If cmbStudentName.Items.Count > 0 Then
            cmbStudentName.SelectedIndex = -1  ' Select the first item
        End If

        dtpFFBDate.Value = AddNBusinessDays(Date.Today, 3)
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs)
        Dim logFilePath As String = System.IO.Path.Combine(Application.StartupPath, "roster_updater.log")

        If System.IO.File.Exists(logFilePath) Then
            System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo() With {.FileName = logFilePath, .UseShellExecute = True})
        Else
            Using fs = System.IO.File.Create(logFilePath)
                ' Optionally write some initial text into the file
            End Using
            System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo() With {.FileName = logFilePath, .UseShellExecute = True})
        End If

    End Sub

    Public Sub CopyLogToDocuments()
        Dim sourcePath As String = Path.Combine(Application.StartupPath, "roster_updater.log")
        Dim destPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "roster_updater.log")

        If File.Exists(sourcePath) Then
            File.Copy(sourcePath, destPath, True)
        End If
    End Sub

    Private Sub btnUpdateDB_Click(sender As Object, e As EventArgs)
        Dim startupPath As String = Application.StartupPath
        Dim exePath As String = Path.Combine(startupPath, "roster_updater.exe")

        If File.Exists(exePath) Then
            Process.Start(exePath)
        Else
            MessageBox.Show("roster_updater.exe not found.")
        End If
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs)
        DBConnection.PopulateAndRefreshRoster(dgvRoster)
    End Sub

    Private Sub dgvRoster_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        ' Check if there are no selected rows or if the clicked cell is a header or an empty row
        If dgvRoster.SelectedRows.Count = 0 OrElse e.RowIndex < 0 OrElse e.RowIndex >= dgvRoster.Rows.Count - 1 Then
            Return
        End If

        Try
            txtID.Text = dgvRoster.SelectedRows(0).Cells(0).Value.ToString()
            txtFName.Text = dgvRoster.SelectedRows(0).Cells(1).Value.ToString()
            txtLName.Text = dgvRoster.SelectedRows(0).Cells(2).Value.ToString()
            dtpDOB.Value = Convert.ToDateTime(dgvRoster.SelectedRows(0).Cells(3).Value)
            dtpDOE.Value = Convert.ToDateTime(dgvRoster.SelectedRows(0).Cells(4).Value)
            txtEMail.Text = dgvRoster.SelectedRows(0).Cells(5).Value.ToString()
            cmbSize.Text = dgvRoster.SelectedRows(0).Cells(7).Value.ToString()
            cmbTrade.Text = dgvRoster.SelectedRows(0).Cells(6).Value.ToString()
            cmbIncentive.Text = dgvRoster.SelectedRows(0).Cells(8).Value.ToString()
            txtID.ReadOnly = True
            txtID.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ResetControls()
        txtID.Text = String.Empty
        txtFName.Text = String.Empty
        txtLName.Text = String.Empty
        dtpDOB.Value = DateTime.Now
        dtpDOE.Value = DateTime.Now
        txtEMail.Text = String.Empty
        cmbSearch.SelectedIndex = -1
        txtSearch.Text = String.Empty

        cmbTrade.SelectedIndex = -1
        cmbSize.SelectedIndex = -1
        cmbIncentive.SelectedIndex = -1

        txtID.ReadOnly = False
        txtID.Enabled = True
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs)
        ResetControls()
    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' Replace with your function to load the data into dgvRoster
        DBConnection.PopulateAndRefreshRoster(dgvRoster)

        Try
            Dim rosterDataTable As DataTable = CType(dgvRoster.DataSource, DataTable)

            Dim comparisonDate As DateTime = DateTime.Today.AddYears(-18)

            Dim filteredRows As EnumerableRowCollection(Of DataRow)

            If cmbSearch.SelectedItem Is "Adults" Then
                filteredRows = rosterDataTable.AsEnumerable().Where(Function(row)
                                                                        Dim dob As DateTime
                                                                        DateTime.TryParse(row("DOB").ToString(), dob)
                                                                        Return dob <= comparisonDate
                                                                    End Function)

            ElseIf cmbSearch.SelectedItem Is "Minors" Then

                filteredRows = rosterDataTable.AsEnumerable().Where(Function(row)
                                                                        Dim dob As DateTime
                                                                        DateTime.TryParse(row("DOB").ToString(), dob)
                                                                        Return dob > comparisonDate
                                                                    End Function)
            Else
                filteredRows = rosterDataTable.AsEnumerable()
            End If

            Dim filteredDataTable As DataTable = filteredRows.CopyToDataTable()

            dgvRoster.DataSource = filteredDataTable
            ' Replace with your function to update the row count label, if applicable

            txtCount.Text = CStr(dgvRoster.Rows.Count)
            ' Implicit conversion

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ' Replace with your function to load the data into dgvRoster

            DBConnection.PopulateAndRefreshRoster(dgvRoster)


            Try
                Dim rosterDataTable As DataTable = CType(dgvRoster.DataSource, DataTable)
                Dim searchText As String = txtSearch.Text.ToLower()

                Dim filteredRows = rosterDataTable.AsEnumerable().Where(Function(row)
                                                                            Dim id = row("StudentID").ToString().ToLower()
                                                                            Dim fName = row("FirstName").ToString().ToLower()
                                                                            Dim lName = row("Lastname").ToString().ToLower()
                                                                            ' ... add more columns as needed
                                                                            Return id.Contains(searchText) OrElse fName.Contains(searchText) OrElse lName.Contains(searchText)
                                                                        End Function)

                Dim filteredDataTable As DataTable = filteredRows.CopyToDataTable()

                dgvRoster.DataSource = filteredDataTable
                ' Replace with your function to update the row count label, if applicable

                txtCount.Text = CStr(dgvRoster.Rows.Count)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs)
        Dim tb As Guna2TextBox = CType(sender, Guna2TextBox)
        tb.Text = tb.Text.ToUpper()
        'tb.Font = New Font(tb.Font.FontFamily, tb.Font.Size, FontStyle.Bold)
        tb.SelectionStart = tb.Text.Length ' Position cursor at the end
    End Sub

    Private Sub btnFill_Click(sender As Object, e As EventArgs)
        Dim firstName As String = txtFName.Text.Trim()
        Dim lastName As String = txtLName.Text.Replace(" ", "").Trim()

        ' Create email address
        txtEMail.Text = $"{lastName}.{firstName}@live.jobcorps.org".ToLower()

        ' Reset combo boxes to their default values
        cmbTrade.SelectedIndex = 0 ' Assuming the first value is the default
        cmbSize.SelectedIndex = 7
        cmbIncentive.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        Dim newStudent As New Student
        newStudent.ID = CInt(txtID.Text)
        newStudent.FName = txtFName.Text
        newStudent.LName = txtLName.Text
        newStudent.DOB = CStr(dtpDOB.Value)
        newStudent.DOE = CStr(dtpDOE.Value)
        newStudent.EMail = txtEMail.Text
        newStudent.Trade = cmbTrade.SelectedItem.ToString()
        newStudent.Size = cmbSize.SelectedItem.ToString()
        newStudent.Incentive = cmbIncentive.SelectedItem.ToString()

        Dim isSuccess As Boolean = Add_Student(newStudent)
        DBConnection.PopulateAndRefreshRoster(dgvRoster)


        If isSuccess Then
            MessageBox.Show("Student record added successfully." & vbCrLf & "Your new OBS is: " & dgvRoster.Rows.Count)
            LogTransaction("Added", newStudent)
            ResetControls()
        Else
            MessageBox.Show("Error adding student record.")
        End If


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        Dim updatedStudent As New Student
        updatedStudent.ID = CInt(txtID.Text)
        updatedStudent.FName = txtFName.Text
        updatedStudent.LName = txtLName.Text
        updatedStudent.DOB = CStr(dtpDOB.Value)
        updatedStudent.DOE = CStr(dtpDOE.Value)
        updatedStudent.EMail = txtEMail.Text
        updatedStudent.Trade = cmbTrade.SelectedItem.ToString()
        updatedStudent.Size = cmbSize.SelectedItem.ToString()
        updatedStudent.Incentive = cmbIncentive.SelectedItem.ToString()

        Dim isSuccess As Boolean = Update_Student(updatedStudent)


        If isSuccess Then
            MessageBox.Show("Student record updated successfully.")
            LogTransaction("Updated", updatedStudent)
            ResetControls()
        Else
            MessageBox.Show("Error updating student record.")
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Dim studentID As Integer = CInt(txtID.Text) ' Assuming txtID is where you keep the StudentID
        Dim studentName As String = txtFName.Text & " " & txtLName.Text ' Assuming txtFName and txtLName are where you keep the first and last names

        Dim isSuccess As Boolean = Delete_Student(studentID)

        If isSuccess Then
            ' Refresh your DataGridView or UI here
            DBConnection.PopulateAndRefreshRoster(dgvRoster)
            ResetControls()
            MessageBox.Show("Student record successfully deleted." & vbCrLf & "Your new OBS is: " & dgvRoster.Rows.Count)

            ' Log the transaction
            LogTransaction("Deleted", New Student With {.ID = studentID, .FName = studentName.Split(" ")(0), .LName = studentName.Split(" ")(1)})

        Else
            MessageBox.Show("Failed to delete student record.")
        End If
    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        ' Call your method to generate the HTML string
        Dim htmlString As String = GenerateHTML()
        '' Save HTML to a temporary file
        'Dim tempPath As String = System.IO.Path.GetTempPath() & Guid.NewGuid().ToString() & ".html"

        'System.IO.File.WriteAllText(tempPath, htmlString)

        '' Open the HTML in the default browser
        'Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe", tempPath)
        GeneratePDF()


    End Sub

    Private Sub cbLevel_CheckedChanged(sender As Object, e As EventArgs)
        Dim selectedInfractions As Dictionary(Of String, String)

        If cbLevel.Checked Then
            cbLevel.Text = "Level II"
            cbLevel.ForeColor = Color.FromArgb(192, 255, 192)
            selectedInfractions = level2Infractions
            dtpFFBDate.Value = AddNBusinessDays(Date.Today, 5)
            txtDetails.ResetText()

        Else
            cbLevel.Text = "Level I"
            cbLevel.ForeColor = Color.White
            selectedInfractions = level1Infractions
            dtpFFBDate.Value = AddNBusinessDays(Date.Today, 3)
            txtDetails.ResetText()

        End If

        cmbInfraction.Items.Clear()
        For Each kvp As KeyValuePair(Of String, String) In selectedInfractions
            cmbInfraction.Items.Add(kvp.Key)
        Next

        If cmbInfraction.Items.Count > 0 Then
            cmbInfraction.SelectedIndex = -1  ' Select the first item
            txtPRHCode.Text = ""
        End If
    End Sub

    Private Sub cmbInfraction_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cmbInfraction.SelectedIndex = -1 Then
            Exit Sub
        End If

        Dim selectedInfractions As Dictionary(Of String, String)
        If cbLevel.Checked Then
            selectedInfractions = level2Infractions
        Else
            selectedInfractions = level1Infractions
        End If

        Dim selectedInfractionIndex As Integer = cmbInfraction.SelectedIndex()
        Dim selectedInfractionText As String = cmbInfraction.SelectedItem.ToString().Trim()
        txtDetails.Text = GetInfractionDetails(selectedInfractionIndex)

        ' Populate txtPRHCode
        If selectedInfractions.ContainsKey(selectedInfractionText) Then
            txtPRHCode.Text = selectedInfractions(selectedInfractionText)
        Else
            txtPRHCode.Text = ""  ' Clear or set to a default value
        End If

    End Sub



    Private Sub dtpFFBDate_ValueChanged(sender As Object, e As EventArgs)
        lblAppealDate.Text = dtpFFBDate.Value.AddDays(30).ToShortDateString()
    End Sub

    Private Sub cmbStudentName_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cmbStudentName.SelectedIndex = -1 Then
            Exit Sub
        End If

        Dim selectedName As String = cmbStudentName.SelectedItem.ToString()
        If studentInfo.ContainsKey(selectedName) Then
            Dim info = studentInfo(selectedName)
            txtStudentID.Text = info.Item1.ToString()
            dtpDOB2.Value = info.Item2
            dtpDOE2.Value = info.Item3
        End If
    End Sub

    Private Sub btnResetForm_Click(sender As Object, e As EventArgs)
        ResetFormFFB()
    End Sub


    Private Sub btnCreateDocs_Click(sender As Object, e As EventArgs)
        RunLevel1()
        ResetFormFFB()
    End Sub

    Private Sub btnOpenDirectory_Click(sender As Object, e As EventArgs)
        Dim path1 As String = Path.Combine(Application.StartupPath, $"PDF\Saved\")
        System.Diagnostics.Process.Start("explorer.exe", path1)
    End Sub

    ' Logging method
    Private Sub LogTransaction(action As String, student As Student)
        Dim logFilePath As String = System.IO.Path.Combine(Application.StartupPath, "roster_updater.log")
        Using writer As New System.IO.StreamWriter(logFilePath, True)
            Dim logEntry As String = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss,fff} - {action} Student {student.FName.ToUpper()} {student.LName.ToUpper()} with ID {student.ID}"
            writer.WriteLine(logEntry)
        End Using
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs)
        Settings.Show()
    End Sub

    Private Sub btnStatement_Click(sender As Object, e As EventArgs)
        Dim pdfDest As String = Path.Combine(Application.StartupPath, $"PDF\" & "Statement.pdf")
        Process.Start(New ProcessStartInfo(pdfDest) With {.UseShellExecute = True})
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Dim contactForm As New Contacts()
        contactForm.ShowDialog()
    End Sub

    Private Sub Guna2HtmlLabel11_Click(sender As Object, e As EventArgs)
        'System.Diagnostics.Process.Start(New ProcessStartInfo("https://github.com/detect2173/EZFFB/blob/mysql-FINAL/README.md") With {.UseShellExecute = True})
        Dim readmePath As String = System.IO.Path.Combine(Application.StartupPath, "README.md")
        System.Diagnostics.Process.Start("cmd.exe", $"/c start chrome {readmePath}")


    End Sub

End Class
