Imports System.Data
Imports System.Data.SqlClient


Public Class RegistroCliente
    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Dim parametro As SqlParameter
    'El apatador es donde se almacena la info que devuelve la consulta
    Dim adaptador As SqlDataAdapter
    'tabla es donde se guarda los datos de la consulta
    Dim tabla As DataTable
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MostrarTablaClientes()
    End Sub
    Private Sub Limpiar()
        txtCodigoCliente.Text = ""
        txtCorreoCliente.Text = ""
        txtDirecciónCliente.Text = ""
        txtDirecciónEntregaCliente.Text = ""
        txtLimiteCliente.Text = ""
        txtNombreCliente.Text = ""
        txtPostalCliente.Text = ""
        txtTelefonoCliente.Text = ""
        cboPaisCliente.Text = ""
        DTPFechaRelaciónCliente.Text = ""
    End Sub
    Private Sub Habilitar()
        txtCodigoCliente.Enabled = True
        txtCorreoCliente.Enabled = True
        txtDirecciónCliente.Enabled = True
        txtDirecciónEntregaCliente.Enabled = True
        txtLimiteCliente.Enabled = True
        txtNombreCliente.Enabled = True
        txtPostalCliente.Enabled = True
        txtTelefonoCliente.Enabled = True
        cboPaisCliente.Enabled = True
        DTPFechaRelaciónCliente.Enabled = True
    End Sub
    Private Sub Deshabilitar()
        txtCodigoCliente.Enabled = False
        txtCorreoCliente.Enabled = False
        txtDirecciónCliente.Enabled = False
        txtDirecciónEntregaCliente.Enabled = False
        txtLimiteCliente.Enabled = False
        txtNombreCliente.Enabled = False
        txtPostalCliente.Enabled = False
        txtTelefonoCliente.Enabled = False
        cboPaisCliente.Enabled = False
        DTPFechaRelaciónCliente.Enabled = False
    End Sub
    Private Sub MostrarTablaClientes()
        conexion = New SqlConnection("Data Source=WIN-9OB8BQ69IMI;Initial Catalog=SISTEMA_DE_VENTAS;User ID=sa;Password=Hola123")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "VerDatosClientes"
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        DataCliente.DataSource = tabla
        conexion.Close()
        'cboCodicionesdePagoCliente.DataSource = tabla
        'cboCodicionesdePagoCliente.DisplayMember = ""
        'cboCodicionesdePagoCliente.ValueMember = ""
        DataCliente.ColumnHeadersVisible = True
        If DataCliente.RowCount <> 0 Then
            sinDatos.Visible = False
        End If
    End Sub
    Private Sub InsertarClientes()
        Dim CodCliente As String = txtCodigoCliente.Text
        Dim NomCliente As String = txtNombreCliente.Text
        Dim PaisCliente As String = cboPaisCliente.Text
        Dim DireccionCliente As String = txtDirecciónCliente.Text
        Dim PostalCliente As String = txtPostalCliente.Text
        Dim TelefonosCliente As String = txtTelefonoCliente.Text
        Dim LimiteCliente As String = txtLimiteCliente.Text
        Dim DireccionE_cliente As String = txtDirecciónEntregaCliente.Text
        Dim Correo_cliente As String = txtCorreoCliente.Text
        Dim Relacion As String = DTPFechaRelaciónCliente.Text
        conexion = New SqlConnection("Data Source=WIN-9OB8BQ69IMI;Initial Catalog=SISTEMA_DE_VENTAS;User ID=sa;Password=Hola123")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "InsertarCliente"
        comando.Parameters.AddWithValue("@codigo_cliente", CodCliente)
        comando.Parameters.AddWithValue("@nombre_cliente", NomCliente)
        comando.Parameters.AddWithValue("@pais_cliente", PaisCliente)
        comando.Parameters.AddWithValue("@direccion_cliente", DireccionCliente)
        comando.Parameters.AddWithValue("@postal_cliente", PostalCliente)
        comando.Parameters.AddWithValue("@telefonos_cliente", TelefonosCliente)
        comando.Parameters.AddWithValue("@limite_credito_cliente", LimiteCliente)
        comando.Parameters.AddWithValue("@dirección_entrega_cliente", DireccionE_cliente)
        comando.Parameters.AddWithValue("@correo_cliente", Correo_cliente)
        comando.Parameters.AddWithValue("@fecha_relación_cliente", Relacion)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        DataCliente.DataSource = tabla
        conexion.Close()
        Deshabilitar()
    End Sub
    Private Sub EditarClientes()
        Dim CodCliente As String = DataCliente.SelectedCells.Item(0).Value
        Dim NomCliente As String = txtNombreCliente.Text
        Dim PaisCliente As String = cboPaisCliente.Text
        Dim DireccionCliente As String = txtDirecciónCliente.Text
        Dim PostalCliente As String = txtPostalCliente.Text
        Dim TelefonosCliente As String = txtTelefonoCliente.Text
        Dim LimiteCliente As String = txtLimiteCliente.Text
        Dim DireccionE_cliente As String = txtDirecciónEntregaCliente.Text
        Dim Correo_cliente As String = txtCorreoCliente.Text
        Dim Relacion As String = DTPFechaRelaciónCliente.Text
        conexion = New SqlConnection("Data Source=WIN-9OB8BQ69IMI;Initial Catalog=SISTEMA_DE_VENTAS;User ID=sa;Password=Hola123")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "editarcliente"
        comando.Parameters.AddWithValue("@codigo_cliente", CodCliente)
        comando.Parameters.AddWithValue("@nombre_cliente", NomCliente)
        comando.Parameters.AddWithValue("@pais_cliente", PaisCliente)
        comando.Parameters.AddWithValue("@direccion_cliente", DireccionCliente)
        comando.Parameters.AddWithValue("@postal_cliente", PostalCliente)
        comando.Parameters.AddWithValue("@telefonos_cliente", TelefonosCliente)
        comando.Parameters.AddWithValue("@limite_credito_cliente", LimiteCliente)
        comando.Parameters.AddWithValue("@dirección_entrega_cliente", DireccionE_cliente)
        comando.Parameters.AddWithValue("@correo_cliente", Correo_cliente)
        comando.Parameters.AddWithValue("@fecha_relación_cliente", Relacion)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        DataCliente.DataSource = tabla
        conexion.Close()
    End Sub
    Private Sub EliminarClientes()
        Dim CodCliente As String = DataCliente.SelectedCells.Item(0).Value
        conexion = New SqlConnection("Data Source=WIN-9OB8BQ69IMI;Initial Catalog=SISTEMA_DE_VENTAS;User ID=sa;Password=Hola123")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "eliminarcliente"
        comando.Parameters.AddWithValue("@codigo_cliente", CodCliente)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        MostrarTablaClientes()
        'DataCliente.DataSource = tabla
        conexion.Close()
    End Sub
    Private Sub buscar()
        Dim ds As New DataSet 'para crear una copia y cargar los datos ahi 
        ds.Tables.Add(tabla.Copy)
        Dim dv As New DataView(ds.Tables(0))
        dv.RowFilter = "NOMBRE_CLIENTE" & " like'" & txtBuscar.Text & "%'"
        DataCliente.DataSource = dv
    End Sub
    Private Sub mostrareditarcliente()
        txtCodigoCliente.Text = DataCliente.SelectedCells.Item(0).Value
        txtNombreCliente.Text = DataCliente.SelectedCells.Item(1).Value
        cboPaisCliente.Text = DataCliente.SelectedCells.Item(2).Value
        txtDirecciónCliente.Text = DataCliente.SelectedCells.Item(3).Value
        txtPostalCliente.Text = DataCliente.SelectedCells.Item(4).Value
        txtTelefonoCliente.Text = DataCliente.SelectedCells.Item(5).Value
        txtLimiteCliente.Text = DataCliente.SelectedCells.Item(6).Value
        txtDirecciónEntregaCliente.Text = DataCliente.SelectedCells.Item(7).Value
        txtCorreoCliente.Text = DataCliente.SelectedCells.Item(8).Value
        DTPFechaRelaciónCliente.Text = DataCliente.SelectedCells.Item(9).Value
    End Sub


    Private Sub txtBuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub btnRegistrarCliente_Click(sender As System.Object, e As System.EventArgs) Handles btnRegistrarCliente.Click
        InsertarClientes()
        MostrarTablaClientes()
    End Sub

    Private Sub DataCliente_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataCliente.CellClick
        mostrareditarcliente()
        Habilitar()
    End Sub
    Private Sub btnEditarCliente_Click(sender As System.Object, e As System.EventArgs) Handles btnEditarCliente.Click
        EditarClientes()
        MostrarTablaClientes()
    End Sub

    
    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        EliminarClientes()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Habilitar()
        Limpiar()
    End Sub
End Class