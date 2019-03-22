Imports System.ComponentModel
Imports System.Net, System.Net.Mail, System.IO


Public Class frmMain
    Dim oSmtpserver As New SmtpClient
    Dim appPath As String = My.Application.Info.DirectoryPath
    Dim fntsize As Integer = 12
    Dim saved As Boolean = True
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
            fntsize = .currentFsize

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
            sendEmailBatch()
        Else
            MessageBox.Show("Some essential items are blank!")
        End If
    End Sub

    Public Sub sendEmailBatch()

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

                oMessage.Subject = My.Settings.currentHeading
                oMessage.Body = My.Settings.currentBody
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
                .currentBody = bodyhtml
                .currentHeading = tbHeading.Text
                .currentFsize = fntsize
            End With
            bLastEmail.Enabled = True
            My.Settings.Save()
            saved = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub bNewEmail_Click(sender As Object, e As EventArgs) Handles bNewEmail.Click

        If TBHtml.Text = "" Then
            NewEmail()
            Exit Sub
        End If
        If MsgBox("Do you want to save this email?", vbYesNo, "Save Email") = vbYes Then
            saveThisEmail()
        End If
        NewEmail()
    End Sub

    Private Sub NewEmail()

        TBHtml.Text = ""
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
        Dim head As String
        Try
            With My.Settings
                tbHeading.Text = .currentHeading
                attachFile.Text = .currentattachment
                fntsize = .currentFsize
                head = .htmlheader & fntsize & "pt" & Chr(34) & ">"
                .currentBody = .currentBody.Replace(head, "")
                TBHtml.Text = .currentBody.Replace(.htmlfooter, "")
                saved = True
                setDelAttached()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TBHtml_TextChanged(sender As Object, e As EventArgs) Handles TBHtml.TextChanged
        bodyhtml = My.Settings.htmlheader & fntsize & "pt" & Chr(34) & ">" & TBHtml.Text & My.Settings.htmlfooter
        WBpreview.DocumentText = bodyhtml
    End Sub



    Private Sub TBHtml_LostFocus(sender As Object, e As EventArgs) Handles TBHtml.LostFocus
        saveThisEmail()

    End Sub

    Private Sub ll12pt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll12pt.LinkClicked
        fntsize = 12
        WBpreview.DocumentText = bodyhtml
    End Sub

    Private Sub ll14pt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll14pt.LinkClicked
        fntsize = 14
        WBpreview.DocumentText = bodyhtml
    End Sub

    Private Sub ll18pt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll18pt.LinkClicked
        fntsize = 18
        WBpreview.DocumentText = bodyhtml
    End Sub

    Private Sub bBold_Click(sender As Object, e As EventArgs) Handles bBold.Click
        If TBHtml.Text.Contains("<b>") Then
            TBHtml.Text = TBHtml.Text.Replace("<b>", "")
            TBHtml.Text = TBHtml.Text.Replace("</b>", "")
        Else
            TBHtml.SelectedText = "<b>" & TBHtml.SelectedText & "</b>"
        End If

    End Sub

    Private Sub bItalic_Click(sender As Object, e As EventArgs) Handles bItalic.Click
        If TBHtml.Text.Contains("<i>") Then
            TBHtml.Text = TBHtml.Text.Replace("<i>", "")
            TBHtml.Text = TBHtml.Text.Replace("</i>", "")
        Else
            TBHtml.SelectedText = "<i>" & TBHtml.SelectedText & "</i>"
        End If
    End Sub

    Private Sub bUline_Click(sender As Object, e As EventArgs) Handles bUline.Click
        If TBHtml.Text.Contains("<u>") Then
            TBHtml.Text = TBHtml.Text.Replace("<u>", "")
            TBHtml.Text = TBHtml.Text.Replace("</u>", "")
        Else
            TBHtml.SelectedText = "<u>" & TBHtml.SelectedText & "</u>"
        End If
    End Sub

    Private Sub TBHtml_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBHtml.KeyPress
        If e.KeyChar = Chr(13) Then
            TBHtml.SelectedText = "<br/>"
        End If

    End Sub

    Private Sub bLink_Click(sender As Object, e As EventArgs) Handles bLink.Click
        TBHtml.SelectedText = "<a href=" & Chr(34) & "paste url here" & Chr(34) & ">" & TBHtml.SelectedText & "</a>"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BList.Click
        TBHtml.SelectedText = "<ul>" & vbCrLf & "<li>" & TBHtml.SelectedText & "</li>" & vbCrLf & "</ul>"
    End Sub

    Private Sub BListitem_Click(sender As Object, e As EventArgs) Handles BListitem.Click
        TBHtml.SelectedText = "<li>" & TBHtml.SelectedText & "</li>" & vbCrLf
    End Sub


#End Region



End Class
