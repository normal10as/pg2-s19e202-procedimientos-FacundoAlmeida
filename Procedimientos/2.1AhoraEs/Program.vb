Imports System
Imports System.DateTime

Module AhoraEs

    Sub Main(args As String())
        Fecha_actual()
        Console.WriteLine(ObtenerHora())


    End Sub
    Sub Fecha_actual()
        Console.WriteLine("La fecha es: " & Now.Date)

    End Sub

    Function ObtenerHora() As String
        Return Now.Hour & ":" & Now.Minute 'la funcion devuelve solo 1 valor
    End Function
End Module
