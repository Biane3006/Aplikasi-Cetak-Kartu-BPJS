Imports System.Data
Imports System.Data.SqlServerCe
Imports System.IO

Public Class FormDatabase
    Dim Aksi As String
    Dim PathDatabase As String = Application.StartupPath & "\dbBPJS.sdf"
    Public koneksi As New SqlCeConnection("Data Source=" & PathDatabase)
    Private dataAdapter As SqlCeDataAdapter
    Private BacaData As SqlCeDataReader
    Private dataSet As New DataSet()
    Private Sub FormDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi.Open()
        Tb_bpjsDataGridView.Location = New Point((Me.Width / 2) - (Tb_bpjsDataGridView.Width / 2), Me.Height - 300)
        btnSimpan.Location = New Point(Tb_bpjsDataGridView.Location.X, Tb_bpjsDataGridView.Location.Y - btnSimpan.Height - 10)
        btnBatal.Location = New Point(btnSimpan.Location.X + btnSimpan.Width + 5, btnSimpan.Location.Y)
        btnTambah.Location = New Point(btnBatal.Location.X + btnBatal.Width + 5, btnSimpan.Location.Y)
        btnEdit.Location = New Point(btnTambah.Location.X + btnTambah.Width + 5, btnSimpan.Location.Y)
        btnHapus.Location = New Point(btnEdit.Location.X + btnEdit.Width + 5, btnSimpan.Location.Y)
        gbDataPeserta.Location = New Point(Tb_bpjsDataGridView.Location.X, 30)
        GroupBox1.Location = New Point(gbDataPeserta.Location.X + gbDataPeserta.Width + 10, 30)
        Call ReadData()
        Call MengaturGrid()
        Call DisableComponent()
    End Sub

    Sub DisableComponent()
        gbDataPeserta.Enabled = False
        GroupBox1.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
    End Sub

    Sub EnableComponent()
        gbDataPeserta.Enabled = True
        GroupBox1.Enabled = True
    End Sub


    Sub BersihkanForm()
        NikWatermark.Text = ""
        NamaWatermark.Text = ""
        Tanggal_lahirDateTimePicker.Value = Date.Now
        ProvinsiComboBox.SelectedIndex = -1
        KotaComboBox.SelectedIndex = -1
        KecamatanComboBox.Text = ""
        KecamatanComboBox.SelectedIndex = -1
        KelurahanComboBox.Text = ""
        KelurahanComboBox.SelectedIndex = -1
        Alamat_lengkapWatermark.Text = ""
        KelasFaskesComboBox.SelectedIndex = -1
    End Sub


    Sub MengaturGrid()
        With Tb_bpjsDataGridView
            .Columns(0).HeaderText = "Nik"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "Nama Lengkap"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Tanggal Lahir"
            .Columns(2).Width = 120
            .Columns(3).HeaderText = "Provinsi"
            .Columns(3).Width = 150
            .Columns(4).HeaderText = "Kota/Kabupaten"
            .Columns(4).Width = 120
            .Columns(5).HeaderText = "Kecamatan"
            .Columns(5).Width = 120
            .Columns(6).HeaderText = "Kelurahan/Desa"
            .Columns(6).Width = 120
            .Columns(7).HeaderText = "Alamat Lengkap"
            .Columns(7).Width = 200
            .Columns(8).HeaderText = "Kelas Faskes"
            .Columns(8).Width = 120
        End With
    End Sub

    Private Sub ReadData()
        dataAdapter = New SqlCeDataAdapter("SELECT * FROM tb_bpjs", koneksi)
        dataSet.Clear()
        dataAdapter.Fill(dataSet, "tb_bpjs")
        Tb_bpjsDataGridView.DataSource = dataSet.Tables("tb_bpjs")
    End Sub



    Private Sub ProvinsiComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProvinsiComboBox.SelectedIndexChanged
        If ProvinsiComboBox.Text = "Kalimantan Timur" Then
            KotaComboBox.Items.Add("Berau")
            KotaComboBox.Items.Add("Kutai Barat")
            KotaComboBox.Items.Add("Kutai Kartanegara")
            KotaComboBox.Items.Add("Kutai Timur")
            KotaComboBox.Items.Add("Mahakam Ulu")
            KotaComboBox.Items.Add("Paser")
            KotaComboBox.Items.Add("Penajam Paser Utara")
            KotaComboBox.Items.Add("Balikpapan")
            KotaComboBox.Items.Add("Bontang")
            KotaComboBox.Items.Add("Samarinda")
        End If
    End Sub


    Private Sub KotaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KotaComboBox.SelectedIndexChanged
        KecamatanComboBox.Items.Clear()
        If KotaComboBox.Text = "Berau" Then
            KecamatanComboBox.Items.Add("Batu Putih")
            KecamatanComboBox.Items.Add("Pulau Derawan")
        ElseIf KotaComboBox.Text = "Kutai Barat" Then
            KecamatanComboBox.Items.Add("Damai")
            KecamatanComboBox.Items.Add("Jempang")
        ElseIf KotaComboBox.Text = "Kutai Kartanegara" Then
            KecamatanComboBox.Items.Add("Anggana")
            KecamatanComboBox.Items.Add("Kota Bangun")
        ElseIf KotaComboBox.Text = "Kutai Timur" Then
            KecamatanComboBox.Items.Add("Bengalon")
            KecamatanComboBox.Items.Add("Busang")
        ElseIf KotaComboBox.Text = "Mahakam Ulu" Then
            KecamatanComboBox.Items.Add("Laham")
            KecamatanComboBox.Items.Add("Long Apari")
        ElseIf KotaComboBox.Text = "Paser" Then
            KecamatanComboBox.Items.Add("Kuaro")
            KecamatanComboBox.Items.Add("Long Kali")
        ElseIf KotaComboBox.Text = "Penajam Paser Utara" Then
            KecamatanComboBox.Items.Add("Babulu")
            KecamatanComboBox.Items.Add("Penajam")
        ElseIf KotaComboBox.Text = "Balikpapan" Then
            KecamatanComboBox.Items.Add("Balikpapan Timur")
            KecamatanComboBox.Items.Add("Balikpapan Barat")
        ElseIf KotaComboBox.Text = "Bontang" Then
            KecamatanComboBox.Items.Add("Bontang Barat")
            KecamatanComboBox.Items.Add("Bontang Selatan")
        ElseIf KotaComboBox.Text = "Samarinda" Then
            KecamatanComboBox.Items.Add("Sambutan")
            KecamatanComboBox.Items.Add("Palaran")
        End If
    End Sub


    Private Sub KecamatanComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KecamatanComboBox.SelectedIndexChanged
        KelurahanComboBox.Items.Clear()
        If KecamatanComboBox.Text = "Batu Putih" Then
            KelurahanComboBox.Items.Add("Kayu Indah")
            KelurahanComboBox.Items.Add("Tembudan")
        ElseIf KecamatanComboBox.Text = "Pulau Derawan" Then
            KelurahanComboBox.Items.Add("Kasai")
            KelurahanComboBox.Items.Add("Tanjung Batu")
        ElseIf KecamatanComboBox.Text = "Damai" Then
            KelurahanComboBox.Items.Add("Benung")
            KelurahanComboBox.Items.Add("Bermai")
        ElseIf KecamatanComboBox.Text = "Jempang" Then
            KelurahanComboBox.Items.Add("Mancong")
            KelurahanComboBox.Items.Add("Perigiq")
        ElseIf KecamatanComboBox.Text = "Anggana" Then
            KelurahanComboBox.Items.Add("Anggana")
            KelurahanComboBox.Items.Add("Kutai Lama")
        ElseIf KecamatanComboBox.Text = "Kota Bangun" Then
            KelurahanComboBox.Items.Add("Wonosari")
            KelurahanComboBox.Items.Add("Pela")
        ElseIf KecamatanComboBox.Text = "Bengalon" Then
            KelurahanComboBox.Items.Add("Keraitan")
            KelurahanComboBox.Items.Add("Sepaso")
        ElseIf KecamatanComboBox.Text = "Busang" Then
            KelurahanComboBox.Items.Add("Long Bentuk")
            KelurahanComboBox.Items.Add("Long Lees")
        ElseIf KecamatanComboBox.Text = "Laham" Then
            KelurahanComboBox.Items.Add("Muara Ratah")
            KelurahanComboBox.Items.Add("Danum Paroy")
        ElseIf KecamatanComboBox.Text = "Long Apari" Then
            KelurahanComboBox.Items.Add("Long Kerioq")
            KelurahanComboBox.Items.Add("Long Apari")
        ElseIf KecamatanComboBox.Text = "Kuaro" Then
            KelurahanComboBox.Items.Add("Kerta Bumi")
            KelurahanComboBox.Items.Add("Sandeley")
        ElseIf KecamatanComboBox.Text = "Long Kali" Then
            KelurahanComboBox.Items.Add("Makmur")
            KelurahanComboBox.Items.Add("Munggu")
        ElseIf KecamatanComboBox.Text = "Babulu" Then
            KelurahanComboBox.Items.Add("Rintik")
            KelurahanComboBox.Items.Add("Sri Raharja")
        ElseIf KecamatanComboBox.Text = "Penajam" Then
            KelurahanComboBox.Items.Add("Pejala")
            KelurahanComboBox.Items.Add("Nenang")
        ElseIf KecamatanComboBox.Text = "Balikpapan Timur" Then
            KelurahanComboBox.Items.Add("Lamaru")
            KelurahanComboBox.Items.Add("Manggar")
        ElseIf KecamatanComboBox.Text = "Balikpapan Barat" Then
            KelurahanComboBox.Items.Add("Margo Mulyo")
            KelurahanComboBox.Items.Add("Margasari")
        ElseIf KecamatanComboBox.Text = "Bontang Barat" Then
            KelurahanComboBox.Items.Add("Belimbing")
            KelurahanComboBox.Items.Add("Kanaan")
        ElseIf KecamatanComboBox.Text = "Bontang Selatan" Then
            KelurahanComboBox.Items.Add("Berbas Pantai")
            KelurahanComboBox.Items.Add("Berbas Tengah")
        ElseIf KecamatanComboBox.Text = "Sambutan" Then
            KelurahanComboBox.Items.Add("Makroman")
            KelurahanComboBox.Items.Add("Pulau Atas")
        ElseIf KecamatanComboBox.Text = "Palaran" Then
            KelurahanComboBox.Items.Add("Bukuan")
            KelurahanComboBox.Items.Add("Bantuas")
        End If
    End Sub

    Private Sub NikWatermark_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NikWatermark.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub NikWatermark_KeyDown(sender As Object, e As KeyEventArgs) Handles NikWatermark.KeyDown

    End Sub

    'Cell enter (Cell nya Ke SELECT)
    Private Sub Tb_bpjsDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tb_bpjsDataGridView.CellEnter
        NikWatermark.Text = Tb_bpjsDataGridView.Rows(e.RowIndex).Cells(0).Value.ToString
        NamaWatermark.Text = Tb_bpjsDataGridView.Rows(e.RowIndex).Cells(1).Value.ToString
        Tanggal_lahirDateTimePicker.Value = Tb_bpjsDataGridView.Rows(e.RowIndex).Cells(2).Value
        ProvinsiComboBox.Text = Tb_bpjsDataGridView.Rows(e.RowIndex).Cells(3).Value.ToString
        KotaComboBox.Text = Tb_bpjsDataGridView.Rows(e.RowIndex).Cells(4).Value.ToString
        KecamatanComboBox.Text = Tb_bpjsDataGridView.Rows(e.RowIndex).Cells(5).Value.ToString
        KelurahanComboBox.Text = Tb_bpjsDataGridView.Rows(e.RowIndex).Cells(6).Value.ToString
        Alamat_lengkapWatermark.Text = Tb_bpjsDataGridView.Rows(e.RowIndex).Cells(7).Value.ToString
        KelasFaskesComboBox.Text = Tb_bpjsDataGridView.Rows(e.RowIndex).Cells(8).Value.ToString
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        NikWatermark.Enabled = True
        Aksi = "Tambah"
        Call BersihkanForm()
        Call EnableComponent()
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        btnTambah.Enabled = False
        btnEdit.Enabled = False
        btnHapus.Enabled = False
        Tb_bpjsDataGridView.Enabled = False
    End Sub


    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Aksi.Equals("Tambah") Then
            'Aksi = TAMBAH DATA
            '1. Cek Form nya dulu, apakah sudah terisi semua
            If NikWatermark.Text.Length < 16 Then
                MessageBox.Show("NIK Tidak Sesuai !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                NikWatermark.Focus()
            ElseIf NamaWatermark.Text = "" Then
                MessageBox.Show("Nama Anda Belum Terisi !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                NamaWatermark.Focus()
            ElseIf ProvinsiComboBox.SelectedIndex = -1 Then
                MessageBox.Show("Provinsi Belum Dipilih !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ProvinsiComboBox.Focus()
            ElseIf KotaComboBox.SelectedIndex = -1 Then
                MessageBox.Show("Kota Belum Dipilih !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                KotaComboBox.Focus()
            ElseIf KecamatanComboBox.SelectedIndex = -1 Then
                MessageBox.Show("Kecamatan Belum Dipilih !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                KecamatanComboBox.Focus()
            ElseIf KelurahanComboBox.SelectedIndex = -1 Then
                MessageBox.Show("Kelurahan Belum Dipilih !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                KelurahanComboBox.Focus()
            ElseIf Alamat_lengkapWatermark.Text = "" Then
                MessageBox.Show("Alamat Belum Lengkap !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Alamat_lengkapWatermark.Focus()
            ElseIf KelasFaskesComboBox.SelectedIndex = -1 Then
                MessageBox.Show("Kelas Faskes Belum Dipilih !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                KelasFaskesComboBox.Focus()
            Else
                Dim querySelect As New SqlCeCommand("SELECT * FROM tb_bpjs WHERE nik='" & NikWatermark.Text & "'", koneksi)
                BacaData = querySelect.ExecuteReader()
                If Not BacaData.Read() Then
                    BacaData.Close()
                    Dim queryInput As New SqlCeCommand("INSERT INTO tb_bpjs VALUES ('" & NikWatermark.Text & "','" & NamaWatermark.Text & "','" & Tanggal_lahirDateTimePicker.Value.ToString("yyyy/MM/dd") & "','" & ProvinsiComboBox.Text & "','" & KotaComboBox.Text & "','" & KecamatanComboBox.Text & "','" & KelurahanComboBox.Text & "','" & Alamat_lengkapWatermark.Text & "','" & KelasFaskesComboBox.Text & "')", koneksi)
                    queryInput.ExecuteNonQuery()
                    Call ReadData()
                    Call DisableComponent()
                    btnTambah.Enabled = True
                    btnEdit.Enabled = True
                    btnHapus.Enabled = True
                Else
                    MessageBox.Show("NIK Sudah Terdaftar !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    BacaData.Close()
                    NikWatermark.Focus()
                End If

            End If
        Else
            'edit
            '1. Cek Form nya dulu, apakah sudah terisi semua
            If NikWatermark.Text.Length < 16 Then
                MessageBox.Show("NIK Tidak Sesuai !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                NikWatermark.Focus()
            ElseIf NamaWatermark.Text = "" Then
                MessageBox.Show("Nama Anda Belum Terisi !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                NamaWatermark.Focus()
            ElseIf ProvinsiComboBox.SelectedIndex = -1 Then
                MessageBox.Show("Provinsi Belum Dipilih !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ProvinsiComboBox.Focus()
            ElseIf KotaComboBox.SelectedIndex = -1 Then
                MessageBox.Show("Kota Belum Dipilih !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                KotaComboBox.Focus()
            ElseIf KecamatanComboBox.SelectedIndex = -1 Then
                MessageBox.Show("Kecamatan Belum Dipilih !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                KecamatanComboBox.Focus()
            ElseIf KelurahanComboBox.SelectedIndex = -1 Then
                MessageBox.Show("Kelurahan Belum Dipilih !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                KelurahanComboBox.Focus()
            ElseIf Alamat_lengkapWatermark.Text = "" Then
                MessageBox.Show("Alamat Belum Lengkap !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Alamat_lengkapWatermark.Focus()
            ElseIf KelasFaskesComboBox.SelectedIndex = -1 Then
                MessageBox.Show("Kelas Faskes Belum Dipilih !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                KelasFaskesComboBox.Focus()
            Else
                Dim queryUpdate As New SqlCeCommand("UPDATE tb_bpjs SET nama='" & NamaWatermark.Text & "',tanggal_lahir='" & Tanggal_lahirDateTimePicker.Value.ToString("yyyy/MM/dd") & "',provinsi='" & ProvinsiComboBox.Text & "',kota='" & KotaComboBox.Text & "',kecamatan='" & KecamatanComboBox.Text & "',kelurahan='" & KelurahanComboBox.Text & "',alamat_lengkap='" & Alamat_lengkapWatermark.Text & "',kelasFaskes='" & KelasFaskesComboBox.Text & "' WHERE nik='" & NikWatermark.Text & "'", koneksi)
                queryUpdate.ExecuteNonQuery()
                Call ReadData()
                Call DisableComponent()
                btnTambah.Enabled = True
                btnEdit.Enabled = True
                btnHapus.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call BersihkanForm()
        Call DisableComponent()
        btnTambah.Enabled = True
        btnEdit.Enabled = True
        btnHapus.Enabled = True
        Tb_bpjsDataGridView.Enabled = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Aksi = "Edit"
        Call EnableComponent()
        NikWatermark.Enabled = False
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        btnTambah.Enabled = False
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim queryUpdate As New SqlCeCommand("DELETE FROM tb_bpjs WHERE nik='" & NikWatermark.Text & "'", koneksi)
        queryUpdate.ExecuteNonQuery()
        Call ReadData()
        Call BersihkanForm()
        Tb_bpjsDataGridView.Focus()
    End Sub
End Class