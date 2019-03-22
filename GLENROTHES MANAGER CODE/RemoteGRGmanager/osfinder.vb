Imports System.Web
Public Class osfinder
    Dim appPath As String = My.Application.Info.DirectoryPath
    Private Sub osfinder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim urlstr As String = "http://www.glenrothesramblers.co.uk/OS/OsGridrefFinder.htm"
        showURL(urlstr)
    End Sub


    Public Sub showURL(urlstr As String)
        Try

            WebBrowser1.Navigate(urlstr)

        Catch ex As Exception
            MsgBox("Image not found")
        End Try

    End Sub

    Public Sub showHelp()
        Dim shelp As String = My.Settings.helpSetting
        WebBrowser1.DocumentText = shelp
    End Sub
End Class