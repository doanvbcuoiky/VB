Imports DTO
Imports BUS

Public Class frmSuaNhaCungCap
    Private Sub frmSuaNhaCungCap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = KhuVucBUS.LoadDSKhuVuc()
        Me.cboKhuVuc.DataSource = dt
        Me.cboKhuVuc.DisplayMember = "TenKhuVuc"
        Me.cboKhuVuc.ValueMember = "MaKhuVuc"
        Me.ckTinhTrang.Checked = True
        Me.txtMa.Text = frmNhaCungCap.manhacungcap
        Dim ncc As NhaCungCapDTO = NhaCungCapBUS.ThongTinNhaCungCap(frmNhaCungCap.manhacungcap)
        Me.txtTen.Text = ncc.TenNhaCungCap1
        Me.txtDiaChi.Text = ncc.DiaChi1
        Me.txtDienThoai.Text = ncc.DienTHoai1
        Me.txtFax.Text = ncc.Fax1
        Me.txtEmail.Text = ncc.Email1
        Me.txtWebSite.Text = ncc.Website1
        Me.txtTaiKhoan.Text = ncc.SoTaiKhoan1
        Me.txtNganHang.Text = ncc.NganHang1
        Me.txtMaSoThue.Text = ncc.MaSoThue1
        Me.txtNoHienTai.Text = ncc.NoHienTai1.ToString()
        Me.ckTinhTrang.Checked = ncc.TinhTrang1
        Me.cboKhuVuc.SelectedValue = ncc.KhuVuc1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ck As Boolean = False
        If Me.ckTinhTrang.Checked = True Then
            ck = True
        End If
        Dim nhacungcap As New NhaCungCapDTO(Me.txtMa.Text, Me.txtTen.Text, Me.txtDiaChi.Text, _
                                           Me.cboKhuVuc.SelectedValue.ToString(), Me.txtDienThoai.Text, _
                                           Me.txtFax.Text, Me.txtEmail.Text, Me.txtWebSite.Text, _
                                           Me.txtTaiKhoan.Text, Me.txtNganHang.Text, Me.txtMaSoThue.Text, _
                                           System.Convert.ToDouble(txtNoHienTai.Text.ToString()), ck)
        Dim kq As Boolean = NhaCungCapBUS.SuaNhaCungCap(nhacungcap)
        If kq = True Then
            MessageBox.Show("Sửa thành công")
            Me.Close()
        Else
            MessageBox.Show("Không sửa được")
        End If
    End Sub
End Class