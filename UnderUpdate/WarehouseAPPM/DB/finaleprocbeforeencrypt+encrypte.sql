USE [Warehouse]
GO
/****** Object:  View [dbo].[_WarehouseSelectQutalyView]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[_WarehouseSelectQutalyView]
AS
SELECT        dbo.Warehouse_Qutaly.OutLayUnID, dbo.Warehouse_Qutaly.Amount, dbo.Warehouse_Qutaly.UsersID, dbo.Warehouse_Qutaly.WDate, dbo.Warehouse_Qutaly.Notes, dbo.Warehouse_OutLayUnites.OutLayID, 
                         dbo.Warehouse_OutLayUnites.QName, dbo.Warehouse_Users.UsersID AS Expr1, dbo.Warehouse_Users.U_Username
FROM            dbo.Warehouse_Qutaly INNER JOIN
                         dbo.Warehouse_OutLayUnites ON dbo.Warehouse_Qutaly.OutLayUnID = dbo.Warehouse_OutLayUnites.OutLayID INNER JOIN
                         dbo.Warehouse_Users ON dbo.Warehouse_Qutaly.UsersID = dbo.Warehouse_Users.UsersID




GO
/****** Object:  View [dbo].[_WarehouseSelectUsersView]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[_WarehouseSelectUsersView]
AS
SELECT        UsersID AS [#], U_Username AS اليوزر, WDate AS التاريخ
FROM            dbo.Warehouse_Users




GO
/****** Object:  View [dbo].[WarehouseSelectAllCustomersARView]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 

create view [dbo].[WarehouseSelectAllCustomersARView]
WITH SCHEMABINDING 
as
 
 SELECT        CustomersID , CName , Phone , [Address] , WarehouseCustomers. WDate , Notes  
FROM         dbo.WarehouseCustomers   

GO
/****** Object:  View [dbo].[WarehouseSelectEmployeeARView]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






Create view
[dbo].[WarehouseSelectEmployeeARView]
WITH SCHEMABINDING 
as

 
SELECT       dbo. Warehouse_Employee.EmployeeId  ,  dbo. Warehouse_Employee.EName  ,  dbo. Warehouse_Employee.Phone  ,  dbo. Warehouse_Employee.[Address]  ,   dbo. Warehouse_Employee.Salary  ,  dbo. Warehouse_Employee.WDate ,  dbo. Warehouse_Employee.Notes  
FROM           dbo.Warehouse_Employee
  











GO
/****** Object:  View [dbo].[WarehouseSelectProdouctsARView]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[WarehouseSelectProdouctsARView]
WITH SCHEMABINDING 
as
SELECT        ProdouctsID  , Pname  , WDate  , BarCodeText  
FROM        [dbo].    WatehouseProdoucts





GO
/****** Object:  View [dbo].[WarehouseSelectSuppliersARView]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[WarehouseSelectSuppliersARView]
WITH SCHEMABINDING 
as
 SELECT        SuppliersID  , SName  , Phone  , [Address]  , Notes  
FROM           dbo. Warehouse_Suppliers





GO
/****** Object:  StoredProcedure [dbo].[_GetUSerBaseName]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_GetUSerBaseName]

@USER_NAME nvarchar(15)
 WITH ENCRYPTION
as
begin
SELECT * FROM TBUSERS where USER_NAME=@USER_NAME
end


GO
/****** Object:  StoredProcedure [dbo].[_InsertAdmin]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





create proc _Warehouse_GetPriceSelling
@Pname nvarchar(50) with ENCRYPTION
as
begin
select Warehouse_Store.SellingPrice 
from Warehouse_Store ,WatehouseProdoucts,Warehouse_Master_Store
where Warehouse_Store.ProdouctsID =WatehouseProdoucts.ProdouctsID
and
Warehouse_Master_Store.StoreId = Warehouse_Store.MStoreId

and
 WatehouseProdoucts.Pname =@Pname
 end
 go
CREATE PROCEDURE [dbo].[_InsertAdmin]

@U_Username Nvarchar(10)
,
@U_Password nvarchar(40)  
WITH ENCRYPTION
 as
 begin
INSERT INTO Administartion
                         (U_Username, U_Password)
VALUES        (@U_Username,@U_Password)

end



GO
/****** Object:  StoredProcedure [dbo].[_SelectSupplyRepresentativeBYsupply]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_SelectSupplyRepresentativeBYsupply]
 
@Supplyid int  
WITH ENCRYPTION
as

begin


SELECT        SupplyRepID, SuppliersID, SRName, Phone, [Address], WDate, Notes
FROM            Warehouse_SupplyRepresentative where SuppliersID=@Supplyid
end





GO
/****** Object:  StoredProcedure [dbo].[_Warehosue_Select_ALL_invoiceSelling]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[_Warehosue_Select_ALL_invoiceSelling]
 
@PageOffset int,
@MaxRecords int  WITH ENCRYPTION
as
begin
SELECT        Warehouse_Selling_Master.Selling_MasterID    as[#]
,
WatehouseProdoucts.Pname as [المنتج],
Warehouse_Selling_Master.WDate as [التاريخ],
Warehouse_MainUnites.UName as[الوحدة الرئيسية],
Warehouse_UnitesSub.UnitsSubName as[الوحده الفرعيه] ,
Warehouse_Selling.Quntity_Product as[الكميه],
Warehouse_Selling.Discount as[الخصم],
Warehouse_Selling.TotalBDiscount as[الاجمالى قبل الخصم],
Warehouse_Selling.AMountDicount as[مبلغ الخصم],
Warehouse_Selling.SellingPrice as[سعر البيع], 
Warehouse_Selling.TotalPrice as[الاجمالى],
Warehouse_Employee.EName as[الموظف] 
  
FROM            Warehouse_Selling INNER JOIN
                         Warehouse_MainUnites ON Warehouse_Selling.UnitesNId = Warehouse_MainUnites.UnitesNId INNER JOIN
                         Warehouse_UnitesSub ON Warehouse_MainUnites.UnitesNId = Warehouse_UnitesSub.UnitesNId INNER JOIN
                         WatehouseProdoucts ON Warehouse_Selling.ProdouctsId = WatehouseProdoucts.ProdouctsID INNER JOIN
                         Warehouse_Selling_Master ON Warehouse_Selling.Selling_MasterID = Warehouse_Selling_Master.Selling_MasterID
						 inner join
						 Warehouse_Employee on Warehouse_Selling.EmpId = Warehouse_Employee.EmployeeId 
		 ORDER BY Warehouse_Selling_Master.Selling_MasterID OFFSET @PageOffset 
ROWS FETCH NEXT @MaxRecords 
ROWS ONLY


end


GO
/****** Object:  StoredProcedure [dbo].[_Warehosue_Select_ALL_invoiceSTore]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--alter proc _Warehosue_Select_ALL_invoiceSTore
--@PageOffset int,
--@MaxRecords int
--as
--begin
-- SELECT
 
--Warehouse_Master_Store.StoreId,
--Warehouse_Store.MStoreId,
 
--Warehouse_Store.Billno,
--Warehouse_Store.PurchasingPrice,
--Warehouse_Store.ProdouctsID,
--Warehouse_Store.Quntity_Product,
--WatehouseProdoucts.ProdouctsID,
--WatehouseProdoucts.Pname,

--Warehouse_Suppliers.SuppliersID,
--Warehouse_Suppliers.SName
-- FROM 
--Warehouse_Store,
--Warehouse_Master_Store,
--WatehouseProdoucts,
--Warehouse_Suppliers
--where 
--Warehouse_Master_Store.StoreId = Warehouse_Store.MStoreId 
--and 
--Warehouse_Store.ProdouctsID =WatehouseProdoucts.ProdouctsID
--and
--Warehouse_Store.SuppliersId = Warehouse_Suppliers.SuppliersID
--ORDER BY MStoreId OFFSET @PageOffset 
--ROWS FETCH NEXT @MaxRecords 
--ROWS ONLY
--end

CREATE proc [dbo].[_Warehosue_Select_ALL_invoiceSTore]
@PageOffset int,
@MaxRecords int  
WITH ENCRYPTION
as
begin
SELECT        Warehouse_Store.MStoreId AS [رقم الفاتورة], Warehouse_Store.Billno AS [فاتورة التاجر], Warehouse_Store.PurchasingPrice AS [سعر الشراء], Warehouse_Store.Quntity_Product AS الكمية, WatehouseProdoucts.Pname AS المنتج, 
                         Warehouse_Suppliers.SName AS التاجر
FROM            Warehouse_Store INNER JOIN
                         Warehouse_Master_Store ON Warehouse_Master_Store.StoreId = Warehouse_Store.MStoreId INNER JOIN
                         WatehouseProdoucts ON Warehouse_Store.ProdouctsID = WatehouseProdoucts.ProdouctsID INNER JOIN
                         Warehouse_Suppliers ON Warehouse_Store.SuppliersId = Warehouse_Suppliers.SuppliersID			 ORDER BY MStoreId OFFSET @PageOffset 
ROWS FETCH NEXT @MaxRecords 
ROWS ONLY


end


GO
/****** Object:  StoredProcedure [dbo].[_Warehosue_Select_ALL_invoiceSToreBY_ID]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[_Warehosue_Select_ALL_invoiceSToreBY_ID]

@StoreId int  WITH ENCRYPTION
as
begin
SELECT        Warehouse_Store.MStoreId AS [رقم الفاتورة], Warehouse_Store.Billno AS [فاتورة التاجر], Warehouse_Store.PurchasingPrice AS [سعر الشراء], Warehouse_Store.Quntity_Product AS الكمية, WatehouseProdoucts.Pname AS المنتج, 
                         Warehouse_Suppliers.SName AS التاجر
FROM            Warehouse_Store INNER JOIN
                         Warehouse_Master_Store ON Warehouse_Master_Store.StoreId = Warehouse_Store.MStoreId INNER JOIN
                         WatehouseProdoucts ON Warehouse_Store.ProdouctsID = WatehouseProdoucts.ProdouctsID INNER JOIN
                         Warehouse_Suppliers ON Warehouse_Store.SuppliersId = Warehouse_Suppliers.SuppliersID			  where Warehouse_Master_Store.StoreId =@StoreId

 end


GO
/****** Object:  StoredProcedure [dbo].[_Warehosue_Select_ProductBarcodeBYNamePrint]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_Warehosue_Select_ProductBarcodeBYNamePrint]
@Pname nvarchar(50)  WITH ENCRYPTION
as
begin
SELECT           BarCodeText,WatehouseProdoucts.ProdouctsID
FROM            WatehouseProdoucts where Pname=@Pname

end


GO
/****** Object:  StoredProcedure [dbo].[_Warehosue_Select_ProductBYBarcodePrint]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[_Warehosue_Select_ProductBYBarcodePrint]
@Pname nvarchar(50)  WITH ENCRYPTION
as
begin
SELECT          Pname, BarCodeText
FROM            WatehouseProdoucts 

end


GO
/****** Object:  StoredProcedure [dbo].[_WarehosueDel_SellingBill]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

create proc [dbo].[_WarehosueDel_SellingBill]

@Selling_MasterID int,
@CurrentQuntity_Product int,
@ProdouctsID int,
@Billno int  WITH ENCRYPTION
as

 
begin tran
 
DELETE FROM Warehouse_Selling WHERE  (Warehouse_Selling.Selling_MasterID = @Selling_MasterID)
if @@ERROR >0
rollback tran

DELETE FROM Warehouse_Selling_Master 
WHERE         Warehouse_Selling_Master.Selling_MasterID = @Selling_MasterID
if @@ERROR >0
rollback tran


UPDATE       Warehouse_Store
SET                Quntity_Product = @CurrentQuntity_Product  where Warehouse_Store.ProdouctsID =@ProdouctsID and Warehouse_Store.Billno = @Billno
if @@ERROR >0
rollback tran
commit tran

 

GO
/****** Object:  StoredProcedure [dbo].[_WarehosueDelSelling]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[_WarehosueDelSelling]
@Selling_MasterID int,
@QuantityProduct decimal,
@ProductID int  WITH ENCRYPTION
as
begin tran
DELETE FROM Warehouse_Selling where Warehouse_Selling.Selling_MasterID =@Selling_MasterID
if @@ERROR >0
rollback tran


UPDATE       Warehouse_Quantity_Product
SET                QuantityProduct =@QuantityProduct where Warehouse_Quantity_Product.ProductID =@ProductID

if @@ERROR >0
rollback tran
commit tran




GO


create proc [dbo].[_WarehosueDelStore]
@Billno int,
@QuantityProduct decimal,
@QtStartPeriod decimal,
@QTReturn decimal,
@ProductID int,
@UserID int
WITH ENCRYPTION
as
begin tran
--//DELETE FROM Warehouse_Store where Warehouse_Store.Billno =@Billno and Warehouse_Store.ProdouctsID =@ProductID
INSERT INTO Warehouse_ReturnProducts
                         (BillNo, QtStartPeriod, QTReturn, UserID)
VALUES        (@BillNo,@QtStartPeriod,@QTReturn,@UserID)

if @@ERROR >0
rollback tran


UPDATE       Warehouse_Quantity_Product
SET                QuantityProduct =@QuantityProduct where Warehouse_Quantity_Product.ProductID =@ProductID

if @@ERROR >0
rollback tran
commit tran

 
GO
 
 
 
/****** Object:  StoredProcedure [dbo].[_Warehouse_delCategoryProduct]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
create proc [dbo].[_Warehouse_delCategoryProduct]
@IdCategoryProduct int  WITH ENCRYPTION

as

begin

DELETE FROM Warehouse_CategoryProduct where Warehouse_CategoryProduct.IdCategoryProduct =@IdCategoryProduct


end



GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_delCustomers]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[_Warehouse_delCustomers]
@CustomersID int  WITH ENCRYPTION
as
begin

DELETE FROM WarehouseCustomers where CustomersID=@CustomersID

end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_delEmployee]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

create proc [dbo].[_Warehouse_delEmployee]
 @EmployeeId int  WITH ENCRYPTION
 as
 begin
 
DELETE FROM Warehouse_Employee
where EmployeeId = @EmployeeId  


end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_delOutLayUnites]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

create proc [dbo].[_Warehouse_delOutLayUnites]
@OutLayUnID int  
 WITH ENCRYPTION
as
 begin
 
DELETE FROM Warehouse_OutLayUnites
where OutLayID = @OutLayUnID
  end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_delPoints]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

create proc [dbo].[_Warehouse_delPoints]
@Pointsid int  WITH ENCRYPTION
 as
 
 begin
 
DELETE FROM Warehouse_Points		where Pointsid = @Pointsid

  end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_delProdoucts]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[_Warehouse_delProdoucts]
@ProdouctsID int  WITH ENCRYPTION
as
begin
 DELETE FROM WatehouseProdoucts where ProdouctsID = @ProdouctsID
end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_delproducts]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_Warehouse_delproducts] 
@ProdouctsID int  WITH ENCRYPTION
as
begin

DELETE FROM WatehouseProdoucts
WHERE        (ProdouctsID = @ProdouctsID)end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_delQutaly]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--#Warehouse_Qutaly

create proc [dbo].[_Warehouse_delQutaly]
@QutalyID int  WITH ENCRYPTION
 
as
 
 begin
DELETE FROM Warehouse_Qutaly
where QutalyID = @QutalyID

  end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_delStore]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[_Warehouse_delStore]
@StoreId int  WITH ENCRYPTION
as
begin

DELETE FROM Warehouse_Store where StoreId=@StoreId

end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_delSuppliers]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[_Warehouse_delSuppliers]
@SuppliersID int  WITH ENCRYPTION
as
begin

DELETE FROM Warehouse_Suppliers where SuppliersID=@SuppliersID

end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_delSupplyRepresentative]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_Warehouse_delSupplyRepresentative]
 @SupplyRepID int  WITH ENCRYPTION
as
begin
 DELETE FROM Warehouse_SupplyRepresentative

 where @SupplyRepID = SupplyRepID
end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_delUnites]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_Warehouse_delUnites]
@UnitesId int  WITH ENCRYPTION
as
begin

DELETE FROM  Warehouse_Unites
WHERE         UnitesId = @UnitesId


end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_delUnitesName]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_Warehouse_delUnitesName]
@UnitesNId int  WITH ENCRYPTION
as
begin

DELETE FROM  Warehouse_UnitesName
WHERE         UnitesNId = @UnitesNId


end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_delUsers]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_Warehouse_delUsers] 
@Userid int  WITH ENCRYPTION
as
begin

DELETE FROM  Warehouse_Users
WHERE        (UsersID = @Userid)


end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Employee]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

CREATE proc [dbo].[_Warehouse_Employee]
--@EmployeeId int
 @EName nvarchar(50),
 @Phone nvarchar(11),
 @Address nvarchar(50),
 @Salary decimal(7, 2),
 @WDate datetime,
 @SalaryDate datetime,
 @Notes nvarchar(150),
 @UsersID int  WITH ENCRYPTION
as
 begin
 
INSERT INTO Warehouse_Employee
                         (EName, Phone, [Address], Salary, WDate,SalaryDate, Notes,UsersID)
VALUES        (@EName,@Phone,@Address,@Salary,@WDate,@SalaryDate,@Notes,@UsersID )  end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Insert_MainUnites]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




create proc [dbo].[_Warehouse_Insert_MainUnites]
--@Userid int,
@UName nvarchar(50), 
@WDate datetime ,
@UnitConvert int,
@UsersID int  WITH ENCRYPTION
 
as
begin 
 
 INSERT INTO Warehouse_MainUnites
                         (UName, WDate,UnitConvert,UsersID)
VALUES        (@UName,@WDate,@UnitConvert,@UsersID)
 
 end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Insert_NewQuantity]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery3.sql|7|0|C:\Users\bishoe\AppData\Local\Temp\~vs54CB.sql


CREATE proc [dbo].[_Warehouse_Insert_NewQuantity]
@QuantityProduct decimal, @ProductID int   WITH ENCRYPTION
as
begin

--declare @GETProductID nvarchar(20),@ALLRES nvarchar ;
--set @GETProductID=(select Warehouse_Quantity_Product.ProductID from Warehouse_Quantity_Product where ProductID =1011);
----set @ALLRES  =@GETProductID ;
----select @ALLRES as [bb];
--if @GETProductID is not  null 
   UPDATE       Warehouse_Quantity_Product
SET                QuantityProduct = @QuantityProduct  where ProductID=@ProductID
 

--else 
-- INSERT INTO Warehouse_Quantity_Product
--                         (QuantityProduct, ProductID)
--VALUES        (@QuantityProduct,@ProductID)

  
end

 


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Insert_Selling]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_Warehouse_Insert_Selling]

@EmpId int,
@Selling_MasterID int,
@ProdouctsId int,
@UnitesNId  int,
@Quntity_Product decimal, 
@SellingPrice decimal,
@TotalPrice int,
@UsersID int, 
@_Quantity_Product			decimal,--Quantity_Product table
@TotalBDiscount decimal,--Total before Discount
@Discount int,
@AMountDicount decimal,
@TotalAmountRow decimal  WITH ENCRYPTION
as
 
-- begin try
--begin tran
 

---------Start Insert Bill Details
  
INSERT INTO Warehouse_Selling
         (Selling_MasterID, ProdouctsId,  UnitesNId 
		 --,SUBUnitesId 
		    , Quntity_Product,
		 --Notes,
		 SellingPrice,TotalPrice,
		 --Billno,
		 --IdCategoryProduct,
		 UsersID,
Discount,TotalBDiscount,AMountDicount,TotalAmountRow,EmpId)
		 
VALUES        (@Selling_MasterID,@ProdouctsId,@UnitesNId 
--,@SUBUnitesId  
,
 @Quntity_Product ,   
--@Notes,
@SellingPrice,@TotalPrice,
--@Billno,
--@IdCategoryProduct,
@UsersID,@Discount,@TotalBDiscount,@AMountDicount,@TotalAmountRow,@EmpId)
--if @@ERROR > 0
--RollBack tran
 
 ----------------
   
UPDATE       Warehouse_Quantity_Product
SET                QuantityProduct = @_Quantity_Product, ProductID =@ProdouctsId
--if @@ERROR > 0
 
  
 --Commit tran

 --end try

 --begin catch

 --rollback tran
 --end catch





GO
 

/****** Object:  StoredProcedure [dbo].[_Warehouse_Insert_Selling_Master]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[_Warehouse_Insert_Selling_Master]
@WDate datetime,

@CustomerID int  WITH ENCRYPTION
--,
--@U_Username nvarchar(20)
as


begin
INSERT INTO Warehouse_Selling_Master
                         (WDate, CustomerID
						-- U_Username
						 )
  
VALUES        (@WDate,@CustomerID
--,@U_Username
)
SELECT SCOPE_IDENTITY()

end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Insert_SubUnits]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[_Warehouse_Insert_SubUnits]
@UnitesNId int,
@UnitConvert int ,
@UnitsSubName nvarchar(10),
@WDate date,
@UsersID int  WITH ENCRYPTION
as
begin
INSERT INTO Warehouse_UnitesSub
                         (UnitesNId, UnitConvert, UnitsSubName, WDate, UsersID)
VALUES        (@UnitesNId,@UnitConvert,@UnitsSubName,@WDate,@UsersID)
end


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Insert_UnitesName]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[_Warehouse_Insert_UnitesName]
--@Userid int,
@UName nvarchar(50), 
@WDate datetime ,@UnitConvert int,
@UsersID int   WITH ENCRYPTION
 
as
begin 
 
 INSERT INTO Warehouse_UnitesName
                         (UName, WDate,UnitConvert,UsersID)
VALUES        (@UName,@WDate,@UnitConvert,@UsersID)
 
 end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_invoice_Store_Status_GETALL]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_Warehouse_invoice_Store_Status_GETALL]
 WITH ENCRYPTION
as
begin
select MStoreId as[فاتورة المخزن],Billno as[فاتورة التاجر],PAIDAMOUNT as[المدفوع],RemainingAMOUNT as[المتبقى],wdate as[التاريخ] from _Warehouse_invoice_Store_Status order by ID
end


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_invoice_Store_StatusINSERT]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[_Warehouse_invoice_Store_StatusINSERT]
@MStoreId int,@Billno  int,@UserID int,@PAIDAMOUNT decimal(18,2), @RemainingAMOUNT decimal(18,2),@Wdate datetime  WITH ENCRYPTION
as
begin
INSERT INTO _Warehouse_invoice_Store_Status
                         (MStoreId, Billno, UserID, PAIDAMOUNT, RemainingAMOUNT,Wdate)
VALUES        (@MStoreId,@Billno,@UserID,@PAIDAMOUNT,@RemainingAMOUNT,@Wdate)
end


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_invoice_Store_StatusSelectALL]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[_Warehouse_invoice_Store_StatusSelectALL]
 WITH ENCRYPTION
as
begin


select * from _Warehouse_invoice_Store_Status
where _Warehouse_invoice_Store_Status.PAIDAMOUNT !=RemainingAMOUNT

 order by ID
end


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_invoice_Store_StatusUpdate]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[_Warehouse_invoice_Store_StatusUpdate]
@MStoreId int,@UserID int,@PAIDAMOUNT decimal(18,2)  WITH ENCRYPTION
as
begin
     UPDATE       _Warehouse_invoice_Store_Status
SET                PAIDAMOUNT =@PAIDAMOUNT, UserID =  @UserID  
where MStoreId =@MStoreId  

 end


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_InvoiceSelling_Print]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[_Warehouse_InvoiceSelling_Print]
@Selling_MasterID int  WITH ENCRYPTION
as
begin

SELECT        Warehouse_Selling.Selling_MasterID AS [#], Warehouse_Selling.TotalPrice AS الاجمالى, Warehouse_Selling.Quntity_Product AS الكميه, 
                         Warehouse_Selling.AMountDicount AS الخصم, Warehouse_Selling.SellingPrice AS [سعر البيع], WarehouseCustomers.CName AS العميل, WatehouseProdoucts.Pname AS المنتج,Warehouse_MainUnites.UName as [الوحده], Warehouse_Selling_Master.U_Username AS [البائع ], 
                         WatehouseProdoucts.ProdouctsID AS [رقم المنتج]
FROM            Warehouse_Selling INNER JOIN
                         Warehouse_Selling_Master ON Warehouse_Selling.Selling_MasterID = Warehouse_Selling_Master.Selling_MasterID INNER JOIN
                         Warehouse_MainUnites ON Warehouse_Selling.UnitesNId = Warehouse_MainUnites.UnitesNId  INNER JOIN
                         WarehouseCustomers ON Warehouse_Selling_Master.CustomerID = WarehouseCustomers.CustomersID INNER JOIN
                         WatehouseProdoucts ON Warehouse_Selling.ProdouctsId = WatehouseProdoucts.ProdouctsID   AND Warehouse_Selling_Master.Selling_MasterID = @Selling_MasterID   
						 end


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_MainUnitesDelete]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[_Warehouse_MainUnitesDelete]
@UnitesNId int WITH ENCRYPTION
as
begin

DELETE FROM Warehouse_MainUnites where Warehouse_MainUnites.UnitesNId =@UnitesNId

end
GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_MasterStore]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_Warehouse_MasterStore]

@WDate datetime,
@EmployeeId int,
@UsersID int  WITH ENCRYPTION
as
begin
 insert into Warehouse_Master_Store (WDate,EmployeeId,UsersID) 
values
(   @WDate , 
@EmployeeId  ,
@UsersID )
end


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_OutLayUnites]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

CREATE proc [dbo].[_Warehouse_OutLayUnites]
@QName nvarchar(50)  WITH ENCRYPTION
      
 
as
 
 begin
 
 INSERT INTO Warehouse_OutLayUnites
                         (QName   )
VALUES        (@QName )
  end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Points]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--#Warehouse_Qutaly

CREATE proc [dbo].[_Warehouse_Points]
@CustomerId int,
@TotalPoint int,
@WDate datetime,
@Notes nvarchar(150) ,
 
@EmpId int  WITH ENCRYPTION
as
 
 begin
 
 INSERT INTO Warehouse_Points
                         (CustomerId, TotalPoint, WDate, Notes, EmpId)
VALUES        (@CustomerId,@TotalPoint,@WDate,@Notes,@EmpId)
  end





GO
/****** Object:  StoredProcedure [dbo].[_warehouse_ProductExpireDate]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
CREATE proc [dbo].[_warehouse_ProductExpireDate]
@Wdate datetime   with ENCRYPTION
as
begin
select      Warehouse_Store.MStoreId as[فاتور المخزن],Warehouse_Store.Billno as [فاتورة التاجر],Warehouse_Store.ExpireDate as [تاريخ الانتهاء],WatehouseProdoucts.Pname as [المنتج],Warehouse_Master_Store.WDate as [تاريخ الشراء],Warehouse_Store.Quntity_Product as [الكميه المشتراه],Warehouse_Store.Productiondate as [تاريخ الانتاج],Warehouse_Store.TotalPrice as [السعر الاجمالى]
from Warehouse_Master_Store ,Warehouse_Store,WatehouseProdoucts
  where DATEDIFF(D ,@Wdate,Warehouse_Store.ExpireDate)<=30
  and
  Warehouse_Master_Store.StoreId = Warehouse_Store.MStoreId
  and
  WatehouseProdoucts.ProdouctsID = Warehouse_Store.ProdouctsID
  end

GO
/****** Object:  StoredProcedure [dbo].[_warehouse_ProductExpireDateDays]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
 
 CREATE proc [dbo].[_warehouse_ProductExpireDateDays]
@Days int,
@Wdate datetime WITH ENCRYPTION
  
as
begin
select      Warehouse_Store.MStoreId as[فاتور المخزن],Warehouse_Store.Billno as [فاتورة التاجر],Warehouse_Store.ExpireDate as [تاريخ الانتهاء],WatehouseProdoucts.Pname as [المنتج],Warehouse_Master_Store.WDate as [تاريخ الشراء],Warehouse_Store.Quntity_Product as [الكميه المشتراه],Warehouse_Store.Productiondate as [تاريخ الانتاج],Warehouse_Store.TotalPrice as [السعر الاجمالى]from Warehouse_Master_Store ,Warehouse_Store,WatehouseProdoucts
  where DATEDIFF(D ,@Wdate,Warehouse_Store.ExpireDate)<=@Days
  and
  Warehouse_Master_Store.StoreId = Warehouse_Store.MStoreId
  and
  WatehouseProdoucts.ProdouctsID = Warehouse_Store.ProdouctsID
  end

GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_products]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[_Warehouse_products] 
@IdCategoryProduct int,
@Pname nvarchar(50),
@WDate Datetime,
@Notes nvarchar(150),
@BarCodeText int ,
@UsersID int  WITH ENCRYPTION
as
begin

INSERT INTO WatehouseProdoucts
                         (Pname, WDate, Notes,IdCategoryProduct,BarCodeText,UsersID)
VALUES        (@Pname,@WDate,@Notes,@IdCategoryProduct,@BarCodeText,@UsersID)

end






GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Qutaly]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--#Warehouse_Qutaly

CREATE proc [dbo].[_Warehouse_Qutaly]
@OutLayUnID int,
--@QName int,
@Amount decimal(7,2),
--@EmpID int ,
@WDate datetime,
@Notes nvarchar(150),
@UsersID int  WITH ENCRYPTION
as
 
 begin


INSERT INTO Warehouse_Qutaly
                         (OutLayUnID,Amount,    WDate, Notes,UsersID)
VALUES        (@OutLayUnID,@Amount,  @WDate,@Notes,@UsersID)
 end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Qutaly_Selectbyid]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[_Warehouse_Qutaly_Selectbyid]
@QutalyID int WITH ENCRYPTION
as
begin
SELECT        QutalyID, OutLayUnID, Amount, UsersID, WDate, Notes
FROM            Warehouse_Qutaly where QutalyID=@QutalyID
end
GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_QutalyUpdate]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc
[dbo].[_Warehouse_QutalyUpdate]
@QutalyID int,
@OutLayUnID int,
@Amount decimal,
@Notes nvarchar(50) WITH ENCRYPTION
as
begin
UPDATE       Warehouse_Qutaly
SET                OutLayUnID =@OutLayUnID , Amount =@Amount, Notes =@Notes where QutalyID =@QutalyID

end
GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Select_AllOutLayUnites]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[_Warehouse_Select_AllOutLayUnites]
 WITH ENCRYPTION
as

SELECT        OutLayID, QName   
FROM            Warehouse_OutLayUnites 


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Select_AllOutLayUnitesBYID]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_Warehouse_Select_AllOutLayUnitesBYID]
@OutLayID int WITH ENCRYPTION
as
begin

select Warehouse_OutLayUnites.QName,Warehouse_OutLayUnites.OutLayID
 from Warehouse_OutLayUnites where OutLayID=@OutLayID
end
GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Select_BarCodeByProductid]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
 --Selling screen
CREATE  proc [dbo].[_Warehouse_Select_BarCodeByProductid]
--create proc _Warehouse_Select_ALL_CATSProduct
  
 @BarCode int=null  WITH ENCRYPTION
as

begin
SELECT    Warehouse_CategoryProduct.IdCategoryProduct,Warehouse_CategoryProduct.CategoryName ,WatehouseProdoucts.ProdouctsID,WatehouseProdoucts.Pname ,WatehouseProdoucts.BarCodeText ,Warehouse_Quantity_Product.ID,Warehouse_Quantity_Product.ProductID,Warehouse_Quantity_Product.QuantityProduct,Warehouse_MainUnites.UnitesNId,Warehouse_MainUnites.UName,Warehouse_MainUnites.UnitConvert
from Warehouse_CategoryProduct,WatehouseProdoucts,Warehouse_Quantity_Product,Warehouse_MainUnites
where 
  WatehouseProdoucts.BarCodeText = @BarCode 

and Warehouse_CategoryProduct.IdCategoryProduct =WatehouseProdoucts.IdCategoryProduct 
and
WatehouseProdoucts.ProdouctsID = Warehouse_Quantity_Product.ProductID

end


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Select_MainUnites]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE proc [dbo].[_Warehouse_Select_MainUnites]
 WITH ENCRYPTION
as
begin
SELECT       UnitesNId,UName, UnitConvert
FROM            Warehouse_MainUnites
end


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Select_MAX_ID_Selling_Master]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create proc [dbo].[_Warehouse_Select_MAX_ID_Selling_Master]
WITH ENCRYPTION
 
as


begin

select MAX(Selling_MasterID)+1 as Selling_MasterID from Warehouse_Selling_Master
end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Select_ProdouctsBYBarcode]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--GET BarCode product => Warehouse screen
create proc 
[dbo].[_Warehouse_Select_ProdouctsBYBarcode]
@BarCode int  with ENCRYPTION
as
SELECT        ProdouctsID, Pname, WDate, Notes, BarCodeText
FROM            WatehouseProdoucts where BarCodeText=@BarCode


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Select_QuantityByProductid]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 


CREATE  proc [dbo].[_Warehouse_Select_QuantityByProductid]
--create proc _Warehouse_Select_ALL_CATSProduct
 @ProdouctsID int=0,
 @BarCode int=0  WITH ENCRYPTION
as

begin
SELECT    Warehouse_CategoryProduct.IdCategoryProduct,Warehouse_CategoryProduct.CategoryName ,WatehouseProdoucts.ProdouctsID,WatehouseProdoucts.Pname ,WatehouseProdoucts.BarCodeText ,Warehouse_Quantity_Product.ID,Warehouse_Quantity_Product.ProductID,Warehouse_Quantity_Product.QuantityProduct
from Warehouse_CategoryProduct,WatehouseProdoucts,Warehouse_Quantity_Product
where(
WatehouseProdoucts.ProdouctsID =@ProdouctsID OR @ProdouctsID  IS Null) 
--and(WatehouseProdoucts.BarCodeText = @BarCode OR @BarCode   IS Null)

and Warehouse_CategoryProduct.IdCategoryProduct =WatehouseProdoucts.IdCategoryProduct 
and Warehouse_CategoryProduct.IdCategoryProduct = WatehouseProdoucts.IdCategoryProduct

and
WatehouseProdoucts.ProdouctsID = Warehouse_Quantity_Product.ProductID
end


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Select_QuantityProduct]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[_Warehouse_Select_QuantityProduct]
--create proc _Warehouse_Select_ALL_CATSProduct
@IdCategoryProduct int,
@ProdouctsID int  WITH ENCRYPTION
as

begin
SELECT    Warehouse_CategoryProduct.IdCategoryProduct,Warehouse_CategoryProduct.CategoryName ,WatehouseProdoucts.ProdouctsID,WatehouseProdoucts.Pname  ,Warehouse_Quantity_Product.ID,Warehouse_Quantity_Product.ProductID,Warehouse_Quantity_Product.QuantityProduct
from Warehouse_CategoryProduct,WatehouseProdoucts,Warehouse_Quantity_Product
where Warehouse_CategoryProduct.IdCategoryProduct =WatehouseProdoucts.IdCategoryProduct 
and Warehouse_CategoryProduct.IdCategoryProduct = @IdCategoryProduct

and
WatehouseProdoucts.ProdouctsID =@ProdouctsID
and
WatehouseProdoucts.ProdouctsID = Warehouse_Quantity_Product.ProductID
end


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Select_QutalBYID]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

CREATE proc [dbo].[_Warehouse_Select_QutalBYID]
@QutalyID int  WITH ENCRYPTION
as
begin
SELECT        Warehouse_Qutaly.*
FROM            Warehouse_Qutaly where QutalyID=@QutalyID

end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Select_SubUnis_BYID]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[_Warehouse_Select_SubUnis_BYID]

@UnitesId int  WITH ENCRYPTION
as
begin
SELECT      *  
             
FROM            Warehouse_UnitesSub

where Warehouse_UnitesSub.UnitesId =@UnitesId

and

Warehouse_UnitesSub.UnitesId=@UnitesId
end


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Select_SubUnis_BYIDMainUnit]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[_Warehouse_Select_SubUnis_BYIDMainUnit]

@UnitesNId int  WITH ENCRYPTION

as

begin

SELECT        Warehouse_UnitesSub.*
FROM            Warehouse_UnitesSub where UnitesNId=@UnitesNId 
end


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_SelectAll_UnitesNameById]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

CREATE proc [dbo].[_Warehouse_SelectAll_UnitesNameById]
@UnitesNId int  WITH ENCRYPTION
as
begin

SELECT        Warehouse_MainUnites.*
FROM 

           Warehouse_MainUnites where UnitesNId =@UnitesNId

		   end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_SElectMAXEMPID]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




create proc [dbo].[_Warehouse_SElectMAXEMPID]
 WITH ENCRYPTION

as


begin

select MAX(Warehouse_Employee.EmployeeId
)+1 as EmployeeId from Warehouse_Employee
end



GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_SElectMAXIDStore]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[_Warehouse_SElectMAXIDStore]
 WITH ENCRYPTION

as


begin

select MAX(Warehouse_Master_Store.StoreId)+1 as StoreId from Warehouse_Master_Store
end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_SelectProducts]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[_Warehouse_SelectProducts]

@IdCategoryProduct int  WITH ENCRYPTION
as

begin

SELECT       Warehouse_CategoryProduct.IdCategoryProduct, CategoryName,WatehouseProdoucts.ProdouctsID,WatehouseProdoucts.ProdouctsID,WatehouseProdoucts.Pname,WatehouseProdoucts.WDate,WatehouseProdoucts.Notes



FROM            Warehouse_CategoryProduct,WatehouseProdoucts


where Warehouse_CategoryProduct.IdCategoryProduct = WatehouseProdoucts.IdCategoryProduct

and
Warehouse_CategoryProduct.IdCategoryProduct=@IdCategoryProduct

end



GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Store]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE proc [dbo].[_Warehouse_Store]

 

@SupplyRepId int,
@SuppliersId int,
 
@Billno int,
@PurchasingPrice decimal(18, 2),
@SellingPrice decimal(18, 2),
@ProdouctsID int,
--@MainUnitId int,
@Productiondate date,
@ExpireDate date,
--@MinimumQT int,
@SizeProducts decimal(18, 2),
@MainUnitesId int,
 
@Notes nvarchar(150),
@IdCategoryProduct int,
 
@TotalPrice decimal(18, 2),
 
@MStoreId int,

@TotalBDiscount decimal(18, 2),--Total before Discount
@Discount decimal(18, 2),
@AMountDicount decimal(18, 2),
@TotalAmountRow decimal(18, 2)
,
@TotalSize decimal(18, 2),
@Quntity_Product decimal(18, 2),
@QtStartPeriod decimal(18, 2)  WITH ENCRYPTION

 as
Begin
declare @IDStore int;set @IDStore=( select Max(StoreId)+1 as IDStore from Warehouse_Store )
select @IDStore
 




INSERT INTO Warehouse_Store
                         (
 SupplyRepId,
 SuppliersId,
 Billno,
  PurchasingPrice,
   SellingPrice,
    ProdouctsID, 
	     [ExpireDate],
		  Productiondate,
		   --MinimumQT, 
Notes,
IdCategoryProduct,
TotalPrice,
Discount,
MStoreId,
TotalBDiscount,
AMountDicount,
TotalAmountRow,
MainUnitesId,
--SUBUnitesId,
TotalSize,
Quntity_Product,
QtStartPeriod,
SizeProducts
)
VALUES        (@SupplyRepId,@SuppliersId,@Billno,@PurchasingPrice,@SellingPrice,@ProdouctsID  ,@ExpireDate,@Productiondate
--,@MinimumQT
 
, @Notes,@IdCategoryProduct,@TotalPrice,@Discount,@MStoreId,@TotalBDiscount,@AMountDicount,@TotalAmountRow,@MainUnitesId,
--@SUBUnitesId,
@TotalSize,@Quntity_Product,@QtStartPeriod,@SizeProducts)
 End






GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Store_Select_Quntity_Product]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[_Warehouse_Store_Select_Quntity_Product]

@ProdouctsID int  WITH ENCRYPTION
as
begin
select Warehouse_Store.Quntity_Product,   WatehouseProdoucts.ProdouctsID,WatehouseProdoucts.ProdouctsID ,WatehouseProdoucts.Pname from Warehouse_Store ,WatehouseProdoucts where Warehouse_Store.ProdouctsID = WatehouseProdoucts.ProdouctsID and WatehouseProdoucts.ProdouctsID =@ProdouctsID

end


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Suppliers]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[_Warehouse_Suppliers]
@SName nvarchar(50),
@Phone int,
@Address nvarchar(50),
@WDate datetime,
@Notes nvarchar(50),
@UsersID int  WITH ENCRYPTION
as
Begin


INSERT INTO Warehouse_Suppliers
                         (SName, Phone, [Address], WDate, Notes,UsersID)
VALUES        (@SName,@Phone,@Address,@WDate,@Notes,@UsersID)
end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_SupplyRepresentative]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[_Warehouse_SupplyRepresentative]
 @SuppliersID int   ,
@SRName nvarchar(50),
@Phone nvarchar(11),
@Address nvarchar(50),
@WDate datetime,
@Notes nvarchar(150),
@UsersID int  WITH ENCRYPTION
as
begin 
 

INSERT INTO Warehouse_SupplyRepresentative
                         (SuppliersID, SRName, Phone, [Address], WDate, Notes,UsersID)
VALUES        (@SuppliersID,@SRName,@Phone,@Address,@WDate,@Notes,@UsersID)                   


 end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Track_employee_progress_INSERT]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[_Warehouse_Track_employee_progress_INSERT]
@USERID int,
@StartWork datetime,
@EndWork datetime  WITH ENCRYPTION
as
INSERT INTO _Warehouse_Track_employee_progress
                         (USERID, StartWork, EndWork)
VALUES        (@USERID,@StartWork,@EndWork)


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_UnitesNameSelect]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[_Warehouse_UnitesNameSelect]
 WITH ENCRYPTION
as
begin
SELECT        UName, UnitesNId
FROM            Warehouse_MainUnites
end


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_UnitesSubSelect]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[_Warehouse_UnitesSubSelect]
@UnitesNId int  WITH ENCRYPTION
as
begin
SELECT        Warehouse_MainUnites.UName,Warehouse_MainUnites.UnitesNId,Warehouse_UnitesSub.UnitesId,
Warehouse_UnitesSub.UnitesNId,Warehouse_UnitesSub.UnitsSubName
FROM   
 Warehouse_MainUnites,     Warehouse_UnitesSub  
                       
					   where
					    Warehouse_UnitesSub.UnitesNId = Warehouse_MainUnites.UnitesNId
						 and
						 Warehouse_UnitesSub.UnitesNId = @UnitesNId
						 end


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Update_MainUnites]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
create proc [dbo].[_Warehouse_Update_MainUnites]
@UnitesNId int,
@UName nvarchar(50), 
@WDate datetime,
@UnitConvert int  WITH ENCRYPTION

 as
begin


UPDATE       Warehouse_MainUnites
SET                UName =@UName, WDate =@WDate ,UnitConvert=@UnitConvert

where UnitesNId = @UnitesNId



end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_UPdate_SubUnits]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[_Warehouse_UPdate_SubUnits]
@UnitesId int,@UnitesNId int,@UnitConvert int ,@UnitsSubName nvarchar(10)  WITH ENCRYPTION
as
begin

UPDATE       Warehouse_UnitesSub
SET                UnitesNId = @UnitesNId, UnitConvert = @UnitConvert, UnitsSubName = @UnitsSubName where Warehouse_UnitesSub.UnitesId=@UnitesId
end


GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_UpdateEmployee]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

CREATE proc [dbo].[_Warehouse_UpdateEmployee]
 @EmployeeId int,
 @EName nvarchar(50),
 @Phone nvarchar(11),
 @Address nvarchar(50),
 @Salary decimal(7, 2),
 @WDate datetime,
 @Notes nvarchar(150)  WITH ENCRYPTION
as
 begin
 
UPDATE       Warehouse_Employee
SET                EName = @EName, Phone = @Phone, Address = @Address, Salary = @Salary, WDate = @WDate, Notes = @Notes 

where EmployeeId = @EmployeeId  


end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_UpdateOutLayUnites]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

CREATE proc [dbo].[_Warehouse_UpdateOutLayUnites]
@OutLayUnID int,
@QName nvarchar(50) WITH ENCRYPTION
    
 

as
 begin
 
UPDATE       Warehouse_OutLayUnites
SET                QName = @QName 

where OutLayID = @OutLayUnID
  end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_UpdatePoints]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

CREATE proc [dbo].[_Warehouse_UpdatePoints]
@Pointsid int,
@CustomerId int,
@TotalPoint int,
@WDate datetime,
@Notes nvarchar(150) ,
@EmpId int  WITH ENCRYPTION
as
 
 begin
 
 UPDATE       Warehouse_Points
SET                CustomerId = @CustomerId, TotalPoint = @TotalPoint, WDate = @WDate, Notes = @Notes, EmpId = @EmpId  
		where Pointsid = @Pointsid

  end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_Updateproducts]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[_Warehouse_Updateproducts] 
@ProdouctsID int,
@Pname nvarchar(50),
@WDate Datetime,
@Notes nvarchar(150),
@BarCodeText int  WITH ENCRYPTION
as
begin

UPDATE       WatehouseProdoucts
SET                Pname =@Pname, WDate =@WDate, Notes =@Notes,BarCodeText=@BarCodeText where ProdouctsID= @ProdouctsID
end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_UpdateSuppliers]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[_Warehouse_UpdateSuppliers]

@SuppliersID int,
@SName nvarchar(50),
@Phone int,
@Address nvarchar(50),
@WDate datetime,
@Notes nvarchar(50)  WITH ENCRYPTION

as
Begin

UPDATE       Warehouse_Suppliers
SET                SName = @SName, Phone = @Phone, Address = @Address, WDate = @WDate, Notes = @Notes  where SuppliersID =@SuppliersID
end





GO
/****** Object:  StoredProcedure [dbo].[_Warehouse_UpdateSupplyRepresentative]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[_Warehouse_UpdateSupplyRepresentative]
@SupplyRepID int,
@SRName nvarchar(50),
@phone nvarchar(15),
@WDate datetime,
@Address nvarchar(50),
@Notes nvarchar(150),
@SuppliersID int    WITH ENCRYPTION
as
begin 
  

UPDATE       Warehouse_SupplyRepresentative
SET                SRName =@SRName, Phone =@Phone,WDate =@WDate, [Address] =@Address, Notes =@Notes, SuppliersID =@SuppliersID

where @SupplyRepID = @SupplyRepID
end





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseAddrow_Selling_Master]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[_WarehouseAddrow_Selling_Master]
WITH ENCRYPTION
as
begin
INSERT INTO Warehouse_Selling_Master
                         (WDate,U_Username)
VALUES        (GETDATE(),1)

end



GO
/****** Object:  StoredProcedure [dbo].[_WarehouseAddrowEmp]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



 CREATE proc  [dbo].[_WarehouseAddrowEmp]
  WITH ENCRYPTION
as


begin

INSERT INTO Warehouse_Employee
                         (EName, Phone, [Address], Salary, WDate, Notes, SalaryDate, UsersID, U_Password, U_Username)
VALUES        (1,1,1,1,2020-01-01,1,2020-01-01,1,1,1)end



GO
/****** Object:  StoredProcedure [dbo].[_WarehouseAddrowStore]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[_WarehouseAddrowStore]
 WITH ENCRYPTION
as
begin
INSERT INTO Warehouse_Master_Store
                         (EmployeeId,UsersID)
VALUES        (1,1)

end



GO
/****** Object:  StoredProcedure [dbo].[_WarehouseAutoCompleteSearch]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
CREATE  PROC [dbo].[_WarehouseAutoCompleteSearch]
(
    @schema NVARCHAR(128), 
    @table  NVARCHAR(128) 
)WITH ENCRYPTION
AS
    BEGIN
        DECLARE 
            @sql NVARCHAR(MAX);
        -- construct SQL
        SET @sql = N'SELECT * FROM ' 
            + QUOTENAME(@schema) 
            + '.' 
            + QUOTENAME(@table);
        -- execute the SQL
        EXEC sp_executesql @sql;
    END;





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseCheckProductInstore]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_WarehouseCheckProductInstore]

@ProdouctsID int  WITH ENCRYPTION

as
begin
SELECT        ProdouctsID
FROM            Warehouse_Store where ProdouctsID =@ProdouctsID

end





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseCustomers]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[_WarehouseCustomers] 

@CName nvarchar(50),
@Phone int,
@Address nvarchar(50),
@WDate datetime ,
@Notes nvarchar(150),
@UsersID int  WITH ENCRYPTION
as
begin
 INSERT INTO WarehouseCustomers
                         (CName, Phone, [Address], WDate, Notes,UsersID)
VALUES        (@CName,@Phone,@Address,@WDate,@Notes,@UsersID)
end





GO
/****** Object:  StoredProcedure [dbo].[_WarehousedelCustomers]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_WarehousedelCustomers] 
@CustomersID int  WITH ENCRYPTION
as
begin
DELETE FROM WarehouseCustomers
			   where CustomersID = @CustomersID 
end





GO
/****** Object:  StoredProcedure [dbo].[_warehouseExecutionofaproducer]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[_warehouseExecutionofaproducer]
 @ProductID int  WITH ENCRYPTION

 as
 -- @QTProduct GET  QTProduct from  Warehouse_Quantity_Product
 -- @QTProduct_FromWarehouse Get QTProduct_ From Warehouse
--set @calcQT = @QTProduct - @QTProduct_FromWarehouse ; 
declare @QTProduct decimal ,@QTProduct_FromWarehouse decimal,@calcQT decimal;
select @QTProduct  =Warehouse_Quantity_Product.QuantityProduct  from Warehouse_Quantity_Product where Warehouse_Quantity_Product.ProductID=@ProductID 
select @QTProduct as QTProduct

set @calcQT = @QTProduct - @QTProduct_FromWarehouse; 

UPDATE   
Warehouse_Store  SET  Anexpiredproduct =1
where 
Warehouse_Store.ProdouctsID =@ProductID


update Warehouse_Quantity_Product set QuantityProduct =@calcQT 
 where Warehouse_Quantity_Product.ProductID =@ProductID
  


GO
/****** Object:  StoredProcedure [dbo].[_warehouseExecutionofaproducerBYAnexpiredproduct]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 Create proc [dbo].[_warehouseExecutionofaproducerBYAnexpiredproduct]
 @ProductID int  WITH ENCRYPTION
 --_warehouseExecutionofaproducerBYAnexpiredproduct  set Warehouse_Store.Anexpiredproduct = 1 
 as  
UPDATE   
Warehouse_Store  SET  Anexpiredproduct =1
where 
Warehouse_Store.ProdouctsID =@ProductID

   


GO
/****** Object:  StoredProcedure [dbo].[_WarehouseReturnProduct]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--_Warehouse_Select_QuantityByProductid

create proc [dbo].[_WarehouseReturnProduct]
@Billno int  WITH ENCRYPTION
as
begin
SELECT        Warehouse_Master_Store.StoreId,
Warehouse_Store.MStoreId,
Warehouse_Store.Billno,
Warehouse_Store.ProdouctsID,
Warehouse_Store.Quntity_Product,
Warehouse_Store.QtStartPeriod,
Warehouse_Quantity_Product.ProductID, Warehouse_Quantity_Product.QuantityProduct
FROM 
		 Warehouse_Master_Store 
		 inner join 
		 Warehouse_Store on
		 Warehouse_Store.MStoreId = Warehouse_Master_Store.StoreId

		 inner join 
		 Warehouse_Quantity_Product on
		 Warehouse_Quantity_Product.ProductID =								Warehouse_Store.ProdouctsID
         where Warehouse_Store.Billno=@Billno

 end


GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectAll_CategoryProduct]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_WarehouseSelectAll_CategoryProduct]
 WITH ENCRYPTION


as

begin

SELECT   
     Warehouse_CategoryProduct.*
FROM 
Warehouse_CategoryProduct


end



GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectAll_Customers]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[_WarehouseSelectAll_Customers]
 WITH ENCRYPTION
as
Begin

SELECT        WarehouseCustomers.*
FROM            WarehouseCustomers

End





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectAll_CustomersAR]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[_WarehouseSelectAll_CustomersAR]
 WITH ENCRYPTION
as
Begin

 SELECT        CustomersID as[رقم العميل], CName as[اسم العميل], Phone as[رقم الهاتف], [Address] as[العنوان], WarehouseCustomers. WDate as[التاريخ], Notes as[ملاحظات],Warehouse_Users.U_Username
FROM            WarehouseCustomers,Warehouse_Users
End





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectAll_CustomersById]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


 

CREATE proc [dbo].[_WarehouseSelectAll_CustomersById]
@CustomersID int  
WITH ENCRYPTION
as

begin

SELECT        CustomersID, CName, Phone, [Address], WarehouseCustomers.WDate, Notes
FROM            WarehouseCustomers 


 where CustomersID = @CustomersID


End





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectAll_Employee]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create proc
[dbo].[_WarehouseSelectAll_Employee]
 WITH ENCRYPTION
as

Begin

SELECT        Warehouse_Employee.*
FROM            Warehouse_Employee
end






GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectAll_EmployeeAR]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 


create proc
[dbo].[_WarehouseSelectAll_EmployeeAR]
 WITH ENCRYPTION
as

Begin
SELECT        EmployeeId as[رقم الموظف], EName as[اسم الموظف], Phone as[رقم الهاتف], [Address] as[العنوان],  Salary as[المرتب], WDate as[التاريخ], Notes as[ملاحظات]
FROM            Warehouse_Employee
 end






GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectAll_EmployeeById]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc
[dbo].[_WarehouseSelectAll_EmployeeById]
@EmployeeId int  
WITH ENCRYPTION
as

Begin

SELECT        Warehouse_Employee.EmployeeId,Warehouse_Employee.EName,Warehouse_Employee.Address,Warehouse_Employee.Phone,Warehouse_Employee.WDate,Warehouse_Employee.Salary,Warehouse_Employee.Notes 






FROM            Warehouse_Employee  
 where EmployeeId = @EmployeeId
 


 
end 






GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectALL_SupplyRepresentative]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[_WarehouseSelectALL_SupplyRepresentative]
 @SuppliersID int
 WITH ENCRYPTION

as
Begin
SELECT        Warehouse_SupplyRepresentative.SRName,Warehouse_SupplyRepresentative.Address,Warehouse_SupplyRepresentative.Notes,Warehouse_SupplyRepresentative.Phone,Warehouse_SupplyRepresentative.SRName,Warehouse_SupplyRepresentative.SuppliersID,Warehouse_SupplyRepresentative.SupplyRepID,Warehouse_SupplyRepresentative.WDate 
 


FROM           Warehouse_Suppliers, Warehouse_SupplyRepresentative
 where Warehouse_Suppliers.SuppliersID = @SuppliersID
end





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectALL_SupplyRepresentativeAR]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

create proc [dbo].[_WarehouseSelectALL_SupplyRepresentativeAR]
 WITH ENCRYPTION
 

as
Begin
  SELECT        SupplyRepID as[رقم الموزع], SRName as[اسم الموزع], Phone as[الهاتف], [Address] as[العنوان], WDate as[التاريخ], Notes as[ملاحظات], SuppliersID as[المورد]
FROM            Warehouse_SupplyRepresentative
end





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectALL_SupplyRepresentativeByID]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[_WarehouseSelectALL_SupplyRepresentativeByID]
@SupplyRepID int  
WITH ENCRYPTION
as



Begin
SELECT        Warehouse_SupplyRepresentative.*
FROM            Warehouse_SupplyRepresentative where SupplyRepID = @SupplyRepID

end





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectAll_Unites]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[_WarehouseSelectAll_Unites]
 WITH ENCRYPTION
as

Begin

SELECT        Warehouse_Unites.*
FROM            Warehouse_Unites
end





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectAll_UnitesName]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[_WarehouseSelectAll_UnitesName]
 WITH ENCRYPTION
as
begin

SELECT        Warehouse_UnitesName.*
FROM 

           Warehouse_UnitesName

		   end





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectAll_Users]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_WarehouseSelectAll_Users]
 WITH ENCRYPTION
as
begin
SELECT        UsersID, U_Username, WDate
FROM            Warehouse_Users

end





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectAll_UsersID]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_WarehouseSelectAll_UsersID]
@UsersID int  WITH ENCRYPTION
as
begin
SELECT        UsersID, U_Username, WDate
FROM            Warehouse_Users where  UsersID=@UsersID

end





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectAll_Warehouse_SupplyRepresentativeID]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[_WarehouseSelectAll_Warehouse_SupplyRepresentativeID]
@SuppliersID int,
@SupplyRepID int  WITH ENCRYPTION
as


Begin
select Warehouse_Suppliers.SName ,Warehouse_Suppliers.SuppliersID,Warehouse_SupplyRepresentative.SuppliersID,Warehouse_SupplyRepresentative.SRName,Warehouse_SupplyRepresentative.Address,Warehouse_SupplyRepresentative.Notes

from Warehouse_Suppliers,Warehouse_SupplyRepresentative
where Warehouse_Suppliers.SuppliersID = @SuppliersID
and

Warehouse_SupplyRepresentative.SupplyRepID =@SupplyRepID

end





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectALLProdoucts]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[_WarehouseSelectALLProdoucts]
  WITH ENCRYPTION
as

begin
SELECT        WatehouseProdoucts.*
FROM            WatehouseProdoucts
 end





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectALLProdouctsAR]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 


create proc [dbo].[_WarehouseSelectALLProdouctsAR]
  WITH ENCRYPTION
as

begin

SELECT        ProdouctsID as[رقم الصنف], Pname as[اسم الصنف], WDate as[التاريخ], Notes as[ملاحظات]
FROM            WatehouseProdoucts

  end





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectALLProdouctsBYID]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[_WarehouseSelectALLProdouctsBYID]
 @ProdouctsID  int  WITH ENCRYPTION
as

begin
SELECT        WatehouseProdoucts.ProdouctsID ,WatehouseProdoucts.Pname,WatehouseProdoucts.WDate,WatehouseProdoucts.Notes,WatehouseProdoucts.BarCodeText,WatehouseProdoucts.IdCategoryProduct,Warehouse_CategoryProduct.IdCategoryProduct,Warehouse_CategoryProduct.CategoryName
FROM            WatehouseProdoucts,Warehouse_CategoryProduct

where
Warehouse_CategoryProduct.IdCategoryProduct = WatehouseProdoucts.IdCategoryProduct

and
  ProdouctsID =@ProdouctsID

 end





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectAllQutaly]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[_WarehouseSelectAllQutaly]
 WITH ENCRYPTION
as

begin




SELECT       Warehouse_Qutaly.QutalyID, Warehouse_Qutaly.Amount, Warehouse_Qutaly.[UsersID], Warehouse_Qutaly.[WDate], Warehouse_Qutaly.Notes, Warehouse_OutLayUnites.QName
 
FROM            Warehouse_Qutaly,Warehouse_OutLayUnites 

where Warehouse_Qutaly.OutLayUnID = Warehouse_OutLayUnites.OutLayID end



GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectAllSuppliers]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[_WarehouseSelectAllSuppliers]
 WITH ENCRYPTION
as

begin
SELECT        Warehouse_Suppliers.*
FROM            Warehouse_Suppliers
End





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectAllSuppliersAR]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 


CREATE proc [dbo].[_WarehouseSelectAllSuppliersAR]
 WITH ENCRYPTION
as

begin
SELECT        SuppliersID as [رقم المورد], SName as [اسم المورد], Phone as [الهاتف], [Address] as [العنوان], Warehouse_Suppliers.WDate as [التاريخ], Notes as[ملاحظات],Warehouse_Users.U_Username


FROM            Warehouse_Suppliers,Warehouse_Users

End





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectALLUnitsBYID]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[_WarehouseSelectALLUnitsBYID]
@UnitesNId int  WITH ENCRYPTION
as

Begin

SELECT        Warehouse_Unites.*
FROM            Warehouse_Unites where UnitesNId = @UnitesNId
end





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseSelectSuppliersById]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[_WarehouseSelectSuppliersById]
@SuppliersID int  WITH ENCRYPTION
as

begin

SELECT  
      Warehouse_Suppliers.SuppliersID,Warehouse_Suppliers.SName,Warehouse_Suppliers.[Address],Warehouse_Suppliers.Phone ,Warehouse_Suppliers.WDate,Notes
	   
	  
	   
FROM            Warehouse_Suppliers 

 where Warehouse_Suppliers.SuppliersID =  @SuppliersID

 End





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseUpdateCustomers]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_WarehouseUpdateCustomers] 
@CustomersID int,
@CName nvarchar(50),
@Phone int,
@Address nvarchar(50),
@WDate datetime ,
@Notes nvarchar(150)  WITH ENCRYPTION
as
begin
 Update WarehouseCustomers
 set CName= @CName, Phone=@Phone, [Address]=@Address, WDate= @WDate, Notes=@Notes 
				   where CustomersID = @CustomersID 
end





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseUpdateUsers]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_WarehouseUpdateUsers]   
@Userid int,
@U_Username nvarchar(15),
@U_Password nvarchar(15),
@WDate datetime  WITH ENCRYPTION
 
as
begin UPDATE       Warehouse_Users
SET                U_Username = @U_Username, U_Password = @U_Password, WDate = @WDate  where UsersID = @Userid
end





GO
/****** Object:  StoredProcedure [dbo].[_WarehouseUsers]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_WarehouseUsers] 

@U_Username nvarchar(15),
@U_Password nvarchar(15),
 
@WDate datetime   WITH ENCRYPTION
 
as
begin
INSERT INTO Warehouse_Users
                         (U_Username, U_Password, WDate)
VALUES        (@U_Username,@U_Password,@WDate)
 
end





GO
/****** Object:  StoredProcedure [dbo].[_WareInsertSelling]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


 CREATE proc [dbo].[_WareInsertSelling]
 WITH ENCRYPTION
 as


  
-- begin try
--begin tran

-- Exec dbo._WarehouseMasterBill

-- Exec dbo._Warehouse_BILL

-- Commit tran

-- end try

-- begin catch

-- rollback tran
-- end catch


--GO
/****** Object:  StoredProcedure [dbo].[_Watehouse_SelectBillByCustomerID]    Script Date: 1/25/2021 8:42:44 PM ******/
SET ANSI_NULLS ON

