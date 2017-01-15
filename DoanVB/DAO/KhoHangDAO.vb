Imports System.Data.SqlClient
Imports DTO

Public Class KhoHangDAO
    Public Shared Function ThongTinKhoHang(ByVal ma As String)
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("Select * from KHOHANG where MaKhoHang = '" & ma & "'", cn)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function LoadDSKhoHang() As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("Select * from KHOHANG", cn)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function ThemKhoHang(ByVal KHDTO As KhoHangDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()

        Dim cmd As New SqlCommand("ThemKhoHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaKhoHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KiHieu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenKhoHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NguoiQuanLy", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NguoiLienHe", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Fax", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Email", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DienGiai", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)


        cmd.Parameters("@MaKhoHang").Value = KHDTO.MaKhoHang1
        cmd.Parameters("@KiHieu").Value = KHDTO.KiHieu1
        cmd.Parameters("@TenKhoHang").Value = KHDTO.TenKhoHang1
        cmd.Parameters("@NguoiQuanLy").Value = KHDTO.NguoiQuanLi1
        cmd.Parameters("@NguoiLienHe").Value = KHDTO.NguoiLienHe1
        cmd.Parameters("@DiaChi").Value = KHDTO.DiaChi1
        cmd.Parameters("@DienThoai").Value = KHDTO.DienThoai1
        cmd.Parameters("@Fax").Value = KHDTO.Fax1
        cmd.Parameters("@Email").Value = KHDTO.Email1
        cmd.Parameters("@DienGiai").Value = KHDTO.DienGiai1
        cmd.Parameters("@TinhTrang").Value = KHDTO.TinhTrang1

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function

    Public Shared Function XoaKhoHang(ByVal makhohang As String) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("Delete From KHOHANG where MaKhoHang = '" & makhohang & "'", cn)
        cmd.CommandType = CommandType.Text
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function

    Public Shared Function SuaKhoHang(ByVal KHDTO As KhoHangDTO)
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaKhoHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaKhoHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KiHieu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenKhoHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NguoiQuanLi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NguoiLienHe", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Fax", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Email", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DienGiai", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)


        cmd.Parameters("@MaKhoHang").Value = KHDTO.MaKhoHang1
        cmd.Parameters("@KiHieu").Value = KHDTO.KiHieu1
        cmd.Parameters("@TenKhoHang").Value = KHDTO.TenKhoHang1
        cmd.Parameters("@NguoiQuanLy").Value = KHDTO.NguoiQuanLi1
        cmd.Parameters("@NguoiLienHe").Value = KHDTO.NguoiLienHe1
        cmd.Parameters("@DiaChi").Value = KHDTO.DiaChi1
        cmd.Parameters("@DienThoai").Value = KHDTO.DienThoai1
        cmd.Parameters("@Fax").Value = KHDTO.Fax1
        cmd.Parameters("@Email").Value = KHDTO.Email1
        cmd.Parameters("@DienGiai").Value = KHDTO.DienGiai1
        cmd.Parameters("@TinhTrang").Value = KHDTO.TinhTrang1
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function
End Class
