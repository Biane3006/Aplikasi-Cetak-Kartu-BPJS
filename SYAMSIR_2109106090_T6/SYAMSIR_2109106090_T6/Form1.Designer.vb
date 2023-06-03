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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.gbrBackground = New System.Windows.Forms.PictureBox()
        Me.gbrBarcode = New System.Windows.Forms.PictureBox()
        Me.gbrHealthy = New System.Windows.Forms.PictureBox()
        Me.gbrGaruda = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.tbNamaLengkap = New System.Windows.Forms.TextBox()
        Me.tbNamaJalan = New System.Windows.Forms.TextBox()
        Me.cbKelurahan = New System.Windows.Forms.TextBox()
        Me.cbKecamatan = New System.Windows.Forms.TextBox()
        Me.cbKotaAlamat = New System.Windows.Forms.TextBox()
        Me.cbProvinsiAlamat = New System.Windows.Forms.TextBox()
        Me.cbFaskes = New System.Windows.Forms.TextBox()
        Me.dtpTanggalLahir = New System.Windows.Forms.TextBox()
        Me.tbNIK = New SYAMSIR_2109106090_T6.Watermark()
        CType(Me.gbrBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbrBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbrHealthy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbrGaruda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.Transparent
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetak.ForeColor = System.Drawing.Color.Black
        Me.btnCetak.Image = CType(resources.GetObject("btnCetak.Image"), System.Drawing.Image)
        Me.btnCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCetak.Location = New System.Drawing.Point(541, 83)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(103, 38)
        Me.btnCetak.TabIndex = 0
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'gbrBackground
        '
        Me.gbrBackground.Enabled = False
        Me.gbrBackground.Image = CType(resources.GetObject("gbrBackground.Image"), System.Drawing.Image)
        Me.gbrBackground.Location = New System.Drawing.Point(134, 109)
        Me.gbrBackground.Name = "gbrBackground"
        Me.gbrBackground.Size = New System.Drawing.Size(36, 40)
        Me.gbrBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gbrBackground.TabIndex = 18
        Me.gbrBackground.TabStop = False
        Me.gbrBackground.Visible = False
        '
        'gbrBarcode
        '
        Me.gbrBarcode.Enabled = False
        Me.gbrBarcode.Image = CType(resources.GetObject("gbrBarcode.Image"), System.Drawing.Image)
        Me.gbrBarcode.Location = New System.Drawing.Point(92, 107)
        Me.gbrBarcode.Name = "gbrBarcode"
        Me.gbrBarcode.Size = New System.Drawing.Size(36, 40)
        Me.gbrBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gbrBarcode.TabIndex = 17
        Me.gbrBarcode.TabStop = False
        Me.gbrBarcode.Visible = False
        '
        'gbrHealthy
        '
        Me.gbrHealthy.Enabled = False
        Me.gbrHealthy.Image = CType(resources.GetObject("gbrHealthy.Image"), System.Drawing.Image)
        Me.gbrHealthy.Location = New System.Drawing.Point(50, 107)
        Me.gbrHealthy.Name = "gbrHealthy"
        Me.gbrHealthy.Size = New System.Drawing.Size(36, 40)
        Me.gbrHealthy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gbrHealthy.TabIndex = 16
        Me.gbrHealthy.TabStop = False
        Me.gbrHealthy.Visible = False
        '
        'gbrGaruda
        '
        Me.gbrGaruda.Enabled = False
        Me.gbrGaruda.Image = CType(resources.GetObject("gbrGaruda.Image"), System.Drawing.Image)
        Me.gbrGaruda.Location = New System.Drawing.Point(7, 107)
        Me.gbrGaruda.Name = "gbrGaruda"
        Me.gbrGaruda.Size = New System.Drawing.Size(36, 40)
        Me.gbrGaruda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gbrGaruda.TabIndex = 15
        Me.gbrGaruda.TabStop = False
        Me.gbrGaruda.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 736)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(874, 48)
        Me.Panel2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 37)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nomor Induk Kependudukan"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel6.Controls.Add(Me.gbrBackground)
        Me.Panel6.Controls.Add(Me.dtpTanggalLahir)
        Me.Panel6.Controls.Add(Me.gbrBarcode)
        Me.Panel6.Controls.Add(Me.cbFaskes)
        Me.Panel6.Controls.Add(Me.gbrHealthy)
        Me.Panel6.Controls.Add(Me.gbrGaruda)
        Me.Panel6.Controls.Add(Me.cbProvinsiAlamat)
        Me.Panel6.Controls.Add(Me.cbKotaAlamat)
        Me.Panel6.Controls.Add(Me.cbKecamatan)
        Me.Panel6.Controls.Add(Me.cbKelurahan)
        Me.Panel6.Controls.Add(Me.tbNamaJalan)
        Me.Panel6.Controls.Add(Me.tbNamaLengkap)
        Me.Panel6.Controls.Add(Me.tbNIK)
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Controls.Add(Me.btnCetak)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(874, 250)
        Me.Panel6.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(404, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 37)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = ":"
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Panel6)
        Me.Panel9.Controls.Add(Me.Panel2)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(874, 784)
        Me.Panel9.TabIndex = 19
        '
        'tbNamaLengkap
        '
        Me.tbNamaLengkap.Location = New System.Drawing.Point(152, 101)
        Me.tbNamaLengkap.Name = "tbNamaLengkap"
        Me.tbNamaLengkap.Size = New System.Drawing.Size(100, 20)
        Me.tbNamaLengkap.TabIndex = 18
        Me.tbNamaLengkap.Visible = False
        '
        'tbNamaJalan
        '
        Me.tbNamaJalan.Location = New System.Drawing.Point(152, 127)
        Me.tbNamaJalan.Name = "tbNamaJalan"
        Me.tbNamaJalan.Size = New System.Drawing.Size(100, 20)
        Me.tbNamaJalan.TabIndex = 19
        Me.tbNamaJalan.Visible = False
        '
        'cbKelurahan
        '
        Me.cbKelurahan.Location = New System.Drawing.Point(152, 153)
        Me.cbKelurahan.Name = "cbKelurahan"
        Me.cbKelurahan.Size = New System.Drawing.Size(100, 20)
        Me.cbKelurahan.TabIndex = 20
        Me.cbKelurahan.Visible = False
        '
        'cbKecamatan
        '
        Me.cbKecamatan.Location = New System.Drawing.Point(152, 179)
        Me.cbKecamatan.Name = "cbKecamatan"
        Me.cbKecamatan.Size = New System.Drawing.Size(100, 20)
        Me.cbKecamatan.TabIndex = 21
        Me.cbKecamatan.Visible = False
        '
        'cbKotaAlamat
        '
        Me.cbKotaAlamat.Location = New System.Drawing.Point(152, 75)
        Me.cbKotaAlamat.Name = "cbKotaAlamat"
        Me.cbKotaAlamat.Size = New System.Drawing.Size(100, 20)
        Me.cbKotaAlamat.TabIndex = 22
        Me.cbKotaAlamat.Visible = False
        '
        'cbProvinsiAlamat
        '
        Me.cbProvinsiAlamat.Location = New System.Drawing.Point(152, 49)
        Me.cbProvinsiAlamat.Name = "cbProvinsiAlamat"
        Me.cbProvinsiAlamat.Size = New System.Drawing.Size(100, 20)
        Me.cbProvinsiAlamat.TabIndex = 23
        Me.cbProvinsiAlamat.Visible = False
        '
        'cbFaskes
        '
        Me.cbFaskes.Location = New System.Drawing.Point(285, 83)
        Me.cbFaskes.Name = "cbFaskes"
        Me.cbFaskes.Size = New System.Drawing.Size(100, 20)
        Me.cbFaskes.TabIndex = 24
        Me.cbFaskes.Visible = False
        '
        'dtpTanggalLahir
        '
        Me.dtpTanggalLahir.Location = New System.Drawing.Point(387, 179)
        Me.dtpTanggalLahir.Name = "dtpTanggalLahir"
        Me.dtpTanggalLahir.Size = New System.Drawing.Size(100, 20)
        Me.dtpTanggalLahir.TabIndex = 25
        Me.dtpTanggalLahir.Visible = False
        '
        'tbNIK
        '
        Me.tbNIK.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNIK.Location = New System.Drawing.Point(444, 6)
        Me.tbNIK.MaxLength = 16
        Me.tbNIK.Name = "tbNIK"
        Me.tbNIK.Size = New System.Drawing.Size(200, 29)
        Me.tbNIK.TabIndex = 17
        Me.tbNIK.WatermarkColor = System.Drawing.Color.Gray
        Me.tbNIK.WatermarkText = "NIK (16 Digit)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(874, 784)
        Me.Controls.Add(Me.Panel9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gbrBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbrBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbrHealthy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbrGaruda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnCetak As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents gbrGaruda As PictureBox
    Friend WithEvents gbrBackground As PictureBox
    Friend WithEvents gbrBarcode As PictureBox
    Friend WithEvents gbrHealthy As PictureBox
    Friend WithEvents tbNIK As Watermark
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents tbNamaLengkap As System.Windows.Forms.TextBox
    Friend WithEvents tbNamaJalan As System.Windows.Forms.TextBox
    Friend WithEvents cbKelurahan As System.Windows.Forms.TextBox
    Friend WithEvents cbProvinsiAlamat As System.Windows.Forms.TextBox
    Friend WithEvents cbKotaAlamat As System.Windows.Forms.TextBox
    Friend WithEvents cbKecamatan As System.Windows.Forms.TextBox
    Friend WithEvents cbFaskes As System.Windows.Forms.TextBox
    Friend WithEvents dtpTanggalLahir As System.Windows.Forms.TextBox
End Class
