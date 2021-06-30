Public Class Form1
    Private vector As Vector


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vector = New Vector
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CargadoEnPotenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargadoEnPotenciaToolStripMenuItem.Click
        Dim ne As Integer = Me.TxtN.Text
        Dim b As Integer = Me.Txt1.Text
        Dim resultado As String
        vector.CargadorEnBaseAFormula(ne, b)
        resultado = vector.Descargar

        Me.TxtResultado.Text = resultado

    End Sub

    Private Sub CargarRandomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarRandomToolStripMenuItem.Click
        Dim n, a, b As Integer
        n = Me.TxtN.Text
        a = Me.Txt1.Text
        b = Me.Txt2.Text

        Me.vector.CargarRandom(n, a, b)
        Me.TxtResultado.Text = Me.vector.Descargar


    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        Dim cantidad As Integer

        cantidad = Me.vector.CantidadPosicionesMultiplo()
        Me.TxtResultado.Text = Str(cantidad)

    End Sub

    Private Sub MayorEnPosicionMMultiploToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MayorEnPosicionMMultiploToolStripMenuItem.Click
        Dim m As Integer = Me.Txt1.Text
        Dim mayor As Integer

        mayor = vector.MayorPosicionesMultiploDeM(m)
        Me.TxtResultado.Text = Str(mayor)
    End Sub

    Private Sub DescargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem1.Click
        Dim resultado As String

        resultado = vector.Descargar
        Me.TxtResultado.Text = resultado

    End Sub

    Private Sub SegmentarPrimosYNoPrimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarPrimosYNoPrimosToolStripMenuItem.Click
        Dim r1 = New Vector
        Dim r2 = New Vector

        vector.PrimosYNoPrimos(r1, r2)

        Dim primos As String = r1.Descargar
        Dim noPrimos As String = r2.Descargar

        Me.TxtResultado.Text = "Primos: " + primos + ", NoPrimos: " + noPrimos


    End Sub

    Private Sub VerificarVectorPrimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarVectorPrimosToolStripMenuItem.Click
        Dim sonPrimos As Boolean

        sonPrimos = vector.ElementosPrimos
        Me.TxtResultado.Text = "Es primo?: " + Str(sonPrimos)

    End Sub

    Private Sub OrdenarBurbujaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarBurbujaToolStripMenuItem.Click
        Me.vector.OrdenarBurbuja()
        Me.TxtResultado.Text = Me.vector.Descargar
    End Sub

    Private Sub OrdenarBurbujaAYBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarBurbujaAYBToolStripMenuItem.Click
        Dim a As Integer = Me.Txt1.Text
        Dim b As Integer = Me.Txt2.Text
        vector.OrdenarBurbujaAyB(a, b)
        Me.TxtResultado.Text = Me.vector.Descargar
    End Sub

    Private Sub DiferentesAYBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiferentesAYBToolStripMenuItem.Click
        Dim a As Integer = Me.Txt1.Text
        Dim b As Integer = Me.Txt2.Text

        Dim cantidad = vector.CantidadDiferentesEntreAyB(a, b)
        Me.TxtResultado.Text = cantidad
    End Sub

    Private Sub FrecuenciaDistribucionAYBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrecuenciaDistribucionAYBToolStripMenuItem.Click
        Dim a As Integer = Me.Txt1.Text
        Dim b As Integer = Me.Txt2.Text

        Dim ele = New Vector
        Dim f = New Vector

        vector.FrecuenciDeDistribucionAyB(ele, f, a, b)
        Me.TxtResultado.Text = ele.Descargar + "~" + f.Descargar
    End Sub

    Private Sub MenorFrecuenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenorFrecuenciaToolStripMenuItem.Click
        Dim a As Integer = Me.Txt1.Text
        Dim b As Integer = Me.Txt2.Text
        Dim menor = vector.ElementoDeMenorFrecuenciaAyB(a, b)
        TxtResultado.Text = menor
    End Sub

    Private Sub Intercalar2VectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Intercalar2VectoresToolStripMenuItem.Click
        Dim v2 = New Vector
        Dim r As New Vector
        v2.CargarRandom(10, 1, 10)
        Debug.WriteLine("V1: " + vector.Descargar)
        Debug.WriteLine("V2: " + v2.Descargar)
        r = vector.IntercaladoEnOtroVector(v2)
        TxtResultado.Text = r.Descargar
    End Sub

    Private Sub DescSegmentarPrimosYNoPrimosAYBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescSegmentarPrimosYNoPrimosAYBToolStripMenuItem.Click
        Dim a As Integer = Me.Txt1.Text
        Dim b As Integer = Me.Txt2.Text

        vector.SegmentarPrimosYNoPrimosDescendenteAyB(a, b)
        TxtResultado.Text = vector.Descargar

    End Sub

    Private Sub SegmentarCapicuaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarCapicuaToolStripMenuItem.Click
        vector.SegmentarCapicuaAscYNoCapicuaDesc()
        TxtResultado.Text = vector.Descargar
    End Sub

    Private Sub IntercalarPrimoNoPrimoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarPrimoNoPrimoToolStripMenuItem.Click
        Dim a As Integer = Txt1.Text
        Dim b As Integer = Txt2.Text

        vector.IntercarlarPrimosNoPrimosAyB(a, b)
        TxtResultado.Text = vector.Descargar

    End Sub

    Private Sub DiferenciaSimetricaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiferenciaSimetricaToolStripMenuItem.Click
        Dim v2 = New Vector
        Dim vR As New Vector
        Dim i = 1
        While DG1.Rows.Item(0).Cells.Item(i - 1).Value <> ""
            v2.Agregar(
                DG1.Rows.Item(0).Cells.Item(i - 1).Value
               )
            i = i + 1
        End While
        DG1.Rows.Clear()

        vR = vector.DiferenciaSimetrica(v2)
        Dim n = vR.DescargarN
        For i = 1 To n
            DGResult.Rows.Item(0).Cells.Item(i - 1).Value = vR.DescargarElemento(i)
        Next
    End Sub

    Private Sub PurgarAYBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurgarAYBToolStripMenuItem.Click
        Dim a As Integer = Me.Txt1.Text
        Dim b As Integer = Me.Txt2.Text
        Dim r As New Vector
        r = vector.PurgarAyBEnNuevoVector(a, b)
        TxtResultado.Text = r.Descargar
    End Sub

    Private Sub PurgarAYBToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PurgarAYBToolStripMenuItem2.Click
        Dim a As Integer = Me.Txt1.Text
        Dim b As Integer = Me.Txt2.Text
        vector.PurgarAyB(a, b)
        TxtResultado.Text = vector.Descargar
    End Sub

    Private Sub OrdenarMultiploMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarMultiploMToolStripMenuItem.Click
        Dim m As Integer = Txt1.Text
        vector.OrdenarMultiploDeM(m)

        Dim n = vector.DescargarN
        For i = 1 To n
            DGResult.Rows.Item(0).Cells.Item(i - 1).Value = vector.DescargarElemento(i)
        Next
    End Sub

    Private Sub FrencuenciaDistribucionAYBInvertidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrencuenciaDistribucionAYBInvertidoToolStripMenuItem.Click
        Dim a As Integer = Txt1.Text
        Dim b As Integer = Txt2.Text
        Dim ele, f As Vector
        ele = New Vector
        f = New Vector
        vector.FrecuenciDeDistribucionAyBInvertido(a, b, ele, f)

        Dim result As String
        result = ele.Descargar + "||" + f.Descargar
        TxtResultado.Text = result
    End Sub

    Private Sub MenorYMayorPorFrecuenciaAYBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenorYMayorPorFrecuenciaAYBToolStripMenuItem.Click
        Dim a As Integer = Me.Txt1.Text
        Dim b As Integer = Me.Txt2.Text
        Dim ele = New Vector
        Dim f = New Vector
        vector.MenorYMayorFrecuenciaEnAyB(a, b, ele, f)
        Me.TxtResultado.Text = ele.Descargar + "~" + f.Descargar
    End Sub

    Private Sub InterseccionDeConjuntosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InterseccionDeConjuntosToolStripMenuItem.Click
        Dim v2 As Vector = New Vector
        Dim vR As Vector = New Vector

        Dim i = 1
        While DG1.Rows.Item(0).Cells.Item(i - 1).Value <> ""
            v2.Agregar(
                DG1.Rows.Item(0).Cells.Item(i - 1).Value
               )
            i = i + 1
        End While
        DG1.Rows.Clear()

        vR = vector.Interseccion(v2)

        Dim n = vR.DescargarN
        For i = 1 To n
            DGResult.Rows.Item(0).Cells.Item(i - 1).Value = vR.DescargarElemento(i)
        Next
    End Sub

    Private Sub CargarDatagridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarDatagridToolStripMenuItem.Click
        vector = New Vector
        Dim i = 1
        While DG1.Rows.Item(0).Cells.Item(i - 1).Value <> ""
            vector.Agregar(
                DG1.Rows.Item(0).Cells.Item(i - 1).Value
               )
            i = i + 1
        End While
        DG1.Rows.Clear()
    End Sub

    Private Sub UnionDeConjuntosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnionDeConjuntosToolStripMenuItem.Click
        Dim v2 As Vector = New Vector
        Dim vR As Vector = New Vector

        Dim i = 1
        While DG1.Rows.Item(0).Cells.Item(i - 1).Value <> ""
            v2.Agregar(
                DG1.Rows.Item(0).Cells.Item(i - 1).Value
               )
            i = i + 1
        End While
        DG1.Rows.Clear()

        vR = vector.Union(v2)
        Dim n = vR.DescargarN
        For i = 1 To n
            DGResult.Rows.Item(0).Cells.Item(i - 1).Value = vR.DescargarElemento(i)
        Next
    End Sub

    Private Sub EjerciciosToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
