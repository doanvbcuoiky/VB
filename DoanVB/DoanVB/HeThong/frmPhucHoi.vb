Imports System.Data.SqlClient
Imports BUS
Public Class frmPhucHoi
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSetPath_Click(sender As Object, e As EventArgs) Handles btnSetPath.Click
        Dim f As New OpenFileDialog
        f.ShowDialog()
        txtPath.Text = f.FileName
        txtName.Text = f.SafeFileName

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If (txtName.Text = "" Or txtPath.Text = "") Then
            MsgBox("Dữ liệu thiếu!")
        Else
            Try

                SaoLuuPhucHoiBUS.PhucHoi(txtPath.Text)
                MessageBox.Show("Phục hồi thành công.!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Dữ liệu đang sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        End If
    End Sub
End Class