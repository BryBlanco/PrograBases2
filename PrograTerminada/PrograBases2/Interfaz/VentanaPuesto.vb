Imports System.Data
Imports System.Data.SqlClient
Public Class VentanaPuesto
    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Dim parametro As SqlParameter
    'El apatador es donde se almacena la info que devuelve la consulta
    Dim adaptador As SqlDataAdapter
    'tabla es donde se guarda los datos de la consulta
    Dim tabla As DataTable

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarTablaPuesto()
    End Sub
    Private Sub Limpiar()
        txtnuevopuesto.Text = ""
        txtcodigopuesto.Text = ""
    End Sub
    Private Sub MostrarTablaPuesto()
        conexion = New SqlConnection("data source=(local);initial catalog=SISTEMA_DE_VENTAS;integrated security=true")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "VerDatosPuesto"
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        DataPuesto.DataSource = tabla
        conexion.Close()
        If DataPuesto.RowCount <> 1 Then
            sinDatos.Visible = False
        Else
            DataPuesto.DataSource = Nothing
        End If
    End Sub
    Private Sub InsertarPuesto()
        Dim NuevoPuesto As String = txtnuevopuesto.Text
        Dim CodPuesto As String = txtcodigopuesto.Text

        conexion = New SqlConnection("data source=(local);initial catalog=SISTEMA_DE_VENTAS;integrated security=true")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "InsertarPuesto"
        comando.Parameters.AddWithValue("@nombre_puesto", NuevoPuesto)
        comando.Parameters.AddWithValue("@Id_puesto", CodPuesto)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        DataPuesto.DataSource = tabla
        conexion.Close()
    End Sub

    Private Sub btopuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btopuesto.Click
        InsertarPuesto()
        MostrarTablaPuesto()
    End Sub


End Class
