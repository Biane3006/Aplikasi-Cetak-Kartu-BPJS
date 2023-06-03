<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Petugas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Petugas))
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.labelBPJS = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labelTime = New System.Windows.Forms.Label()
        Me.labelWaktu = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnCetakKartu = New System.Windows.Forms.Button()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnGrafikPengguna = New System.Windows.Forms.Button()
        Me.btnInputData = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.labelMenuAktif = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.labelCopyright = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.PanelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLogo.Controls.Add(Me.labelBPJS)
        Me.PanelLogo.Controls.Add(Me.PictureBox2)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(260, 104)
        Me.PanelLogo.TabIndex = 0
        '
        'labelBPJS
        '
        Me.labelBPJS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelBPJS.AutoSize = True
        Me.labelBPJS.BackColor = System.Drawing.Color.Transparent
        Me.labelBPJS.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBPJS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelBPJS.Location = New System.Drawing.Point(41, 65)
        Me.labelBPJS.Name = "labelBPJS"
        Me.labelBPJS.Size = New System.Drawing.Size(180, 28)
        Me.labelBPJS.TabIndex = 16
        Me.labelBPJS.Text = "BPJS KESEHATAN"
        Me.labelBPJS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(99, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnKeluar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnKeluar.Image = CType(resources.GetObject("btnKeluar.Image"), System.Drawing.Image)
        Me.btnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKeluar.Location = New System.Drawing.Point(712, 0)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnKeluar.Size = New System.Drawing.Size(54, 41)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel1.Controls.Add(Me.labelTime)
        Me.Panel1.Controls.Add(Me.btnKeluar)
        Me.Panel1.Controls.Add(Me.labelWaktu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(262, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(766, 41)
        Me.Panel1.TabIndex = 3
        '
        'labelTime
        '
        Me.labelTime.AutoSize = True
        Me.labelTime.BackColor = System.Drawing.Color.Transparent
        Me.labelTime.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.labelTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelTime.Location = New System.Drawing.Point(216, 0)
        Me.labelTime.Name = "labelTime"
        Me.labelTime.Size = New System.Drawing.Size(93, 37)
        Me.labelTime.TabIndex = 22
        Me.labelTime.Text = "Waktu"
        '
        'labelWaktu
        '
        Me.labelWaktu.AutoSize = True
        Me.labelWaktu.BackColor = System.Drawing.Color.Transparent
        Me.labelWaktu.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelWaktu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelWaktu.Location = New System.Drawing.Point(6, 0)
        Me.labelWaktu.Name = "labelWaktu"
        Me.labelWaktu.Size = New System.Drawing.Size(113, 37)
        Me.labelWaktu.TabIndex = 21
        Me.labelWaktu.Text = "Tanggal"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(262, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(766, 354)
        Me.Panel3.TabIndex = 4
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMenu.Controls.Add(Me.btnCetakKartu)
        Me.PanelMenu.Controls.Add(Me.btnLaporan)
        Me.PanelMenu.Controls.Add(Me.btnGrafikPengguna)
        Me.PanelMenu.Controls.Add(Me.btnInputData)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(262, 477)
        Me.PanelMenu.TabIndex = 0
        '
        'btnCetakKartu
        '
        Me.btnCetakKartu.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnCetakKartu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCetakKartu.FlatAppearance.BorderSize = 0
        Me.btnCetakKartu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetakKartu.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetakKartu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCetakKartu.Image = CType(resources.GetObject("btnCetakKartu.Image"), System.Drawing.Image)
        Me.btnCetakKartu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCetakKartu.Location = New System.Drawing.Point(0, 236)
        Me.btnCetakKartu.Name = "btnCetakKartu"
        Me.btnCetakKartu.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnCetakKartu.Size = New System.Drawing.Size(260, 44)
        Me.btnCetakKartu.TabIndex = 14
        Me.btnCetakKartu.Text = "Cetak Kartu BPJS"
        Me.btnCetakKartu.UseVisualStyleBackColor = False
        '
        'btnLaporan
        '
        Me.btnLaporan.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnLaporan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLaporan.FlatAppearance.BorderSize = 0
        Me.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporan.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLaporan.Image = CType(resources.GetObject("btnLaporan.Image"), System.Drawing.Image)
        Me.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaporan.Location = New System.Drawing.Point(0, 192)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnLaporan.Size = New System.Drawing.Size(260, 44)
        Me.btnLaporan.TabIndex = 13
        Me.btnLaporan.Text = "Laporan Data BPJS"
        Me.btnLaporan.UseVisualStyleBackColor = False
        '
        'btnGrafikPengguna
        '
        Me.btnGrafikPengguna.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnGrafikPengguna.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGrafikPengguna.FlatAppearance.BorderSize = 0
        Me.btnGrafikPengguna.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrafikPengguna.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrafikPengguna.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGrafikPengguna.Image = CType(resources.GetObject("btnGrafikPengguna.Image"), System.Drawing.Image)
        Me.btnGrafikPengguna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrafikPengguna.Location = New System.Drawing.Point(0, 148)
        Me.btnGrafikPengguna.Name = "btnGrafikPengguna"
        Me.btnGrafikPengguna.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnGrafikPengguna.Size = New System.Drawing.Size(260, 44)
        Me.btnGrafikPengguna.TabIndex = 12
        Me.btnGrafikPengguna.Text = "Grafik Pengguna BPJS"
        Me.btnGrafikPengguna.UseVisualStyleBackColor = False
        '
        'btnInputData
        '
        Me.btnInputData.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnInputData.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInputData.FlatAppearance.BorderSize = 0
        Me.btnInputData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInputData.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInputData.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnInputData.Image = CType(resources.GetObject("btnInputData.Image"), System.Drawing.Image)
        Me.btnInputData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInputData.Location = New System.Drawing.Point(0, 104)
        Me.btnInputData.Name = "btnInputData"
        Me.btnInputData.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnInputData.Size = New System.Drawing.Size(260, 44)
        Me.btnInputData.TabIndex = 10
        Me.btnInputData.Text = "Input Data"
        Me.btnInputData.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Panel4.Controls.Add(Me.labelMenuAktif)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(262, 41)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(766, 41)
        Me.Panel4.TabIndex = 4
        '
        'labelMenuAktif
        '
        Me.labelMenuAktif.AutoSize = True
        Me.labelMenuAktif.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMenuAktif.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelMenuAktif.Location = New System.Drawing.Point(298, 3)
        Me.labelMenuAktif.Name = "labelMenuAktif"
        Me.labelMenuAktif.Size = New System.Drawing.Size(261, 37)
        Me.labelMenuAktif.TabIndex = 21
        Me.labelMenuAktif.Text = "SELAMAT DATANG"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel5.Controls.Add(Me.labelCopyright)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(262, 436)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(766, 41)
        Me.Panel5.TabIndex = 5
        '
        'labelCopyright
        '
        Me.labelCopyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelCopyright.AutoSize = True
        Me.labelCopyright.BackColor = System.Drawing.Color.Transparent
        Me.labelCopyright.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCopyright.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelCopyright.Location = New System.Drawing.Point(55, 11)
        Me.labelCopyright.Name = "labelCopyright"
        Me.labelCopyright.Size = New System.Drawing.Size(639, 21)
        Me.labelCopyright.TabIndex = 17
        Me.labelCopyright.Text = "Copyright © 2023 | 2109106090  | Syamsir | Informatika 2021 | Universitas Mulawar" & _
    "man"
        Me.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Petugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 477)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Petugas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnLaporan As Button
    Friend WithEvents btnGrafikPengguna As Button
    Friend WithEvents btnInputData As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents labelBPJS As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents labelMenuAktif As Label
    Friend WithEvents labelCopyright As Label
    Friend WithEvents btnCetakKartu As Button
    Friend WithEvents labelTime As Label
    Friend WithEvents labelWaktu As Label
    Friend WithEvents Timer1 As Timer
End Class
