Imports System

Module Program
    Public suma, acumulador As Single

    Sub Main(args As String())

        Console.WriteLine("Ingrese un numero ")
        acumulador = Console.ReadLine()
        Acumular()
        Console.WriteLine("El valor acumulado es: " & suma)

        Console.WriteLine("Ingrese otro numero ")
        acumulador = Console.ReadLine()
        Acumular()
        Console.WriteLine("El valor acumulado es: " & suma)
        Console.WriteLine("Ingrese otro numero ")
        acumulador = Console.ReadLine()
        Acumular()
        Console.WriteLine("Total de suma: " & suma)
    End Sub
    Sub Acumular()
        suma = suma + acumulador

    End Sub
End Module
