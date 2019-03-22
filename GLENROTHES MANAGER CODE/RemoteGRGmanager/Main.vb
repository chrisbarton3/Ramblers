Imports System.IO, System.Data, System.Net, System.Text.RegularExpressions

Public Class frmMain

    Dim version As String = "6.0"

#Region "DECLARATIONS"
    Dim appPath As String = My.Application.Info.DirectoryPath
    Dim datelist(52) As Date
    Dim ftpurl As String = My.Settings.ftpurl
    Dim basedir As String = My.Settings.basedir
    Dim user As String = My.Settings.ftpuser
    Dim pword As String = My.Settings.ftppword
    Dim oFTP As New FTPutility(ftpurl, user, pword)
    Public additem As Boolean = False 'marker for adding new walk
    Public addedWalk As String 'insert new walk name from entry form

#End Region

#Region "TABS"

    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem
        TabControl1.Alignment = TabAlignment.Left
        TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        Dim g As Graphics = e.Graphics
        Dim colProg As Color = Color.FromArgb(235, 235, 255)
        Dim colDraft As Color = Color.FromArgb(245, 245, 255)
        Dim colFP As Color = Color.FromArgb(235, 215, 255)
        Dim colWalk As Color = Color.FromArgb(180, 250, 190)
        Dim colLead As Color = Color.FromArgb(150, 240, 160)
        Dim colUtil As Color = Color.FromArgb(211, 211, 211)
        Dim _TextBrush As Brush
        Dim BackBrush As SolidBrush
        'Dim blankbrush As Brush
        ' Get the item from the collection.
        Dim _TabPage As TabPage = TabControl1.TabPages(e.Index)

        ' Get the real bounds for the tab rectangle.
        Dim _TabBounds As Rectangle = TabControl1.GetTabRect(e.Index)

        If (e.State = DrawItemState.Selected) And (e.Index > 0) Then
            ' Draw a different background color, and don't paint a focus rectangle.
            _TextBrush = New SolidBrush(Color.White)
            g.FillRectangle(Brushes.LightSteelBlue, e.Bounds)
        Else
            Select Case e.Index

                Case 0, 1 'prog
                    _TextBrush = New System.Drawing.SolidBrush(Color.Black)
                    BackBrush = New System.Drawing.SolidBrush(colProg)
                    g.FillRectangle(BackBrush, e.Bounds)
                Case 2 'draft
                    _TextBrush = New System.Drawing.SolidBrush(Color.Black)
                    BackBrush = New System.Drawing.SolidBrush(colDraft)
                    g.FillRectangle(BackBrush, e.Bounds)
                Case 3 'fp
                    _TextBrush = New System.Drawing.SolidBrush(Color.Black)
                    BackBrush = New System.Drawing.SolidBrush(colFP)
                    g.FillRectangle(BackBrush, e.Bounds)
                Case 4 'walks
                    _TextBrush = New System.Drawing.SolidBrush(Color.Black)
                    BackBrush = New System.Drawing.SolidBrush(colWalk)
                    g.FillRectangle(BackBrush, e.Bounds)
                Case 5 'leader
                    _TextBrush = New System.Drawing.SolidBrush(Color.Black)
                    BackBrush = New System.Drawing.SolidBrush(colLead)
                    g.FillRectangle(BackBrush, e.Bounds)
                Case 6, 7, 8 'utility
                    _TextBrush = New System.Drawing.SolidBrush(Color.Black)
                    BackBrush = New System.Drawing.SolidBrush(colUtil)
                    g.FillRectangle(BackBrush, e.Bounds)
                Case Else 'tools
                    _TextBrush = New System.Drawing.SolidBrush(Color.White)
                    BackBrush = New System.Drawing.SolidBrush(Color.Gray)
                    g.FillRectangle(BackBrush, e.Bounds)
            End Select

        End If

        ' Use our own font.
        Dim _TabFont As New Font("Arial", 13.0, FontStyle.Bold, GraphicsUnit.Pixel)

        ' Draw string. Center the text.
        Dim _StringFlags As New StringFormat With {
            .Alignment = StringAlignment.Center,
            .LineAlignment = StringAlignment.Center
        }
        g.DrawString(_TabPage.Text, _TabFont, _TextBrush, _TabBounds, New StringFormat(_StringFlags))
    End Sub
#End Region

