Imports System.Data.SqlClient
Imports DTO

Public Class LoaiKhachHangDAO
    Public Shared Function LoadDSLoaiKhachHang() As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("Select * from LOAIKHACHHANG", cn)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function ThemLoaiKhachHang(ByVal LKHDTO As LoaiKhachHangDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()

        Dim cmd As New SqlCommand("ThemLoaiKhachHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaLoaiKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenLoaiKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaLoaiKhachHang").Value = LKHDTO.MaLoaiKhachHang1
        cmd.Parameters("@TenLoaiKhachHang").Value = LKHDTO.TenLoaiKhachHang1
        cmd.Parameters("@GhiChu").Value = LKHDTO.GhiChu1
        cmd.Parameters("@TinhTrang").Value = LKHDTO.TinhTrang1

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function

    Public Shared Function XoaLoaiKhachHang(ByVal maloaikh As String) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("Delete From LOAIKHACHHANG where MaLoaiKhachHang = '" & maloaikh & "'", cn)
        cmd.CommandType = CommandType.Text
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function

    Public Sub SuaLoaiKhachHang(ByVal LKHDTO As LoaiKhachHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaLoaiKhachHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaLoaiKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenLoaiKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaLoaiKhachHang").Value = LKHDTO.MaLoaiKhachHang1
        cmd.Parameters("@TenLoaiKhachHang").Value = LKHDTO.TenLoaiKhachHang1
        cmd.Parameters("@GhiChu").Value = LKHDTO.GhiChu1
        cmd.Parameters("@TinhTrang").Value = LKHDTO.TinhTrang1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
