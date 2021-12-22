Imports System.Data.Odbc
Public Class bank
    Sub tampil_tunjangan()
        CMD = New OdbcCommand("select * from bank", Conn)
        Rd = CMD.ExecuteReader
        dgvbank.Rows.Clear()
        Do While Rd.Read = True
            dgvbank.Rows.Add(Rd(0), Rd(1), Rd(2), Rd(3), Rd(4))
        Loop
    End Sub

    Sub bersih()
        txtkodebank.Clear()
        cbnip.Text = ""
        txtnamaguru.Clear()
        txtnamabank.Clear()
        txtnorekening.Clear()
        cbnip.Focus()
    End Sub

    Sub bersihtambahdata()
        cbnip.Text = ""
        txtnamaguru.Clear()
        txtnamabank.Clear()
        txtnorekening.Clear()
        cbnip.Focus()
    End Sub

    Private Sub kondisienable()
        txtkodebank.Enabled = False
        cbnip.Enabled = False
        txtnamaguru.Enabled = False
        txtnamabank.Enabled = False
        txtnorekening.Enabled = False
        btntambahdata.Enabled = True
        btnsave.Enabled = False
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnclear.Enabled = False
    End Sub

    Private Sub kondisidisable()
        txtkodebank.Enabled = False
        cbnip.Enabled = True
        txtnamaguru.Enabled = False
        txtnamabank.Enabled = True
        txtnorekening.Enabled = True
        btntambahdata.Enabled = False
        btnsave.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnclear.Enabled = False
    End Sub

    Private Sub kondisidisableupdate()
        txtkodebank.Enabled = False
        cbnip.Enabled = True
        txtnamaguru.Enabled = False
        txtnamabank.Enabled = True
        txtnorekening.Enabled = True
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
    Private Sub bank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call tampil_tunjangan()
        Call bersih()
        Call kondisidisable()
        Call kondisidisableupdate()
        Call kondisienable()
        Call bersihtambahdata()
        Call comboboxnip()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        kondisienable()
        If txtkodebank.Text = "" Or cbnip.Text = "" Or txtnamaguru.Text = "" Or txtnamabank.Text = "" Or txtnorekening.Text = "" Then
            MsgBox("Semua Data Wajib di Isi.!!")
        Else
            'pesan username tidak boleh sama
            Call Koneksi()
            CMD = New OdbcCommand("select * from bank where nip ='" & cbnip.Text & "'", Conn)
            Rd = CMD.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                MsgBox("NIP Guru tidak boleh sama")
                Call bersih()
            Else
                'pengecekan data user apakah ada atau tidak
                CMD = New OdbcCommand("select * from bank where kodebank='" & txtkodebank.Text & "'", Conn)
                Rd = CMD.ExecuteReader
                Rd.Read()
                If Rd.HasRows = False Then
                    'penyimpanan data ke database
                    Call Koneksi()
                    CMD = New OdbcCommand("insert into bank values ('" & txtkodebank.Text &
                                          "','" & cbnip.Text &
                                          "','" & txtnamaguru.Text &
                                          "','" & txtnamabank.Text &
                                          "','" & txtnorekening.Text &
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

    Private Sub txtnip_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MsgBox("Apakah data akan di hapus..?") Then
            CMD = New OdbcCommand("delete from bank where kodebank = '" & txtkodebank.Text & "' ", Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di delete !!!")
            Call bersih()
            Call tampil_tunjangan()
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Call bersih()
    End Sub

    Private Sub txtkodebank_TextChanged(sender As Object, e As EventArgs) Handles txtkodebank.TextChanged
        'Memanggil data berdasarkan kode
        CMD = New OdbcCommand("select * from bank where kodebank='" & txtkodebank.Text & "'", Conn)
        Rd = CMD.ExecuteReader
        Rd.Read()
        If Rd.HasRows = True Then
            cbnip.Text = Rd(1)
        Else
            cbnip.Text = ""
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        'melakukan edit data user berdasarkan kode user yang di panggil
        Call Koneksi()
        CMD = New OdbcCommand("update bank set nip = '" & cbnip.Text &
                                   "', namaguru='" & txtnamaguru.Text &
                                   "', namabank='" & txtnamabank.Text &
                                   "', norekening='" & txtnorekening.Text &
                                   "' where kodebank = '" & txtkodebank.Text & "'", Conn)
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil Di Update..!")
        Call bersih()
        Call tampil_tunjangan()
    End Sub

    Private Sub btntambahdata_Click(sender As Object, e As EventArgs) Handles btntambahdata.Click
        kondisidisable()
        Call Koneksi()
        CMD = New OdbcCommand("select kodebank from bank order by kodebank desc", Conn)
        Dim urutankode As String
        Dim hitung As Long
        Rd = CMD.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            urutankode = "KBNK" + "0001"
            cbnip.Focus()
        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 4) + 1
            urutankode = "KBNK" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        txtkodebank.Text = urutankode
        cbnip.Focus()
        Call bersihtambahdata()
    End Sub

    Private Sub dgvbank_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbank.CellContentClick
        kondisidisableupdate()
        Dim i As Integer
        i = dgvbank.CurrentRow.Index

        On Error Resume Next
        txtkodebank.Text = dgvbank.Item(0, i).Value
        cbnip.Text = dgvbank.Item(1, i).Value
        txtnamaguru.Text = dgvbank.Item(2, i).Value
        txtnamabank.Text = dgvbank.Item(3, i).Value
        txtnorekening.Text = dgvbank.Item(4, i).Value
    End Sub

    Private Sub cbnip_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbnip.SelectedIndexChanged
        'Memanggil data berdasarkan kode
        CMD = New OdbcCommand("select * from guru where nip='" & cbnip.Text & "'", Conn)
        Rd = CMD.ExecuteReader
        Rd.Read()
        If Rd.HasRows = True Then
            txtnamaguru.Text = Rd(1)

        Else
            txtnamaguru.Clear()
        End If
    End Sub
End Class