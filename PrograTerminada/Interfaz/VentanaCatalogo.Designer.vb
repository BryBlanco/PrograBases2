<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaCatalogo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtimpuestocatalogo = New System.Windows.Forms.TextBox()
        Me.txtexistenciascatalogo = New System.Windows.Forms.TextBox()
        Me.txtprecioventacatalogo = New System.Windows.Forms.TextBox()
        Me.txtcostounitariocatalogo = New System.Windows.Forms.TextBox()
        Me.txtdescripcionproductocatalogo = New System.Windows.Forms.TextBox()
        Me.txtidcatalogo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtbuscarproducto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnmodificarproducto = New System.Windows.Forms.Button()
        Me.btneliminarproducto = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtimpuestocatalogo)
        Me.GroupBox1.Controls.Add(Me.txtexistenciascatalogo)
        Me.GroupBox1.Controls.Add(Me.txtprecioventacatalogo)
        Me.GroupBox1.Controls.Add(Me.txtcostounitariocatalogo)
        Me.GroupBox1.Controls.Add(Me.txtdescripcionproductocatalogo)
        Me.GroupBox1.Controls.Add(Me.txtidcatalogo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(522, 488)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Catalogo de Productos"
        '
        'txtimpuestocatalogo
        '
        Me.txtimpuestocatalogo.Location = New System.Drawing.Point(191, 241)
        Me.txtimpuestocatalogo.Name = "txtimpuestocatalogo"
        Me.txtimpuestocatalogo.Size = New System.Drawing.Size(211, 20)
        Me.txtimpuestocatalogo.TabIndex = 11
        '
        'txtexistenciascatalogo
        '
        Me.txtexistenciascatalogo.Location = New System.Drawing.Point(191, 203)
        Me.txtexistenciascatalogo.Name = "txtexistenciascatalogo"
        Me.txtexistenciascatalogo.Size = New System.Drawing.Size(211, 20)
        Me.txtexistenciascatalogo.TabIndex = 10
        '
        'txtprecioventacatalogo
        '
        Me.txtprecioventacatalogo.Location = New System.Drawing.Point(191, 165)
        Me.txtprecioventacatalogo.Name = "txtprecioventacatalogo"
        Me.txtprecioventacatalogo.Size = New System.Drawing.Size(211, 20)
        Me.txtprecioventacatalogo.TabIndex = 9
        '
        'txtcostounitariocatalogo
        '
        Me.txtcostounitariocatalogo.Location = New System.Drawing.Point(191, 127)
        Me.txtcostounitariocatalogo.Name = "txtcostounitariocatalogo"
        Me.txtcostounitariocatalogo.Size = New System.Drawing.Size(211, 20)
        Me.txtcostounitariocatalogo.TabIndex = 8
        '
        'txtdescripcionproductocatalogo
        '
        Me.txtdescripcionproductocatalogo.Location = New System.Drawing.Point(191, 89)
        Me.txtdescripcionproductocatalogo.Name = "txtdescripcionproductocatalogo"
        Me.txtdescripcionproductocatalogo.Size = New System.Drawing.Size(211, 20)
        Me.txtdescripcionproductocatalogo.TabIndex = 7
        '
        'txtidcatalogo
        '
        Me.txtidcatalogo.Location = New System.Drawing.Point(191, 51)
        Me.txtidcatalogo.Name = "txtidcatalogo"
        Me.txtidcatalogo.Size = New System.Drawing.Size(211, 20)
        Me.txtidcatalogo.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(131, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Impuesto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(118, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Existencias"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio de Venta Unitario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Costo Unitario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion de Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID de Producto"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.btneliminarproducto)
        Me.GroupBox2.Controls.Add(Me.btnmodificarproducto)
        Me.GroupBox2.Controls.Add(Me.txtbuscarproducto)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(550, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(491, 488)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Producto"
        '
        'txtbuscarproducto
        '
        Me.txtbuscarproducto.Location = New System.Drawing.Point(177, 54)
        Me.txtbuscarproducto.Name = "txtbuscarproducto"
        Me.txtbuscarproducto.Size = New System.Drawing.Size(212, 20)
        Me.txtbuscarproducto.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(74, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Buscar Producto"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(6, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(479, 313)
        Me.DataGridView1.TabIndex = 0
        '
        'btnmodificarproducto
        '
        Me.btnmodificarproducto.Location = New System.Drawing.Point(64, 448)
        Me.btnmodificarproducto.Name = "btnmodificarproducto"
        Me.btnmodificarproducto.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificarproducto.TabIndex = 3
        Me.btnmodificarproducto.Text = "Modificar"
        Me.btnmodificarproducto.UseVisualStyleBackColor = True
        '
        'btneliminarproducto
        '
        Me.btneliminarproducto.Location = New System.Drawing.Point(349, 448)
        Me.btneliminarproducto.Name = "btneliminarproducto"
        Me.btneliminarproducto.Size = New System.Drawing.Size(75, 23)
        Me.btneliminarproducto.TabIndex = 4
        Me.btneliminarproducto.Text = "Eliminar"
        Me.btneliminarproducto.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1053, 522)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Catalogo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtimpuestocatalogo As System.Windows.Forms.TextBox
    Friend WithEvents txtexistenciascatalogo As System.Windows.Forms.TextBox
    Friend WithEvents txtprecioventacatalogo As System.Windows.Forms.TextBox
    Friend WithEvents txtcostounitariocatalogo As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcionproductocatalogo As System.Windows.Forms.TextBox
    Friend WithEvents txtidcatalogo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtbuscarproducto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btneliminarproducto As System.Windows.Forms.Button
    Friend WithEvents btnmodificarproducto As System.Windows.Forms.Button
End Class
