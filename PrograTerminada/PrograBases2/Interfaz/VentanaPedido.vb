Imports System.Data
Imports System.Data.SqlClient
Public Class VentanaPedido
    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Dim parametro As SqlParameter
    'El apatador es donde se almacena la info que devuelve la consulta
    Dim adaptador As SqlDataAdapter
    'tabla es donde se guarda los datos de la consulta
    Dim tabla As DataTable

    Private Sub VentanaPedido_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SISTEMA_DE_VENTASDataSet2.VerEjecutivos' table. You can move, or remove it, as needed.
        Me.VerEjecutivosTableAdapter1.Fill(Me.SISTEMA_DE_VENTASDataSet2.VerEjecutivos)
        'TODO: This line of code loads data into the 'SISTEMA_DE_VENTASDataSet1.VerEjecutivos' table. You can move, or remove it, as needed.
        'Me.VerEjecutivosTableAdapter.Fill(Me.SISTEMA_DE_VENTASDataSet1.VerEjecutivos)
        MostrarTablaPedidos()
        MostrarTablaProductos()
        MostrarTablaPedidosTemporal()
        Deshabilitarproductopedido()
        txtclientepedido.Enabled = False
        txtcodigoclientepedido.Enabled = False
        txtidpedido.Enabled = False
        btneliminarpedido.Enabled = False
        btnmodificarpedido.Enabled = False
        btnAceptarCambios.Enabled = False
        btnEditarDatosPedido.Visible = False
    End Sub
    Private Sub MostrarTablaPedidos()
        conexion = New SqlConnection("data source=(local);initial catalog=SISTEMA_DE_VENTAS;integrated security=true")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "VerDatosPedido"
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        datapedido.DataSource = tabla
        MsgBox(datapedido.RowCount)
        If datapedido.RowCount <> 1 Then
            sinDatos2.Visible = False
        Else
            datapedido.DataSource = Nothing
        End If
        conexion.Close()

    End Sub
    Private Sub MostrarTablaProductosPedidos()

        Dim Correlativo As Integer = datapedidoTemporal.Rows(datapedidoTemporal.RowCount - 2).Cells(0).Value
        Dim Anno As Integer = datapedidoTemporal.Rows(datapedidoTemporal.RowCount - 2).Cells(1).Value
        conexion = New SqlConnection("data source=(local);initial catalog=SISTEMA_DE_VENTAS;integrated security=true")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "VerDatosProductosPedido"
        comando.Parameters.AddWithValue("@correlativo", Correlativo)
        comando.Parameters.AddWithValue("@anno", Anno)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        dataproductopedido.DataSource = tabla
        conexion.Close()
        If dataproductopedido.RowCount <> 1 Then
            sinDatos1.Visible = False
        Else
            sinDatos1.Visible = True
            dataproductopedido.DataSource = Nothing
        End If

    End Sub
    Private Sub MostrarTablaProductos()
        conexion = New SqlConnection("data source=(local);initial catalog=SISTEMA_DE_VENTAS;integrated security=true")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "VerDatosCatalogo"
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        dataproductospedido.DataSource = tabla
        conexion.Close()
        If dataproductospedido.RowCount <> 1 Then
            sinDatos.Visible = False
        Else
            dataproductospedido.DataSource = Nothing
        End If
    End Sub
    Private Sub InsertarPedido()
        Dim Anno As String = Date.Now.Year
        Dim FechaPedido As String = DTPfechapedido.Text
        Dim CodigoCliente As String = txtcodigoclientepedido.Text
        Dim NomCliente As String = txtclientepedido.Text
        Dim FormaPago As String = cboformadepagopedido.Text
        Dim FechaEntrega As String = DTPentregapedido.Text
        Dim IDEjecutivo1 As String = cboIdEjecutivoPedido.SelectedValue
        conexion = New SqlConnection("data source=(local);initial catalog=SISTEMA_DE_VENTAS;integrated security=true")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "insertarpedido"
        comando.Parameters.AddWithValue("@anno", Anno)
        comando.Parameters.AddWithValue("@fecha_pedido", FechaPedido)
        comando.Parameters.AddWithValue("@codigo_cliente", CodigoCliente)
        comando.Parameters.AddWithValue("@forma_de_pago", FormaPago)
        comando.Parameters.AddWithValue("@id_ejecutivo", IDEjecutivo1)
        comando.Parameters.AddWithValue("@fecha_de_entrega", FechaEntrega)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        conexion.Close()
    End Sub
    Private Sub Limpiar()
        txtidpedido.Text = ""
        txtcodigoclientepedido.Text = ""
        DTPfechapedido.Text = ""
        txtcodigoclientepedido.Text = ""
        txtclientepedido.Text = ""
        cboformadepagopedido.Text = ""
        DTPentregapedido.Text = ""
        cboIdEjecutivoPedido.Text = ""
        dataproductopedido.DataSource = Nothing
        sinDatos1.Visible = True
    End Sub
    Private Sub MostrarTablaPedidosTemporal()
        conexion = New SqlConnection("data source=(local);initial catalog=SISTEMA_DE_VENTAS;integrated security=true")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "VerDatosPedido"
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        datapedidoTemporal.DataSource = tabla
        conexion.Close()
    End Sub
    Private Sub EliminarProductoPedido()
        Dim Correlativo As String = dataproductopedido.SelectedCells.Item(0).Value
        Dim Anno As String = dataproductopedido.SelectedCells.Item(1).Value
        Dim Sku As String = dataproductopedido.SelectedCells.Item(2).Value
        conexion = New SqlConnection("data source=(local);initial catalog=SISTEMA_DE_VENTAS;integrated security=true")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "eliminarproductopedido"
        comando.Parameters.AddWithValue("@correlativo", Correlativo)
        comando.Parameters.AddWithValue("@anno", Anno)
        comando.Parameters.AddWithValue("@sku", Sku)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        conexion.Close()
    End Sub
    Private Sub Deshabilitarproductopedido()
        btnagregarproductopedido.Enabled = False
        dataproductopedido.Enabled = False
        dataproductospedido.Enabled = False
        btneliminarpedido.Enabled = False
    End Sub
    Private Sub DeshabilitarPedido()
        cboformadepagopedido.Enabled = False
        cboIdEjecutivoPedido.Enabled = False
        DTPentregapedido.Enabled = False
        DTPfechapedido.Enabled = False
    End Sub
    Private Sub Habilitarpedido()
        cboformadepagopedido.Enabled = True
        cboIdEjecutivoPedido.Enabled = True
        DTPentregapedido.Enabled = True
        DTPfechapedido.Enabled = True
    End Sub
    Private Sub Habilitarproductopedido()
        btnagregarproductopedido.Enabled = True
        dataproductopedido.Enabled = True
        dataproductospedido.Enabled = True
    End Sub

    Private Sub VerDetalleProducto()
        VCatalogoProducto.txtSkuPedido.Text = dataproductospedido.SelectedCells.Item(0).Value()
        VCatalogoProducto.txtDescripciónProductoPedido.Text = dataproductospedido.SelectedCells.Item(1).Value()
        VCatalogoProducto.txtPrecioUnitarioPedido.Text = dataproductospedido.SelectedCells.Item(3).Value()
        VCatalogoProducto.txtexistenciaPedido.Text = dataproductospedido.SelectedCells.Item(4).Value()
        VCatalogoProducto.txtImpuestosPedido.Text = dataproductospedido.SelectedCells.Item(5).Value()
    End Sub
    Private Sub MostrarDatosEditarPedido()
        txtidpedido.Text = datapedido.SelectedCells.Item(0).Value.ToString + "-" + datapedido.SelectedCells.Item(1).Value.ToString
        DTPfechapedido.Text = datapedido.SelectedCells.Item(2).Value.ToString
        txtcodigoclientepedido.Text = datapedido.SelectedCells.Item(3).Value.ToString
        cboformadepagopedido.Text = datapedido.SelectedCells.Item(4).Value.ToString
        cboIdEjecutivoPedido.Text = datapedido.SelectedCells.Item(5).Value.ToString
        DTPentregapedido.Text = datapedido.SelectedCells.Item(6).Value.ToString


    End Sub


    Private Sub btnVerClientes_Click(sender As System.Object, e As System.EventArgs) Handles btnVerClientes.Click
        VClient.Show()
    End Sub
    Private Sub btnagregarproductopedido_Click(sender As System.Object, e As System.EventArgs) Handles btnagregarproductopedido.Click
        VCatalogoProducto.Show()
        VerDetalleProducto()
    End Sub

    Private Sub btnregistrarpedido_Click(sender As System.Object, e As System.EventArgs) Handles btnregistrarpedido.Click
        InsertarPedido()
        MostrarTablaPedidosTemporal()
        Habilitarproductopedido()
        DeshabilitarPedido()
        btnActualizarEditar.Visible = False
        btnActualizarProductoPedido.Visible = True
        txtidpedido.Text = datapedidoTemporal.Rows(datapedidoTemporal.RowCount - 2).Cells(0).Value.ToString + " - " + Date.Now.Year.ToString
    End Sub

    Private Sub btnNuevoPedido_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoPedido.Click
        Limpiar()
        Deshabilitarproductopedido()
        Habilitarpedido()
        btnmodificarpedido.Enabled = False
        btnEditarDatosPedido.Visible = False
        btnregistrarpedido.Enabled = True
        btnregistrarpedido.Visible = True
        btnActualizarProductoPedido.Enabled = True
        btnActualizarEditar.Enabled = False
        btnAceptarCambios.Enabled = False
    End Sub

    Private Sub btnActualizarProductoPedido_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizarProductoPedido.Click
        MostrarTablaProductosPedidos()
    End Sub

    Private Sub btneliminarpedido_Click(sender As System.Object, e As System.EventArgs) Handles btneliminarpedido.Click
        EliminarProductoPedido()
    End Sub

    Private Sub dataproductopedido_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataproductopedido.CellClick
        btneliminarpedido.Enabled = True
    End Sub

    Private Sub btnmodificarpedido_Click(sender As System.Object, e As System.EventArgs) Handles btnmodificarpedido.Click
        btnregistrarpedido.Visible = False
        btnEditarDatosPedido.Visible = True
        btnActualizarProductoPedido.Enabled = False
        btnActualizarEditar.Enabled = True
        btnAceptarCambios.Enabled = True
        Habilitarpedido()
        MostrarDatosEditarPedido()
    End Sub

    Private Sub datapedido_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datapedido.CellClick
        LlenarCombo()
    End Sub

    Private Sub btnCambiarEstado_Click(sender As System.Object, e As System.EventArgs) Handles btnCambiarEstado.Click
        If cboCambioEstadoPedido.Items.Equals("") Then
            MsgBox("Debe Elegir un de las opciones")
        Else
            If cboCambioEstadoPedido.SelectedItem.ToString.Equals("CANCELADO") Then
                ActualizarEstado()
                MsgBox("CANCELADO")
            ElseIf cboCambioEstadoPedido.SelectedItem.ToString.Equals("REVISADO") Then
                ActualizarEstado()
                MsgBox("REVISADO")
            ElseIf cboCambioEstadoPedido.SelectedItem.ToString.Equals("CONFIRMADO") Then
                ActualizarEstadoConfirmado()
                MsgBox("CONFIRMADO")
            End If
            MostrarTablaPedidos()
        End If
    End Sub
    Private Sub LlenarCombo()
        cboCambioEstadoPedido.Items.Clear()
        If datapedido.SelectedCells.Item(7).Value.Equals("CONFIRMADO") Or datapedido.SelectedCells.Item(7).Value.Equals("RECHAZADO ") Or datapedido.SelectedCells.Item(7).Value.Equals("CANCELADO ") Then
            'MsgBox("El pedido no puede ser Modificado ya que su estado es " + datapedido.SelectedCells.Item(7).Value.ToString)
            btnmodificarpedido.Enabled = False
            btnAceptarCambios.Enabled = False
            btnEliminarelPedido.Enabled = False
            btnCambiarEstado.Enabled = False
            cboCambioEstadoPedido.Enabled = False
            btnmodificarpedido.Enabled = False
            btnAceptarCambios.Enabled = False
        ElseIf datapedido.SelectedCells.Item(7).Value.Equals("REGISTRADO") Or datapedido.SelectedCells.Item(7).Value.Equals("REPROCESAR") Then
            btnmodificarpedido.Enabled = True
            btnAceptarCambios.Enabled = True
            btnEliminarelPedido.Enabled = True
            btnCambiarEstado.Enabled = True
            cboCambioEstadoPedido.Enabled = True
            cboCambioEstadoPedido.Items.Add("REVISADO")
        ElseIf datapedido.SelectedCells.Item(7).Value.Equals("REVISADO  ") Then
            btnCambiarEstado.Enabled = True
            cboCambioEstadoPedido.Enabled = True
            btnEliminarelPedido.Enabled = False
            btnmodificarpedido.Enabled = False
            btnAceptarCambios.Enabled = False

            cboCambioEstadoPedido.Items.Add("CONFIRMADO")
            cboCambioEstadoPedido.Items.Add("CANCELADO")
        End If
    End Sub
    Private Sub ActualizarEstado()
        Dim Correlativo As String = datapedido.SelectedCells.Item(0).Value
        Dim Anno As String = datapedido.SelectedCells.Item(1).Value
        Dim estado As String = cboCambioEstadoPedido.SelectedItem.ToString
        conexion = New SqlConnection("data source=(local);initial catalog=SISTEMA_DE_VENTAS;integrated security=true")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "CambiarEstadoPedido"
        comando.Parameters.AddWithValue("@correlativo", Correlativo)
        comando.Parameters.AddWithValue("@anno", Anno)
        comando.Parameters.AddWithValue("@estado", estado)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        conexion.Close()
    End Sub
    Private Sub EliminarPedido()
        Dim Correlativo As String = datapedido.SelectedCells.Item(0).Value
        Dim Anno As String = datapedido.SelectedCells.Item(1).Value
        conexion = New SqlConnection("data source=(local);initial catalog=SISTEMA_DE_VENTAS;integrated security=true")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "EliminarPedido"
        comando.Parameters.AddWithValue("@correlativo", Correlativo)
        comando.Parameters.AddWithValue("@anno", Anno)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        conexion.Close()
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "EliminarCascadaPedido"
        comando.Parameters.AddWithValue("@correlativo", Correlativo)
        comando.Parameters.AddWithValue("@anno", Anno)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        conexion.Close()
    End Sub
    Private Sub ActualizarEstadoConfirmado()
        VClienteEstadoPedido.Show()
    End Sub

    Private Sub btnEliminarelPedido_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarelPedido.Click
        EliminarPedido()
        MostrarTablaPedidos()
    End Sub

    Private Sub btnActualizarpedido_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizarpedido.Click
        MostrarTablaPedidos()
    End Sub

    Private Sub btnEditarDatosPedido_Click(sender As System.Object, e As System.EventArgs) Handles btnEditarDatosPedido.Click
        'EditarPedido()
        Habilitarproductopedido()
        DeshabilitarPedido()
        btnActualizarEditar.Visible = True
        btnActualizarProductoPedido.Visible = False
        'txtidpedido.Text = datapedidoTemporal.Rows(datapedidoTemporal.RowCount - 2).Cells(0).Value.ToString + " - " + Date.Now.Year.ToString
    End Sub

    Private Sub btnAceptarCambios_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarCambios.Click
        Deshabilitarproductopedido()
        Habilitarpedido()
        btnmodificarpedido.Enabled = False
        btnEditarDatosPedido.Visible = False
        btnregistrarpedido.Enabled = True
        btnregistrarpedido.Visible = True
        btnActualizarProductoPedido.Enabled = True
        btnActualizarEditar.Enabled = False
        btnAceptarCambios.Enabled = False
    End Sub
End Class
