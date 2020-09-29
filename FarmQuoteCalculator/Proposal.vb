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
    Private _Region As Region
    Private _FoodQuota As Integer
    Private _IsBudgetRestricted As Boolean
    Private _Farms() As Farm

    Public Sub New(ByRef region As Region, ByVal isBudgetRestricted As Boolean)
        _Region = region
        _IsBudgetRestricted = isBudgetRestricted
        _FoodQuota = region.CalculateFoodQuota()
        _Farms = CalculateFarmsToConstruct()
    End Sub


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


    Private Function CalculateFarmsToConstruct() As Farm()

    End Function

    Public Function GetNumberOfFarms() As Integer
        Return _Farms.Length
    End Function

    Public Function GenerateFoodRestrictedProposal() As Proposal

    End Function





End Class
