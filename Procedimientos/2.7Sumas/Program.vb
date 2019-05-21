Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Resultado de la suma con 2 numeros: " & Suma(5, 8))
        Console.WriteLine("El resultado de sumar 3 numeros: " & Suma(5, 8, 5))
        Console.WriteLine("El resultado de sumar 4 numeros: " & Suma(5, 8, 5, 8))

        Console.WriteLine("Hello World!")
    End Sub
    Function Suma(suma_1 As Single, suma_2 As Single)
        Return suma_1 + suma_2
    End Function
    Function Suma(suma_1 As Single, suma_2 As Single, suma_3 As Single)
        Return suma_1 + suma_2 + suma_3
    End Function
    Function Suma(suma_1 As Single, suma_2 As Single, suma_3 As Single, suma_4 As Single)
        Return suma_1 + suma_2 + suma_3 + suma_4

    End Function
End Module
