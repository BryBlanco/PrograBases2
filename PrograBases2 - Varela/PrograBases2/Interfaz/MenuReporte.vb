Public Class MenuReporte

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If ComboBox1.SelectedItem.Equals("Clientes") Then
                Dim form As ReporteCliente
                form = New ReporteCliente()
                form.Show()
                form = Nothing
            End If
            If ComboBox1.SelectedItem.Equals("Condiciones de Pago de Clientes") Then
                Dim form As ReporteCondicionPago
                form = New ReporteCondicionPago()
                form.Show()
                form = Nothing
            End If
            If ComboBox1.SelectedItem.Equals("Catálogo de Productos") Then
                Dim form As ReporteCatalogo
                form = New ReporteCatalogo()
                form.Show()
                form = Nothing
            End If
            If ComboBox1.SelectedItem.Equals("Pedidos") Then
                Dim form As ReportePedido
                form = New ReportePedido()
                form.Show()
                form = Nothing
            End If
            If ComboBox1.SelectedItem.Equals("Facturas") Then
                Dim form As ReporteFactura
                form = New ReporteFactura()
                form.Show()
                form = Nothing
            End If
            If ComboBox1.SelectedItem.Equals("Cuentas por Cobrar") Then
                Dim form As ReporteCxC
                form = New ReporteCxC()
                form.Show()
                form = Nothing
            End If
            If ComboBox1.SelectedItem.Equals("Personal") Then
                Dim form As ReportePersonal
                form = New ReportePersonal()
                form.Show()
                form = Nothing
            End If
        Catch ex As Exception
            Dim msg As String
            msg = "No seleccionó una opción. Inténtelo de nuevo."
            MsgBox(msg, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.KeyChar = ""
    End Sub

End Class