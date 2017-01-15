Imports DTO
Imports BUS
Public Class frmThemNhomHang

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim nhomhang As New NhomHangHoaDTO(Me.txtMa.Text, Me.txtTen.Text, Me.txtGhiChu.Text, True)
        If NhomHangHoaBUS.ThemNhomHangHoa(nhomhang) = True Then
            MessageBox.Show("Thêm thành công")
        Else
            MessageBox.Show("Không thêm đưuọc")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class