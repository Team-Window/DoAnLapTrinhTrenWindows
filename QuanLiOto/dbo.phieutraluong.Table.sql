USE [DoAnLapTrinhTrenWIndows]
GO
/****** Object:  Table [dbo].[phieutraluong]    Script Date: 19/05/2020 12:27:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieutraluong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[iduser] [int] NULL,
	[fname] [varchar](50) NULL,
	[lname] [varchar](50) NULL,
	[ngaylamviec] [date] NULL,
	[luong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
