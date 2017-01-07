Imports System.Data.SqlClient
Imports DTO

Public Class NguoiDungDAO

    Public Shared Sub LuuThongTinDangNhap(ByVal manguoidung As String)
        Dim con As Connect = New Connect()
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("LuuThongTinDangNhap", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@manguoidung", SqlDbType.VarChar)
        cmd.Parameters.Item("@manguoidung").Value = manguoidung.ToString()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
    Public Shared Function LoadDSNguoiDung() As DataTable
        Dim con As Connect = New Connect()
        Dim cn As SqlConnection
        cn = con.connect()
        Dim dt As DataTable = New DataTable()
        Dim cmd As New SqlCommand("LoadDSNguoiDung", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function LayMatKhau(ByVal manguoidung As String) As String
        Dim con As Connect = New Connect()
        Dim cn As SqlConnection = New SqlConnection()
        cn = con.connect()
        Dim dt As DataTable = New DataTable()

        Dim cmd As New SqlCommand("LayMatKhau", cn)
        cmd.Parameters.Add("@manguoidung", SqlDbType.VarChar)
        cmd.Parameters.Item("@manguoidung").Value = manguoidung
        cmd.CommandType = CommandType.StoredProcedure

        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Dim matkhau As String = ""
        If (dt.Select().Count() <> 0) Then
            matkhau = dt.Select()(0).Item(columnName:="MatKhau").ToString()
        End If
        cn.Close()
        Return matkhau
    End Function

    Public Shared Function KiemTraDangNhap(ByVal manguoidung As String, ByVal matkhau As String) As Boolean
        Dim con As Connect = New Connect()
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("KiemTraDangNhap", cn)
        cmd.Parameters.Add("@manguoidung", SqlDbType.VarChar)
        cmd.Parameters("@manguoidung").Value = manguoidung.ToString()
        cmd.Parameters.Add("@matkhau", SqlDbType.VarChar)
        cmd.Parameters("@matkhau").Value = matkhau
        cmd.Parameters.Add("@check", SqlDbType.Char)
        cmd.Parameters.Item("@check").Value = "N"
        cmd.Parameters("@check").Direction = ParameterDirection.Output
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()
        cn.Close()
        If cmd.Parameters("@check").Value.ToString() = "Y" Then
            Return True
        End If
        Return False
    End Function
    Public Sub ThemNguoiDung(ByVal NDDTO As NguoiDungDTO)
        Dim con As Connect = New Connect()
        Dim cn As SqlConnection = New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("ThemNguoiDung", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaNguoiDung", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MatKhau", SqlDbType.Bit)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)
        cmd.Parameters.Add("@NhoMatKhau", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaNhanVien", SqlDbType.NVarChar)

        cmd.Parameters("@MaNguoiDung").Value = NDDTO.MaNguoiDung1
        cmd.Parameters("@TenNguoiDung").Value = NDDTO.TenNguoiDung1
        cmd.Parameters("@MatKhau").Value = NDDTO.MatKhau1
        cmd.Parameters("@TinhTrang").Value = NDDTO.TinhTrang1
        cmd.Parameters("@NhoMatKhau").Value = NDDTO.NhoMatKhau1
        cmd.Parameters("@MaNhanVien").Value = NDDTO.MaNhanVien1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub XoaNguoiDung(ByVal NDDTO As NguoiDungDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("XoaNguoiDung", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaNguoiDung", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MatKhau", SqlDbType.Bit)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)
        cmd.Parameters.Add("@NhoMatKhau", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaNhanVien", SqlDbType.NVarChar)

        cmd.Parameters("@MaNguoiDung").Value = NDDTO.MaNguoiDung1
        cmd.Parameters("@TenNguoiDung").Value = NDDTO.TenNguoiDung1
        cmd.Parameters("@MatKhau").Value = NDDTO.MatKhau1
        cmd.Parameters("@TinhTrang").Value = NDDTO.TinhTrang1
        cmd.Parameters("@NhoMatKhau").Value = NDDTO.NhoMatKhau1
        cmd.Parameters("@MaNhanVien").Value = NDDTO.MaNhanVien1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub SuaNguoiDung(ByVal NDDTO As NguoiDungDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaNguoiDung", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaNguoiDung", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MatKhau", SqlDbType.Bit)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)
        cmd.Parameters.Add("@NhoMatKhau", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaNhanVien", SqlDbType.NVarChar)

        cmd.Parameters("@MaNguoiDung").Value = NDDTO.MaNguoiDung1
        cmd.Parameters("@TenNguoiDung").Value = NDDTO.TenNguoiDung1
        cmd.Parameters("@MatKhau").Value = NDDTO.MatKhau1
        cmd.Parameters("@TinhTrang").Value = NDDTO.TinhTrang1
        cmd.Parameters("@NhoMatKhau").Value = NDDTO.NhoMatKhau1
        cmd.Parameters("@MaNhanVien").Value = NDDTO.MaNhanVien1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
