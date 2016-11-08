Imports System.Data
Imports System.Data.SqlClient

Public Class VentanaPersonal
    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Dim parametro As SqlParameter
    'El apatador es donde se almacena la info que devuelve la consulta
    Dim adaptador As SqlDataAdapter
    'tabla es donde se guarda los datos de la consulta
    Dim tabla As DataTable
    Dim DataPersonal As Object

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SISTEMA_DE_VENTASDataSet4.verDatosJefe' Puede moverla o quitarla según sea necesario.
        Me.VerDatosJefeTableAdapter1.Fill(Me.SISTEMA_DE_VENTASDataSet4.verDatosJefe)
        'TODO: esta línea de código carga datos en la tabla 'SISTEMA_DE_VENTASDataSet3.verDatosJefe' Puede moverla o quitarla según sea necesario.
        Me.VerDatosJefeTableAdapter.Fill(Me.SISTEMA_DE_VENTASDataSet3.verDatosJefe)
        'TODO: esta línea de código carga datos en la tabla 'SISTEMA_DE_VENTASDataSet2.VerDatosPuesto' Puede moverla o quitarla según sea necesario.
        Me.VerDatosPuestoTableAdapter1.Fill(Me.SISTEMA_DE_VENTASDataSet2.VerDatosPuesto)
        'TODO: esta línea de código carga datos en la tabla 'SISTEMA_DE_VENTASDataSet1.VerDatosPuesto' Puede moverla o quitarla según sea necesario.
        Me.VerDatosPuestoTableAdapter.Fill(Me.SISTEMA_DE_VENTASDataSet1.VerDatosPuesto)
        MostrarTablaPersonal()
    End Sub


    Private Sub Limpiar()
        txtidempleadopersonal.Text = ""
        txtnombrepersonal.Text = ""
        txtprimerapellidopersonal.Text = ""
        txttelefonopersonal.Text = ""
        txtcorreopersonal.Text = ""
        txtresidenciapersonal.Text = ""
        cbopuestopersonal.Text = ""
        DTPnacimientopersonal.Text = ""
        DTPingresopersonal.Text = ""
        DTPretiropersonal.Text = ""
        cbojefepersonal.Text = ""
    End Sub
    Private Sub Habilitar()
        txtidempleadopersonal.Enabled = True
        txtnombrepersonal.Enabled = True
        txtprimerapellidopersonal.Enabled = True
        txttelefonopersonal.Enabled = True
        txtcorreopersonal.Enabled = True
        txtresidenciapersonal.Enabled = True
        cbopuestopersonal.Enabled = True
        DTPnacimientopersonal.Enabled = True
        DTPingresopersonal.Enabled = True
        DTPretiropersonal.Enabled = True
        cbojefepersonal.Enabled = True
    End Sub
    Private Sub Deshabilitar()
        txtidempleadopersonal.Enabled = False
        txtnombrepersonal.Enabled = False
        txtprimerapellidopersonal.Enabled = False
        txttelefonopersonal.Enabled = False
        txtcorreopersonal.Enabled = False
        txtresidenciapersonal.Enabled = False
        cbopuestopersonal.Enabled = False
        DTPnacimientopersonal.Enabled = False
        DTPingresopersonal.Enabled = False
        DTPretiropersonal.Enabled = False
        cbojefepersonal.Enabled = False
    End Sub
    Private Sub MostrarTablaPersonal()
        conexion = New SqlConnection("data source=(local);initial catalog=SISTEMA_DE_VENTAS;integrated security=true")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "VerDatosPersonal"
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        DataPersonal1.DataSource = tabla
        conexion.Close()
        If DataPersonal1.RowCount <> 1 Then
            sinDatos.Visible = False
        Else
            DataPersonal1.DataSource = Nothing
        End If
    End Sub
    Private Sub InsertarPersonal()
        Dim CodPersonal As String = txtidempleadopersonal.Text
        Dim NomPersonal As String = txtnombrepersonal.Text
        Dim Apell1Personal As String = txtprimerapellidopersonal.Text
        Dim Apell2Personal As String = txtsegundoapellidopersonal.Text
        Dim TelefonoPersonal As String = txttelefonopersonal.Text
        Dim Correo_Perosnal As String = txtcorreopersonal.Text
        Dim ResidenciaPersonal As String = txtresidenciapersonal.Text
        Dim PuestoPerosonal As String = cbopuestopersonal.SelectedValue
        Dim FechaNacimiento As String = DTPnacimientopersonal.Text
        Dim FechaIngreso As String = DTPingresopersonal.Text
        Dim FechaRetiro As String = DTPretiropersonal.Text
        Dim JefePersonal As String = cbojefepersonal.SelectedValue

        conexion = New SqlConnection("data source=(local);initial catalog=SISTEMA_DE_VENTAS;integrated security=true")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "InsertarPersonal"
        comando.Parameters.AddWithValue("@nombre_empleado", NomPersonal)
        comando.Parameters.AddWithValue("@apellido1_empleado", Apell1Personal)
        comando.Parameters.AddWithValue("@apellido2_empleado", Apell2Personal)
        comando.Parameters.AddWithValue("@telefono_empleado", TelefonoPersonal)
        comando.Parameters.AddWithValue("@correo_empleado", Correo_Perosnal)
        comando.Parameters.AddWithValue("@residencia_empleado", ResidenciaPersonal)
        comando.Parameters.AddWithValue("@puesto_empleado", PuestoPerosonal)
        comando.Parameters.AddWithValue("@fecha_nacimiento", FechaNacimiento)
        comando.Parameters.AddWithValue("@fecha_ingreso", FechaIngreso)
        comando.Parameters.AddWithValue("@fecha_retiro", FechaRetiro)
        comando.Parameters.AddWithValue("@jefe_empleado", JefePersonal)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        DataPersonal1.DataSource = tabla
        conexion.Close()
        Deshabilitar()
    End Sub
    Private Sub EditarPersonal()
        Dim CodPersonal As String = txtidempleadopersonal.Text
        Dim NomPersonal As String = txtnombrepersonal.Text
        Dim Apell1Personal As String = txtprimerapellidopersonal.Text
        Dim Apell2Personal As String = txtsegundoapellidopersonal.Text()
        Dim TelefonoPersonal As String = txttelefonopersonal.Text
        Dim Correo_Perosnal As String = txtcorreopersonal.Text
        Dim ResidenciaPersonal As String = txtresidenciapersonal.Text
        Dim PuestoPerosonal As String = cbopuestopersonal.Text()
        Dim FechaNacimiento As String = DTPnacimientopersonal.Text
        Dim FechaIngreso As String = DTPingresopersonal.Text
        Dim FechaRetiro As String = DTPretiropersonal.Text
        Dim JefePersonal As String = cbojefepersonal.Text

        conexion = New SqlConnection("data source=(local);initial catalog=SISTEMA_DE_VENTAS;integrated security=true")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "editarPersonal"
        comando.Parameters.AddWithValue("@nombre_empleado", NomPersonal)
        comando.Parameters.AddWithValue("@apellido1_empleado", Apell1Personal)
        comando.Parameters.AddWithValue("@apellido2_empleado", Apell2Personal)
        comando.Parameters.AddWithValue("@telefono_empleado", TelefonoPersonal)
        comando.Parameters.AddWithValue("@correo_empleado", Correo_Perosnal)
        comando.Parameters.AddWithValue("@residencia_empleado", ResidenciaPersonal)
        comando.Parameters.AddWithValue("@puesto_empleado", PuestoPerosonal)
        comando.Parameters.AddWithValue("@fecha_nacimiento", FechaNacimiento)
        comando.Parameters.AddWithValue("@fecha_ingreso", FechaIngreso)
        comando.Parameters.AddWithValue("@fecha_retiro", FechaRetiro)
        comando.Parameters.AddWithValue("@jefe_empleado", JefePersonal)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        DataPersonal1.DataSource = tabla
        conexion.Close()
    End Sub
    Private Sub EliminarPersonal()
        Dim CodPersonal As String = DataPersonal.SelectedCells.Item(0).Value()
        conexion = New SqlConnection("data source=(local);initial catalog=SISTEMA_DE_VENTAS;integrated security=true")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "eliminarPersonal"
        comando.Parameters.AddWithValue("@codigo_empleado", CodPersonal)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        adaptador.Fill(tabla)
        MostrarTablaPersonal()
        conexion.Close()
    End Sub
    Private Sub buscar()
        Dim ds As New DataSet 'para crear una copia y cargar los datos ahi 
        ds.Tables.Add(tabla.Copy)
        Dim dv As New DataView(ds.Tables(0))
        dv.RowFilter = "NOMBRE" & " like'" & txtbuscarpersonal.Text & "%'"
        DataPersonal1.DataSource = dv
    End Sub
    Private Sub mostrareditarPersonal()
        txtidempleadopersonal.Text = DataPersonal.SelectedCells.Item(0).Value
        txtnombrepersonal.Text = DataPersonal.SelectedCells.Item(1).Value
        txtprimerapellidopersonal.Text = DataPersonal.SelectedCells.Item(2).Value
        txtsegundoapellidopersonal.Text = DataPersonal.SelectedCells.Item(3).Value
        txttelefonopersonal.Text = DataPersonal.SelectedCells.Item(4).Value
        txtcorreopersonal.Text = DataPersonal.SelectedCells.Item(5).Value
        txtresidenciapersonal.Text = DataPersonal.SelectedCells.Item(6).Value
        cbopuestopersonal.Text = DataPersonal.SelectedCells.Item(7).Value
        DTPnacimientopersonal.Text = DataPersonal.SelectedCells.Item(8).Value
        DTPingresopersonal.Text = DataPersonal.SelectedCells.Item(9).Value
        DTPretiropersonal.Text = DataPersonal.SelectedCells.Item(10).Value
        cbojefepersonal.Text = DataPersonal.SelectedCells.Item(11).Value
    End Sub

    Private Sub btnregistrarpersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrarpersonal.Click
        InsertarPersonal()
        MostrarTablaPersonal()
    End Sub

    Private Sub btnmodificarempleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarempleado.Click
        EditarPersonal()
    End Sub

    Private Sub DataPersonal1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataPersonal1.CellClick
        mostrareditarPersonal()
    End Sub

End Class
