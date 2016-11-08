Imports System.Data
Imports System.Data.SqlClient

Public Class VentanaFactura
    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Dim parametro As SqlParameter
    'El apatador es donde se almacena la info que devuelve la consulta
    Dim adaptador As SqlDataAdapter
    'tabla es donde se guarda los datos de la consulta
    Dim tabla As DataTable

    Private Sub VentanaFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnagregarafactura.Enabled = False
        btngenerarfactura.Enabled = False
        datafacturafinal.ColumnCount = 10
        datafacturafinal.Columns(0).Name = "1"
        datafacturafinal.Columns(1).Name = "2"
        datafacturafinal.Columns(2).Name = "3"
        datafacturafinal.Columns(3).Name = "4"
        datafacturafinal.Columns(4).Name = "5"
        datafacturafinal.Columns(5).Name = "6"
        datafacturafinal.Columns(6).Name = "7"
        datafacturafinal.Columns(7).Name = "8"
        datafacturafinal.Columns(8).Name = "9"
        datafacturafinal.Columns(9).Name = "10"

    End Sub

    Private Sub agregarAFactura()
        Dim row As String() = New String() {labelidfactura.Text.ToString(), txtcorrelativo.Text.ToString(),
                                            txtidano.Text.ToString(), txtsku.Text.ToString(),
                                            nupcantidadafacturar.Value.ToString(),
                                            txtprecioventa.Text.ToString(), txtsubtotal.Text.ToString(),
                                            txtdescuentoaplicado.Text.ToString(), txtimpuestoaplicado.Text.ToString(),
                                            txttotalapagar.Text.ToString()}
        datafacturafinal.Rows.Add(row)
    End Sub

    Private Sub MostrarTablaFactura()
        conexion = New SqlConnection("Data Source=WIN-9OB8BQ69IMI;Initial Catalog=SISTEMA_DE_VENTAS;User ID=sa;Password=Hola123")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "VerDatosFactura"
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        DataGridView2.DataSource = tabla
        conexion.Close()
    End Sub

    Private Sub MostrarTablaPedidosPorCliente()
        Dim idcliente As String = txtIDCliente.Text
        conexion = New SqlConnection("Data Source=WIN-9OB8BQ69IMI;Initial Catalog=SISTEMA_DE_VENTAS;User ID=sa;Password=Hola123")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "CargarProductosPedidosParaFacturar"
        comando.Parameters.AddWithValue("@id_cliente", idcliente)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        DataPedidosAFacturar.DataSource = tabla
        conexion.Close()
        DataPedidosAFacturar.ColumnHeadersVisible = True
        If DataPedidosAFacturar.RowCount <> 0 Then
            sinDatos.Visible = False
        End If
    End Sub

    Private Sub MostrarCantidadFacturada()
        Dim idcorrelativo As String = txtcorrelativo.Text
        Dim sku As String = txtsku.Text
        conexion = New SqlConnection("Data Source=WIN-9OB8BQ69IMI;Initial Catalog=SISTEMA_DE_VENTAS;User ID=sa;Password=Hola123")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "CantidadProductoFacturado"
        comando.Parameters.AddWithValue("@id_correlativo", idcorrelativo)
        comando.Parameters.AddWithValue("@id_sku", sku)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        tabla = New DataTable
        adaptador.Fill(tabla)
        dataCantidadFacturada.DataSource = tabla
        conexion.Close()
    End Sub

    Private Sub CrearFactura()
        Dim idcliente As String = txtIDCliente.Text
        Dim fechafactura As String = DTPfechafactura.Text
        Dim condicionpago As String = cbxcondicionpagofactura.Text
        Dim fechavencimiento As String = DTPvencimientofactura.Text
        Dim direccionentrega As String = txtdireccionentregafactura.Text

        conexion = New SqlConnection("Data Source=WIN-9OB8BQ69IMI;Initial Catalog=SISTEMA_DE_VENTAS;User ID=sa;Password=Hola123")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "InsertarFactura"
        comando.Parameters.AddWithValue("@id_cliente", idcliente)
        comando.Parameters.AddWithValue("@fecha_factura", fechafactura)
        comando.Parameters.AddWithValue("@condicion_pago", condicionpago)
        comando.Parameters.AddWithValue("@fecha_vencimiento", fechavencimiento)
        comando.Parameters.AddWithValue("@direccion_entrega", direccionentrega)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        Try
            adaptador.Fill(tabla)
        Catch ex As Exception
            Dim msg As String = "Mamó."
            MsgBox(msg, MsgBoxStyle.Information, "Recordatorio")
        End Try
        conexion.Close()
    End Sub

    Private Sub InsertarProductosPedidos()
        Dim id_factura As String = labelidfactura.Text
        Dim id_correlativo As String = txtcorrelativo.Text
        Dim id_ano As String = txtidano.Text
        Dim sku As String = txtsku.Text
        Dim cantidadfacturada As String = nupcantidadafacturar.Value
        Dim precioventa As String = txtprecioventa.Text
        Dim subtotal As String = txtsubtotal.Text
        Dim descuento As String = txtdescuentoaplicado.Text()
        Dim impuesto As String = txtimpuestoaplicado.Text
        Dim total As String = txttotalapagar.Text

        conexion = New SqlConnection("Data Source=WIN-9OB8BQ69IMI;Initial Catalog=SISTEMA_DE_VENTAS;User ID=sa;Password=Hola123")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "InsertarProductoFacturado"
        comando.Parameters.AddWithValue("@id_factura", id_factura)
        comando.Parameters.AddWithValue("@id_correlativo", id_correlativo)
        comando.Parameters.AddWithValue("@id_ano", id_ano)
        comando.Parameters.AddWithValue("@SKU", sku)
        comando.Parameters.AddWithValue("@cantidadfacturada", cantidadfacturada)
        comando.Parameters.AddWithValue("@precioventa", Convert.ToDecimal(precioventa))
        comando.Parameters.AddWithValue("@subtotal", Convert.ToDecimal(subtotal))
        comando.Parameters.AddWithValue("@descuento", Convert.ToDecimal(descuento))
        comando.Parameters.AddWithValue("@impuesto", Convert.ToDecimal(impuesto))
        comando.Parameters.AddWithValue("@totalpagar", Convert.ToDecimal(total))
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        'Try
        adaptador.Fill(tabla)
        'Catch ex As Exception
        'Dim msg As String = "Sólo puede facturar el producto una única vez."
        'MsgBox(msg, MsgBoxStyle.Information, "Error")
        'End Try
        datafacturafinal.DataSource = tabla
        conexion.Close()
        Deshabilitar()
    End Sub

    Private Sub MostrarProductoParaFacturar()
        txtcorrelativo.Text = DataPedidosAFacturar.SelectedCells.Item(0).Value
        txtidano.Text = DataPedidosAFacturar.SelectedCells.Item(1).Value
        txtsku.Text = DataPedidosAFacturar.SelectedCells.Item(2).Value
        txtdescripcion.Text = DataPedidosAFacturar.SelectedCells.Item(3).Value
        txtprecioventa.Text = DataPedidosAFacturar.SelectedCells.Item(4).Value
        txtexistencias.Text = DataPedidosAFacturar.SelectedCells.Item(5).Value
        txtcantidadpedida.Text = DataPedidosAFacturar.SelectedCells.Item(6).Value
        txtdescuento.Text = DataPedidosAFacturar.SelectedCells.Item(7).Value
        txtimpuesto.Text = DataPedidosAFacturar.SelectedCells.Item(8).Value
        MostrarCantidadFacturada()
        MostrarAux()
        'corrarlo
    End Sub

    Private Sub MostrarAux()
        txtcantidadfacturada.Text = dataCantidadFacturada.Rows(0).Cells(0).Value
    End Sub

    Private Sub Deshabilitar()
        txtcorrelativo.ReadOnly = True
        txtidano.ReadOnly = True
        txtsku.ReadOnly = True
        txtdescripcion.ReadOnly = True
        txtprecioventa.ReadOnly = True
        txtexistencias.ReadOnly = True
        txtcantidadpedida.ReadOnly = True
        txtdescuento.ReadOnly = True
        txtimpuesto.ReadOnly = True
        txtsubtotal.ReadOnly = True
        txttotalapagar.ReadOnly = True

    End Sub

    Private Sub btnfacturarpedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfacturarpedidos.Click
        MostrarTablaPedidosPorCliente()
        CrearFactura()
        MostrarTablaFactura()
        labelidfactura.Text = DataGridView2.Rows(DataGridView2.RowCount() - 2).Cells(0).Value
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
    End Sub

    Private Sub DataPedidosAFacturar_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataPedidosAFacturar.CellClick
        nupcantidadafacturar.Value = 0
        MostrarProductoParaFacturar()
        If txtcantidadfacturada.Text = txtcantidadpedida.Text Then
            Dim msg As String = "El producto pedido ya se facturó en su totalidad."
            MsgBox(msg, MsgBoxStyle.Information, "Recordatorio")
        End If
        Deshabilitar()
        btnagregarafactura.Enabled = False
    End Sub

    Private Sub nupcantidadafacturar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nupcantidadafacturar.ValueChanged
        If nupcantidadafacturar.Value = 0 Then
            btnagregarafactura.Enabled = False
        Else
            If nupcantidadafacturar.Value > txtexistencias.Text Then
                Dim msg As String = "La cantidad que solicita es mayor a las existencias de la tienda. Por favor, seleccione una cantidad menor"
                MsgBox(msg, MsgBoxStyle.Information, "Error")
                nupcantidadafacturar.DownButton()
            ElseIf nupcantidadafacturar.Value > txtcantidadpedida.Text Then
                Dim msg As String = "La cantidad que solicita es mayor al pedido registrado por ese producto."
                MsgBox(msg, MsgBoxStyle.Information, "Error")
                nupcantidadafacturar.DownButton()
            ElseIf nupcantidadafacturar.Value > txtcantidadpedida.Text - txtcantidadfacturada.Text Then
                Dim msg As String = "Cantidad máxima del producto que completa este pedido. Si desea más de este producto, realice un nuevo pedido"
                MsgBox(msg, MsgBoxStyle.Information, "Alerta")
                nupcantidadafacturar.DownButton()
            End If
            btnagregarafactura.Enabled = True
        End If
        txtsubtotal.Text = nupcantidadafacturar.Value * txtprecioventa.Text
        txtdescuentoaplicado.Text = txtsubtotal.Text * (txtdescuento.Text / 100)
        txtimpuestoaplicado.Text = (txtsubtotal.Text - txtdescuentoaplicado.Text) * (txtimpuesto.Text / 100)
        txttotalapagar.Text = txtsubtotal.Text - txtdescuentoaplicado.Text + txtimpuestoaplicado.Text
    End Sub

    Private Sub btnagregarafactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregarafactura.Click
        btngenerarfactura.Enabled = True
        agregarAFactura()
        InsertarProductosPedidos()

    End Sub

    Private Sub btngenerarfactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerarfactura.Click
        txtDate.Text = DTPfechafactura.Value
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class