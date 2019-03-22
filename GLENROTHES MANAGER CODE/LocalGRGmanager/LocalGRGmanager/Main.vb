Public Class Main
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub BtnTables_Click(sender As Object, e As EventArgs) Handles BtnTables.Click
        GRGlocal.Show()
    End Sub

    Private Sub BtnData_Click(sender As Object, e As EventArgs) Handles BtnData.Click
        SQLbackup.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDates()
    End Sub

    Private Sub LoadDates()
        LAJP.Text = My.Settings.lastajp
        Lprog.Text = My.Settings.lastprog
        Lfinal.Text = My.Settings.lastfp
        Lwalks.Text = My.Settings.lastallw
        Larch.Text = My.Settings.lastaw
        Llead.Text = My.Settings.lastlead
        Lgc.Text = My.Settings.lastgc
        Lphoto.Text = My.Settings.lastpha
    End Sub

    Private Sub Bsetdates_Click(sender As Object, e As EventArgs) Handles Bsetdates.Click
        Dim dt As Date = DateTimePicker1.Value
        My.Settings.lastajp = dt.ToShortDateString
        My.Settings.lastprog = dt.ToShortDateString
        My.Settings.lastfp = dt.ToShortDateString
        My.Settings.lastallw = dt.ToShortDateString
        My.Settings.lastaw = dt.ToShortDateString
        My.Settings.lastlead = dt.ToShortDateString
        My.Settings.lastgc = dt.ToShortDateString
        My.Settings.lastpha = dt.ToShortDateString
        LoadDates()
    End Sub
End Class