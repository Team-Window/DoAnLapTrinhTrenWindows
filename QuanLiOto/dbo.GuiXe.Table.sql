USE [DoAnLapTrinhTrenWIndows]
GO
/****** Object:  Table [dbo].[GuiXe]    Script Date: 19/05/2020 12:27:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuiXe](
	[mave] [int] NOT NULL,
	[bienso] [nvarchar](50) NOT NULL,
	[loaixe] [nvarchar](20) NOT NULL,
	[hieuxe] [nvarchar](10) NULL,
	[hinhanh] [image] NOT NULL,
	[giovaoben] [time](7) NOT NULL,
	[ngayvaoben] [datetime] NOT NULL,
	[loaive] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[mave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
