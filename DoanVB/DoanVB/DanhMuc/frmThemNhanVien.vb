Imports BUS
Imports DTO
Public Class frmThemNhanVien

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim nv As New NhanVienDTO(Me.txtMa.Text, Me.txtTen.Text, Me.txtChucVu.Text, _
                                  Me.txtDiaChi.Text, Me.txtEmail.Text, Me.txtDienThoai.Text, _
                                  Me.cboBoPhan.SelectedValue.ToString(), Me.cboNguoiQuanLi.SelectedValue.ToString(), _
                                  True)
        Dim kq As Boolean = NhanVienBUS.ThemNhanVien(nv)
        If kq = True Then
            MessageBox.Show("Thêm thành công")
        Else
            MessageBox.Show("Không thêm được")
        End If
    End Sub

    Private Sub frmThemNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bophan As DataTable = BoPhanBUS.LoadDSBoPhan()
        Dim quanli As DataTable = NhanVienBUS.LoadDSNhanVien()

        Me.cboBoPhan.DataSource = bophan
        Me.cboNguoiQuanLi.DataSource = quanli

        Me.cboBoPhan.DisplayMember = "TenBoPhan"
        Me.cboNguoiQuanLi.DisplayMember = "TenNhanVien"

        Me.cboBoPhan.ValueMember = "MaBoPhan"
        Me.cboNguoiQuanLi.ValueMember = "MaNhanVien"

        Me.cboBoPhan.SelectedIndex = 0
        Me.cboNguoiQuanLi.SelectedIndex = 0
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class