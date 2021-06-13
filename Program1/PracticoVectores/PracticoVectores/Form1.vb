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
End Class
