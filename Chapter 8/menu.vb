Public Class Menu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim box = New friendList
        box.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim box = New friendsList2
        box.Show()
    End Sub

    Private Sub btnRandomNumbos_Click(sender As Object, e As EventArgs) Handles btnRandomNumbos.Click
        Dim box = New arrayPractice
        box.Show()

    End Sub
End Class
