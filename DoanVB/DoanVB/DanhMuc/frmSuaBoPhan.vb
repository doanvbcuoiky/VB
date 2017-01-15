Imports DTO
Imports BUS
Public Class frmSuaBoPhan

    Private Sub frmSuaBoPhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bophan As BoPhanDTO = BoPhanBUS.ThongTinBoPhan(frmBoPhan.mabophan)

        Me.txtMa.Text = bophan.MaBoPhan1
        Me.txtTen.Text = bophan.TenBoPhan1
        Me.txtGhiChu.Text = bophan.GhiChu1
        Me.ckTinhTrang.Checked = bophan.TinhTrang1

    End Sub

    Private Sub btbLuu_Click(sender As Object, e As EventArgs) Handles btbLuu.Click
        Dim bophan As New BoPhanDTO(Me.txtMa.Text, Me.txtTen.Text, Me.txtGhiChu.Text, Me.ckTinhTrang.Checked)
        If BoPhanBUS.SuaBoPhan(bophan) = True Then
            MessageBox.Show("Sửa thành công")
            frmSuaBoPhan_Load(sender, e)
        Else
            MessageBox.Show("Không thêm được")
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class