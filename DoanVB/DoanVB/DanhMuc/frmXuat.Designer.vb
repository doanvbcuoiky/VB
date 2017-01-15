<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXuat
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSetPath = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSetPath = New DevComponents.DotNetBar.ButtonX()
        Me.btnXuat = New DevComponents.DotNetBar.ButtonX()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên file"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Thư mục"
        '
        'txtName
        '
        '
        '
        '
        Me.txtName.Border.Class = "TextBoxBorder"
        Me.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtName.Location = New System.Drawing.Point(83, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.PreventEnterBeep = True
        Me.txtName.Size = New System.Drawing.Size(250, 21)
        Me.txtName.TabIndex = 2
        '
        'txtSetPath
        '
        '
        '
        '
        Me.txtSetPath.Border.Class = "TextBoxBorder"
        Me.txtSetPath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSetPath.Location = New System.Drawing.Point(83, 43)
        Me.txtSetPath.Name = "txtSetPath"
        Me.txtSetPath.PreventEnterBeep = True
        Me.txtSetPath.Size = New System.Drawing.Size(250, 21)
        Me.txtSetPath.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(339, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "*.csv"
        '
        'btnSetPath
        '
        Me.btnSetPath.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSetPath.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSetPath.Location = New System.Drawing.Point(342, 43)
        Me.btnSetPath.Name = "btnSetPath"
        Me.btnSetPath.Size = New System.Drawing.Size(46, 21)
        Me.btnSetPath.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSetPath.TabIndex = 5
        Me.btnSetPath.Text = "SetPath"
        '
        'btnXuat
        '
        Me.btnXuat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnXuat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnXuat.Location = New System.Drawing.Point(147, 70)
        Me.btnXuat.Name = "btnXuat"
        Me.btnXuat.Size = New System.Drawing.Size(75, 23)
        Me.btnXuat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnXuat.TabIndex = 6
        Me.btnXuat.Text = "Xuất"
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Location = New System.Drawing.Point(258, 70)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Thoát"
        '
        'frmXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(390, 105)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnXuat)
        Me.Controls.Add(Me.btnSetPath)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSetPath)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.name = "frmXuat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmXuat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSetPath As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSetPath As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnXuat As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
End Class
