Imports System.Data.Odbc
Public Class sekolah
    Sub tampil_sekolah()
        CMD = New OdbcCommand("select * from sekolah", Conn)
        Rd = CMD.ExecuteReader
        dgvsekolah.Rows.Clear()
        Do While Rd.Read = True
            dgvsekolah.Rows.Add(Rd(0), Rd(1), Rd(2), Rd(3), Rd(4), Rd(5), Rd(6), Rd(7), Rd(8))
        Loop
    End Sub

    Sub bersih()
        txtnpsn.Clear()
        txtkepalasekolah.Clear()
        txtbendahara.Clear()
        txtinstansi.Clear()
        txtalamatsekolah.Clear()
        txtkecamatan.Clear()
        txtprovinsi.Clear()
        txtwebsite.Clear()
        txtemail.Clear()
        txtnpsn.Focus()
    End Sub

    Sub bersihtambahdata()
        txtkepalasekolah.Clear()
        txtbendahara.Clear()
        txtinstansi.Clear()
        txtalamatsekolah.Clear()
        txtkecamatan.Clear()
        txtprovinsi.Clear()
        txtwebsite.Clear()
        txtemail.Clear()
    End Sub

    Private Sub kondisienable()
        txtnpsn.Enabled = False
        txtkepalasekolah.Enabled = False
        txtbendahara.Enabled = False
        txtinstansi.Enabled = False
        txtalamatsekolah.Enabled = False
        txtkecamatan.Enabled = False
        txtprovinsi.Enabled = False
        txtwebsite.Enabled = False
        txtemail.Enabled = False
        btntambahdata.Enabled = True
        btnsave.Enabled = False
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnclear.Enabled = False
    End Sub

    Private Sub kondisidisable()
        txtnpsn.Enabled = True
        txtkepalasekolah.Enabled = True
        txtbendahara.Enabled = True
        txtinstansi.Enabled = True
        txtalamatsekolah.Enabled = True
        txtkecamatan.Enabled = True
        txtprovinsi.Enabled = True
        txtwebsite.Enabled = True
        txtemail.Enabled = True
        btntambahdata.Enabled = False
        btnsave.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnclear.Enabled = False
    End Sub

    Private Sub kondisidisableupdate()
        txtnpsn.Enabled = True
        txtkepalasekolah.Enabled = True
        txtbendahara.Enabled = True
        txtinstansi.Enabled = True
        txtalamatsekolah.Enabled = True
        txtkecamatan.Enabled = True
        txtprovinsi.Enabled = True
        txtwebsite.Enabled = True
        txtemail.Enabled = True
        btntambahdata.Enabled = True
        btnsave.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
        btnclear.Enabled = True
    End Sub
    Private Sub sekolah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call tampil_sekolah()
        Call bersih()
        Call kondisidisable()
        Call kondisienable()
        Call bersihtambahdata()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btntambahdata_Click(sender As Object, e As EventArgs) Handles btntambahdata.Click
        kondisidisable()
        Call Koneksi()
        CMD = New OdbcCommand("select npsn from sekolah order by npsn desc", Conn)
        'Dim urutankode As String
        'Dim hitung As Long
        'Rd = CMD.ExecuteReader
        'Rd.Read()
        'If Not Rd.HasRows Then
        '    urutankode = "USR" + "0001"
        '    txtnamauser.Focus()
        'Else
        '    hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 4) + 1
        '    urutankode = "USR" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        'End If
        'txtkodeuser.Text = urutankode
        'txtnamauser.Focus()
        Call bersihtambahdata()
        txtnpsn.Focus()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        kondisienable()
        If txtnpsn.Text = "" Or txtkepalasekolah.Text = "" Or txtbendahara.Text = "" Or txtinstansi.Text = "" Or txtalamatsekolah.Text = "" Or txtkecamatan.Text = "" Or txtprovinsi.Text = "" Or txtwebsite.Text = "" Or txtemail.Text = "" Then
            MsgBox("Semua Data Wajib di Isi.!!")
        Else
            'pesan username tidak boleh sama
            Call Koneksi()
            CMD = New OdbcCommand("select * from sekolah where npsn ='" & txtnpsn.Text & "'", Conn)
            Rd = CMD.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                MsgBox("username tidak boleh sama")
                Call bersih()
            Else

                'pengecekan data user apakah ada atau tidak
                CMD = New OdbcCommand("select * from sekolah where npsn='" & txtnpsn.Text & "'", Conn)
                Rd = CMD.ExecuteReader
                Rd.Read()
                If Rd.HasRows = False Then
                    'penyimpanan data ke database
                    Call Koneksi()
                    CMD = New OdbcCommand("insert into sekolah values ('" & txtnpsn.Text &
                                              "','" & txtkepalasekolah.Text &
                                              "','" & txtbendahara.Text &
                                              "','" & txtinstansi.Text &
                                              "','" & txtalamatsekolah.Text &
                                              "','" & txtkecamatan.Text &
                                              "','" & txtprovinsi.Text &
                                              "','" & txtwebsite.Text &
                                              "','" & txtemail.Text &
                                              "')", Conn)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Tambahkan.!!")
                    Call bersih()
                    Call tampil_sekolah()
                Else
                End If
            End If
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Call Koneksi()
        CMD = New OdbcCommand("update sekolah set namakepalasekolah = '" & txtkepalasekolah.Text &
                                       "', bendahara='" & txtbendahara.Text &
                                       "', namasekolah='" & txtinstansi.Text &
                                       "', alamatsekolah='" & txtalamatsekolah.Text &
                                       "', kecamatan='" & txtkecamatan.Text &
                                       "', provinsi='" & txtprovinsi.Text &
                                       "', website='" & txtwebsite.Text &
                                       "', emailsekolah='" & txtemail.Text &
                                       "' where npsn = '" & txtnpsn.Text & "'", Conn)
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil Di Update..!")
        Call bersih()
        Call tampil_sekolah()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MsgBox("Apakah data akan di hapus..?") Then
            CMD = New OdbcCommand("delete from sekolah where npsn = '" & txtnpsn.Text & "' ", Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di delete !!!")
            Call bersih()
            Call tampil_sekolah()
        End If
    End Sub

    Private Sub dgvsekolah_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsekolah.CellContentClick

    End Sub

    Private Sub dgvsekolah_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsekolah.CellClick
        kondisidisableupdate()
        Dim i As Integer
        i = dgvsekolah.CurrentRow.Index

        On Error Resume Next
        txtnpsn.Text = dgvsekolah.Item(0, i).Value
        txtkepalasekolah.Text = dgvsekolah.Item(1, i).Value
        txtbendahara.Text = dgvsekolah.Item(2, i).Value
        txtinstansi.Text = dgvsekolah.Item(3, i).Value
        txtalamatsekolah.Text = dgvsekolah.Item(4, i).Value
        txtkecamatan.Text = dgvsekolah.Item(5, i).Value
        txtprovinsi.Text = dgvsekolah.Item(6, i).Value
        txtwebsite.Text = dgvsekolah.Item(7, i).Value
        txtemail.Text = dgvsekolah.Item(8, i).Value
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Call bersih()
    End Sub
End Class