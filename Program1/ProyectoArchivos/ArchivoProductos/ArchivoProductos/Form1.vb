Public Class Form1
    Dim archivo As ArchivoProducto
    Dim nr, codigo As Int16
    Dim n As NEntero

    Private Sub NuevoArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoArchivoToolStripMenuItem.Click
        Dim nombreArchivo As String

        If SaveFileDialog1.ShowDialog Then
            nombreArchivo = SaveFileDialog1.FileName()
            archivo.Abrir(nombreArchivo)
            nr = 0
            codigo = nr + 1
            DGDatos.Rows.Item(0).Cells.Item(0).Value = codigo
        End If


    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        nr = nr + 1

        With DGDatos.Rows.Item(0).Cells
            archivo.Guardar(.Item(0).Value, .Item(1).Value, .Item(2).Value, .Item(3).Value, .Item(4).Value, nr, .Item(5).Value)
        End With
        codigo = nr + 1
        LimpiarDG()
        DGDatos.Rows.Item(0).Cells.Item(0).Value = codigo
        MsgBox("Producto guardado con exito")
    End Sub

    Private Sub LimpiarDG()
        DGDatos.Rows.Clear()
    End Sub

    Private Sub AccederArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccederArchivoToolStripMenuItem.Click
        Dim nombreArchivo As String
        Dim cod As Int16
        Dim desc, cant, costo As String
        Dim tipo As Char
        Dim nRegs As Integer
        Dim est As Boolean
        If OpenFileDialog1.ShowDialog Then
            nombreArchivo = OpenFileDialog1.FileName
            archivo.Abrir(nombreArchivo)

            nRegs = archivo.CantidadRegs()
            DGDatos.RowCount = nRegs

            For r = 1 To nRegs
                archivo.Leer(r, cod, desc, cant, costo, tipo, est)

                DGDatos.Rows.Item(r - 1).Cells.Item(0).Value = cod
                DGDatos.Rows.Item(r - 1).Cells.Item(1).Value = desc
                DGDatos.Rows.Item(r - 1).Cells.Item(2).Value = cant
                DGDatos.Rows.Item(r - 1).Cells.Item(3).Value = costo
                DGDatos.Rows.Item(r - 1).Cells.Item(4).Value = tipo
                DGDatos.Rows.Item(r - 1).Cells.Item(5).Value = est
            Next
            'archivo.Cerrar()
        End If
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        archivo.Cerrar()
    End Sub

    Private Sub ParesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParesToolStripMenuItem.Click
        Dim nombreArchivo As String
        Dim cod As Int16
        Dim desc, cant, costo As String
        Dim tipo As Char
        Dim nRegs As Integer
        Dim est As Boolean

        Dim fil = 0
        If OpenFileDialog1.ShowDialog Then
            nombreArchivo = OpenFileDialog1.FileName
            archivo.Abrir(nombreArchivo)

            nRegs = archivo.CantidadRegs()
            DGDatos.RowCount = 1

            For r = 1 To nRegs
                archivo.Leer(r, cod, desc, cant, costo, tipo, est)
                n.Cargar(cod)

                If n.EsPar Then

                    DGDatos.Rows.Item(fil).Cells.Item(0).Value = cod
                    DGDatos.Rows.Item(fil).Cells.Item(1).Value = desc
                    DGDatos.Rows.Item(fil).Cells.Item(2).Value = cant
                    DGDatos.Rows.Item(fil).Cells.Item(3).Value = costo
                    DGDatos.Rows.Item(fil).Cells.Item(4).Value = tipo
                    DGDatos.Rows.Item(fil).Cells.Item(5).Value = est
                    fil = fil + 1
                    DGDatos.RowCount = DGDatos.RowCount + 1
                End If


            Next
            archivo.Cerrar()
        End If
    End Sub

    Private Sub ImparesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImparesToolStripMenuItem.Click
        Dim nombreArchivo As String
        Dim cod As Int16
        Dim desc, cant, costo As String
        Dim tipo As Char
        Dim nRegs As Integer
        Dim est As Boolean

        Dim fil = 0
        If OpenFileDialog1.ShowDialog Then
            nombreArchivo = OpenFileDialog1.FileName
            archivo.Abrir(nombreArchivo)

            nRegs = archivo.CantidadRegs()
            DGDatos.RowCount = 1

            For r = 1 To nRegs
                archivo.Leer(r, cod, desc, cant, costo, tipo, est)
                n.Cargar(cod)

                If n.EsImpar Then

                    DGDatos.Rows.Item(fil).Cells.Item(0).Value = cod
                    DGDatos.Rows.Item(fil).Cells.Item(1).Value = desc
                    DGDatos.Rows.Item(fil).Cells.Item(2).Value = cant
                    DGDatos.Rows.Item(fil).Cells.Item(3).Value = costo
                    DGDatos.Rows.Item(fil).Cells.Item(4).Value = tipo
                    DGDatos.Rows.Item(fil).Cells.Item(5).Value = est
                    fil = fil + 1
                    DGDatos.RowCount = DGDatos.RowCount + 1
                End If


            Next
            archivo.Cerrar()
        End If
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim tipoBusqueda As String = TxtTipo.Text
        Dim costoTotal As Double = 0
        Dim prdTipo As String = ""
        Dim prdCant As Integer = 0
        Dim prdCost As Integer = 0
        If tipoBusqueda = "" Then
            MsgBox("Introducir dato")
        Else
            For i = 1 To DGDatos.RowCount
                prdTipo = DGDatos.Rows.Item(i - 1).Cells.Item(2).Value.ToString.Trim

                If prdTipo = tipoBusqueda Then
                    prdCant = Val(DGDatos.Rows.Item(i - 1).Cells.Item(3).Value)
                    prdCost = Val(DGDatos.Rows.Item(i - 1).Cells.Item(4).Value)

                    costoTotal = costoTotal + prdCant * prdCost
                End If

            Next

            TxtResultado.Text = "Costo total: " + costoTotal.ToString
        End If



    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DGDatos_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGDatos.CellEnter
        nr = e.RowIndex + 1
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        With DGDatos.Rows.Item(nr - 1).Cells
            archivo.Guardar(.Item(0).Value, .Item(1).Value, .Item(2).Value, .Item(3).Value, .Item(4).Value, nr, .Item(5).Value)
        End With
        MsgBox("Producto modificado con exito")
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        With DGDatos.Rows.Item(nr - 1).Cells
            archivo.Guardar(.Item(0).Value, .Item(1).Value, .Item(2).Value, .Item(3).Value, .Item(4).Value, nr, False)
        End With
        DGDatos.Rows.Item(nr - 1).Cells.Item(5).Value = False
        MsgBox("Producto eliminado con exito")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        archivo = New ArchivoProducto()
        n = New NEntero()
    End Sub
End Class
