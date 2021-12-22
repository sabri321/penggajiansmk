Imports System.Data.Odbc
Public Class transaksi
    Sub tampil_transaksi()
        CMD = New OdbcCommand("select * from transaksi", Conn)
        Rd = CMD.ExecuteReader
        dgvtransaksi.Rows.Clear()
        Do While Rd.Read = True
            dgvtransaksi.Rows.Add(Rd(0), Rd(1), Rd(2), Rd(3), Rd(4), Rd(5), Rd(6), Rd(7), Rd(8), Rd(9), Rd(10), Rd(11), Rd(12), Rd(13), Rd(14), Rd(15))
        Loop
    End Sub

    Sub bersih()
        txtkodetransaksi.Clear()
        cbnip.Text = ""
        txtnamaguru.Clear()
        'dtptanggal.ResetText()
        txtjabatan.Clear()
        txtgajipokok.Clear()
        txttunjangan.Clear()
        txtjumlahjamterisi.Clear()
        txthonor.Clear()
        txthonorbersih.Clear()
        txtbulan.Clear()
        txttransport.Clear()
        cbjenis.Text = ""
        cbmetode.Text = ""
        txtnamabank.Clear()
        txtnorekening.Clear()
        cbnip.Focus()
    End Sub

    Sub bersihtambahdata()
        'txtkodetransaksi.Clear()
        cbnip.Text = ""
        txtnamaguru.Clear()
        'dtptanggal.Clear()
        txtjabatan.Clear()
        txtgajipokok.Clear()
        txttunjangan.Clear()
        txtjabatan.Clear()
        txttransport.Clear()
        txtjumlahjamterisi.Clear()
        txthonor.Clear()
        txthonorbersih.Clear()
        cbjenis.Text = ""
        cbmetode.Text = ""
        txtnamabank.Clear()
        txtnorekening.Focus()
    End Sub

    Private Sub kondisienable()
        txtkodetransaksi.Enabled = False
        cbnip.Enabled = False
        txtnamaguru.Enabled = False
        'dtptanggal.Enabled = False
        txtjabatan.Enabled = False
        txtgajipokok.Enabled = False
        txttunjangan.Enabled = False
        txttransport.Enabled = False
        txtjumlahjamterisi.Enabled = False
        txthonor.Enabled = False
        txthonorbersih.Enabled = False
        cbjenis.Enabled = False
        cbmetode.Enabled = False
        txtnamabank.Enabled = False
        txtnorekening.Enabled = False
        btntambahdata.Enabled = True
        btnsave.Enabled = False
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnclear.Enabled = False
    End Sub

    Private Sub kondisidisable()
        txtkodetransaksi.Enabled = False
        cbnip.Enabled = True
        txtnamaguru.Enabled = False
        'dtptanggal.Enabled = False
        txtjabatan.Enabled = False
        txtgajipokok.Enabled = False
        txttunjangan.Enabled = False
        txttransport.Enabled = False
        txtjumlahjamterisi.Enabled = False
        txthonor.Enabled = False
        txthonorbersih.Enabled = False
        cbjenis.Enabled = True
        cbmetode.Enabled = True
        txtnamabank.Enabled = False
        txtnorekening.Enabled = False
        btntambahdata.Enabled = False
        btnsave.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnclear.Enabled = False
    End Sub

    Private Sub kondisidisableupdate()
        txtkodetransaksi.Enabled = False
        cbnip.Enabled = False
        txtnamaguru.Enabled = False
        'dtptanggal.Enabled = False
        txtjabatan.Enabled = False
        txtgajipokok.Enabled = False
        txttunjangan.Enabled = False
        txttransport.Enabled = False
        txtjumlahjamterisi.Enabled = False
        txthonor.Enabled = False
        txthonorbersih.Enabled = False
        cbjenis.Enabled = True
        cbmetode.Enabled = True
        txtnamabank.Enabled = False
        txtnorekening.Enabled = False
        btntambahdata.Enabled = True
        btnsave.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
        btnclear.Enabled = True
    End Sub
    Sub comboboxbnip()
        Call Koneksi()
        cbnip.Items.Clear()
        CMD = New OdbcCommand("select * from guru", Conn)
        Rd = CMD.ExecuteReader
        Do While Rd.Read
            cbnip.Items.Add(Rd.Item(0))
        Loop
    End Sub


    Private Sub transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call tampil_transaksi()
        Call bersih()
        Call bersihtambahdata()
        Call kondisidisable()
        Call kondisienable()
        Call kondisidisableupdate()
        Call comboboxbnip()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        kondisienable()
        If txtkodetransaksi.Text = "" Or cbnip.Text = "" Or txtnamaguru.Text = "" Or dtptanggallahir.Text = "" Or txtjabatan.Text = "" Or txtgajipokok.Text = "" Or txttunjangan.Text = "" Or txttransport.Text = "" Or txtjumlahjamterisi.Text = "" Or txthonor.Text = "" Or txthonorbersih.Text = "" Or cbjenis.Text = "" Or cbmetode.Text = "" Or txtnamabank.Text = "" Or txtnorekening.Text = "" Or txtbulan.Text = "" Then
            MsgBox("Semua Data Wajib di Isi.!!")
        Else
            'pesan username tidak boleh sama
            Call Koneksi()
            CMD = New OdbcCommand("select * from transaksi where nip ='" & cbnip.Text & "'", Conn)
            Rd = CMD.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                MsgBox("NIP Guru tidak boleh sama")
                Call bersih()
            Else
                Dim tgllahir As String
                tgllahir = Format(dtptanggallahir.Value, "yyyy-MM-dd")
                'pengecekan data user apakah ada atau tidak
                CMD = New OdbcCommand("select * from transaksi where kodetransaksi='" & txtkodetransaksi.Text & "'", Conn)
                Rd = CMD.ExecuteReader
                Rd.Read()
                If Rd.HasRows = False Then
                    'penyimpanan data ke database
                    Call Koneksi()
                    CMD = New OdbcCommand("insert into transaksi values ('" & txtkodetransaksi.Text &
                                      "','" & cbnip.Text &
                                      "','" & txtnamaguru.Text &
                                      "','" & tgllahir &
                                      "','" & txtjabatan.Text &
                                      "','" & txtgajipokok.Text &
                                      "','" & txttunjangan.Text &
                                      "','" & txttransport.Text &
                                      "','" & txtjumlahjamterisi.Text &
                                      "','" & txthonor.Text &
                                      "','" & txthonorbersih.Text &
                                      "','" & cbjenis.Text &
                                      "','" & cbmetode.Text &
                                      "','" & txtnamabank.Text &
                                      "','" & txtnorekening.Text &
                                      "','" & txtbulan.Text &
                                      "')", Conn)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Tambahkan.!!")
                    Call bersih()
                    Call tampil_transaksi()
                Else
                End If
            End If
        End If

    End Sub

    Private Sub txtnip_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txttransport_TextChanged(sender As Object, e As EventArgs) Handles txttransport.TextChanged
        txthonorbersih.Text = Val(txthonor.Text) + Val(txtgajipokok.Text) + Val(txttunjangan.Text) + Val(txttransport.Text)
    End Sub

    Private Sub txttunjangan_TextChanged(sender As Object, e As EventArgs) Handles txttunjangan.TextChanged
        txthonorbersih.Text = Val(txthonor.Text) + Val(txtgajipokok.Text) + Val(txttunjangan.Text) + Val(txttransport.Text)
    End Sub

    Private Sub txtgajipokok_TextChanged(sender As Object, e As EventArgs) Handles txtgajipokok.TextChanged
        txthonorbersih.Text = Val(txthonor.Text) + Val(txtgajipokok.Text) + Val(txttunjangan.Text) + Val(txttransport.Text)
    End Sub

    Private Sub txthonor_TextChanged(sender As Object, e As EventArgs) Handles txthonor.TextChanged
        txthonorbersih.Text = Val(txthonor.Text) + Val(txtgajipokok.Text) + Val(txttunjangan.Text) + Val(txttransport.Text)
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim tgllahir As String
        tgllahir = Format(dtptanggallahir.Value, "yyyy/MM/dd")
        'melakukan edit data user berdasarkan kode user yang di panggil
        Call Koneksi()
        CMD = New OdbcCommand("update transaksi set nip = '" & cbnip.Text &
                                   "', namaguru='" & txtnamaguru.Text &
                                   "', tanggal='" & tgllahir &
                                   "', jabatan='" & txtjabatan.Text &
                                   "', gajipokok='" & txtgajipokok.Text &
                                   "', tunjanganjabatan='" & txttunjangan.Text &
                                   "', transport='" & txttransport.Text &
                                   "', jumlahjamterisi='" & txtjumlahjamterisi.Text &
                                   "', honor='" & txthonor.Text &
                                   "', honorbersih='" & txthonorbersih.Text &
                                   "', jenis='" & cbjenis.Text &
                                   "', metode='" & cbmetode.Text &
                                   "', namabank='" & txtnamabank.Text &
                                   "', norekening='" & txtnorekening.Text &
                                   "', bulan='" & txtbulan.Text &
                                   "' where kodetransaksi = '" & txtkodetransaksi.Text & "'", Conn)
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil Di Update..!")
        Call bersih()
        Call tampil_transaksi()
    End Sub

    Private Sub dgvtransaksi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtransaksi.CellContentClick
        kondisidisableupdate()
        Dim i As Integer
        i = dgvtransaksi.CurrentRow.Index

        On Error Resume Next
        txtkodetransaksi.Text = dgvtransaksi.Item(0, i).Value
        cbnip.Text = dgvtransaksi.Item(1, i).Value
        txtnamaguru.Text = dgvtransaksi.Item(2, i).Value
        dtptanggallahir.Text = dgvtransaksi.Item(3, i).Value
        txtjabatan.Text = dgvtransaksi.Item(4, i).Value
        txtgajipokok.Text = dgvtransaksi.Item(5, i).Value
        txttunjangan.Text = dgvtransaksi.Item(6, i).Value
        txttransport.Text = dgvtransaksi.Item(7, i).Value
        txtjumlahjamterisi.Text = dgvtransaksi.Item(8, i).Value
        txthonor.Text = dgvtransaksi.Item(9, i).Value
        txthonorbersih.Text = dgvtransaksi.Item(10, i).Value
        cbjenis.Text = dgvtransaksi.Item(11, i).Value
        cbmetode.Text = dgvtransaksi.Item(12, i).Value
        txtnamabank.Text = dgvtransaksi.Item(13, i).Value
        txtnorekening.Text = dgvtransaksi.Item(14, i).Value
        txtbulan.Text = dgvtransaksi.Item(15, i).Value
    End Sub

    Private Sub btntambahdata_Click(sender As Object, e As EventArgs) Handles btntambahdata.Click
        kondisidisable()
        Call Koneksi()
        CMD = New OdbcCommand("select kodetransaksi from transaksi order by kodetransaksi desc", Conn)
        Dim urutankode As String
        Dim hitung As Long
        Rd = CMD.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            urutankode = "KTRN" + "0001"
            cbnip.Focus()
        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 4) + 1
            urutankode = "KTRN" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        txtkodetransaksi.Text = urutankode
        cbnip.Focus()
        Call bersihtambahdata()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MsgBox("Apakah data akan di hapus..?") Then
            CMD = New OdbcCommand("delete from transaksi where kodetransaksi = '" & txtkodetransaksi.Text & "' ", Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di delete !!!")
            Call bersih()
            Call tampil_transaksi()
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Call bersih()
    End Sub

    Private Sub cbnip_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbnip.SelectedIndexChanged
        'Memanggil data berdasarkan kode barang
        CMD = New OdbcCommand("select * from guru where nip='" & cbnip.Text & "'", Conn)
        Rd = CMD.ExecuteReader
        Rd.Read()
        If Rd.HasRows = True Then
            txtnamaguru.Text = Rd(1)
            txtjabatan.Text = Rd(2)
        Else
            txtnamaguru.Clear()
            txtjabatan.Text = ""
        End If


        'Memanggil data berdasarkan kode barang
        CMD = New OdbcCommand("select * from tunjangan where nip='" & cbnip.Text & "'", Conn)
        Rd = CMD.ExecuteReader
        Rd.Read()
        If Rd.HasRows = True Then
            txttunjangan.Text = Rd(4)
            txttransport.Text = Rd(5)
            txtgajipokok.Text = Rd(6)


        Else
            txttunjangan.Clear()
            txttransport.Clear()
            txtgajipokok.Clear()
        End If

        'Memanggil data berdasarkan kode barang
        CMD = New OdbcCommand("select * from bank where nip='" & cbnip.Text & "'", Conn)
        Rd = CMD.ExecuteReader
        Rd.Read()
        If Rd.HasRows = True Then
            txtnamabank.Text = Rd(3)
            txtnorekening.Text = Rd(4)
        Else
            txtnamabank.Clear()
            txtnorekening.Clear()
        End If

        CMD = New OdbcCommand("select * from absensi where nip='" & cbnip.Text & "'", Conn)
        Rd = CMD.ExecuteReader
        Rd.Read()
        If Rd.HasRows = True Then
            txtbulan.Text = Rd(3)
            txtjumlahjamterisi.Text = Rd(6)
            txthonor.Text = Rd(7)

        Else
            txtjumlahjamterisi.Clear()
            txthonor.Clear()
            txtbulan.Clear()
        End If
    End Sub
End Class