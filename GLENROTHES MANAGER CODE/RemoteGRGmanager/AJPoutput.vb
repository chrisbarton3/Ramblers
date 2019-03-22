Public Class AJPoutput
    Dim period As String

    Private Sub saveAJP()
        Cursor = Cursors.WaitCursor
        Try
            Me.Validate()
            Me.AJPwalksBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Chrisbarton_grg10DataSet)
            Me.AJPwalksTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.AJPwalks)
            Cursor = Cursors.Default
            MsgBox("AJP table saved to database")
        Catch ex As Exception
            MsgBox("Unable to save data!")
        End Try

    End Sub

    Private Sub AJPoutput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Chrisbarton_grg10DataSet3.PUBLISHED' table. You can move, or remove it, as needed.
        Me.PUBLISHEDTableAdapter.Fill(Me.Chrisbarton_grg10DataSet3.PUBLISHED)

        Me.AJPwalksTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.AJPwalks)
        getPeriod()
    End Sub

    Private Sub constructTable(sender As Object, e As EventArgs) Handles ToolStripButton1.Click 'construct table
        If Chrisbarton_grg10DataSet.AJPwalks.Rows.Count > 0 Then
            MsgBox("Clear table first")
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        Me.Validate()
        Me.AJPwalksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Chrisbarton_grg10DataSet)
        Me.AJPwalksTableAdapter.Fill(Me.Chrisbarton_grg10DataSet.AJPwalks)
        Dim kids As String, dogs As String, datetxt As String, tidydescr As String
        Dim fix As Integer = Chrisbarton_grg10DataSet3.PUBLISHED.Rows.Count - 1
        Dim idx As Integer = 0
        For ix As Integer = 0 To fix
            With Chrisbarton_grg10DataSet3.PUBLISHED(ix)
                If .period = period And Not IsDBNull(.id) Then
                    idx += 1
                    kids = setChildren(.kids)
                    dogs = setDogs(.dogs)
                    datetxt = textDate(.itemdate.ToShortDateString)
                    tidydescr = cleanStr(.descr)
                    Chrisbarton_grg10DataSet.AJPwalks.AddAJPwalksRow(idx, .itemdate, datetxt, period, .prog_item, tidydescr, .ascent, .grade, .dist, .time, .meet, .start, .place, .osmap, .gridref, kids, dogs, .leader, .phone, .email, .note)
                End If

            End With
        Next
        saveAJP()
        Cursor = Cursors.Default
        MsgBox("AJP table constructed." & vbCrLf & "Before submitting to Area, check that initial Strollers entry is unchanged.")
    End Sub

    Private Sub getPeriod()
        Try
            Dim endix As Integer = Chrisbarton_grg10DataSet3.PUBLISHED.Rows.Count - 1
            period = Chrisbarton_grg10DataSet3.PUBLISHED(endix).period
            tslPeriod.Text = "Current Programme period is " & period
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tsbClearTable_Click(sender As Object, e As EventArgs) Handles tsbClearTable.Click
        Cursor = Cursors.WaitCursor

        For ix = 0 To Chrisbarton_grg10DataSet.AJPwalks.Rows.Count - 1
            Try
                Chrisbarton_grg10DataSet.AJPwalks.Rows(ix).Delete()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
        saveAJP()
    End Sub


    'remove non printing characters and change colons to semicolons
    Public Function cleanStr(this As String) As String
        this = Trim(this)
        For ix As Integer = 0 To Len(this) - 1
            Dim chr As Char = this(ix)
            If Asc(chr) < 32 Or Asc(chr) > 126 Then
                this = this.Replace(chr, "|")
            End If
        Next
        cleanStr = this.Replace("|", " ")

        Return cleanStr
    End Function

    Public Function textDate(ByVal sdate As String) As String
        Dim d As Date
        d = CDate(sdate)
        Dim swk As String = d.DayOfWeek.ToString
        Dim smon As String = d.ToString("MMMM")
        Dim sday As String = d.Day.ToString

        Select Case sday
            Case "1", "21", "31"
                sday = sday & "st"
            Case "2", "22"
                sday = sday & "nd"
            Case "3", "23"
                sday = sday & "rd"
            Case Else
                sday = sday & "th"
        End Select

        textDate = swk & " " & sday & " " & smon
        Return textDate
    End Function


    'AJP setting
    Public Function setDogs(ByVal value As String) As String
        Try
            If value = "yes" Then
                Return "DWOL "
            Else
                Return "RADO "
            End If
        Catch ex As Exception
            Return ""
        End Try

    End Function

    'AJP setting
    Public Function setChildren(ByVal value As String) As String
        Try
            If value = "yes" Then
                Return "CWRA "
            Else
                Return "NoSC "
            End If
        Catch ex As Exception
            Return ""
        End Try

    End Function

End Class