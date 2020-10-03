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

Public Class TraditionalFarm
    Inherits Farm

    Public Sub New(ByRef plot As Plot, ByVal size As Double)
        MyBase.New(plot, size)
    End Sub

    Public Overrides Sub CalculateYield()
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub CalculateConstructionCost()
        Throw New NotImplementedException()
    End Sub

    Public Overrides Function GetFarmType() As String
        Return "Traditional"
    End Function
End Class
