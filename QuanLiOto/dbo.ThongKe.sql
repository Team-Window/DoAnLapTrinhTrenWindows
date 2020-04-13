CREATE TABLE [dbo].[ThongKe] (
    [mave]       INT           NOT NULL,
    [bienso]     NVARCHAR (50) NOT NULL,
    [loaixe]     NVARCHAR (10) NULL,
    [hieuxe]     NCHAR (10)    NULL,
    [hinhanh]    IMAGE         NULL,
    [giovaoben]  TIME (7)      NOT NULL,
    [ngayvaoben] DATETIME      NOT NULL,
    [gioraben]   TIME (7)      NOT NULL,
    [ngayraben]  DATETIME      NOT NULL,
    [tongtien]   INT           NOT NULL,
    [loaive]     NCHAR (10)    NULL,
    CONSTRAINT [PK_ThongKe] PRIMARY KEY CLUSTERED ([mave],[bienso] ASC)

);

