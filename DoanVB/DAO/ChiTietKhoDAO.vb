Imports System.Data.SqlClient
Imports DTO
Public Class ChiTietKhoDAO
    Public Function LoadDSChiTietKho() As DataTable
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim dt As DataTable
        Dim cmd As New SqlCommand("LoadDSChiTietKho", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Sub ThemChiTietKho(ByVal CTKDTO As ChiTietKhoDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("ThemChiTietKho", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaKhoHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoLuong", SqlDbType.Int)

        cmd.Parameters("@MaKhoHang").Value = CTKDTO.MaKhoHang1
        cmd.Parameters("@MaHangHoa").Value = CTKDTO.MaHangHoa1
        cmd.Parameters("@SoLuong").Value = CTKDTO.SoLuong1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub XoaChiTietKho(ByVal CTKDTO As ChiTietKhoDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("XoaChiTietKho", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaKhoHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoLuong", SqlDbType.Int)

        cmd.Parameters("@MaKhoHang").Value = CTKDTO.MaKhoHang1
        cmd.Parameters("@MaHangHoa").Value = CTKDTO.MaHangHoa1
        cmd.Parameters("@SoLuong").Value = CTKDTO.SoLuong1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub SuaChiTietKho(ByVal CTKDTO As ChiTietKhoDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaChiTietKho", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaKhoHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoLuong", SqlDbType.Int)

        cmd.Parameters("@MaKhoHang").Value = CTKDTO.MaKhoHang1
        cmd.Parameters("@MaHangHoa").Value = CTKDTO.MaHangHoa1
        cmd.Parameters("@SoLuong").Value = CTKDTO.SoLuong1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
