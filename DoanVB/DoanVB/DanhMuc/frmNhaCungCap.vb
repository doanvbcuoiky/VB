Imports DTO
Imports BUS

Public Class frmNhaCungCap

    Private Sub frmNhaCungCap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim dt As DataTable = NhaCungCapBUS.LoadDSNhaCungCap()
        'Me.GridControl1.DataSource = dt
        Dim dt As DataTable = NhaCungCapBUS.LoadDSNhaCungCap()
        Me.GridControl1.DataSource = dt
        Me.lblMaNhaCungCap.DataBindings.Clear()
        Me.lblMaNhaCungCap.DataBindings.Add("Text", dt, "MaNhaCungCap")
    End Sub

    Private Sub btnThem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThem.ItemClick
        Dim frmThem = New frmThemNhaCungCap()
        frmThem.ShowDialog()
    End Sub

    Private Sub btnSua_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSua.ItemClick
        Dim frmSua = New frmSuaNhaCungCap()
        frmKhuVuc.lblmakh = Me.lblMaNhaCungCap.Text
        frmSua.ShowDialog()
    End Sub

    Private Sub btnXoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoa.ItemClick
        Dim dlgresult = MessageBox.Show("Bạn muốn xóa nhân viên có mã  " & Me.lblMaNhaCungCap.Text & " không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgresult = Windows.Forms.DialogResult.Yes Then
            If NhaCungCapBUS.XoaNhaCungCap(Me.lblMaNhaCungCap.Text) = True Then
                MessageBox.Show("Đã xóa.")
                Me.frmNhaCungCap_Load(sender, e)
            End If
        End If
    End Sub
End Class