Imports System.Data.SqlClient
Imports DTO

Public Class ChiTietPhieuChuyenKhoDAO
    Public Function LoadDSChiTietPhieuChuyenKho() As DataTable
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim dt As DataTable
        Dim cmd As New SqlCommand("LoadDSChiTietPhieuChuyenKho", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Sub ThemChiTietPhieuChuyenKho(ByVal CTPCK As ChiTietPhieuChuyenKhoDTO)
        Dim con As Connect
        Dim cn As SqlConnection
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

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub XoaChiTietPhieuChuyenKho(ByVal CTPCK As ChiTietPhieuChuyenKhoDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("XoaChiTietPhieuChuyenKho", cn)
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
