Public Class Vector

    Const MAX = 100
    Private n As Integer
    Private V(MAX) As Integer

    Public Sub Vector()
        n = 0
    End Sub

    Public Sub Cargar(n As Integer)
        Me.n = n
        For i = 1 To n
            V(i) = InputBox("Ingrese un numero")
        Next
    End Sub

    Public Sub Agregar(e As Integer)
        Me.n = Me.n + 1
        V(n) = e
    End Sub

    Public Function Contiene(e As Integer) As Boolean
        For i = 1 To n
            If V(i) = e Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function Descargar() As String
        Dim r As String = ""
        For i = 1 To n
            r = r + Str(V(i)) + ", "
        Next
        Return r
    End Function

    Public Function Unir(v2 As Vector) As Vector
        Dim r As Vector = New Vector()
        For i = 1 To Me.n
            If Not r.Contiene(Me.V(i)) Then
                r.Agregar(Me.V(i))
            End If
        Next

        For j = 1 To v2.n
            If Not r.Contiene(v2.V(j)) Then
                r.Agregar(v2.V(j))
            End If
        Next

        Return r
    End Function

    Public Function DiferenciaSimetrica(v2 As Vector) As Vector
        Dim r As Vector = New Vector()
        For i = 1 To Me.n
            If Not v2.Contiene(Me.V(i)) Then
                r.Agregar(V(i))
            End If
        Next
        For j = 1 To v2.n
            If Not Me.Contiene(v2.V(j)) Then
                r.Agregar(v2.V(j))
            End If
        Next
        Return r
    End Function

    Public Sub OrdenarAsc()
        For i = 1 To n
            For j = 1 To n - 1
                If V(i) < V(j) Then
                    Intercambiar(i, j)
                    Debug.WriteLine(Descargar)
                End If
            Next
        Next
    End Sub

    Public Sub OrdenarDesc()
        For i = 1 To n
            For j = 1 To n - 1
                If V(i) > V(j) Then
                    Intercambiar(i, j)
                    Debug.WriteLine(Descargar)
                End If
            Next
        Next
    End Sub

    Public Sub Intercambiar(i As Integer, j As Integer)
        Dim aux As Integer = V(i)
        V(i) = V(j)
        V(j) = aux
    End Sub

    Public Function PurgarAyBEnOtroVector(a As Integer, b As Integer) As Vector
        Me.OrdenarAsc()

        Dim i = a
        Dim e As Integer
        Dim vr As Vector = New Vector()
        While i <= b
            e = V(i)
            While i <= b And e = V(i)
                i = i + 1
            End While
            vr.Agregar(e)
        End While
        vr.OrdenarDesc()
        Return vr
    End Function

    Public Sub EliminarPrimos()
        Dim nAux As NEntero = New NEntero()
        Dim i = 1

        While (i <= n)
            nAux.Cargar(V(i))
            If nAux.VerificarPrimo() Then
                RecorrerIzquierda(i)
                n = n - 1
                i = i - 1
            End If
            i = i + 1
        End While
    End Sub

    Public Sub RecorrerIzquierda(a As Integer)
        For i = a To n
            V(i) = V(i + 1)
        Next
    End Sub
End Class
