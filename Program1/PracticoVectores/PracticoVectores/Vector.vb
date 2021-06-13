Public Class Vector
    Const MAX = 100

    Private n As Integer
    Private V(MAX) As Integer

    Public Sub Vector()
        n = 0
    End Sub


    Public Sub Agregar(elemento As Integer)
        n = n + 1
        V(n) = elemento
    End Sub

    Public Sub CargarRandom(ne As Integer, a As Integer, b As Integer)
        Me.n = ne
        Dim i As Integer
        For i = 1 To Me.n
            V(i) = Rnd() * (b - a)
        Next
    End Sub

    Public Sub CargadorEnBaseAFormula(ne As Integer, b As Integer)
        Me.n = ne
        Dim exponente, i As Integer
        exponente = 0

        For i = 1 To Me.n
            Me.V(i) = b ^ exponente
            exponente = exponente + 1
        Next
    End Sub

    Public Function Descargar() As String
        Dim i As Integer = 1
        Dim datos As String = ""
        For i = 1 To Me.n
            datos = datos + Str(Me.V(i)) + ","
        Next
        datos = Mid(datos, 1, Len(datos) - 1)
        Return datos
    End Function

    Public Function CantidadPosicionesMultiplo() As Integer
        Dim i As Integer
        Dim cantidad As Integer = 0
        For i = 1 To Me.n
            If (V(i) Mod i) = 0 Then
                cantidad = cantidad + 1
            End If
        Next

        Return cantidad
    End Function

    Public Function MayorPosicionesMultiploDeM(ByRef m As Integer) As Integer
        Dim i As Integer
        Dim mayor As Integer = V(1)

        For i = 1 To Me.n
            If i Mod m = 0 Then
                If V(i) >= mayor Then
                    mayor = V(i)
                End If
            End If
        Next
        Return mayor

    End Function

    Public Sub PrimosYNoPrimos(r1 As Vector, r2 As Vector)
        Dim i As Integer
        For i = 1 To Me.n
            Dim numero As NEntero = New NEntero()
            numero.Cargar(V(i))

            If (numero.VerificarPrimo) Then
                r1.Agregar(V(i))
            Else
                r2.Agregar(V(i))
            End If
        Next
    End Sub

    Public Function ElementosPrimos() As Boolean
        Dim i As Integer
        Dim sonPrimos = True
        Dim numero As NEntero = New NEntero
        For i = 1 To n
            numero.Cargar(V(i))

            If Not numero.VerificarPrimo Then
                sonPrimos = False
                i = n
            End If

        Next

        Return sonPrimos
    End Function
End Class
