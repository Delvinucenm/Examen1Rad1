Public Class FrmRegistroEmpleados
    Private Sub btnsalir1_Click(sender As Object, e As EventArgs) Handles btnsalir1.Click
        Application.Exit()
    End Sub

    Private Sub btnsucursal_Click(sender As Object, e As EventArgs) Handles btnsucursal.Click
        Me.Dispose()
        FrmSucursales.ShowDialog()
    End Sub
End Class