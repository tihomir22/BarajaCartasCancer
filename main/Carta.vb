Public Class Carta

    Dim numero As Integer
    Dim palo As String

    Public Sub New()
        Me.numero = generarNumero()
        Me.palo = generarPaloAleatorio()
    End Sub

    Function generarNumero()
        Dim numAle As Integer = Int((12 * Rnd()) + 1)
        While numAle = 8 Or numAle = 9
            numAle = Int((12 * Rnd()) + 1)
        End While
        Return numAle
    End Function
    Function generarPaloAleatorio()
        Dim numAle As Integer = Int((3 * Rnd()) + 0)
        Dim listaPalos As New List(Of String)
        listaPalos.Add("ESPADAS")
        listaPalos.Add("BASTOS")
        listaPalos.Add("OROS")
        listaPalos.Add("COPAS")

        Return listaPalos(numAle)

    End Function

    Function toString()
        Return Me.numero & " " & Me.palo
    End Function

End Class
