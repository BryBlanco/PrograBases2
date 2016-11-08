Public Class Menu
    Private Sub ClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        RegistroCliente.Show()
    End Sub
    Private Sub EmpleadosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmpleadosToolStripMenuItem.Click
        'VentanaPersonal.Show()
    End Sub
    Private Sub PedidosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PedidosToolStripMenuItem.Click
        VentanaPedido.Show()
    End Sub

    Private Sub PuestosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PuestosToolStripMenuItem.Click
        VentanaPuesto.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ClientesToolStripMenuItem1.Click
        ReporteCliente.Show()
    End Sub
    Private Sub CatalogoDeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CatalogoDeToolStripMenuItem.Click
        ReporteCatalogo.Show()
    End Sub


    Private Sub CodicionesDePagoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CodicionesDePagoToolStripMenuItem.Click
        ReporteCondicionPago.Show()
    End Sub

    Private Sub PedidosToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PedidosToolStripMenuItem1.Click
        ReportePedido.Show()
    End Sub

    Private Sub FacturasToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles FacturasToolStripMenuItem1.Click
        ReporteFactura.Show()
    End Sub

    Private Sub CuentasPorCobrarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CuentasPorCobrarToolStripMenuItem.Click
        ReporteCxC.Show()
    End Sub

    Private Sub PersonalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PersonalToolStripMenuItem.Click
        ReportePersonal.Show()
    End Sub

    Private Sub CatalogoProductosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CatalogoProductosToolStripMenuItem.Click
        VentanaCatalogo.Show()
    End Sub
End Class