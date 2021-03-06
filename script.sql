Create database QuanLyBanHang
USE [QuanLyBanHang]
GO
/****** Object:  Table [dbo].[BOPHAN]    Script Date: 1/5/2017 11:12:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BOPHAN](
	[MaBoPhan] [varchar](20) NOT NULL,
	[TenBoPhan] [nvarchar](50) NOT NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TinhTrang] [bit] NOT NULL,
 CONSTRAINT [PK_BOPHAN] PRIMARY KEY CLUSTERED 
(
	[MaBoPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETKHO]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETKHO](
	[MaKhoHang] [varchar](20) NOT NULL,
	[MaHangHoa] [varchar](20) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_CHITIETKHO] PRIMARY KEY CLUSTERED 
(
	[MaKhoHang] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETPHIEUBANHANG]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUBANHANG](
	[MaPhieuBan] [varchar](20) NOT NULL,
	[MaHangHoa] [varchar](20) NOT NULL,
	[DonVi] [varchar](20) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [money] NULL,
	[ChietKhau] [float] NULL,
 CONSTRAINT [PK_CHITIETPHIEUBANHANG] PRIMARY KEY CLUSTERED 
(
	[MaPhieuBan] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETPHIEUCHUYENKHO]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUCHUYENKHO](
	[MaPhieuChuyen] [varchar](20) NOT NULL,
	[MaHangHoa] [varchar](20) NOT NULL,
	[DonVi] [varchar](20) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [money] NULL,
 CONSTRAINT [PK_CHITIETPHIEUCHUYENKHO] PRIMARY KEY CLUSTERED 
(
	[MaPhieuChuyen] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETPHIEUNHAPHANG]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAPHANG](
	[MaPhieuNhap] [varchar](20) NOT NULL,
	[MaHangHoa] [varchar](20) NOT NULL,
	[DonVi] [varchar](20) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [money] NULL,
	[ChietKhau] [float] NULL,
 CONSTRAINT [PK_CHITIETPHIEUNHAPHANG] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DONVITINH]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DONVITINH](
	[MaDonVi] [varchar](20) NOT NULL,
	[TenDonVi] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_DONVITINH] PRIMARY KEY CLUSTERED 
(
	[MaDonVi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MaHangHoa] [varchar](20) NOT NULL,
	[TenHangHoa] [nvarchar](50) NULL,
	[KieuHangHoa] [nvarchar](50) NULL,
	[NhomHang] [varchar](20) NULL,
	[MaVach] [varchar](50) NULL,
	[DonVi] [varchar](20) NULL,
	[XuatXu] [nvarchar](50) NULL,
	[TonKhoToiThieu] [int] NULL,
	[TonHienTai] [int] NULL,
	[NhaCungCap] [varchar](20) NULL,
	[GiaMua] [money] NULL,
	[GiaBanLe] [money] NULL,
	[GiaBanSi] [money] NULL,
	[LoaiTien] [varchar](3) NULL,
	[HinhAnh] [nvarchar](255) NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_HANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKhachHang] [varchar](20) NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[NguoiLienHe] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[LoaiKhachHang] [varchar](20) NULL,
	[KhuVuc] [varchar](20) NULL,
	[DienThoai] [varchar](13) NULL,
	[Fax] [varchar](15) NULL,
	[Email] [varchar](20) NULL,
	[Website] [varchar](20) NULL,
	[MaSoThue] [varchar](20) NULL,
	[SoTaiKhoan] [varchar](20) NULL,
	[NganHang] [nvarchar](50) NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHOHANG]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHOHANG](
	[MaKhoHang] [varchar](20) NOT NULL,
	[KiHieu] [varchar](20) NULL,
	[TenKhoHang] [nvarchar](50) NULL,
	[NguoiQuanLi] [varchar](20) NULL,
	[NguoiLienHe] [varchar](20) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [varchar](13) NULL,
	[Fax] [varchar](15) NULL,
	[Email] [varchar](20) NULL,
	[DienGiai] [nvarchar](50) NULL,
	[TinhTrang] [bit] NOT NULL,
 CONSTRAINT [PK_KHOHANG] PRIMARY KEY CLUSTERED 
(
	[MaKhoHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHUVUC]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHUVUC](
	[MaKhuVuc] [varchar](20) NOT NULL,
	[TenKhuVuc] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_KHUVUC] PRIMARY KEY CLUSTERED 
(
	[MaKhuVuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIKHACHHANG]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAIKHACHHANG](
	[MaLoaiKhachHang] [varchar](20) NOT NULL,
	[TenLoaiKhachHang] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_LOAIKHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[MaNguoiDung] [varchar](20) NOT NULL,
	[TenNguoiDung] [nvarchar](50) NULL,
	[MatKhau] [varchar](20) NULL,
	[TinhTrang] [bit] NULL,
	[NhoMatKhau] [bit] NULL,
	[MaNhanVien] [varchar](20) NULL,
 CONSTRAINT [PK_NGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNhaCungCap] [varchar](20) NOT NULL,
	[TenNhaCungCap] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[KhuVuc] [varchar](20) NULL,
	[DienThoai] [varchar](13) NULL,
	[Fax] [varchar](20) NULL,
	[Email] [varchar](20) NULL,
	[Website] [varchar](20) NULL,
	[MaSoThue] [varchar](20) NULL,
	[SoTaiKhoan] [varchar](20) NULL,
	[NganHang] [nvarchar](50) NULL,
	[NoHienTai] [float] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNhanVien] [varchar](20) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Emai] [varchar](20) NULL,
	[DienThoai] [varchar](13) NULL,
	[BoPhan] [varchar](20) NULL,
	[NguoiQuanLi] [varchar](20) NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHOMHANGHOA]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHOMHANGHOA](
	[MaNhomHang] [varchar](20) NOT NULL,
	[TenNhomHang] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_NHOMHANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaNhomHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHANQUYEN](
	[TenNhom] [nvarchar](50) NOT NULL,
	[TenChucNang] [nvarchar](50) NOT NULL,
	[MaNguoiDung] [varchar](20) NOT NULL,
	[ChoPhepThem] [bit] NULL,
	[ChoPhepXoa] [bit] NULL,
	[ChoPhepSua] [bit] NULL,
	[ChoPhepTruyCap] [bit] NULL,
	[ChoPhepIn] [bit] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_PHANQUYEN] PRIMARY KEY CLUSTERED 
(
	[TenNhom] ASC,
	[TenChucNang] ASC,
	[MaNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUBANHANG]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUBANHANG](
	[MaPhieuBan] [varchar](20) NOT NULL,
	[MaKhachHang] [varchar](20) NULL,
	[NgayBan] [datetime] NULL,
	[NhanVienBan] [varchar](20) NULL,
	[KhoXuat] [varchar](20) NULL,
	[HinhThucThanhToan] [nvarchar](50) NULL,
	[TongTien] [money] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_PHIEUBANHANG] PRIMARY KEY CLUSTERED 
(
	[MaPhieuBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUCHUYENKHO]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUCHUYENKHO](
	[MaPhieuChuyen] [varchar](20) NOT NULL,
	[NgayChuyen] [datetime] NULL,
	[KhoXuat] [varchar](20) NULL,
	[KhoNhap] [varchar](20) NULL,
	[NguoiChuyen] [varchar](20) NULL,
	[NguoiNhan] [varchar](20) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TongTien] [money] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_PHIEUCHUYENKHO] PRIMARY KEY CLUSTERED 
(
	[MaPhieuChuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAPHANG]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUNHAPHANG](
	[MaPhieuNhap] [varchar](20) NOT NULL,
	[NgayNhap] [datetime] NULL,
	[NhanVienNhap] [varchar](20) NULL,
	[KhoNhap] [varchar](20) NULL,
	[HanThanhToan] [datetime] NULL,
	[NhaCungCap] [varchar](20) NULL,
	[HinhThucThanhToan] [nvarchar](50) NULL,
	[TongTien] [money] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_PHIEUNHAPHANG] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TYGIA]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TYGIA](
	[MaTienTe] [varchar](3) NOT NULL,
	[TenTienTe] [nvarchar](50) NULL,
	[TyGiaQuyDoi] [money] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_TYGIA] PRIMARY KEY CLUSTERED 
(
	[MaTienTe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [GhiChu], [TinhTrang]) VALUES (N'GD', N'Giám Đốc', N'', 1)
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [GhiChu], [TinhTrang]) VALUES (N'KD', N'Phòng Kinh Doanh', N'', 1)
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [GhiChu], [TinhTrang]) VALUES (N'KT', N'Phòng kế toán', N'', 1)
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [GhiChu], [TinhTrang]) VALUES (N'KTH', N'Phòng Kỹ Thuật', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV000029', N'Hệ thống', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV01', N'bình', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV02', N'bộ', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV03', N'cái', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV04', N'cặp', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV05', N'cây', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV06', N'chai', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV07', N'con', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV08', N'cục', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV09', N'cụm', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV10', N'cuộn', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV11', N'dàn', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV12', N'dây', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV13', N'đôi', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV14', N'gói', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV15', N'hộp', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV16', N'kg', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV17', N'khúc', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV18', N'lít', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV19', N'lon', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV20', N'm²', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV21', N'mét', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV22', N'ống', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV23', N'que', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV24', N'sợi', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV25', N'tấm', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV26', N'tờ', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV27', N'Thùng', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDonVi], [TenDonVi], [GhiChu], [TinhTrang]) VALUES (N'DV28', N'Xấp', N'', 1)
INSERT [dbo].[KHOHANG] ([MaKhoHang], [KiHieu], [TenKhoHang], [NguoiQuanLi], [NguoiLienHe], [DiaChi], [DienThoai], [Fax], [Email], [DienGiai], [TinhTrang]) VALUES (N'CT', NULL, N'Kho công ty', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[KHOHANG] ([MaKhoHang], [KiHieu], [TenKhoHang], [NguoiQuanLi], [NguoiLienHe], [DiaChi], [DienThoai], [Fax], [Email], [DienGiai], [TinhTrang]) VALUES (N'CT2', NULL, N'Kho Hà Nội', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[KHOHANG] ([MaKhoHang], [KiHieu], [TenKhoHang], [NguoiQuanLi], [NguoiLienHe], [DiaChi], [DienThoai], [Fax], [Email], [DienGiai], [TinhTrang]) VALUES (N'CT3', NULL, N'Kho Phạm Văn Hai', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[KHOHANG] ([MaKhoHang], [KiHieu], [TenKhoHang], [NguoiQuanLi], [NguoiLienHe], [DiaChi], [DienThoai], [Fax], [Email], [DienGiai], [TinhTrang]) VALUES (N'K000001', NULL, N'Kho 6 HCM', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[KHUVUC] ([MaKhuVuc], [TenKhuVuc], [GhiChu], [TinhTrang]) VALUES (N'KV000001', N'Miền Nam', N'', 1)
INSERT [dbo].[KHUVUC] ([MaKhuVuc], [TenKhuVuc], [GhiChu], [TinhTrang]) VALUES (N'KV000002', N'Miền Bắc', N'', 1)
INSERT [dbo].[KHUVUC] ([MaKhuVuc], [TenKhuVuc], [GhiChu], [TinhTrang]) VALUES (N'KV000003', N'Miền trung', N'', 1)
INSERT [dbo].[LOAIKHACHHANG] ([MaLoaiKhachHang], [TenLoaiKhachHang], [GhiChu], [TinhTrang]) VALUES (N'KHHM', N'Khách hàng hỏi mua', N'', 1)
INSERT [dbo].[LOAIKHACHHANG] ([MaLoaiKhachHang], [TenLoaiKhachHang], [GhiChu], [TinhTrang]) VALUES (N'KHTN', N'Khách hàng tiềm năng', N'', 1)
INSERT [dbo].[LOAIKHACHHANG] ([MaLoaiKhachHang], [TenLoaiKhachHang], [GhiChu], [TinhTrang]) VALUES (N'KHTX', N'Khách hàng thường xuyên', N'', 1)
INSERT [dbo].[LOAIKHACHHANG] ([MaLoaiKhachHang], [TenLoaiKhachHang], [GhiChu], [TinhTrang]) VALUES (N'KHVL', N'Khách hàng vãng lai', N'', 1)
INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [TenNguoiDung], [MatKhau], [TinhTrang], [NhoMatKhau], [MaNhanVien]) VALUES (N'US000001', N'admin', N'7CC3AC058E8DA675476', 1, 0, N'NV000001')
INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [TenNguoiDung], [MatKhau], [TinhTrang], [NhoMatKhau], [MaNhanVien]) VALUES (N'US000002', N'duynguyen', N'duynguyen', 1, 1, NULL)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000001', N'Công ty CP Minh An', NULL, N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000002', N'Công ty MINH TÍN', N'Q8', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000003', N'Công ty ESACO', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000004', N'VŨ TOÀN THIỆN', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000005', N'Công ty TNHH TMDV Sao Nam An', N'27/3 Kinh Dương Vương, P12, Q6, TPHCM', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000006', N'Công ty TNHH Biển Bạc', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000007', N'Tân Phát', N'140/11 Lý Thường Kiệt, P7, Q10, HCM', N'KV000001', N'0822300043', N'0918053088', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000008', N'Công ty CP TM DV Thiết Bị Giám Sát Bảo Toàn', N'30D.08 D,300 Bến Chương Dương, P.Cầu Kho, Q.1, HCM', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000009', N'Công ty TNHH TM DV Minh Nhãn', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000010', N'Công ty Đại Minh', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000011', N'Linh kiện vi tính Tân Phát', N'140/11 Lý Thường Kiệt, P7, Q. Gò Vâp', N'KV000001', N'0918053088', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000012', N'Công ty  TNHH Đồng Bằng', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000013', N'Công ty TNHH TMDV Truyền Thông Mặt Trời', N'218B/D18C Nguyễn Trãi, Q.1, TP.HCM', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000014', N'Mua lẻ', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000015', N'Cty TNHH Thương mại KT Tin Học Anh Ngọc', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000016', N'Công ty CP Thế Giới Di Động', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000017', N'Công ty TNHH TM TC Samsung', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000018', N'Công ty CP Quốc tế Viễn Tín', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000019', N'Công ty CP TM Công Nghệ Điện Tử Viễn Thông TES', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000020', N'Công ty CP Quốc tế Việt Khang', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000021', N'Vi Khang Trade Service Equeipment Co.LTD', N'16-01A, Tòa H3 Hoàng Diệu, Q.4, HCM', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000022', N'CN Công ty TNHH Vĩnh Tín', N'213 Hoàng Văn Thụ, P.8, Q.Phú Nhuận, TP.HCM', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000023', N'Công ty TNHH TM Phát triển Kỹ Thuật', N'16 Nguyễn Cư Trinh, P.Nguyễn Cư Trinh, Q1, TPHCM', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000024', N'Công ty Huyền Vũ', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000025', N'Công ty MINH NGỌC', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000026', N'Công ty TNHH ĐỒNG BẰNG', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000027', N'Công ty CP TM DV ABS', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000028', N'Đẳng cấp digital ', N'211 Quang Trung, P.10, Q. Gò Vấp', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000029', N'Công ty An Việt', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000030', N'Công ty TNHH TM DV Gia Bảo', N'SS1P Hồng Lĩnh, P.15, Q.10, HCM', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000031', N'D.F.S Technology co.ltd', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000032', N'Công ty CP Công Nghệ An Nhiên', N'43B Trần Khắc Chân, P.15, Q.PN,  TP.HCM', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000033', N'Công ty CP Công Nghệ Quốc Việt', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000034', N'Công ty TNHH TMDV Nguyên Bảo', N'126 Lý Thường Kiệt, P.7, Q.10', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000035', N'Công ty CP Công Nghệ Rồng Đông Dương', N'824/1 Sư Vạn Hạnh, P.13, Q.10, TP.HCM', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000036', N'Cty CP SX XNK HDC', N'140 Nguyễn Đình Chính, P.8, Q.Phú Nhuận', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000037', N'Cty TNHH TM XL Điện Cao Trần', N'23 Trần Phú, P.4, Q.5, TP HCM', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000038', N'Công ty TNHH Ứng Dụng Bản Đồ Việt', N'160 Trần Bình Trọng, P.3, Q.5, HCM', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000039', N'Công ty Nhà An Toàn', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000040', N'Công ty TNHH TMDV Sao Việt', N'Tầng 5 tòa nhà Lotteria, 298 Cầu Giấy, Hà Nội', N'KV000002', N'08.35897.313', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000041', N'Công ty Thảo Việt', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000042', N'Cửa hàng 35D Computer', N'140/8 Lý Thường Kiệt, P.7, Q.10, TP.HCM', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000043', N'Công ty Phúc Bình', NULL, N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000044', N'Công ty CP Thiết Bị Siêu Thị Vinatech', N'66 Nguyễn Hữu Dật, P.Tây Thạnh, Tân Phú', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000045', N'Công ty TNHH TMDV Công Nghệ Đại Hàn', N'823 Võ Văn Kiệt, P.5, Q.5, TP.HCM', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000046', N'Công ty TNHH Giải Pháp Thiên An', N'195/28 Đường D1, P.25, Bình Thạnh, HCM', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000047', N'Công ty CP Phân Phối Điện Tử JVS', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000048', N'Công ty Bảo Thắng - Hải Phòng', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000049', N'Công ty Hàn Việt', NULL, N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000050', N'Đẳng cấp Kỹ Thuật Số', N'164 Nguyễn Phúc Nguyên, P9, Q3', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000051', N'Trung tâm kinh doanh di động BBMobile', N'Số 6 - Ngõ 178 - Tây sơn - Đống đa - Hà Nội', N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000052', N'Công ty OBC', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000053', N'Công ty TNHH TM DL XD Thạnh Xuân', N'182 Đường TX22, P.Thạnh Xuân, Q.12', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000054', N'Công ty TNHH Dịch Vụ Công Nghệ Toàn Cầu', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000055', N'Công ty TNHH Mỹ Thuật và Quảng Đất Sáng Tạo', N'024 Lô C2, Đường Số 45, P.6, Q.4, TP.HCM', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000056', N'Công ty TNHH Thương mại Quốc Tế HPT Việt Nam', NULL, N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000057', N'Công ty CP Công Nghệ DSS Việt Nam', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NCC000058', N'SETRUS-CT TNHH Mỹ Thuật TT & QC Đất Sáng tạo', N'024 Lô C2, đường số 45, P.6, Q.4', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP000046', N'Kh trả hàng', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0001', N'Công ty TNHH Máy văn phòng Minh Tân', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0002', N'Công ty TNHH MTV Thiên An Phát', NULL, N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0003', N'Công ty TNHH Tư Vấn Đầu Tư ANFA', NULL, N'KV000003', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0004', N'Công ty TNHH MTV TM và DV Sóng Nhạc', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0005', N'Công ty Cổ Phần Biển Bạc', NULL, N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0006', N'CN CT TNHH Phát Triển Công Nghệ Điện Tử Bình Anh', NULL, N'KV000003', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0007', N'Công ty TNHH TMDV Công Nghệ Chí Cường', NULL, N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0008', N'Công ty TNHH TM Báo Cháy Báo Động Đa Kao', NULL, N'KV000003', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0009', N'Công ty TNHH TMDV Công Nghệ EBS', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0010', N'Công ty TNHH TMDV XNK HPT Việt Nam', NULL, N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0011', N'Công ty TNHH Đầu Tư TM và Dịch Vụ Hưng Việt', NULL, N'KV000003', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0012', N'Công ty TNHH Kỹ Thuật Lê Hoàng', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0013', N'Công ty CP SX TM & DV tin học xây dựng NaNo', NULL, N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0014', N'Công ty Cổ Phần Đầu Tư Phát Triển Ngọc Phát', NULL, N'KV000003', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0015', N'Công ty TNHH Nhật Nam', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0016', N'Công ty Cổ Phần Phân Phối Tân Niềm Tin', NULL, N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0017', N'Công ty TNHH PA Việt Nam', NULL, N'KV000003', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0018', N'Công ty Cổ Phần TM SX Phước Nhân', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0019', N'Công ty TNHH MTV Quản trị mạng Quang Phát', NULL, N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0020', N'Công ty TNHH SECOM', NULL, N'KV000003', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0021', N'CN tại TP HCM- Công ty Cổ Phần Máy Tính Tầm Nhìn', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0022', N'Công ty TNHH Công nghệ Tân Quân', NULL, N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0023', N'Công ty TNHH Thương mại T.C', NULL, N'KV000003', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0024', N'Công ty TNHH TMDV T.D.N', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0025', N'Công ty TNHH Viễn Thông Trần Lập', NULL, N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0026', N'CT TNHH TM DV Tin học và Viễn thông Trường Tiến', NULL, N'KV000003', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0027', N'Công ty TNHH Sản Xuất TM Kỹ Thuật Trung Đông', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0028', N'Công ty TNHH Công Nghệ Thông Tin An Phát', NULL, N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0029', N'Công ty CP Vạn Xuân', NULL, N'KV000003', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0030', N'Công ty TNHH TMDV Vĩnh Vĩnh Hằng', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0031', N'Nhập khẩu', NULL, N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0032', N'Cty Thịnh Thiên Ngân', NULL, N'KV000003', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0033', N'Công ty VIETENGINEERING', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0034', N'Cty Đông Dương', NULL, N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0035', N'Cty Đại Dương', NULL, N'KV000003', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0036', N'Cty Vĩnh An', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0037', N'Cty Kim Đạt', NULL, N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0038', N'Cty Chuyên Việt', NULL, N'KV000003', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0039', N'Công ty Đại An', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0040', N'Công ty Lê Phát', NULL, N'KV000002', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0041', N'Công ty Rồng Vàng', NULL, N'KV000003', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0042', N'Công ty Đức Long', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0043', N'Công ty Thiên Nhãn', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0044', N'Khoa Icare', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0045', N'Công ty VIệt Map', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0046', N'Công ty TNHH TMDV Nam Phú', N'189A Lý Thường Kiệt, P7, Quận 11 Tp.Hcm', N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0047', N'Chị Vân Anh Hóc Môn', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0048', N'Cty TNHH CÔNG NGHỆ ĐIỆN TỬ THANH SƠN', N'50 Ngô Quyền P.5 Quận 10', N'KV000001', N'0839571004', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [KhuVuc], [DienThoai], [Fax], [Email], [Website], [MaSoThue], [SoTaiKhoan], [NganHang], [NoHienTai], [TinhTrang]) VALUES (N'NPP0049', N'Hàng cũ', NULL, N'KV000001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [Emai], [DienThoai], [BoPhan], [NguoiQuanLi], [TinhTrang]) VALUES (N'NV000001', N'Nguyễn Thị Minh  Huệ', NULL, NULL, N'huenguyen@hptvn.com', N'0946 980 408', N'KD', NULL, 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [Emai], [DienThoai], [BoPhan], [NguoiQuanLi], [TinhTrang]) VALUES (N'NV000002', N'Phan Quang Thông', N'Phó Giám Ðốc', NULL, N'quangthong@hptvn.com', N'0946 980 409', N'KD', NULL, 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [Emai], [DienThoai], [BoPhan], [NguoiQuanLi], [TinhTrang]) VALUES (N'NV000003', N'Nguyễn Hoàng Dũng', N'TP Kỹ Thuật', NULL, N'hoangdung@hptvn.com', N'0946 980 407', N'KTH', NULL, 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [Emai], [DienThoai], [BoPhan], [NguoiQuanLi], [TinhTrang]) VALUES (N'NV000004', N'Vũ Anh Tuấn', N'Giám Ðốc', NULL, N'director@hptvn.com', N'0909 668 443', N'GD', NULL, 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [Emai], [DienThoai], [BoPhan], [NguoiQuanLi], [TinhTrang]) VALUES (N'NV000005', N'Huỳnh Thị Ngọc Lãnh', N'Nhân viên', NULL, N'ketoan@hptvn.com', N'0914 181 101', N'KT', NULL, 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [Emai], [DienThoai], [BoPhan], [NguoiQuanLi], [TinhTrang]) VALUES (N'NV000006', N'Phạm Bảo Trung', N'Nhân viên', NULL, NULL, N'01207 512 093', N'KTH', N'NV000003', 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [Emai], [DienThoai], [BoPhan], [NguoiQuanLi], [TinhTrang]) VALUES (N'NV000007', N'Phạm Thành Sơn', N'Nhân Viên', NULL, NULL, N'0908 270 382', N'KTH', N'NV000003', 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [Emai], [DienThoai], [BoPhan], [NguoiQuanLi], [TinhTrang]) VALUES (N'NV000008', N'Huỳnh Ngọc Trung', N'Nhân Viên', NULL, NULL, N'01689 977 218', N'KTH', N'NV000003', 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [Emai], [DienThoai], [BoPhan], [NguoiQuanLi], [TinhTrang]) VALUES (N'NV000009', N'Đoàn Thị Thu Thảo', N'Nhân Viên', NULL, N'thaodoan@hptvn.com', N'01668 777 006', N'KT', NULL, 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [Emai], [DienThoai], [BoPhan], [NguoiQuanLi], [TinhTrang]) VALUES (N'NV000010', N'Mai Văn Thái', NULL, NULL, NULL, NULL, N'GD', NULL, 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [Emai], [DienThoai], [BoPhan], [NguoiQuanLi], [TinhTrang]) VALUES (N'NV000011', N'Nguyễn Thị Thu Trang', N'Nhân viên', NULL, NULL, NULL, N'KD', NULL, 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [Emai], [DienThoai], [BoPhan], [NguoiQuanLi], [TinhTrang]) VALUES (N'NV000012', N'Nguyễn Huỳnh Phước Đức', NULL, NULL, NULL, NULL, N'KD', NULL, 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [Emai], [DienThoai], [BoPhan], [NguoiQuanLi], [TinhTrang]) VALUES (N'NV000013', N'Nguyễn Văn Viết  Sỹ', NULL, NULL, NULL, NULL, N'KTH', NULL, 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [Emai], [DienThoai], [BoPhan], [NguoiQuanLi], [TinhTrang]) VALUES (N'NV000014', N'Nguyễn Duy trung Chiến', NULL, NULL, NULL, NULL, N'KTH', NULL, 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [Emai], [DienThoai], [BoPhan], [NguoiQuanLi], [TinhTrang]) VALUES (N'NV000015', N'Nguyễn Đức Việt', NULL, NULL, NULL, NULL, N'GD', NULL, 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [Emai], [DienThoai], [BoPhan], [NguoiQuanLi], [TinhTrang]) VALUES (N'NV000016', N'Vũ Kim Nhung', NULL, N'Tầng 5 Tòa nhà 14/90 Yên Lạc, Vĩnh Tuy, Hà Nội', NULL, NULL, N'KD', NULL, 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [Emai], [DienThoai], [BoPhan], [NguoiQuanLi], [TinhTrang]) VALUES (N'NV000017', N'Chung Thị Bích Phượng', NULL, NULL, NULL, NULL, N'GD', NULL, 1)
INSERT [dbo].[NHOMHANGHOA] ([MaNhomHang], [TenNhomHang], [GhiChu], [TinhTrang]) VALUES (N'ANS', N'An ninh siêu thị', N'', 1)
INSERT [dbo].[NHOMHANGHOA] ([MaNhomHang], [TenNhomHang], [GhiChu], [TinhTrang]) VALUES (N'BAT', N'Báo trộm, báo cháy', N'', 1)
INSERT [dbo].[NHOMHANGHOA] ([MaNhomHang], [TenNhomHang], [GhiChu], [TinhTrang]) VALUES (N'CAM', N'Camera quan sát', N'', 1)
INSERT [dbo].[NHOMHANGHOA] ([MaNhomHang], [TenNhomHang], [GhiChu], [TinhTrang]) VALUES (N'CARCAM', N'Camera hành trình', N'', 1)
INSERT [dbo].[NHOMHANGHOA] ([MaNhomHang], [TenNhomHang], [GhiChu], [TinhTrang]) VALUES (N'CHA', N'Máy chấm công', N'', 1)
INSERT [dbo].[NHOMHANGHOA] ([MaNhomHang], [TenNhomHang], [GhiChu], [TinhTrang]) VALUES (N'CHM', N'Chuông cửa màn hình', N'', 1)
INSERT [dbo].[NHOMHANGHOA] ([MaNhomHang], [TenNhomHang], [GhiChu], [TinhTrang]) VALUES (N'DAC', N'Dây cáp', N'', 1)
INSERT [dbo].[NHOMHANGHOA] ([MaNhomHang], [TenNhomHang], [GhiChu], [TinhTrang]) VALUES (N'DAG', N'Đầu ghi', N'', 1)
INSERT [dbo].[NHOMHANGHOA] ([MaNhomHang], [TenNhomHang], [GhiChu], [TinhTrang]) VALUES (N'KIS', N'Kiểm soát ra vào', N'', 1)
INSERT [dbo].[NHOMHANGHOA] ([MaNhomHang], [TenNhomHang], [GhiChu], [TinhTrang]) VALUES (N'NH000001', N'Hàng cũ', N'Hàng cũ bảo hành', 1)
INSERT [dbo].[NHOMHANGHOA] ([MaNhomHang], [TenNhomHang], [GhiChu], [TinhTrang]) VALUES (N'NH000002', N'Secure display', N'', 1)
INSERT [dbo].[NHOMHANGHOA] ([MaNhomHang], [TenNhomHang], [GhiChu], [TinhTrang]) VALUES (N'OCU', N'Ổ cứng', N'', 1)
INSERT [dbo].[NHOMHANGHOA] ([MaNhomHang], [TenNhomHang], [GhiChu], [TinhTrang]) VALUES (N'TBK', N'Thiết bị khác', N'', 1)
INSERT [dbo].[NHOMHANGHOA] ([MaNhomHang], [TenNhomHang], [GhiChu], [TinhTrang]) VALUES (N'TBN', N'Thiết bị hội nghị', N'', 1)
INSERT [dbo].[NHOMHANGHOA] ([MaNhomHang], [TenNhomHang], [GhiChu], [TinhTrang]) VALUES (N'TBV', N'Thiết bị định vị', N'', 1)
INSERT [dbo].[NHOMHANGHOA] ([MaNhomHang], [TenNhomHang], [GhiChu], [TinhTrang]) VALUES (N'TDKL', N'Tay dò kim loại', N'', 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'Chức năng', N'Mua hàng', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'Danh mục', N'Bộ phận', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'Danh mục', N'Đơn vị tính', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'Danh mục', N'Hàng hóa', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'Danh mục', N'khách hàng', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'Danh mục', N'Kho hàng', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'Danh mục', N'Khu vực', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'Danh mục', N'Nhà cung cấp', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'Danh mục', N'Nhân viên', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'Danh mục', N'Nhóm hàng', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'Danh mục', N'Tỷ giá', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'Hệ thống', N'Backup', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'Hệ thống', N'Đăng nhập', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'Hệ thống', N'Đổi mật khẩu', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'Hệ thống', N'Nhật ký hệ thống', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'Hệ thống', N'Phân quyền', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'Hệ thống', N'Phục hồi', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'Hệ thống', N'Thông tin', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'view', N'Bán hàng', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'view', N'Báo cáo', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'view', N'Chuyển kho', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'view', N'Thu tiền', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'view', N'Tồn kho', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PHANQUYEN] ([TenNhom], [TenChucNang], [MaNguoiDung], [ChoPhepThem], [ChoPhepXoa], [ChoPhepSua], [ChoPhepTruyCap], [ChoPhepIn], [TinhTrang]) VALUES (N'view', N'Trả tiền', N'US000001', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[TYGIA] ([MaTienTe], [TenTienTe], [TyGiaQuyDoi], [TinhTrang]) VALUES (N'EUR', N'Đồng tiền chung EU', 17988.0000, 1)
INSERT [dbo].[TYGIA] ([MaTienTe], [TenTienTe], [TyGiaQuyDoi], [TinhTrang]) VALUES (N'GBP', N'Bang Anh', 26149.0000, 1)
INSERT [dbo].[TYGIA] ([MaTienTe], [TenTienTe], [TyGiaQuyDoi], [TinhTrang]) VALUES (N'USD', N'Dola My', 20000.0000, 1)
INSERT [dbo].[TYGIA] ([MaTienTe], [TenTienTe], [TyGiaQuyDoi], [TinhTrang]) VALUES (N'VND', N'Việt Nam Đồng', 1.0000, 1)
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_NGUOIDUNG]    Script Date: 1/5/2017 11:12:06 PM ******/
ALTER TABLE [dbo].[NGUOIDUNG] ADD  CONSTRAINT [UK_NGUOIDUNG] UNIQUE NONCLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHITIETKHO]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETKHO_HANGHOA] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HANGHOA] ([MaHangHoa])
GO
ALTER TABLE [dbo].[CHITIETKHO] CHECK CONSTRAINT [FK_CHITIETKHO_HANGHOA]
GO
ALTER TABLE [dbo].[CHITIETKHO]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETKHO_KHOHANG] FOREIGN KEY([MaKhoHang])
REFERENCES [dbo].[KHOHANG] ([MaKhoHang])
GO
ALTER TABLE [dbo].[CHITIETKHO] CHECK CONSTRAINT [FK_CHITIETKHO_KHOHANG]
GO
ALTER TABLE [dbo].[CHITIETPHIEUBANHANG]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUBANHANG_DONVITINH] FOREIGN KEY([DonVi])
REFERENCES [dbo].[DONVITINH] ([MaDonVi])
GO
ALTER TABLE [dbo].[CHITIETPHIEUBANHANG] CHECK CONSTRAINT [FK_CHITIETPHIEUBANHANG_DONVITINH]
GO
ALTER TABLE [dbo].[CHITIETPHIEUBANHANG]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUBANHANG_HANGHOA] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HANGHOA] ([MaHangHoa])
GO
ALTER TABLE [dbo].[CHITIETPHIEUBANHANG] CHECK CONSTRAINT [FK_CHITIETPHIEUBANHANG_HANGHOA]
GO
ALTER TABLE [dbo].[CHITIETPHIEUBANHANG]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUBANHANG_PHIEUBANHANG] FOREIGN KEY([MaPhieuBan])
REFERENCES [dbo].[PHIEUBANHANG] ([MaPhieuBan])
GO
ALTER TABLE [dbo].[CHITIETPHIEUBANHANG] CHECK CONSTRAINT [FK_CHITIETPHIEUBANHANG_PHIEUBANHANG]
GO
ALTER TABLE [dbo].[CHITIETPHIEUCHUYENKHO]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUCHUYENKHO_DONVITINH] FOREIGN KEY([DonVi])
REFERENCES [dbo].[DONVITINH] ([MaDonVi])
GO
ALTER TABLE [dbo].[CHITIETPHIEUCHUYENKHO] CHECK CONSTRAINT [FK_CHITIETPHIEUCHUYENKHO_DONVITINH]
GO
ALTER TABLE [dbo].[CHITIETPHIEUCHUYENKHO]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUCHUYENKHO_HANGHOA] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HANGHOA] ([MaHangHoa])
GO
ALTER TABLE [dbo].[CHITIETPHIEUCHUYENKHO] CHECK CONSTRAINT [FK_CHITIETPHIEUCHUYENKHO_HANGHOA]
GO
ALTER TABLE [dbo].[CHITIETPHIEUCHUYENKHO]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUCHUYENKHO_PHIEUCHUYENKHO] FOREIGN KEY([MaPhieuChuyen])
REFERENCES [dbo].[PHIEUCHUYENKHO] ([MaPhieuChuyen])
GO
ALTER TABLE [dbo].[CHITIETPHIEUCHUYENKHO] CHECK CONSTRAINT [FK_CHITIETPHIEUCHUYENKHO_PHIEUCHUYENKHO]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAPHANG]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAPHANG_DONVITINH] FOREIGN KEY([DonVi])
REFERENCES [dbo].[DONVITINH] ([MaDonVi])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAPHANG] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAPHANG_DONVITINH]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAPHANG]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAPHANG_HANGHOA] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HANGHOA] ([MaHangHoa])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAPHANG] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAPHANG_HANGHOA]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAPHANG]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAPHANG_PHIEUNHAPHANG] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PHIEUNHAPHANG] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAPHANG] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAPHANG_PHIEUNHAPHANG]
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_HANGHOA_DONVITINH] FOREIGN KEY([DonVi])
REFERENCES [dbo].[DONVITINH] ([MaDonVi])
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [FK_HANGHOA_DONVITINH]
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_HANGHOA_NHACUNGCAP] FOREIGN KEY([NhaCungCap])
REFERENCES [dbo].[NHACUNGCAP] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [FK_HANGHOA_NHACUNGCAP]
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_HANGHOA_NHOMHANGHOA] FOREIGN KEY([NhomHang])
REFERENCES [dbo].[NHOMHANGHOA] ([MaNhomHang])
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [FK_HANGHOA_NHOMHANGHOA]
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_HANGHOA_TYGIA] FOREIGN KEY([LoaiTien])
REFERENCES [dbo].[TYGIA] ([MaTienTe])
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [FK_HANGHOA_TYGIA]
GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD  CONSTRAINT [FK_KHACHHANG_KHUVUC] FOREIGN KEY([KhuVuc])
REFERENCES [dbo].[KHUVUC] ([MaKhuVuc])
GO
ALTER TABLE [dbo].[KHACHHANG] CHECK CONSTRAINT [FK_KHACHHANG_KHUVUC]
GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD  CONSTRAINT [FK_KHACHHANG_LOAIKHACHHANG] FOREIGN KEY([LoaiKhachHang])
REFERENCES [dbo].[LOAIKHACHHANG] ([MaLoaiKhachHang])
GO
ALTER TABLE [dbo].[KHACHHANG] CHECK CONSTRAINT [FK_KHACHHANG_LOAIKHACHHANG]
GO
ALTER TABLE [dbo].[KHOHANG]  WITH CHECK ADD  CONSTRAINT [FK_KHOHANG_NHANVIEN] FOREIGN KEY([NguoiQuanLi])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[KHOHANG] CHECK CONSTRAINT [FK_KHOHANG_NHANVIEN]
GO
ALTER TABLE [dbo].[KHOHANG]  WITH CHECK ADD  CONSTRAINT [FK_KHOHANG_NHANVIEN1] FOREIGN KEY([NguoiLienHe])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[KHOHANG] CHECK CONSTRAINT [FK_KHOHANG_NHANVIEN1]
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUNG_NHANVIEN] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [FK_NGUOIDUNG_NHANVIEN]
GO
ALTER TABLE [dbo].[NHACUNGCAP]  WITH CHECK ADD  CONSTRAINT [FK_NHACUNGCAP_KHUVUC] FOREIGN KEY([KhuVuc])
REFERENCES [dbo].[KHUVUC] ([MaKhuVuc])
GO
ALTER TABLE [dbo].[NHACUNGCAP] CHECK CONSTRAINT [FK_NHACUNGCAP_KHUVUC]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_BOPHAN] FOREIGN KEY([BoPhan])
REFERENCES [dbo].[BOPHAN] ([MaBoPhan])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_BOPHAN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_NHANVIEN] FOREIGN KEY([NguoiQuanLi])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_NHANVIEN]
GO
ALTER TABLE [dbo].[PHANQUYEN]  WITH CHECK ADD  CONSTRAINT [FK_PHANQUYEN_NGUOIDUNG] FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NGUOIDUNG] ([MaNguoiDung])
GO
ALTER TABLE [dbo].[PHANQUYEN] CHECK CONSTRAINT [FK_PHANQUYEN_NGUOIDUNG]
GO
ALTER TABLE [dbo].[PHIEUBANHANG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUBANHANG_KHACHHANG] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PHIEUBANHANG] CHECK CONSTRAINT [FK_PHIEUBANHANG_KHACHHANG]
GO
ALTER TABLE [dbo].[PHIEUBANHANG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUBANHANG_KHOHANG] FOREIGN KEY([KhoXuat])
REFERENCES [dbo].[KHOHANG] ([MaKhoHang])
GO
ALTER TABLE [dbo].[PHIEUBANHANG] CHECK CONSTRAINT [FK_PHIEUBANHANG_KHOHANG]
GO
ALTER TABLE [dbo].[PHIEUBANHANG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUBANHANG_NHANVIEN] FOREIGN KEY([NhanVienBan])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUBANHANG] CHECK CONSTRAINT [FK_PHIEUBANHANG_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUCHUYENKHO_KHOHANG] FOREIGN KEY([KhoXuat])
REFERENCES [dbo].[KHOHANG] ([MaKhoHang])
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO] CHECK CONSTRAINT [FK_PHIEUCHUYENKHO_KHOHANG]
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUCHUYENKHO_KHOHANG1] FOREIGN KEY([KhoNhap])
REFERENCES [dbo].[KHOHANG] ([MaKhoHang])
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO] CHECK CONSTRAINT [FK_PHIEUCHUYENKHO_KHOHANG1]
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUCHUYENKHO_NHANVIEN] FOREIGN KEY([NguoiChuyen])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO] CHECK CONSTRAINT [FK_PHIEUCHUYENKHO_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUCHUYENKHO_NHANVIEN1] FOREIGN KEY([NguoiNhan])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO] CHECK CONSTRAINT [FK_PHIEUCHUYENKHO_NHANVIEN1]
GO
ALTER TABLE [dbo].[PHIEUNHAPHANG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAPHANG_KHOHANG] FOREIGN KEY([KhoNhap])
REFERENCES [dbo].[KHOHANG] ([MaKhoHang])
GO
ALTER TABLE [dbo].[PHIEUNHAPHANG] CHECK CONSTRAINT [FK_PHIEUNHAPHANG_KHOHANG]
GO
ALTER TABLE [dbo].[PHIEUNHAPHANG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAPHANG_NHACUNGCAP] FOREIGN KEY([NhaCungCap])
REFERENCES [dbo].[NHACUNGCAP] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[PHIEUNHAPHANG] CHECK CONSTRAINT [FK_PHIEUNHAPHANG_NHACUNGCAP]
GO
ALTER TABLE [dbo].[PHIEUNHAPHANG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAPHANG_NHANVIEN] FOREIGN KEY([NhanVienNhap])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUNHAPHANG] CHECK CONSTRAINT [FK_PHIEUNHAPHANG_NHANVIEN]
GO
/****** Object:  StoredProcedure [dbo].[KiemTraDangNhap]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KiemTraDangNhap] @manguoidung nvarchar(20), @matkhau nvarchar(20), @check char output
as
	if exists(select * from NGUOIDUNG nd where nd.MaNguoiDung = @manguoidung and nd.MatKhau = @matkhau)
		set @check = 'Y'
	else
		set @check = 'N'

GO
/****** Object:  StoredProcedure [dbo].[LayMatKhau]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayMatKhau] @manguoidung nvarchar(20), @matkhau nvarchar(20) output
as
begin
	select @matkhau = nd.MatKhau from NGUOIDUNG nd where nd.MaNguoiDung = @manguoidung and nd.NhoMatKhau = '1'
end

GO
/****** Object:  StoredProcedure [dbo].[LoadDSNguoiDung]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoadDSNguoiDung]
as
	select * from NGUOIDUNG

GO
/****** Object:  StoredProcedure [dbo].[LuuThongTinDangNhap]    Script Date: 1/5/2017 11:12:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LuuThongTinDangNhap] @manguoidung varchar(20)
as
	update NGUOIDUNG set NhoMatKhau = 1
	where MaNguoiDung = @manguoidung

GO
