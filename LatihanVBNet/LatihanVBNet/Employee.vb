Public Class Employee
    ' definition of global variables  
    Public name As String
    Public age As Integer
    Public Occupation As String
    Public email As String

    Sub Main()
        ' Create an emp object   
        Dim emp As New Employee
        ' To define the member of an object  
        With emp
            .name = " Mr. Stephen"
            .age = 33
            .Occupation = "Data Analyst"
            .email = "xyz@employee.com"
        End With
        With emp
            ' use emp as a reference  
            Console.WriteLine(" Name is : {0}", .name)
            Console.WriteLine(" Age is : {0}", .age)
            Console.WriteLine(" Occupation is : {0}", .Occupation)
            Console.WriteLine(" Employee Email is : {0}", .email)
        End With
        Console.WriteLine(" Press any key to exit...")
        Console.ReadKey()
    End Sub
End Class
