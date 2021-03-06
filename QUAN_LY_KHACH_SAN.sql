USE [QUAN_LY_KHACH_SAN]
GO
/****** Object:  StoredProcedure [dbo].[AddObject]    Script Date: 22/12/2020 14:55  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddObject]
(
	@core int,
	@ID1 varchar(10),
	@ID2 varchar(10),
	@String nvarchar(50),
	@Date1 date,
	@Date2 date,
	@Num bigint
)
as
begin
	if @core=1
		insert into KHACHHANG
		values (@ID1,@String,@ID2,@Num)
	else if @core=2
		insert into PHONG
		values (@ID1,@ID2,@Num,@String)
	else if @core=3
		insert into DODUNG
		values(@ID1,@String,@Num)
	else if @core=4
		insert into DICHVU
		values(@ID1,@String,@Num)
	else if @core=5
		insert into QUANLYDICHVU
		values (@ID1,@ID2,@Num)
	else if @core=6
		insert into QUANLYDODUNG
		values (@ID1,@ID2,@Num)
	else 
		insert into QUANLYPHONG
		values (@ID1,@ID2,@Date1,@Date2,@Num,@String)
end

GO
/****** Object:  StoredProcedure [dbo].[AutoCounting]    Script Date: 22/12/2020 14:55  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AutoCounting]
as 
begin
	update QUANLYPHONG set TongTien=0
	declare pointer1 cursor scroll for select ID_Phong,NgayThue,NgayTra from QUANLYPHONG
	declare pointer2 cursor scroll for select * from QUANLYDODUNG
	declare pointer3 cursor scroll for select * from QUANLYDICHVU
	declare @check int =0
	declare @ID nvarchar(10)
	declare @Date1 date
	declare @Date2 date
	declare @total bigint
	open pointer1
	while @check<>1
	begin
		fetch next from pointer1 into @ID,@Date1,@Date2
		if @@FETCH_STATUS<>0
		begin
			set @check=1
		end
		else
		begin
			set @total = Convert(bigint,(select DATEDIFF(DAY,NgayThue,NgayTra) from QUANLYPHONG where ID_Phong=@ID))*(select Gia1Ngay from PHONG where ID_Phong=@ID)
			open pointer2
			declare @ID2_Phong nvarchar(10)
			declare @ID2_DoDung nvarchar(10)
			declare @count2 bigint
			declare @check2 int=0
			while @check2<>1
			begin
				fetch next from pointer2 into @ID2_Phong,@ID2_DoDung,@count2
				if @@FETCH_STATUS<>0
					set @check2=1
				else
				begin
					if @ID2_Phong=@ID
					begin
						set @total = @total + (select Gia from DODUNG where ID_DoDung=@ID2_DoDung)*@count2
					end
				end
			end
			close pointer2
			open pointer3
			declare @ID3_Phong nvarchar(10)
			declare @ID3_DichVu nvarchar(10)
			declare @count3 bigint
			declare @check3 int=0
			while @check3<>1
			begin
				fetch next from pointer3 into @ID3_Phong,@ID3_DichVu,@count3 
				if @@FETCH_STATUS<>0
					set @check3=1
				else
				begin
					if @ID3_Phong=@ID
					begin
						set @total=@total +(select Gia from DICHVU where ID_DichVu=@ID3_DichVu)*@count3
					end
				end
			end
			close pointer3
			update QUANLYPHONG set TongTien=@total where ID_Phong=@ID
		end
	end
	close pointer1
	deallocate pointer1
	deallocate pointer2
	deallocate pointer3
end

GO
/****** Object:  StoredProcedure [dbo].[DeleteObject]    Script Date: 22/12/2020 14:55  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteObject]
(
	@core int,
	@ID1 nvarchar(10),
	@ID2 nvarchar(10)
)
as
begin
	if @core=1
		delete from KHACHHANG where ID_KhachHang=@ID1
	else if @core=2
		delete from PHONG where ID_Phong=@ID1
	else if @core=3
		delete from DODUNG where ID_DoDung=@ID1
	else if @core=4
		delete from DICHVU where ID_DichVu =@ID1
	else if @core=5
		delete from QUANLYDICHVU where ID_Phong=@ID1 and ID_DichVu=@ID2
	else if @core=6
		delete from QUANLYDODUNG where ID_Phong=@ID1 and ID_DoDung=@ID2
	else 
		delete from QUANLYPHONG where ID_Phong=@ID1 and ID_KhachHang=@ID2
end

GO
/****** Object:  StoredProcedure [dbo].[EditObject]    Script Date: 22/12/2020 14:55  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditObject]
(
	@core int,
	@ID1 varchar(10),
	@ID2 varchar(10),
	@String nvarchar(50),
	@Date1 date,
	@Date2 date,
	@Num bigint
)
as
begin
	if @core=1
		update KHACHHANG set TenKhachHang=@String, CMND=@ID2,SDT=@Num
		where ID_KhachHang=@ID1
	else if @core=2
		update PHONG set TinhTrang=@ID2, GhiChu=@String ,Gia1Ngay=@Num
		where ID_Phong=@ID1
	else if @core=3
		update DODUNG set TenDoDung=@String,Gia=@Num
		where ID_DoDung=@ID1
	else if @core=4
		update DICHVU set TenDichVu=@String, Gia=@Num
		where ID_DichVu=@ID1
	else if @core=5
		update QUANLYDICHVU set SoLuong=@Num
		where ID_Phong=@ID1 and ID_DichVu=@ID2
	else if @core=6
		update QUANLYDODUNG set SoLuong=@Num
		where ID_Phong=@ID1 and ID_DoDung=@ID2
	else 
		update QUANLYPHONG set NgayThue=@Date1,NgayTra=@Date2,GhiChu=@String, TongTien=@Num
		where ID_Phong=@ID1 and ID_KhachHang=@ID2
end

GO
/****** Object:  StoredProcedure [dbo].[FindObject]    Script Date: 22/12/2020 14:55  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[FindObject]
(
	@core int,
	@Part nvarchar(50)
)
as
begin
	if @core=1
		select*from KHACHHANG where ID_KhachHang like ('%'+@Part+'%') or TenKhachHang like ('%'+@Part+'%') or SDT like ('%'+@Part+'%')
	else if @core=2
		select*from PHONG where ID_Phong like ('%'+@Part+'%') or TinhTrang like ('%'+@Part+'%') or GhiChu like ('%'+@Part+'%') or Gia1Ngay like ('%'+@Part+'%')
	else if @core=3
		select*from DODUNG where ID_DoDung like ('%'+@Part+'%') or  TenDoDung like ('%'+@Part+'%') or Gia like ('%'+@Part+'%')
	else if @core=4
		select*from DICHVU where ID_DichVu like ('%'+@Part+'%') or TenDichVu like ('%'+@Part+'%') or Gia like ('%'+@Part+'%')
	else if @core=5
		select*from QUANLYDICHVU where ID_DichVu  like ('%'+@Part+'%') or ID_Phong like ('%'+@Part+'%') or SoLuong like ('%'+@Part+'%')
	else if @core=6
		select*from QUANLYDODUNG where ID_DoDung like ('%'+@Part+'%') or ID_Phong like ('%'+@Part+'%') or SoLuong  like ('%'+@Part+'%')
	else 
		select*from QUANLYPHONG where ID_KhachHang  like ('%'+@Part+'%') or ID_Phong  like ('%'+@Part+'%')
end

GO
/****** Object:  StoredProcedure [dbo].[OutPutTable]    Script Date: 22/12/2020 14:55  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OutPutTable]
(
	@core int
)
as
begin
	if @core=1
		select*from KHACHHANG
	else if @core=2
		select*from PHONG
	else if @core=3
		select*from DODUNG
	else if @core=4
		select*from DICHVU
	else if @core=5
		select*from QUANLYDICHVU
	else if @core=6
		select*from QUANLYDODUNG
	else if @core=7
		select*from QUANLYPHONG
	else 
		select*from DANGNHAP
end

GO
/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 22/12/2020 14:55  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGNHAP](
	[Username] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NULL,
 CONSTRAINT [PK_DN] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 22/12/2020 14:55  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[ID_DichVu] [nvarchar](10) NOT NULL,
	[TenDichVu] [nvarchar](50) NULL,
	[Gia] [bigint] NULL,
 CONSTRAINT [PK_DV] PRIMARY KEY CLUSTERED 
(
	[ID_DichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DODUNG]    Script Date: 22/12/2020 14:55  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DODUNG](
	[ID_DoDung] [nvarchar](10) NOT NULL,
	[TenDoDung] [nvarchar](50) NULL,
	[Gia] [bigint] NULL,
 CONSTRAINT [PK_DD] PRIMARY KEY CLUSTERED 
(
	[ID_DoDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 22/12/2020 14:55  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[ID_KhachHang] [nvarchar](10) NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[CMND] [nvarchar](10) NULL,
	[SDT] [bigint] NULL,
 CONSTRAINT [PK_KH] PRIMARY KEY CLUSTERED 
(
	[ID_KhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 22/12/2020 14:55  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[ID_Phong] [nvarchar](10) NOT NULL,
	[TinhTrang] [nvarchar](10) NULL,
	[Gia1Ngay] [bigint] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ph] PRIMARY KEY CLUSTERED 
(
	[ID_Phong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QUANLYDICHVU]    Script Date: 22/12/2020 14:55  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUANLYDICHVU](
	[ID_Phong] [nvarchar](10) NOT NULL,
	[ID_DichVu] [nvarchar](10) NOT NULL,
	[Soluong] [bigint] NULL,
 CONSTRAINT [PK_CTTP] PRIMARY KEY CLUSTERED 
(
	[ID_Phong] ASC,
	[ID_DichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QUANLYDODUNG]    Script Date: 22/12/2020 14:55  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUANLYDODUNG](
	[ID_Phong] [nvarchar](10) NOT NULL,
	[ID_DoDung] [nvarchar](10) NOT NULL,
	[SoLuong] [bigint] NULL,
 CONSTRAINT [PK_QLDD] PRIMARY KEY CLUSTERED 
(
	[ID_Phong] ASC,
	[ID_DoDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QUANLYPHONG]    Script Date: 22/12/2020 14:55  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUANLYPHONG](
	[ID_Phong] [nvarchar](10) NOT NULL,
	[ID_KhachHang] [nvarchar](10) NOT NULL,
	[NgayThue] [date] NULL,
	[NgayTra] [date] NULL,
	[TongTien] [bigint] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_QLP] PRIMARY KEY CLUSTERED 
(
	[ID_Phong] ASC,
	[ID_KhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[DANGNHAP] ([Username], [Pass]) VALUES (N'abc', N'123')
INSERT [dbo].[DANGNHAP] ([Username], [Pass]) VALUES (N'mam', N'123')
INSERT [dbo].[DANGNHAP] ([Username], [Pass]) VALUES (N'phousi', N'123')
INSERT [dbo].[DANGNHAP] ([Username], [Pass]) VALUES (N'quyet', N'123')
INSERT [dbo].[DANGNHAP] ([Username], [Pass]) VALUES (N'sang', N'123')
INSERT [dbo].[DANGNHAP] ([Username], [Pass]) VALUES (N'trung', N'123')
INSERT [dbo].[DICHVU] ([ID_DichVu], [TenDichVu], [Gia]) VALUES (N'DV001', N'Dịch vụ 1', 350000)
INSERT [dbo].[DICHVU] ([ID_DichVu], [TenDichVu], [Gia]) VALUES (N'DV002', N'Dịch vụ 2', 450000)
INSERT [dbo].[DICHVU] ([ID_DichVu], [TenDichVu], [Gia]) VALUES (N'DV003', N'Dịch vụ 3', 550000)
INSERT [dbo].[DICHVU] ([ID_DichVu], [TenDichVu], [Gia]) VALUES (N'DV004', N'Dịch vụ 4', 250000)
INSERT [dbo].[DICHVU] ([ID_DichVu], [TenDichVu], [Gia]) VALUES (N'DV005', N'Dịch vụ 5', 550000)
INSERT [dbo].[DICHVU] ([ID_DichVu], [TenDichVu], [Gia]) VALUES (N'DV006', N'Dịch vụ 6', 300000)
INSERT [dbo].[DICHVU] ([ID_DichVu], [TenDichVu], [Gia]) VALUES (N'DV007', N'Dịch vụ 7', 400000)
INSERT [dbo].[DICHVU] ([ID_DichVu], [TenDichVu], [Gia]) VALUES (N'DV008', N'Dịch vụ 8', 500000)
INSERT [dbo].[DICHVU] ([ID_DichVu], [TenDichVu], [Gia]) VALUES (N'DV009', N'Dịch vụ 9', 600000)
INSERT [dbo].[DICHVU] ([ID_DichVu], [TenDichVu], [Gia]) VALUES (N'DV010', N'Dịch vụ 10', 200000)
INSERT [dbo].[DODUNG] ([ID_DoDung], [TenDoDung], [Gia]) VALUES (N'DD001', N'Máy nóng lạnh', 150000)
INSERT [dbo].[DODUNG] ([ID_DoDung], [TenDoDung], [Gia]) VALUES (N'DD002', N'Tivi', 210000)
INSERT [dbo].[DODUNG] ([ID_DoDung], [TenDoDung], [Gia]) VALUES (N'DD003', N'Lò sưởi', 300000)
INSERT [dbo].[DODUNG] ([ID_DoDung], [TenDoDung], [Gia]) VALUES (N'DD004', N'Rèm', 410000)
INSERT [dbo].[DODUNG] ([ID_DoDung], [TenDoDung], [Gia]) VALUES (N'DD005', N'Kệ TiVi', 50000)
INSERT [dbo].[DODUNG] ([ID_DoDung], [TenDoDung], [Gia]) VALUES (N'DD006', N'Giường', 120000)
INSERT [dbo].[DODUNG] ([ID_DoDung], [TenDoDung], [Gia]) VALUES (N'DD007', N'Vòi sen', 100000)
INSERT [dbo].[DODUNG] ([ID_DoDung], [TenDoDung], [Gia]) VALUES (N'DD008', N'Khóa nước', 110000)
INSERT [dbo].[DODUNG] ([ID_DoDung], [TenDoDung], [Gia]) VALUES (N'DD009', N'Quạt', 100000)
INSERT [dbo].[DODUNG] ([ID_DoDung], [TenDoDung], [Gia]) VALUES (N'DD010', N'Máy giặt', 100000)
INSERT [dbo].[KHACHHANG] ([ID_KhachHang], [TenKhachHang], [CMND], [SDT]) VALUES (N'KH001', N'Trịnh Thành Trung', N'352200021', 928182732)
INSERT [dbo].[KHACHHANG] ([ID_KhachHang], [TenKhachHang], [CMND], [SDT]) VALUES (N'KH002', N'Trần Sang Anh', N'764232022', 982716273)
INSERT [dbo].[KHACHHANG] ([ID_KhachHang], [TenKhachHang], [CMND], [SDT]) VALUES (N'KH003', N'Nguyễn Trọng Quyết', N'124210202', 982628174)
INSERT [dbo].[KHACHHANG] ([ID_KhachHang], [TenKhachHang], [CMND], [SDT]) VALUES (N'KH004', N'Phạm Công Tú', N'543200974', 29182837)
INSERT [dbo].[KHACHHANG] ([ID_KhachHang], [TenKhachHang], [CMND], [SDT]) VALUES (N'KH005', N'Hoàng Anh', N'964232321', 192837172)
INSERT [dbo].[KHACHHANG] ([ID_KhachHang], [TenKhachHang], [CMND], [SDT]) VALUES (N'KH006', N'Phousi', N'174254333', 123737180)
INSERT [dbo].[KHACHHANG] ([ID_KhachHang], [TenKhachHang], [CMND], [SDT]) VALUES (N'KH007', N'Nguyễn Mạnh Cường', N'214209172', 192837172)
INSERT [dbo].[KHACHHANG] ([ID_KhachHang], [TenKhachHang], [CMND], [SDT]) VALUES (N'KH008', N'Lê Duy Dũng', N'174203232', 19283162)
INSERT [dbo].[KHACHHANG] ([ID_KhachHang], [TenKhachHang], [CMND], [SDT]) VALUES (N'KH009', N'Võ Văn Bình', N'224289002', 182764718)
INSERT [dbo].[KHACHHANG] ([ID_KhachHang], [TenKhachHang], [CMND], [SDT]) VALUES (N'KH010', N'Nguyễn Duy Quang', N'774294828', 182736271)
INSERT [dbo].[PHONG] ([ID_Phong], [TinhTrang], [Gia1Ngay], [GhiChu]) VALUES (N'Ph001', N'Trống', 100000, N'')
INSERT [dbo].[PHONG] ([ID_Phong], [TinhTrang], [Gia1Ngay], [GhiChu]) VALUES (N'Ph002', N'Busy', 50000, N'')
INSERT [dbo].[PHONG] ([ID_Phong], [TinhTrang], [Gia1Ngay], [GhiChu]) VALUES (N'Ph003', N'Busy', 75000, N'')
INSERT [dbo].[PHONG] ([ID_Phong], [TinhTrang], [Gia1Ngay], [GhiChu]) VALUES (N'Ph004', N'Ready', 125000, N'')
INSERT [dbo].[PHONG] ([ID_Phong], [TinhTrang], [Gia1Ngay], [GhiChu]) VALUES (N'Ph005', N'Ready', 100000, N'')
INSERT [dbo].[PHONG] ([ID_Phong], [TinhTrang], [Gia1Ngay], [GhiChu]) VALUES (N'Ph006', N'Ready', 100000, N'')
INSERT [dbo].[PHONG] ([ID_Phong], [TinhTrang], [Gia1Ngay], [GhiChu]) VALUES (N'Ph007', N'Busy', 50000, N'')
INSERT [dbo].[PHONG] ([ID_Phong], [TinhTrang], [Gia1Ngay], [GhiChu]) VALUES (N'Ph008', N'Busy', 100000, N'')
INSERT [dbo].[PHONG] ([ID_Phong], [TinhTrang], [Gia1Ngay], [GhiChu]) VALUES (N'Ph009', N'Ready', 100000, N'')
INSERT [dbo].[PHONG] ([ID_Phong], [TinhTrang], [Gia1Ngay], [GhiChu]) VALUES (N'Ph010', N'Ready', 100000, N'')
INSERT [dbo].[PHONG] ([ID_Phong], [TinhTrang], [Gia1Ngay], [GhiChu]) VALUES (N'Ph011', N'Ready', 100000, N'')
INSERT [dbo].[PHONG] ([ID_Phong], [TinhTrang], [Gia1Ngay], [GhiChu]) VALUES (N'Ph012', N'Ready', 100000, N'')
INSERT [dbo].[PHONG] ([ID_Phong], [TinhTrang], [Gia1Ngay], [GhiChu]) VALUES (N'Ph013', N'Ready', 100000, N'')
INSERT [dbo].[PHONG] ([ID_Phong], [TinhTrang], [Gia1Ngay], [GhiChu]) VALUES (N'Ph014', N'Ready', 100000, N'')
INSERT [dbo].[PHONG] ([ID_Phong], [TinhTrang], [Gia1Ngay], [GhiChu]) VALUES (N'Ph015', N'Ready', 100000, N'')
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph001', N'DV001', 1)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph001', N'DV002', 2)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph001', N'DV003', 1)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph001', N'DV004', 1)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph002', N'DV002', 1)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph002', N'DV003', 1)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph002', N'DV004', 1)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph003', N'DV003', 1)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph003', N'DV005', 1)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph003', N'DV006', 3)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph004', N'DV004', 1)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph004', N'DV008', 2)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph005', N'DV005', 1)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph005', N'DV006', 1)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph005', N'DV007', 1)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph005', N'DV009', 1)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph006', N'DV006', 1)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph006', N'DV009', 3)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph007', N'DV003', 1)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph007', N'DV006', 4)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph007', N'DV008', 1)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph008', N'DV001', 1)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph008', N'DV002', 5)
INSERT [dbo].[QUANLYDICHVU] ([ID_Phong], [ID_DichVu], [Soluong]) VALUES (N'Ph008', N'DV010', 1)
INSERT [dbo].[QUANLYDODUNG] ([ID_Phong], [ID_DoDung], [SoLuong]) VALUES (N'Ph001', N'DD001', 1)
INSERT [dbo].[QUANLYDODUNG] ([ID_Phong], [ID_DoDung], [SoLuong]) VALUES (N'Ph001', N'DD002', 1)
INSERT [dbo].[QUANLYDODUNG] ([ID_Phong], [ID_DoDung], [SoLuong]) VALUES (N'Ph002', N'DD002', 2)
INSERT [dbo].[QUANLYDODUNG] ([ID_Phong], [ID_DoDung], [SoLuong]) VALUES (N'Ph002', N'DD003', 1)
INSERT [dbo].[QUANLYDODUNG] ([ID_Phong], [ID_DoDung], [SoLuong]) VALUES (N'Ph002', N'DD007', 1)
INSERT [dbo].[QUANLYDODUNG] ([ID_Phong], [ID_DoDung], [SoLuong]) VALUES (N'Ph003', N'DD002', 1)
INSERT [dbo].[QUANLYDODUNG] ([ID_Phong], [ID_DoDung], [SoLuong]) VALUES (N'Ph004', N'DD005', 1)
INSERT [dbo].[QUANLYDODUNG] ([ID_Phong], [ID_DoDung], [SoLuong]) VALUES (N'Ph004', N'DD008', 2)
INSERT [dbo].[QUANLYPHONG] ([ID_Phong], [ID_KhachHang], [NgayThue], [NgayTra], [TongTien], [GhiChu]) VALUES (N'Ph001', N'KH002', CAST(0x6E390B00 AS Date), CAST(0xA9390B00 AS Date), 0, N'')
INSERT [dbo].[QUANLYPHONG] ([ID_Phong], [ID_KhachHang], [NgayThue], [NgayTra], [TongTien], [GhiChu]) VALUES (N'Ph002', N'KH003', CAST(0x8E390B00 AS Date), CAST(0x193B0B00 AS Date), 0, N'')
INSERT [dbo].[QUANLYPHONG] ([ID_Phong], [ID_KhachHang], [NgayThue], [NgayTra], [TongTien], [GhiChu]) VALUES (N'Ph003', N'KH004', CAST(0xAB390B00 AS Date), CAST(0x383B0B00 AS Date), 0, N'')
INSERT [dbo].[QUANLYPHONG] ([ID_Phong], [ID_KhachHang], [NgayThue], [NgayTra], [TongTien], [GhiChu]) VALUES (N'Ph004', N'KH005', CAST(0xAC390B00 AS Date), CAST(0x263A0B00 AS Date), 0, N'')
INSERT [dbo].[QUANLYPHONG] ([ID_Phong], [ID_KhachHang], [NgayThue], [NgayTra], [TongTien], [GhiChu]) VALUES (N'Ph005', N'KH006', CAST(0xEA390B00 AS Date), CAST(0x653A0B00 AS Date), 0, N'')
INSERT [dbo].[QUANLYPHONG] ([ID_Phong], [ID_KhachHang], [NgayThue], [NgayTra], [TongTien], [GhiChu]) VALUES (N'Ph006', N'KH007', CAST(0x0B3A0B00 AS Date), CAST(0x853A0B00 AS Date), 0, N'')
INSERT [dbo].[QUANLYPHONG] ([ID_Phong], [ID_KhachHang], [NgayThue], [NgayTra], [TongTien], [GhiChu]) VALUES (N'Ph007', N'KH008', CAST(0x493A0B00 AS Date), CAST(0x853A0B00 AS Date), 0, N'')
INSERT [dbo].[QUANLYPHONG] ([ID_Phong], [ID_KhachHang], [NgayThue], [NgayTra], [TongTien], [GhiChu]) VALUES (N'Ph008', N'KH009', CAST(0x683A0B00 AS Date), CAST(0xF33B0B00 AS Date), 0, N'')
ALTER TABLE [dbo].[QUANLYDICHVU]  WITH CHECK ADD  CONSTRAINT [PK_CTTP_DV] FOREIGN KEY([ID_DichVu])
REFERENCES [dbo].[DICHVU] ([ID_DichVu])
GO
ALTER TABLE [dbo].[QUANLYDICHVU] CHECK CONSTRAINT [PK_CTTP_DV]
GO
ALTER TABLE [dbo].[QUANLYDICHVU]  WITH CHECK ADD  CONSTRAINT [PK_CTTP_Ph] FOREIGN KEY([ID_Phong])
REFERENCES [dbo].[PHONG] ([ID_Phong])
GO
ALTER TABLE [dbo].[QUANLYDICHVU] CHECK CONSTRAINT [PK_CTTP_Ph]
GO
ALTER TABLE [dbo].[QUANLYDODUNG]  WITH CHECK ADD  CONSTRAINT [PK_QLDD_DD] FOREIGN KEY([ID_DoDung])
REFERENCES [dbo].[DODUNG] ([ID_DoDung])
GO
ALTER TABLE [dbo].[QUANLYDODUNG] CHECK CONSTRAINT [PK_QLDD_DD]
GO
ALTER TABLE [dbo].[QUANLYDODUNG]  WITH CHECK ADD  CONSTRAINT [PK_QLDD_Ph] FOREIGN KEY([ID_Phong])
REFERENCES [dbo].[PHONG] ([ID_Phong])
GO
ALTER TABLE [dbo].[QUANLYDODUNG] CHECK CONSTRAINT [PK_QLDD_Ph]
GO
ALTER TABLE [dbo].[QUANLYPHONG]  WITH CHECK ADD  CONSTRAINT [PK_QLP_KH] FOREIGN KEY([ID_KhachHang])
REFERENCES [dbo].[KHACHHANG] ([ID_KhachHang])
GO
ALTER TABLE [dbo].[QUANLYPHONG] CHECK CONSTRAINT [PK_QLP_KH]
GO
ALTER TABLE [dbo].[QUANLYPHONG]  WITH CHECK ADD  CONSTRAINT [PK_QLP_Ph] FOREIGN KEY([ID_Phong])
REFERENCES [dbo].[PHONG] ([ID_Phong])
GO
ALTER TABLE [dbo].[QUANLYPHONG] CHECK CONSTRAINT [PK_QLP_Ph]
GO
