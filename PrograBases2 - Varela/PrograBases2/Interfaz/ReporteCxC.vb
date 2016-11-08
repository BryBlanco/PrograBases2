Imports System.Data
Imports System.Data.SqlClient

Public Class ReporteCxC
    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Dim parametro As SqlParameter
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Private Sub ReporteCxC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarTablaCxC()
    End Sub

    Private Sub MostrarTablaCxC()
        Dim fecha1 As String = DateTimePicker1.Text
        Dim fecha2 As String = DateTimePicker2.Text
        conexion = New SqlConnection("Data Source=WIN-9OB8BQ69IMI;Initial Catalog=SISTEMA_DE_VENTAS;User ID=sa;Password=Hola123")
        conexion.Open()
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "VerDatosCxC"
        comando.Parameters.AddWithValue("@inicio", fecha1)
        comando.Parameters.AddWithValue("@fin", fecha2)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable
        tabla = New DataTable
        adaptador.Fill(tabla)
        DataReporteCxC.DataSource = tabla
        conexion.Close()
    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        If DateTimePicker1.Value > DateTimePicker2.Value Then
            Dim msg As String = "Error de fechas, ingréselas en orden."
            MsgBox(msg, MsgBoxStyle.Information, "Error")
        Else : MostrarTablaCxC()
        End If
    End Sub
    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        If DateTimePicker2.Value < DateTimePicker1.Value Then
            Dim msg As String = "Error de fechas, ingréselas en orden."
            MsgBox(msg, MsgBoxStyle.Information, "Error")
        Else : MostrarTablaCxC()
        End If
    End Sub
End Class