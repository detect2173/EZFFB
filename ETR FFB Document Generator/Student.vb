Public Class Student
    Public Property ID As Integer
    Public Property FName As String
    Public Property LName As String
    Public Property DOB As String
    Public Property DOE As String
    Public Property EMail As String
    Public Property Trade As String
    Public Property Size As String
    Public Property Incentive As String

    Public Shared ReadOnly TradeOptions As New Dictionary(Of String, String) From {
    {"CPP", "CPP"},
    {"Advanced_Welding", "Advanced Welding"},
    {"Basic_Welding", "Basic Welding"},
    {"Automotive_Technology", "Automotive Technology"},
    {"Urban_Forestry", "Urban Forestry"},
    {"Building_Construction_Technology", "Building Construction Technology"},
    {"Clinical_Medical_Assistant", "Clinical Medical Assistant"},
    {"Culinary_Arts", "Culinary Arts"},
    {"Office_Administration", "Office Administration"},
    {"U/K", "U/K"}
}

    Public Shared ReadOnly SizeOptions As New Dictionary(Of String, String) From {
    {"Small", "Small"},
    {"Medium", "Medium"},
    {"Large", "Large"},
    {"XLarge", "XLarge"},
    {"2XLarge", "2XLarge"},
    {"3XLarge", "3XLarge"},
    {"4XLarge", "4XLarge"},
    {"U/K", "U/K"}
}

    Public Shared ReadOnly IncentiveOptions As New Dictionary(Of String, String) From {
    {"Blue", "Blue"},
    {"Bronze", "Bronze"},
    {"Gold", "Gold"},
    {"Platinum", "Platinum"},
    {"Red", "Red"},
    {"Silver", "Silver"},
    {"U/K", "U/K"}
}

End Class
