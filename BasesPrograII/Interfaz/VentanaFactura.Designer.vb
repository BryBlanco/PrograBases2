<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaFactura
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtidfactura = New System.Windows.Forms.TextBox()
        Me.DTPfechafactura = New System.Windows.Forms.DateTimePicker()
        Me.cbxcondicionpagofactura = New System.Windows.Forms.ComboBox()
        Me.DTPvencimientofactura = New System.Windows.Forms.DateTimePicker()
        Me.txtdireccionentregafactura = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbuscarfactura = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cbxid = New System.Windows.Forms.ComboBox()
        Me.btnregistrarfactura = New System.Windows.Forms.Button()
        Me.btnmodificarfactura = New System.Windows.Forms.Button()
        Me.btneliminarfactura = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnregistrarfactura)
        Me.GroupBox1.Controls.Add(Me.cbxid)
        Me.GroupBox1.Controls.Add(Me.txtdireccionentregafactura)
        Me.GroupBox1.Controls.Add(Me.DTPvencimientofactura)
        Me.GroupBox1.Controls.Add(Me.cbxcondicionpagofactura)
        Me.GroupBox1.Controls.Add(Me.DTPfechafactura)
        Me.GroupBox1.Controls.Add(Me.txtidfactura)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(14, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 505)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar Factura"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Factura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha de Factura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Condición de Pago"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha de Vencimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(79, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Direccion de Entrega"
        '
        'txtidfactura
        '
        Me.txtidfactura.Location = New System.Drawing.Point(209, 63)
        Me.txtidfactura.Name = "txtidfactura"
        Me.txtidfactura.Size = New System.Drawing.Size(162, 20)
        Me.txtidfactura.TabIndex = 8
        '
        'DTPfechafactura
        '
        Me.DTPfechafactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPfechafactura.Location = New System.Drawing.Point(209, 131)
        Me.DTPfechafactura.Name = "DTPfechafactura"
        Me.DTPfechafactura.Size = New System.Drawing.Size(162, 20)
        Me.DTPfechafactura.TabIndex = 10
        '
        'cbxcondicionpagofactura
        '
        Me.cbxcondicionpagofactura.FormattingEnabled = True
        Me.cbxcondicionpagofactura.Location = New System.Drawing.Point(209, 162)
        Me.cbxcondicionpagofactura.Name = "cbxcondicionpagofactura"
        Me.cbxcondicionpagofactura.Size = New System.Drawing.Size(162, 21)
        Me.cbxcondicionpagofactura.TabIndex = 11
        '
        'DTPvencimientofactura
        '
        Me.DTPvencimientofactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPvencimientofactura.Location = New System.Drawing.Point(209, 195)
        Me.DTPvencimientofactura.Name = "DTPvencimientofactura"
        Me.DTPvencimientofactura.Size = New System.Drawing.Size(162, 20)
        Me.DTPvencimientofactura.TabIndex = 12
        '
        'txtdireccionentregafactura
        '
        Me.txtdireccionentregafactura.Location = New System.Drawing.Point(209, 228)
        Me.txtdireccionentregafactura.Name = "txtdireccionentregafactura"
        Me.txtdireccionentregafactura.Size = New System.Drawing.Size(162, 20)
        Me.txtdireccionentregafactura.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btneliminarfactura)
        Me.GroupBox2.Controls.Add(Me.btnmodificarfactura)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.txtbuscarfactura)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(532, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 504)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Factura"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(104, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Buscar Factura"
        '
        'txtbuscarfactura
        '
        Me.txtbuscarfactura.Location = New System.Drawing.Point(198, 63)
        Me.txtbuscarfactura.Name = "txtbuscarfactura"
        Me.txtbuscarfactura.Size = New System.Drawing.Size(188, 20)
        Me.txtbuscarfactura.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(492, 353)
        Me.DataGridView1.TabIndex = 2
        '
        'cbxid
        '
        Me.cbxid.FormattingEnabled = True
        Me.cbxid.Location = New System.Drawing.Point(209, 98)
        Me.cbxid.Name = "cbxid"
        Me.cbxid.Size = New System.Drawing.Size(162, 21)
        Me.cbxid.TabIndex = 14
        '
        'btnregistrarfactura
        '
        Me.btnregistrarfactura.Location = New System.Drawing.Point(357, 451)
        Me.btnregistrarfactura.Name = "btnregistrarfactura"
        Me.btnregistrarfactura.Size = New System.Drawing.Size(75, 23)
        Me.btnregistrarfactura.TabIndex = 15
        Me.btnregistrarfactura.Text = "Registrar"
        Me.btnregistrarfactura.UseVisualStyleBackColor = True
        '
        'btnmodificarfactura
        '
        Me.btnmodificarfactura.Location = New System.Drawing.Point(83, 464)
        Me.btnmodificarfactura.Name = "btnmodificarfactura"
        Me.btnmodificarfactura.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificarfactura.TabIndex = 3
        Me.btnmodificarfactura.Text = "Modificar"
        Me.btnmodificarfactura.UseVisualStyleBackColor = True
        '
        'btneliminarfactura
        '
        Me.btneliminarfactura.Location = New System.Drawing.Point(345, 464)
        Me.btneliminarfactura.Name = "btneliminarfactura"
        Me.btneliminarfactura.Size = New System.Drawing.Size(75, 23)
        Me.btneliminarfactura.TabIndex = 4
        Me.btneliminarfactura.Text = "Eliminar"
        Me.btneliminarfactura.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1045, 524)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form4"
        Me.Text = "Form4"
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
    Friend WithEvents txtdireccionentregafactura As System.Windows.Forms.TextBox
    Friend WithEvents DTPvencimientofactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxcondicionpagofactura As System.Windows.Forms.ComboBox
    Friend WithEvents DTPfechafactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtidfactura As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtbuscarfactura As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnregistrarfactura As System.Windows.Forms.Button
    Friend WithEvents cbxid As System.Windows.Forms.ComboBox
    Friend WithEvents btneliminarfactura As System.Windows.Forms.Button
    Friend WithEvents btnmodificarfactura As System.Windows.Forms.Button
End Class
