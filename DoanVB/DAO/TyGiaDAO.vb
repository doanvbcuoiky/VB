Imports System.Data.SqlClient
Imports DTO

Public Class TyGiaDAO
    Public Shared Function LoadDSTyGia() As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("LoadDSTyGia", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function ThemTyGia(ByVal TGDTO As TyGiaDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
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

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function

    Public Shared Function XoaTyGia(ByVal matygia As String) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("Delete From TYGIA where MaTienTe = '" & matygia & "'", cn)
        cmd.CommandType = CommandType.Text
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function

    Public Sub SuaTyGia(ByVal TGDTO As TyGiaDTO)
        Dim con As New Connect()
        Dim cn As New SqlConnection()
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
