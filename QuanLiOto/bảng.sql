USE [DoAnLapTrinhTrenWIndows]
GO
/****** Object:  Table [dbo].[ThongKe]    Script Date: 4/13/2020 8:11:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongKe](
	[mave] [int] NOT NULL,
	[bienso] [nvarchar](50) NULL,
	[loaixe] [nvarchar](10) NULL,
	[hieuxe] [nchar](10) NULL,
	[hinhanh] [image] NULL,
	[giovaoben] [time](7) NOT NULL,
	[ngayvaoben] [datetime] NOT NULL,
	[gioraben] [time](7) NOT NULL,
	[ngayraben] [datetime] NOT NULL,
	[tongtien] [int] NOT NULL,
	[loaive] [nchar](10) NULL,
 CONSTRAINT [PK_ThongKe] PRIMARY KEY CLUSTERED 
(
	[mave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
