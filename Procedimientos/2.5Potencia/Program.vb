Imports System

Module Program

    Sub Main(args As String())
        Dim valor_1 As Single
        Console.WriteLine("Ingrese un numero: ")
        valor_1 = Console.ReadLine()
        Console.WriteLine("Resultado: " & Potenciacion(valor_1))
    End Sub

    Function Potenciacion(valor_1)
        Dim resul_1, resul_2, resul_3 As Single
        resul_1 = valor_1 ^ 2
        resul_2 = valor_1 ^ 3
        resul_3 = valor_1 ^ 5

        Return (resul_1 & ", " & resul_2 & ", " & resul_3 & ".")
    End Function
End Module
