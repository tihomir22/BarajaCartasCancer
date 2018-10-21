Imports main

Public Class Baraja
    Private listaCartas As List(Of Carta)
    Private contadorCartaSiguiente As Integer = 0

    Public Sub New(listaCartas As List(Of Carta))
        Me.listaCartas = listaCartas
    End Sub

    Public Function lenght()
        Return Me.listaCartas.Count
    End Function

    Public Sub barajar()
        For indice As Integer = 0 To Me.lenght() - 1
            Dim numAle As Integer = Int((40 * Rnd()) + 0)
            Dim carta As Carta = Me.listaCartas(indice)
            Me.listaCartas(indice) = Me.listaCartas(numAle)
            Me.listaCartas(numAle) = carta

        Next

        Console.WriteLine("Intercambiadas con exito")
        Console.ReadLine()

    End Sub

    Public Function siguienteCarta()
        If contadorCartaSiguiente = 39 Then
            Console.WriteLine("Se han terminado las cartas")
        Else
            Dim carta As Carta = Me.listaCartas(contadorCartaSiguiente)
            contadorCartaSiguiente = contadorCartaSiguiente + 1
            Return carta

        End If
    End Function

    Public Sub imprimirCartas()
        For indice As Integer = 0 To Me.lenght() - 1
            Console.WriteLine(Me.listaCartas(indice).toString())
        Next
    End Sub

    Public Function numeroDeCartasReparticles()
        If Me.lenght - Me.contadorCartaSiguiente >= 0 Then
            Return (Me.lenght - Me.contadorCartaSiguiente)
        Else
            Return 0
        End If

    End Function

    Function darCartas(ByRef num As Integer)
        Dim cartasRestantes As Integer = Me.numeroDeCartasReparticles()
        Dim listaDevolucionCartas As New List(Of Carta)
        If num < cartasRestantes Then
            While num > 0
                listaDevolucionCartas.Add(Me.siguienteCarta())

                num = num - 1

            End While
            Return listaDevolucionCartas
        Else
            Console.WriteLine("No quedan tantas cartas como quieres puto")
            Return listaDevolucionCartas
        End If
    End Function

    Function CartasMonton()
        If Me.contadorCartaSiguiente = 0 Then
            Console.WriteLine("Aun no ha salido ninguna carta...")
        Else
            Console.WriteLine("Cartas que han salido...")
            For indice As Integer = 0 To Me.contadorCartaSiguiente
                Dim carta As Carta = Me.listaCartas(indice)
                Console.WriteLine(carta.toString())

            Next
        End If
    End Function

    Function mostrarMonton()
        Console.WriteLine("Cartas que no han salido...")
        For indice As Integer = Me.contadorCartaSiguiente To Me.lenght() - 1
            Dim carta As Carta = Me.listaCartas(indice)
            Console.WriteLine(carta.toString())
        Next

    End Function

End Class
