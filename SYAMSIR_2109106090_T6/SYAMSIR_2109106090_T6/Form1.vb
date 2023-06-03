Imports System.Data
Imports System.Data.SqlServerCe
Imports System.IO
Public Class Form1
    Dim PathDatabase As String = Application.StartupPath & "\dbBPJS.sdf"
    Private koneksi As New SqlCeConnection("Data Source=" & PathDatabase)
    Private dataAdapter As SqlCeDataAdapter
    Private BacaData As SqlCeDataReader
    Private dataSet As New DataSet()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi.Open()
        tbNIK.Focus()

        Label2.Location = New Point((Me.Width / 2) - ((Label2.Width + tbNIK.Width + Label15.Width + 20) / 2), 70)
        tbNIK.Location = New Point(Label2.Location.X + Label2.Width + 17, Label2.Location.Y + 8)
        Label15.Location = New Point(tbNIK.Location.X - 25, Label2.Location.Y)

        btnCetak.Location = New Point(tbNIK.Location.X, tbNIK.Location.Y + tbNIK.Height + 20)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If tbNIK.Text = "" Or tbNIK.TextLength < 16 Then
            MessageBox.Show("NIK Tidak Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            tbNIK.Focus()
        Else
            Dim querySelect As New SqlCeCommand("SELECT * FROM tb_bpjs WHERE nik='" & tbNIK.Text & "'", koneksi)
            BacaData = querySelect.ExecuteReader()
            If BacaData.Read() Then
                tbNamaLengkap.Text = BacaData.GetString(1)
                dtpTanggalLahir.Text = BacaData.GetDateTime(2).ToString("yyyy-MM-dd")
                cbProvinsiAlamat.Text = BacaData.GetString(3)
                cbKotaAlamat.Text = BacaData.GetString(4)
                cbKecamatan.Text = BacaData.GetString(5)
                cbKelurahan.Text = BacaData.GetString(6)
                tbNamaJalan.Text = BacaData.GetString(7)
                cbFaskes.Text = BacaData.GetInt32(8)
                PrintDocument1.DefaultPageSettings.Landscape = True
                PrintPreviewDialog1.Document = PrintDocument1
                PrintPreviewDialog1.FormBorderStyle = FormBorderStyle.None
                PrintPreviewDialog1.WindowState = FormWindowState.Maximized
                AddHandler PrintDocument1.PrintPage, AddressOf Me.printDocument1_PrintPage
                PrintPreviewDialog1.ShowDialog()
            Else
                MessageBox.Show("NIK Tidak Ditemukan !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                tbNIK.Focus()
            End If
        End If
    End Sub

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim randomNomor As String = ""
        Randomize()
        For i As Integer = 1 To 13
            randomNomor &= Int(Rnd() * 10)
        Next

        Dim rect As New Rectangle(50, 50, 1000, 646)
        Dim borderRadius As Integer = 20
        Dim penBorder As New Pen(Color.FromArgb(255, 0, 112, 64), 8)

        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        'Kiri Atas
        path.AddArc(rect.X, rect.Y, borderRadius * 2, borderRadius * 2, 180, 90)
        'path.AddLine(rect.X + borderRadius, rect.Y, rect.X + rect.Width - borderRadius, rect.Y)
        'Kanan Atas
        path.AddArc(rect.X + rect.Width - borderRadius * 2, rect.Y, borderRadius * 2, borderRadius * 2, 270, 90)
        'path.AddLine(rect.X + rect.Width, rect.Y + borderRadius, rect.X + rect.Width, rect.Y + rect.Y)

        path.AddLine(rect.Right, rect.Top + 120, rect.Left, rect.Top + 120)
        path.AddLine(rect.Left, rect.Top + 120, rect.Left, rect.Top + borderRadius)
        'Mengisi path dengan warna (HEADERNYA)
        Dim brush As New Drawing2D.LinearGradientBrush(rect, Color.FromArgb(255, 0, 112, 64), Color.FromArgb(255, 0, 112, 64), Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillPath(brush, path)


        'Membuat kotak ISIANNYA
        path.AddArc(rect.X + rect.Width - borderRadius * 2, rect.Y + rect.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90)
        path.AddArc(rect.X, rect.Y + rect.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90)
        path.AddLine(rect.X + rect.Width, rect.Y + rect.Height - borderRadius, rect.X + rect.Width, rect.Y + rect.Height - borderRadius)
        'Mengisi path dengan gambar (ISIANNYA)
        'Mengisi background image
        Dim gambarBackground As Image = gbrBackground.Image
        e.Graphics.DrawImage(gambarBackground, rect.Left, rect.Top + 120, rect.Width, rect.Bottom - 170)

        path.CloseFigure()
        ' Draw the top and bottom lines inside the rectangle
        e.Graphics.DrawLine(penBorder, rect.Left, rect.Top + 120, rect.Right, rect.Top + 120)

        Dim penBorder1 As New Pen(Color.FromArgb(255, 0, 166, 80), 5)
        'Garis Tepi atas
        e.Graphics.DrawLine(penBorder1, rect.Left + borderRadius, rect.Top, rect.Right - borderRadius, rect.Top)
        'Garis Tepi bawah
        e.Graphics.DrawLine(penBorder1, rect.Left + borderRadius, rect.Bottom, rect.Right - borderRadius, rect.Bottom)
        'Garis Tepi Kanan
        e.Graphics.DrawLine(penBorder1, rect.Right, rect.Top + borderRadius, rect.Right, rect.Bottom - borderRadius)
        'Garis Tepi Kiri
        e.Graphics.DrawLine(penBorder1, rect.Left, rect.Top + borderRadius, rect.Left, rect.Bottom - borderRadius)

        'Lengkungan Kanan Atas
        e.Graphics.DrawCurve(penBorder1, {New Point(rect.Right - borderRadius - 1, rect.Top), New Point(rect.Right - 6, rect.Top + 6), New Point(rect.Right, rect.Top + borderRadius + 1)})
        'Lengkungan Kiri Atas
        e.Graphics.DrawCurve(penBorder1, {New Point(rect.Left + borderRadius + 1, rect.Top), New Point(rect.Left + 6, rect.Top + 6), New Point(rect.Left, rect.Top + borderRadius + 1)})
        'Lengkungan Kanan Bawah
        e.Graphics.DrawCurve(penBorder1, {New Point(rect.Right - borderRadius - 1, rect.Bottom), New Point(rect.Right - 6, rect.Bottom - 6), New Point(rect.Right, rect.Bottom - borderRadius - 1)})
        'Lengkungan Kiri Bawah
        e.Graphics.DrawCurve(penBorder1, {New Point(rect.Left + borderRadius + 1, rect.Bottom), New Point(rect.Left + 6, rect.Bottom - 6), New Point(rect.Left, rect.Bottom - borderRadius - 1)})


        ' Load the Garuda image
        Dim garudaImage As Image = gbrGaruda.Image

        ' Draw the Garuda image on the left side of the rectangle
        e.Graphics.DrawImage(garudaImage, rect.Left + 20, rect.Top + 3, 120, 120)

        ' Load the Healthy Care logo image
        Dim healthyCareImage As Image = gbrHealthy.Image

        ' Draw the Healthy Care logo image on the left side of the rectangle
        e.Graphics.DrawImage(healthyCareImage, rect.Left + 855, rect.Top + 3, 130, 120)


        ' Load Gambar Barcode
        Dim barcodeImage As Image = gbrBarcode.Image

        ' Draw the Garuda image on the left side of the rectangle
        e.Graphics.DrawImage(barcodeImage, rect.Left + 100, rect.Top + 150, 400, 40)

        ' Draw the text data inside the rectangle
        Dim fontJudul As New Font("Calibri", 40, FontStyle.Bold)
        e.Graphics.DrawString("Kartu Indonesia Sehat", fontJudul, Brushes.White, rect.Left + 240, rect.Top + 30)

        Dim fontData As New Font("Arial", 18, FontStyle.Regular)
        e.Graphics.DrawString("Nomor Kartu", fontData, Brushes.Black, rect.Left + 100, rect.Top + 200)
        e.Graphics.DrawString(": " & randomNomor, fontData, Brushes.Black, rect.Left + 300, rect.Top + 200)

        e.Graphics.DrawString("Nama", fontData, Brushes.Black, rect.Left + 100, rect.Top + 240)
        e.Graphics.DrawString(": " & tbNamaLengkap.Text, fontData, Brushes.Black, rect.Left + 300, rect.Top + 240)

        e.Graphics.DrawString("Alamat", fontData, Brushes.Black, rect.Left + 100, rect.Top + 280)

        If Len(tbNamaJalan.Text & " " & cbKelurahan.Text & " " & cbKecamatan.Text) > 50 Then
            e.Graphics.DrawString(": " & tbNamaJalan.Text & " " & cbKelurahan.Text, fontData, Brushes.Black, rect.Left + 300, rect.Top + 280)
            e.Graphics.DrawString("  " & cbKecamatan.Text & " " & cbKotaAlamat.Text & " " & cbProvinsiAlamat.Text, fontData, Brushes.Black, rect.Left + 300, rect.Top + 320)
        Else
            e.Graphics.DrawString(": " & tbNamaJalan.Text & " " & cbKelurahan.Text & " " & cbKecamatan.Text, fontData, Brushes.Black, rect.Left + 300, rect.Top + 280)
            e.Graphics.DrawString("  " & cbKotaAlamat.Text & " " & cbProvinsiAlamat.Text, fontData, Brushes.Black, rect.Left + 300, rect.Top + 320)
        End If

        e.Graphics.DrawString("Tanggal Lahir", fontData, Brushes.Black, rect.Left + 100, rect.Top + 360)
        e.Graphics.DrawString(": " & dtpTanggalLahir.Text, fontData, Brushes.Black, rect.Left + 300, rect.Top + 360)

        e.Graphics.DrawString("NIK", fontData, Brushes.Black, rect.Left + 100, rect.Top + 400)
        e.Graphics.DrawString(": " & tbNIK.Text, fontData, Brushes.Black, rect.Left + 300, rect.Top + 400)

        e.Graphics.DrawString("Kelas Faskes", fontData, Brushes.Black, rect.Left + 100, rect.Top + 440)
        e.Graphics.DrawString(": " & cbFaskes.Text, fontData, Brushes.Black, rect.Left + 300, rect.Top + 440)

        Dim fontKetentuan As New Font("Arial", 10, FontStyle.Regular)
        e.Graphics.DrawString("Syarat dan Ketentuan:" & Environment.NewLine & "1.Kartu Peserta harap dibawa ketika berobat." & Environment.NewLine & "2. Apabila kartu ini disalahgunakan akan dikenakan sanksi." & Environment.NewLine & "3. Apabila ada perubahan atau kehilangan Kartu, segera lapor ke kantor BPJS Kesehatan setempat. " & Environment.NewLine & "BPJS Kesehatan Care Center 165 " & Environment.NewLine & "www.bpjs-kesehatan.go.id", fontKetentuan, Brushes.Black, rect.Left + 100, rect.Top + 485)

        Dim fontTanggal As New Font("Arial", 8, FontStyle.Regular)
        e.Graphics.DrawString(("Kartu ini dicetak pada " + Format(Now, "dd-MM-yyyy HH:mm:ss")), fontTanggal, Brushes.Black, rect.Left + 100, rect.Bottom - 20)
    End Sub


    Private Sub tbNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNIK.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbNIK_KeyDown(sender As Object, e As KeyEventArgs) Handles tbNIK.KeyDown, tbNIK.KeyUp
        If e.KeyCode = Keys.Down Then
            btnCetak.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            btnCetak.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            btnPrint_Click(Me, New EventArgs)
        End If
    End Sub
End Class
