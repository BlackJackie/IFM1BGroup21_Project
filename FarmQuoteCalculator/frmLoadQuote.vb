' *****************************************************************
' Team Number: 21
' Team Member 1 Details: Ntsie, KC (220061693)
' Team Member 2 Details: Nchaupa, F (200915560)
' Team Member 3 Details: Jansen, JNJ (217040076)
' Team Member 4 Details: Smit, K (201572532)
' Practical: Team Project
' Class name: frmLoadQuote
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmLoadQuote

    Private proposals() As Proposal
    Private fileManager As FileStorageManager

    Public Sub New()
        InitializeComponent()
        'Reload all proposals from file
        fileManager = New FileStorageManager()
        proposals = fileManager.LoadQuotes()
    End Sub

    Private Sub frmLoadQuote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

    End Sub

    Private Sub btnBackToMenu_Click(sender As Object, e As EventArgs) Handles btnBackToMenu.Click
        frmMenu.Show()
        Me.Hide()
    End Sub
End Class