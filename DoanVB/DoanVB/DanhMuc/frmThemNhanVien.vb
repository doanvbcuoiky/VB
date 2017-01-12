Imports BUS
Imports DTO
Public Class frmThemNhanVien

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim nv As New NhanVienDTO(Me.txtMa.Text)

        NhanVienBUS.ThemNhanVien()
    End Sub
End Class