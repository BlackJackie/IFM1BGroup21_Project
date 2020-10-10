' *****************************************************************
' Team Number: 21
' Team Member 1 Details: Ntsie, KC (220061693)
' Team Member 2 Details: Nchaupa, F (200915560)
' Team Member 3 Details: Jansen, JNJ (217040076)
' Team Member 4 Details: Smit, K (201572532)
' Practical: Team Project
' Class name: HydroponicFarm
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off

<Serializable()>
Public Class HydroponicFarm
    Inherits Farm

    Public Sub New(ByRef plot As Plot, ByVal limitToMeet As Double, ByVal isBudgetRestricted As Boolean)
        MyBase.New(plot)
        _ConstructionCostPerSquareMeter = 20.0
        _YieldPerSquareMeter = 1
        CalculateOptimalFarmSize(limitToMeet, isBudgetRestricted)
        CalculateConstructionCost()
        CalculateYield()
    End Sub
    Protected Overrides Sub CalculateYield()
        _Yield = _YieldPerSquareMeter * _Size
    End Sub

    Protected Overrides Sub CalculateConstructionCost()
        _ConstructionCost = _ConstructionCostPerSquareMeter * _Size
    End Sub

    Protected Overrides Sub CalculateOptimalFarmSize(limitToMeet As Double, isBudgetRestricted As Boolean)
        If isBudgetRestricted Then
            'First attempt a full plot size farm
            _Size = _Plot.SurfaceArea
            CalculateConstructionCost()

            If (_ConstructionCost > limitToMeet) Then
                'Cost is bigger so make the farm smaller limited to cost
                _Size = limitToMeet / _ConstructionCostPerSquareMeter
            End If
        Else
            'First attempt a full plot size farm
            _Size = _Plot.SurfaceArea
            CalculateYield()

            If (_Yield > limitToMeet) Then
                'Yield is too big, reduce farm size to fit yield exactly
                _Size = (limitToMeet) / (_YieldPerSquareMeter)
            End If
        End If
    End Sub

    Public Overrides Function GetFarmType() As String
        Return "Hydroponic"
    End Function

    Public Overrides Function GetFarmTypeEnum() As EnumCollection.FarmType
        Return EnumCollection.FarmType.HYDROPONIC
    End Function
End Class