#Region "MAIN"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TabControl1.Enabled = False
        Me.Width = My.Settings.winx
        Me.Height = My.Settings.winy
        'getSettings()
        Me.Text = Me.Text & " - ver " & version
        TabControl1.SelectedIndex() = 0
        RefreshPeriod()
        SetNewProgramme()
    End Sub

    Public Sub GetArchivedWalks()
        Me.ARCHIVED_WALKSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet2.ARCHIVED_WALKS)
    End Sub

    Private Sub SetNewProgramme()
        If Month(Now) > 3 And Month(Now) < 10 Then
            'summer
            rbWinter.Checked = True
            rbThisyear.Checked = True
        Else
            'winter
            rbSummer.Checked = True
            rbNextyear.Checked = True
        End If
        rbThisyear.Text = "This year - " & Year(Now).ToString
        rbNextyear.Text = "Next year - " & (Year(Now) + 1).ToString
    End Sub

    Private Sub tbSettings_Click(sender As Object, e As EventArgs) Handles tbSettings.Click
        Dialog1.ShowDialog()
    End Sub

    Private Sub tsbDraft_Click(sender As Object, e As EventArgs) Handles tsbDraft.Click
        'DraftAJP.Show()
        AJPoutput.ShowDialog()

    End Sub

    Private Sub frmMain_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        My.Settings.winx = Me.Width
        My.Settings.winy = Me.Height

    End Sub

    Private Sub FPPeriodList_SelectedIndexChanged(sender As Object, e As EventArgs)
        bDeletePeriod.Enabled = True
    End Sub


    Private Sub tsbDbaseload_Click(sender As Object, e As EventArgs) Handles tsbDbaseload.Click
        dbaseLoad()

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

    Public Sub dbaseLoad()
        TableAdapterManager.Connection.ConnectionString = "Data Source=MAIN-I7\SQLEXPRESS;Initial Catalog=chrisbarton_grg10;Integrated Security=True"
        wait(True)
        Try

            Me.ALLWALKSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.ALLWALKS)
            Me.LEADERSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.LEADERS)
            Me.PHOTOALBUMTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PHOTOALBUM)
            Me.ALLWALKSTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.ALLWALKS)
            Me.LEADERSTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.LEADERS)
            Me.PROGRAMMETableAdapter.FillBy(Me.Chrisbarton_grg10DataSet.PROGRAMME)
            Me.GROUP_CONTACTSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.GROUP_CONTACTS)
            Me.STROLLERS_WALKTableAdapter.Fill(Me.Chrisbarton_grg10DataSet._STROLLERS_WALK)
            Me.STROLLERS_LEADERTableAdapter.Fill(Me.Chrisbarton_grg10DataSet._STROLLERS_LEADER)
            Me.PUBLISHEDTableAdapter.FillByCurrent(Me.Chrisbarton_grg10DataSet3.PUBLISHED)

            txtCurrentPeriod.Text = GetCurrentPeriod()
            txtCurrentPeriod.Refresh()
            'tbStrollers.Text = getStrollerLeader()
            showDraft()
            TabControl1.Enabled = True
            Me.PROGRAMMEBindingSource.MoveFirst()
            tsbDbaseload.Text = "Reload Database"
            trimProg()
            wait(False)
        Catch ex As Exception
            wait(False)
            MsgBox("Unable to load data. Check internet connection.", MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Function GetCurrentPeriod() As String
        Dim endix As Integer = Chrisbarton_grg10DataSet3.PUBLISHED.Rows.Count - 1
        Return Chrisbarton_grg10DataSet3.PUBLISHED(endix).period
    End Function

    Private Sub trimProg()
        For ix As Integer = 0 To Chrisbarton_grg10DataSet.PROGRAMME.Rows.Count - 1
            With Chrisbarton_grg10DataSet.PROGRAMME(ix)
                .grade = Trim(.grade)
                .dist = Trim(.dist)
                .time = Trim(.time)
                .meet = Trim(.meet)
                .start = Trim(.start)
                .osmap = Trim(.osmap)
                .griref = Trim(.griref)
                .ascent = Trim(.ascent)
                .descr = Trim(.descr)
                .place = Trim(.place)
            End With
        Next
    End Sub


    Private Function setPeriod(sdate As Date) As String
        Try
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

        Catch ex As Exception
            MsgBox(ex.Message)
            Return "no period"
        End Try

    End Function


    Private Sub tsbgrfinder_Click(sender As Object, e As EventArgs) Handles tsbgrfinder.Click
        Dim urlstr As String = "http://www.glenrothesramblers.co.uk/OS/OsGridrefFinder.htm"
        Dim osgrf As New Process
        osgrf.StartInfo.FileName = urlstr
        osgrf.Start()

        'osfinder.Show()
    End Sub

    Private Sub tsbHelp_Click(sender As Object, e As EventArgs) Handles tsbHelp.Click
        osfinder.Show()
        'osfinder.showURL("http://glenrothesramblers.co.uk/Content/Documentation.html")
        osfinder.showHelp()
    End Sub

    Private Sub tsbWalkfinder_Click(sender As Object, e As EventArgs) Handles tsbWalkfinder.Click
        walkfinder.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsbStoppress.Click
        StopPress.Show()

    End Sub

    Private Sub tsbWalkstable_Click(sender As Object, e As EventArgs) Handles tsbWalkstable.Click
        My.Forms.archive.Show()
    End Sub

    Private Sub TSBarchive_Click(sender As Object, e As EventArgs) Handles TSBarchive.Click
        Dim idx As Integer = ALLWALKSBindingSource1.Position
        Me.ARCHIVED_WALKSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet2.ARCHIVED_WALKS)
        With Chrisbarton_grg10DataSet1.ALLWALKS(idx)
            If MsgBox("Archive walk? - " & .NAME, MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
            Try
                Chrisbarton_grg10DataSet2.ARCHIVED_WALKS.AddARCHIVED_WALKSRow(.IDW, .NAME, .TOWN, .DESCRIPTION, .GRADE, .DISTANCE, .MEET_TIME, .START_TIME, .TIME, .START_PLACE, .GRIDREF, .OS_MAP, .CHILDREN, .DOGS, .MAP, .ASCENT, "", "", False)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End With
        Me.Validate()
        Me.ARCHIVED_WALKSBindingSource.EndEdit()
        Me.TableAdapterManager2.UpdateAll(Chrisbarton_grg10DataSet2)
        ALLWALKSBindingSource1.RemoveCurrent()
        Me.Validate()
        Me.ALLWALKSBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Chrisbarton_grg10DataSet1)
        dbaseLoad()
    End Sub

#End Region

