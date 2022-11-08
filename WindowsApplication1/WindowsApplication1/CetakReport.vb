Module CetakReport
    Sub Cetak()
        Dim myReport As New CrystalReport1
        'myReport.SetParameterValue("nomor", nomor)

        Dim objX As New Form2
        objX.CrystalReportViewer1.ReportSource = myReport
        objX.WindowState = FormWindowState.Maximized
        objX.ShowDialog()
    End Sub
End Module
