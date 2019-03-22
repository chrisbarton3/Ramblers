Imports System.IO, System.Net
Public Class FTPform

#Region "Declarations"
    Dim connected As Boolean
    Dim conPw As String = My.Settings.ftppword
    Dim conUser As String = My.Settings.ftpuser
    Dim conFTP As String = My.Settings.ftpurl
    Dim basedir As String = My.Settings.basedir
    Dim localPath As String = My.Settings.defaultLocalPath
    Dim oFTP As New FTPutility(conFTP, conUser, conPw)
    Dim lastRemoteDir As String = ""
    Dim thisRemoteDir As String = ""
#End Region


#Region "Form Actions"

    Private Sub thisform_load(sender As Object, e As System.EventArgs) Handles Me.Load
        redrawform()
        basedir = basedir.TrimEnd("/")
        txtRemote.Text = basedir
        getLocalFiles()
        getRemotefiles(basedir)
        ListView2.Columns(0).Text = conFTP
    End Sub

    Private Sub thisform_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        redrawform()
    End Sub

    Private Sub wait(w As Boolean)
        If w Then
            Cursor.Current = Cursors.WaitCursor
            SplitContainer1.Enabled = False
        Else
            Cursor.Current = Cursors.Default
            SplitContainer1.Enabled = True
        End If
    End Sub

    Private Sub redrawform()

        scLocal.Width = Me.Width / 2 - 10
        scremote.Width = Me.Width / 2 - 10
        ListView1.Columns(0).Width = ListView1.Width - 160
        ListView1.Columns(1).Width = 140
        ListView2.Columns(0).Width = ListView1.Width - 160
        ListView2.Columns(1).Width = 150

        txtLocal.Text = localPath

    End Sub

#End Region

