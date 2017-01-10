Imports BUS
Imports DTO
Public Class frmKhoHang

    Private Sub frmKhoHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim dt As DataTable = KhoHangBUS.LoadDSKhoHang()
        ' Me.GridControl1.DataSource = dt
        Dim dt As DataTable = KhoHangBUS.LoadDSKhoHang()
        Me.GridControl1.DataSource = dt
        Me.lblMaKhoHang.DataBindings.Clear()
        Me.lblMaKhoHang.DataBindings.Add("Text", dt, "MaKhoHang")
    End Sub

    Private Sub btnThem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThem.ItemClick
        Dim frmThem = New frmThemKhoHang()
        frmThem.ShowDialog()
    End Sub

    Private Sub btnSua_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSua.ItemClick
        Dim frmSua = New frmSuaKhoHang()
        frmKhuVuc.lblmakh = Me.lblMaKhoHang.Text
        frmSua.ShowDialog()
    End Sub

    Private Sub btnXoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoa.ItemClick
        Dim dlgresult = MessageBox.Show("Bạn muốn xóa nhân viên có mã  " & Me.lblMaKhoHang.Text & " không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgresult = Windows.Forms.DialogResult.Yes Then
            If KhoHangBUS.XoaKhoHang(Me.lblMaKhoHang.Text) = True Then
                MessageBox.Show("Đã xóa.")
                Me.frmKhoHang_Load(sender, e)
            End If
        End If
    End Sub
End Class