Imports System
'PARA NUMEROS DECIMAL UTILIZAR COMA
Module VolumenCilindro
    Public Const Pi As Single = 3.14159265
    Public R As Single
    Public H As Single
    Public V As Single
    Sub Main(args As String())
        Console.WriteLine("Ingrese el radio de la base: ")
        R = Console.ReadLine()
        Console.WriteLine("Ingrese la altura: ")
        H = Console.ReadLine()

        Console.WriteLine("El volumen del cilindro es: " & Resultado_cilindro() & " Metros cubicos")


    End Sub
    Function Resultado_cilindro() As Single
        V = (Pi * (R * R)) * H
        Return V
    End Function
End Module
