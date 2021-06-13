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
        Me.TxtN = New System.Windows.Forms.TextBox()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EjerciciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargadoEnPotenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarRandomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MayorEnPosicionMMultiploToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescargarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SegmentarPrimosYNoPrimosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.VerificarVectorPrimosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtN
        '
        Me.TxtN.Location = New System.Drawing.Point(43, 63)
        Me.TxtN.Name = "TxtN"
        Me.TxtN.Size = New System.Drawing.Size(100, 23)
        Me.TxtN.TabIndex = 0
        Me.TxtN.Text = "N"
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(194, 63)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(100, 23)
        Me.Txt1.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EjerciciosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EjerciciosToolStripMenuItem
        '
        Me.EjerciciosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargadoEnPotenciaToolStripMenuItem, Me.CargarRandomToolStripMenuItem, Me.DescargarToolStripMenuItem, Me.MayorEnPosicionMMultiploToolStripMenuItem, Me.DescargarToolStripMenuItem1, Me.SegmentarPrimosYNoPrimosToolStripMenuItem, Me.VerificarVectorPrimosToolStripMenuItem})
        Me.EjerciciosToolStripMenuItem.Name = "EjerciciosToolStripMenuItem"
        Me.EjerciciosToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.EjerciciosToolStripMenuItem.Text = "Ejercicios"
        '
        'CargadoEnPotenciaToolStripMenuItem
        '
        Me.CargadoEnPotenciaToolStripMenuItem.Name = "CargadoEnPotenciaToolStripMenuItem"
        Me.CargadoEnPotenciaToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.CargadoEnPotenciaToolStripMenuItem.Text = "Cargado en potencia"
        '
        'CargarRandomToolStripMenuItem
        '
        Me.CargarRandomToolStripMenuItem.Name = "CargarRandomToolStripMenuItem"
        Me.CargarRandomToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.CargarRandomToolStripMenuItem.Text = "Cargar random"
        '
        'DescargarToolStripMenuItem
        '
        Me.DescargarToolStripMenuItem.Name = "DescargarToolStripMenuItem"
        Me.DescargarToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.DescargarToolStripMenuItem.Text = "Posiciones submultiplo"
        '
        'MayorEnPosicionMMultiploToolStripMenuItem
        '
        Me.MayorEnPosicionMMultiploToolStripMenuItem.Name = "MayorEnPosicionMMultiploToolStripMenuItem"
        Me.MayorEnPosicionMMultiploToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.MayorEnPosicionMMultiploToolStripMenuItem.Text = "Mayor en posicion M multiplo"
        '
        'DescargarToolStripMenuItem1
        '
        Me.DescargarToolStripMenuItem1.Name = "DescargarToolStripMenuItem1"
        Me.DescargarToolStripMenuItem1.Size = New System.Drawing.Size(236, 22)
        Me.DescargarToolStripMenuItem1.Text = "Descargar"
        '
        'SegmentarPrimosYNoPrimosToolStripMenuItem
        '
        Me.SegmentarPrimosYNoPrimosToolStripMenuItem.Name = "SegmentarPrimosYNoPrimosToolStripMenuItem"
        Me.SegmentarPrimosYNoPrimosToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.SegmentarPrimosYNoPrimosToolStripMenuItem.Text = "Segmentar Primos y NoPrimos"
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(38, 168)
        Me.TxtResultado.Multiline = True
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(300, 93)
        Me.TxtResultado.TabIndex = 4
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(319, 66)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(100, 23)
        Me.Txt2.TabIndex = 5
        '
        'VerificarVectorPrimosToolStripMenuItem
        '
        Me.VerificarVectorPrimosToolStripMenuItem.Name = "VerificarVectorPrimosToolStripMenuItem"
        Me.VerificarVectorPrimosToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.VerificarVectorPrimosToolStripMenuItem.Text = "Verificar vector primos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.TxtN)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtN As TextBox
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EjerciciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargadoEnPotenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents CargarRandomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescargarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents MayorEnPosicionMMultiploToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescargarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SegmentarPrimosYNoPrimosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerificarVectorPrimosToolStripMenuItem As ToolStripMenuItem
End Class
