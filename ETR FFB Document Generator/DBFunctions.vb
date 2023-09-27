Imports MySql.Data.MySqlClient

Module DBFunctions

    Public Function Add_Student(student As Student) As Boolean
        Dim isSuccess As Boolean = False
        Dim connectionString As String = $"Server=localhost;Database=roster;User ID=root;Password=;"

        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "INSERT INTO roster.roster (StudentID, Firstname, Lastname, DOB, DOE, EMail, Trade, Size, Incentive) " &
                              "VALUES (@StudentID, @Firstname, @Lastname, @DOB, @DOE, @EMail, @Trade, @Size, @Incentive)"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@StudentID", student.ID)
                cmd.Parameters.AddWithValue("@Firstname", student.FName)
                cmd.Parameters.AddWithValue("@Lastname", student.LName)
                cmd.Parameters.AddWithValue("@DOB", student.DOB)
                cmd.Parameters.AddWithValue("@DOE", student.DOE)
                cmd.Parameters.AddWithValue("@EMail", student.EMail)
                cmd.Parameters.AddWithValue("@Trade", student.Trade)
                cmd.Parameters.AddWithValue("@Size", student.Size)
                cmd.Parameters.AddWithValue("@Incentive", student.Incentive)

                conn.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    isSuccess = True
                End If
            End Using
        End Using

        Return isSuccess
    End Function

    Public Function Update_Student(student As Student) As Boolean
        Dim isSuccess As Boolean = False
        Dim connectionString As String = $"Server=localhost;Database=roster;User ID=root;Password=;"

        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "UPDATE roster.roster SET Firstname = @Firstname, Lastname = @Lastname, DOB = @DOB, DOE = @DOE, " &
                                  "EMail = @EMail, Trade = @Trade, Size = @Size, Incentive = @Incentive WHERE StudentID = @StudentID"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@StudentID", student.ID)
                cmd.Parameters.AddWithValue("@Firstname", student.FName)
                cmd.Parameters.AddWithValue("@Lastname", student.LName)
                cmd.Parameters.AddWithValue("@DOB", student.DOB)
                cmd.Parameters.AddWithValue("@DOE", student.DOE)
                cmd.Parameters.AddWithValue("@EMail", student.EMail)
                cmd.Parameters.AddWithValue("@Trade", student.Trade)
                cmd.Parameters.AddWithValue("@Size", student.Size)
                cmd.Parameters.AddWithValue("@Incentive", student.Incentive)

                conn.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    isSuccess = True
                End If
            End Using
        End Using

        Return isSuccess
    End Function

    Public Function Delete_Student(studentID As Integer) As Boolean
        Dim isSuccess As Boolean = False
        Dim connectionString As String = $"Server=localhost;Database=roster;User ID=root;Password=;"

        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "DELETE FROM roster.roster WHERE StudentID = @StudentID"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@StudentID", studentID)

                conn.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    isSuccess = True
                End If
            End Using
        End Using

        Return isSuccess
    End Function


    Public Function GetLevel1Infractions() As Dictionary(Of String, String)
        Dim infractions As New Dictionary(Of String, String)
        Dim connectionString As String = $"Server=localhost;Database=roster;User ID=root;Password=;"

        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "SELECT Infraction, Code FROM Level1"

            Using cmd As New MySqlCommand(query, conn)
                conn.Open()

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        infractions.Add(reader.GetString("Infraction"), reader.GetString("Code"))
                    End While
                End Using
            End Using
        End Using

        Return infractions
    End Function

    Public Function GetLevel2Infractions() As Dictionary(Of String, String)
        Dim infractions As New Dictionary(Of String, String)
        Dim connectionString As String = $"Server=localhost;Database=roster;User ID=root;Password=;"

        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "SELECT Infraction, Code FROM Level2"

            Using cmd As New MySqlCommand(query, conn)
                conn.Open()

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        infractions.Add(reader.GetString("Infraction"), reader.GetString("Code"))
                    End While
                End Using
            End Using
        End Using

        Return infractions
    End Function

    Public Function AddNBusinessDays(ByVal startDate As DateTime, ByVal numDays As Integer) As DateTime

        If numDays = 0 Then Return New DateTime(startDate.Ticks)

        If numDays < 0 Then Throw New ArgumentException()

        'Dim i As Integer
        Dim totalDays As Integer
        Dim businessDays As Integer
        totalDays = 0
        businessDays = 0

        Dim currDate As DateTime
        While businessDays < numDays
            totalDays += 1

            currDate = startDate.AddDays(totalDays)

            If Not (currDate.DayOfWeek = DayOfWeek.Saturday Or currDate.DayOfWeek = DayOfWeek.Sunday) Then
                businessDays += 1
            End If

        End While

        Return currDate


    End Function

    Public Function GetStudentInfo() As Dictionary(Of String, (Integer, DateTime, DateTime))
        Dim students As New Dictionary(Of String, (Integer, DateTime, DateTime))
        Dim connectionString As String = "Server=localhost;Database=roster;User ID=root;Password=;"
        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "SELECT CONCAT(Firstname, ' ', Lastname) AS FullName, StudentID, DOB, DOE FROM roster.roster"
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        students.Add(reader("FullName").ToString(), (Integer.Parse(reader("StudentID").ToString()), DateTime.Parse(reader("DOB").ToString()), DateTime.Parse(reader("DOE").ToString())))
                    End While
                End Using
            End Using
        End Using
        Return students
    End Function

    Public Sub ResetFormFFB()
        ' Reset ComboBoxes to first item
        Form1.cmbStudentName.SelectedIndex = -1
        Form1.cmbInfraction.SelectedIndex = -1
        ' ... add other ComboBox controls here

        ' Clear TextBoxes
        Form1.txtStudentID.Clear()
        Form1.txtPRHCode.Clear()
        Form1.txtDetails.Clear()
        Form1.txtLocation.Clear()


        ' ... add other TextBox controls here

        ' Reset DateTimePickers to current date or any default date
        Form1.dtpDOB2.Value = DateTime.Now
        Form1.dtpDOE2.Value = DateTime.Now
        Form1.dtpFFBDate.Value = DateTime.Now
        Form1.dtpNotification.Value = DateTime.Now
        Form1.dtpDOI.Value = DateTime.Now
        ' ... add other DateTimePicker controls here

        Form1.cbLevel.Checked = False
        Form1.lblAppealDate.Text = DateTime.Today.AddDays(30).ToShortDateString()
    End Sub


    Public Function GetInfractionDetails(selectedInfraction As Integer) As String
        Select Case selectedInfraction
            Case 6
                Return "Student tested positive on their second drug test for the presence of drugs. "
            Case 15
                Return "Student received more than 4 minor infractions within a 60 day period elevating the infraction to a Level II infraction with a Fact Finding Board for: Pattern of minor infractons."
            Case Else
                Return "" ' Clear the textbox or set to a default value
        End Select
    End Function

    Public Sub PopulateContactInfoByCenter(centerName As String, lblCenter As Label, txtSHRO As Guna.UI2.WinForms.Guna2TextBox, txtSHROeMail As Guna.UI2.WinForms.Guna2TextBox, txtC2C As Guna.UI2.WinForms.Guna2TextBox, txtSHROphone As Guna.UI2.WinForms.Guna2TextBox)
        Dim connectionString As String = $"Server=localhost;Database=roster;User ID=root;Password=;"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT * FROM contacts WHERE Center = @centerName"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@centerName", centerName)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lblCenter.Text = reader("Center").ToString()
                            txtSHRO.Text = reader("Name").ToString()
                            txtSHROeMail.Text = reader("Email").ToString()
                            txtC2C.Text = reader("C2C").ToString()
                            txtSHROphone.Text = reader("Phone").ToString()
                        Else

                        End If
                    End Using
                End Using
            Catch ex As Exception
                ' Handle exceptions
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Public Sub UpdateContactInfo(centerName As String, txtSHRO As Guna.UI2.WinForms.Guna2TextBox, txtSHROeMail As Guna.UI2.WinForms.Guna2TextBox, txtC2C As Guna.UI2.WinForms.Guna2TextBox, txtSHROphone As Guna.UI2.WinForms.Guna2TextBox)
        Dim connectionString As String = $"Server=localhost;Database=roster;User ID=root;Password=;"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "UPDATE contacts SET Name = @Name, Email = @Email, C2C = @C2C, Phone = @Phone WHERE Center = @Center"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Name", txtSHRO.Text)
                command.Parameters.AddWithValue("@Email", txtSHROeMail.Text)
                command.Parameters.AddWithValue("@C2C", txtC2C.Text)
                command.Parameters.AddWithValue("@Phone", txtSHROphone.Text)
                command.Parameters.AddWithValue("@Center", centerName)
                Dim rowsAffected = command.ExecuteNonQuery()
                If rowsAffected > 0 Then

                    MessageBox.Show("Record Updated Successfully!")

                Else
                    MessageBox.Show("Update failed.")

                End If
            End Using
        End Using
    End Sub


End Module
