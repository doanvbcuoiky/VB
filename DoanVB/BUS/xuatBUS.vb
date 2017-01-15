Imports DAO
Public Class xuatBUS
    Public Sub xuat(name As String, path As String)
        Dim dao As New xuatDAO
        dao.xuat(name, path)
    End Sub

End Class
