Friend Class Car
    Inherits Vehicle

    Public wheels As Integer = 4
    Private maxSpeed As Integer = 300

    Public Overrides Function Go() As String
        Dim message As String = "The car is moving!"
        Return message
    End Function

    Public Overrides Function Trick() As String
        Dim message As String = "The car is revving the engine and sounds amazing!"
        Return message
    End Function
End Class
