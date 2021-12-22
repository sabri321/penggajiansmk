<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class transaksi
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvtransaksi = New System.Windows.Forms.DataGridView()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbnip = New System.Windows.Forms.ComboBox()
        Me.txtjabatan = New System.Windows.Forms.TextBox()
        Me.txtkodetransaksi = New System.Windows.Forms.TextBox()
        Me.txtnamaguru = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtptanggallahir = New System.Windows.Forms.DateTimePicker()
        Me.txtbulan = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txttransport = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txthonor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txthonorbersih = New System.Windows.Forms.TextBox()
        Me.txtjumlahjamterisi = New System.Windows.Forms.TextBox()
        Me.txttunjangan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtgajipokok = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtnorekening = New System.Windows.Forms.TextBox()
        Me.cbmetode = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbjenis = New System.Windows.Forms.ComboBox()
        Me.txtnamabank = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btntambahdata = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvtransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvtransaksi
        '
        Me.dgvtransaksi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvtransaksi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtransaksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16})
        Me.dgvtransaksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvtransaksi.Location = New System.Drawing.Point(46, 495)
        Me.dgvtransaksi.Name = "dgvtransaksi"
        Me.dgvtransaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvtransaksi.Size = New System.Drawing.Size(1251, 199)
        Me.dgvtransaksi.TabIndex = 72
        '
        'btnclose
        '
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnclose.Location = New System.Drawing.Point(1118, 438)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 30)
        Me.btnclose.TabIndex = 71
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclear.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnclear.Location = New System.Drawing.Point(1037, 438)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 30)
        Me.btnclear.TabIndex = 70
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btndelete.Location = New System.Drawing.Point(956, 438)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 30)
        Me.btndelete.TabIndex = 69
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnsave.Location = New System.Drawing.Point(794, 438)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 30)
        Me.btnsave.TabIndex = 68
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(566, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 29)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "TRANSAKSI"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbnip)
        Me.GroupBox1.Controls.Add(Me.txtjabatan)
        Me.GroupBox1.Controls.Add(Me.txtkodetransaksi)
        Me.GroupBox1.Controls.Add(Me.txtnamaguru)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(123, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 218)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Identitas"
        '
        'cbnip
        '
        Me.cbnip.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.cbnip.FormattingEnabled = True
        Me.cbnip.Location = New System.Drawing.Point(154, 77)
        Me.cbnip.Name = "cbnip"
        Me.cbnip.Size = New System.Drawing.Size(146, 28)
        Me.cbnip.TabIndex = 103
        '
        'txtjabatan
        '
        Me.txtjabatan.Enabled = False
        Me.txtjabatan.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtjabatan.Location = New System.Drawing.Point(154, 144)
        Me.txtjabatan.Name = "txtjabatan"
        Me.txtjabatan.Size = New System.Drawing.Size(163, 26)
        Me.txtjabatan.TabIndex = 99
        '
        'txtkodetransaksi
        '
        Me.txtkodetransaksi.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtkodetransaksi.Location = New System.Drawing.Point(154, 44)
        Me.txtkodetransaksi.Name = "txtkodetransaksi"
        Me.txtkodetransaksi.Size = New System.Drawing.Size(310, 26)
        Me.txtkodetransaksi.TabIndex = 96
        '
        'txtnamaguru
        '
        Me.txtnamaguru.Enabled = False
        Me.txtnamaguru.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtnamaguru.Location = New System.Drawing.Point(154, 111)
        Me.txtnamaguru.Name = "txtnamaguru"
        Me.txtnamaguru.Size = New System.Drawing.Size(310, 26)
        Me.txtnamaguru.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Kode Transaksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(28, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 20)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "NIP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(28, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Nama Guru"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(28, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Jabatan"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtptanggallahir)
        Me.GroupBox2.Controls.Add(Me.txtbulan)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txttransport)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txthonor)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txthonorbersih)
        Me.GroupBox2.Controls.Add(Me.txtjumlahjamterisi)
        Me.GroupBox2.Controls.Add(Me.txttunjangan)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtgajipokok)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(672, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(521, 323)
        Me.GroupBox2.TabIndex = 100
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Honor Mengajar"
        '
        'dtptanggallahir
        '
        Me.dtptanggallahir.CalendarFont = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtptanggallahir.CustomFormat = "dd/MM/yyyy"
        Me.dtptanggallahir.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtptanggallahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtptanggallahir.Location = New System.Drawing.Point(147, 64)
        Me.dtptanggallahir.MinimumSize = New System.Drawing.Size(200, 27)
        Me.dtptanggallahir.Name = "dtptanggallahir"
        Me.dtptanggallahir.Size = New System.Drawing.Size(200, 27)
        Me.dtptanggallahir.TabIndex = 109
        Me.dtptanggallahir.Value = New Date(2021, 11, 14, 0, 0, 0, 0)
        '
        'txtbulan
        '
        Me.txtbulan.Enabled = False
        Me.txtbulan.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtbulan.Location = New System.Drawing.Point(147, 32)
        Me.txtbulan.Name = "txtbulan"
        Me.txtbulan.Size = New System.Drawing.Size(321, 26)
        Me.txtbulan.TabIndex = 108
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.Location = New System.Drawing.Point(21, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 20)
        Me.Label17.TabIndex = 107
        Me.Label17.Text = "Bulan"
        '
        'txttransport
        '
        Me.txttransport.Enabled = False
        Me.txttransport.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txttransport.Location = New System.Drawing.Point(147, 226)
        Me.txttransport.Name = "txttransport"
        Me.txttransport.Size = New System.Drawing.Size(150, 26)
        Me.txttransport.TabIndex = 105
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(21, 229)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 20)
        Me.Label16.TabIndex = 104
        Me.Label16.Text = "Transport"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 20)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "Tanggal"
        '
        'txthonor
        '
        Me.txthonor.Enabled = False
        Me.txthonor.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txthonor.Location = New System.Drawing.Point(147, 128)
        Me.txthonor.Name = "txthonor"
        Me.txthonor.Size = New System.Drawing.Size(321, 26)
        Me.txthonor.TabIndex = 101
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 20)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Honor"
        '
        'txthonorbersih
        '
        Me.txthonorbersih.Enabled = False
        Me.txthonorbersih.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txthonorbersih.Location = New System.Drawing.Point(147, 269)
        Me.txthonorbersih.Name = "txthonorbersih"
        Me.txthonorbersih.Size = New System.Drawing.Size(150, 44)
        Me.txthonorbersih.TabIndex = 99
        '
        'txtjumlahjamterisi
        '
        Me.txtjumlahjamterisi.Enabled = False
        Me.txtjumlahjamterisi.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtjumlahjamterisi.Location = New System.Drawing.Point(147, 97)
        Me.txtjumlahjamterisi.Name = "txtjumlahjamterisi"
        Me.txtjumlahjamterisi.Size = New System.Drawing.Size(56, 26)
        Me.txtjumlahjamterisi.TabIndex = 96
        '
        'txttunjangan
        '
        Me.txttunjangan.Enabled = False
        Me.txttunjangan.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txttunjangan.Location = New System.Drawing.Point(147, 194)
        Me.txttunjangan.Name = "txttunjangan"
        Me.txttunjangan.Size = New System.Drawing.Size(150, 26)
        Me.txttunjangan.TabIndex = 98
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 20)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Jumlah Jam Terisi"
        '
        'txtgajipokok
        '
        Me.txtgajipokok.Enabled = False
        Me.txtgajipokok.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtgajipokok.Location = New System.Drawing.Point(147, 160)
        Me.txtgajipokok.Name = "txtgajipokok"
        Me.txtgajipokok.Size = New System.Drawing.Size(321, 26)
        Me.txtgajipokok.TabIndex = 97
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(21, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 20)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Gaji Pokok"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(21, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 20)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Tunjangan Jabatan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(21, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 20)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Honor Bersih"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtnorekening)
        Me.GroupBox3.Controls.Add(Me.cbmetode)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.cbjenis)
        Me.GroupBox3.Controls.Add(Me.txtnamabank)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(123, 343)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(510, 125)
        Me.GroupBox3.TabIndex = 100
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lainnya"
        '
        'txtnorekening
        '
        Me.txtnorekening.Enabled = False
        Me.txtnorekening.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtnorekening.Location = New System.Drawing.Point(375, 65)
        Me.txtnorekening.Name = "txtnorekening"
        Me.txtnorekening.Size = New System.Drawing.Size(110, 26)
        Me.txtnorekening.TabIndex = 102
        '
        'cbmetode
        '
        Me.cbmetode.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.cbmetode.FormattingEnabled = True
        Me.cbmetode.Items.AddRange(New Object() {"Cash", "Transfer"})
        Me.cbmetode.Location = New System.Drawing.Point(104, 68)
        Me.cbmetode.Name = "cbmetode"
        Me.cbmetode.Size = New System.Drawing.Size(146, 28)
        Me.cbmetode.TabIndex = 101
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(282, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 20)
        Me.Label14.TabIndex = 101
        Me.Label14.Text = "No Rekening"
        '
        'cbjenis
        '
        Me.cbjenis.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.cbjenis.FormattingEnabled = True
        Me.cbjenis.Items.AddRange(New Object() {"Honorer", "Tetap"})
        Me.cbjenis.Location = New System.Drawing.Point(104, 35)
        Me.cbjenis.Name = "cbjenis"
        Me.cbjenis.Size = New System.Drawing.Size(146, 28)
        Me.cbjenis.TabIndex = 100
        '
        'txtnamabank
        '
        Me.txtnamabank.Enabled = False
        Me.txtnamabank.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtnamabank.Location = New System.Drawing.Point(375, 35)
        Me.txtnamabank.Name = "txtnamabank"
        Me.txtnamabank.Size = New System.Drawing.Size(110, 26)
        Me.txtnamabank.TabIndex = 98
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 20)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Jenis"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(25, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 20)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "Metode"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(282, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 20)
        Me.Label13.TabIndex = 94
        Me.Label13.Text = "Nama Bank"
        '
        'btnupdate
        '
        Me.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdate.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(875, 438)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 30)
        Me.btnupdate.TabIndex = 101
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btntambahdata
        '
        Me.btntambahdata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntambahdata.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btntambahdata.Location = New System.Drawing.Point(672, 438)
        Me.btntambahdata.Name = "btntambahdata"
        Me.btntambahdata.Size = New System.Drawing.Size(116, 30)
        Me.btntambahdata.TabIndex = 102
        Me.btntambahdata.Text = "Tambah Data"
        Me.btntambahdata.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kode Transaksi"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "NIP"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 130
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nama Guru"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 130
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tanggal"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 70
        '
        'Column5
        '
        Me.Column5.HeaderText = "Jabatan"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Gaji Pokok"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Tunjangan Jabatan"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Transport"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Jumlah Jam Terisi"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Honor"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Honor Bersih"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Jenis"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.HeaderText = "Metode"
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.HeaderText = "Nama Bank"
        Me.Column14.Name = "Column14"
        '
        'Column15
        '
        Me.Column15.HeaderText = "No. Rekening"
        Me.Column15.Name = "Column15"
        '
        'Column16
        '
        Me.Column16.HeaderText = "Bulan"
        Me.Column16.Name = "Column16"
        '
        'transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1341, 729)
        Me.Controls.Add(Me.btntambahdata)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvtransaksi)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "transaksi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvtransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvtransaksi As DataGridView
    Friend WithEvents btnclose As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtjabatan As TextBox
    Friend WithEvents txtkodetransaksi As TextBox
    Friend WithEvents txtnamaguru As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txthonor As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txthonorbersih As TextBox
    Friend WithEvents txtjumlahjamterisi As TextBox
    Friend WithEvents txttunjangan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtgajipokok As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtnamabank As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtnorekening As TextBox
    Friend WithEvents cbmetode As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cbjenis As ComboBox
    Friend WithEvents txttransport As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btnupdate As Button
    Friend WithEvents btntambahdata As Button
    Friend WithEvents txtbulan As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cbnip As ComboBox
    Friend WithEvents dtptanggallahir As DateTimePicker
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
End Class
