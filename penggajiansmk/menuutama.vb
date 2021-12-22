Public Class menuutama
    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim keluar As String

        '' Tampil peringatan
        keluar = MsgBox("Yakin Anda ingin keluar..?", vbQuestion + vbYesNo, "Konfirmasi")
        If keluar = vbYes Then
            Me.Close()
        ElseIf keluar = vbNo Then
            Exit Sub
        End If
        login.Show()
    End Sub

    Private Sub btnuser_Click(sender As Object, e As EventArgs) Handles btnuser.Click
        user.ShowDialog()
    End Sub

    Private Sub btnguru_Click(sender As Object, e As EventArgs) Handles btnguru.Click
        guru.ShowDialog()
    End Sub

    Private Sub btntunjangan_Click(sender As Object, e As EventArgs) Handles btntunjangan.Click
        tunjangan.ShowDialog()
    End Sub

    Private Sub btnabsensi_Click(sender As Object, e As EventArgs) Handles btnabsensi.Click
        absensi.ShowDialog()
    End Sub

    Private Sub btnbank_Click(sender As Object, e As EventArgs) Handles btnbank.Click
        bank.ShowDialog()
    End Sub

    Private Sub btntransaksi_Click(sender As Object, e As EventArgs) Handles btntransaksi.Click
        transaksi.ShowDialog()
    End Sub

    Private Sub btnlaporan_Click(sender As Object, e As EventArgs) Handles btnlaporan.Click
        laporan.ShowDialog()
    End Sub

    Private Sub btnabout_Click(sender As Object, e As EventArgs) Handles btnabout.Click
        about.ShowDialog()
    End Sub

    Private Sub btnsekolah_Click(sender As Object, e As EventArgs) Handles btnsekolah.Click
        sekolah.ShowDialog()
    End Sub
End Class