USE [QLHocSinh]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 2/29/2024 1:50:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[ID] [varchar](10) NOT NULL,
	[Name] [varchar](100) NULL,
	[Address] [varchar](255) NULL,
	[Cmnd] [varchar](100) NULL,
	[BornYear] [date] NULL,
	[Gender] [varchar](10) NULL,
	[Email] [varchar](50) NULL,
	[PhoneNumber] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 2/29/2024 1:50:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinh](
	[ID] [varchar](10) NOT NULL,
	[Name] [varchar](100) NULL,
	[Address] [varchar](255) NULL,
	[Cmnd] [varchar](100) NULL,
	[BornYear] [date] NULL,
	[Gender] [varchar](10) NULL,
	[Email] [varchar](50) NULL,
	[PhoneNumber] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[GiaoVien] ([ID], [Name], [Address], [Cmnd], [BornYear], [Gender], [Email], [PhoneNumber]) VALUES (N'1', N'Tran Vu Khanh', N'Le Van Viet', N'0183183', CAST(N'2004-10-17' AS Date), N'Nam', N'khanh@gmail.com', N'079-4821-201')
INSERT [dbo].[GiaoVien] ([ID], [Name], [Address], [Cmnd], [BornYear], [Gender], [Email], [PhoneNumber]) VALUES (N'2', N'Pham Danh Huong', N'ktx d2', N'123', CAST(N'1974-06-12' AS Date), N'nam', N'huong@gmail.com', N'033-5811-744')
INSERT [dbo].[GiaoVien] ([ID], [Name], [Address], [Cmnd], [BornYear], [Gender], [Email], [PhoneNumber]) VALUES (N'3', N'Le Dang Hieu', N'thu duc', N'123615155', CAST(N'2004-06-21' AS Date), N'nam', N'hieu@gmail.com', N'012-3456-789')
INSERT [dbo].[GiaoVien] ([ID], [Name], [Address], [Cmnd], [BornYear], [Gender], [Email], [PhoneNumber]) VALUES (N'4', N'Huynh Viet Dan', N'chung cu', N'56151', CAST(N'1974-06-11' AS Date), N'Nam', N'danhuynh@gmail.com', N'072-1511-511')
INSERT [dbo].[GiaoVien] ([ID], [Name], [Address], [Cmnd], [BornYear], [Gender], [Email], [PhoneNumber]) VALUES (N'5', N'Le Dinh Loc', N'quan 2', N'1235', CAST(N'1979-07-19' AS Date), N'Nam', N'loc@gmai.com', N'015-1566-375')
INSERT [dbo].[GiaoVien] ([ID], [Name], [Address], [Cmnd], [BornYear], [Gender], [Email], [PhoneNumber]) VALUES (N'6', N'Pham Ngoc Duy', N'lvv', N'0183183', CAST(N'2004-10-17' AS Date), N'nam', N'duysm17102004@gmail.com', N'045-1511-311')
GO
INSERT [dbo].[HocSinh] ([ID], [Name], [Address], [Cmnd], [BornYear], [Gender], [Email], [PhoneNumber]) VALUES (N'1', N'Pham Ngoc Duy', N'ktx', N'123', CAST(N'2004-10-17' AS Date), N'Nam', N'Duysm1123@gmail.com', N'079-4821-201')
INSERT [dbo].[HocSinh] ([ID], [Name], [Address], [Cmnd], [BornYear], [Gender], [Email], [PhoneNumber]) VALUES (N'10', N'Dang Hung Thinh', N'Quan10', N'5161', CAST(N'1990-10-23' AS Date), N'Nam', N'Thinh@gmai.l.c.o.m', N'015-1415-721')
INSERT [dbo].[HocSinh] ([ID], [Name], [Address], [Cmnd], [BornYear], [Gender], [Email], [PhoneNumber]) VALUES (N'2', N'Thao Vy', N'Xuan Hoa', N'01714731651', CAST(N'2004-07-24' AS Date), N'Nu', N'ThaoVy@gmail.com', N'086-1234-525')
INSERT [dbo].[HocSinh] ([ID], [Name], [Address], [Cmnd], [BornYear], [Gender], [Email], [PhoneNumber]) VALUES (N'3', N'Nguyen Huu Ngoc Lam', N'hoang dieu', N'123', CAST(N'2004-10-17' AS Date), N'Nam', N'lam@gmail.com', N'051-1346-161')
INSERT [dbo].[HocSinh] ([ID], [Name], [Address], [Cmnd], [BornYear], [Gender], [Email], [PhoneNumber]) VALUES (N'4', N'Pham Huong', N'ktx', N'123', CAST(N'1948-07-21' AS Date), N'Nam', N'huong1123@gmail.com', N'013-1511-141')
INSERT [dbo].[HocSinh] ([ID], [Name], [Address], [Cmnd], [BornYear], [Gender], [Email], [PhoneNumber]) VALUES (N'5', N'Dao Thanh Hieu', N'ktx d1', N'123', CAST(N'1948-07-21' AS Date), N'Nam', N'Hieu1123@gmail.com', N'015-1411-141')
INSERT [dbo].[HocSinh] ([ID], [Name], [Address], [Cmnd], [BornYear], [Gender], [Email], [PhoneNumber]) VALUES (N'6', N'Duy pham', N'ha tinh', N'123', CAST(N'1948-07-21' AS Date), N'Nam', N'Duysm1123@gmail.com', N'079-4111-202')
INSERT [dbo].[HocSinh] ([ID], [Name], [Address], [Cmnd], [BornYear], [Gender], [Email], [PhoneNumber]) VALUES (N'7', N'Huynh Dan', N'vinhome', N'415', CAST(N'2004-10-17' AS Date), N'Nam', N'dan0204@gmail.com', N'051-6167-131')
INSERT [dbo].[HocSinh] ([ID], [Name], [Address], [Cmnd], [BornYear], [Gender], [Email], [PhoneNumber]) VALUES (N'8', N'phamngoc duy', N'dong nai', N'123', CAST(N'1993-06-15' AS Date), N'nam', N'duy@g.com', N'079-4821-201')
INSERT [dbo].[HocSinh] ([ID], [Name], [Address], [Cmnd], [BornYear], [Gender], [Email], [PhoneNumber]) VALUES (N'9', N'Nguyen Cong Manh', N'Quan10', N'5161', CAST(N'1990-10-23' AS Date), N'Nam', N'Thinh@gmail.com', N'015-1415-721')
GO
