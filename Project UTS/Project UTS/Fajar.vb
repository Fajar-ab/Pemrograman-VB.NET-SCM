Public Class Fajar

    Public hgmakanan, hgminuman As Integer

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Bakso"
                Label2.Text = "Rp. 13000"
                hgmakanan = 13000
            Case "Nasi Uduk"
                Label2.Text = "Rp. 15000"
                hgmakanan = 15000
            Case "Nasi Goreng"
                Label2.Text = "Rp. 14000"
                hgmakanan = 14000
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Es Teh Manis"
                Label4.Text = "Rp. 6000"
                hgminuman = 6000
            Case "Es Kelapa Muda"
                Label4.Text = "Rp. 10000"
                hgminuman = 10000
        End Select
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ComboBox2.Visible = False
        Label4.Visible = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If ComboBox2.Enabled = False Then
            ComboBox2.Visible = False
        End If
        If ComboBox2.Enabled = True Then
            ComboBox2.Visible = True
            Label4.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prsmakanan, prsminuman, jumlah As Integer

        prsmakanan = Val(TextBox1.Text)
        prsminuman = Val(TextBox2.Text)

        jumlah = (hgmakanan * prsmakanan) + (hgminuman * prsminuman)
        Label7.Text = "Rp. " & jumlah.ToString
    End Sub

End Class
