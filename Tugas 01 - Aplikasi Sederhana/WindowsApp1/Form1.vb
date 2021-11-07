Public Class Form1

    Dim potongan As Integer = 0

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Focus()
    End Sub
 ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        TextBox1.Focus()
    End Sub
    Private Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        potongan = sender.text
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        potongan = sender.text
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        potongan = sender.text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim diskon As Single
        Dim total As Single

        diskon = (ComboBox2.Text * TextBox1.Text * potongan) / 100
        total = (ComboBox2.Text * TextBox1.Text - diskon)
        TextBox2.Text = Format(total, "#,#")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With ComboBox1
            .Items.Add("Buku Tulis")
            .Items.Add("Buku Gambar")
            .Items.Add("Pulpen")
            .Items.Add("Pensil")
            .Items.Add("Penggaris")
            .Items.Add("Rautan Pensil")
        End With

        With ComboBox2
            .Items.Add("2000")
            .Items.Add("3000")
            .Items.Add("2500")
            .Items.Add("2000")
            .Items.Add("3000")
            .Items.Add("1000")
        End With

    End Sub
End Class
