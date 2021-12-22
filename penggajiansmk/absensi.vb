Imports System.Data.Odbc
Public Class absensi
    Sub tampil_absensi()
        CMD = New OdbcCommand("select * from absensi", Conn)
        Rd = CMD.ExecuteReader
        dgvabsensi.Rows.Clear()
        Do While Rd.Read = True
            dgvabsensi.Rows.Add(Rd(0), Rd(1), Rd(2), Rd(3), Rd(4), Rd(5), Rd(6), Rd(7))
        Loop
    End Sub


    Sub bersih()
        cbnip.Text = ""
        txtnamaguru.Clear()
        txtjabatan.Clear()
        txtbulan.Clear()
        txtjumlahjamperbulan.Clear()
        txtjumlahjamtidakterisi.Clear()
        txtjumlahjamterisi.Clear()
        txthonor.Clear()
        cbnip.Focus()
    End Sub

    Sub bersihtambahdata()
        cbnip.Text = ""
        txtnamaguru.Clear()
        txtjabatan.Clear()
        txtbulan.Clear()
        txtjumlahjamperbulan.Clear()
        txtjumlahjamtidakterisi.Clear()
        txtjumlahjamterisi.Clear()
        txthonor.Clear()
        cbnip.Focus()
    End Sub

    Private Sub kondisienable()
        cbnip.Enabled = False
        txtnamaguru.Enabled = False
        txtjabatan.Enabled = False
        txtbulan.Enabled = False
        txtjumlahjamperbulan.Enabled = False
        txtjumlahjamtidakterisi.Enabled = False
        txtjumlahjamterisi.Enabled = False
        txthonor.Enabled = False
        btntambahdata.Enabled = True
        btnsave.Enabled = False
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnclear.Enabled = False
    End Sub

    Private Sub kondisidisable()
        cbnip.Enabled = True
        txtnamaguru.Enabled = False
        txtjabatan.Enabled = False
        txtbulan.Enabled = True
        txtjumlahjamperbulan.Enabled = True
        txtjumlahjamtidakterisi.Enabled = True
        txtjumlahjamterisi.Enabled = False
        txthonor.Enabled = False
        btntambahdata.Enabled = False
        btnsave.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnclear.Enabled = False
    End Sub

    Private Sub kondisidisableupdate()
        cbnip.Enabled = False
        txtnamaguru.Enabled = False
        txtjabatan.Enabled = False
        txtbulan.Enabled = True
        txtjumlahjamperbulan.Enabled = True
        txtjumlahjamtidakterisi.Enabled = True
        txtjumlahjamterisi.Enabled = False
        txthonor.Enabled = False
        btntambahdata.Enabled = True
        btnsave.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
        btnclear.Enabled = True
    End Sub
    Sub comboboxnip()
        Call Koneksi()
        cbnip.Items.Clear()
        CMD = New OdbcCommand("select * from guru", Conn)
        Rd = CMD.ExecuteReader
        Do While Rd.Read
            cbnip.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub absensi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call tampil_absensi()
        Call bersih()
        Call kondisidisable()
        Call kondisidisableupdate()
        Call kondisienable()
        Call bersihtambahdata()
        Call comboboxnip()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If cbnip.Text = "" Or txtnamaguru.Text = "" Or txtjabatan.Text = "" Or txtbulan.Text = "" Or txtjumlahjamperbulan.Text = "" Or txtjumlahjamtidakterisi.Text = "" Or txtjumlahjamterisi.Text = "" Or txthonor.Text = "" Then
            MsgBox("Semua Data Wajib di Isi.!!")
        Else
            'pesan username tidak boleh sama
            Call Koneksi()
            CMD = New OdbcCommand("select * from absensi where nip ='" & cbnip.Text & "'", Conn)
            Rd = CMD.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                MsgBox("NIP Guru tidak boleh sama")
                Call bersih()
            Else

                'pengecekan data user apakah ada atau tidak
                CMD = New OdbcCommand("select * from absensi where nip='" & cbnip.Text & "'", Conn)
                Rd = CMD.ExecuteReader
            Rd.Read()
                If Rd.HasRows = False Then
                    'penyimpanan data ke database
                    Call Koneksi()
                    CMD = New OdbcCommand("insert into absensi values ('" & cbnip.Text &
                                      "','" & txtnamaguru.Text &
                                      "','" & txtjabatan.Text &
                                      "','" & txtbulan.Text &
                                      "','" & txtjumlahjamperbulan.Text &
                                      "','" & txtjumlahjamtidakterisi.Text &
                                      "','" & txtjumlahjamterisi.Text &
                                      "','" & txthonor.Text &
                                      "')", Conn)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Tambahkan.!!")
                    Call bersih()
                    Call tampil_absensi()
                Else
                End If
            End If
        End If
    End Sub

    Private Sub txtnip_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtjumlahjamtidakterisi_TextChanged(sender As Object, e As EventArgs) Handles txtjumlahjamtidakterisi.TextChanged
        txtjumlahjamterisi.Text = Val(txtjumlahjamperbulan.Text) - Val(txtjumlahjamtidakterisi.Text)
        txthonor.Text = Val(txtjumlahjamterisi.Text) * 20000
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Call bersih()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MsgBox("Apakah data akan di hapus..?") Then
            CMD = New OdbcCommand("delete from absensi where nip = '" & cbnip.Text & "' ", Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di delete !!!")
            Call bersih()
            Call tampil_absensi()
        End If
    End Sub

    Private Sub txtjumlahjamperbulan_TextChanged(sender As Object, e As EventArgs) Handles txtjumlahjamperbulan.TextChanged
        txtjumlahjamterisi.Text = Val(txtjumlahjamperbulan.Text) - Val(txtjumlahjamtidakterisi.Text)
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        'melakukan edit data user berdasarkan kode user yang di panggil
        Call Koneksi()
        CMD = New OdbcCommand("update absensi set namaguru = '" & txtnamaguru.Text &
                               "', jabatan='" & txtjabatan.Text &
                               "', bulan='" & txtbulan.Text &
                               "', jumlahjamperbulan='" & txtjumlahjamperbulan.Text &
                               "', jumlahjamtidakterisi='" & txtjumlahjamtidakterisi.Text &
                               "', jumlahjamterisi='" & txtjumlahjamterisi.Text &
                               "', honor='" & txthonor.Text &
                               "' where nip = '" & cbnip.Text & "'", Conn)
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil Di Update..!")
        Call bersih()
        Call tampil_absensi()
    End Sub

    Private Sub dgvabsensi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvabsensi.CellContentClick
        kondisidisableupdate()
        Dim i As Integer
        i = dgvabsensi.CurrentRow.Index

        On Error Resume Next
        cbnip.Text = dgvabsensi.Item(0, i).Value
        txtnamaguru.Text = dgvabsensi.Item(1, i).Value
        txtjabatan.Text = dgvabsensi.Item(2, i).Value
        txtbulan.Text = dgvabsensi.Item(3, i).Value
        txtjumlahjamperbulan.Text = dgvabsensi.Item(4, i).Value
        txtjumlahjamtidakterisi.Text = dgvabsensi.Item(5, i).Value
        txtjumlahjamterisi.Text = dgvabsensi.Item(6, i).Value
        txthonor.Text = dgvabsensi.Item(7, i).Value
    End Sub

    Private Sub btntambahdata_Click(sender As Object, e As EventArgs) Handles btntambahdata.Click
        kondisidisable()
        cbnip.Focus()
        Call bersihtambahdata()
    End Sub

    Private Sub cbnip_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbnip.SelectedIndexChanged
        'Memanggil data berdasarkan kode
        CMD = New OdbcCommand("select * from guru where nip='" & cbnip.Text & "'", Conn)
        Rd = CMD.ExecuteReader
        Rd.Read()
        If Rd.HasRows = True Then
            txtnamaguru.Text = Rd(1)
            txtjabatan.Text = Rd(2)
        Else
            txtnamaguru.Clear()
            txtjabatan.Clear()
        End If
    End Sub
End Class