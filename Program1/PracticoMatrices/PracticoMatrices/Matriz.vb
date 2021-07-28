Public Class Matriz
    Const MAXF = 30
    Const MAXC = 30
    Private f As Integer
    Private c As Integer
    Private x(MAXF, MAXC) As Integer

    Public Sub Matriz()
        f = 0
        c = 0
    End Sub

    Public Sub Cargar(nf As Integer, nc As Integer, vi As Integer, r As Integer)
        Dim f1, c1, i As Integer
        Me.f = nf
        Me.c = nc
        i = 0

        For f1 = 1 To f
            For c1 = 1 To c
                i = i + 1
                x(f1, c1) = vi + (i - 1) * r
            Next
        Next
    End Sub

    Public Sub CargaRandom(nf As Integer, nc As Integer, a As Integer, b As Integer)
        Dim f1, c1 As Integer
        Me.f = nf
        Me.c = nc
        For f1 = 1 To f
            For c1 = 1 To c
                x(f1, c1) = Rnd() * (b - a) + a
            Next
        Next

    End Sub

    Public Sub CargaManual(nf As Integer, nc As Integer)
        Dim f1, c1 As Integer
        Me.f = nf
        Me.c = nc
        For f1 = 1 To f
            For c1 = 1 To c
                x(f1, c1) = InputBox("Ingresar valor")
            Next
        Next

    End Sub

    Public Function Descargar() As String
        Dim f1, c1 As Integer
        Dim s As String = ""

        For f1 = 1 To f
            For c1 = 1 To c
                s = s + Str(x(f1, c1)) + " "
            Next
            s = s + Chr(13) + Chr(10)
        Next

        Return s
    End Function

    Public Function AcumularPrimos() As Double
        Dim rf As Double
        Dim f1, c1, s As Integer
        Dim n As NEntero = New NEntero()
        s = -1
        For f1 = f To 1 Step -1
            For c1 = c To 1 Step -1
                n.Cargar(x(f1, c1))

                If n.VerificarPrimo Then
                    rf = rf + s * Math.Sqrt(x(f1, c1))
                    s = s * -1
                End If
            Next
        Next

        Return rf
    End Function

    Public Function FrecuenciaElemento(e As Integer) As Integer
        Dim ca, f1, c1 As Integer
        ca = 0

        For f1 = 1 To f
            For c1 = 1 To c
                If x(f1, c1) = e Then
                    ca = ca + 1
                End If
            Next
        Next

        Return ca
    End Function

    Public Function CantidadNoRepetidos() As Integer
        Dim ca, f1, c1, fr As Integer
        ca = 0
        fr = 0
        For f1 = 1 To f
            For c1 = 1 To c
                fr = FrecuenciaElemento(x(f1, c1))

                If fr = 1 Then
                    ca = ca + 1
                End If
            Next
        Next

        Return ca
    End Function

    Public Sub ContarPrimosPorFila()
        Dim f1, c1, ca As Integer
        Dim n As NEntero = New NEntero

        Me.c = Me.c + 1

        For f1 = 1 To f
            ca = 0
            For c1 = 1 To c - 1
                n.Cargar(x(f1, c1))
                If n.VerificarPrimo Then
                    ca = ca + 1
                End If
            Next
            x(f1, Me.c) = ca
        Next
    End Sub

    'Intercambiar(1,1,4,4)
    Private Sub Intercambiar(f1, c1, f2, c2)
        Dim aux = x(f1, c1)
        x(f1, c1) = x(f2, c2)
        x(f2, c2) = aux
    End Sub

    Public Sub SegmentarFilasParesImpares()
        Dim n1, n2 As NEntero
        n1 = New NEntero
        n2 = New NEntero

        For fp = 1 To f
            For cp = 1 To c
                For cd = cp + 1 To c
                    n1.Cargar(Me.x(fp, cd))
                    n2.Cargar(x(fp, cp))

                    If n1.EsPar And Not n2.EsPar Or n1.EsPar And n2.EsPar And x(fp, cp) > x(fp, cd) Or
                        Not n1.EsPar And Not n2.EsPar And x(fp, cp) > x(fp, cd) Then

                        Intercambiar(fp, cp, fp, cd)

                    End If
                Next
            Next
            Next

    End Sub

    Private Sub IntercambiarColumnas(c1, c2)
        For fp = 1 To f
            Intercambiar(fp, c1, fp, c2)
        Next
    End Sub

    Public Sub OrdenarColumnasDeAcuerdoAElementoFilaOrdenado(fil As Integer)

        For cp = 1 To c
            For cd = 1 To c
                If x(fil, cd) > x(fil, cp) Then
                    IntercambiarColumnas(cp, cd)
                End If
            Next
        Next

    End Sub

    Public Function VerificarColumnasOrdenadasDeAbajoHaciaArriba() As Boolean
        Dim fp, cp, e As Integer
        fp = f
        cp = c
        e = x(fp, cp)
        Dim b = True
        While cp >= 1 And b
            fp = f
            e = x(fp, cp)
            While fp >= 1 And b
                If (x(fp, cp) >= e) Then
                    e = x(fp, cp)
                Else
                    b = False
                End If
                fp = fp - 1
            End While
            cp = cp - 1
        End While

        Return b
    End Function

    Public Function VerificarMatrizOrdenadaDeIzquierInferiorADerecha() As Boolean
        Dim b As Boolean = True
        Dim fd, cd, e As Integer
        fd = f
        cd = 1
        e = x(fd, cd)

        While fd >= 1 And b = True
            cd = 1
            While cd <= c And b = True
                If x(fd, cd) >= e Then
                    e = x(fd, cd)
                Else
                    b = False
                End If

                cd = cd + 1
            End While

            fd = fd - 1
        End While
        Return b
    End Function

    Public Sub OrdenarFilasPorCantidadPrimos()
        For fp = 1 To f
            For fd = fp + 1 To f
                If CantidadPrimosEnFila(fd) < CantidadPrimosEnFila(fp) Then
                    IntercambiarFilas(fp, fd)
                End If
            Next
        Next
    End Sub

    Private Function CantidadPrimosEnFila(f1)
        Dim cp = 0
        Dim n = New NEntero
        For cd = 1 To c
            n.Cargar(x(f1, cd))

            If n.VerificarPrimo Then
                cp = cp + 1
            End If
        Next

        Return cp
    End Function

    Private Sub IntercambiarFilas(f1, f2)
        For cp = 1 To c
            Intercambiar(f1, cp, f2, cp)
        Next
    End Sub

    Public Sub OrdenarFinalHastaInicio()
        Dim i As Integer

        For cp = c To 1 Step -1
            For fp = f To 1 Step -1
                For cd = cp To 1 Step -1
                    If cp = cd Then
                        i = fp
                    Else
                        i = c
                    End If

                    For fd = i To 1 Step -1
                        If x(fp, cp) > x(fd, cd) Then
                            Intercambiar(fp, cp, fd, cd)
                        End If
                    Next
                Next
            Next
        Next
    End Sub

    Public Sub SegmentarMatrizFrecuencia()
        Dim i As Integer

        For fp = 1 To f
            For cp = 1 To c
                For fd = fp To f
                    If fp = fd Then
                        i = cp
                    Else
                        i = 1
                    End If
                    For cd = i To c
                        If FrecuenciaElemento(x(fd, cd)) > FrecuenciaElemento(x(fp, cp)) Or
                            FrecuenciaElemento(x(fd, cd)) = FrecuenciaElemento(x(fp, cp)) And x(fd, cd) > x(fp, cp) Then

                            Intercambiar(fp, cp, fd, cd)

                        End If
                    Next
                Next
            Next
        Next
    End Sub
End Class
