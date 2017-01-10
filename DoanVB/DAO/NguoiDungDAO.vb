Imports System.Data.SqlClient
Imports DTO

Public Class NguoiDungDAO

    Public Shared Sub CapNhatMatKhau(ByVal user As String, ByVal pass As String)
        Dim con As Connect = New Connect()
        Dim cn As SqlConnection
        cn = con.connect()
        Dim sqlQuerry As String = "Update NguoiDung set MatKhau = '" & pass & "' where MaNguoiDung = '" & user & "'"
        Dim cmd As New SqlCommand(sqlQuerry, cn)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
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
        'Try
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
        ' Catch ex As Exception
        '     Return ""
        ' End Try

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
    Public Shared Function ThemNguoiDung(ByVal NDDTO As NguoiDungDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
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

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function

    Public Shared Function XoaNguoiDung(ByVal manguoidung As String) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("Delete From NGUOIDUNG where MaNguoiDung = '" & manguoidung & "'", cn)
        cmd.CommandType = CommandType.Text
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function

    Public Shared Function SuaNguoiDung(ByVal NDDTO As NguoiDungDTO)
        Dim con As New Connect()
        Dim cn As New SqlConnection()
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
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function
End Class
