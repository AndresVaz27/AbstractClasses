Public Class Form1
    Dim car As Car = New Car()
    Dim bycicle As Bycicle = New Bycicle()
    Dim boat As Boat = New Boat()
    Private Sub btnCar_Click(sender As Object, e As EventArgs) Handles btnCar.Click
        If MessageBox.Show(car.Go()) = DialogResult.OK Then
            MessageBox.Show(car.Trick())
        End If
    End Sub

    Private Sub btnBycicle_Click(sender As Object, e As EventArgs) Handles btnBycicle.Click
        If MessageBox.Show(bycicle.Go()) = DialogResult.OK Then
            MessageBox.Show(bycicle.Trick())
        End If
    End Sub

    Private Sub btnBoat_Click(sender As Object, e As EventArgs) Handles btnBoat.Click
        If MessageBox.Show(boat.Go()) = DialogResult.OK Then
            MessageBox.Show(boat.Trick())
        End If
    End Sub
End Class
