Module Module1

    Sub Main()
        Dim cantidadHoras As Integer
        Dim minutos As Decimal
        Dim segundos As Decimal
        Dim dias As Integer

        Console.Write("INGRESE CANTIDAD DE HORAS: ")
        cantidadHoras = Console.ReadLine()

        minutos = cantidadHoras * 60
        Console.WriteLine("Minutos: " & minutos)
        segundos = minutos * 60
        Console.WriteLine("Segundos: " & segundos)
        dias = cantidadHoras * 0.041666
        Console.WriteLine("Dias: " & dias)
        Console.ReadLine()



    End Sub

End Module
