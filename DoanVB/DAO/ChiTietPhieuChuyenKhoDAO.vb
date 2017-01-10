Imports System.Data.SqlClient
Imports DTO

Public Class ChiTietPhieuChuyenKhoDAO
    Public Shared Function LoadDSChiTietPhieuChuyenKho() As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("LoadDSChiTietPhieuChuyenKho", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function ThemChiTietPhieuChuyenKho(ByVal CTPCK As ChiTietPhieuChuyenKhoDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()

        Dim cmd As New SqlCommand("ThemChiTietPhieuChuyenKho", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaPhieuChuyen", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoLuong", SqlDbType.Int)
        cmd.Parameters.Add("@DonGia", SqlDbType.Money)

        cmd.Parameters("@MaPhieuChuyen").Value = CTPCK.MaPhieuChuyen1
        cmd.Parameters("@MaHangHoa").Value = CTPCK.MaHangHoa1
        cmd.Parameters("@DonVi").Value = CTPCK.DonVi1
        cmd.Parameters("@SoLuong").Value = CTPCK.SoLuong1
        cmd.Parameters("@DonGia").Value = CTPCK.DonGia1

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function

    Public Shared Function XoaChiTietPhieuChuyenKho(ByVal maphieuchuyen As String) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("Delete From CHITIETPHIEUCHUYENKHO where MaPhieuChuyen = '" & maphieuchuyen & "'", cn)
        cmd.CommandType = CommandType.Text
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function

    Public Sub SuaChiTietPhieuChuyenKho(ByVal CTPCK As ChiTietPhieuChuyenKhoDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaChiTietPhieuChuyenKho", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaPhieuChuyen", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoLuong", SqlDbType.Int)
        cmd.Parameters.Add("@DonGia", SqlDbType.Money)

        cmd.Parameters("@MaPhieuChuyen").Value = CTPCK.MaPhieuChuyen1
        cmd.Parameters("@MaHangHoa").Value = CTPCK.MaHangHoa1
        cmd.Parameters("@DonVi").Value = CTPCK.DonVi1
        cmd.Parameters("@SoLuong").Value = CTPCK.SoLuong1
        cmd.Parameters("@DonGia").Value = CTPCK.DonGia1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
