Imports System.Data.SqlClient
Imports DTO

Public Class NhomHangHoaDAO
    Public Function LoadDSNhomHangHoa() As DataTable
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim dt As DataTable
        Dim cmd As New SqlCommand("LoadDSNhomHangHoa", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Sub ThemNhomHangHoa(ByVal NHHDTO As NhomHangHoaDTO)
        Dim con As Connect
        Dim cn As SqlConnection
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

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub XoaNhomHangHoa(ByVal NHHDTO As NhomHangHoaDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("XoaNhomHangHoa", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaNhomHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenNhomHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaNhomHang").Value = NHHDTO.MaNhomHang1
        cmd.Parameters("@TenNhomHang").Value = NHHDTO.TenNhomHang1
        cmd.Parameters("@GhiChu").Value = NHHDTO.GhiChu1
        cmd.Parameters("@TinhTrang").Value = NHHDTO.TinhTrang1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub SuaNhomHangHoa(ByVal NHHDTO As NhomHangHoaDTO)
        Dim con As Connect
        Dim cn As SqlConnection
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

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
