﻿Imports System.Data.SqlClient
Imports System.Data

Public Class ReporteCatalogo

    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Dim parametro As SqlParameter
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter

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
        DataGridView1.DataSource = tabla
        conexion.Close()
    End Sub

    Private Sub ReporteCatalogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarTablaCatalogo()
    End Sub
End Class