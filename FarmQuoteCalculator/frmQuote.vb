' *****************************************************************
' Team Number: 21
' Team Member 1 Details: Ntsie, KC (220061693)
' Team Member 2 Details: Nchaupa, F (200915560)
' Team Member 3 Details: Jansen, JNJ (217040076)
' Team Member 4 Details: Smit, K (201572532)
' Practical: Team Project
' Class name: frmQuote
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmQuote

    Private _region As Region
    Private _proposal As Proposal

    Public Sub New(ByRef region As Region)
        InitializeComponent()
        Me._region = region
    End Sub

    Public Sub New(ByRef proposal As Proposal)
        InitializeComponent()
        Me._proposal = proposal
        'Load proposal from file or loaded collection
    End Sub

    Private Sub frmQuote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNextQuote.Click

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        frmMenu.Show()
        Me.Hide()
    End Sub
End Class