#Region "NEW PROGRAMME"


    Private Sub bNewProgramme_Click(sender As Object, e As EventArgs) Handles bNewProgramme.Click
        Dim newPeriod As String = tbNPseason.Text & " - " & tbNPyear.Text
        If MsgBox("Make new period for " & newPeriod & "?" & vbCrLf & "This will delete current programme.", MsgBoxStyle.OkCancel) <> MsgBoxResult.Ok Then
            Exit Sub
        End If
        Me.PROGRAMMETableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PROGRAMME)
        Dim fpcnt As Integer = Chrisbarton_grg10DataSet.PROGRAMME.Rows.Count - 1
        For ix As Integer = 0 To fpcnt
            Chrisbarton_grg10DataSet.PROGRAMME.Rows(ix).Delete()
        Next
        Me.Validate()
        Me.PROGRAMMEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Chrisbarton_grg10DataSet)
        Me.PROGRAMMETableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PROGRAMME)
        TabControl1.SelectedIndex() = 1
        NewProgramme()
    End Sub

    Private Sub NewProgramme()
        Dim np As Prog_period = New Prog_period(tbNPseason.Text, tbNPyear.Text)
        Dim pd As String = tbNPseason.Text & " - " & tbNPyear.Text
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
                        .AddPROGRAMMERow(stname, stdescr, "", stgrd, stdist, sttim, stmeet, ststrt, stpl, stos, stgr, stch, stdg, stleader, stphon, steml, "", pd, dt)
                    Else
                        .AddPROGRAMMERow(nc, "", "", "", "", "", "", "", "", "", "", False, False, nc, "", "", "", pd, dt)
                    End If

                End With
            Next
            MsgBox("Check programme on design page, then SAVE to confirm changes.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub RefreshPeriod()
        If rbSummer.Checked Then
            tbNPseason.Text = "Summer"
        Else
            tbNPseason.Text = "Winter"
        End If

        If rbThisyear.Checked Then
            tbNPyear.Text = Year(Now).ToString
        Else
            tbNPyear.Text = (Year(Now) + 1).ToString
        End If
    End Sub


    Private Sub rbWinter_CheckedChanged(sender As Object, e As EventArgs) Handles rbWinter.CheckedChanged
        RefreshPeriod()
    End Sub

    Private Sub rbThisyear_CheckedChanged(sender As Object, e As EventArgs) Handles rbThisyear.CheckedChanged
        RefreshPeriod()
    End Sub

    Private Sub unhideWalks()
        Try
            For ix As Integer = 0 To Chrisbarton_grg10DataSet1.ALLWALKS.Rows.Count - 1
                With Chrisbarton_grg10DataSet1.ALLWALKS(ix)
                    If .NAME <> "Strollers Walk" And .NAME <> "- none chosen" Then
                        .HIDDEN = False
                    End If
                End With
            Next

            Me.Validate()
            Me.ALLWALKSBindingSource1.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.Chrisbarton_grg10DataSet1)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "PROGRAMME"

    Private Sub unNullProgramme()
        Me.PROGRAMMETableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PROGRAMME)
        Try
            For ix As Integer = 0 To Chrisbarton_grg10DataSet.PROGRAMME.Rows.Count - 1
                With Chrisbarton_grg10DataSet.PROGRAMME(ix)
                    If .IsascentNull Then .ascent = ""
                    If .IsdistNull Then .dist = ""
                    If .IsemailNull Then .email = ""
                    If .IsgradeNull Then .grade = ""
                    If .IsgrirefNull Then .griref = ""
                    If .IsmeetNull Then .meet = ""
                    If .IsnoteNull Then .note = ""
                    If .IsosmapNull Then .osmap = ""
                    If .IsperiodNull Then .period = ""
                    If .IsplaceNull Then .place = ""
                    If .IsstartNull Then .start = ""
                    If .IstimeNull Then .time = ""
                    If .IsdescrNull Then .descr = ""
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Validate()
        Me.PROGRAMMEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Chrisbarton_grg10DataSet)
        Me.PROGRAMMETableAdapter.FillBy(Me.Chrisbarton_grg10DataSet.PROGRAMME)
    End Sub

    Private Sub bSaveProgramme_Click(sender As Object, e As EventArgs) Handles bSaveProgramme.Click
        saveProgramme()
    End Sub

    Private Sub saveProgramme()
        'CleanupProgramme() 'remove non printing chars from entries
        Try
            wait(True)
            Me.Validate()
            Dim pos As Integer = PROGRAMMEBindingSource.Position
            Me.PROGRAMMEBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Chrisbarton_grg10DataSet)
            wait(False)
            MsgBox("Changes saved to database")
            Me.PROGRAMMETableAdapter.FillBy(Me.Chrisbarton_grg10DataSet.PROGRAMME)
            PROGRAMMEBindingSource.Position = pos
        Catch ex As Exception
            wait(False)
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LEADERComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LEADERComboBox.SelectedIndexChanged
        Try
            Dim gridix As Integer = PROGRAMMEBindingSource.Position
            Dim selix As Integer = LEADERComboBox.SelectedIndex
            Dim sleader As String = Chrisbarton_grg10DataSet.LEADERS(selix).LEADER
            If MsgBox("Change Leader from " & LeaderTB.Text & vbCrLf & "to " & sleader & " ?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
            LeaderTB.Text = sleader
            With Chrisbarton_grg10DataSet.LEADERS(selix)
                Chrisbarton_grg10DataSet.PROGRAMME(gridix).leader = sleader
                Chrisbarton_grg10DataSet.PROGRAMME(gridix).phone = .PHONE
                Chrisbarton_grg10DataSet.PROGRAMME(gridix).email = .EMAIL

            End With

        Catch ex As Exception

        End Try

    End Sub


    Private Sub bProgUndo_Click(sender As Object, e As EventArgs) Handles bProgUndo.Click, tsbUndoProg.Click
        Try
            PROGRAMMETableAdapter.FillBy(Chrisbarton_grg10DataSet.PROGRAMME)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub bStrollers_Click(sender As Object, e As EventArgs) Handles bStrollers.Click
        Try
            PROGRAMMETableAdapter.Fill(Chrisbarton_grg10DataSet.PROGRAMME)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub NAMEComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NAMEComboBox.SelectedIndexChanged
        If additem Then Exit Sub
        Try
            Dim gridix As Integer = PROGRAMMEBindingSource.Position
            Dim selix As Integer = NAMEComboBox.SelectedIndex
            With Chrisbarton_grg10DataSet.ALLWALKS(selix)
                Dim swalk As String = .NAME
                Dim oldwalk As String = WALKtb.Text
                If MsgBox("Change walk from " & WALKtb.Text & vbCrLf & "to " & swalk & " ?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
                WALKtb.Text = swalk
                Chrisbarton_grg10DataSet.PROGRAMME(gridix).walk = swalk
                Chrisbarton_grg10DataSet.PROGRAMME(gridix).grade = .GRADE
                Chrisbarton_grg10DataSet.PROGRAMME(gridix).dist = .DISTANCE
                Chrisbarton_grg10DataSet.PROGRAMME(gridix).descr = .DESCRIPTION
                Chrisbarton_grg10DataSet.PROGRAMME(gridix).ascent = .ASCENT
                Chrisbarton_grg10DataSet.PROGRAMME(gridix).time = .TIME
                Chrisbarton_grg10DataSet.PROGRAMME(gridix).meet = .MEET_TIME
                Chrisbarton_grg10DataSet.PROGRAMME(gridix).start = .START_TIME
                Chrisbarton_grg10DataSet.PROGRAMME(gridix).place = .START_PLACE
                Chrisbarton_grg10DataSet.PROGRAMME(gridix).osmap = .OS_MAP
                Chrisbarton_grg10DataSet.PROGRAMME(gridix).griref = .GRIDREF
                Chrisbarton_grg10DataSet.PROGRAMME(gridix).kids = .CHILDREN
                Chrisbarton_grg10DataSet.PROGRAMME(gridix).dogs = .DOGS
                unHideWalk(oldwalk)
                hideWalk(swalk)

            End With

        Catch ex As Exception

        End Try

    End Sub

    Private Sub llChangeDate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llChangeDate.LinkClicked
        If isDateCurrent(dtpDesign.Value) Then
            ItemdateTextBox.Text = dtpDesign.Value.ToShortDateString
            Try
                Dim pos As Integer = PROGRAMMEBindingSource.Position
                Chrisbarton_grg10DataSet.PROGRAMME(pos).itemdate = dtpDesign.Value.ToShortDateString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Invalid date for current period!")
        End If
        PROGRAMMEDataGridView.Refresh()
    End Sub

    Private Function isDateCurrent(sdate As Date) As Boolean
        Try
            Dim syear As String = txtCurrentPeriod.Text.Substring(0, 4)
            Dim nextyr As Integer = CInt(syear) + 1
            If txtCurrentPeriod.Text.Contains("Summer") Then
                If sdate < CDate("01/04/" & syear) Or sdate > CDate("30/09/" & syear) Then
                    Return False
                End If
            ElseIf txtCurrentPeriod.Text.Contains("Winter") Then
                If sdate < CDate("01/10/" & syear) Or sdate > CDate("31/03/" & nextyr.ToString) Then
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            Return True
        End Try

    End Function

    Private Sub bAddDate_Click(sender As Object, e As EventArgs) Handles bAddDate.Click
        getdate.Show()
    End Sub

    Public Sub addNewDate(sdate As Date)
        Dim newdate As String = sdate.ToShortDateString
        Try
            PROGRAMMETableAdapter.Fill(Chrisbarton_grg10DataSet.PROGRAMME)
            Chrisbarton_grg10DataSet.PROGRAMME.AddPROGRAMMERow("- none chosen", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", False, False, "- none chosen", " ", " ", " ", Periodtb.Text, newdate)
            MsgBox("New item created for date: " & newdate)
            PROGRAMMEBindingSource.MoveLast()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub hideWalk(name As String)
        Try
            For ix As Integer = 0 To Chrisbarton_grg10DataSet1.ALLWALKS.Rows.Count - 1
                With Chrisbarton_grg10DataSet1.ALLWALKS(ix)
                    If .NAME = name Then .HIDDEN = True
                End With
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub unHideWalk(name As String)
        Try
            For ix As Integer = 0 To Chrisbarton_grg10DataSet1.ALLWALKS.Rows.Count - 1
                With Chrisbarton_grg10DataSet1.ALLWALKS(ix)
                    If .NAME <> "Strollers Walk" And .NAME <> "- none chosen" Then
                        If .NAME = name Then .HIDDEN = False
                    End If

                End With
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bDeleterow_Click(sender As Object, e As EventArgs) Handles bDeleterow.Click, tsbDeleteItem.Click
        Try
            Dim row As Integer = PROGRAMMEDataGridView.SelectedRows(0).Index
            PROGRAMMEDataGridView.Rows.RemoveAt(row)
            If MsgBox("Row deleted - Cancel to Undo", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                PROGRAMMETableAdapter.Fill(Chrisbarton_grg10DataSet.PROGRAMME)
                PROGRAMMETableAdapter.FillBy(Chrisbarton_grg10DataSet.PROGRAMME)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub bNostrollers_Click(sender As Object, e As EventArgs) Handles bNostrollers.Click
        Try
            PROGRAMMETableAdapter.FillBy(Chrisbarton_grg10DataSet.PROGRAMME)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub bNewWalkItem_Click(sender As Object, e As EventArgs) Handles bNewWalkItem.Click
        Dim newwalkpos As Integer
        Try
            additem = False
            NewWalk.ShowDialog()
            If additem Then

                For wix As Integer = 0 To Chrisbarton_grg10DataSet.ALLWALKS.Rows.Count - 1
                    With Chrisbarton_grg10DataSet.ALLWALKS(wix)
                        If .NAME = addedWalk Then
                            newwalkpos = wix
                        End If
                    End With

                Next

            End If
            additem = False
            NAMEComboBox.SelectedIndex = newwalkpos
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub refreshProg()
        Try
            Dim rc As Integer = Chrisbarton_grg10DataSet.PROGRAMME.Rows.Count - 1
            With PROGRAMMEBindingSource
                If .Position > 0 Then
                    .MovePrevious()
                    .MoveNext()
                Else
                    .MoveNext()
                    .MovePrevious()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DetailsPage_Enter(sender As Object, e As EventArgs) Handles DetailsPage.Enter
        refreshProg()
    End Sub

    Private Sub llShowOS_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llShowOS.LinkClicked
        Try
            Dim gr As String = Grireftb.Text
            If Not gr = "" Then
                Dim urlstr As String = "www.glenrothesramblers.co.uk/OS/ShowOSgridref.htm?gr=" & gr
                Dim osgrf As New Process
                osgrf.StartInfo.FileName = urlstr
                osgrf.Start()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub llEvent_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llEvent.LinkClicked
        Dim ix As Integer = PROGRAMMEBindingSource.Position
        Chrisbarton_grg10DataSet.PROGRAMME(ix).grade = "EVENT"
        PROGRAMMEDataGridView.Refresh()
    End Sub

    Private Sub ItemdateTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ItemdateTextBox1.TextChanged
        Dim pos As Integer = PROGRAMMEBindingSource.Position
        Dim thisdate As Date = Chrisbarton_grg10DataSet.PROGRAMME(pos).itemdate
        ldayofweek.Text = thisdate.DayOfWeek.ToString
    End Sub

    Private Sub Descrtb_TextChanged(sender As Object, e As EventArgs) Handles Descrtb.TextChanged
        Dim ch As Integer = Descrtb.Text.Length
        LDescrCnt.Text = ch & " chars"
        freetxtcnt()
    End Sub

    Private Sub Placetb_TextChanged(sender As Object, e As EventArgs) Handles Placetb.TextChanged
        Dim ch As Integer = Placetb.Text.Length
        Lstartcnt.Text = ch & " chars"
        freetxtcnt()
    End Sub

    Private Sub freetxtcnt()
        Dim ch As Integer = NoteTextBox1.Text.Length + Placetb.Text.Length + Descrtb.Text.Length
        Ltotalcharcnt.Text = ch & " total free text chars"
    End Sub

    Private Sub NoteTextBox1_TextChanged(sender As Object, e As EventArgs) Handles NoteTextBox1.TextChanged
        Dim ch As Integer = NoteTextBox1.Text.Length
        Lnotecnt.Text = ch & " chars"
        freetxtcnt()
    End Sub


#End Region

#Region "PUBLICATION"

    Private Sub bPrePublish_Click(sender As Object, e As EventArgs) Handles bPrePublish.Click
        tbPublish.Text = ""
        unNullProgramme()
        Try
            Dim lastrow As Integer = Chrisbarton_grg10DataSet.PROGRAMME.Rows.Count - 1
            For row As Integer = 0 To lastrow
                With Chrisbarton_grg10DataSet.PROGRAMME(row)
                    Try
                        'add row to final programme
                        If .walk <> "- none chosen" And .leader <> "- none chosen" Then
                            Chrisbarton_grg10DataSet3.PUBLISHED.AddPUBLISHEDRow(.itemdate, .period, .walk, .grade, .descr, .ascent, .dist, .time, .meet, .start, .place, .osmap, .griref, SetKids(.kids), SetDogs(.dogs), .leader, .phone, .email, .note)
                            tbPublish.AppendText("Published " & .itemdate.ToShortDateString & .walk & vbCrLf)
                        Else
                            tbPublish.AppendText("NOT PUBLISHED " & .itemdate.ToShortDateString & .walk & vbCrLf)
                        End If

                    Catch ex As Exception
                        tbPublish.AppendText("NOT PUBLISHED " & .itemdate.ToShortDateString & .walk & vbCrLf)
                        MsgBox(ex.Message)
                    End Try
                End With
            Next
            wait(False)

            MsgBox("Pre-publication check completed without error. Check any dates marked as NOT PUBLISHED")
        Catch ex As Exception
            wait(False)
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub bPublish_Click(sender As Object, e As EventArgs) Handles bPublish.Click
        If MsgBox("This will add current programme to Final Programme table" & vbCrLf & "When saved, It will appear on the website. If not complete, press Cancel",
                  MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        wait(True)
        setWalkHistory()
        tbPublish.Text = ""
        Me.PROGRAMMETableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PROGRAMME)
        Try
            Dim lastrow As Integer = Chrisbarton_grg10DataSet.PROGRAMME.Rows.Count - 1
            For row As Integer = 0 To lastrow
                With Chrisbarton_grg10DataSet.PROGRAMME(row)
                    Try
                        'add row to final programme
                        If .walk <> "- none chosen" And .leader <> "- none chosen" Then
                            Chrisbarton_grg10DataSet3.PUBLISHED.AddPUBLISHEDRow(.itemdate, .period, .walk, .grade, .descr, .ascent, .dist, .time, .meet, .start, .place, .osmap, .griref, SetKids(.kids), SetDogs(.dogs), .leader, .phone, .email, .note)
                            tbPublish.AppendText("Published " & .itemdate.ToShortDateString & .walk & vbCrLf)
                        Else
                            tbPublish.AppendText("NOT PUBLISHED " & .itemdate.ToShortDateString & .walk & vbCrLf)
                        End If

                    Catch ex As Exception
                        tbPublish.AppendText("NOT PUBLISHED " & .itemdate.ToShortDateString & .walk & vbCrLf)
                        MsgBox(ex.Message)
                    End Try
                End With
            Next
            wait(False)
            TabControl1.SelectedIndex() = 4
            MsgBox("Publication Complete - check result then" & vbCrLf & "save FinalProgramme table to update database." & vbCrLf & "If incorrect - press Reload to undo.")
        Catch ex As Exception
            wait(False)
            MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub setWalkHistory()
        wait(True)
        Try
            For row As Integer = 0 To Chrisbarton_grg10DataSet1.ALLWALKS.Rows.Count - 1
                With Chrisbarton_grg10DataSet1.ALLWALKS(row)
                    If .NAME <> "Strollers walk" Or .NAME <> "EVENT" Or .NAME <> "- none chosen" Then
                        For pr As Integer = 0 To Chrisbarton_grg10DataSet.PROGRAMME.Rows.Count - 1
                            If Chrisbarton_grg10DataSet.PROGRAMME(pr).walk = .NAME Then
                                .LASTLEADER = Chrisbarton_grg10DataSet.PROGRAMME(pr).leader
                                .LASTDATE = Chrisbarton_grg10DataSet.PROGRAMME(pr).itemdate

                            End If
                        Next
                    End If

                End With
            Next
            MsgBox("History updated for Current Programme" & vbCrLf & "Save Walks table to confirm changes")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        wait(False)
    End Sub


#End Region

#Region "WALKS"

    Private Sub addNew_Click(sender As Object, e As EventArgs) Handles addNew.Click
        NewWalk.ShowDialog()
        additem = False
    End Sub

    Private Sub selectWalk(ByVal swalk As String)
        Try
            For wix As Integer = 0 To ALLWALKSDataGridView.Rows.Count - 1
                If ALLWALKSDataGridView.Rows(wix).Cells(1).Value = swalk Then
                    ALLWALKSBindingSource1.MoveFirst()
                    For i As Integer = 0 To wix - 1
                        ALLWALKSBindingSource1.MoveNext()
                    Next
                    Exit Sub
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub saveWALKS_Click(sender As Object, e As EventArgs) Handles saveWALKS.Click
        If IDWTextBox.Text = "" Then
            MsgBox("ID must have a unique value set")
            Exit Sub
        End If

        If isDuplicate() Then
            MsgBox("There is already a walk with this name - NOT SAVED!")
            Exit Sub
        End If
        Try
            wait(True)
            Dim pos As Integer = ALLWALKSBindingSource1.Position
            Me.Validate()
            Me.ALLWALKSBindingSource1.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Chrisbarton_grg10DataSet1)
            wait(False)
            MsgBox("Changes saved to database")
            Me.ALLWALKSTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.ALLWALKS)
            Me.ALLWALKSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.ALLWALKS)
            ALLWALKSBindingSource1.Position = pos
        Catch ex As Exception
            wait(False)
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function isDuplicate() As Boolean
        Try
            Dim istr As String = IDWTextBox.Text
            Dim wname As String = NAMETextBox.Text
            For ix As Integer = 0 To ALLWALKSDataGridView.Rows.Count - 1
                With ALLWALKSDataGridView.Rows(ix)
                    If .Cells(0).Value <> istr Then
                        If .Cells(1).Value = wname Then
                            Return True
                        End If
                    End If
                End With
            Next
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Private Sub tsb3Undo_Click(sender As Object, e As EventArgs) Handles tsb3Undo.Click
        Me.ALLWALKSTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.ALLWALKS)

    End Sub

    Private Sub BindingNavigatorDeleteItem1_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem1.Click
        If MsgBox("Deleting selected walk", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        ALLWALKSBindingSource1.RemoveCurrent()
    End Sub

    Private Sub NAMETextBox_Click(sender As Object, e As EventArgs) Handles NAMETextBox.Click
        If NAMETextBox.ReadOnly = True Then
            MsgBox("Unable to edit selected Walk Name" & vbCrLf & "If name change required, deselect walk from programme first")
        End If
    End Sub

    Private Sub CHILDRENCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CHILDRENCheckBox.CheckedChanged
        If CHILDRENCheckBox.CheckState <> CheckState.Checked Then CHILDRENCheckBox.CheckState = CheckState.Unchecked
    End Sub

    Private Sub DOGSCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles DOGSCheckBox.CheckedChanged
        If DOGSCheckBox.CheckState <> CheckState.Checked Then DOGSCheckBox.CheckState = CheckState.Unchecked
    End Sub

    Private Sub llShowstart_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llShowstart.LinkClicked
        Try
            Dim gr As String = GRIDREFTextBox.Text
            If Not gr = "" Then
                Dim urlstr As String = "www.glenrothesramblers.co.uk/OS/ShowOSgridref.htm?gr=" & gr
                Dim osgrf As New Process
                osgrf.StartInfo.FileName = urlstr
                osgrf.Start()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub llShowmap_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llShowmap.LinkClicked
        If MAPTextBox.Text <> "" Then
            Dim urlRoute As String = "www.glenrothesramblers.co.uk/Maps/" & MAPTextBox.Text
            osfinder.Show()
            osfinder.showURL(urlRoute)
        End If

    End Sub

#End Region

#Region "LEADERS"

    Private Sub bSaveleader_Click(sender As Object, e As EventArgs) Handles tsbSaveleader.Click
        Try
            wait(True)
            Me.Validate()
            Me.LEADERSBindingSource1.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.Chrisbarton_grg10DataSet1)
            MsgBox("Changes saved to database")
            Me.LEADERSTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.LEADERS)
            wait(False)
        Catch ex As Exception
            wait(False)
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tsbUndoleader_Click(sender As Object, e As EventArgs) Handles tsbUndoleader.Click
        Me.LEADERSTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.LEADERS)
    End Sub

    Private Sub EMAILLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles EMAILLinkLabel.LinkClicked
        Dim indexurl As String = "mailto:" & EMAILLinkLabel.Text
        System.Diagnostics.Process.Start(indexurl)
    End Sub

    Private Sub bGroupEmail_Click(sender As Object, e As EventArgs) Handles bGroupEmail.Click
        Dim emlstr = "mailto:"
        For ix As Integer = 0 To LEADERSDataGridView.Rows.Count - 1
            Try
                emlstr = emlstr & LEADERSDataGridView.Rows(ix).Cells(3).Value.ToString & "; "
            Catch ex As Exception

            End Try

        Next

        System.Diagnostics.Process.Start(emlstr)
    End Sub

