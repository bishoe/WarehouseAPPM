USE [Warehouse]
GO
/****** Object:  Table [dbo].[_Warehouse_invoice_Store_Status]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_Warehouse_invoice_Store_Status](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MStoreId] [int] NULL,
	[Billno] [nchar](10) NULL,
	[PAIDAMOUNT] [decimal](18, 2) NULL,
	[RemainingAMOUNT] [decimal](18, 2) NULL,
	[UserID] [int] NULL,
	[Wdate] [datetime] NULL,
 CONSTRAINT [PK__Warehouse_invoice_Store_Status] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[_Warehouse_Track_employee_progress]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_Warehouse_Track_employee_progress](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[USERID] [int] NULL,
	[StartWork] [datetime] NULL,
	[EndWork] [datetime] NULL,
 CONSTRAINT [PK__Warehouse_Track_employee_progress] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[TBCONTROLS]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBCONTROLS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ROLES_ID] [int] NULL,
	[User_ID] [int] NULL,
 CONSTRAINT [PK_TBCONTROLS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBROLES]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBROLES](
	[ROLES_ID] [int] IDENTITY(1,1) NOT NULL,
	[ROLES_NAME] [nvarchar](20) NULL,
 CONSTRAINT [PK_TBROLES] PRIMARY KEY CLUSTERED 
(
	[ROLES_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBSCREENS]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBSCREENS](
	[SCREEN_ID] [int] IDENTITY(1,1) NOT NULL,
	[SCREEN_NAME] [nvarchar](50) NULL,
	[SCREEN_NameAr] [nvarchar](50) NULL,
 CONSTRAINT [PK_SCREENS] PRIMARY KEY CLUSTERED 
(
	[SCREEN_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBUSERS]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBUSERS](
	[User_ID] [int] IDENTITY(1,1) NOT NULL,
	[USER_NAME] [nvarchar](15) NULL,
	[USER_PASSWORD] [nvarchar](max) NULL,
	[USER_LASTLOGIN] [date] NULL,
	[LOCKACCOUNT] [bit] NULL,
 CONSTRAINT [PK_TBUSERS] PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse_CategoryProduct]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse_CategoryProduct](
	[IdCategoryProduct] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](15) NULL,
	[WDate] [date] NULL,
	[UsersID] [int] NULL,
 CONSTRAINT [PK_CategoryProduct_1] PRIMARY KEY CLUSTERED 
(
	[IdCategoryProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse_Employee]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse_Employee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[EName] [nvarchar](50) NULL,
	[Phone] [nvarchar](12) NULL,
	[Address] [nvarchar](50) NULL,
	[Salary] [decimal](7, 2) NULL,
	[WDate] [datetime] NULL,
	[Notes] [nvarchar](150) NULL,
	[SalaryDate] [datetime] NULL,
	[JobID] [int] NULL,
	[U_Username] [nvarchar](15) NULL,
	[U_Password] [nvarchar](24) NULL,
	[UsersID] [int] NULL,
 CONSTRAINT [PK_Warehouse_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse_MainUnites]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse_MainUnites](
	[UnitesNId] [int] IDENTITY(1,1) NOT NULL,
	[UName] [nvarchar](50) NULL,
	[WDate] [datetime] NULL,
	[UnitConvert] [int] NULL,
	[UsersID] [int] NULL,
 CONSTRAINT [PK_Warehouse_UnitesName] PRIMARY KEY CLUSTERED 
(
	[UnitesNId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse_Master_Store]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse_Master_Store](
	[StoreId] [int] IDENTITY(1,1) NOT NULL,
	[WDate] [datetime] NULL,
	[EmployeeId] [int] NULL,
	[UsersID] [int] NULL,
 CONSTRAINT [PK_Warehouse_Master_Store] PRIMARY KEY CLUSTERED 
(
	[StoreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse_OutLayUnites]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse_OutLayUnites](
	[OutLayID] [int] IDENTITY(1,1) NOT NULL,
	[QName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Warehouse_OutLayUnites] PRIMARY KEY CLUSTERED 
(
	[OutLayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse_Points]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse_Points](
	[Pointsid] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[TotalPoint] [int] NULL,
	[WDate] [datetime] NULL,
	[Notes] [nvarchar](150) NULL,
	[EmpId] [int] NULL,
 CONSTRAINT [PK_Warehouse_Points] PRIMARY KEY CLUSTERED 
(
	[Pointsid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse_QT]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse_QT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[STartQT] [int] NULL,
	[IDStore] [int] NULL,
	[CUTQT] [int] NULL,
 CONSTRAINT [PK_Warehouse_QT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse_Quantity_Product]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse_Quantity_Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[QuantityProduct] [int] NULL,
	[Wdate] [datetime] NULL,
 CONSTRAINT [PK_Quantity_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse_Qutaly]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse_Qutaly](
	[QutalyID] [int] IDENTITY(1,1) NOT NULL,
	[OutLayUnID] [int] NULL,
	[Amount] [decimal](7, 2) NULL,
	[UsersID] [int] NULL,
	[WDate] [date] NULL,
	[Notes] [nvarchar](150) NULL,
 CONSTRAINT [PK_Warehouse_Qutaly] PRIMARY KEY CLUSTERED 
(
	[QutalyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse_ReturnProducts]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse_ReturnProducts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BillNo] [int] NULL,
	[QtStartPeriod] [decimal](18, 0) NULL,
	[QTReturn] [decimal](18, 0) NULL,
	[_datetime] [datetime] NULL,
	[UserID] [int] NULL,
	[ProdouctsID] [int] NULL,
 CONSTRAINT [PK_ReturnProducts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse_Selling]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse_Selling](
	[SellingId] [int] IDENTITY(1,1) NOT NULL,
	[Selling_MasterID] [int] NOT NULL,
	[PointsId] [int] NULL,
	[UnitesNId] [int] NULL,
	[SUBUnitesId] [int] NULL,
	[TotalPrice] [decimal](18, 0) NOT NULL,
	[Billno] [int] NULL,
	[IdCategoryProduct] [int] NULL,
	[ProdouctsId] [int] NULL,
	[Quntity_Product] [int] NULL,
	[UsersID] [int] NULL,
	[Discount] [int] NULL,
	[TotalBDiscount] [decimal](18, 0) NULL,
	[AMountDicount] [decimal](18, 0) NULL,
	[TotalAmountRow] [decimal](18, 0) NULL,
	[EmpId] [int] NULL,
	[SellingPrice] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Warehouse_Bill] PRIMARY KEY CLUSTERED 
(
	[SellingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse_Selling_Master]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse_Selling_Master](
	[Selling_MasterID] [int] IDENTITY(1,1) NOT NULL,
	[WDate] [date] NULL,
	[CustomerID] [int] NULL,
	[U_Username] [nvarchar](20) NULL,
 CONSTRAINT [PK_Warehouse_BillMaster] PRIMARY KEY CLUSTERED 
(
	[Selling_MasterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse_Store]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse_Store](
	[StoreId] [int] IDENTITY(1,1) NOT NULL,
	[MStoreId] [int] NOT NULL,
	[Billno] [int] NULL,
	[SupplyRepId] [int] NOT NULL,
	[SuppliersId] [int] NOT NULL,
	[PurchasingPrice] [decimal](18, 2) NULL,
	[SellingPrice] [decimal](18, 2) NULL,
	[IdCategoryProduct] [int] NULL,
	[ProdouctsID] [int] NULL,
	[ExpireDate] [datetime] NULL,
	[Productiondate] [datetime] NULL,
	[MinimumQT] [int] NULL,
	[SizeProducts] [int] NULL,
	[Notes] [nvarchar](150) NULL,
	[TotalPrice] [decimal](18, 2) NULL,
	[Discount] [int] NULL,
	[TotalBDiscount] [decimal](18, 2) NULL,
	[AMountDicount] [decimal](18, 2) NULL,
	[TotalAmountRow] [decimal](18, 2) NULL,
	[MainUnitesId] [int] NULL,
	[SUBUnitesId] [int] NULL,
	[TotalSize] [decimal](18, 2) NULL,
	[Quntity_Product] [int] NULL,
	[QtStartPeriod] [int] NULL,
	[Anexpiredproduct] [bit] NULL,
 CONSTRAINT [PK_Warehouse_Store] PRIMARY KEY CLUSTERED 
(
	[StoreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse_Suppliers]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse_Suppliers](
	[SuppliersID] [int] IDENTITY(1,1) NOT NULL,
	[SName] [nvarchar](50) NULL,
	[Phone] [nvarchar](12) NULL,
	[Address] [nvarchar](50) NULL,
	[WDate] [datetime] NULL,
	[Notes] [nvarchar](50) NULL,
	[UsersID] [int] NULL,
 CONSTRAINT [PK_Warehouse_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SuppliersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse_SupplyRepresentative]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse_SupplyRepresentative](
	[SupplyRepID] [int] IDENTITY(1,1) NOT NULL,
	[SuppliersID] [int] NOT NULL,
	[SRName] [nvarchar](50) NULL,
	[Phone] [nvarchar](11) NULL,
	[Address] [nvarchar](50) NULL,
	[WDate] [datetime] NULL,
	[Notes] [nvarchar](150) NULL,
	[UsersID] [int] NULL,
 CONSTRAINT [PK_Warehouse_SupplyRepresentative] PRIMARY KEY CLUSTERED 
(
	[SupplyRepID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse_UnitesSub]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse_UnitesSub](
	[UnitesId] [int] IDENTITY(1,1) NOT NULL,
	[UnitesNId] [int] NULL,
	[UnitConvert] [int] NULL,
	[UnitsSubName] [nvarchar](10) NULL,
	[WDate] [date] NULL,
	[UsersID] [int] NULL,
 CONSTRAINT [PK_Warehouse_Unites] PRIMARY KEY CLUSTERED 
(
	[UnitesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse_Users]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse_Users](
	[UsersID] [int] IDENTITY(1,1) NOT NULL,
	[U_Username] [nvarchar](15) NULL,
	[U_Password] [nvarchar](15) NULL,
	[WDate] [datetime] NULL,
 CONSTRAINT [PK_Warehouse_Users] PRIMARY KEY CLUSTERED 
(
	[UsersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WarehouseCustomers]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WarehouseCustomers](
	[CustomersID] [int] IDENTITY(1,1) NOT NULL,
	[CName] [nvarchar](50) NULL,
	[Phone] [nvarchar](12) NULL,
	[Address] [nvarchar](50) NULL,
	[WDate] [datetime] NULL,
	[Notes] [nvarchar](150) NULL,
	[UsersID] [int] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Watehouse_BarCode]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Watehouse_BarCode](
	[BarCodeID] [int] IDENTITY(1,1) NOT NULL,
	[BarcodeCategory_Product] [int] NULL,
	[BarCodeProduct] [int] NULL,
	[BarCodeDate] [datetime] NULL,
	[BarCodeText] [nvarchar](25) NULL,
 CONSTRAINT [PK_Watehouse_BarCode] PRIMARY KEY CLUSTERED 
(
	[BarCodeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WatehouseProdoucts]    Script Date: 4/6/2021 8:14:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WatehouseProdoucts](
	[ProdouctsID] [int] IDENTITY(1,1) NOT NULL,
	[IdCategoryProduct] [int] NULL,
	[Pname] [nvarchar](50) NULL,
	[WDate] [date] NULL,
	[Notes] [nvarchar](150) NULL,
	[UsersID] [int] NULL,
	[BarCodeText] [int] NULL,
 CONSTRAINT [PK_WatehouseProdoucts] PRIMARY KEY CLUSTERED 
(
	[ProdouctsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Warehouse_Quantity_Product] ADD  CONSTRAINT [DF_Warehouse_Quantity_Product_Wdate]  DEFAULT (getdate()) FOR [Wdate]
GO
ALTER TABLE [dbo].[Warehouse_ReturnProducts] ADD  CONSTRAINT [DF_Warehouse_ReturnProducts__datetime]  DEFAULT (getdate()) FOR [_datetime]
GO
ALTER TABLE [dbo].[Warehouse_Selling] ADD  CONSTRAINT [DF_Warehouse_Selling_PointsId]  DEFAULT ((0)) FOR [PointsId]
GO
ALTER TABLE [dbo].[Warehouse_Selling] ADD  CONSTRAINT [DF_Warehouse_Bill_TotalPrice]  DEFAULT ((0)) FOR [TotalPrice]
GO
ALTER TABLE [dbo].[_Warehouse_invoice_Store_Status]  WITH CHECK ADD  CONSTRAINT [FK__Warehouse_invoice_Store_Status_Warehouse_Master_Store] FOREIGN KEY([MStoreId])
REFERENCES [dbo].[Warehouse_Master_Store] ([StoreId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[_Warehouse_invoice_Store_Status] CHECK CONSTRAINT [FK__Warehouse_invoice_Store_Status_Warehouse_Master_Store]
GO
ALTER TABLE [dbo].[Warehouse_Qutaly]  WITH CHECK ADD  CONSTRAINT [FK_Warehouse_Qutaly_Warehouse_OutLayUnites] FOREIGN KEY([OutLayUnID])
REFERENCES [dbo].[Warehouse_OutLayUnites] ([OutLayID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Warehouse_Qutaly] CHECK CONSTRAINT [FK_Warehouse_Qutaly_Warehouse_OutLayUnites]
GO
ALTER TABLE [dbo].[Warehouse_Selling_Master]  WITH CHECK ADD  CONSTRAINT [FK_Warehouse_BillMaster_WarehouseCustomers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[WarehouseCustomers] ([CustomersID])
GO
ALTER TABLE [dbo].[Warehouse_Selling_Master] CHECK CONSTRAINT [FK_Warehouse_BillMaster_WarehouseCustomers]
GO
ALTER TABLE [dbo].[Warehouse_UnitesSub]  WITH CHECK ADD  CONSTRAINT [FK_Warehouse_Unites_Warehouse_UnitesName] FOREIGN KEY([UnitesNId])
REFERENCES [dbo].[Warehouse_MainUnites] ([UnitesNId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Warehouse_UnitesSub] CHECK CONSTRAINT [FK_Warehouse_Unites_Warehouse_UnitesName]
GO
ALTER TABLE [dbo].[WatehouseProdoucts]  WITH CHECK ADD  CONSTRAINT [FK_WatehouseProdoucts_Warehouse_CategoryProduct] FOREIGN KEY([IdCategoryProduct])
REFERENCES [dbo].[Warehouse_CategoryProduct] ([IdCategoryProduct])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[WatehouseProdoucts] CHECK CONSTRAINT [FK_WatehouseProdoucts_Warehouse_CategoryProduct]
GO
