﻿Public Class flash
    Private Sub flash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        Timer1.Enabled = True
        Me.BackColor = Nothing
        TransparencyKey = BackColor
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 2
        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            Me.Hide()
            login.Show()
        End If
    End Sub
End Class