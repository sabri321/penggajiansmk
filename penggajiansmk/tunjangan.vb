Imports System.Data.Odbc
Public Class tunjangan
    Sub tampil_tunjangan()
        CMD = New OdbcCommand("select * from tunjangan", Conn)
        Rd = CMD.ExecuteReader
        dgvtunjangan.Rows.Clear()
        Do While Rd.Read = True
            dgvtunjangan.Rows.Add(Rd(0), Rd(1), Rd(2), Rd(3), Rd(4), Rd(5), Rd(6))
        Loop
    End Sub

    Sub bersih()
        txtkodetunjangan.Clear()
        cbnip.Text = ""
        txtnamaguru.Clear()
        txtjabatan.Clear()
        txttunjanganjabatan.Clear()
        txttransport.Clear()
        txtgajipokok.Clear()
        cbnip.Focus()
    End Sub

    Sub bersihtambahdata()
        cbnip.Text = ""
        txtnamaguru.Clear()
        txtjabatan.Clear()
        txttunjanganjabatan.Clear()
        txttransport.Clear()
        txtgajipokok.Clear()
        cbnip.Focus()
    End Sub

    Private Sub kondisienable()
        txtkodetunjangan.Enabled = False
        cbnip.Enabled = False
        txtnamaguru.Enabled = False
        txtjabatan.Enabled = False
        txttunjanganjabatan.Enabled = False
        txttransport.Enabled = False
        txtgajipokok.Enabled = False
        btntambahdata.Enabled = True
        btnsave.Enabled = False
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnclear.Enabled = False
    End Sub

    Private Sub kondisidisable()
        txtkodetunjangan.Enabled = False
        cbnip.Enabled = True
        txtnamaguru.Enabled = False
        txtjabatan.Enabled = False
        txttunjanganjabatan.Enabled = True
        txttransport.Enabled = True
        txtgajipokok.Enabled = True
        btntambahdata.Enabled = False
        btnsave.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnclear.Enabled = False
    End Sub

    Private Sub kondisidisableupdate()
        txtkodetunjangan.Enabled = False
        cbnip.Enabled = False
        txtnamaguru.Enabled = False
        txtjabatan.Enabled = False
        txttunjanganjabatan.Enabled = True
        txttransport.Enabled = True
        txtgajipokok.Enabled = True
        btntambahdata.Enabled = True
        btnsave.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
        btnclear.Enabled = True
    End Sub
    Sub tampilcb()
        Call Koneksi()
        cbnip.Items.Clear()
        CMD = New OdbcCommand("select * from guru", Conn)
        Rd = CMD.ExecuteReader
        Do While Rd.Read
            cbnip.Items.Add(Rd.Item(0))
        Loop
    End Sub
    Private Sub tunjangan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call tampil_tunjangan()
        Call bersih()
        Call kondisidisable()
        Call kondisidisableupdate()
        Call kondisienable()
        Call bersihtambahdata()
        Call tampilcb()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub


    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        kondisienable()
        If txtkodetunjangan.Text = "" Or cbnip.Text = "" Or txtnamaguru.Text = "" Or txtjabatan.Text = "" Or txttunjanganjabatan.Text = "" Or txttransport.Text = "" Or txtgajipokok.Text = "" Then
            MsgBox("Semua Data Wajib di Isi.!!")
        Else

            'pesan username tidak boleh sama
            Call Koneksi()
            CMD = New OdbcCommand("select * from tunjangan where nip ='" & cbnip.Text & "'", Conn)
            Rd = CMD.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                MsgBox("NIP Guru tidak boleh sama")
                Call bersih()
            Else
                'pengecekan data user apakah ada atau tidak
                CMD = New OdbcCommand("select * from tunjangan where kodetunjangan='" & txtkodetunjangan.Text & "'", Conn)
                Rd = CMD.ExecuteReader
                Rd.Read()
                If Rd.HasRows = False Then
                    'penyimpanan data ke database
                    Call Koneksi()
                    CMD = New OdbcCommand("insert into tunjangan values ('" & txtkodetunjangan.Text &
                                              "','" & cbnip.Text &
                                              "','" & txtnamaguru.Text &
                                              "','" & txtjabatan.Text &
                                              "','" & txttunjanganjabatan.Text &
                                              "','" & txttransport.Text &
                                               "','" & txtgajipokok.Text &
                                              "')", Conn)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Tambahkan.!!")
                    Call bersih()
                    Call tampil_tunjangan()
                Else
                End If
            End If
        End If
    End Sub

    Private Sub txtkodetunjangan_TextChanged(sender As Object, e As EventArgs) Handles txtkodetunjangan.TextChanged
        'Memanggil Data berdasarkan kode
        CMD = New OdbcCommand("select * from tunjangan where kodetunjangan='" & txtkodetunjangan.Text & "'", Conn)
        Rd = CMD.ExecuteReader
        Rd.Read()
        If Rd.HasRows = True Then
            cbnip.Text = Rd(1)
        Else
            cbnip.Text = ""
        End If
    End Sub



    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Call bersih()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MsgBox("Apakah data akan di hapus..?") Then
            CMD = New OdbcCommand("delete from tunjangan where kodetunjangan = '" & txtkodetunjangan.Text & "' ", Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di delete !!!")
            Call bersih()
            Call tampil_tunjangan()
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        'melakukan edit data user berdasarkan kode user yang di panggil
        Call Koneksi()
        CMD = New OdbcCommand("update tunjangan set nip = '" & cbnip.Text &
                                   "', namaguru='" & txtnamaguru.Text &
                                   "', jabatan='" & txtjabatan.Text &
                                   "', tunjanganjabatan='" & txttunjanganjabatan.Text &
                                   "', transport='" & txttransport.Text &
                                    "', gajipokok='" & txtgajipokok.Text &
                                   "' where kodetunjangan = '" & txtkodetunjangan.Text & "'", Conn)
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil Di Update..!")
        Call bersih()
        Call tampil_tunjangan()

    End Sub

    Private Sub btntambahdata_Click(sender As Object, e As EventArgs) Handles btntambahdata.Click
        kondisidisable()
        Call Koneksi()
        CMD = New OdbcCommand("select kodetunjangan from tunjangan order by kodetunjangan desc", Conn)
        Dim urutankode As String
        Dim hitung As Long
        Rd = CMD.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            urutankode = "KTJN" + "0001"
            txttunjanganjabatan.Focus()
        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 4) + 1
            urutankode = "KTJN" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        txtkodetunjangan.Text = urutankode
        txttunjanganjabatan.Focus()
        Call bersihtambahdata()
    End Sub

    Private Sub dgvtunjangan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtunjangan.CellContentClick
        kondisidisableupdate()
        Dim i As Integer
        i = dgvtunjangan.CurrentRow.Index

        On Error Resume Next
        txtkodetunjangan.Text = dgvtunjangan.Item(0, i).Value
        cbnip.Text = dgvtunjangan.Item(1, i).Value
        txtnamaguru.Text = dgvtunjangan.Item(2, i).Value
        txtjabatan.Text = dgvtunjangan.Item(3, i).Value
        txttunjanganjabatan.Text = dgvtunjangan.Item(4, i).Value
        txttransport.Text = dgvtunjangan.Item(5, i).Value
        txtgajipokok.Text = dgvtunjangan.Item(6, i).Value
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