﻿Imports System.Data.SqlClient
Imports DTO

Public Class KhachHangDAO
    Public Function LoadDSKhachHang() As DataTable
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim dt As DataTable
        Dim cmd As New SqlCommand("LoadDSKhachHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Sub ThemKhachHang(ByVal KHDTO As KhachHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("ThemKhachHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NguoiLienHe", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@LoaiKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KhuVuc", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Fax", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Email", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Website", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaSoThue", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoTaiKhoan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NganHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)


        cmd.Parameters("@MaKhachHang").Value = KHDTO.MaKhachHang1
        cmd.Parameters("@TenKhachHang").Value = KHDTO.TenKhachHang1
        cmd.Parameters("@NguoiLienHe").Value = KHDTO.NguoiLienHe1
        cmd.Parameters("@DiaChi").Value = KHDTO.DiaChi1
        cmd.Parameters("@LoaiKhachHang").Value = KHDTO.LoaiKhachHang1
        cmd.Parameters("@KhuVuc").Value = KHDTO.KhuVuc1
        cmd.Parameters("@DienThoai").Value = KHDTO.DienThoai1
        cmd.Parameters("@Fax").Value = KHDTO.Fax1
        cmd.Parameters("@Email").Value = KHDTO.Email1
        cmd.Parameters("@Website").Value = KHDTO.Website1
        cmd.Parameters("@MaSoThue").Value = KHDTO.MaSoThue1
        cmd.Parameters("@SoTaiKhoan").Value = KHDTO.SoTaiKhoan1
        cmd.Parameters("@NganHang").Value = KHDTO.NganHang1
        cmd.Parameters("@TinhTrang").Value = KHDTO.TinhTrang1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub XoaKhachHang(ByVal KHDTO As KhachHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("XoaKhachHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NguoiLienHe", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@LoaiKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KhuVuc", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Fax", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Email", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Website", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaSoThue", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoTaiKhoan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NganHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)


        cmd.Parameters("@MaKhachHang").Value = KHDTO.MaKhachHang1
        cmd.Parameters("@TenKhachHang").Value = KHDTO.TenKhachHang1
        cmd.Parameters("@NguoiLienHe").Value = KHDTO.NguoiLienHe1
        cmd.Parameters("@DiaChi").Value = KHDTO.DiaChi1
        cmd.Parameters("@LoaiKhachHang").Value = KHDTO.LoaiKhachHang1
        cmd.Parameters("@KhuVuc").Value = KHDTO.KhuVuc1
        cmd.Parameters("@DienThoai").Value = KHDTO.DienThoai1
        cmd.Parameters("@Fax").Value = KHDTO.Fax1
        cmd.Parameters("@Email").Value = KHDTO.Email1
        cmd.Parameters("@Website").Value = KHDTO.Website1
        cmd.Parameters("@MaSoThue").Value = KHDTO.MaSoThue1
        cmd.Parameters("@SoTaiKhoan").Value = KHDTO.SoTaiKhoan1
        cmd.Parameters("@NganHang").Value = KHDTO.NganHang1
        cmd.Parameters("@TinhTrang").Value = KHDTO.TinhTrang1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub SuaKhachHang(ByVal KHDTO As KhachHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaKhachHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NguoiLienHe", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@LoaiKhachHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KhuVuc", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Fax", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Email", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Website", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaSoThue", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoTaiKhoan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NganHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)


        cmd.Parameters("@MaKhachHang").Value = KHDTO.MaKhachHang1
        cmd.Parameters("@TenKhachHang").Value = KHDTO.TenKhachHang1
        cmd.Parameters("@NguoiLienHe").Value = KHDTO.NguoiLienHe1
        cmd.Parameters("@DiaChi").Value = KHDTO.DiaChi1
        cmd.Parameters("@LoaiKhachHang").Value = KHDTO.LoaiKhachHang1
        cmd.Parameters("@KhuVuc").Value = KHDTO.KhuVuc1
        cmd.Parameters("@DienThoai").Value = KHDTO.DienThoai1
        cmd.Parameters("@Fax").Value = KHDTO.Fax1
        cmd.Parameters("@Email").Value = KHDTO.Email1
        cmd.Parameters("@Website").Value = KHDTO.Website1
        cmd.Parameters("@MaSoThue").Value = KHDTO.MaSoThue1
        cmd.Parameters("@SoTaiKhoan").Value = KHDTO.SoTaiKhoan1
        cmd.Parameters("@NganHang").Value = KHDTO.NganHang1
        cmd.Parameters("@TinhTrang").Value = KHDTO.TinhTrang1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
