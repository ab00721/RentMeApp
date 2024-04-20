/****** Object:  Table [dbo].[Category]    Script Date: 4/17/2024 10:32:32 PM ******/
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
/****** Object:  Table [dbo].[Employee]    Script Date: 4/17/2024 10:32:32 PM ******/
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
/****** Object:  Table [dbo].[Furniture]    Script Date: 4/17/2024 10:32:32 PM ******/
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
/****** Object:  Table [dbo].[Login]    Script Date: 4/17/2024 10:32:32 PM ******/
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
/****** Object:  Table [dbo].[Member]    Script Date: 4/17/2024 10:32:32 PM ******/
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
/****** Object:  Table [dbo].[RentalLineItem]    Script Date: 4/17/2024 10:32:32 PM ******/
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
/****** Object:  Table [dbo].[RentalTransaction]    Script Date: 4/17/2024 10:32:32 PM ******/
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
/****** Object:  Table [dbo].[ReturnLineItem]    Script Date: 4/17/2024 10:32:32 PM ******/
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
/****** Object:  Table [dbo].[ReturnTransaction]    Script Date: 4/17/2024 10:32:32 PM ******/
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
/****** Object:  Table [dbo].[Style]    Script Date: 4/17/2024 10:32:32 PM ******/
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
INSERT [dbo].[Category] ([Category]) VALUES (N'Test-Category')
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone], [IsAdmin], [Username]) VALUES (901, N'Smith', N'Jane', N'F', CAST(N'1969-12-31' AS Date), N'123 Main St.', NULL, N'Atlanta', N'GA', N'30317', N'404-555-1234', 1, N'jane')
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

INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (101, N'Test-F1', N'T-Description', N'Test-Category', N'Test-Style', CAST(1.00 AS Decimal(10, 2)), 10, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (102, N'Test-F2', N'T-Description', N'Test-Category', N'Test-Style', CAST(1.00 AS Decimal(10, 2)), 10, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (103, N'Test-F3', N'T-Description', N'Test-Category', N'Test-Style', CAST(1.00 AS Decimal(10, 2)), 10, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (104, N'Test-F4', N'T-Description', N'Test-Category', N'Test-Style', CAST(1.00 AS Decimal(10, 2)), 10, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (105, N'Test-F5', N'T-Description', N'Test-Category', N'Test-Style', CAST(1.00 AS Decimal(10, 2)), 10, 10)
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [Category], [Style], [DailyRate], [TotalQuantity], [InStockQuantity]) VALUES (106, N'Test-F6', N'T-Description', N'Test-Category', N'Test-Style', CAST(1.00 AS Decimal(10, 2)), 10, 10)
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

INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (301, N'report-test-db', N'A20', N'M', CAST(N'2000-01-01' AS Date), N'123 Main', NULL, N'Anywhere', N'US', N'99999', N'555-555-5555')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (302, N'report-test-db', N'B40', N'F', CAST(N'1980-01-01' AS Date), N'123 Main', NULL, N'Anywhere', N'US', N'99999', N'555-555-5555')
INSERT [dbo].[Member] ([MemberID], [LastName], [FirstName], [Sex], [DateOfBirth], [AddressLine1], [AddressLine2], [City], [State], [Zip], [Phone]) VALUES (303, N'report-test-db', N'A20', N'F', CAST(N'2000-01-01' AS Date), N'123 Main', NULL, N'Anywhere', N'US', N'99999', N'555-555-5555')
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET IDENTITY_INSERT [dbo].[RentalLineItem] ON 

INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (501, 701, 102, 2, 0, CAST(9.99 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (502, 701, 104, 3, 0, CAST(9.99 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (503, 702, 103, 3, 0, CAST(9.99 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (504, 702, 104, 6, 0, CAST(9.99 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (505, 703, 105, 1, 0, CAST(9.99 AS Decimal(10, 2)))
INSERT [dbo].[RentalLineItem] ([RentalLineItemID], [RentalTransactionID], [FurnitureID], [Quantity], [QuantityReturned], [DailyCost]) VALUES (506, 703, 106, 1, 0, CAST(9.99 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[RentalLineItem] OFF
GO
SET IDENTITY_INSERT [dbo].[RentalTransaction] ON 

INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (701, 901, 301, CAST(N'2024-04-01' AS Date), CAST(N'2024-04-01' AS Date), CAST(999.99 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (702, 901, 302, CAST(N'2024-04-01' AS Date), CAST(N'2024-04-01' AS Date), CAST(999.99 AS Decimal(10, 2)))
INSERT [dbo].[RentalTransaction] ([RentalTransactionID], [EmployeeID], [MemberID], [RentalDate], [DueDate], [TotalCost]) VALUES (703, 901, 303, CAST(N'2024-04-01' AS Date), CAST(N'2024-04-01' AS Date), CAST(999.99 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[RentalTransaction] OFF
GO
SET IDENTITY_INSERT [dbo].[ReturnLineItem] ON 

SET IDENTITY_INSERT [dbo].[ReturnLineItem] OFF
GO
SET IDENTITY_INSERT [dbo].[ReturnTransaction] ON 

SET IDENTITY_INSERT [dbo].[ReturnTransaction] OFF
GO
INSERT [dbo].[Style] ([Style]) VALUES (N'Test-Style')
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
/****** Object:  StoredProcedure [dbo].[getMostPopularFurnitureDuringDates]    Script Date: 4/17/2024 10:32:32 PM ******/
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

	SET @total_transactions = (SELECT COUNT(DISTINCT rli.RentalTransactionID) FROM RentalLineItem rli JOIN RentalTransaction rt ON rli.RentalTransactionID = rt.RentalTransactionID WHERE rt.RentalDate >= @start_date AND rt.RentalDate <= @end_date HAVING COUNT(DISTINCT rli.RentalTransactionID) >= 2); 

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
ALTER DATABASE [report-test-db] SET  READ_WRITE 
GO
