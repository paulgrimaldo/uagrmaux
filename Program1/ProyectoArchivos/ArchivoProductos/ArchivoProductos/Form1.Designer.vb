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
        Me.DGDatos = New System.Windows.Forms.DataGridView()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Est = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccederArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImparesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        CType(Me.DGDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGDatos
        '
        Me.DGDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod, Me.Desc, Me.Tipo, Me.Cant, Me.Costo, Me.Est})
        Me.DGDatos.Location = New System.Drawing.Point(46, 139)
        Me.DGDatos.Name = "DGDatos"
        Me.DGDatos.RowTemplate.Height = 25
        Me.DGDatos.Size = New System.Drawing.Size(611, 106)
        Me.DGDatos.TabIndex = 0
        '
        'Cod
        '
        Me.Cod.HeaderText = "Cod"
        Me.Cod.Name = "Cod"
        '
        'Desc
        '
        Me.Desc.HeaderText = "Desc"
        Me.Desc.Name = "Desc"
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'Cant
        '
        Me.Cant.HeaderText = "Cant"
        Me.Cant.Name = "Cant"
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        '
        'Est
        '
        Me.Est.HeaderText = "Est"
        Me.Est.Name = "Est"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.SeleccionarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoArchivoToolStripMenuItem, Me.AccederArchivoToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'NuevoArchivoToolStripMenuItem
        '
        Me.NuevoArchivoToolStripMenuItem.Name = "NuevoArchivoToolStripMenuItem"
        Me.NuevoArchivoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NuevoArchivoToolStripMenuItem.Text = "Nuevo archivo"
        '
        'AccederArchivoToolStripMenuItem
        '
        Me.AccederArchivoToolStripMenuItem.Name = "AccederArchivoToolStripMenuItem"
        Me.AccederArchivoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AccederArchivoToolStripMenuItem.Text = "Acceder archivo"
        '
        'SeleccionarToolStripMenuItem
        '
        Me.SeleccionarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParesToolStripMenuItem, Me.ImparesToolStripMenuItem})
        Me.SeleccionarToolStripMenuItem.Name = "SeleccionarToolStripMenuItem"
        Me.SeleccionarToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.SeleccionarToolStripMenuItem.Text = "Seleccionar"
        '
        'ParesToolStripMenuItem
        '
        Me.ParesToolStripMenuItem.Name = "ParesToolStripMenuItem"
        Me.ParesToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ParesToolStripMenuItem.Text = "Pares"
        '
        'ImparesToolStripMenuItem
        '
        Me.ImparesToolStripMenuItem.Name = "ImparesToolStripMenuItem"
        Me.ImparesToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ImparesToolStripMenuItem.Text = "Impares"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(674, 139)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 2
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(674, 182)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCerrar.TabIndex = 3
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TxtTipo
        '
        Me.TxtTipo.Location = New System.Drawing.Point(46, 300)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.Size = New System.Drawing.Size(132, 23)
        Me.TxtTipo.TabIndex = 4
        Me.TxtTipo.Text = "Introducir el tipo"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(202, 300)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcular.TabIndex = 5
        Me.BtnCalcular.Text = "Calcular costo"
        Me.BtnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(46, 344)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(100, 23)
        Me.TxtResultado.TabIndex = 6
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(381, 299)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 8
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(381, 329)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 9
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.TxtTipo)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.DGDatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGDatos As DataGridView
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents Desc As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Cant As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents Est As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccederArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SeleccionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImparesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtTipo As TextBox
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
End Class
