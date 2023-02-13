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
        Dim resultCounter(11) As Integer
        Dim quitFlag = False
        Dim randomNumber As New Random()

        Do Until quitFlag
            'Console.Clear()
            Console.WriteLine("Enter a whole number to roll two 6-sided dice that number of times.")
            Console.WriteLine("Press " & Chr(34) & "Q" & Chr(34) & " at anytime to quit.")
            userInput = Console.ReadLine()

            Select Case userInput

                Case "Q"
                    quitFlag = True
                Case Else
                    Try
                        rollCount = CInt(userInput)

                        For i As Integer = 1 To rollCount

                            resultCounter(CInt(randomNumber.Next(2, 12))) += 1

                        Next
                    Catch ex As Exception
                        Console.WriteLine($"Sorry, {userInput} is not a whole number.")
                    End Try
            End Select

        Loop
    End Sub
End Module
