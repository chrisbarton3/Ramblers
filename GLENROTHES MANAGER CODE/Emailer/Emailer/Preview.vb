Public Class Preview
    Private Sub Preview_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim oRtf As RTFtoHTML = New RTFtoHTML
        wbBody.DocumentText = oRtf.convert(My.Settings.currentBody, My.Settings.currentFsize)
        lHeading.Text = My.Settings.currentHeading
        lAttach.Text = My.Settings.currentattachment
        lCount.Text = My.Forms.frmMain.SendEmailsList.Items.Count.ToString & " email(s)"
    End Sub

    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click
        Me.Close()
    End Sub


    Private Sub bOK_Click(sender As Object, e As EventArgs) Handles bOK.Click
        My.Forms.frmMain.sendSingleBatch()
        Me.Close()
    End Sub

    Public Sub hideControls()
        Try
            Panel1.Visible = False
            SplitContainer2.SplitterDistance = 80
        Catch ex As Exception

        End Try

    End Sub
End Class