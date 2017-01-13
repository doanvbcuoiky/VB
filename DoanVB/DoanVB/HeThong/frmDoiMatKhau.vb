Imports DTO
Imports BUS
Public Class frmDoiMatKhau

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        If (txtMkMoi.Text <> txtXacNhan.Text) Then
            MessageBox.Show("Mật khẩu mới không khớp")
        ElseIf NguoiDungBUS.LayMatKhau(frmMain.USER) <> txtMkCu.Text Then
            MessageBox.Show("Mật khẩu cũ không đúng.")
        Else
            NguoiDungBUS.CapNhatMatKhau(frmMain.USER, txtMkMoi.Text)
            MessageBox.Show("Cập nhật thành công.")
            txtMkCu.Text = ""
            txtMkMoi.Text = ""
            txtXacNhan.Text = ""
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub frmDoiMatKhau_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class