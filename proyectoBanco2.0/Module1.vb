Imports System.Data.SqlClient

Module Miconexion
    Public conexion = New SqlConnection("Data Source=FABIPC\SQLEXPRESS;Initial Catalog=Banco;Persist Security Info=True;User ID=SA;Password=58905326;Encrypt=True;TrustServerCertificate=True")

    Sub abrir_Conexion()
        If conexion.State = 0 Then
            conexion.open()
        End If
    End Sub
End Module
