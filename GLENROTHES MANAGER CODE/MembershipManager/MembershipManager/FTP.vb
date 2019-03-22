Imports System.IO, System.Net, System.Data


Module FTP

    Dim remotepath As String = My.Settings.ftpurl
    Dim user As String = My.Settings.ftpuser
    Dim pword As String = My.Settings.ftppword

    Public Function upLoad(localfile, remotefile) As String

        'localfile = full file path 
        'remotefile is path after ... /httpdocs/
        remotefile = remotepath & remotefile
        Try
            'upload code
            Dim client As New WebClient

            client.Credentials = New NetworkCredential(user, pword)

            client.UploadFile(remotefile, localfile)

            Return "ok"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function deleteFile(filestr As String) As String
        Try
            'delete File
            Try
                Dim dfile As String = remotepath & filestr
                Dim request As FtpWebRequest = WebRequest.Create(dfile)

                request.Method = WebRequestMethods.Ftp.DeleteFile

                request.Credentials = New NetworkCredential(user, pword)
                request.Timeout = 200000
                Dim response As FtpWebResponse = CType(request.GetResponse(), FtpWebResponse)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return "ok"
        Catch ex As Exception
            Return ex.Message

        End Try
    End Function

    Public Function getFiles(sfolder As String) As String 'sfolder is folder/
        Try
            Dim dir As String = ""
            Dim request As FtpWebRequest = WebRequest.Create(remotepath & sfolder)
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails
            request.Credentials = New NetworkCredential(user, pword)
            request.Timeout = 200000
            Dim response As WebResponse = request.GetResponse
            Dim responseStream As Stream = response.GetResponseStream
            Dim buffer(1024) As Byte
            Dim bRead As Integer = responseStream.Read(buffer, 0, 1024)
            Dim localFileStream As New FileStream("Dir.txt", FileMode.Create)
            While bRead > 0
                localFileStream.Write(buffer, 0, bRead)
                bRead = responseStream.Read(buffer, 0, 1024)
            End While

            localFileStream.Close()
            responseStream.Close()
            Dim loadfile As New StreamReader("Dir.txt")
            Do Until loadfile.EndOfStream
                Dim sline As String = loadfile.ReadLine
                Dim shortsline As String = sline.Remove(0, 38)
                shortsline = shortsline.Trim()
                If Not sline.Contains("DIR") Then
                    dir = dir & vbCrLf & shortsline
                End If

            Loop
            loadfile.Close()
            File.Delete("Dir.txt")
            Return dir
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function getFolders(sfolder As String) As String 'sfolder is folder/
        Dim dir As String = ""
        Try
            Dim request As FtpWebRequest = WebRequest.Create(remotepath & sfolder)
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails
            request.Credentials = New NetworkCredential(user, pword)
            request.Timeout = 200000
            Dim response As WebResponse = request.GetResponse
            Dim responseStream As Stream = response.GetResponseStream
            Dim buffer(1024) As Byte
            Dim bRead As Integer = responseStream.Read(buffer, 0, 1024)
            Dim localFileStream As New FileStream("Dir.txt", FileMode.Create)
            While bRead > 0
                localFileStream.Write(buffer, 0, bRead)
                bRead = responseStream.Read(buffer, 0, 1024)
            End While
            localFileStream.Close()
            responseStream.Close()
            Dim loadfile As New StreamReader("Dir.txt")
            Do Until loadfile.EndOfStream
                Dim sline As String = loadfile.ReadLine
                Dim shortsline As String = sline.Remove(0, 38)
                shortsline = shortsline.Trim()
                If sline.Contains("DIR") Then
                    dir = dir & vbCrLf & shortsline
                End If
            Loop
            loadfile.Close()
            File.Delete("Dir.txt")
            Return dir
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function makeDir(sDir As String) As String
        Try
            Dim dfile As String = remotepath & "/" & sDir
            Dim request As FtpWebRequest = WebRequest.Create(dfile)
            request.Method = WebRequestMethods.Ftp.MakeDirectory
            request.Credentials = New NetworkCredential(user, pword)
            request.Timeout = 200000
            Dim response As FtpWebResponse = CType(request.GetResponse(), FtpWebResponse)
            response.Close()
            Return "ok"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Sub downloadPhoto(getfile As String)
        Dim appPath As String = My.Application.Info.DirectoryPath
        getfile = remotepath & getfile
        Dim sfile As String = appPath & "\temp.jpg"
        Try
            Dim localFileStream As New FileStream(sfile, FileMode.OpenOrCreate)
            Dim request As FtpWebRequest = WebRequest.Create(getfile)
            request.Method = WebRequestMethods.Ftp.DownloadFile
            request.Credentials = New NetworkCredential(user, pword)
            request.Timeout = 200000
            Dim response As WebResponse = request.GetResponse
            Dim responseStream As Stream = response.GetResponseStream
            Dim buffer(1024) As Byte
            Dim bRead As Integer = responseStream.Read(buffer, 0, 1024)
            While bRead > 0
                localFileStream.Write(buffer, 0, bRead)
                bRead = responseStream.Read(buffer, 0, 1024)
            End While
            responseStream.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub ReName(oldname As String, newname As String)
        Dim ftpStream As System.IO.Stream = Nothing
        Dim oldpath As String = remotepath & "Maps/" & oldname
        Dim reqFTP As System.Net.FtpWebRequest = CType(System.Net.FtpWebRequest.Create(New Uri(oldpath)), System.Net.FtpWebRequest)

        reqFTP.Method = System.Net.WebRequestMethods.Ftp.Rename
        reqFTP.RenameTo = Path.GetFileName(newname)
        reqFTP.UseBinary = True
        reqFTP.Credentials = New System.Net.NetworkCredential(user, pword)

        Dim response As System.Net.FtpWebResponse = DirectCast(reqFTP.GetResponse(), System.Net.FtpWebResponse)
        ftpStream = response.GetResponseStream()
        ftpStream.Close()
        response.Close()
    End Sub

End Module
