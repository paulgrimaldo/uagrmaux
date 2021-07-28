Public Class Form1
    Private m As Matriz

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        Dim f, c, vi, r As Integer
        f = TxtNF.Text
        c = TxtNC.Text
        vi = TextBox3.Text
        r = TextBox4.Text

        m = New Matriz()
        m.Cargar(f, c, vi, r)

    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        Dim s As String
        s = m.Descargar

        TxtResultado.Text = s
    End Sub

    Private Sub AcumularPrimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcumularPrimosToolStripMenuItem.Click
        Dim f As Double

        f = m.AcumularPrimos

        TxtResultado.Text = f
    End Sub

    Private Sub CantidadElementosUnicosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CantidadElementosUnicosToolStripMenuItem.Click
        Dim c As Integer

        c = m.CantidadNoRepetidos
        TxtResultado.Text = c
    End Sub

    Private Sub CargarRandomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarRandomToolStripMenuItem.Click
        Dim f, c, a, b As Integer
        f = TxtNF.Text
        c = TxtNC.Text
        a = TextBox3.Text
        b = TextBox4.Text

        m.CargaRandom(f, c, a, b)

    End Sub

    Private Sub CantidadPrimosPorFilaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CantidadPrimosPorFilaToolStripMenuItem.Click
        Dim s As String

        m.ContarPrimosPorFila()

        s = m.Descargar
        TxtResultado.Text = s
    End Sub

    Private Sub SegmentarPrimosNoPrimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarPrimosNoPrimosToolStripMenuItem.Click
        Dim s As String

        m.SegmentarFilasParesImpares()

        s = m.Descargar
        TxtResultado.Text = s
    End Sub

    Private Sub OrdenarColumnasDeAcuerdoAFilaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarColumnasDeAcuerdoAFilaToolStripMenuItem.Click
        Dim s As String
        Dim fil As Integer
        fil = TextBox3.Text
        m.OrdenarColumnasDeAcuerdoAElementoFilaOrdenado(fil)

        s = m.Descargar
        TxtResultado.Text = s
    End Sub

    Private Sub VerificarColumnasOrdenadasAbajoAArribaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarColumnasOrdenadasAbajoAArribaToolStripMenuItem.Click


        Dim b = m.VerificarColumnasOrdenadasDeAbajoHaciaArriba

        TxtResultado.Text = b
    End Sub

    Private Sub CargaManualToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargaManualToolStripMenuItem1.Click
        Dim f, c As Integer
        f = TxtNF.Text
        c = TxtNC.Text
        m = New Matriz()
        m.CargaManual(f, c)
    End Sub

    Private Sub OrdenarMatrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarMatrToolStripMenuItem.Click
        Dim s As String

        m.OrdenarFilasPorCantidadPrimos()

        s = m.Descargar
        TxtResultado.Text = s
    End Sub

    Private Sub OrdenarInversoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarInversoToolStripMenuItem.Click
        Dim s As String

        m.OrdenarFinalHastaInicio()

        s = m.Descargar
        TxtResultado.Text = s
    End Sub

    Private Sub VerificarMatrizOrdenadaInferiorIzquierdaADerechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarMatrizOrdenadaInferiorIzquierdaADerechaToolStripMenuItem.Click
        Dim b As Boolean
        b = m.VerificarMatrizOrdenadaDeIzquierInferiorADerecha
        TxtResultado.Text = b
    End Sub

    Private Sub SegmentarMatrizPorFrecuenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarMatrizPorFrecuenciaToolStripMenuItem.Click
        Dim s As String
        m.SegmentarMatrizFrecuencia()

        s = m.Descargar
        TxtResultado.Text = s
    End Sub
End Class
