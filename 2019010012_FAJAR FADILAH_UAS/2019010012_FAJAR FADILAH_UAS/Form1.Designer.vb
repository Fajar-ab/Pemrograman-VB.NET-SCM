<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.kode_buku = New System.Windows.Forms.TextBox()
        Me.judul_buku = New System.Windows.Forms.TextBox()
        Me.pengarang_buku = New System.Windows.Forms.TextBox()
        Me.penerbit_buku = New System.Windows.Forms.TextBox()
        Me.no_buku = New System.Windows.Forms.TextBox()
        Me.jumlah_buku = New System.Windows.Forms.NumericUpDown()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.prosses = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.jumlah_buku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Buku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Judu Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pengarang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Penerbit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nomor ISBN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jumlah Buku"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tanggal Peminjaman"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 354)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tanggal Pengembalian"
        '
        'kode_buku
        '
        Me.kode_buku.Location = New System.Drawing.Point(165, 36)
        Me.kode_buku.Name = "kode_buku"
        Me.kode_buku.Size = New System.Drawing.Size(200, 23)
        Me.kode_buku.TabIndex = 8
        '
        'judul_buku
        '
        Me.judul_buku.Location = New System.Drawing.Point(165, 81)
        Me.judul_buku.Name = "judul_buku"
        Me.judul_buku.Size = New System.Drawing.Size(200, 23)
        Me.judul_buku.TabIndex = 9
        '
        'pengarang_buku
        '
        Me.pengarang_buku.Location = New System.Drawing.Point(165, 126)
        Me.pengarang_buku.Name = "pengarang_buku"
        Me.pengarang_buku.Size = New System.Drawing.Size(200, 23)
        Me.pengarang_buku.TabIndex = 10
        '
        'penerbit_buku
        '
        Me.penerbit_buku.Location = New System.Drawing.Point(165, 171)
        Me.penerbit_buku.Name = "penerbit_buku"
        Me.penerbit_buku.Size = New System.Drawing.Size(200, 23)
        Me.penerbit_buku.TabIndex = 11
        '
        'no_buku
        '
        Me.no_buku.Location = New System.Drawing.Point(165, 216)
        Me.no_buku.Name = "no_buku"
        Me.no_buku.Size = New System.Drawing.Size(200, 23)
        Me.no_buku.TabIndex = 12
        '
        'jumlah_buku
        '
        Me.jumlah_buku.Location = New System.Drawing.Point(165, 262)
        Me.jumlah_buku.Name = "jumlah_buku"
        Me.jumlah_buku.Size = New System.Drawing.Size(120, 23)
        Me.jumlah_buku.TabIndex = 13
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(406, 36)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(439, 284)
        Me.ListBox1.TabIndex = 14
        '
        'prosses
        '
        Me.prosses.Location = New System.Drawing.Point(526, 350)
        Me.prosses.Name = "prosses"
        Me.prosses.Size = New System.Drawing.Size(66, 23)
        Me.prosses.TabIndex = 15
        Me.prosses.Text = "Proses"
        Me.prosses.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(165, 309)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePicker1.TabIndex = 16
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(165, 348)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePicker2.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(613, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(698, 350)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(779, 350)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Keluar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 410)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.prosses)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.jumlah_buku)
        Me.Controls.Add(Me.no_buku)
        Me.Controls.Add(Me.penerbit_buku)
        Me.Controls.Add(Me.pengarang_buku)
        Me.Controls.Add(Me.judul_buku)
        Me.Controls.Add(Me.kode_buku)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.jumlah_buku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents kode_buku As TextBox
    Friend WithEvents judul_buku As TextBox
    Friend WithEvents pengarang_buku As TextBox
    Friend WithEvents penerbit_buku As TextBox
    Friend WithEvents no_buku As TextBox
    Friend WithEvents jumlah_buku As NumericUpDown
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents prosses As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
