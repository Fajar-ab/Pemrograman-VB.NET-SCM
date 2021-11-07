Public Class Form1
    Dim Makanan As String
    Dim Harga As String
    Dim potongan As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        With ComboBox1
            .Items.Add("Kebab")
            .Items.Add("Risol")
            .Items.Add("Pecel")
            .Items.Add("Unta Bakar")
            .Items.Add("Amer")
            .Items.Add("Cap Tikus")
            .Items.Add("Tuak")
        End With

        With ComboBox2
            .Items.Add("20000")
            .Items.Add("1000")
            .Items.Add("6000")
            .Items.Add("15000")
            .Items.Add("30000")
            .Items.Add("50000")
            .Items.Add("5000")
        End With

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.Focus()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Makanan = TextBox1.Focus()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        potongan = sender.text
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        potongan = sender.text
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        potongan = sender.text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Harga = TextBox2.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim diskon As Single
        Dim total As Single

        diskon = (ComboBox2.Text * TextBox1.Text * potongan) / 100
        total = (ComboBox2.Text * TextBox1.Text - diskon)
        TextBox2.Text = Format(total, "#,#")


        List_Daftar.Items.Add("Makanan/ Minuman  : " + ComboBox1.SelectedItem)
        'List_Daftar.Items.Add()
        'List_Daftar.Items.Add("Jumalah  : " + Makanan)
        'List_Daftar.Items.Add("Potongan :" + potongan)
        List_Daftar.Items.Add("Jumlah  : " + Harga)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Makanan = TextBox1.Text
    End Sub
End Class
