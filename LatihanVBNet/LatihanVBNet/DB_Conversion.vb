'Option Strict On
Module DB_Conversion
    Sub Main()
        'defining the Data type conversion  
        Dim dblData As Double
        dblData = 5.78
        Dim A, B As Char
        Dim bool As Boolean = True
        Dim x, Z, B_int As Integer
        A = "A"
        B = "B"
        B_int = AscW(B)

        Console.WriteLine(" Ascii value of B is {0}", B_int)

        x = 1
        Z = AscW(A)
        Z = Z + x
        Console.WriteLine("String to integer {0}", Z)
        Console.WriteLine("Boolean value is : {0}", CStr(bool))
        Dim num, intData As Integer

        num = CInt(dblData)
        intData = CType(dblData, Integer)
        Console.WriteLine(" Explicit conversion of Data type " & Str(intData))
        Console.WriteLine(" Value of Double is: {0}", dblData)
        Console.WriteLine("Double to Integer: {0}", num)
        Console.ReadKey()
    End Sub
End Module