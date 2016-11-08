<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroCliente
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnEditarCliente = New System.Windows.Forms.Button()
        Me.btnRegistrarCliente = New System.Windows.Forms.Button()
        Me.DTPFechaRelaciónCliente = New System.Windows.Forms.DateTimePicker()
        Me.txtCorreoCliente = New System.Windows.Forms.TextBox()
        Me.txtDirecciónEntregaCliente = New System.Windows.Forms.TextBox()
        Me.txtLimiteCliente = New System.Windows.Forms.TextBox()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.txtPostalCliente = New System.Windows.Forms.TextBox()
        Me.txtDirecciónCliente = New System.Windows.Forms.TextBox()
        Me.cboPaisCliente = New System.Windows.Forms.ComboBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.sinDatos = New System.Windows.Forms.Label()
        Me.DataCliente = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnEditarCliente)
        Me.GroupBox1.Controls.Add(Me.btnRegistrarCliente)
        Me.GroupBox1.Controls.Add(Me.DTPFechaRelaciónCliente)
        Me.GroupBox1.Controls.Add(Me.txtCorreoCliente)
        Me.GroupBox1.Controls.Add(Me.txtDirecciónEntregaCliente)
        Me.GroupBox1.Controls.Add(Me.txtLimiteCliente)
        Me.GroupBox1.Controls.Add(Me.txtTelefonoCliente)
        Me.GroupBox1.Controls.Add(Me.txtPostalCliente)
        Me.GroupBox1.Controls.Add(Me.txtDirecciónCliente)
        Me.GroupBox1.Controls.Add(Me.cboPaisCliente)
        Me.GroupBox1.Controls.Add(Me.txtNombreCliente)
        Me.GroupBox1.Controls.Add(Me.txtCodigoCliente)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 412)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar Cliente"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(49, 370)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Nuevo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnEditarCliente
        '
        Me.btnEditarCliente.Location = New System.Drawing.Point(196, 370)
        Me.btnEditarCliente.Name = "btnEditarCliente"
        Me.btnEditarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnEditarCliente.TabIndex = 24
        Me.btnEditarCliente.Text = "Editar"
        Me.btnEditarCliente.UseVisualStyleBackColor = True
        '
        'btnRegistrarCliente
        '
        Me.btnRegistrarCliente.Location = New System.Drawing.Point(344, 370)
        Me.btnRegistrarCliente.Name = "btnRegistrarCliente"
        Me.btnRegistrarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrarCliente.TabIndex = 23
        Me.btnRegistrarCliente.Text = "Registrar"
        Me.btnRegistrarCliente.UseVisualStyleBackColor = True
        '
        'DTPFechaRelaciónCliente
        '
        Me.DTPFechaRelaciónCliente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaRelaciónCliente.Location = New System.Drawing.Point(139, 322)
        Me.DTPFechaRelaciónCliente.Name = "DTPFechaRelaciónCliente"
        Me.DTPFechaRelaciónCliente.Size = New System.Drawing.Size(189, 20)
        Me.DTPFechaRelaciónCliente.TabIndex = 21
        '
        'txtCorreoCliente
        '
        Me.txtCorreoCliente.Location = New System.Drawing.Point(139, 294)
        Me.txtCorreoCliente.Name = "txtCorreoCliente"
        Me.txtCorreoCliente.Size = New System.Drawing.Size(189, 20)
        Me.txtCorreoCliente.TabIndex = 20
        '
        'txtDirecciónEntregaCliente
        '
        Me.txtDirecciónEntregaCliente.Location = New System.Drawing.Point(139, 259)
        Me.txtDirecciónEntregaCliente.Name = "txtDirecciónEntregaCliente"
        Me.txtDirecciónEntregaCliente.Size = New System.Drawing.Size(189, 20)
        Me.txtDirecciónEntregaCliente.TabIndex = 19
        '
        'txtLimiteCliente
        '
        Me.txtLimiteCliente.Location = New System.Drawing.Point(139, 228)
        Me.txtLimiteCliente.Name = "txtLimiteCliente"
        Me.txtLimiteCliente.Size = New System.Drawing.Size(189, 20)
        Me.txtLimiteCliente.TabIndex = 18
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(139, 191)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(189, 20)
        Me.txtTelefonoCliente.TabIndex = 17
        '
        'txtPostalCliente
        '
        Me.txtPostalCliente.Location = New System.Drawing.Point(139, 157)
        Me.txtPostalCliente.Name = "txtPostalCliente"
        Me.txtPostalCliente.Size = New System.Drawing.Size(189, 20)
        Me.txtPostalCliente.TabIndex = 16
        '
        'txtDirecciónCliente
        '
        Me.txtDirecciónCliente.Location = New System.Drawing.Point(139, 128)
        Me.txtDirecciónCliente.Name = "txtDirecciónCliente"
        Me.txtDirecciónCliente.Size = New System.Drawing.Size(189, 20)
        Me.txtDirecciónCliente.TabIndex = 15
        '
        'cboPaisCliente
        '
        Me.cboPaisCliente.FormattingEnabled = True
        Me.cboPaisCliente.Items.AddRange(New Object() {"CRI", "MEX", "COL", "URU", "BRA", "DEU"})
        Me.cboPaisCliente.Location = New System.Drawing.Point(139, 96)
        Me.cboPaisCliente.Name = "cboPaisCliente"
        Me.cboPaisCliente.Size = New System.Drawing.Size(189, 21)
        Me.cboPaisCliente.TabIndex = 14
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(139, 60)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(189, 20)
        Me.txtNombreCliente.TabIndex = 13
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Location = New System.Drawing.Point(139, 21)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(189, 20)
        Me.txtCodigoCliente.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 322)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Fecha de Relación"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Dirección de entrega"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Correo Electrónico"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Limite de Credito"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(65, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Telefonos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Codigo postal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dirección "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(97, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pais"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.sinDatos)
        Me.GroupBox2.Controls.Add(Me.DataCliente)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(463, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(435, 412)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Clientes"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(35, 370)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 27
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'sinDatos
        '
        Me.sinDatos.AutoSize = True
        Me.sinDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sinDatos.ForeColor = System.Drawing.Color.Blue
        Me.sinDatos.Location = New System.Drawing.Point(84, 198)
        Me.sinDatos.Name = "sinDatos"
        Me.sinDatos.Size = New System.Drawing.Size(267, 16)
        Me.sinDatos.TabIndex = 26
        Me.sinDatos.Text = "No se encuentran datos relacionados"
        '
        'DataCliente
        '
        Me.DataCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataCliente.BackgroundColor = System.Drawing.Color.White
        Me.DataCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataCliente.Location = New System.Drawing.Point(19, 63)
        Me.DataCliente.Name = "DataCliente"
        Me.DataCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataCliente.Size = New System.Drawing.Size(395, 279)
        Me.DataCliente.TabIndex = 25
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(185, 25)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(189, 20)
        Me.txtBuscar.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(90, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Buscar Código"
        '
        'RegistroCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(910, 436)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "RegistroCliente"
        Me.Text = "CLIENTES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrarCliente As System.Windows.Forms.Button
    Friend WithEvents DTPFechaRelaciónCliente As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCorreoCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtDirecciónEntregaCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtLimiteCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefonoCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtPostalCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtDirecciónCliente As System.Windows.Forms.TextBox
    Friend WithEvents cboPaisCliente As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoCliente As System.Windows.Forms.TextBox
    Friend WithEvents DataCliente As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents sinDatos As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnEditarCliente As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
