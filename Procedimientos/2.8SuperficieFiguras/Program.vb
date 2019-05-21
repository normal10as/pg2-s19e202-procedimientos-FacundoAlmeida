Imports System

Module Program
    Private lado_1, lado_2, lado_3 As Single
    Private area As Single
    Sub Main(args As String())
        Console.WriteLine("Ingrese primer valor: ")
        lado_1 = Console.ReadLine()
        Console.WriteLine("Ingrese segundo valor: ")
        lado_2 = Console.ReadLine()
        Console.WriteLine("Ingrese tercer valor: ")
        lado_3 = Console.ReadLine()

        Console.WriteLine("El resultado es: " & Figura(lado_1))
        Console.WriteLine("El resultado es: " & Figura(lado_1, lado_2))
        Console.WriteLine("El resultado es: " & Figura(lado_1, lado_2, lado_3))
    End Sub

    Function Figura(lado_1 As Single)
        area = lado_1 * lado_1
        Return area
    End Function
    Function Figura(lado_1 As Single, lado_2 As Single)
        area = (lado_2 * lado_1)
        Return area
    End Function
    Function Figura(lado_1 As Single, lado_2 As Single, lado_3 As Single)
        area = lado_3 * (lado_1 + lado_2) / 2
        Return area
    End Function

End Module
