Public Class NewWalk
    Public Structure newWalkRow

        Dim name As String
        Dim town As String
        Dim descr As String
        Dim grade As String
        Dim dist As String
        Dim meet As String
        Dim start As String
        Dim time As String
        Dim place As String
        Dim grid As String
        Dim os As String
        Dim child As Boolean
        Dim dog As Boolean
        Dim map As String
        Dim gpx As String
        Dim asc As String
    End Structure

    Dim walk As newWalkRow

    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click
        Me.Close()
    End Sub

    Private Sub NewWalk_Load(sender As Object, e As EventArgs) Handles Me.Load
        walk.asc = ""
        walk.descr = ""
        walk.dist = ""
        walk.grade = ""
        walk.grid = ""
        walk.map = ""
        walk.meet = ""
        walk.os = ""
        walk.place = ""
        walk.start = ""
        walk.time = ""
        walk.town = ""
        walk.gpx = ""
        'TODO: This line of code loads data into the 'Chrisbarton_grg10DataSet.ALLWALKS' table. You can move, or remove it, as needed.
        Me.ALLWALKSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.ALLWALKS)
        'TODO: This line of code loads data into the 'Chrisbarton_grg10DataSet.TOWNS' table. You can move, or remove it, as needed.
        Me.TOWNSTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.TOWNS)
        'TODO: This line of code loads data into the 'Chrisbarton_grg10DataSet.TOWNS' table. You can move, or remove it, as needed.
        Me.ALLWALKSTableAdapter1.Fill(Me.Chrisbarton_grg10DataSet1.ALLWALKS)

    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        If NAMEtb.Text = "" Then
            MsgBox("There is no Walk Name!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If emptyFields() Then
            If MsgBox("Some required fields were not filled, Save anyway?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        End If
        'save changes
        With walk
            Chrisbarton_grg10DataSet1.ALLWALKS.AddALLWALKSRow(.name, .town, .descr, .grade, .dist, .meet, .start, .time, .place, .grid, .os, .child, .dog, .map, .asc, "", "", False, .gpx)
            Me.Validate()
            Me.ALLWALKSBindingSource1.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.Chrisbarton_grg10DataSet1)
            frmMain.ALLWALKSTableAdapter.Fill(frmMain.Chrisbarton_grg10DataSet.ALLWALKS)
            frmMain.ALLWALKSTableAdapter1.Fill(frmMain.Chrisbarton_grg10DataSet1.ALLWALKS)
            frmMain.addedWalk = .name
            MsgBox("New walk saved - " & .name)
        End With

        frmMain.additem = True
        Me.Close()

    End Sub

    Private Function emptyFields() As Boolean
        If TOWNtb.Text = "" Or PLACEtb.Text = "" Or OStb.Text = "" Or GRIDtb.Text = "" Or DESCRtb.Text = "" Or GRADEcb.Text = "" Or STARTcb.Text = "" Or MEETcb.Text = "" Or DISTcb.Text = "" Then
            Return True
        Else
            Return False

        End If
    End Function

    Private Function isDuplicate(walk As String) As Boolean
        For ix As Integer = 0 To Chrisbarton_grg10DataSet1.ALLWALKS.Rows.Count - 1
            If Chrisbarton_grg10DataSet1.ALLWALKS(ix)(1).ToString = walk Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub NAMEtb_Leave(sender As Object, e As EventArgs) Handles NAMEtb.Leave
        If NAMEtb.Text = "" Then Exit Sub
        If isDuplicate(NAMEtb.Text) Then
            MsgBox("This walk name is in use, please choose another", MsgBoxStyle.Critical)
            NAMEtb.Text = ""
            NAMEtb.Focus()
        End If
    End Sub

    Private Sub NAMEtb_TextChanged(sender As Object, e As EventArgs) Handles NAMEtb.TextChanged
        walk.name = NAMEtb.Text
    End Sub

    Private Sub GRADEcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GRADEcb.SelectedIndexChanged
        Dim selix As Integer = GRADEcb.SelectedIndex
        walk.grade = GRADEcb.Items(selix).ToString
    End Sub

    Private Sub DESCRtb_TextChanged(sender As Object, e As EventArgs) Handles DESCRtb.TextChanged
        walk.descr = DESCRtb.Text
    End Sub

    Private Sub PLACEtb_TextChanged(sender As Object, e As EventArgs) Handles PLACEtb.TextChanged
        walk.place = PLACEtb.Text
    End Sub

    Private Sub MEETcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MEETcb.SelectedIndexChanged
        Dim selix As Integer = MEETcb.SelectedIndex
        walk.meet = MEETcb.Items(selix).ToString
    End Sub

    Private Sub STARTcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles STARTcb.SelectedIndexChanged
        Dim selix As Integer = STARTcb.SelectedIndex
        walk.start = STARTcb.Items(selix).ToString
    End Sub

    Private Sub OStb_TextChanged(sender As Object, e As EventArgs) Handles OStb.TextChanged
        walk.os = OStb.Text
    End Sub

    Private Sub GRIDtb_Leave(sender As Object, e As EventArgs) Handles GRIDtb.Leave
        If GRIDtb.Text = "" Then Exit Sub
        If Len(GRIDtb.Text) <> 8 Then
            MsgBox("Not a valid OS Grid Ref!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        walk.grid = GRIDtb.Text.ToUpper
    End Sub

    Private Sub CHILDchk_CheckedChanged(sender As Object, e As EventArgs) Handles CHILDchk.CheckedChanged
        If CHILDchk.CheckState = CheckState.Checked Then
            walk.child = True
        Else
            walk.child = False
        End If
    End Sub

    Private Sub DOGchk_CheckedChanged(sender As Object, e As EventArgs) Handles DOGchk.CheckedChanged
        If DOGchk.CheckState = CheckState.Checked Then
            walk.dog = True
        Else
            walk.dog = False
        End If
    End Sub

    Private Sub ASCtb_TextChanged(sender As Object, e As EventArgs) Handles ASCtb.TextChanged
        walk.asc = ASCtb.Text
    End Sub

    Private Sub MAPtb_TextChanged(sender As Object, e As EventArgs) Handles MAPtb.TextChanged
        walk.map = MAPtb.Text
    End Sub

    Private Sub TOWNtb_TextChanged(sender As Object, e As EventArgs) Handles TOWNtb.TextChanged
        walk.town = TOWNtb.Text
    End Sub

    Private Sub OSmaplistcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OSmaplistcb.SelectedIndexChanged
        If NAMEtb.Text = "" Then Exit Sub
        Dim sel As Integer = OSmaplistcb.SelectedIndex
        OStb.Text = OSmaplistcb.Items(sel).ToString(0) & OSmaplistcb.Items(sel).ToString(1)
    End Sub

    Private Sub Townlistcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Townlistcb.SelectedIndexChanged
        If NAMEtb.Text = "" Then Exit Sub
        Dim sel As Integer = Townlistcb.SelectedIndex
        TOWNtb.Text = Townlistcb.SelectedItem.ToString
    End Sub

    Private Sub FindGRll_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles FindGRll.LinkClicked
        Dim urlstr As String = "http://www.glenrothesramblers.co.uk/OS/OsGridrefFinder.htm"
        Dim osgrf As New Process
        osgrf.StartInfo.FileName = urlstr
        osgrf.Start()

    End Sub

    Private Sub SEPAlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SEPAlink.LinkClicked
        Dim indexurl As String = "http://map.sepa.org.uk/ngrtool/"
        System.Diagnostics.Process.Start(indexurl)
    End Sub

    Private Sub TIMETextBox_TextChanged(sender As Object, e As EventArgs) Handles TIMETextBox.TextChanged
        walk.time = TIMETextBox.Text
    End Sub

    Private Sub DISTcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DISTcb.SelectedIndexChanged
        Dim selix As Integer = DISTcb.SelectedIndex
        walk.dist = DISTcb.Items(selix).ToString
    End Sub
End Class