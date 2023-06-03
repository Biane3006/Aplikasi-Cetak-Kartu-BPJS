Imports System.Data
Imports System.Data.SqlServerCe
Imports System.IO
Public Class Laporan
    Dim PathDatabase As String = Application.StartupPath & "\dbBPJS.sdf"
    Private koneksi As New SqlCeConnection("Data Source=" & PathDatabase)
    Private dataAdapter As SqlCeDataAdapter
    Private BacaData As SqlCeDataReader
    Private dataSet As New DataSet()

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi.Open()
        KelasFaskesComboBox.SelectedIndex = 0
        Call ReadData()
        Call MengaturGrid()
        Tb_bpjsDataGridView.Location = New Point((Me.Width / 2) - (Tb_bpjsDataGridView.Width / 2), 150)
        btnCetak.Location = New Point(Tb_bpjsDataGridView.Location.X, Tb_bpjsDataGridView.Location.Y - btnCetak.Height - 10)
        KelasFaskesComboBox.Location = New Point(btnCetak.Location.X + btnCetak.Width + 10, btnCetak.Location.Y)
        AddHandler PrintDocument1.PrintPage, AddressOf Me.printDocument1_PrintPage
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
    End Sub

    Sub MengaturGrid()
        With Tb_bpjsDataGridView
            .Columns(0).HeaderText = "Nik"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "Nama Lengkap"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Tanggal Lahir"
            .Columns(2).Width = 120
            .Columns(3).HeaderText = "Kelas Faskes"
            .Columns(3).Width = 120
        End With
    End Sub

    Private Sub ReadData()
        If KelasFaskesComboBox.SelectedIndex = 0 Then
            dataAdapter = New SqlCeDataAdapter("SELECT nik,nama,tanggal_lahir,kelasFaskes FROM tb_bpjs", koneksi)
            dataSet.Clear()
            dataAdapter.Fill(dataSet, "tb_bpjs")
            Tb_bpjsDataGridView.DataSource = dataSet.Tables("tb_bpjs")
        ElseIf KelasFaskesComboBox.SelectedIndex = 1 Then
            dataAdapter = New SqlCeDataAdapter("SELECT nik,nama,tanggal_lahir,kelasFaskes FROM tb_bpjs WHERE kelasFaskes='1'", koneksi)
            dataSet.Clear()
            dataAdapter.Fill(dataSet, "tb_bpjs")
            Tb_bpjsDataGridView.DataSource = dataSet.Tables("tb_bpjs")
        ElseIf KelasFaskesComboBox.SelectedIndex = 2 Then
            dataAdapter = New SqlCeDataAdapter("SELECT nik,nama,tanggal_lahir,kelasFaskes FROM tb_bpjs WHERE kelasFaskes='2'", koneksi)
            dataSet.Clear()
            dataAdapter.Fill(dataSet, "tb_bpjs")
            Tb_bpjsDataGridView.DataSource = dataSet.Tables("tb_bpjs")
        ElseIf KelasFaskesComboBox.SelectedIndex = 3 Then
            dataAdapter = New SqlCeDataAdapter("SELECT nik,nama,tanggal_lahir,kelasFaskes FROM tb_bpjs WHERE kelasFaskes='3'", koneksi)
            dataSet.Clear()
            dataAdapter.Fill(dataSet, "tb_bpjs")
            Tb_bpjsDataGridView.DataSource = dataSet.Tables("tb_bpjs")
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If KelasFaskesComboBox.SelectedItem Is Nothing Then
            MessageBox.Show("Kelas Faskes Tidak Ditersedia !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            KelasFaskesComboBox.SelectedIndex = 0
        ElseIf Tb_bpjsDataGridView.RowCount = 0 Then
            MessageBox.Show("Data Kosong !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            PrintDocument1.DefaultPageSettings.Landscape = True
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.FormBorderStyle = FormBorderStyle.None
            PrintPreviewDialog1.WindowState = FormWindowState.Maximized
            AddHandler PrintDocument1.PrintPage, AddressOf Me.printDocument1_PrintPage
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        Dim f As Font = New Font("Times New Roman", 14, FontStyle.Bold)
        Dim G As Font = New Font("Times New Roman", 14)
        Dim br As SolidBrush = New SolidBrush(Color.Black) 'br = adalah warna font
        Dim p As Pen = New Pen(Color.Black) 'p = adalah warna garis

        Dim Judul As String = "LAPORAN JUMLAH PESERTA BPJS BERDASARKAN KELAS TERTENTU"
        e.Graphics.DrawString(Judul, f, br, 250, 60)
        e.Graphics.DrawString("NIK", f, br, 100, 90)
        e.Graphics.DrawString("NAMA LENGKAP", f, br, 300, 90)
        e.Graphics.DrawString("TANGGAL LAHIR", f, br, 600, 90)
        e.Graphics.DrawString("KELAS BPJS", f, br, 900, 90)

        e.Graphics.DrawLine(p, 45, 90, 1045, 90)
        e.Graphics.DrawLine(p, 45, 115, 1045, 115)
        Dim tinggi As Integer = 115
        For Each baris As DataGridViewRow In Tb_bpjsDataGridView.Rows
            e.Graphics.DrawString(baris.Cells("nik").Value.ToString, f, br, 60, tinggi)
            e.Graphics.DrawString(baris.Cells("nama").Value.ToString, f, br, 300, tinggi)
            e.Graphics.DrawString(baris.Cells("tanggal_lahir").Value.ToString, f, br, 600, tinggi)
            e.Graphics.DrawString(baris.Cells("kelasFaskes").Value.ToString, f, br, 950, tinggi)
            e.Graphics.DrawLine(p, 45, tinggi, 1045, tinggi)
            tinggi += 25
        Next

    End Sub

    Private Sub KelasFaskesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KelasFaskesComboBox.SelectedIndexChanged
        ReadData()
    End Sub
End Class