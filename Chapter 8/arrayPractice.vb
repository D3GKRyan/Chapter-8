Public Class arrayPractice

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        ' Create an array to hold five lottery numbers.
        Const intMAX_SUBSCRIPT As Integer = 4           ' The maximum subscript
        Dim intNumbers(intMAX_SUBSCRIPT) As Integer     ' Array Declaration
        Dim intCount As Integer                         ' Loop Counter

        ' Create a Random object.
        Dim rand As New Random

        ' Fill the array with random numbers.
        ' Each number will be in the range 0-99
        For intCount = 0 To intMAX_SUBSCRIPT
            intNumbers(intCount) = rand.Next(100)
        Next

        ' Display the array elements in the labels.
        lbl1.Text = intNumbers(0).ToString()
        lbl2.Text = intNumbers(1).ToString()
        lbl3.Text = intNumbers(2).ToString()
        lbl4.Text = intNumbers(3).ToString()
        lbl5.Text = intNumbers(4).ToString()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class