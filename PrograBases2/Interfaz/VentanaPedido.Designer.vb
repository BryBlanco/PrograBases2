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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnregistrarpedido = New System.Windows.Forms.Button()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtbuscarpedido = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.datapedido = New System.Windows.Forms.DataGridView()
        Me.btnmodificarpedido = New System.Windows.Forms.Button()
        Me.btneliminarpedido = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datapedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnregistrarpedido)
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
        Me.GroupBox1.Size = New System.Drawing.Size(452, 498)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar Pedido"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(169, 281)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(185, 21)
        Me.ComboBox1.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "ID Ejecutivo"
        '
        'btnregistrarpedido
        '
        Me.btnregistrarpedido.Location = New System.Drawing.Point(310, 448)
        Me.btnregistrarpedido.Name = "btnregistrarpedido"
        Me.btnregistrarpedido.Size = New System.Drawing.Size(114, 32)
        Me.btnregistrarpedido.TabIndex = 23
        Me.btnregistrarpedido.Text = "Registrar"
        Me.btnregistrarpedido.UseVisualStyleBackColor = True
        '
        'DTPentregapedido
        '
        Me.DTPentregapedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPentregapedido.Location = New System.Drawing.Point(169, 250)
        Me.DTPentregapedido.Name = "DTPentregapedido"
        Me.DTPentregapedido.Size = New System.Drawing.Size(185, 20)
        Me.DTPentregapedido.TabIndex = 17
        '
        'txtcodigoclientepedido
        '
        Me.txtcodigoclientepedido.Location = New System.Drawing.Point(169, 219)
        Me.txtcodigoclientepedido.Name = "txtcodigoclientepedido"
        Me.txtcodigoclientepedido.Size = New System.Drawing.Size(185, 20)
        Me.txtcodigoclientepedido.TabIndex = 16
        '
        'cboformadepagopedido
        '
        Me.cboformadepagopedido.FormattingEnabled = True
        Me.cboformadepagopedido.Location = New System.Drawing.Point(169, 186)
        Me.cboformadepagopedido.Name = "cboformadepagopedido"
        Me.cboformadepagopedido.Size = New System.Drawing.Size(185, 21)
        Me.cboformadepagopedido.TabIndex = 15
        '
        'txtclientepedido
        '
        Me.txtclientepedido.Location = New System.Drawing.Point(169, 155)
        Me.txtclientepedido.Name = "txtclientepedido"
        Me.txtclientepedido.Size = New System.Drawing.Size(185, 20)
        Me.txtclientepedido.TabIndex = 14
        '
        'DTPfechapedido
        '
        Me.DTPfechapedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPfechapedido.Location = New System.Drawing.Point(169, 124)
        Me.DTPfechapedido.Name = "DTPfechapedido"
        Me.DTPfechapedido.Size = New System.Drawing.Size(185, 20)
        Me.DTPfechapedido.TabIndex = 13
        '
        'txtidpedido
        '
        Me.txtidpedido.Location = New System.Drawing.Point(169, 93)
        Me.txtidpedido.Name = "txtidpedido"
        Me.txtidpedido.Size = New System.Drawing.Size(185, 20)
        Me.txtidpedido.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha de Entrega"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Codigo del Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Forma de Pago"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha del Pedido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID de Pedido"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btneliminarpedido)
        Me.GroupBox2.Controls.Add(Me.btnmodificarpedido)
        Me.GroupBox2.Controls.Add(Me.txtbuscarpedido)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.datapedido)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(474, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(493, 498)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Pedido"
        '
        'txtbuscarpedido
        '
        Me.txtbuscarpedido.Location = New System.Drawing.Point(140, 55)
        Me.txtbuscarpedido.Name = "txtbuscarpedido"
        Me.txtbuscarpedido.Size = New System.Drawing.Size(208, 20)
        Me.txtbuscarpedido.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(49, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Buscar Código"
        '
        'datapedido
        '
        Me.datapedido.BackgroundColor = System.Drawing.Color.White
        Me.datapedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datapedido.GridColor = System.Drawing.Color.White
        Me.datapedido.Location = New System.Drawing.Point(17, 97)
        Me.datapedido.Name = "datapedido"
        Me.datapedido.Size = New System.Drawing.Size(460, 326)
        Me.datapedido.TabIndex = 0
        '
        'btnmodificarpedido
        '
        Me.btnmodificarpedido.Location = New System.Drawing.Point(79, 457)
        Me.btnmodificarpedido.Name = "btnmodificarpedido"
        Me.btnmodificarpedido.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificarpedido.TabIndex = 3
        Me.btnmodificarpedido.Text = "Modificar"
        Me.btnmodificarpedido.UseVisualStyleBackColor = True
        '
        'btneliminarpedido
        '
        Me.btneliminarpedido.Location = New System.Drawing.Point(332, 457)
        Me.btneliminarpedido.Name = "btneliminarpedido"
        Me.btneliminarpedido.Size = New System.Drawing.Size(75, 23)
        Me.btneliminarpedido.TabIndex = 4
        Me.btneliminarpedido.Text = "Eliminar"
        Me.btneliminarpedido.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(996, 527)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Pedido"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents btnregistrarpedido As System.Windows.Forms.Button
    Friend WithEvents DTPentregapedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcodigoclientepedido As System.Windows.Forms.TextBox
    Friend WithEvents cboformadepagopedido As System.Windows.Forms.ComboBox
    Friend WithEvents txtclientepedido As System.Windows.Forms.TextBox
    Friend WithEvents DTPfechapedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtidpedido As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbuscarpedido As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents datapedido As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btneliminarpedido As System.Windows.Forms.Button
    Friend WithEvents btnmodificarpedido As System.Windows.Forms.Button

End Class
