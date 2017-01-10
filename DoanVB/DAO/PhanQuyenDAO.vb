Imports System.Data.SqlClient
Imports DTO

Public Class PhanQuyenDAO
    Public Shared Function LoadDSPhanQuyen(ByVal MaNguoiDung As String) As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("LoadDSPhanQuyen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaNguoiDung", SqlDbType.VarChar)
        cmd.Parameters("@MaNguoiDung").Value = MaNguoiDung
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function ThemPhanQuyen(ByVal PQDTO As PhanQuyenDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
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

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function

    Public Shared Function XoaPhanQuyen(ByVal PQDTO As PhanQuyenDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
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

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function

    Public Shared Function SuaPhanQuyen(ByVal PQDTO As PhanQuyenDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
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

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function
End Class
