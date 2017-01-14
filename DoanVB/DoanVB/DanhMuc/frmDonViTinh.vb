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
    End Sub

    Private Sub btnSua_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSua.ItemClick
        Dim frmSua = New frmSuaDonViTinh()
        madonvi = Me.lblMaDonVi.Text
        frmSua.ShowDialog()
    End Sub

    Private Sub btnXoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoa.ItemClick
        Dim dlgresult = MessageBox.Show("Bạn muốn xóa nhân viên có mã  " & Me.lblMaDonVi.Text & " không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgresult = Windows.Forms.DialogResult.Yes Then
            If DonViTinhBUS.XoaDonViTinh(Me.lblMaDonVi.Text) = True Then
                MessageBox.Show("Đã xóa.")
                Me.frmDonViTinh_Load(sender, e)
            End If
        End If
    End Sub
End Class