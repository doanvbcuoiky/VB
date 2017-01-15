Imports DTO
Imports BUS
Public Class frmSuaKhuVuc

    Private Sub btbLuu_Click(sender As Object, e As EventArgs) Handles btbLuu.Click
        Dim khuvuc = New KhuVucDTO(Me.txtMa.Text, Me.txtTen.Text, Me.txtGhiChu.Text, Me.ckTinhTrang.Checked)
        Dim kq As Boolean = KhuVucBUS.SuaKhuVuc(khuvuc)
        If kq = True Then
            MessageBox.Show("Lưu thành công")
            Me.Close()
        Else
            MessageBox.Show("Không Lưu được")
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub frmSuaKhuVuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtMa.Text = frmKhuVuc.lblmakh
        Dim dt As DataTable = KhuVucBUS.ThongTinKhuVuc(Me.txtMa.Text.ToString())
        Me.txtTen.Text = dt.Select()(0).Item(columnName:="TenKhuVuc").ToString()
        Me.txtGhiChu.Text = dt.Select()(0).Item(columnName:="GhiChu").ToString()
        If dt.Select()(0).Item(columnName:="TinhTrang").ToString() = "True" Then
            Me.ckTinhTrang.Checked = True
        Else
            Me.ckTinhTrang.Checked = False
        End If
    End Sub
End Class