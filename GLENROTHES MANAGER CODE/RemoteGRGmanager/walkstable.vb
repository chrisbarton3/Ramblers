Public Class walkstable
    Private Sub ALLWALKSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ALLWALKSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ALLWALKSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Chrisbarton_grg10DataSet1)

    End Sub

    Private Sub walkstable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Chrisbarton_grg10DataSet1.ALLWALKS' table. You can move, or remove it, as needed.
        Me.ALLWALKSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet1.ALLWALKS)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.ALLWALKSTableAdapter.FillByMaps(Me.Chrisbarton_grg10DataSet1.ALLWALKS)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.ALLWALKSTableAdapter.FillByNoMaps(Me.Chrisbarton_grg10DataSet1.ALLWALKS)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Try
            Dim map As String = ALLWALKSDataGridView.SelectedRows(0).Cells(13).Value
            If Not map = "" Then
                Dim urlRoute As String = "www.glenrothesramblers.co.uk/Maps/" & map
                osfinder.Show()
                osfinder.showURL(urlRoute)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class