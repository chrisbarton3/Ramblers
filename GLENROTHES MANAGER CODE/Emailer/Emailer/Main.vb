Imports System.ComponentModel
Imports System.Net, System.Net.Mail, System.IO


Public Class frmMain
    Dim oSmtpserver As New SmtpClient
    Dim appPath As String = My.Application.Info.DirectoryPath
    Dim fntsize As Integer = 12
    Dim saved As Boolean = True
    Dim docfntrtf As Integer = 24
    Dim docfntpts As Integer = 12
    Dim bodyhtml As String


#Region "FORM CODE"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Chrisbarton_grg10DataSet.contacts' table. You can move, or remove it, as needed.
        Try
            Me.ContactsTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.contacts)
        Catch ex As Exception
            MsgBox("Unable to load database!" & vbCrLf & ex.Message)
        End Try

        getSettings()
        If My.Settings.currentBody = "" Then bLastEmail.Enabled = False

        With oSmtpserver
            .Credentials = New Net.NetworkCredential(My.Settings.account, My.Settings.password)
            .Port = 587
            .EnableSsl = True
            .Host = My.Settings.mailserver
        End With
        setDelAttached()
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not saved Then
            If MsgBox("Save changes?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                saveThisEmail()
                e.Cancel = False
            Else
                e.Cancel = False
            End If

        End If
    End Sub
    Private Sub getSettings()
        With My.Settings
            tbemailServer.Text = .mailserver
            tbServerAccount.Text = .account
            tbPassword.Text = .password
            tbFromEmail.Text = .fromemail
            tbFromName.Text = .fromname
            tbResults.Text = .history
            docfntpts = .currentFsize

        End With

    End Sub

    Private Sub setSettings()
        With My.Settings
            .mailserver = tbemailServer.Text
            .account = tbServerAccount.Text
            .password = tbPassword.Text
            .fromemail = tbFromEmail.Text
            .fromname = tbFromName.Text
        End With
        My.Settings.Save()
    End Sub


    Private Sub bShowPreview_Click(sender As Object, e As EventArgs) Handles bShowPreview.Click
        My.Forms.Preview.Show()
        My.Forms.Preview.hideControls()
    End Sub



#End Region

#Region "SELECT RECIPIENTS CODE"


    Private Sub tsbSelectAll_Click(sender As Object, e As EventArgs) Handles tsbSelectAll.Click
        ContactsDataGridView.SelectAll()
    End Sub

    Private Sub tsbSelectNone_Click(sender As Object, e As EventArgs) Handles tsbSelectNone.Click
        clearGrid()

    End Sub

    Private Sub clearGrid()
        For ix As Integer = 0 To ContactsDataGridView.Rows.Count - 1
            ContactsDataGridView.Rows(ix).Selected = False
        Next
    End Sub

    Private Sub tsbClearSend_Click(sender As Object, e As EventArgs) Handles tsbClearSend.Click
        clearSend()

    End Sub

    Private Sub clearSend()
        SendEmailsList.Items.Clear()

    End Sub

    Private Sub tsbUpdate_Click(sender As Object, e As EventArgs) Handles tsbUpdate.Click
        Dim ix As Integer
        If SendEmailsList.Items.Count > 0 Then
            If MessageBox.Show("Delete existing items first?", "Confirm delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                SendEmailsList.Items.Clear()
            End If
        End If

        For ix = 0 To ContactsDataGridView.SelectedRows.Count - 1
            With ContactsDataGridView.SelectedRows(ix)
                If checkValid(.Cells(1).Value) Then
                    SendEmailsList.Items.Add(.Cells(0).Value & ";" & .Cells(1).Value)
                Else
                    MessageBox.Show("Duplicate value", "")
                End If
            End With
        Next
        lCount.Text = "Selected recipients = " & SendEmailsList.Items.Count.ToString
        clearGrid()
    End Sub

    Private Function checkValid(checkstr As String) As Boolean
        For ix As Integer = 0 To SendEmailsList.Items.Count - 1
            If SendEmailsList.Items(ix).ToString().Contains(checkstr) Then
                Return False
            End If
        Next
        Return True
    End Function


    Private Sub tsbDelSendItem_Click(sender As Object, e As EventArgs) Handles tsbDelSendItem.Click
        If SendEmailsList.SelectedItems.Count = 0 Then Exit Sub
        Try
            Dim ix As Integer = SendEmailsList.SelectedIndex
            SendEmailsList.Items.RemoveAt(ix)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tsbNewEmailAddr_Click(sender As Object, e As EventArgs) Handles tsbNewEmailAddr.Click
        My.Forms.newEmail.ShowDialog()
    End Sub
    Private Sub clearSentItems()

        SendEmailsList.Items.Clear()
        SendEmailsList.Refresh()
        lCount.Text = "Selected recipients = 0"
    End Sub

#End Region

#Region "SENDING CODE"

    Private Sub bSendOneBatch_Click(sender As Object, e As EventArgs) Handles bSendOneBatch.Click
        If tbHeading.Text <> "" And SendEmailsList.Items.Count > 0 Then
            saveThisEmail()
            My.Forms.Preview.ShowDialog()
        Else
            MessageBox.Show("Some essential items are blank!")
        End If
    End Sub

    Public Sub sendSingleBatch()

        Dim cnt As Integer = 0

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim lastix As Integer = SendEmailsList.Items.Count - 1

            For ix As Integer = 0 To lastix
                sendOneEmail(ix)
                cnt += 1
            Next
            clearSentItems()

            tbResults.Text += vbCrLf & Now.ToShortDateString & " : " & "***************END OF BATCH*****************"
            My.Settings.history += tbResults.Text
            Me.Cursor = Cursors.Default
            MessageBox.Show("Email batch sent, " & cnt & " items")

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub sendOneEmail(index As Integer)
        Dim emls(1) As String
        Try

            Dim oMessage As New MailMessage
            Dim eml As String = SendEmailsList.Items(index).ToString
            emls = Split(eml, ";")
            With oMessage
                Dim oRTF As New RTFtoHTML
                oMessage.Subject = My.Settings.currentHeading
                oMessage.Body = oRTF.convert(My.Settings.currentBody, My.Settings.currentFsize)
                If My.Settings.currentattachment <> "" Then
                    Dim oAtt As Attachment = New Attachment(My.Settings.currentattachment)
                    .Attachments.Add(oAtt)
                End If
                .IsBodyHtml = True
                .From = New MailAddress(My.Settings.fromemail, My.Settings.fromname)
                .To.Add(New MailAddress(emls(1), emls(0)))

                Try
                        oSmtpserver.Send(oMessage)
                        tbResults.Text += vbCrLf & Now.ToShortDateString & " : " & emls(0) & ", " & emls(1) & " ...sent"
                        tbResults.Refresh()
                    Catch ex As Exception
                        MsgBox("Unable to send email to " & emls(0) & vbCrLf & ex.Message)
                    End Try

            End With
            oMessage.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub bClearHistory_Click(sender As Object, e As EventArgs) Handles bClearHistory.Click
        tbResults.Text = ""
        My.Settings.history = ""
    End Sub

    Private Sub bSaveSettings_Click(sender As Object, e As EventArgs) Handles bSaveSettings.Click
        setSettings()
    End Sub

#End Region

#Region "COMPOSER CODE"


    Private Sub saveMessage(sender As Object, e As EventArgs) Handles bSaveMessage.Click
        saveThisEmail()
    End Sub

    Private Sub bAttach_Click(sender As Object, e As EventArgs) Handles bAttach.Click
        Try
            If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                attachFile.Text = OpenFileDialog1.FileName
                setDelAttached()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub setDelAttached()
        If attachFile.Text <> "" Then
            llDelAttached.Visible = True
            llDelAttached.Location() = New Point(168 + attachFile.Width, 47)
        End If

    End Sub
    Private Sub saveThisEmail()
        Try
            With My.Settings
                .currentattachment = attachFile.Text
                .currentBody = tbRTF.Rtf
                .currentHeading = tbHeading.Text
                .currentFsize = docfntpts
            End With
            bLastEmail.Enabled = True
            My.Settings.Save()
            saved = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub bNewEmail_Click(sender As Object, e As EventArgs) Handles bNewEmail.Click

        If tbRTF.Text = "" Then
            NewEmail()
            Exit Sub
        End If
        If MsgBox("Do you want to save this email?", vbYesNo, "Save Email") = vbYes Then
            saveThisEmail()
        End If
        NewEmail()
    End Sub

    Private Sub NewEmail()

        tbRTF.Text = ""
        tbHeading.Text = ""
        attachFile.Text = ""

    End Sub

    Private Sub llDelAttached_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llDelAttached.LinkClicked
        attachFile.Text = ""
        llDelAttached.Visible = False
    End Sub

    Private Sub bLastEmail_Click(sender As Object, e As EventArgs) Handles bLastEmail.Click
        getLastEmail()

    End Sub

    Private Sub getLastEmail()
        Try
            With My.Settings
                tbRTF.Rtf = .currentBody
                tbHeading.Text = .currentHeading
                attachFile.Text = .currentattachment
                docfntpts = .currentFsize
                saved = True
                setDelAttached()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function getPreview() As String
        Dim oRTF As New RTFtoHTML
        bodyhtml = oRTF.convert(tbRTF.Rtf, docfntpts)
        Return bodyhtml
    End Function

    Private Sub bPreview_Click(sender As Object, e As EventArgs)
        My.Forms.Preview.Show()
    End Sub

    Private Sub bBold_Click(sender As Object, e As EventArgs) Handles bBold.Click
        If tbRTF.SelectedText = "" Then Exit Sub
        Dim cx As Integer = tbRTF.SelectionFont.Style
        setFontstyle(cx, 1)

    End Sub

    Private Sub bItalic_Click(sender As Object, e As EventArgs) Handles bItalic.Click
        If tbRTF.SelectedText = "" Then Exit Sub
        Dim cx As Integer = tbRTF.SelectionFont.Style
        setFontstyle(cx, 2)

    End Sub

    Private Sub bUline_Click(sender As Object, e As EventArgs) Handles bUline.Click
        If tbRTF.SelectedText = "" Then Exit Sub
        Dim cx As Integer = tbRTF.SelectionFont.Style
        setFontstyle(cx, 4)

    End Sub

    Private Sub bLink_Click(sender As Object, e As EventArgs) Handles bLink.Click
        If tbRTF.SelectedText = "" Then
            MsgBox("No text selected to add link")
            Exit Sub
        End If
        Dim urls = InputBox("Input URL")
        If urls = "" Then Exit Sub
        If Not (urls.Contains("http://") Or urls.Contains("https://")) Then
            urls = "http://" & urls
        End If
        Dim sel As String = tbRTF.SelectedText
        Dim rep As String = sel
        sel = "[" & urls & "][" & sel & "]"
        tbRTF.SelectedText = tbRTF.SelectedText.Replace(rep, sel)
    End Sub

    Private Sub tbRTF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbRTF.KeyPress
        If e.KeyChar = "\" Or e.KeyChar = "{" Or e.KeyChar = "}" Or e.KeyChar = "[" Or e.KeyChar = "]" Then
            e.Handled = True
            MsgBox("Characters \, {} and [] can't be used in emails" & vbCrLf & "and will be deleted")

        End If
    End Sub

    Private Sub ll12pt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll12pt.LinkClicked
        Dim fs As String = "\fs" & docfntrtf.ToString
        docfntpts = 12
        docfntrtf = 24
        tbRTF.Rtf = tbRTF.Rtf.Replace(fs, "\fs24")
        tbRTF.Refresh()
    End Sub

    Private Sub ll14pt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll14pt.LinkClicked
        Dim fs As String = "\fs" & docfntrtf.ToString
        docfntpts = 14
        docfntrtf = 29
        tbRTF.Rtf = tbRTF.Rtf.Replace(fs, "\fs29")
        tbRTF.Refresh()
    End Sub

    Private Sub ll18pt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll18pt.LinkClicked
        Dim fs As String = "\fs" & docfntrtf.ToString
        docfntpts = 18
        docfntrtf = 36
        tbRTF.Rtf = tbRTF.Rtf.Replace(fs, "\fs36")
        tbRTF.Refresh()
    End Sub


    Private Sub setFontstyle(cx As Integer, nx As Integer)
        Select Case cx
            Case 0
                Dim nfont As New Font(tbRTF.Font, cx + nx)
                tbRTF.SelectionFont = nfont
            Case 1
                If nx = 1 Then
                    Dim nfont As New Font(tbRTF.Font, cx - nx)
                    tbRTF.SelectionFont = nfont
                Else
                    Dim nfont As New Font(tbRTF.Font, cx + nx)
                    tbRTF.SelectionFont = nfont
                End If
            Case 2
                If nx = 2 Then
                    Dim nfont As New Font(tbRTF.Font, cx - nx)
                    tbRTF.SelectionFont = nfont
                Else
                    Dim nfont As New Font(tbRTF.Font, cx + nx)
                    tbRTF.SelectionFont = nfont
                End If
            Case 3
                If nx = 4 Then
                    Dim nfont As New Font(tbRTF.Font, cx + nx)
                    tbRTF.SelectionFont = nfont
                Else
                    Dim nfont As New Font(tbRTF.Font, cx - nx)
                    tbRTF.SelectionFont = nfont
                End If
            Case 4
                If nx = 4 Then
                    Dim nfont As New Font(tbRTF.Font, cx - nx)
                    tbRTF.SelectionFont = nfont
                Else
                    Dim nfont As New Font(tbRTF.Font, cx + nx)
                    tbRTF.SelectionFont = nfont
                End If
            Case 5
                If nx = 2 Then
                    Dim nfont As New Font(tbRTF.Font, cx + nx)
                    tbRTF.SelectionFont = nfont
                Else
                    Dim nfont As New Font(tbRTF.Font, cx - nx)
                    tbRTF.SelectionFont = nfont
                End If
            Case 6
                If nx = 1 Then
                    Dim nfont As New Font(tbRTF.Font, cx + nx)
                    tbRTF.SelectionFont = nfont
                Else
                    Dim nfont As New Font(tbRTF.Font, cx - nx)
                    tbRTF.SelectionFont = nfont
                End If
            Case 7
                Dim nfont As New Font(tbRTF.Font, cx - nx)
                tbRTF.SelectionFont = nfont
        End Select
    End Sub

    Private Sub tbRTF_TextChanged(sender As Object, e As EventArgs) Handles tbRTF.TextChanged
        If tbRTF.Text <> "" Then
            saved = False
        Else
            saved = True
        End If
    End Sub

#End Region

End Class
