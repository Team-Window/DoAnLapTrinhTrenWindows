USE [DoAnLapTrinhTrenWIndows]
GO
/****** Object:  Table [dbo].[dkcongviec]    Script Date: 19/05/2020 12:27:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dkcongviec](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[iduser] [int] NULL,
	[fname] [varchar](50) NULL,
	[lname] [varchar](50) NULL,
	[ngaydk] [date] NULL,
	[ca] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[dkcongviec] ON 

INSERT [dbo].[dkcongviec] ([id], [iduser], [fname], [lname], [ngaydk], [ca]) VALUES (1, 2, N'test', N'user02', CAST(N'2020-05-19' AS Date), 1)
INSERT [dbo].[dkcongviec] ([id], [iduser], [fname], [lname], [ngaydk], [ca]) VALUES (2, 2, N'test', N'user02', CAST(N'2020-05-18' AS Date), 1)
SET IDENTITY_INSERT [dbo].[dkcongviec] OFF
