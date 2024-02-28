Imports System.Data.SqlClient

Module Miconexion
    Public conexion = New SqlConnection("Data Source=HUE-LAB-1H4\SQLEXPRESS;Initial Catalog=Banco;Persist Security Info=True;User ID=sa;Password=Umg$2023")

    Sub abrir_Conexion()
        If conexion.State = 0 Then
            conexion.open()
        End If
    End Sub
End Module
