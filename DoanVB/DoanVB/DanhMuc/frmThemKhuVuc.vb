Imports BUS
Imports DTO
Public Class frmThemKhuVuc
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
    Private Sub btbLuu_Click(sender As Object, e As EventArgs) Handles btbLuu.Click
        Dim khuvuc = New KhuVucDTO(Me.txtMa.Text, Me.txtTen.Text, Me.txtGhiChu.Text, Me.ckTinhTrang.Checked)
        Dim kq As Boolean = KhuVucBUS.ThemKhuVuc(khuvuc)
        If kq = True Then
            MessageBox.Show("Thêm thành công")
            Me.txtMa.Text = ""
            Me.txtTen.Text = ""
            Me.txtGhiChu.Text = ""
            Me.ckTinhTrang.Checked = True
        Else
            MessageBox.Show("Không thêm được")
        End If
    End Sub

    Private Sub frmThemKhuVuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ckTinhTrang.Checked = True
    End Sub
End Class