Imports System.Data.Odbc
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class laporan
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Close()
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        Try
            Dim cryrpt As ReportDocument
            Dim crtablelogoinfos As New TableLogOnInfos
            Dim crtablelogoinfo As New TableLogOnInfo
            Dim crconnectioninfo As New ConnectionInfo
            Dim crtables As Tables
            Dim crtable As Table
            Dim laporan As New laporanpenggajian

            cryrpt = laporan

            With crconnectioninfo
                .ServerName = Application.StartupPath & "\dbpenggajiansmk"
                .DatabaseName = Application.StartupPath & "\dbpenggajiansmk"
                .UserID = ""
                .Password = ""
                laporan.Load("laporanpenggajian.rpt")
                laporan.SetDatabaseLogon("root", "")
                CrystalReportViewer1.ReportSource = laporan
                CrystalReportViewer1.RefreshReport()
            End With
            crtables = cryrpt.Database.Tables
            For Each crtable In crtables
                crtablelogoinfo = crtable.LogOnInfo
                crtablelogoinfo.ConnectionInfo = crconnectioninfo
                crtable.ApplyLogOnInfo(crtablelogoinfo)
            Next
            CrystalReportViewer1.ReportSource = cryrpt
            'CrystalReportViewer1.Refresh()
            'CrystalReportViewer1.RefreshReport()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        CrystalReportViewer1.PrintReport()
    End Sub

    Private Sub btnexport_Click(sender As Object, e As EventArgs) Handles btnexport.Click
        CrystalReportViewer1.ExportReport()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class