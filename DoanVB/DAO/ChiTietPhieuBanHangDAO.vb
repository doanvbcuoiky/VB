Imports System.Data.SqlClient
Imports DTO

Public Class ChiTietPhieuBanHangDAO
    Public Function LoadDSChiTietPhieuBanHang() As DataTable
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim dt As DataTable
        Dim cmd As New SqlCommand("LoadDSChiTietPhieuBanHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Sub ThemChiTietPhieuBanHang(ByVal CTPBH As ChiTietPhieuBanHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("ThemChiTietPhieuBanHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaPhieuBan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoLuong", SqlDbType.Int)
        cmd.Parameters.Add("@DonGia", SqlDbType.Money)
        cmd.Parameters.Add("@ChieuKhau", SqlDbType.Float)

        cmd.Parameters("@MaPhieuBan").Value = CTPBH.MaPhieuBan1
        cmd.Parameters("@MaHangHoa").Value = CTPBH.MaHangHoa1
        cmd.Parameters("@DonVi").Value = CTPBH.DonVi1
        cmd.Parameters("@SoLuong").Value = CTPBH.SoLuong1
        cmd.Parameters("@DonGia").Value = CTPBH.DonGia1
        cmd.Parameters("@ChieuKhau").Value = CTPBH.ChietKhau1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub XoaChiTietPhieuBanHang(ByVal CTPBH As ChiTietPhieuBanHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("XoaChiTietPhieuBanHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaPhieuBan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoLuong", SqlDbType.Int)
        cmd.Parameters.Add("@DonGia", SqlDbType.Money)
        cmd.Parameters.Add("@ChieuKhau", SqlDbType.Float)

        cmd.Parameters("@MaPhieuBan").Value = CTPBH.MaPhieuBan1
        cmd.Parameters("@MaHangHoa").Value = CTPBH.MaHangHoa1
        cmd.Parameters("@DonVi").Value = CTPBH.DonVi1
        cmd.Parameters("@SoLuong").Value = CTPBH.SoLuong1
        cmd.Parameters("@DonGia").Value = CTPBH.DonGia1
        cmd.Parameters("@ChieuKhau").Value = CTPBH.ChietKhau1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub SuaChiTietPhieuBanHang(ByVal CTPBH As ChiTietPhieuBanHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaChiTietPhieuBanHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaPhieuBan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoLuong", SqlDbType.Int)
        cmd.Parameters.Add("@DonGia", SqlDbType.Money)
        cmd.Parameters.Add("@ChieuKhau", SqlDbType.Float)

        cmd.Parameters("@MaPhieuBan").Value = CTPBH.MaPhieuBan1
        cmd.Parameters("@MaHangHoa").Value = CTPBH.MaHangHoa1
        cmd.Parameters("@DonVi").Value = CTPBH.DonVi1
        cmd.Parameters("@SoLuong").Value = CTPBH.SoLuong1
        cmd.Parameters("@DonGia").Value = CTPBH.DonGia1
        cmd.Parameters("@ChieuKhau").Value = CTPBH.ChietKhau1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
