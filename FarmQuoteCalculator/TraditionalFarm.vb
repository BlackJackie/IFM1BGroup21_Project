' *****************************************************************
' Team Number: 21
' Team Member 1 Details: Ntsie, KC (220061693)
' Team Member 2 Details: Nchaupa, F (200915560)
' Team Member 3 Details: Jansen, JNJ (217040076)
' Team Member 4 Details: Smit, K (201572532)
' Practical: Team Project
' Class name: TraditionalFarm
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off

<Serializable()>
Public Class TraditionalFarm
    Inherits Farm

    Public Sub New(ByRef plot As Plot, ByVal limitToMeet As Double, ByVal isBudgetRestricted As Boolean)
        MyBase.New(plot)
        _ConstructionCostPerSquareMeter = 10.0
        _YieldPerSquareMeter = 1
        CalculateOptimalFarmSize(limitToMeet, isBudgetRestricted)
        CalculateConstructionCost()
        CalculateYield()
    End Sub

    Protected Overrides Sub CalculateYield()
        Dim water_multiplier As Double
        Dim fertility_multiplier As Double

        Select Case (_Plot.FertilityRating)
            Case EnumCollection.Rating.HIGH
                fertility_multiplier = 1.0
            Case EnumCollection.Rating.LOW
                fertility_multiplier = 0.5
        End Select

        Select Case (_Plot.WaterRating)
            Case EnumCollection.Rating.HIGH
                water_multiplier = 1.0
            Case EnumCollection.Rating.LOW
                water_multiplier = 0.5
        End Select

        'yield = (water multiplier) x (fertility multiplier) x (yield / m^2) x (farm size)
        _Yield = (water_multiplier) * (fertility_multiplier) * (0.1) * (_Size)
    End Sub

    Protected Overrides Sub CalculateConstructionCost()
        _ConstructionCost = _ConstructionCostPerSquareMeter * _Size
    End Sub

    Protected Overrides Sub CalculateOptimalFarmSize(ByVal limitToMeet As Double, ByVal isBudgetRestricted As Boolean)
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
                Dim water_multiplier As Double
                Dim fertility_multiplier As Double

                Select Case (_Plot.FertilityRating)
                    Case EnumCollection.Rating.HIGH
                        fertility_multiplier = 1.0
                    Case EnumCollection.Rating.LOW
                        fertility_multiplier = 0.5
                End Select
                Select Case (_Plot.WaterRating)
                    Case EnumCollection.Rating.HIGH
                        water_multiplier = 1.0
                    Case EnumCollection.Rating.LOW
                        water_multiplier = 0.5
                End Select

                _Size = (limitToMeet) / ((water_multiplier) * (fertility_multiplier) * (_YieldPerSquareMeter))

            End If
        End If
    End Sub

    Public Overrides Function GetFarmType() As String
        Return "Traditional"
    End Function

    Public Overrides Function GetFarmTypeEnum() As EnumCollection.FarmType
        Return EnumCollection.FarmType.TRADITIONAL
    End Function
End Class
