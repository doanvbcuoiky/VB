<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InMaVach
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InMaVach))
        Me.txtSetPath = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.btnSetPath = New DevComponents.DotNetBar.ButtonX()
        Me.btnIn = New DevComponents.DotNetBar.ButtonX()
        Me.cbbMa = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.img1 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.SuspendLayout()
        '
        'txtSetPath
        '
        '
        '
        '
        Me.txtSetPath.Border.Class = "TextBoxBorder"
        Me.txtSetPath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSetPath.Location = New System.Drawing.Point(67, 45)
        Me.txtSetPath.Name = "txtSetPath"
        Me.txtSetPath.PreventEnterBeep = True
        Me.txtSetPath.ReadOnly = True
        Me.txtSetPath.Size = New System.Drawing.Size(251, 21)
        Me.txtSetPath.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Thư Mục"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Mã vạch"
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Location = New System.Drawing.Point(324, 72)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Thoát"
        '
        'btnSetPath
        '
        Me.btnSetPath.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSetPath.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSetPath.Location = New System.Drawing.Point(324, 45)
        Me.btnSetPath.Name = "btnSetPath"
        Me.btnSetPath.Size = New System.Drawing.Size(75, 19)
        Me.btnSetPath.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSetPath.TabIndex = 10
        Me.btnSetPath.Text = "SetPath"
        '
        'btnIn
        '
        Me.btnIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnIn.Location = New System.Drawing.Point(243, 72)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(75, 23)
        Me.btnIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnIn.TabIndex = 9
        Me.btnIn.Text = "In"
        '
        'cbbMa
        '
        Me.cbbMa.DisplayMember = "Text"
        Me.cbbMa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbbMa.FormattingEnabled = True
        Me.cbbMa.ItemHeight = 16
        Me.cbbMa.Location = New System.Drawing.Point(67, 20)
        Me.cbbMa.Name = "cbbMa"
        Me.cbbMa.Size = New System.Drawing.Size(251, 22)
        Me.cbbMa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbbMa.TabIndex = 17
        '
        'img1
        '
        '
        '
        '
        Me.img1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.img1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.img1.Image = CType(resources.GetObject("img1.Image"), System.Drawing.Image)
        Me.img1.Location = New System.Drawing.Point(67, 109)
        Me.img1.Name = "img1"
        Me.img1.Size = New System.Drawing.Size(251, 67)
        Me.img1.TabIndex = 18
        '
        'InMaVach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(432, 188)
        Me.Controls.Add(Me.img1)
        Me.Controls.Add(Me.cbbMa)
        Me.Controls.Add(Me.txtSetPath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSetPath)
        Me.Controls.Add(Me.btnIn)
        Me.Name = "InMaVach"
        Me.Text = "InMaVach"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSetPath As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSetPath As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnIn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbbMa As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents img1 As DevComponents.DotNetBar.Controls.ReflectionImage
End Class
