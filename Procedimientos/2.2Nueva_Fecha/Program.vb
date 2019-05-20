Imports System
Imports System.DateTime


Module Nueva_Fecha
    Public Fecha As Date
    Public DiaASumar As Int16
    Sub Main(args As String())

        Console.WriteLine("Ingrese una fecha(DD/MM/AAAA): ")
        Fecha = Console.ReadLine()
        Console.WriteLine("Ingrese cuantos dias sumar a la fecha ingresada: ")
        DiaASumar = Console.ReadLine()
        Console.WriteLine("fecha sumada: " & Suma_fechas())


    End Sub

    Function Suma_fechas() As Date
        Fecha = Fecha.AddDays(DiaASumar)
        Return Fecha
    End Function
End Module
