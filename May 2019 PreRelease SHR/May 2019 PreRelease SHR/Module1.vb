Module Module1


    Dim store(10000), name, email As String
    Dim StNum As Integer

    Sub Main()

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

        search()
    End Sub


    '===================================================================================================================
    Sub search()

        Dim searchname, content, result As String

        Console.Clear()
        Console.WriteLine("Enter the name or a part of it of the one you want to find")
        searchname = Console.ReadLine()

        Console.Write("Name")
        Console.Write("                    ") ' 20 spaces
        Console.WriteLine("Contents")

        For searchindex = 0 To StNum - 1
            content = store(searchindex)

            For position = 1 To Len(content) + 1
                result = Mid(content, position, Len(searchname))

                If (result = searchname) Then
                    Print(content)
                    Exit For
                End If

            Next

        Next

    End Sub


    Sub DeleteRecords(ByRef store() As String, ByVal StNum As Integer)
        Dim leave, checker, StName, StEmail As String
        Console.Clear()
        For x = 1 To StNum
            Console.WriteLine("Did anyone leave this class? (Yes or No)")
            leave = Console.ReadLine()

            Console.WriteLine("")
            Console.WriteLine("")
            If (leave = "Yes") Then
                Console.WriteLine("Enter the name of the student who left: ")
                StName = Console.ReadLine()

                Console.WriteLine("")
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


    Sub Print(ByVal content As String)

        Dim spaces As Integer
        Dim letter, addname, addemail As String


        addname = ""



        For hashfinder = 0 To Len(content) - 1
            letter = content(hashfinder)
            If (letter = "#") Then
                addemail = Mid(content, hashfinder + 2, Len(content))
                spaces = Len(content)
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
    End Sub


End Module
