USE [DoAnLapTrinhTrenWIndows]
GO
/****** Object:  Table [dbo].[thanhtoanluong]    Script Date: 19/05/2020 12:27:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thanhtoanluong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[iduser] [int] NULL,
	[fname] [varchar](50) NULL,
	[lname] [varchar](50) NULL,
	[ngaylamviec] [date] NULL,
	[sogiolamviec] [float] NULL,
	[luong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[thanhtoanluong] ON 

INSERT [dbo].[thanhtoanluong] ([id], [iduser], [fname], [lname], [ngaylamviec], [sogiolamviec], [luong]) VALUES (1, 2, N'test', N'user02', CAST(N'2020-05-19' AS Date), 0.015315720811486244, 0)
SET IDENTITY_INSERT [dbo].[thanhtoanluong] OFF
