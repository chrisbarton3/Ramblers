Imports System.IO

Public Class walkfinder
    Dim csv(57, 23) As String
    Dim csvLines(57) As String
    Dim period As String
    Dim csvlen As Integer

    Private Sub walkfinder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Chrisbarton_grg10DataSet.PUBLISHED' table. You can move, or remove it, as needed.
        Me.PUBLISHEDTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.PUBLISHED)

        getPeriod()
        makeCSV()
        RichTextBox1.Rtf = My.Settings.wfrtf
    End Sub

    Private Sub getPeriod()
        Try
            Dim lastix As Integer = Chrisbarton_grg10DataSet.PUBLISHED.Rows.Count - 1
            period = Chrisbarton_grg10DataSet.PUBLISHED(lastix).period
            tslPeriod.Text = "Current Programme period is " & period
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub makeCSV()
        'row one headings - list of required fields for csv input
        For fx As Integer = 0 To 22
            Select Case fx
                Case 0
                    csv(0, fx) = "Date"
                Case 1
                    csv(0, fx) = "Title"
                Case 2
                    csv(0, fx) = "Description"
                Case 3
                    csv(0, fx) = "Linear or Circular"
                Case 4
                    csv(0, fx) = "Starting gridref"
                Case 5
                    csv(0, fx) = "Starting location details"
                Case 6
                    csv(0, fx) = "Show exact starting point?"
                Case 7
                    csv(0, fx) = "Start time"
                Case 8
                    csv(0, fx) = "Meeting gridref"
                Case 9
                    csv(0, fx) = "Meeting location details"
                Case 10
                    csv(0, fx) = "Show exact meeting point?"
                Case 11
                    csv(0, fx) = "Meeting time"
                Case 12
                    csv(0, fx) = "Restriction"
                Case 13
                    csv(0, fx) = "Difficulty"
                Case 14
                    csv(0, fx) = "Local walk grade"
                Case 15
                    csv(0, fx) = "Distance miles"
                Case 16
                    csv(0, fx) = "Contact display name"
                Case 17
                    csv(0, fx) = "Contact email"
                Case 18
                    csv(0, fx) = "Contact telephone 1"
                Case 19
                    csv(0, fx) = "Is walk leader?"
                Case 20
                    csv(0, fx) = "Ascent feet"
                Case 21
                    csv(0, fx) = "Child friendly?"
                Case 22
                    csv(0, fx) = "Dog friendly?"
            End Select
        Next

        'rest of csv
        Dim selix As Integer = 0
        For ix = 1 To Chrisbarton_grg10DataSet.PUBLISHED.Rows.Count - 1
            With Chrisbarton_grg10DataSet.PUBLISHED(ix)
                If .period = period Then
                    selix += 1
                    For field As Integer = 0 To 22
                        Select Case field
                            Case 0
                                csv(selix, field) = .itemdate.ToShortDateString
                            Case 1
                                csv(selix, field) = cleanStr(.prog_item)
                            Case 2
                                csv(selix, field) = cleanStr(.descr)
                            Case 3
                                csv(selix, field) = setLinear(.prog_item)
                            Case 4
                                csv(selix, field) = .gridref
                            Case 5
                                csv(selix, field) = cleanStr(.place)
                            Case 6
                                csv(selix, field) = "yes"
                            Case 7
                                csv(selix, field) = .start
                            Case 8
                                csv(selix, field) = setGridref(.prog_item)
                            Case 9
                                csv(selix, field) = setMeet(.prog_item)
                            Case 10
                                csv(selix, field) = "yes"
                            Case 11
                                csv(selix, field) = .meet
                            Case 12
                                csv(selix, field) = "Public"
                            Case 13
                                csv(selix, field) = setGrade(.grade, .dist)
                            Case 14
                                csv(selix, field) = .grade
                            Case 15
                                csv(selix, field) = setDist(.dist)
                            Case 16
                                csv(selix, field) = .leader
                            Case 17
                                csv(selix, field) = .email
                            Case 18
                                csv(selix, field) = .phone
                            Case 19
                                csv(selix, field) = "yes"
                            Case 20
                                csv(selix, field) = Trim(.ascent)
                            Case 21
                                csv(selix, field) = .kids
                            Case 22
                                csv(selix, field) = .dogs
                        End Select
                    Next
                End If
            End With
        Next
        csvlen = selix
        tslPeriod.Text = tslPeriod.Text & " Records found - " & csvlen
        For ix As Integer = 0 To csvlen
            csvLines(ix) = ""
            For fx As Integer = 0 To 22
                csvLines(ix) = csvLines(ix) & "," & csv(ix, fx)

            Next
            csvLines(ix) = csvLines(ix).TrimStart(",")
            ' tbItems.AppendText(csvLines(ix) & vbCrLf)
        Next
    End Sub
    Private Function setDist(dist As String) As String
        If Len(dist) > 2 Then dist = "5"
        Return dist
    End Function

    Private Sub writeCSV(sfile As String)
        Try
            Using sw As StreamWriter = New StreamWriter(sfile)
                For ix As Integer = 0 To csvlen
                    sw.WriteLine(csvLines(ix))

                Next

            End Using
            MsgBox("CSV file created - " & sfile)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function cleanStr(this As String) As String
        this = Trim(this)
        For ix As Integer = 0 To Len(this) - 1
            Dim chr As Char = this(ix)
            If Asc(chr) < 32 Or Asc(chr) > 126 Then
                this = this.Replace(chr, "|")
            End If
        Next
        cleanStr = this.Replace("|", " ")
        cleanStr = this.Replace(",", "")
        Return cleanStr
    End Function


    Private Function setGrade(cgrade As String, cdist As String) As String

        Try
            Select Case cgrade
                Case "A"
                    Return "Strenuous"
                Case "B+"
                    Return "Strenuous"
                Case "B"

                    If cdist < "8" Then
                        Return "Moderate"
                    Else
                        Return "Strenuous"
                    End If
                Case "C+"
                    Return "Moderate"
                Case "C"

                    If cdist < "5" Then
                        Return "Easy"
                    Else
                        Return "Leisurely"
                    End If
                Case Else
                    Return ""
            End Select

        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Function setMeet(cname As String) As String
        If cname.Contains("Strollers") Then
            Return "St Columbas Church CP"
        Else
            Return "Lomond Centre CP"
        End If
    End Function

    Private Function setGridref(cname As String) As String
        If cname.Contains("Strollers") Then
            Return "NO269009"
        Else
            Return "NO286008"
        End If
    End Function

    Private Function setLinear(cname As String) As String
        If cname.Contains("linear") Then
            Return "linear"
        Else
            Return "circular"
        End If
    End Function

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsbSave.Click
        sfdlg.FileName = "CF04_" & period & ".csv"
        sfdlg.Filter = "csv files (*.csv)|*.csv"
        If sfdlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sfile As String = sfdlg.FileName
            writeCSV(sfile)

        End If

    End Sub

End Class