Imports System.Data.SqlClient
Imports DTO

Public Class KhuVucDAO
    Public Shared Function LoadDSKhuVuc() As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("Select * from KHUVUC", cn)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function ThemKhuVuc(ByVal KVDTO As KhuVucDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()

        Dim cmd As New SqlCommand("ThemKhuVuc", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaKhuVuc", SqlDbType.VarChar)
        cmd.Parameters.Add("@TenKhuVuc", SqlDbType.NVarChar)
        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaKhuVuc").Value = KVDTO.MaKhuVuc1
        cmd.Parameters("@TenKhuVuc").Value = KVDTO.TenKhuVuc1
        cmd.Parameters("@GhiChu").Value = KVDTO.GhiChu1
        cmd.Parameters("@TinhTrang").Value = KVDTO.TinhTrang1

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function

    Public Shared Function XoaKhuVuc(ByVal makhuvuc As String) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("Delete From KHUVUC where MaKhuVuc = '" & makhuvuc & "'", cn)
        cmd.CommandType = CommandType.Text
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function

    Public Sub SuaKhuVuc(ByVal KVDTO As KhuVucDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaKhuVuc", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaKhuVuc", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenKhuVuc", SqlDbType.NVarChar)
        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaKhuVuc").Value = KVDTO.MaKhuVuc1
        cmd.Parameters("@TenKhuVuc").Value = KVDTO.TenKhuVuc1
        cmd.Parameters("@GhiChu").Value = KVDTO.GhiChu1
        cmd.Parameters("@TinhTrang").Value = KVDTO.TinhTrang1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
