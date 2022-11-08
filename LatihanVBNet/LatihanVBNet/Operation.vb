Imports System
Module Operation
    Sub main()
        'declaration of the variables  
        Dim num1, num2, sum As Integer
        Dim def As Char
        'initialization of num1 and num2 variable  
        num1 = 2
        num2 = 6
        Console.WriteLine(" Want to perform any operation?")
        Console.WriteLine(" A for Addition")
        Console.WriteLine(" S for Subtraction")
        Console.WriteLine(" M for Multiplication")
        Console.WriteLine(" D for Division")
        Console.WriteLine(" Please enter any input")
        def = Console.ReadLine()
        Select Case def
            Case "A"
                'perform Addition  
                sum = num1 + num2
                Console.WriteLine(" Addition of two number is :{0}", sum)
            Case "S"
                'perform Subtraction  
                sum = num2 - num1
                Console.WriteLine(" Subtraction of two number is :{0}", sum)
            Case "M"
                'perform Multiplication  
                sum = num1 * num2
                Console.WriteLine(" Multiplication of two number is :{0}", sum)
            Case "D"
                'Peform Division  
                sum = num2 / num1
                Console.WriteLine(" Division of two number is :{0}", sum)
            Case Else
                'If none of the operation matched, call default statement  
                Console.WriteLine(" Please enter only define operation With Capital letter")
        End Select
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
