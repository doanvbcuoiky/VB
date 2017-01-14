<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuaTyGia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.txtTenTienTe = New System.Windows.Forms.TextBox()
        Me.txtMatienTe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numTyGia = New System.Windows.Forms.NumericUpDown()
        Me.ckTinhTrang = New System.Windows.Forms.CheckBox()
        CType(Me.numTyGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(187, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Hủy"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(80, 144)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(75, 23)
        Me.btnLuu.TabIndex = 14
        Me.btnLuu.Text = "Sửa"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'txtTenTienTe
        '
        Me.txtTenTienTe.Location = New System.Drawing.Point(92, 50)
        Me.txtTenTienTe.Name = "txtTenTienTe"
        Me.txtTenTienTe.Size = New System.Drawing.Size(180, 20)
        Me.txtTenTienTe.TabIndex = 12
        '
        'txtMatienTe
        '
        Me.txtMatienTe.Location = New System.Drawing.Point(92, 21)
        Me.txtMatienTe.Name = "txtMatienTe"
        Me.txtMatienTe.Size = New System.Drawing.Size(180, 20)
        Me.txtMatienTe.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tỷ giá quy đổi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tên tiền tệ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mã tiền tệ"
        '
        'numTyGia
        '
        Me.numTyGia.DecimalPlaces = 5
        Me.numTyGia.Location = New System.Drawing.Point(92, 82)
        Me.numTyGia.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.numTyGia.Name = "numTyGia"
        Me.numTyGia.Size = New System.Drawing.Size(180, 20)
        Me.numTyGia.TabIndex = 16
        Me.numTyGia.Value = New Decimal(New Integer() {12456, 0, 0, 196608})
        '
        'ckTinhTrang
        '
        Me.ckTinhTrang.AutoSize = True
        Me.ckTinhTrang.Location = New System.Drawing.Point(92, 108)
        Me.ckTinhTrang.Name = "ckTinhTrang"
        Me.ckTinhTrang.Size = New System.Drawing.Size(81, 17)
        Me.ckTinhTrang.TabIndex = 17
        Me.ckTinhTrang.Text = "Còn quản lí"
        Me.ckTinhTrang.UseVisualStyleBackColor = True
        '
        'frmSuaTyGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 194)
        Me.Controls.Add(Me.ckTinhTrang)
        Me.Controls.Add(Me.numTyGia)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.txtTenTienTe)
        Me.Controls.Add(Me.txtMatienTe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSuaTyGia"
        Me.Text = "frmSuaTyGia"
        CType(Me.numTyGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents txtTenTienTe As System.Windows.Forms.TextBox
    Friend WithEvents txtMatienTe As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numTyGia As System.Windows.Forms.NumericUpDown
    Friend WithEvents ckTinhTrang As System.Windows.Forms.CheckBox
End Class
