Imports System
Module Arithmetic_Operator
    Sub Main()
        'Declare a, b And c as integer Data Type()  
        Dim a, b, c As Integer
        Dim d As Single
        a = 17
        b = 4
        ' Use of + Operator  
        c = a + b
        Console.WriteLine(" Sum of a + b is {0}", c)

        'Use of - Operator  
        c = a - b
        Console.WriteLine(" Subtraction of a - b is {0}", c)

        'Use of * Operator  
        c = a * b
        Console.WriteLine(" Multiplication of a * b is {0}", c)

        'Use of / Operator  
        d = a / b
        Console.WriteLine(" Division of a / b is {0}", d)

        'Use of \ Operator  
        c = a \ b
        Console.WriteLine(" Similar to division Operator (return only integer value) of a - b is {0}", c)

        'Use of Mod Operator  
        c = a Mod b
        Console.WriteLine(" Modulus of a Mod b is {0}", c)

        'Use of ^ Operator  
        c = a ^ b
        Console.WriteLine(" Power of a ^ b is {0}", c)
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
