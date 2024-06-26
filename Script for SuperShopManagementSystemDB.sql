USE [master]
GO
/****** Object:  Database [SuperShopDB]    Script Date: 5/14/2024 9:05:49 PM ******/
CREATE DATABASE [SuperShopDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SuperShopDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SuperShopDB.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SuperShopDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SuperShopDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SuperShopDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SuperShopDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SuperShopDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SuperShopDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SuperShopDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SuperShopDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SuperShopDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SuperShopDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SuperShopDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SuperShopDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SuperShopDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SuperShopDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SuperShopDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SuperShopDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SuperShopDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SuperShopDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SuperShopDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SuperShopDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SuperShopDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SuperShopDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SuperShopDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SuperShopDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SuperShopDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SuperShopDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SuperShopDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SuperShopDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SuperShopDB] SET  MULTI_USER 
GO
ALTER DATABASE [SuperShopDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SuperShopDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SuperShopDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SuperShopDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SuperShopDB]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 5/14/2024 9:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[CatId] [int] IDENTITY(1,1) NOT NULL,
	[CatName] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Order]    Script Date: 5/14/2024 9:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[ProdId] [int] NULL,
	[CatId] [int] NULL,
	[Totalprice] [float] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 5/14/2024 9:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[ProdId] [int] IDENTITY(1,1) NOT NULL,
	[ProdLabel] [varchar](50) NOT NULL,
	[Category] [varchar](50) NULL,
	[Supplier] [varchar](50) NULL,
	[Status] [varchar](50) NOT NULL,
	[Unit] [int] NULL,
	[UnitPrice] [varchar](50) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProdId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 5/14/2024 9:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[SupId] [int] IDENTITY(1,1) NOT NULL,
	[SupName] [varchar](50) NOT NULL,
	[SupEmail] [varchar](50) NOT NULL,
	[SupContactNo] [varchar](50) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[SupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserInformation]    Script Date: 5/14/2024 9:05:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserInformation](
	[UserName] [varchar](30) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[Role] [varchar](10) NOT NULL,
	[Email] [varchar](30) NULL,
	[Address] [varchar](50) NULL,
	[ContactNo] [varchar](20) NULL,
 CONSTRAINT [PK_UserInformation] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (1, N'Fruits')
INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (2, N'Vegetables')
INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (3, N'Dairy')
INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (4, N'Meat')
INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (5, N'Fish')
INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (6, N'Frozen Food')
INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (7, N'Snacks')
INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (9, N'Household and Cleani')
INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (10, N'Personal care')
INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (11, N'Baby product')
INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (12, N'Hygiene')
INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (13, N'Bakery items')
INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (14, N'Canned food')
INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (15, N'Accessories')
INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (16, N'Clothes')
INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (20, N'Electronics')
INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (22, N'cosmatic items')
INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (24, N'Fragile')
INSERT [dbo].[Category] ([CatId], [CatName]) VALUES (25, N'Cleaning Product')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProdId], [ProdLabel], [Category], [Supplier], [Status], [Unit], [UnitPrice]) VALUES (1, N'Sprite', N'Drinks', N'CocaCola', N'In stock', 120, N'55')
INSERT [dbo].[Product] ([ProdId], [ProdLabel], [Category], [Supplier], [Status], [Unit], [UnitPrice]) VALUES (9, N'df', N'System.Data.DataRowView', N'', N'Out Of Stock', 0, N'100')
INSERT [dbo].[Product] ([ProdId], [ProdLabel], [Category], [Supplier], [Status], [Unit], [UnitPrice]) VALUES (10, N'fd', N'1', N'2', N'', 555, N'1000')
INSERT [dbo].[Product] ([ProdId], [ProdLabel], [Category], [Supplier], [Status], [Unit], [UnitPrice]) VALUES (11, N'Fresh water', N'Drinks', N'Fresh', N'In Stock', 500, N'20')
INSERT [dbo].[Product] ([ProdId], [ProdLabel], [Category], [Supplier], [Status], [Unit], [UnitPrice]) VALUES (12, N'ff', N'1', N'2', N'', 50, N'100')
INSERT [dbo].[Product] ([ProdId], [ProdLabel], [Category], [Supplier], [Status], [Unit], [UnitPrice]) VALUES (13, N'ggll', N'System.Data.DataRowView', N'System.Data.DataRowView', N'In stock', 100, N'100')
INSERT [dbo].[Product] ([ProdId], [ProdLabel], [Category], [Supplier], [Status], [Unit], [UnitPrice]) VALUES (14, N'frrr', N'3', N'3', N'', 0, N'120')
INSERT [dbo].[Product] ([ProdId], [ProdLabel], [Category], [Supplier], [Status], [Unit], [UnitPrice]) VALUES (15, N'Mojo', N'System.Data.DataRowView', N'System.Data.DataRowView', N'In stock', 100, N'45')
INSERT [dbo].[Product] ([ProdId], [ProdLabel], [Category], [Supplier], [Status], [Unit], [UnitPrice]) VALUES (16, N'mojo', N'System.Data.DataRowView', N'System.Data.DataRowView', N'In stock', 100, N'50')
INSERT [dbo].[Product] ([ProdId], [ProdLabel], [Category], [Supplier], [Status], [Unit], [UnitPrice]) VALUES (17, N'mango', N'System.Data.DataRowView', N'System.Data.DataRowView', N'Out Of Stock', 0, N'100')
INSERT [dbo].[Product] ([ProdId], [ProdLabel], [Category], [Supplier], [Status], [Unit], [UnitPrice]) VALUES (18, N'gg', N'Vegetables', N'System.Data.DataRowView', N'In stock', 50, N'100')
INSERT [dbo].[Product] ([ProdId], [ProdLabel], [Category], [Supplier], [Status], [Unit], [UnitPrice]) VALUES (19, N'rf', N'Fruits', N'Wow Food', N'', 100, N'150')
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[Supplier] ON 

