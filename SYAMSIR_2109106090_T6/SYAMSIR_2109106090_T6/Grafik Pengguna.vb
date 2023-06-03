Imports System.Data
Imports System.Data.SqlServerCe
Imports System.IO

Public Class Grafik_Pengguna
    Dim PathDatabase As String = Application.StartupPath & "\dbBPJS.sdf"
    Private koneksi As New SqlCeConnection("Data Source=" & PathDatabase)
    Private dataAdapter As SqlCeDataAdapter
    Private BacaData As SqlCeDataReader
    Private dataSet As New DataSet()

    Private Sub Grafik2Dimensi()
        Dim Kelas1 As Integer = 0
        Dim Kelas2 As Integer = 0
        Dim Kelas3 As Integer = 0
        Dim querySelect As New SqlCeCommand("SELECT kelasFaskes FROM tb_bpjs", koneksi)
        BacaData = querySelect.ExecuteReader()
        'Looping untuk membaca data per baris
        Dim DataKelas As Integer
        While BacaData.Read()
            DataKelas = BacaData.GetInt32(0)
            If DataKelas = 1 Then
                Kelas1 += 1
            ElseIf DataKelas = 2 Then
                Kelas2 += 1
            ElseIf DataKelas = 3 Then
                Kelas3 += 1
            End If
        End While
        BacaData.Close()
        With Chart1
            .Titles.Clear()
            .Series.Clear()
            .Titles.Add("GRAFIK JUMLAH PESERTA BPJS BERDASARKAN KELAS")
            .Series.Add("Jumlah Peserta")
            .Series(0).Points.Clear()
            .Series(0).Points.AddXY("Kelas 1", Kelas1)
            .Series(0).Points.AddXY("Kelas 2", Kelas2)
            .Series(0).Points.AddXY("Kelas 3", Kelas3)
            .Series(0).Points(0).Color = Color.Red
            .Series(0).Points(1).Color = Color.Green
            .Series(0).Points(2).Color = Color.Blue
        End With
    End Sub



    Private Sub btnGrafik2D_Click(sender As Object, e As EventArgs) Handles btnGrafik2D.Click
        PictureBox2.Visible = True
        Timer1.Enabled = True
    End Sub

    Private Sub btnGrafik3D_Click(sender As Object, e As EventArgs) Handles btnGrafik3D.Click
        PictureBox2.Visible = True
        Timer2.Enabled = True
    End Sub

    Private Sub Grafik_Pengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Size = Me.Size
        koneksi.Open()
        btnGrafik2D.BackColor = Color.Transparent
        btnGrafik3D.BackColor = Color.Transparent
        btnGrafik2D.Location = New Point((Me.Width / 4) - (btnGrafik2D.Width / 2), 50)
        btnGrafik3D.Location = New Point((Me.Width - (Me.Width / 4)) - (btnGrafik3D.Width / 2), 50)
        Chart1.Size = New Size((btnGrafik3D.Location.X + btnGrafik3D.Width) - btnGrafik2D.Location.X, 340)
        Chart1.Location = New Point(btnGrafik2D.Location.X, btnGrafik2D.Location.Y + btnGrafik2D.Height + 10)
        PictureBox2.Location = New Point((Me.Width / 2) - (PictureBox2.Width / 2), Chart1.Location.Y + 120)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        PictureBox2.Visible = False
        Call Grafik2Dimensi()
        Chart1.ChartAreas(0).Area3DStyle.Enable3D = False
        Chart1.Visible = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        PictureBox2.Visible = False
        Call Grafik2Dimensi()
        Chart1.ChartAreas(0).Area3DStyle.Enable3D = True
        Chart1.Visible = True
    End Sub
End Class