Imports System.ComponentModel
Imports System.Text


Partial Public Class frmMain
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Function KiemTraTonTai(ByVal fType As Type) As Form
        For Each f As Form In Me.MdiChildren
            If (f.GetType = fType) Then
                Return f
            End If

        Next
        Return Nothing
    End Function

    Private Sub bbtKetThuc_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtKetThuc.ItemClick
        Application.Exit()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtThongTin.ItemClick
        Dim frmthongtin As New frmThongTin2
        frmthongtin.ShowDialog()
    End Sub

    Private Sub bbtPhanQuyen_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtPhanQuyen.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmPhanQuyen))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmphanquyen As frmPhanQuyen = New frmPhanQuyen
            frmphanquyen.MdiParent = Me
            frmphanquyen.Show()
        End If
     
    End Sub

    Private Sub bbtDoiMatKhau_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtDoiMatKhau.ItemClick
        Dim frmm As New frmDoiMatKhau
        frmm.ShowDialog()
    End Sub

    Private Sub bbtNhatKyHeThong_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNhatKyHeThong.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmNhatKyHeThong))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmNhatKyHeThong = New frmNhatKyHeThong
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtSaoLuu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtSaoLuu.ItemClick
        Dim frmm As New frmSaoLuu
        frmm.ShowDialog()
    End Sub

    Private Sub bbtPhucHoi_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtPhucHoi.ItemClick
        Dim frmm As New frmPhucHoi
        frmm.ShowDialog()
    End Sub

    Private Sub bbtSuaChua_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtSuaChua.ItemClick
        Dim frmm As New frmSuaChua
        frmm.ShowDialog()
    End Sub

    Private Sub bbtKhuVuc_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtKhuVuc.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmKhuVuc))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmKhuVuc = New frmKhuVuc
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtKhachHang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtKhachHang.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmKhachHang))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmKhachHang = New frmKhachHang
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtNhaCungCap_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNhaCungCap.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmNhaCungCap))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmNhaCungCap = New frmNhaCungCap
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub BarButtonItem22_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtMuaHang.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmMuaHang))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmMuaHang = New frmMuaHang
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtKetChuyen_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtKetChuyen.ItemClick

    End Sub

    Private Sub bbtnNhapDanhMucTuExel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtnNhapDanhMucTuExel.ItemClick
        Dim frmm As New frmNhapDanhMucTuExel
        frmm.ShowDialog()
    End Sub

    Private Sub bbtKhoHang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtKhoHang.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmKhoHang))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmKhoHang = New frmKhoHang
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtDonViTinh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtDonViTinh.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmDonViTinh))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmDonViTinh = New frmDonViTinh
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtNhomHang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNhomHang.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmNhomHang))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmNhomHang = New frmNhomHang
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtHangHoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtHangHoa.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmHangHoa))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmHangHoa = New frmHangHoa
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtInMaVach_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtInMaVach.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmInMaVach))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmInMaVach = New frmInMaVach
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtTyGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtTyGia.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmTyGia))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmTyGia = New frmTyGia
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtBoPhan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtBoPhan.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmBoPhan))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmBoPhan = New frmBoPhan
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtNhanVien_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNhanVien.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmNhanVien))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmNhanVien = New frmNhanVien
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtBanHang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtBanHang.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmBanHang))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmBanHang = New frmBanHang
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtTonKho_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtTonKho.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmTonKho))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmTonKho = New frmTonKho
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtChuyenKho_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtChuyenKho.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmChuyenKho))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmChuyenKho = New frmChuyenKho
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtNhapSoDuDauKy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtNhapSoDuDauKy.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmNhapSoDuDauKy))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmNhapSoDuDauKy = New frmNhapSoDuDauKy
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtThuTien_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtThuTien.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmThuTien))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmThuTien = New frmThuTien
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtTraTien_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtTraTien.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmTraTien))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmTraTien = New frmTraTien
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtBaoCaoKhoHang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtBaoCaoKhoHang.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmBaoCaoKhoHang))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmBaoCaoKhoHang = New frmBaoCaoKhoHang
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtBaoCaoBanHang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtBaoCaoBanHang.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmBaoCaoBanHang))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmBaoCaoBanHang = New frmBaoCaoBanHang
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtChungTu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtChungTu.ItemClick
        Dim frm As Form = Me.KiemTraTonTai(GetType(frmChungTu))
        If (Not (frm) Is Nothing) Then
            frm.Activate()
        Else
            Dim frmm As frmChungTu = New frmChungTu
            frmm.MdiParent = Me
            frmm.Show()
        End If
    End Sub

    Private Sub bbtLienHe_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtLienHe.ItemClick
        Dim frmm As New frmLienHe
        frmm.ShowDialog()
    End Sub

    Private Sub bbtDangKy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtDangKy.ItemClick
        Dim frmm As New frmDangKy
        frmm.ShowDialog()
    End Sub

    Private Sub bbtThongTin1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbtThongTin1.ItemClick
        Dim frmm As New frmTTin
        frmm.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frm As New frmDangNhap
        frm.ShowDialog()
    End Sub
End Class
