Imports System.Windows.Forms

Public Class Dialog1
    Dim localpath As String
    Dim remotepath As String
    Dim user As String
    Dim pword As String

    Private Sub bReset_Click(sender As Object, e As EventArgs)
        getDefaultSettings()

    End Sub

    Private Sub getDefaultSettings()

        Dim conn As String = My.Settings.chrisbarton_grg10ConnectionString
        TextBox1.Text = conn
        remotepath = My.Settings.ftpurl
        tbUser.Text = My.Settings.ftpuser
        tbPassword.Text = My.Settings.ftppword
        localpath = My.Settings.defaultLocalPath
        'localpath = localpath.TrimEnd("\")
        tbLocal.Text = localpath
        'remotepath = remotepath.TrimEnd("/")
        tbRemote.Text = remotepath
        TBbasedir.Text = My.Settings.basedir
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles Me.Load
        getDefaultSettings()

    End Sub

    Private Sub bSavesettings_Click(sender As Object, e As EventArgs) Handles bSavesettings.Click
        My.Settings.defaultLocalPath = tbLocal.Text
        My.Settings.ftpurl = tbRemote.Text
        My.Settings.ftpuser = tbUser.Text
        My.Settings.ftppword = tbPassword.Text
        My.Settings.basedir = TBbasedir.Text
        My.Settings.Save()
    End Sub
End Class