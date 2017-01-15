Imports BUS
Imports DTO
Public Class frmThemDonViTinh

    Private Sub frmThemDonViTinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim donvitinh As New DonViTinhDTO(Me.txtMa.Text, Me.txtTen.Text, Me.txtGhiChu.Text, True)
        If DonViTinhBUS.ThemDonViTinh(donvitinh) = True Then
            MessageBox.Show("Thêm thành công.")
        Else
            MessageBox.Show("Không thêm được.")
        End If
    End Sub

    Private Sub btndong_Click(sender As Object, e As EventArgs) Handles btndong.Click
        Me.Close()
    End Sub
End Class