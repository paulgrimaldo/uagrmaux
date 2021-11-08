Public Class Form1
    Private vector As Vector

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vector = New Vector()
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        Dim n As Integer = TxtN.Text
        vector.Cargar(n)
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        Dim r As String = vector.Descargar
        TxtResult.Text = r
    End Sub

    Private Sub UnirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnirToolStripMenuItem.Click
        Dim n2 As Integer = TxtN2.Text
        Dim v2 As Vector = New Vector()
        v2.Cargar(n2)

        Dim r As Vector = New Vector()
        r = vector.Unir(v2)
        TxtResult.Text = r.Descargar
    End Sub

    Private Sub DiferenciaSimetricaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiferenciaSimetricaToolStripMenuItem.Click
        Dim n2 As Integer = TxtN2.Text
        Dim v2 As Vector = New Vector()
        v2.Cargar(n2)

        TxtResult.Text = TxtResult.Text + " ||| " + v2.Descargar


        Dim vr As Vector
        vr = vector.DiferenciaSimetrica(v2)
        TxtResult.Text = TxtResult.Text + " ||| " + vr.Descargar

        'c = c +1
        'TxtResult.Text = TxtResult.Text + "
    End Sub

    Private Sub OrdenarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarToolStripMenuItem.Click
        vector.OrdenarAsc()

        TxtResult.Text = vector.Descargar
    End Sub

    Private Sub PurgarEnRangoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurgarEnRangoToolStripMenuItem.Click
        Dim a As Integer = TxtA.Text
        Dim b As Integer = TxtB.Text

        Dim Vr = New Vector()
        Vr = vector.PurgarAyBEnOtroVector(a, b)

        TxtResult.Text = Vr.Descargar
    End Sub

    Private Sub EliminarPrimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPrimosToolStripMenuItem.Click
        vector.EliminarPrimos()

        TxtResult.Text = vector.Descargar


    End Sub
End Class
