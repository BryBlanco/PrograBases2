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

    Private Sub CatalogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogoToolStripMenuItem.Click
        VentanaCatalogo.Show()
    End Sub
End Class