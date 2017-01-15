Imports DAO
Imports DTO

Public Class NhaCungCapBUS
    Public Shared Function ThongTinNhaCungCap(ByVal MaNCC As String) As NhaCungCapDTO
        Dim dt As DataTable = NhaCungCapDAO.ThongTinNhaCungCap(MaNCC)
        Dim ck As Boolean = True
        If dt.Select()(0).Item(columnName:="TinhTrang").ToString = "False" Then
            ck = False
        End If
        Dim no As Double = 0
        If dt.Select()(0).Item(columnName:="NoHienTai").ToString() <> "" Then
            no = System.Convert.ToDouble(dt.Select()(0).Item(columnName:="NoHienTai").ToString())
        End If
        Dim nhacungcap As New NhaCungCapDTO(dt.Select()(0).Item(columnName:="MaNhaCungCap").ToString(), _
                                            dt.Select()(0).Item(columnName:="TenNhaCungCap").ToString(), _
                                            dt.Select()(0).Item(columnName:="DiaChi").ToString(), _
                                            dt.Select()(0).Item(columnName:="KhuVuc").ToString(), _
                                            dt.Select()(0).Item(columnName:="DienThoai").ToString(), _
                                            dt.Select()(0).Item(columnName:="Fax").ToString(), _
                                            dt.Select()(0).Item(columnName:="Email").ToString(), _
                                             dt.Select()(0).Item(columnName:="Website").ToString(), _
                                             dt.Select()(0).Item(columnName:="MaSoThue").ToString(), _
                                             dt.Select()(0).Item(columnName:="SoTaiKhoan").ToString(), _
                                             dt.Select()(0).Item(columnName:="NganHang").ToString(), _
                                             no, _
                                             ck)
        'Dim nhacungcap As New NhaCungCapDTO(, _
        '                                    , _
        '                                    
        '                                    , _
        '                                    , _
        '                                    , _
        '                                     _
        '                                    , _
        '                                    , _
        '                                    
        '                                    , _
        '                                    System.Convert.ToDouble(dt.Select()(0).Item(columnName:="NoHienTai").ToString()), _
        '                                    ck)
        Return nhacungcap
    End Function
    Public Shared Function LoadDSNhaCungCap() As DataTable
        Return NhaCungCapDAO.LoadDSNhaCungCap()
    End Function
    Public Shared Function ThemNhaCungCap(ByVal NCCDTO As NhaCungCapDTO) As Boolean
        Return NhaCungCapDAO.ThemNhaCungCap(NCCDTO)
    End Function
    Public Shared Function XoaNhaCungCap(ByVal mancc As String) As Boolean
        Return NhaCungCapDAO.XoaNhaCungCap(mancc)
    End Function
    Public Shared Function SuaNhaCungCap(ByVal NCCDTO As NhaCungCapDTO) As Boolean
        Return NhaCungCapDAO.SuaNhaCungCap(NCCDTO)
    End Function
End Class
