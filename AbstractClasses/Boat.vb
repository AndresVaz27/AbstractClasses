Friend Class Boat
    Inherits Vehicle

    Public wheels As Integer = 0
    Private maxSpeed As Integer = 100

    Public Overrides Function Go() As String
        Dim message As String = "The Boat is moving!"
        Return message
    End Function

    Public Overrides Function Trick() As String
        Dim message As String = "The Boat is racing a dolphin!"
        Return message
    End Function
End Class