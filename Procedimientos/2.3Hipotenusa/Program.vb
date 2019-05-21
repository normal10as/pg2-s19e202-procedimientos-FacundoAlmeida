Imports System
Imports System.Math

Module Hipotenusa
    Public A As Single
    Public B As Single
    Public C As Single
    Public D As Single

    Sub Main(args As String())
        Console.WriteLine("Ingrese el lado A: ")
        A = Console.ReadLine()
        Console.WriteLine("Ingrese lado B: ")
        B = Console.ReadLine()

        Console.WriteLine("El resultado de los lado C es: " & Resultado())



    End Sub

    Function Resultado() As Single
        C = Math.Sqrt(A * A + B * B)
        Console.WriteLine("resultado de D " & C)

        Return C
    End Function
End Module
