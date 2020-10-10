' *****************************************************************
' Team Number: 21
' Team Member 1 Details: Ntsie, KC (220061693)
' Team Member 2 Details: Nchaupa, F (200915560)
' Team Member 3 Details: Jansen, JNJ (217040076)
' Team Member 4 Details: Smit, K (201572532)
' Practical: Team Project
' Class name: frmMenu
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMenu

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileManager As New FileStorageManager()
        'fileManager.startFreshFile()
        'fileManager.test()
    End Sub

    Private Sub btnNewQuote_Click(sender As Object, e As EventArgs) Handles btnNewQuote.Click
        Dim frmNewQuoteWindow As New frmNewQuote()
        frmNewQuoteWindow.Show()
        Me.Hide()
    End Sub

    Private Sub btnLoadQuote_Click(sender As Object, e As EventArgs) Handles btnLoadQuote.Click
        frmLoadQuote.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
