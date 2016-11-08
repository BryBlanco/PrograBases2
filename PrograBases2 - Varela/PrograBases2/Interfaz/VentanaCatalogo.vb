Imports System.Data
Imports System.Data.SqlClient

Public Class VentanaCatalogo

    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Dim parametro As SqlParameter
    'El apatador es donde se almacena la info que devuelve la consulta
    Dim adaptador As SqlDataAdapter
    'tabla es donde se guarda los datos de la consulta
    Dim tabla As DataTable
    Private Sub Limpiar()
        txtdescripcionproductocatalogo.Text = ""
        txtcostounitariocatalogo.Text = ""
        txtprecioventacatalogo.Text = ""
        txtexistenciascatalogo.Text = ""
        txtimpuestocatalogo.Text = ""
    End Sub
    Private Sub Habilitar()
        txtdescripcionproductocatalogo.Enabled = True
        txtcostounitariocatalogo.Enabled = True
        txtprecioventacatalogo.Enabled = True
        txtexistenciascatalogo.Enabled = True
        txtimpuestocatalogo.Enabled = True
    End Sub
    Private Sub Deshabilitar()
        txtdescripcionproductocatalogo.Enabled = False
        txtcostounitariocatalogo.Enabled = False
        txtprecioventacatalogo.Enabled = False
        txtexistenciascatalogo.Enabled = False
        txtimpuestocatalogo.Enabled = False
    End Sub
    Private Sub MostrarTablaCatalogo()
        conexion = New SqlConnection("Data Source=WIN-9OB8BQ69IMI;Initial Catalog=SISTEMA_DE_VENTAS;User ID=sa;Password=Hola123")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "VerDatosCatalogo"
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        DataCatalogo.DataSource = tabla
        conexion.Close()
        'cboCodicionesdePagoCliente.DataSource = tabla
        'cboCodicionesdePagoCliente.DisplayMember = ""
        'cboCodicionesdePagoCliente.ValueMember = ""
        DataCatalogo.ColumnHeadersVisible = True
        If DataCatalogo.RowCount <> 0 Then
            sinDatos.Visible = False
        End If
    End Sub
    Private Sub InsertarCatalogo()
        Dim DescripcionProductoCatalogo As String = txtdescripcionproductocatalogo.Text
        Dim CostoUnitarioCatalogo As String = txtcostounitariocatalogo.Text
        Dim PrecioVentaCatalogo As String = txtprecioventacatalogo.Text
        Dim ExistenciasCatalogo As String = txtexistenciascatalogo.Text
        Dim ImpuestoCatalogo As String = txtimpuestocatalogo.Text
        conexion = New SqlConnection("Data Source=WIN-9OB8BQ69IMI;Initial Catalog=SISTEMA_DE_VENTAS;User ID=sa;Password=Hola123")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "insertarcatalogo"
        comando.Parameters.AddWithValue("@descripcion", DescripcionProductoCatalogo)
        comando.Parameters.AddWithValue("@costo_unitario", Convert.ToDecimal(CostoUnitarioCatalogo))
        comando.Parameters.AddWithValue("@precio_venta", Convert.ToDecimal(PrecioVentaCatalogo))
        comando.Parameters.AddWithValue("@existencias", ExistenciasCatalogo)
        comando.Parameters.AddWithValue("@impuesto_venta", Convert.ToDecimal(ImpuestoCatalogo))
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        DataCatalogo.DataSource = tabla
        conexion.Close()
        Deshabilitar()
    End Sub
    Private Sub EditarCatalogo()
        Dim CodCatalogo As String = DataCatalogo.SelectedCells.Item(0).Value
        Dim DescripcionProductoCatalogo As String = txtdescripcionproductocatalogo.Text
        Dim CostoUnitarioCatalogo As String = txtcostounitariocatalogo.Text
        Dim PrecioVentaCatalogo As String = txtprecioventacatalogo.Text
        Dim ExistenciasCatalogo As String = txtexistenciascatalogo.Text
        Dim ImpuestoCatalogo As String = txtimpuestocatalogo.Text
        conexion = New SqlConnection("Data Source=WIN-9OB8BQ69IMI;Initial Catalog=SISTEMA_DE_VENTAS;User ID=sa;Password=Hola123")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "editarcatalogo"
        comando.Parameters.AddWithValue("@cod_catalogo", CodCatalogo)
        comando.Parameters.AddWithValue("@descripcion", DescripcionProductoCatalogo)
        comando.Parameters.AddWithValue("@costo_unitario", Convert.ToDecimal(CostoUnitarioCatalogo))
        comando.Parameters.AddWithValue("@precio_venta", Convert.ToDecimal(PrecioVentaCatalogo))
        comando.Parameters.AddWithValue("@existencias", ExistenciasCatalogo)
        comando.Parameters.AddWithValue("@impuesto_venta", Convert.ToDecimal(ImpuestoCatalogo))
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        DataCatalogo.DataSource = tabla
        conexion.Close()
    End Sub
    Private Sub EliminarCatalogo()
        Dim CodCatalogo As String = DataCatalogo.SelectedCells.Item(0).Value
        conexion = New SqlConnection("Data Source=WIN-9OB8BQ69IMI;Initial Catalog=SISTEMA_DE_VENTAS;User ID=sa;Password=Hola123")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "eliminarcatalogo"
        comando.Parameters.AddWithValue("@sku", CodCatalogo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        MostrarTablaCatalogo()
        'DataCliente.DataSource = tabla
        conexion.Close()
    End Sub
    Private Sub buscar()
        Dim ds As New DataSet 'para crear una copia y cargar los datos ahi 
        ds.Tables.Add(tabla.Copy)
        Dim dv As New DataView(ds.Tables(0))
        dv.RowFilter = "descripcion" & " like'" & txtbuscarproducto.Text & "%'"
        DataCatalogo.DataSource = dv
    End Sub
    Private Sub mostrareditarcatalogo()
        txtdescripcionproductocatalogo.Text = DataCatalogo.SelectedCells.Item(1).Value
        txtcostounitariocatalogo.Text = DataCatalogo.SelectedCells.Item(2).Value
        txtprecioventacatalogo.Text = DataCatalogo.SelectedCells.Item(3).Value
        txtexistenciascatalogo.Text = DataCatalogo.SelectedCells.Item(4).Value
        txtimpuestocatalogo.Text = DataCatalogo.SelectedCells.Item(5).Value
    End Sub

    Private Sub txtbuscarproducto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscarproducto.TextChanged
        buscar()
    End Sub

    Private Sub btnIngresarCatalogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarCatalogo.Click
        InsertarCatalogo()
        MostrarTablaCatalogo()
    End Sub

    Private Sub DataCatalogo_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataCatalogo.CellClick
        mostrareditarcatalogo()
        Habilitar()
    End Sub

    Private Sub btnEditarCatalogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarCatalogo.Click
        EditarCatalogo()
        MostrarTablaCatalogo()
    End Sub

    Private Sub btnEliminarCatalogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarCatalogo.Click
        EliminarCatalogo()
    End Sub

    Private Sub btnNuevoCatalogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoCatalogo.Click
        Habilitar()
        Limpiar()
    End Sub

    Private Sub VentanaCatalogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarTablaCatalogo()
    End Sub
End Class