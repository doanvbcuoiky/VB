Imports System.Data.SqlClient
Imports DTO
Public Class ChiTietKhoDAO
    Public Shared Function LoadDSChiTietKho() As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("LoadDSChiTietKho", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function ThemChiTietKho(ByVal CTKDTO As ChiTietKhoDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()

        Dim cmd As New SqlCommand("ThemChiTietKho", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaKhoHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoLuong", SqlDbType.Int)

        cmd.Parameters("@MaKhoHang").Value = CTKDTO.MaKhoHang1
        cmd.Parameters("@MaHangHoa").Value = CTKDTO.MaHangHoa1
        cmd.Parameters("@SoLuong").Value = CTKDTO.SoLuong1

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function

    Public Shared Function XoaChiTietKho(ByVal makhohang As String) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("Delete From CHITIETKHO where MaKhoHang = '" & makhohang & "'", cn)
        cmd.CommandType = CommandType.Text
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function

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
