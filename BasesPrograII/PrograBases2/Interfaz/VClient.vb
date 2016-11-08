Imports System.Data
Imports System.Data.SqlClient

Public Class VClient
    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Dim parametro As SqlParameter
    'El apatador es donde se almacena la info que devuelve la consulta
    Dim adaptador As SqlDataAdapter
    'tabla es donde se guarda los datos de la consulta
    Dim tabla As DataTable
    Private Sub VClient_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("data source=(local);initial catalog=SISTEMA_DE_VENTAS;integrated security=true")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "VerDatosClientes"
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        DataGridView1.DataSource = tabla
        conexion.Close()
        If DataGridView1.RowCount <> 1 Then
            sinDatos.Visible = False
        Else
            DataGridView1.DataSource = Nothing
        End If
    End Sub

    Private Sub SelectCliente_Click(sender As System.Object, e As System.EventArgs) Handles SelectCliente.Click
        Dim CodClientess As String = DataGridView1.SelectedCells.Item(0).Value
        Dim Clientess As String = DataGridView1.SelectedCells.Item(1).Value
        VentanaPedido.txtclientepedido.Text = Clientess
        VentanaPedido.txtcodigoclientepedido.Text = CodClientess
        Me.Close()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub
    Private Sub buscar()
        Dim ds As New DataSet 'para crear una copia y cargar los datos ahi 
        ds.Tables.Add(tabla.Copy)
        Dim dv As New DataView(ds.Tables(0))
        dv.RowFilter = "NOMBRE_CLIENTE" & " like'" & txtBuscar.Text & "%'"
        DataGridView1.DataSource = dv
    End Sub
End Class