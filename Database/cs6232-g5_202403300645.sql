USE [cs6232-g5]
GO
ALTER TABLE [dbo].[ReturnTransaction] DROP CONSTRAINT [FK_Member_ReturnTransaction]
GO
ALTER TABLE [dbo].[ReturnTransaction] DROP CONSTRAINT [FK_Employee_ReturnTransaction]
GO
ALTER TABLE [dbo].[ReturnLineItem] DROP CONSTRAINT [FK_ReturnTransaction_ReturnLineItem]
GO
ALTER TABLE [dbo].[ReturnLineItem] DROP CONSTRAINT [FK_RentalLineItem_ReturnLineItem]
GO
ALTER TABLE [dbo].[RentalTransaction] DROP CONSTRAINT [FK_Member_RentalTransaction]
GO
ALTER TABLE [dbo].[RentalTransaction] DROP CONSTRAINT [FK_Employee_RentalTransaction]
GO
ALTER TABLE [dbo].[RentalLineItem] DROP CONSTRAINT [FK_RentalTransaction_RentalLineItem]
GO
ALTER TABLE [dbo].[RentalLineItem] DROP CONSTRAINT [FK_Furniture_RentalLineItem]
GO
ALTER TABLE [dbo].[Furniture] DROP CONSTRAINT [FK_Style_Furniture]
GO
ALTER TABLE [dbo].[Furniture] DROP CONSTRAINT [FK_Category_Furniture]
GO
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK_Login_Employee]
GO
/****** Object:  Table [dbo].[Style]    Script Date: 3/30/2024 6:55:50 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Style]') AND type in (N'U'))
DROP TABLE [dbo].[Style]
GO
/****** Object:  Table [dbo].[ReturnTransaction]    Script Date: 3/30/2024 6:55:50 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReturnTransaction]') AND type in (N'U'))
DROP TABLE [dbo].[ReturnTransaction]
GO
/****** Object:  Table [dbo].[ReturnLineItem]    Script Date: 3/30/2024 6:55:50 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReturnLineItem]') AND type in (N'U'))
DROP TABLE [dbo].[ReturnLineItem]
GO
/****** Object:  Table [dbo].[RentalTransaction]    Script Date: 3/30/2024 6:55:50 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RentalTransaction]') AND type in (N'U'))
DROP TABLE [dbo].[RentalTransaction]
GO
/****** Object:  Table [dbo].[RentalLineItem]    Script Date: 3/30/2024 6:55:50 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RentalLineItem]') AND type in (N'U'))
DROP TABLE [dbo].[RentalLineItem]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 3/30/2024 6:55:50 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Member]') AND type in (N'U'))
DROP TABLE [dbo].[Member]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 3/30/2024 6:55:50 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Login]') AND type in (N'U'))
DROP TABLE [dbo].[Login]
GO
/****** Object:  Table [dbo].[Furniture]    Script Date: 3/30/2024 6:55:50 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Furniture]') AND type in (N'U'))
DROP TABLE [dbo].[Furniture]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 3/30/2024 6:55:50 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type in (N'U'))
DROP TABLE [dbo].[Employee]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 3/30/2024 6:55:50 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Category]') AND type in (N'U'))
DROP TABLE [dbo].[Category]
GO
USE [master]
GO
/****** Object:  Database [cs6232-g5]    Script Date: 3/30/2024 6:55:50 AM ******/
DROP DATABASE [cs6232-g5]
GO
/****** Object:  Database [cs6232-g5]    Script Date: 3/30/2024 6:55:50 AM ******/
CREATE DATABASE [cs6232-g5]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cs6232-g5', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\cs6232-g5.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cs6232-g5_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\cs6232-g5_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [cs6232-g5] SET COMPATIBILITY_LEVEL = 160
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
ALTER DATABASE [cs6232-g5] SET QUERY_STORE = ON
GO
ALTER DATABASE [cs6232-g5] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [cs6232-g5]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 3/30/2024 6:55:50 AM ******/
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
/****** Object:  Table [dbo].[Employee]    Script Date: 3/30/2024 6:55:50 AM ******/
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
	[Zip] [varchar](6) NOT NULL,
	[Phone] [varchar](20) NULL,
	[IsAdmin] [int] NOT NULL,
	[Username] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Employee_1] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Furniture]    Script Date: 3/30/2024 6:55:50 AM ******/
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
/****** Object:  Table [dbo].[Login]    Script Date: 3/30/2024 6:55:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 3/30/2024 6:55:50 AM ******/
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
	[Zip] [varchar](6) NOT NULL,
	[Phone] [varchar](20) NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalLineItem]    Script Date: 3/30/2024 6:55:50 AM ******/
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
/****** Object:  Table [dbo].[RentalTransaction]    Script Date: 3/30/2024 6:55:50 AM ******/
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
/****** Object:  Table [dbo].[ReturnLineItem]    Script Date: 3/30/2024 6:55:50 AM ******/
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
/****** Object:  Table [dbo].[ReturnTransaction]    Script Date: 3/30/2024 6:55:50 AM ******/
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
/****** Object:  Table [dbo].[Style]    Script Date: 3/30/2024 6:55:50 AM ******/
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

INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (101, N'Classic Armchair', N'A conventional armchair that seats one person. Fits into a family rooms decorated with traditional furnishings.', N'Armchair', N'Traditional', CAST(3.10 AS Decimal(10, 2)), 20, 19)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (102, N'Country Armchair', N'An old-fashioned armchair that seats one person. Looks good in a family room setting with rustic décor.', N'Armchair', N'Rustic', CAST(2.50 AS Decimal(10, 2)), 2, 2)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (103, N'Retro Armchair', N'A throwback accent chair that is suited for one person sitting. Ideal in a living room for a funky 1970s vibe.', N'Armchair', N'Vintage', CAST(4.50 AS Decimal(10, 2)), 16, 13)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (104, N'Mod Bed', N'A streamlined Queen-sized bed with mattress and boxed spring set. Accommodates one or two persons for a tranquil sleep experience.', N'Bed', N'Modern', CAST(8.10 AS Decimal(10, 2)), 8, 6)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (105, N'Simple Bed', N'A standard King-sized bed with mattress and boxed spring set. Accommodates two persons for a reliable bedtime ritual.', N'Bed', N'Contemporary', CAST(9.20 AS Decimal(10, 2)), 7, 6)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (106, N'Seaside Bed', N'An oceanic-print Full-sized bed with foam mattress only. Fits one person for good slumber in a vacation home.', N'Bed', N'Coastal', CAST(7.60 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (107, N'Swedish Bookshelf', N'A five-shelf minimal bookshelf provides a sturdy and spacious way to organize a library or display trinkets.', N'Bookshelf', N'Minimalist', CAST(1.55 AS Decimal(10, 2)), 10, 5)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (108, N'Seaside Bookshelf', N'A 3-shelf safari-themed bookshelf. Designed to hold family photos or store a collection of paperbacks for beach reading.', N'Bookshelf', N'Coastal', CAST(1.85 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (109, N'Classic Crib', N'Safety is the priority for this crib. This item fits well in a nursery decorated with traditional furniture.', N'Crib', N'Traditional', CAST(3.55 AS Decimal(10, 2)), 2, 1)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (110, N'Simple Crib', N'A standard baby''s crib. The best-selling crib on the market. Guaranteed to keep a newborn secure.', N'Crib', N'Contemporary', CAST(3.15 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (111, N'Swedish Desk', N'Part of the Swedish Minimalist collection. This cost-saving desk must be assembled by the buyer.', N'Desk', N'Minimalist', CAST(2.25 AS Decimal(10, 2)), 8, 7)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (112, N'Swedish Dining Chair', N'A minimal dining chair with no arm supports. Seats one. Recommend 4 or 6 chairs per dining set.', N'Dining chair', N'Minimalist', CAST(1.00 AS Decimal(10, 2)), 44, 36)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (113, N'Seaside Dining Chair', N'A sailing-themed dining chair with arm supports. Seats one. Recommend 4 or 6 chairs per dining set.', N'Dining chair', N'Coastal', CAST(1.25 AS Decimal(10, 2)), 24, 12)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (114, N'Retro Dining Chair', N'A 1970s-inspired dining chair with no arm supports. Seats one. Recommend 4 chairs per dining set.', N'Dining chair', N'Vintage', CAST(1.30 AS Decimal(10, 2)), 48, 36)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (115, N'Mod Dresser', N'A sleek 4-drawer vertical dresser. Goes well with bedroom sets containing modern beds and nightstands.', N'Dresser', N'Modern', CAST(4.20 AS Decimal(10, 2)), 10, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (116, N'Simple Dresser', N'A standard 6-drawer horizontal dresser. The default option for a dresser of the contemporary variety.', N'Dresser', N'Contemporary', CAST(4.10 AS Decimal(10, 2)), 8, 8)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (117, N'Seaside Dresser', N'A five-drawer dresser designed for a vacation spot. Ideal for bedrooms filled with coastal-style merchandise.', N'Dresser', N'Coastal', CAST(4.05 AS Decimal(10, 2)), 13, 11)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (118, N'Mod Futon', N'A no-frills futon. Converts easily between sofa and bed functions. Seats three or sleeps one.', N'Futon', N'Modern', CAST(3.50 AS Decimal(10, 2)), 0, 0)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (119, N'Swedish Futon', N'A minimal futon. Switches quickly between seating and sleeping purposes.', N'Futon', N'Minimalist', CAST(3.00 AS Decimal(10, 2)), 10, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (120, N'Classic Loveseat', N'A conventional loveseat that seats two persons. Fits into a family room decorated with traditional furnishings.', N'Loveseat', N'Traditional', CAST(4.50 AS Decimal(10, 2)), 10, 8)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (121, N'Country Loveseat', N'A rural-style loveseat that seats two persons. Fits into a family room filled with other rustic items.', N'Loveseat', N'Rustic', CAST(3.60 AS Decimal(10, 2)), 4, 4)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (122, N'Retro Loveseat', N'An avocado-colored loveseat suitable for 2-person seating. Ideal for a room with a disco-era feeling.', N'Loveseat', N'Vintage', CAST(2.60 AS Decimal(10, 2)), 14, 13)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (123, N'Mod Nightstand', N'A streamlined bedside table with no drawers. Recommend two nightstands per bedroom.', N'Nightstand', N'Modern', CAST(2.90 AS Decimal(10, 2)), 12, 8)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (124, N'Simple Nightstand', N'A standard nightstand with 2-drawer storage capability. Recommend two nightstands per bedroom.', N'Nightstand', N'Contemporary', CAST(2.85 AS Decimal(10, 2)), 8, 6)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (125, N'Seaside Nightstand', N'A safari-themed nightstand with one drawer for storage. Recommend two nightstands per bedroom.', N'Nightstand', N'Coastal', CAST(2.25 AS Decimal(10, 2)), 12, 12)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (126, N'Swedish Office Chair', N'Part of the Swedish Minimalist collection. This cost-saving office chair must be assembled by the buyer.', N'Office chair', N'Minimalist', CAST(1.90 AS Decimal(10, 2)), 7, 6)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (127, N'Classic Ottoman', N'A conventional ottoman. Built to match the Classic Armchair.', N'Ottoman', N'Traditional', CAST(1.40 AS Decimal(10, 2)), 3, 2)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (128, N'Country Ottoman', N'An old-fashioned oversized footrest. Rugged upholstery. Looks great in any farmhouse.', N'Ottoman', N'Rustic', CAST(1.60 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (129, N'Retro Ottoman', N'A kitschy, vinyl ottoman reminiscent of the 1970s. Built to match the Retro Armchair.', N'Ottoman', N'Vintage', CAST(1.50 AS Decimal(10, 2)), 16, 13)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (130, N'Classic Sofa', N'A conventional couch that accommodates seating 3 persons. Perfect for family rooms decorated with traditional furnishings.', N'Sofa', N'Traditional', CAST(5.50 AS Decimal(10, 2)), 5, 3)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (131, N'Country Sofa', N'An old-fashioned couch that accommodates seating 4 persons. Great for family rooms decorated with rustic items.', N'Sofa', N'Rustic', CAST(4.50 AS Decimal(10, 2)), 7, 4)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (132, N'Retro Sofa', N'A 1970s-era couch that accommodates seating 3 persons. Works well in family rooms containing other vintage furnishings.', N'Sofa', N'Vintage', CAST(5.20 AS Decimal(10, 2)), 4, 2)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (133, N'Swedish Table', N'A minimal dining table. Seats six persons with leaf or four persons without leaf.', N'Table', N'Minimalist', CAST(3.80 AS Decimal(10, 2)), 8, 6)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (134, N'Seaside Table', N'A sailing-themed dining table well-suited for 4-6 vacationers. Good for family meals at the lake house.', N'Table', N'Coastal', CAST(4.00 AS Decimal(10, 2)), 3, 0)
SET IDENTITY_INSERT [dbo].[Furniture] OFF
GO
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'anna', N'anna')
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'babbage', N'babbage')
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'curie', N'curie')
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'david', N'david')
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'goodall', N'goodall')
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'jane', N'test1234')
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'justin', N'justin')
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'kepler', N'kepler')
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'oppenheimer', N'oppenheimer')
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'sagan', N'sagan')
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
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET IDENTITY_INSERT [dbo].[RentalLineItem] ON 

INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (65, 10034, 101, 1, 0, CAST(3.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (66, 10034, 127, 1, 0, CAST(1.40 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (67, 10034, 130, 1, 0, CAST(5.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (68, 10034, 120, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (69, 10035, 103, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (70, 10035, 129, 1, 0, CAST(1.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (71, 10035, 122, 1, 0, CAST(2.60 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (72, 10035, 132, 1, 0, CAST(5.20 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (73, 10036, 111, 1, 0, CAST(2.25 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (74, 10036, 126, 1, 0, CAST(1.90 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (75, 10037, 104, 1, 1, CAST(8.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (76, 10037, 123, 2, 2, CAST(5.80 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (77, 10037, 115, 2, 2, CAST(8.40 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (78, 10038, 114, 12, 0, CAST(15.60 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (79, 10039, 134, 1, 0, CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (80, 10039, 113, 6, 0, CAST(7.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (81, 10040, 105, 1, 0, CAST(9.20 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (82, 10040, 124, 2, 0, CAST(5.70 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (83, 10040, 117, 2, 0, CAST(8.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (84, 10041, 133, 1, 0, CAST(3.80 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (85, 10041, 112, 4, 0, CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (86, 10042, 104, 1, 0, CAST(8.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (87, 10042, 123, 2, 0, CAST(5.80 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (88, 10043, 131, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (89, 10044, 130, 1, 1, CAST(5.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (90, 10044, 120, 1, 1, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (91, 10045, 103, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (92, 10045, 129, 1, 0, CAST(1.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (93, 10046, 113, 2, 0, CAST(2.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (94, 10047, 134, 1, 0, CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (95, 10047, 113, 4, 0, CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (96, 10048, 133, 1, 0, CAST(3.80 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (97, 10048, 112, 4, 0, CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (98, 10049, 104, 1, 0, CAST(8.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (99, 10049, 123, 2, 0, CAST(5.80 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (100, 10050, 131, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (101, 10051, 130, 1, 0, CAST(5.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (102, 10052, 109, 1, 0, CAST(3.55 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (103, 10053, 132, 1, 0, CAST(5.20 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (104, 10053, 107, 4, 0, CAST(6.20 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (105, 10054, 113, 2, 2, CAST(2.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (106, 10055, 116, 1, 1, CAST(4.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (107, 10056, 111, 1, 1, CAST(2.25 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (108, 10056, 126, 1, 1, CAST(1.90 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (109, 10057, 123, 1, 1, CAST(2.90 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (110, 10058, 115, 2, 2, CAST(8.40 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (111, 10059, 131, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (112, 10060, 120, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (113, 10061, 103, 1, 0, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (114, 10061, 129, 1, 0, CAST(1.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (115, 10062, 134, 1, 0, CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (116, 10063, 107, 1, 0, CAST(1.55 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[RentalLineItem] OFF
GO
SET IDENTITY_INSERT [dbo].[RentalTransaction] ON 

INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10034, 1036, 100, CAST(N'2024-03-30' AS Date), CAST(N'2024-04-04' AS Date), CAST(72.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10035, 1035, 101, CAST(N'2024-03-30' AS Date), CAST(N'2024-04-29' AS Date), CAST(414.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10036, 1034, 102, CAST(N'2024-03-30' AS Date), CAST(N'2024-06-28' AS Date), CAST(373.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10037, 1033, 103, CAST(N'2024-03-30' AS Date), CAST(N'2024-09-26' AS Date), CAST(4014.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10038, 1032, 104, CAST(N'2024-03-30' AS Date), CAST(N'2025-03-30' AS Date), CAST(5694.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10039, 1031, 105, CAST(N'2024-03-30' AS Date), CAST(N'2024-04-04' AS Date), CAST(57.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10040, 1027, 106, CAST(N'2024-03-30' AS Date), CAST(N'2024-04-29' AS Date), CAST(690.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10041, 1036, 107, CAST(N'2024-03-30' AS Date), CAST(N'2024-06-28' AS Date), CAST(702.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10042, 1035, 108, CAST(N'2024-03-30' AS Date), CAST(N'2024-09-26' AS Date), CAST(2502.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10043, 1034, 109, CAST(N'2024-03-30' AS Date), CAST(N'2025-03-30' AS Date), CAST(1642.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10044, 1033, 110, CAST(N'2024-03-30' AS Date), CAST(N'2024-04-04' AS Date), CAST(50.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10045, 1032, 111, CAST(N'2024-03-30' AS Date), CAST(N'2024-04-29' AS Date), CAST(180.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10046, 1031, 112, CAST(N'2024-03-30' AS Date), CAST(N'2024-06-28' AS Date), CAST(225.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10047, 1027, 113, CAST(N'2024-03-30' AS Date), CAST(N'2024-09-26' AS Date), CAST(1620.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10048, 1036, 114, CAST(N'2024-03-30' AS Date), CAST(N'2025-03-30' AS Date), CAST(2847.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10049, 1035, 115, CAST(N'2024-03-30' AS Date), CAST(N'2024-04-04' AS Date), CAST(69.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10050, 1034, 116, CAST(N'2024-03-30' AS Date), CAST(N'2024-04-29' AS Date), CAST(135.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10051, 1033, 117, CAST(N'2024-03-30' AS Date), CAST(N'2024-06-28' AS Date), CAST(495.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10052, 1032, 118, CAST(N'2024-03-30' AS Date), CAST(N'2024-09-26' AS Date), CAST(639.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10053, 1031, 119, CAST(N'2024-03-30' AS Date), CAST(N'2025-03-30' AS Date), CAST(4161.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10054, 1027, 120, CAST(N'2024-03-30' AS Date), CAST(N'2024-03-31' AS Date), CAST(2.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10055, 1036, 121, CAST(N'2024-03-30' AS Date), CAST(N'2024-03-31' AS Date), CAST(4.10 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10056, 1035, 122, CAST(N'2024-03-30' AS Date), CAST(N'2024-03-31' AS Date), CAST(4.15 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10057, 1034, 123, CAST(N'2024-03-30' AS Date), CAST(N'2024-03-31' AS Date), CAST(2.90 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10058, 1033, 105, CAST(N'2024-03-30' AS Date), CAST(N'2024-03-31' AS Date), CAST(8.40 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10059, 1032, 112, CAST(N'2024-03-30' AS Date), CAST(N'2024-03-31' AS Date), CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10060, 1031, 114, CAST(N'2024-03-30' AS Date), CAST(N'2024-03-31' AS Date), CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10061, 1027, 119, CAST(N'2024-03-30' AS Date), CAST(N'2024-06-28' AS Date), CAST(540.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10062, 1036, 121, CAST(N'2024-03-30' AS Date), CAST(N'2024-09-26' AS Date), CAST(720.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (10063, 1035, 122, CAST(N'2024-03-30' AS Date), CAST(N'2025-03-30' AS Date), CAST(565.75 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[RentalTransaction] OFF
GO
SET IDENTITY_INSERT [dbo].[ReturnLineItem] ON 

INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (11, 75, 10010, 1, CAST(8.10 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (12, 76, 10010, 2, CAST(5.80 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (13, 77, 10010, 2, CAST(8.40 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (14, 89, 10011, 1, CAST(5.50 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (15, 90, 10011, 1, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (16, 105, 10012, 2, CAST(2.50 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (17, 106, 10013, 1, CAST(4.10 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (18, 107, 10014, 1, CAST(2.25 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (19, 108, 10014, 1, CAST(1.90 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (20, 109, 10015, 1, CAST(2.90 AS Decimal(10, 2)))
INSERT [dbo].[ReturnLineItem] ([ReturnLineItemID], [RentalLineItemID], [ReturnTransactionID], [Quantity], [DailyCost]) VALUES (21, 110, 10016, 2, CAST(8.40 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[ReturnLineItem] OFF
GO
SET IDENTITY_INSERT [dbo].[ReturnTransaction] ON 

INSERT [dbo].[ReturnTransaction] ([ReturnTransactionID], [EmployeeID], [MemberID], [ReturnDate], [TotalCost]) VALUES (10010, 1031, 103, CAST(N'2024-03-30' AS Date), CAST(-2720.80 AS Decimal(10, 2)))
INSERT [dbo].[ReturnTransaction] ([ReturnTransactionID], [EmployeeID], [MemberID], [ReturnDate], [TotalCost]) VALUES (10011, 1034, 110, CAST(N'2024-03-30' AS Date), CAST(-40.00 AS Decimal(10, 2)))
INSERT [dbo].[ReturnTransaction] ([ReturnTransactionID], [EmployeeID], [MemberID], [ReturnDate], [TotalCost]) VALUES (10012, 1032, 120, CAST(N'2024-03-30' AS Date), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[ReturnTransaction] ([ReturnTransactionID], [EmployeeID], [MemberID], [ReturnDate], [TotalCost]) VALUES (10013, 1035, 121, CAST(N'2024-03-30' AS Date), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[ReturnTransaction] ([ReturnTransactionID], [EmployeeID], [MemberID], [ReturnDate], [TotalCost]) VALUES (10014, 1027, 122, CAST(N'2024-03-30' AS Date), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[ReturnTransaction] ([ReturnTransactionID], [EmployeeID], [MemberID], [ReturnDate], [TotalCost]) VALUES (10015, 1031, 123, CAST(N'2024-03-30' AS Date), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[ReturnTransaction] ([ReturnTransactionID], [EmployeeID], [MemberID], [ReturnDate], [TotalCost]) VALUES (10016, 1033, 105, CAST(N'2024-03-30' AS Date), CAST(0.00 AS Decimal(10, 2)))
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
USE [master]
GO
ALTER DATABASE [cs6232-g5] SET  READ_WRITE 
GO
