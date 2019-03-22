Public Class StopPress


    Private Sub StopPress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Chrisbarton_grg10DataSet3.PUBLISHED' table. You can move, or remove it, as needed.
        Me.PUBLISHEDTableAdapter.Fill(Me.Chrisbarton_grg10DataSet3.PUBLISHED)

    End Sub

    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click
        Me.Close()
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        Try
            Chrisbarton_grg10DataSet3.PUBLISHED.AddPUBLISHEDRow(dtp.Value, "", "STOP PRESS ITEM", "STOPPRESS", texttb.Text, "", "", "", "", "", "", "", "", "", "", "", "", "", "")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Validate()
        Me.PUBLISHEDBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.Chrisbarton_grg10DataSet3)
        MsgBox("New Stop Press item saved")
        Me.Close()

    End Sub
End Class