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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtIDCliente = New System.Windows.Forms.TextBox()
        Me.btnfacturarpedidos = New System.Windows.Forms.Button()
        Me.txtdireccionentregafactura = New System.Windows.Forms.TextBox()
        Me.DTPvencimientofactura = New System.Windows.Forms.DateTimePicker()
        Me.cbxcondicionpagofactura = New System.Windows.Forms.ComboBox()
        Me.DTPfechafactura = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.datafacturafinal = New System.Windows.Forms.DataGridView()
        Me.labelidfactura = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btneliminarfactura = New System.Windows.Forms.Button()
        Me.btnmodificarfactura = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btngenerarfactura = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtimpuestoaplicado = New System.Windows.Forms.TextBox()
        Me.txtdescuentoaplicado = New System.Windows.Forms.TextBox()
        Me.btnagregarafactura = New System.Windows.Forms.Button()
        Me.txtcantidadfacturada = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.nupcantidadafacturar = New System.Windows.Forms.NumericUpDown()
        Me.sinDatos = New System.Windows.Forms.Label()
        Me.txttotalapagar = New System.Windows.Forms.TextBox()
        Me.txtimpuesto = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbxidpedido = New System.Windows.Forms.ComboBox()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.txtcantidadpedida = New System.Windows.Forms.TextBox()
        Me.txtexistencias = New System.Windows.Forms.TextBox()
        Me.txtprecioventa = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtsku = New System.Windows.Forms.TextBox()
        Me.txtidano = New System.Windows.Forms.TextBox()
        Me.txtcorrelativo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataPedidosAFacturar = New System.Windows.Forms.DataGridView()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataCantidadFacturada = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datafacturafinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nupcantidadafacturar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataPedidosAFacturar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataCantidadFacturada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtIDCliente)
        Me.GroupBox1.Controls.Add(Me.btnfacturarpedidos)
        Me.GroupBox1.Controls.Add(Me.txtdireccionentregafactura)
        Me.GroupBox1.Controls.Add(Me.DTPvencimientofactura)
        Me.GroupBox1.Controls.Add(Me.cbxcondicionpagofactura)
        Me.GroupBox1.Controls.Add(Me.DTPfechafactura)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(14, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar Factura"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(341, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 20)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtIDCliente
        '
        Me.txtIDCliente.Location = New System.Drawing.Point(173, 19)
        Me.txtIDCliente.Name = "txtIDCliente"
        Me.txtIDCliente.Size = New System.Drawing.Size(162, 20)
        Me.txtIDCliente.TabIndex = 16
        '
        'btnfacturarpedidos
        '
        Me.btnfacturarpedidos.Location = New System.Drawing.Point(407, 148)
        Me.btnfacturarpedidos.Name = "btnfacturarpedidos"
        Me.btnfacturarpedidos.Size = New System.Drawing.Size(116, 23)
        Me.btnfacturarpedidos.TabIndex = 15
        Me.btnfacturarpedidos.Text = "Facturar pedidos"
        Me.btnfacturarpedidos.UseVisualStyleBackColor = True
        '
        'txtdireccionentregafactura
        '
        Me.txtdireccionentregafactura.Location = New System.Drawing.Point(173, 150)
        Me.txtdireccionentregafactura.Name = "txtdireccionentregafactura"
        Me.txtdireccionentregafactura.Size = New System.Drawing.Size(162, 20)
        Me.txtdireccionentregafactura.TabIndex = 13
        '
        'DTPvencimientofactura
        '
        Me.DTPvencimientofactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPvencimientofactura.Location = New System.Drawing.Point(173, 117)
        Me.DTPvencimientofactura.Name = "DTPvencimientofactura"
        Me.DTPvencimientofactura.Size = New System.Drawing.Size(162, 20)
        Me.DTPvencimientofactura.TabIndex = 12
        '
        'cbxcondicionpagofactura
        '
        Me.cbxcondicionpagofactura.FormattingEnabled = True
        Me.cbxcondicionpagofactura.Location = New System.Drawing.Point(173, 51)
        Me.cbxcondicionpagofactura.Name = "cbxcondicionpagofactura"
        Me.cbxcondicionpagofactura.Size = New System.Drawing.Size(162, 21)
        Me.cbxcondicionpagofactura.TabIndex = 11
        '
        'DTPfechafactura
        '
        Me.DTPfechafactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPfechafactura.Location = New System.Drawing.Point(173, 82)
        Me.DTPfechafactura.Name = "DTPfechafactura"
        Me.DTPfechafactura.Size = New System.Drawing.Size(162, 20)
        Me.DTPfechafactura.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Direccion de Entrega"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha de Vencimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Condición de Pago"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha de Factura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.datafacturafinal)
        Me.GroupBox2.Controls.Add(Me.labelidfactura)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Controls.Add(Me.TextBox17)
        Me.GroupBox2.Controls.Add(Me.TextBox16)
        Me.GroupBox2.Controls.Add(Me.TextBox15)
        Me.GroupBox2.Controls.Add(Me.TextBox14)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.txtDate)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.btneliminarfactura)
        Me.GroupBox2.Controls.Add(Me.btnmodificarfactura)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(800, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 623)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Factura"
        '
        'datafacturafinal
        '
        Me.datafacturafinal.AllowUserToDeleteRows = False
        Me.datafacturafinal.BackgroundColor = System.Drawing.Color.White
        Me.datafacturafinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datafacturafinal.Location = New System.Drawing.Point(15, 129)
        Me.datafacturafinal.Name = "datafacturafinal"
        Me.datafacturafinal.Size = New System.Drawing.Size(469, 220)
        Me.datafacturafinal.TabIndex = 34
        '
        'labelidfactura
        '
        Me.labelidfactura.AutoSize = True
        Me.labelidfactura.Location = New System.Drawing.Point(442, 84)
        Me.labelidfactura.Name = "labelidfactura"
        Me.labelidfactura.Size = New System.Drawing.Size(0, 13)
        Me.labelidfactura.TabIndex = 33
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(460, 23)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(24, 16)
        Me.DataGridView2.TabIndex = 32
        Me.DataGridView2.Visible = False
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(231, 520)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(100, 20)
        Me.TextBox17.TabIndex = 16
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(231, 485)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(100, 20)
        Me.TextBox16.TabIndex = 15
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(231, 449)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(100, 20)
        Me.TextBox15.TabIndex = 14
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(231, 413)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(100, 20)
        Me.TextBox14.TabIndex = 13
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(117, 523)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(84, 13)
        Me.Label27.TabIndex = 12
        Me.Label27.Text = "Total a Pagar"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(117, 488)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(91, 13)
        Me.Label26.TabIndex = 11
        Me.Label26.Text = "Total Impuesto"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(117, 452)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(68, 13)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "Descuento"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(117, 416)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(54, 13)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "Subtotal"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(235, 98)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(111, 13)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Aqui va el CLiente"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(152, 98)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 13)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Cliente:"
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.Location = New System.Drawing.Point(235, 66)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(105, 13)
        Me.txtDate.TabIndex = 6
        Me.txtDate.Text = "Aqui va getdate()"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(165, 67)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 13)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Fecha:"
        '
        'btneliminarfactura
        '
        Me.btneliminarfactura.Location = New System.Drawing.Point(423, 355)
        Me.btneliminarfactura.Name = "btneliminarfactura"
        Me.btneliminarfactura.Size = New System.Drawing.Size(75, 23)
        Me.btneliminarfactura.TabIndex = 4
        Me.btneliminarfactura.Text = "Eliminar"
        Me.btneliminarfactura.UseVisualStyleBackColor = True
        '
        'btnmodificarfactura
        '
        Me.btnmodificarfactura.Location = New System.Drawing.Point(340, 579)
        Me.btnmodificarfactura.Name = "btnmodificarfactura"
        Me.btnmodificarfactura.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificarfactura.TabIndex = 3
        Me.btnmodificarfactura.Text = "Facturar"
        Me.btnmodificarfactura.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(199, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Sistema de Ventas"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btngenerarfactura)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.txtimpuestoaplicado)
        Me.GroupBox3.Controls.Add(Me.txtdescuentoaplicado)
        Me.GroupBox3.Controls.Add(Me.btnagregarafactura)
        Me.GroupBox3.Controls.Add(Me.txtcantidadfacturada)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.nupcantidadafacturar)
        Me.GroupBox3.Controls.Add(Me.sinDatos)
        Me.GroupBox3.Controls.Add(Me.txttotalapagar)
        Me.GroupBox3.Controls.Add(Me.txtimpuesto)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.cbxidpedido)
        Me.GroupBox3.Controls.Add(Me.txtdescuento)
        Me.GroupBox3.Controls.Add(Me.txtsubtotal)
        Me.GroupBox3.Controls.Add(Me.txtcantidadpedida)
        Me.GroupBox3.Controls.Add(Me.txtexistencias)
        Me.GroupBox3.Controls.Add(Me.txtprecioventa)
        Me.GroupBox3.Controls.Add(Me.txtdescripcion)
        Me.GroupBox3.Controls.Add(Me.txtsku)
        Me.GroupBox3.Controls.Add(Me.txtidano)
        Me.GroupBox3.Controls.Add(Me.txtcorrelativo)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.DataPedidosAFacturar)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(16, 215)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(769, 430)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de Pedidos"
        '
        'btngenerarfactura
        '
        Me.btngenerarfactura.Location = New System.Drawing.Point(457, 408)
        Me.btngenerarfactura.Name = "btngenerarfactura"
        Me.btngenerarfactura.Size = New System.Drawing.Size(75, 23)
        Me.btngenerarfactura.TabIndex = 36
        Me.btngenerarfactura.Text = "Generar Factura"
        Me.btngenerarfactura.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(134, 382)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(13, 13)
        Me.Label30.TabIndex = 35
        Me.Label30.Text = "="
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(132, 349)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(13, 13)
        Me.Label29.TabIndex = 34
        Me.Label29.Text = "="
        '
        'txtimpuestoaplicado
        '
        Me.txtimpuestoaplicado.Location = New System.Drawing.Point(153, 379)
        Me.txtimpuestoaplicado.Name = "txtimpuestoaplicado"
        Me.txtimpuestoaplicado.Size = New System.Drawing.Size(72, 20)
        Me.txtimpuestoaplicado.TabIndex = 33
        '
        'txtdescuentoaplicado
        '
        Me.txtdescuentoaplicado.Location = New System.Drawing.Point(151, 346)
        Me.txtdescuentoaplicado.Name = "txtdescuentoaplicado"
        Me.txtdescuentoaplicado.Size = New System.Drawing.Size(74, 20)
        Me.txtdescuentoaplicado.TabIndex = 32
        '
        'btnagregarafactura
        '
        Me.btnagregarafactura.Location = New System.Drawing.Point(639, 401)
        Me.btnagregarafactura.Name = "btnagregarafactura"
        Me.btnagregarafactura.Size = New System.Drawing.Size(114, 23)
        Me.btnagregarafactura.TabIndex = 31
        Me.btnagregarafactura.Text = "Agregar a la Factura"
        Me.btnagregarafactura.UseVisualStyleBackColor = True
        '
        'txtcantidadfacturada
        '
        Me.txtcantidadfacturada.Location = New System.Drawing.Point(162, 285)
        Me.txtcantidadfacturada.Name = "txtcantidadfacturada"
        Me.txtcantidadfacturada.Size = New System.Drawing.Size(50, 20)
        Me.txtcantidadfacturada.TabIndex = 30
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(15, 288)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(130, 13)
        Me.Label28.TabIndex = 29
        Me.Label28.Text = "CANTIDAD FACTURADA"
        '
        'nupcantidadafacturar
        '
        Me.nupcantidadafacturar.Location = New System.Drawing.Point(122, 252)
        Me.nupcantidadafacturar.Name = "nupcantidadafacturar"
        Me.nupcantidadafacturar.Size = New System.Drawing.Size(90, 20)
        Me.nupcantidadafacturar.TabIndex = 28
        '
        'sinDatos
        '
        Me.sinDatos.AutoSize = True
        Me.sinDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sinDatos.ForeColor = System.Drawing.Color.Blue
        Me.sinDatos.Location = New System.Drawing.Point(356, 224)
        Me.sinDatos.Name = "sinDatos"
        Me.sinDatos.Size = New System.Drawing.Size(267, 16)
        Me.sinDatos.TabIndex = 27
        Me.sinDatos.Text = "No se encuentran datos relacionados"
        '
        'txttotalapagar
        '
        Me.txttotalapagar.Location = New System.Drawing.Point(135, 408)
        Me.txttotalapagar.Name = "txttotalapagar"
        Me.txttotalapagar.Size = New System.Drawing.Size(90, 20)
        Me.txttotalapagar.TabIndex = 26
        '
        'txtimpuesto
        '
        Me.txtimpuesto.Location = New System.Drawing.Point(98, 379)
        Me.txtimpuesto.Name = "txtimpuesto"
        Me.txtimpuesto.Size = New System.Drawing.Size(34, 20)
        Me.txtimpuesto.TabIndex = 25
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(15, 411)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 13)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Total a Pagar"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 382)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 13)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Total Impuesto"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(240, 28)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Pedido"
        '
        'cbxidpedido
        '
        Me.cbxidpedido.FormattingEnabled = True
        Me.cbxidpedido.Location = New System.Drawing.Point(359, 25)
        Me.cbxidpedido.Name = "cbxidpedido"
        Me.cbxidpedido.Size = New System.Drawing.Size(121, 21)
        Me.cbxidpedido.TabIndex = 21
        '
        'txtdescuento
        '
        Me.txtdescuento.Location = New System.Drawing.Point(92, 346)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(34, 20)
        Me.txtdescuento.TabIndex = 20
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(122, 316)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(90, 20)
        Me.txtsubtotal.TabIndex = 19
        '
        'txtcantidadpedida
        '
        Me.txtcantidadpedida.Location = New System.Drawing.Point(122, 219)
        Me.txtcantidadpedida.Name = "txtcantidadpedida"
        Me.txtcantidadpedida.Size = New System.Drawing.Size(90, 20)
        Me.txtcantidadpedida.TabIndex = 17
        '
        'txtexistencias
        '
        Me.txtexistencias.Location = New System.Drawing.Point(122, 190)
        Me.txtexistencias.Name = "txtexistencias"
        Me.txtexistencias.Size = New System.Drawing.Size(90, 20)
        Me.txtexistencias.TabIndex = 16
        '
        'txtprecioventa
        '
        Me.txtprecioventa.Location = New System.Drawing.Point(122, 161)
        Me.txtprecioventa.Name = "txtprecioventa"
        Me.txtprecioventa.Size = New System.Drawing.Size(90, 20)
        Me.txtprecioventa.TabIndex = 15
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(122, 132)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(90, 20)
        Me.txtdescripcion.TabIndex = 14
        '
        'txtsku
        '
        Me.txtsku.Location = New System.Drawing.Point(122, 103)
        Me.txtsku.Name = "txtsku"
        Me.txtsku.Size = New System.Drawing.Size(90, 20)
        Me.txtsku.TabIndex = 13
        '
        'txtidano
        '
        Me.txtidano.Location = New System.Drawing.Point(122, 76)
        Me.txtidano.Name = "txtidano"
        Me.txtidano.Size = New System.Drawing.Size(90, 20)
        Me.txtidano.TabIndex = 12
        '
        'txtcorrelativo
        '
        Me.txtcorrelativo.Location = New System.Drawing.Point(122, 47)
        Me.txtcorrelativo.Name = "txtcorrelativo"
        Me.txtcorrelativo.Size = New System.Drawing.Size(90, 20)
        Me.txtcorrelativo.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Id Correlativo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Id Año"
        '
        'DataPedidosAFacturar
        '
        Me.DataPedidosAFacturar.AllowUserToAddRows = False
        Me.DataPedidosAFacturar.AllowUserToDeleteRows = False
        Me.DataPedidosAFacturar.BackgroundColor = System.Drawing.Color.White
        Me.DataPedidosAFacturar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataPedidosAFacturar.Location = New System.Drawing.Point(243, 52)
        Me.DataPedidosAFacturar.Name = "DataPedidosAFacturar"
        Me.DataPedidosAFacturar.ReadOnly = True
        Me.DataPedidosAFacturar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataPedidosAFacturar.Size = New System.Drawing.Size(510, 350)
        Me.DataPedidosAFacturar.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 349)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 13)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Descuento"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 320)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Subtotal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 254)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Cantidad a Facturar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Cantidad Pedida"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Existencias"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Precio Venta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SKU"
        '
        'dataCantidadFacturada
        '
        Me.dataCantidadFacturada.AllowUserToAddRows = False
        Me.dataCantidadFacturada.AllowUserToDeleteRows = False
        Me.dataCantidadFacturada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataCantidadFacturada.Location = New System.Drawing.Point(627, 105)
        Me.dataCantidadFacturada.Name = "dataCantidadFacturada"
        Me.dataCantidadFacturada.ReadOnly = True
        Me.dataCantidadFacturada.Size = New System.Drawing.Size(114, 104)
        Me.dataCantidadFacturada.TabIndex = 31
        Me.dataCantidadFacturada.Visible = False
        '
        'VentanaFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1320, 640)
        Me.Controls.Add(Me.dataCantidadFacturada)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "VentanaFactura"
        Me.Text = "Form4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datafacturafinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nupcantidadafacturar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataPedidosAFacturar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataCantidadFacturada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdireccionentregafactura As System.Windows.Forms.TextBox
    Friend WithEvents DTPvencimientofactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxcondicionpagofactura As System.Windows.Forms.ComboBox
    Friend WithEvents DTPfechafactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnfacturarpedidos As System.Windows.Forms.Button
    Friend WithEvents btneliminarfactura As System.Windows.Forms.Button
    Friend WithEvents btnmodificarfactura As System.Windows.Forms.Button
    Friend WithEvents txtIDCliente As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdescuento As System.Windows.Forms.TextBox
    Friend WithEvents txtsubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidadpedida As System.Windows.Forms.TextBox
    Friend WithEvents txtexistencias As System.Windows.Forms.TextBox
    Friend WithEvents txtprecioventa As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtsku As System.Windows.Forms.TextBox
    Friend WithEvents txtidano As System.Windows.Forms.TextBox
    Friend WithEvents txtcorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents DataPedidosAFacturar As System.Windows.Forms.DataGridView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cbxidpedido As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtimpuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents sinDatos As System.Windows.Forms.Label
    Friend WithEvents nupcantidadafacturar As System.Windows.Forms.NumericUpDown
    Friend WithEvents txttotalapagar As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidadfacturada As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents dataCantidadFacturada As System.Windows.Forms.DataGridView
    Friend WithEvents btnagregarafactura As System.Windows.Forms.Button
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtimpuestoaplicado As System.Windows.Forms.TextBox
    Friend WithEvents txtdescuentoaplicado As System.Windows.Forms.TextBox
    Friend WithEvents btngenerarfactura As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents labelidfactura As System.Windows.Forms.Label
    Friend WithEvents datafacturafinal As System.Windows.Forms.DataGridView
End Class
