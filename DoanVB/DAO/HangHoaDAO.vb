﻿Imports System.Data.SqlClient
Imports DTO

Public Class HangHoaDAO
    Public Function LoadDSHangHoa() As DataTable
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim dt As DataTable
        Dim cmd As New SqlCommand("LoadDSHangHoa", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Sub ThemHangHoa(ByVal HHDTO As HangHoaDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("ThemHangHoa", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KieuHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NhomHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaVach", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@XuatXu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TonKhoToiThieu", SqlDbType.Int)
        cmd.Parameters.Add("@TonHienTai", SqlDbType.Int)
        cmd.Parameters.Add("@NhaCungCap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@GiaMua", SqlDbType.Money)
        cmd.Parameters.Add("@GiaBanLe", SqlDbType.Money)
        cmd.Parameters.Add("@GiaBanSi", SqlDbType.Money)
        cmd.Parameters.Add("@LoaiTien", SqlDbType.NVarChar)
        cmd.Parameters.Add("@HinhAnh", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)


        cmd.Parameters("@MaHangHoa").Value = HHDTO.MaHangHoa1
        cmd.Parameters("@TenHangHoa").Value = HHDTO.TenHangHoa1
        cmd.Parameters("@KieuHangHoa").Value = HHDTO.KieuHangHoa1
        cmd.Parameters("@NhomHang").Value = HHDTO.NhomHang1
        cmd.Parameters("@MaVach").Value = HHDTO.MaVach1
        cmd.Parameters("@DonVi").Value = HHDTO.DonVi1
        cmd.Parameters("@XuatXu").Value = HHDTO.XuatXu1
        cmd.Parameters("@TonKhoToiThieu").Value = HHDTO.TonKhoToiThieu1
        cmd.Parameters("@TonHienTai").Value = HHDTO.TonHienTai1
        cmd.Parameters("@NhaCungCap").Value = HHDTO.NhaCungCap1
        cmd.Parameters("@GiaMua").Value = HHDTO.GiaMua1
        cmd.Parameters("@GiaBanLe").Value = HHDTO.GiaBanLe1
        cmd.Parameters("@GiaBanSi").Value = HHDTO.GiaBanSi1
        cmd.Parameters("@LoaiTien").Value = HHDTO.LoaiTien1
        cmd.Parameters("@HinhAnh").Value = HHDTO.HinhAnh1
        cmd.Parameters("@TinhTrang").Value = HHDTO.TinhTrang1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub XoaHangHoa(ByVal HHDTO As HangHoaDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("XoaHangHoa", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KieuHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NhomHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaVach", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@XuatXu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TonKhoToiThieu", SqlDbType.Int)
        cmd.Parameters.Add("@TonHienTai", SqlDbType.Int)
        cmd.Parameters.Add("@NhaCungCap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@GiaMua", SqlDbType.Money)
        cmd.Parameters.Add("@GiaBanLe", SqlDbType.Money)
        cmd.Parameters.Add("@GiaBanSi", SqlDbType.Money)
        cmd.Parameters.Add("@LoaiTien", SqlDbType.NVarChar)
        cmd.Parameters.Add("@HinhAnh", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)


        cmd.Parameters("@MaHangHoa").Value = HHDTO.MaHangHoa1
        cmd.Parameters("@TenHangHoa").Value = HHDTO.TenHangHoa1
        cmd.Parameters("@KieuHangHoa").Value = HHDTO.KieuHangHoa1
        cmd.Parameters("@NhomHang").Value = HHDTO.NhomHang1
        cmd.Parameters("@MaVach").Value = HHDTO.MaVach1
        cmd.Parameters("@DonVi").Value = HHDTO.DonVi1
        cmd.Parameters("@XuatXu").Value = HHDTO.XuatXu1
        cmd.Parameters("@TonKhoToiThieu").Value = HHDTO.TonKhoToiThieu1
        cmd.Parameters("@TonHienTai").Value = HHDTO.TonHienTai1
        cmd.Parameters("@NhaCungCap").Value = HHDTO.NhaCungCap1
        cmd.Parameters("@GiaMua").Value = HHDTO.GiaMua1
        cmd.Parameters("@GiaBanLe").Value = HHDTO.GiaBanLe1
        cmd.Parameters("@GiaBanSi").Value = HHDTO.GiaBanSi1
        cmd.Parameters("@LoaiTien").Value = HHDTO.LoaiTien1
        cmd.Parameters("@HinhAnh").Value = HHDTO.HinhAnh1
        cmd.Parameters("@TinhTrang").Value = HHDTO.TinhTrang1


        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub SuaHangHoa(ByVal HHDTO As HangHoaDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaHangHoa", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KieuHangHoa", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NhomHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaVach", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@XuatXu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TonKhoToiThieu", SqlDbType.Int)
        cmd.Parameters.Add("@TonHienTai", SqlDbType.Int)
        cmd.Parameters.Add("@NhaCungCap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@GiaMua", SqlDbType.Money)
        cmd.Parameters.Add("@GiaBanLe", SqlDbType.Money)
        cmd.Parameters.Add("@GiaBanSi", SqlDbType.Money)
        cmd.Parameters.Add("@LoaiTien", SqlDbType.NVarChar)
        cmd.Parameters.Add("@HinhAnh", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)


        cmd.Parameters("@MaHangHoa").Value = HHDTO.MaHangHoa1
        cmd.Parameters("@TenHangHoa").Value = HHDTO.TenHangHoa1
        cmd.Parameters("@KieuHangHoa").Value = HHDTO.KieuHangHoa1
        cmd.Parameters("@NhomHang").Value = HHDTO.NhomHang1
        cmd.Parameters("@MaVach").Value = HHDTO.MaVach1
        cmd.Parameters("@DonVi").Value = HHDTO.DonVi1
        cmd.Parameters("@XuatXu").Value = HHDTO.XuatXu1
        cmd.Parameters("@TonKhoToiThieu").Value = HHDTO.TonKhoToiThieu1
        cmd.Parameters("@TonHienTai").Value = HHDTO.TonHienTai1
        cmd.Parameters("@NhaCungCap").Value = HHDTO.NhaCungCap1
        cmd.Parameters("@GiaMua").Value = HHDTO.GiaMua1
        cmd.Parameters("@GiaBanLe").Value = HHDTO.GiaBanLe1
        cmd.Parameters("@GiaBanSi").Value = HHDTO.GiaBanSi1
        cmd.Parameters("@LoaiTien").Value = HHDTO.LoaiTien1
        cmd.Parameters("@HinhAnh").Value = HHDTO.HinhAnh1
        cmd.Parameters("@TinhTrang").Value = HHDTO.TinhTrang1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
