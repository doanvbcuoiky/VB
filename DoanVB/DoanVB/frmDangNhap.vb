
Imports DTO
Imports BUS
Public Class frmDangNhap

    Private Sub frmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Lấy danh sách người dùng
        Dim dt As DataTable = NguoiDungBUS.LoadDSNguoiDung()
        Me.cboTaiKhoan.DataSource = dt
        Me.cboTaiKhoan.DisplayMember = "TenNguoiDung"
        Me.cboTaiKhoan.ValueMember = "MaNguoiDung"
        'Me.txtMatKhau.Text = dt.Select()(1).Item(columnName:="MatKhau").ToString()
    End Sub

    Private Sub cboTaiKhoan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTaiKhoan.SelectedIndexChanged
        'Dim matkhau As String = NguoiDungBUS.LayMatKhau(Me.cboTaiKhoan.SelectedValue.ToString()).ToString()
        'If (matkhau <> "") Then
        '    Me.txtMatKhau.Text = matkhau
        'End If
    End Sub

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        'Kiem tra thong tin dang nhap.
        If Me.txtMatKhau.Text = "" Then
            MessageBox.Show("Chưa nhập mật khẩu.")
        ElseIf NguoiDungBUS.KiemTraDangNhap(Me.cboTaiKhoan.SelectedValue.ToString(), Me.txtMatKhau.Text.ToString()) Then
            MessageBox.Show("Đăng nhập thành công.")
            If Me.ckGhiNho.Checked = False Then
                MessageBox.Show("đã chọn")
                NguoiDungBUS.LuuThongTinDangNhap(Me.cboTaiKhoan.SelectedValue.ToString())
            End If
            Me.Close()
        Else
            'MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.")
        End If
        'Kiem tra check box ghi nhớ thông tin đăng nhập.
    End Sub
End Class