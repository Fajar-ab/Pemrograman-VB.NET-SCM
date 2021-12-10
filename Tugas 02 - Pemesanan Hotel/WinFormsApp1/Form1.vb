Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Ekonomi")
        ComboBox1.Items.Add("VIP")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Ekonomi" Then
            ComboBox2.Items.Add("1/EKO-S")
            ComboBox2.Items.Add("2/EKO-F")
            ComboBox2.Items.Add("3/EKO-D")
        ElseIf ComboBox1.Text = "VIP" Then
            ComboBox2.Items.Add("1/VIP-S")
            ComboBox2.Items.Add("2/VIP-F")
            ComboBox2.Items.Add("3/VIP-D")
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim x, y, z As String
        Dim hk As Integer

        'Nama Kamar
        x = Microsoft.VisualBasic.Right(ComboBox2.Text, 1)
        If x = "S" Then
            TextBox1.Text = "Standard Room"
        ElseIf x = "F" Then
            TextBox1.Text = "Family Room"
        ElseIf x = "D" Then
            TextBox1.Text = "Deluxe Room"
        End If

        'Kode Kunci
        y = Microsoft.VisualBasic.Left(ComboBox2.Text, 1)
        z = Microsoft.VisualBasic.Mid(ComboBox2.Text, 3, 3)
        TextBox2.Text = "Kunci/" & y & "-" & z & "/" & x

        If ComboBox1.Text = "Ekonomi" Then

            hk = 1000000

            If x = "S" Then
                TextBox3.Text = hk + 500000
            ElseIf x = "F" Then
                TextBox3.Text = hk + 1000000
            ElseIf x = "D" Then
                TextBox3.Text = hk + 1500000
            End If

        ElseIf ComboBox1.Text = "VIP" Then

            hk = 2000000

            If x = "S" Then
                TextBox3.Text = hk + 500000
            ElseIf x = "F" Then
                TextBox3.Text = hk + 1000000
            ElseIf x = "D" Then
                TextBox3.Text = hk + 1500000
            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox4.Text >= 5 Then
            TextBox5.Text = 0.02 * Val(TextBox4.Text * TextBox3.Text)
        ElseIf TextBox4.Text >= 2 Then
            TextBox5.Text = 0.01 * Val(TextBox4.Text * TextBox3.Text)
        Else
            TextBox5.Text = 0
        End If

        TextBox6.Text = Val(TextBox4.Text * TextBox3.Text) - Val(TextBox5.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
