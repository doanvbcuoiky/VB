<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKhachHang))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMaKhachHang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTenKhachHang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNguoiLienHe = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiaChi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLoaiKhachHang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKhuVuc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDienThoai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWebsite = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaSoThue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSoTaiKhoan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNganHang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTinhTrang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btnThem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSua = New DevExpress.XtraBars.BarButtonItem()
        Me.btnXoa = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.QuanLyBanHangDataSet1 = New DoanVB.QuanLyBanHangDataSet1()
        Me.KHACHHANGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KHACHHANGTableAdapter = New DoanVB.QuanLyBanHangDataSet1TableAdapters.KHACHHANGTableAdapter()
        Me.lblMaKhachHang = New System.Windows.Forms.Label()
        Me.PanelEx1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuanLyBanHangDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KHACHHANGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.GridControl1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 24)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(722, 363)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(722, 363)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMaKhachHang, Me.colTenKhachHang, Me.colNguoiLienHe, Me.colDiaChi, Me.colLoaiKhachHang, Me.colKhuVuc, Me.colDienThoai, Me.colFax, Me.colEmail, Me.colWebsite, Me.colMaSoThue, Me.colSoTaiKhoan, Me.colNganHang, Me.colTinhTrang})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colMaKhachHang
        '
        Me.colMaKhachHang.FieldName = "MaKhachHang"
        Me.colMaKhachHang.Name = "colMaKhachHang"
        Me.colMaKhachHang.Visible = True
        Me.colMaKhachHang.VisibleIndex = 0
        '
        'colTenKhachHang
        '
        Me.colTenKhachHang.FieldName = "TenKhachHang"
        Me.colTenKhachHang.Name = "colTenKhachHang"
        Me.colTenKhachHang.Visible = True
        Me.colTenKhachHang.VisibleIndex = 1
        '
        'colNguoiLienHe
        '
        Me.colNguoiLienHe.FieldName = "NguoiLienHe"
        Me.colNguoiLienHe.Name = "colNguoiLienHe"
        Me.colNguoiLienHe.Visible = True
        Me.colNguoiLienHe.VisibleIndex = 2
        '
        'colDiaChi
        '
        Me.colDiaChi.FieldName = "DiaChi"
        Me.colDiaChi.Name = "colDiaChi"
        Me.colDiaChi.Visible = True
        Me.colDiaChi.VisibleIndex = 3
        '
        'colLoaiKhachHang
        '
        Me.colLoaiKhachHang.FieldName = "LoaiKhachHang"
        Me.colLoaiKhachHang.Name = "colLoaiKhachHang"
        Me.colLoaiKhachHang.Visible = True
        Me.colLoaiKhachHang.VisibleIndex = 4
        '
        'colKhuVuc
        '
        Me.colKhuVuc.FieldName = "KhuVuc"
        Me.colKhuVuc.Name = "colKhuVuc"
        Me.colKhuVuc.Visible = True
        Me.colKhuVuc.VisibleIndex = 5
        '
        'colDienThoai
        '
        Me.colDienThoai.FieldName = "DienThoai"
        Me.colDienThoai.Name = "colDienThoai"
        Me.colDienThoai.Visible = True
        Me.colDienThoai.VisibleIndex = 6
        '
        'colFax
        '
        Me.colFax.FieldName = "Fax"
        Me.colFax.Name = "colFax"
        Me.colFax.Visible = True
        Me.colFax.VisibleIndex = 7
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 8
        '
        'colWebsite
        '
        Me.colWebsite.FieldName = "Website"
        Me.colWebsite.Name = "colWebsite"
        Me.colWebsite.Visible = True
        Me.colWebsite.VisibleIndex = 9
        '
        'colMaSoThue
        '
        Me.colMaSoThue.FieldName = "MaSoThue"
        Me.colMaSoThue.Name = "colMaSoThue"
        Me.colMaSoThue.Visible = True
        Me.colMaSoThue.VisibleIndex = 10
        '
        'colSoTaiKhoan
        '
        Me.colSoTaiKhoan.FieldName = "SoTaiKhoan"
        Me.colSoTaiKhoan.Name = "colSoTaiKhoan"
        Me.colSoTaiKhoan.Visible = True
        Me.colSoTaiKhoan.VisibleIndex = 11
        '
        'colNganHang
        '
        Me.colNganHang.FieldName = "NganHang"
        Me.colNganHang.Name = "colNganHang"
        Me.colNganHang.Visible = True
        Me.colNganHang.VisibleIndex = 12
        '
        'colTinhTrang
        '
        Me.colTinhTrang.FieldName = "TinhTrang"
        Me.colTinhTrang.Name = "colTinhTrang"
        Me.colTinhTrang.Visible = True
        Me.colTinhTrang.VisibleIndex = 13
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnThem, Me.btnSua, Me.btnXoa, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 7
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem3, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem5, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem6, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'btnThem
        '
        Me.btnThem.Border = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.btnThem.Caption = "Thêm"
        Me.btnThem.Glyph = CType(resources.GetObject("btnThem.Glyph"), System.Drawing.Image)
        Me.btnThem.Id = 0
        Me.btnThem.ImageUri.Uri = "Add"
        Me.btnThem.LargeGlyph = CType(resources.GetObject("btnThem.LargeGlyph"), System.Drawing.Image)
        Me.btnThem.Name = "btnThem"
        '
        'btnSua
        '
        Me.btnSua.Caption = "Sửa Chữa"
        Me.btnSua.Glyph = CType(resources.GetObject("btnSua.Glyph"), System.Drawing.Image)
        Me.btnSua.Id = 1
        Me.btnSua.LargeGlyph = CType(resources.GetObject("btnSua.LargeGlyph"), System.Drawing.Image)
        Me.btnSua.Name = "btnSua"
        '
        'btnXoa
        '
        Me.btnXoa.Caption = "Xóa"
        Me.btnXoa.Glyph = CType(resources.GetObject("btnXoa.Glyph"), System.Drawing.Image)
        Me.btnXoa.Id = 2
        Me.btnXoa.LargeGlyph = CType(resources.GetObject("btnXoa.LargeGlyph"), System.Drawing.Image)
        Me.btnXoa.Name = "btnXoa"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Nạp Lại"
        Me.BarButtonItem3.Glyph = CType(resources.GetObject("BarButtonItem3.Glyph"), System.Drawing.Image)
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.LargeGlyph = CType(resources.GetObject("BarButtonItem3.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Xuất"
        Me.BarButtonItem4.Glyph = CType(resources.GetObject("BarButtonItem4.Glyph"), System.Drawing.Image)
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.LargeGlyph = CType(resources.GetObject("BarButtonItem4.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Nhập "
        Me.BarButtonItem5.Glyph = CType(resources.GetObject("BarButtonItem5.Glyph"), System.Drawing.Image)
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.LargeGlyph = CType(resources.GetObject("BarButtonItem5.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Đóng"
        Me.BarButtonItem6.Glyph = CType(resources.GetObject("BarButtonItem6.Glyph"), System.Drawing.Image)
        Me.BarButtonItem6.Id = 6
        Me.BarButtonItem6.LargeGlyph = CType(resources.GetObject("BarButtonItem6.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(722, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 387)
        Me.barDockControlBottom.Size = New System.Drawing.Size(722, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 363)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(722, 24)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 363)
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Còn Quản Lý"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Di Động"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'QuanLyBanHangDataSet1
        '
        Me.QuanLyBanHangDataSet1.DataSetName = "QuanLyBanHangDataSet1"
        Me.QuanLyBanHangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KHACHHANGBindingSource
        '
        Me.KHACHHANGBindingSource.DataMember = "KHACHHANG"
        Me.KHACHHANGBindingSource.DataSource = Me.QuanLyBanHangDataSet1
        '
        'KHACHHANGTableAdapter
        '
        Me.KHACHHANGTableAdapter.ClearBeforeFill = True
        '
        'lblMaKhachHang
        '
        Me.lblMaKhachHang.AutoSize = True
        Me.lblMaKhachHang.Location = New System.Drawing.Point(573, 5)
        Me.lblMaKhachHang.Name = "lblMaKhachHang"
        Me.lblMaKhachHang.Size = New System.Drawing.Size(85, 13)
        Me.lblMaKhachHang.TabIndex = 8
        Me.lblMaKhachHang.Text = "lblMaKhachHang"
        '
        'frmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 387)
        Me.Controls.Add(Me.lblMaKhachHang)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmKhachHang"
        Me.Text = "frmKhachHang"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuanLyBanHangDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KHACHHANGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnThem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSua As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnXoa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents QuanLyBanHangDataSet1 As DoanVB.QuanLyBanHangDataSet1
    Friend WithEvents KHACHHANGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KHACHHANGTableAdapter As DoanVB.QuanLyBanHangDataSet1TableAdapters.KHACHHANGTableAdapter
    Friend WithEvents colMaKhachHang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTenKhachHang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNguoiLienHe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiaChi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoaiKhachHang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKhuVuc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDienThoai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWebsite As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaSoThue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSoTaiKhoan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNganHang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTinhTrang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblMaKhachHang As System.Windows.Forms.Label
End Class
