Imports System.Data.SqlClient
Imports DTO

Public Class NhaCungCapDAO

    Public Shared Function ThongTinNhaCungCap(ByVal ma As String) As NhaCungCapDTO
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("Select * from NHACUNGCAP where MaNhacCungCap = '" & ma & "'", cn)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Dim nhacungcap As New NhaCungCapDTO(dt.Select()(0).Item(columnName:="MaNhaCungCap"), _
                                            dt.Select()(0).Item(columnName:="TenNhaCungCap"), _
                                            dt.Select()(0).Item(columnName:="DiaChi"), _
                                            dt.Select()(0).Item(columnName:="KhuVuc"), _
                                            dt.Select()(0).Item(columnName:="DienThoai"), _
                                            dt.Select()(0).Item(columnName:="Fax"), _
                                            dt.Select()(0).Item(columnName:="Email"), _
                                            dt.Select()(0).Item(columnName:="Website"), _
                                            dt.Select()(0).Item(columnName:="MaSoThue"), _
                                            dt.Select()(0).Item(columnName:="SoTaiKhoan"), _
                                            dt.Select()(0).Item(columnName:="NganHang"), _
                                            dt.Select()(0).Item(columnName:="NoHienTai"), _
                                            dt.Select()(0).Item(columnName:="TinhTrang"))
        Return nhacungcap
    End Function
    Public Shared Function LoadDSNhaCungCap() As DataTable
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("Select * from NHACUNGCAP", cn)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function
    Public Shared Function ThemNhaCungCap(ByVal NCCDTO As NhaCungCapDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()

        Dim cmd As New SqlCommand("ThemNhaCungCap", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaNhaCungCap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenNhaCungCap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KhuVuc", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Fax", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Email", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Website", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaSoThue", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoTaiKhoan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NganHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NoHienTai", SqlDbType.Float)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)


        cmd.Parameters("@MaNhaCungCap").Value = NCCDTO.MaNhaCungCap1
        cmd.Parameters("@TenNhaCungCap").Value = NCCDTO.TenNhaCungCap1
        cmd.Parameters("@DiaChi").Value = NCCDTO.DiaChi1
        cmd.Parameters("@KhuVuc").Value = NCCDTO.KhuVuc1
        cmd.Parameters("@DienThoai").Value = NCCDTO.DienTHoai1
        cmd.Parameters("@Fax").Value = NCCDTO.Fax1
        cmd.Parameters("@Email").Value = NCCDTO.Email1
        cmd.Parameters("@Website").Value = NCCDTO.Website1
        cmd.Parameters("@MaSoThue").Value = NCCDTO.MaSoThue1
        cmd.Parameters("@SoTaiKhoan").Value = NCCDTO.SoTaiKhoan1
        cmd.Parameters("@NganHang").Value = NCCDTO.NganHang1
        cmd.Parameters("@NoHienTai").Value = NCCDTO.NoHienTai1
        cmd.Parameters("@TinhTrang").Value = NCCDTO.TinhTrang1

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function

    Public Shared Function XoaNhaCungCap(ByVal manhacungcap As String) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("Delete From NHACUNGCAP where MaNhaCungCap = '" & manhacungcap & "'", cn)
        cmd.CommandType = CommandType.Text
        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        Else
            cn.Close()
            Return False
        End If
    End Function

    Public Shared Function SuaNhaCungCap(ByVal NCCDTO As NhaCungCapDTO) As Boolean
        Dim con As New Connect()
        Dim cn As New SqlConnection()
        cn = con.connect()
        Dim cmd As New SqlCommand("SuaNhaCungCap", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaNhaCungCap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@TenNhaCungCap", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar)
        cmd.Parameters.Add("@KhuVuc", SqlDbType.NVarChar)
        cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Fax", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Email", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Website", SqlDbType.NVarChar)
        cmd.Parameters.Add("@MaSoThue", SqlDbType.NVarChar)
        cmd.Parameters.Add("@SoTaiKhoan", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NganHang", SqlDbType.NVarChar)
        cmd.Parameters.Add("@NoHienTai", SqlDbType.Float)
        cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit)


        cmd.Parameters("@MaNhaCungCap").Value = NCCDTO.MaNhaCungCap1
        cmd.Parameters("@TenNhaCungCap").Value = NCCDTO.TenNhaCungCap1
        cmd.Parameters("@DiaChi").Value = NCCDTO.DiaChi1
        cmd.Parameters("@KhuVuc").Value = NCCDTO.KhuVuc1
        cmd.Parameters("@DienThoai").Value = NCCDTO.DienTHoai1
        cmd.Parameters("@Fax").Value = NCCDTO.Fax1
        cmd.Parameters("@Email").Value = NCCDTO.Email1
        cmd.Parameters("@Website").Value = NCCDTO.Website1
        cmd.Parameters("@MaSoThue").Value = NCCDTO.MaSoThue1
        cmd.Parameters("@SoTaiKhoan").Value = NCCDTO.SoTaiKhoan1
        cmd.Parameters("@NganHang").Value = NCCDTO.NganHang1
        cmd.Parameters("@NoHienTai").Value = NCCDTO.NoHienTai1
        cmd.Parameters("@TinhTrang").Value = NCCDTO.TinhTrang1

        If cmd.ExecuteNonQuery() > 0 Then
            cn.Close()
            Return True
        End If
        cn.Close()
        Return False
    End Function
End Class
