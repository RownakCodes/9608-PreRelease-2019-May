Module Module1

    Sub Main()

        Dim store(10000), name, email As String
        Dim StNum As Integer

        Console.WriteLine("What is the number of students? ")
        StNum = Console.ReadLine

        Console.WriteLine("")
        Console.WriteLine("")

        For stindex = 0 To StNum - 1
            Console.Write("Enter the name of the Student: ")
            name = Console.ReadLine()

            Console.Write("Enter the email of the Student: ")
            email = Console.ReadLine()

            Console.WriteLine("")
            Console.WriteLine("")

            store(stindex) = name + "#" + email
        Next
        Console.Clear()
        PrintRecords(store, StNum)
        DeleteRecords(store, StNum)


    End Sub





    Sub DeleteRecords(ByRef store() As String, ByVal StNum As Integer)
        Dim leave, checker, StName, StEmail As String
        Console.Clear()
        For x = 1 To StNum
            Console.WriteLine("Did anyone leave this class? (Yes or No)")
            leave = Console.ReadLine()

            If (leave = "Yes") Then
                Console.WriteLine("Enter the name of the student who left: ")
                StName = Console.ReadLine()

                Console.WriteLine("Enter the email of the student who left: ")
                StEmail = Console.ReadLine()


                Console.WriteLine("")
                Console.WriteLine("")

                checker = StName + "#" + StEmail

                For index = 0 To StNum - 1
                    If (checker = store(index)) Then
                        store(index) = "NULL"
                    Else

                        x = x - 1
                        Console.WriteLine("it didn't match, please try again: ")
                    End If
                Next
            Else
                Exit For
            End If
            Console.Clear()
            PrintRecords(store, StNum)
        Next


    End Sub







    Sub PrintRecords(ByRef store() As String, StNum As Integer)
        Dim spaces As Integer
        Dim content, letter, addname, addemail As String

        Console.Write("Name")
        Console.Write("                    ") ' 20 spaces
        Console.WriteLine("Contents")
        addname = ""




        For printIndex = 0 To StNum
            addemail = ""
            addname = ""
            content = store(printIndex)

            If (content <> "NULL") Then
                For hashfinder = 0 To Len(content) - 1
                    letter = content(hashfinder)
                    If (letter = "#") Then
                        addemail = Mid(content, hashfinder + 2, Len(content))
                        spaces = Len(store(printIndex))
                        Console.Write(addname)
                        For printspaces = 1 To (24 - Len(addname))
                            Console.Write(" ")
                        Next
                        Console.WriteLine(addemail)
                        Exit For
                    Else
                        addname = addname + letter
                    End If

                Next
            End If



        Next

    End Sub

End Module
