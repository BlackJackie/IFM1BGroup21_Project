﻿' *****************************************************************
' Team Number: 21
' Team Member 1 Details: Ntsie, KC (220061693)
' Team Member 2 Details: Nchaupa, F (200915560)
' Team Member 3 Details: Jansen, JNJ (217040076)
' Team Member 4 Details: Smit, K (201572532)
' Practical: Team Project
' Class name: Farm
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off

<Serializable()>
Public MustInherit Class Farm
    Protected _Yield As Double
    Protected _Plot As Plot
    Protected _Size As Double
    Protected _ConstructionCostPerSquareMeter As Double
    Protected _ConstructionCost As Double
    Protected _YieldPerSquareMeter As Double

    'Constructor
    Public Sub New(ByRef plot As Plot)
        _Plot = plot
    End Sub

    'Properties
    Public ReadOnly Property Yield() As Double
        Get
            Return _Yield
        End Get
    End Property

    Public ReadOnly Property Plot() As Plot
        Get
            Return _Plot
        End Get
    End Property

    Public ReadOnly Property Size() As Double
        Get
            Return _Size
        End Get
    End Property

    Public ReadOnly Property Cost() As Double
        Get
            Return _ConstructionCost
        End Get
    End Property


    'Abstract Methods
    Protected MustOverride Sub CalculateYield()
    Protected MustOverride Sub CalculateConstructionCost()
    Public MustOverride Function GetFarmType() As String
    Public MustOverride Function GetFarmTypeEnum() As EnumCollection.FarmType
    Protected MustOverride Sub CalculateOptimalFarmSize(ByVal limitToMeet As Double, ByVal isBudgetRestricted As Boolean)

    'Methods
    Public Function GetMarketedYield() As Double
        Return _Yield * (20 / 100)
    End Function

    Public Function GetCharityYield() As Double
        Return _Yield * (80 / 100)
    End Function


End Class
