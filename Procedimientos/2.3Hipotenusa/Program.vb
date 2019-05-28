Imports System
Imports System.Math

Module Hipotenusa
    Sub Main(args As String())
        Dim a, b As Single

        Console.WriteLine("Ingrese el lado A: ")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese lado B: ")
        b = Console.ReadLine()
        Console.WriteLine("El resultado de los lado C es: " & Resultado(a, b))

    End Sub

    Function Resultado(a, b) As Single
        Dim c As Single
        c = Sqrt(Pow(a, 2) + Pow(b, 2))
        Return c
    End Function
End Module
