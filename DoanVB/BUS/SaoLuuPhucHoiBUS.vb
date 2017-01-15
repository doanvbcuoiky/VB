Imports DAO
Public Class SaoLuuPhucHoiBUS
    Public Shared Sub SaoLuu(name As String, path As String)
        SaoLuuPhucHoiDAO.SaoLuu(name, path)
    End Sub
    Public Shared Sub PhucHoi(path As String)
        SaoLuuPhucHoiDAO.PhucHoi(path)
    End Sub
End Class
