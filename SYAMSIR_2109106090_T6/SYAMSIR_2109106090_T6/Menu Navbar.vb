
Public Class Petugas
    Private Sub Petugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        labelBPJS.Focus()
        'Setting Posisi Label Menu Aktif dan Label Copyright
        labelMenuAktif.Location = New Point((Panel4.Width / 2) - (labelMenuAktif.Width / 2))
        labelCopyright.Location = New Point((Panel5.Width / 2) - (labelCopyright.Width / 2))
    End Sub

    Private Sub btnInputData_Click(sender As Object, e As EventArgs) Handles btnInputData.Click
        'Mengisi Label Aktif
        labelMenuAktif.Text = "INPUT DATA BPJS"
        labelMenuAktif.Location = New Point((Panel4.Width / 2) - (labelMenuAktif.Width / 2))
        With FormDatabase
            .TopLevel = False
            Panel3.Controls.Clear()
            .Size = New Size(Panel3.Size)
            Panel3.Controls.Add(FormDatabase)
            .Location = New Point(0, 0)
            .BringToFront()
            .Show()
        End With
        'Mengubah warna button saat aktif
        'Ubah warnanya menjadi hijau pudar (Menu Aktif)
        btnInputData.BackColor = Color.FromArgb(106, 187, 109)
        'ubahwarnanya menjadi hijau tua (Menu Non-Aktif)
        btnGrafikPengguna.BackColor = Color.FromArgb(30, 97, 36)
        btnLaporan.BackColor = Color.FromArgb(30, 97, 36)
        btnCetakKartu.BackColor = Color.FromArgb(30, 97, 36)
        Grafik_Pengguna.Close()
        Form1.Close()
        Laporan.Close()
    End Sub

    Private Sub btnGrafikPengguna_Click(sender As Object, e As EventArgs) Handles btnGrafikPengguna.Click
        'Mengisi Label Aktif
        labelMenuAktif.Text = "GRAFIK PENGGUNA BPJS"
        labelMenuAktif.Location = New Point((Panel4.Width / 2) - (labelMenuAktif.Width / 2))
        With Grafik_Pengguna
            .TopLevel = False
            Panel3.Controls.Clear()
            .Size = New Size(Panel3.Size)
            Panel3.Controls.Add(Grafik_Pengguna)
            .Location = New Point(0, 0)
            .BringToFront()
            .Show()
        End With
        'Mengubah warna button saat aktif
        'Ubah warnanya menjadi hijau pudar (Menu Aktif)
        btnGrafikPengguna.BackColor = Color.FromArgb(106, 187, 109)
        'ubahwarnanya menjadi hijau tua (Menu Non-Aktif)
        btnInputData.BackColor = Color.FromArgb(30, 97, 36)
        btnLaporan.BackColor = Color.FromArgb(30, 97, 36)
        btnCetakKartu.BackColor = Color.FromArgb(30, 97, 36)
        FormDatabase.Close()
        Form1.Close()
        Laporan.Close()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        'Mengisi Label Aktif
        labelMenuAktif.Text = "LAPORAN DATA BPJS"
        labelMenuAktif.Location = New Point((Panel4.Width / 2) - (labelMenuAktif.Width / 2))
        With Laporan
            .TopLevel = False
            Panel3.Controls.Clear()
            .Size = New Size(Panel3.Size)
            Panel3.Controls.Add(Laporan)
            .Location = New Point(0, 0)
            .BringToFront()
            .Show()
        End With
        'Mengubah warna button saat aktif
        'Ubah warnanya menjadi hijau pudar (Menu Aktif)
        btnLaporan.BackColor = Color.FromArgb(106, 187, 109)
        'ubahwarnanya menjadi hijau tua (Menu Non-Aktif)
        btnInputData.BackColor = Color.FromArgb(30, 97, 36)
        btnGrafikPengguna.BackColor = Color.FromArgb(30, 97, 36)
        btnCetakKartu.BackColor = Color.FromArgb(30, 97, 36)
        FormDatabase.Close()
        Grafik_Pengguna.Close()
        Form1.Close()
    End Sub

    Private Sub btnCetakKartu_Click(sender As Object, e As EventArgs) Handles btnCetakKartu.Click
        'Mengisi Label Aktif
        labelMenuAktif.Text = "CETAK KARTU BPJS"
        labelMenuAktif.Location = New Point((Panel4.Width / 2) - (labelMenuAktif.Width / 2))
        With Form1
            .TopLevel = False
            Panel3.Controls.Clear()
            .Size = New Size(Panel3.Size)
            Panel3.Controls.Add(Form1)
            .Location = New Point(0, 0)
            .BringToFront()
            .Show()
        End With
        'Mengubah warna button saat aktif
        'Ubah warnanya menjadi hijau pudar (Menu Aktif)
        btnCetakKartu.BackColor = Color.FromArgb(106, 187, 109)
        btnLaporan.BackColor = Color.FromArgb(30, 97, 36)
        'ubahwarnanya menjadi hijau tua (Menu Non-Aktif)
        btnInputData.BackColor = Color.FromArgb(30, 97, 36)
        btnGrafikPengguna.BackColor = Color.FromArgb(30, 97, 36)
        btnLaporan.BackColor = Color.FromArgb(30, 97, 36)
        FormDatabase.Close()
        Grafik_Pengguna.Close()
        Laporan.Close()
    End Sub
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        FormDatabase.koneksi.Close()
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelWaktu.Text = Format(Now, "dddd dd MMMM yyyy")
        labelWaktu.Location = New Point(0, 0)
        labelTime.Text = Format(Now, "HH:mm:ss")
        labelTime.Location = New Point(labelWaktu.Width + 10, 0)
    End Sub
End Class