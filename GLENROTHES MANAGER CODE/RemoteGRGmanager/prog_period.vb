Public Class Prog_period

    Public season As String
    Public syear As Integer
    Public itemdates(53) As Date
    Public itemdays(52) As String
    Public startdate As Date
    Public enddate As Date
    Public inputerror As Boolean = False

    Public Sub New(newSeason As String, newYear As Integer)
        season = newSeason
        syear = newYear
        Dim start As String, last As String
        If season = "Summer" Then
            start = "01/04/"
            last = "30/09/"
            startdate = CDate(start & syear.ToString)
            enddate = CDate(last & syear.ToString)
        ElseIf season = "Winter" Then
            start = "01/10/"
            last = "31/03/"
            startdate = CDate(start & syear.ToString)
            enddate = CDate(last & (syear + 1).ToString)
        Else
            inputerror = True
            Exit Sub
        End If

        SetItemdates()
    End Sub

    Private Sub SetItemdates()
        Dim str As String = "Thursday"
        Dim we As String ' sat or sun
        Dim dix As Integer = 0
        Dim sdate As Date = startdate
        If sdate.DayOfWeek.ToString = "Sunday" Then
            we = "Sunday"
        Else
            we = "Saturday"
        End If
        'loop until enddate finding thurs and wes
        'add day to startdate, and incr dix if date set
        Do
            'action
            If sdate.DayOfWeek.ToString = we Then
                itemdates(dix) = sdate
                itemdays(dix) = we
                we = SwapWe(we)
                dix += 1
                sdate = DateAdd("d", 1, sdate)
            ElseIf sdate.DayOfWeek.ToString = str Then
                itemdates(dix) = sdate
                itemdays(dix) = str
                dix += 1
            End If
            sdate = DateAdd("d", 1, sdate)
        Loop Until sdate > enddate

    End Sub

    Private Function SwapWe(we As String) As String
        If we = "Saturday" Then
            Return "Sunday"
        Else
            Return "Saturday"
        End If
    End Function
End Class
