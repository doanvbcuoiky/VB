Imports System.Data.SqlClient
Imports DTO

Public Class BoPhanDAO
    Public Function LoadDSBoPhan() As DataTable
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim dt As DataTable
        Dim cmd As New SqlCommand("LoadDSBoPhan", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Sub ThemBoPhan(ByVal BPDTO As BoPhanDTO)
        Dim con As Connect
        Dim cn As SqlConnection
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

        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub XoaBoPhan(ByVal BPDTO As BoPhanDTO)
        Dim con As Connect
        Dim cn As SqlConnection
        cn = con.connect()
        Dim cmd As New SqlCommand("XoaBoPhan", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaBoPhan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenBoPhan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)

        cmd.Parameters("@MaBoPhan").Value = BPDTO.MaBoPhan1
        cmd.Parameters("@TenBoPhan").Value = BPDTO.TenBoPhan1
        cmd.Parameters("@GhiChu").Value = BPDTO.GhiChu1
        cmd.Parameters("@TinhTrang").Value = BPDTO.TinhTrang1
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub SuaBoPhan(ByVal BPDTO As BoPhanDTO)
        Dim con As Connect
        Dim cn As SqlConnection
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
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
