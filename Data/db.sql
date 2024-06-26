USE [Restaurant]
GO
/****** Object:  Table [dbo].[Dish]    Script Date: 2024/5/9 11:04:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dish](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Dish] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Restaurant]    Script Date: 2024/5/9 11:04:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Restaurant](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Restaurant] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Dish] ON 

INSERT [dbo].[Dish] ([Id], [Name], [Category], [Price]) VALUES (1, N'杨枝甘露', N'饮品', CAST(10.09 AS Decimal(18, 2)))
INSERT [dbo].[Dish] ([Id], [Name], [Category], [Price]) VALUES (2, N'瑞幸咖啡', N'饮品', CAST(12.99 AS Decimal(18, 2)))
INSERT [dbo].[Dish] ([Id], [Name], [Category], [Price]) VALUES (3, N'肯德基', N'快餐', CAST(12.00 AS Decimal(18, 2)))
INSERT [dbo].[Dish] ([Id], [Name], [Category], [Price]) VALUES (4, N'麦当劳', N'快餐', CAST(10.09 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Dish] OFF
SET IDENTITY_INSERT [dbo].[Restaurant] ON 

INSERT [dbo].[Restaurant] ([Id], [Name], [Address], [Phone]) VALUES (1, N'九州饭店', N'湖北省武汉市', N'0755-1236985')
SET IDENTITY_INSERT [dbo].[Restaurant] OFF
