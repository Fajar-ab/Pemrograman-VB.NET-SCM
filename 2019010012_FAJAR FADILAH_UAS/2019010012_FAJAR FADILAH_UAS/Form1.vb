Public Class Form1

    Dim buku As Integer = 0

    Private Sub prosses_Click(sender As Object, e As EventArgs) Handles prosses.Click

        buku += 1

        ListBox1.Items.Add("📘 Buku " & buku.ToString)
        ListBox1.Items.Add("- Kode Buku            : " + kode_buku.Text)
        ListBox1.Items.Add("- Judul Buku           : " + judul_buku.Text)
        ListBox1.Items.Add("- Pengarang            : " + pengarang_buku.Text)
        ListBox1.Items.Add("- Penerbit             : " + penerbit_buku.Text)
        ListBox1.Items.Add("- Nomor ISBN           : " + no_buku.Text)
        ListBox1.Items.Add("- Jumlah Buku          : " + jumlah_buku.Text)
        ListBox1.Items.Add("- Tanggal Peminjaman   : " + DateTimePicker1.Text)
        ListBox1.Items.Add("- Tanggal Pengembalian : " + DateTimePicker1.Text)
    End Sub
End Class
