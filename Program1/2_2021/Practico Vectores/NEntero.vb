Public Class NEntero
    Private n As Integer


    Public Sub NEntero()
        n = 0
    End Sub


    Public Sub Cargar(num As Integer)
        n = num
    End Sub
    Public Sub Unir2n(n1 As NEntero)
        Dim nd As Integer
        'Dim f As Integer
        n1 = New NEntero
        'n2 = New Nent

        nd = n1.ContDig()
        n = (n * 10 ^ 2) + n1.n
        'n = nd
        'Return f
    End Sub

    Public Sub Unir2nOK(n2 As Integer)
        Dim nd As Integer
        Dim nu As NEntero
        nu = New NEntero
        nu.n = n2
        nd = nu.ContDig()
        n = (n * 10 ^ nd) + nu.n
        'n = nd
    End Sub


    Public Sub CortarDigNdg(dig As NEntero)
        Dim d, c, nd As Integer
        Dim nu As NEntero
        Dim ndg As Integer
        nu = New NEntero
        dig = New NEntero
        ndg = dig.ContDig()
        c = -1
        Do
            d = n Mod 10 ^ ndg
            n = n \ 10 ^ ndg
            If Not (d = dig.n) Then
                c = c + 1
                nu.n = nu.n + d * 10 ^ c
            End If
        Loop Until d = dig.n

        nd = nu.ContDig()
        n = n * 10 ^ nd + nu.n

        'n = nu.n
    End Sub

    Public Function DigMen()
        Dim dm, na, d As Integer
        na = n
        dm = na Mod 10
        na = na \ 10
        While na > 0
            d = na Mod 10
            na = na \ 10
            If d < dm Then
                dm = d
            End If
        End While

        Return dm
    End Function


    Public Function ContDig() As Integer
        Dim na, c As Integer
        na = n
        c = 0
        While na > 0
            na = na \ 10
            c = c + 1
        End While
        'n = na
        Return c
    End Function

    Public Sub CortDgPrim()
        Dim c, na, nu As Integer
        Dim d As NEntero
        d = New NEntero
        na = n
        c = -1

        While na > 0
            d.n = na Mod 10
            na = na \ 10
            If Not (d.VerificarPrimo()) = True Then
                c = c + 1
                nu = nu + d.n * 10 ^ c
            End If
            n = nu

        End While
    End Sub

    Public Sub CortDgNOPrim()
        Dim c, na, nu As Integer
        Dim d As NEntero
        d = New NEntero
        na = n
        c = -1

        While na > 0
            d.n = na Mod 10
            na = na \ 10
            If (d.VerificarPrimo()) = True Then
                c = c + 1
                nu = nu + d.n * 10 ^ c
            End If
            n = nu

        End While
    End Sub

    Public Function Pnec1(Vi As Double, r As Integer)
        Dim f, Sr As Double
        Dim i, d, na As Integer
        f = 0 : i = 0
        na = n
        While n > 0
            d = n Mod 10 : n = n \ 10 : i = i + 1
            Sr = Vi + (i - 1) * r
            f = f + (Fact(Sr) ^ (1 / d))
        End While
        n = na
        Return f
    End Function

    Public Function Seno(nu As Double)
        Dim r, pi As Double
        pi = Math.PI
        nu = Math.Sin((nu * pi) / 180)
        r = nu
        'r = r / pi
        Return r
    End Function

    Public Function Vfibo() As Boolean
        Dim a, b, c As Integer
        a = -1 : b = 1
        Do
            c = a + b
            a = b : b = c
        Loop Until (c = n) Or (c > n)
        Return c = n
    End Function

    Public Function Fact(nu As Integer)
        Dim f As Double : Dim i As Integer

        If nu <> 0 Then
            f = 1
            For i = Math.Abs(nu) To 1 Step -1
                f = f * i
            Next
            If nu < 0 Then
                f = f * (-1)
            End If
        Else
            f = 1
        End If
        Return f
    End Function

    Public Function VerificarPrimo()
        If n = 1 Then
            Return False
        End If
        Dim b As Boolean
        Dim c As Integer
        b = True : c = 0

        For i = 1 To n
            If (n Mod i) = 0 Then
                c = c + 1
            End If

            If c >= 3 Then
                b = False
                i = n
            End If
        Next

        Return b

    End Function

    Public Function NoPrimo()
        Return Not VerificarPrimo()
    End Function


    Public Function Vexist(d As Integer) As Boolean
        Dim b As Boolean
        Dim d1, na As Integer
        b = False
        na = n
        While (n > 0) And (b = False)
            d1 = n Mod 10
            n = n \ 10
            If d1 = d Then
                b = True
            End If
        End While
        n = na
        Return b
    End Function

    Public Function Pnec1s(Vi As Double, r As Integer)
        Dim Sr As Double
        Dim i, d, na As Integer
        Dim S As String
        S = "f = "
        na = n
        While n > 0
            d = n Mod 10 : n = n \ 10 : i = i + 1
            Sr = Vi + (i - 1) * r
            S = S + Str(d) + "v" + Str(Sr) + "! +"
        End While
        S = Mid(S, 1, Len(S) - 1)
        n = na
        Return S
    End Function

    Public Function Pnec2(nd As Integer)
        Dim f As Double
        Dim na As Integer
        Dim d As NEntero
        d = New NEntero
        Dim bl As Boolean

        f = 0 : na = n : bl = True

        While n > 0
            d.n = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If (d.VerificarPrimo()) = True Then
                If bl = True Then
                    f = f + Math.Sqrt(d.n)
                Else
                    f = f - Math.Sqrt(d.n)
                End If
                bl = Not bl
            End If
        End While
        n = na
        Return f
    End Function


    Public Function Pnec2s(nd As Integer)
        Dim s As String
        Dim na As Integer
        Dim d As NEntero
        d = New NEntero
        Dim bl As Boolean

        s = "f = " : na = n : bl = True

        While n > 0
            d.n = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If (d.VerificarPrimo()) = True Then
                If bl = True Then
                    s = s + "v" + Str(d.n) + "- "
                Else
                    s = s + "v" + Str(d.n) + "+ "
                End If
                bl = Not bl
            End If
        End While
        s = Mid(s, 1, Len(s) - 2)
        n = na
        Return s
    End Function

    Public Function Pnec3()
        Dim f As Double
        Dim na As Integer
        Dim d As NEntero
        d = New NEntero
        na = n : f = 0
        While n > 0
            d.n = n Mod 10
            n = n \ 10
            If d.Vfibo() Then
                'f = f + Math.Sin(Math.PI / d.n)
                f = f + Seno(Math.PI / d.n)
            End If
        End While
        n = na
        Return f
    End Function

    Public Function Pnec3s()
        Dim s As String
        Dim na As Integer
        Dim d As NEntero
        d = New NEntero
        na = n : s = "f = "

        While n > 0
            d.n = n Mod 10
            n = n \ 10
            If d.Vfibo() Then
                'f = f + Math.Sin(Math.PI / d.n)
                s = s + "sen(p/" + Str(d.n) + ") +"
            End If
        End While
        s = Mid(s, 1, Len(s) - 1)
        n = na
        Return s
    End Function

    Public Sub Pnes1()
        Dim c, f, d As Integer
        c = -1
        While n > 0
            d = n Mod 10
            n = n \ 10
            If Not Vexist(d) Then
                c = c + 1
                f = f + d * 10 ^ c
            End If
        End While

        n = f
    End Sub

    Public Function Pnes2()
        Dim na As NEntero
        na = New NEntero
        na.n = n
        na.Pnes1()
        Return na.ContDig()
    End Function

    Public Function Pnes3(d1 As Integer)
        Dim na, c, d As Integer
        na = n : c = 0
        While na > 0
            d = na Mod 10
            na = na \ 10
            If d = d1 Then
                c = c + 1
            End If
        End While

        Return c
    End Function

    Public Sub Pnes4()
        Dim f As Double
        Dim na, c, d As Integer
        c = -1
        na = n
        While na > 0
            d = na Mod 10
            na = na \ 10
            If Pnes3(d) = 1 Then
                c = c + 1
                'f = f + d * 10 ^ c '
                f = f * 10 + d
            End If
        End While
        n = f
    End Sub
    Public Sub Pnes5()
        Dim nu, d As Integer
        nu = 0
        While n > 0
            d = DigMen()
            '  CortarDig(d)
            nu = nu * 10 + d
        End While
        n = nu
    End Sub

    Public Function Pnec4(nd As Integer)
        Dim dm, na, d As Integer
        na = n
        dm = na Mod 10 ^ nd
        na = na \ 10 ^ nd
        While na > 0
            d = na Mod 10 ^ nd
            na = na \ 10 ^ nd
            If d < dm Then
                dm = d
            End If
        End While

        Return dm
    End Function

    Public Function Pnec5(nd As Integer, m As Integer) As Boolean
        Dim b As Boolean
        Dim na, c As Integer
        Dim d As Double
        na = n : c = 0
        b = True
        While (na > 0)
            d = na Mod 10 ^ nd
            na = na \ 10 ^ nd
            If Not (d Mod m = 0) Then
                c = c + 1
            End If
        End While

        If c > 0 Then
            b = False
        End If

        Return b
    End Function

    Public Function Pnec6(nd As Integer) As Boolean
        Dim d, dm, na As Integer
        Dim b As Boolean
        b = True : na = n

        dm = na Mod 10 ^ nd
        na = na \ 10 ^ nd

        While (b = True) And (na > 0)
            d = na Mod 10 ^ nd
            na = na \ 10 ^ nd

            If (dm <= d) Then
                dm = d
            Else
                b = False
            End If
        End While

        Return b
    End Function

    Public Function Pnec7(nd As Integer) As Boolean
        Dim d, d1, na As Integer
        Dim b As Boolean
        b = True : na = n

        d1 = na Mod 10 ^ nd
        na = na \ 10 ^ nd

        While (b = True) And (na > 0)
            d = na Mod 10 ^ nd
            na = na \ 10 ^ nd

            If (d1 = d) Then
                d1 = d
            Else
                b = False
            End If
        End While

        Return b
    End Function


    Public Function Pnes6(ne As NEntero)
        Dim c, na As Integer
        Dim b As Boolean
        b = True
        na = n
        ne = New NEntero

        While (b = True) And (na > 0)
            '   CortarDig(ne.n)
            If na <> n Then
                c = c + 1
                na = n
            Else
                b = False
            End If
        End While

        Return c
    End Function

    Public Sub Pnes7()
        Dim b As Boolean
        ' Dim d As Integer

        While n > 0
            If b = True Then

            End If
        End While
    End Sub
    Public Function verifEscalera() As Boolean

        Dim o As NEntero
        o = New NEntero
        o.n = n
        o.Pnes5()
        Return (o.n = 12345) Or (o.n = 23456) Or (o.n = 13456)
    End Function

    Public Function verifFULL()
        Dim d, d1, na As Integer
        Dim b As Boolean
        na = n : b = False
        d = na Mod 10 : na = na \ 10
        While (b = False) And (na > 0)
            d1 = na Mod 10
            na = na \ 10
            If d <> d1 Then
                b = True
            End If
        End While
        If (Pnes3(d) = 3) And (Pnes3(d1) = 2) Or (Pnes3(d) = 2) And (Pnes3(d1) = 3) Then
            b = True
        Else
            b = False
        End If

        Return b
    End Function
    Public Function leonardeta(nd As Integer) As Boolean
        Dim na, d, d1 As Integer
        Dim b As Boolean
        b = True : na = n
        d = na Mod 10 ^ nd : na = na \ 10 ^ 10
        While (na > 0) And (b = True)
            d1 = na Mod 10 ^ nd : na = na \ 10 ^ nd
            If Not (d = d1) Then
                b = False
            End If
        End While
        Return b
    End Function

    Public Function EsCapicua() As Boolean
        Dim aux, d, inverso As Integer
        aux = Me.n
        While aux <> 0
            d = aux Mod 10
            inverso = inverso * 10 + d
            aux /= 10
        End While
        Return inverso = n
    End Function

    Public Function NoCapicua() As Boolean
        Return Not EsCapicua()
    End Function
End Class