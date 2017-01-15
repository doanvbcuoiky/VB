<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemTyGia
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMa = New System.Windows.Forms.TextBox()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.numTyGia = New System.Windows.Forms.NumericUpDown()
        CType(Me.numTyGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã tiền tệ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên tiền tệ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tỷ giá quy đổi"
        '
        'txtMa
        '
        Me.txtMa.Location = New System.Drawing.Point(92, 15)
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(180, 20)
        Me.txtMa.TabIndex = 3
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(92, 53)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(180, 20)
        Me.txtTen.TabIndex = 4
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(90, 123)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 6
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnHuy
        '
        Me.btnHuy.Location = New System.Drawing.Point(197, 123)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 23)
        Me.btnHuy.TabIndex = 7
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'numTyGia
        '
        Me.numTyGia.DecimalPlaces = 5
        Me.numTyGia.Location = New System.Drawing.Point(92, 88)
        Me.numTyGia.Name = "numTyGia"
        Me.numTyGia.Size = New System.Drawing.Size(180, 20)
        Me.numTyGia.TabIndex = 8
        '
        'frmThemTyGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 162)
        Me.Controls.Add(Me.numTyGia)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtTen)
        Me.Controls.Add(Me.txtMa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmThemTyGia"
        Me.Text = "frmThemTyGia"
        CType(Me.numTyGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMa As System.Windows.Forms.TextBox
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents numTyGia As System.Windows.Forms.NumericUpDown
End Class
