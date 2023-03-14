Friend Class Bycicle
    Inherits Vehicle

    Public wheels As Integer = 2
    Private maxSpeed As Integer = 50

    Public Overrides Function Go() As String
        Dim message As String = "The bycicle is moving!"
        Return message
    End Function

    Public Overrides Function Trick() As String
        Dim message As String = "The bycicle is making a wheelie!"
        Return message
    End Function
End Class
