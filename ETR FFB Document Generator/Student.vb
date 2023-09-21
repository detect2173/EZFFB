Public Class Student
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
