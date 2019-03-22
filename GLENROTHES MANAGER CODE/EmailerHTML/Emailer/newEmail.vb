Public Class newEmail
    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click
        Me.Close()
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        If tbEmail.Text = "" Or tbName.Text = "" Or Not tbEmail.Text.Contains("@") Then
            MsgBox("Invalid input!")
            Exit Sub
        End If
        My.Forms.frmMain.SendEmailsList.Items.Add(tbName.Text & ";" & tbEmail.Text)
        'My.Forms.frmMain.setUnsent()
        'My.Forms.frmMain.setLists()
        Me.Close()
    End Sub
End Class