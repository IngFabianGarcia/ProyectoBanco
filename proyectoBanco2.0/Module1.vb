Imports System.Data.SqlClient

Module Miconexion
    Public user As String
    Public pass As String

    Public conexion = New SqlConnection()

    Sub abrir_Conexion()
        conexion = New SqlConnection("Data Source=HUE-LAB-1B2\SQLEXPRESS;Initial Catalog=BANCO;User ID=" & user & ";Password=" & pass & ";")
        If conexion.State = 0 Then
            conexion.open()
            MsgBox("Conectado Correctamente")
        End If
    End Sub
End Module
