Imports System.Data
Imports System.Data.SqlClient
Public Class VCatalogoProducto
    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Dim parametro As SqlParameter
    'El apatador es donde se almacena la info que devuelve la consulta
    Dim adaptador As SqlDataAdapter
    'tabla es donde se guarda los datos de la consulta
    Dim tabla As DataTable
    Private Sub VCatalogoProducto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Deshabilitar()

    End Sub
    Private Sub Deshabilitar()
        txtSkuPedido.Enabled = False
        txtDescripciónProductoPedido.Enabled = False
        txtPrecioUnitarioPedido.Enabled = False
        txtexistenciaPedido.Enabled = False
        txtImpuestosPedido.Enabled = False
        txtTotalProductoPedido.Enabled = False
    End Sub
    Private Sub InsertarProductoPedido()
        Dim correlativo As String = VentanaPedido.datapedidoTemporal.Rows(VentanaPedido.datapedidoTemporal.RowCount - 2).Cells(0).Value.ToString
        Dim anno As String = VentanaPedido.datapedidoTemporal.Rows(VentanaPedido.datapedidoTemporal.RowCount - 2).Cells(1).Value.ToString
        Dim Sku As String = txtSkuPedido.Text
        Dim Cantidad As String = txtCantidadProductoPedido.Text
        Dim Descuento As String = txtDescuentoProductoPedido.Text
        Dim PrecioTotal As String = txtTotalProductoPedido.Text
        conexion = New SqlConnection("data source=(local);initial catalog=SISTEMA_DE_VENTAS;integrated security=true")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "insertarproductopedido"
        comando.Parameters.AddWithValue("@correlativo", correlativo)
        comando.Parameters.AddWithValue("@anno", anno)
        comando.Parameters.AddWithValue("@sku", Sku)
        comando.Parameters.AddWithValue("@cantidad", Cantidad)
        comando.Parameters.AddWithValue("@descuento", Convert.ToDecimal(Descuento))
        comando.Parameters.AddWithValue("@precio_total", Convert.ToDecimal(PrecioTotal))
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        Try
            adaptador.Fill(tabla)
        Catch
            MsgBox("El producto ya esta en la lista de Productos Pedido")
        End Try
        conexion.Close()
    End Sub
    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Dim Cero As String = "0"
        If txtCantidadProductoPedido.Equals("") Then
            txtCantidadProductoPedido.Text = Cero
        End If
        If txtDescuentoProductoPedido.Equals("") Then
            txtDescuentoProductoPedido.Text = Cero
        End If
        Dim cantidad As Integer = CType(txtCantidadProductoPedido.Text, Integer)
        Dim Total As Integer = CType(txtTotalProductoPedido.Text, Integer)
        Dim Descuento As Integer = CType(txtDescuentoProductoPedido.Text, Integer)
        Dim Impuesto As Integer = CType(txtImpuestosPedido.Text, Integer)
        Dim PrecioUnitario As Integer = CType(txtPrecioUnitarioPedido.Text, Integer)
        txtTotalProductoPedido.Text = (cantidad * PrecioUnitario) - ((cantidad * PrecioUnitario) * (Impuesto / 100)) - ((cantidad * PrecioUnitario)) * (Descuento / 100)
    End Sub

    Private Sub txtCantidadProductoPedido_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCantidadProductoPedido.TextChanged
        Dim Cero As String = "0"
        If txtCantidadProductoPedido.Text.Equals("") Then
            txtCantidadProductoPedido.Text = Cero
        End If
    End Sub


    Private Sub txtDescuentoProductoPedido_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDescuentoProductoPedido.TextChanged
        Dim Cero As String = "0"
        If txtDescuentoProductoPedido.Text.Equals("") Then
            txtDescuentoProductoPedido.Text = Cero
        End If
    End Sub

    Private Sub txtTotalProductoPedido_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTotalProductoPedido.TextChanged
        If txtTotalProductoPedido.Text < 0 Then
            MsgBox("El total no puede ser menor a cero")
            btnAgregarProducto.Enabled = False
        Else
            btnAgregarProducto.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnAgregarProducto_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarProducto.Click
        InsertarProductoPedido()
        Me.Close()
    End Sub
End Class