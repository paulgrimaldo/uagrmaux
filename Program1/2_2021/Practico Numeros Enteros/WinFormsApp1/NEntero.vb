Public Class NEntero
    Private n As Integer

    Public Sub NEntero()
        n = 0
    End Sub

    Public Sub Cargar(nu As Integer)
        n = nu
    End Sub

    Public Function Descargar() As Integer
        Return n
    End Function

    Public Function VerificarPar() As Boolean
        If n Mod 2 = 0 Then
            Return True
        Else
            Return False
        End If

        ' Return ((n mod 2) = 0)
    End Function

    Public Function VerificarImpar() As Boolean
        Return Not VerificarPar()
    End Function

    Public Function VerificarMultiplo(nu As Integer) As Boolean
        Return ((n Mod nu) = 0)
    End Function

    Public Function VerificarSubMultiplo(nu As Integer) As Boolean
        Dim esMultiplo As Boolean = VerificarMultiplo(nu)

        Dim a As Integer = n / nu

        'If esMultiplo Then
        'If a >= 2 Then
        'Return True
        'Else
        'Return False
        'End If
        'Else
        'Return False
        'End If


        Return esMultiplo And (a >= 2)
    End Function

    Public Function VerificarFibonacci() As Boolean
        Dim x, y, z As Integer
        x = -1
        y = 1

        Do
            z = x + y
            x = y
            y = z
        Loop Until (z = n) Or (z > n)

        Return (z = n)
    End Function
End Class
