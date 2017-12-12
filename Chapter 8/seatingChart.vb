Public Class seatingChart

    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
        ' Variables for the selected row and column
        Dim intRow, intCol As Integer

        ' Constants for the maximum row and column subscripts
        Const intMAX_ROW As Integer = 5
        Const INTMAX_COLUMN As Integer = 3

        ' Array with seat prices
        Dim decPrices(,) = {{450D, 450D, 450D, 450D},
                             {425D, 425D, 425D, 425D},
                             {400D, 400D, 400D, 400D},
                             {375D, 375D, 375D, 375D},
                             {375D, 375D, 375D, 375D},
                             {350D, 350D, 350D, 350D}}

        Try
            ' Get the selected row and column numbers.
            intRow = CInt(txtRow.Text)
            intCol = CInt(txtColumn.Text)

            ' Make sure the row and column are within range.
            If intRow >= 0 And intRow <= intMAX_ROW Then
                If intCol >= 0 And intCol <= INTMAX_COLUMN Then
                    ' Display the selected seat's price.
                    lblPrice.Text = decPrices(intRow, intCol).ToString("c")
                Else
                    ' Error message for invalid column.
                    MessageBox.Show("Column must be 0 through " & INTMAX_COLUMN.ToString())
                End If
            Else
                ' Error Message for invalid row.
                MessageBox.Show("Row must be 0 through " & intMAX_ROW.ToString())
            End If
        Catch
            ' Error message for non-integer input.
            MessageBox.Show("Row and column must be integers.")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class