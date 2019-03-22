Public Class GRGlocal


    Dim new_programme As String



    Private Sub SaveAll()
        Me.AJPwalksBindingSource.EndEdit()
        Me.PUBLISHEDBindingSource.EndEdit()
        Me.ALLWALKSBindingSource.EndEdit()
        Me.LEADERSBindingSource.EndEdit()
        Me.PROGRAMMEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Chrisbarton_grg10DataSet)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'Chrisbarton_grg10DataSet._STROLLERS_LEADER' table. You can move, or remove it, as needed.
        Me.STROLLERS_LEADERTableAdapter.Fill(Me.Chrisbarton_grg10DataSet._STROLLERS_LEADER)
        'TODO: This line of code loads data into the 'Chrisbarton_grg10DataSet._STROLLERS_WALK' table. You can move, or remove it, as needed.
        Me.STROLLERS_WALKTableAdapter.Fill(Me.Chrisbarton_grg10DataSet._STROLLERS_WALK)
        TableAdapterManager.Connection.ConnectionString = "Data Source=MAIN-I7\SQLEXPRESS;Initial Catalog=chrisbarton_grg10;Integrated Security=True"

        LoadAll()


    End Sub

    Public Sub wait(ByVal waiting As Boolean)
        If waiting Then
            Cursor = Cursors.WaitCursor
            TabControl1.Enabled = False
        Else
            TabControl1.Enabled = True
            Cursor = Cursors.Default

        End If
    End Sub

    Private Sub LoadAll()
        Me.AJPwalksTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.AJPwalks)
        Me.PUBLISHEDTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PUBLISHED)
        Me.ALLWALKSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.ALLWALKS)
        Me.PROGRAMMETableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PROGRAMME)
        Me.LEADERSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.LEADERS)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        SaveAll()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        LoadAll()
    End Sub

    Private Sub Publish()
        If MsgBox("This will add current programme to Final Programme table" & vbCrLf & "When saved, It will appear on the website. If not complete, press Cancel",
                          MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        wait(True)

        Me.PROGRAMMETableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PROGRAMME)
        Try
            Dim lastrow As Integer = Chrisbarton_grg10DataSet.PROGRAMME.Rows.Count - 1
            For row As Integer = 0 To lastrow
                With Chrisbarton_grg10DataSet.PROGRAMME(row)
                    Try
                        'add row to final programme
                        If .walk <> "- none chosen" And .leader <> "- none chosen" Then
                            Chrisbarton_grg10DataSet.PUBLISHED.AddPUBLISHEDRow(.dateid, .itemdate, .period, .walk, .grade, .descr, .ascent, .dist, .time, .meet, .start, .place, .osmap, .griref, setChildren(.kids), setDogs(.dogs), .leader, .phone, .email, .note)

                        Else
                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End With
            Next
            wait(False)
            PUBLISHEDDataGridView.Refresh()
            TabControl1.SelectedIndex() = 1
            MsgBox("Publication Complete - check result then" & vbCrLf & "save FinalProgramme table to update database." & vbCrLf & "If incorrect - press Reload to undo.")
        Catch ex As Exception
            wait(False)
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub constructTable()  'construct table
        Cursor = Cursors.WaitCursor
        If Chrisbarton_grg10DataSet.AJPwalks.Rows.Count > 0 Then
            If MsgBox("Clear table first?", MsgBoxStyle.OkCancel) <> MsgBoxResult.Ok Then
                Exit Sub
            End If
            ClearAJPTable()
        End If

        Me.Validate()
        Me.AJPwalksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Chrisbarton_grg10DataSet)
        Me.AJPwalksTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.AJPwalks)
        Me.PUBLISHEDTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PUBLISHED)
        Dim kids As String, dogs As String, datetxt As String, descr As String
        Dim fix As Integer = Chrisbarton_grg10DataSet.PUBLISHED.Rows.Count - 1
        Dim current_period As String = Chrisbarton_grg10DataSet.PUBLISHED(fix).period
        Dim idx As Integer = 0
        For ix As Integer = 0 To fix
            With Chrisbarton_grg10DataSet.PUBLISHED(ix)
                If .period = current_period And .grade <> "STOPPRESS" Then
                    idx += 1
                    kids = setChildren(.kids)
                    dogs = setDogs(.dogs)
                    datetxt = textDate(.itemdate.ToShortDateString)
                    descr = .descr
                    Chrisbarton_grg10DataSet.AJPwalks.AddAJPwalksRow(.id, .itemdate, datetxt, .period, .prog_item, descr, .ascent, .grade, .dist, .time, .meet, .start, .place, .osmap, .gridref, kids, dogs, .leader, .phone, .email, .note)
                End If

            End With
        Next
        SaveAll()
        Cursor = Cursors.Default
        MsgBox("AJP table constructed." & vbCrLf & "Before submitting to Area, check that initial Strollers entry is unchanged.")
    End Sub

    Private Sub ClearAJPTable()

        For ix = 0 To Chrisbarton_grg10DataSet.AJPwalks.Rows.Count - 1
            Try
                Chrisbarton_grg10DataSet.AJPwalks.Rows(ix).Delete()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
        SaveAll()
    End Sub

    Public Function textDate(ByVal sdate As String) As String
        Dim d As Date
        d = CDate(sdate)
        Dim swk As String = d.DayOfWeek.ToString
        Dim smon As String = d.ToString("MMMM")
        Dim sday As String = d.Day.ToString

        Select Case sday
            Case "1", "21", "31"
                sday = sday & "st"
            Case "2", "22"
                sday = sday & "nd"
            Case "3", "23"
                sday = sday & "rd"
            Case Else
                sday = sday & "th"
        End Select

        textDate = swk & " " & sday & " " & smon
        Return textDate
    End Function


    'AJP setting
    Public Function setDogs(ByVal value As String) As String
        Try
            If value = "yes" Then
                Return "DWOL "
            Else
                Return "RADO "
            End If
        Catch ex As Exception
            Return ""
        End Try

    End Function

    'AJP setting
    Public Function setChildren(ByVal value As String) As String
        Try
            If value = "yes" Then
                Return "CWRA "
            Else
                Return "NoSC "
            End If
        Catch ex As Exception
            Return ""
        End Try

    End Function

    Private Sub MakeNewProgramme()

        Dim currentseason As String, currentyear As Integer, currix As Integer
        currix = Chrisbarton_grg10DataSet.PUBLISHED.Rows.Count - 1
        Dim currentperiod As String = Chrisbarton_grg10DataSet.PUBLISHED(currix).period
        Dim parts() As String = currentperiod.Split("-")
        currentseason = parts(0).Trim(" ")
        currentyear = CInt(parts(1).Trim(" "))
        If currentseason = "Winter" Then
            currentseason = "Summer"
            currentyear += 1
        Else
            currentseason = "Winter"
        End If
        If MsgBox("Make new programme for " & currentyear & ", " & currentseason & "?" & vbCrLf & "This will delete old programme!", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        DelProgramme()
        Dim np As Prog_period = New Prog_period(currentseason, currentyear)
        Dim pd As String = currentseason & " - " & currentyear
        Dim nc As String = "- none chosen"
        Dim stname As String = Chrisbarton_grg10DataSet._STROLLERS_WALK(0).NAME
        Dim stgrd As String = Chrisbarton_grg10DataSet._STROLLERS_WALK(0).GRADE
        Dim stdist As String = Chrisbarton_grg10DataSet._STROLLERS_WALK(0).DISTANCE
        Dim stdescr As String = Chrisbarton_grg10DataSet._STROLLERS_WALK(0).DESCRIPTION
        Dim sttim As String = Chrisbarton_grg10DataSet._STROLLERS_WALK(0).TIME
        Dim stmeet As String = Chrisbarton_grg10DataSet._STROLLERS_WALK(0).MEET_TIME
        Dim ststrt As String = Chrisbarton_grg10DataSet._STROLLERS_WALK(0).START_TIME
        Dim stpl As String = Chrisbarton_grg10DataSet._STROLLERS_WALK(0).START_PLACE
        Dim stgr As String = Chrisbarton_grg10DataSet._STROLLERS_WALK(0).GRIDREF
        Dim stch As Boolean = Chrisbarton_grg10DataSet._STROLLERS_WALK(0).CHILDREN
        Dim stdg As Boolean = Chrisbarton_grg10DataSet._STROLLERS_WALK(0).DOGS
        Dim stos As String = Chrisbarton_grg10DataSet._STROLLERS_WALK(0).OS_MAP
        Dim stleader As String = Chrisbarton_grg10DataSet._STROLLERS_LEADER(0).LEADER
        Dim stphon As String = Chrisbarton_grg10DataSet._STROLLERS_LEADER(0).PHONE
        Dim steml As String = Chrisbarton_grg10DataSet._STROLLERS_LEADER(0).EMAIL
        unhideWalks()
        Try
            For ix As Integer = 0 To 51
                With Chrisbarton_grg10DataSet.PROGRAMME
                    Dim dt As Date = np.itemdates(ix)
                    If np.itemdays(ix) = "Thursday" Then
                        .AddPROGRAMMERow(ix, dt, pd, stname, stdescr, "", stgrd, stdist, sttim, stmeet, ststrt, stpl, stos, stgr, stch, stdg, stleader, stphon, steml, "")
                    Else
                        .AddPROGRAMMERow(ix, dt, pd, nc, "", "", "", "", "", "", "", "", "", "", False, False, nc, "", "", "")
                    End If

                End With
            Next
            SaveAll()
            MsgBox("New PROGRAMME constructed.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DelProgramme()
        Me.PROGRAMMETableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PROGRAMME)
        Dim fpcnt As Integer = Chrisbarton_grg10DataSet.PROGRAMME.Rows.Count - 1
        For ix As Integer = 0 To fpcnt
            Chrisbarton_grg10DataSet.PROGRAMME.Rows(ix).Delete()
        Next
        Me.Validate()
        Me.PROGRAMMEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Chrisbarton_grg10DataSet)
        Me.PROGRAMMETableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PROGRAMME)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Publish()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles TSBajp.Click
        constructTable()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        walkfinder.Show()

    End Sub

    Private Sub ToolStripButton4_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        MakeNewProgramme()
    End Sub

    Private Sub unhideWalks()
        Try
            For ix As Integer = 0 To Chrisbarton_grg10DataSet.ALLWALKS.Rows.Count - 1
                With Chrisbarton_grg10DataSet.ALLWALKS(ix)
                    If .NAME <> "Strollers Walk" And .NAME <> "- none chosen" Then
                        .HIDDEN = False
                    End If
                End With
            Next

            Me.Validate()
            Me.ALLWALKSBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Chrisbarton_grg10DataSet)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorDeleteItem3_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem3.Click
        MsgBox("1 record deleted - Save to confirm or Reload to cancel")
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        MsgBox("1 record deleted - Save to confirm or Reload to cancel")
    End Sub

    Private Sub BindingNavigatorDeleteItem2_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem2.Click
        MsgBox("1 record deleted - Save to confirm or Reload to cancel")
    End Sub

    Private Sub BindingNavigatorDeleteItem1_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem1.Click
        MsgBox("1 record deleted - Save to confirm or Reload to cancel")
    End Sub
End Class


