Imports DTO
Imports BUS

Public Class frmThemNhaCungCap

    Private Sub frmThemNhaCungCap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = KhuVucBUS.LoadDSKhuVuc()
        Me.cboKhuVuc.DataSource = dt
        Me.cboKhuVuc.DisplayMember = "TenKhuVuc"
        Me.cboKhuVuc.ValueMember = "MaKhuVuc"
        Me.ckTinhTrang.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nhacungcap As New NhaCungCapDTO(Me.txtMa.Text, Me.txtTen.Text, Me.txtDiaChi.Text, _
                                            Me.cboKhuVuc.SelectedValue.ToString(), Me.txtDienThoai.Text, _
                                            Me.txtFax.Text, Me.txtEmail.Text, Me.txtWebSite.Text, _
                                            Me.txtTaiKhoan.Text, Me.txtNganHang.Text, Me.txtMaSoThue.Text, _
                                            System.Convert.ToDouble(txtNoHienTai.Text.ToString()), True)
        Dim kq As Boolean = NhaCungCapBUS.ThemNhaCungCap(nhacungcap)
        If kq = True Then
            MessageBox.Show("Thêm thành công")
            Me.txtMa.Text = ""
            Me.txtTen.Text = ""
            Me.txtDiaChi.Text = ""
            Me.txtDienThoai.Text = ""
            Me.txtFax.Text = ""
            Me.txtEmail.Text = ""
            Me.txtWebSite.Text = ""
            Me.txtTaiKhoan.Text = ""
            Me.txtNganHang.Text = ""
            Me.txtMaSoThue.Text = ""
            Me.txtNoHienTai.Text = ""
            Me.ckTinhTrang.Checked = True
        Else
            MessageBox.Show("Không thêm được")
        End If
    End Sub
End Class