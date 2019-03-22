Imports System.IO, System.Data
Public Class frmMain
    Dim appPath As String = My.Application.Info.DirectoryPath
    Dim gridref As String = "NO269008"

#Region "MAIN"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        bNewid.Visible = False
    End Sub

    Private Sub tsbDbaseload_Click(sender As Object, e As EventArgs) Handles tsbDbaseload.Click
        dbaseLoad()

    End Sub

    Private Sub dbaseLoad()
        wait.Show()
        wait.Refresh()
        Try
            Me.PROGRAMTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PROGRAM)
            Me.FINAL_PROGRAMTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.FINAL_PROGRAM)
            Me.ALLWALKSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.ALLWALKS)
            Me.LEADERSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.LEADERS)
            Me.HISTORYTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.HISTORY)
            Me.SETFINALTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.SETFINAL)
        Catch ex As Exception
            MsgBox("Unable to load database" & vbCr & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        tsbDbaseload.BackColor = Color.LightGreen

        wait.Hide()
    End Sub


    Private Function setPeriod(sdate As Date) As String
        Dim mon As Integer = sdate.Month
        Dim yr As Integer = sdate.Year
        If mon > 3 And mon < 10 Then
            setPeriod = yr.ToString & "-Summer"
        Else
            If mon < 4 Then
                setPeriod = (yr - 1).ToString & "-Winter"
            Else
                setPeriod = yr.ToString & "-Winter"
            End If
        End If

    End Function

    Private Function setID(sdate As Date) As String
        Dim dateid As String = CStr(sdate.Year - 2000)
        dateid = dateid & CStr(sdate.DayOfYear)
        Return dateid
    End Function

#End Region

#Region "PROGRAM"

    Private Sub PROGRAMBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PROGRAMBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.PROGRAMBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Chrisbarton_grg10DataSet)
            MsgBox("Changes saved to database")
            Me.PROGRAMTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PROGRAM)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub W_DATEDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles W_DATEDateTimePicker.ValueChanged
        Dim sdate As Date = W_DATEDateTimePicker.Value
        PROGRAM_IDTextBox.Text = setID(sdate)
        PERIODTextBox1.Text = setPeriod(sdate)

    End Sub

    Private Sub tsb1Undo_Click(sender As Object, e As EventArgs) Handles tsb1Undo.Click
        Me.PROGRAMTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PROGRAM)
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        MsgBox("Deleting item date " & W_DATEDateTimePicker.Value.ToShortDateString & vbCr & "If this is in error then click Ok then UNDO")
    End Sub

#End Region

#Region "WALKS"

    Private Sub saveWALKS_Click(sender As Object, e As EventArgs) Handles saveWALKS.Click
        Try
            Me.Validate()
            Me.ALLWALKSBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Chrisbarton_grg10DataSet)
            MsgBox("Changes saved to database")
            Me.ALLWALKSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.ALLWALKS)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tsb3Undo_Click(sender As Object, e As EventArgs) Handles tsb3Undo.Click
        Me.ALLWALKSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.ALLWALKS)
        bNewid.Visible = False
    End Sub

    Private Sub BindingNavigatorDeleteItem1_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem1.Click
        MsgBox("Deleting walk:" & vbCr & NAMETextBox.Text & vbCr & "If this is in error then click Ok then UNDO")
    End Sub

    Private Sub BindingNavigatorAddNewItem1_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem1.Click
        bNewid.Visible = True
    End Sub

    Private Sub bNewid_Click(sender As Object, e As EventArgs) Handles bNewid.Click
        Dim newid As Integer, maxid As Integer = 600
        For ix = 0 To ALLWALKSDataGridView.RowCount - 1
            If Not IsDBNull(ALLWALKSDataGridView(0, ix).Value) Then
                If CInt(ALLWALKSDataGridView(0, ix).Value) > maxid Then maxid = CInt(ALLWALKSDataGridView(0, ix).Value)
            End If
        Next
        newid = maxid + 1
        IDWTextBox.Text = newid.ToString
        bNewid.Visible = False
    End Sub

#End Region

#Region "LEADERS"

    Private Sub bSaveleader_Click(sender As Object, e As EventArgs)
        Try
            Me.Validate()
            Me.LEADERSBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Chrisbarton_grg10DataSet)
            MsgBox("Changes saved to database")
            Me.LEADERSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.LEADERS)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub bUndoleader_Click(sender As Object, e As EventArgs)
        Me.LEADERSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.LEADERS)
    End Sub

    Private Sub tsbUndoleader_Click(sender As Object, e As EventArgs) Handles tsbUndoleader.Click
        Me.LEADERSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.LEADERS)
    End Sub

    Private Sub tsbSaveleader_Click(sender As Object, e As EventArgs) Handles tsbSaveleader.Click
        Me.Validate()
        Me.LEADERSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Chrisbarton_grg10DataSet)
    End Sub

#End Region

#Region "Final Program"


    Private Sub CDATEDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles CDATEDateTimePicker.ValueChanged
        Dim sdate As Date = CDATEDateTimePicker.Value
        PROGRAM_IDTextBox1.Text = setID(sdate)
        PERIODTextBox.Text = setPeriod(sdate)
    End Sub

    Private Sub tsbUndoFP_Click(sender As Object, e As EventArgs) Handles tsbUndoFP.Click
        Me.FINAL_PROGRAMTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.FINAL_PROGRAM)
    End Sub

    Private Sub tsbsaveFP_Click(sender As Object, e As EventArgs) Handles tsbsaveFP.Click
        If MsgBox("Changes will appear immediately on the Website - press Cancel if this is not correct!", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        Try
            Me.Validate()
            Me.FINAL_PROGRAMBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Chrisbarton_grg10DataSet)
            MsgBox("Changes saved to database")
            Me.FINAL_PROGRAMTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.FINAL_PROGRAM)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BindingNavigatorDeleteItem2_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem2.Click
        MsgBox("Deleting item date " & CDATEDateTimePicker.Value.ToShortDateString & vbCr & "If this is in error then click Ok then UNDO")
    End Sub

