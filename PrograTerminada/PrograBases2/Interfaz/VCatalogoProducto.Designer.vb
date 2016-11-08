<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VCatalogoProducto
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
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.SKULABEL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSkuPedido = New System.Windows.Forms.TextBox()
        Me.txtDescripciónProductoPedido = New System.Windows.Forms.TextBox()
        Me.txtexistenciaPedido = New System.Windows.Forms.TextBox()
        Me.txtPrecioUnitarioPedido = New System.Windows.Forms.TextBox()
        Me.txtImpuestosPedido = New System.Windows.Forms.TextBox()
        Me.txtCantidadProductoPedido = New System.Windows.Forms.TextBox()
        Me.txtDescuentoProductoPedido = New System.Windows.Forms.TextBox()
        Me.txtTotalProductoPedido = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.ForeColor = System.Drawing.Color.Navy
        Me.btnAgregarProducto.Location = New System.Drawing.Point(309, 328)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(87, 23)
        Me.btnAgregarProducto.TabIndex = 0
        Me.btnAgregarProducto.Text = "Agregar"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'SKULABEL
        '
        Me.SKULABEL.AutoSize = True
        Me.SKULABEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SKULABEL.ForeColor = System.Drawing.Color.Navy
        Me.SKULABEL.Location = New System.Drawing.Point(28, 37)
        Me.SKULABEL.Name = "SKULABEL"
        Me.SKULABEL.Size = New System.Drawing.Size(32, 13)
        Me.SKULABEL.TabIndex = 6
        Me.SKULABEL.Text = "SKU"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(216, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(229, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Precio de Unitario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(28, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Existencias"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Impuesto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(76, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Descuento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(45, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cantidad a Pedir"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(70, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Precio Total"
        '
        'txtSkuPedido
        '
        Me.txtSkuPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSkuPedido.ForeColor = System.Drawing.Color.Navy
        Me.txtSkuPedido.Location = New System.Drawing.Point(69, 34)
        Me.txtSkuPedido.Name = "txtSkuPedido"
        Me.txtSkuPedido.Size = New System.Drawing.Size(116, 20)
        Me.txtSkuPedido.TabIndex = 14
        '
        'txtDescripciónProductoPedido
        '
        Me.txtDescripciónProductoPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripciónProductoPedido.ForeColor = System.Drawing.Color.Navy
        Me.txtDescripciónProductoPedido.Location = New System.Drawing.Point(309, 34)
        Me.txtDescripciónProductoPedido.Name = "txtDescripciónProductoPedido"
        Me.txtDescripciónProductoPedido.Size = New System.Drawing.Size(200, 20)
        Me.txtDescripciónProductoPedido.TabIndex = 15
        '
        'txtexistenciaPedido
        '
        Me.txtexistenciaPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexistenciaPedido.ForeColor = System.Drawing.Color.Navy
        Me.txtexistenciaPedido.Location = New System.Drawing.Point(92, 62)
        Me.txtexistenciaPedido.Name = "txtexistenciaPedido"
        Me.txtexistenciaPedido.Size = New System.Drawing.Size(103, 20)
        Me.txtexistenciaPedido.TabIndex = 16
        '
        'txtPrecioUnitarioPedido
        '
        Me.txtPrecioUnitarioPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioUnitarioPedido.ForeColor = System.Drawing.Color.Navy
        Me.txtPrecioUnitarioPedido.Location = New System.Drawing.Point(356, 74)
        Me.txtPrecioUnitarioPedido.Name = "txtPrecioUnitarioPedido"
        Me.txtPrecioUnitarioPedido.Size = New System.Drawing.Size(153, 20)
        Me.txtPrecioUnitarioPedido.TabIndex = 17
        Me.txtPrecioUnitarioPedido.Text = "10"
        '
        'txtImpuestosPedido
        '
        Me.txtImpuestosPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpuestosPedido.ForeColor = System.Drawing.Color.Navy
        Me.txtImpuestosPedido.Location = New System.Drawing.Point(93, 111)
        Me.txtImpuestosPedido.Name = "txtImpuestosPedido"
        Me.txtImpuestosPedido.Size = New System.Drawing.Size(116, 20)
        Me.txtImpuestosPedido.TabIndex = 18
        Me.txtImpuestosPedido.Text = "13"
        '
        'txtCantidadProductoPedido
        '
        Me.txtCantidadProductoPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadProductoPedido.ForeColor = System.Drawing.Color.Navy
        Me.txtCantidadProductoPedido.Location = New System.Drawing.Point(159, 53)
        Me.txtCantidadProductoPedido.Name = "txtCantidadProductoPedido"
        Me.txtCantidadProductoPedido.Size = New System.Drawing.Size(175, 20)
        Me.txtCantidadProductoPedido.TabIndex = 19
        Me.txtCantidadProductoPedido.Text = "1"
        '
        'txtDescuentoProductoPedido
        '
        Me.txtDescuentoProductoPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuentoProductoPedido.ForeColor = System.Drawing.Color.Navy
        Me.txtDescuentoProductoPedido.Location = New System.Drawing.Point(159, 91)
        Me.txtDescuentoProductoPedido.Name = "txtDescuentoProductoPedido"
        Me.txtDescuentoProductoPedido.Size = New System.Drawing.Size(175, 20)
        Me.txtDescuentoProductoPedido.TabIndex = 20
        Me.txtDescuentoProductoPedido.Text = "0"
        '
        'txtTotalProductoPedido
        '
        Me.txtTotalProductoPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalProductoPedido.ForeColor = System.Drawing.Color.Navy
        Me.txtTotalProductoPedido.Location = New System.Drawing.Point(159, 136)
        Me.txtTotalProductoPedido.Name = "txtTotalProductoPedido"
        Me.txtTotalProductoPedido.Size = New System.Drawing.Size(175, 20)
        Me.txtTotalProductoPedido.TabIndex = 21
        Me.txtTotalProductoPedido.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtexistenciaPedido)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 129)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Producto"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnActualizar)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtTotalProductoPedido)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtDescuentoProductoPedido)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtCantidadProductoPedido)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(14, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(502, 175)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Del Pedido"
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.Navy
        Me.btnActualizar.Location = New System.Drawing.Point(367, 56)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(87, 23)
        Me.btnActualizar.TabIndex = 25
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Location = New System.Drawing.Point(122, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VCatalogoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(530, 363)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtImpuestosPedido)
        Me.Controls.Add(Me.txtPrecioUnitarioPedido)
        Me.Controls.Add(Me.txtDescripciónProductoPedido)
        Me.Controls.Add(Me.txtSkuPedido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SKULABEL)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Name = "VCatalogoProducto"
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregarProducto As System.Windows.Forms.Button
    Friend WithEvents SKULABEL As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSkuPedido As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripciónProductoPedido As System.Windows.Forms.TextBox
    Friend WithEvents txtexistenciaPedido As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioUnitarioPedido As System.Windows.Forms.TextBox
    Friend WithEvents txtImpuestosPedido As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidadProductoPedido As System.Windows.Forms.TextBox
    Friend WithEvents txtDescuentoProductoPedido As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalProductoPedido As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
