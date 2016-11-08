<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaPersonal
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
        Me.btnregistrarpersonal = New System.Windows.Forms.Button()
        Me.DTPretiropersonal = New System.Windows.Forms.DateTimePicker()
        Me.DTPingresopersonal = New System.Windows.Forms.DateTimePicker()
        Me.DTPnacimientopersonal = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtresidenciapersonal = New System.Windows.Forms.TextBox()
        Me.txtcorreopersonal = New System.Windows.Forms.TextBox()
        Me.txttelefonopersonal = New System.Windows.Forms.TextBox()
        Me.txtapellidospersonal = New System.Windows.Forms.TextBox()
        Me.txtnombrepersonal = New System.Windows.Forms.TextBox()
        Me.txtidempleadopersonal = New System.Windows.Forms.TextBox()
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtbuscarpersonal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbxjefepersonal = New System.Windows.Forms.ComboBox()
        Me.cmxpuestopersonal = New System.Windows.Forms.ComboBox()
        Me.btnmodificarempleado = New System.Windows.Forms.Button()
        Me.btneliminarempleado = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmxpuestopersonal)
        Me.GroupBox1.Controls.Add(Me.cbxjefepersonal)
        Me.GroupBox1.Controls.Add(Me.btnregistrarpersonal)
        Me.GroupBox1.Controls.Add(Me.DTPretiropersonal)
        Me.GroupBox1.Controls.Add(Me.DTPingresopersonal)
        Me.GroupBox1.Controls.Add(Me.DTPnacimientopersonal)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtresidenciapersonal)
        Me.GroupBox1.Controls.Add(Me.txtcorreopersonal)
        Me.GroupBox1.Controls.Add(Me.txttelefonopersonal)
        Me.GroupBox1.Controls.Add(Me.txtapellidospersonal)
        Me.GroupBox1.Controls.Add(Me.txtnombrepersonal)
        Me.GroupBox1.Controls.Add(Me.txtidempleadopersonal)
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
        Me.GroupBox1.Size = New System.Drawing.Size(540, 505)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro Personal"
        '
        'btnregistrarpersonal
        '
        Me.btnregistrarpersonal.Location = New System.Drawing.Point(378, 457)
        Me.btnregistrarpersonal.Name = "btnregistrarpersonal"
        Me.btnregistrarpersonal.Size = New System.Drawing.Size(75, 23)
        Me.btnregistrarpersonal.TabIndex = 22
        Me.btnregistrarpersonal.Text = "Registrar"
        Me.btnregistrarpersonal.UseVisualStyleBackColor = True
        '
        'DTPretiropersonal
        '
        Me.DTPretiropersonal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPretiropersonal.Location = New System.Drawing.Point(176, 370)
        Me.DTPretiropersonal.Name = "DTPretiropersonal"
        Me.DTPretiropersonal.Size = New System.Drawing.Size(178, 20)
        Me.DTPretiropersonal.TabIndex = 20
        '
        'DTPingresopersonal
        '
        Me.DTPingresopersonal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPingresopersonal.Location = New System.Drawing.Point(176, 335)
        Me.DTPingresopersonal.Name = "DTPingresopersonal"
        Me.DTPingresopersonal.Size = New System.Drawing.Size(178, 20)
        Me.DTPingresopersonal.TabIndex = 19
        '
        'DTPnacimientopersonal
        '
        Me.DTPnacimientopersonal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPnacimientopersonal.Location = New System.Drawing.Point(176, 299)
        Me.DTPnacimientopersonal.Name = "DTPnacimientopersonal"
        Me.DTPnacimientopersonal.Size = New System.Drawing.Size(178, 20)
        Me.DTPnacimientopersonal.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(142, 408)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Jefe"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(82, 373)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Feha de Retiro"
        '
        'txtresidenciapersonal
        '
        Me.txtresidenciapersonal.Location = New System.Drawing.Point(176, 229)
        Me.txtresidenciapersonal.Name = "txtresidenciapersonal"
        Me.txtresidenciapersonal.Size = New System.Drawing.Size(178, 20)
        Me.txtresidenciapersonal.TabIndex = 14
        '
        'txtcorreopersonal
        '
        Me.txtcorreopersonal.Location = New System.Drawing.Point(176, 192)
        Me.txtcorreopersonal.Name = "txtcorreopersonal"
        Me.txtcorreopersonal.Size = New System.Drawing.Size(178, 20)
        Me.txtcorreopersonal.TabIndex = 13
        '
        'txttelefonopersonal
        '
        Me.txttelefonopersonal.Location = New System.Drawing.Point(176, 155)
        Me.txttelefonopersonal.Name = "txttelefonopersonal"
        Me.txttelefonopersonal.Size = New System.Drawing.Size(178, 20)
        Me.txttelefonopersonal.TabIndex = 12
        '
        'txtapellidospersonal
        '
        Me.txtapellidospersonal.Location = New System.Drawing.Point(176, 117)
        Me.txtapellidospersonal.Name = "txtapellidospersonal"
        Me.txtapellidospersonal.Size = New System.Drawing.Size(178, 20)
        Me.txtapellidospersonal.TabIndex = 11
        '
        'txtnombrepersonal
        '
        Me.txtnombrepersonal.Location = New System.Drawing.Point(176, 81)
        Me.txtnombrepersonal.Name = "txtnombrepersonal"
        Me.txtnombrepersonal.Size = New System.Drawing.Size(178, 20)
        Me.txtnombrepersonal.TabIndex = 10
        '
        'txtidempleadopersonal
        '
        Me.txtidempleadopersonal.Location = New System.Drawing.Point(176, 43)
        Me.txtidempleadopersonal.Name = "txtidempleadopersonal"
        Me.txtidempleadopersonal.Size = New System.Drawing.Size(178, 20)
        Me.txtidempleadopersonal.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(67, 338)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Fecha de Ingreso"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Fecha de Nacimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Puesto de Trabajo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Lugar de Residencia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Correo Electronico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(116, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Empleado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btneliminarempleado)
        Me.GroupBox2.Controls.Add(Me.btnmodificarempleado)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.txtbuscarpersonal)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(566, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(497, 508)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Empleado"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(485, 326)
        Me.DataGridView1.TabIndex = 2
        '
        'txtbuscarpersonal
        '
        Me.txtbuscarpersonal.Location = New System.Drawing.Point(173, 61)
        Me.txtbuscarpersonal.Name = "txtbuscarpersonal"
        Me.txtbuscarpersonal.Size = New System.Drawing.Size(184, 20)
        Me.txtbuscarpersonal.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(65, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Buscar Empleado"
        '
        'cbxjefepersonal
        '
        Me.cbxjefepersonal.FormattingEnabled = True
        Me.cbxjefepersonal.Location = New System.Drawing.Point(176, 408)
        Me.cbxjefepersonal.Name = "cbxjefepersonal"
        Me.cbxjefepersonal.Size = New System.Drawing.Size(178, 21)
        Me.cbxjefepersonal.TabIndex = 23
        '
        'cmxpuestopersonal
        '
        Me.cmxpuestopersonal.FormattingEnabled = True
        Me.cmxpuestopersonal.Location = New System.Drawing.Point(176, 265)
        Me.cmxpuestopersonal.Name = "cmxpuestopersonal"
        Me.cmxpuestopersonal.Size = New System.Drawing.Size(178, 21)
        Me.cmxpuestopersonal.TabIndex = 24
        '
        'btnmodificarempleado
        '
        Me.btnmodificarempleado.Location = New System.Drawing.Point(83, 457)
        Me.btnmodificarempleado.Name = "btnmodificarempleado"
        Me.btnmodificarempleado.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificarempleado.TabIndex = 3
        Me.btnmodificarempleado.Text = "Modificar"
        Me.btnmodificarempleado.UseVisualStyleBackColor = True
        '
        'btneliminarempleado
        '
        Me.btneliminarempleado.Location = New System.Drawing.Point(350, 457)
        Me.btneliminarempleado.Name = "btneliminarempleado"
        Me.btneliminarempleado.Size = New System.Drawing.Size(75, 23)
        Me.btneliminarempleado.TabIndex = 4
        Me.btneliminarempleado.Text = "Eliminar"
        Me.btneliminarempleado.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1068, 524)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DTPretiropersonal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPingresopersonal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPnacimientopersonal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtresidenciapersonal As System.Windows.Forms.TextBox
    Friend WithEvents txtcorreopersonal As System.Windows.Forms.TextBox
    Friend WithEvents txttelefonopersonal As System.Windows.Forms.TextBox
    Friend WithEvents txtapellidospersonal As System.Windows.Forms.TextBox
    Friend WithEvents txtnombrepersonal As System.Windows.Forms.TextBox
    Friend WithEvents txtidempleadopersonal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtbuscarpersonal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnregistrarpersonal As System.Windows.Forms.Button
    Friend WithEvents cmxpuestopersonal As System.Windows.Forms.ComboBox
    Friend WithEvents cbxjefepersonal As System.Windows.Forms.ComboBox
    Friend WithEvents btneliminarempleado As System.Windows.Forms.Button
    Friend WithEvents btnmodificarempleado As System.Windows.Forms.Button
End Class
