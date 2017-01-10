Imports System.Data.SqlClient
Imports DTO

Public Class PhieuBanHangDAO
    Public Shared Function LoadDSPhieuBanHang() As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("LoadDSPhieuBanHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function ThemPhieuBanHang(ByVal PBHDTO As PhieuBanHangDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()

        Dim cmd As New SqlCommand("ThemPhieuBanHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaPhieuBan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NgayBan", SqlDbType.DateTime)
        cmd.Parameters.Add("@NhanVienBan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KhoXuat", SqlDbType.NVarChar)
        cmd.Parameters.Add("@HinhThucThanhToan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TongTien", SqlDbType.Money)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaPhieuBan").Value = PBHDTO.MaPhieuBan1
        cmd.Parameters("@MaKhachHang").Value = PBHDTO.MaKhachHang1
        cmd.Parameters("@NgayBan").Value = PBHDTO.NgayBan1
        cmd.Parameters("@NhanVienBan").Value = PBHDTO.NhanVienBan1
        cmd.Parameters("@KhoXuat").Value = PBHDTO.KhoXuat1
        cmd.Parameters("@HinhThucThanhToan").Value = PBHDTO.HinhThucThanhToan1
        cmd.Parameters("@TongTien").Value = PBHDTO.TongTien1
        cmd.Parameters("@TinhTrang").Value = PBHDTO.TinhTrang1

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function

    Public Shared Function XoaPhieuBanHang(ByVal maphieuban As String) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("Delete From PHIEUBANHANG where MaPhieuBan = '" & maphieuban & "'", cn)
        cmd.CommandType = CommandType.Text
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function

    Public Sub SuaPhieuBanHang(ByVal PBHDTO As PhieuBanHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaPhieuBanHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaPhieuBan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NgayBan", SqlDbType.DateTime)
        cmd.Parameters.Add("@NhanVienBan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KhoXuat", SqlDbType.NVarChar)
        cmd.Parameters.Add("@HinhThucThanhToan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TongTien", SqlDbType.Money)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaPhieuBan").Value = PBHDTO.MaPhieuBan1
        cmd.Parameters("@MaKhachHang").Value = PBHDTO.MaKhachHang1
        cmd.Parameters("@NgayBan").Value = PBHDTO.NgayBan1
        cmd.Parameters("@NhanVienBan").Value = PBHDTO.NhanVienBan1
        cmd.Parameters("@KhoXuat").Value = PBHDTO.KhoXuat1
        cmd.Parameters("@HinhThucThanhToan").Value = PBHDTO.HinhThucThanhToan1
        cmd.Parameters("@TongTien").Value = PBHDTO.TongTien1
        cmd.Parameters("@TinhTrang").Value = PBHDTO.TinhTrang1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
