Option Strict On
Option Explicit On

'Taylor Herndon
'RCET0265
'Spring 2021
'Roll of the Dice
'https://github.com/TaylorHerndon/Roll-of-the-Dice


Module RollOfTheDice

    Sub Main()

        Randomize()

        Dim rollA As Integer = Nothing
        Dim rollB As Integer = Nothing
        Dim result As Integer = Nothing
        Dim logRoll(999) As Integer
        Dim rollRecursions(12) As Integer

        'Make two rolls, add them together, and log the result
        For i = 0 To 999
            rollA = CInt(Math.Ceiling(VBMath.Rnd * 6))
            rollB = CInt(Math.Ceiling(VBMath.Rnd * 6))

            result = rollA + rollB

            logRoll(i) = result
        Next

        'Go through the log and count and index how many times each number occoured
        For i = 0 To 999

            Select Case logRoll(i)
                Case 2
                    rollRecursions(2) = rollRecursions(2) + 1
                Case 3
                    rollRecursions(3) = rollRecursions(3) + 1
                Case 4
                    rollRecursions(4) = rollRecursions(4) + 1
                Case 5
                    rollRecursions(5) = rollRecursions(5) + 1
                Case 6
                    rollRecursions(6) = rollRecursions(6) + 1
                Case 7
                    rollRecursions(7) = rollRecursions(7) + 1
                Case 8
                    rollRecursions(8) = rollRecursions(8) + 1
                Case 9
                    rollRecursions(9) = rollRecursions(9) + 1
                Case 10
                    rollRecursions(10) = rollRecursions(10) + 1
                Case 11
                    rollRecursions(11) = rollRecursions(11) + 1
                Case 12
                    rollRecursions(12) = rollRecursions(12) + 1
            End Select

        Next

        'Write out the header and the results from the RollRecursions array
        Console.WriteLine("                           Roll of the Dice                        ")
        Console.WriteLine(StrDup(67, "-"))
        Console.WriteLine("|  2  |  3  |  4  |  5  |  6  |  7  |  8  |  9  |  10 |  11 |  12 |")
        Console.WriteLine(StrDup(67, "-"))

        For i = 2 To 12
            Console.Write("|" & rollRecursions(i).ToString.PadLeft(4) & " ")
        Next

        Console.WriteLine("|" & vbNewLine & StrDup(67, "-"))

        Console.WriteLine(vbNewLine & "[Press any key to exit]")
        Console.ReadKey()

    End Sub

End Module
