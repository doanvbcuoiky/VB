﻿Imports System.Data.SqlClient
Imports DTO

Public Class KhoHangDAO
    Public Function LoadDSKhoHang() As DataTable
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim dt As DataTable
        Dim cmd As New SqlCommand("LoadDSKhoHang", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Sub ThemKhoHang(ByVal KHDTO As KhoHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
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


        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub XoaKhoHang(ByVal KHDTO As KhoHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("XoaKhoHang", cn)
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
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub SuaKhoHang(ByVal KHDTO As KhoHangDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaKhoHang", cn)
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
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
