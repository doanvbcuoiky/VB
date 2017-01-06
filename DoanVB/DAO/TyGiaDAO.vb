Imports System.Data.SqlClient
Imports DTO

Public Class TyGiaDAO
    Public Function LoadDSTyGia() As DataTable
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim dt As DataTable
        Dim cmd As New SqlCommand("LoadDSTyGia", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Sub ThemTyGia(ByVal TGDTO As TyGiaDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("ThemTyGia", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaTienTe", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenTienTe", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TyGiaQuyDoi", SqlDbType.Money)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaTienTe").Value = TGDTO.MaTienTe1
        cmd.Parameters("@TenTienTe").Value = TGDTO.TenTienTe1
        cmd.Parameters("@TyGiaQuyDoi").Value = TGDTO.TyGiaQuyDoi1
        cmd.Parameters("@TinhTrang").Value = TGDTO.TinhTrang1

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub XoaTyGia(ByVal TGDTO As TyGiaDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("XoaTyGia", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaTienTe", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenTienTe", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TyGiaQuyDoi", SqlDbType.Money)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaTienTe").Value = TGDTO.MaTienTe1
        cmd.Parameters("@TenTienTe").Value = TGDTO.TenTienTe1
        cmd.Parameters("@TyGiaQuyDoi").Value = TGDTO.TyGiaQuyDoi1
        cmd.Parameters("@TinhTrang").Value = TGDTO.TinhTrang1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub SuaTyGia(ByVal TGDTO As TyGiaDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaTyGia", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaTienTe", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenTienTe", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TyGiaQuyDoi", SqlDbType.Money)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaTienTe").Value = TGDTO.MaTienTe1
        cmd.Parameters("@TenTienTe").Value = TGDTO.TenTienTe1
        cmd.Parameters("@TyGiaQuyDoi").Value = TGDTO.TyGiaQuyDoi1
        cmd.Parameters("@TinhTrang").Value = TGDTO.TinhTrang1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