#End Region


#Region "PHOTOALBUM"

    Private Sub tsbGetPhotos_Click(sender As Object, e As EventArgs)
        addphoto.Show()
    End Sub


    Private Sub FilenameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FilenameTextBox.TextChanged
        Dim urlPhoto As String = "www.glenrothesramblers.co.uk/Galleries/" & DirectoryTextBox.Text & "/" & FilenameTextBox.Text
        currentPhoto.Navigate(urlPhoto)
    End Sub

    Private Sub tsbUndoAlbum_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click
        Me.PHOTOALBUMTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PHOTOALBUM)
    End Sub


    Public Sub photoAlbumSave()
        Me.Validate()
        Me.PHOTOALBUMBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Chrisbarton_grg10DataSet)
    End Sub

    Private Sub tsbSaveAlbum_Click(sender As Object, e As EventArgs) Handles tsbSaveAlbum.Click
        wait(True)
        photoAlbumSave()
        wait(False)
    End Sub

    Private Sub BindingNavigatorDeleteItem5_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem5.Click
        deletePhoto()
    End Sub

    Private Sub tsbPhotos_Click(sender As Object, e As EventArgs) Handles tsbPhotos.Click
        addphoto.Show()
    End Sub


#End Region

#Region "DRAFT"

    Private Sub showDraft()

        Dim pcnt As Integer = Chrisbarton_grg10DataSet.PROGRAMME.Rows.Count
        If pcnt = 0 Then Exit Sub

        tbDraft.Text = "DRAFT PROGRAMME FOR PERIOD " & Periodtb.Text & vbCrLf & vbCrLf
        For ix As Integer = 0 To pcnt - 1
            With Chrisbarton_grg10DataSet.PROGRAMME(ix)
                If .walk <> "Strollers Walk" Then
                    Try
                        tbDraft.AppendText(.itemdate & vbCrLf & "Walk: ")
                        If .walk = "- none chosen" Then
                            tbDraft.AppendText(.walk & vbCrLf)
                        Else
                            If (Not .grade.Contains("EVENT")) Then
                                tbDraft.AppendText(.walk & "   Grade: " & .grade & "   Miles:" & .dist & vbCrLf)
                                tbDraft.AppendText("Start from: " & .place & vbCrLf)
                            Else
                                tbDraft.AppendText(.walk & " -  " & .grade & vbCrLf)
                            End If

                        End If

                        tbDraft.AppendText("Leader: " & .leader & "    " & .phone & "   " & .email & vbCrLf)
                        If .descr <> "" Then
                            tbDraft.AppendText(.descr & vbCrLf)
                        End If

                    Catch ex As Exception

                    End Try
                End If
                tbDraft.AppendText(vbCrLf)
            End With

        Next

    End Sub

    Private Sub bClip_Click(sender As Object, e As EventArgs) Handles bClip.Click
        Windows.Clipboard.SetText(tbDraft.Text)
    End Sub

    Private Sub DraftPage_Enter(sender As Object, e As EventArgs) Handles DraftPage.Enter
        showDraft()
    End Sub
