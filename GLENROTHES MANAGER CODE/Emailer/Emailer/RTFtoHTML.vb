Public Class RTFtoHTML

    Dim htmlheader1 As String = "<!DOCTYPE html><html><head><meta charset='utf-8'/></head><body style='font-family:Arial;font-size:"
    Dim htmlheader2 As String = "pt'>"
    Dim htmlheader As String
    Dim htmlfooter = "</body></html>"
    Dim alink1 As String = "<a href='"
    Dim alink2 As String = "'>"
    Dim alink3 As String = "</a>"


    Public Function convert(rtf As String, fsize As Integer) As String
        Dim htmltxt As String
        ' conversion code

        'remove header
        rtf = removeRTFheader(rtf)

        'remove \fs tags
        rtf = removefs(rtf)

        'add new header and footer
        htmltxt = rtf
        htmlheader = htmlheader1 & fsize.ToString & htmlheader2
        htmltxt = htmlheader & htmltxt
        htmltxt = htmltxt & htmlfooter
        'replace par, B, I and U tags and remove residual \s
        htmltxt = reformatRTF(htmltxt)

        'final tidy up of stray { } or \
        htmltxt = htmltxt.Replace("{", "")
        htmltxt = htmltxt.Replace("}", "")
        htmltxt = htmltxt.Replace("\", "")

        'add hyperlinks
        htmltxt = htmltxt.Replace("][", alink2)
        htmltxt = htmltxt.Replace("[", alink1)
        htmltxt = htmltxt.Replace("]", alink3)

        Return htmltxt
    End Function

    Private Function removefs(rtf As String) As String
        Dim ix As Integer
        Do
            ix = rtf.IndexOf("\fs")
            If ix > -1 Then
                rtf = rtf.Remove(ix, 5)
            End If
        Loop Until ix = -1

        Return rtf
    End Function

    Private Function removeRTFheader(rtf As String) As String
        Dim ix As Integer, lenh As Integer
        ix = rtf.IndexOf("\pard")
        lenh = ix + 5
        rtf = rtf.Remove(0, lenh)
        Return rtf
    End Function

    Private Function reformatRTF(htmltxt As String) As String
        htmltxt = htmltxt.Replace("\par", "<br/>")
        htmltxt = htmltxt.Replace("\b0", "</b>")
        htmltxt = htmltxt.Replace("\b", "<b>")
        htmltxt = htmltxt.Replace("\i0", "</i>")
        htmltxt = htmltxt.Replace("\i", "<i>")
        htmltxt = htmltxt.Replace("\ulnone", "</u>")
        htmltxt = htmltxt.Replace("\ul", "<u>")

        Return htmltxt
    End Function


End Class