INSERT [dbo].[Supplier] ([SupId], [SupName], [SupEmail], [SupContactNo]) VALUES (2, N'Unilever2', N'unilever@brand.com', N'5645585567')
INSERT [dbo].[Supplier] ([SupId], [SupName], [SupEmail], [SupContactNo]) VALUES (3, N'CocaCola', N'cocagola@dmail.com', N'1234568')
INSERT [dbo].[Supplier] ([SupId], [SupName], [SupEmail], [SupContactNo]) VALUES (5, N'Fuad Bakery', N'fuad@bakery.com', N'1235877458')
INSERT [dbo].[Supplier] ([SupId], [SupName], [SupEmail], [SupContactNo]) VALUES (6, N'Akij Company', N'akij@gmail.com', N'45666')
INSERT [dbo].[Supplier] ([SupId], [SupName], [SupEmail], [SupContactNo]) VALUES (7, N'Wow Food', N'wowfood@yahoo.com', N'125555555')
INSERT [dbo].[Supplier] ([SupId], [SupName], [SupEmail], [SupContactNo]) VALUES (10, N'basundhara', N'basundhara@gmail.com', N'11111111111')
SET IDENTITY_INSERT [dbo].[Supplier] OFF
INSERT [dbo].[UserInformation] ([UserName], [Password], [Role], [Email], [Address], [ContactNo]) VALUES (N'admin', N'admin123', N'admin', N'admin@supershop.com', N'Banani,Dhaka', N'01235645448')
INSERT [dbo].[UserInformation] ([UserName], [Password], [Role], [Email], [Address], [ContactNo]) VALUES (N'admin5', N'admin123', N'Admin', N'admin5@supershop.com', N'Dhaka', N'0171544559')
INSERT [dbo].[UserInformation] ([UserName], [Password], [Role], [Email], [Address], [ContactNo]) VALUES (N'admin7', N'123', N'Admin', N'admin9@supershop.com', N'Dhaka', N'0171544559')
INSERT [dbo].[UserInformation] ([UserName], [Password], [Role], [Email], [Address], [ContactNo]) VALUES (N'admin8', N'123', N'Admin', N'admin5@supershop.com', N'Dhaka', N'0171544559')
INSERT [dbo].[UserInformation] ([UserName], [Password], [Role], [Email], [Address], [ContactNo]) VALUES (N'ahnaf', N'123', N'Seller', N'ahnaf@gmail.com', N'', N'')
INSERT [dbo].[UserInformation] ([UserName], [Password], [Role], [Email], [Address], [ContactNo]) VALUES (N'ahnafz', N'1234', N'Admin', N'ah', N'dhaka ', N'011111111')
INSERT [dbo].[UserInformation] ([UserName], [Password], [Role], [Email], [Address], [ContactNo]) VALUES (N'nirjhar', N'123', N'Admin', N'nirjhar@gmail.com', N'', N'')
INSERT [dbo].[UserInformation] ([UserName], [Password], [Role], [Email], [Address], [ContactNo]) VALUES (N'seller', N'seller123', N'seller', N'seller@supershop.com', N'Dhaka', NULL)
INSERT [dbo].[UserInformation] ([UserName], [Password], [Role], [Email], [Address], [ContactNo]) VALUES (N'seller2', N'123', N'Admin', N'seller2@supershop.com', N'Dhaka', N'0171544559')
INSERT [dbo].[UserInformation] ([UserName], [Password], [Role], [Email], [Address], [ContactNo]) VALUES (N'seller3', N'123', N'Seller', N'seller3@supershop.com', N'Dhaka', N'0171544559')
INSERT [dbo].[UserInformation] ([UserName], [Password], [Role], [Email], [Address], [ContactNo]) VALUES (N'user777', N'123', N'Seller', N'user777@gmail.com', N'', N'')
INSERT [dbo].[UserInformation] ([UserName], [Password], [Role], [Email], [Address], [ContactNo]) VALUES (N'zawad', N'12345', N'Seller', N'zawad@gmail.com', N'', N'')
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Order] FOREIGN KEY([CatId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Order]
GO
USE [master]
GO
ALTER DATABASE [SuperShopDB] SET  READ_WRITE 
GO
