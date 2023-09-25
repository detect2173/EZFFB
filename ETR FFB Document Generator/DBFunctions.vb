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
End Module
