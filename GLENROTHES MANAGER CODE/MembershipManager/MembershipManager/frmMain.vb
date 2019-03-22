Imports System.IO

Public Class Main

    Dim appPath As String = My.Application.Info.DirectoryPath
    Dim XlsPath As String = appPath & "\XLSs\"
    Dim PdfPath As String = appPath & "\PDFs\"
    Dim thismonth As String = MonthName(Now.Month) & Now.Year

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LocalEmailsTableAdapter.Fill(Me.MembershipDataSet.LocalEmails)
        Me.LocalPostalListTableAdapter.Fill(Me.MembershipDataSet.LocalPostalList)
    End Sub
    Private Sub LoadData()
        Try
            Cursor.Current = Cursors.WaitCursor
            Me.Full_ListTableAdapter.Fill(Me.MembershipDataSet.Full_List)
            Me.PostalListTableAdapter.Fill(Me.MembershipDataSet.PostalList)
            Me.OrphanedEmailsTableAdapter.Fill(Me.MembershipDataSet.OrphanedEmails)
            Me.UnusedEmailsTableAdapter.Fill(Me.MembershipDataSet.UnusedEmails)
            Me.HouseholdsTableAdapter.Fill(Me.MembershipDataSet.Households)
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox("Unable to load database!" & vbCrLf & ex.Message)
            Me.Close()
        End Try

    End Sub

    Private Sub SaveAll()
        Try
            Cursor.Current = Cursors.WaitCursor
            Me.Validate()
            Me.LocalPostalListBindingSource.EndEdit()
            Me.LocalEmailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MembershipDataSet)
            Me.LocalEmailsTableAdapter.Fill(Me.MembershipDataSet.LocalEmails)
            Me.LocalPostalListTableAdapter.Fill(Me.MembershipDataSet.LocalPostalList)
            Cursor.Current = Cursors.Default
            MsgBox("Local tables saved")
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TSBreload_Click(sender As Object, e As EventArgs) Handles TSBreload.Click
        LoadData()
    End Sub

    Private Sub GetJoint()
        If _06_Joint_WithTextBox.Text = "" Then Exit Sub
        Try
            Dim jntix As String = _06_Joint_WithTextBox.Text
            Dim joint As String
            For ix As Integer = 0 To MembershipDataSet.Full_List.Rows.Count - 1
                With MembershipDataSet.Full_List(ix)
                    If ._01_Membership_Number = jntix Then
                        joint = ._07_Title & " " & ._08_Initials & " " & ._10_Surname & vbCrLf
                        joint += ._11_Address1 & ", " & ._14_Town & ", " & ._16_Postcode & vbCrLf
                        joint += ._18_Email_Address
                        LblJoint.Text = joint
                        Exit Sub
                    End If
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DetailsPage_Enter(sender As Object, e As EventArgs) Handles DetailsPage.Enter
        GetJoint()
    End Sub

    Private Sub Full_ListDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Full_ListDataGridView.CellDoubleClick
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub TSBmakepostal_Click(sender As Object, e As EventArgs) Handles TSBmakepostal.Click
        If MsgBox("This will delete any current data. Proceed?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        Try
            For ix = 0 To MembershipDataSet.LocalPostalList.Rows.Count - 1
                MembershipDataSet.LocalPostalList(ix).Delete()
            Next
            Dim contact As String, addr2 As String
            For ix = 0 To MembershipDataSet.PostalList.Rows.Count - 1
                With MembershipDataSet.PostalList(ix)
                    contact = ._07_Title & " " & ._08_Initials & " " & ._10_Surname
                    addr2 = ._12_Address2 & " " & ._13_Address3
                    MembershipDataSet.LocalPostalList.AddLocalPostalListRow(contact, ._11_Address1, addr2, ._14_Town, ._16_Postcode)
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TSBsaveall_Click(sender As Object, e As EventArgs) Handles TSBsaveall.Click
        SaveAll()
    End Sub

    Private Sub LLdeleteemail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLdeleteemail.LinkClicked
        Dim delid As String = OrphanedEmailsDataGridView.SelectedRows(0).Cells(0).Value.ToString
        Dim deleml As String = OrphanedEmailsDataGridView.SelectedRows(0).Cells(2).Value.ToString
        If MsgBox("Remove " & deleml & " from list?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
            Exit Sub
        End If

        Try
            For ix As Integer = 0 To MembershipDataSet.LocalEmails.Rows.Count - 1
                With MembershipDataSet.LocalEmails(ix)
                    If .ID = delid Then
                        LocalEmailsBindingSource.RemoveAt(ix)
                        SaveAll()
                        Exit Sub
                    End If
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LLaddnewemail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLaddnewemail.LinkClicked
        With UnusedEmailsDataGridView.SelectedRows(0)
            Dim neweml As String = .Cells(1).Value.ToString
            If MsgBox("Add email to local list? - " & neweml, MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub

            Dim newid As String = .Cells(0).Value.ToString
            Dim newcontact As String = .Cells(3).Value.ToString & " " & .Cells(4).Value.ToString & " " & .Cells(5).Value.ToString
            Dim newsn As String = .Cells(5).Value.ToString

            LocalEmailsBindingSource.AddNew()
            IDTextBox.Text = newid
            SURNAMETextBox.Text = newsn
            CONTACTTextBox.Text = newcontact
            EMAILTextBox.Text = neweml
        End With
    End Sub

    Private Sub Bcomposeemail_Click(sender As Object, e As EventArgs) Handles Bcomposeemail.Click
        If EMAILTextBox.Text = "" Then Exit Sub
        Dim indexurl As String = "mailto:" & EMAILTextBox.Text
        System.Diagnostics.Process.Start(indexurl)
    End Sub

    Private Sub TSBarchivepdf_Click(sender As Object, e As EventArgs) Handles TSBarchivepdf.Click

        Dim currentpdf As String = thismonth & ".pdf"
        Dim pdffile As String = OpenUploadFile("pdf")
        Dim pdfname As String = Path.GetFileName(pdffile)
        If pdffile = "" Then Exit Sub

        Try
            File.Copy(pdffile, PdfPath & currentpdf)
            MsgBox(pdfname & " archived as " & currentpdf)
        Catch ex As Exception
            MsgBox("Archive failed" & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Function OpenUploadFile(filter As String) As String
        Dim sfilter As String
        If filter = "pdf" Then
            sfilter = "PDF files|*.pdf"
        ElseIf filter = "jpg" Then
            sfilter = "JPEG files|*.jpg"
        ElseIf filter = "xlsx" Then
            sfilter = "XLSX files|*.xlsx"
        Else
            sfilter = "All files|*.*"
        End If

        dlg.InitialDirectory = appPath
        dlg.Filter = sfilter
        dlg.FileName = ""
        ' Show open file dialog box
        Dim result As Boolean = dlg.ShowDialog()

        ' Process open file dialog box results
        If result = True Then
            ' Open document

            Return dlg.FileName

        Else
            Return ""

        End If
    End Function

    Private Sub TSBarchivexls_Click(sender As Object, e As EventArgs) Handles TSBarchivexls.Click
        archiveMemberlist()
    End Sub

    Private Sub archiveMemberlist()

        Dim currentxls As String = XlsPath & thismonth & ".xlsx"
        Dim memberlist As String
        Try
            memberlist = appPath & "\memberlist.xlsx"
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        If MsgBox("Archive current Memberlist?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        Try
            FileCopy(memberlist, currentxls)
            MsgBox("Memberlist archived as " & currentxls)
        Catch ex As Exception
            MsgBox("Archive failed" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub TSBmemberlist_Click(sender As Object, e As EventArgs) Handles TSBmemberlist.Click
        archiveMemberlist()
        Dim newmemberlist As String = OpenUploadFile("xlsx")
        If newmemberlist = "" Then Exit Sub
        If MsgBox("Update Memberlist from file? - " & Path.GetFileName(newmemberlist), MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        FileCopy(newmemberlist, appPath & "/memberlist.xlsx")
        LoadData()
        MsgBox("Memberlist updated and saved")
    End Sub
End Class


