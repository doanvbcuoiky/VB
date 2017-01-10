Imports System.Data.SqlClient
Imports DTO

Public Class ChiTietPhieuBanHangDAO
    Public Shared Function LoadDSChiTietPhieuBanHang() As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("LoadDSChiTietPhieuBanHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function ThemChiTietPhieuBanHang(ByVal CTPBH As ChiTietPhieuBanHangDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
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

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function

    Public Shared Function XoaChiTietPhieuBanHang(ByVal maphieuban As String, ByVal mahanghoa As String) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("Delete From CHITIETPHIEUBANHANG where MaPhieuBan = '" & maphieuban & "'", cn)
        cmd.CommandType = CommandType.Text
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function

    Public Shared Function SuaChiTietPhieuBanHang(ByVal CTPBH As ChiTietPhieuBanHangDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
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

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function
End Class
