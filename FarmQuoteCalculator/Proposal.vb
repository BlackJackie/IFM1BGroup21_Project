Option Strict On
Option Explicit On
Option Infer Off
' *****************************************************************
' Team Number: 21
' Team Member 1 Details: Ntsie, KC (220061693)
' Team Member 2 Details: Nchaupa, F (200915560)
' Team Member 3 Details: Jansen, JNJ (217040076)
' Team Member 4 Details: Smit, K (201572532)
' Practical: Team Project
' Class name: Proposal
' *****************************************************************

Imports System.Security

<Serializable()> Public Class Proposal
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
        Return Format(Now, "yyyyMMddHHmmssff")
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
            total_charity_food += Farm(index).Yield
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


    'Calculations
    Public Function GenerateFoodRestrictedProposal() As Proposal
        Dim new_proposal As New Proposal(_Region, False)
        Return new_proposal
    End Function

    Public Function GenerateBudgetRestrictedProposal() As Proposal
        Dim new_proposal As New Proposal(_Region, True)
        Return new_proposal
    End Function

    Private Function removePlotFromArray(ByRef plots As Plot(), ByVal index As Integer) As Plot()
        Dim new_max_index As Integer = plots.Length - 2
        Dim old_max_index As Integer = plots.Length - 1
        Dim new_plots(new_max_index) As Plot

        Dim i_old As Integer
        Dim i_new As Integer = 0

        For i_old = 0 To old_max_index
            If Not (i_old = index) Then
                new_plots(i_new) = plots(i_old)
                i_new += 1
            End If
        Next

        Return new_plots
    End Function

    Private Function CalculateFarmsToConstruct() As Farm()
        Console.WriteLine("Starting calculation...")
        Dim farms() As Farm
        Dim limit_left As Double

        If (_IsBudgetRestricted) Then
            limit_left = _Region.Budget
            Console.WriteLine("is budget restricted")
        Else
            limit_left = _Region.CalculateFoodQuota()
            Console.WriteLine("is food restricted")
        End If

        Dim plots() As Plot = _Region.clonePlots()
        Dim land_left As Boolean = True

        Dim high_value_land_left As Boolean = True
        Dim medium_value_land_left As Boolean = True
        Dim low_value_land_left As Boolean = True

        'First - populate TRADITIONAL farms on high value land
        Console.WriteLine("...Calculating traditional farms on high value land")
        While (limit_left > 0) And (high_value_land_left)
            Dim i As Integer
            Dim land_found As Boolean = False

            For i = 0 To (plots.Length - 1)
                If ((plots(i).FertilityRating = EnumCollection.Rating.HIGH) And (plots(i).WaterRating = EnumCollection.Rating.HIGH)) Then

                    land_found = True
                    Dim farm As Farm = New TraditionalFarm(plots(i), limit_left, _IsBudgetRestricted)
                    plots = removePlotFromArray(plots, i)
                    addFarmToFarmArray(farms, farm)

                    If (_IsBudgetRestricted) Then
                        limit_left -= farm.Cost
                    Else
                        limit_left -= farm.Yield
                    End If
                    Exit For
                End If
            Next

            Console.WriteLine("......limit left = " & CStr(limit_left))

            If Not (land_found) Then
                high_value_land_left = False
                Console.WriteLine("......No more high value land")
            End If

        End While

        'Second - If budget left, populate TRADITIONAL farms to medium value land
        If (limit_left > 0) Then
            Console.WriteLine("...Calculating traditional farms on medium value land")
            While (limit_left > 0) And (medium_value_land_left)
                Dim i As Integer
                Dim land_found As Boolean = False

                For i = 0 To (plots.Length - 1)
                    If ((plots(i).FertilityRating = EnumCollection.Rating.HIGH) And (plots(i).WaterRating = EnumCollection.Rating.LOW)) Or
                        ((plots(i).FertilityRating = EnumCollection.Rating.LOW) And (plots(i).WaterRating = EnumCollection.Rating.HIGH)) Then

                        land_found = True
                        Dim farm As Farm = New TraditionalFarm(plots(i), limit_left, _IsBudgetRestricted)
                        plots = removePlotFromArray(plots, i)
                        addFarmToFarmArray(farms, farm)

                        If (_IsBudgetRestricted) Then
                            limit_left -= farm.Cost
                        Else
                            limit_left -= farm.Yield
                        End If

                        Exit For
                    End If
                Next

                Console.WriteLine("......limit left = " & CStr(limit_left))

                If Not (land_found) Then
                    medium_value_land_left = False
                    Console.WriteLine("......No more medium value land")
                End If

            End While

            'Third - If budget left, populate HYDROPONICS farms to low value land
            If (limit_left > 0) Then
                Console.WriteLine("...Calculating hydroponic farms on low value land")
                While (limit_left > 0) And (low_value_land_left)
                    Dim i As Integer
                    Dim land_found As Boolean = False

                    For i = 0 To (plots.Length - 1)
                        If ((plots(i).FertilityRating = EnumCollection.Rating.LOW) And (plots(i).WaterRating = EnumCollection.Rating.LOW)) Then

                            land_found = True
                            Dim farm As Farm = New HydroponicFarm(plots(i), limit_left, _IsBudgetRestricted)
                            plots = removePlotFromArray(plots, i)
                            addFarmToFarmArray(farms, farm)

                            If (_IsBudgetRestricted) Then
                                limit_left -= farm.Cost
                            Else
                                limit_left -= farm.Yield
                            End If

                            Exit For
                        End If
                    Next

                    Console.WriteLine("......limit left = " & CStr(limit_left))

                    If Not (land_found) Then
                        low_value_land_left = False
                        Console.WriteLine("......No more low value land")
                    End If

                End While


            Else
                'Since there is no more budget left
                Return farms
            End If

        Else
            'Since there is no more budget left
            Return farms
        End If

        'Have budget left but no more land
        'TODO - Optimise medium value farm with hydroponics
        Return farms



        'Throw New NotImplementedException()
    End Function


    Private Sub addFarmToFarmArray(ByRef farm_array As Farm(), farm As Farm)
        If IsNothing(farm_array) Then
            ReDim farm_array(0)
            farm_array(0) = farm
        Else
            Dim index As Integer = farm_array.Length
            ReDim Preserve farm_array(index)
            farm_array(index) = farm
        End If
    End Sub





End Class
