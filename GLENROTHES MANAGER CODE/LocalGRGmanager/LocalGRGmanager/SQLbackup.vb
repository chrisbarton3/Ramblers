Public Class SQLbackup
    Dim localloaded As Boolean = False
    Dim remoteloaded As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Bloadlocal_Click(sender As Object, e As EventArgs) Handles Bloadlocal.Click
        Try

            Me.PROGRAMMETableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PROGRAMME)
            TBinfo.AppendText("Local PROGRAMME table loaded" & vbCrLf)
            Me.PHOTOALBUMTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PHOTOALBUM)
            TBinfo.AppendText("Local PHOTOALBUM table loaded" & vbCrLf)
            Me.LEADERSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.LEADERS)
            TBinfo.AppendText("Local LEADERS table loaded" & vbCrLf)
            Me.GROUP_CONTACTSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.GROUP_CONTACTS)
            TBinfo.AppendText("Local GROUP_CONTACTS table loaded" & vbCrLf)
            Me.PUBLISHEDTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PUBLISHED)
            TBinfo.AppendText("Local PUBLISHED table loaded" & vbCrLf)
            Me.ARCHIVED_WALKSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.ARCHIVED_WALKS)
            TBinfo.AppendText("Local ARCHIVED_WALKS table loaded" & vbCrLf)
            Me.ALLWALKSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.ALLWALKS)
            TBinfo.AppendText("Local ALLWALKS table loaded" & vbCrLf)
            Me.AJPwalksTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.AJPwalks)
            TBinfo.AppendText("Local AJPWalks table loaded" & vbCrLf)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        TBinfo.AppendText("All local DB tables loaded" & vbCrLf)
        localloaded = True
        If remoteloaded Then
            Bupdatelocal.Enabled = True
            Bupdateremote.Enabled = True
        End If
        Bsavelocal.Enabled = True

    End Sub

    Private Sub Bsavelocal_Click(sender As Object, e As EventArgs) Handles Bsavelocal.Click
        SaveLocal()
    End Sub

    Private Sub SaveLocal()
        Try
            Me.PROGRAMMEBindingSource.EndEdit()
            Me.PHOTOALBUMBindingSource.EndEdit()
            Me.LEADERSBindingSource.EndEdit()
            Me.GROUP_CONTACTSBindingSource.EndEdit()
            Me.PUBLISHEDBindingSource.EndEdit()
            Me.ARCHIVED_WALKSBindingSource.EndEdit()
            Me.ALLWALKSBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Chrisbarton_grg10DataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        TBinfo.AppendText("All local DB tables saved" & vbCrLf)
    End Sub

    Private Sub Bloadremote_Click(sender As Object, e As EventArgs) Handles Bloadremote.Click
        Try

            Me.PROGRAMMETableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.PROGRAMME)
            TBinfo.AppendText("Remote PROGRAMME table loaded" & vbCrLf)
            Me.PHOTOALBUMTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.PHOTOALBUM)
            TBinfo.AppendText("Remote PHOTOALBUM table loaded" & vbCrLf)
            Me.LEADERSTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.LEADERS)
            TBinfo.AppendText("Remote LEADERS table loaded" & vbCrLf)
            Me.GROUP_CONTACTSTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.GROUP_CONTACTS)
            TBinfo.AppendText("Remote GROUP_CONTACTS table loaded" & vbCrLf)
            Me.PUBLISHEDTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.PUBLISHED)
            TBinfo.AppendText("Remote PUBLISHED table loaded" & vbCrLf)
            Me.ARCHIVED_WALKSTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.ARCHIVED_WALKS)
            TBinfo.AppendText("Remote ARCHIVED_WALKS table loaded" & vbCrLf)
            Me.ALLWALKSTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.ALLWALKS)
            TBinfo.AppendText("Remote ALLWALKS table loaded" & vbCrLf)
            Me.AJPwalksTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.AJPwalks)
            TBinfo.AppendText("Remote AJPWalks table loaded" & vbCrLf)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        TBinfo.AppendText("All local DB tables loaded" & vbCrLf)
        remoteloaded = True
        If localloaded Then
            Bupdatelocal.Enabled = True
            Bupdateremote.Enabled = True
        End If
        Bsaveremote.Enabled = True
    End Sub

    Private Sub Bupdatelocal_Click(sender As Object, e As EventArgs) Handles Bupdatelocal.Click
        Dim chk As Boolean = CLBtables.CheckedItems.Count > 0
        If Not chk Then
            MsgBox("No tables selected")
            Exit Sub
        End If
        If MsgBox("Update selected tables in local db from remote?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then UpdateLocal()
    End Sub

    Private Sub UpdateLocal()

        Cursor = Cursors.WaitCursor
        Dim ix As Integer
        'ARCHIVED_WALKS routine
        If CLBtables.CheckedItems.Contains("ARCHIVED_WALKS") Then
            Try
                'delete old local table
                Dim lastix As Integer = Chrisbarton_grg10DataSet.ARCHIVED_WALKS.Rows.Count - 1
                For ix = 0 To lastix
                    Chrisbarton_grg10DataSet.ARCHIVED_WALKS.Rows(ix).Delete()
                Next
                Me.Validate()
                Me.ARCHIVED_WALKSBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Chrisbarton_grg10DataSet)
                Me.ARCHIVED_WALKSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.ARCHIVED_WALKS)
                TBinfo.AppendText("Local ARCHIVED_WALKS table cleared" & vbCrLf)
                'copy from remote
                lastix = Chrisbarton_grg10DataSet1.ARCHIVED_WALKS.Rows.Count - 1
                For ix = 0 To lastix
                    With Chrisbarton_grg10DataSet1.ARCHIVED_WALKS(ix)
                        Chrisbarton_grg10DataSet.ARCHIVED_WALKS.AddARCHIVED_WALKSRow(.IDW, .NAME, .TOWN, .DESCRIPTION, .GRADE, .DISTANCE, .MEET_TIME, .START_TIME, .TIME, .START_PLACE, .GRIDREF, .OS_MAP, .CHILDREN, .DOGS, .MAP, .ASCENT, .LASTLEADER, .LASTDATE, .HIDDEN)
                    End With
                Next
                My.Settings.lastaw = Now.ToShortDateString
                TBinfo.AppendText("ARCHIVED_WALKS table copied from remote db" & vbCrLf)
            Catch ex As Exception
                Dim errorline As String = Chrisbarton_grg10DataSet.ARCHIVED_WALKS(ix).NAME
                TBinfo.AppendText("ARCHIVED_WALKS table update error in item" & vbCrLf & errorline & vbCrLf)
                MsgBox(ex.Message)
            End Try
        End If

        'LEADERS routine
        If CLBtables.CheckedItems.Contains("LEADERS") Then
            Try
                'delete old local table
                Dim lastix As Integer = Chrisbarton_grg10DataSet.LEADERS.Rows.Count - 1
                For ix = 0 To lastix
                    Chrisbarton_grg10DataSet.LEADERS.Rows(ix).Delete()
                Next
                Me.Validate()
                Me.LEADERSBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Chrisbarton_grg10DataSet)
                Me.LEADERSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.LEADERS)
                TBinfo.AppendText("Local LEADERS table cleared" & vbCrLf)
                'copy from remote
                lastix = Chrisbarton_grg10DataSet1.LEADERS.Rows.Count - 1
                For ix = 0 To lastix
                    With Chrisbarton_grg10DataSet1.LEADERS(ix) 'add row
                        Chrisbarton_grg10DataSet.LEADERS.AddLEADERSRow(.ID, .LEADER, .PHONE, .EMAIL)
                    End With
                Next
                My.Settings.lastlead = Now.ToShortDateString
                TBinfo.AppendText("LEADERS table copied from remote db" & vbCrLf)
            Catch ex As Exception
                Dim errorline As String = Chrisbarton_grg10DataSet.LEADERS(ix).LEADER
                TBinfo.AppendText("LEADERS table update error in item" & vbCrLf & errorline & vbCrLf)
                MsgBox(ex.Message)
            End Try
        End If

        'AJPwalks routine
        If CLBtables.CheckedItems.Contains("AJPwalks") Then
            Try
                'delete old local table
                Dim lastix As Integer = Chrisbarton_grg10DataSet.AJPwalks.Rows.Count - 1
                For ix = 0 To lastix
                    Chrisbarton_grg10DataSet.AJPwalks.Rows(ix).Delete()
                Next
                Me.Validate()
                Me.AJPwalksBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Chrisbarton_grg10DataSet)
                Me.AJPwalksTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.AJPwalks)
                TBinfo.AppendText("Local AJPwalks table cleared" & vbCrLf)
                'copy from remote
                lastix = Chrisbarton_grg10DataSet1.AJPwalks.Rows.Count - 1
                For ix = 0 To lastix
                    With Chrisbarton_grg10DataSet1.AJPwalks(ix) 'add row
                        Chrisbarton_grg10DataSet.AJPwalks.AddAJPwalksRow(.dateid, .itemdate, .txtdate, .period, .walk, .descr, .ascent, .grade, .dist, .time, .meet, .start, .place, .osmap, .griref, .kids, .dogs, .leader, .phone, .email, .note)
                    End With
                Next
                My.Settings.lastajp = Now.ToShortDateString
                TBinfo.AppendText("AJPwalks table copied from remote db" & vbCrLf)
            Catch ex As Exception
                Dim errorline As String = Chrisbarton_grg10DataSet.AJPwalks(ix).walk
                TBinfo.AppendText("AJPwalks table update error in item" & vbCrLf & errorline & vbCrLf)
                MsgBox(ex.Message)
            End Try
        End If

        'ALLWALKS routine
        If CLBtables.CheckedItems.Contains("ALLWALKS") Then
            Try
                'delete old local table
                Dim lastix As Integer = Chrisbarton_grg10DataSet.ALLWALKS.Rows.Count - 1
                For ix = 0 To lastix
                    Chrisbarton_grg10DataSet.ALLWALKS.Rows(ix).Delete()
                Next
                Me.Validate()
                Me.ALLWALKSBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Chrisbarton_grg10DataSet)
                Me.ALLWALKSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.ALLWALKS)
                TBinfo.AppendText("Local ALLWALKS table cleared" & vbCrLf)
                'copy from remote
                lastix = Chrisbarton_grg10DataSet1.ALLWALKS.Rows.Count - 1
                For ix = 0 To lastix
                    With Chrisbarton_grg10DataSet1.ALLWALKS(ix) 'add row
                        Chrisbarton_grg10DataSet.ALLWALKS.AddALLWALKSRow _
                        (.IDW, .NAME, .TOWN, .DESCRIPTION, .GRADE, .DISTANCE, .MEET_TIME, .START_TIME, .TIME, .START_PLACE, .GRIDREF, .OS_MAP, .CHILDREN, .DOGS, .MAP, .GPX, .ASCENT, .LASTLEADER, .LASTDATE, .HIDDEN)
                    End With
                Next
                My.Settings.lastallw = Now.ToShortDateString
                TBinfo.AppendText("ALLWALKS table copied from remote db" & vbCrLf)
            Catch ex As Exception
                Dim errorline As String = Chrisbarton_grg10DataSet.ALLWALKS(ix).NAME
                TBinfo.AppendText("ALLWALKS table update error in item" & vbCrLf & errorline & vbCrLf)
                MsgBox(ex.Message)
            End Try
        End If

        'PROGRAMME routine
        If CLBtables.CheckedItems.Contains("PROGRAMME") Then
            Try
                'delete old local table
                Dim lastix As Integer = Chrisbarton_grg10DataSet.PROGRAMME.Rows.Count - 1
                For ix = 0 To lastix
                    Chrisbarton_grg10DataSet.PROGRAMME.Rows(ix).Delete()
                Next
                Me.Validate()
                Me.PROGRAMMEBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Chrisbarton_grg10DataSet)
                Me.PROGRAMMETableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PROGRAMME)
                TBinfo.AppendText("Local PROGRAMME table cleared" & vbCrLf)
                'copy from remote
                lastix = Chrisbarton_grg10DataSet1.PROGRAMME.Rows.Count - 1
                For ix = 0 To lastix
                    With Chrisbarton_grg10DataSet1.PROGRAMME(ix) 'add row
                        Chrisbarton_grg10DataSet.PROGRAMME.AddPROGRAMMERow _
                        (.dateid, .itemdate, .period, .walk, .descr, .ascent, .grade, .dist, .time, .meet, .start, .place, .osmap, .griref, .kids, .dogs, .leader, .phone, .email, .note)
                    End With
                Next
                My.Settings.lastprog = Now.ToShortDateString
                TBinfo.AppendText("PROGRAMME table copied from remote db" & vbCrLf)
            Catch ex As Exception
                Dim errorline As String = Chrisbarton_grg10DataSet.PROGRAMME(ix).walk
                TBinfo.AppendText("PROGRAMME table update error in item" & vbCrLf & errorline & vbCrLf)
                MsgBox(ex.Message)
            End Try
        End If

        'FINAL_PROGRAM routine local
        If CLBtables.CheckedItems.Contains("PUBLISHED") Then
            Try
                'delete old local table
                Dim lastix As Integer = Chrisbarton_grg10DataSet.PUBLISHED.Rows.Count - 1
                For ix = 0 To lastix
                    Chrisbarton_grg10DataSet.PUBLISHED.Rows(ix).Delete()
                Next
                Me.Validate()
                Me.PUBLISHEDBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Chrisbarton_grg10DataSet)
                Me.PUBLISHEDTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PUBLISHED)
                TBinfo.AppendText("Local FINAL_PROGRAM table cleared" & vbCrLf)
                'copy from remote
                lastix = Chrisbarton_grg10DataSet1.PUBLISHED.Rows.Count - 1

                For ix = 0 To lastix
                    With Chrisbarton_grg10DataSet1.PUBLISHED(ix) 'add row
                        Try
                            Chrisbarton_grg10DataSet.PUBLISHED.AddPUBLISHEDRow _
                                                       (.id, .itemdate, .period, .prog_item, .grade, .descr, .ascent, .dist, .time, .meet, .start, .place, .osmap, .gridref, .kids, .dogs, .leader, .phone, .email, .note)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                    End With
                Next
                My.Settings.lastfp = Now.ToShortDateString
                TBinfo.AppendText("PUBLISHED table copied from remote db" & vbCrLf)
            Catch ex As Exception
                Dim errorline As String = Chrisbarton_grg10DataSet.PUBLISHED(ix).prog_item
                TBinfo.AppendText("PUBLISHED table update error in item" & vbCrLf & errorline & vbCrLf)
                MsgBox(ex.Message)
            End Try
        End If

        'GROUP_CONTACTS routine
        If CLBtables.CheckedItems.Contains("GROUP_CONTACTS") Then
            Try
                'delete old local table
                Dim lastix As Integer = Chrisbarton_grg10DataSet.GROUP_CONTACTS.Rows.Count - 1
                For ix = 0 To lastix
                    Chrisbarton_grg10DataSet.GROUP_CONTACTS.Rows(ix).Delete()
                Next
                Me.Validate()
                Me.GROUP_CONTACTSBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Chrisbarton_grg10DataSet)
                Me.GROUP_CONTACTSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.GROUP_CONTACTS)
                TBinfo.AppendText("Local GROUP_CONTACTS table cleared" & vbCrLf)
                'copy from remote
                lastix = Chrisbarton_grg10DataSet1.GROUP_CONTACTS.Rows.Count - 1
                For ix = 0 To lastix
                    With Chrisbarton_grg10DataSet1.GROUP_CONTACTS(ix) 'add row
                        Chrisbarton_grg10DataSet.GROUP_CONTACTS.AddGROUP_CONTACTSRow(.name, .phone, .email, .designation, .photo, .id)
                    End With
                Next
                My.Settings.lastgc = Now.ToShortDateString
                TBinfo.AppendText("GROUP_CONTACTS table copied from remote db" & vbCrLf)
            Catch ex As Exception
                Dim errorline As String = Chrisbarton_grg10DataSet.GROUP_CONTACTS(ix).name
                TBinfo.AppendText("GROUP_CONTACTS table update error in item" & vbCrLf & errorline & vbCrLf)
                MsgBox(ex.Message)
            End Try
        End If

        'PHOTOALBUM routine
        If CLBtables.CheckedItems.Contains("PHOTOALBUM") Then
            Try
                'delete old local table
                Dim lastix As Integer = Chrisbarton_grg10DataSet.PHOTOALBUM.Rows.Count - 1
                For ix = 0 To lastix
                    Chrisbarton_grg10DataSet.PHOTOALBUM.Rows(ix).Delete()
                Next
                Me.Validate()
                Me.PHOTOALBUMBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Chrisbarton_grg10DataSet)
                Me.PHOTOALBUMTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PHOTOALBUM)
                TBinfo.AppendText("Local PHOTOALBUM table cleared" & vbCrLf)
                'copy from remote
                lastix = Chrisbarton_grg10DataSet1.PHOTOALBUM.Rows.Count - 1
                For ix = 0 To lastix
                    With Chrisbarton_grg10DataSet1.PHOTOALBUM(ix) 'add row
                        Chrisbarton_grg10DataSet.PHOTOALBUM.AddPHOTOALBUMRow(.idx, .filename, .directory, .caption, .filedate)
                    End With
                Next
                My.Settings.lastpha = Now.ToShortDateString
                TBinfo.AppendText("PHOTOALBUM table copied from remote db" & vbCrLf)
            Catch ex As Exception
                Dim errorline As String = Chrisbarton_grg10DataSet.PHOTOALBUM(ix).filename
                TBinfo.AppendText("PHOTOALBUM table update error in item" & vbCrLf & errorline & vbCrLf)
                MsgBox(ex.Message)
            End Try
        End If

        SaveLocal()

        Cursor = Cursors.Default
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Bsaveremote.Click
        SaveRemote()
    End Sub

    Private Sub SaveRemote()
        Try
            Me.PROGRAMMEBindingSource1.EndEdit()
            Me.PHOTOALBUMBindingSource1.EndEdit()
            Me.LEADERSBindingSource1.EndEdit()
            Me.GROUP_CONTACTSBindingSource1.EndEdit()
            Me.PUBLISHEDBindingSource1.EndEdit()
            Me.ARCHIVED_WALKSBindingSource1.EndEdit()
            Me.ALLWALKSBindingSource1.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Chrisbarton_grg10DataSet1)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        TBinfo.AppendText("All remote DB tables saved" & vbCrLf)
    End Sub

    Private Sub Bupdateremote_Click(sender As Object, e As EventArgs) Handles Bupdateremote.Click
        If MsgBox("This will delete tables in the remote database" & vbCrLf & "and copy them from the local database" & vbCrLf & "Are you sure?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        Dim ix As Integer
        'ARCHIVED_WALKS routine
        If CLBtables.CheckedItems.Contains("ARCHIVED_WALKS") Then
            Try
                'delete old remote table
                Dim lastix As Integer = Chrisbarton_grg10DataSet1.ARCHIVED_WALKS.Rows.Count - 1
                For ix = 0 To lastix
                    Chrisbarton_grg10DataSet1.ARCHIVED_WALKS.Rows(ix).Delete()
                Next
                Me.Validate()
                Me.ARCHIVED_WALKSBindingSource1.EndEdit()
                Me.TableAdapterManager1.UpdateAll(Chrisbarton_grg10DataSet1)
                Me.ARCHIVED_WALKSTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.ARCHIVED_WALKS)
                TBinfo.AppendText("Remote ARCHIVED_WALKS table cleared" & vbCrLf)
                'copy from local
                lastix = Chrisbarton_grg10DataSet.ARCHIVED_WALKS.Rows.Count - 1
                For ix = 0 To lastix
                    With Chrisbarton_grg10DataSet.ARCHIVED_WALKS(ix)
                        Chrisbarton_grg10DataSet1.ARCHIVED_WALKS.AddARCHIVED_WALKSRow(.IDW, .NAME, .TOWN, .DESCRIPTION, .GRADE, .DISTANCE, .MEET_TIME, .START_TIME, .TIME, .START_PLACE, .GRIDREF, .OS_MAP, .CHILDREN, .DOGS, .MAP, .ASCENT, .LASTLEADER, .LASTDATE, .HIDDEN)
                    End With
                Next
                My.Settings.lastaw = Now.ToShortDateString
                TBinfo.AppendText("Remote ARCHIVED_WALKS table copied from local db" & vbCrLf)
            Catch ex As Exception
                Dim errorline As String = Chrisbarton_grg10DataSet1.ARCHIVED_WALKS(ix).NAME
                TBinfo.AppendText("ARCHIVED_WALKS table update error in item" & vbCrLf & errorline & vbCrLf)
                MsgBox(ex.Message)
            End Try
        End If

        'AJPwalks routine
        If CLBtables.CheckedItems.Contains("AJPwalks") Then
            Try
                'delete old remote table
                Dim lastix As Integer = Chrisbarton_grg10DataSet1.AJPwalks.Rows.Count - 1
                For ix = 0 To lastix
                    Chrisbarton_grg10DataSet1.AJPwalks.Rows(ix).Delete()
                Next
                Me.Validate()
                Me.AJPwalksBindingSource1.EndEdit()
                Me.TableAdapterManager1.UpdateAll(Chrisbarton_grg10DataSet1)
                Me.AJPwalksTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.AJPwalks)
                TBinfo.AppendText("Remote AJPwalks table cleared" & vbCrLf)
                'copy from local
                lastix = Chrisbarton_grg10DataSet.AJPwalks.Rows.Count - 1
                For ix = 0 To lastix
                    With Chrisbarton_grg10DataSet.AJPwalks(ix)
                        Chrisbarton_grg10DataSet1.AJPwalks.AddAJPwalksRow(.dateid, .itemdate, .txtdate, .period, .walk, .descr, .ascent, .grade, .dist, .time, .meet, .start, .place, .osmap, .griref, .kids, .dogs, .leader, .phone, .email, .note)
                    End With
                Next
                My.Settings.lastaw = Now.ToShortDateString
                TBinfo.AppendText("Remote AJPwalks table copied from local db" & vbCrLf)
            Catch ex As Exception
                Dim errorline As String = Chrisbarton_grg10DataSet1.AJPwalks(ix).walk
                TBinfo.AppendText("AJPwalks table update error in item" & vbCrLf & errorline & vbCrLf)
                MsgBox(ex.Message)
            End Try
        End If

        'ALLWALKS routine
        If CLBtables.CheckedItems.Contains("ALLWALKS") Then
            Try
                'delete old remote table
                Dim lastix As Integer = Chrisbarton_grg10DataSet1.ALLWALKS.Rows.Count - 1
                For ix = 0 To lastix
                    Chrisbarton_grg10DataSet1.ALLWALKS.Rows(ix).Delete()
                Next
                Me.Validate()
                Me.ALLWALKSBindingSource1.EndEdit()
                Me.TableAdapterManager1.UpdateAll(Chrisbarton_grg10DataSet1)
                Me.ALLWALKSTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.ALLWALKS)
                TBinfo.AppendText("Remote ALLWALKS table cleared" & vbCrLf)
                'copy from local
                lastix = Chrisbarton_grg10DataSet.ALLWALKS.Rows.Count - 1
                For ix = 0 To lastix
                    With Chrisbarton_grg10DataSet.ALLWALKS(ix)
                        Chrisbarton_grg10DataSet1.ALLWALKS.AddALLWALKSRow(.IDW, .NAME, .TOWN, .DESCRIPTION, .GRADE, .DISTANCE, .MEET_TIME, .START_TIME, .TIME, .START_PLACE, .GRIDREF, .OS_MAP, .CHILDREN, .DOGS, .MAP, .GPX, .ASCENT, .LASTLEADER, .LASTDATE, .HIDDEN)
                    End With
                Next
                My.Settings.lastaw = Now.ToShortDateString
                TBinfo.AppendText("Remote ALLWALKS table copied from local db" & vbCrLf)
            Catch ex As Exception
                Dim errorline As String = Chrisbarton_grg10DataSet1.ALLWALKS(ix).NAME
                TBinfo.AppendText("ALLWALKS table update error in item" & vbCrLf & errorline & vbCrLf)
                MsgBox(ex.Message)
            End Try
        End If

        'LEADERS routine
        If CLBtables.CheckedItems.Contains("LEADERS") Then
            Try
                'delete old remote table
                Dim lastix As Integer = Chrisbarton_grg10DataSet1.LEADERS.Rows.Count - 1
                For ix = 0 To lastix
                    Chrisbarton_grg10DataSet1.LEADERS.Rows(ix).Delete()
                Next
                Me.Validate()
                Me.LEADERSBindingSource1.EndEdit()
                Me.TableAdapterManager1.UpdateAll(Chrisbarton_grg10DataSet1)
                Me.LEADERSTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.LEADERS)
                TBinfo.AppendText("Remote LEADERS table cleared" & vbCrLf)
                'copy from local
                lastix = Chrisbarton_grg10DataSet.LEADERS.Rows.Count - 1
                For ix = 0 To lastix
                    With Chrisbarton_grg10DataSet.LEADERS(ix)
                        Chrisbarton_grg10DataSet1.LEADERS.AddLEADERSRow(.ID, .LEADER, .PHONE, .EMAIL)
                    End With
                Next
                My.Settings.lastaw = Now.ToShortDateString
                TBinfo.AppendText("Remote LEADERS table copied from local db" & vbCrLf)
            Catch ex As Exception
                Dim errorline As String = Chrisbarton_grg10DataSet1.LEADERS(ix).LEADER
                TBinfo.AppendText("LEADERS table update error in item" & vbCrLf & errorline & vbCrLf)
                MsgBox(ex.Message)
            End Try
        End If

        'PROGRAMME routine
        If CLBtables.CheckedItems.Contains("PROGRAMME") Then
            Try
                'delete old remote table
                Dim lastix As Integer = Chrisbarton_grg10DataSet1.PROGRAMME.Rows.Count - 1
                For ix = 0 To lastix
                    Chrisbarton_grg10DataSet1.PROGRAMME.Rows(ix).Delete()
                Next
                Me.Validate()
                Me.PROGRAMMEBindingSource1.EndEdit()
                Me.TableAdapterManager1.UpdateAll(Chrisbarton_grg10DataSet1)
                Me.PROGRAMMETableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.PROGRAMME)
                TBinfo.AppendText("Remote PROGRAMME table cleared" & vbCrLf)
                'copy from local
                lastix = Chrisbarton_grg10DataSet.PROGRAMME.Rows.Count - 1
                For ix = 0 To lastix
                    With Chrisbarton_grg10DataSet.PROGRAMME(ix)
                        Chrisbarton_grg10DataSet1.PROGRAMME.AddPROGRAMMERow(.dateid, .itemdate, .period, .walk, .descr, .ascent, .grade, .dist, .time, .meet, .start, .place, .osmap, .griref, .kids, .dogs, .leader, .phone, .email, .note)
                    End With
                Next
                My.Settings.lastaw = Now.ToShortDateString
                TBinfo.AppendText("Remote PROGRAMME table copied from local db" & vbCrLf)
            Catch ex As Exception
                Dim errorline As String = Chrisbarton_grg10DataSet1.PROGRAMME(ix).walk
                TBinfo.AppendText("PROGRAMME table update error in item" & vbCrLf & errorline & vbCrLf)
                MsgBox(ex.Message)
            End Try
        End If

        'PUBLISHED routine
        If CLBtables.CheckedItems.Contains("PUBLISHED") Then
            Try
                'delete old remote table
                Dim lastix As Integer = Chrisbarton_grg10DataSet1.PUBLISHED.Rows.Count - 1
                For ix = 0 To lastix
                    Chrisbarton_grg10DataSet1.PUBLISHED.Rows(ix).Delete()
                Next
                Me.Validate()
                Me.PUBLISHEDBindingSource1.EndEdit()
                Me.TableAdapterManager1.UpdateAll(Chrisbarton_grg10DataSet1)
                Me.PUBLISHEDTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.PUBLISHED)
                TBinfo.AppendText("Remote PUBLISHED table cleared" & vbCrLf)
                'copy from local
                lastix = Chrisbarton_grg10DataSet.PUBLISHED.Rows.Count - 1
                For ix = 0 To lastix
                    With Chrisbarton_grg10DataSet.PUBLISHED(ix)
                        Chrisbarton_grg10DataSet1.PUBLISHED.AddPUBLISHEDRow(.id, .itemdate, .period, .prog_item, .grade, .descr, .ascent, .dist, .time, .meet, .start, .place, .osmap, .gridref, .kids, .dogs, .leader, .phone, .email, .note)
                    End With
                Next
                My.Settings.lastaw = Now.ToShortDateString
                TBinfo.AppendText("Remote PUBLISHED table copied from local db" & vbCrLf)
            Catch ex As Exception
                Dim errorline As String = Chrisbarton_grg10DataSet1.PUBLISHED(ix).prog_item
                TBinfo.AppendText("PUBLISHED table update error in item" & vbCrLf & errorline & vbCrLf)
                MsgBox(ex.Message)
            End Try
        End If

        'GROUP_CONTACTS routine
        If CLBtables.CheckedItems.Contains("GROUP_CONTACTS") Then
            Try
                'delete old remote table
                Dim lastix As Integer = Chrisbarton_grg10DataSet1.GROUP_CONTACTS.Rows.Count - 1
                For ix = 0 To lastix
                    Chrisbarton_grg10DataSet1.GROUP_CONTACTS.Rows(ix).Delete()
                Next
                Me.Validate()
                Me.GROUP_CONTACTSBindingSource1.EndEdit()
                Me.TableAdapterManager1.UpdateAll(Chrisbarton_grg10DataSet1)
                Me.GROUP_CONTACTSTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.GROUP_CONTACTS)
                TBinfo.AppendText("Remote GROUP_CONTACTS table cleared" & vbCrLf)
                'copy from local
                lastix = Chrisbarton_grg10DataSet.GROUP_CONTACTS.Rows.Count - 1
                For ix = 0 To lastix
                    With Chrisbarton_grg10DataSet.GROUP_CONTACTS(ix)
                        Chrisbarton_grg10DataSet1.GROUP_CONTACTS.AddGROUP_CONTACTSRow(.name, .phone, .email, .designation, .photo, .id)
                    End With
                Next
                My.Settings.lastaw = Now.ToShortDateString
                TBinfo.AppendText("Remote GROUP_CONTACTS table copied from local db" & vbCrLf)
            Catch ex As Exception
                Dim errorline As String = Chrisbarton_grg10DataSet1.GROUP_CONTACTS(ix).name
                TBinfo.AppendText("GROUP_CONTACTS table update error in item" & vbCrLf & errorline & vbCrLf)
                MsgBox(ex.Message)
            End Try
        End If

        'PHOTOALBUM routine
        If CLBtables.CheckedItems.Contains("PHOTOALBUM") Then
            Try
                'delete old remote table
                Dim lastix As Integer = Chrisbarton_grg10DataSet1.PHOTOALBUM.Rows.Count - 1
                For ix = 0 To lastix
                    Chrisbarton_grg10DataSet1.PHOTOALBUM.Rows(ix).Delete()
                Next
                Me.Validate()
                Me.PHOTOALBUMBindingSource1.EndEdit()
                Me.TableAdapterManager1.UpdateAll(Chrisbarton_grg10DataSet1)
                Me.PHOTOALBUMTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.PHOTOALBUM)
                TBinfo.AppendText("Remote PHOTOALBUM table cleared" & vbCrLf)
                'copy from local
                lastix = Chrisbarton_grg10DataSet.PHOTOALBUM.Rows.Count - 1
                For ix = 0 To lastix
                    With Chrisbarton_grg10DataSet.PHOTOALBUM(ix)
                        Chrisbarton_grg10DataSet1.PHOTOALBUM.AddPHOTOALBUMRow(.idx, .filename, .directory, .caption, .filedate)
                    End With
                Next
                My.Settings.lastaw = Now.ToShortDateString
                TBinfo.AppendText("Remote PHOTOALBUM table copied from local db" & vbCrLf)
            Catch ex As Exception
                Dim errorline As String = Chrisbarton_grg10DataSet1.PHOTOALBUM(ix).filename
                TBinfo.AppendText("PHOTOALBUM table update error in item" & vbCrLf & errorline & vbCrLf)
                MsgBox(ex.Message)
            End Try
        End If


        SaveRemote()
        Cursor = Cursors.Default
    End Sub

    Private Sub BLocalManager_Click(sender As Object, e As EventArgs) Handles BLocalManager.Click
        GRGlocal.Show()
    End Sub

    Private Sub LLcheckall_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLcheckall.LinkClicked
        For ix As Integer = 0 To CLBtables.Items.Count - 1
            CLBtables.SetItemCheckState(ix, CheckState.Checked)
        Next
    End Sub

    Private Sub LLchecknone_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLchecknone.LinkClicked
        For ix As Integer = 0 To CLBtables.Items.Count - 1
            CLBtables.SetItemCheckState(ix, CheckState.Unchecked)
        Next
    End Sub
End Class
