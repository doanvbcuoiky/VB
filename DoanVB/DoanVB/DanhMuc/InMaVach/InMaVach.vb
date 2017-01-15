Imports Spire.Barcode.Forms
Public Class InMaVach
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        If cbbMa.Text = "" Or txtSetPath.Text = "" Then
            MsgBox("Kiểm tra lại!")
        Else
            Dim barcode As New BarCodeControl
            barcode.Data = cbbMa.Text
            barcode.Data2D = cbbMa.Text
            barcode.Type = Spire.Barcode.BarCodeType.Code128
            barcode.SaveToFile(txtSetPath.Text + "\" + cbbMa.Text + ".png")
            Process.Start(txtSetPath.Text + "\" + cbbMa.Text + ".png")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSetPath_Click(sender As Object, e As EventArgs) Handles btnSetPath.Click
        Dim folder As New FolderBrowserDialog
        folder.ShowDialog()
        txtSetPath.Text = folder.SelectedPath
    End Sub
End Class