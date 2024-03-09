USE [master]
GO
/****** Object:  Database [cs6232-g5]    Script Date: 3/9/2024 3:57:50 PM ******/
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
/****** Object:  Table [dbo].[Category]    Script Date: 3/9/2024 3:57:50 PM ******/
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
/****** Object:  Table [dbo].[Employee]    Script Date: 3/9/2024 3:57:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1000,1) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[Sex] [char](1) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[AddressLine1] [varchar](50) NOT NULL,
	[AddressLine2] [varchar](50) NULL,
	[City] [varchar](20) NOT NULL,
	[State] [char](2) NOT NULL,
	[Zip] [varchar](10) NOT NULL,
	[Phone] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[IsAdmin] [int] NOT NULL,
	[Username] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Employee_1] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Furniture]    Script Date: 3/9/2024 3:57:50 PM ******/
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
/****** Object:  Table [dbo].[Login]    Script Date: 3/9/2024 3:57:50 PM ******/
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
/****** Object:  Table [dbo].[Member]    Script Date: 3/9/2024 3:57:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberID] [int] IDENTITY(100,1) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[Sex] [char](1) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[AddressLine1] [varchar](50) NOT NULL,
	[AddressLine2] [varchar](50) NULL,
	[City] [varchar](20) NOT NULL,
	[State] [char](2) NOT NULL,
	[Zip] [varchar](10) NOT NULL,
	[Phone] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalLineItem]    Script Date: 3/9/2024 3:57:50 PM ******/
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
/****** Object:  Table [dbo].[RentalTransaction]    Script Date: 3/9/2024 3:57:50 PM ******/
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
/****** Object:  Table [dbo].[ReturnLineItem]    Script Date: 3/9/2024 3:57:50 PM ******/
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
/****** Object:  Table [dbo].[ReturnTransaction]    Script Date: 3/9/2024 3:57:50 PM ******/
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
/****** Object:  Table [dbo].[Style]    Script Date: 3/9/2024 3:57:50 PM ******/
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
