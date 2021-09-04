Public Class ArchivoProducto
    Private Narch As String
    Private nr As Int16
    Private nc As Int16
    Private reg As RegProd

    Structure RegProd
        Public cod As Int16
        <VBFixedString(20)> Public desc As String
        <VBFixedString(20)> Public cant As String
        <VBFixedString(20)> Public costo As String
        Public tipo As Char
        Public est As Boolean
    End Structure

    Public Sub ArchivoProducto()
        Narch = ""
    End Sub

    Public Sub Abrir(archivo As String)
        Me.Narch = archivo
        nc = FreeFile()
        FileOpen(nc, Me.Narch, OpenMode.Random, , , Len(reg))
    End Sub

    Public Sub Cerrar()
        FileClose(nc)
    End Sub

    Public Sub Guardar(cod As String, desc As String, cant As String, costo As String, tipo As String, nr As Int16, est As Boolean)
        Me.nr = nr
        'reg.cod = cod
        'reg.cant = cant
        With reg
            .cod = cod
            .cant = cant
            .desc = desc
            .tipo = tipo
            .costo = costo
            .est = est
        End With
        FilePut(nc, reg, nr)
    End Sub

    Public Sub Leer(nr As Int16, ByRef cod As String, ByRef desc As String, ByRef cant As String, ByRef costo As String, ByRef tipo As String, ByRef est As Boolean)
        Me.nr = nr
        FileGet(nc, reg, nr)
        'cod = reg.cod
        'desc = reg.desc

        With reg
            cod = .cod
            desc = .desc
            cant = .cant
            tipo = .tipo
            costo = .costo
            est = .est
        End With


    End Sub

    Public Function CantidadRegs() As Int16
        Return FileLen(Narch) / Len(reg)
    End Function
End Class
