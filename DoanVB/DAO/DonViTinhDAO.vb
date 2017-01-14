Imports System.Data.SqlClient
Imports DTO

Public Class DonViTinhDAO
    Public Shared Function ThongTinDonVi(ByVal madonvi As String) As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("Select * from DONVITINH where MadonVi = '" & madonvi & "'", cn)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
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
    Public Shared Function ThemDonViTinh(ByVal DVTDTO As DonViTinhDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
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

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function

    Public Shared Function XoaDonViTinh(ByVal madonvi As String) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("Delete From DONVITINH where MaDonVi = '" & madonvi & "'", cn)
        cmd.CommandType = CommandType.Text
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function

    Public Shared Function SuaDonViTinh(ByVal DVTDTO As DonViTinhDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
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

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function
End Class
