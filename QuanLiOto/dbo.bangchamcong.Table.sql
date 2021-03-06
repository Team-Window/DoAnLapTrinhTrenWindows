USE [DoAnLapTrinhTrenWIndows]
GO
/****** Object:  Table [dbo].[bangchamcong]    Script Date: 19/05/2020 12:27:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bangchamcong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[iduser] [int] NULL,
	[giovaolam] [datetime] NULL,
	[giotanlam] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[bangchamcong] ON 

INSERT [dbo].[bangchamcong] ([id], [iduser], [giovaolam], [giotanlam]) VALUES (1, 2, CAST(N'2020-05-18T16:33:22.793' AS DateTime), CAST(N'2020-05-18T16:33:28.430' AS DateTime))
INSERT [dbo].[bangchamcong] ([id], [iduser], [giovaolam], [giotanlam]) VALUES (2, 2, CAST(N'2020-05-19T09:15:22.090' AS DateTime), CAST(N'2020-05-19T09:16:17.227' AS DateTime))
SET IDENTITY_INSERT [dbo].[bangchamcong] OFF
