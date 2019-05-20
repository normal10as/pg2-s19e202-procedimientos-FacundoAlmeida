Module prueba
    Public acumulador, suma As Single
    Sub Main()
        Dim x As Single
        For x = 0 To 3
            Console.WriteLine("Ingrese un numero ")
            acumulador = Console.ReadLine()
            NumerosAcumulados(acumulador)

        Next

    End Sub
    Sub NumerosAcumulados(acumulador)
        Dim suma As Single
        'suma = acumulador
        acumulador = acumulador + suma
        Console.WriteLine("suma: " & acumulador)

    End Sub
End Module
