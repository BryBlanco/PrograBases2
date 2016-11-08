Imports System.Data
Imports System.Data.SqlClient
Class VClienteEstadoPedido
    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Dim parametro As SqlParameter
    'El apatador es donde se almacena la info que devuelve la consulta
    Dim adaptador As SqlDataAdapter
    'tabla es donde se guarda los datos de la consulta
    Dim tabla As DataTable
    Private Sub VClienteEstadoPedido_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cboEstadoClientePedido.Enabled = False
        txtIdClientePedido.Enabled = False
        txtNombreClientePedido.Enabled = False
        btnCambiarEstado.Enabled = False
        lblMotivo.Visible = False
        txtMotivo.Visible = False
        txtIdClientePedido.Text = VentanaPedido.datapedido.SelectedCells.Item(3).Value.ToString
        txtNombreClientePedido.Text = VentanaPedido.txtclientepedido.Text.ToString
        MostrarPedidos()
        MostrarTablaPedidos()
    End Sub
    Private Sub MostrarPedidos()

    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnCambiarEstado_Click(sender As System.Object, e As System.EventArgs) Handles btnCambiarEstado.Click
        If cboEstadoClientePedido.SelectedItem.Equals("") Then
            MsgBox("Debe elegir una de las opciones de estado del pedido")
        Else
            ActualizarEstado()
            MostrarTablaPedidos()
        End If
    End Sub
    Private Sub ActualizarEstado()
        Dim Correlativo As String = DataClientePedido.SelectedCells.Item(0).Value
        Dim Anno As String = DataClientePedido.SelectedCells.Item(1).Value
        Dim IDCliente As String = txtIdClientePedido.Text
        Dim estado As String = cboEstadoClientePedido.SelectedItem.ToString
        Dim Motivo As String = txtMotivo.Text
        conexion = New SqlConnection("data source=(local);initial catalog=SISTEMA_DE_VENTAS;integrated security=true")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "CambiarEstadoClientePedido"
        comando.Parameters.AddWithValue("@correlativo", Correlativo)
        comando.Parameters.AddWithValue("@anno", Anno)
        comando.Parameters.AddWithValue("@estado", estado)
        comando.Parameters.AddWithValue("@idcliente", IDCliente)
        comando.Parameters.AddWithValue("@motivo", Motivo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        conexion.Close()
    End Sub
    Private Sub MostrarTablaPedidos()
        Dim IDCliente As String = txtIdClientePedido.Text
        conexion = New SqlConnection("data source=(local);initial catalog=SISTEMA_DE_VENTAS;integrated security=true")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "VerDatosPedidoCliente"
        comando.Parameters.AddWithValue("@idcliente", IDCliente)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        DataClientePedido.DataSource = tabla
        If DataClientePedido.RowCount <> 1 Then
            sinDatos.Visible = False
        Else
            DataClientePedido.DataSource = Nothing
        End If
        conexion.Close()

    End Sub

    Private Sub cboEstadoClientePedido_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboEstadoClientePedido.SelectedIndexChanged
        If cboEstadoClientePedido.SelectedItem.Equals("CONFIRMADO") Then
            btnCambiarEstado.Enabled = True
            lblMotivo.Visible = False
            txtMotivo.Visible = False
        ElseIf cboEstadoClientePedido.SelectedItem.ToString.Equals("RECHAZADO ") Or cboEstadoClientePedido.SelectedItem.ToString.Equals("REPROCESAR") Then
            lblMotivo.Visible = True
            txtMotivo.Visible = True
        End If
    End Sub

    Private Sub DataClientePedido_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataClientePedido.CellClick
        cboEstadoClientePedido.Enabled = True
    End Sub
End Class