#End Region

#Region "MAP MANAGER"

    Private Sub llShowMap2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llShowMap2.LinkClicked
        If MAPTextBox1.Text <> "" Then
            Dim urlRoute As String = "www.glenrothesramblers.co.uk/Maps/" & MAPTextBox1.Text
            osfinder.Show()
            osfinder.showURL(urlRoute)
        End If
    End Sub

    Private Sub tsbSavemap_Click(sender As Object, e As EventArgs) Handles tsbSavemap.Click
        saveMaps()

    End Sub

    Private Sub saveMaps()
        Try
            wait(True)
            Dim pos As Integer = ALLWALKSBindingSource1.Position
            Me.Validate()
            Me.ALLWALKSBindingSource1.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Chrisbarton_grg10DataSet1)
            MsgBox("Changes saved to database")
            Me.ALLWALKSTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.ALLWALKS)
            Me.ALLWALKSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.ALLWALKS)
            ALLWALKSBindingSource1.Position = pos
            wait(False)
        Catch ex As Exception
            wait(False)
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Function MapName(id As String, walk As String) As String
        Dim nm As String = id & walk
        nm = MakeAlphanumeric(nm)
        If nm.Length > 25 Then nm = nm.Substring(0, 25)
        nm = nm & ".jpg"
        Return nm
    End Function

    Private Sub tsbAddMap_Click(sender As Object, e As EventArgs) Handles tsbAddMap.Click
        dlg.InitialDirectory = My.Settings.defaultfolder
        dlg.DefaultExt = ".jpg" ' Default file extension
        dlg.Filter = "images (.jpg)|*.jpg|images (.JPG)| *.JPG" ' Filter files by extension

        ' Show open file dialog box
        Dim result As Boolean = dlg.ShowDialog()

        ' Process open file dialog box results
        If result = True Then
            ' Open document
            tbFilename.Text = dlg.FileName
            Try
                My.Settings.defaultfolder = Path.GetDirectoryName(tbFilename.Text)
            Catch ex As Exception

            End Try
        Else
            Exit Sub
        End If
        pbMap.Image = New Bitmap(tbFilename.Text)
        MAPTextBox1.Text = My.Computer.FileSystem.GetFileInfo(tbFilename.Text).Name
        bInsertMap.Visible = True
    End Sub


    Private Function isMapUnused(map As String) As Boolean
        For id As Integer = 0 To Chrisbarton_grg10DataSet1.ALLWALKS.Rows.Count - 1
            With Chrisbarton_grg10DataSet1.ALLWALKS(id)
                If .MAP.Contains(map) Then Return False
            End With
        Next
        Return True
    End Function

    Private Sub tsbbMapsUndo_Click(sender As Object, e As EventArgs) Handles tsbbMapsUndo.Click
        dbaseLoad()
        pbMap.Image = Nothing
        bInsertMap.Visible = False
        tbFilename.Text = ""
    End Sub

    Private Sub GetMapCount()
        Dim walktot As Integer = Chrisbarton_grg10DataSet1.ALLWALKS.Rows.Count
        Dim mapcount As Integer, gpxcount As Integer
        For ix As Integer = 0 To walktot - 1
            With Chrisbarton_grg10DataSet1.ALLWALKS(ix)
                If Not IsDBNull(.MAP) Then
                    If .MAP <> "" Then mapcount += 1
                End If
                If Not IsDBNull(.GPX) Then
                    If .GPX <> "" Then gpxcount += 1
                End If
            End With
        Next
        Lmapcount.Text = mapcount & " / " & walktot
        Lgpxcount.Text = gpxcount & " / " & walktot
    End Sub

    Private Sub RoutePage_Enter(sender As Object, e As EventArgs) Handles RoutePage.Enter
        GetMapCount()
    End Sub


