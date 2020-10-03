' *****************************************************************
' Team Number: 21
' Team Member 1 Details: Ntsie, KC (220061693)
' Team Member 2 Details: Nchaupa, F (200915560)
' Team Member 3 Details: Jansen, JNJ (217040076)
' Team Member 4 Details: Smit, K (201572532)
' Practical: Team Project
' Class name: frmNewQuote
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmNewQuote

    Private _region As Region

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmNewQuote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Buttons
    Private Sub btnAddRegion_Click(sender As Object, e As EventArgs) Handles btnAddRegion.Click

    End Sub

    Private Sub btnNewPlotToggle_Click(sender As Object, e As EventArgs) Handles btnNewPlotToggle.Click

    End Sub

    Private Sub btnAddPlot_Click(sender As Object, e As EventArgs) Handles btnAddPlot.Click

    End Sub

    Private Sub btnGenerateQuote_Click(sender As Object, e As EventArgs) Handles btnGenerateQuote.Click
        Dim frmQuoteWindow As New frmQuote(_region)
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnBackToMenu_Click(sender As Object, e As EventArgs) Handles btnBackToMenu.Click
        frmMenu.Show()
        Me.Hide()
    End Sub
End Class