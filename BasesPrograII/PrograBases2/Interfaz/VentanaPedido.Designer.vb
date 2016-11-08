<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaPedido
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.datapedidoTemporal = New System.Windows.Forms.DataGridView()
        Me.btnNuevoPedido = New System.Windows.Forms.Button()
        Me.btnVerClientes = New System.Windows.Forms.Button()
        Me.btnregistrarpedido = New System.Windows.Forms.Button()
        Me.cboIdEjecutivoPedido = New System.Windows.Forms.ComboBox()
        Me.VerEjecutivosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SISTEMA_DE_VENTASDataSet2 = New PrograBases2.SISTEMA_DE_VENTASDataSet2()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DTPentregapedido = New System.Windows.Forms.DateTimePicker()
        Me.txtcodigoclientepedido = New System.Windows.Forms.TextBox()
        Me.cboformadepagopedido = New System.Windows.Forms.ComboBox()
        Me.txtclientepedido = New System.Windows.Forms.TextBox()
        Me.DTPfechapedido = New System.Windows.Forms.DateTimePicker()
        Me.txtidpedido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnmodificarpedido = New System.Windows.Forms.Button()
        Me.VerEjecutivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SISTEMA_DE_VENTASDataSet1 = New PrograBases2.SISTEMA_DE_VENTASDataSet1()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnActualizarEditar = New System.Windows.Forms.Button()
        Me.btnActualizarProductoPedido = New System.Windows.Forms.Button()
        Me.sinDatos1 = New System.Windows.Forms.Label()
        Me.btneliminarpedido = New System.Windows.Forms.Button()
        Me.dataproductopedido = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.sinDatos = New System.Windows.Forms.Label()
        Me.btnagregarproductopedido = New System.Windows.Forms.Button()
        Me.dataproductospedido = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnEliminarelPedido = New System.Windows.Forms.Button()
        Me.btnCambiarEstado = New System.Windows.Forms.Button()
        Me.cboCambioEstadoPedido = New System.Windows.Forms.ComboBox()
        Me.btnAceptarCambios = New System.Windows.Forms.Button()
        Me.sinDatos2 = New System.Windows.Forms.Label()
        Me.datapedido = New System.Windows.Forms.DataGridView()
        Me.VerEjecutivosTableAdapter = New PrograBases2.SISTEMA_DE_VENTASDataSet1TableAdapters.VerEjecutivosTableAdapter()
        Me.VerEjecutivosTableAdapter1 = New PrograBases2.SISTEMA_DE_VENTASDataSet2TableAdapters.VerEjecutivosTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.datapedidoTemporal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerEjecutivosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SISTEMA_DE_VENTASDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerEjecutivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SISTEMA_DE_VENTASDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataproductopedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dataproductospedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.datapedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.datapedidoTemporal)
        Me.GroupBox1.Controls.Add(Me.btnNuevoPedido)
        Me.GroupBox1.Controls.Add(Me.btnVerClientes)
        Me.GroupBox1.Controls.Add(Me.btnregistrarpedido)
        Me.GroupBox1.Controls.Add(Me.cboIdEjecutivoPedido)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DTPentregapedido)
        Me.GroupBox1.Controls.Add(Me.txtcodigoclientepedido)
        Me.GroupBox1.Controls.Add(Me.cboformadepagopedido)
        Me.GroupBox1.Controls.Add(Me.txtclientepedido)
        Me.GroupBox1.Controls.Add(Me.DTPfechapedido)
        Me.GroupBox1.Controls.Add(Me.txtidpedido)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(16, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 335)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar Pedido"
        '
        'datapedidoTemporal
        '
        Me.datapedidoTemporal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datapedidoTemporal.Location = New System.Drawing.Point(354, 19)
        Me.datapedidoTemporal.Name = "datapedidoTemporal"
        Me.datapedidoTemporal.Size = New System.Drawing.Size(18, 16)
        Me.datapedidoTemporal.TabIndex = 28
        '
        'btnNuevoPedido
        '
        Me.btnNuevoPedido.Location = New System.Drawing.Point(34, 292)
        Me.btnNuevoPedido.Name = "btnNuevoPedido"
        Me.btnNuevoPedido.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevoPedido.TabIndex = 27
        Me.btnNuevoPedido.Text = "Nuevo"
        Me.btnNuevoPedido.UseVisualStyleBackColor = True
        '
        'btnVerClientes
        '
        Me.btnVerClientes.Location = New System.Drawing.Point(320, 105)
        Me.btnVerClientes.Name = "btnVerClientes"
        Me.btnVerClientes.Size = New System.Drawing.Size(30, 21)
        Me.btnVerClientes.TabIndex = 26
        Me.btnVerClientes.Text = "..."
        Me.btnVerClientes.UseVisualStyleBackColor = True
        '
        'btnregistrarpedido
        '
        Me.btnregistrarpedido.Location = New System.Drawing.Point(283, 290)
        Me.btnregistrarpedido.Name = "btnregistrarpedido"
        Me.btnregistrarpedido.Size = New System.Drawing.Size(89, 27)
        Me.btnregistrarpedido.TabIndex = 23
        Me.btnregistrarpedido.Text = "Registrar"
        Me.btnregistrarpedido.UseVisualStyleBackColor = True
        '
        'cboIdEjecutivoPedido
        '
        Me.cboIdEjecutivoPedido.DataSource = Me.VerEjecutivosBindingSource1
        Me.cboIdEjecutivoPedido.DisplayMember = "ID_PERSONAL"
        Me.cboIdEjecutivoPedido.FormattingEnabled = True
        Me.cboIdEjecutivoPedido.Location = New System.Drawing.Point(129, 231)
        Me.cboIdEjecutivoPedido.Name = "cboIdEjecutivoPedido"
        Me.cboIdEjecutivoPedido.Size = New System.Drawing.Size(185, 21)
        Me.cboIdEjecutivoPedido.TabIndex = 25
        Me.cboIdEjecutivoPedido.ValueMember = "ID_PERSONAL"
        '
        'VerEjecutivosBindingSource1
        '
        Me.VerEjecutivosBindingSource1.DataMember = "VerEjecutivos"
        Me.VerEjecutivosBindingSource1.DataSource = Me.SISTEMA_DE_VENTASDataSet2
        '
        'SISTEMA_DE_VENTASDataSet2
        '
        Me.SISTEMA_DE_VENTASDataSet2.DataSetName = "SISTEMA_DE_VENTASDataSet2"
        Me.SISTEMA_DE_VENTASDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "ID Ejecutivo"
        '
        'DTPentregapedido
        '
        Me.DTPentregapedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPentregapedido.Location = New System.Drawing.Point(129, 200)
        Me.DTPentregapedido.Name = "DTPentregapedido"
        Me.DTPentregapedido.Size = New System.Drawing.Size(185, 20)
        Me.DTPentregapedido.TabIndex = 17
        '
        'txtcodigoclientepedido
        '
        Me.txtcodigoclientepedido.Location = New System.Drawing.Point(129, 105)
        Me.txtcodigoclientepedido.Name = "txtcodigoclientepedido"
        Me.txtcodigoclientepedido.Size = New System.Drawing.Size(185, 20)
        Me.txtcodigoclientepedido.TabIndex = 16
        '
        'cboformadepagopedido
        '
        Me.cboformadepagopedido.FormattingEnabled = True
        Me.cboformadepagopedido.Items.AddRange(New Object() {"Contado", "Pago a 15 días", "Pago a 30 días"})
        Me.cboformadepagopedido.Location = New System.Drawing.Point(129, 164)
        Me.cboformadepagopedido.Name = "cboformadepagopedido"
        Me.cboformadepagopedido.Size = New System.Drawing.Size(185, 21)
        Me.cboformadepagopedido.TabIndex = 15
        '
        'txtclientepedido
        '
        Me.txtclientepedido.Location = New System.Drawing.Point(129, 132)
        Me.txtclientepedido.Name = "txtclientepedido"
        Me.txtclientepedido.Size = New System.Drawing.Size(185, 20)
        Me.txtclientepedido.TabIndex = 14
        '
        'DTPfechapedido
        '
        Me.DTPfechapedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPfechapedido.Location = New System.Drawing.Point(129, 74)
        Me.DTPfechapedido.Name = "DTPfechapedido"
        Me.DTPfechapedido.Size = New System.Drawing.Size(185, 20)
        Me.DTPfechapedido.TabIndex = 13
        '
        'txtidpedido
        '
        Me.txtidpedido.Location = New System.Drawing.Point(129, 43)
        Me.txtidpedido.Name = "txtidpedido"
        Me.txtidpedido.Size = New System.Drawing.Size(185, 20)
        Me.txtidpedido.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha de Entrega"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Codigo del Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Forma de Pago"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha del Pedido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID de Pedido"
        '
        'btnmodificarpedido
        '
        Me.btnmodificarpedido.Location = New System.Drawing.Point(1168, 65)
        Me.btnmodificarpedido.Name = "btnmodificarpedido"
        Me.btnmodificarpedido.Size = New System.Drawing.Size(112, 23)
        Me.btnmodificarpedido.TabIndex = 3
        Me.btnmodificarpedido.Text = "Modificar"
        Me.btnmodificarpedido.UseVisualStyleBackColor = True
        '
        'VerEjecutivosBindingSource
        '
        Me.VerEjecutivosBindingSource.DataMember = "VerEjecutivos"
        Me.VerEjecutivosBindingSource.DataSource = Me.SISTEMA_DE_VENTASDataSet1
        '
        'SISTEMA_DE_VENTASDataSet1
        '
        Me.SISTEMA_DE_VENTASDataSet1.DataSetName = "SISTEMA_DE_VENTASDataSet1"
        Me.SISTEMA_DE_VENTASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnActualizarEditar)
        Me.GroupBox2.Controls.Add(Me.btnActualizarProductoPedido)
        Me.GroupBox2.Controls.Add(Me.sinDatos1)
        Me.GroupBox2.Controls.Add(Me.btneliminarpedido)
        Me.GroupBox2.Controls.Add(Me.dataproductopedido)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(869, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 335)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos del Pedido"
        '
        'btnActualizarEditar
        '
        Me.btnActualizarEditar.Location = New System.Drawing.Point(160, 304)
        Me.btnActualizarEditar.Name = "btnActualizarEditar"
        Me.btnActualizarEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizarEditar.TabIndex = 29
        Me.btnActualizarEditar.Text = "Actualizar"
        Me.btnActualizarEditar.UseVisualStyleBackColor = True
        '
        'btnActualizarProductoPedido
        '
        Me.btnActualizarProductoPedido.Location = New System.Drawing.Point(67, 304)
        Me.btnActualizarProductoPedido.Name = "btnActualizarProductoPedido"
        Me.btnActualizarProductoPedido.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizarProductoPedido.TabIndex = 28
        Me.btnActualizarProductoPedido.Text = "Actualizar"
        Me.btnActualizarProductoPedido.UseVisualStyleBackColor = True
        '
        'sinDatos1
        '
        Me.sinDatos1.AutoSize = True
        Me.sinDatos1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sinDatos1.ForeColor = System.Drawing.Color.Blue
        Me.sinDatos1.Location = New System.Drawing.Point(87, 159)
        Me.sinDatos1.Name = "sinDatos1"
        Me.sinDatos1.Size = New System.Drawing.Size(267, 16)
        Me.sinDatos1.TabIndex = 27
        Me.sinDatos1.Text = "No se encuentran datos relacionados"
        '
        'btneliminarpedido
        '
        Me.btneliminarpedido.Location = New System.Drawing.Point(316, 304)
        Me.btneliminarpedido.Name = "btneliminarpedido"
        Me.btneliminarpedido.Size = New System.Drawing.Size(75, 23)
        Me.btneliminarpedido.TabIndex = 4
        Me.btneliminarpedido.Text = "Eliminar"
        Me.btneliminarpedido.UseVisualStyleBackColor = True
        '
        'dataproductopedido
        '
        Me.dataproductopedido.BackgroundColor = System.Drawing.Color.White
        Me.dataproductopedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataproductopedido.GridColor = System.Drawing.Color.White
        Me.dataproductopedido.Location = New System.Drawing.Point(6, 19)
        Me.dataproductopedido.Name = "dataproductopedido"
        Me.dataproductopedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataproductopedido.Size = New System.Drawing.Size(425, 279)
        Me.dataproductopedido.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.sinDatos)
        Me.GroupBox3.Controls.Add(Me.btnagregarproductopedido)
        Me.GroupBox3.Controls.Add(Me.dataproductospedido)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(414, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(452, 335)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Catalogo Productos"
        '
        'sinDatos
        '
        Me.sinDatos.AutoSize = True
        Me.sinDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sinDatos.ForeColor = System.Drawing.Color.Blue
        Me.sinDatos.Location = New System.Drawing.Point(93, 159)
        Me.sinDatos.Name = "sinDatos"
        Me.sinDatos.Size = New System.Drawing.Size(267, 16)
        Me.sinDatos.TabIndex = 27
        Me.sinDatos.Text = "No se encuentran datos relacionados"
        '
        'btnagregarproductopedido
        '
        Me.btnagregarproductopedido.Location = New System.Drawing.Point(333, 306)
        Me.btnagregarproductopedido.Name = "btnagregarproductopedido"
        Me.btnagregarproductopedido.Size = New System.Drawing.Size(75, 23)
        Me.btnagregarproductopedido.TabIndex = 1
        Me.btnagregarproductopedido.Text = "Agregar"
        Me.btnagregarproductopedido.UseVisualStyleBackColor = True
        '
        'dataproductospedido
        '
        Me.dataproductospedido.BackgroundColor = System.Drawing.Color.White
        Me.dataproductospedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataproductospedido.Location = New System.Drawing.Point(6, 19)
        Me.dataproductospedido.Name = "dataproductospedido"
        Me.dataproductospedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataproductospedido.Size = New System.Drawing.Size(440, 279)
        Me.dataproductospedido.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnEliminarelPedido)
        Me.GroupBox4.Controls.Add(Me.btnCambiarEstado)
        Me.GroupBox4.Controls.Add(Me.cboCambioEstadoPedido)
        Me.GroupBox4.Controls.Add(Me.btnAceptarCambios)
        Me.GroupBox4.Controls.Add(Me.sinDatos2)
        Me.GroupBox4.Controls.Add(Me.datapedido)
        Me.GroupBox4.Controls.Add(Me.btnmodificarpedido)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(12, 355)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1297, 273)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pedido"
        '
        'btnEliminarelPedido
        '
        Me.btnEliminarelPedido.Location = New System.Drawing.Point(1153, 162)
        Me.btnEliminarelPedido.Name = "btnEliminarelPedido"
        Me.btnEliminarelPedido.Size = New System.Drawing.Size(135, 23)
        Me.btnEliminarelPedido.TabIndex = 31
        Me.btnEliminarelPedido.Text = "Eliminar el Pedido"
        Me.btnEliminarelPedido.UseVisualStyleBackColor = True
        '
        'btnCambiarEstado
        '
        Me.btnCambiarEstado.Location = New System.Drawing.Point(1153, 241)
        Me.btnCambiarEstado.Name = "btnCambiarEstado"
        Me.btnCambiarEstado.Size = New System.Drawing.Size(135, 23)
        Me.btnCambiarEstado.TabIndex = 30
        Me.btnCambiarEstado.Text = "Cambiar Estado"
        Me.btnCambiarEstado.UseVisualStyleBackColor = True
        '
        'cboCambioEstadoPedido
        '
        Me.cboCambioEstadoPedido.FormattingEnabled = True
        Me.cboCambioEstadoPedido.Location = New System.Drawing.Point(1153, 214)
        Me.cboCambioEstadoPedido.Name = "cboCambioEstadoPedido"
        Me.cboCambioEstadoPedido.Size = New System.Drawing.Size(135, 21)
        Me.cboCambioEstadoPedido.TabIndex = 29
        '
        'btnAceptarCambios
        '
        Me.btnAceptarCambios.Location = New System.Drawing.Point(1168, 94)
        Me.btnAceptarCambios.Name = "btnAceptarCambios"
        Me.btnAceptarCambios.Size = New System.Drawing.Size(112, 23)
        Me.btnAceptarCambios.TabIndex = 28
        Me.btnAceptarCambios.Text = "Aceptar Cambios"
        Me.btnAceptarCambios.UseVisualStyleBackColor = True
        '
        'sinDatos2
        '
        Me.sinDatos2.AutoSize = True
        Me.sinDatos2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sinDatos2.ForeColor = System.Drawing.Color.Blue
        Me.sinDatos2.Location = New System.Drawing.Point(495, 138)
        Me.sinDatos2.Name = "sinDatos2"
        Me.sinDatos2.Size = New System.Drawing.Size(267, 16)
        Me.sinDatos2.TabIndex = 27
        Me.sinDatos2.Text = "No se encuentran datos relacionados"
        '
        'datapedido
        '
        Me.datapedido.BackgroundColor = System.Drawing.Color.White
        Me.datapedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datapedido.Location = New System.Drawing.Point(109, 19)
        Me.datapedido.Name = "datapedido"
        Me.datapedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datapedido.Size = New System.Drawing.Size(1038, 248)
        Me.datapedido.TabIndex = 24
        '
        'VerEjecutivosTableAdapter
        '
        Me.VerEjecutivosTableAdapter.ClearBeforeFill = True
        '
        'VerEjecutivosTableAdapter1
        '
        Me.VerEjecutivosTableAdapter1.ClearBeforeFill = True
        '
        'VentanaPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1317, 640)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "VentanaPedido"
        Me.Text = "Pedido"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.datapedidoTemporal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerEjecutivosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SISTEMA_DE_VENTASDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerEjecutivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SISTEMA_DE_VENTASDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dataproductopedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dataproductospedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.datapedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DTPentregapedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcodigoclientepedido As System.Windows.Forms.TextBox
    Friend WithEvents cboformadepagopedido As System.Windows.Forms.ComboBox
    Friend WithEvents txtclientepedido As System.Windows.Forms.TextBox
    Friend WithEvents DTPfechapedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtidpedido As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dataproductopedido As System.Windows.Forms.DataGridView
    Friend WithEvents cboIdEjecutivoPedido As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btneliminarpedido As System.Windows.Forms.Button
    Friend WithEvents btnmodificarpedido As System.Windows.Forms.Button
    Friend WithEvents btnVerClientes As System.Windows.Forms.Button
    Friend WithEvents btnregistrarpedido As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnagregarproductopedido As System.Windows.Forms.Button
    Friend WithEvents dataproductospedido As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents datapedido As System.Windows.Forms.DataGridView
    Friend WithEvents sinDatos1 As System.Windows.Forms.Label
    Friend WithEvents sinDatos As System.Windows.Forms.Label
    Friend WithEvents sinDatos2 As System.Windows.Forms.Label
    Friend WithEvents SISTEMA_DE_VENTASDataSet1 As PrograBases2.SISTEMA_DE_VENTASDataSet1
    Friend WithEvents VerEjecutivosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VerEjecutivosTableAdapter As PrograBases2.SISTEMA_DE_VENTASDataSet1TableAdapters.VerEjecutivosTableAdapter
    Friend WithEvents btnNuevoPedido As System.Windows.Forms.Button
    Friend WithEvents SISTEMA_DE_VENTASDataSet2 As PrograBases2.SISTEMA_DE_VENTASDataSet2
    Friend WithEvents VerEjecutivosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents VerEjecutivosTableAdapter1 As PrograBases2.SISTEMA_DE_VENTASDataSet2TableAdapters.VerEjecutivosTableAdapter
    Friend WithEvents datapedidoTemporal As System.Windows.Forms.DataGridView
    Friend WithEvents btnActualizarProductoPedido As System.Windows.Forms.Button
    Friend WithEvents btnActualizarEditar As System.Windows.Forms.Button
    Friend WithEvents btnAceptarCambios As System.Windows.Forms.Button
    Friend WithEvents btnCambiarEstado As System.Windows.Forms.Button
    Friend WithEvents cboCambioEstadoPedido As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminarelPedido As System.Windows.Forms.Button

End Class
