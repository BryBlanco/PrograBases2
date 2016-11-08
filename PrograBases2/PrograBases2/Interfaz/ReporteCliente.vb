﻿Imports System.Data.SqlClient
Imports System.Data

Public Class ReporteCliente

    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Dim parametro As SqlParameter
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter

    Private Sub ReporteCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarTablaClientes()
    End Sub

    Private Sub MostrarTablaClientes()
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
    End Sub
End Class
