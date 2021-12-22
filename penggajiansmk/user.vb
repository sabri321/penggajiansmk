Imports System.Data.Odbc
Public Class user

    Sub tampil_user()
        CMD = New OdbcCommand("select * from user", Conn)
        Rd = CMD.ExecuteReader
        dgvuser.Rows.Clear()
        Do While Rd.Read = True
            dgvuser.Rows.Add(Rd(0), Rd(1), Rd(2), Rd(3))
        Loop
    End Sub

    Sub bersih()
        txtkodeuser.Clear()
        txtnamauser.Clear()
        txtusername.Clear()
        txtpassword.Clear()
    End Sub

    Sub bersihtambahdata()
        txtnamauser.Clear()
        txtusername.Clear()
        txtpassword.Clear()
    End Sub

    Private Sub kondisienable()
        txtkodeuser.Enabled = False
        txtnamauser.Enabled = False
        txtusername.Enabled = False
        txtpassword.Enabled = False
        btntambahdata.Enabled = True
        btnsave.Enabled = False
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnclear.Enabled = False
    End Sub

    Private Sub kondisidisable()
        txtkodeuser.Enabled = False
        txtnamauser.Enabled = True
        txtusername.Enabled = True
        txtpassword.Enabled = True
        btntambahdata.Enabled = False
        btnsave.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnclear.Enabled = False
    End Sub

    Private Sub kondisidisableupdate()
        txtkodeuser.Enabled = False
        txtnamauser.Enabled = True
        txtusername.Enabled = True
        txtpassword.Enabled = True
        btntambahdata.Enabled = True
        btnsave.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
        btnclear.Enabled = True
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call tampil_user()
        Call bersih()
        Call kondisidisable()
        Call kondisienable()
        Call bersihtambahdata()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        kondisienable()
        If txtkodeuser.Text = "" Or txtnamauser.Text = "" Or txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Semua Data Wajib di Isi.!!")
        Else
            'pesan username tidak boleh sama
            Call Koneksi()
            CMD = New OdbcCommand("select * from user where username ='" & txtusername.Text & "'", Conn)
            Rd = CMD.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                MsgBox("username tidak boleh sama")
                Call bersih()
            Else

                'pengecekan data user apakah ada atau tidak
                CMD = New OdbcCommand("select * from user where kodeuser='" & txtkodeuser.Text & "'", Conn)
                Rd = CMD.ExecuteReader
                Rd.Read()
                If Rd.HasRows = False Then
                    'penyimpanan data ke database
                    Call Koneksi()
                    CMD = New OdbcCommand("insert into user values ('" & txtkodeuser.Text &
                                              "','" & txtnamauser.Text &
                                              "','" & txtusername.Text &
                                              "','" & txtpassword.Text &
                                              "')", Conn)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Tambahkan.!!")
                    Call bersih()
                    Call tampil_user()
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
            CMD = New OdbcCommand("delete from user where kodeuser = '" & txtkodeuser.Text & "' ", Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di delete !!!")
            Call bersih()
            Call tampil_user()
        End If
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub btntambahdata_Click(sender As Object, e As EventArgs) Handles btntambahdata.Click
        kondisidisable()
        Call Koneksi()
        CMD = New OdbcCommand("select kodeuser from user order by kodeuser desc", Conn)
        Dim urutankode As String
        Dim hitung As Long
        Rd = CMD.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            urutankode = "USR" + "0001"
            txtnamauser.Focus()
        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 4) + 1
            urutankode = "USR" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        txtkodeuser.Text = urutankode
        txtnamauser.Focus()
        Call bersihtambahdata()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Call Koneksi()
        CMD = New OdbcCommand("update user set namauser = '" & txtnamauser.Text &
                                       "', username='" & txtusername.Text &
                                       "', password='" & txtpassword.Text &
                                       "' where kodeuser = '" & txtkodeuser.Text & "'", Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Di Update..!")
            Call bersih()
        Call tampil_user()
    End Sub

    Private Sub dgvuser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvuser.CellContentClick

    End Sub

    Private Sub dgvuser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvuser.CellClick
        kondisidisableupdate()
        Dim i As Integer
        i = dgvuser.CurrentRow.Index

        On Error Resume Next
        txtkodeuser.Text = dgvuser.Item(0, i).Value
        txtnamauser.Text = dgvuser.Item(1, i).Value
        txtusername.Text = dgvuser.Item(2, i).Value
        txtpassword.Text = dgvuser.Item(3, i).Value
    End Sub
End Class