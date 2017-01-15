Imports System.Data.SqlClient
Imports DTO

Public Class PhieuChuyenKhoDAO
    Public Shared Function LoadDSPhieuChuyenKho() As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("LoadDSPhieuChuyenKho", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function ThemPhieuChuyenKho(ByVal PCKDTO As PhieuChuyenKhoDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()

        Dim cmd As New SqlCommand("ThemPhieuChuyenKho", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaPhieuChuyen", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NgayChuyen", SqlDbType.DateTime)
        cmd.Parameters.Add("@KhoXuat", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KhoNhap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NguoiChuyen", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NguoiNhan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TongTien", SqlDbType.Money)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaPhieuChuyen").Value = PCKDTO.MaPhieuChuyen1
        cmd.Parameters("@NgayChuyen").Value = PCKDTO.NgayChuyen1
        cmd.Parameters("@KhoXuat").Value = PCKDTO.KhoXuat1
        cmd.Parameters("@KhoNhap").Value = PCKDTO.KhoNhap1
        cmd.Parameters("@NguoiChuyen").Value = PCKDTO.NguoiChuyen1
        cmd.Parameters("@NguoiNhan").Value = PCKDTO.NguoiNhan1
        cmd.Parameters("@GhiChu").Value = PCKDTO.GhiChu1
        cmd.Parameters("@TongTien").Value = PCKDTO.TongTien1
        cmd.Parameters("@TinhTrang").Value = PCKDTO.TinhTrang1

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function

    Public Shared Function XoaPhieuChuyenKho(ByVal maphieuchuyen As String) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("Delete From PHIEUCHUYENKHO where MaPhieuChuyen = '" & maphieuchuyen & "'", cn)
        cmd.CommandType = CommandType.Text
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function

    Public Shared Function SuaPhieuChuyenKho(ByVal PCKDTO As PhieuChuyenKhoDTO)
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaPhieuChuyenKho", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaPhieuChuyen", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NgayChuyen", SqlDbType.DateTime)
        cmd.Parameters.Add("@KhoXuat", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KhoNhap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NguoiChuyen", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NguoiNhan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TongTien", SqlDbType.Money)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaPhieuChuyen").Value = PCKDTO.MaPhieuChuyen1
        cmd.Parameters("@NgayChuyen").Value = PCKDTO.NgayChuyen1
        cmd.Parameters("@KhoXuat").Value = PCKDTO.KhoXuat1
        cmd.Parameters("@KhoNhap").Value = PCKDTO.KhoNhap1
        cmd.Parameters("@NguoiChuyen").Value = PCKDTO.NguoiChuyen1
        cmd.Parameters("@NguoiNhan").Value = PCKDTO.NguoiNhan1
        cmd.Parameters("@GhiChu").Value = PCKDTO.GhiChu1
        cmd.Parameters("@TongTien").Value = PCKDTO.TongTien1
        cmd.Parameters("@TinhTrang").Value = PCKDTO.TinhTrang1

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function
End Class