#Region "local files"


    Private Sub tsbDefault_Click(sender As Object, e As EventArgs) Handles tsbDefault.Click
        localPath = My.Settings.defaultLocalPath
        txtLocal.Text = localPath
        getLocalFiles()
    End Sub

    Private Sub getLocalFiles()
        If Not Directory.Exists(localPath) Then
            localPath = "C:\"
            txtLocal.Text = localPath
        End If
        Try
            Dim files = From file In Directory.EnumerateFiles(localPath)
            Dim folders = From folder In Directory.EnumerateDirectories(localPath)
            Dim spath As Integer = Len(localPath)
            Dim sfile As String
            Dim sfolder As String

            ' Show results.
            ListView1.Items.Clear()
            For Each folder In folders
                sfolder = folder.Remove(0, spath)
                'strip backslash
                sfolder = sfolder.TrimStart("\")
                'Usually the first unique colum is the root item
                Dim lv As ListViewItem = ListView1.Items.Add(sfolder)
                'The remaining columns are subitems
                lv.ImageIndex = 0
            Next
            Dim ext As String = ""
            For Each file In files
                Dim fdate As Date = FileDateTime(file)
                sfile = file.Remove(0, spath)
                sfile = sfile.TrimStart("\")
                Dim lv As ListViewItem = ListView1.Items.Add(sfile)
                lv.SubItems.Add(fdate.ToShortDateString)
                ext = sfile.Substring(sfile.LastIndexOf("."))
                lv.ImageIndex = getIconIndex(ext)
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub frmListView_DoubleClick(sender As Object, e As System.EventArgs) Handles ListView1.DoubleClick
        Try
            If ListView1.FocusedItem.ImageIndex <> 0 Then Exit Sub
            localPath = localPath.TrimEnd("\")
            localPath = localPath & "\" & ListView1.FocusedItem.Text
            getLocalFiles()
            txtLocal.Text = localPath
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub tsbBack_Click(sender As System.Object, e As System.EventArgs) Handles tsbBack.Click
        If Len(localPath) = 3 Then Exit Sub
        Try
            Dim lastdir As Integer = localPath.LastIndexOf("\")
            localPath = localPath.Remove(lastdir)
            If Len(localPath) = 2 Then localPath = localPath & "\"
            getLocalFiles()
            txtLocal.Text = localPath
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub tsbBrowse_Click(sender As System.Object, e As System.EventArgs) Handles tsbBrowse.Click
        getlocalfolder.SelectedPath = localPath
        Dim result As DialogResult = getlocalfolder.ShowDialog()

        If (result = DialogResult.OK) Then
            txtLocal.Text = getlocalfolder.SelectedPath
            localPath = txtLocal.Text
            getLocalFiles()
        End If
    End Sub

    Private Sub tsbUpload_Click(sender As System.Object, e As System.EventArgs) Handles tsbUpload.Click

        If ListView1.SelectedItems.Count > 0 Then
            If ListView1.SelectedItems(0).SubItems(1).Text = "" Then Exit Sub
            Dim localFile As String = localPath & "\" & ListView1.SelectedItems(0).Text
            Dim remoteFile As String = txtRemote.Text & "/" & ListView1.SelectedItems(0).Text
            If Not oFTP.Upload(localFile, remoteFile) Then
                MsgBox("Upload failed! " & vbCrLf & oFTP.errormessage)
            Else
                RemoteRefresh()
            End If
        End If

    End Sub


    Private Sub TSBdeletelocal_Click(sender As Object, e As EventArgs) Handles TSBdeletelocal.Click
        If ListView1.SelectedItems.Count = 0 Or ListView1.SelectedItems(0).SubItems(1).Text = "" Then Exit Sub
        Dim localFile As String = localPath & "\" & ListView1.SelectedItems(0).Text
        If MsgBox("Delete " & ListView1.SelectedItems(0).Text, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then File.Delete(localFile)
        getLocalFiles()
    End Sub

#End Region


#Region "Remote Files"


    Private Function getRemotefiles(dir As String) As Boolean
        oFTP.connect()
        Dim item() As String, items As String
        Dim itemdate() As String, itemdates As String
        wait(True)
        'GET FOLDERS
        items = oFTP.getFolders(dir)
        If items.Contains("error") Then
            message.AppendText(items & vbCrLf)
            oFTP.disconnect()
            Return False

            Exit Function
        Else
            lastRemoteDir = dir
            message.AppendText("Folder list returned for " & txtRemote.Text & vbCrLf)

        End If
        ListView2.Items.Clear()
        item = Split(items, vbCrLf)
        For ix As Integer = 0 To item.GetUpperBound(0) - 1
            Dim lv As ListViewItem = ListView2.Items.Add(item(ix))
            lv.ImageIndex = 0

        Next
        'GET FILES AND DATES
        Dim ext As String = ""
        items = oFTP.getFiles(dir)
        itemdates = oFTP.getFileDates(dir)
        If items.Contains("error") Then
            message.AppendText(items & vbCrLf)
            oFTP.disconnect()
            Return False
            Exit Function
        Else
            lastRemoteDir = dir
            message.AppendText("File list returned for " & txtRemote.Text & vbCrLf)

        End If

        item = Split(items, vbCrLf)
        itemdate = Split(itemdates, vbCrLf)
        For ix As Integer = 0 To item.GetUpperBound(0) - 1
            Dim lv As ListViewItem = ListView2.Items.Add(item(ix))
            lv.SubItems.Add(itemdate(ix))
            ext = item(ix).Substring(item(ix).LastIndexOf("."))
            lv.ImageIndex = getIconIndex(ext)
        Next
        oFTP.disconnect()
        wait(False)
        Return True
    End Function
    Private Function getIconIndex(ext As String) As Integer
        ext = ext.ToLower
        ext = ext.TrimEnd("l")
        ext = ext.TrimStart(".")
        Select Case ext
            Case "htm", "aspx", "master"
                Return 2
            Case "pdf"
                Return 3
            Case "vb", "js", "config", "css"
                Return 4
            Case "jpg", "jpeg", "bmp", "png"
                Return 5
            Case Else
                Return 1

        End Select
    End Function

    Private Sub ListView2_DoubleClick(sender As Object, e As System.EventArgs) Handles ListView2.DoubleClick

        If ListView2.FocusedItem.ImageIndex <> 0 Then Exit Sub
        txtRemote.Text = txtRemote.Text & "/" & ListView2.FocusedItem.Text
        thisRemoteDir = txtRemote.Text
        RemoteRefresh()

    End Sub

    Private Sub tbrBack_Click(sender As System.Object, e As System.EventArgs) Handles tbrBack.Click
        If txtRemote.Text = basedir Then Exit Sub
        lastRemoteDir = txtRemote.Text

        Dim lastdir As Integer = lastRemoteDir.LastIndexOf("/")
        lastRemoteDir = lastRemoteDir.Remove(lastdir)
        txtRemote.Text = lastRemoteDir
        thisRemoteDir = txtRemote.Text
        RemoteRefresh()


    End Sub

    Private Sub tbrHome_Click(sender As System.Object, e As System.EventArgs) Handles tbrHome.Click

        txtRemote.Text = basedir
        thisRemoteDir = txtRemote.Text
        RemoteRefresh()

    End Sub

    Private Sub tbrDownload_Click(sender As System.Object, e As System.EventArgs) Handles tbrDownload.Click
        If ListView2.SelectedItems.Count > 0 Then
            If ListView2.SelectedItems(0).ImageIndex = 0 Then Exit Sub
            Dim localFile As String = localPath & "\" & ListView2.SelectedItems(0).Text
            Dim remoteFile As String = txtRemote.Text & "/" & ListView2.SelectedItems(0).Text
            If Not oFTP.Download(localFile, remoteFile) Then
                MsgBox(oFTP.errormessage)
                message.AppendText(remoteFile & " not downloaded" & vbCrLf)
            End If
            getLocalFiles()
            message.AppendText(remoteFile & " downloaded" & vbCrLf)
        End If

    End Sub

    Private Sub tbrDelete_Click(sender As System.Object, e As System.EventArgs) Handles tbrDelete.Click
        If ListView2.SelectedItems.Count = 0 Then Exit Sub     'make sure there is a selected item to delete
        If ListView2.SelectedItems(0).ImageIndex <> 0 Then   'file delete
            If MessageBox.Show("Do you want to delete this file?", "Confirm", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim dfile As String = txtRemote.Text & "/" & ListView2.SelectedItems(0).Text
                If Not oFTP.Deletefile(dfile) Then
                    MsgBox("Failed to delete file!" & vbCrLf & oFTP.errormessage)
                Else
                    thisRemoteDir = txtRemote.Text
                    RemoteRefresh()
                    message.AppendText(dfile & " deleted" & vbCrLf)
                End If
            End If
        Else   'directory delete
            If MessageBox.Show("Do you want to delete this folder and all files in it?", "Confirm", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim dfolder As String = txtRemote.Text & "/" & ListView2.SelectedItems(0).Text
                If Not oFTP.removeDir(dfolder) Then
                    MsgBox("Failed to delete folder!" & vbCrLf & oFTP.errormessage)
                Else
                    thisRemoteDir = txtRemote.Text
                    message.AppendText(dfolder & " and contents deleted" & vbCrLf)
                    RemoteRefresh()
                End If
            End If
        End If
    End Sub

    Private Sub TSBrename_Click(sender As Object, e As EventArgs) Handles TSBrename.Click
        Dim oldnm As String
        Try
            If ListView2.FocusedItem.ImageIndex = 0 Then Exit Sub
            oldnm = txtRemote.Text & "/" & ListView2.FocusedItem.Text
        Catch ex As Exception
            Exit Sub
        End Try

        Dim newnm As String = InputBox("New file name?")
        If newnm = "" Then Exit Sub
        newnm = txtRemote.Text & "/" & newnm
        If oFTP.Renamefile(oldnm, newnm) Then
            thisRemoteDir = txtRemote.Text
            message.AppendText(oldnm & " renamed to " & newnm & vbCrLf)
            RemoteRefresh()
        Else
            MsgBox("Rename failed " & vbCrLf & oFTP.errormessage)
        End If
    End Sub

    Private Sub RemoteRefresh()
        If Not getRemotefiles(thisRemoteDir) Then
            MsgBox("Directory listing failed " & vbCrLf & oFTP.errormessage)
        End If
    End Sub

    Private Sub TSBadddir_Click(sender As Object, e As EventArgs) Handles TSBadddir.Click
        thisRemoteDir = txtRemote.Text
        Dim newdir As String = InputBox("New folder name?")
        If newdir = "" Then Exit Sub
        If Not oFTP.makeDir(thisRemoteDir & "/" & newdir) Then
            MsgBox("Folder creation failed " & vbCrLf & oFTP.errormessage)
        Else
            RemoteRefresh()
            message.AppendText(newdir & " folder created" & vbCrLf)
        End If
    End Sub

#End Region


End Class
