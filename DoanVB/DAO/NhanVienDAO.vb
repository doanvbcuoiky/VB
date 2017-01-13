Imports System.Data.SqlClient
Imports DTO

Public Class NhanVienDAO

    Public Shared Function ThongTinNhanVien(ByVal MaNhanVien As String) As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("Select * from NHANVIEN where MaNhanVien = '" & MaNhanVien & "'", cn)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function LoadDSNhanVien() As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("Select * from NHANVIEN", cn)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function ThemNhanVien(ByVal NVDTO As NhanVienDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
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

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function

    Public Shared Function XoaNhanVien(ByVal manhanvien As String) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("Delete From NHANVIEN where MaNhanVien = '" & manhanvien & "'", cn)
        cmd.CommandType = CommandType.Text
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function

    Public Shared Function SuaNhanVien(ByVal NVDTO As NhanVienDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
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

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function
End Class
