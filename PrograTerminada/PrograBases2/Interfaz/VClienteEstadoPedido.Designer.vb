<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VClienteEstadoPedido
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
        Me.DataClientePedido = New System.Windows.Forms.DataGridView()
        Me.btnCambiarEstado = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cboEstadoClientePedido = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdClientePedido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreClientePedido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.sinDatos = New System.Windows.Forms.Label()
        CType(Me.DataClientePedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataClientePedido
        '
        Me.DataClientePedido.BackgroundColor = System.Drawing.Color.White
        Me.DataClientePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataClientePedido.Location = New System.Drawing.Point(14, 70)
        Me.DataClientePedido.Name = "DataClientePedido"
        Me.DataClientePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataClientePedido.Size = New System.Drawing.Size(651, 298)
        Me.DataClientePedido.TabIndex = 0
        '
        'btnCambiarEstado
        '
        Me.btnCambiarEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarEstado.ForeColor = System.Drawing.Color.Navy
        Me.btnCambiarEstado.Location = New System.Drawing.Point(554, 4)
        Me.btnCambiarEstado.Name = "btnCambiarEstado"
        Me.btnCambiarEstado.Size = New System.Drawing.Size(110, 23)
        Me.btnCambiarEstado.TabIndex = 1
        Me.btnCambiarEstado.Text = "Cambiar "
        Me.btnCambiarEstado.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Navy
        Me.Button3.Location = New System.Drawing.Point(577, 389)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cboEstadoClientePedido
        '
        Me.cboEstadoClientePedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoClientePedido.ForeColor = System.Drawing.Color.Navy
        Me.cboEstadoClientePedido.FormattingEnabled = True
        Me.cboEstadoClientePedido.Items.AddRange(New Object() {"CONFIRMADO", "RECHAZADO ", "REPROCESAR"})
        Me.cboEstadoClientePedido.Location = New System.Drawing.Point(365, 5)
        Me.cboEstadoClientePedido.Name = "cboEstadoClientePedido"
        Me.cboEstadoClientePedido.Size = New System.Drawing.Size(182, 21)
        Me.cboEstadoClientePedido.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(33, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'txtIdClientePedido
        '
        Me.txtIdClientePedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdClientePedido.ForeColor = System.Drawing.Color.Navy
        Me.txtIdClientePedido.Location = New System.Drawing.Point(69, 6)
        Me.txtIdClientePedido.Name = "txtIdClientePedido"
        Me.txtIdClientePedido.Size = New System.Drawing.Size(170, 20)
        Me.txtIdClientePedido.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(14, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre"
        '
        'txtNombreClientePedido
        '
        Me.txtNombreClientePedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreClientePedido.ForeColor = System.Drawing.Color.Navy
        Me.txtNombreClientePedido.Location = New System.Drawing.Point(69, 29)
        Me.txtNombreClientePedido.Name = "txtNombreClientePedido"
        Me.txtNombreClientePedido.Size = New System.Drawing.Size(170, 20)
        Me.txtNombreClientePedido.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(264, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cambiar Estado"
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Location = New System.Drawing.Point(264, 34)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(45, 13)
        Me.lblMotivo.TabIndex = 10
        Me.lblMotivo.Text = "Motivo"
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(315, 30)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(232, 20)
        Me.txtMotivo.TabIndex = 11
        '
        'sinDatos
        '
        Me.sinDatos.AutoSize = True
        Me.sinDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sinDatos.ForeColor = System.Drawing.Color.Blue
        Me.sinDatos.Location = New System.Drawing.Point(213, 204)
        Me.sinDatos.Name = "sinDatos"
        Me.sinDatos.Size = New System.Drawing.Size(267, 16)
        Me.sinDatos.TabIndex = 27
        Me.sinDatos.Text = "No se encuentran datos relacionados"
        '
        'VClienteEstadoPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(693, 424)
        Me.Controls.Add(Me.sinDatos)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.lblMotivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombreClientePedido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdClientePedido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboEstadoClientePedido)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnCambiarEstado)
        Me.Controls.Add(Me.DataClientePedido)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Name = "VClienteEstadoPedido"
        Me.Text = "VClienteEstadoPedido"
        CType(Me.DataClientePedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataClientePedido As System.Windows.Forms.DataGridView
    Friend WithEvents btnCambiarEstado As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cboEstadoClientePedido As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdClientePedido As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombreClientePedido As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblMotivo As System.Windows.Forms.Label
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents sinDatos As System.Windows.Forms.Label
End Class
