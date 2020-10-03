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

    Private _isRegionInputEnabled As Boolean = True
    Private _isPlotDetailsEnabled As Boolean = True
    Private _isPlotGridEnabled As Boolean = True


    'Constructors
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmNewQuote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtnFertilityGood.Checked = True
        rbtnWaterGood.Checked = True
        togglePlotInput()
        togglePlotGrid()
        btnGenerateQuote.Enabled = False
        refreshGrid()
    End Sub


    'Buttons
    Private Sub btnAddRegion_Click(sender As Object, e As EventArgs) Handles btnAddRegion.Click
        If isRegionDetailsValid() Then
            _region = New Region(txtRegionDescription.Text, CDbl(txtBudget.Text), CInt(txtPovertyPopulation.Text), CInt(txtWorkingPopulation.Text))
            toggleRegionInput()
            togglePlotGrid()
        End If
    End Sub

    Private Sub btnNewPlotToggle_Click(sender As Object, e As EventArgs) Handles btnNewPlotToggle.Click
        togglePlotInput()
    End Sub

    Private Sub btnAddPlot_Click(sender As Object, e As EventArgs) Handles btnAddPlot.Click
        If isPlotDetailsValid() Then
            Dim waterRating As EnumCollection.Rating
            Dim soilRating As EnumCollection.Rating

            If rbtnWaterGood.Checked Then
                waterRating = EnumCollection.Rating.HIGH
            Else
                waterRating = EnumCollection.Rating.LOW
            End If

            If rbtnFertilityGood.Checked Then
                soilRating = EnumCollection.Rating.HIGH
            Else
                soilRating = EnumCollection.Rating.LOW
            End If

            _region.AddPlot(txtPlotDescription.Text, waterRating, soilRating, CDbl(txtPlotSize.Text))
            refreshGrid()
            btnGenerateQuote.Enabled = True
        End If
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


    'Helper Methods
    'Helper Methods - Input Validators
    Private Function isIntegerInputValid(ByVal value As String, ByVal value_name As String) As Boolean
        If IsNumeric(value) Then
            Dim int_value As Integer = CInt(value)
            If int_value > 0 Then
                Return True
            Else
                showMessage("Error, the " & value_name & " must be greater than zero")
                Return False
            End If
        Else
            showMessage("Error, the input " & value_name & " must be a numeric value")
            Return False
        End If
    End Function

    Private Function isDoubleInputValid(ByVal value As String, ByVal value_name As String) As Boolean
        If IsNumeric(value) Then
            Dim double_value As Double = CDbl(value)
            If double_value > 0.00 Then
                Return True
            Else
                showMessage("Error, the " & value_name & " must be greater than zero")
                Return False
            End If
        Else
            showMessage("Error, the input " & value_name & " must be a numeric value")
            Return False
        End If
    End Function

    Private Function isRegionDetailsValid() As Boolean
        If Not (String.IsNullOrEmpty(txtRegionDescription.Text) Or
            (String.IsNullOrEmpty(txtPovertyPopulation.Text)) Or
            (String.IsNullOrEmpty(txtWorkingPopulation.Text)) Or
            (String.IsNullOrEmpty(txtBudget.Text))) Then

            If Not (String.IsNullOrWhiteSpace(txtRegionDescription.Text) Or
                (String.IsNullOrWhiteSpace(txtPovertyPopulation.Text)) Or
                (String.IsNullOrWhiteSpace(txtWorkingPopulation.Text)) Or
                (String.IsNullOrWhiteSpace(txtBudget.Text))) Then

                'Check numeric input
                If (isIntegerInputValid(txtPovertyPopulation.Text, "Poverty population") And
                    isIntegerInputValid(txtWorkingPopulation.Text, "Working population") And
                    isDoubleInputValid(txtBudget.Text, "Budget")) Then

                    Return True
                End If
            Else
                showMessage("Invalid input, make sure that the Region fields are not empty")
            End If
        Else
            showMessage("Invalid input, make sure that the Region fields are not empty")
        End If
        Return False
    End Function

    Private Function isPlotDetailsValid() As Boolean
        If Not (String.IsNullOrEmpty(txtPlotDescription.Text) Or
            (String.IsNullOrEmpty(txtPlotSize.Text))) Then

            If Not (String.IsNullOrWhiteSpace(txtPlotDescription.Text) Or
                (String.IsNullOrWhiteSpace(txtPlotSize.Text))) Then

                'Check numeric input
                If isDoubleInputValid(txtPlotSize.Text, "Plot size") Then
                    Return True
                End If
            Else
                showMessage("Invalid input, make sure that the Plot Detail fields are not empty")
            End If
        Else
            showMessage("Invalid input, make sure that the Plot Detail fields are not empty")
        End If
        Return False
    End Function

    Private Sub showMessage(ByVal message As String)
        MessageBox.Show(message)
    End Sub


    'Helper Methods - Input Toggles
    Private Sub toggleRegionInput()
        If _isRegionInputEnabled Then
            _isRegionInputEnabled = False
            pnlRegion.Enabled = False
        Else
            _isRegionInputEnabled = True
            pnlRegion.Enabled = True
        End If
    End Sub

    Private Sub togglePlotInput()
        If _isPlotDetailsEnabled Then
            _isPlotDetailsEnabled = False
            lblDetails.Enabled = False
            lblPlotDesc.Enabled = False
            lblSize.Enabled = False
            lblRatings.Enabled = False
            pnlFertility.Enabled = False
            pnlWater.Enabled = False
            txtPlotDescription.Enabled = False
            txtPlotSize.Enabled = False
            btnAddPlot.Enabled = False
        Else
            _isPlotDetailsEnabled = True
            lblDetails.Enabled = True
            lblPlotDesc.Enabled = True
            lblSize.Enabled = True
            lblRatings.Enabled = True
            pnlFertility.Enabled = True
            pnlWater.Enabled = True
            txtPlotDescription.Enabled = True
            txtPlotDescription.Text = ""
            txtPlotSize.Enabled = True
            txtPlotSize.Text = ""
            rbtnFertilityGood.Checked = True
            rbtnWaterGood.Checked = True
            btnAddPlot.Enabled = True
        End If
    End Sub

    Private Sub togglePlotGrid()
        If _isPlotGridEnabled Then
            _isPlotGridEnabled = False
            pnlPlots.Enabled = False
        Else
            _isPlotGridEnabled = True
            pnlPlots.Enabled = True
        End If
    End Sub


    'Helper Methods - Plot Grid Control
    Private Sub setCell(ByVal row As Integer, ByVal col As Integer, ByVal value As String)
        grdPlots.Row = row
        grdPlots.Col = col
        grdPlots.Text = value
    End Sub

    Private Sub refreshGrid()
        grdPlots.FixedCols = 0
        grdPlots.FixedRows = 1

        If IsNothing(_region) Then
            grdPlots.Cols = 4
            grdPlots.Rows = 2
            loadHeaders()
        Else
            Dim index As Integer
            Dim numPlots As Integer = _region.GetNumberOfPlots()
            Dim plot As Plot

            grdPlots.Cols = 4
            grdPlots.Rows = (numPlots) + 1
            loadHeaders()

            For index = 0 To numPlots
                plot = _region.Plots(index)
                setCell(index + 1, 0, plot.Description)
                setCell(index + 1, 1, CStr(plot.SurfaceArea))
                setCell(index + 1, 2, CStr(plot.FertilityRatingDescription))
                setCell(index + 1, 3, CStr(plot.WaterRatingDescription))
            Next

        End If
    End Sub

    Private Sub loadHeaders()
        setCell(0, 0, "Description")
        setCell(0, 1, "Size(m^2)")
        setCell(0, 2, "Fertility")
        setCell(0, 3, "Water Supply")
    End Sub

End Class