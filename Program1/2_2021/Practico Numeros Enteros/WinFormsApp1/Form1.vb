Public Class Form1
    Private x As NEntero

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        x = New NEntero()
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        Dim numero As Integer
        numero = TxtN.Text
        x.Cargar(numero)
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        Dim numero As Integer
        numero = x.Descargar()
        TxtResultado.Text = numero
    End Sub

    Private Sub VerificarParToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarParToolStripMenuItem.Click
        Dim b As Boolean
        b = x.VerificarPar()

        TxtResultado.Text = b
    End Sub

    Private Sub VerificarMultiploToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarMultiploToolStripMenuItem.Click
        'Dim nu As Integer
        'nu = TxtAux1.Text
        Dim nu As Integer = TxtAux1.Text
        Dim b As Boolean
        b = x.VerificarMultiplo(nu)

        TxtResultado.Text = b

    End Sub

    Private Sub VerificarSubMultiploToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarSubMultiploToolStripMenuItem.Click
        Dim nu = TxtAux1.Text
        Dim b As Boolean
        b = x.VerificarSubMultiplo(nu)
        TxtResultado.Text = b
    End Sub

    Private Sub VerificarFiboToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarFiboToolStripMenuItem.Click
        TxtResultado.Text = x.VerificarFibonacci
    End Sub
End Class
