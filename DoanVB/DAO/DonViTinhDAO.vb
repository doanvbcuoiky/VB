Imports System.Data.SqlClient
Imports DTO

Public Class DonViTinhDAO
    Public Shared Function LoadDSDonViTinh() As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("Select * from DONVITINH", cn)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Sub ThemDonViTinh(ByVal DVTDTO As DonViTinhDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("ThemDonViTinh", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaDonVi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenDonVi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaDonVi").Value = DVTDTO.MaDonVi1
        cmd.Parameters("@TenDonVi").Value = DVTDTO.TenDonVi1
        cmd.Parameters("@GhiChu").Value = DVTDTO.GhiChu1
        cmd.Parameters("@TinhTrang").Value = DVTDTO.TinhTrang1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub XoaDonViTinh(ByVal DVTDTO As DonViTinhDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("XoaDonViTinh", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaDonVi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenDonVi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaDonVi").Value = DVTDTO.MaDonVi1
        cmd.Parameters("@TenDonVi").Value = DVTDTO.TenDonVi1
        cmd.Parameters("@GhiChu").Value = DVTDTO.GhiChu1
        cmd.Parameters("@TinhTrang").Value = DVTDTO.TinhTrang1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub SuaDonViTinh(ByVal DVTDTO As DonViTinhDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaDonViTinh", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaDonVi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenDonVi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaDonVi").Value = DVTDTO.MaDonVi1
        cmd.Parameters("@TenDonVi").Value = DVTDTO.TenDonVi1
        cmd.Parameters("@GhiChu").Value = DVTDTO.GhiChu1
        cmd.Parameters("@TinhTrang").Value = DVTDTO.TinhTrang1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
