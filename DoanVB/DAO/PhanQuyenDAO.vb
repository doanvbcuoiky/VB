﻿Imports System.Data.SqlClient
Imports DTO

Public Class PhanQuyenDAO
    Public Function LoadDSPhanQuyen() As DataTable
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim dt As DataTable
        Dim cmd As New SqlCommand("LoadDSPhanQuyen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Sub ThemPhanQuyen(ByVal PQDTO As PhanQuyenDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("ThemPhanQuyen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@TenNhom", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenChucNang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaNguoiDung", SqlDbType.NVarChar)
        cmd.Parameters.Add("@ChoPhepThem", SqlDbType.Bit)
        cmd.Parameters.Add("@ChoPhepXoa", SqlDbType.Bit)
        cmd.Parameters.Add("@ChoPhepSua", SqlDbType.Bit)
        cmd.Parameters.Add("@ChoPhepTruyCap", SqlDbType.Bit)
        cmd.Parameters.Add("@ChoPhepIn", SqlDbType.Bit)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@TenNhom").Value = PQDTO.TenNhom1
        cmd.Parameters("@TenChucNang").Value = PQDTO.TenChucNang1
        cmd.Parameters("@MaNguoiDung").Value = PQDTO.MaNguoiDung1
        cmd.Parameters("@ChoPhepThem").Value = PQDTO.ChoPhepThem1
        cmd.Parameters("@ChoPhepXoa").Value = PQDTO.ChoPhepXoa1
        cmd.Parameters("@ChoPhepSua").Value = PQDTO.ChoPhepSua1
        cmd.Parameters("@ChoPhepTruyCap").Value = PQDTO.ChoPhepTruyCap1
        cmd.Parameters("@ChoPhepIn").Value = PQDTO.ChoPhepIn1
        cmd.Parameters("@TinhTrang").Value = PQDTO.TinhTrang1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub XoaPhanQuyen(ByVal PQDTO As PhanQuyenDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("XoaPhanQuyen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@TenNhom", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenChucNang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaNguoiDung", SqlDbType.NVarChar)
        cmd.Parameters.Add("@ChoPhepThem", SqlDbType.Bit)
        cmd.Parameters.Add("@ChoPhepXoa", SqlDbType.Bit)
        cmd.Parameters.Add("@ChoPhepSua", SqlDbType.Bit)
        cmd.Parameters.Add("@ChoPhepTruyCap", SqlDbType.Bit)
        cmd.Parameters.Add("@ChoPhepIn", SqlDbType.Bit)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@TenNhom").Value = PQDTO.TenNhom1
        cmd.Parameters("@TenChucNang").Value = PQDTO.TenChucNang1
        cmd.Parameters("@MaNguoiDung").Value = PQDTO.MaNguoiDung1
        cmd.Parameters("@ChoPhepThem").Value = PQDTO.ChoPhepThem1
        cmd.Parameters("@ChoPhepXoa").Value = PQDTO.ChoPhepXoa1
        cmd.Parameters("@ChoPhepSua").Value = PQDTO.ChoPhepSua1
        cmd.Parameters("@ChoPhepTruyCap").Value = PQDTO.ChoPhepTruyCap1
        cmd.Parameters("@ChoPhepIn").Value = PQDTO.ChoPhepIn1
        cmd.Parameters("@TinhTrang").Value = PQDTO.TinhTrang1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub SuaPhanQuyen(ByVal PQDTO As PhanQuyenDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaPhanQuyen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@TenNhom", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenChucNang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaNguoiDung", SqlDbType.NVarChar)
        cmd.Parameters.Add("@ChoPhepThem", SqlDbType.Bit)
        cmd.Parameters.Add("@ChoPhepXoa", SqlDbType.Bit)
        cmd.Parameters.Add("@ChoPhepSua", SqlDbType.Bit)
        cmd.Parameters.Add("@ChoPhepTruyCap", SqlDbType.Bit)
        cmd.Parameters.Add("@ChoPhepIn", SqlDbType.Bit)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@TenNhom").Value = PQDTO.TenNhom1
        cmd.Parameters("@TenChucNang").Value = PQDTO.TenChucNang1
        cmd.Parameters("@MaNguoiDung").Value = PQDTO.MaNguoiDung1
        cmd.Parameters("@ChoPhepThem").Value = PQDTO.ChoPhepThem1
        cmd.Parameters("@ChoPhepXoa").Value = PQDTO.ChoPhepXoa1
        cmd.Parameters("@ChoPhepSua").Value = PQDTO.ChoPhepSua1
        cmd.Parameters("@ChoPhepTruyCap").Value = PQDTO.ChoPhepTruyCap1
        cmd.Parameters("@ChoPhepIn").Value = PQDTO.ChoPhepIn1
        cmd.Parameters("@TinhTrang").Value = PQDTO.TinhTrang1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