#End Region

#Region "GROUP CONTACTS"

    Private Sub tsbSaveContacts_Click(sender As Object, e As EventArgs) Handles tsbSaveContacts.Click
        saveContacts()
    End Sub

    Private Sub tsbGetContactPhoto_Click(sender As Object, e As EventArgs) Handles tsbGetContactPhoto.Click
        dlg.InitialDirectory = My.Settings.defaultfolder
        dlg.DefaultExt = ".jpg" ' Default file extension
        dlg.Filter = "images (.jpg)|*.jpg|images (.JPG)| *.JPG" ' Filter files by extension

        ' Show open file dialog box
        Dim result As Boolean = dlg.ShowDialog()

        ' Process open file dialog box results
        If result = True Then
            ' Open document
            llContactPhoto.Text = dlg.FileName

        Else
            Exit Sub
        End If
        pbContact.Image = New Bitmap(llContactPhoto.Text)
        PhotoTextBox.Text = My.Computer.FileSystem.GetFileInfo(llContactPhoto.Text).Name
        bUploadContact.Visible = True
    End Sub

    Private Sub tsbUndoContact_Click(sender As Object, e As EventArgs) Handles tsbUndoContact.Click
        wait(True)
        dbaseLoad()
        pbContact.Image = Nothing
        bUploadContact.Visible = False
        llContactPhoto.Text = ""
        wait(False)
    End Sub

    Private Sub saveContacts()
        wait(True)
        Try
            Me.Validate()
            Me.GROUP_CONTACTSBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Chrisbarton_grg10DataSet)
            wait(False)
            MsgBox("Changes saved to database")
        Catch ex As Exception
            wait(False)
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub PhotoTextBox_TextChanged(sender As Object, e As EventArgs) Handles PhotoTextBox.TextChanged
        If PhotoTextBox.Text <> "" Then
            Dim urlRoute As String = "www.glenrothesramblers.co.uk/Images/" & PhotoTextBox.Text
            contactphoto.Navigate(urlRoute)
        Else
            PhotoTextBox.Text = "blankphoto.jpg"
            Dim urlRoute As String = "www.glenrothesramblers.co.uk/Images/blankphoto.jpg"
            contactphoto.Navigate(urlRoute)
        End If

    End Sub


#End Region