GO
/****** Object:  StoredProcedure [dbo].[_WatehouseProdoucts]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[_WatehouseProdoucts]
@IdCategoryProduct int,
@Pname nvarchar(50)
,
@WDate datetime,
@Notes nvarchar(150),
@BarCodeText nvarchar(150)
, 
@UsersID int  WITH ENCRYPTION
as

begin
declare @inserted TABLE  (
	[ProdouctsID] [int]  ,
	[IdCategoryProduct] [int]  ,
	[Pname] [nvarchar](50)  ,
	[WDate] [date]  ,
	[Notes] [nvarchar](150)  ,
	[UsersID] [int]  ,
	[BarCodeText] [int]   ); 

INSERT INTO WatehouseProdoucts
                         (IdCategoryProduct,Pname, WDate, Notes,BarCodeText,UsersID)
						 OUTPUT INSERTED.[ProdouctsID],INSERTED.[IdCategoryProduct],INSERTED.[Pname],INSERTED.[WDate],INSERTED.[Notes],INSERTED.[BarCodeText],INSERTED.[UsersID]INTO @inserted
VALUES        (@IdCategoryProduct,@Pname,@WDate,@Notes,@BarCodeText,@UsersID)
declare @ProdouctsID int;



set @ProdouctsID =(select ProdouctsID  from @inserted);
INSERT INTO Warehouse_Quantity_Product
                         (ProductID, QuantityProduct)
VALUES        (@ProdouctsID,0)
end





GO
/****** Object:  StoredProcedure [dbo].[_WatehouseUpdateProdoucts]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[_WatehouseUpdateProdoucts]
@ProdouctsID int,
@IdCategoryProduct int,
@Pname nvarchar(50)
,
@WDate datetime,
@Notes nvarchar(150)  WITH ENCRYPTION

as

begin

UPDATE       WatehouseProdoucts
SET             IdCategoryProduct = @IdCategoryProduct,   Pname = @Pname, WDate = @WDate, Notes = @Notes where ProdouctsID =@ProdouctsID 
end





GO
/****** Object:  StoredProcedure [dbo].[DeleteAllProcedures]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  
/****** Object:  StoredProcedure [dbo].[GETRolebaseUSerID]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GETRolebaseUSerID]
@User_ID int  WITH ENCRYPTION
as

select  TBCONTROLS.User_ID,TBCONTROLS.ROLES_ID

from
TBCONTROLS 

where 
TBCONTROLS.User_ID =@User_ID





GO
/****** Object:  StoredProcedure [dbo].[InsertRoles]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertRoles]
@ROLES_NAME nvarchar(10)  WITH ENCRYPTION

as
INSERT INTO TBROLES
                         (ROLES_NAME)
VALUES        (@ROLES_NAME)



GO
/****** Object:  StoredProcedure [dbo].[INSERTSCREEN]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[INSERTSCREEN]
@SCREEN_NAME nvarchar(50),@SCREEN_NameAr nvarchar(50)  WITH ENCRYPTION
as
INSERT INTO TBSCREENS
                         (SCREEN_NAME, SCREEN_NameAr)
VALUES        (@SCREEN_NAME,@SCREEN_NameAr)



GO
/****** Object:  StoredProcedure [dbo].[InsertUSers]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[InsertUSers]
@USER_NAME nvarchar(50),@USER_PASSWORD nvarchar(50)  WITH ENCRYPTION
as
INSERT INTO TBUSERS
                         (USER_NAME, USER_PASSWORD)
VALUES        (@USER_NAME,@USER_PASSWORD)



GO
/****** Object:  StoredProcedure [dbo].[sds]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 --"SELECT TOP " + this.mintPageSize +
 --               " * FROM tblEmp WHERE E_Id NOT IN " +
 --               "(SELECT TOP " + intSkip + " E_Id FROM tblEmp)"
 CREATE proc [dbo].[sds]
 @c int , 
 @intSkip int  WITH ENCRYPTION
 as
SELECT    top  (@c) Warehouse_Master_Store.StoreId,Warehouse_Master_Store.StoreId,Warehouse_Store.MStoreId,Warehouse_Store.StoreId,Warehouse_Store.SuppliersId,Warehouse_Suppliers.SuppliersID,Warehouse_Suppliers.SName    
FROM       Warehouse_Store  ,   Warehouse_Master_Store  ,Warehouse_Suppliers

where Warehouse_Master_Store.StoreId =Warehouse_Store.MStoreId
and Warehouse_Store.SuppliersId=Warehouse_Suppliers.SuppliersID 
SELECT TOP   (@intSkip)   Warehouse_Master_Store.StoreId FROM Warehouse_Master_Store
                             


GO
/****** Object:  StoredProcedure [dbo].[SelectAllQutaly]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[SelectAllQutaly]
 WITH ENCRYPTION
as
begin
SELECT        Warehouse_Qutaly.*
FROM            Warehouse_Qutaly

end





GO
/****** Object:  StoredProcedure [dbo].[SelectAllQutalyAR]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[SelectAllQutalyAR]
 WITH ENCRYPTION
as
begin
 
SELECT        QutalyID as[رقم المصروف] ,Amount as[المبلغ], WDate as[التاريخ], Notes as[ملاحظات]
FROM            Warehouse_Qutaly


end





GO
/****** Object:  StoredProcedure [dbo].[SelectRolesIDForMenustrip]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectRolesIDForMenustrip]
@ROLES_ID int  WITH ENCRYPTION
as

select   TBCONTROLS.ROLES_ID
,
TBROLES.ROLES_ID,TBROLES.ROLES_NAME
from

TBCONTROLS ,TBROLES

where 

TBROLES.ROLES_ID =TBCONTROLS.ROLES_ID

and

TBCONTROLS.ROLES_ID =@ROLES_ID



GO
/****** Object:  StoredProcedure [dbo].[SelectScreen]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SelectScreen]
 WITH ENCRYPTION
as
SELECT        SCREEN_NAME, SCREEN_NameAr, SCREEN_ID
FROM            TBSCREENS



GO
/****** Object:  StoredProcedure [dbo].[sp]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp]
 
as
begin
select * from WarehouseCustomers
end


GO
/****** Object:  StoredProcedure [dbo].[sp2]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp2]
 WITH ENCRYPTION
as
begin
select * from WarehouseCustomers
end


GO
/****** Object:  StoredProcedure [dbo].[spGetBCONTROLSAll]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetBCONTROLSAll]
 WITH ENCRYPTION
AS
BEGIN
SELECT *
FROM
TBCONTROLS
END




GO
/****** Object:  StoredProcedure [dbo].[spGetBROLESAll]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetBROLESAll]
 WITH ENCRYPTION
AS
BEGIN
SELECT *
FROM
TBROLES
END




GO
/****** Object:  StoredProcedure [dbo].[spGetBUSERSAll]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetBUSERSAll]
 WITH ENCRYPTION
AS
BEGIN
SELECT *
FROM
TBUSERS
END




GO
/****** Object:  StoredProcedure [dbo].[spInsertBCONTROLS]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertBCONTROLS]

--@ID int,
@ROLES_ID int,
@User_ID int  WITH ENCRYPTION
AS
BEGIN
INSERT INTO
TBCONTROLS(
--ID,
--SCREEN_ID,
 
 
ROLES_ID,
User_ID
)
VALUES (
--@ID,
--@SCREEN_ID,
 
@ROLES_ID,
@User_ID
)
END



GO
/****** Object:  StoredProcedure [dbo].[spInsertBROLES]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertBROLES]
@ROLES_ID int,
@ROLES_NAME nvarchar(20)  WITH ENCRYPTION
AS
BEGIN
INSERT INTO
TBROLES(
ROLES_ID,
ROLES_NAME
)
VALUES (
@ROLES_ID,
@ROLES_NAME
)
END




GO
/****** Object:  StoredProcedure [dbo].[spInsertBUSERS]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertBUSERS]
@User_ID int,
@USER_NAME nvarchar(15),
@USER_PASSWORD nvarchar(max),
@USER_LASTLOGIN date,
@LOCKACCOUNT bit  WITH ENCRYPTION
AS
BEGIN
INSERT INTO
TBUSERS(
User_ID,
USER_NAME,
USER_PASSWORD,
USER_LASTLOGIN,
LOCKACCOUNT
)
VALUES (
@User_ID,
@USER_NAME,
@USER_PASSWORD,
@USER_LASTLOGIN,
@LOCKACCOUNT
)
END




GO
/****** Object:  StoredProcedure [dbo].[spUpdateBROLES]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateBROLES]
 
@ROLES_ID int,
@ROLES_NAME nvarchar(20)  WITH ENCRYPTION
AS
BEGIN
UPDATE
TBROLES
SET
 
ROLES_NAME = @ROLES_NAME
WHERE
ROLES_ID = @ROLES_ID
END




GO
/****** Object:  StoredProcedure [dbo].[spUpdateBUSERS]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateBUSERS]
 
@User_ID int,
@USER_NAME nvarchar(15),
@USER_PASSWORD nvarchar(max),
@USER_LASTLOGIN date,
@LOCKACCOUNT bit  WITH ENCRYPTION
AS
BEGIN
UPDATE
TBUSERS
SET
 
USER_NAME = @USER_NAME,
USER_PASSWORD = @USER_PASSWORD,
USER_LASTLOGIN = @USER_LASTLOGIN,
LOCKACCOUNT = @LOCKACCOUNT
WHERE
 User_ID = @User_ID
END



GO
/****** Object:  StoredProcedure [dbo].[testLOOoops]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
 
/****** Object:  StoredProcedure [dbo].[UpdateUSersPassword]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--use[Warehouse]
create proc [dbo].[UpdateUSersPassword]
@User_ID int 
,
@USER_PASSWORD Nvarchar(MAX)  WITH ENCRYPTION
as
begin
UPDATE       TBUSERS
SET                USER_PASSWORD = @USER_PASSWORD where TBUSERS.[User_ID]=@User_ID
end


GO
/****** Object:  StoredProcedure [dbo].[Warehouse_AllPrdouctsnocat]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Warehouse_AllPrdouctsnocat]
  
  WITH ENCRYPTION
as
begin
  
 SELECT        WatehouseProdoucts.*
FROM            WatehouseProdoucts
  
end



GO
/****** Object:  StoredProcedure [dbo].[Warehouse_CalcGainloss]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Warehouse_CalcGainloss]
@StartDate date,
@EndDate date WITH ENCRYPTION

as
begin
SELECT   Warehouse_Store.TotalPrice,
  sum(Warehouse_Store.TotalPrice) over() as TotalPriceBill  
  ,
     --Warehouse_BillMaster.BillMId ,
Warehouse_Master_Store.WDate
--Warehouse_Store.BillMId

FROM  
           Warehouse_Store, Warehouse_Master_Store 
		   
		   where Warehouse_Master_Store.WDate    between @StartDate and @EndDate  
		   and
		   Warehouse_Master_Store.StoreId =Warehouse_Store.MStoreId
		  Group by   Warehouse_Master_Store.WDate ,Warehouse_Store.TotalPrice

end
begin
----------------------------Start Warehouse_Qutaly----------------------------

select 
sum(Warehouse_Qutaly.Amount) over() as TotalQutaly  
,
Warehouse_Qutaly.QutalyID 

from Warehouse_Qutaly

where Warehouse_Qutaly.WDate  between @StartDate and @EndDate  
		  Group by  
		  Warehouse_Qutaly.Amount,Warehouse_Qutaly.QutalyID


		  end
----------------------------End Warehouse_Qutaly----------------------------

----------------------------start Employee----------------------------
begin

select    Warehouse_Employee.WDate,

sum(Warehouse_Employee.Salary) over() as TotalSalary 

from Warehouse_Employee

--where Warehouse_Employee.WDate between @StartDate and @EndDate

Group by Warehouse_Employee.WDate,Warehouse_Employee.Salary

----------------------------End Employee----------------------------
end

begin
select Warehouse_Master_Store.StoreId ,Warehouse_Master_Store.WDate ,Warehouse_Store.StoreId,
sum(Warehouse_Store.TotalPrice  
) over() as  TotalStore

from  Warehouse_Master_Store,Warehouse_Store

 where Warehouse_Master_Store.WDate between @StartDate and @EndDate 

 Group by Warehouse_Master_Store.StoreId ,Warehouse_Master_Store.WDate ,Warehouse_Store.StoreId,Warehouse_Store.TotalPrice  
 end
----------------------------End Warehouse_Store----------------------------




GO
/****** Object:  StoredProcedure [dbo].[Warehouse_CalcGainlossEmployee]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create proc [dbo].[Warehouse_CalcGainlossEmployee]
@StartDate date ,@EndDate  date  WITH ENCRYPTION
as
begin

select    Warehouse_Employee.WDate,

sum(Warehouse_Employee.Salary) over() as TotalSalary 

from Warehouse_Employee

--where Warehouse_Employee.WDate between @StartDate and @EndDate

Group by Warehouse_Employee.WDate,Warehouse_Employee.Salary

----------------------------End Employee----------------------------
end




GO
/****** Object:  StoredProcedure [dbo].[Warehouse_CalcGainlossQutaly]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create proc [dbo].[Warehouse_CalcGainlossQutaly]
@StartDate date ,@EndDate  date  WITH ENCRYPTION
as
begin
----------------------------Start Warehouse_Qutaly----------------------------

select 
sum(Warehouse_Qutaly.Amount) over() as TotalQutaly  
,
Warehouse_Qutaly.QutalyID 

from Warehouse_Qutaly

where Warehouse_Qutaly.WDate  between @StartDate and @EndDate  
		  Group by  
		  
		  Warehouse_Qutaly.Amount,Warehouse_Qutaly.QutalyID


		  end




GO
/****** Object:  StoredProcedure [dbo].[Warehouse_CalcGainlossStore]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[Warehouse_CalcGainlossStore]
@StartDate date ,@EndDate  date WITH ENCRYPTION 
as
begin
----------------------------Start Warehouse_Master_Store----------------------------
  

select Warehouse_Master_Store.StoreId ,Warehouse_Master_Store.WDate ,Warehouse_Store.StoreId,Warehouse_Store.MStoreId,
sum(Warehouse_Store.TotalPrice  
) over() as  TotalStore

from  Warehouse_Master_Store,Warehouse_Store

 where Warehouse_Master_Store.WDate between @StartDate and @EndDate 
 and
 Warehouse_Store.MStoreId = Warehouse_Master_Store.StoreId
 Group by Warehouse_Master_Store.StoreId ,Warehouse_Master_Store.WDate ,Warehouse_Store.StoreId,Warehouse_Store.TotalPrice  
,Warehouse_Store.MStoreId
		  end




GO
/****** Object:  StoredProcedure [dbo].[Warehouse_Category_Product]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Warehouse_Category_Product]

@CategoryName nvarchar(15),
@WDate date,
@UsersID int  WITH ENCRYPTION
as


begin

INSERT INTO Warehouse_CategoryProduct
                         (CategoryName, WDate,[UsersID])
VALUES        (@CategoryName,@WDate,@UsersID)


end



GO
/****** Object:  StoredProcedure [dbo].[Warehouse_CategoryProductByid]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[Warehouse_CategoryProductByid]
@IdCategoryProduct int  
WITH ENCRYPTION
as
begin
SELECT      *  
FROM            Warehouse_CategoryProduct where IdCategoryProduct =@IdCategoryProduct

end



GO
/****** Object:  StoredProcedure [dbo].[Warehouse_DELETEBillFromStore]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Warehouse_DELETEBillFromStore]
@StoreId int  WITH ENCRYPTION
as
begin
DELETE FROM Warehouse_Store

where
Warehouse_Store.StoreId=@StoreId 

end



GO
/****** Object:  StoredProcedure [dbo].[Warehouse_delSuppliers]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[Warehouse_delSuppliers]
@SuppliersID int  WITH ENCRYPTION
 
as
Begin

DELETE FROM Warehouse_Suppliers where SuppliersID=@SuppliersID

  end





GO
/****** Object:  StoredProcedure [dbo].[Warehouse_SelectALLadmin]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Warehouse_SelectALLadmin]
 WITH ENCRYPTION
as
begin

SELECT        U_Username, UsersID
FROM            Administartion

end



GO
/****** Object:  StoredProcedure [dbo].[Warehouse_SortProductByMaxPrice]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Warehouse_SortProductByMaxPrice]
@ProdouctsID int  
WITH ENCRYPTION
as
begin
SELECT        WatehouseProdoucts.ProdouctsID, WatehouseProdoucts.Pname,  Warehouse_Store.PurchasingPrice
FROM            WatehouseProdoucts INNER JOIN
                         Warehouse_Store ON WatehouseProdoucts.ProdouctsID = Warehouse_Store.ProdouctsID
						 where WatehouseProdoucts.ProdouctsID=@ProdouctsID

						 order by Warehouse_Store.PurchasingPrice     desc
						 end





GO
/****** Object:  StoredProcedure [dbo].[Warehouse_UpdateCategory_Product]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Warehouse_UpdateCategory_Product]
@IdCategoryProduct int,
@CategoryName nvarchar(15)WITH ENCRYPTION
--,
--@WDate date  
as


begin
UPDATE       Warehouse_CategoryProduct
SET                CategoryName = @CategoryName  where IdCategoryProduct = @IdCategoryProduct

end



GO
/****** Object:  StoredProcedure [dbo].[Warehouse_UpdatePasswordAdmin]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Warehouse_UpdatePasswordAdmin]
@UsersID int,
 
@U_Password nvarchar(20)  WITH ENCRYPTION
as

begin

UPDATE       Administartion

SET                 U_Password =@U_Password
where UsersID =@UsersID

end



GO
/****** Object:  StoredProcedure [dbo].[Warehouse_UpdatePermissions]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

CREATE proc [dbo].[Warehouse_UpdatePermissions]
@CustomersDel bit ,
@EmployeesDel bit ,
@SuppliersDel bit,
@SupplyRepresentativeDel bit,
@PrdouctsDel bit,
@StoreDel bit,
@BillDel bit,
@U_Username nvarchar(10),
@Main_Data bit,
@Managment bit,
@CustomersEdit bit,
@EmployeesEdit bit,
@SuppliersEdit bit,
@SupplyRepresentativeEdit bit,
@PrdouctsEdit bit,
@StoreEdit bit,
@BillEdit bit,
@Main_Data1 bit,
@Managment1 bit,
@Reports bit  WITH ENCRYPTION


as


UPDATE       Permissions
SET                CustomersDel = @CustomersDel, EmployeesDel = @EmployeesDel, SuppliersDel = @SuppliersDel, SupplyRepresentativeDel = @SupplyRepresentativeDel, PrdouctsDel = @PrdouctsDel, StoreDel = @StoreDel, 
                         BillDel = @BillDel, U_Username = @U_Username, Main_Data = @Main_Data, Managment = @Managment, CustomersEdit = @CustomersEdit, EmployeesEdit = @EmployeesEdit, SuppliersEdit = @SuppliersEdit, 
                         SupplyRepresentativeEdit = @SupplyRepresentativeEdit, PrdouctsEdit = @PrdouctsEdit, StoreEdit = @StoreEdit, BillEdit = @BillEdit, Main_Data1 = @Main_Data1, Managment1 = @Managment1 , Reports =@Reports where  U_Username=@U_Username



GO
/****** Object:  StoredProcedure [dbo].[Warehouse_UpdateSuppliers]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[Warehouse_UpdateSuppliers]
@SuppliersID int,
@SName nvarchar(50),
@Phone int,
@Address nvarchar(50),
@WDate datetime,
@Notes nvarchar(50)  WITH ENCRYPTION

as
Begin


UPDATE       Warehouse_Suppliers
SET                SName = @SName, Phone = @Phone, [Address] = @Address, WDate = @WDate, Notes = @Notes  where SuppliersID = @SuppliersID
 end





GO
/****** Object:  StoredProcedure [dbo].[WarehouseHightPurchasingPrice]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc  [dbo].[WarehouseHightPurchasingPrice] 
@ProdouctsID int  WITH ENCRYPTION
as

begin
SELECT   Warehouse_CategoryProduct.IdCategoryProduct,WatehouseProdoucts.ProdouctsID,WatehouseProdoucts.Pname,Warehouse_Store.Billno,Warehouse_Store. PurchasingPrice,Warehouse_Store.SellingPrice

     
FROM            Warehouse_CategoryProduct ,WatehouseProdoucts,Warehouse_Store


where WatehouseProdoucts.ProdouctsID = Warehouse_Store.ProdouctsID

and

Warehouse_CategoryProduct.IdCategoryProduct = WatehouseProdoucts.ProdouctsID

and

WatehouseProdoucts.ProdouctsID =@ProdouctsID

 order by Warehouse_Store.PurchasingPrice desc 
 end



GO
/****** Object:  StoredProcedure [dbo].[WarehouseinvoiceNOStore]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc  [dbo].[WarehouseinvoiceNOStore]
@BillNO int  WITH ENCRYPTION
as
begin
SELECT        Warehouse_Master_Store.WDate as[التاريخ], Warehouse_Store.Billno as[فاتوره المورد], Warehouse_Store.PurchasingPrice as[سعر الشراء],    Warehouse_Store.ExpireDate as[تاريخ الانتهاء], Warehouse_Store.Productiondate as[تاريخ الانتاج], Warehouse_Store.TotalPrice as [السعر],Warehouse_Store.QtStartPeriod as [الكميه الافتتاحيه],
                        Warehouse_SupplyRepresentative.SRName as[المندوب], Warehouse_Suppliers.SName as[المورد],WatehouseProdoucts.ProdouctsID as[رقم المنتج], WatehouseProdoucts.Pname as[المنتج], Warehouse_MainUnites.UName as[الوحده],Warehouse_MainUnites.UnitConvert as[U]
FROM            Warehouse_Store INNER JOIN
                         Warehouse_Master_Store ON Warehouse_Master_Store.StoreId = Warehouse_Store.MStoreId INNER JOIN
                         WatehouseProdoucts ON Warehouse_Store.ProdouctsID = WatehouseProdoucts.ProdouctsID INNER JOIN
                         Warehouse_Suppliers ON Warehouse_Store.SuppliersId = Warehouse_Suppliers.SuppliersID INNER JOIN
                         Warehouse_SupplyRepresentative ON Warehouse_Store.SupplyRepId = Warehouse_SupplyRepresentative.SupplyRepID INNER JOIN
                         Warehouse_MainUnites ON Warehouse_Store.MainUnitesId = Warehouse_MainUnites.UnitesNId 

WHERE        (Warehouse_Store.Billno = @BillNO)
----SELECT        Warehouse_Quantity_Product.ProductID, Warehouse_Quantity_Product.QuantityProduct, Warehouse_Quantity_Product.Wdate, WatehouseProdoucts.ProdouctsID, WatehouseProdoucts.IdCategoryProduct, 
----                         WatehouseProdoucts.Pname, WatehouseProdoucts.WDate AS Expr1
----FROM            Warehouse_Quantity_Product CROSS JOIN
----                         WatehouseProdoucts where WatehouseProdoucts.ProdouctsID=@ProdouctsID
end

Create proc _WarehouseGetIDMainUnits
@UName nvarchar(20) WITH ENCRYPTION

as
SELECT UnitesNId, UName, UnitConvert FROM Warehouse_MainUnites where UName=@UName

GO
/****** Object:  StoredProcedure [dbo].[WarehouseSelectAllProdoucts]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[WarehouseSelectAllProdoucts]
 WITH ENCRYPTION
as
begin
SELECT        ProdouctsID, Pname
FROM            WatehouseProdoucts
end


GO
/****** Object:  StoredProcedure [dbo].[WarehouseSelectALLProdouctsBYIdCategory]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create proc [dbo].[WarehouseSelectALLProdouctsBYIdCategory]
@IdCategoryProduct int  WITH ENCRYPTION
as



begin
SELECT   Warehouse_CategoryProduct.IdCategoryProduct,Warehouse_CategoryProduct.CategoryName, WatehouseProdoucts.IdCategoryProduct,WatehouseProdoucts.ProdouctsID,WatehouseProdoucts.Pname
     
FROM        
Warehouse_CategoryProduct  ,WatehouseProdoucts 
where
Warehouse_CategoryProduct.IdCategoryProduct = WatehouseProdoucts.IdCategoryProduct
and 

Warehouse_CategoryProduct.IdCategoryProduct= @IdCategoryProduct

end



GO
/****** Object:  StoredProcedure [dbo].[WarehouseSelectProdouctsBY_Qt]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[WarehouseSelectProdouctsBY_Qt]

@Billno int  WITH ENCRYPTION
as
begin
SELECT 
WatehouseProdoucts.ProdouctsID,Warehouse_Store.Billno, Warehouse_Store.SellingPrice,WatehouseProdoucts.Pname,  Warehouse_Store.Quntity_Product,SizeProducts FROM 
WatehouseProdoucts , Warehouse_Store ,Warehouse_CategoryProduct 
where 
 Warehouse_Store.Billno = @Billno and  Warehouse_Store.IdCategoryProduct = Warehouse_CategoryProduct.IdCategoryProduct and WatehouseProdoucts.ProdouctsID = Warehouse_Store.ProdouctsID   order by Warehouse_Store.PurchasingPrice desc

 end


GO
/****** Object:  StoredProcedure [dbo].[WarehouseSelectProdouctsBYProductiondate]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[WarehouseSelectProdouctsBYProductiondate]
@ProdouctsID int  WITH ENCRYPTION
as
begin
SELECT Warehouse_CategoryProduct.IdCategoryProduct,
WatehouseProdoucts.ProdouctsID,
WatehouseProdoucts.Pname,
Warehouse_Store.Billno,
Warehouse_Store.Productiondate,
Warehouse_Store.SellingPrice
 FROM Warehouse_CategoryProduct, WatehouseProdoucts, Warehouse_Store 
 where
  Warehouse_Store.ProdouctsID = WatehouseProdoucts.ProdouctsID 
  and
   Warehouse_Store.IdCategoryProduct =Warehouse_CategoryProduct.IdCategoryProduct
    and
	 Warehouse_Store.ProdouctsID =@ProdouctsID  order by 
	 Warehouse_Store.Productiondate desc
	 end


GO
/****** Object:  StoredProcedure [dbo].[Watehouse_Delete_BarCode]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create Proc [dbo].[Watehouse_Delete_BarCode]
@BarCodeID int   WITH ENCRYPTION
 as
begin
DELETE FROM Watehouse_BarCode
WHERE        (BarCodeID = @BarCodeID)end


GO
/****** Object:  StoredProcedure [dbo].[Watehouse_Insert_BarCode]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE Proc [dbo].[Watehouse_Insert_BarCode]
@BarcodeCategory_Product int,
 @BarCodeProduct int,
  @BarCodeDate Date
  ,
  @BarCodeText int  WITH ENCRYPTION
as
begin
INSERT INTO Watehouse_BarCode
                         (BarcodeCategory_Product, BarCodeProduct, BarCodeDate,BarCodeText)
VALUES        (@BarcodeCategory_Product,@BarCodeProduct,@BarCodeDate,@BarCodeText)

end


GO
/****** Object:  StoredProcedure [dbo].[Watehouse_Select_ALL_BarCode]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create Proc [dbo].[Watehouse_Select_ALL_BarCode]
  WITH ENCRYPTION
as
begin
 SELECT        Watehouse_BarCode.*
FROM            Watehouse_BarCode
end


GO
/****** Object:  StoredProcedure [dbo].[Watehouse_Select_ALL_BYID_BarCode]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create Proc [dbo].[Watehouse_Select_ALL_BYID_BarCode]
 @BarCodeID int  WITH ENCRYPTION
as
begin
 SELECT        Watehouse_BarCode.*
FROM            Watehouse_BarCode where BarCodeID=@BarCodeID
end


GO
/****** Object:  StoredProcedure [dbo].[Watehouse_Update_BarCode]    Script Date: 2/16/2021 11:01:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE Proc [dbo].[Watehouse_Update_BarCode]
@BarCodeID int,
@BarcodeCategory_Product int,
 @BarCodeProduct int,
  @BarCodeDate Date,
  @BarCodeText int  WITH ENCRYPTION

as
begin
UPDATE       Watehouse_BarCode
SET                BarcodeCategory_Product = @BarcodeCategory_Product, BarCodeProduct = @BarCodeProduct, BarCodeDate = @BarCodeDate,BarCodeText=@BarCodeText where Watehouse_BarCode.BarCodeID=@BarCodeID
end


GO
 alter proc  [dbo].[WarehouseinvoiceNOStore]
@BillNO int WITH ENCRYPTION
as
begin
SELECT        Warehouse_Master_Store.WDate as[التاريخ], Warehouse_Store.Billno as[فاتوره المورد], Warehouse_Store.PurchasingPrice as[سعر الشراء],    Warehouse_Store.ExpireDate as[تاريخ الانتهاء], Warehouse_Store.Productiondate as[تاريخ الانتاج], Warehouse_Store.TotalPrice as [السعر],Warehouse_Store.QtStartPeriod as [الكميه الافتتاحيه],
                        Warehouse_SupplyRepresentative.SRName as[المندوب], Warehouse_Suppliers.SName as[المورد],WatehouseProdoucts.ProdouctsID as[رقم المنتج], WatehouseProdoucts.Pname as[المنتج], Warehouse_MainUnites.UName as[الوحده],Warehouse_MainUnites.UnitConvert as[U]
FROM            Warehouse_Store INNER JOIN
                         Warehouse_Master_Store ON Warehouse_Master_Store.StoreId = Warehouse_Store.MStoreId INNER JOIN
                         WatehouseProdoucts ON Warehouse_Store.ProdouctsID = WatehouseProdoucts.ProdouctsID INNER JOIN
                         Warehouse_Suppliers ON Warehouse_Store.SuppliersId = Warehouse_Suppliers.SuppliersID INNER JOIN
                         Warehouse_SupplyRepresentative ON Warehouse_Store.SupplyRepId = Warehouse_SupplyRepresentative.SupplyRepID INNER JOIN
                         Warehouse_MainUnites ON Warehouse_Store.MainUnitesId = Warehouse_MainUnites.UnitesNId 

WHERE        (Warehouse_Store.Billno = @BillNO)
----SELECT        Warehouse_Quantity_Product.ProductID, Warehouse_Quantity_Product.QuantityProduct, Warehouse_Quantity_Product.Wdate, WatehouseProdoucts.ProdouctsID, WatehouseProdoucts.IdCategoryProduct, 
----                         WatehouseProdoucts.Pname, WatehouseProdoucts.WDate AS Expr1
----FROM            Warehouse_Quantity_Product CROSS JOIN
----                         WatehouseProdoucts where WatehouseProdoucts.ProdouctsID=@ProdouctsID
end

GO

create proc [dbo].[_Warehosue_Select_ALL_ReturnProducts]
 
@PageOffset int,
@MaxRecords int  WITH ENCRYPTION
as
begin
SELECT        Warehouse_ReturnProducts.Id    as[#]
,
Warehouse_ReturnProducts.BillNo as [فاتورة التاجر],
WatehouseProdoucts.Pname as [المنتج],
Warehouse_ReturnProducts._datetime as [التاريخ], 
Warehouse_ReturnProducts.QtStartPeriod as[ الكميه المشتراه],
Warehouse_ReturnProducts.QTReturn as[الكميه المرتجعه]
--,
--Warehouse_Master_Store.WDate as[تاريخ الشراء]
  
FROM            Warehouse_ReturnProducts ,WatehouseProdoucts
where WatehouseProdoucts.ProdouctsID= Warehouse_ReturnProducts.ProdouctsID
                   
		 ORDER BY Warehouse_ReturnProducts.Id OFFSET @PageOffset 
ROWS FETCH NEXT @MaxRecords 
ROWS ONLY


end


GO

create proc    Warehouse_ReturnProducts_
@BillNo int,
@QtStartPeriod decimal,
@QTReturn decimal,
@UserID int
as
begin
INSERT INTO Warehouse_ReturnProducts
                         (BillNo, QtStartPeriod, QTReturn, UserID)
VALUES        (@BillNo,@QtStartPeriod,@QTReturn,@UserID)

end
GO
