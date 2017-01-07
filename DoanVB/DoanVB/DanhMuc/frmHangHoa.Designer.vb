<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHangHoa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHangHoa))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.HANGHOABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuanLyBanHangDataSet = New DoanVB.QuanLyBanHangDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.HANGHOATableAdapter = New DoanVB.QuanLyBanHangDataSetTableAdapters.HANGHOATableAdapter()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HANGHOABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuanLyBanHangDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 7
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem4, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem5, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem6, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem7, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Thêm"
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Sửa Chữa"
        Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"), System.Drawing.Image)
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.LargeGlyph = CType(resources.GetObject("BarButtonItem2.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Xóa"
        Me.BarButtonItem3.Glyph = CType(resources.GetObject("BarButtonItem3.Glyph"), System.Drawing.Image)
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.LargeGlyph = CType(resources.GetObject("BarButtonItem3.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Nạp Lại"
        Me.BarButtonItem4.Glyph = CType(resources.GetObject("BarButtonItem4.Glyph"), System.Drawing.Image)
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.LargeGlyph = CType(resources.GetObject("BarButtonItem4.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Xuất"
        Me.BarButtonItem5.Glyph = CType(resources.GetObject("BarButtonItem5.Glyph"), System.Drawing.Image)
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.LargeGlyph = CType(resources.GetObject("BarButtonItem5.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Nhập"
        Me.BarButtonItem6.Glyph = CType(resources.GetObject("BarButtonItem6.Glyph"), System.Drawing.Image)
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.LargeGlyph = CType(resources.GetObject("BarButtonItem6.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Đóng"
        Me.BarButtonItem7.Glyph = CType(resources.GetObject("BarButtonItem7.Glyph"), System.Drawing.Image)
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.LargeGlyph = CType(resources.GetObject("BarButtonItem7.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(583, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 333)
        Me.barDockControlBottom.Size = New System.Drawing.Size(583, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 309)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(583, 24)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 309)
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 24)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(583, 309)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'HANGHOABindingSource
        '
        Me.HANGHOABindingSource.DataMember = "HANGHOA"
        Me.HANGHOABindingSource.DataSource = Me.QuanLyBanHangDataSet
        '
        'QuanLyBanHangDataSet
        '
        Me.QuanLyBanHangDataSet.DataSetName = "QuanLyBanHangDataSet"
        Me.QuanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'HANGHOATableAdapter
        '
        Me.HANGHOATableAdapter.ClearBeforeFill = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Mã hàng"
        Me.GridColumn1.FieldName = "MaHangHoa"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tên hàng"
        Me.GridColumn2.FieldName = "TenHangHoa"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Kiểu hàng hóa"
        Me.GridColumn3.FieldName = "KieuHangHoa"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Nhóm hàng"
        Me.GridColumn4.FieldName = "NhomHang"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Mã Vạch"
        Me.GridColumn5.FieldName = "MaVach"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Đơn vị"
        Me.GridColumn6.FieldName = "DonVi"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Xuất xứ"
        Me.GridColumn7.FieldName = "XuatXu"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Tồn kho tối thiểu"
        Me.GridColumn8.FieldName = "TonKhoToiThieu"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Tồn hiện tại"
        Me.GridColumn9.FieldName = "TonHienTai"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Nhà cung cấp"
        Me.GridColumn10.FieldName = "NhaCungCap"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Giá mua"
        Me.GridColumn11.FieldName = "GiaMua"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 10
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Giá bản lẻ"
        Me.GridColumn12.FieldName = "GiaBanLe"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 11
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Giá bán sĩ"
        Me.GridColumn13.FieldName = "GiaBanSi"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 12
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Loại tiền"
        Me.GridColumn14.FieldName = "LoaiTien"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 13
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Tình trạng"
        Me.GridColumn15.FieldName = "TinhTrang"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 14
        '
        'frmHangHoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 333)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmHangHoa"
        Me.Text = "frmHangHoa"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HANGHOABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuanLyBanHangDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Private WithEvents Bar2 As DevExpress.XtraBars.Bar
    Private WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents QuanLyBanHangDataSet As DoanVB.QuanLyBanHangDataSet
    Friend WithEvents HANGHOABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HANGHOATableAdapter As DoanVB.QuanLyBanHangDataSetTableAdapters.HANGHOATableAdapter
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
End Class
