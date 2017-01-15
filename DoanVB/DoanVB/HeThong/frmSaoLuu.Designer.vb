<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaoLuu
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.btnSetPath = New DevComponents.DotNetBar.ButtonX()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnCreate = New DevComponents.DotNetBar.ButtonX()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnLocal = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.btnLocal)
        Me.PanelEx1.Controls.Add(Me.btnSetPath)
        Me.PanelEx1.Controls.Add(Me.txtPath)
        Me.PanelEx1.Controls.Add(Me.btnCreate)
        Me.PanelEx1.Controls.Add(Me.btnClose)
        Me.PanelEx1.Controls.Add(Me.ProgressBarX1)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.txtName)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(475, 190)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'btnSetPath
        '
        Me.btnSetPath.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSetPath.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSetPath.Location = New System.Drawing.Point(388, 114)
        Me.btnSetPath.Name = "btnSetPath"
        Me.btnSetPath.Size = New System.Drawing.Size(75, 23)
        Me.btnSetPath.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSetPath.TabIndex = 8
        Me.btnSetPath.Text = "SetPath"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(119, 116)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(263, 21)
        Me.txtPath.TabIndex = 7
        '
        'btnCreate
        '
        Me.btnCreate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCreate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCreate.Location = New System.Drawing.Point(307, 143)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCreate.TabIndex = 6
        Me.btnCreate.Text = "Thực hiện"
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Location = New System.Drawing.Point(388, 143)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Đóng"
        '
        'ProgressBarX1
        '
        '
        '
        '
        Me.ProgressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBarX1.Location = New System.Drawing.Point(119, 52)
        Me.ProgressBarX1.Name = "ProgressBarX1"
        Me.ProgressBarX1.Size = New System.Drawing.Size(344, 23)
        Me.ProgressBarX1.TabIndex = 3
        Me.ProgressBarX1.Text = "0%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Đường dẫn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên tập tin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tiến trình"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(139, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sao lưu dự phòng dữ liệu."
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(119, 84)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(344, 21)
        Me.txtName.TabIndex = 0
        '
        'btnLocal
        '
        Me.btnLocal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLocal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLocal.Enabled = False
        Me.btnLocal.Location = New System.Drawing.Point(119, 143)
        Me.btnLocal.Name = "btnLocal"
        Me.btnLocal.Size = New System.Drawing.Size(102, 23)
        Me.btnLocal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLocal.TabIndex = 9
        Me.btnLocal.Text = "Thư mục chứa"
        '
        'frmSaoLuu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 190)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSaoLuu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sao Lưu Dữ Liệu"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnCreate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSetPath As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtPath As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnLocal As DevComponents.DotNetBar.ButtonX
End Class