#Region "TOOLS"

    Private Sub CBfiletoUpload_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBfiletoUpload.SelectedIndexChanged
        Dim ix As Integer = CBfiletoUpload.SelectedIndex
        Select Case ix
            Case < 0
                TBtargetfile.Text = ""
                LUploadType.Text = ""
                Exit Sub
            Case 0
                TBtargetfile.Text = "Newsletter/CurrentNewsletter.pdf"
                LUploadType.Text = "Upload current newsletter"
            Case 1
                TBtargetfile.Text = "Content/minutes-last-meeting.pdf"
                LUploadType.Text = "Upload latest minutes"
            Case 2
                TBtargetfile.Text = "Images/home-photo.jpg"
                LUploadType.Text = "Upload new home page photo"
            Case 3
                TBtargetfile.Text = "Content/SummerAJP.pdf"
                LUploadType.Text = "Upload new Summer AJP"
            Case 4
                TBtargetfile.Text = "Content/WinterAJP.pdf"
                LUploadType.Text = "Upload new Winter AJP"
            Case 5
                TBtargetfile.Text = "Content/Expenses_Form.pdf"
                LUploadType.Text = "Update expenses form"
            Case 6
                TBtargetfile.Text = "Content/Incident_Report_form.pdf"
                LUploadType.Text = "Update incident report form"
            Case 7
                TBtargetfile.Text = "Content/Walk_Participant_Record_Sheet.pdf"
                LUploadType.Text = "Update walk participants sheet"
            Case Else
                TBtargetfile.Text = ""
                LUploadType.Text = ""
                Exit Sub
        End Select
    End Sub

    Private Sub OpenUploadFile(filter As String)
        Dim sfilter As String
        If filter = "pdf" Then
            sfilter = "PDF files|*.pdf"
        ElseIf filter = "jpg" Then
            sfilter = "JPEG files|*.jpg"
        Else
            sfilter = "All files|*.*"
        End If

        dlg.InitialDirectory = My.Settings.defaultfolder
        dlg.Filter = sfilter

        ' Show open file dialog box
        Dim result As Boolean = dlg.ShowDialog()

        ' Process open file dialog box results
        If result = True Then
            ' Open document
            tbUploadFile.Text = dlg.FileName
        Else
            Exit Sub
        End If
    End Sub


    Private Sub bDeletePeriod_Click(sender As Object, e As EventArgs) Handles bDeletePeriod.Click
        If MsgBox("this will delete all items more than a week old." & "Continue?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub

        Try
            Dim current As Date = Now
            current = current.AddDays(-7)
            Me.PUBLISHEDTableAdapter.Fill(Chrisbarton_grg10DataSet3.PUBLISHED)
            Dim fpcnt As Integer = Chrisbarton_grg10DataSet3.PUBLISHED.Rows.Count - 1
            For ix As Integer = 0 To fpcnt
                If Chrisbarton_grg10DataSet3.PUBLISHED(ix).itemdate < current Then
                    Chrisbarton_grg10DataSet3.PUBLISHED.Rows(ix).Delete()
                End If
            Next
            wait(False)
            TabControl1.SelectedIndex() = 3
            MsgBox("All old dates deleted from PUBLISHED table" & vbCr & "Press SAVE to confirm delete")

        Catch ex As Exception
            wait(False)
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub bGetNewsletter_Click(sender As Object, e As EventArgs) Handles bGetUploadFile.Click
        Dim filter As String
        If CBfiletoUpload.SelectedIndex < 0 Then
            Exit Sub
        ElseIf CBfiletoUpload.SelectedIndex = 2 Then
            filter = "jpg"
        Else
            filter = "pdf"
        End If
        OpenUploadFile(filter)
    End Sub

    Public Function MakeAlphanumeric(this As String) As String
        this = Regex.Replace(this, "[^a-zA-Z0-9]", "")
        Return this
    End Function

    Public Function cleanStr(this As String) As String
        this = Trim(this)

        For ix As Integer = 0 To Len(this) - 1
            Dim chr As Char = this(ix)
            If Asc(chr) < 32 Or Asc(chr) > 126 Then
                this = this.Replace(chr, "|")
            End If
        Next
        this = this.Replace("|", " ")
        Return this
    End Function

    Private Sub CleanupWalks()
        Try
            wait(True)
            For ix As Integer = 0 To Chrisbarton_grg10DataSet1.ALLWALKS.Rows.Count - 1
                With Chrisbarton_grg10DataSet1.ALLWALKS(ix)
                    .NAME = cleanStr(.NAME)
                    .DESCRIPTION = cleanStr(.DESCRIPTION)
                    .START_PLACE = cleanStr(.START_PLACE)
                End With
            Next

            wait(False)
        Catch ex As Exception
            wait(False)
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CleanupProgramme()
        Try
            wait(True)
            For ix As Integer = 0 To Chrisbarton_grg10DataSet.PROGRAMME.Rows.Count - 1
                With Chrisbarton_grg10DataSet.PROGRAMME(ix)
                    .walk = cleanStr(.walk)
                    .descr = cleanStr(.descr)
                    .place = cleanStr(.place)
                End With
            Next
            wait(False)
        Catch ex As Exception
            wait(False)
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Bcleanwalks_Click(sender As Object, e As EventArgs) Handles Bcleanwalks.Click
        CleanupWalks()
    End Sub

    Private Sub TSBftp_Click(sender As Object, e As EventArgs) Handles TSBftp.Click
        FTPform.Show()
    End Sub

    Private Sub tsbSaveDetails_Click(sender As Object, e As EventArgs) Handles tsbSaveDetails.Click
        saveProgramme()
    End Sub

#End Region

#Region "FTP"

    Private Sub bUploadContact_Click(sender As Object, e As EventArgs) Handles bUploadContact.Click
        wait(True)
        Dim sPhoto As String = PhotoTextBox.Text
        sPhoto = basedir & "Images/" & sPhoto
        Dim localphoto As String = llContactPhoto.Text
        If Not oFTP.Upload(localphoto, sPhoto) Then
            MsgBox("Unable to upload photo! - " & oFTP.errormessage)
            Exit Sub
        End If
        saveContacts()
        pbContact.Image = Nothing
        bUploadContact.Visible = False
        llContactPhoto.Text = ""
        wait(False)
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim res As MsgBoxResult = MsgBox("This will delete item and file on server.", MsgBoxStyle.OkCancel)
        If res = MsgBoxResult.Cancel Then Exit Sub
        'delete File
        Dim dfile As String = basedir & "Images/" & PhotoTextBox.Text
        If Not oFTP.Deletefile(dfile) Then
            MsgBox("Delete failed - " & oFTP.errormessage)
            Exit Sub
        End If
        GROUP_CONTACTSBindingSource.RemoveCurrent()
        saveContacts()
    End Sub

    Private Sub deletePhoto()
        Dim res As MsgBoxResult = MsgBox("This will delete item and file on server.", MsgBoxStyle.OkCancel)
        If res = MsgBoxResult.Cancel Then Exit Sub
        'delete File
        Dim dfile As String = basedir & "Galleries/" & PHOTOALBUMDataGridView.SelectedRows(0).Cells(2).Value & "/" & PHOTOALBUMDataGridView.SelectedRows(0).Cells(3).Value
        MsgBox(dfile)
        If Not oFTP.Deletefile(dfile) Then
            MsgBox("delete failed - " & oFTP.errormessage)
            Exit Sub
        End If

        PHOTOALBUMBindingSource.RemoveCurrent()
        photoAlbumSave()
        dbaseLoad()
    End Sub

    Private Sub tsbDelMap_Click(sender As Object, e As EventArgs) Handles tsbDelMap.Click
        If MsgBox("This will delete current map from server" & vbCrLf & "and database reference. Ok?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        If Not oFTP.Deletefile(basedir & "Maps/" & MAPTextBox1.Text) Then
            MsgBox("Error deleting map! - " & oFTP.errormessage)
        Else
            MAPTextBox1.Text = ""
            saveMaps()
        End If
    End Sub

    Private Sub BGPX_Click(sender As Object, e As EventArgs) Handles BGPX.Click
        dlg.InitialDirectory = My.Settings.defaultfolder
        dlg.DefaultExt = ".gpx" ' Default file extension
        dlg.Filter = "GPX files (.gpx)|*.gpx|GPX files (.GPX)| *.GPX" ' Filter files by extension

        ' Show open file dialog box
        Dim result As Boolean = dlg.ShowDialog()

        ' Process open file dialog box results
        If result <> DialogResult.Cancel Then
            ' Open document
            If MsgBox("Upload this GPX?" & vbCrLf & dlg.FileName, MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
            Lgpxupload.Text = dlg.FileName
            GPXTextBox.Text = My.Computer.FileSystem.GetFileInfo(Lgpxupload.Text).Name
        Else
            Exit Sub
        End If

        Dim gpxid As String = IDWlabel1.Text
        Dim gpxnm As String = NAMETextBox1.Text
        Dim sGPX As String = GPXTextBox.Text
        sGPX = MapName(gpxid, gpxnm)
        sGPX = sGPX.Replace(".jpg", ".gpx") 'make standard gpx filename
        GPXTextBox.Text = sGPX
        sGPX = basedir & "GPX/" & sGPX
        Dim localGPX As String = Lgpxupload.Text
        If Not oFTP.Upload(localGPX, sGPX) Then
            MsgBox("Unable to upload GPX! - " & oFTP.errormessage)
            Exit Sub
        End If
        saveMaps()
        Lgpxupload.Text = ""

    End Sub

    Private Sub bInsertMap_Click(sender As Object, e As EventArgs) Handles bInsertMap.Click
        Dim mapid As String = IDWlabel1.Text
        Dim mapnm As String = NAMETextBox1.Text
        Dim sMap As String = MAPTextBox1.Text
        sMap = MapName(mapid, mapnm) 'make standard map name
        MAPTextBox1.Text = sMap
        sMap = basedir & "Maps/" & sMap
        Dim localmap As String = tbFilename.Text
        If Not oFTP.Upload(localmap, sMap) Then
            MsgBox("Unable to upload map! - " & oFTP.errormessage)
            Exit Sub
        End If
        saveMaps()
        pbMap.Image = Nothing
        bInsertMap.Visible = False
        tbFilename.Text = ""
    End Sub

    Private Sub llOldMaps_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llOldMaps.LinkClicked
        tbOldMaps.Text = ""
        wait(True)
        Dim sFiles As String = oFTP.getFiles(basedir & "Maps/")
        Dim checkFiles() As String = Split(sFiles.Trim, vbCrLf)
        Try
            For ix As Integer = 0 To checkFiles.Length - 1
                If isMapUnused(checkFiles(ix)) Then
                    tbOldMaps.Text = tbOldMaps.Text & checkFiles(ix) & vbCrLf

                End If
            Next
            wait(False)
        Catch ex As Exception
            wait(False)
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub llDelOldMaps_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llDelOldMaps.LinkClicked
        If Not tbOldMaps.Text.Contains(".jpg") Then Exit Sub
        Dim delMaps() As String = Split(tbOldMaps.Text.Trim, vbCrLf)
        For ix As Integer = 0 To delMaps.Length - 1
            If Not oFTP.Deletefile(basedir & "Maps/" & delMaps(ix)) Then MsgBox("Failed to delete " & delMaps(ix) & vbCrLf & oFTP.errormessage)
        Next
        tbOldMaps.Text = "All old maps deleted"
    End Sub

    Private Sub LLOrphanedMaps_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLOrphanedMaps.LinkClicked
        tbOldMaps.Text = ""
        wait(True)
        Dim sFiles As String = oFTP.getFiles(basedir & "Maps/")
        Dim checkFiles() As String = Split(sFiles.Trim, vbCrLf)
        Try
            For ix As Integer = 0 To Chrisbarton_grg10DataSet.ALLWALKS.Rows.Count - 1
                With Chrisbarton_grg10DataSet.ALLWALKS(ix)
                    If Not (.IsMAPNull) And .MAP <> "" Then
                        If Not checkFiles.Contains(.MAP) Then
                            tbOldMaps.Text = tbOldMaps.Text & .NAME & vbCrLf
                        End If

                    End If
                End With

            Next
            wait(False)
        Catch ex As Exception
            wait(False)
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub bUploadFile_Click(sender As Object, e As EventArgs) Handles bUploadFile.Click
        If tbUploadFile.Text = "" Or TBtargetfile.Text = "" Then
            Exit Sub
        Else
            If MsgBox("Upload file " & tbUploadFile.Text & vbCrLf & " to Website: " & TBtargetfile.Text & "?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim targetfile As String = basedir & TBtargetfile.Text

                If Not oFTP.Upload(tbUploadFile.Text, targetfile) Then
                    MsgBox("File upload failed! - " & oFTP.errormessage)
                Else
                    MsgBox(targetfile & " updated")

                End If
            End If
            tbUploadFile.Text = ""
            TBtargetfile.Text = ""
            LUploadType.Text = ""
            CBfiletoUpload.SelectedIndex = -1
        End If
    End Sub

#End Region

#Region "PUBLISHED TABLE"

    Private Function SetKids(val As Boolean) As String
        If val Then
            Return "yes"
        Else
            Return ""
        End If
    End Function

    Private Function SetDogs(val As Boolean) As String
        If val Then
            Return "yes"
        Else
            Return ""
        End If
    End Function

    Private Sub SavePublished()
        Try
            Me.Validate()
            Me.PUBLISHEDBindingSource.EndEdit()
            Me.TableAdapterManager3.UpdateAll(Chrisbarton_grg10DataSet3)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ClearPublished()
        Try
            Me.PUBLISHEDTableAdapter.Fill(Me.Chrisbarton_grg10DataSet3.PUBLISHED)
            Dim lastix = Chrisbarton_grg10DataSet3.PUBLISHED.Rows.Count - 1
            For ix As Integer = 0 To lastix
                Chrisbarton_grg10DataSet3.PUBLISHED.Rows(ix).Delete()
            Next
            SavePublished()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ItemdateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles ItemdateDateTimePicker.ValueChanged
        ItemdateLabel4.Text = ItemdateDateTimePicker.Value.DayOfWeek.ToString
    End Sub

    Private Sub CHBincStrollers_CheckedChanged(sender As Object, e As EventArgs) Handles CHBincStrollers.CheckedChanged
        If CHBincStrollers.Checked Then
            Me.PUBLISHEDTableAdapter.Fill(Me.Chrisbarton_grg10DataSet3.PUBLISHED)
        Else
            Me.PUBLISHEDTableAdapter.FillByCurrent(Me.Chrisbarton_grg10DataSet3.PUBLISHED)
        End If
    End Sub

    Private Sub TSBSavePublished_Click(sender As Object, e As EventArgs) Handles TSBSavePublished.Click
        SavePublished()
        MsgBox("PUBLISHED table saved")
    End Sub

#End Region

End Class