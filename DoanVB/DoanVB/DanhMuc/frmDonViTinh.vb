Imports BUS
Imports DTO
Public Class frmDonViTinh
    Public Shared madonvi As String
    Private Sub frmDonViTinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim dt As DataTable = DonViTinhBUS.LoadDSDonViTinh()
        'Me.GridControl1.DataSource = dt
        Dim dt As DataTable = DonViTinhBUS.LoadDSDonViTinh()
        Me.GridControl1.DataSource = dt
        Me.lblMaDonVi.DataBindings.Clear()
        Me.lblMaDonVi.DataBindings.Add("Text", dt, "MaDonVi")
    End Sub

    Private Sub btnThem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThem.ItemClick
        Dim frmThem = New frmThemDonViTinh()
        frmThem.ShowDialog()
        frmDonViTinh_Load(sender, e)
    End Sub

    Private Sub btnSua_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSua.ItemClick
        Dim frmSua = New frmSuaDonViTinh()
        madonvi = Me.lblMaDonVi.Text
        frmSua.ShowDialog()
        frmDonViTinh_Load(sender, e)
    End Sub

    Private Sub btnXoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoa.ItemClick
        NhatKyHeThongBUS.ThemNhatKy(frmMain.USER, "Đơn vị tính", "Xóa")
        Dim dlgresult = MessageBox.Show("Bạn muốn xóa nhân viên có mã  " & Me.lblMaDonVi.Text & " không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgresult = Windows.Forms.DialogResult.Yes Then
            If DonViTinhBUS.XoaDonViTinh(Me.lblMaDonVi.Text) = True Then
                MessageBox.Show("Đã xóa.")
                Me.frmDonViTinh_Load(sender, e)
            End If
        End If
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        NhatKyHeThongBUS.ThemNhatKy(frmMain.USER, "Xóa", "Đóng")
        Me.Close()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        frmDonViTinh_Load(sender, e)
    End Sub
End Class