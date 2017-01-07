Imports System.Data.SqlClient
Imports DTO

Public Class NhaCungCapDAO
    Public Shared Function LoadDSNhaCungCap() As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("Select * from NHACUNGCAP", cn)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Sub ThemNhaCungCap(ByVal NCCDTO As NhaCungCapDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("ThemNhaCungCap", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaNhaCungCap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenNhaCungCap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KhuVuc", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Fax", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Email", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Website", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaSoThue", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoTaiKhoan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NganHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NoHienTai", SqlDbType.Float)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)


        cmd.Parameters("@MaNhaCungCap").Value = NCCDTO.MaNhaCungCap1
        cmd.Parameters("@TenNhaCungCap").Value = NCCDTO.TenNhaCungCap1
        cmd.Parameters("@DiaChi").Value = NCCDTO.DiaChi1
        cmd.Parameters("@KhuVuc").Value = NCCDTO.KhuVuc1
        cmd.Parameters("@DienThoai").Value = NCCDTO.DienTHoai1
        cmd.Parameters("@Fax").Value = NCCDTO.Fax1
        cmd.Parameters("@Email").Value = NCCDTO.Email1
        cmd.Parameters("@Website").Value = NCCDTO.Website1
        cmd.Parameters("@MaSoThue").Value = NCCDTO.MaSoThue1
        cmd.Parameters("@SoTaiKhoan").Value = NCCDTO.SoTaiKhoan1
        cmd.Parameters("@NganHang").Value = NCCDTO.NganHang1
        cmd.Parameters("@NoHienTai").Value = NCCDTO.NoHienTai1
        cmd.Parameters("@TinhTrang").Value = NCCDTO.TinhTrang1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub XoaNhaCungCap(ByVal NCCDTO As NhaCungCapDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("XoaNhaCungCap", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaNhaCungCap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenNhaCungCap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KhuVuc", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Fax", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Email", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Website", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaSoThue", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoTaiKhoan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NganHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NoHienTai", SqlDbType.Float)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)


        cmd.Parameters("@MaNhaCungCap").Value = NCCDTO.MaNhaCungCap1
        cmd.Parameters("@TenNhaCungCap").Value = NCCDTO.TenNhaCungCap1
        cmd.Parameters("@DiaChi").Value = NCCDTO.DiaChi1
        cmd.Parameters("@KhuVuc").Value = NCCDTO.KhuVuc1
        cmd.Parameters("@DienThoai").Value = NCCDTO.DienTHoai1
        cmd.Parameters("@Fax").Value = NCCDTO.Fax1
        cmd.Parameters("@Email").Value = NCCDTO.Email1
        cmd.Parameters("@Website").Value = NCCDTO.Website1
        cmd.Parameters("@MaSoThue").Value = NCCDTO.MaSoThue1
        cmd.Parameters("@SoTaiKhoan").Value = NCCDTO.SoTaiKhoan1
        cmd.Parameters("@NganHang").Value = NCCDTO.NganHang1
        cmd.Parameters("@NoHienTai").Value = NCCDTO.NoHienTai1
        cmd.Parameters("@TinhTrang").Value = NCCDTO.TinhTrang1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub SuaNhaCungCap(ByVal NCCDTO As NhaCungCapDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaNhaCungCap", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaNhaCungCap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenNhaCungCap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KhuVuc", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Fax", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Email", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Website", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaSoThue", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoTaiKhoan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NganHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NoHienTai", SqlDbType.Float)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)


        cmd.Parameters("@MaNhaCungCap").Value = NCCDTO.MaNhaCungCap1
        cmd.Parameters("@TenNhaCungCap").Value = NCCDTO.TenNhaCungCap1
        cmd.Parameters("@DiaChi").Value = NCCDTO.DiaChi1
        cmd.Parameters("@KhuVuc").Value = NCCDTO.KhuVuc1
        cmd.Parameters("@DienThoai").Value = NCCDTO.DienTHoai1
        cmd.Parameters("@Fax").Value = NCCDTO.Fax1
        cmd.Parameters("@Email").Value = NCCDTO.Email1
        cmd.Parameters("@Website").Value = NCCDTO.Website1
        cmd.Parameters("@MaSoThue").Value = NCCDTO.MaSoThue1
        cmd.Parameters("@SoTaiKhoan").Value = NCCDTO.SoTaiKhoan1
        cmd.Parameters("@NganHang").Value = NCCDTO.NganHang1
        cmd.Parameters("@NoHienTai").Value = NCCDTO.NoHienTai1
        cmd.Parameters("@TinhTrang").Value = NCCDTO.TinhTrang1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
