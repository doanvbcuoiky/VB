Imports System.Data.SqlClient
Imports DTO

Public Class PhieuNhapHangDAO
    Public Function LoadDSPhieuNhapHang() As DataTable
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim dt As DataTable
        Dim cmd As New SqlCommand("LoadDSPhieuNhapHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Sub ThemPhieuNhapHang(ByVal PNHDTO As PhieuNhapHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("ThemPhieuNhapHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaPhieuNhap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NgayNhap", SqlDbType.DateTime)
        cmd.Parameters.Add("@NhanVienNhap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KhoNhap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@HanThanhToan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NhaCungCap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@HinhThucThanhToan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TongTien", SqlDbType.Money)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaPhieuNhap").Value = PNHDTO.MaPhieuNhap1
        cmd.Parameters("@NgayNhap").Value = PNHDTO.NgayNhap1
        cmd.Parameters("@NhanVienNhap").Value = PNHDTO.NhanVienNhap1
        cmd.Parameters("@KhoNhap").Value = PNHDTO.KhoNhap1
        cmd.Parameters("@HanThanhToan").Value = PNHDTO.HanThanhToan1
        cmd.Parameters("@NhaCungCap").Value = PNHDTO.NhaCungCap1
        cmd.Parameters("@HinhThucThanhToan").Value = PNHDTO.HinhThucThanhToan1
        cmd.Parameters("@TongTien").Value = PNHDTO.TongTien1
        cmd.Parameters("@TinhTrang").Value = PNHDTO.TinhTrang1


        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub XoaPhieuNhapHang(ByVal PNHDTO As PhieuNhapHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("XoaPhieuNhapHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaPhieuNhap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NgayNhap", SqlDbType.DateTime)
        cmd.Parameters.Add("@NhanVienNhap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KhoNhap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@HanThanhToan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NhaCungCap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@HinhThucThanhToan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TongTien", SqlDbType.Money)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaPhieuNhap").Value = PNHDTO.MaPhieuNhap1
        cmd.Parameters("@NgayNhap").Value = PNHDTO.NgayNhap1
        cmd.Parameters("@NhanVienNhap").Value = PNHDTO.NhanVienNhap1
        cmd.Parameters("@KhoNhap").Value = PNHDTO.KhoNhap1
        cmd.Parameters("@HanThanhToan").Value = PNHDTO.HanThanhToan1
        cmd.Parameters("@NhaCungCap").Value = PNHDTO.NhaCungCap1
        cmd.Parameters("@HinhThucThanhToan").Value = PNHDTO.HinhThucThanhToan1
        cmd.Parameters("@TongTien").Value = PNHDTO.TongTien1
        cmd.Parameters("@TinhTrang").Value = PNHDTO.TinhTrang1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub SuaPhieuNhapHang(ByVal PNHDTO As PhieuNhapHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaPhieuNhapHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaPhieuNhap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NgayNhap", SqlDbType.DateTime)
        cmd.Parameters.Add("@NhanVienNhap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KhoNhap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@HanThanhToan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NhaCungCap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@HinhThucThanhToan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TongTien", SqlDbType.Money)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaPhieuNhap").Value = PNHDTO.MaPhieuNhap1
        cmd.Parameters("@NgayNhap").Value = PNHDTO.NgayNhap1
        cmd.Parameters("@NhanVienNhap").Value = PNHDTO.NhanVienNhap1
        cmd.Parameters("@KhoNhap").Value = PNHDTO.KhoNhap1
        cmd.Parameters("@HanThanhToan").Value = PNHDTO.HanThanhToan1
        cmd.Parameters("@NhaCungCap").Value = PNHDTO.NhaCungCap1
        cmd.Parameters("@HinhThucThanhToan").Value = PNHDTO.HinhThucThanhToan1
        cmd.Parameters("@TongTien").Value = PNHDTO.TongTien1
        cmd.Parameters("@TinhTrang").Value = PNHDTO.TinhTrang1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
