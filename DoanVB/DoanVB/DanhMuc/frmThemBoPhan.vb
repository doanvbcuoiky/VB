Imports DTO
Imports BUS
Public Class frmThemBoPhan

    Private Sub btbLuu_Click(sender As Object, e As EventArgs) Handles btbLuu.Click
        Dim bophan As New BoPhanDTO(Me.txtMa.Text, Me.txtTen.Text, Me.txtGhiChu.Text, True)
        If BoPhanBUS.ThemBoPhan(bophan) = True Then
            MessageBox.Show("Thêm thành công")
        Else
            MessageBox.Show("Không thêm được")
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class