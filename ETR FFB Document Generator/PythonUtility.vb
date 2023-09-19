Imports Python.Runtime

''' <summary>
''' Utility class for handling Python-related operations.
''' </summary>
Public Class PythonUtility

    ''' <summary>
    ''' Initializes the embedded Python runtime.
    ''' </summary>
    Public Shared Sub InitializePython()
        ' Determine the path to the bundled Python runtime
        Dim pythonPath As String = AppDomain.CurrentDomain.BaseDirectory & "\PythonRuntime\"

        ' Set the Python path for the PythonEngine
        PythonEngine.PythonPath = pythonPath

        ' Initialize the Python engine
        PythonEngine.Initialize()
    End Sub
End Class

