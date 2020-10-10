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

    Private _proposal As Proposal


    'Constructors
    Public Sub New(ByRef region As Region)
        InitializeComponent()
        _proposal = New Proposal(region, True)
        lblQuoteID.Text = _proposal.QuoteID
        refreshQuoteGrid()
        refreshFarmGrid()
    End Sub

    Public Sub New(ByRef proposal As Proposal)
        InitializeComponent()
        Me._proposal = proposal
        lblQuoteID.Text = _proposal.QuoteID

        If proposal.IsBudgetRestricted Then
            lblRestriction.Text = "Budget Restricted Quote"
            btnGenerateBudgetRestrictedQuote.Enabled = False
            btnGenerateFoodRestrictedQuote.Enabled = True
        Else
            lblRestriction.Text = "Food Restricted Quote"
            btnGenerateBudgetRestrictedQuote.Enabled = True
            btnGenerateFoodRestrictedQuote.Enabled = False
        End If

        refreshQuoteGrid()
        refreshFarmGrid()
    End Sub

    Private Sub frmQuote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Do nothing
    End Sub


    'Buttons
    Private Sub btnGenerateFoodRestrictedQuote_Click(sender As Object, e As EventArgs) Handles btnGenerateFoodRestrictedQuote.Click
        Dim next_proposal As Proposal = _proposal.GenerateFoodRestrictedProposal()
        Dim frmQuoteWindow As New frmQuote(next_proposal)
        frmQuoteWindow.Show()
        Me.Hide()
    End Sub

    Private Sub btnGenerateBudgetRestrictedQuote_Click(sender As Object, e As EventArgs) Handles btnGenerateBudgetRestrictedQuote.Click
        Dim next_proposal As Proposal = _proposal.GenerateBudgetRestrictedProposal()
        Dim frmQuoteWindow As New frmQuote(next_proposal)
        frmQuoteWindow.Show()
        Me.Hide()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        frmMenu.Show()
        Me.Hide()
    End Sub


    'Helper Methods
    'Helper Methods - Quote Grid Control
    Private Sub setQuoteCell(ByVal row As Integer, ByVal col As Integer, ByVal value As String)
        grdQuote.Row = row
        grdQuote.Col = col
        grdQuote.Text = value
    End Sub

    Private Sub refreshQuoteGrid()
        grdQuote.FixedCols = 1
        grdQuote.FixedRows = 0
        grdQuote.Cols = 2
        grdQuote.Rows = 21
        loadQuoteHeaders()

        If IsNothing(_proposal) Then
            'Do nothing
        Else
            If _proposal.IsBudgetRestricted Then
                setQuoteCell(0, 1, "Budget Restricted")
            Else
                setQuoteCell(0, 1, "Food Quota Restricted")
            End If
            setQuoteCell(1, 1, _proposal.GivenRegion.Description)
            setQuoteCell(2, 1, "R " & CStr(_proposal.GivenRegion.Budget))
            setQuoteCell(3, 1, "R " & CStr(_proposal.GetTotalCost()))
            setQuoteCell(4, 1, CStr(_proposal.FoodQuota))
            setQuoteCell(5, 1, CStr(_proposal.GetFulfilledFoodQuota()))
            setQuoteCell(6, 1, CStr(_proposal.GetTotalFarms()))
            setQuoteCell(7, 1, "")
            setQuoteCell(8, 1, "------")
            setQuoteCell(9, 1, CStr(_proposal.GetTotalTraditionalFarms()))
            setQuoteCell(10, 1, CStr(_proposal.GetTotalSizeOfTraditionalFarms()))
            setQuoteCell(11, 1, CStr(_proposal.GetTotalCostTraditional()))
            setQuoteCell(12, 1, CStr(_proposal.GetTotalYieldOfTraditionalFarms()))
            setQuoteCell(13, 1, CStr(_proposal.GetFulfilledFoodQuotaByTraditional()))
            setQuoteCell(14, 1, "")
            setQuoteCell(15, 1, "------")
            setQuoteCell(16, 1, CStr(_proposal.GetTotalHydroponicFarms()))
            setQuoteCell(17, 1, CStr(_proposal.GetTotalSizeHydroponicFarms()))
            setQuoteCell(18, 1, CStr(_proposal.GetTotalCostHydroponic()))
            setQuoteCell(19, 1, CStr(_proposal.GetTotalYieldHydroponicFarms()))
            setQuoteCell(20, 1, CStr(_proposal.GetFulfilledFoodQuotaByHydroponic()))

        End If
    End Sub

    Private Sub loadQuoteHeaders()
        setQuoteCell(0, 0, "Restriction")
        setQuoteCell(1, 0, "Region")
        setQuoteCell(2, 0, "Allocated Budget")
        setQuoteCell(3, 0, "Quoted Budget")
        setQuoteCell(4, 0, "Allocated Food Quota")
        setQuoteCell(5, 0, "Fulfilled Food Quota")
        setQuoteCell(6, 0, "Total Farms Combined")
        setQuoteCell(7, 0, "")
        setQuoteCell(8, 0, "Traditional Farms")
        setQuoteCell(9, 0, "Total Farms")
        setQuoteCell(10, 0, "Total Size (m^2)")
        setQuoteCell(11, 0, "Total Cost")
        setQuoteCell(12, 0, "Total Yield")
        setQuoteCell(13, 0, "Total Fulfilled Food Quota")
        setQuoteCell(14, 0, "")
        setQuoteCell(15, 0, "Hydroponic Farms")
        setQuoteCell(16, 0, "Total Farms")
        setQuoteCell(17, 0, "Total Size (m^2)")
        setQuoteCell(18, 0, "Total Cost")
        setQuoteCell(19, 0, "Total Yield")
        setQuoteCell(20, 0, "Total Fulfilled Food Quota")
    End Sub


    'Helper Methods - Farms Grid Control
    Private Sub setFarmCell(ByVal row As Integer, ByVal col As Integer, ByVal value As String)
        grdFarms.Row = row
        grdFarms.Col = col
        grdFarms.Text = value
    End Sub

    Private Sub refreshFarmGrid()
        grdFarms.FixedCols = 0
        grdFarms.FixedRows = 1
        grdFarms.Cols = 6

        If IsNothing(_proposal) Then
            grdFarms.Rows = 2
            loadFarmHeaders()
        Else
            Dim index As Integer
            Dim numFarms As Integer = _proposal.GetTotalFarms()
            Dim farm As Farm

            grdFarms.Rows = (numFarms) + 1
            loadFarmHeaders()

            For index = 0 To numFarms - 1
                farm = _proposal.Farm(index)
                setFarmCell(index + 1, 0, farm.GetFarmType())
                setFarmCell(index + 1, 1, farm.Plot.Description)
                setFarmCell(index + 1, 2, CStr(farm.Size))
                setFarmCell(index + 1, 3, CStr(farm.Cost))
                setFarmCell(index + 1, 4, CStr(farm.GetCharityYield()))
                setFarmCell(index + 1, 5, CStr(farm.GetMarketedYield()))
            Next

        End If
    End Sub

    Private Sub loadFarmHeaders()
        setFarmCell(0, 0, "Farm Type")
        setFarmCell(0, 1, "Plot")
        setFarmCell(0, 2, "Size(m^2)")
        setFarmCell(0, 3, "Cost")
        setFarmCell(0, 4, "Charity Yield")
        setFarmCell(0, 5, "Maintenance Yield")
    End Sub

End Class