﻿Imports System.Data.SqlClient

Public Class Connect
    Public Function connect() As SqlConnection
        Dim strcon As String
        strcon = "Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"
        'strcon = "Data Source=PC\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True"

        Dim cn As New SqlConnection
        cn.ConnectionString = strcon
        cn.Open()
        Return cn
    End Function
End Class
