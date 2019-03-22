Imports System.IO, System.Net, FluentFTP

Public Class FTPutility

    'Dim ftpurl As String = "ftp.glenrothesramblers.co.uk"
    'Dim user As String = "chrisbarton"
    'Dim pword As String = "G@rf0rt#"
    'Dim client As New FtpClient
    'Dim oFTP As New FTPutility(ftpurl, basedir, user, pword)

    Public errormessage As String = ""
    Public singleConn As Boolean = True
    Dim client As New FtpClient

    Public Sub New(url As String, usr As String, pw As String)
        Dim ftpurl As String = url.TrimEnd("/")

        Dim user As String = usr
        Dim pword As String = pw
        client.Host = ftpurl
        client.Credentials = New NetworkCredential(user, pword)
    End Sub

    Public Sub connect()
        Try
            singleConn = False
            client.Connect()
        Catch ex As Exception
            errormessage = ex.Message
        End Try

    End Sub

    Public Sub disconnect()
        Try
            client.Disconnect()
            singleConn = True
        Catch ex As Exception
            errormessage = ex.Message
        End Try

    End Sub

    Public Function Upload(localfile As String, remotefile As String) As Boolean 'localfile = full file path , remotefile path inc basedir/
        errormessage = ""
        'remotefile = basedir & remotefile
        Try
            If singleConn Then client.Connect()
            client.UploadFile(localfile, remotefile)
            If singleConn Then client.Disconnect()
            Return True
        Catch ex As Exception
            errormessage = ex.Message
            Return False
        End Try
    End Function

    Public Function Download(localfile As String, remotefile As String) As Boolean 'localfile = full file path , remotefile path inc basedir/
        errormessage = ""
        'remotefile = basedir & remotefile
        Try
            If singleConn Then client.Connect()
            client.DownloadFile(localfile, remotefile)
            If singleConn Then client.Disconnect()
            Return True
        Catch ex As Exception
            errormessage = ex.Message
            Return False
        End Try
    End Function

    Public Function Deletefile(filestr As String) As Boolean 'filestr is path 
        errormessage = ""
        Try
            Dim dfile As String = filestr
            If singleConn Then client.Connect()
            client.DeleteFile(dfile)
            If singleConn Then client.Disconnect()
            Return True
        Catch ex As Exception
            errormessage = ex.Message
            Return False
        End Try
    End Function

    Public Function Renamefile(oldnm As String, newnm As String) As Boolean 'nms is path
        errormessage = ""
        Try
            Dim oldfile As String = oldnm
            Dim newfile As String = newnm
            If singleConn Then client.Connect()
            client.Rename(oldfile, newfile)
            If singleConn Then client.Disconnect()
            Return True
        Catch ex As Exception
            errormessage = ex.Message
            Return False
        End Try
    End Function

    Public Function getFiles(sfolder As String) As String 'sfolder is folder/ fails with #error#
        errormessage = ""
        Dim sfiles As String = ""
        Try
            If singleConn Then client.Connect()
            For Each item In client.GetListing(sfolder)
                If item.Type = 0 Then
                    sfiles += item.Name & vbCrLf
                End If
            Next
            If singleConn Then client.Disconnect()
            Return sfiles
        Catch ex As Exception
            errormessage = ex.Message
            Return "#error# " & errormessage
        End Try
    End Function

    Public Function getFileDates(sfolder As String) As String 'sfolder is folder/ fails with #error#
        errormessage = ""
        Dim sfiles As String = ""
        Try
            If singleConn Then client.Connect()
            For Each item In client.GetListing(sfolder)
                If item.Type = 0 Then
                    sfiles += item.Modified & vbCrLf
                End If
            Next
            If singleConn Then client.Disconnect()
            Return sfiles
        Catch ex As Exception
            errormessage = ex.Message
            Return "#error# " & errormessage
        End Try
    End Function

    Public Function getFolders(sfolder As String) As String 'sfolder is folder/
        errormessage = ""
        Dim sfiles As String = ""
        Try
            If singleConn Then client.Connect()
            For Each item In client.GetListing(sfolder)
                If item.Type = 1 Then
                    sfiles += item.Name & vbCrLf
                End If
            Next
            If singleConn Then client.Disconnect()
            Return sfiles
        Catch ex As Exception
            errormessage = ex.Message
            Return "#error# " & errormessage
        End Try
    End Function

    Public Function makeDir(sDir As String) As Boolean
        Try
            Dim dfile As String = sDir
            If singleConn Then client.Connect()
            client.CreateDirectory(dfile)
            If singleConn Then client.Disconnect()
            Return True
        Catch ex As Exception
            errormessage = ex.Message
            Return False

        End Try
    End Function


    Public Function removeDir(sDir As String) As Boolean
        Try
            Dim dfile As String = sDir
            If singleConn Then client.Connect()
            client.DeleteDirectory(dfile)
            If singleConn Then client.Disconnect()
            Return True
        Catch ex As Exception
            errormessage = ex.Message
            Return False

        End Try
    End Function



End Class
