Imports DTO
Imports BUS
Public Class frmThemTyGia

    Private Sub frmThemTyGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim tygia As New TyGiaDTO(Me.txtMa.Text, Me.txtTen.Text, _
                                  System.Convert.ToDouble(Me.numTyGia.Value.ToString()), True)
        If TyGiaBUS.ThemTyGia(tygia) = True Then
            MessageBox.Show("Thêm thành công")
        Else
            MessageBox.Show("Không thêm đưuọc")
        End If
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Me.Close()
    End Sub
End Class