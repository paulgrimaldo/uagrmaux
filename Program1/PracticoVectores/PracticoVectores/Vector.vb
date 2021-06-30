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

    Public Function DescargarN() As Integer
        Return n
    End Function

    Public Function DescargarElemento(posicion As Integer) As Integer
        Return V(posicion)
    End Function

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

    Public Sub OrdenarBurbuja()
        Dim i, j As Integer
        i = 2
        j = 0
        For i = 1 To n
            For j = 1 To n - i
                If (V(j) > V(j + 1)) Then
                    Intercambiar(j, j + 1)
                    Debug.WriteLine(Descargar)
                End If
            Next
        Next
    End Sub

    Public Sub Intercambiar(pos1 As Integer, pos2 As Integer)
        Dim aux = Me.V(pos2)
        V(pos2) = V(pos1)
        V(pos1) = aux
    End Sub

    Public Sub OrdenarBurbujaAyB(a As Integer, b As Integer)
        Dim i, j As Integer
        For i = a To b - 1
            For j = a To b - 1
                If (V(j) > V(j + 1)) Then
                    Intercambiar(j, j + 1)
                End If
            Next
        Next
    End Sub

    Public Sub InsertarVectorDesdePos(pos As Integer, v2 As Vector)
        Dim i As Integer
        For i = n + v2.n To v2.n Step -1
            V(i) = V(i - v2.n)
        Next
        n += v2.n
        For i = 1 To v2.n
            V((pos - 1) + i) = v2.V(i)
        Next
    End Sub

    Public Function CantidadDiferentesEntreAyB(a As Integer, b As Integer) As Integer
        Dim c = 0
        Dim i As Integer = a
        Dim ele As Integer
        OrdenarBurbuja()
        While i <= b
            ele = V(i)
            While i <= b And ele = V(i)
                i += 1
            End While
            c += 1
        End While
        Return c
    End Function

    Public Sub FrecuenciaDeDistrucion(e As Vector, f As Vector)
        Dim i, fr, ele As Integer
        OrdenarBurbuja()
        i = 1 : e.n = 0 : f.n = 0
        While i <= n
            ele = V(i)
            fr = 0
            While (i <= n) And (V(i) = ele)
                i += 1 : fr += 1
            End While
            e.n += 1 : e.V(e.n) = ele
            f.n += 1 : f.V(f.n) = fr
        End While

    End Sub

    Public Sub FrecuenciDeDistribucionAyB(e As Vector, f As Vector, a As Integer, b As Integer)
        Dim i, fr, ele As Integer
        OrdenarBurbuja()
        i = a : e.n = 0 : f.n = 0
        While i <= b
            ele = V(i)
            fr = 0
            While (i <= b) And (V(i) = ele)
                i += 1 : fr += 1
            End While
            e.n += 1 : e.V(e.n) = ele
            f.n += 1 : f.V(f.n) = fr
        End While
    End Sub

    Public Sub FrecuenciDeDistribucionAyBInvertido(a As Integer, b As Integer, e As Vector, f As Vector)
        Dim i, ele, fr As Integer
        Me.OrdenarBurbujaAyB(a, b)
        i = a
        While i <= b
            ele = V(i)
            fr = 0
            While i <= b And V(i) = ele
                i = i + 1
                fr = fr + 1
            End While
            e.Agregar(ele)
            f.Agregar(fr)
        End While
        e.VolcarVector()
        f.VolcarVector()
    End Sub

    Public Sub Purgar()
        OrdenarBurbuja()
        Dim i, d, ele As Integer
        i = 0 : d = 1
        While d <= n
            ele = V(d)
            While d <= n And ele = V(d)
                d += 1
            End While
            i += 1
            V(i) = ele
        End While
        n = i
    End Sub

    Public Sub PurgarAyB(a As Integer, b As Integer)
        OrdenarBurbujaAyB(a, b)
        Dim v2 As New Vector
        Dim ele As Integer
        Dim d = a
        For i = 1 To a - 1
            v2.Agregar(V(i))
        Next
        While d <= b
            ele = V(d)
            While d <= b And ele = V(d)
                d += 1
            End While
            v2.Agregar(ele)
        End While
        For i = b + 1 To n
            v2.Agregar(V(i))
        Next
        V = v2.V
        n = v2.n
    End Sub

    Public Function FrecuenciaDeElemento(ele As Integer)
        Dim c, i As Integer
        c = 0
        For i = 1 To n
            If V(i) = ele Then
                c += 1
            End If
        Next
        Return c
    End Function

    Public Function FrecuenciaDeElementoAyB(ele As Integer, a As Integer, b As Integer)
        Dim c, i As Integer
        c = 0
        For i = a To b
            If V(i) = ele Then
                c += 1
            End If
        Next
        Return c
    End Function

    Public Function ElementoDeMenorFrecuenciaAyB(a As Integer, b As Integer)
        OrdenarBurbuja()
        Dim i As Integer = a
        Dim fr = FrecuenciaDeElemento(V(i))
        Dim ele = V(i)
        For i = a To b
            If (FrecuenciaDeElemento(V(i)) < fr) Then
                fr = FrecuenciaDeElemento(V(i))
                ele = V(i)
            End If
        Next

        Return ele
    End Function

    Public Function ElementoDeMayorFrecuenciaAyB(a As Integer, b As Integer)
        OrdenarBurbuja()
        Dim i As Integer = a
        Dim fr = FrecuenciaDeElemento(V(i))
        Dim ele = V(i)
        For i = a To b
            If (FrecuenciaDeElemento(V(i)) > fr) Then
                fr = FrecuenciaDeElemento(V(i))
                ele = V(i)
            End If
        Next

        Return ele
    End Function

    Public Function IntercaladoEnOtroVector(v2 As Vector) As Vector
        Dim r As New Vector
        Dim b As Boolean = True
        Dim v1i, v2i As Integer
        v1i = 1
        v2i = 1

        While v1i <= n Or v2i <= v2.n
            If (b) Then
                If v1i <= n Then
                    r.Agregar(V(v1i))
                    v1i += 1
                End If
            Else
                If (v2i <= v2.n) Then
                    r.Agregar(v2.V(v2i))
                    v2i += 1
                End If
            End If
            b = Not b
        End While
        Return r
    End Function

    Public Sub SegmentarPrimosYNoPrimosDescendenteAyB(a As Integer, b As Integer)
        Dim n1 As New NEntero
        Dim n2 As New NEntero
        Dim i, j As Integer
        For i = a To b - 1
            For j = i + 1 To b
                n1.Cargar(V(i))
                n2.Cargar(V(j))
                If n1.VerificarPrimo And n2.NoPrimo Or
                n1.VerificarPrimo And n2.VerificarPrimo And (V(i) < V(j)) Or
                 n1.NoPrimo And n2.NoPrimo And (V(i) < V(j)) Then
                    Intercambiar(i, j)
                End If
            Next
        Next
    End Sub

    Public Sub SegmentarCapicuaAscYNoCapicuaDesc()
        Dim n1 As New NEntero
        Dim n2 As New NEntero
        For i = 1 To n - 1
            For j = i + 1 To n
                n1.Cargar(V(i))
                n2.Cargar(V(j))

                If n1.EsCapicua And n2.NoCapicua Or
                        n1.EsCapicua And n2.EsCapicua And (V(i) < V(j)) Or
                        n1.NoCapicua And n2.NoCapicua And (V(i) > V(j)) Then
                    Intercambiar(i, j)
                End If
            Next
        Next
    End Sub

    Public Sub IntercarlarPrimosNoPrimosAyB(a As Integer, b As Integer)
        Dim n1, n2 As NEntero
        n1 = New NEntero
        n2 = New NEntero

        Dim sw As Boolean = True
        For i = a To b - 1
            If sw = True Then
                For j = i + 1 To b
                    n1.Cargar(V(i))
                    n2.Cargar(V(j))

                    If n1.VerificarPrimo And n2.NoPrimo Or
                        n1.VerificarPrimo And n2.VerificarPrimo And (V(i) < V(j)) Or
                        n1.NoPrimo And n2.NoPrimo And (V(i) < V(j)) Then
                        Intercambiar(i, j)
                    End If
                Next
            Else
                For j = i + 1 To b
                    n1.Cargar(V(j))
                    n2.Cargar(V(i))

                    If n1.VerificarPrimo And n2.NoPrimo Or
                        n1.VerificarPrimo And n2.VerificarPrimo And (V(i) < V(j)) Or
                        n1.NoPrimo And n2.NoPrimo And (V(i) < V(j)) Then
                        Intercambiar(i, j)
                    End If
                Next
            End If
            sw = Not sw
        Next
    End Sub

    Private Function ContieneElemento(e As Integer) As Boolean
        For i = 1 To n
            If (V(i) = e) Then
                Return True
            End If
        Next
        Return False
    End Function


    Public Function DiferenciaSimetrica(v2 As Vector) As Vector
        Dim vR As Vector = New Vector
        For i = 1 To n
            If Not v2.ContieneElemento(Me.V(i)) Then
                vR.Agregar(Me.V(i))
            End If
        Next
        Dim n1 = v2.DescargarN
        For j = 1 To n1
            If Not Me.ContieneElemento(v2.DescargarElemento(j)) Then
                vR.Agregar(v2.DescargarElemento(j))
            End If
        Next
        Return vR
    End Function

    Public Function PurgarAyBEnNuevoVector(a As Integer, b As Integer) As Vector
        Dim d, ele As Integer
        d = a
        Dim r As New Vector
        While d <= b
            ele = V(d)
            While d <= n And ele = V(d)
                d += 1
            End While
            r.Agregar(ele)
        End While
        Return r
    End Function

    Public Sub OrdenarMultiploDeM(m As Integer)
        For i = 1 To n \ m - 1
            For j = i + 1 To n \ m
                If V(i * m) > V(j * m) Then
                    Intercambiar(i * m, j * m)
                End If
            Next
        Next
    End Sub

    Public Sub VolcarVector()
        Dim d = n
        For i = 1 To n \ 2
            Intercambiar(i, d)
            d -= 1
        Next
    End Sub

    Public Sub MenorYMayorFrecuenciaEnAyB(a As Integer, b As Integer, e As Vector, f As Vector)
        Dim menorEle, frecMenor, mayorEle, frecMayor As Integer
        menorEle = V(a)
        frecMenor = FrecuenciaDeElementoAyB(V(a), a, b)
        mayorEle = V(a)
        frecMayor = FrecuenciaDeElementoAyB(V(a), a, b)
        For i = a To b
            If FrecuenciaDeElementoAyB(V(i), a, b) < frecMenor Then
                menorEle = V(i)
                frecMenor = FrecuenciaDeElementoAyB(V(i), a, b)
            End If
            If FrecuenciaDeElementoAyB(V(i), a, b) > frecMayor Then
                mayorEle = V(i)
                frecMayor = FrecuenciaDeElementoAyB(V(i), a, b)
            End If
        Next
        e.Agregar(menorEle)
        e.Agregar(mayorEle)
        f.Agregar(frecMenor)
        f.Agregar(frecMayor)
    End Sub

    Public Function Interseccion(v2 As Vector) As Vector
        Dim Vr As Vector = New Vector

        For i = 1 To n
            If (v2.ContieneElemento(Me.V(i))) Then
                If Not Vr.ContieneElemento(Me.V(i)) Then
                    Vr.Agregar(Me.V(i))
                End If
            End If
        Next
        Return Vr
    End Function


    Public Function Union(v2 As Vector) As Vector
        Dim vR As Vector = New Vector
        For i = 1 To n
            vR.Agregar(Me.V(i))
        Next

        Dim n1 = v2.DescargarN
        For j = 1 To n1
            If Not vR.ContieneElemento(v2.DescargarElemento(j)) Then
                vR.Agregar(v2.DescargarElemento(j))
            End If
        Next
        Return vR
    End Function
End Class
