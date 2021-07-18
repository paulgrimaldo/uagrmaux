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
End Class
