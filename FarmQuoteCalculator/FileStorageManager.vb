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

    Private Const _fileName As String = "quotes.txt"

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
        Dim size As Integer = 0

        _FS = New FileStream(_fileName, FileMode.Open, FileAccess.Read)
        _BF = New BinaryFormatter()

        While _FS.Position < _FS.Length
            Dim temp_proposal As Proposal
            temp_proposal = DirectCast(_BF.Deserialize(_FS), Proposal)
            size += 1
            ReDim Preserve proposals(size)
            proposals(size - 1) = temp_proposal
        End While

        _FS.Close()

        Return proposals
    End Function

    Public Sub SaveQuote(proposal As Proposal)
        Dim proposals() As Proposal = LoadQuotes()
        Dim size As Integer = proposals.Length + 1
        ReDim Preserve proposals(size)
        proposals(size - 1) = proposal

        _FS = New FileStream(_fileName, FileMode.Create, FileAccess.Write)
        _BF = New BinaryFormatter()

        Dim index As Integer
        For index = 0 To size - 1
            _BF.Serialize(_FS, proposals(index))
        Next

        _FS.Close()
    End Sub

End Class
