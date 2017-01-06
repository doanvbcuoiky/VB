Imports System.Data.SqlClient

Public Class Connect
    Public Function connect() As SqlConnection
        Dim strcon As String
        strcon = "Data Source=DUY-NGUYEN\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"
        Dim cn As New SqlConnection
        cn.ConnectionString = strcon
        cn.Open()
        Return cn
    End Function
End Class
