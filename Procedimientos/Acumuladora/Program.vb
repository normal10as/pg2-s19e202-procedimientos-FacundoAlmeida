Imports System

Module Program
    Private suma, acumulador As Single

    Sub Main(args As String())

        Console.WriteLine("Ingrese un numero ")
        acumulador = Console.ReadLine()
        Acumular()
        Console.WriteLine("El valor acumulado es: " & suma)
        Acumular()
        Console.WriteLine("El valor acumulado es: " & suma)
        Acumular()
        Console.WriteLine("Total de suma: " & suma)
    End Sub
    Sub Acumular()
        suma = suma + acumulador

    End Sub
End Module
