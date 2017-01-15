Imports DAO
Imports DTO

Public Class HangHoaBUS

    Public Shared Sub CapNhatSoLuong_Tang(ByVal ma As String, ByVal sl As Integer)
        HangHoaDAO.CapNhatSoLuong_Tang(ma, sl)
    End Sub
    Public Shared Sub CapNhatSoLuong_Giam(ByVal ma As String, ByVal sl As Integer)
        HangHoaDAO.CapNhatSoLuong_Giam(ma, sl)
    End Sub
    Public Shared Function ThongTinHangHoa(ByVal mahang As String) As HangHoaDTO
        Dim dt As DataTable = HangHoaDAO.ThongTinHangHoa(mahang)
        If dt.Select().Count() > 0 Then
            Dim ck As Boolean = True
            If dt.Select()(0).Item(columnName:="TinhTrang").ToString() = "True" Then
                ck = True
            End If
            Dim hanghoa As New HangHoaDTO(dt.Select()(0).Item(columnName:="MaHangHoa").ToString(), _
                                          dt.Select()(0).Item(columnName:="TenHangHoa").ToString(), _
                                          dt.Select()(0).Item(columnName:="KieuHangHoa").ToString(), _
                                          dt.Select()(0).Item(columnName:="NhomHang").ToString(), _
                                          dt.Select()(0).Item(columnName:="MaVach").ToString(), _
                                          dt.Select()(0).Item(columnName:="DonVi").ToString(), _
                                          dt.Select()(0).Item(columnName:="XuatXu").ToString(), _
                                          System.Convert.ToInt32(dt.Select()(0).Item(columnName:="TonKhoToiThieu").ToString()), _
                                          System.Convert.ToInt32(dt.Select()(0).Item(columnName:="TonHienTai").ToString()), _
                                          dt.Select()(0).Item(columnName:="NhaCungCap").ToString(), _
                                          System.Convert.ToDouble(dt.Select()(0).Item(columnName:="GiaMua").ToString()), _
                                          System.Convert.ToDouble(dt.Select()(0).Item(columnName:="GiaBanLe").ToString()), _
                                          System.Convert.ToDouble(dt.Select()(0).Item(columnName:="GiaBanSi").ToString()), _
                                          dt.Select()(0).Item(columnName:="LoaiTien").ToString(), _
                                          dt.Select()(0).Item(columnName:="HinhAnh").ToString(), _
                                          ck)
            Return hanghoa
        Else
            Dim hanghoa2 As New HangHoaDTO()
            Return hanghoa2
        End If
    End Function
    Public Shared Function LoadDSHangHoa() As DataTable
        Dim dt As DataTable = HangHoaDAO.LoadDSHangHoa()
        Return dt
    End Function
    Public Shared Function ThemHangHoa(ByVal HHDTO As HangHoaDTO) As Boolean
        Return HangHoaDAO.ThemHangHoa(HHDTO)
    End Function
    Public Shared Function XoaHangHoa(ByVal mahanghoa As String) As Boolean
        Return HangHoaDAO.XoaHangHoa(mahanghoa)
    End Function
    Public Shared Function SuaHangHoa(ByVal HHDTO As HangHoaDTO) As Boolean
        Return HangHoaDAO.SuaHangHoa(HHDTO)
    End Function
End Class
