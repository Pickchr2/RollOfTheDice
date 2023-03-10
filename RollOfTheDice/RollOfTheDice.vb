'Christopher Pickens
'RCET0265
'Spring 2023
'Roll of the Dice
'https://github.com/Pickchr2/RollOfTheDice.git

Option Compare Text
Option Explicit On
Option Strict On

Imports System

Module RollOfTheDice
    Sub Main(args As String())
        Dim userInput As String
        Dim rollCount As Integer
        Dim quitFlag = False
        Dim randomNumber As New Random()

        Do Until quitFlag
            Dim resultCounter(11) As Integer

            Console.WriteLine("Enter a whole number between 1,000 and 1,000,000 to roll two 6-sided dice that number of times.")
            Console.WriteLine("Press " & Chr(34) & "C" & Chr(34) & " to clear results, or " & Chr(34) & "Q" & Chr(34) & " to quit at anytime.")
            userInput = Console.ReadLine()
            Console.WriteLine()

            Select Case userInput

                Case "Q"
                    quitFlag = True
                Case "C"
                    Console.Clear()
                Case Else
                    Try
                        rollCount = CInt(userInput)

                        If rollCount >= 1000 And rollCount <= 1000000 Then
                            Console.WriteLine($"Two Six-Sided dice have been rolled {rollCount} times. Here are the results.")
                            Console.WriteLine("-----------------------------------------------------------------------------")
                            For i As Integer = 1 To rollCount

                                resultCounter(CInt(randomNumber.Next(0, 11))) += 1

                            Next

                            For j As Integer = 2 To 12
                                Console.Write(CStr(j).PadLeft(6) & "|")
                            Next
                            Console.WriteLine()
                            Console.WriteLine("-----------------------------------------------------------------------------")
                            For k As Integer = 0 To 10
                                Console.Write(CStr(resultCounter(k)).PadLeft(6) & "|")
                            Next
                            Console.WriteLine()
                            Console.WriteLine("-----------------------------------------------------------------------------")
                        Else
                            Console.WriteLine($"Sorry, {rollCount} is out of range of acceptable numbers.")
                        End If
                    Catch ex As Exception
                        Console.WriteLine($"Sorry, {userInput} is not a whole number.")
                    End Try


            End Select
            Console.WriteLine()
            Console.WriteLine()
        Loop
    End Sub
End Module
