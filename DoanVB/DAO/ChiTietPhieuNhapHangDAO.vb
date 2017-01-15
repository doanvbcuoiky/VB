Imports System.Data.SqlClient
Imports DTO

Public Class ChiTietPhieuNhapHangDAO
    Public Shared Function LoadDSChiTietPhieuNhapHang() As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("LoadDSChiTietPhieuNhapHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function ThemChiTietPhieuNhapHang(ByVal CTPNK As ChiTietPhieuNhapHangDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
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
        cmd.Parameters("@DonGia").Value = CTPNK.DonGia1.ToString()
        cmd.Parameters("@ChietKhau").Value = CTPNK.ChietKhau1

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function

    Public Shared Function XoaChiTietPhieuNhapHang(ByVal maphieunhap As String, ByVal mahanghoa As String) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("Delete From CHITIETPHIEUNHAPHANG where MaPhieuNhap = '" & maphieunhap & "'", cn)
        cmd.CommandType = CommandType.Text
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function

    Public Shared Function SuaChiTietPhieuNhapHang(ByVal CTPNK As ChiTietPhieuNhapHangDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
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
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function
End Class
