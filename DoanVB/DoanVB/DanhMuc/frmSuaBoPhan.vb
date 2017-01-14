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
End Class