' *****************************************************************
' Team Number: 21
' Team Member 1 Details: Ntsie, KC (220061693)
' Team Member 2 Details: Nchaupa, F (200915560)
' Team Member 3 Details: Jansen, JNJ (217040076)
' Team Member 4 Details: Smit, K (201572532)
' Practical: Team Project
' Class name: FileStorageManager
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class FileStorageManager

    Private Const _fileName As String = "data/quotes.txt"

    Private _FS As FileStream
    Private _BF As BinaryFormatter

    Public Sub New()

    End Sub

    Public Sub startFreshFile()
        _FS = New FileStream(_fileName, FileMode.Create, FileAccess.Write)
        _BF = New BinaryFormatter()
        _FS.Close()
    End Sub

    Public Function LoadQuotes() As Proposal()
        Dim proposals() As Proposal
        Dim max_index As Integer = -1

        _FS = New FileStream(_fileName, FileMode.Open, FileAccess.Read)
        _BF = New BinaryFormatter()

        While _FS.Position < _FS.Length
            Dim temp_proposal As Proposal
            temp_proposal = DirectCast(_BF.Deserialize(_FS), Proposal)
            max_index += 1
            ReDim Preserve proposals(max_index)
            proposals(max_index) = temp_proposal
            Console.WriteLine("...Existing quote - " & temp_proposal.QuoteID)
        End While

        _FS.Close()

        Return proposals
    End Function

    Public Sub SaveQuote(proposal As Proposal)
        Console.WriteLine("Loading Quotes")
        Dim proposals() As Proposal = LoadQuotes()
        Dim new_max_index As Integer

        If IsNothing(proposals) Then
            Console.WriteLine("...No existing quotes found")
            ReDim proposals(0)
            proposals(0) = proposal
        Else
            Console.WriteLine("...Appending to existing quotes")
            new_max_index = proposals.Length
            ReDim Preserve proposals(new_max_index)
            proposals(new_max_index) = proposal

        End If

        _FS = New FileStream(_fileName, FileMode.Create, FileAccess.Write)
        _BF = New BinaryFormatter()

        Dim index As Integer
        For index = 0 To new_max_index
            _BF.Serialize(_FS, proposals(index))
            Console.WriteLine("...Serialized quote - " & proposals(index).QuoteID)
        Next

        _FS.Close()
    End Sub

    Public Sub test()
        Console.WriteLine("Saving to file...")
        'Dim fs As New FileStream("data/test_binary.txt", FileMode.Create, FileAccess.Write)
        'Dim bwriter As New BinaryWriter(fs)
        'Dim x As Integer = 40
        'Dim f As Single = 23.45
        'bwriter.Write(x)
        'bwriter.Write(f)
        'bwriter.Close()
        'fs.Close()


        Console.WriteLine("Done")
    End Sub

End Class
