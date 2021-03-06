USE [QuanLyBanHang]
GO
/****** Object:  StoredProcedure [dbo].[GiamChiTietKho]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GiamChiTietKho]
@MaKhoHang varchar(20),
@MaHangHoa varchar(20),
@SoLuong int
as
	update CHITIETKHO set SoLuong = SoLuong - @SoLuong where MaKhoHang = @MaKhoHang and MaHangHoa = @MaHangHoa

GO
/****** Object:  StoredProcedure [dbo].[KiemTraDangNhap]    Script Date: 1/15/2017 4:24:44 PM ******/
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
/****** Object:  StoredProcedure [dbo].[LayMatKhau]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayMatKhau] @manguoidung nvarchar(20)
as
begin
	select nd.MatKhau from NGUOIDUNG nd where nd.MaNguoiDung = @manguoidung and nd.NhoMatKhau = '1'
end

GO
/****** Object:  StoredProcedure [dbo].[LoadDSHangHoaBan]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoadDSHangHoaBan]
as
	select hh.* from HANGHOA hh, (select distinct(k.MaHangHoa) as MaHangHoa from CHITIETKHO k) as kh
	where hh.MaHangHoa = kh.MaHangHoa

GO
/****** Object:  StoredProcedure [dbo].[LoadDSNguoiDung]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoadDSNguoiDung]
as
	select * from NGUOIDUNG

GO
/****** Object:  StoredProcedure [dbo].[LoadDSPhanQuyen]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoadDSPhanQuyen] @MaNguoiDung varchar(20)
as
	select * from PHANQUYEN where MaNguoiDung = @MaNguoiDung

GO
/****** Object:  StoredProcedure [dbo].[LuuThongTinDangNhap]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LuuThongTinDangNhap] @manguoidung varchar(20)
as
	update NGUOIDUNG set NhoMatKhau = 1
	where MaNguoiDung = @manguoidung

GO
/****** Object:  StoredProcedure [dbo].[SuaBoPhan]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SuaBoPhan]
@MaBoPhan varchar(20),
@TenBoPhan nvarchar(20),
@GhiChu nvarchar(50),
@TinhTrang nvarchar(50)
as
	update BOPHAN set TenBoPhan=@TenBoPhan ,GhiChu=@GhiChu ,TinhTrang=@TinhTrang 
	where MaBoPhan=@MaBoPhan

GO
/****** Object:  StoredProcedure [dbo].[SuaChiTietKho]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SuaChiTietKho]
@MaKhoHang varchar(20),
@MaHangHoa varchar(20),
@SoLuong int
as
	update CHITIETKHO set SoLuong=@SoLuong
	where MaKhoHang=@MaKhoHang and MaHangHoa=@MaHangHoa

GO
/****** Object:  StoredProcedure [dbo].[SuaChiTietPhieuBanHang]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SuaChiTietPhieuBanHang]
@MaPhieuBan varchar(20),
@MaHangHoa varchar(20),
@DonVi varchar(20),
@SoLuong int,
@DonGia money,
@ChietKhau float
as
	update CHITIETPHIEUBANHANG set MaHangHoa=@MaHangHoa,donvi=@DonVi,SoLuong=@SoLuong,DonGia=@DonGia,ChietKhau=@ChietKhau
	where MaPhieuBan=@MaPhieuBan

GO
/****** Object:  StoredProcedure [dbo].[SuaChiTietPhieuChuyenKho]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SuaChiTietPhieuChuyenKho]
@MaPhieuChuyen varchar(20),
@MaHangHoa varchar(20),
@DonVi varchar(20),
@SoLuong int,
@DonGia money
as
	update CHITIETPHIEUCHUYENKHO set MaHangHoa=@MaHangHoa,DonVi=@DonVi,SoLuong=@SoLuong,DonGia=@DonGia
	where MaPhieuChuyen=@MaPhieuChuyen

GO
/****** Object:  StoredProcedure [dbo].[SuaChiTietPhieuNhapHang]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SuaChiTietPhieuNhapHang]
@MaPhieuNhap varchar(20),
@MaHangHoa varchar(20),
@DonVi varchar(20),
@SoLuong int,
@DonGia money,
@ChieuKhau float
as
	update CHITIETPHIEUNHAPHANG set donvi=@DonVi,SoLuong=@SoLuong,DonGia=@DonGia,ChietKhau=@ChieuKhau
	where MaPhieuNhap=@MaPhieuNhap and MaHangHoa=@MaHangHoa

GO
/****** Object:  StoredProcedure [dbo].[SuaDonViTinh]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SuaDonViTinh]
@MaDonVi varchar(20),
@TenDonVi nvarchar(20),
@GhiChu nvarchar(50),
@TinhTrang bit
as
	update DONVITINH set TenDonVi=@TenDonVi,GhiChu=@GhiChu,TinhTrang=@TinhTrang
	where MaDonVi=@MaDonVi

GO
/****** Object:  StoredProcedure [dbo].[SuaHangHoa]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SuaHangHoa]
@MaHangHoa varchar(20),
@TenHangHoa nvarchar(50),
@KieuHangHoa nvarchar(50),
@NhomHang varchar(20),
@MaVach varchar(50),
@DonVi varchar(20),
@XuatXu nvarchar(50),
@TonKhoToiThieu int,
@TonHienTai int,
@NhaCungCap varchar(20),
@GiaMua money,
@GiaBanLe money,
@GiaBanSi money,
@LoaiTien varchar(10),
@HinhAnh nvarchar(255),
@TinhTrang bit
as
	update HANGHOA set TenHangHoa=@TenHangHoa,KieuHangHoa=@KieuHangHoa,NhomHang=@NhomHang,MaVach=@MaVach,DonVi=@DonVi,XuatXu=@XuatXu,TonKhoToiThieu=@TonKhoToiThieu,TonHienTai=@TonHienTai,NhaCungCap=@NhaCungCap,GiaMua=@GiaMua,GiaBanLe=@GiaBanLe,GiaBanSi=@GiaBanSi,LoaiTien=@LoaiTien,HinhAnh=@HinhAnh,TinhTrang=@TinhTrang
	where MaHangHoa=@MaHangHoa

GO
/****** Object:  StoredProcedure [dbo].[SuaKhachHang]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaKhachHang]
	@MaKhachHang varchar(20), @TenKhachHang nvarchar(50),
	@NguoiLienHe nvarchar(50), @DiaChi nvarchar(50),
	@LoaiKhachHang varchar(20), @Khuvuc varchar(20),
	@DienThoai varchar(13), @Fax varchar(15), @Email varchar(20),
	@Website varchar(20), @MaSoThue varchar(20), @SoTaiKhoan varchar(20),
	@NganHang nvarchar(50), @TinhTrang bit
as
	delete from KHACHHANG where MaKhachHang = @MaKhachHang
	insert into KHACHHANG values(@MaKhachHang, @TenKhachHang, @NguoiLienHe, @DiaChi, @LoaiKhachHang, @Khuvuc, @DienThoai, @Fax, @Email, @Website, @MaSoThue, @SoTaiKhoan, @NganHang, @TinhTrang)
	

GO
/****** Object:  StoredProcedure [dbo].[SuaKhoHang]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	
create proc [dbo].[SuaKhoHang]	
@MaKhoHang	varchar(20),
@KiHieu	varchar(20)	,
@TenKhoHang	nvarchar(50)	,
@NguoiQuanLi	varchar(20)	,
@NguoiLienHe	varchar(20)	,
@DiaChi	nvarchar(50)	,
@DienThoai	varchar(13)	,
@Fax	varchar(15)	,
@Email	varchar(20)	,
@DienGiai	nvarchar(50)	,
@TinhTrang	bit	
as
	update KHOHANG set KiHieu=@KiHieu,TenKhoHang=@TenKhoHang,NguoiQuanLi=@NguoiQuanLi,NguoiLienHe=@NguoiLienHe,DiaChi=@DiaChi,DienThoai=@DienThoai,Fax=@Fax,Email=@Email,DienGiai=@DienGiai,TinhTrang=@TinhTrang
	where MaKhoHang=@MaKhoHang

GO
/****** Object:  StoredProcedure [dbo].[SuaKhuVuc]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaKhuVuc] @MaKhuVuc varchar(20), @TenKhuVuc nvarchar(50), @Ghichu nvarchar(50), @Tinhtrang bit
as
	update KHUVUC set TenKhuVuc = @TenKhuVuc, GhiChu = @Ghichu, TinhTrang = @Tinhtrang where MaKhuVuc = @MaKhuVuc 

GO
/****** Object:  StoredProcedure [dbo].[SuaLoaiKhachHang]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SuaLoaiKhachHang]
@MaLoaiKhachHang	varchar(20)	,
@TenLoaiKhachHang	nvarchar(50),
@GhiChu	nvarchar(50),
@TinhTrang	bit		
as
	update LOAIKHACHHANG set TenLoaiKhachHang=@TenLoaiKhachHang,GhiChu=@GhiChu,TinhTrang=@TinhTrang
	where MaLoaiKhachHang=@MaLoaiKhachHang

GO
/****** Object:  StoredProcedure [dbo].[SuaNguoiDung]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SuaNguoiDung]
@MaNguoiDung	varchar(20)	,
@TenNguoiDung	nvarchar(50)	,
@MatKhau	varchar(20)	,
@TinhTrang	bit	,
@NhoMatKhau	bit	,
@MaNhanVien	varchar(20)		
as
	update NGUOIDUNG set TenNguoiDung=@TenNguoiDung,MatKhau=@MatKhau,TinhTrang=@TinhTrang,NhoMatKhau=@NhoMatKhau,MaNhanVien=@MaNhanVien
	where MaNguoiDung=@MaNguoiDung

GO
/****** Object:  StoredProcedure [dbo].[SuaNhaCungCap]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SuaNhaCungCap]
@MaNhaCungCap	varchar(20)	,
@TenNhaCungCap	nvarchar(50)	,
@DiaChi	nvarchar(50)	,
@KhuVuc	varchar(20)	,
@DienThoai	varchar(13)	,
@Fax	varchar(20)	,
@Email	varchar(20)	,
@Website	varchar(20)	,
@MaSoThue	varchar(20)	,
@SoTaiKhoan	varchar(20)	,
@NganHang	nvarchar(50)	,
@NoHienTai	float	,
@TinhTrang	bit	
as
	update NHACUNGCAP set TenNhaCungCap=@TenNhaCungCap,DiaChi=@DiaChi,KhuVuc=@KhuVuc,DienThoai=@DienThoai,Fax=@Fax,Email=@Email,Website=@Website,MaSoThue=@MaSoThue,SoTaiKhoan=@SoTaiKhoan,NganHang=@NganHang,NoHienTai=@NoHienTai,TinhTrang=@TinhTrang
	where MaNhaCungCap=@MaNhaCungCap

GO
/****** Object:  StoredProcedure [dbo].[SuaNhanVien]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SuaNhanVien]
@MaNhanVien	varchar(20)	,
@TenNhanVien	nvarchar(50)	,
@ChucVu	nvarchar(50)	,
@DiaChi	nvarchar(50)	,
@Emai	varchar(20)	,
@DienThoai	varchar(13)	,
@BoPhan	varchar(20)	,
@NguoiQuanLi	varchar(20)	,
@TinhTrang	bit	
as
	update NHANVIEN set TenNhanVien=@TenNhanVien,ChucVu=@ChucVu,DiaChi=@DiaChi,Emai=@Emai,DienThoai=@DienThoai,BoPhan=@BoPhan,NguoiQuanLi=@NguoiQuanLi,TinhTrang=@TinhTrang
	where MaNhanVien=@MaNhanVien

GO
/****** Object:  StoredProcedure [dbo].[SuaNhatKyHeThong]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SuaNhatKyHeThong]
@MaNguoiDung	varchar(20)	,
@MayTinh	varchar(20),
@ThoiGian	datetime	,
@ChucNang	nvarchar(50),
@HanhDong	nvarchar(20)
as
	update NHATKYHETHONG set MayTinh=@MayTinh,ThoiGian=@ThoiGian,ChucNang=@ChucNang,HanhDong=@HanhDong
	where MaNguoiDung=@MaNguoiDung

GO
/****** Object:  StoredProcedure [dbo].[SuaNhomHangHoa]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SuaNhomHangHoa]
@MaNhomHang	varchar(20)	,
@TenNhomHang	nvarchar(50),
@GhiChu	nvarchar(50),
@TinhTrang	bit	
as
	update NHOMHANGHOA set TenNhomHang=@TenNhomHang,GhiChu=@GhiChu,TinhTrang=@TinhTrang
	where MaNhomHang=@MaNhomHang

GO
/****** Object:  StoredProcedure [dbo].[SuaPhanQuyen]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SuaPhanQuyen]
@TenNhom nvarchar(50),
@TenChucNang nvarchar(50),
@MaNguoiDung varchar(20),
@ChoPhepThem bit,
@ChoPhepXoa	bit,
@ChoPhepSua	bit,
@ChoPhepTruyCap	bit,
@ChoPhepIn bit,
@TinhTrang bit
as
	update PHANQUYEN set ChoPhepThem=@ChoPhepThem,ChoPhepXoa=@ChoPhepXoa,ChoPhepSua=@ChoPhepSua,ChoPhepTruyCap=@ChoPhepTruyCap,ChoPhepIn=@ChoPhepIn,TinhTrang=@TinhTrang
	where TenNhom=@TenNhom and TenChucNang=@TenChucNang and MaNguoiDung=@MaNguoiDung

GO
/****** Object:  StoredProcedure [dbo].[SuaPhieuBanHang]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SuaPhieuBanHang]
@MaPhieuBan	varchar(20)	,
@MaKhachHang	varchar(20)	,
@NgayBan	datetime	,
@NhanVienBan	varchar(20)	,
@KhoXuat	varchar(20)	,
@HinhThucThanhToan	nvarchar(50)	,
@TongTien	money	,
@TinhTrang	bit
as
	update PHIEUBANHANG set MaKhachHang=@MaKhachHang,NgayBan=@NgayBan,NhanVienBan=@NhanVienBan,KhoXuat=@KhoXuat,HinhThucThanhToan=@HinhThucThanhToan,TongTien=@TongTien,TinhTrang=@TinhTrang
	where MaPhieuBan=@MaPhieuBan

GO
/****** Object:  StoredProcedure [dbo].[SuaPhieuChuyenKho]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SuaPhieuChuyenKho]
@MaPhieuChuyen	varchar(20)	,
@NgayChuyen	datetime	,
@KhoXuat	varchar(20)	,
@KhoNhap	varchar(20)	,
@NguoiChuyen	varchar(20)	,
@NguoiNhan	varchar(20)	,
@GhiChu	nvarchar(50)	,
@TongTien	money	,
@TinhTrang	bit	
as
	update PHIEUCHUYENKHO set NgayChuyen=@NgayChuyen,KhoXuat=@KhoXuat,KhoNhap=@KhoNhap,NguoiChuyen=@NguoiChuyen,NguoiNhan=@NguoiNhan,GhiChu=@GhiChu,TongTien=@TongTien,TinhTrang=@TinhTrang
	where MaPhieuChuyen=@MaPhieuChuyen

GO
/****** Object:  StoredProcedure [dbo].[SuaPhieuNhapHang]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SuaPhieuNhapHang]
@MaPhieuNhap	varchar(20)	,
@NgayNhap	datetime	,
@NhanVienNhap	varchar(20)	,
@KhoNhap	varchar(20)	,
@HanThanhToan	datetime	,
@NhaCungCap	varchar(20)	,
@HinhThucThanhToan	nvarchar(50)	,
@TongTien	money	,
@TinhTrang	bit	
as
	update PHIEUNHAPHANG set NgayNhap=@NgayNhap,NhanVienNhap=@NhanVienNhap,KhoNhap=@KhoNhap,HanThanhToan=@HanThanhToan,HinhThucThanhToan=@HinhThucThanhToan,TongTien=@TongTien,TinhTrang=@TinhTrang
	where MaPhieuNhap=@MaPhieuNhap

GO
/****** Object:  StoredProcedure [dbo].[SuaTyGia]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SuaTyGia]
@MaTienTe	varchar(3),
@TenTienTe	nvarchar(50),
@TyGiaQuyDoi	money,
@TinhTrang	bit	
as
	update TYGIA set TenTienTe=@TenTienTe,TyGiaQuyDoi=@TyGiaQuyDoi,TinhTrang=@TinhTrang
	where MaTienTe=@MaTienTe

GO
/****** Object:  StoredProcedure [dbo].[ThemBoPhan]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemBoPhan]
@MaBoPhan varchar(20),
@TenBoPhan nvarchar(20),
@GhiChu nvarchar(50),
@TinhTrang bit
as
	insert into BOPHAN values(@MaBoPhan ,@TenBoPhan ,@GhiChu ,@TinhTrang)

GO
/****** Object:  StoredProcedure [dbo].[ThemChiTietKho]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemChiTietKho]
@MaKhoHang varchar(20),
@MaHangHoa varchar(20),
@SoLuong int
as
	if exists(select * from CHITIETKHO where MaKhoHang = @MaKhoHang and MaHangHoa = @MaHangHoa)
	begin
		update CHITIETKHO set SoLuong = SoLuong + @SoLuong where MaKhoHang = @MaKhoHang and MaHangHoa = @MaHangHoa
	end
	else
		insert into CHITIETKHO values(@MaKhoHang,@MaHangHoa,@SoLuong)

GO
/****** Object:  StoredProcedure [dbo].[ThemChiTietPhieuBanHang]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemChiTietPhieuBanHang]
@MaPhieuBan varchar(20),
@MaHangHoa varchar(20),
@DonVi varchar(20),
@SoLuong int,
@DonGia money,
@ChietKhau float
as
	insert into CHITIETPHIEUBANHANG values(@MaPhieuBan,@MaHangHoa,@DonVi,@SoLuong,@DonGia,@ChietKhau)

GO
/****** Object:  StoredProcedure [dbo].[ThemChiTietPhieuChuyenKho]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--CHITIETPHIEUCHUYENKHO
create proc [dbo].[ThemChiTietPhieuChuyenKho]
@MaPhieuChuyen varchar(20),
@MaHangHoa varchar(20),
@DonVi varchar(20),
@SoLuong int,
@DonGia money
as
	insert into CHITIETPHIEUCHUYENKHO values(@MaPhieuChuyen,@MaHangHoa,@DonVi,@SoLuong,@DonGia)

GO
/****** Object:  StoredProcedure [dbo].[ThemChiTietPhieuNhapHang]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemChiTietPhieuNhapHang]
@MaPhieuNhap varchar(20),
@MaHangHoa varchar(20),
@DonVi varchar(20),
@SoLuong int,
@DonGia money,
@ChietKhau float
as
	insert into CHITIETPHIEUNHAPHANG values(@MaPhieuNhap,@MaHangHoa,@DonVi,@SoLuong,@DonGia,@ChietKhau)

GO
/****** Object:  StoredProcedure [dbo].[ThemDonViTinh]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemDonViTinh]
@MaDonVi varchar(20),
@TenDonVi nvarchar(20),
@GhiChu nvarchar(50),
@TinhTrang bit
as
	insert into DONVITINH values(@MaDonVi,@TenDonVi,@GhiChu,@TinhTrang)

GO
/****** Object:  StoredProcedure [dbo].[ThemHangHoa]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--HANGHOA
create proc [dbo].[ThemHangHoa]
@MaHangHoa varchar(20),
@TenHangHoa nvarchar(50),
@KieuHangHoa nvarchar(50),
@NhomHang varchar(20),
@MaVach varchar(50),
@DonVi varchar(20),
@XuatXu nvarchar(50),
@TonKho int,
@TonHienTai int,
@NhaCungCap varchar(20),
@GiaMua money,
@GiaBanLe money,
@GiaBanSi money,
@LoaiTien varchar(10),
@HinhAnh nvarchar(255),
@TinhTrang bit
as
	insert into HANGHOA values(@MaHangHoa,@TenHangHoa,@KieuHangHoa,@NhomHang ,@MaVach,@DonVi ,@XuatXu,@TonKho,@TonHienTai ,@NhaCungCap,@GiaMua ,@GiaBanLe ,@GiaBanSi,@LoaiTien ,@HinhAnh,@TinhTrang)

GO
/****** Object:  StoredProcedure [dbo].[ThemKhachHang]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemKhachHang]
	@MaKhachHang varchar(20), @TenKhachHang nvarchar(50),
	@NguoiLienHe nvarchar(50), @DiaChi nvarchar(50),
	@LoaiKhachHang varchar(20), @Khuvuc varchar(20),
	@DienThoai varchar(13), @Fax varchar(15), @Email varchar(20),
	@Website varchar(20), @MaSoThue varchar(20), @SoTaiKhoan varchar(20),
	@NganHang nvarchar(50), @TinhTrang bit
as
	insert into KHACHHANG values(@MaKhachHang, @TenKhachHang, @NguoiLienHe, @DiaChi, @LoaiKhachHang, @Khuvuc, @DienThoai, @Fax, @Email, @Website, @MaSoThue, @SoTaiKhoan, @NganHang, @TinhTrang)


GO
/****** Object:  StoredProcedure [dbo].[ThemKhoHang]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--KHACHHANG
--co roi tao k them
--KHOHANG
create proc [dbo].[ThemKhoHang]	
@MaKhoHang	varchar(20),
@KiHieu	varchar(20)	,
@TenKhoHang	nvarchar(50)	,
@NguoiQuanLi	varchar(20)	,
@NguoiLienHe	varchar(20)	,
@DiaChi	nvarchar(50)	,
@DienThoai	varchar(13)	,
@Fax	varchar(15)	,
@Email	varchar(20)	,
@DienGiai	nvarchar(50)	,
@TinhTrang	bit	
as
	insert into KHOHANG values(@MaKhoHang	,
@KiHieu,
@TenKhoHang,
@NguoiQuanLi,
@NguoiLienHe	,
@DiaChi,
@DienThoai,
@Fax	,
@Email	,
@DienGiai	,	
@TinhTrang)

GO
/****** Object:  StoredProcedure [dbo].[ThemKhuVuc]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemKhuVuc] @MaKhuVuc varchar(20), @TenKhuVuc nvarchar(50), @Ghichu nvarchar(50), @Tinhtrang bit
as
	insert into KHUVUC values(@MaKhuVuc, @TenKhuVuc, @Ghichu, @Tinhtrang)

GO
/****** Object:  StoredProcedure [dbo].[ThemLoaiKhachHang]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--KHUVUC
--co roi khoi lam
--LOAIKHACHHANG
create proc [dbo].[ThemLoaiKhachHang]
@MaLoaiKhachHang	varchar(20)	,
@TenLoaiKhachHang	nvarchar(50),
@GhiChu	nvarchar(50),
@TinhTrang	bit		
as
	insert into LOAIKHACHHANG values(@MaLoaiKhachHang,@TenLoaiKhachHang,@GhiChu,@TinhTrang)

GO
/****** Object:  StoredProcedure [dbo].[ThemNguoiDung]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--NGUOIDUNG
create proc [dbo].[ThemNguoiDung]
@MaNguoiDung	varchar(20)	,
@TenNguoiDung	nvarchar(50)	,
@MatKhau	varchar(20)	,
@TinhTrang	bit	,
@NhoMatKhau	bit	,
@MaNhanVien	varchar(20)		
as
	insert into NGUOIDUNG values(@MaNguoiDung,@TenNguoiDung,@MatKhau,@TinhTrang,@NhoMatKhau,@MaNhanVien)

GO
/****** Object:  StoredProcedure [dbo].[ThemNhaCungCap]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--NHACUNGCAP
create proc [dbo].[ThemNhaCungCap]
@MaNhaCungCap	varchar(20)	,
@TenNhaCungCap	nvarchar(50)	,
@DiaChi	nvarchar(50)	,
@KhuVuc	varchar(20)	,
@DienThoai	varchar(13)	,
@Fax	varchar(20)	,
@Email	varchar(20)	,
@Website	varchar(20)	,
@MaSoThue	varchar(20)	,
@SoTaiKhoan	varchar(20)	,
@NganHang	nvarchar(50)	,
@NoHienTai	float	,
@TinhTrang	bit	
as
	insert into NHACUNGCAP values(@MaNhaCungCap,
@TenNhaCungCap	,
@DiaChi,
@KhuVuc	,
@DienThoai	,
@Fax	,
@Email	,
@Website,
@MaSoThue	,
@SoTaiKhoan	,
@NganHang	,
@NoHienTai	,
@TinhTrang)

GO
/****** Object:  StoredProcedure [dbo].[ThemNhanVien]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--NHANVIEN
create proc [dbo].[ThemNhanVien]
@MaNhanVien	varchar(20)	,
@TenNhanVien	nvarchar(50)	,
@ChucVu	nvarchar(50)	,
@DiaChi	nvarchar(50)	,
@Emai	varchar(20)	,
@DienThoai	varchar(13)	,
@BoPhan	varchar(20)	,
@NguoiQuanLi	varchar(20)	,
@TinhTrang	bit	
as
	insert into NHANVIEN values(@MaNhanVien,
@TenNhanVien	,
@ChucVu	,
@DiaChi,
@Emai,
@DienThoai	,
@BoPhan,
@NguoiQuanLi	,
@TinhTrang)

GO
/****** Object:  StoredProcedure [dbo].[ThemNhatKyHeThong]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--NHATKYHETHONG
create proc [dbo].[ThemNhatKyHeThong]
@MaNguoiDung	varchar(20)	,
@MayTinh	varchar(20),
@ThoiGian	datetime	,
@ChucNang	nvarchar(50),
@HanhDong	nvarchar(20)
as
	insert into NHATKYHETHONG values(@MaNguoiDung,@MayTinh,@ThoiGian,@ChucNang,@HanhDong)

GO
/****** Object:  StoredProcedure [dbo].[ThemNhomHangHoa]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--NHOMHANGHOA
create proc [dbo].[ThemNhomHangHoa]
@MaNhomHang	varchar(20)	,
@TenNhomHang	nvarchar(50),
@GhiChu	nvarchar(50),
@TinhTrang	bit	
as
	insert into NHOMHANGHOA values(@MaNhomHang,@TenNhomHang,@GhiChu,@TinhTrang)

GO
/****** Object:  StoredProcedure [dbo].[ThemPhanQuyen]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--PHANQUYEN
create proc [dbo].[ThemPhanQuyen]
@TenNhom nvarchar(50),
@TenChucNang nvarchar(50),
@MaNguoiDung varchar(20),
@ChoPhepThem bit,
@ChoPhepXoa	bit,
@ChoPhepSua	bit,
@ChoPhepTruyCap	bit,
@ChoPhepIn bit,
@TinhTrang bit
as
	insert into PHANQUYEN values(@TenNhom, @TenChucNang,@MaNguoiDung, @ChoPhepThem, @ChoPhepXoa, @ChoPhepSua, @ChoPhepTruyCap, @ChoPhepIn, @TinhTrang)

GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuBanHang]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemPhieuBanHang]
@MaPhieuBan varchar(20),
@MaKhachHang varchar(20),
@NgayBan datetime,
@NhanVienBan varchar(20),
@KhoXuat varchar(20),
@HinhThucThanhToan nvarchar(50),
@TongTien money,
@TinhTrang bit
as
	insert into PHIEUBANHANG values(@MaPhieuBan, @MaKhachHang,@NgayBan, @NhanVienBan, @KhoXuat, @HinhThucThanhToan, @TongTien, @TinhTrang)

GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuChuyenKho]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PHIEUCHUYENKHO
create proc [dbo].[ThemPhieuChuyenKho]
@MaPhieuChuyen	varchar(20)	,
@NgayChuyen	datetime	,
@KhoXuat	varchar(20)	,
@KhoNhap	varchar(20)	,
@NguoiChuyen	varchar(20)	,
@NguoiNhan	varchar(20)	,
@GhiChu	nvarchar(50)	,
@TongTien	money	,
@TinhTrang	bit	
as
	insert into PHIEUCHUYENKHO values(@MaPhieuChuyen	,
@NgayChuyen,
@KhoXuat	,
@KhoNhap	,
@NguoiChuyen	,
@NguoiNhan,
@GhiChu,
@TongTien	,
@TinhTrang)

GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuNhapHang]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PHIEUNHAPHANG
create proc [dbo].[ThemPhieuNhapHang]
@MaPhieuNhap	varchar(20)	,
@NgayNhap	datetime	,
@NhanVienNhap	varchar(20)	,
@KhoNhap	varchar(20)	,
@HanThanhToan	datetime	,
@NhaCungCap	varchar(20)	,
@HinhThucThanhToan	nvarchar(50)	,
@TongTien	money	,
@TinhTrang	bit	
as
	insert into PHIEUNHAPHANG values(@MaPhieuNhap	,
@NgayNhap	,
@NhanVienNhap	,
@KhoNhap	,
@HanThanhToan	,
@NhaCungCap	,
@HinhThucThanhToan	,
@TongTien	,
@TinhTrang
)

GO
/****** Object:  StoredProcedure [dbo].[ThemTyGia]    Script Date: 1/15/2017 4:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TYGIA
create proc [dbo].[ThemTyGia]
@MaTienTe	varchar(3),
@TenTienTe	nvarchar(50),
@TyGiaQuyDoi	money,
@TinhTrang	bit	
as
	insert into TYGIA values(@MaTienTe,@TenTienTe,@TyGiaQuyDoi,@TinhTrang)	

GO
