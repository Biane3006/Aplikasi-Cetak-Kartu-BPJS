<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDatabase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDatabase))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.KelurahanComboBox = New System.Windows.Forms.ComboBox()
        Me.KecamatanComboBox = New System.Windows.Forms.ComboBox()
        Me.KotaComboBox = New System.Windows.Forms.ComboBox()
        Me.ProvinsiComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbDataPeserta = New System.Windows.Forms.GroupBox()
        Me.Tanggal_lahirDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.KelasFaskesComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nik = New System.Windows.Forms.Label()
        Me.Tb_bpjsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Alamat_lengkapWatermark = New SYAMSIR_2109106090_T6.Watermark()
        Me.NikWatermark = New SYAMSIR_2109106090_T6.Watermark()
        Me.NamaWatermark = New SYAMSIR_2109106090_T6.Watermark()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbDataPeserta.SuspendLayout()
        CType(Me.Tb_bpjsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnHapus)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnBatal)
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.btnTambah)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.gbDataPeserta)
        Me.Panel1.Controls.Add(Me.Tb_bpjsDataGridView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1092, 559)
        Me.Panel1.TabIndex = 2
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Transparent
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.Black
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHapus.Location = New System.Drawing.Point(306, 210)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(44, 44)
        Me.btnHapus.TabIndex = 53
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(279, 210)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(44, 44)
        Me.btnEdit.TabIndex = 52
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Transparent
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ForeColor = System.Drawing.Color.Black
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(128, 210)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(95, 44)
        Me.btnBatal.TabIndex = 51
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Transparent
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.Black
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(14, 210)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(108, 44)
        Me.btnSimpan.TabIndex = 50
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.Transparent
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.Black
        Me.btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), System.Drawing.Image)
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(229, 210)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(44, 44)
        Me.btnTambah.TabIndex = 49
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Alamat_lengkapWatermark)
        Me.GroupBox1.Controls.Add(Me.KelurahanComboBox)
        Me.GroupBox1.Controls.Add(Me.KecamatanComboBox)
        Me.GroupBox1.Controls.Add(Me.KotaComboBox)
        Me.GroupBox1.Controls.Add(Me.ProvinsiComboBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(714, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 246)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alamat Peserta BPJS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 25)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Alamat Lengkap"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 25)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Kelurahan / Desa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 25)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Kecamatan"
        '
        'KelurahanComboBox
        '
        Me.KelurahanComboBox.FormattingEnabled = True
        Me.KelurahanComboBox.Location = New System.Drawing.Point(169, 148)
        Me.KelurahanComboBox.Name = "KelurahanComboBox"
        Me.KelurahanComboBox.Size = New System.Drawing.Size(200, 29)
        Me.KelurahanComboBox.TabIndex = 43
        '
        'KecamatanComboBox
        '
        Me.KecamatanComboBox.FormattingEnabled = True
        Me.KecamatanComboBox.Location = New System.Drawing.Point(169, 110)
        Me.KecamatanComboBox.Name = "KecamatanComboBox"
        Me.KecamatanComboBox.Size = New System.Drawing.Size(200, 29)
        Me.KecamatanComboBox.TabIndex = 41
        '
        'KotaComboBox
        '
        Me.KotaComboBox.FormattingEnabled = True
        Me.KotaComboBox.Location = New System.Drawing.Point(169, 71)
        Me.KotaComboBox.Name = "KotaComboBox"
        Me.KotaComboBox.Size = New System.Drawing.Size(200, 29)
        Me.KotaComboBox.TabIndex = 39
        '
        'ProvinsiComboBox
        '
        Me.ProvinsiComboBox.FormattingEnabled = True
        Me.ProvinsiComboBox.Items.AddRange(New Object() {"Kalimantan Timur"})
        Me.ProvinsiComboBox.Location = New System.Drawing.Point(169, 32)
        Me.ProvinsiComboBox.Name = "ProvinsiComboBox"
        Me.ProvinsiComboBox.Size = New System.Drawing.Size(200, 29)
        Me.ProvinsiComboBox.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 25)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Kota / Kabupaten"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 25)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Provinsi"
        '
        'gbDataPeserta
        '
        Me.gbDataPeserta.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.gbDataPeserta.Controls.Add(Me.NikWatermark)
        Me.gbDataPeserta.Controls.Add(Me.NamaWatermark)
        Me.gbDataPeserta.Controls.Add(Me.Tanggal_lahirDateTimePicker)
        Me.gbDataPeserta.Controls.Add(Me.KelasFaskesComboBox)
        Me.gbDataPeserta.Controls.Add(Me.Label8)
        Me.gbDataPeserta.Controls.Add(Me.Label2)
        Me.gbDataPeserta.Controls.Add(Me.Label1)
        Me.gbDataPeserta.Controls.Add(Me.Nik)
        Me.gbDataPeserta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDataPeserta.ForeColor = System.Drawing.Color.Black
        Me.gbDataPeserta.Location = New System.Drawing.Point(346, 12)
        Me.gbDataPeserta.Name = "gbDataPeserta"
        Me.gbDataPeserta.Size = New System.Drawing.Size(370, 246)
        Me.gbDataPeserta.TabIndex = 2
        Me.gbDataPeserta.TabStop = False
        Me.gbDataPeserta.Text = "Identitas Peserta BPJS"
        '
        'Tanggal_lahirDateTimePicker
        '
        Me.Tanggal_lahirDateTimePicker.Location = New System.Drawing.Point(150, 99)
        Me.Tanggal_lahirDateTimePicker.Name = "Tanggal_lahirDateTimePicker"
        Me.Tanggal_lahirDateTimePicker.Size = New System.Drawing.Size(200, 29)
        Me.Tanggal_lahirDateTimePicker.TabIndex = 35
        '
        'KelasFaskesComboBox
        '
        Me.KelasFaskesComboBox.FormattingEnabled = True
        Me.KelasFaskesComboBox.Items.AddRange(New Object() {"1", "2", "3"})
        Me.KelasFaskesComboBox.Location = New System.Drawing.Point(150, 134)
        Me.KelasFaskesComboBox.Name = "KelasFaskesComboBox"
        Me.KelasFaskesComboBox.Size = New System.Drawing.Size(200, 29)
        Me.KelasFaskesComboBox.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 25)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Kelas Faskes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Tanggal Lahir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nama Lengkap"
        '
        'Nik
        '
        Me.Nik.AutoSize = True
        Me.Nik.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nik.ForeColor = System.Drawing.Color.Black
        Me.Nik.Location = New System.Drawing.Point(6, 27)
        Me.Nik.Name = "Nik"
        Me.Nik.Size = New System.Drawing.Size(40, 25)
        Me.Nik.TabIndex = 19
        Me.Nik.Text = "Nik"
        '
        'Tb_bpjsDataGridView
        '
        Me.Tb_bpjsDataGridView.AllowUserToAddRows = False
        Me.Tb_bpjsDataGridView.AllowUserToDeleteRows = False
        Me.Tb_bpjsDataGridView.AllowUserToResizeColumns = False
        Me.Tb_bpjsDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Tb_bpjsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Tb_bpjsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Tb_bpjsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tb_bpjsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tb_bpjsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Tb_bpjsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Tb_bpjsDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.Tb_bpjsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Tb_bpjsDataGridView.EnableHeadersVisualStyles = False
        Me.Tb_bpjsDataGridView.Location = New System.Drawing.Point(0, 254)
        Me.Tb_bpjsDataGridView.MultiSelect = False
        Me.Tb_bpjsDataGridView.Name = "Tb_bpjsDataGridView"
        Me.Tb_bpjsDataGridView.ReadOnly = True
        Me.Tb_bpjsDataGridView.RowHeadersVisible = False
        Me.Tb_bpjsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Tb_bpjsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Tb_bpjsDataGridView.Size = New System.Drawing.Size(1044, 270)
        Me.Tb_bpjsDataGridView.TabIndex = 1
        '
        'Alamat_lengkapWatermark
        '
        Me.Alamat_lengkapWatermark.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Alamat_lengkapWatermark.Location = New System.Drawing.Point(169, 190)
        Me.Alamat_lengkapWatermark.MaxLength = 1000
        Me.Alamat_lengkapWatermark.Name = "Alamat_lengkapWatermark"
        Me.Alamat_lengkapWatermark.Size = New System.Drawing.Size(200, 29)
        Me.Alamat_lengkapWatermark.TabIndex = 45
        Me.Alamat_lengkapWatermark.WatermarkColor = System.Drawing.Color.Gray
        Me.Alamat_lengkapWatermark.WatermarkText = "Alamat Rumah"
        '
        'NikWatermark
        '
        Me.NikWatermark.Location = New System.Drawing.Point(150, 27)
        Me.NikWatermark.MaxLength = 16
        Me.NikWatermark.Name = "NikWatermark"
        Me.NikWatermark.Size = New System.Drawing.Size(200, 29)
        Me.NikWatermark.TabIndex = 31
        Me.NikWatermark.WatermarkColor = System.Drawing.Color.Gray
        Me.NikWatermark.WatermarkText = "NIK (16 Digit)"
        '
        'NamaWatermark
        '
        Me.NamaWatermark.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NamaWatermark.Location = New System.Drawing.Point(150, 62)
        Me.NamaWatermark.MaxLength = 200
        Me.NamaWatermark.Name = "NamaWatermark"
        Me.NamaWatermark.Size = New System.Drawing.Size(200, 29)
        Me.NamaWatermark.TabIndex = 33
        Me.NamaWatermark.WatermarkColor = System.Drawing.Color.Gray
        Me.NamaWatermark.WatermarkText = "Nama Lengkap"
        '
        'FormDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 559)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDatabase"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbDataPeserta.ResumeLayout(False)
        Me.gbDataPeserta.PerformLayout()
        CType(Me.Tb_bpjsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gbDataPeserta As System.Windows.Forms.GroupBox
    Friend WithEvents Nik As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Tb_bpjsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Alamat_lengkapWatermark As SYAMSIR_2109106090_T6.Watermark
    Friend WithEvents KelurahanComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents KecamatanComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents KotaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProvinsiComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NikWatermark As SYAMSIR_2109106090_T6.Watermark
    Friend WithEvents NamaWatermark As SYAMSIR_2109106090_T6.Watermark
    Friend WithEvents Tanggal_lahirDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents KelasFaskesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
End Class
