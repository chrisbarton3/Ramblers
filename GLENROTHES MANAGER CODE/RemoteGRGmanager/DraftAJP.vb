Public Class DraftAJP


    Private Sub DraftAJP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Chrisbarton_grg10DataSet.PROGRAMME' table. You can move, or remove it, as needed.
        Me.PROGRAMMETableAdapter.FillBy(Me.Chrisbarton_grg10DataSet.PROGRAMME)
        showAJP()
    End Sub

    Private Sub showAJP()

        For ix As Integer = 0 To Chrisbarton_grg10DataSet.PROGRAMME.Rows.Count - 1
            With Chrisbarton_grg10DataSet.PROGRAMME(ix)

                tbAJP.AppendText(textDate(.itemdate) & vbCrLf)
                tbAJP.AppendText("Glenrothes:" & vbTab & Replace(.walk, ":", ";") & vbCrLf)
                'conditional text EVENT or STANDARD
                If .grade.Contains("EVENT") Then
                    tbAJP.AppendText(.descr & " " & .note & vbCrLf)
                    tbAJP.AppendText("CONTACT: " & .leader & " " & .phone & " " & .email & vbCrLf)
                Else
                    tbAJP.AppendText("GRADE " & .grade & ": " & .dist & "mls" & "/" & .time & "hrs " & isAscent(.ascent))
                    tbAJP.AppendText("DEPART: LCCP at " & .meet & " WALK START: " & .place & " at " & .start)
                    tbAJP.AppendText(" OS: " & .osmap & " GR: " & .griref & " DESCRIPTION: " & .descr)
                    tbAJP.AppendText(" NOTE: " & setChildren(.kids) & setDogs(.dogs) & .note)
                    tbAJP.AppendText(vbCrLf)
                    tbAJP.AppendText("LEADER: " & .leader & " " & .phone & " " & .email)
                    tbAJP.AppendText(vbCrLf)
                End If
                tbAJP.AppendText(vbCrLf)

            End With
        Next
    End Sub

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

    Private Function isAscent(ascent As String) As String
        If ascent.Contains("0") Then
            Return "Ascent: " & Trim(ascent) & "ft "
        Else
            Return ""
        End If
    End Function

    'AJP setting
    Public Function setDogs(ByVal value As Boolean) As String
        Try
            If value Then
                Return "DWOL "
            Else
                Return "RADO "
            End If
        Catch ex As Exception
            Return ""
        End Try

    End Function

    'AJP setting
    Public Function setChildren(ByVal value As Boolean) As String
        Try
            If value Then
                Return "CWRA "
            Else
                Return "NoSC "
            End If
        Catch ex As Exception
            Return ""
        End Try

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cliptxt As String
        cliptxt = Label1.Text & vbCrLf & Label2.Text & vbCrLf & vbCrLf & tbAJP.Text
        Clipboard.SetText(cliptxt)
    End Sub

End Class