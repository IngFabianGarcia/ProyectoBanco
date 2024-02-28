Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BancoDataSet1.CUENTAS' Puede moverla o quitarla según sea necesario.
        Me.CUENTASTableAdapter1.Fill(Me.BancoDataSet1.CUENTAS)


    End Sub

    Private Sub btnAgregarRegistro_Click(sender As Object, e As EventArgs) Handles btnAgregarRegistro.Click
        Try
            abrir_Conexion()
            'Inicia la transaccion'
            Dim sqlTrans As SqlTransaction
            sqlTrans = conexion.beginTransaction()
            'Termina transaccion'

            Dim cmd As New System.Data.SqlClient.SqlCommand
            'Toma los datos ingresados para insertarlos a la base de datos'
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "insert into cuentas (apellidos,nombre,saldo) values('" & txtApellidos.Text & "','" & txtNombre.Text & "'," & txtSaldo.Text & ")"
            cmd.Connection = conexion
            cmd.Transaction = sqlTrans
            cmd.ExecuteNonQuery()
            Dim respuesta As Byte

            'Muestra mensaje con opcion de lo que se desea realizar'

            respuesta = MsgBox("¿Quiere agregar la cuenta?", vbYesNoCancel)

            'Si la respuesta es si realiza el commit'
            If respuesta = 6 Then
                cmd.Transaction.Commit()
                Me.CUENTASTableAdapter1.Fill(Me.BancoDataSet1.CUENTAS)
                MsgBox("Registro agregado existosamente")
            Else
                'Si es otra la respueta se realiza un rollback'
                cmd.Transaction.Rollback()
                txtApellidos.Text = ""
                txtNombre.Text = ""
                txtSaldo.Text = ""
                MsgBox("Registro Cancelado")
            End If
            conexion.close()


            Me.CUENTASTableAdapter1.Fill(Me.BancoDataSet1.CUENTAS)
        Catch ex As SqlException
            'Muestra error generado'
            MsgBox("Surgio un error    " + ex.Message)

        End Try
    End Sub
End Class
