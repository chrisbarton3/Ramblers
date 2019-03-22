Public Class getdate
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bInsert.Click
        Dim sdate As Date = DateTimePicker1.Value
        frmMain.addNewDate(sdate)
        Me.Close()
    End Sub

    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click
        Me.Close()
    End Sub
End Class