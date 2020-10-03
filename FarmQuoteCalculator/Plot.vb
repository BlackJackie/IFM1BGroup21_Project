' *****************************************************************
' Team Number: 21
' Team Member 1 Details: Ntsie, KC (220061693)
' Team Member 2 Details: Nchaupa, F (200915560)
' Team Member 3 Details: Jansen, JNJ (217040076)
' Team Member 4 Details: Smit, K (201572532)
' Practical: Team Project
' Class name: Plot
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off

<Serializable()>
Public Class Plot
    Private _Description As String
    Private _WaterRating As EnumCollection.Rating
    Private _FertilityRating As EnumCollection.Rating
    Private _SurfaceArea As Double

    Public Sub New(ByVal description As String,
                   ByVal waterRating As EnumCollection.Rating,
                   ByVal fertilityRating As EnumCollection.Rating, ByVal surfaceArea As Double)
        _Description = description
        _WaterRating = waterRating
        _FertilityRating = fertilityRating
        _SurfaceArea = surfaceArea
    End Sub

    Public ReadOnly Property WaterRating() As EnumCollection.Rating
        Get
            Return _WaterRating
        End Get
    End Property

    Public ReadOnly Property WaterRatingDescription() As String
        Get
            Select Case _WaterRating
                Case EnumCollection.Rating.HIGH
                    Return "High"
                Case EnumCollection.Rating.LOW
                    Return "Low"
                Case Else
                    Return "Unknown"
            End Select
        End Get
    End Property

    Public ReadOnly Property FertilityRating() As EnumCollection.Rating
        Get
            Return _FertilityRating
        End Get
    End Property

    Public ReadOnly Property FertilityRatingDescription() As String
        Get
            Select Case _FertilityRating
                Case EnumCollection.Rating.HIGH
                    Return "High"
                Case EnumCollection.Rating.LOW
                    Return "Low"
                Case Else
                    Return "Unknown"
            End Select
        End Get
    End Property

    Public ReadOnly Property SurfaceArea() As Double
        Get
            Return _SurfaceArea
        End Get
    End Property

    Public ReadOnly Property Description() As String
        Get
            Return _Description
        End Get
    End Property

End Class
