Imports System.Data.Odbc
Public Class Form1
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
    Sub KondisiAwal()

        Call Koneksi()

        DA = New OdbcDataAdapter("Select * From tbl_pekerjaan ", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_pekerjaan")
        DataGridView1.DataSource = DS.Tables("tbl_pekerjaan")

        'Generate auto number 
        Dim nomorBaru As String = ""
        Dim number As String
        Dim maxNum As String

        Try
            Cmd = New OdbcCommand("SELECT no_pekerjaan FROM tbl_pekerjaan ORDER BY no_pekerjaan DESC LIMIT 1", Conn)
            DR = CMD.ExecuteReader

            If DR.Read Then

                number = DR!no_pekerjaan

                'ambil nomor
                maxNum = Strings.Mid(number, 3, 3)
                nomorBaru = "A-" & maxNum + 1

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'Isi otomatis no pekerjaan
        TextNo.Text = nomorBaru
        ButtonHapus.Enabled = False
        ButtonUpdate.Enabled = False
        ButtonSimpan.Enabled = True
        ButtonInput.Enabled = False
        TextNo.Enabled = False
        TextNo.Focus()


    End Sub
    Sub ClearData()
        TextNamaModul.Clear()
        TextUraian.Clear()
        TextPerbaikan.Clear()
        TextPencegahan.Clear()
        TextNo.Clear()
        ComboDivisi.Text = ""
        ComboStatus.Text = ""
        RadioYa.Checked = False
        RadioTidak.Checked = False
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        'Validasi form Textbox
        If TextNamaModul.Text = "" Then
            MsgBox("Nama modul belum diisi !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            TextNamaModul.Focus()
        ElseIf ComboDivisi.Text = "" Then
            MsgBox("Divisi belum diisi !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            ComboDivisi.Focus()
        Else
            Call Koneksi()
            Dim trouble As String = ""

            If RadioYa.Checked = True Then
                trouble = RadioYa.Text
            ElseIf RadioTidak.Checked = True Then
                trouble = RadioTidak.Text
            End If

            Dim dataPekerjaan As String = "Insert into tbl_pekerjaan values('" & TextNo.Text & "', '" & ComboDivisi.Text & "', '" & Format(Tanggal.Value, "yyyy-MM-dd HH:mm") & "', '" & TextNamaModul.Text & "','" & trouble & "' , '" & TextUraian.Text & "', '" & TextPerbaikan.Text & "', '" & TextPencegahan.Text & "', '" & ComboStatus.Text & "')"
            Cmd = New OdbcCommand(dataPekerjaan, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Input data berhasil")
            Call ClearData()
            Call KondisiAwal()
        End If



    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        Call Koneksi()

        Dim hasil As MsgBoxResult = MessageBox.Show("Apakah data ingin dihapus?", "Pesan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If hasil = vbOK Then
            Dim hapus As String = "DELETE From tbl_pekerjaan WHERE no_pekerjaan = '" & TextNo.Text & "'"
            Cmd = New OdbcCommand(hapus, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Hapus data berhasil")
            Call KondisiAwal()
            Call ClearData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index

        With DataGridView1.Rows.Item(i)
            Me.TextNo.Text = .Cells(0).Value
            Me.ComboDivisi.Text = .Cells(1).Value
            Me.Tanggal.Text = .Cells(2).Value
            Me.TextNamaModul.Text = .Cells(3).Value
            If RadioYa.Text = .Cells(4).Value Then
                RadioYa.Checked = True
            ElseIf RadioTidak.Text = .Cells(4).Value Then
                RadioTidak.Checked = True
            End If
            If Not String.IsNullOrEmpty(.Cells(5).Value) Then
                Me.TextUraian.Text = .Cells(5).Value
            End If
            If Not String.IsNullOrEmpty(.Cells(6).Value) Then
                Me.TextPencegahan.Text = .Cells(6).Value
            End If
            If Not String.IsNullOrEmpty(.Cells(7).Value) Then
                Me.TextPerbaikan.Text = .Cells(7).Value
            End If
            Me.ComboStatus.Text = .Cells(8).Value
        End With

        TextNo.Enabled = False
        ButtonSimpan.Enabled = False
        ButtonHapus.Enabled = True
        ButtonUpdate.Enabled = True
        ButtonInput.Enabled = True
    End Sub

    Private Sub ButtonUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdate.Click
        Call KONEKSI()

        Dim trouble As String = ""

        If RadioYa.Checked = True Then
            trouble = RadioYa.Text
        ElseIf RadioTidak.Checked = True Then
            trouble = RadioTidak.Text
        End If

        Dim Update As String = "UPDATE tbl_pekerjaan SET tanggal_mulai = '" & Format(Tanggal.Value, "yyyy-MM-dd HH:mm") & "',nama_modul = '" & TextNamaModul.Text & "', uraian = '" & TextUraian.Text & "', tindakan_perbaikan = '" & TextPerbaikan.Text & "', tindakan_pencegahan = '" & TextPencegahan.Text & "', status = '" & ComboStatus.Text & "', trouble = '" & trouble & "' WHERE no_pekerjaan = '" & TextNo.Text & "'"
        CMD = New OdbcCommand(Update, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Update data berhasil")
        Call KondisiAwal()
        Call ClearData()
    End Sub

    Private Sub ButtonInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInput.Click
        Call ClearData()
        Call KondisiAwal()
    End Sub

    Private Sub ButtonReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReport.Click
        CetakReport.Cetak()
    End Sub
End Class
