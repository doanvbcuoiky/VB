Imports System.Data.SqlClient
Imports DTO

Public Class NhanVienDAO
    Public Function LoadDSNhanVien() As DataTable
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim dt As DataTable
        Dim cmd As New SqlCommand("LoadDSNhanVien", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Sub ThemNhanVien(ByVal NVDTO As NhanVienDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("ThemNhanVien", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaNhanVien", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenNhanVien", SqlDbType.NVarChar)
        cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Email", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar)
        cmd.Parameters.Add("@BoPhan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NguoiQuanLi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaNhanVien").Value = NVDTO.MaNhanVien1
        cmd.Parameters("@TenNhanVien").Value = NVDTO.TenNhanVien1
        cmd.Parameters("@ChucVu").Value = NVDTO.ChucVu1
        cmd.Parameters("@DiaChi").Value = NVDTO.DiaChi1
        cmd.Parameters("@Email").Value = NVDTO.Email1
        cmd.Parameters("@DienThoai").Value = NVDTO.DienThoai1
        cmd.Parameters("@BoPhan").Value = NVDTO.BoPhan1
        cmd.Parameters("@NguoiQuanLi").Value = NVDTO.NguoiQuanLi1
        cmd.Parameters("@TinhTrang").Value = NVDTO.TinhTrang1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub XoaNhanVien(ByVal NVDTO As NhanVienDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("XoaNhanVien", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaNhanVien", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenNhanVien", SqlDbType.NVarChar)
        cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Email", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar)
        cmd.Parameters.Add("@BoPhan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NguoiQuanLi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaNhanVien").Value = NVDTO.MaNhanVien1
        cmd.Parameters("@TenNhanVien").Value = NVDTO.TenNhanVien1
        cmd.Parameters("@ChucVu").Value = NVDTO.ChucVu1
        cmd.Parameters("@DiaChi").Value = NVDTO.DiaChi1
        cmd.Parameters("@Email").Value = NVDTO.Email1
        cmd.Parameters("@DienThoai").Value = NVDTO.DienThoai1
        cmd.Parameters("@BoPhan").Value = NVDTO.BoPhan1
        cmd.Parameters("@NguoiQuanLi").Value = NVDTO.NguoiQuanLi1
        cmd.Parameters("@TinhTrang").Value = NVDTO.TinhTrang1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub SuaNhanVien(ByVal NVDTO As NhanVienDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaNhanVien", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaNhanVien", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenNhanVien", SqlDbType.NVarChar)
        cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Email", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar)
        cmd.Parameters.Add("@BoPhan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NguoiQuanLi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaNhanVien").Value = NVDTO.MaNhanVien1
        cmd.Parameters("@TenNhanVien").Value = NVDTO.TenNhanVien1
        cmd.Parameters("@ChucVu").Value = NVDTO.ChucVu1
        cmd.Parameters("@DiaChi").Value = NVDTO.DiaChi1
        cmd.Parameters("@Email").Value = NVDTO.Email1
        cmd.Parameters("@DienThoai").Value = NVDTO.DienThoai1
        cmd.Parameters("@BoPhan").Value = NVDTO.BoPhan1
        cmd.Parameters("@NguoiQuanLi").Value = NVDTO.NguoiQuanLi1
        cmd.Parameters("@TinhTrang").Value = NVDTO.TinhTrang1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
