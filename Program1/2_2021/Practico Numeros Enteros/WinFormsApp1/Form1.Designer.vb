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
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerificarParToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerificarMultiploToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerificarSubMultiploToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtAux1 = New System.Windows.Forms.TextBox()
        Me.VerificarFiboToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtN
        '
        Me.TxtN.Location = New System.Drawing.Point(139, 134)
        Me.TxtN.Name = "TxtN"
        Me.TxtN.Size = New System.Drawing.Size(100, 23)
        Me.TxtN.TabIndex = 0
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(353, 133)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(100, 23)
        Me.TxtResultado.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarToolStripMenuItem, Me.DescargarToolStripMenuItem, Me.VerificarParToolStripMenuItem, Me.VerificarMultiploToolStripMenuItem, Me.VerificarSubMultiploToolStripMenuItem, Me.VerificarFiboToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'CargarToolStripMenuItem
        '
        Me.CargarToolStripMenuItem.Name = "CargarToolStripMenuItem"
        Me.CargarToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.CargarToolStripMenuItem.Text = "Cargar"
        '
        'DescargarToolStripMenuItem
        '
        Me.DescargarToolStripMenuItem.Name = "DescargarToolStripMenuItem"
        Me.DescargarToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DescargarToolStripMenuItem.Text = "Descargar"
        '
        'VerificarParToolStripMenuItem
        '
        Me.VerificarParToolStripMenuItem.Name = "VerificarParToolStripMenuItem"
        Me.VerificarParToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.VerificarParToolStripMenuItem.Text = "Verificar Par"
        '
        'VerificarMultiploToolStripMenuItem
        '
        Me.VerificarMultiploToolStripMenuItem.Name = "VerificarMultiploToolStripMenuItem"
        Me.VerificarMultiploToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.VerificarMultiploToolStripMenuItem.Text = "Verificar Multiplo"
        '
        'VerificarSubMultiploToolStripMenuItem
        '
        Me.VerificarSubMultiploToolStripMenuItem.Name = "VerificarSubMultiploToolStripMenuItem"
        Me.VerificarSubMultiploToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.VerificarSubMultiploToolStripMenuItem.Text = "Verificar SubMultiplo"
        '
        'TxtAux1
        '
        Me.TxtAux1.Location = New System.Drawing.Point(139, 191)
        Me.TxtAux1.Name = "TxtAux1"
        Me.TxtAux1.Size = New System.Drawing.Size(100, 23)
        Me.TxtAux1.TabIndex = 3
        '
        'VerificarFiboToolStripMenuItem
        '
        Me.VerificarFiboToolStripMenuItem.Name = "VerificarFiboToolStripMenuItem"
        Me.VerificarFiboToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.VerificarFiboToolStripMenuItem.Text = "Verificar Fibo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtAux1)
        Me.Controls.Add(Me.TxtResultado)
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
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescargarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerificarParToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerificarMultiploToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtAux1 As TextBox
    Friend WithEvents VerificarSubMultiploToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerificarFiboToolStripMenuItem As ToolStripMenuItem
End Class
