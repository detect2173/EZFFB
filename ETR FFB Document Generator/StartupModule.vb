''' <summary>
''' The StartupModule serves as the entry point for the application.
''' </summary>
Module StartupModule

    ''' <summary>
    ''' Main subroutine executed when the application starts.
    ''' </summary>
    Sub Main()
        ' Initialize the Python runtime by calling the utility method
        PythonUtility.InitializePython()

        ' Start the main form of the application
        Application.Run(New Form1())
    End Sub

End Module
