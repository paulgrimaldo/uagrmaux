<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcumularPrimosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CantidadElementosUnicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarRandomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CantidadPrimosPorFilaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SegmentarPrimosNoPrimosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenarColumnasDeAcuerdoAFilaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerificarColumnasOrdenadasAbajoAArribaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenarMatrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenarInversoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerificarMatrizOrdenadaInferiorIzquierdaADerechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargaManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargaManualToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtNF = New System.Windows.Forms.TextBox()
        Me.TxtNC = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.SegmentarMatrizPorFrecuenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MatrizToolStripMenuItem, Me.CargaManualToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MatrizToolStripMenuItem
        '
        Me.MatrizToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarToolStripMenuItem, Me.DescargarToolStripMenuItem, Me.AcumularPrimosToolStripMenuItem, Me.CantidadElementosUnicosToolStripMenuItem, Me.CargarRandomToolStripMenuItem, Me.CantidadPrimosPorFilaToolStripMenuItem, Me.SegmentarPrimosNoPrimosToolStripMenuItem, Me.OrdenarColumnasDeAcuerdoAFilaToolStripMenuItem, Me.VerificarColumnasOrdenadasAbajoAArribaToolStripMenuItem, Me.OrdenarMatrToolStripMenuItem, Me.OrdenarInversoToolStripMenuItem, Me.VerificarMatrizOrdenadaInferiorIzquierdaADerechaToolStripMenuItem, Me.SegmentarMatrizPorFrecuenciaToolStripMenuItem})
        Me.MatrizToolStripMenuItem.Name = "MatrizToolStripMenuItem"
        Me.MatrizToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.MatrizToolStripMenuItem.Text = "Matriz"
        '
        'CargarToolStripMenuItem
        '
        Me.CargarToolStripMenuItem.Name = "CargarToolStripMenuItem"
        Me.CargarToolStripMenuItem.Size = New System.Drawing.Size(351, 22)
        Me.CargarToolStripMenuItem.Text = "Cargar"
        '
        'DescargarToolStripMenuItem
        '
        Me.DescargarToolStripMenuItem.Name = "DescargarToolStripMenuItem"
        Me.DescargarToolStripMenuItem.Size = New System.Drawing.Size(351, 22)
        Me.DescargarToolStripMenuItem.Text = "Descargar"
        '
        'AcumularPrimosToolStripMenuItem
        '
        Me.AcumularPrimosToolStripMenuItem.Name = "AcumularPrimosToolStripMenuItem"
        Me.AcumularPrimosToolStripMenuItem.Size = New System.Drawing.Size(351, 22)
        Me.AcumularPrimosToolStripMenuItem.Text = "Acumular primos"
        '
        'CantidadElementosUnicosToolStripMenuItem
        '
        Me.CantidadElementosUnicosToolStripMenuItem.Name = "CantidadElementosUnicosToolStripMenuItem"
        Me.CantidadElementosUnicosToolStripMenuItem.Size = New System.Drawing.Size(351, 22)
        Me.CantidadElementosUnicosToolStripMenuItem.Text = "Cantidad elementos unicos"
        '
        'CargarRandomToolStripMenuItem
        '
        Me.CargarRandomToolStripMenuItem.Name = "CargarRandomToolStripMenuItem"
        Me.CargarRandomToolStripMenuItem.Size = New System.Drawing.Size(351, 22)
        Me.CargarRandomToolStripMenuItem.Text = "Cargar Random"
        '
        'CantidadPrimosPorFilaToolStripMenuItem
        '
        Me.CantidadPrimosPorFilaToolStripMenuItem.Name = "CantidadPrimosPorFilaToolStripMenuItem"
        Me.CantidadPrimosPorFilaToolStripMenuItem.Size = New System.Drawing.Size(351, 22)
        Me.CantidadPrimosPorFilaToolStripMenuItem.Text = "Cantidad Primos Por Fila"
        '
        'SegmentarPrimosNoPrimosToolStripMenuItem
        '
        Me.SegmentarPrimosNoPrimosToolStripMenuItem.Name = "SegmentarPrimosNoPrimosToolStripMenuItem"
        Me.SegmentarPrimosNoPrimosToolStripMenuItem.Size = New System.Drawing.Size(351, 22)
        Me.SegmentarPrimosNoPrimosToolStripMenuItem.Text = "Segmentar Pares Impares"
        '
        'OrdenarColumnasDeAcuerdoAFilaToolStripMenuItem
        '
        Me.OrdenarColumnasDeAcuerdoAFilaToolStripMenuItem.Name = "OrdenarColumnasDeAcuerdoAFilaToolStripMenuItem"
        Me.OrdenarColumnasDeAcuerdoAFilaToolStripMenuItem.Size = New System.Drawing.Size(351, 22)
        Me.OrdenarColumnasDeAcuerdoAFilaToolStripMenuItem.Text = "Ordenar columnas de acuerdo a fila"
        '
        'VerificarColumnasOrdenadasAbajoAArribaToolStripMenuItem
        '
        Me.VerificarColumnasOrdenadasAbajoAArribaToolStripMenuItem.Name = "VerificarColumnasOrdenadasAbajoAArribaToolStripMenuItem"
        Me.VerificarColumnasOrdenadasAbajoAArribaToolStripMenuItem.Size = New System.Drawing.Size(351, 22)
        Me.VerificarColumnasOrdenadasAbajoAArribaToolStripMenuItem.Text = "Verificar Columnas ordenadas abajo a arriba"
        '
        'OrdenarMatrToolStripMenuItem
        '
        Me.OrdenarMatrToolStripMenuItem.Name = "OrdenarMatrToolStripMenuItem"
        Me.OrdenarMatrToolStripMenuItem.Size = New System.Drawing.Size(351, 22)
        Me.OrdenarMatrToolStripMenuItem.Text = "Ordenar filas por cantidad primos"
        '
        'OrdenarInversoToolStripMenuItem
        '
        Me.OrdenarInversoToolStripMenuItem.Name = "OrdenarInversoToolStripMenuItem"
        Me.OrdenarInversoToolStripMenuItem.Size = New System.Drawing.Size(351, 22)
        Me.OrdenarInversoToolStripMenuItem.Text = "Ordenar desde el final al inicio"
        '
        'VerificarMatrizOrdenadaInferiorIzquierdaADerechaToolStripMenuItem
        '
        Me.VerificarMatrizOrdenadaInferiorIzquierdaADerechaToolStripMenuItem.Name = "VerificarMatrizOrdenadaInferiorIzquierdaADerechaToolStripMenuItem"
        Me.VerificarMatrizOrdenadaInferiorIzquierdaADerechaToolStripMenuItem.Size = New System.Drawing.Size(351, 22)
        Me.VerificarMatrizOrdenadaInferiorIzquierdaADerechaToolStripMenuItem.Text = "Verificar Matriz ordenada inferior izquierda a derecha"
        '
        'CargaManualToolStripMenuItem
        '
        Me.CargaManualToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargaManualToolStripMenuItem1})
        Me.CargaManualToolStripMenuItem.Name = "CargaManualToolStripMenuItem"
        Me.CargaManualToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.CargaManualToolStripMenuItem.Text = "Carga"
        '
        'CargaManualToolStripMenuItem1
        '
        Me.CargaManualToolStripMenuItem1.Name = "CargaManualToolStripMenuItem1"
        Me.CargaManualToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.CargaManualToolStripMenuItem1.Text = "Carga Manual"
        '
        'TxtNF
        '
        Me.TxtNF.Location = New System.Drawing.Point(32, 67)
        Me.TxtNF.Name = "TxtNF"
        Me.TxtNF.Size = New System.Drawing.Size(100, 23)
        Me.TxtNF.TabIndex = 2
        '
        'TxtNC
        '
        Me.TxtNC.Location = New System.Drawing.Point(177, 66)
        Me.TxtNC.Name = "TxtNC"
        Me.TxtNC.Size = New System.Drawing.Size(100, 23)
        Me.TxtNC.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(313, 67)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 23)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(452, 67)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 23)
        Me.TextBox4.TabIndex = 5
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(225, 241)
        Me.TxtResultado.Multiline = True
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(262, 97)
        Me.TxtResultado.TabIndex = 6
        '
        'SegmentarMatrizPorFrecuenciaToolStripMenuItem
        '
        Me.SegmentarMatrizPorFrecuenciaToolStripMenuItem.Name = "SegmentarMatrizPorFrecuenciaToolStripMenuItem"
        Me.SegmentarMatrizPorFrecuenciaToolStripMenuItem.Size = New System.Drawing.Size(351, 22)
        Me.SegmentarMatrizPorFrecuenciaToolStripMenuItem.Text = "Segmentar Matriz por Frecuencia"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TxtNC)
        Me.Controls.Add(Me.TxtNF)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MatrizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescargarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtNF As TextBox
    Friend WithEvents TxtNC As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents AcumularPrimosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CantidadElementosUnicosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarRandomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CantidadPrimosPorFilaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SegmentarPrimosNoPrimosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenarColumnasDeAcuerdoAFilaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerificarColumnasOrdenadasAbajoAArribaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargaManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargaManualToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OrdenarMatrToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenarInversoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerificarMatrizOrdenadaInferiorIzquierdaADerechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SegmentarMatrizPorFrecuenciaToolStripMenuItem As ToolStripMenuItem
End Class
