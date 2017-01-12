Imports BUS
Imports DTO
Public Class frmThemNhanVien

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim nv As New NhanVienDTO(Me.txtMa.Text, Me.txtTen.Text, Me.txtChucVu.Text, _
                                  Me.txtDiaChi.Text, Me.txtEmail.Text, Me.txtDienThoai.Text, _
                                  Me.cboBoPhan.SelectedValue.ToString(), Me.cboNguoiQuanLi.SelectedValue.ToString(), _
                                  Me.cktinhTrang.Checked)
        Dim kq As Boolean = NhanVienBUS.ThemNhanVien(nv)
        If kq = True Then
            MessageBox.Show("Thêm thành công")
        Else
            MessageBox.Show("Không thêm được")
        End If
    End Sub
End Class