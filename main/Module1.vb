Module Module1

    Sub Main()
        Dim baraja As Baraja = New Baraja(darDeAltaCartasDeEjemplo())
        Console.WriteLine(baraja.lenght)
        Console.ReadLine()

        baraja.barajar()
        baraja.imprimirCartas()
        Console.ReadLine()

        Dim carta As Carta = baraja.siguienteCarta()
        Console.WriteLine("La siguiente carta es " & carta.toString())
        Console.ReadLine()

        Console.WriteLine("Aun quedar " & baraja.numeroDeCartasReparticles() & " cartas por repartir")
        Console.ReadLine()

        Dim listaCartasDevueltas As New List(Of Carta)
        listaCartasDevueltas = baraja.darCartas(5)

        For Each carta In listaCartasDevueltas
            Console.WriteLine(carta.toString())
        Next
        Console.WriteLine("Aun quedar " & baraja.numeroDeCartasReparticles() & " cartas por repartir")
        Console.ReadLine()

        baraja.CartasMonton()
        Console.ReadLine()

        baraja.mostrarMonton()
        Console.ReadLine()


    End Sub

    Function darDeAltaCartasDeEjemplo()
        Dim i As Int64 = 0
        Dim listaCartas As New List(Of Carta)

        While i < 40
            Dim carta1 As Carta = New Carta()
            Console.WriteLine("Dado con exito de alta " & carta1.toString())
            listaCartas.Add(carta1)
            i = i + 1
        End While
        Console.WriteLine(listaCartas.Count & " dadas con exito")
        Return listaCartas
    End Function



End Module
