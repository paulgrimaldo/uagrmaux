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
End Class
