Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BancoDataSet.cuentas' Puede moverla o quitarla según sea necesario.
        Me.CuentasTableAdapter.Fill(Me.BancoDataSet.cuentas)

    End Sub

    Private Sub btnAgregarRegistro_Click(sender As Object, e As EventArgs) Handles btnAgregarRegistro.Click
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "insert into cuentas (apellidos,nombre,saldo) values('" & txtApellidos.Text & "','" & txtNombre.Text & "'," & txtSaldo.Text & ")"
            cmd.Connection = conexion
            abrir_Conexion()
            cmd.ExecuteNonQuery()
            MsgBox("Registro agregado existosamente")
            Me.CuentasTableAdapter.Fill(Me.BancoDataSet.cuentas)
        Catch ex As SqlException
            MsgBox("Surgio un error    " + ex.Message)
        End Try
    End Sub
End Class
