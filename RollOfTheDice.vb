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

        Dim RollA As Integer = Nothing
        Dim RollB As Integer = Nothing
        Dim Result As Integer = Nothing
        Dim i As Integer = 0
        Dim LogRoll(999) As Integer
        Dim RollRecursions(12) As Integer

        'Make two rolls, add them together, and log the result
        For i = 0 To 999

            Do Until RollA <> 0 And RollB <> 0

                RollA = Convert.ToInt32(VBMath.Rnd * 6)
                RollB = Convert.ToInt32(VBMath.Rnd * 6)

            Loop

            Result = RollA + RollB

            LogRoll(i) = Result

            RollA = 0
            RollB = 0

        Next

        i = 0

        'Go through the log and count and index how many times each number occoured
        For i = 0 To 999

            Select Case LogRoll(i)
                Case 2
                    RollRecursions(2) = RollRecursions(2) + 1
                Case 3
                    RollRecursions(3) = RollRecursions(3) + 1
                Case 4
                    RollRecursions(4) = RollRecursions(4) + 1
                Case 5
                    RollRecursions(5) = RollRecursions(5) + 1
                Case 6
                    RollRecursions(6) = RollRecursions(6) + 1
                Case 7
                    RollRecursions(7) = RollRecursions(7) + 1
                Case 8
                    RollRecursions(8) = RollRecursions(8) + 1
                Case 9
                    RollRecursions(9) = RollRecursions(9) + 1
                Case 10
                    RollRecursions(10) = RollRecursions(10) + 1
                Case 11
                    RollRecursions(11) = RollRecursions(11) + 1
                Case 12
                    RollRecursions(12) = RollRecursions(12) + 1
            End Select

        Next

        'Write out the header and the results from the RollRecursions array

        Console.WriteLine("                           Roll of the Dice                        ")
        Console.WriteLine("-------------------------------------------------------------------")
        Console.WriteLine("|  2  |  3  |  4  |  5  |  6  |  7  |  8  |  9  |  10 |  11 |  12 |")
        Console.WriteLine("-------------------------------------------------------------------")
        Console.Write("|" & RollRecursions(2).ToString.PadLeft(4) & " ")
        Console.Write("|" & RollRecursions(3).ToString.PadLeft(4) & " ")
        Console.Write("|" & RollRecursions(4).ToString.PadLeft(4) & " ")
        Console.Write("|" & RollRecursions(5).ToString.PadLeft(4) & " ")
        Console.Write("|" & RollRecursions(6).ToString.PadLeft(4) & " ")
        Console.Write("|" & RollRecursions(7).ToString.PadLeft(4) & " ")
        Console.Write("|" & RollRecursions(8).ToString.PadLeft(4) & " ")
        Console.Write("|" & RollRecursions(9).ToString.PadLeft(4) & " ")
        Console.Write("|" & RollRecursions(10).ToString.PadLeft(4) & " ")
        Console.Write("|" & RollRecursions(11).ToString.PadLeft(4) & " ")
        Console.WriteLine("|" & RollRecursions(12).ToString.PadLeft(4) & " |")
        Console.WriteLine("-------------------------------------------------------------------")

        Console.WriteLine(vbNewLine & "[Press any key to exit]")
        Console.ReadKey()

    End Sub

End Module
