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
    Public Shared Sub ThemNhatKy(ByVal user As String, ByVal chucnang As String, ByVal hanhdong As String)
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()

        Dim maytinh As String = Environment.MachineName.ToString()
        Dim thoigian As String = DateAndTime.Now.ToString()
        Dim cmd As New SqlCommand("insert into NHATKYHETHONG values('" & user & "', '" & maytinh & "', '" & thoigian & "', N'" & chucnang & "', N'" & hanhdong & "')", cn)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