#End Region



    Private Sub maptab(sender As Object, e As EventArgs) Handles MapPage.Enter
        Dim gr As String = gridref
        If Not gr = "" Then
            Dim urlstr As String = "file:///" & appPath & "\Docs\ShowOSgridref.htm?gr=" & gr
            WebBrowser1.Navigate(urlstr)
        End If

    End Sub

    Private Sub GRIDREFTextBox_TextChanged(sender As Object, e As EventArgs) Handles GRIDREFTextBox.TextChanged
        If GRIDREFTextBox.Text <> "" Then
            gridref = GRIDREFTextBox.Text
        End If

    End Sub

    Private Sub publish()
        If MsgBox("This will add current programme to Final Programme table" & vbCrLf & "When saved, It will appear on the website. If not complete, press Cancel", _
                  MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        wait.Show()
        wait.Refresh()
        Try
            Dim lastrow As Integer = Chrisbarton_grg10DataSet.SETFINAL.Rows.Count - 1
            For row As Integer = 0 To lastrow
                With Chrisbarton_grg10DataSet
                    Chrisbarton_grg10DataSet.FINAL_PROGRAM.AddFINAL_PROGRAMRow(.SETFINAL(row)(0).ToString, .SETFINAL(row)(1).ToString, .SETFINAL(row)(2).ToString, .SETFINAL(row)(9).ToString, _
                                                                               .SETFINAL(row)(8).ToString, .SETFINAL(row)(10).ToString, .SETFINAL(row)(11).ToString, .SETFINAL(row)(12).ToString, _
                                                                               .SETFINAL(row)(13).ToString, .SETFINAL(row)(14).ToString, .SETFINAL(row)(15).ToString, .SETFINAL(row)(16).ToString, _
                                                                               .SETFINAL(row)(17).ToString, .SETFINAL(row)(18).ToString, .SETFINAL(row)(19).ToString, .SETFINAL(row)(3).ToString, _
                                                                               .SETFINAL(row)(6).ToString, .SETFINAL(row)(7).ToString, .SETFINAL(row)(4).ToString, .SETFINAL(row)(5).ToString)

                End With

            Next
            FINAL_PROGRAMDataGridView.Refresh()
            TabControl1.SelectTab(6)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        wait.Hide()
    End Sub


    Private Sub bPublish_Click(sender As Object, e As EventArgs) Handles bPublish.Click
        publish()
    End Sub

    Private Sub getFPperiod()
        Dim period As String = ""
        Dim fpcnt As Integer = FINAL_PROGRAMDataGridView.RowCount - 1
        For ix As Integer = 0 To fpcnt
            If period <> FINAL_PROGRAMDataGridView.Rows(ix).Cells(4).Value Then
                period = FINAL_PROGRAMDataGridView.Rows(ix).Cells(4).Value
                FPPeriodList.Items.Add(period)
            End If
        Next
    End Sub

    Private Sub getHistoryPeriod()
        Dim period As String = ""
        Dim fpcnt As Integer = HISTORYDataGridView.RowCount - 1
        For ix As Integer = 0 To fpcnt
            If period <> HISTORYDataGridView.Rows(ix).Cells(1).Value Then
                period = HISTORYDataGridView.Rows(ix).Cells(1).Value
                HistoryPeriodList.Items.Add(period)
            End If
        Next
    End Sub

    Private Sub bDelPeriod_Click(sender As Object, e As EventArgs) Handles bDelPeriod.Click
        Dim selPeriod As String = FPPeriodList.SelectedItem.ToString
        If HistoryPeriodList.Items.Contains(selPeriod) Then
            wait.Show()
            wait.Refresh()
            Dim fpcnt As Integer = Chrisbarton_grg10DataSet.FINAL_PROGRAM.Rows.Count - 1
            For ix As Integer = 0 To fpcnt
                If Chrisbarton_grg10DataSet.FINAL_PROGRAM(ix).PERIOD.ToString = selPeriod Then
                    Chrisbarton_grg10DataSet.FINAL_PROGRAM.Rows(ix).Delete()
                End If
            Next
            wait.Hide()
            TabControl1.SelectTab(FinalPage)
            MsgBox(selPeriod & " deleted from FINAL PROGRAMME" & vbCr & "Press SAVE to confirm delete")
        Else
            MsgBox("Save this period to history first!")
        End If

    End Sub

    Private Sub PublishPage_Enter(sender As Object, e As EventArgs) Handles PublishPage.Enter
        Try
            getFPperiod()
            getHistoryPeriod()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tsbSaveHistory_Click(sender As Object, e As EventArgs) Handles tsbSaveHistory.Click
        Try
            Me.Validate()
            Me.HISTORYBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Chrisbarton_grg10DataSet)
            MsgBox("Changes saved to database")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Chrisbarton_grg10DataSet.HISTORY.AddHISTORYRow("12/12/14", "fgghh", 1111, "hgh", "vbb")
    End Sub
End Class
