Imports System
Imports System.Math
'PARA NUMEROS DECIMAL UTILIZAR COMA
Module VolumenCilindro

    Sub Main(args As String())
        Const PI As Single = 3.14159265
        Dim R, H As Single
        Console.WriteLine("Ingrese el radio de la base: ")
        R = Console.ReadLine()
        Console.WriteLine("Ingrese la altura: ")
        H = Console.ReadLine()

        Console.WriteLine("El volumen del cilindro es: " & Resultado_cilindro(R, H, PI) & " Metros cubicos")


    End Sub
    Function Resultado_cilindro(R, H, PI) As Single
        Dim V As Single
        V = (PI * Pow(R, 2)) * H
        Return V
    End Function
End Module
