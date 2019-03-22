Public Class archive


    Private Sub archive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Chrisbarton_grg10DataSet.ALLWALKS' table. You can move, or remove it, as needed.
        Try
            Me.ALLWALKSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.ALLWALKS)
            Me.ARCHIVED_WALKSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet2.ARCHIVED_WALKS)
            frmMain.GetArchivedWalks()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
        End Try

    End Sub

    Private Sub ARCHIVED_WALKSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ARCHIVED_WALKSBindingNavigatorSaveItem.Click
        savedata()
    End Sub

    Private Sub savedata()
        Me.Validate()
        Me.ARCHIVED_WALKSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Chrisbarton_grg10DataSet2)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim pos As Integer = ARCHIVED_WALKSBindingSource.Position

        With Chrisbarton_grg10DataSet2.ARCHIVED_WALKS(pos)
            If MsgBox("Un-archive this walk? - " & .NAME, MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
            Try
                Chrisbarton_grg10DataSet.ALLWALKS.AddALLWALKSRow(.IDW, .NAME, .TOWN, .DESCRIPTION, .GRADE, .DISTANCE, .MEET_TIME, .START_TIME, .TIME, .START_PLACE, .GRIDREF, .OS_MAP, .CHILDREN, .DOGS, .MAP, .ASCENT)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End With
        Me.Validate()
        Me.ALLWALKSBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Chrisbarton_grg10DataSet)
        ARCHIVED_WALKSBindingSource.RemoveCurrent()
        savedata()
        Me.ARCHIVED_WALKSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet2.ARCHIVED_WALKS)
        My.Forms.frmMain.dbaseLoad()
    End Sub
End Class