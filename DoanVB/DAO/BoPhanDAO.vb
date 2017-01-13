Imports System.Data.SqlClient
Imports DTO

Public Class BoPhanDAO
    Public Shared Function LoadDSBoPhan() As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("Select * from BOPHAN", cn)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function ThemBoPhan(ByVal BPDTO As BoPhanDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()

        Dim cmd As New SqlCommand("ThemBoPhan", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaBoPhan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenBoPhan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaBoPhan").Value = BPDTO.MaBoPhan1
        cmd.Parameters("@TenBoPhan").Value = BPDTO.TenBoPhan1
        cmd.Parameters("@GhiChu").Value = BPDTO.GhiChu1
        cmd.Parameters("@TinhTrang").Value = BPDTO.TinhTrang1

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function

    Public Shared Function XoaBoPhan(ByVal mabophan As String) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("Delete From BOPHAN where MaBoPhan = '" & mabophan & "'", cn)
        cmd.CommandType = CommandType.Text
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function

    Public Shared Function SuaBoPhan(ByVal BPDTO As BoPhanDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaBoPhan", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaBoPhan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenBoPhan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaBoPhan").Value = BPDTO.MaBoPhan1
        cmd.Parameters("@TenBoPhan").Value = BPDTO.TenBoPhan1
        cmd.Parameters("@GhiChu").Value = BPDTO.GhiChu1
        cmd.Parameters("@TinhTrang").Value = BPDTO.TinhTrang1

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function
End Class
