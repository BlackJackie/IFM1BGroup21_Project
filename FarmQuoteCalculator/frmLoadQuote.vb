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
        refreshQuotesGrid()
    End Sub

    Private Sub frmLoadQuote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

    End Sub

    Private Sub btnBackToMenu_Click(sender As Object, e As EventArgs) Handles btnBackToMenu.Click
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnCleanFile_Click(sender As Object, e As EventArgs) Handles btnCleanFile.Click
        fileManager.startFreshFile()
    End Sub

    'Helper Methods
    Private Sub setQuoteCell(ByVal row As Integer, ByVal col As Integer, ByVal value As String)
        grdQuotes.Row = row
        grdQuotes.Col = col
        grdQuotes.Text = value
    End Sub

    Private Sub loadQuoteGridHeaders()
        setQuoteCell(0, 0, "Quote ID")
        setQuoteCell(0, 1, "Region")
        setQuoteCell(0, 2, "Restriction")
        setQuoteCell(0, 3, "Budget")
        setQuoteCell(0, 4, "Actual Cost")
        setQuoteCell(0, 5, "Food Quota")
    End Sub

    Private Sub addQuoteToGrid(ByRef proposal As Proposal)
        grdQuotes.Rows = grdQuotes.Rows + 1
        Dim row As Integer = grdQuotes.Rows - 1
        setQuoteCell(row, 0, proposal.QuoteID)
        setQuoteCell(row, 1, proposal.GivenRegion.Description)
        If (proposal.IsBudgetRestricted) Then
            setQuoteCell(row, 2, "Budget")
        Else
            setQuoteCell(row, 2, "Food")
        End If
        setQuoteCell(row, 3, CStr(proposal.GivenRegion.Budget))
        setQuoteCell(row, 4, CStr(proposal.GetTotalCost()))
        setQuoteCell(row, 5, CStr(proposal.GivenRegion.CalculateFoodQuota()))

    End Sub

    Private Sub refreshQuotesGrid()
        grdQuotes.Rows = 1
        grdQuotes.Cols = 6
        grdQuotes.FixedRows = 1

        loadQuoteGridHeaders()

        Dim num_proposals As Integer = proposals.Length
        Dim i As Integer
        For i = 0 To num_proposals - 1
            addQuoteToGrid(proposals(i))
        Next
    End Sub
End Class