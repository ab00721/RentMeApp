﻿USE [master]
GO
/****** Object:  Database [cs6232-g5]    Script Date: 5/1/2024 10:08:33 PM ******/
CREATE DATABASE [cs6232-g5]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cs6232-g5', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\cs6232-g5.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cs6232-g5_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\cs6232-g5_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [cs6232-g5] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cs6232-g5].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cs6232-g5] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cs6232-g5] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cs6232-g5] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cs6232-g5] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cs6232-g5] SET ARITHABORT OFF 
GO
ALTER DATABASE [cs6232-g5] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cs6232-g5] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cs6232-g5] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cs6232-g5] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cs6232-g5] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cs6232-g5] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cs6232-g5] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cs6232-g5] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cs6232-g5] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cs6232-g5] SET  DISABLE_BROKER 
GO
ALTER DATABASE [cs6232-g5] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cs6232-g5] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cs6232-g5] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cs6232-g5] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cs6232-g5] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cs6232-g5] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cs6232-g5] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cs6232-g5] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [cs6232-g5] SET  MULTI_USER 
GO
ALTER DATABASE [cs6232-g5] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cs6232-g5] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cs6232-g5] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cs6232-g5] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cs6232-g5] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cs6232-g5] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'cs6232-g5', N'ON'
GO
ALTER DATABASE [cs6232-g5] SET QUERY_STORE = ON
GO
ALTER DATABASE [cs6232-g5] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [cs6232-g5]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 5/1/2024 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Category] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Category] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 5/1/2024 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1000,1) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[Sex] [char](1) NULL,
	[DateOfBirth] [date] NOT NULL,
	[AddressLine1] [varchar](50) NOT NULL,
	[AddressLine2] [varchar](50) NULL,
	[City] [varchar](20) NOT NULL,
	[State] [char](2) NOT NULL,
	[Zip] [varchar](5) NOT NULL,
	[Phone] [varchar](20) NULL,
	[IsAdmin] [int] NOT NULL,
	[Username] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Employee_1] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Furniture]    Script Date: 5/1/2024 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Furniture](
	[FurnitureID] [int] IDENTITY(100,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [text] NOT NULL,
	[Category] [varchar](25) NOT NULL,
	[Style] [varchar](25) NOT NULL,
	[DailyRate] [decimal](10, 2) NOT NULL,
	[TotalQuantity] [int] NOT NULL,
	[InStockQuantity] [int] NOT NULL,
 CONSTRAINT [PK_Furniture] PRIMARY KEY CLUSTERED 
(
	[FurnitureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 5/1/2024 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[Username] [varchar](50) NOT NULL,
	[Password] [varbinary](64) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 5/1/2024 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberID] [int] IDENTITY(100,1) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[Sex] [char](1) NULL,
	[DateOfBirth] [date] NOT NULL,
	[AddressLine1] [varchar](50) NOT NULL,
	[AddressLine2] [varchar](50) NULL,
	[City] [varchar](20) NOT NULL,
	[State] [char](2) NOT NULL,
	[Zip] [varchar](5) NOT NULL,
	[Phone] [varchar](20) NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalLineItem]    Script Date: 5/1/2024 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalLineItem](
	[RentalLineItemID] [int] IDENTITY(1,1) NOT NULL,
	[RentalTransactionID] [int] NOT NULL,
	[FurnitureID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[QuantityReturned] [int] NOT NULL,
	[DailyCost] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_RentalLineItem] PRIMARY KEY CLUSTERED 
(
	[RentalLineItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalTransaction]    Script Date: 5/1/2024 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalTransaction](
	[RentalTransactionID] [int] IDENTITY(10000,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[MemberID] [int] NOT NULL,
	[RentalDate] [date] NOT NULL,
	[DueDate] [date] NOT NULL,
	[TotalCost] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_RentalTransaction] PRIMARY KEY CLUSTERED 
(
	[RentalTransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnLineItem]    Script Date: 5/1/2024 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnLineItem](
	[ReturnLineItemID] [int] IDENTITY(1,1) NOT NULL,
	[RentalLineItemID] [int] NOT NULL,
	[ReturnTransactionID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[DailyCost] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_ReturnLineItem] PRIMARY KEY CLUSTERED 
(
	[ReturnLineItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnTransaction]    Script Date: 5/1/2024 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnTransaction](
	[ReturnTransactionID] [int] IDENTITY(10000,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[MemberID] [int] NOT NULL,
	[ReturnDate] [date] NOT NULL,
	[TotalCost] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_ReturnTransaction] PRIMARY KEY CLUSTERED 
(
	[ReturnTransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Style]    Script Date: 5/1/2024 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Style](
	[Style] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Style] PRIMARY KEY CLUSTERED 
(
	[Style] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Category] ([Category]) VALUES (N'Armchair')
INSERT [dbo].[Category] ([Category]) VALUES (N'Bed')
INSERT [dbo].[Category] ([Category]) VALUES (N'Bookshelf')
INSERT [dbo].[Category] ([Category]) VALUES (N'Crib')
INSERT [dbo].[Category] ([Category]) VALUES (N'Desk')
INSERT [dbo].[Category] ([Category]) VALUES (N'Dining chair')
INSERT [dbo].[Category] ([Category]) VALUES (N'Dresser')
INSERT [dbo].[Category] ([Category]) VALUES (N'Futon')
INSERT [dbo].[Category] ([Category]) VALUES (N'Loveseat')
INSERT [dbo].[Category] ([Category]) VALUES (N'Nightstand')
INSERT [dbo].[Category] ([Category]) VALUES (N'Office chair')
INSERT [dbo].[Category] ([Category]) VALUES (N'Ottoman')
INSERT [dbo].[Category] ([Category]) VALUES (N'Sofa')
INSERT [dbo].[Category] ([Category]) VALUES (N'Table')
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone], [IsAdmin], [Username]) VALUES (1027, N'Smith', N'Jane', N'F', CAST(N'1969-12-31' AS Date), N'123 Main St.', NULL, N'Atlanta', N'GA', N'30317', N'404-555-1234', 1, N'jane')
INSERT [dbo].[Employee] ([EmployeeID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone], [IsAdmin], [Username]) VALUES (1028, N'Barbero', N'David', N'M', CAST(N'2024-01-01' AS Date), N'University of West Georgia', N'1601 Maple St.', N'Carrollton', N'GA', N'30118', N'678-839-5000', 1, N'david')
INSERT [dbo].[Employee] ([EmployeeID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone], [IsAdmin], [Username]) VALUES (1029, N'Blood', N'Anna', N'F', CAST(N'2024-01-01' AS Date), N'University of West Georgia', N'1601 Maple St.', N'Carrollton', N'GA', N'30118', N'678-839-5000', 1, N'anna')
INSERT [dbo].[Employee] ([EmployeeID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone], [IsAdmin], [Username]) VALUES (1030, N'Maxwell', N'Justin', N'M', CAST(N'2024-01-01' AS Date), N'University of West Georgia', N'1601 Maple St.', N'Carrollton', N'GA', N'30118', N'678-839-5000', 1, N'justin')
INSERT [dbo].[Employee] ([EmployeeID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone], [IsAdmin], [Username]) VALUES (1031, N'Babbage', N'Bella', N'F', CAST(N'1973-09-23' AS Date), N'2465 Vanderbilt Ave', NULL, N'St. Louis', N'MO', N'63116', N'314-555-1234', 0, N'babbage')
INSERT [dbo].[Employee] ([EmployeeID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone], [IsAdmin], [Username]) VALUES (1032, N'Curie', N'Casey', NULL, CAST(N'1985-07-14' AS Date), N'574 Purdue Dr', NULL, N'Webster Groves', N'MO', N'63119', N'314-555-5678', 0, N'curie')
INSERT [dbo].[Employee] ([EmployeeID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone], [IsAdmin], [Username]) VALUES (1033, N'Goodall', N'Grace', N'F', CAST(N'1978-03-30' AS Date), N'732 Tulane Rd', N'Apt. 6B', N'Creve Coeur', N'MO', N'63141', N'314-555-2468', 0, N'goodall')
INSERT [dbo].[Employee] ([EmployeeID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone], [IsAdmin], [Username]) VALUES (1034, N'Kepler', N'Kiki', N'F', CAST(N'1992-11-05' AS Date), N'19 Syracuse Blvd', NULL, N'St. Peters', N'MO', N'63376', N'636-555-9876', 0, N'kepler')
INSERT [dbo].[Employee] ([EmployeeID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone], [IsAdmin], [Username]) VALUES (1035, N'Oppenheimer', N'Oscar', N'M', CAST(N'1970-06-12' AS Date), N'8733 Stanford St', N'Suite 303', N'Belleville', N'IL', N'62220', N'618-555-3141', 0, N'oppenheimer')
INSERT [dbo].[Employee] ([EmployeeID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone], [IsAdmin], [Username]) VALUES (1036, N'Sagan', N'Skylar', N'F', CAST(N'1998-04-17' AS Date), N'997 Rice Way', NULL, N'San Juan', N'PR', N'00909', N'787-555-9517', 0, N'sagan')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Furniture] ON 

INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (101, N'Classic Armchair', N'A conventional armchair that seats one person. Fits into a family rooms decorated with traditional furnishings.', N'Armchair', N'Traditional', CAST(3.10 AS Decimal(10, 2)), 20, 8)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (102, N'Country Armchair', N'An old-fashioned armchair that seats one person. Looks good in a family room setting with rustic décor.', N'Armchair', N'Rustic', CAST(2.50 AS Decimal(10, 2)), 2, 2)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (103, N'Retro Armchair', N'A throwback accent chair that is suited for one person sitting. Ideal in a living room for a funky 1970s vibe.', N'Armchair', N'Vintage', CAST(4.50 AS Decimal(10, 2)), 16, 8)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (104, N'Mod Bed', N'A streamlined Queen-sized bed with mattress and boxed spring set. Accommodates one or two persons for a tranquil sleep experience.', N'Bed', N'Modern', CAST(8.10 AS Decimal(10, 2)), 8, 6)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (105, N'Simple Bed', N'A standard King-sized bed with mattress and boxed spring set. Accommodates two persons for a reliable bedtime ritual.', N'Bed', N'Contemporary', CAST(9.20 AS Decimal(10, 2)), 7, 3)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (106, N'Seaside Bed', N'An oceanic-print Full-sized bed with foam mattress only. Fits one person for good slumber in a vacation home.', N'Bed', N'Coastal', CAST(7.60 AS Decimal(10, 2)), 1, 0)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (107, N'Swedish Bookshelf', N'A five-shelf minimal bookshelf provides a sturdy and spacious way to organize a library or display trinkets.', N'Bookshelf', N'Minimalist', CAST(1.55 AS Decimal(10, 2)), 10, 4)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (108, N'Seaside Bookshelf', N'A 3-shelf safari-themed bookshelf. Designed to hold family photos or store a collection of paperbacks for beach reading.', N'Bookshelf', N'Coastal', CAST(1.85 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (109, N'Classic Crib', N'Safety is the priority for this crib. This item fits well in a nursery decorated with traditional furniture.', N'Crib', N'Traditional', CAST(3.55 AS Decimal(10, 2)), 2, 1)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (110, N'Simple Crib', N'A standard baby''s crib. The best-selling crib on the market. Guaranteed to keep a newborn secure.', N'Crib', N'Contemporary', CAST(3.15 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (111, N'Swedish Desk', N'Part of the Swedish Minimalist collection. This cost-saving desk must be assembled by the buyer.', N'Desk', N'Minimalist', CAST(2.25 AS Decimal(10, 2)), 8, 7)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (112, N'Swedish Dining Chair', N'A minimal dining chair with no arm supports. Seats one. Recommend 4 or 6 chairs per dining set.', N'Dining chair', N'Minimalist', CAST(1.00 AS Decimal(10, 2)), 44, 36)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (113, N'Seaside Dining Chair', N'A sailing-themed dining chair with arm supports. Seats one. Recommend 4 or 6 chairs per dining set.', N'Dining chair', N'Coastal', CAST(1.25 AS Decimal(10, 2)), 24, 11)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (114, N'Retro Dining Chair', N'A 1970s-inspired dining chair with no arm supports. Seats one. Recommend 4 chairs per dining set.', N'Dining chair', N'Vintage', CAST(1.30 AS Decimal(10, 2)), 48, 36)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (115, N'Mod Dresser', N'A sleek 4-drawer vertical dresser. Goes well with bedroom sets containing modern beds and nightstands.', N'Dresser', N'Modern', CAST(4.20 AS Decimal(10, 2)), 10, 8)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (116, N'Simple Dresser', N'A standard 6-drawer horizontal dresser. The default option for a dresser of the contemporary variety.', N'Dresser', N'Contemporary', CAST(4.10 AS Decimal(10, 2)), 8, 8)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (117, N'Seaside Dresser', N'A five-drawer dresser designed for a vacation spot. Ideal for bedrooms filled with coastal-style merchandise.', N'Dresser', N'Coastal', CAST(4.05 AS Decimal(10, 2)), 13, 11)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (118, N'Mod Futon', N'A no-frills futon. Converts easily between sofa and bed functions. Seats three or sleeps one.', N'Futon', N'Modern', CAST(3.50 AS Decimal(10, 2)), 0, 0)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (119, N'Swedish Futon', N'A minimal futon. Switches quickly between seating and sleeping purposes.', N'Futon', N'Minimalist', CAST(3.00 AS Decimal(10, 2)), 10, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (120, N'Classic Loveseat', N'A conventional loveseat that seats two persons. Fits into a family room decorated with traditional furnishings.', N'Loveseat', N'Traditional', CAST(4.50 AS Decimal(10, 2)), 10, 8)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (121, N'Country Loveseat', N'A rural-style loveseat that seats two persons. Fits into a family room filled with other rustic items.', N'Loveseat', N'Rustic', CAST(3.60 AS Decimal(10, 2)), 4, 3)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (122, N'Retro Loveseat', N'An avocado-colored loveseat suitable for 2-person seating. Ideal for a room with a disco-era feeling.', N'Loveseat', N'Vintage', CAST(2.60 AS Decimal(10, 2)), 14, 13)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (123, N'Mod Nightstand', N'A streamlined bedside table with no drawers. Recommend two nightstands per bedroom.', N'Nightstand', N'Modern', CAST(2.90 AS Decimal(10, 2)), 12, 8)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (124, N'Simple Nightstand', N'A standard nightstand with 2-drawer storage capability. Recommend two nightstands per bedroom.', N'Nightstand', N'Contemporary', CAST(2.85 AS Decimal(10, 2)), 8, 5)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (125, N'Seaside Nightstand', N'A safari-themed nightstand with one drawer for storage. Recommend two nightstands per bedroom.', N'Nightstand', N'Coastal', CAST(2.25 AS Decimal(10, 2)), 12, 11)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (126, N'Swedish Office Chair', N'Part of the Swedish Minimalist collection. This cost-saving office chair must be assembled by the buyer.', N'Office chair', N'Minimalist', CAST(1.90 AS Decimal(10, 2)), 7, 6)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (127, N'Classic Ottoman', N'A conventional ottoman. Built to match the Classic Armchair.', N'Ottoman', N'Traditional', CAST(1.40 AS Decimal(10, 2)), 3, 2)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (128, N'Country Ottoman', N'An old-fashioned oversized footrest. Rugged upholstery. Looks great in any farmhouse.', N'Ottoman', N'Rustic', CAST(1.60 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (129, N'Retro Ottoman', N'A kitschy, vinyl ottoman reminiscent of the 1970s. Built to match the Retro Armchair.', N'Ottoman', N'Vintage', CAST(1.50 AS Decimal(10, 2)), 16, 13)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (130, N'Classic Sofa', N'A conventional couch that accommodates seating 3 persons. Perfect for family rooms decorated with traditional furnishings.', N'Sofa', N'Traditional', CAST(5.50 AS Decimal(10, 2)), 5, 2)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (131, N'Country Sofa', N'An old-fashioned couch that accommodates seating 4 persons. Great for family rooms decorated with rustic items.', N'Sofa', N'Rustic', CAST(4.50 AS Decimal(10, 2)), 7, 4)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (132, N'Retro Sofa', N'A 1970s-era couch that accommodates seating 3 persons. Works well in family rooms containing other vintage furnishings.', N'Sofa', N'Vintage', CAST(5.20 AS Decimal(10, 2)), 4, 2)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (133, N'Swedish Table', N'A minimal dining table. Seats six persons with leaf or four persons without leaf.', N'Table', N'Minimalist', CAST(3.80 AS Decimal(10, 2)), 8, 6)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (134, N'Seaside Table', N'A sailing-themed dining table well-suited for 4-6 vacationers. Good for family meals at the lake house.', N'Table', N'Coastal', CAST(4.00 AS Decimal(10, 2)), 3, 0)
SET IDENTITY_INSERT [dbo].[Furniture] OFF
GO
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'anna', 0xA70F9E38FF015AFAA9AB0AACABEE2E13)
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'babbage', 0x54A28E933E22FBABF29E267DD3F5C908)
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'curie', 0x128D1CAF36BC17CBA3A9AA7371A544EA)
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'david', 0x172522EC1028AB781D9DFD17EACA4427)
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'goodall', 0x65ABA82AC5DB373AEB287E476E100430)
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'jane', 0x16D7A4FCA7442DDA3AD93C9A726597E4)
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'justin', 0x53DD9C6005F3CDFC5A69C5C07388016D)
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'kepler', 0x381A32D9DBA66B89D38AB02181A7334D)
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'oppenheimer', 0xBB2161E6DE3062852E1FB433270F6D8A)
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'sagan', 0xF48E3EDD3841E27191F508F8369F762F)
GO
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (100, N'Ash', N'Andrew', N'M', CAST(N'1982-07-15' AS Date), N'587 Pepperdine Ave.', NULL, N'Marietta', N'GA', N'30006', N'404-555-0101')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (101, N'Birch', N'Bella', N'F', CAST(N'1995-11-29' AS Date), N'3241 Baylor Blvd.', N'Apt. 3B', N'Decatur', N'GA', N'30030', N'404-555-0202')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (102, N'Cedar', N'Chloe', N'F', CAST(N'1978-04-03' AS Date), N'396 Marquette St.', N'Basement', N'Alpharetta', N'GA', N'30004', N'470-555-0303')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (103, N'Dogwood', N'Dee', N'F', CAST(N'1987-09-21' AS Date), N'725 Gonzaga Way', NULL, N'Roswell', N'GA', N'30075', N'678-555-0404')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (104, N'Elm', N'Emily', N'F', CAST(N'2000-06-09' AS Date), N'8843 DePaul Rd.', NULL, N'Sandy Springs', N'GA', N'30328', N'404-555-0505')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (105, N'Forest', N'Franklin', N'M', CAST(N'1992-03-12' AS Date), N'512 Creighton Ave.', NULL, N'Lawrenceville', N'GA', N'30042', NULL)
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (106, N'Geranium', N'George', N'M', CAST(N'1985-10-05' AS Date), N'679 Xavier Blvd.', NULL, N'Duluth', N'GA', N'30095', N'770-555-0707')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (107, N'Hawthorn', N'Henry', N'M', CAST(N'1973-12-18' AS Date), N'137 Loyola Dr.', NULL, N'Norcross', N'GA', N'30003', N'404-555-0808')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (108, N'Juniper', N'Jordan', NULL, CAST(N'1980-08-27' AS Date), N'86 Fordham Way', N'Suite 201', N'Johns Creek', N'GA', N'30005', N'404-555-0909')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (109, N'Jasper', N'Jose', N'M', CAST(N'2003-01-06' AS Date), N'943 Belmont Rd.', NULL, N'Smyrna', N'GA', N'30080', N'404-555-1010')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (110, N'Kudzu', N'Kim', N'F', CAST(N'1998-05-24' AS Date), N'268 Butler St.', NULL, N'Kennesaw', N'GA', N'30144', N'678-555-1111')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (111, N'Lilac', N'Liam', N'M', CAST(N'1989-02-11' AS Date), N'507 Villanova Blvd.', NULL, N'Woodstock', N'GA', N'30188', NULL)
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (112, N'Maple', N'Madison', N'F', CAST(N'1976-07-30' AS Date), N'7731 Providence Ave.', N'Apartment 202A', N'Conyers', N'GA', N'30012', N'404-555-1313')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (113, N'Narcissus', N'Noah', N'M', CAST(N'1983-11-02' AS Date), N'682 Dayton Way', NULL, N'Stone Mountain', N'GA', N'30083', N'470-555-1414')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (114, N'Orchid', N'Olivia', N'F', CAST(N'1990-09-09' AS Date), N'524 Bradley St.', NULL, N'Tucker', N'GA', N'30084', NULL)
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (115, N'Poplar', N'Patrick', N'F', CAST(N'1971-04-17' AS Date), N'3559 Saint Louis Rd.', N'Unit D', N'Acworth', N'GA', N'30101', N'404-555-1616')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (116, N'Rose', N'Rachael', N'F', CAST(N'2001-10-22' AS Date), N'785 Drake Ave.', N'Apt. 4', N'Parkville', N'MD', N'21234', N'443-555-1717')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (117, N'Redwood', N'Rene', N'F', CAST(N'1984-06-05' AS Date), N'912 Canisius Blvd.', NULL, N'Buford', N'GA', N'30515', N'678-555-1818')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (118, N'Spruce', N'Sophia', N'F', CAST(N'1979-12-08' AS Date), N'643 Saint Joseph Way', NULL, N'Suwanee', N'GA', N'30024', N'404-555-1919')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (119, N'Tulip', N'Taylor', NULL, CAST(N'1997-08-13' AS Date), N'199 Belmont Dr.', NULL, N'Collierville', N'TN', N'38017', N'901-555-1515')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (120, N'Thistle', N'Trey', N'M', CAST(N'1974-01-28' AS Date), N'5468 Seton Hall Blvd.', N'Condo #504', N'Loganville', N'GA', N'30052', N'404-555-2121')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (121, N'Violet', N'Vera', N'F', CAST(N'1981-03-19' AS Date), N'749 Duquesne Blvd.', NULL, N'Mission Viejo', N'CA', N'92691', N'714-555-2222')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (122, N'Willow', N'William', N'M', CAST(N'1993-05-10' AS Date), N'27 Valparaiso Ave.', NULL, N'Peachtree City', N'GA', N'30269', N'404-555-2323')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (123, N'Yarrow', N'Yasmine', N'F', CAST(N'1985-03-14' AS Date), N'341 Santa Clara Blvd.', NULL, N'Charlotte Amalie', N'VI', N'00801', N'340-555-2424')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (124, N'Maxwell', N'Justin', N'M', CAST(N'2003-04-30' AS Date), N'123 Main St.', NULL, N'Woodstock', N'GA', N'30000', N'123-456-7899')
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET IDENTITY_INSERT [dbo].[RentalLineItem] ON 

INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (118, 10065, 101, 1, 0, CAST(3.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (119, 10065, 127, 1, 0, CAST(1.40 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (120, 10065, 130, 1, 0, CAST(5.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (121, 10065, 120, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (122, 10066, 103, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (123, 10066, 129, 1, 0, CAST(1.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (124, 10066, 122, 1, 0, CAST(2.60 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (125, 10066, 132, 1, 0, CAST(5.20 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (126, 10067, 111, 1, 0, CAST(2.25 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (127, 10067, 126, 1, 0, CAST(1.90 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (128, 10068, 104, 1, 1, CAST(8.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (129, 10068, 123, 2, 2, CAST(2.90 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (130, 10068, 115, 2, 2, CAST(4.20 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (131, 10069, 114, 12, 0, CAST(1.30 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (132, 10070, 134, 1, 0, CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (133, 10070, 113, 6, 0, CAST(1.25 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (134, 10071, 105, 1, 0, CAST(9.20 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (135, 10071, 124, 2, 0, CAST(2.85 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (136, 10071, 117, 2, 0, CAST(4.05 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (137, 10072, 133, 1, 0, CAST(3.80 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (138, 10072, 112, 4, 0, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (139, 10073, 104, 1, 0, CAST(8.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (140, 10073, 123, 2, 0, CAST(2.90 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (141, 10074, 131, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (142, 10075, 130, 1, 1, CAST(5.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (143, 10075, 120, 1, 1, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (144, 10076, 103, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (145, 10076, 129, 1, 0, CAST(1.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (146, 10077, 113, 2, 0, CAST(1.25 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (147, 10078, 134, 1, 0, CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (148, 10078, 113, 4, 0, CAST(1.25 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (149, 10079, 133, 1, 0, CAST(3.80 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (150, 10079, 112, 4, 0, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (151, 10080, 104, 1, 0, CAST(8.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (152, 10080, 123, 2, 0, CAST(2.90 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (153, 10081, 131, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (154, 10082, 130, 1, 0, CAST(5.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (155, 10083, 109, 1, 0, CAST(3.55 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (156, 10084, 132, 1, 0, CAST(5.20 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (157, 10084, 107, 4, 0, CAST(1.55 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (158, 10085, 113, 2, 1, CAST(1.25 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (159, 10086, 116, 1, 1, CAST(4.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (160, 10087, 111, 1, 1, CAST(2.25 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (161, 10087, 126, 1, 1, CAST(1.90 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (162, 10088, 123, 1, 1, CAST(2.90 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (163, 10089, 115, 2, 2, CAST(4.20 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (164, 10090, 131, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (165, 10091, 103, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (166, 10091, 129, 1, 0, CAST(1.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (167, 10092, 120, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (168, 10093, 134, 1, 0, CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (169, 10094, 107, 1, 0, CAST(1.55 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (170, 10095, 103, 2, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (171, 10095, 101, 3, 0, CAST(3.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (172, 10096, 105, 3, 0, CAST(9.20 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (173, 10096, 101, 6, 0, CAST(3.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (174, 10097, 124, 1, 0, CAST(2.85 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (175, 10097, 125, 1, 0, CAST(2.25 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (176, 10098, 101, 1, 0, CAST(3.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (177, 10098, 103, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (178, 10099, 103, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (179, 10099, 106, 1, 0, CAST(7.60 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (180, 10100, 101, 1, 0, CAST(3.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (181, 10101, 103, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (182, 10101, 107, 1, 0, CAST(1.55 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[RentalLineItem] OFF
GO
SET IDENTITY_INSERT [dbo].[RentalTransaction] ON 

INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10065, 1036, 100, CAST(N'2024-04-01' AS Date), CAST(N'2024-04-08' AS Date), CAST(101.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10066, 1035, 101, CAST(N'2024-04-01' AS Date), CAST(N'2024-05-01' AS Date), CAST(414.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10067, 1034, 102, CAST(N'2024-04-01' AS Date), CAST(N'2024-07-01' AS Date), CAST(377.65 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10068, 1033, 103, CAST(N'2024-04-01' AS Date), CAST(N'2024-09-28' AS Date), CAST(4014.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10069, 1032, 104, CAST(N'2024-04-01' AS Date), CAST(N'2025-04-01' AS Date), CAST(5694.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10070, 1031, 105, CAST(N'2024-04-01' AS Date), CAST(N'2024-04-08' AS Date), CAST(80.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10071, 1027, 106, CAST(N'2024-04-01' AS Date), CAST(N'2024-05-01' AS Date), CAST(690.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10072, 1036, 107, CAST(N'2024-04-01' AS Date), CAST(N'2024-07-01' AS Date), CAST(709.80 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10073, 1035, 108, CAST(N'2024-04-01' AS Date), CAST(N'2024-09-28' AS Date), CAST(2502.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10074, 1034, 109, CAST(N'2024-04-01' AS Date), CAST(N'2025-04-01' AS Date), CAST(1642.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10075, 1033, 110, CAST(N'2024-04-01' AS Date), CAST(N'2024-04-08' AS Date), CAST(70.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10076, 1032, 111, CAST(N'2024-04-01' AS Date), CAST(N'2024-05-01' AS Date), CAST(180.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10077, 1031, 112, CAST(N'2024-04-01' AS Date), CAST(N'2024-07-01' AS Date), CAST(227.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10078, 1027, 113, CAST(N'2024-04-01' AS Date), CAST(N'2024-09-28' AS Date), CAST(1620.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10079, 1036, 114, CAST(N'2024-04-01' AS Date), CAST(N'2025-04-01' AS Date), CAST(2847.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10080, 1035, 115, CAST(N'2024-04-01' AS Date), CAST(N'2024-04-08' AS Date), CAST(97.30 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10081, 1034, 116, CAST(N'2024-04-01' AS Date), CAST(N'2024-05-01' AS Date), CAST(135.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10082, 1033, 117, CAST(N'2024-04-01' AS Date), CAST(N'2024-07-01' AS Date), CAST(500.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10083, 1032, 118, CAST(N'2024-04-01' AS Date), CAST(N'2024-09-28' AS Date), CAST(639.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10084, 1031, 119, CAST(N'2024-04-01' AS Date), CAST(N'2025-04-01' AS Date), CAST(4161.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10085, 1027, 120, CAST(N'2024-04-01' AS Date), CAST(N'2024-04-02' AS Date), CAST(2.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10086, 1036, 121, CAST(N'2024-04-01' AS Date), CAST(N'2024-04-02' AS Date), CAST(4.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10087, 1035, 122, CAST(N'2024-04-01' AS Date), CAST(N'2024-04-02' AS Date), CAST(4.15 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10088, 1034, 123, CAST(N'2024-04-01' AS Date), CAST(N'2024-04-02' AS Date), CAST(2.90 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10089, 1033, 105, CAST(N'2024-04-01' AS Date), CAST(N'2024-04-02' AS Date), CAST(8.40 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10090, 1032, 112, CAST(N'2024-04-01' AS Date), CAST(N'2024-04-02' AS Date), CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10091, 1031, 114, CAST(N'2024-04-01' AS Date), CAST(N'2024-04-02' AS Date), CAST(6.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10092, 1027, 119, CAST(N'2024-04-01' AS Date), CAST(N'2024-07-01' AS Date), CAST(409.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10093, 1036, 121, CAST(N'2024-04-01' AS Date), CAST(N'2024-09-28' AS Date), CAST(720.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10094, 1035, 122, CAST(N'2024-04-01' AS Date), CAST(N'2025-04-01' AS Date), CAST(565.75 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10095, 1029, 104, CAST(N'2024-04-17' AS Date), CAST(N'2024-04-17' AS Date), CAST(18.30 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10096, 1029, 112, CAST(N'2024-04-17' AS Date), CAST(N'2024-04-17' AS Date), CAST(46.20 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10097, 1029, 116, CAST(N'2024-04-17' AS Date), CAST(N'2024-04-17' AS Date), CAST(5.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10098, 1030, 124, CAST(N'2024-04-30' AS Date), CAST(N'2024-05-02' AS Date), CAST(22.80 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10099, 1030, 124, CAST(N'2024-04-30' AS Date), CAST(N'2024-04-30' AS Date), CAST(12.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10100, 1030, 100, CAST(N'2024-04-30' AS Date), CAST(N'2024-04-30' AS Date), CAST(3.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10101, 1030, 124, CAST(N'2024-04-30' AS Date), CAST(N'2024-04-30' AS Date), CAST(6.05 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[RentalTransaction] OFF
GO
SET IDENTITY_INSERT [dbo].[ReturnLineItem] ON 

INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (25, 128, 10018, 1, CAST(8.10 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (26, 129, 10018, 2, CAST(5.80 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (27, 130, 10018, 2, CAST(8.40 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (28, 142, 10019, 1, CAST(5.50 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (29, 143, 10019, 1, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (30, 158, 10020, 1, CAST(1.25 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (31, 159, 10021, 1, CAST(4.10 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (32, 160, 10022, 1, CAST(2.25 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (33, 161, 10022, 1, CAST(1.90 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (34, 162, 10023, 1, CAST(2.90 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (35, 163, 10024, 2, CAST(8.40 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[ReturnLineItem] OFF
GO
SET IDENTITY_INSERT [dbo].[ReturnTransaction] ON 

INSERT [dbo].[ReturnTransaction] ([ReturnTransactionID], [EmployeeID], [MemberID], [ReturnDate], [TotalCost]) VALUES (10018, 1033, 103, CAST(N'2024-04-01' AS Date), CAST(-3991.70 AS Decimal(10, 2)))
INSERT [dbo].[ReturnTransaction] ([ReturnTransactionID], [EmployeeID], [MemberID], [ReturnDate], [TotalCost]) VALUES (10019, 1033, 110, CAST(N'2024-04-01' AS Date), CAST(-60.00 AS Decimal(10, 2)))
INSERT [dbo].[ReturnTransaction] ([ReturnTransactionID], [EmployeeID], [MemberID], [ReturnDate], [TotalCost]) VALUES (10020, 1031, 120, CAST(N'2024-04-01' AS Date), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[ReturnTransaction] ([ReturnTransactionID], [EmployeeID], [MemberID], [ReturnDate], [TotalCost]) VALUES (10021, 1036, 121, CAST(N'2024-04-01' AS Date), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[ReturnTransaction] ([ReturnTransactionID], [EmployeeID], [MemberID], [ReturnDate], [TotalCost]) VALUES (10022, 1035, 122, CAST(N'2024-04-01' AS Date), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[ReturnTransaction] ([ReturnTransactionID], [EmployeeID], [MemberID], [ReturnDate], [TotalCost]) VALUES (10023, 1032, 123, CAST(N'2024-04-01' AS Date), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[ReturnTransaction] ([ReturnTransactionID], [EmployeeID], [MemberID], [ReturnDate], [TotalCost]) VALUES (10024, 1034, 105, CAST(N'2024-04-01' AS Date), CAST(0.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[ReturnTransaction] OFF
GO
INSERT [dbo].[Style] ([Style]) VALUES (N'Coastal')
INSERT [dbo].[Style] ([Style]) VALUES (N'Contemporary')
INSERT [dbo].[Style] ([Style]) VALUES (N'Minimalist')
INSERT [dbo].[Style] ([Style]) VALUES (N'Modern')
INSERT [dbo].[Style] ([Style]) VALUES (N'Rustic')
INSERT [dbo].[Style] ([Style]) VALUES (N'Traditional')
INSERT [dbo].[Style] ([Style]) VALUES (N'Vintage')
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Login_Employee] FOREIGN KEY([Username])
REFERENCES [dbo].[Login] ([Username])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Login_Employee]
GO
ALTER TABLE [dbo].[Furniture]  WITH CHECK ADD  CONSTRAINT [FK_Category_Furniture] FOREIGN KEY([Category])
REFERENCES [dbo].[Category] ([Category])
GO
ALTER TABLE [dbo].[Furniture] CHECK CONSTRAINT [FK_Category_Furniture]
GO
ALTER TABLE [dbo].[Furniture]  WITH CHECK ADD  CONSTRAINT [FK_Style_Furniture] FOREIGN KEY([Style])
REFERENCES [dbo].[Style] ([Style])
GO
ALTER TABLE [dbo].[Furniture] CHECK CONSTRAINT [FK_Style_Furniture]
GO
ALTER TABLE [dbo].[RentalLineItem]  WITH CHECK ADD  CONSTRAINT [FK_Furniture_RentalLineItem] FOREIGN KEY([FurnitureID])
REFERENCES [dbo].[Furniture] ([FurnitureID])
GO
ALTER TABLE [dbo].[RentalLineItem] CHECK CONSTRAINT [FK_Furniture_RentalLineItem]
GO
ALTER TABLE [dbo].[RentalLineItem]  WITH CHECK ADD  CONSTRAINT [FK_RentalTransaction_RentalLineItem] FOREIGN KEY([RentalTransactionID])
REFERENCES [dbo].[RentalTransaction] ([RentalTransactionID])
GO
ALTER TABLE [dbo].[RentalLineItem] CHECK CONSTRAINT [FK_RentalTransaction_RentalLineItem]
GO
ALTER TABLE [dbo].[RentalTransaction]  WITH CHECK ADD  CONSTRAINT [FK_Employee_RentalTransaction] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[RentalTransaction] CHECK CONSTRAINT [FK_Employee_RentalTransaction]
GO
ALTER TABLE [dbo].[RentalTransaction]  WITH CHECK ADD  CONSTRAINT [FK_Member_RentalTransaction] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Member] ([MemberID])
GO
ALTER TABLE [dbo].[RentalTransaction] CHECK CONSTRAINT [FK_Member_RentalTransaction]
GO
ALTER TABLE [dbo].[ReturnLineItem]  WITH CHECK ADD  CONSTRAINT [FK_RentalLineItem_ReturnLineItem] FOREIGN KEY([RentalLineItemID])
REFERENCES [dbo].[RentalLineItem] ([RentalLineItemID])
GO
ALTER TABLE [dbo].[ReturnLineItem] CHECK CONSTRAINT [FK_RentalLineItem_ReturnLineItem]
GO
ALTER TABLE [dbo].[ReturnLineItem]  WITH CHECK ADD  CONSTRAINT [FK_ReturnTransaction_ReturnLineItem] FOREIGN KEY([ReturnTransactionID])
REFERENCES [dbo].[ReturnTransaction] ([ReturnTransactionID])
GO
ALTER TABLE [dbo].[ReturnLineItem] CHECK CONSTRAINT [FK_ReturnTransaction_ReturnLineItem]
GO
ALTER TABLE [dbo].[ReturnTransaction]  WITH CHECK ADD  CONSTRAINT [FK_Employee_ReturnTransaction] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[ReturnTransaction] CHECK CONSTRAINT [FK_Employee_ReturnTransaction]
GO
ALTER TABLE [dbo].[ReturnTransaction]  WITH CHECK ADD  CONSTRAINT [FK_Member_ReturnTransaction] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Member] ([MemberID])
GO
ALTER TABLE [dbo].[ReturnTransaction] CHECK CONSTRAINT [FK_Member_ReturnTransaction]
GO
/****** Object:  StoredProcedure [dbo].[getMostPopularFurnitureDuringDates]    Script Date: 5/1/2024 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Justin Maxwell
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[getMostPopularFurnitureDuringDates] 
	-- Add the parameters for the stored procedure here
	@start_date date, 
	@end_date date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @total_transactions AS INT;
	DECLARE @total_members AS INT;

	SET @total_transactions = (SELECT COUNT(DISTINCT rli.RentalTransactionID) FROM RentalLineItem rli JOIN RentalTransaction rt ON rli.RentalTransactionID = rt.RentalTransactionID WHERE rt.RentalDate >= @start_date AND rt.RentalDate <= @end_date); 

	SELECT
		rli.FurnitureID,
		f.Category,
		f.Name,
		COUNT(DISTINCT rli.RentalTransactionID) AS CountRentalTransactions,
		@total_transactions AS 'Total Transactions',
		CONCAT (100 * COUNT(DISTINCT rli.RentalTransactionID) / @total_transactions, '%') AS '% of transactions',
		CONCAT (100 * SUM(CASE WHEN (DATEDIFF(YEAR, m.DateOfBirth, rt.RentalDate)) BETWEEN 18 AND 29 THEN 1 ELSE 0 END)/ COUNT(m.MemberID), '%') AS '% b/t 18-29',
		CONCAT (100 * SUM(CASE WHEN (DATEDIFF(YEAR, m.DateOfBirth, rt.RentalDate)) NOT BETWEEN 18 AND 29 THEN 1 ELSE 0 END)/ COUNT(m.MemberID), '%') AS '% not b/t 18-29'
	FROM RentalLineItem rli
	JOIN Furniture f ON rli.FurnitureID = f.FurnitureID
	JOIN RentalTransaction rt ON rli.RentalTransactionID = rt.RentalTransactionID
	JOIN Member m ON rt.MemberID = m.MemberID
	WHERE rt.RentalDate >= @start_date AND rt.RentalDate <= @end_date
	GROUP BY rli.FurnitureID, f.Category, f.Name
	HAVING COUNT(DISTINCT rli.RentalTransactionID) >= 2
	ORDER BY SUM(rli.Quantity) desc, rli.FurnitureID desc;
END

GO
USE [master]
GO
ALTER DATABASE [cs6232-g5] SET  READ_WRITE 
GO
