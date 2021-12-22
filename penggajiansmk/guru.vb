Imports System.Data.Odbc
Public Class guru
    Sub tampil_guru()
        CMD = New OdbcCommand("select * from guru", Conn)
        Rd = CMD.ExecuteReader
        dgvguru.Rows.Clear()
        Do While Rd.Read = True
            dgvguru.Rows.Add(Rd(0), Rd(1), Rd(2), Rd(3), Rd(4), Rd(5), Rd(6), Rd(7), Rd(8), Rd(9), Rd(10), Rd(11), Rd(12))
        Loop
    End Sub

    Sub bersih()
        txtagama.Clear()
        txtalamat.Clear()
        txtemail.Clear()
        txttahunmasuk.Clear()
        txttempatlahir.Clear()
        cbjabatan.Text = ""
        cbstatus.Text = ""
        cbpendidikanterakhir.Text = ""
        cbjeniskelamin.Text = ""
        txtnip.Clear()
        txtnamaguru.Clear()
        txtnotelp.Clear()
        'dtptanggallahir.ResetText()
        txtnip.Focus()
    End Sub

    Sub bersihtambahdata()
        txtagama.Clear()
        txtalamat.Clear()
        txtemail.Clear()
        txttahunmasuk.Clear()
        txttempatlahir.Clear()
        cbjabatan.Text = ""
        cbstatus.Text = ""
        cbpendidikanterakhir.Text = ""
        cbjeniskelamin.Text = ""
        txtnip.Clear()
        txtnamaguru.Clear()
        txtnotelp.Clear()
        'dtptanggallahir.ResetText()
        txtnip.Focus()
    End Sub

    Private Sub kondisienable()
        txtagama.Enabled = False
        txtalamat.Enabled = False
        txtemail.Enabled = False
        txttahunmasuk.Enabled = False
        txttempatlahir.Enabled = False
        cbjabatan.Enabled = False
        cbstatus.Enabled = False
        cbpendidikanterakhir.Enabled = False
        cbjeniskelamin.Enabled = False
        txtnip.Enabled = False
        txtnamaguru.Enabled = False
        txtnotelp.Enabled = False
        'dtptanggallahir.Enabled = False
        btntambahdata.Enabled = True
        btnsave.Enabled = False
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnclear.Enabled = False
    End Sub

    Private Sub kondisidisable()
        txtagama.Enabled = True
        txtalamat.Enabled = True
        txtemail.Enabled = True
        txttahunmasuk.Enabled = True
        txttempatlahir.Enabled = True
        cbjabatan.Enabled = True
        cbstatus.Enabled = True
        cbpendidikanterakhir.Enabled = True
        cbjeniskelamin.Enabled = True
        txtnip.Enabled = True
        txtnamaguru.Enabled = True
        txtnotelp.Enabled = True
        'dtptanggallahir.Enabled = True
        btntambahdata.Enabled = False
        btnsave.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnclear.Enabled = True
    End Sub

    Private Sub kondisidisableupdate()
        txtagama.Enabled = True
        txtalamat.Enabled = True
        txtemail.Enabled = True
        txttahunmasuk.Enabled = True
        txttempatlahir.Enabled = True
        cbjabatan.Enabled = True
        cbstatus.Enabled = True
        cbpendidikanterakhir.Enabled = True
        cbjeniskelamin.Enabled = True
        txtnip.Enabled = True
        txtnamaguru.Enabled = True
        txtnotelp.Enabled = True
        'dtptanggallahir.Enabled = True
        btntambahdata.Enabled = True
        btnsave.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
        btnclear.Enabled = True
    End Sub


    Private Sub guru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call tampil_guru()
        Call bersih()
        Call bersihtambahdata()
        Call kondisidisable()
        Call kondisidisableupdate()
        Call kondisienable()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtnip.Text = "" Or txtnamaguru.Text = "" Or cbjabatan.Text = "" Or txttempatlahir.Text = "" Or dtptanggallahir.Text = "" Or cbjeniskelamin.Text = "" Or txtagama.Text = "" Or cbpendidikanterakhir.Text = "" Or txtalamat.Text = "" Or txtnotelp.Text = "" Or txtemail.Text = "" Or cbstatus.Text = "" Or txttahunmasuk.Text = "" Then
            MsgBox("Semua Data Wajib di Isi.!!")
        Else
            'pesan username tidak boleh sama
            Call Koneksi()
            CMD = New OdbcCommand("select * from guru where nip ='" & txtnip.Text & "'", Conn)
            Rd = CMD.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                MsgBox("username tidak boleh sama")
                Call bersih()
            Else
                Dim tgllahir As String
                tgllahir = Format(dtptanggallahir.Value, "yyyy-MM-dd")
                'pengecekan data user apakah ada atau tidak
                CMD = New OdbcCommand("select * from guru where nip='" & txtnip.Text & "'", Conn)
                Rd = CMD.ExecuteReader
                Rd.Read()
                If Rd.HasRows = False Then
                    'penyimpanan data ke database
                    Call Koneksi()
                    CMD = New OdbcCommand("insert into guru values ('" & txtnip.Text &
                                          "','" & txtnamaguru.Text &
                                          "','" & cbjabatan.Text &
                                          "','" & txttempatlahir.Text &
                                          "','" & tgllahir &
                                          "','" & cbjeniskelamin.Text &
                                          "','" & txtagama.Text &
                                          "','" & cbpendidikanterakhir.Text &
                                          "','" & txtalamat.Text &
                                          "','" & txtnotelp.Text &
                                          "','" & txtemail.Text &
                                          "','" & cbstatus.Text &
                                          "','" & txttahunmasuk.Text &
                                          "')", Conn)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Tambahkan.!!")
                    Call bersih()
                    Call tampil_guru()
                Else
                End If
            End If
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Call bersih()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MsgBox("Apakah data akan di hapus..?") Then
            CMD = New OdbcCommand("delete from guru where nip = '" & txtnip.Text & "' ", Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di delete !!!")
            Call bersih()
            Call tampil_guru()
        End If

    End Sub

    Private Sub btntambahdata_Click(sender As Object, e As EventArgs) Handles btntambahdata.Click
        kondisidisable()
        txtnip.Focus()
        Call bersihtambahdata()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim tgllahir As String
        tgllahir = Format(dtptanggallahir.Value, "yyyy/MM/dd")
        'melakukan edit data user berdasarkan kode user yang di panggil
        Call Koneksi()
        CMD = New OdbcCommand("update guru set namaguru = '" & txtnamaguru.Text &
                               "', jabatan='" & cbjabatan.Text &
                               "', tempatlahir='" & txttempatlahir.Text &
                               "', tanggallahir='" & tgllahir &
                               "', jeniskelamin='" & cbjeniskelamin.Text &
                               "', agama='" & txtagama.Text &
                               "', pendidikan='" & cbpendidikanterakhir.Text &
                               "', alamat='" & txtalamat.Text &
                               "', notelp='" & txtnotelp.Text &
                               "', email='" & txtemail.Text &
                               "', status='" & cbstatus.Text &
                               "', tahunmasuk='" & txttahunmasuk.Text &
                               "' where nip = '" & txtnip.Text & "'", Conn)
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil Di Update..!")
        Call bersih()
        Call tampil_guru()
    End Sub

    Private Sub dgvguru_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvguru.CellContentClick

    End Sub

    Private Sub dgvguru_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvguru.CellClick
        kondisidisableupdate()
        Dim i As Integer
        i = dgvguru.CurrentRow.Index

        On Error Resume Next
        txtnip.Text = dgvguru.Item(0, i).Value
        txtnamaguru.Text = dgvguru.Item(1, i).Value
        cbjabatan.Text = dgvguru.Item(2, i).Value
        txttempatlahir.Text = dgvguru.Item(3, i).Value
        dtptanggallahir = dgvguru.Item(4, i).Value
        cbjeniskelamin.Text = dgvguru.Item(5, i).Value
        txtagama.Text = dgvguru.Item(6, i).Value
        cbpendidikanterakhir.Text = dgvguru.Item(7, i).Value
        txtalamat.Text = dgvguru.Item(8, i).Value
        txtnotelp.Text = dgvguru.Item(9, i).Value
        txtemail.Text = dgvguru.Item(10, i).Value
        cbstatus.Text = dgvguru.Item(11, i).Value
        txttahunmasuk.Text = dgvguru.Item(12, i).Value
    End Sub
End Class