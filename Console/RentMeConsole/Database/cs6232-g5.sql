USE [master]
GO
/****** Object:  Database [cs6232-g5]    Script Date: 3/11/2024 12:00:57 PM ******/
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
ALTER DATABASE [cs6232-g5] SET RECOVERY FULL 
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
ALTER DATABASE [cs6232-g5] SET QUERY_STORE = OFF
GO
USE [cs6232-g5]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 3/11/2024 12:00:57 PM ******/
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
/****** Object:  Table [dbo].[Employee]    Script Date: 3/11/2024 12:00:57 PM ******/
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
	[Zip] [varchar](10) NOT NULL,
	[Phone] [varchar](20) NULL,
	[IsAdmin] [int] NOT NULL,
	[Username] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Employee_1] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Furniture]    Script Date: 3/11/2024 12:00:57 PM ******/
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
/****** Object:  Table [dbo].[Login]    Script Date: 3/11/2024 12:00:57 PM ******/
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
/****** Object:  Table [dbo].[Member]    Script Date: 3/11/2024 12:00:57 PM ******/
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
	[Zip] [varchar](10) NOT NULL,
	[Phone] [varchar](20) NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalLineItem]    Script Date: 3/11/2024 12:00:57 PM ******/
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
/****** Object:  Table [dbo].[RentalTransaction]    Script Date: 3/11/2024 12:00:57 PM ******/
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
/****** Object:  Table [dbo].[ReturnLineItem]    Script Date: 3/11/2024 12:00:57 PM ******/
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
/****** Object:  Table [dbo].[ReturnTransaction]    Script Date: 3/11/2024 12:00:57 PM ******/
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
/****** Object:  Table [dbo].[Style]    Script Date: 3/11/2024 12:00:57 PM ******/
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

INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (101, N'Classic Armchair', N'A conventional armchair that seats one person. Fits into a family rooms decorated with traditional furnishings.', N'Armchair', N'Traditional', CAST(31.00 AS Decimal(10, 2)), 3, 3)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (102, N'Country Armchair', N'An old-fashioned armchair that seats one person. Looks good in a family room setting with rustic décor.', N'Armchair', N'Rustic', CAST(25.00 AS Decimal(10, 2)), 2, 2)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (103, N'Retro Armchair', N'A throwback accent chair that is suited for one person sitting. Ideal in a living room for a funky 1970s vibe.', N'Armchair', N'Vintage', CAST(45.00 AS Decimal(10, 2)), 6, 6)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (104, N'Mod Bed', N'A streamlined Queen-sized bed with mattress and boxed spring set. Accommodates one or two persons for a tranquil sleep experience.', N'Bed', N'Modern', CAST(81.00 AS Decimal(10, 2)), 8, 8)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (105, N'Simple Bed', N'A standard King-sized bed with mattress and boxed spring set. Accommodates two persons for a reliable bedtime ritual.', N'Bed', N'Contemporary', CAST(92.00 AS Decimal(10, 2)), 7, 7)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (106, N'Seaside Bed', N'An oceanic-print Full-sized bed with foam mattress only. Fits one person for good slumber in a vacation home.', N'Bed', N'Coastal', CAST(76.00 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (107, N'Swedish Bookshelf', N'A five-shelf minimal bookshelf provides a sturdy and spacious way to organize a library or display trinkets.', N'Bookshelf', N'Minimalist', CAST(15.50 AS Decimal(10, 2)), 10, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (108, N'Seaside Bookshelf', N'A 3-shelf safari-themed bookshelf. Designed to hold family photos or store a collection of paperbacks for beach reading.', N'Bookshelf', N'Coastal', CAST(18.50 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (109, N'Classic Crib', N'Safety is the priority for this crib. This item fits well in a nursery decorated with traditional furniture.', N'Crib', N'Traditional', CAST(35.50 AS Decimal(10, 2)), 2, 2)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (110, N'Simple Crib', N'A standard baby''s crib. The best-selling crib on the market. Guaranteed to keep a newborn secure.', N'Crib', N'Contemporary', CAST(31.50 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (111, N'Swedish Desk', N'Part of the Swedish Minimalist collection. This cost-saving desk must be assembled by the buyer.', N'Desk', N'Minimalist', CAST(22.50 AS Decimal(10, 2)), 8, 8)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (112, N'Swedish Dining Chair', N'A minimal dining chair with no arm supports. Seats one. Recommend 4 or 6 chairs per dining set.', N'Dining chair', N'Minimalist', CAST(10.00 AS Decimal(10, 2)), 44, 44)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (113, N'Seaside Dining Chair', N'A sailing-themed dining chair with arm supports. Seats one. Recommend 4 or 6 chairs per dining set.', N'Dining chair', N'Coastal', CAST(12.50 AS Decimal(10, 2)), 12, 12)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (114, N'Retro Dining Chair', N'A 1970s-inspired dining chair with no arm supports. Seats one. Recommend 4 chairs per dining set.', N'Dining chair', N'Vintage', CAST(13.00 AS Decimal(10, 2)), 48, 48)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (115, N'Mod Dresser', N'A sleek 4-drawer vertical dresser. Goes well with bedroom sets containing modern beds and nightstands.', N'Dresser', N'Modern', CAST(42.00 AS Decimal(10, 2)), 10, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (116, N'Simple Dresser', N'A standard 6-drawer horizontal dresser. The default option for a dresser of the contemporary variety.', N'Dresser', N'Contemporary', CAST(41.00 AS Decimal(10, 2)), 8, 8)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (117, N'Seaside Dresser', N'A five-drawer dresser designed for a vacation spot. Ideal for bedrooms filled with coastal-style merchandise.', N'Dresser', N'Coastal', CAST(40.50 AS Decimal(10, 2)), 3, 3)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (118, N'Mod Futon', N'A no-frills futon. Converts easily between sofa and bed functions. Seats three or sleeps one.', N'Futon', N'Modern', CAST(35.00 AS Decimal(10, 2)), 0, 0)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (119, N'Swedish Futon', N'A minimal futon. Switches quickly between seating and sleeping purposes.', N'Futon', N'Minimalist', CAST(30.00 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (120, N'Classic Loveseat', N'A conventional loveseat that seats two persons. Fits into a family room decorated with traditional furnishings.', N'Loveseat', N'Traditional', CAST(40.50 AS Decimal(10, 2)), 3, 3)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (121, N'Country Loveseat', N'A rural-style loveseat that seats two persons. Fits into a family room filled with other rustic items.', N'Loveseat', N'Rustic', CAST(36.00 AS Decimal(10, 2)), 2, 2)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (122, N'Retro Loveseat', N'An avocado-colored loveseat suitable for 2-person seating. Ideal for a room with a disco-era feeling.', N'Loveseat', N'Vintage', CAST(26.00 AS Decimal(10, 2)), 4, 4)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (123, N'Mod Nightstand', N'A streamlined bedside table with no drawers. Recommend two nightstands per bedroom.', N'Nightstand', N'Modern', CAST(29.00 AS Decimal(10, 2)), 12, 12)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (124, N'Simple Nightstand', N'A standard nightstand with 2-drawer storage capability. Recommend two nightstands per bedroom.', N'Nightstand', N'Contemporary', CAST(28.50 AS Decimal(10, 2)), 8, 8)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (125, N'Seaside Nightstand', N'A safari-themed nightstand with one drawer for storage. Recommend two nightstands per bedroom.', N'Nightstand', N'Coastal', CAST(22.50 AS Decimal(10, 2)), 2, 2)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (126, N'Swedish Office Chair', N'Part of the Swedish Minimalist collection. This cost-saving office chair must be assembled by the buyer.', N'Office chair', N'Minimalist', CAST(19.00 AS Decimal(10, 2)), 7, 7)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (127, N'Classic Ottoman', N'A conventional ottoman. Built to match the Classic Armchair.', N'Ottoman', N'Traditional', CAST(14.00 AS Decimal(10, 2)), 3, 3)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (128, N'Country Ottoman', N'An old-fashioned oversized footrest. Rugged upholstery. Looks great in any farmhouse.', N'Ottoman', N'Rustic', CAST(16.00 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (129, N'Retro Ottoman', N'A kitschy, vinyl ottoman reminiscent of the 1970s. Built to match the Retro Armchair.', N'Ottoman', N'Vintage', CAST(15.00 AS Decimal(10, 2)), 6, 6)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (130, N'Classic Sofa', N'A conventional couch that accommodates seating 3 persons. Perfect for family rooms decorated with traditional furnishings.', N'Sofa', N'Traditional', CAST(55.50 AS Decimal(10, 2)), 5, 5)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (131, N'Country Sofa', N'An old-fashioned couch that accommodates seating 4 persons. Great for family rooms decorated with rustic items.', N'Sofa', N'Rustic', CAST(45.00 AS Decimal(10, 2)), 7, 7)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (132, N'Retro Sofa', N'A 1970s-era couch that accommodates seating 3 persons. Works well in family rooms containing other vintage furnishings.', N'Sofa', N'Vintage', CAST(52.00 AS Decimal(10, 2)), 4, 4)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (133, N'Swedish Table', N'A minimal dining table. Seats six persons with leaf or four persons without leaf.', N'Table', N'Minimalist', CAST(38.00 AS Decimal(10, 2)), 8, 8)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (134, N'Seaside Table', N'A sailing-themed dining table well-suited for 4-6 vacationers. Good for family meals at the lake house.', N'Table', N'Coastal', CAST(40.00 AS Decimal(10, 2)), 3, 3)
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
