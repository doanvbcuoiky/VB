Imports System.Data.SqlClient
Imports DTO

Public Class ChiTietPhieuNhapHangDAO
    Public Function LoadDSChiTietPhieuNhapHang() As DataTable
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim dt As DataTable
        Dim cmd As New SqlCommand("LoadDSChiTietPhieuNhapHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Sub ThemChiTietPhieuNhapHang(ByVal CTPNK As ChiTietPhieuNhapHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("ThemChiTietPhieuNhapHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaPhieuNhap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoLuong", SqlDbType.Int)
        cmd.Parameters.Add("@DonGia", SqlDbType.Money)
        cmd.Parameters.Add("@ChietKhau", SqlDbType.Float)

        cmd.Parameters("@MaPhieuNhap").Value = CTPNK.MaPhieuNhap1
        cmd.Parameters("@MaHangHoa").Value = CTPNK.MaHangHoa1
        cmd.Parameters("@DonVi").Value = CTPNK.DonVi1
        cmd.Parameters("@SoLuong").Value = CTPNK.SoLuong1
        cmd.Parameters("@DonGia").Value = CTPNK.DonGia1
        cmd.Parameters("@ChietKhau").Value = CTPNK.ChietKhau1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub XoaChiTietPhieuNhapHang(ByVal CTPNK As ChiTietPhieuNhapHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("XoaChiTietPhieuNhapHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaPhieuNhap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoLuong", SqlDbType.Int)
        cmd.Parameters.Add("@DonGia", SqlDbType.Money)
        cmd.Parameters.Add("@ChietKhau", SqlDbType.Float)

        cmd.Parameters("@MaPhieuNhap").Value = CTPNK.MaPhieuNhap1
        cmd.Parameters("@MaHangHoa").Value = CTPNK.MaHangHoa1
        cmd.Parameters("@DonVi").Value = CTPNK.DonVi1
        cmd.Parameters("@SoLuong").Value = CTPNK.SoLuong1
        cmd.Parameters("@DonGia").Value = CTPNK.DonGia1
        cmd.Parameters("@ChietKhau").Value = CTPNK.ChietKhau1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub SuaChiTietPhieuNhapHang(ByVal CTPNK As ChiTietPhieuNhapHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaChiTietPhieuNhapHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaPhieuNhap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoLuong", SqlDbType.Int)
        cmd.Parameters.Add("@DonGia", SqlDbType.Money)
        cmd.Parameters.Add("@ChietKhau", SqlDbType.Float)

        cmd.Parameters("@MaPhieuNhap").Value = CTPNK.MaPhieuNhap1
        cmd.Parameters("@MaHangHoa").Value = CTPNK.MaHangHoa1
        cmd.Parameters("@DonVi").Value = CTPNK.DonVi1
        cmd.Parameters("@SoLuong").Value = CTPNK.SoLuong1
        cmd.Parameters("@DonGia").Value = CTPNK.DonGia1
        cmd.Parameters("@ChietKhau").Value = CTPNK.ChietKhau1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
