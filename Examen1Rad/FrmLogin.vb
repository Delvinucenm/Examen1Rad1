Imports System.Data.SqlClient
Public Class FrmLogin
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Application.Exit()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        txtusuario.Clear()
        txtcontrasena.Clear()
        txtusuario.Focus()
    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click

        Dim con As New SqlClient.SqlConnection(My.Settings.ExamenRAD)
        con.Open()
        Dim reader As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("SELECT * FROM Usuarios WHERE idusuario = '" & txtusuario.Text & " ' and contrasena =  '" & txtcontrasena.Text & "' ", con)
        reader = cmd.ExecuteReader

        If reader.Read() Then
            If reader.Item("activo") = True Then
                VariablesPublicas.idusuario = reader.Item("idusuario")
                VariablesPublicas.nivelacceso = reader.Item("nivelacceso")
                VariablesPublicas.nombreusuario = reader.Item("NombresCompletos")
                Me.Dispose()
                FrmRegistroEmpleados.ShowDialog()
            Else
                MessageBox.Show("Usuario inactivo")
            End If
        Else
            MessageBox.Show("Usuario o contrasena incorrectos")
        End If

    End Sub
End Class