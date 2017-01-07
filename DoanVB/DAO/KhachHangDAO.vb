Imports System.Data.SqlClient
Imports DTO

Public Class KhachHangDAO
    Public Shared Function LoadDSKhachHang() As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("Select * from KHACHHANG", cn)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function ThemKhachHang(ByVal KHDTO As KhachHangDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("ThemKhachHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaKhachHang", SqlDbType.VarChar)
        cmd.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NguoiLienHe", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@LoaiKhachHang", SqlDbType.VarChar)
        cmd.Parameters.Add("@KhuVuc", SqlDbType.VarChar)
        cmd.Parameters.Add("@DienThoai", SqlDbType.VarChar)
        cmd.Parameters.Add("@Fax", SqlDbType.VarChar)
        cmd.Parameters.Add("@Email", SqlDbType.VarChar)
        cmd.Parameters.Add("@Website", SqlDbType.VarChar)
        cmd.Parameters.Add("@MaSoThue", SqlDbType.VarChar)
        cmd.Parameters.Add("@SoTaiKhoan", SqlDbType.VarChar)
        cmd.Parameters.Add("@NganHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)


        cmd.Parameters("@MaKhachHang").Value = KHDTO.MaKhachHang1
        cmd.Parameters("@TenKhachHang").Value = KHDTO.TenKhachHang1
        cmd.Parameters("@NguoiLienHe").Value = KHDTO.NguoiLienHe1
        cmd.Parameters("@DiaChi").Value = KHDTO.DiaChi1
        cmd.Parameters("@LoaiKhachHang").Value = KHDTO.LoaiKhachHang1
        cmd.Parameters("@KhuVuc").Value = KHDTO.KhuVuc1
        cmd.Parameters("@DienThoai").Value = KHDTO.DienThoai1
        cmd.Parameters("@Fax").Value = KHDTO.Fax1
        cmd.Parameters("@Email").Value = KHDTO.Email1
        cmd.Parameters("@Website").Value = KHDTO.Website1
        cmd.Parameters("@MaSoThue").Value = KHDTO.MaSoThue1
        cmd.Parameters("@SoTaiKhoan").Value = KHDTO.SoTaiKhoan1
        cmd.Parameters("@NganHang").Value = KHDTO.NganHang1
        cmd.Parameters("@TinhTrang").Value = KHDTO.TinhTrang1

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function

    Public Sub XoaKhachHang(ByVal KHDTO As KhachHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("XoaKhachHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NguoiLienHe", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@LoaiKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KhuVuc", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Fax", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Email", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Website", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaSoThue", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoTaiKhoan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NganHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)


        cmd.Parameters("@MaKhachHang").Value = KHDTO.MaKhachHang1
        cmd.Parameters("@TenKhachHang").Value = KHDTO.TenKhachHang1
        cmd.Parameters("@NguoiLienHe").Value = KHDTO.NguoiLienHe1
        cmd.Parameters("@DiaChi").Value = KHDTO.DiaChi1
        cmd.Parameters("@LoaiKhachHang").Value = KHDTO.LoaiKhachHang1
        cmd.Parameters("@KhuVuc").Value = KHDTO.KhuVuc1
        cmd.Parameters("@DienThoai").Value = KHDTO.DienThoai1
        cmd.Parameters("@Fax").Value = KHDTO.Fax1
        cmd.Parameters("@Email").Value = KHDTO.Email1
        cmd.Parameters("@Website").Value = KHDTO.Website1
        cmd.Parameters("@MaSoThue").Value = KHDTO.MaSoThue1
        cmd.Parameters("@SoTaiKhoan").Value = KHDTO.SoTaiKhoan1
        cmd.Parameters("@NganHang").Value = KHDTO.NganHang1
        cmd.Parameters("@TinhTrang").Value = KHDTO.TinhTrang1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub SuaKhachHang(ByVal KHDTO As KhachHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaKhachHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NguoiLienHe", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@LoaiKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KhuVuc", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Fax", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Email", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Website", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaSoThue", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoTaiKhoan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NganHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)


        cmd.Parameters("@MaKhachHang").Value = KHDTO.MaKhachHang1
        cmd.Parameters("@TenKhachHang").Value = KHDTO.TenKhachHang1
        cmd.Parameters("@NguoiLienHe").Value = KHDTO.NguoiLienHe1
        cmd.Parameters("@DiaChi").Value = KHDTO.DiaChi1
        cmd.Parameters("@LoaiKhachHang").Value = KHDTO.LoaiKhachHang1
        cmd.Parameters("@KhuVuc").Value = KHDTO.KhuVuc1
        cmd.Parameters("@DienThoai").Value = KHDTO.DienThoai1
        cmd.Parameters("@Fax").Value = KHDTO.Fax1
        cmd.Parameters("@Email").Value = KHDTO.Email1
        cmd.Parameters("@Website").Value = KHDTO.Website1
        cmd.Parameters("@MaSoThue").Value = KHDTO.MaSoThue1
        cmd.Parameters("@SoTaiKhoan").Value = KHDTO.SoTaiKhoan1
        cmd.Parameters("@NganHang").Value = KHDTO.NganHang1
        cmd.Parameters("@TinhTrang").Value = KHDTO.TinhTrang1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
