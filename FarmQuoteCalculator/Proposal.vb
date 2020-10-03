' *****************************************************************
' Team Number: 21
' Team Member 1 Details: Ntsie, KC (220061693)
' Team Member 2 Details: Nchaupa, F (200915560)
' Team Member 3 Details: Jansen, JNJ (217040076)
' Team Member 4 Details: Smit, K (201572532)
' Practical: Team Project
' Class name: Proposal
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class Proposal
    Private _QuoteID As String
    Private _Region As Region
    Private _FoodQuota As Integer
    Private _IsBudgetRestricted As Boolean
    Private _Farms() As Farm

    'Constructor
    Public Sub New(ByRef region As Region, ByVal isBudgetRestricted As Boolean)
        _QuoteID = GenerateQuoteID()
        _Region = region
        _IsBudgetRestricted = isBudgetRestricted
        _FoodQuota = region.CalculateFoodQuota()
        _Farms = CalculateFarmsToConstruct()
    End Sub

    'File storage 
    Private Function GenerateQuoteID() As String
        'Easy - use the date time numbers to form the quote ID
        Return "TODO"
    End Function

    Public ReadOnly Property QuoteID() As String
        Get
            Return _QuoteID
        End Get
    End Property

    Public ReadOnly Property GivenRegion() As Region
        Get
            Return _Region
        End Get
    End Property

    Public ReadOnly Property FoodQuota() As Integer
        Get
            Return _FoodQuota
        End Get
    End Property

    Public ReadOnly Property IsBudgetRestricted() As Boolean
        Get
            Return _IsBudgetRestricted
        End Get
    End Property

    Public ReadOnly Property Farm(ByVal index As Integer) As Farm
        Get
            Return _Farms(index)
        End Get
    End Property


    'Total Cost
    Public Function GetTotalCost() As Double
        Dim total_cost As Double = 0
        Dim numFarms As Integer = GetTotalFarms()
        Dim index As Integer

        For index = 0 To numFarms - 1
            total_cost = total_cost + Farm(index).Cost
        Next

        Return total_cost;
    End Function

    Public Function GetTotalCostTraditional() As Double
        Throw New NotImplementedException()
    End Function

    Public Function GetTotalCostHydroponic() As Double
        Throw New NotImplementedException()
    End Function


    'Fulfilled Food Quota
    Public Function GetFulfilledFoodQuota() As Double
        Throw New NotImplementedException()
    End Function

    Public Function GetFulfilledFoodQuotaByTraditional() As Double
        Throw New NotImplementedException()
    End Function

    Public Function GetFulfilledFoodQuotaByHydroponic() As Double
        Throw New NotImplementedException()
    End Function


    'Number of Farms
    Public Function GetTotalFarms() As Integer
        Return _Farms.Length
    End Function

    Public Function GetTotalTraditionalFarms() As Integer
        Throw New NotImplementedException()
    End Function

    Public Function GetTotalHydroponicFarms() As Integer
        Throw New NotImplementedException()
    End Function


    'Yield of Farms
    Public Function GetTotalYieldOfFarms() As Integer
        Throw New NotImplementedException()
    End Function

    Public Function GetTotalYieldOfTraditionalFarms() As Integer
        Throw New NotImplementedException()
    End Function

    Public Function GetTotalYieldHydroponicFarms() As Integer
        Throw New NotImplementedException()
    End Function


    'Size of Farms
    Public Function GetTotalSizeOfFarms() As Integer
        Throw New NotImplementedException()
    End Function

    Public Function GetTotalSizeOfTraditionalFarms() As Integer
        Throw New NotImplementedException()
    End Function

    Public Function GetTotalSizeHydroponicFarms() As Integer
        Throw New NotImplementedException()
    End Function


    'Calculation
    Private Function CalculateFarmsToConstruct() As Farm()
        Throw New NotImplementedException()
    End Function

    Public Function GenerateFoodRestrictedProposal() As Proposal
        Throw New NotImplementedException()
    End Function





End Class
