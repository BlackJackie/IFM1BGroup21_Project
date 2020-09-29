' *****************************************************************
' Team Number: 21
' Team Member 1 Details: Ntsie, KC (220061693)
' Team Member 2 Details: Nchaupa, F (200915560)
' Team Member 3 Details: Jansen, JNJ (217040076)
' Team Member 4 Details: Smit, K (201572532)
' Practical: Team Project
' Class name: Region
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class Region
    Private _Description As String
    Private _Budget As Double
    Private _PovertyPopulation As Integer
    Private _WorkForcePopulation As Integer
    Private _Plots() As Plot

    Public Sub New(ByVal description As String,
                   ByVal budget As Double,
                   ByVal povertyPopulation As Integer,
                   ByVal workingPopulation As Integer)
        _Description = description
        _Budget = budget
        _PovertyPopulation = povertyPopulation
        _WorkForcePopulation = workingPopulation
    End Sub

    Public ReadOnly Property Description() As String
        Get
            Return _Description
        End Get
    End Property

    Public ReadOnly Property Budget() As Double
        Get
            Return _Budget
        End Get
    End Property

    Public ReadOnly Property PovertyPopulation() As Integer
        Get
            Return _PovertyPopulation
        End Get
    End Property

    Public ReadOnly Property WorkForcePopulation() As Integer
        Get
            Return _WorkForcePopulation
        End Get
    End Property

    Public ReadOnly Property Plots(ByVal index As Integer) As Plot
        Get
            Return _Plots(index)
        End Get
    End Property


    Public Function GetNumberOfPlots() As Integer
        Return _Plots.Length
    End Function

    Public Function CalculateFoodQuota() As Integer

    End Function

    Public Sub AddPlot(ByVal description As String,
                   ByVal waterRating As EnumCollection.Rating,
                   ByVal fertilityRating As EnumCollection.Rating, ByVal surfaceArea As Double)

    End Sub
End Class
