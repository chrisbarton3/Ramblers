Imports System.IO, System.Net, System.Data
Public Class addphoto

    Dim localpath As String
    Dim sphoto As String
    Dim sfolder As String
    Dim ftpurl As String = My.Settings.ftpurl
    Dim user As String = My.Settings.ftpuser
    Dim pword As String = My.Settings.ftppword
    Dim basedir As String = My.Settings.basedir
    Dim remotepath As String = basedir & "Galleries/" & Now.Year.ToString
    Dim galleries As String = basedir & "Galleries"
    Dim oFTP As New FTPutility(ftpurl, user, pword)

    Private Sub photos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Chrisbarton_grg10DataSet.PHOTOALBUM' table. You can move, or remove it, as needed.
        Try
            Me.PHOTOALBUMTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PHOTOALBUM)
            isCurrentGallery()
            reset()
        Catch ex As Exception
            MsgBox("Failed to connect to database!" & vbCrLf & ex.Message)
            Me.Close()
        End Try

    End Sub

    Private Sub reset()
        bUpload.Enabled = False
        lYear.Text = Now.Year.ToString
        bGetphoto.Enabled = True
        photo.Image = Nothing
        tbCaption.Text = ""
        tbFilename.Text = ""
        dtpDate.Value = Now
        lWidth.Text = ""
        lHeight.Text = ""

    End Sub

    Private Sub isCurrentGallery()
        Dim syear As String = Now.Year.ToString

        Try
            If Not oFTP.getFolders(galleries).Contains(syear) Then
                If MsgBox("No folder for  " & lYear.Text & vbCrLf & "Make one?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    If Not oFTP.makeDir(galleries & "/" & lYear.Text) Then
                        MsgBox(oFTP.errormessage)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Check database connection!" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click

        Me.Close()
    End Sub


    Private Sub bGetphoto_Click(sender As Object, e As EventArgs) Handles bGetphoto.Click
        Try
            If tbFilename.Text <> "" Then
                MsgBox("There is a photo selected")
                Exit Sub
            End If
            dlg.InitialDirectory = My.Settings.defaultfolder
            dlg.DefaultExt = ".jpg" ' Default file extension
            dlg.Filter = "Photos (.jpg)|*.jpg|Photos (.JPG)| *.JPG" ' Filter files by extension

            ' Show open file dialog box
            Dim result? As Boolean = dlg.ShowDialog()

            ' Process open file dialog box results
            If result = True Then
                ' Open document
                tbFilename.Text = dlg.FileName
                Try
                    My.Settings.defaultfolder = Path.GetDirectoryName(tbFilename.Text)
                Catch ex As Exception

                End Try

            End If
            photo.Image = New Bitmap(tbFilename.Text)
            bGetphoto.Enabled = False
            dtpDate.Value = My.Computer.FileSystem.GetFileInfo(tbFilename.Text).CreationTime
            localpath = tbFilename.Text
            sphoto = My.Computer.FileSystem.GetFileInfo(localpath).Name
            lWidth.Text = "width " & photo.Width & " pixels"
            lHeight.Text = "height " & photo.Height & " pixels"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click
        reset()
    End Sub

    Private Sub tbCaption_TextChanged(sender As Object, e As EventArgs) Handles tbCaption.TextChanged
        bUpload.Enabled = True
    End Sub

    Private Sub bUpload_Click(sender As Object, e As EventArgs) Handles bUpload.Click
        If tbFilename.Text = "" Then Exit Sub
        sfolder = lYear.Text

        If MsgBox("This will upload selected photo to website folder " & sfolder, MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
            reset()
            Exit Sub
        End If
        Upload()
        reset()
    End Sub
    Private Sub Upload()

        Dim sdate As String, caption As String
        Dim remotefile As String = remotepath & "/" & sphoto
        'MsgBox(localpath & vbCrLf & remotefile)
        If Not oFTP.Upload(localpath, remotefile) Then
            MsgBox(oFTP.errormessage)
            Exit Sub
        End If
        Try
            sdate = dtpDate.Value.ToShortDateString
            caption = tbCaption.Text
            Chrisbarton_grg10DataSet.PHOTOALBUM.AddPHOTOALBUMRow(sphoto, sfolder, caption, sdate)
            MsgBox("1 file uploaded and record created")
            savePhotos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub savePhotos()
        Me.Validate()
        Me.PHOTOALBUMBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Chrisbarton_grg10DataSet)

    End Sub
End Class