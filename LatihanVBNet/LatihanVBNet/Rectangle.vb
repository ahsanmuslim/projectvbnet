Module Rectangle
    Public Length As Integer

    Public Breadth As Integer
    Public Sub Dimension()
        Length = 5
        Breadth = 6
    End Sub
    Public Function Area() As Integer
        Area = Length * Breadth
    End Function
    Public Function Pera() As Integer
        Pera = 2 * (Length + Breadth)
    End Function
    Public Sub Display()
        Console.WriteLine(" Length is: {0}", Length)
        Console.WriteLine("Breadth is: {0}", Breadth)
        Console.WriteLine(" Area of Rectangle is: {0}", Area())
        Console.WriteLine(" Perimeter of Rectangle is: {0}", Pera())
    End Sub
    Sub Main()
        'Dimension() ' directly call the function in main method  
        'Area()
        'Pera()  ' directly call the function in main method  
        'Display()
        'Console.WriteLine("Press any key to exit...")
        'Console.ReadKey()

        'Arithmetic_Operator.Main()
        'DB_Conversion.Main()
        'Misc_Operator.Main()
        Operation.main()

    End Sub
End Module
