Public Class friendsList2
    Private lstNames As New List(Of String)
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Add the name to the List.
        lstNames.Add(txtInput.Text)

        ' Clear the text box.
        txtInput.Clear()
        txtInput.Focus()

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ' Display all names in the list box.
        Dim strName As String
        lstFriends.Items.Clear()

        For Each strName In lstNames
            lstFriends.Items.Add(strName) ' Add to list box
        Next

    End Sub
End Class