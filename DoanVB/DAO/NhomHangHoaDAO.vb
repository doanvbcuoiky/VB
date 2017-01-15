Imports System.Data.SqlClient
Imports DTO

Public Class NhomHangHoaDAO
    Public Shared Function ThongTinNhomHang(ByVal ma As String) As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("select * from NHOMHANGHOA where MaNhomHang = '" & ma & "'", cn)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function LoadDSNhomHangHoa() As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("select * from NHOMHANGHOA", cn)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function ThemNhomHangHoa(ByVal NHHDTO As NhomHangHoaDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()

        Dim cmd As New SqlCommand("ThemNhomHangHoa", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaNhomHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenNhomHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaNhomHang").Value = NHHDTO.MaNhomHang1
        cmd.Parameters("@TenNhomHang").Value = NHHDTO.TenNhomHang1
        cmd.Parameters("@GhiChu").Value = NHHDTO.GhiChu1
        cmd.Parameters("@TinhTrang").Value = NHHDTO.TinhTrang1

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function

    Public Shared Function XoaNhomHangHoa(ByVal manhomhang As String) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("Delete From NHOMHANGHOA where MaNhomHang = '" & manhomhang & "'", cn)
        cmd.CommandType = CommandType.Text
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function

    Public Shared Function SuaNhomHangHoa(ByVal NHHDTO As NhomHangHoaDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaNhomHangHoa", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaNhomHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenNhomHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaNhomHang").Value = NHHDTO.MaNhomHang1
        cmd.Parameters("@TenNhomHang").Value = NHHDTO.TenNhomHang1
        cmd.Parameters("@GhiChu").Value = NHHDTO.GhiChu1
        cmd.Parameters("@TinhTrang").Value = NHHDTO.TinhTrang1

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function
End Class
