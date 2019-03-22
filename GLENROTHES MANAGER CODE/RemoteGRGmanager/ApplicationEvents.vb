Imports System.IO, System.Net
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Dim apppath As String = My.Application.Info.DirectoryPath & "\FluentFTP.dll"
            If Not File.Exists(apppath) Then
                If MsgBox("Required file missing - FluentFTP.dll" & vbCrLf & "Click OK to download from internet.", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    LoadDLL(apppath)
                End If

            End If
        End Sub

        Private Sub LoadDLL(localfile As String)
            Try
                Dim wc As New WebClient With {
                              .Credentials = New NetworkCredential(My.Settings.ftpuser, My.Settings.ftppword)
                          }
                Dim remotefile As String = "ftp://" & My.Settings.ftpurl & "/httpdocs/bin/FluentFTP.dll"
                wc.DownloadFile(remotefile, localfile)
            Catch ex As Exception
                MsgBox("File download failed." & vbCrLf & ex.Message)
            End Try

        End Sub

    End Class


End Namespace
