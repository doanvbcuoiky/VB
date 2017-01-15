Imports BUS
Public Class frmNhanVien

    Public Shared manhanvien As String
    Private Sub frmNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = NhanVienBUS.LoadDSNhanVien()
        Me.GridControl1.DataSource = dt
        Me.lblMaNhanVien.DataBindings.Clear()
        Me.lblMaNhanVien.DataBindings.Add("Text", dt, "MaNhanVien")
    End Sub
    Private Sub btnThem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThem.ItemClick
        Dim frmThem = New frmThemNhanVien()
        frmThem.ShowDialog()
        frmNhanVien_Load(sender, e)
    End Sub

    Private Sub btnSua_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSua.ItemClick
        Dim frmSua = New frmSuaNhanVien()
        manhanvien = Me.lblMaNhanVien.Text
        frmSua.ShowDialog()
        frmNhanVien_Load(sender, e)
    End Sub

    Private Sub btnXoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoa.ItemClick
        Dim dlgresult = MessageBox.Show("Bạn muốn xóa nhân viên có mã  " & Me.lblMaNhanVien.Text & " không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgresult = Windows.Forms.DialogResult.Yes Then
            If NhanVienBUS.XoaNhanVien(Me.lblMaNhanVien.Text) = True Then
                MessageBox.Show("Đã xóa.")
                Me.frmNhanVien_Load(sender, e)
            End If
        End If
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        frmNhanVien_Load(sender, e)
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Me.Close()
    End Sub
End Class