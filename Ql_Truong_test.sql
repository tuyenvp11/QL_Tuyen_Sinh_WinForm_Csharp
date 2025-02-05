USE [Ql_Truong_test]
GO

CREATE TABLE [dbo].[Diem_Thi_THPT](
	[MaThiSinh] [nvarchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[Cccd] [int] NULL,
	[QueQuan] [nvarchar](50) NULL,
	[NamSinh] [datetime] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[KhoiXetTuyen] [nvarchar](50) NULL,
	[ToHopMonXetTuyen] [nvarchar](50) NULL,
	[DiemMon1] [float] NULL,
	[DiemMon2] [float] NULL,
	[DiemMon3] [float] NULL,
 CONSTRAINT [PK_Diem_Thi_THPT] PRIMARY KEY CLUSTERED 
(
	[MaThiSinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Hoc_Ba_THPT](
	[MaHocSinh] [nvarchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[Cccd] [int] NULL,
	[QueQuan] [nvarchar](50) NULL,
	[NamSinh] [datetime] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[KhoiXetTuyen] [nvarchar](50) NULL,
	[ToHopMonXetTuyen] [nvarchar](50) NULL,
	[DiemLop12Mon1] [float] NULL,
	[DiemLop12Mon2] [float] NULL,
	[DiemLop12Mon3] [float] NULL,
 CONSTRAINT [PK_Hoc_Ba_THPT] PRIMARY KEY CLUSTERED 
(
	[MaHocSinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Nganh_Hoc](
	[MaNganh] [int] NOT NULL,
	[TenNganh] [nvarchar](50) NULL,
	[KhoiXetTuyen] [nvarchar](50) NULL,
	[DiemChuanTheoHocBa] [float] NULL,
	[DiemChuanTheoDiemThi] [float] NULL, 
	[TieuChi] [int] NULL,
 CONSTRAINT [PK_Nganh_Hoc] PRIMARY KEY CLUSTERED 
(
	[MaNganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Xet_Tuyen_Theo_Diem_Thi_THPT](
	[MaThiSinh] [nvarchar](50) NULL,
	[MaNganh] [int] NULL,
	[TongDiemBaMon] [float] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Xet_Tuyen_Theo_Hoc_Ba_THPT](
	[MaHocSinh] [nvarchar](50) NULL,
	[MaNganh] [int] NULL,
	[TongDiemBaMon] [float] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Xet_Tuyen_Theo_Diem_Thi_THPT]  WITH CHECK ADD  CONSTRAINT [FK_Xet_Tuyen_Theo_Diem_Thi_THPT_Diem_Thi_THPT] FOREIGN KEY([MaThiSinh])
REFERENCES [dbo].[Diem_Thi_THPT] ([MaThiSinh])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Xet_Tuyen_Theo_Diem_Thi_THPT] CHECK CONSTRAINT [FK_Xet_Tuyen_Theo_Diem_Thi_THPT_Diem_Thi_THPT]
GO
ALTER TABLE [dbo].[Xet_Tuyen_Theo_Diem_Thi_THPT]  WITH CHECK ADD  CONSTRAINT [FK_Xet_Tuyen_Theo_Diem_Thi_THPT_Nganh_Hoc] FOREIGN KEY([MaNganh])
REFERENCES [dbo].[Nganh_Hoc] ([MaNganh])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Xet_Tuyen_Theo_Diem_Thi_THPT] CHECK CONSTRAINT [FK_Xet_Tuyen_Theo_Diem_Thi_THPT_Nganh_Hoc]
GO
ALTER TABLE [dbo].[Xet_Tuyen_Theo_Hoc_Ba_THPT]  WITH CHECK ADD  CONSTRAINT [FK_Xet_Tuyen_Theo_Hoc_Ba_THPT_Hoc_Ba_THPT] FOREIGN KEY([MaHocSinh])
REFERENCES [dbo].[Hoc_Ba_THPT] ([MaHocSinh])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Xet_Tuyen_Theo_Hoc_Ba_THPT] CHECK CONSTRAINT [FK_Xet_Tuyen_Theo_Hoc_Ba_THPT_Hoc_Ba_THPT]
GO
ALTER TABLE [dbo].[Xet_Tuyen_Theo_Hoc_Ba_THPT]  WITH CHECK ADD  CONSTRAINT [FK_Xet_Tuyen_Theo_Hoc_Ba_THPT_Nganh_Hoc] FOREIGN KEY([MaNganh])
REFERENCES [dbo].[Nganh_Hoc] ([MaNganh])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Xet_Tuyen_Theo_Hoc_Ba_THPT] CHECK CONSTRAINT [FK_Xet_Tuyen_Theo_Hoc_Ba_THPT_Nganh_Hoc]
GO



SELECT * FROM Hoc_Ba_THPT
SELECT * FROM Diem_Thi_THPT
SELECT * FROM Nganh_Hoc
SELECT * FROM Xet_Tuyen_Theo_Hoc_Ba_THPT
SELECT * FROM Xet_Tuyen_Theo_Diem_Thi_THPT


INSERT INTO Hoc_Ba_THPT(MaHocSinh,HoTen,Cccd,QueQuan,NamSinh,GioiTinh,KhoiXetTuyen,ToHopMonXetTuyen,DiemLop12Mon1,DiemLop12Mon2,DiemLop12Mon3)VALUES
(N'HS01',N'Lê Hải Anh',20214065,N'Nam Định','2003-10-14',N'Nam',N'TỰ NHIÊN',N'A00',9,9,8),
(N'HS02',N'Nguyễn Việt Anh',20213126,N'Quảng Nam','2003-08-05',N'Nam',N'TỰ NHIÊN',N'A00',9,9,9),
(N'HS03',N'Trịnh Công Anh',20213254,N'Gia Lai','2003-10-24',N'Nam',N'TỰ NHIÊN',N'A01',8,9,8),
(N'HS04',N'Đỗ Gia Bảo',20213215,N'Thanh Hóa','2003-08-28',N'Nam',N'TỰ NHIÊN',N'C01',9,8,9),
(N'HS05',N'Tạ Hoàng Bảo',20213102,N'Hà Nam','2003-11-24',N'Nam',N'TỰ NHIÊN',N'D01',8,9,10),
(N'HS06',N'Hoàng Trọng Đại',2021358,N'Hà Nội','2003-12-15',N'Nam',N'TỰ NHIÊN',N'A00',7,7,7),
(N'HS07',N'Nguyễn Thành Đạt',20213104,N'Bắc Ninh','2003-12-09',N'Nam',N'TỰ NHIÊN',N'A01',8,7,7),
(N'HS08',N'Phan Tuấn Đạt',20213151,N'Nghệ An','2003-05-21',N'Nam',N'TỰ NHIÊN',N'A01',8,8,8),
(N'HS09',N'Vũ Tiến Đạt',20213197,N'Cà Mau','2003-10-26',N'Nam',N'TỰ NHIÊN',N'A00',8,9,10),
(N'HS10',N'Dương Trùng Điệp',20213176,N'Điện Biên','2003-01-29',N'Nam',N'TỰ NHIÊN',N'A01',8,9,9),
(N'HS11',N'Nguyễn Lê Điệp',20213177,N'Phú Thọ','2003-01-14',N'Nam',N'TỰ NHIÊN',N'D01',8,9,8),
(N'HS12',N'Nguyễn Sỹ Đức',20213178,N'Quảng Nam','2003-12-24',N'Nam',N'TỰ NHIÊN',N'C01',9,9,9),
(N'HS13',N'Phạm Anh Đức',20213128,N'Ninh Bình','2003-11-27',N'Nam',N'TỰ NHIÊN',N'D01',7,7,7),
(N'HS14',N'Nguyễn Triệu Duy',20213253,N'Nam Định','2003-08-08',N'Nam',N'XÃ HỘI',N'A00',8,9,10),
(N'HS15',N'Trần Quốc Duy',20213279,N'Thanh Hóa','2003-10-29',N'Nam',N'XÃ HỘI',N'A00',9,9,9),
(N'HS16',N'Trần Trường Giang',20213201,N'Nghệ An','2003-10-18',N'Nam',N'XÃ HỘI',N'A00',10,9,10),
(N'HS17',N'Nguyễn Tiến Hào',20214037,N'Cà Mau','2003-01-10',N'Nam',N'XÃ HỘI',N'A00',8,8,9),
(N'HS18',N'Nguyễn Văn Hiệp',20213134,N'Nam Định','2003-10-22',N'Nam',N'XÃ HỘI',N'A00',8,9,10),
(N'HS19',N'Lê Đình Hiếu',20214045,N'Hà Nội','2003-10-18',N'Nam',N'XÃ HỘI',N'A01',9,9,9),
(N'HS20',N'Lê Huy Hoàng',20213168,N'Ninh Bình','2003-06-23',N'Nam',N'XÃ HỘI',N'C00',10,10,9),
(N'HS21',N'Nguyễn Xuân Hoàng',20214021,N'Hà Nam','2003-11-29',N'Nam',N'XÃ HỘI',N'D01',10,9,10),
(N'HS22',N'Hoàng Văn Huấn',20213095,N'Hải Phòng','2003-09-23',N'Nam',N'XÃ HỘI',N'C00',8,9,7),
(N'HS23',N'Lê Viết Hùng',20213140,N'Nghệ An','2003-12-08',N'Nam',N'XÃ HỘI',N'A00',8,9,8),
(N'HS24',N'Lò Văn Hùng',20213118,N'Hà Tĩnh','2003-03-13',N'Nam',N'XÃ HỘI',N'A01',8,9,10),
(N'HS25',N'Nguyễn Cao Việt Hưng',20213181,N'Nam Định','2003-08-28',N'Nam',N'XÃ HỘI',N'C00',9,9,10),
(N'HS26',N'Đoàn Xuân Khang',20213037,N'Hà Nam','2003-8-14',N'Nam',N'XÃ HỘI',N'A00',7,9,8),
(N'HS27',N'Nguyễn Quang Huy',20213156,N'Nam Định','2003-01-29',N'Nam',N'XÃ HỘI',N'A00',9,9,10),
(N'HS28',N'Lâm Thị Huyền',20213109,N'Thanh Hóa','2003-08-07',N'Nữ',N'XÃ HỘI',N'A01',10,9,10),
(N'HS29',N'Đào Thi Huệ',20213116,N'Thanh Hóa','2003-01-30',N'Nữ',N'XÃ HỘI',N'A02',10,9,10),
(N'HS30',N'Bùi Thị Trang',20213111,N'Nghệ An','2003-12-07',N'Nữ',N'XÃ HỘI',N'A02',8,8,8);

INSERT INTO Diem_Thi_THPT(MaThiSinh,HoTen,Cccd,QueQuan,NamSinh,GioiTinh,KhoiXetTuyen,ToHopMonXetTuyen,DiemMon1,DiemMon2,DiemMon3)VALUES
(N'TS01',N'Nguyễn Tùng Lâm',20213106,N'Ninh Bình','2003-12-04',N'Nam',N'TỰ NHIÊN',N'A00',7,7,8),
(N'TS02',N'Đỗ Vũ Thành Lộc',20213217,N'Thanh Hóa','2003-12-16',N'Nam',N'TỰ NHIÊN',N'A01',8,8,8),
(N'TS03',N'Nguyễn Thế Hoàng Long',20213136,N'Lào Cai','2003-08-22',N'Nam',N'TỰ NHIÊN',N'A00',9,8,7),
(N'TS04',N'Bùi Thị Phương Mai',20213195,N'Yên Bái','2003-07-26',N'Nữ',N'TỰ NHIÊN',N'D01',8,9,8),
(N'TS05',N'Phạm Ngọc Nam',20213198,N'Cà Mau','2003-02-16',N'Nam',N'TỰ NHIÊN',N'A00',9,9,9),
(N'TS06',N'Lê Khắc Ngọc',20213218,N'Nam Định','2003-06-07',N'Nam',N'TỰ NHIÊN',N'C01',6,6,6),
(N'TS07',N'Phạm Văn Ngọc',20213174,N'Hà Nam','2003-01-16',N'Nam',N'TỰ NHIÊN',N'A00',7,7,7),
(N'TS08',N'Phạm Văn Phi',20213160,N'Thái Nguyên','2003-10-24',N'Nam',N'TỰ NHIÊN',N'A00',8,7,6),
(N'TS09',N'Nguyễn Tiến Phương',20213127,N'Vũng Tàu','2003-10-29',N'Nam',N'TỰ NHIÊN',N'A00',8,7,7),
(N'TS10',N'Bùi Ngọc Quần',20213147,N'Lạng Sơn','2003-09-09',N'Nam',N'TỰ NHIÊN',N'A01',8,7,8),
(N'TS11',N'Hoàng Thạch Quần',20213219,N'Sơn La','2003-10-02',N'Nam',N'TỰ NHIÊN',N'C01',7,7,7),
(N'TS12',N'Trần Trí Quý',202131096,N'Đà Nẵng','2003-12-14',N'Nam',N'TỰ NHIÊN',N'D01',8,9,6),
(N'TS13',N'Phạm Hồng Sáng',20213103,N'Vĩnh Phúc','2003-10-12',N'Nam',N'TỰ NHIÊN',N'A00',7,6,5),
(N'TS14',N'Trần Văn Sơn',20213199,N'Ninh Bình','2003-10-12',N'Nam',N'XÃ HỘI',N'A00',7,7,7),
(N'TS15',N'Nguyễn Trí Tân',20213089,N'Hà Nam','2003-03-02',N'Nam',N'XÃ HỘI',N'A01',6,7,8),
(N'TS16',N'Lê Xuân Thái',20213111,N'Hà Nội','2003-04-05',N'Nam',N'XÃ HỘI',N'C00',7,8,8),
(N'TS17',N'Phạm Đức Thắng',20213110,N'Thanh Hóa','2003-10-31',N'Nam',N'XÃ HỘI',N'D01',6,6,6),
(N'TS18',N'Nguyễn Thị Phương Thảo',20213220,N'Cà Mau','2003-07-29',N'Nữ',N'XÃ HỘI',N'A00',8,8,8),
(N'TS19',N'Bùi Xuân Thiện',20213088,N'Tp Hồ Chí Minh','2003-06-17',N'Nam',N'XÃ HỘI',N'A01',9,9,7),
(N'TS20',N'Nguyễn Thành Trung',20213105,N'Nghệ An','2003-05-23',N'Nam',N'XÃ HỘI',N'C00',8,9,6),
(N'TS21',N'Trần Đức Trường',20213146,N'Hà Tĩnh','2003-03-04',N'Nam',N'XÃ HỘI',N'D01',7,7,7),
(N'TS22',N'Vũ Anh Tú',20213178,N'Hòa Bình','2003-09-14',N'Nam',N'XÃ HỘI',N'A00',8,7,6),
(N'TS23',N'Nguyễn Mạnh Tuấn',20213099,N'Hải Dương','2003-08-11',N'Nam',N'XÃ HỘI',N'A00',7,7,7),
(N'TS24',N'Nguyễn Duy Tùng',20214056,N'Phú Thọ','2003-04-16',N'Nam',N'XÃ HỘI',N'A01',9,9,6),
(N'TS25',N'Đào Thuận Tường',20213182,N'Bắc Ninh','2003-08-31',N'Nam',N'XÃ HỘI',N'C00',8,7,7),
(N'TS26',N'Phạm Văn Tuyến',20213085,N'Thái Nguyên','2003-04-11',N'Nam',N'XÃ HỘI',N'D01',5,6,7),
(N'TS27',N'Nguyễn Ngọc Vi',20213200,N'Huế','2003-11-19',N'Nam',N'XÃ HỘI',N'A00',8,8,8),
(N'TS28',N'Hà Quang Vinh',20213166,N'Nam Định','2003-06-25',N'Nam',N'XÃ HỘI',N'A01',9,8,8),
(N'TS29',N'Bùi Thị Yến',20213093,N'Ninh Bình','2003-06-13',N'Nữ',N'XÃ HỘI',N'A02',7,8,7),
(N'TS30',N'Lê Xuân Khải',20214321,N'Mộc Châu','2003-06-06',N'Nam',N'XÃ HỘI',N'B00',8,7,6),
(N'TS31',N'Lê Thị Trang',20213000,N'Hà Giang','2003-11-11',N'Nữ',N'XÃ HỘI',N'A00',9,9,9),
(N'TS32',N'Lê Khách Chi',20213144,N'Sơn La','2003-05-09',N'Nữ',N'XÃ HỘI',N'A01',9,8,9),
(N'TS33',N'Trần Huyền Diệp',20214500,N'Hưng Yên','2003-07-08',N'Nữ',N'XÃ HỘI',N'A02',8,8,8),
(N'TS34',N'Lê Quang Tuấn Anh',20215678,N'Hòa Bình','2003-06-26',N'Nam',N'XÃ HỘI',N'B00',10,8,7),
(N'TS35',N'Văn Định Thuận',20213091,N'Vĩnh Phúc','2003-08-13',N'Nam',N'XÃ HỘI',N'B02',9,7,9),
(N'TS36',N'Nguyễn Văn Đức',20213177,N'Quảng Nam','2003-07-18',N'Nam',N'XÃ HỘI',N'B07',9,8,8);

INSERT INTO Nganh_Hoc(MaNganh,TenNganh,KhoiXetTuyen,DiemChuanTheoHocBa,DiemChuanTheoDiemThi,TieuChi)VALUES
(7480201,N'Công Nghệ Thông Tin',N'TỰ NHIÊN',25,22,10),
(7510205,N'Công Nghệ Kỹ Thuật Ô Tô',N'TỰ NHIÊN',25,21,8),
(7340101,N'Quản trị Kinh Doanh',N'XÃ HỘI',27,20,6),
(7540110,N'MARKETING',N'XÃ HỘI',27,22,7),
(7340301,N'Kế Toán',N'XÃ HỘI',25,20,6),
(7720201,N'Dược',N'XÃ HỘI',28,23,5),
(7720301,N'Điều Dưỡng',N'XÃ HỘI',26,23,6);

INSERT INTO Xet_Tuyen_Theo_Hoc_Ba_THPT(MaHocSinh,MaNganh,TongDiemBaMon)VALUES
(N'HS01',7480201,26),
(N'HS02',7480201,27),
(N'HS03',7480201,25),
(N'HS04',7480201,26),
(N'HS05',7480201,27),
(N'HS06',7480201,21),
(N'HS07',7480201,22),
(N'HS08',7480201,24),
(N'HS09',7510205,27),
(N'HS10',7510205,26),
(N'HS11',7510205,25),
(N'HS12',7510205,27),
(N'HS13',7510205,21),
(N'HS14',7340101,27),
(N'HS15',7340101,27),
(N'HS16',7340101,29),
(N'HS17',7340101,25),
(N'HS18',7540110,27),
(N'HS19',7540110,27),
(N'HS20',7540110,29),
(N'HS21',7540110,29),
(N'HS22',7540110,24),
(N'HS23',7340301,25),
(N'HS24',7340301,27),
(N'HS25',7340301,28),
(N'HS26',7340301,24),
(N'HS27',7720201,28),
(N'HS28',7720201,29),
(N'HS29',7720201,29),
(N'HS30',7720201,24);


INSERT INTO Xet_Tuyen_Theo_Diem_Thi_THPT(MaThiSinh,MaNganh,TongDiemBaMon)VALUES
(N'TS01',7480201,22),
(N'TS02',7480201,24),
(N'TS03',7480201,24),
(N'TS04',7480201,25),
(N'TS05',7480201,27),
(N'TS06',7480201,18),
(N'TS07',7480201,21),
(N'TS08',7480201,21),
(N'TS09',7510205,22),
(N'TS10',7510205,23),
(N'TS11',7510205,21),
(N'TS12',7510205,23),
(N'TS13',7510205,18),
(N'TS14',7340101,21),
(N'TS15',7340101,21),
(N'TS16',7340101,23),
(N'TS17',7340101,18),
(N'TS18',7540110,24),
(N'TS19',7540110,25),
(N'TS20',7540110,23),
(N'TS21',7540110,21),
(N'TS22',7540110,21),
(N'TS23',7340301,21),
(N'TS24',7340301,24),
(N'TS25',7340301,22),
(N'TS26',7340301,18),
(N'TS27',7720201,24),
(N'TS28',7720201,25),
(N'TS29',7720201,22),
(N'TS30',7720201,21),
(N'TS31',7720301,27),
(N'TS32',7720301,26),
(N'TS33',7720301,24),
(N'TS34',7720301,25),
(N'TS35',7720301,25),
(N'TS36',7720301,25);

-- select bảng xét tuyển theo học bạ 
SELECT Xet_Tuyen_Theo_Hoc_Ba_THPT.MaHocSinh,HoTen,Cccd,QueQuan,NamSinh,GioiTinh,Nganh_Hoc.MaNganh,Hoc_Ba_THPT.KhoiXetTuyen,ToHopMonXetTuyen,TongDiemBaMon,DiemChuanTheoHocBa FROM Xet_Tuyen_Theo_Hoc_Ba_THPT,Hoc_Ba_THPT,Nganh_Hoc WHERE Xet_Tuyen_Theo_Hoc_Ba_THPT.MaHocSinh=Hoc_Ba_THPT.MaHocSinh AND Xet_Tuyen_Theo_Hoc_Ba_THPT.MaNganh=Nganh_Hoc.MaNganh
-- select bảng xét tuyển theo điểm thi 
SELECT Xet_Tuyen_Theo_Diem_Thi_THPT.MaThiSinh,HoTen,Cccd,QueQuan,NamSinh,GioiTinh,Nganh_Hoc.MaNganh,Diem_Thi_THPT.KhoiXetTuyen,ToHopMonXetTuyen,TongDiemBaMon,DiemChuanTheoHocBa FROM Xet_Tuyen_Theo_Diem_Thi_THPT,Diem_Thi_THPT,Nganh_Hoc WHERE Xet_Tuyen_Theo_Diem_Thi_THPT.MaThiSinh=Diem_Thi_THPT.MaThiSinh AND Xet_Tuyen_Theo_Diem_Thi_THPT.MaNganh=Nganh_Hoc.MaNganh


-- tính số học sinh đậu theo học bạ
SELECT Xet_Tuyen_Theo_Hoc_Ba_THPT.MaHocSinh,HoTen,Cccd,QueQuan,NamSinh,GioiTinh,Nganh_Hoc.MaNganh,Hoc_Ba_THPT.KhoiXetTuyen,ToHopMonXetTuyen,TongDiemBaMon,DiemChuanTheoHocBa FROM Xet_Tuyen_Theo_Hoc_Ba_THPT,Hoc_Ba_THPT,Nganh_Hoc WHERE Xet_Tuyen_Theo_Hoc_Ba_THPT.MaHocSinh=Hoc_Ba_THPT.MaHocSinh AND Xet_Tuyen_Theo_Hoc_Ba_THPT.MaNganh=Nganh_Hoc.MaNganh AND Xet_Tuyen_Theo_Hoc_Ba_THPT.TongDiemBaMon>=Nganh_Hoc.DiemChuanTheoHocBa
-- số học sinh đậu theo điểm thi 
SELECT Xet_Tuyen_Theo_Diem_Thi_THPT.MaThiSinh,HoTen,Cccd,QueQuan,NamSinh,GioiTinh,Nganh_Hoc.MaNganh,Diem_Thi_THPT.KhoiXetTuyen,ToHopMonXetTuyen,TongDiemBaMon,DiemChuanTheoHocBa FROM Xet_Tuyen_Theo_Diem_Thi_THPT,Diem_Thi_THPT,Nganh_Hoc WHERE Xet_Tuyen_Theo_Diem_Thi_THPT.MaThiSinh=Diem_Thi_THPT.MaThiSinh AND Xet_Tuyen_Theo_Diem_Thi_THPT.MaNganh=Nganh_Hoc.MaNganh AND Xet_Tuyen_Theo_Diem_Thi_THPT.TongDiemBaMon>=Nganh_Hoc.DiemChuanTheoDiemThi


