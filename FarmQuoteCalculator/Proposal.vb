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
        Throw New NotImplementedException()
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
            total_cost += Farm(index).Cost
        Next

        Return total_cost
    End Function

    Public Function GetTotalCostTraditional() As Double
        Dim numFarms As Integer = GetTotalFarms()
        Dim total_cost As Double = 0

        Dim currentFarm As Farm
        Dim index As Integer

        For index = 0 To numFarms - 1
            currentFarm = Farm(index)
            If (currentFarm.GetFarmTypeEnum() = EnumCollection.FarmType.TRADITIONAL) Then
                total_cost += currentFarm.Cost
            End If
        Next

        Return total_cost
    End Function

    Public Function GetTotalCostHydroponic() As Double
        Dim numFarms As Integer = GetTotalFarms()
        Dim total_cost As Double = 0

        Dim currentFarm As Farm
        Dim index As Integer

        For index = 0 To numFarms - 1
            currentFarm = Farm(index)
            If (currentFarm.GetFarmTypeEnum() = EnumCollection.FarmType.HYDROPONIC) Then
                total_cost += currentFarm.Cost
            End If
        Next

        Return total_cost
    End Function


    'Fulfilled Food Quota
    Public Function GetFulfilledFoodQuota() As Double
        Dim total_charity_food As Double = 0
        Dim numFarms As Integer = GetTotalFarms()
        Dim index As Integer

        For index = 0 To numFarms - 1
            total_charity_food += Farm(index).GetCharityYield()
        Next

        Return total_charity_food
    End Function

    Public Function GetFulfilledFoodQuotaByTraditional() As Double
        Dim numFarms As Integer = GetTotalFarms()
        Dim total_charity_food As Double = 0

        Dim currentFarm As Farm
        Dim index As Integer

        For index = 0 To numFarms - 1
            currentFarm = Farm(index)
            If (currentFarm.GetFarmTypeEnum() = EnumCollection.FarmType.TRADITIONAL) Then
                total_charity_food += currentFarm.GetCharityYield()
            End If
        Next

        Return total_charity_food
    End Function

    Public Function GetFulfilledFoodQuotaByHydroponic() As Double
        Dim numFarms As Integer = GetTotalFarms()
        Dim total_charity_food As Double = 0

        Dim currentFarm As Farm
        Dim index As Integer

        For index = 0 To numFarms - 1
            currentFarm = Farm(index)
            If (currentFarm.GetFarmTypeEnum() = EnumCollection.FarmType.HYDROPONIC) Then
                total_charity_food += currentFarm.GetCharityYield()
            End If
        Next

        Return total_charity_food
    End Function


    'Number of Farms
    Public Function GetTotalFarms() As Integer
        Return _Farms.Length
    End Function

    Public Function GetTotalTraditionalFarms() As Integer
        Dim numFarms As Integer = GetTotalFarms()
        Dim numTraditionalFarms As Integer = 0

        Dim currentFarm As Farm
        Dim index As Integer

        For index = 0 To numFarms - 1
            currentFarm = Farm(index)
            If (currentFarm.GetFarmTypeEnum() = EnumCollection.FarmType.TRADITIONAL) Then
                numTraditionalFarms += 1
            End If
        Next

        Return numTraditionalFarms
    End Function

    Public Function GetTotalHydroponicFarms() As Integer
        Dim numFarms As Integer = GetTotalFarms()
        Dim numHydroponicFarms As Integer = 0

        Dim currentFarm As Farm
        Dim index As Integer

        For index = 0 To numFarms - 1
            currentFarm = Farm(index)
            If (currentFarm.GetFarmTypeEnum() = EnumCollection.FarmType.HYDROPONIC) Then
                numHydroponicFarms += 1
            End If
        Next

        Return numHydroponicFarms
    End Function


    'Yield of Farms
    Public Function GetTotalYieldOfFarms() As Double
        Dim total_food As Double = 0
        Dim numFarms As Integer = GetTotalFarms()
        Dim index As Integer

        For index = 0 To numFarms - 1
            total_food += Farm(index).Yield
        Next

        Return total_food
    End Function

    Public Function GetTotalYieldOfTraditionalFarms() As Double
        Dim numFarms As Integer = GetTotalFarms()
        Dim total_food As Double = 0

        Dim currentFarm As Farm
        Dim index As Integer

        For index = 0 To numFarms - 1
            currentFarm = Farm(index)
            If (currentFarm.GetFarmTypeEnum() = EnumCollection.FarmType.TRADITIONAL) Then
                total_food += currentFarm.Yield
            End If
        Next

        Return total_food
    End Function

    Public Function GetTotalYieldHydroponicFarms() As Double
        Dim numFarms As Integer = GetTotalFarms()
        Dim total_food As Double = 0

        Dim currentFarm As Farm
        Dim index As Integer

        For index = 0 To numFarms - 1
            currentFarm = Farm(index)
            If (currentFarm.GetFarmTypeEnum() = EnumCollection.FarmType.HYDROPONIC) Then
                total_food += currentFarm.Yield
            End If
        Next

        Return total_food
    End Function


    'Size of Farms
    Public Function GetTotalSizeOfFarms() As Double
        Dim total_size As Double = 0
        Dim numFarms As Integer = GetTotalFarms()
        Dim index As Integer

        For index = 0 To numFarms - 1
            total_size += Farm(index).Size
        Next

        Return total_size
    End Function

    Public Function GetTotalSizeOfTraditionalFarms() As Double
        Dim numFarms As Integer = GetTotalFarms()
        Dim total_size As Double = 0

        Dim currentFarm As Farm
        Dim index As Integer

        For index = 0 To numFarms - 1
            currentFarm = Farm(index)
            If (currentFarm.GetFarmTypeEnum() = EnumCollection.FarmType.TRADITIONAL) Then
                total_size += currentFarm.Size
            End If
        Next

        Return total_size
    End Function

    Public Function GetTotalSizeHydroponicFarms() As Double
        Dim numFarms As Integer = GetTotalFarms()
        Dim total_size As Double = 0

        Dim currentFarm As Farm
        Dim index As Integer

        For index = 0 To numFarms - 1
            currentFarm = Farm(index)
            If (currentFarm.GetFarmTypeEnum() = EnumCollection.FarmType.HYDROPONIC) Then
                total_size += currentFarm.Size
            End If
        Next

        Return total_size
    End Function


    'Clone a Seperate Farm Array
    Private Function GetTraditionalFarms() As Farm()
        Dim numFarms As Integer = GetTotalFarms()
        Dim numTraditionalFarms As Integer = GetTotalTraditionalFarms()

        Dim traditionalFarms(numTraditionalFarms) As Farm
        Dim currentFarm As Farm

        Dim traditional_index As Integer = 0
        Dim general_index As Integer

        For general_index = 0 To numFarms - 1
            currentFarm = Farm(general_index)
            If (currentFarm.GetFarmTypeEnum() = EnumCollection.FarmType.TRADITIONAL) Then
                traditionalFarms(traditional_index) = currentFarm
                traditional_index = traditional_index + 1
            End If
        Next

        Return traditionalFarms
    End Function

    Private Function GetHydroponicFarms() As Farm()
        Dim numFarms As Integer = GetTotalFarms()
        Dim numHydroponicFarms As Integer = GetTotalTraditionalFarms()

        Dim hydroponicFarms(numHydroponicFarms) As Farm
        Dim currentFarm As Farm

        Dim hydroponic_index As Integer = 0
        Dim general_index As Integer

        For general_index = 0 To numFarms - 1
            currentFarm = Farm(general_index)
            If (currentFarm.GetFarmTypeEnum() = EnumCollection.FarmType.HYDROPONIC) Then
                hydroponicFarms(hydroponic_index) = currentFarm
                hydroponic_index = hydroponic_index + 1
            End If
        Next

        Return hydroponicFarms
    End Function


    'Calculation
    Private Function CalculateFarmsToConstruct() As Farm()
        Throw New NotImplementedException()
    End Function

    Public Function GenerateFoodRestrictedProposal() As Proposal
        Throw New NotImplementedException()
    End Function





End Class
