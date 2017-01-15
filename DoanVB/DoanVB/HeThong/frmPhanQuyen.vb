Imports DTO
Imports BUS
Public Class frmPhanQuyen

    Private Sub TreeList1_FocusedNodeChanged(sender As Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList1.FocusedNodeChanged
        
    End Sub

    Private Sub frmPhanQuyen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = NguoiDungBUS.LoadDSNguoiDung()
        Me.TreeList1.DataSource = dt
        TreeList1.DataSource = dt
        TreeList1.ParentFieldName = "MaNguoiDung"
        NhatKyHeThongBUS.ThemNhatKy(frmMain.USER, "Phân quyền", "")
    End Sub

    Private Sub TreeList2_FocusedNodeChanged(sender As Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList2.FocusedNodeChanged

    End Sub
End Class