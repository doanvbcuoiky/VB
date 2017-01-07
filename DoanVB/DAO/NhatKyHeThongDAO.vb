Imports System.Data.SqlClient
Imports DTO
Public Class NhatKyHeThongDAO
    Public Shared Function LoadDSNhatKy() As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("Select * from NHATKYHETHONG", cn)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
End Class
