Imports System.Data.Odbc
Public Class login
    Sub bersih()
        txtpassword.Clear()

    End Sub
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Dim keluar As String

        '' Tampil peringatan
        keluar = MsgBox("Yakin Anda ingin tutup aplikasi..?", vbQuestion + vbYesNo, "Konfirmasi")
        If keluar = vbYes Then
            End
        ElseIf keluar = vbNo Then
            Exit Sub
        End If
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Username atau Password Tidak Boleh Kosong!")
        Else
            Call Koneksi()
            CMD = New Odbc.OdbcCommand("Select * From user where username='" & txtusername.Text & "' and password='" & txtpassword.Text & "'", Conn)
            Rd = CMD.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                'If txtusername.Text = "AA" And txtpassword.Text = "BB" Then
                Me.Hide()
                menuutama.Show()
            Else
                MsgBox("Username atau Password Salah!")
            End If
            Call bersih()
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.Focus()
    End Sub
End Class